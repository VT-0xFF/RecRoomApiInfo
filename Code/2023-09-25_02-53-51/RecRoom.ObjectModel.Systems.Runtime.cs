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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x22740C0", Offset = "0x22734C0", VA = "0x1822740C0")]
		public static FGANGKDGHOI<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(FGANGKDGHOI<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct AGEGNOOMMAM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JNKGEHLNOAI]
public static class MGCKCPADAKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E358F0", Offset = "0x5E34CF0", VA = "0x185E358F0")]
	static MGCKCPADAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x247CFD0", Offset = "0x247C3D0", VA = "0x18247CFD0")]
	public static void KJKAJKCKHNK<T>(T KECAMMIJJDM, T PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E357E0", Offset = "0x5E34BE0", VA = "0x185E357E0")]
	public static void KJKAJKCKHNK(FixedString32Bytes KECAMMIJJDM, string PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E35870", Offset = "0x5E34C70", VA = "0x185E35870")]
	public static void KJKAJKCKHNK(string KECAMMIJJDM, FixedString32Bytes PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E35700", Offset = "0x5E34B00", VA = "0x185E35700")]
	public static void KJKAJKCKHNK(FixedString64Bytes KECAMMIJJDM, string PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E35670", Offset = "0x5E34A70", VA = "0x185E35670")]
	public static void KJKAJKCKHNK(string KECAMMIJJDM, FixedString64Bytes PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E35840", Offset = "0x5E34C40", VA = "0x185E35840")]
	public static void KJKAJKCKHNK(LEKCIPKLACF KECAMMIJJDM, Vector3 PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D68FE0", Offset = "0x5D683E0", VA = "0x185D68FE0")]
	public static void KJKAJKCKHNK(Vector3 KECAMMIJJDM, LEKCIPKLACF PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E35730", Offset = "0x5E34B30", VA = "0x185E35730")]
	public static void KJKAJKCKHNK(MNKHGAODJMG KECAMMIJJDM, Vector4 PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A340", Offset = "0x5D69740", VA = "0x185D6A340")]
	public static void KJKAJKCKHNK(Vector4 KECAMMIJJDM, MNKHGAODJMG PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E35730", Offset = "0x5E34B30", VA = "0x185E35730")]
	public static void KJKAJKCKHNK(MNKHGAODJMG KECAMMIJJDM, Quaternion PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A340", Offset = "0x5D69740", VA = "0x185D6A340")]
	public static void KJKAJKCKHNK(Quaternion KECAMMIJJDM, MNKHGAODJMG PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5E35810", Offset = "0x5E34C10", VA = "0x185E35810")]
	public static void KJKAJKCKHNK(LEKCIPKLACF KECAMMIJJDM, float3 PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D68FE0", Offset = "0x5D683E0", VA = "0x185D68FE0")]
	public static void KJKAJKCKHNK(float3 KECAMMIJJDM, LEKCIPKLACF PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E35760", Offset = "0x5E34B60", VA = "0x185E35760")]
	public static void KJKAJKCKHNK(MNKHGAODJMG KECAMMIJJDM, float4 PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A340", Offset = "0x5D69740", VA = "0x185D6A340")]
	public static void KJKAJKCKHNK(float4 KECAMMIJJDM, MNKHGAODJMG PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E35760", Offset = "0x5E34B60", VA = "0x185E35760")]
	public static void KJKAJKCKHNK(MNKHGAODJMG KECAMMIJJDM, quaternion PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E35780", Offset = "0x5E34B80", VA = "0x185E35780")]
	public static void KJKAJKCKHNK(quaternion KECAMMIJJDM, MNKHGAODJMG PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E358B0", Offset = "0x5E34CB0", VA = "0x185E358B0")]
	public static void KJKAJKCKHNK(Entity KECAMMIJJDM, PHOHBGHIDBC PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E356D0", Offset = "0x5E34AD0", VA = "0x185E356D0")]
	public static void KJKAJKCKHNK(PHOHBGHIDBC KECAMMIJJDM, Entity PFDAOEPJLFE, ILNADNNCEJM JHHKBGNPJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class DOFEAHAAFKI : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E900", Offset = "0x5E1DD00", VA = "0x185E1E900", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E9B0", Offset = "0x5E1DDB0", VA = "0x185E1E9B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public DOFEAHAAFKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AGNACEIDMIN(DPJKEJCGJEB.OMRoom)]
internal class CCJDAEIAKAI : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KEMPNLKAPFH ILIGNJLONBF;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C4F0", Offset = "0x5E1B8F0", VA = "0x185E1C4F0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C540", Offset = "0x5E1B940", VA = "0x185E1C540", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CCJDAEIAKAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[UnityEngine.Scripting.Preserve]
internal class GJDCEABDLCD : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EntityQuery NKBIPPNKNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E26B30", Offset = "0x5E25F30", VA = "0x185E26B30", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E26B80", Offset = "0x5E25F80", VA = "0x185E26B80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E26C10", Offset = "0x5E26010", VA = "0x185E26C10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public GJDCEABDLCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AGNACEIDMIN(DPJKEJCGJEB.OMRoom)]
internal class CPHFKFLGNMF : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KEMPNLKAPFH ILIGNJLONBF;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CD40", Offset = "0x5E1C140", VA = "0x185E1CD40", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CD90", Offset = "0x5E1C190", VA = "0x185E1CD90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CPHFKFLGNMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AGNACEIDMIN(DPJKEJCGJEB.OMRoom)]
internal class CMPNGAGCCEI : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private BNKPHKHKLHD KMCCKENJIHJ;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C6F0", Offset = "0x5E1BAF0", VA = "0x185E1C6F0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C740", Offset = "0x5E1BB40", VA = "0x185E1C740", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CMPNGAGCCEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[UnityEngine.Scripting.Preserve]
internal sealed class PJECNBLJJJK<T> : FILNMLJOIDH where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FB70", Offset = "0x3E4EF70", VA = "0x183E4FB70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FCE0", Offset = "0x3E4F0E0", VA = "0x183E4FCE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public PJECNBLJJJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[BAHPFKKFPEH]
public class MDLBDPCGADD : ComponentSystem, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private FIMDMOFKGJF AGOENIEKEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x767760", Offset = "0x766B60", VA = "0x180767760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x767710", Offset = "0x766B10", VA = "0x180767710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E35600", Offset = "0x5E34A00", VA = "0x185E35600", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
	public MDLBDPCGADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class FBKGJCBOJCM : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E24D90", Offset = "0x5E24190", VA = "0x185E24D90", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E24F90", Offset = "0x5E24390", VA = "0x185E24F90")]
	[UnityEngine.Scripting.Preserve]
	private void MMHNBPJHHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public FBKGJCBOJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class ENIJCCMAIEL : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E23A80", Offset = "0x5E22E80", VA = "0x185E23A80", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public ENIJCCMAIEL()
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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AC80", Offset = "0x5E3A080", VA = "0x185E3AC80")]
		public static ObjectModelConfigAsset FIMHDKGHCMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x835CD0", Offset = "0x8350D0", VA = "0x180835CD0")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JFNCLGIKILO
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E30F00", Offset = "0x5E30300", VA = "0x185E30F00")]
	public static void KMAGGMOJDAB(FJOGIBEAJHF AABDFOONPNL, string CLEPEBHHLEB, CAKFEHOBCAO BCKPEHNNCPM, Action MLOAGIOGKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E30CC0", Offset = "0x5E300C0", VA = "0x185E30CC0")]
	public static void KMAGGMOJDAB(FJOGIBEAJHF AABDFOONPNL, string CLEPEBHHLEB, KLCLLLJMBOO ANFKEJHECIE, Action MLOAGIOGKED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HNLGLFOBLEK
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ONFEDJFHBAF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class NEHMKLBPLMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly FJOGIBEAJHF AABDFOONPNL;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5E37880", Offset = "0x5E36C80", VA = "0x185E37880")]
		public static IKAJAHLJFMC NMNDJFNLLFC(int EEJBIJAEEPN, KLDHNDGGMFO PLBKMELAPOA)
		{
			return default(IKAJAHLJFMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5E37CB0", Offset = "0x5E370B0", VA = "0x185E37CB0")]
		private static CAKFEHOBCAO ONPCCCHDPEJ(KLDHNDGGMFO CDHOAFNDCKL, CAKFEHOBCAO CFPIINMMECG)
		{
			return default(CAKFEHOBCAO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E376D0", Offset = "0x5E36AD0", VA = "0x185E376D0")]
		private static void EMHFIHDOGPP(CAKFEHOBCAO NPIADPAJCCE, CAKFEHOBCAO DLCALNHMKIC, IKAJAHLJFMC MIPKLHDFLBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E373D0", Offset = "0x5E367D0", VA = "0x185E373D0")]
		public static int ADECLDNMDDI(GameObject GHAOKLKOOCA, EINHHNIDDEG EGPBMJCBMOJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static JMIBEAJAMBD IJMBJKNCIIG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static LMFELGCOCBG AKMKBNFOGOJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static LMFELGCOCBG OJOECFJLMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5E39AF0", Offset = "0x5E38EF0", VA = "0x185E39AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool BGHGBMKGMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E39C90", Offset = "0x5E39090", VA = "0x185E39C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FIMDMOFKGJF AGOENIEKEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A5C0", Offset = "0x5E399C0", VA = "0x185E3A5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5E39870", Offset = "0x5E38C70", VA = "0x185E39870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static NCBLCPIDIEA CPCCPCBLEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A920", Offset = "0x5E39D20", VA = "0x185E3A920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E39C20", Offset = "0x5E39020", VA = "0x185E39C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static GMEBHOOMEDK EFBMJCLPBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A860", Offset = "0x5E39C60", VA = "0x185E3A860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static IBNLNIKJFKJ IEECJPHCDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A990", Offset = "0x5E39D90", VA = "0x185E3A990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool LDAOAEAIIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E39E00", Offset = "0x5E39200", VA = "0x185E39E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool EHJKONCEDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A380", Offset = "0x5E39780", VA = "0x185E3A380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static BAJJJAGOPJE NGAMFNGJMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A790", Offset = "0x5E39B90", VA = "0x185E3A790")]
		get
		{
			return default(BAJJJAGOPJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool PJEOAADAKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A3D0", Offset = "0x5E397D0", VA = "0x185E3A3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static byte HPLNMLEDBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AA00", Offset = "0x5E39E00", VA = "0x185E3AA00")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static byte BMPLEMGJDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool LNOEJBOHGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5E39FC0", Offset = "0x5E393C0", VA = "0x185E39FC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool CBBCLAOPPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A8D0", Offset = "0x5E39CD0", VA = "0x185E3A8D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E39E70", Offset = "0x5E39270", VA = "0x185E39E70")]
	public static void GKJBJGDGLMM(JMIBEAJAMBD LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A640", Offset = "0x5E39A40", VA = "0x185E3A640")]
	public static CAKFEHOBCAO MBBJHIFDBPF(GameObject GHAOKLKOOCA)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E398E0", Offset = "0x5E38CE0", VA = "0x185E398E0")]
	public static BAJJJAGOPJE BKLGKCDNGDA(IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E399A0", Offset = "0x5E38DA0", VA = "0x185E399A0")]
	public static bool CGAJJGIDPGH(GameObject GHAOKLKOOCA, [Out] IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A240", Offset = "0x5E39640", VA = "0x185E3A240")]
	public static EEKDDPBIMAP JJJKAMEDMMF(IEnumerable<OPBDJAPIKJM> AHCDBFBGANG)
	{
		return default(EEKDDPBIMAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A150", Offset = "0x5E39550", VA = "0x185E3A150")]
	private static LMFELGCOCBG JJDFHPBOAMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A010", Offset = "0x5E39410", VA = "0x185E3A010")]
	private static bool IKLFFLMHPOE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DBIAONDNBOC
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CDC0", Offset = "0x5E1C1C0", VA = "0x185E1CDC0")]
	public static bool FHGKKIFDIGF(CGNNELOIABF EFIBPNFKBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D0B0", Offset = "0x5E1C4B0", VA = "0x185E1D0B0")]
	public static CGNNELOIABF GFCMFFOEFBO(GameObject GHAOKLKOOCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CED0", Offset = "0x5E1C2D0", VA = "0x185E1CED0")]
	public static CGNNELOIABF GFCMFFOEFBO(GameObject GHAOKLKOOCA, IKAJAHLJFMC MIPKLHDFLBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D2F0", Offset = "0x5E1C6F0", VA = "0x185E1D2F0")]
	public static bool HMFLFDFPLAA(GameObject DHIHKCPMIMH, string CMKNABKHAEG, bool GKJJEPLNKMK)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DisembodiedObjectView : MonoBehaviour, MAIPDEKHDOP
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JMGKFCEFHMB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public CAKFEHOBCAO DBJNLKBFEIC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xBF5C20", Offset = "0xBF5020", VA = "0x180BF5C20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(CAKFEHOBCAO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xBF5C00", Offset = "0xBF5000", VA = "0x180BF5C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E222F0", Offset = "0x5E216F0", VA = "0x185E222F0")]
		public void SetName(string DKFEAPHKBMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, CGNNELOIABF, MAIPDEKHDOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly FJOGIBEAJHF AABDFOONPNL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private const string ODAKFBEEEDM = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private OANLLCBMGJL CGABFKIJBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CAKFEHOBCAO PCOAABDKEED;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public CAKFEHOBCAO DBJNLKBFEIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5E24B30", Offset = "0x5E23F30", VA = "0x185E24B30", Slot = "15")]
			get
			{
				return default(CAKFEHOBCAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BAJJJAGOPJE KNMGHOCIPIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5E24BF0", Offset = "0x5E23FF0", VA = "0x185E24BF0", Slot = "6")]
			get
			{
				return default(BAJJJAGOPJE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool JMGKFCEFHMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5E24B20", Offset = "0x5E23F20", VA = "0x185E24B20", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public OANLLCBMGJL JOIAGLGDJGM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x855B80", Offset = "0x854F80", VA = "0x180855B80", Slot = "7")]
			get
			{
				return default(OANLLCBMGJL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private CPBLFKHDDGN NKHNPFLPACC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5E23F80", Offset = "0x5E23380", VA = "0x185E23F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool PNEMGIOOKAD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7E06E0", Offset = "0x7DFAE0", VA = "0x1807E06E0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8520D0", Offset = "0x8514D0", VA = "0x1808520D0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> DPFLCNDBHEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5E249C0", Offset = "0x5E23DC0", VA = "0x185E249C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5E24C30", Offset = "0x5E24030", VA = "0x185E24C30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<CGNNELOIABF> MODKIIHHLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5E24A70", Offset = "0x5E23E70", VA = "0x185E24A70", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5E24CE0", Offset = "0x5E240E0", VA = "0x185E24CE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E24010", Offset = "0x5E23410", VA = "0x185E24010")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E247B0", Offset = "0x5E23BB0", VA = "0x185E247B0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E24380", Offset = "0x5E23780", VA = "0x185E24380", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E24770", Offset = "0x5E23B70", VA = "0x185E24770", Slot = "10")]
		public void OnEmbody(HONAKLLNIOE KMPNHHILNIL, CAKFEHOBCAO PCOAABDKEED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E247A0", Offset = "0x5E23BA0", VA = "0x185E247A0", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E24620", Offset = "0x5E23A20", VA = "0x185E24620", Slot = "12")]
		public void OnDisembody(bool IHNGGFIGPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E24210", Offset = "0x5E23610", VA = "0x185E24210")]
		private void KFCKOAFCIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E24340", Offset = "0x5E23740", VA = "0x185E24340", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA0AD90", Offset = "0xA0A190", VA = "0x180A0AD90", Slot = "9")]
		private GameObject NALAHGOKKME()
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
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleComponent]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override HNGHCMBBKEB PKHPDJBKOCM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5E3CA30", Offset = "0x5E3BE30", VA = "0x185E3CA30", Slot = "6")]
			get
			{
				return default(HNGHCMBBKEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3C9E0", Offset = "0x5E3BDE0", VA = "0x185E3C9E0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, MAIPDEKHDOP
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly FJOGIBEAJHF AABDFOONPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private HNGHCMBBKEB prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private CAKFEHOBCAO AJAFIOGCMHP;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual HNGHCMBBKEB PKHPDJBKOCM
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400", Slot = "6")]
			get
			{
				return default(HNGHCMBBKEB);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x76B440", Offset = "0x76A840", VA = "0x18076B440", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public CAKFEHOBCAO DBJNLKBFEIC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA41800", Offset = "0xA40C00", VA = "0x180A41800", Slot = "5")]
			get
			{
				return default(CAKFEHOBCAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool JMGKFCEFHMB
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7E06E0", Offset = "0x7DFAE0", VA = "0x1807E06E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8520D0", Offset = "0x8514D0", VA = "0x1808520D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal Entity EKDNLCACBPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5E3CC90", Offset = "0x5E3C090", VA = "0x185E3CC90")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal CDJJECGMMII LCJLLGELGBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E3CB60", Offset = "0x5E3BF60", VA = "0x185E3CB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal EPEIHHNCIHD FIHFHBBKOKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5E3CC10", Offset = "0x5E3C010", VA = "0x185E3CC10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CB50", Offset = "0x5E3BF50", VA = "0x185E3CB50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CA40", Offset = "0x5E3BE40", VA = "0x185E3CA40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CCA0", Offset = "0x5E3C0A0", VA = "0x185E3CCA0")]
		internal void OMELHDOHHCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CB70", Offset = "0x5E3BF70", VA = "0x185E3CB70")]
		private bool GJPCFCAKEGF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D070", Offset = "0x5E3C470", VA = "0x185E3D070")]
		private void PJDHDAKKBOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CA40", Offset = "0x5E3BE40", VA = "0x185E3CA40")]
		internal void AGCMPNGAPHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CFD0", Offset = "0x5E3C3D0", VA = "0x185E3CFD0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D130", Offset = "0x5E3C530", VA = "0x185E3D130")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FHOIBFDAOOA(typeof(LMFELGCOCBG), new string[] { })]
[AIFOCBABFAO(typeof(EOAILPGBNIC))]
[AIFOCBABFAO(typeof(NBAFOHEBHDH))]
public class LHILGNHFLGE : LMFELGCOCBG, PNLMNOEHBNA, EOAILPGBNIC, IDisposable, NBAFOHEBHDH
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly ProfilerMarker OAKNOGEIIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private JMIBEAJAMBD MHCBJGOCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private CPBLFKHDDGN MCIPOELAAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JPNIIOOOMOP KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OAPOPJMEPNA OGDJALIBICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JMIBEAJAMBD AGOENIEKEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public JPNIIOOOMOP IBEJPPJAKBH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public OAPOPJMEPNA AGOLEMGECKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7B8540", Offset = "0x7B7940", VA = "0x1807B8540", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ENLBFFMNMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5F0", Offset = "0x7EE9F0", VA = "0x1807EF5F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7EF610", Offset = "0x7EEA10", VA = "0x1807EF610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public PKBFGGPEDBK EPEIEKGKMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x937FA0", Offset = "0x9373A0", VA = "0x180937FA0", Slot = "9")]
		get
		{
			return default(PKBFGGPEDBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E35160", Offset = "0x5E34560", VA = "0x185E35160", Slot = "13")]
	private void LAIDINFJFCP(bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E353C0", Offset = "0x5E347C0", VA = "0x185E353C0")]
	public static LHILGNHFLGE PJBIIEEDKDI(JMIBEAJAMBD MHCBJGOCOMD, CEKMILKKGMN PLINNFIDOFF = CEKMILKKGMN.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void NIPAGNDIOKE(JMIBEAJAMBD MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void OJDIEMGMCBB(JMIBEAJAMBD MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E35050", Offset = "0x5E34450", VA = "0x185E35050", Slot = "10")]
	public void KLMMKHHBOHM(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xB98900", Offset = "0xB97D00", VA = "0x180B98900")]
	private void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E34FA0", Offset = "0x5E343A0", VA = "0x185E34FA0")]
	private void HHHCCFOFBDJ(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E34F40", Offset = "0x5E34340", VA = "0x185E34F40", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public LHILGNHFLGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JLJDGGFKFNL
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum CEKMILKKGMN
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[FHOIBFDAOOA(typeof(OAPOPJMEPNA), new string[] { })]
public class MPODHBNHCKC : OAPOPJMEPNA, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly FJOGIBEAJHF NAOCLJCNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private JMIBEAJAMBD MHCBJGOCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private NBAFOHEBHDH PBPLEILOBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private JPNIIOOOMOP KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private LMFELGCOCBG AKMKBNFOGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private JFKABFIKFCO BADPICBHGCK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool LGAJFECOMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E367B0", Offset = "0x5E35BB0", VA = "0x185E367B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action AAOJNFDAGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E36710", Offset = "0x5E35B10", VA = "0x185E36710", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E36410", Offset = "0x5E35810", VA = "0x185E36410", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E36640", Offset = "0x5E35A40", VA = "0x185E36640", Slot = "12")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E36220", Offset = "0x5E35620", VA = "0x185E36220", Slot = "6")]
	public void DEICEPJKFDL(bool GJFJLOBMJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E365F0", Offset = "0x5E359F0", VA = "0x185E365F0", Slot = "7")]
	public bool IHGBDBPIGJB(ByteString KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E36210", Offset = "0x5E35610", VA = "0x185E36210", Slot = "11")]
	public void ABIKFDNBPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1619520", Offset = "0x1618920", VA = "0x181619520", Slot = "9")]
	public void AADMAAIDNBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E364B0", Offset = "0x5E358B0", VA = "0x185E364B0", Slot = "10")]
	public void ICKNFFFCLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public MPODHBNHCKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class PDFPGGNAHKF<T> : FAGIAHAODNP<T>, JIMDNDNBHNB<IKAJAHLJFMC, T>, PKPMIGECBKB<IKAJAHLJFMC>, IJNFIHACIMM, IDisposable, DNHFDIEHCPF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PKPMIGECBKB<Entity> OIBKEMMFJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Delegate PBPHEHNPDKP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF540", Offset = "0x3DFE940", VA = "0x183DFF540", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Type EMLIJIGFNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E05C00", Offset = "0x3E05000", VA = "0x183E05C00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public JKAOACKGDOB OHGMICICEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E065A0", Offset = "0x3E059A0", VA = "0x183E065A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NALINPCHJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E12A80", Offset = "0x3E11E80", VA = "0x183E12A80", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public AGCKMMLDJMF MAPOJMLOMNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFA90", Offset = "0x3DFEE90", VA = "0x183DFFA90", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event EIDGEBHMFOI<IKAJAHLJFMC> ILMIDAPKLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEB90", Offset = "0x3DFDF90", VA = "0x183DFEB90", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3E13720", Offset = "0x3E12B20", VA = "0x183E13720", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x380CC40", Offset = "0x380C040", VA = "0x18380CC40")]
	public PDFPGGNAHKF(PKPMIGECBKB<Entity> OIBKEMMFJDM, CDJJECGMMII JJMFHKECKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E10C30", Offset = "0x3E10030", VA = "0x183E10C30")]
	private Entity MHFBJFFHDKD(IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3E10DB0", Offset = "0x3E101B0", VA = "0x183E10DB0")]
	private IKAJAHLJFMC MHFBJFFHDKD(Entity AHNNJNFIHFM)
	{
		return default(IKAJAHLJFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3E077D0", Offset = "0x3E06BD0", VA = "0x183E077D0", Slot = "4")]
	public T KJBHHOOLCCM(IKAJAHLJFMC MIPKLHDFLBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3E00120", Offset = "0x3DFF520", VA = "0x183E00120")]
	public bool FAJCEJLMNJF(IKAJAHLJFMC MIPKLHDFLBO, [In] T GJFJLOBMJBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3E122B0", Offset = "0x3E116B0", VA = "0x183E122B0", Slot = "7")]
	public bool NDBJGAPFHCF(IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3E07140", Offset = "0x3E06540", VA = "0x183E07140", Slot = "8")]
	public void KJBHHOOLCCM(IKAJAHLJFMC MIPKLHDFLBO, PAAILIGMCIN LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFCE0", Offset = "0x3DFF0E0", VA = "0x183DFFCE0", Slot = "9")]
	public bool FAJCEJLMNJF(IKAJAHLJFMC MIPKLHDFLBO, JGFJHAANPIB GJFJLOBMJBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3804160", Offset = "0x3803560", VA = "0x183804160", Slot = "16")]
	public void CJBPDOLDKJH(AJBOGAKBDLF DMDOHKOAEAA, [Optional] object CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3E13F90", Offset = "0x3E13390", VA = "0x183E13F90", Slot = "10")]
	public bool PCONDBHNLLG(IKAJAHLJFMC PFDAOEPJLFE, IKAJAHLJFMC KECAMMIJJDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFCC0", Offset = "0x3DFF0C0", VA = "0x183DFFCC0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3E148B0", Offset = "0x3E13CB0", VA = "0x183E148B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB280", Offset = "0x3DFA680", VA = "0x183DFB280")]
	private void AEKAHFJPNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3E04700", Offset = "0x3E03B00", VA = "0x183E04700")]
	private void FNEPICAPINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C6F0", Offset = "0x3E0BAF0", VA = "0x183E0C6F0")]
	private void KMKHHNFCEFK(Entity AHNNJNFIHFM, [In] JGFJHAANPIB MKKHNLNBPNM, [In] JGFJHAANPIB GJFJLOBMJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3E11660", Offset = "0x3E10A60", VA = "0x183E11660")]
	private void MNNBLABAHOJ(Entity AHNNJNFIHFM, [In] JGFJHAANPIB MKKHNLNBPNM, [In] JGFJHAANPIB GJFJLOBMJBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class KKKAPFIEENB<T> : FACGOEDLDML<T>, JIMDNDNBHNB<CAKFEHOBCAO, T>, PKPMIGECBKB<CAKFEHOBCAO>, IJNFIHACIMM, IDisposable, LJEACGFBGAF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PKPMIGECBKB<Entity> OIBKEMMFJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Delegate PBPHEHNPDKP;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3803EE0", Offset = "0x38032E0", VA = "0x183803EE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type EMLIJIGFNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3806990", Offset = "0x3805D90", VA = "0x183806990", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JKAOACKGDOB OHGMICICEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3806D70", Offset = "0x3806170", VA = "0x183806D70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int NALINPCHJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x380B860", Offset = "0x380AC60", VA = "0x18380B860", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public AGCKMMLDJMF MAPOJMLOMNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3804230", Offset = "0x3803630", VA = "0x183804230", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EIDGEBHMFOI<CAKFEHOBCAO> ILMIDAPKLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3803E30", Offset = "0x3803230", VA = "0x183803E30", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x380B8B0", Offset = "0x380ACB0", VA = "0x18380B8B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x380CC40", Offset = "0x380C040", VA = "0x18380CC40")]
	public KKKAPFIEENB(PKPMIGECBKB<Entity> OIBKEMMFJDM, CDJJECGMMII JJMFHKECKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x380AF90", Offset = "0x380A390", VA = "0x18380AF90")]
	private Entity MHFBJFFHDKD(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x380AF40", Offset = "0x380A340", VA = "0x18380AF40")]
	private CAKFEHOBCAO MHFBJFFHDKD(Entity AHNNJNFIHFM)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3807A10", Offset = "0x3806E10", VA = "0x183807A10", Slot = "4")]
	public T KJBHHOOLCCM(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3804B00", Offset = "0x3803F00", VA = "0x183804B00")]
	public bool FAJCEJLMNJF(CAKFEHOBCAO AJAFIOGCMHP, [In] T GJFJLOBMJBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x380B0F0", Offset = "0x380A4F0", VA = "0x18380B0F0", Slot = "7")]
	public bool NDBJGAPFHCF(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3806EB0", Offset = "0x38062B0", VA = "0x183806EB0", Slot = "8")]
	public void KJBHHOOLCCM(CAKFEHOBCAO AJAFIOGCMHP, PAAILIGMCIN LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3804FF0", Offset = "0x38043F0", VA = "0x183804FF0", Slot = "9")]
	public bool FAJCEJLMNJF(CAKFEHOBCAO AJAFIOGCMHP, JGFJHAANPIB GJFJLOBMJBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3804160", Offset = "0x3803560", VA = "0x183804160", Slot = "16")]
	public void CJBPDOLDKJH(AJBOGAKBDLF DMDOHKOAEAA, [Optional] object CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x380BFB0", Offset = "0x380B3B0", VA = "0x18380BFB0", Slot = "10")]
	public bool PCONDBHNLLG(CAKFEHOBCAO PFDAOEPJLFE, CAKFEHOBCAO KECAMMIJJDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3803560", Offset = "0x3802960", VA = "0x183803560")]
	private void AEKAHFJPNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3806530", Offset = "0x3805930", VA = "0x183806530")]
	private void FNEPICAPINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x380AAF0", Offset = "0x3809EF0", VA = "0x18380AAF0")]
	private void KMKHHNFCEFK(Entity AHNNJNFIHFM, [In] JGFJHAANPIB MKKHNLNBPNM, [In] JGFJHAANPIB GJFJLOBMJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x380AFA0", Offset = "0x380A3A0", VA = "0x18380AFA0")]
	private void MNNBLABAHOJ(Entity AHNNJNFIHFM, [In] JGFJHAANPIB MKKHNLNBPNM, [In] JGFJHAANPIB GJFJLOBMJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3000C50", Offset = "0x3000050", VA = "0x183000C50", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x380CA00", Offset = "0x380BE00", VA = "0x18380CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KEIADDADLII : PAEPNGDGNBO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HEIEIMMBOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int JLENMGKDJEP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> FCNPHJFMOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA40000", Offset = "0xA3F400", VA = "0x180A40000", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int LMFDPDKPOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EF630", Offset = "0x7EEA30", VA = "0x1807EF630", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x303D580", Offset = "0x303C980", VA = "0x18303D580")]
	public KEIADDADLII(NativeArray<EntityRemapUtility.EntityRemapInfo> HEIEIMMBOHA, int JLENMGKDJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E31760", Offset = "0x5E30B60", VA = "0x185E31760", Slot = "6")]
	public CAKFEHOBCAO KJADHLDCIPC(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E317E0", Offset = "0x5E30BE0", VA = "0x185E317E0", Slot = "8")]
	public LocalId KJADHLDCIPC(LocalId AHNNJNFIHFM)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E31700", Offset = "0x5E30B00", VA = "0x185E31700", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[FHOIBFDAOOA(typeof(IENHIAPIEPB), new string[] { "Editor" })]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public sealed class IENHIAPIEPB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate void KFFKOKPLPIA(IKAJAHLJFMC HKGAELMMDKP, CHCOMAAHOED OOIBMCBCEPD, bool KIPGDOOKNKL);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate void AHBKDILFLDI(IKAJAHLJFMC HKGAELMMDKP, bool KIPGDOOKNKL);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void DHPHICBALHO(IKAJAHLJFMC HKGAELMMDKP, NHGDGBFBAIF OIBKEMMFJDM, [In] JGFJHAANPIB LPCGJALKADL, bool KIPGDOOKNKL);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public IENHIAPIEPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum JBBOGPBFINA
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Main = 2,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Load = 4,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	NetworkReceive = 8,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Suppressed = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[FHOIBFDAOOA(typeof(KFIGKCHPCDA), new string[] { "Editor" })]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public sealed class KFIGKCHPCDA
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate void CMKEOCOLPPH(IKAJAHLJFMC MIPKLHDFLBO, CHCOMAAHOED OOIBMCBCEPD, JBBOGPBFINA PLINNFIDOFF);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate void PPICLOJFJPA(IKAJAHLJFMC MIPKLHDFLBO, JBBOGPBFINA PLINNFIDOFF);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void DJIKFMJBGHK(IKAJAHLJFMC MIPKLHDFLBO, NHGDGBFBAIF OIBKEMMFJDM, JGFJHAANPIB HDAGINFADOG, JGFJHAANPIB LFEAEFFENHM, JBBOGPBFINA PLINNFIDOFF);

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void DANENICKBAC(KFHEKKOEHDF IHHOPACLNAK, ReadOnlySpan<byte> CJFCIOOMJGN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KFIGKCHPCDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[FHOIBFDAOOA(typeof(IBNLNIKJFKJ), new string[] { })]
internal class FDJAJJIKHFK : IBNLNIKJFKJ, ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private enum Flag
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Allowed,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		AllowedInRoomV1,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		RoomUpgrade,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Clone,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Copy,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Undo,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		UndoCreation,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Physics,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		SerializationV4,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		HierarchyViewVisible
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class ONIIBENCBOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public ONIIBENCBOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AC00", Offset = "0x5E3A000", VA = "0x185E3AC00")]
		internal object ELJJLFKHJMO((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[DMNKPOGEHOO]
	private JMLLBGKNGCC KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[DMNKPOGEHOO]
	private EOAILPGBNIC GGJLDJABGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private NativeBitArray GJFOJEDJCDO;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public NBPHAGCBFCO BMMKBBBMIIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E25210", Offset = "0x5E24610", VA = "0x185E25210", Slot = "4")]
		get
		{
			return default(NBPHAGCBFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NBPHAGCBFCO JLKIGCNMAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E251E0", Offset = "0x5E245E0", VA = "0x185E251E0", Slot = "5")]
		get
		{
			return default(NBPHAGCBFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public NBPHAGCBFCO BOJEMDGECMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E25200", Offset = "0x5E24600", VA = "0x185E25200", Slot = "6")]
		get
		{
			return default(NBPHAGCBFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NBPHAGCBFCO PCONDBHNLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E251B0", Offset = "0x5E245B0", VA = "0x185E251B0", Slot = "7")]
		get
		{
			return default(NBPHAGCBFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NBPHAGCBFCO NDGMEKCFKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E251D0", Offset = "0x5E245D0", VA = "0x185E251D0", Slot = "8")]
		get
		{
			return default(NBPHAGCBFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NBPHAGCBFCO NHEPPELDCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E25020", Offset = "0x5E24420", VA = "0x185E25020", Slot = "9")]
		get
		{
			return default(NBPHAGCBFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NBPHAGCBFCO CEAOLLGHOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E256B0", Offset = "0x5E24AB0", VA = "0x185E256B0", Slot = "10")]
		get
		{
			return default(NBPHAGCBFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NBPHAGCBFCO BHBGFGFGFPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E250D0", Offset = "0x5E244D0", VA = "0x185E250D0", Slot = "11")]
		get
		{
			return default(NBPHAGCBFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NBPHAGCBFCO BBHMEIFDOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E251C0", Offset = "0x5E245C0", VA = "0x185E251C0", Slot = "12")]
		get
		{
			return default(NBPHAGCBFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private int EGOOIBGPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E25030", Offset = "0x5E24430", VA = "0x185E25030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E25480", Offset = "0x5E24880", VA = "0x185E25480", Slot = "13")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E25100", Offset = "0x5E24500", VA = "0x185E25100", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5E25660", Offset = "0x5E24A60", VA = "0x185E25660")]
	private void PDBGIMPGOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5E25230", Offset = "0x5E24630", VA = "0x185E25230")]
	private void IPEMGNADFHB(Flag LGHBOELIKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5E255E0", Offset = "0x5E249E0", VA = "0x185E255E0")]
	private NBPHAGCBFCO NGPEJIEPLLI(Flag LGHBOELIKLL)
	{
		return default(NBPHAGCBFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5E250E0", Offset = "0x5E244E0", VA = "0x185E250E0")]
	private NBPHAGCBFCO DJCNONCCKCP(Flag LGHBOELIKLL)
	{
		return default(NBPHAGCBFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FDJAJJIKHFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[FHOIBFDAOOA(typeof(ILMDBJJKHAL), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
internal class ILMDBJJKHAL : IFKHMGNDLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C6A0", Offset = "0x5E2BAA0", VA = "0x185E2C6A0", Slot = "4")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public ILMDBJJKHAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[FHOIBFDAOOA(typeof(BHJJJGDFHKK), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal class BHJJJGDFHKK : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly FJOGIBEAJHF EKDAAJIAFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[DMNKPOGEHOO]
	private NFFPLOOJDLP KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[DMNKPOGEHOO]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[DMNKPOGEHOO]
	private EPEIHHNCIHD EHJFODOFCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private JFKABFIKFCO BADPICBHGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private EntityQuery FJBIAIPDEFA;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1BD80", Offset = "0x5E1B180", VA = "0x185E1BD80")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B0C0", Offset = "0x5E1A4C0", VA = "0x185E1B0C0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E19660", Offset = "0x5E18A60", VA = "0x185E19660", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B320", Offset = "0x5E1A720", VA = "0x185E1B320")]
	public EEKDDPBIMAP JJJKAMEDMMF(IEnumerable<OPBDJAPIKJM> BGMKAIMCJBK)
	{
		return default(EEKDDPBIMAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A330", Offset = "0x5E19730", VA = "0x185E1A330")]
	public static bool EIPKLEIDICI(OPBDJAPIKJM EJJHDDFDLOL, [Out] IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E19960", Offset = "0x5E18D60", VA = "0x185E19960")]
	private EEKDDPBIMAP EEMGOHHICON(IEnumerable<OPBDJAPIKJM> BGMKAIMCJBK)
	{
		return default(EEKDDPBIMAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E19070", Offset = "0x5E18470", VA = "0x185E19070")]
	private (List<OPBDJAPIKJM>, int[], int) AFIHPLKLNBE(IEnumerable<OPBDJAPIKJM> BGMKAIMCJBK)
	{
		return default((List<OPBDJAPIKJM>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BAD0", Offset = "0x5E1AED0", VA = "0x185E1BAD0")]
	private Dictionary<IKAJAHLJFMC, (OPBDJAPIKJM, int)> MNJBEIJFCNC(IEnumerable<OPBDJAPIKJM> BGMKAIMCJBK, Entity ANNLEMAHFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E19270", Offset = "0x5E18670", VA = "0x185E19270")]
	private void BBPGACGMDMM(Dictionary<IKAJAHLJFMC, (OPBDJAPIKJM request, int srcIndex)> HJKKEBPEJPC, IEnumerable<OPBDJAPIKJM> BGMKAIMCJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B860", Offset = "0x5E1AC60", VA = "0x185E1B860")]
	private void MMPHJMNJPMO(Dictionary<IKAJAHLJFMC, (OPBDJAPIKJM request, int srcIndex)> HJKKEBPEJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A430", Offset = "0x5E19830", VA = "0x185E1A430")]
	private void EMFLGPGNDOM(Dictionary<IKAJAHLJFMC, (OPBDJAPIKJM request, int srcIndex)> HJKKEBPEJPC, IKAJAHLJFMC MIPKLHDFLBO, string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E19E50", Offset = "0x5E19250", VA = "0x185E19E50")]
	private void EHIGEIEKGFI(Dictionary<IKAJAHLJFMC, (OPBDJAPIKJM request, int srcIndex)> HJKKEBPEJPC, Entity ANNLEMAHFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A910", Offset = "0x5E19D10", VA = "0x185E1A910")]
	private (List<OPBDJAPIKJM>, int[], int) GMKFFLEPMNL(Dictionary<IKAJAHLJFMC, (OPBDJAPIKJM request, int srcIndex)> HJKKEBPEJPC, Entity ANNLEMAHFPO)
	{
		return default((List<OPBDJAPIKJM>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E19670", Offset = "0x5E18A70", VA = "0x185E19670")]
	private void ECLGHPGJKJH(Dictionary<IKAJAHLJFMC, (OPBDJAPIKJM request, int srcIndex)> HJKKEBPEJPC, List<OPBDJAPIKJM> HDDDGCGPGPP, int[] EGMGKCBFJEH, NativeArray<Entity> JIBDNODJOAB, NativeList<IKAJAHLJFMC> LLBGDKONGBO, NativeList<Entity> JMNCECBPPNH, Entity ANNLEMAHFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B790", Offset = "0x5E1AB90", VA = "0x185E1B790")]
	private static bool MCLFHAICLAN(Entity AHNNJNFIHFM, ComponentDataFromEntity<ParentData> NMBEPDAHJGF, Entity ANNLEMAHFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B420", Offset = "0x5E1A820", VA = "0x185E1B420")]
	private void LDFIJBNNCOI(Dictionary<IKAJAHLJFMC, (OPBDJAPIKJM request, int srcIndex)> HJKKEBPEJPC, List<OPBDJAPIKJM> HDDDGCGPGPP, int[] EGMGKCBFJEH, NativeList<Entity> JMNCECBPPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AD80", Offset = "0x5E1A180", VA = "0x185E1AD80")]
	private NativeList<IKAJAHLJFMC> HGPEPKOGLHH(Dictionary<IKAJAHLJFMC, (OPBDJAPIKJM request, int srcIndex)> HJKKEBPEJPC)
	{
		return default(NativeList<IKAJAHLJFMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BB90", Offset = "0x5E1AF90", VA = "0x185E1BB90")]
	private NativeArray<Entity> NGJMAKKLAGG(NativeList<IKAJAHLJFMC> LLBGDKONGBO)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AFA0", Offset = "0x5E1A3A0", VA = "0x185E1AFA0")]
	private static void IGMGDDFCFKA(Dictionary<IKAJAHLJFMC, (OPBDJAPIKJM request, int srcIndex)> HJKKEBPEJPC, IKAJAHLJFMC MIPKLHDFLBO, OPBDJAPIKJM EJJHDDFDLOL, string DKFEAPHKBMP, int LJLBCLNHPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A270", Offset = "0x5E19670", VA = "0x185E1A270")]
	private void EHIIAFADMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public BHJJJGDFHKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
[FHOIBFDAOOA(typeof(ABINPCDKADH), new string[] { })]
internal class ABINPCDKADH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public void JJEADOEMNFB(string DKFEAPHKBMP, EntityManager OKNGAOGEIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public ABINPCDKADH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[AIFOCBABFAO(typeof(BGDEDBPHGDF))]
[FHOIBFDAOOA(typeof(JFKABFIKFCO), new string[] { })]
internal class BGDEDBPHGDF : JFKABFIKFCO, IDisposable, ENDDIKHKCDF, KJICHBMECLA
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly FJOGIBEAJHF NAOCLJCNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[DMNKPOGEHOO]
	private JPNIIOOOMOP KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[DMNKPOGEHOO]
	private OAPOPJMEPNA OGDJALIBICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[DMNKPOGEHOO]
	private EOJCJEFAOPN OMNHOGNBOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private LMFELGCOCBG AKMKBNFOGOJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool AKFAGMFIFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7B8540", Offset = "0x7B7940", VA = "0x1807B8540", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7B7D20", Offset = "0x7B7120", VA = "0x1807B7D20", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool JNPNFAEJDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x108B3A0", Offset = "0x108A7A0", VA = "0x18108B3A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool APJLDIFMKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5F0", Offset = "0x7EE9F0", VA = "0x1807EF5F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7EF610", Offset = "0x7EEA10", VA = "0x1807EF610", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public KLDHNDGGMFO ANPCHGNBOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x767760", Offset = "0x766B60", VA = "0x180767760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5E18A20", Offset = "0x5E17E20", VA = "0x185E18A20", Slot = "15")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5E18320", Offset = "0x5E17720", VA = "0x185E18320", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5E18EA0", Offset = "0x5E182A0", VA = "0x185E18EA0", Slot = "8")]
	public EINHHNIDDEG NHMEKPHCMOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5E18790", Offset = "0x5E17B90", VA = "0x185E18790")]
	public EINHHNIDDEG GDHPIIHLFOC(IEnumerable<CAKFEHOBCAO> MOMJNKBEDGK, [In] CJOBJHHCGGP MGMGONHABNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5E18520", Offset = "0x5E17920", VA = "0x185E18520", Slot = "10")]
	public GOPDDEOGDJM FIKEIGEMCPF(ByteString KHPJJNGKJGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5E18380", Offset = "0x5E17780", VA = "0x185E18380")]
	public CCDCMKEIGFA EKKNNINADNC(ByteString KHPJJNGKJGC, CAKFEHOBCAO DCLCDDGJKIC, [In] CJOBJHHCGGP EDKPGHPBAJK, IIOGBKCCMMK BEDKGOACLBP, bool LGDOBIONJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5E18CA0", Offset = "0x5E180A0", VA = "0x185E18CA0", Slot = "12")]
	public void KINAHPFLLOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5E18AD0", Offset = "0x5E17ED0", VA = "0x185E18AD0", Slot = "13")]
	public EEKDDPBIMAP JJJKAMEDMMF(IEnumerable<OPBDJAPIKJM> AHCDBFBGANG)
	{
		return default(EEKDDPBIMAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5E18920", Offset = "0x5E17D20", VA = "0x185E18920")]
	public static bool IHGBDBPIGJB(ByteString KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5E18320", Offset = "0x5E17720", VA = "0x185E18320")]
	private void GJEHLEMAAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5E18E80", Offset = "0x5E18280", VA = "0x185E18E80")]
	private void LJOEHOMEHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5E18250", Offset = "0x5E17650", VA = "0x185E18250")]
	private void DFDJEPKOJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5E186E0", Offset = "0x5E17AE0", VA = "0x185E186E0", Slot = "16")]
	public void GAPJGIMLFIN(FIMDMOFKGJF AACLFMKNBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public BGDEDBPHGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5E180C0", Offset = "0x5E174C0", VA = "0x185E180C0", Slot = "9")]
	private EINHHNIDDEG DFCIOGMBGBK(IEnumerable<CAKFEHOBCAO> MOMJNKBEDGK, [In] CJOBJHHCGGP MGMGONHABNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5E17EF0", Offset = "0x5E172F0", VA = "0x185E17EF0", Slot = "11")]
	private CCDCMKEIGFA BENPCBIHIMO(ByteString KHPJJNGKJGC, CAKFEHOBCAO DCLCDDGJKIC, [In] CJOBJHHCGGP EDKPGHPBAJK, IIOGBKCCMMK BEDKGOACLBP, bool LGDOBIONJGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[FHOIBFDAOOA(typeof(MAICAFPPDGB), new string[] { })]
[AIFOCBABFAO(typeof(EOJCJEFAOPN))]
internal class EOJCJEFAOPN : MAICAFPPDGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[CompilerGenerated]
	private Action<PAEPNGDGNBO> JBNKFOLAJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[CompilerGenerated]
	private Action<PAEPNGDGNBO> MMHAJNHDAAM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action ICKNFFFCLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5E23EE0", Offset = "0x5E232E0", VA = "0x185E23EE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5E23BC0", Offset = "0x5E22FC0", VA = "0x185E23BC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action PIGBEIEEOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5E23D00", Offset = "0x5E23100", VA = "0x185E23D00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5E23E40", Offset = "0x5E23240", VA = "0x185E23E40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action GBGGLNAFMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5E23C60", Offset = "0x5E23060", VA = "0x185E23C60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5E23DA0", Offset = "0x5E231A0", VA = "0x185E23DA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA95F10", Offset = "0xA95310", VA = "0x180A95F10")]
	public void KINAHPFLLOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xA95CD0", Offset = "0xA950D0", VA = "0x180A95CD0")]
	public void OBOFEJMGBMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0xAA46D0", Offset = "0xAA3AD0", VA = "0x180AA46D0")]
	public void EHBCAOKFEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x11AF840", Offset = "0x11AEC40", VA = "0x1811AF840")]
	public void EPPFIAHOKGN(PAEPNGDGNBO PMNHOPMJONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x172C310", Offset = "0x172B710", VA = "0x18172C310")]
	public void PPPJCDBKMIK(PAEPNGDGNBO PMNHOPMJONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public EOJCJEFAOPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[FHOIBFDAOOA(typeof(GMEBHOOMEDK), new string[] { })]
public class KOANKKJNBMH : GMEBHOOMEDK, BJJLPKDABKC, IFKHMGNDLHA, ENDDIKHKCDF, ICKLGHMJPBB, IDisposable, KOANKKJNBMH.FKJHCHKPOIE
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal interface FKJHCHKPOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PCJKFPBFBMJ(global::CNJPIPKMIKP GEFLJJFNGLO);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private MDBBBKIBFGG NMABGJCEKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private DJAIMNHGDHI MNIFNPOEFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private HFHCOKNIOMB LKCOHANNNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private global::CNJPIPKMIKP AAANBDEJCAC;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private FACGOEDLDML<CAKFEHOBCAO> KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x765460", Offset = "0x764860", VA = "0x180765460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5E32C30", Offset = "0x5E32030", VA = "0x185E32C30")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<OGALCPHBFJB> HBOMIODELKD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5E32240", Offset = "0x5E31640", VA = "0x185E32240", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5E32910", Offset = "0x5E31D10", VA = "0x185E32910", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x158E820", Offset = "0x158DC20", VA = "0x18158E820", Slot = "17")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5E32620", Offset = "0x5E31A20", VA = "0x185E32620", Slot = "18")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5E322A0", Offset = "0x5E316A0", VA = "0x185E322A0", Slot = "19")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x767710", Offset = "0x766B10", VA = "0x180767710", Slot = "21")]
	private void CHOFDEFLDNF(global::CNJPIPKMIKP GEFLJJFNGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x158E770", Offset = "0x158DB70", VA = "0x18158E770", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5E32390", Offset = "0x5E31790", VA = "0x185E32390")]
	private CAKFEHOBCAO FMLCGBPJBLI(Entity AHNNJNFIHFM)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5E32590", Offset = "0x5E31990", VA = "0x185E32590", Slot = "6")]
	public CAKFEHOBCAO IKLADMFFKPA(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5E326F0", Offset = "0x5E31AF0", VA = "0x185E326F0", Slot = "7")]
	public void JCEFKGHBPFN(List<CAKFEHOBCAO> ALDIHCKBCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5E32B80", Offset = "0x5E31F80", VA = "0x185E32B80", Slot = "11")]
	public int NAODMJCGMDJ(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5E32140", Offset = "0x5E31540", VA = "0x185E32140", Slot = "12")]
	public KLCLLLJMBOO DIAHBPCGMNJ(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5E329F0", Offset = "0x5E31DF0", VA = "0x185E329F0", Slot = "15")]
	public CAKFEHOBCAO LFJGHBELPCN(CAKFEHOBCAO ADOGMMPMLJB, CAKFEHOBCAO EOFPNCBMKHP)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5E324A0", Offset = "0x5E318A0", VA = "0x185E324A0", Slot = "16")]
	public bool HMBKMODMMCG(CAKFEHOBCAO ADOGMMPMLJB, CAKFEHOBCAO EOFPNCBMKHP, [Out] CAKFEHOBCAO AFMEONIJNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5E32AF0", Offset = "0x5E31EF0", VA = "0x185E32AF0", Slot = "8")]
	public CAKFEHOBCAO NALNAGAMHFP(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5E32C80", Offset = "0x5E32080", VA = "0x185E32C80", Slot = "14")]
	public bool OMHDFCIKAMC(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO JHJELAILOKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5E323E0", Offset = "0x5E317E0", VA = "0x185E323E0", Slot = "13")]
	public bool GBDKGPAEEJJ(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO JBFHBGCJGMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5E32970", Offset = "0x5E31D70", VA = "0x185E32970", Slot = "9")]
	public bool LEKFLKBIABP(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO DCLCDDGJKIC, bool HLAFCEMDKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5E32440", Offset = "0x5E31840", VA = "0x185E32440", Slot = "10")]
	public bool GNMLKPBGKPO(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO DCLCDDGJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KOANKKJNBMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[FHOIBFDAOOA(typeof(DCFMFEJHJBD), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal class DCFMFEJHJBD : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[DMNKPOGEHOO]
	private KHBOFPBPOBG MJHCCCCPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<int, AEPEJGKFDPK> JNMCDBKBEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D7E0", Offset = "0x5E1CBE0", VA = "0x185E1D7E0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D550", Offset = "0x5E1C950", VA = "0x185E1D550", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DC10", Offset = "0x5E1D010", VA = "0x185E1DC10")]
	public AEPEJGKFDPK OPCDCILFOHB(AMAMFBGBCKA OKJGMJDJMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D9E0", Offset = "0x5E1CDE0", VA = "0x185E1D9E0")]
	public AEPEJGKFDPK OPCDCILFOHB(NHGDGBFBAIF LNAKMGONIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D830", Offset = "0x5E1CC30", VA = "0x185E1D830")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DD10", Offset = "0x5E1D110", VA = "0x185E1DD10")]
	public DCFMFEJHJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class AEPEJGKFDPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeList<NOJABDMKHEO> EJLMPKNBNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeList<OJKDLDANCCG> ODFCMLHAAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<FFIEFAIFGJM> AGDAEKCIDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<OJKDLDANCCG> AEIBFIDOKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public NativeList<NOJABDMKHEO> PPNDODEIELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA40000", Offset = "0xA3F400", VA = "0x180A40000")]
		get
		{
			return default(NativeList<NOJABDMKHEO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NativeList<OJKDLDANCCG> BGCBMCOGCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xD6E3E0", Offset = "0xD6D7E0", VA = "0x180D6E3E0")]
		get
		{
			return default(NativeList<OJKDLDANCCG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<FFIEFAIFGJM> BDEGFEFNOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xD230A0", Offset = "0xD224A0", VA = "0x180D230A0")]
		get
		{
			return default(NativeList<FFIEFAIFGJM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<OJKDLDANCCG> BDLIDNMPMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x88A1D0", Offset = "0x8895D0", VA = "0x18088A1D0")]
		get
		{
			return default(NativeList<OJKDLDANCCG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public JobHandle OPFLGDLCHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x93E100", Offset = "0x93D500", VA = "0x18093E100")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xFD81C0", Offset = "0xFD75C0", VA = "0x180FD81C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool KMLKCKNNLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5E17240", Offset = "0x5E16640", VA = "0x185E17240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5E174A0", Offset = "0x5E168A0", VA = "0x185E174A0")]
	public AEPEJGKFDPK(Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5E17410", Offset = "0x5E16810", VA = "0x185E17410")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5E172E0", Offset = "0x5E166E0", VA = "0x185E172E0")]
	public void OCOEOHNAACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5E16F00", Offset = "0x5E16300", VA = "0x185E16F00")]
	public void GIHKKMKIIOJ(Entity AHNNJNFIHFM, Entity CLBKMLECIHH, Entity KJOCICNOINI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[FHOIBFDAOOA(typeof(PIJPFGBFCFH), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public class PIJPFGBFCFH : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[DMNKPOGEHOO]
	private BNKPHKHKLHD CNIFLPLFONI;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C050", Offset = "0x5E3B450", VA = "0x185E3C050", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C030", Offset = "0x5E3B430", VA = "0x185E3C030", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public PIJPFGBFCFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[AKLGDNDGKKL(DPJKEJCGJEB.PhotonRoom)]
[FHOIBFDAOOA(typeof(ILNJHJKGMAN), new string[] { })]
public class ILNJHJKGMAN : BJJLPKDABKC, IFKHMGNDLHA, ENDDIKHKCDF, ICKLGHMJPBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private BKIMEPBHNGA KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private OAPOPJMEPNA MFBPLBIAIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NativeList<int> KFKFDGKODOJ;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C910", Offset = "0x5E2BD10", VA = "0x185E2C910", Slot = "4")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C860", Offset = "0x5E2BC60", VA = "0x185E2C860", Slot = "5")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C7B0", Offset = "0x5E2BBB0", VA = "0x185E2C7B0", Slot = "6")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C6F0", Offset = "0x5E2BAF0", VA = "0x185E2C6F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C970", Offset = "0x5E2BD70", VA = "0x185E2C970")]
	public void OHCMCGAOODI(NativeParallelHashSet<int> ENMFCGBAJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C8D0", Offset = "0x5E2BCD0", VA = "0x185E2C8D0")]
	public void JCGFLIICEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public ILNJHJKGMAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal abstract class OIBOBBOALJP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private uint AOGJAKMEAAH;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract uint DJGGCNBKAJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3AD82D0", Offset = "0x3AD76D0", VA = "0x183AD82D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5E39820", Offset = "0x5E38C20", VA = "0x185E39820")]
	public IKAJAHLJFMC PLDLGEKLLIK()
	{
		return default(IKAJAHLJFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5E397B0", Offset = "0x5E38BB0", VA = "0x185E397B0")]
	public void PIGOIOKFDJB(NativeArray<IKAJAHLJFMC> LLBGDKONGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5E396B0", Offset = "0x5E38AB0", VA = "0x185E396B0")]
	public void PIGOIOKFDJB(IKAJAHLJFMC MIPKLHDFLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0xA71EE0", Offset = "0xA712E0", VA = "0x180A71EE0", Slot = "6")]
	public virtual void CGCDLMDFFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5E39610", Offset = "0x5E38A10", VA = "0x185E39610")]
	private unsafe void AAKAHBPDBCM(IKAJAHLJFMC* NNCOLKNDNPD, int CHEGLPEPHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5E396D0", Offset = "0x5E38AD0", VA = "0x185E396D0")]
	private unsafe void PIGOIOKFDJB(IKAJAHLJFMC* NNCOLKNDNPD, int CHEGLPEPHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected OIBOBBOALJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[FHOIBFDAOOA(typeof(CONBBCGFLGK), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal sealed class CONBBCGFLGK : OIBOBBOALJP, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DMNKPOGEHOO]
	private GENLJBHGPDA KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private uint JNIFDEFBBOF;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override uint DJGGCNBKAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7EF630", Offset = "0x7EEA30", VA = "0x1807EF630", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CCB0", Offset = "0x5E1C0B0", VA = "0x185E1CCB0", Slot = "7")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CC00", Offset = "0x5E1C000", VA = "0x185E1CC00")]
	private void BJJJEFPEADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CC50", Offset = "0x5E1C050", VA = "0x185E1CC50", Slot = "6")]
	public override void CGCDLMDFFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public CONBBCGFLGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(JFKPCOBONKJ), new string[] { })]
internal sealed class JFKPCOBONKJ : OIBOBBOALJP
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override uint DJGGCNBKAJF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public JFKPCOBONKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[FHOIBFDAOOA(typeof(DDPCONHAGKM), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal sealed class DDPCONHAGKM : BJJLPKDABKC, IFKHMGNDLHA, ENDDIKHKCDF, ICKLGHMJPBB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private EntityQuery OHMOAACMHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private EntityQuery PDPBJFLDINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private EntityQuery PGPPCGHHHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private EntityQuery PLKGIGLACFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery COFIMACDDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery LGOPDGLLNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery HKHJKNMPDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E5B0", Offset = "0x5E1D9B0", VA = "0x185E1E5B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public EntityQuery GCHGPMFNILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x93E120", Offset = "0x93D520", VA = "0x18093E120")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E560", Offset = "0x5E1D960", VA = "0x185E1E560", Slot = "5")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DEE0", Offset = "0x5E1D2E0", VA = "0x185E1DEE0", Slot = "6")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E440", Offset = "0x5E1D840", VA = "0x185E1E440")]
	private EntityQueryDesc GJNJEFKDIGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DE70", Offset = "0x5E1D270", VA = "0x185E1DE70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DDA0", Offset = "0x5E1D1A0", VA = "0x185E1DDA0")]
	public PLMJAAHFMOO CBFFKDJAICB(CAKFEHOBCAO PCOAABDKEED)
	{
		return default(PLMJAAHFMOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E4B0", Offset = "0x5E1D8B0", VA = "0x185E1E4B0")]
	public HNGHCMBBKEB HHHMIGOGAJK(Entity AHNNJNFIHFM)
	{
		return default(HNGHCMBBKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E600", Offset = "0x5E1DA00", VA = "0x185E1E600")]
	public DDPCONHAGKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[FHOIBFDAOOA(typeof(CDJJECGMMII), new string[] { })]
public class OCBEJBHBNEG : ENDDIKHKCDF, CDJJECGMMII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly FJOGIBEAJHF GMEGONMCAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[DMNKPOGEHOO]
	private CPBLFKHDDGN MCIPOELAAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[DMNKPOGEHOO]
	private OELIJJIDAJD FBGBGEJBECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[DMNKPOGEHOO]
	private HFHCOKNIOMB GIKKACIEGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[DMNKPOGEHOO]
	private BFCOAGBJGDN FNIMMOLDOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[DMNKPOGEHOO]
	private DDPCONHAGKM MNIFNPOEFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private DJOMFACBNME IEDKLDPPILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private GICCNDIODFI EKNAGPONANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public CPBLFKHDDGN NKHNPFLPACC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public OBPNGNFDEPN NGPOIHIFCBF
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6710", Offset = "0x8A5B10", VA = "0x1808A6710", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(OBPNGNFDEPN);
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8A5590", Offset = "0x8A4990", VA = "0x1808A5590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<KLCLLLJMBOO, NativeArray<HNGHCMBBKEB>> ABCOPLNBDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x5E39350", Offset = "0x5E38750", VA = "0x185E39350", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5E389E0", Offset = "0x5E37DE0", VA = "0x185E389E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<KLCLLLJMBOO> CHDCLLPLJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5E37E30", Offset = "0x5E37230", VA = "0x185E37E30", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5E38FC0", Offset = "0x5E383C0", VA = "0x185E38FC0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5E38AE0", Offset = "0x5E37EE0", VA = "0x185E38AE0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E38420", Offset = "0x5E37820", VA = "0x185E38420", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E38CE0", Offset = "0x5E380E0", VA = "0x185E38CE0")]
	private void JKCIGHNLBEE(KLCLLLJMBOO GIIACOBGMNH, NativeArray<HNGHCMBBKEB> HDDEBDIKCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E38550", Offset = "0x5E37950", VA = "0x185E38550")]
	private void EMAAPOHLAME(KLCLLLJMBOO GIIACOBGMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E38840", Offset = "0x5E37C40", VA = "0x185E38840")]
	internal CAKFEHOBCAO FMLCGBPJBLI(Entity AHNNJNFIHFM)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E38290", Offset = "0x5E37690", VA = "0x185E38290", Slot = "11")]
	public PLMJAAHFMOO CBFFKDJAICB(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(PLMJAAHFMOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E38A90", Offset = "0x5E37E90", VA = "0x185E38A90", Slot = "12")]
	public HNGHCMBBKEB HHHMIGOGAJK(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(HNGHCMBBKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E39200", Offset = "0x5E38600", VA = "0x185E39200", Slot = "39")]
	public bool NDBJGAPFHCF(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E39400", Offset = "0x5E38800", VA = "0x185E39400", Slot = "34")]
	public void PICMAPEPIMK(KLCLLLJMBOO MOMJNKBEDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E392F0", Offset = "0x5E386F0", VA = "0x185E392F0", Slot = "35")]
	public void OMMIKAHKMGL(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E39540", Offset = "0x5E38940", VA = "0x185E39540", Slot = "36")]
	public void PMDLPBBGJKF(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E39500", Offset = "0x5E38900", VA = "0x185E39500", Slot = "37")]
	public void PICMAPEPIMK(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E390B0", Offset = "0x5E384B0", VA = "0x185E390B0", Slot = "24")]
	public KLCLLLJMBOO MBBJHIFDBPF(NativeArray<IKAJAHLJFMC> MIPKLHDFLBO, Allocator JIIMEDFKEME)
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E38720", Offset = "0x5E37B20", VA = "0x185E38720", Slot = "25")]
	public KLCLLLJMBOO FIOLIIPCNDJ(NativeArray<IKAJAHLJFMC> MIPKLHDFLBO, NativeArray<CHCOMAAHOED> CPBGBMAIAGD, Allocator JIIMEDFKEME)
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E38E20", Offset = "0x5E38220", VA = "0x185E38E20", Slot = "26")]
	public BAJJJAGOPJE KEABAAMENCA(HNGHCMBBKEB HOAIKLJFCGK, bool BONNBAOJEFF)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E38EC0", Offset = "0x5E382C0", VA = "0x185E38EC0", Slot = "27")]
	public BAJJJAGOPJE KEABAAMENCA(HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E38D80", Offset = "0x5E38180", VA = "0x185E38D80", Slot = "28")]
	public BAJJJAGOPJE KCANJMAFAGK(HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E38010", Offset = "0x5E37410", VA = "0x185E38010", Slot = "29")]
	public BAJJJAGOPJE AONPGCLANIO(HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E385E0", Offset = "0x5E379E0", VA = "0x185E385E0", Slot = "30")]
	public BAJJJAGOPJE FIOLIIPCNDJ(IKAJAHLJFMC MIPKLHDFLBO, HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E388B0", Offset = "0x5E37CB0", VA = "0x185E388B0", Slot = "31")]
	public PNAAPOCOKHE GLLDEMPMFCB()
	{
		return default(PNAAPOCOKHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E39110", Offset = "0x5E38510", VA = "0x185E39110", Slot = "32")]
	public BHAKFOIGDML MDIMLHEMGML()
	{
		return default(BHAKFOIGDML);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E38140", Offset = "0x5E37540", VA = "0x185E38140", Slot = "33")]
	public LNDHJLHCOEC BCBCDPHCOFG(JHDIEJNPMMJ DJMKKNDNCBM)
	{
		return default(LNDHJLHCOEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E38890", Offset = "0x5E37C90", VA = "0x185E38890", Slot = "13")]
	public void GFCMFFOEFBO(IKAJAHLJFMC MIPKLHDFLBO, CGNNELOIABF BIAMFCLNIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E37EE0", Offset = "0x5E372E0", VA = "0x185E37EE0", Slot = "14")]
	public BAJJJAGOPJE ALDDGBMMJNL(CAKFEHOBCAO AJAFIOGCMHP, [Optional] object IBLOMPOENGH)
	{
		return default(BAJJJAGOPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E38F60", Offset = "0x5E38360", VA = "0x185E38F60", Slot = "15")]
	public bool KEDFCEGBEDG(CAKFEHOBCAO AJAFIOGCMHP, [Out] CGNNELOIABF BBHPNPGLHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E39290", Offset = "0x5E38690", VA = "0x185E39290", Slot = "16")]
	public bool NHKFAJGADBA(CAKFEHOBCAO AJAFIOGCMHP, [Out] Transform IJKPFNCIDCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E38240", Offset = "0x5E37640", VA = "0x185E38240", Slot = "17")]
	public bool BDLMEDCBLOE(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E383B0", Offset = "0x5E377B0", VA = "0x185E383B0", Slot = "18")]
	public void DAFHNGHAEML(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E39240", Offset = "0x5E38640", VA = "0x185E39240", Slot = "19")]
	public bool NFIDNGBGDFA(LocalId AJAFIOGCMHP, object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E38590", Offset = "0x5E37990", VA = "0x185E38590", Slot = "20")]
	public bool FDDJPIDFEJE(LocalId AJAFIOGCMHP, object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E38980", Offset = "0x5E37D80", VA = "0x185E38980", Slot = "38")]
	public KLCLLLJMBOO GPLBOIIHMOK(KLCLLLJMBOO KPFNJKBFGEC, Allocator JIIMEDFKEME)
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E38370", Offset = "0x5E37770", VA = "0x185E38370", Slot = "23")]
	public IKAJAHLJFMC CDLFJKIJIFJ(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(IKAJAHLJFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E39070", Offset = "0x5E38470", VA = "0x185E39070", Slot = "21")]
	public CAKFEHOBCAO MBBJHIFDBPF(IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E38400", Offset = "0x5E37800", VA = "0x185E38400", Slot = "22")]
	public bool DMFHNPPLLIH(IKAJAHLJFMC MIPKLHDFLBO, [Out] CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E38D30", Offset = "0x5E38130", VA = "0x185E38D30")]
	private void JMLMBLLNJMC(HNGHCMBBKEB BBGNHGDCHBO, CAKFEHOBCAO AJAFIOGCMHP, IKAJAHLJFMC MIPKLHDFLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public OCBEJBHBNEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(KPEDMHIOJHN), new string[] { })]
internal sealed class KPEDMHIOJHN : ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private BFCOAGBJGDN FNIMMOLDOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[DMNKPOGEHOO]
	private DDPCONHAGKM MNIFNPOEFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[DMNKPOGEHOO]
	private EKBKOBJCEAO NPKOEECOIIM;

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E33540", Offset = "0x5E32940", VA = "0x185E33540", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E333F0", Offset = "0x5E327F0", VA = "0x185E333F0")]
	public KLCLLLJMBOO GPLBOIIHMOK(KLCLLLJMBOO KPFNJKBFGEC, Allocator JIIMEDFKEME)
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E32CE0", Offset = "0x5E320E0", VA = "0x185E32CE0")]
	private void BNEAKDEGNPP(NativeParallelMultiHashMap<int, (CAKFEHOBCAO src, CAKFEHOBCAO dst)> CAOJMCBIGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E335F0", Offset = "0x5E329F0", VA = "0x185E335F0")]
	private void LDKDALLCHJK(NativeParallelMultiHashMap<int, (CAKFEHOBCAO src, CAKFEHOBCAO dst)> CAOJMCBIGOK, int HOAIKLJFCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E33230", Offset = "0x5E32630", VA = "0x185E33230")]
	private void EPGHKKKOEFE(NativeParallelMultiHashMap<int, (CAKFEHOBCAO src, CAKFEHOBCAO dst)> CAOJMCBIGOK, int HOAIKLJFCGK, BPMBFEJHHKF MJHCCCCPHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E32F10", Offset = "0x5E32310", VA = "0x185E32F10")]
	private NativeParallelMultiHashMap<int, (CAKFEHOBCAO, CAKFEHOBCAO)> CKEHMDJMPBP(Allocator JIIMEDFKEME, KLCLLLJMBOO KPFNJKBFGEC, [Out] KLCLLLJMBOO KNHCOJBKNJO)
	{
		return default(NativeParallelMultiHashMap<int, (CAKFEHOBCAO, CAKFEHOBCAO)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KPEDMHIOJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[AIFOCBABFAO(typeof(JFKNGONJIPL))]
[FHOIBFDAOOA(typeof(EPEIHHNCIHD), new string[] { })]
public class JFKNGONJIPL : EPEIHHNCIHD, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly FJOGIBEAJHF EGCFNGOIMJN;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly FJOGIBEAJHF EOBNMFDHMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private DDJENBEKAAO KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private LAKGPMMKLEK KMCCKENJIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private GMEBHOOMEDK PIKEAKJOJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private AOGMODGMOLB GIPHOGCOLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private HFHCOKNIOMB GIKKACIEGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private EntityManager OKNGAOGEIDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E7D0", Offset = "0x5E2DBD0", VA = "0x185E2E7D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E940", Offset = "0x5E2DD40", VA = "0x185E2E940", Slot = "34")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DF50", Offset = "0x5E2D350", VA = "0x185E2DF50", Slot = "35")]
	public bool DMFHNPPLLIH(Transform IJKPFNCIDCJ, [Out] CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DE90", Offset = "0x5E2D290", VA = "0x185E2DE90", Slot = "36")]
	public Transform DDPLAOKCOEG(Entity AHNNJNFIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E302A0", Offset = "0x5E2F6A0", VA = "0x185E302A0", Slot = "31")]
	public bool NHKFAJGADBA(Entity AHNNJNFIHFM, [Out] Transform IJKPFNCIDCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E670", Offset = "0x5E2DA70", VA = "0x185E2E670")]
	private void EMCJHBNIEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E309F0", Offset = "0x5E2FDF0", VA = "0x185E309F0", Slot = "30")]
	public void PIGNKMLMHMH(Entity AHNNJNFIHFM, [Out] float4x4 LOCOPBDKIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FD50", Offset = "0x5E2F150", VA = "0x185E2FD50", Slot = "4")]
	public void NABGKJCIJEJ(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E500", Offset = "0x5E2D900", VA = "0x185E2E500", Slot = "28")]
	public void EIGDCDLBOPD(Entity AHNNJNFIHFM, [Out] float4x4 LOCOPBDKIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FFD0", Offset = "0x5E2F3D0", VA = "0x185E2FFD0")]
	public void NCNCKLBNGKJ(Entity AHNNJNFIHFM, [In] float4x4 LOCOPBDKIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EB80", Offset = "0x5E2DF80", VA = "0x185E2EB80")]
	public void KDBAMBKBMAK(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E690", Offset = "0x5E2DA90", VA = "0x185E2E690", Slot = "6")]
	public float3 FOIMDLGHOPD(Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CE80", Offset = "0x5E2C280", VA = "0x185E2CE80")]
	public void JFOFKKNAHGL(Entity AHNNJNFIHFM, [In] quaternion LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E30520", Offset = "0x5E2F920", VA = "0x185E30520", Slot = "8")]
	public quaternion ONPCLDDJECM(Entity AHNNJNFIHFM)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DD60", Offset = "0x5E2D160", VA = "0x185E2DD60")]
	public void CNOCJDKBOFP(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E820", Offset = "0x5E2DC20", VA = "0x185E2E820", Slot = "12")]
	public float3 IJCHDLNCBKK(Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F160", Offset = "0x5E2E560", VA = "0x185E2F160", Slot = "15")]
	public float LODIFPINEAL(Entity AHNNJNFIHFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D450", Offset = "0x5E2C850", VA = "0x185E2D450", Slot = "14")]
	public void BMNKFONIFDG(Entity AHNNJNFIHFM, float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E30630", Offset = "0x5E2FA30", VA = "0x185E30630", Slot = "17")]
	public float3 PAICGNMPDGP(Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CFA0", Offset = "0x5E2C3A0", VA = "0x185E2CFA0")]
	public void BELDBNJGCLB(Entity AHNNJNFIHFM, [In] float3 NJDABNGLAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F440", Offset = "0x5E2E840", VA = "0x185E2F440", Slot = "9")]
	public void MGMFCEHDLMO(Entity AHNNJNFIHFM, [Out] float3 BAONBICGOEJ, [Out] quaternion CKFJFCLIANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F240", Offset = "0x5E2E640", VA = "0x185E2F240", Slot = "10")]
	public void MGMFCEHDLMO(Entity AHNNJNFIHFM, [Out] RigidTransform BLHLKIADHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E270", Offset = "0x5E2D670", VA = "0x185E2E270", Slot = "37")]
	public void ECIDLHAOAHH(Entity AHNNJNFIHFM, [Out] float3 BAONBICGOEJ, [Out] quaternion CKFJFCLIANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E250", Offset = "0x5E2D650", VA = "0x185E2E250", Slot = "11")]
	public void ECIDLHAOAHH(Entity AHNNJNFIHFM, [Out] RigidTransform BLHLKIADHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EA50", Offset = "0x5E2DE50", VA = "0x185E2EA50")]
	public void PBHFKJEOLIA(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ECB0", Offset = "0x5E2E0B0", VA = "0x185E2ECB0", Slot = "19")]
	public float3 KEGJIIGHKDE(Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D330", Offset = "0x5E2C730", VA = "0x185E2D330")]
	public void EBGIHCANICC(Entity AHNNJNFIHFM, [In] quaternion LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EF20", Offset = "0x5E2E320", VA = "0x185E2EF20", Slot = "21")]
	public quaternion LIEOCLOELCH(Entity AHNNJNFIHFM)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D120", Offset = "0x5E2C520", VA = "0x185E2D120")]
	public void BFPKHMPHDPM(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E308D0", Offset = "0x5E2FCD0", VA = "0x185E308D0", Slot = "22")]
	public float3 PDKBCNAGNHG(Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F5B0", Offset = "0x5E2E9B0", VA = "0x185E2F5B0", Slot = "24")]
	public void MIBBBHNADII(Entity AHNNJNFIHFM, float EIBBDGKHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E307F0", Offset = "0x5E2FBF0", VA = "0x185E307F0", Slot = "25")]
	public float PBIEAAPIOKH(Entity AHNNJNFIHFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F8E0", Offset = "0x5E2ECE0", VA = "0x185E2F8E0")]
	public void MJIGIMEJFKC(Entity AHNNJNFIHFM, [In] float3 KBLJNEAJGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E30390", Offset = "0x5E2F790", VA = "0x185E30390", Slot = "27")]
	public float3 OMNKCNNIGGI(Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D630", Offset = "0x5E2CA30", VA = "0x185E2D630", Slot = "32")]
	public void CEMCJLIKJOA(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E100", Offset = "0x5E2D500", VA = "0x185E2E100")]
	private CAKFEHOBCAO EAFAHKBIPGP(Transform IJKPFNCIDCJ)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CBF0", Offset = "0x5E2BFF0", VA = "0x185E2CBF0")]
	private static TransformEntity AKDDDJPDAKB(HNGHCMBBKEB DJMKKNDNCBM, GameObject DHIHKCPMIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2410320", Offset = "0x240F720", VA = "0x182410320")]
	private static T KJHGIJBOHMP<T>(GameObject DHIHKCPMIMH) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E30AA0", Offset = "0x5E2FEA0", VA = "0x185E30AA0", Slot = "33")]
	public void PLNILILGDLI(Entity AHNNJNFIHFM, Entity CLBKMLECIHH, Entity KJOCICNOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public JFKNGONJIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EB80", Offset = "0x5E2DF80", VA = "0x185E2EB80", Slot = "5")]
	private void MFEEHJBHLNK(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CE80", Offset = "0x5E2C280", VA = "0x185E2CE80", Slot = "7")]
	private void AOGJJBMGEPN(Entity AHNNJNFIHFM, [In] quaternion LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DD60", Offset = "0x5E2D160", VA = "0x185E2DD60", Slot = "13")]
	private void KJNHIKAFFLM(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CFA0", Offset = "0x5E2C3A0", VA = "0x185E2CFA0", Slot = "16")]
	private void APBAKIMOFHA(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EA50", Offset = "0x5E2DE50", VA = "0x185E2EA50", Slot = "18")]
	private void JEPCCFCEKCO(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D330", Offset = "0x5E2C730", VA = "0x185E2D330", Slot = "20")]
	private void BGPLFFJHLGK(Entity AHNNJNFIHFM, [In] quaternion LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E7C0", Offset = "0x5E2DBC0", VA = "0x185E2E7C0", Slot = "23")]
	private void GMOOEGICNLE(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CE70", Offset = "0x5E2C270", VA = "0x185E2CE70", Slot = "26")]
	private void ALCOBLCBBEK(Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E7B0", Offset = "0x5E2DBB0", VA = "0x185E2E7B0", Slot = "29")]
	private void GLHKODHCDEG(Entity AHNNJNFIHFM, [In] float4x4 BFDECFAPKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DPJJBKJCGHI
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F500", Offset = "0x5E1E900", VA = "0x185E1F500")]
	public static void AEPMACEOBCC(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] float3 EDOEDBAJLGN, [In] quaternion ALNLHNLOHOA, [In] float3 EAKOEGCEGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E22000", Offset = "0x5E21400", VA = "0x185E22000")]
	public static void PIGNKMLMHMH(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [Out] float4x4 LOCOPBDKIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E22120", Offset = "0x5E21520", VA = "0x185E22120")]
	private static void PIGNKMLMHMH(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, Entity DCLCDDGJKIC, [Out] float4x4 LOCOPBDKIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5E21130", Offset = "0x5E20530", VA = "0x185E21130")]
	public static void NCNCKLBNGKJ(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] float4x4 LOCOPBDKIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5E203B0", Offset = "0x5E1F7B0", VA = "0x185E203B0")]
	public static void JJNBNDPDPCL(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [Out] float4x4 GGNCKOFKBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5E21800", Offset = "0x5E20C00", VA = "0x185E21800")]
	public static void PAAKHKAJODP(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] float4x4 GGNCKOFKBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5E20120", Offset = "0x5E1F520", VA = "0x185E20120")]
	public static float3 FOIMDLGHOPD(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5E20760", Offset = "0x5E1FB60", VA = "0x185E20760")]
	public static void KDBAMBKBMAK(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5E21720", Offset = "0x5E20B20", VA = "0x185E21720")]
	public static quaternion ONPCLDDJECM(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5E202C0", Offset = "0x5E1F6C0", VA = "0x185E202C0")]
	public static void JFOFKKNAHGL(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] quaternion LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5E20210", Offset = "0x5E1F610", VA = "0x185E20210")]
	public static float3 IJCHDLNCBKK(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FB10", Offset = "0x5E1EF10", VA = "0x185E1FB10")]
	public static void CNOCJDKBOFP(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5E20B40", Offset = "0x5E1FF40", VA = "0x185E20B40")]
	public static float LODIFPINEAL(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FA60", Offset = "0x5E1EE60", VA = "0x185E1FA60")]
	public static void BMNKFONIFDG(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5E218D0", Offset = "0x5E20CD0", VA = "0x185E218D0")]
	public static float3 PAICGNMPDGP(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F740", Offset = "0x5E1EB40", VA = "0x185E1F740")]
	public static void BELDBNJGCLB(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5E20C10", Offset = "0x5E20010", VA = "0x185E20C10")]
	public static void MGMFCEHDLMO(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [Out] RigidTransform GGNCKOFKBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5E20CF0", Offset = "0x5E200F0", VA = "0x185E20CF0")]
	public static void MGMFCEHDLMO(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [Out] float3 BAONBICGOEJ, [Out] quaternion CKFJFCLIANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F5A0", Offset = "0x5E1E9A0", VA = "0x185E1F5A0")]
	public static void AHEEMEEPPJF(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] float3 EDOEDBAJLGN, [In] quaternion ALNLHNLOHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FF90", Offset = "0x5E1F390", VA = "0x185E1FF90")]
	public static void ECIDLHAOAHH(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [Out] float3 BAONBICGOEJ, [Out] quaternion CKFJFCLIANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5E20850", Offset = "0x5E1FC50", VA = "0x185E20850")]
	public static float3 KEGJIIGHKDE(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5E219B0", Offset = "0x5E20DB0", VA = "0x185E219B0")]
	public static void PBHFKJEOLIA(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FC00", Offset = "0x5E1F000", VA = "0x185E1FC00")]
	public static void EBGIHCANICC(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] quaternion LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5E209D0", Offset = "0x5E1FDD0", VA = "0x185E209D0")]
	public static quaternion LIEOCLOELCH(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5E21DE0", Offset = "0x5E211E0", VA = "0x185E21DE0")]
	public static float3 PDKBCNAGNHG(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F810", Offset = "0x5E1EC10", VA = "0x185E1F810")]
	public static void BFPKHMPHDPM(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5E21C00", Offset = "0x5E21000", VA = "0x185E21C00")]
	public static float PBIEAAPIOKH(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5E20E00", Offset = "0x5E20200", VA = "0x185E20E00")]
	public static void MIBBBHNADII(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, float EIBBDGKHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5E214C0", Offset = "0x5E208C0", VA = "0x185E214C0")]
	public static float3 OMNKCNNIGGI(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5E20F40", Offset = "0x5E20340", VA = "0x185E20F40")]
	public static void MJIGIMEJFKC(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [In] float3 KBLJNEAJGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F6A0", Offset = "0x5E1EAA0", VA = "0x185E1F6A0")]
	public static bool BDKDPOAGOND(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [Out] Entity DCLCDDGJKIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
[FHOIBFDAOOA(typeof(PIMLMDKAMKF), new string[] { })]
internal sealed class PIMLMDKAMKF : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[DMNKPOGEHOO]
	private MIHEJMLNMCP KDDNMNODBLK;

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C0F0", Offset = "0x5E3B4F0", VA = "0x185E3C0F0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C0A0", Offset = "0x5E3B4A0", VA = "0x185E3C0A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public PIMLMDKAMKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[FHOIBFDAOOA(typeof(PBAKHOFDHOO), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public class PBAKHOFDHOO
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct CDBDDBGKMHB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly PBAKHOFDHOO DCLCDDGJKIC;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C560", Offset = "0x5E1B960", VA = "0x185E1C560", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int PFAEEEOFMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[CompilerGenerated]
	private Action LCBLFKBIPKK;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AD30", Offset = "0x5E3A130", VA = "0x185E3AD30")]
	public void HDCGMIBNNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public PBAKHOFDHOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(DGCKHDEMBFP), new string[] { })]
public class DGCKHDEMBFP
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool GGJLDJABGMP;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool ENLBFFMNMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7B47D0", Offset = "0x7B3BD0", VA = "0x1807B47D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E610", Offset = "0x5E1DA10", VA = "0x185E1E610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public DGCKHDEMBFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[FHOIBFDAOOA(typeof(LGFADEDNMPD), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public class LGFADEDNMPD : ENDDIKHKCDF, KJICHBMECLA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private struct KLBIGEOAEHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private NativeArray<int> NCBCHOPNFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private NativeArray<int> FDAPJIJNFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private Dictionary<ComponentSystemBase, int> PCBKIOGGJDM;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5E31D30", Offset = "0x5E31130", VA = "0x185E31D30")]
		public KLBIGEOAEHN(NativeArray<int> NCBCHOPNFBB, NativeArray<int> FDAPJIJNFKC, Dictionary<ComponentSystemBase, int> PCBKIOGGJDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5E31C00", Offset = "0x5E31000", VA = "0x185E31C00")]
		public static void ODPDNNFOOOK(World KMPNHHILNIL, DPJKEJCGJEB JLCNHLEBDAG, NativeArray<int> NCBCHOPNFBB, NativeArray<int> FDAPJIJNFKC, Dictionary<ComponentSystemBase, int> PCBKIOGGJDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5E31910", Offset = "0x5E30D10", VA = "0x185E31910")]
		public void DKBGDCICJLF(IEnumerable<ComponentSystemBase> MCIPOELAAMA, DPJKEJCGJEB JLCNHLEBDAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class KPPHLIJAOHP : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private ComponentSystemBase <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public LGFADEDNMPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>3__start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>3__end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public KPPHLIJAOHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5E33AC0", Offset = "0x5E32EC0", VA = "0x185E33AC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5E33CA0", Offset = "0x5E330A0", VA = "0x185E33CA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5E33BF0", Offset = "0x5E32FF0", VA = "0x185E33BF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5E33BF0", Offset = "0x5E32FF0", VA = "0x185E33BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly FJOGIBEAJHF FNKGMDIPFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private World KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private FIMDMOFKGJF MHCBJGOCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private NativeArray<int> MPPHFPMFFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private NativeArray<int> BPGFLBGKKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private int KAHINILDCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private DPJKEJCGJEB DAGCBKCLBDD;

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5E34370", Offset = "0x5E33770", VA = "0x185E34370", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5E33E60", Offset = "0x5E33260", VA = "0x185E33E60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5E34450", Offset = "0x5E33850", VA = "0x185E34450")]
	[IteratorStateMachine(typeof(KPPHLIJAOHP))]
	private IEnumerable<ComponentSystemBase> JBHELBENJID(int CJJOHOENBLA, int KAABKEFBBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5E33EF0", Offset = "0x5E332F0", VA = "0x185E33EF0", Slot = "5")]
	public void GAPJGIMLFIN(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5E33EF0", Offset = "0x5E332F0", VA = "0x185E33EF0")]
	private void JHPCBOLPEGN(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5E344F0", Offset = "0x5E338F0", VA = "0x185E344F0")]
	public void JHPCBOLPEGN(DPJKEJCGJEB ECDJEINDOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5E33F70", Offset = "0x5E33370", VA = "0x185E33F70")]
	private void HMAPHCKMIJN(DPJKEJCGJEB ECDJEINDOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5E341F0", Offset = "0x5E335F0", VA = "0x185E341F0")]
	private void IBAHNCLPHNJ(DPJKEJCGJEB ECDJEINDOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5E34730", Offset = "0x5E33B30", VA = "0x185E34730")]
	private void LPJONDENGEN(DPJKEJCGJEB ECDJEINDOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5E346E0", Offset = "0x5E33AE0", VA = "0x185E346E0")]
	private void LIFGPBECMMK(int CJJOHOENBLA, int KAABKEFBBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5E33CF0", Offset = "0x5E330F0", VA = "0x185E33CF0")]
	private void CNOOJKLJJDP(int CJJOHOENBLA, int KAABKEFBBLK, bool GGJLDJABGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5E33ED0", Offset = "0x5E332D0", VA = "0x185E33ED0")]
	private int FPLHINFDMHF(DPJKEJCGJEB ECDJEINDOON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5E348B0", Offset = "0x5E33CB0", VA = "0x185E348B0")]
	private bool OKBCGIKCDJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5E347C0", Offset = "0x5E33BC0", VA = "0x185E347C0")]
	private Dictionary<ComponentSystemBase, int> NCAKNOGDHKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5E346A0", Offset = "0x5E33AA0", VA = "0x185E346A0")]
	private void KLMAMDJGLHC(NativeArray<int> NCBCHOPNFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5E33DB0", Offset = "0x5E331B0", VA = "0x185E33DB0")]
	private void DCKJOJLLBHB(NativeArray<int> FDAPJIJNFKC, NativeArray<int> NCBCHOPNFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5E34310", Offset = "0x5E33710", VA = "0x185E34310")]
	private static DPJKEJCGJEB IKAJFBOLFII(Type DJMKKNDNCBM, DPJKEJCGJEB HBPJMDHPOKO)
	{
		return default(DPJKEJCGJEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5E34F30", Offset = "0x5E34330", VA = "0x185E34F30")]
	public LGFADEDNMPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5E342B0", Offset = "0x5E336B0", VA = "0x185E342B0")]
	[CompilerGenerated]
	private void IILGBJDHAKH(ENDDIKHKCDF DAAGIBDGGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x5E34640", Offset = "0x5E33A40", VA = "0x185E34640")]
	[CompilerGenerated]
	private void KJLNAAHBBJJ(ICKLGHMJPBB DAAGIBDGGJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[FHOIBFDAOOA(typeof(KBADIJFHJMJ), new string[] { })]
public class GJLENADFHLO : ENDDIKHKCDF, KBADIJFHJMJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[DMNKPOGEHOO]
	private JFKABFIKFCO BADPICBHGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[DMNKPOGEHOO]
	private MOHMCBFIKAN FANNEIHEMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[DMNKPOGEHOO]
	private EOAILPGBNIC KDIOGGCJKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[DMNKPOGEHOO]
	private AOGMODGMOLB IIGCFGNJAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[DMNKPOGEHOO]
	private EJAPLNPOEKH JMLFNACGIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private World FGAELHLIPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private JIEKBFCOBFM GJJMEKKGKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private JIEKBFCOBFM AECHBHGDAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private JIEKBFCOBFM KEENBNJPIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private JIEKBFCOBFM ICAPANOBBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JIEKBFCOBFM FOKPOGJLHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private JIEKBFCOBFM BGAOBEIHKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private JIEKBFCOBFM NMCNKNGBPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private JIEKBFCOBFM HBNIJJOJNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private JIEKBFCOBFM BGPELNPECAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private JIEKBFCOBFM KKHPNOGDCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private JIEKBFCOBFM PFKENHAMKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private JIEKBFCOBFM GEPOILJMJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private JIEKBFCOBFM AOINPNFOLKI;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private bool HEBBEMBFBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5E26EF0", Offset = "0x5E262F0", VA = "0x185E26EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private bool AIJGFDMGGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5E27860", Offset = "0x5E26C60", VA = "0x185E27860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private bool GBFDJJGHPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5E26C50", Offset = "0x5E26050", VA = "0x185E26C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private bool AJBFABBALKD
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5E26C50", Offset = "0x5E26050", VA = "0x185E26C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5E26FF0", Offset = "0x5E263F0", VA = "0x185E26FF0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x23C9E30", Offset = "0x23C9230", VA = "0x1823C9E30")]
	private JIEKBFCOBFM CFDAHOBDPKD<T>() where T : GJIBNPODALO
	{
		return default(JIEKBFCOBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5E26EC0", Offset = "0x5E262C0", VA = "0x185E26EC0")]
	private JIEKBFCOBFM CFDAHOBDPKD(Type DJMKKNDNCBM)
	{
		return default(JIEKBFCOBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5E27810", Offset = "0x5E26C10", VA = "0x185E27810", Slot = "14")]
	public void LFKINDAJIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5E278F0", Offset = "0x5E26CF0", VA = "0x185E278F0", Slot = "15")]
	public void NKMOAHAEANH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5E27840", Offset = "0x5E26C40", VA = "0x185E27840", Slot = "5")]
	public void LKNAKEALBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5E26E40", Offset = "0x5E26240", VA = "0x185E26E40", Slot = "6")]
	public void BOLHLDCHAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5E27400", Offset = "0x5E26800", VA = "0x185E27400", Slot = "7")]
	public void KCKEIALFJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5E26DC0", Offset = "0x5E261C0", VA = "0x185E26DC0", Slot = "8")]
	public void BJBJNHGALAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5E26D40", Offset = "0x5E26140", VA = "0x185E26D40", Slot = "9")]
	public void BDNJCEPJADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x5E26C60", Offset = "0x5E26060", VA = "0x185E26C60", Slot = "10")]
	public void BACIAADNNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x5E26F70", Offset = "0x5E26370", VA = "0x185E26F70", Slot = "11")]
	public void FHGBMPAHFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x5E277D0", Offset = "0x5E26BD0", VA = "0x185E277D0", Slot = "12")]
	public void LCCHJDLAEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5E27480", Offset = "0x5E26880", VA = "0x185E27480", Slot = "13")]
	public void KHFJBIHOHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x5E27920", Offset = "0x5E26D20", VA = "0x185E27920")]
	private void PCHACAMPKFH(JIEKBFCOBFM FIPLOBJLBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5E279B0", Offset = "0x5E26DB0", VA = "0x185E279B0")]
	private void POGGLGEEACN(JIEKBFCOBFM FIPLOBJLBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5E278D0", Offset = "0x5E26CD0", VA = "0x185E278D0")]
	private void NJILJMMFAAF(JIEKBFCOBFM FIPLOBJLBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public GJLENADFHLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal readonly struct JIEKBFCOBFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly ComponentSystemBase FIPLOBJLBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly ProfilerMarker FMHCJMMNHOF;

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5E31200", Offset = "0x5E30600", VA = "0x185E31200")]
	public JIEKBFCOBFM(World KMPNHHILNIL, Type DJMKKNDNCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5E31130", Offset = "0x5E30530", VA = "0x185E31130")]
	public void NJILJMMFAAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[FHOIBFDAOOA(typeof(HONAKLLNIOE), new string[] { })]
public class NAMKKGIMMIG : HONAKLLNIOE, IDisposable, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[DMNKPOGEHOO]
	private JEKOGBJNELB LLODMBLJFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[DMNKPOGEHOO]
	private KFIGKCHPCDA KGLLDELCPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private World FGAELHLIPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private World GFDIPPMMOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool COMHOKDBICG;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public World KMONKLDHPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public World CACIINNIHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5E36D60", Offset = "0x5E36160", VA = "0x185E36D60", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x35BCFF0", Offset = "0x35BC3F0", VA = "0x1835BCFF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x5E36BC0", Offset = "0x5E35FC0", VA = "0x185E36BC0", Slot = "10")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x5E36D80", Offset = "0x5E36180", VA = "0x185E36D80")]
	private void PJBIIEEDKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5E368F0", Offset = "0x5E35CF0", VA = "0x185E368F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5E368D0", Offset = "0x5E35CD0", VA = "0x185E368D0", Slot = "8")]
	public ComponentSystemBase CFDAHOBDPKD(Type DJMKKNDNCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public NAMKKGIMMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(NBCBHHFNMNI), new string[] { })]
public class NBCBHHFNMNI : PNLMNOEHBNA, BJJLPKDABKC, IFKHMGNDLHA, ENDDIKHKCDF, ICKLGHMJPBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class AFGMHEIPLBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public FIMDMOFKGJF services;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public AFGMHEIPLBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x5E175B0", Offset = "0x5E169B0", VA = "0x185E175B0")]
		internal void KNCBCFFGAMF(ENDDIKHKCDF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CLMLEEKMAOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public FIMDMOFKGJF services;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CLMLEEKMAOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C5A0", Offset = "0x5E1B9A0", VA = "0x185E1C5A0")]
		internal void IHBIHELANHE(ICKLGHMJPBB svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[DMNKPOGEHOO]
	private MIEDEIBEABA GPCCKMGNMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[DMNKPOGEHOO]
	private EKBKOBJCEAO DIHODDBACDE;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public PKBFGGPEDBK EPEIEKGKMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x937FA0", Offset = "0x9373A0", VA = "0x180937FA0", Slot = "4")]
		get
		{
			return default(PKBFGGPEDBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5E37220", Offset = "0x5E36620", VA = "0x185E37220", Slot = "5")]
	public void KLMMKHHBOHM(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5E372B0", Offset = "0x5E366B0", VA = "0x185E372B0", Slot = "6")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x5E37140", Offset = "0x5E36540", VA = "0x185E37140", Slot = "7")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x5E37060", Offset = "0x5E36460", VA = "0x185E37060", Slot = "8")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5E36F40", Offset = "0x5E36340", VA = "0x185E36F40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x24DFC00", Offset = "0x24DF000", VA = "0x1824DFC00")]
	private void KJJJAAKECGD<T>(Action<T> BMNGNEENDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public NBCBHHFNMNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[FHOIBFDAOOA(typeof(KHBOFPBPOBG), new string[] { })]
[DefaultMember("Item")]
public class PIAAHDHCEPD : KHBOFPBPOBG, IEnumerable<BLKKNKJIPKI>, IEnumerable, BJJLPKDABKC, IFKHMGNDLHA, ENDDIKHKCDF, ICKLGHMJPBB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[DMNKPOGEHOO]
	private HHNNJBNMMAM MJHCCCCPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Dictionary<(Type, string), int> CPIHCCBHJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeBitArray DFGFFDNPMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> IFLCLJCALCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NOODCLKDFOP HNKLFHJGMGH;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public NativeBitArray GMPIOECNCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xD6E3E0", Offset = "0xD6D7E0", VA = "0x180D6E3E0", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public NativeArray<int> GKAAKCHBNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xD230A0", Offset = "0xD224A0", VA = "0x180D230A0", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private int OAMPDHOLIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x829240", Offset = "0x828640", VA = "0x180829240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BB90", Offset = "0x5E3AF90", VA = "0x185E3BB90", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public BLKKNKJIPKI ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B1F0", Offset = "0x5E3A5F0", VA = "0x185E3B1F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public BLKKNKJIPKI ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B1F0", Offset = "0x5E3A5F0", VA = "0x185E3B1F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BDA0", Offset = "0x5E3B1A0", VA = "0x185E3BDA0", Slot = "13")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BD20", Offset = "0x5E3B120", VA = "0x185E3BD20", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "15")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B260", Offset = "0x5E3A660", VA = "0x185E3B260")]
	private void GDPEBIBEFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BDF0", Offset = "0x5E3B1F0", VA = "0x185E3BDF0", Slot = "9")]
	public BLKKNKJIPKI OHHBJJNGNKB(AMAMFBGBCKA OKJGMJDJMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BBD0", Offset = "0x5E3AFD0", VA = "0x185E3BBD0")]
	private bool IPAPMODNFND(Type GHMPLAHPDJK, string DKFEAPHKBMP, [Out] BLKKNKJIPKI AGIINHOJANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AFC0", Offset = "0x5E3A3C0", VA = "0x185E3AFC0", Slot = "10")]
	public NHGDGBFBAIF DCIEGAAPHFM(AMAMFBGBCKA OKJGMJDJMMC)
	{
		return default(NHGDGBFBAIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BBB0", Offset = "0x5E3AFB0", VA = "0x185E3BBB0", Slot = "11")]
	public IEnumerator<BLKKNKJIPKI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BBB0", Offset = "0x5E3AFB0", VA = "0x185E3BBB0", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B210", Offset = "0x5E3A610", VA = "0x185E3B210", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BFA0", Offset = "0x5E3B3A0", VA = "0x185E3BFA0")]
	public PIAAHDHCEPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[FHOIBFDAOOA(typeof(EGMLFPKLELH), new string[] { })]
[DefaultMember("Item")]
public class DPABOFMJMPD : EGMLFPKLELH, IEnumerable<DNHFDIEHCPF>, IEnumerable, BJJLPKDABKC, IFKHMGNDLHA, ENDDIKHKCDF, ICKLGHMJPBB, AJBOGAKBDLF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[DMNKPOGEHOO]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[DMNKPOGEHOO]
	private KHBOFPBPOBG NCJPABNBAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private DNHFDIEHCPF[] JCGGHHPIHBN;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5323FB0", Offset = "0x53233B0", VA = "0x185323FB0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public DNHFDIEHCPF ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EEA0", Offset = "0x5E1E2A0", VA = "0x185E1EEA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "10")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F0E0", Offset = "0x5E1E4E0", VA = "0x185E1F0E0", Slot = "11")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "12")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F3C0", Offset = "0x5E1E7C0", VA = "0x185E1F3C0", Slot = "6")]
	public DNHFDIEHCPF OHHBJJNGNKB(AMAMFBGBCKA OKJGMJDJMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EDD0", Offset = "0x5E1E1D0", VA = "0x185E1EDD0", Slot = "7")]
	public NHGDGBFBAIF DCIEGAAPHFM(AMAMFBGBCKA OKJGMJDJMMC)
	{
		return default(NHGDGBFBAIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F000", Offset = "0x5E1E400", VA = "0x185E1F000", Slot = "8")]
	public IEnumerator<DNHFDIEHCPF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F4E0", Offset = "0x5E1E8E0", VA = "0x185E1F4E0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x222B480", Offset = "0x222A880", VA = "0x18222B480", Slot = "13")]
	public void JIOPANEDDHL<TKey, T>(JIMDNDNBHNB<TKey, T> OIBKEMMFJDM, [Optional] object CNKGFJIJGPA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EED0", Offset = "0x5E1E2D0", VA = "0x185E1EED0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public DPABOFMJMPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EEA0", Offset = "0x5E1E2A0", VA = "0x185E1EEA0")]
	[CompilerGenerated]
	private DNHFDIEHCPF KMOJKKFDCKH(int PBOOCHALMNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DefaultMember("Item")]
[FHOIBFDAOOA(typeof(DFLIKLKNDFH), new string[] { })]
public class BDFJLIPPKCF : DFLIKLKNDFH, IEnumerable<LJEACGFBGAF>, IEnumerable, ENDDIKHKCDF, ICKLGHMJPBB, AJBOGAKBDLF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[DMNKPOGEHOO]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[DMNKPOGEHOO]
	private KHBOFPBPOBG NCJPABNBAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private LJEACGFBGAF[] JCGGHHPIHBN;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E17B40", Offset = "0x5E16F40", VA = "0x185E17B40", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public LJEACGFBGAF ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E177F0", Offset = "0x5E16BF0", VA = "0x185E177F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5E17CA0", Offset = "0x5E170A0", VA = "0x185E17CA0", Slot = "10")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E178A0", Offset = "0x5E16CA0", VA = "0x185E178A0", Slot = "11")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E17D10", Offset = "0x5E17110", VA = "0x185E17D10")]
	private LJEACGFBGAF LKPCMKMFMBO(int JPEMHHILGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E17DD0", Offset = "0x5E171D0", VA = "0x185E17DD0", Slot = "6")]
	public LJEACGFBGAF OHHBJJNGNKB(AMAMFBGBCKA OKJGMJDJMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E17720", Offset = "0x5E16B20", VA = "0x185E17720", Slot = "7")]
	public NHGDGBFBAIF DCIEGAAPHFM(AMAMFBGBCKA OKJGMJDJMMC)
	{
		return default(NHGDGBFBAIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E17B90", Offset = "0x5E16F90", VA = "0x185E17B90", Slot = "8")]
	public IEnumerator<LJEACGFBGAF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E17B90", Offset = "0x5E16F90", VA = "0x185E17B90", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2189270", Offset = "0x2188670", VA = "0x182189270", Slot = "12")]
	public void JIOPANEDDHL<TKey, T>(JIMDNDNBHNB<TKey, T> OIBKEMMFJDM, [Optional] object CNKGFJIJGPA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E17800", Offset = "0x5E16C00", VA = "0x185E17800", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public BDFJLIPPKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E177F0", Offset = "0x5E16BF0", VA = "0x185E177F0")]
	[CompilerGenerated]
	private LJEACGFBGAF KMOJKKFDCKH(int PBOOCHALMNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[FHOIBFDAOOA(typeof(HHNNJBNMMAM), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal class HHNNJBNMMAM : ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private KHBOFPBPOBG NCJPABNBAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private DFLIKLKNDFH BMPKJPJJNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private EGMLFPKLELH CCNALECNDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[DMNKPOGEHOO]
	private EKBKOBJCEAO DIHODDBACDE;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public NOODCLKDFOP JHEIIOBOIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x767760", Offset = "0x766B60", VA = "0x180767760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BE10", Offset = "0x5E2B210", VA = "0x185E2BE10", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BD70", Offset = "0x5E2B170", VA = "0x185E2BD70")]
	private void HAFAMLNLJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BF60", Offset = "0x5E2B360", VA = "0x185E2BF60")]
	public BLKKNKJIPKI MICEFGOAENO(AMAMFBGBCKA DKFEAPHKBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x23DB780", Offset = "0x23DAB80", VA = "0x1823DB780")]
	public KKKAPFIEENB<T> HKOKKEDOCIJ<T>(AMAMFBGBCKA DKFEAPHKBMP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public HHNNJBNMMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal static class OPDKNPALHMF
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x253BCD0", Offset = "0x253B0D0", VA = "0x18253BCD0")]
	public static MKIKBAICGGB<T> MICEFGOAENO<T>(this HHNNJBNMMAM PLCJOCGPCHN, EMNGLKONKEK<T> DKFEAPHKBMP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[FHOIBFDAOOA(typeof(EJAPLNPOEKH), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
public class EJAPLNPOEKH : IFKHMGNDLHA, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[DMNKPOGEHOO]
	private OMMEEFHEKMM OCNOLDKMEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private bool MDHMEAKGABH;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public TimeData AFJAGFPAEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E23980", Offset = "0x5E22D80", VA = "0x185E23980")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E23830", Offset = "0x5E22C30", VA = "0x185E23830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool MDKMJBLKILM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x804D90", Offset = "0x804190", VA = "0x180804D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xB67990", Offset = "0xB66D90", VA = "0x180B67990", Slot = "4")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E23890", Offset = "0x5E22C90", VA = "0x185E23890", Slot = "5")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E238E0", Offset = "0x5E22CE0", VA = "0x185E238E0")]
	public void KIOJNBIJBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	public void IAODCLEONAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public EJAPLNPOEKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(KLNNOPHINFN), new string[] { })]
public class KLNNOPHINFN : ENDDIKHKCDF, ICKLGHMJPBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private DJOMFACBNME IEDKLDPPILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private EGMLFPKLELH MJHCCCCPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NHGDGBFBAIF[] KAIKGFNJMOB;

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E320D0", Offset = "0x5E314D0", VA = "0x185E320D0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E31D50", Offset = "0x5E31150", VA = "0x185E31D50", Slot = "5")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E31FB0", Offset = "0x5E313B0", VA = "0x185E31FB0")]
	public void HDKNPKBNGLK(IKAJAHLJFMC MIPKLHDFLBO, bool FBAJBADKNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KLNNOPHINFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[FHOIBFDAOOA(typeof(JIJFKEDMCGO), new string[] { })]
public sealed class FLIEEDEJJPH : JIJFKEDMCGO, BJJLPKDABKC, IFKHMGNDLHA, ENDDIKHKCDF, ICKLGHMJPBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JPCGCOEAAJI : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x93E0D0", Offset = "0x93D4D0", VA = "0x18093E0D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x5E316B0", Offset = "0x5E30AB0", VA = "0x185E316B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1B2BE70", Offset = "0x1B2B270", VA = "0x181B2BE70")]
		[DebuggerHidden]
		public JPCGCOEAAJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E313C0", Offset = "0x5E307C0", VA = "0x185E313C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E31660", Offset = "0x5E30A60", VA = "0x185E31660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E315B0", Offset = "0x5E309B0", VA = "0x185E315B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E315B0", Offset = "0x5E309B0", VA = "0x185E315B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[DMNKPOGEHOO]
	private DFLIKLKNDFH MJHCCCCPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly HPPKKFEODPC FDMMDBKBMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Dictionary<string, AIEGHBJFDHC> IKGAKKPFBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Dictionary<int, IBNGANGAIIG> KGNHPJEKGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly List<LJEACGFBGAF> JFKAAMFALMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private MJHGFDFFPLH MGJAOFDCMDC;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IBNGANGAIIG CAHOKKAJPFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5E25E30", Offset = "0x5E25230", VA = "0x185E25E30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public List<LJEACGFBGAF> OJCNEHAEBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "9")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E26230", Offset = "0x5E25630", VA = "0x185E26230", Slot = "10")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E25CA0", Offset = "0x5E250A0", VA = "0x185E25CA0", Slot = "11")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E25BF0", Offset = "0x5E24FF0", VA = "0x185E25BF0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E26910", Offset = "0x5E25D10", VA = "0x185E26910", Slot = "6")]
	public bool PANMBMJOILD(LJEACGFBGAF OIBKEMMFJDM, [Out] IBNGANGAIIG DMBGGOLNLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E25730", Offset = "0x5E24B30", VA = "0x185E25730")]
	private void BFHCGFCENEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E265C0", Offset = "0x5E259C0", VA = "0x185E265C0")]
	private void MPONCHMNIGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E26290", Offset = "0x5E25690", VA = "0x185E26290")]
	private AIEGHBJFDHC KAGEMFAONMI(string NFFEJPHMJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E25E30", Offset = "0x5E25230", VA = "0x185E25E30")]
	private AIEGHBJFDHC HFLPPBJKKCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E25E90", Offset = "0x5E25290", VA = "0x185E25E90")]
	private AIEGHBJFDHC HFAIBNOKGFI(string NFFEJPHMJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E263D0", Offset = "0x5E257D0", VA = "0x185E263D0")]
	private AIEGHBJFDHC MLNPNDBHHPH(string EOEPLCPMJAO, string IBLOMPOENGH, [Optional] AIEGHBJFDHC LGGGAKBOBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E25D00", Offset = "0x5E25100", VA = "0x185E25D00")]
	[IteratorStateMachine(typeof(JPCGCOEAAJI))]
	private IEnumerable<(string, string)> EMDOFNENIND(string NFFEJPHMJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E26150", Offset = "0x5E25550", VA = "0x185E26150")]
	private bool IBNFKGCIPGK(LJEACGFBGAF OIBKEMMFJDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E25B10", Offset = "0x5E24F10", VA = "0x185E25B10")]
	private HPPKKFEODPC BNPFGCJEAIM(LJEACGFBGAF OIBKEMMFJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E262F0", Offset = "0x5E256F0", VA = "0x185E262F0")]
	private HPPKKFEODPC KDMDHIJLBDK(LJEACGFBGAF OIBKEMMFJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E261A0", Offset = "0x5E255A0", VA = "0x185E261A0")]
	private HPPKKFEODPC ICFOEFMFCHK(LJEACGFBGAF OIBKEMMFJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x23B9F60", Offset = "0x23B9360", VA = "0x1823B9F60")]
	private T NGLGNBPIKLE<T>(LJEACGFBGAF OIBKEMMFJDM) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E26820", Offset = "0x5E25C20", VA = "0x185E26820")]
	private FieldInfo PAHGPOOAGFA(LJEACGFBGAF OIBKEMMFJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E25D80", Offset = "0x5E25180", VA = "0x185E25D80", Slot = "7")]
	public void GFCMFFOEFBO(LJEACGFBGAF OIBKEMMFJDM, GGCLCHAMHEE LNKIKCGJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E26770", Offset = "0x5E25B70", VA = "0x185E26770", Slot = "8")]
	public void OOFKJBAJEMO(LJEACGFBGAF OIBKEMMFJDM, GGCLCHAMHEE LNKIKCGJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E269A0", Offset = "0x5E25DA0", VA = "0x185E269A0")]
	public FLIEEDEJJPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E26340", Offset = "0x5E25740", VA = "0x185E26340")]
	[CompilerGenerated]
	private int MBNBIEIMPCI(LJEACGFBGAF BOGGCLFEFDJ, LJEACGFBGAF OGHJEHJOFGN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class AIEGHBJFDHC : IBNGANGAIIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public readonly string CGABEIGNIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public readonly AIEGHBJFDHC LGGGAKBOBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public readonly List<AIEGHBJFDHC> LJCCNGOCCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public readonly List<LJEACGFBGAF> MJHCCCCPHBO;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public string HCFDKLNAKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public IBNGANGAIIG NEGNKOPKGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IEnumerable<IBNGANGAIIG> DFNLKFGGGAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E17610", Offset = "0x5E16A10", VA = "0x185E17610")]
	public AIEGHBJFDHC(string DKFEAPHKBMP, AIEGHBJFDHC DCLCDDGJKIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[FHOIBFDAOOA(typeof(global::CNJPIPKMIKP), new string[] { })]
internal class BHNKOGNHOOK : global::CNJPIPKMIKP, ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[DMNKPOGEHOO]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[DMNKPOGEHOO]
	private GMEBHOOMEDK PIKEAKJOJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	[DMNKPOGEHOO]
	private HHNNJBNMMAM MJHCCCCPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	[DMNKPOGEHOO]
	private MJHGFDFFPLH FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Action<OGALCPHBFJB> AIBILCAOCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private MKIKBAICGGB<Entity> DCLCDDGJKIC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<OGALCPHBFJB> HBOMIODELKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C000", Offset = "0x5E1B400", VA = "0x185E1C000", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C380", Offset = "0x5E1B780", VA = "0x185E1C380", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C1F0", Offset = "0x5E1B5F0", VA = "0x185E1C1F0", Slot = "6")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BE90", Offset = "0x5E1B290", VA = "0x185E1BE90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C000", Offset = "0x5E1B400", VA = "0x185E1C000")]
	private void OKFACJNGNPK(Action<OGALCPHBFJB> LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C380", Offset = "0x5E1B780", VA = "0x185E1C380")]
	private void NNFCOIOCLKJ(Action<OGALCPHBFJB> LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C180", Offset = "0x5E1B580", VA = "0x185E1C180")]
	private void ENBFILCCGAL(DMMDOJFOBIA OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public BHNKOGNHOOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
[FHOIBFDAOOA(typeof(PBCBPEPOEFI), new string[] { })]
public class PBCBPEPOEFI : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	[DMNKPOGEHOO]
	private DGCKHDEMBFP EMJCANGJNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[DMNKPOGEHOO]
	private LGFADEDNMPD KEDGGGOBOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[DMNKPOGEHOO]
	private BNKPHKHKLHD CNIFLPLFONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[DMNKPOGEHOO]
	private HFHCOKNIOMB LKCOHANNNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ADA0", Offset = "0x5E3A1A0", VA = "0x185E3ADA0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AD50", Offset = "0x5E3A150", VA = "0x185E3AD50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AEE0", Offset = "0x5E3A2E0", VA = "0x185E3AEE0")]
	private void JMFBONKAKJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AD50", Offset = "0x5E3A150", VA = "0x185E3AD50")]
	private void JNDMPFGPNEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AF70", Offset = "0x5E3A370", VA = "0x185E3AF70")]
	private void KDCNHLFHFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public PBCBPEPOEFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[FHOIBFDAOOA(typeof(DPIEMLJJLCJ), new string[] { })]
public class EDIMNKCMJKO : DPIEMLJJLCJ, ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[DMNKPOGEHOO]
	private CDJJECGMMII GKEPNPGEJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[DMNKPOGEHOO]
	private BOJOADFJNML PCCBNHMLCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly List<NativeListAsync<Entity>> JHMGNBLFIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly List<(NativeListAsync<Entity>, bool)> MMCCPEIHMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private GPEGLENBLNP COLMKMGNEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private Dictionary<Entity, KECPHEPKDGP> KCFIHFEKONI;

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E23360", Offset = "0x5E22760", VA = "0x185E23360", Slot = "8")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E23050", Offset = "0x5E22450", VA = "0x185E23050", Slot = "4")]
	public void FKCCMDIBFII(NativeListAsync<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E22A40", Offset = "0x5E21E40", VA = "0x185E22A40", Slot = "5")]
	public void CGMFLODOOOF(GPEGLENBLNP COLMKMGNEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E22A90", Offset = "0x5E21E90", VA = "0x185E22A90", Slot = "6")]
	public void DKCAMGDLMPC(NativeListAsync<Entity> JIBDNODJOAB, bool HLBLIGNGLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E22420", Offset = "0x5E21820", VA = "0x185E22420", Slot = "7")]
	public void ANPJEGGEMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E22BC0", Offset = "0x5E21FC0", VA = "0x185E22BC0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E23420", Offset = "0x5E22820", VA = "0x185E23420")]
	private int PFALGPIBLKG(NativeListAsync<Entity> JHMGNBLFIOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E227A0", Offset = "0x5E21BA0", VA = "0x185E227A0")]
	private int BKDCGNPAFCI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E23120", Offset = "0x5E22520", VA = "0x185E23120")]
	private int HHIDCCPJEJI(NativeListAsync<Entity> MMCCPEIHMDG, bool KLIGAFICGJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E23710", Offset = "0x5E22B10", VA = "0x185E23710")]
	public EDIMNKCMJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E233D0", Offset = "0x5E227D0", VA = "0x185E233D0")]
	[CompilerGenerated]
	private CAKFEHOBCAO MGHHNGDEHFH(Entity AHNNJNFIHFM)
	{
		return default(CAKFEHOBCAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[FHOIBFDAOOA(typeof(PMGCPLLNMOO), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public class PMGCPLLNMOO : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly List<NativeListAsync<OMALCGLLKKB>> OEABJNDFPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C7A0", Offset = "0x5E3BBA0", VA = "0x185E3C7A0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C7F0", Offset = "0x5E3BBF0", VA = "0x185E3C7F0")]
	public void NGABFNEGIAC(NativeListAsync<OMALCGLLKKB> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C1A0", Offset = "0x5E3B5A0", VA = "0x185E3C1A0")]
	public void ABDKKMAPHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C620", Offset = "0x5E3BA20", VA = "0x185E3C620", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C950", Offset = "0x5E3BD50", VA = "0x185E3C950")]
	public PMGCPLLNMOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[FHOIBFDAOOA(typeof(AEMEMLHFPNC), new string[] { })]
public class IDKNOMAKLEC : ENDDIKHKCDF, AEMEMLHFPNC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private NGDPKGKNNBP BNEEDBKPFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private BOJOADFJNML PCCBNHMLCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C540", Offset = "0x5E2B940", VA = "0x185E2C540", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C400", Offset = "0x5E2B800", VA = "0x185E2C400", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C410", Offset = "0x5E2B810", VA = "0x185E2C410", Slot = "5")]
	public bool HAOMAKBHCDC(CAKFEHOBCAO AJAFIOGCMHP, [Out] Collider MHOODELGFIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C030", Offset = "0x5E2B430", VA = "0x185E2C030", Slot = "6")]
	public GameObject BLDIONAMLBD(CAKFEHOBCAO JABLJFLILAM, GameObject LCCDMMMBGLD, Vector3 EDOEDBAJLGN, Quaternion ALNLHNLOHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C220", Offset = "0x5E2B620", VA = "0x185E2C220", Slot = "7")]
	public void DAKCHAFEEID(GameObject MHOODELGFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x23F5CB0", Offset = "0x23F50B0", VA = "0x1823F5CB0", Slot = "8")]
	public TCollider EHEDNJODCKJ<TCollider>(GameObject OAMKKHHFDEP) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C330", Offset = "0x5E2B730", VA = "0x185E2C330", Slot = "9")]
	public void DJENMLKKBFO(Collider MHOODELGFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x23F5CB0", Offset = "0x23F50B0", VA = "0x1823F5CB0", Slot = "10")]
	public GameObject ADFIBOODNIO<TCollider>(string DKFEAPHKBMP) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public IDKNOMAKLEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[FHOIBFDAOOA(typeof(CAMBFJGGDMI), new string[] { })]
public class GODHGLMEEJP : ENDDIKHKCDF, CAMBFJGGDMI
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class JEFPMLMDFAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public CAKFEHOBCAO localId;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public JEFPMLMDFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CCD0", Offset = "0x5E4C0D0", VA = "0x185E4CCD0")]
		internal object ENLPPPMKPBA(GODHGLMEEJP a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FGEOMBGCKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public CAKFEHOBCAO localId;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public FGEOMBGCKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x5E47700", Offset = "0x5E46B00", VA = "0x185E47700")]
		internal object FONCLELCAGJ(GODHGLMEEJP a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private EPEIHHNCIHD EHJFODOFCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private World KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private OACDJAJNOAN BCGPINDEONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[DMNKPOGEHOO]
	private OMMEEFHEKMM OCNOLDKMEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private EntityManager NLGDANGGHAL;

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A400", Offset = "0x5E29800", VA = "0x185E2A400", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5E287A0", Offset = "0x5E27BA0", VA = "0x185E287A0", Slot = "6")]
	public EOMJBFBJHKL BKOIEMKCJEN(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A2A0", Offset = "0x5E296A0", VA = "0x185E2A2A0", Slot = "5")]
	public void IOIPLAFKPLK(CAKFEHOBCAO AJAFIOGCMHP, EOMJBFBJHKL LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5E29260", Offset = "0x5E28660", VA = "0x185E29260", Slot = "31")]
	public CollisionDetectionMode EJCELKLFNLG(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5E28420", Offset = "0x5E27820", VA = "0x185E28420", Slot = "32")]
	public void BBABGNHNKPH(CAKFEHOBCAO AJAFIOGCMHP, CollisionDetectionMode LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x5E29690", Offset = "0x5E28A90", VA = "0x185E29690", Slot = "33")]
	public LHMMHIJEJEH FMEHBDDLJIJ(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(LHMMHIJEJEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5E292F0", Offset = "0x5E286F0", VA = "0x185E292F0", Slot = "34")]
	public void FAOBFHNDNPE(CAKFEHOBCAO AJAFIOGCMHP, LHMMHIJEJEH LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B4D0", Offset = "0x5E2A8D0", VA = "0x185E2B4D0", Slot = "35")]
	public bool NGCBGDFHEAM(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5E28580", Offset = "0x5E27980", VA = "0x185E28580", Slot = "36")]
	public void BGENHPEAHBJ(CAKFEHOBCAO AJAFIOGCMHP, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A1C0", Offset = "0x5E295C0", VA = "0x185E2A1C0", Slot = "37")]
	public CAKFEHOBCAO IKLADMFFKPA(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5E27C70", Offset = "0x5E27070", VA = "0x185E27C70", Slot = "38")]
	public void ADIKJJDDBPK(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B0C0", Offset = "0x5E2A4C0", VA = "0x185E2B0C0", Slot = "39")]
	public CAKFEHOBCAO NALNAGAMHFP(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AC10", Offset = "0x5E2A010", VA = "0x185E2AC10", Slot = "40")]
	public void LEKFLKBIABP(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x5E293C0", Offset = "0x5E287C0", VA = "0x185E293C0", Slot = "7")]
	public void FFBCIDBKJPK(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x5E28970", Offset = "0x5E27D70", VA = "0x185E28970", Slot = "8")]
	public void BOJDPHNKIJA(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B1A0", Offset = "0x5E2A5A0", VA = "0x185E2B1A0", Slot = "9")]
	public int NAODMJCGMDJ(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5E27AD0", Offset = "0x5E26ED0", VA = "0x185E27AD0", Slot = "10")]
	public CAKFEHOBCAO AAJAIICOEAP(CAKFEHOBCAO AJAFIOGCMHP, int JPEMHHILGGG)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ACD0", Offset = "0x5E2A0D0", VA = "0x185E2ACD0", Slot = "11")]
	public void LIFAMBKLFMA(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5E28170", Offset = "0x5E27570", VA = "0x185E28170", Slot = "12")]
	public void ANFJAKJKEIE(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH, CAKFEHOBCAO LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B560", Offset = "0x5E2A960", VA = "0x185E2B560", Slot = "13")]
	public void NHLBJCNGJDN(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5E28F70", Offset = "0x5E28370", VA = "0x185E28F70", Slot = "14")]
	public bool DPJPFDIOIAH(CAKFEHOBCAO AJAFIOGCMHP, [Out] CAKFEHOBCAO LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5E27D30", Offset = "0x5E27130", VA = "0x185E27D30", Slot = "15")]
	public void ADLOAHLPKMN(CAKFEHOBCAO AJAFIOGCMHP, float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B680", Offset = "0x5E2AA80", VA = "0x185E2B680", Slot = "16")]
	public bool NPIFMHKCNNM(CAKFEHOBCAO AJAFIOGCMHP, [Out] float3 LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A070", Offset = "0x5E29470", VA = "0x185E2A070", Slot = "17")]
	public void IHAOOMMBMEF(CAKFEHOBCAO AJAFIOGCMHP, float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5E282B0", Offset = "0x5E276B0", VA = "0x185E282B0", Slot = "18")]
	public bool ANHCBEMDGIJ(CAKFEHOBCAO AJAFIOGCMHP, [Out] float3 LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BBB0", Offset = "0x5E2AFB0", VA = "0x185E2BBB0", Slot = "23")]
	[Obsolete("Use SetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	public float3 PNINNBIKIFA(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A650", Offset = "0x5E29A50", VA = "0x185E2A650", Slot = "24")]
	public float3 KAJNKJKKCHL(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B900", Offset = "0x5E2AD00", VA = "0x185E2B900", Slot = "25")]
	public void OHJHFPDAKLO(CAKFEHOBCAO AJAFIOGCMHP, float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A7A0", Offset = "0x5E29BA0", VA = "0x185E2A7A0", Slot = "26")]
	public void KFHEDNJHJPA(CAKFEHOBCAO AJAFIOGCMHP, float3 LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5E297A0", Offset = "0x5E28BA0", VA = "0x185E297A0", Slot = "27")]
	[Obsolete("Use GetMassOfSelf or TryGetMassOfHierarchy")]
	public float FMICGLMFLGO(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5E280E0", Offset = "0x5E274E0", VA = "0x185E280E0", Slot = "28")]
	public float AKPNDJCNKPP(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A850", Offset = "0x5E29C50", VA = "0x185E2A850", Slot = "29")]
	public void KFIOKECDAJF(CAKFEHOBCAO AJAFIOGCMHP, float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5E28C00", Offset = "0x5E28000", VA = "0x185E28C00", Slot = "30")]
	public void CJJEBOGMCHN(CAKFEHOBCAO AJAFIOGCMHP, float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5E28600", Offset = "0x5E27A00", VA = "0x185E28600", Slot = "19")]
	public void BIHLKFFOIGB(CAKFEHOBCAO AJAFIOGCMHP, (Quaternion rot, Vector3 moments) ALHLPOFJJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5E29CA0", Offset = "0x5E290A0", VA = "0x185E29CA0", Slot = "20")]
	public bool GJNOIFGPOLE(CAKFEHOBCAO AJAFIOGCMHP, [Out] quaternion BFDFAOOEJAP, [Out] float3 LFPMLPFJALN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5E28EE0", Offset = "0x5E282E0", VA = "0x185E28EE0", Slot = "41")]
	public JJDKBJICEBO DKIDFIKELLO(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(JJDKBJICEBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x5E29130", Offset = "0x5E28530", VA = "0x185E29130", Slot = "42")]
	public void EEJJPCHAFLB(CAKFEHOBCAO AJAFIOGCMHP, JJDKBJICEBO LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5E29F30", Offset = "0x5E29330", VA = "0x185E29F30", Slot = "66")]
	public void HDELMPEGJEH(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5E288D0", Offset = "0x5E27CD0", VA = "0x185E288D0", Slot = "67")]
	public void BOCBLGJAFLA(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x5E28840", Offset = "0x5E27C40", VA = "0x185E28840", Slot = "68")]
	public bool BNJDIPFJNGE(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5E294D0", Offset = "0x5E288D0", VA = "0x185E294D0", Slot = "82")]
	public bool FGMBIHKBJEA(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A9F0", Offset = "0x5E29DF0", VA = "0x185E2A9F0", Slot = "83")]
	public void KMJCGIHOIBO(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH, bool CHLKIHBDBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x5E28DC0", Offset = "0x5E281C0", VA = "0x185E28DC0", Slot = "84")]
	public void DGOHJENHDKA(CAKFEHOBCAO AJAFIOGCMHP, bool NDDCPACLCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B7F0", Offset = "0x5E2ABF0", VA = "0x185E2B7F0", Slot = "86")]
	public bool OBGOCKBMCFN(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5E29EB0", Offset = "0x5E292B0", VA = "0x185E29EB0", Slot = "85")]
	public void GMDPJHBLEIG(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5E299B0", Offset = "0x5E28DB0", VA = "0x185E299B0", Slot = "43")]
	public bool GALBCOBALMG(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x5E28B90", Offset = "0x5E27F90", VA = "0x185E28B90", Slot = "44")]
	public void CGBMEKACBDL(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5E28D30", Offset = "0x5E28130", VA = "0x185E28D30", Slot = "45")]
	public bool DDJOOPMGHHI(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5E29AE0", Offset = "0x5E28EE0", VA = "0x185E29AE0", Slot = "46")]
	public void GCFBKFKKIAH(CAKFEHOBCAO AJAFIOGCMHP, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A710", Offset = "0x5E29B10", VA = "0x185E2A710", Slot = "47")]
	public bool KCCNBGCKIIK(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B600", Offset = "0x5E2AA00", VA = "0x185E2B600", Slot = "48")]
	public void NNCANHGOODB(CAKFEHOBCAO AJAFIOGCMHP, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AF10", Offset = "0x5E2A310", VA = "0x185E2AF10", Slot = "49")]
	public RigidbodyConstraints LPOOBAGHPJJ(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ADB0", Offset = "0x5E2A1B0", VA = "0x185E2ADB0", Slot = "50")]
	public void LKHDNHAKICI(CAKFEHOBCAO AJAFIOGCMHP, RigidbodyConstraints LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x5E28B00", Offset = "0x5E27F00", VA = "0x185E28B00", Slot = "51")]
	public float CEMOKJDICPD(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A120", Offset = "0x5E29520", VA = "0x185E2A120", Slot = "52")]
	public void IIPCFAGHDIK(CAKFEHOBCAO AJAFIOGCMHP, float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5E28CA0", Offset = "0x5E280A0", VA = "0x185E28CA0", Slot = "53")]
	public float CJLFNOGKMCJ(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B430", Offset = "0x5E2A830", VA = "0x185E2B430", Slot = "54")]
	public void NEDDOHIEABH(CAKFEHOBCAO AJAFIOGCMHP, float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5E27FB0", Offset = "0x5E273B0", VA = "0x185E27FB0", Slot = "55")]
	public bool AIKCLBABIJN(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B880", Offset = "0x5E2AC80", VA = "0x185E2B880", Slot = "56")]
	public void ODCAGPJOLJO(CAKFEHOBCAO AJAFIOGCMHP, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AFA0", Offset = "0x5E2A3A0", VA = "0x185E2AFA0", Slot = "57")]
	public bool MJDMHFFMNGE(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5E28A80", Offset = "0x5E27E80", VA = "0x185E28A80", Slot = "58")]
	public void CEEEPMPEMNG(CAKFEHOBCAO AJAFIOGCMHP, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A520", Offset = "0x5E29920", VA = "0x185E2A520", Slot = "59")]
	public void JBANJHPFMMD(CAKFEHOBCAO AJAFIOGCMHP, int LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5E295F0", Offset = "0x5E289F0", VA = "0x185E295F0", Slot = "73")]
	public Rigidbody FJLPGGBIFGL(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5E27E50", Offset = "0x5E27250", VA = "0x185E27E50", Slot = "74")]
	public void AHGCNHEHEJD(CAKFEHOBCAO AJAFIOGCMHP, Rigidbody LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BB10", Offset = "0x5E2AF10", VA = "0x185E2BB10", Slot = "75")]
	public void ONCMECCPFEJ(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x5E29B60", Offset = "0x5E28F60", VA = "0x185E29B60", Slot = "76")]
	public void GGEHJOCGMEA(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5E291D0", Offset = "0x5E285D0", VA = "0x185E291D0", Slot = "77")]
	public bool EEOAJIPHNKN(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x5E29C00", Offset = "0x5E29000", VA = "0x185E29C00", Slot = "60")]
	public object GHHAKMPLIIK(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B9B0", Offset = "0x5E2ADB0", VA = "0x185E2B9B0", Slot = "61")]
	public void OLGDEODKAID(CAKFEHOBCAO AJAFIOGCMHP, object LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5E28E40", Offset = "0x5E28240", VA = "0x185E28E40", Slot = "62")]
	public object DJGBFCGNNIO(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B2D0", Offset = "0x5E2A6D0", VA = "0x185E2B2D0", Slot = "63")]
	public void NDDOPHBLGIO(CAKFEHOBCAO AJAFIOGCMHP, object LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A5C0", Offset = "0x5E299C0", VA = "0x185E2A5C0", Slot = "64")]
	public float JIOJFMGLNLO(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5E29A40", Offset = "0x5E28E40", VA = "0x185E29A40", Slot = "65")]
	public void GBALDBDDJEH(CAKFEHOBCAO AJAFIOGCMHP, float LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5E28040", Offset = "0x5E27440", VA = "0x185E28040", Slot = "69")]
	public void AKPIBHNFMDJ(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5E29FD0", Offset = "0x5E293D0", VA = "0x185E29FD0", Slot = "70")]
	public void HHNOMBFDOFK(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B030", Offset = "0x5E2A430", VA = "0x185E2B030", Slot = "71")]
	public bool MKNOMFEFACD(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5E27DE0", Offset = "0x5E271E0", VA = "0x185E27DE0", Slot = "21")]
	public void AEJCOCDNJBE(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5E27C00", Offset = "0x5E27000", VA = "0x185E27C00", Slot = "22")]
	public void ACNLHCHJOAP(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A370", Offset = "0x5E29770", VA = "0x185E2A370", Slot = "72")]
	public bool IPNHICNDDAH(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x5E298B0", Offset = "0x5E28CB0", VA = "0x185E298B0", Slot = "78")]
	public void FNHGJJMPBAP(CAKFEHOBCAO AJAFIOGCMHP, float3 FJGOAHOCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A8F0", Offset = "0x5E29CF0", VA = "0x185E2A8F0", Slot = "79")]
	public void KIOILKINCGH(CAKFEHOBCAO AJAFIOGCMHP, float3 DPKJDPPAHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x5E290E0", Offset = "0x5E284E0", VA = "0x185E290E0", Slot = "80")]
	public bool EBLJFOACMNM(CAKFEHOBCAO AJAFIOGCMHP, [Out] float3 FJGOAHOCDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B280", Offset = "0x5E2A680", VA = "0x185E2B280", Slot = "81")]
	public bool NCODECCIGIO(CAKFEHOBCAO AJAFIOGCMHP, [Out] float3 DPKJDPPAHNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AE50", Offset = "0x5E2A250", VA = "0x185E2AE50")]
	private DynamicBuffer<Entity> LLCBJICNBJA(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5E284C0", Offset = "0x5E278C0", VA = "0x185E284C0")]
	private DynamicBuffer<Entity> BBBKNNCJLIN(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x23CAA30", Offset = "0x23C9E30", VA = "0x1823CAA30")]
	private void PMDCMMPFIKC<T>(CAKFEHOBCAO AJAFIOGCMHP, object LPCGJALKADL, Func<object, T> MLOAGIOGKED) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public GODHGLMEEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[FHOIBFDAOOA(typeof(FJIPHEGHMFE), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public class FJIPHEGHMFE : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class GAOIJCJMHLM : IEnumerable<EOMJBFBJHKL>, IEnumerable, IEnumerator<EOMJBFBJHKL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private EOMJBFBJHKL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public FJIPHEGHMFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public NativeArray<Entity> <>3__entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private EntityManager <entityManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeArray<Entity>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private EOMJBFBJHKL System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public GAOIJCJMHLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5E49220", Offset = "0x5E48620", VA = "0x185E49220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x5E48EA0", Offset = "0x5E482A0", VA = "0x185E48EA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x5E490D0", Offset = "0x5E484D0", VA = "0x185E490D0")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x5E491D0", Offset = "0x5E485D0", VA = "0x185E491D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5E49120", Offset = "0x5E48520", VA = "0x185E49120", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EOMJBFBJHKL> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5E49120", Offset = "0x5E48520", VA = "0x185E49120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> HINKMADOLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x5E48540", Offset = "0x5E47940", VA = "0x185E48540", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x5E48590", Offset = "0x5E47990", VA = "0x185E48590")]
	public void NGABFNEGIAC(NativeArray<Entity> JIBDNODJOAB, bool MCIPAONIKMH, bool DMKOJIDKHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x5E47880", Offset = "0x5E46C80", VA = "0x185E47880")]
	public void ABDKKMAPHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5E47CC0", Offset = "0x5E470C0", VA = "0x185E47CC0")]
	private void INIPBEOFMGG(NativeArray<Entity> JIBDNODJOAB, bool MCIPAONIKMH, bool DMKOJIDKHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5E47C30", Offset = "0x5E47030", VA = "0x185E47C30")]
	[IteratorStateMachine(typeof(GAOIJCJMHLM))]
	private IEnumerable<EOMJBFBJHKL> IEBDMKMHAMD(NativeArray<Entity> JIBDNODJOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x5E47AC0", Offset = "0x5E46EC0", VA = "0x185E47AC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x5E48780", Offset = "0x5E47B80", VA = "0x185E48780")]
	public FJIPHEGHMFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[FHOIBFDAOOA(typeof(JCGFEEDFAOG), new string[] { })]
public class GJKPDCNEEOM : JCGFEEDFAOG, ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class LHMLBEKNHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public List<CapsuleCollider> GMMHAFEDELO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public List<SphereCollider> JJPEHJBNOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public GameObject DGDFPNPKMOH;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5E53DE0", Offset = "0x5E531E0", VA = "0x185E53DE0")]
		public LHMLBEKNHED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[DMNKPOGEHOO]
	private CDJJECGMMII GKEPNPGEJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[DMNKPOGEHOO]
	private AEMEMLHFPNC ILHJOHKFFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly Dictionary<Entity, LHMLBEKNHED> IHDHAPBBJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private GameObject JOCAFMFGAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private GameObject ANMIFMLIHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private GameObject JLOBAMDIHHI;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private GameObject JGOIPKFGICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5E495D0", Offset = "0x5E489D0", VA = "0x185E495D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A830", Offset = "0x5E49C30", VA = "0x185E4A830", Slot = "6")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A3A0", Offset = "0x5E497A0", VA = "0x185E4A3A0", Slot = "4")]
	public void HCECHKJKDBB(Entity NCFEPMCAPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A8A0", Offset = "0x5E49CA0", VA = "0x185E4A8A0", Slot = "5")]
	public void KBFIEMKIOCD(Entity NCFEPMCAPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5E49690", Offset = "0x5E48A90", VA = "0x185E49690", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AE50", Offset = "0x5E4A250", VA = "0x185E4AE50")]
	private LHMLBEKNHED PHKNNJDFPIC(Entity NCFEPMCAPNO, BHAKFOIGDML ALKPGICEAHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5E497B0", Offset = "0x5E48BB0", VA = "0x185E497B0")]
	private void EMBCEPAHIFN(BHAKFOIGDML ALKPGICEAHM, LHMLBEKNHED ANCKFNMACMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A640", Offset = "0x5E49A40", VA = "0x185E4A640")]
	private void IODKBPGJFLM(BHAKFOIGDML ALKPGICEAHM, LHMLBEKNHED ANCKFNMACMJ, int GMBCGJHBKMF, Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA, float ILPHNFDIOJC, float FFMDGIGMLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B0C0", Offset = "0x5E4A4C0", VA = "0x185E4B0C0")]
	private void PPKJHJAOMLA(LHMLBEKNHED ANCKFNMACMJ, int DHDCNCHGPOM, Vector3 BAONBICGOEJ, float ILPHNFDIOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5E492F0", Offset = "0x5E486F0", VA = "0x185E492F0")]
	private void BLIIFPCBFFM(BHAKFOIGDML ALKPGICEAHM, LHMLBEKNHED ANCKFNMACMJ, int IHOIGLHJODN, int ALHBHHBDNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x23C9B40", Offset = "0x23C8F40", VA = "0x1823C9B40")]
	private T GMFBDMCFLCA<T>(BHAKFOIGDML ALKPGICEAHM, GameObject BDNIDEKLIGD, Vector3 EDOEDBAJLGN, Quaternion ALNLHNLOHOA) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B310", Offset = "0x5E4A710", VA = "0x185E4B310")]
	public GJKPDCNEEOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
[FHOIBFDAOOA(typeof(DOIKPMDBKOI), new string[] { })]
public sealed class DOIKPMDBKOI : ENDDIKHKCDF, ICKLGHMJPBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class MDBDGCLPFNP : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public MDBDGCLPFNP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E546B0", Offset = "0x5E53AB0", VA = "0x185E546B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E54230", Offset = "0x5E53630", VA = "0x185E54230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E54570", Offset = "0x5E53970", VA = "0x185E54570")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E54660", Offset = "0x5E53A60", VA = "0x185E54660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E545C0", Offset = "0x5E539C0", VA = "0x185E545C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E545C0", Offset = "0x5E539C0", VA = "0x185E545C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<SerializableGuid, OOOKHLEFLPC> LJNKLGIOPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly List<SerializableGuid> FLIAEBGFOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly Dictionary<SerializableGuid, GameObject> FNIMMOLDOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private DFLIKLKNDFH MJHCCCCPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private BKIMEPBHNGA KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private MAICAFPPDGB BADPICBHGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private EKBKOBJCEAO DIHODDBACDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private FACGOEDLDML<OOOKHLEFLPC> CFPNKLPCMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private GameObject CCPILHNFJJH;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x5E444D0", Offset = "0x5E438D0", VA = "0x185E444D0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5E44150", Offset = "0x5E43550", VA = "0x185E44150", Slot = "5")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x5E43FB0", Offset = "0x5E433B0", VA = "0x185E43FB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x5E444C0", Offset = "0x5E438C0", VA = "0x185E444C0")]
	private void IDDEBPMEENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x5E44A40", Offset = "0x5E43E40", VA = "0x185E44A40")]
	internal void LKBMPBGEDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x5E43DC0", Offset = "0x5E431C0", VA = "0x185E43DC0")]
	private void BNMAODNIMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x5E450D0", Offset = "0x5E444D0", VA = "0x185E450D0")]
	private void NMNFAAPDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x5E442D0", Offset = "0x5E436D0", VA = "0x185E442D0")]
	[IteratorStateMachine(typeof(MDBDGCLPFNP))]
	private IEnumerable<RRCustomPropTag> FNIHIFKMCKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x5E445A0", Offset = "0x5E439A0", VA = "0x185E445A0")]
	private void KLOJDJGBFKD(CAKFEHOBCAO AJAFIOGCMHP, [In] JGFJHAANPIB MKKHNLNBPNM, [In] JGFJHAANPIB GJFJLOBMJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x5E44330", Offset = "0x5E43730", VA = "0x185E44330")]
	private void GFCMFFOEFBO(SerializableGuid HILDEDLDEPK, GameObject GHAOKLKOOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E439F0", Offset = "0x5E42DF0", VA = "0x185E439F0")]
	private void AALOGKMIENC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E44F10", Offset = "0x5E44310", VA = "0x185E44F10")]
	private bool LOIHEFEDIHJ(OOOKHLEFLPC MLKBHDGIANN, Transform DCLCDDGJKIC, [Out] GameObject CLFOAALEFAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E451B0", Offset = "0x5E445B0", VA = "0x185E451B0")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E45290", Offset = "0x5E44690", VA = "0x185E45290")]
	public DOIKPMDBKOI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public SerializableGuid MEDHPMNONNA
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x93E0D0", Offset = "0x93D4D0", VA = "0x18093E0D0")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E59130", Offset = "0x5E58530", VA = "0x185E59130")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[FHOIBFDAOOA(typeof(NCBLCPIDIEA), new string[] { })]
public class DLNMOFCLOCO : ENDDIKHKCDF, ICKLGHMJPBB, NCBLCPIDIEA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private GMEBHOOMEDK PIKEAKJOJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private KNKIEHNOADO JKFKBDCHGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private MJHGFDFFPLH MGJAOFDCMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private PGDEHOKHKKJ ICGAFPAJNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private int KPFFEDNJGDB;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool LDAOAEAIIDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E426B0", Offset = "0x5E41AB0", VA = "0x185E426B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CAKFEHOBCAO DNFLNGMMCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E42930", Offset = "0x5E41D30", VA = "0x185E42930", Slot = "9")]
		get
		{
			return default(CAKFEHOBCAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E421E0", Offset = "0x5E415E0", VA = "0x185E421E0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public BAJJJAGOPJE NGAMFNGJMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E42CC0", Offset = "0x5E420C0", VA = "0x185E42CC0", Slot = "11")]
		get
		{
			return default(BAJJJAGOPJE);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E421E0", Offset = "0x5E415E0", VA = "0x185E421E0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private uint KLFIKFANBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E42810", Offset = "0x5E41C10", VA = "0x185E42810")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event KEBLKNNECFM GAPJGIMLFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E42970", Offset = "0x5E41D70", VA = "0x185E42970", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E42210", Offset = "0x5E41610", VA = "0x185E42210", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E42860", Offset = "0x5E41C60", VA = "0x185E42860", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E42520", Offset = "0x5E41920", VA = "0x185E42520", Slot = "5")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E42430", Offset = "0x5E41830", VA = "0x185E42430", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E42D30", Offset = "0x5E42130", VA = "0x185E42D30")]
	private void NJDMDLLIIHF(DMMDOJFOBIA OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E42A10", Offset = "0x5E41E10", VA = "0x185E42A10", Slot = "13")]
	public CAKFEHOBCAO LFJGHBELPCN(CAKFEHOBCAO ADOGMMPMLJB, CAKFEHOBCAO EOFPNCBMKHP)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E42700", Offset = "0x5E41B00", VA = "0x185E42700", Slot = "14")]
	public bool HMBKMODMMCG(CAKFEHOBCAO ADOGMMPMLJB, CAKFEHOBCAO EOFPNCBMKHP, [Out] CAKFEHOBCAO AFMEONIJNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E422B0", Offset = "0x5E416B0", VA = "0x185E422B0", Slot = "15")]
	public void CJLPJDLHJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E42FC0", Offset = "0x5E423C0", VA = "0x185E42FC0", Slot = "16")]
	public void PINBDFJFFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E42B40", Offset = "0x5E41F40", VA = "0x185E42B40", Slot = "17")]
	public bool LOHAEJHJHFA(CAKFEHOBCAO ADOGMMPMLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E42FF0", Offset = "0x5E423F0", VA = "0x185E42FF0")]
	private void PKBJOCGMAAO(CAKFEHOBCAO CKPCHHKCOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public DLNMOFCLOCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[FHOIBFDAOOA(typeof(JFDAFKCNFNC), new string[] { })]
public class LGKLHABOMEI : ENDDIKHKCDF, JFDAFKCNFNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E53CF0", Offset = "0x5E530F0", VA = "0x185E53CF0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E53D70", Offset = "0x5E53170", VA = "0x185E53D70", Slot = "5")]
	public void OLNICKOCIEG(CAKFEHOBCAO PCOAABDKEED, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x244D1D0", Offset = "0x244C5D0", VA = "0x18244D1D0")]
	private void FAJCEJLMNJF<T>(CAKFEHOBCAO PCOAABDKEED, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public LGKLHABOMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[FHOIBFDAOOA(typeof(EJLACCPBJAD), new string[] { })]
public class HMKPIAIIIAL : ENDDIKHKCDF, EJLACCPBJAD
{
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BF60", Offset = "0x5E4B360", VA = "0x185E4BF60", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BEF0", Offset = "0x5E4B2F0", VA = "0x185E4BEF0", Slot = "5")]
	public void GJCNHNDJGBM(CAKFEHOBCAO PCOAABDKEED, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BE80", Offset = "0x5E4B280", VA = "0x185E4BE80", Slot = "6")]
	public void BBHDHNHEGGC(CAKFEHOBCAO PCOAABDKEED, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BFE0", Offset = "0x5E4B3E0", VA = "0x185E4BFE0", Slot = "7")]
	public void JJHEBLMMMIK(CAKFEHOBCAO PCOAABDKEED, int LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x23DCD80", Offset = "0x23DC180", VA = "0x1823DCD80")]
	private void FAJCEJLMNJF<T>(CAKFEHOBCAO PCOAABDKEED, bool LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x23DCE50", Offset = "0x23DC250", VA = "0x1823DCE50")]
	private void FAJCEJLMNJF<T>(CAKFEHOBCAO PCOAABDKEED, T OOIBMCBCEPD) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public HMKPIAIIIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
[FHOIBFDAOOA(typeof(JHLEBLAHMEC), new string[] { })]
public class JHLEBLAHMEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly Dictionary<JHDIEJNPMMJ, string> DAKIECBAOJL;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D960", Offset = "0x5E4CD60", VA = "0x185E4D960")]
	public GameObject AADPHPHCKJO(JHDIEJNPMMJ KBIHHOCHFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DA30", Offset = "0x5E4CE30", VA = "0x185E4DA30")]
	public JHLEBLAHMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
[FHOIBFDAOOA(typeof(CODDPCILKPF), new string[] { })]
internal class CODDPCILKPF : ENDDIKHKCDF, ICKLGHMJPBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private EPEIHHNCIHD EHJFODOFCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private MKIKBAICGGB<Entity> DCLCDDGJKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private HFHCOKNIOMB GIKKACIEGBJ;

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E41CD0", Offset = "0x5E410D0", VA = "0x185E41CD0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E41BB0", Offset = "0x5E40FB0", VA = "0x185E41BB0", Slot = "5")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E41B10", Offset = "0x5E40F10", VA = "0x185E41B10", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E41D40", Offset = "0x5E41140", VA = "0x185E41D40")]
	private void LIEFCOCGDLE(Entity AHNNJNFIHFM, [In] JGFJHAANPIB MKKHNLNBPNM, [In] JGFJHAANPIB GJFJLOBMJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public CODDPCILKPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DefaultMember("Item")]
public class HDABOIJOBCH<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
public class DKCBFGBHECP<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[DefaultMember("Item")]
public class IOMLAPODFAM<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Func<From, To> HLFOJBLLGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly Func<To, From> GJKHHICHGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public NativeArray<From> FOAJABBKLPB;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public To ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x35FB740", Offset = "0x35FAB40", VA = "0x1835FB740", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x35FB7A0", Offset = "0x35FABA0", VA = "0x1835FB7A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x35FB730", Offset = "0x35FAB30", VA = "0x1835FB730", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public bool DNCECCDBGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x769080", Offset = "0x768480", VA = "0x180769080")]
	public IOMLAPODFAM(Func<From, To> HLFOJBLLGKF, Func<To, From> GJKHHICHGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x35FB2A0", Offset = "0x35FA6A0", VA = "0x1835FB2A0", Slot = "11")]
	public void Add(To IBHHDIJNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x35FB2F0", Offset = "0x35FA6F0", VA = "0x1835FB2F0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x35FB340", Offset = "0x35FA740", VA = "0x1835FB340", Slot = "13")]
	public bool Contains(To IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x35FB420", Offset = "0x35FA820", VA = "0x1835FB420", Slot = "14")]
	public void CopyTo(To[] FOAJABBKLPB, int MHBLGNNCLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x35FB4E0", Offset = "0x35FA8E0", VA = "0x1835FB4E0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x35FB5A0", Offset = "0x35FA9A0", VA = "0x1835FB5A0", Slot = "6")]
	public int IndexOf(To IBHHDIJNMFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x35FB640", Offset = "0x35FAA40", VA = "0x1835FB640", Slot = "7")]
	public void Insert(int JPEMHHILGGG, To IBHHDIJNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x35FB6E0", Offset = "0x35FAAE0", VA = "0x1835FB6E0", Slot = "15")]
	public bool Remove(To IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x35FB690", Offset = "0x35FAA90", VA = "0x1835FB690", Slot = "8")]
	public void RemoveAt(int JPEMHHILGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x32E6F60", Offset = "0x32E6360", VA = "0x1832E6F60", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct ECLMJGCONAP : IComparable<ECLMJGCONAP>, IEquatable<ECLMJGCONAP>
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public static readonly ECLMJGCONAP AJNJPGPIKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public IKAJAHLJFMC PCOAABDKEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public NHGDGBFBAIF LNAKMGONIOO;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool ADBIFDDOPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E462B0", Offset = "0x5E456B0", VA = "0x185E462B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x962380", Offset = "0x961780", VA = "0x180962380")]
	public ECLMJGCONAP(IKAJAHLJFMC PCOAABDKEED, NHGDGBFBAIF LNAKMGONIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E462C0", Offset = "0x5E456C0", VA = "0x185E462C0", Slot = "4")]
	public int CompareTo(ECLMJGCONAP KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E464D0", Offset = "0x5E458D0", VA = "0x185E464D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E46340", Offset = "0x5E45740", VA = "0x185E46340", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E463D0", Offset = "0x5E457D0", VA = "0x185E463D0", Slot = "5")]
	public bool Equals(ECLMJGCONAP KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E46460", Offset = "0x5E45860", VA = "0x185E46460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct ODDANHNKOCH : IEnumerable<ECLMJGCONAP>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum BFCCDCJFEKM
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct IAKGJCIAHCL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private NativeList<byte> OOIBMCBCEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private ODDANHNKOCH NMLNNLIOHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly ECLMJGCONAP OFAFLOECBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly int CJJOHOENBLA;

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C830", Offset = "0x5E4BC30", VA = "0x185E4C830")]
		internal IAKGJCIAHCL(ODDANHNKOCH NMLNNLIOHNF, ECLMJGCONAP OFAFLOECBGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C600", Offset = "0x5E4BA00", VA = "0x185E4C600", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C790", Offset = "0x5E4BB90", VA = "0x185E4C790")]
		public void MPPKCBDACEI(ReadOnlySpan<byte> LPCGJALKADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C6F0", Offset = "0x5E4BAF0", VA = "0x185E4C6F0")]
		private void EMPJPFIOCIH(ReadOnlySpan<byte> LPCGJALKADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C690", Offset = "0x5E4BA90", VA = "0x185E4C690")]
		private unsafe void EMPJPFIOCIH(void* NNCOLKNDNPD, int FADEBHLHEEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct LODFCMGGJIB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private ODDANHNKOCH NMLNNLIOHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private NativeArray<byte> OOIBMCBCEPD;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5E541E0", Offset = "0x5E535E0", VA = "0x185E541E0")]
		internal LODFCMGGJIB(ODDANHNKOCH NMLNNLIOHNF, NativeArray<byte> OOIBMCBCEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x5E54130", Offset = "0x5E53530", VA = "0x185E54130", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x5E54070", Offset = "0x5E53470", VA = "0x185E54070")]
		public NativeArray<byte> DBMJBCODMPB(int FADEBHLHEEP)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5E54140", Offset = "0x5E53540", VA = "0x185E54140")]
		public void LEGFHKBEDAJ(Span<byte> LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct OKLGIOJJCKC : IEnumerator<ECLMJGCONAP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly NativeList<ECLMJGCONAP> FOAJABBKLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private int JPEMHHILGGG;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public ECLMJGCONAP KCBEOJELDAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x5E57960", Offset = "0x5E56D60", VA = "0x185E57960", Slot = "4")]
			get
			{
				return default(ECLMJGCONAP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x5E57910", Offset = "0x5E56D10", VA = "0x185E57910", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x5E577C0", Offset = "0x5E56BC0", VA = "0x185E577C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5E578C0", Offset = "0x5E56CC0", VA = "0x185E578C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private struct EBAGFCKKIDC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private NativeArray<int> OOIBMCBCEPD;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool PJPBOLEMKCC
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x5E45590", Offset = "0x5E44990", VA = "0x185E45590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public int JHGLKKJPKHC
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x5E45470", Offset = "0x5E44870", VA = "0x185E45470")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x5E45480", Offset = "0x5E44880", VA = "0x185E45480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public BFCCDCJFEKM MHOODHMFOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x5E45510", Offset = "0x5E44910", VA = "0x185E45510")]
			get
			{
				return default(BFCCDCJFEKM);
			}
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x5E45570", Offset = "0x5E44970", VA = "0x185E45570")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool DLEBFCBPPGM
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x5E45490", Offset = "0x5E44890", VA = "0x185E45490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool OBHJPAJGCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x5E454B0", Offset = "0x5E448B0", VA = "0x185E454B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5E45600", Offset = "0x5E44A00", VA = "0x185E45600")]
		public EBAGFCKKIDC(BFCCDCJFEKM MEGEBNGNINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x5E455D0", Offset = "0x5E449D0", VA = "0x185E455D0")]
		private int KJBHHOOLCCM(int POBHOBNPPIN, int NPHHNBJFHKC = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5E45520", Offset = "0x5E44920", VA = "0x185E45520")]
		private void FAJCEJLMNJF(int POBHOBNPPIN, int LPCGJALKADL, int NPHHNBJFHKC = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x5E454D0", Offset = "0x5E448D0", VA = "0x185E454D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly ECLMJGCONAP HBMEPLKGNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private NativeParallelHashMap<ECLMJGCONAP, int> HAOCCDOENBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private NativeList<ECLMJGCONAP> OMNHOGNBOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private NativeList<int> BPGFLBGKKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private NativeList<byte> LMANGKICJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private NativeList<byte> OOIBMCBCEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private EBAGFCKKIDC OJJNHGGGKOD;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E56940", Offset = "0x5E55D40", VA = "0x185E56940")]
	public static ODDANHNKOCH PJBIIEEDKDI(BFCCDCJFEKM MEGEBNGNINK = BFCCDCJFEKM.Last, int MGJOOOECAOG = 16, int IGKHLMMCJPM = 256)
	{
		return default(ODDANHNKOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E56B60", Offset = "0x5E55F60", VA = "0x185E56B60")]
	private ODDANHNKOCH(BFCCDCJFEKM MEGEBNGNINK, int MGJOOOECAOG, int IGKHLMMCJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E56200", Offset = "0x5E55600", VA = "0x185E56200", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E56110", Offset = "0x5E55510", VA = "0x185E56110")]
	public IAKGJCIAHCL BKOKOLEBONN(ECLMJGCONAP OFAFLOECBGM)
	{
		return default(IAKGJCIAHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E56300", Offset = "0x5E55700", VA = "0x185E56300")]
	public bool ENLODLDACGO(ECLMJGCONAP OFAFLOECBGM, [Out] LODFCMGGJIB JBLBJMHLOFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E56810", Offset = "0x5E55C10", VA = "0x185E56810")]
	public bool NGMBHJLAGCA(ECLMJGCONAP OFAFLOECBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E564A0", Offset = "0x5E558A0", VA = "0x185E564A0")]
	public bool KGPAHKPNOKL(ECLMJGCONAP OFAFLOECBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E56860", Offset = "0x5E55C60", VA = "0x185E56860")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E565A0", Offset = "0x5E559A0", VA = "0x185E565A0")]
	private void KIAKCAPJJMN(ECLMJGCONAP OFAFLOECBGM, int CJJOHOENBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E56030", Offset = "0x5E55430", VA = "0x185E56030")]
	private void AGIMNCAEDLP(int KHDPHINBIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E56980", Offset = "0x5E55D80", VA = "0x185E56980")]
	private void PLKCEOIDHNF(ECLMJGCONAP OFAFLOECBGM, int CJJOHOENBLA, int FADEBHLHEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E56AB0", Offset = "0x5E55EB0", VA = "0x185E56AB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E56A60", Offset = "0x5E55E60", VA = "0x185E56A60", Slot = "4")]
	private IEnumerator<ECLMJGCONAP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DefaultMember("Item")]
public class MMGJOLPGMCH<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class LIHBJCJOGEI
{
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class NLMCJKPAHIA
{
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class DHDEJNJGCIE
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class CGOLFOENAKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public FIMDMOFKGJF services;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CGOLFOENAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5E41660", Offset = "0x5E40A60", VA = "0x185E41660")]
		internal void GDCPMJKOAAN(ENDDIKHKCDF svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5E416C0", Offset = "0x5E40AC0", VA = "0x185E416C0")]
		internal void JODAKBPMMMP(ICKLGHMJPBB svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5E41FB0", Offset = "0x5E413B0", VA = "0x185E41FB0")]
	public static void LBHCFJOEAGO(this World KMPNHHILNIL, FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x22286A0", Offset = "0x2227AA0", VA = "0x1822286A0")]
	public static void PPCOJBDDJIK<T>(this World KMPNHHILNIL, Action<T> BMNGNEENDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2228240", Offset = "0x2227640", VA = "0x182228240")]
	public static void PJLPPNGDJAM<T>(this World KMPNHHILNIL, Action<T> BMNGNEENDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2228420", Offset = "0x2227820", VA = "0x182228420")]
	public static void PJLPPNGDJAM<T>(IEnumerable<ComponentSystemBase> MCIPOELAAMA, Action<T> BMNGNEENDGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class LMOGAFMEJGI
{
	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5E53F20", Offset = "0x5E53320", VA = "0x185E53F20")]
	public static void CGDAKONFHKH(ComponentSystemBase FIPLOBJLBLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class KNLOICHEJBP
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class GBDNHHLJDCD
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class MIDFMEGCCNC
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MIDFMEGCCNC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class BOOCDNCBAHG
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class PMIBMMBDNKA
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class PHGINPDIBJB
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class JFFDFEGABEO
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal static class KKAKFFIFBEC
{
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly ProfilerMarker CJMMACLPNAP;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly ProfilerMarker NCCLIAFFBMI;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5E50270", Offset = "0x5E4F670", VA = "0x185E50270")]
	public static void LHBGMEBPDNO(this JMIBEAJAMBD MHCBJGOCOMD, CEKMILKKGMN PLINNFIDOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FF30", Offset = "0x5E4F330", VA = "0x185E4FF30")]
	public static void HJPKJFOOBID(this JMIBEAJAMBD MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FE20", Offset = "0x5E4F220", VA = "0x185E4FE20")]
	private static string[] HCLJCFOOPMF(CEKMILKKGMN PLINNFIDOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5E50110", Offset = "0x5E4F510", VA = "0x185E50110")]
	private static bool KJMMBDBDOEK(CEKMILKKGMN PLINNFIDOFF, [Out] string[] BOGIAOJOKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280")]
	private static bool DJBMEAJNBFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public abstract class DMMMJKKAEBM : GDLIMMCJFOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly MethodInfo EOCBGKKNGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Type[] LHPGBFGMEDK;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5E43290", Offset = "0x5E42690", VA = "0x185E43290")]
	public DMMMJKKAEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action ECDEADNJNII();

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5E430C0", Offset = "0x5E424C0", VA = "0x185E430C0")]
	public MethodInfo FIOBFJBJNOM(Action PAFFKHOCLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5E43100", Offset = "0x5E42500", VA = "0x185E43100", Slot = "4")]
	public void GFCMFFOEFBO(Type DJMKKNDNCBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class EPJDDHOKMFM : DMMMJKKAEBM
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private enum OGNJHHIMDBO
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5E47660", Offset = "0x5E46A60", VA = "0x185E47660", Slot = "5")]
	public override Action ECDEADNJNII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void LFLFMBAAJCP<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5E475D0", Offset = "0x5E469D0", VA = "0x185E475D0")]
	[UnityEngine.Scripting.Preserve]
	public void DPAFHFOEFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5E417D0", Offset = "0x5E40BD0", VA = "0x185E417D0")]
	protected EPJDDHOKMFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public abstract class KLJGMPLFMGL : DMMMJKKAEBM
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5E53680", Offset = "0x5E52A80", VA = "0x185E53680", Slot = "5")]
	public override Action ECDEADNJNII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void HKFCEBENKBN<T>() where T : GJJMNANPJKP;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5E535F0", Offset = "0x5E529F0", VA = "0x185E535F0")]
	[UnityEngine.Scripting.Preserve]
	public void DPAFHFOEFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5E417D0", Offset = "0x5E40BD0", VA = "0x185E417D0")]
	protected KLJGMPLFMGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class OCBAADKFNAG : DMMMJKKAEBM
{
	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x5E55F90", Offset = "0x5E55390", VA = "0x185E55F90", Slot = "5")]
	public override Action ECDEADNJNII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void BHGLHONKKDI<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5E55F00", Offset = "0x5E55300", VA = "0x185E55F00")]
	[UnityEngine.Scripting.Preserve]
	public void DPAFHFOEFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5E417D0", Offset = "0x5E40BD0", VA = "0x185E417D0")]
	protected OCBAADKFNAG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct LCGJHKCNAFP : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
	public void OnCreate(SystemState CGABFKIJBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
	public void OnDestroy(SystemState CGABFKIJBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5E538D0", Offset = "0x5E52CD0", VA = "0x185E538D0", Slot = "6")]
	public void OnUpdate(SystemState CGABFKIJBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void AMHNLNENMGL(IntPtr CLFMFOEGLFG, IntPtr CGABFKIJBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5E538D0", Offset = "0x5E52CD0", VA = "0x185E538D0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void EJAOJEHMBEK(IntPtr CLFMFOEGLFG, IntPtr CGABFKIJBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void BAFBPLBNPOH(IntPtr CLFMFOEGLFG, IntPtr CGABFKIJBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class JDMABBOEHOJ
{
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public static readonly ComponentType[] HNAOBHLFJDD;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CB50", Offset = "0x5E4BF50", VA = "0x185E4CB50")]
	public static Entity MONBNDPCAEP(this EntityManager OKNGAOGEIDO)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class PGICCGNANNI
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class IPFJHCOOIOI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class FGHEDMEBEPD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class KDEOMMACCOI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5E580B0", Offset = "0x5E574B0", VA = "0x185E580B0")]
	public static Entity DEDGBFFFANE(this EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5E57D80", Offset = "0x5E57180", VA = "0x185E57D80")]
	public static DynamicBuffer<ChildrenData> BBBKNNCJLIN(this EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(DynamicBuffer<ChildrenData>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5E58FA0", Offset = "0x5E583A0", VA = "0x185E58FA0")]
	public static bool POBKOBCFDJN(this EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, Allocator JIIMEDFKEME, [Out] NativeArray<Entity> OCCPEHILJMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5E57F30", Offset = "0x5E57330", VA = "0x185E57F30")]
	public static NativeArray<Entity> CJIDMDHJBBC(this EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5E58A10", Offset = "0x5E57E10", VA = "0x185E58A10")]
	public static int NAODMJCGMDJ(this EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5E58B40", Offset = "0x5E57F40", VA = "0x185E58B40")]
	public static void NDHLKODIKCE(NativeArray<Entity> NMABGJCEKFC, NativeArray<Entity> FEGECHNBDFA, EntityManager OKNGAOGEIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5E58DD0", Offset = "0x5E581D0", VA = "0x185E58DD0")]
	public static bool OMHDFCIKAMC(this EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, Entity JHJELAILOKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x5E58410", Offset = "0x5E57810", VA = "0x185E58410")]
	public static bool GBDKGPAEEJJ(this EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, Entity JBFHBGCJGMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5E58120", Offset = "0x5E57520", VA = "0x185E58120")]
	public static NativeList<Entity> DOCAHACJNJG(this EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, bool PMDDIKGHDKP = false, Allocator JIIMEDFKEME = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5E588E0", Offset = "0x5E57CE0", VA = "0x185E588E0")]
	public static Entity IKLADMFFKPA(this EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5E58610", Offset = "0x5E57A10", VA = "0x185E58610")]
	public static bool HMBKMODMMCG(this EntityManager OKNGAOGEIDO, Entity ADOGMMPMLJB, Entity EOFPNCBMKHP, [Out] Entity OGJHDCCIKIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5E57E10", Offset = "0x5E57210", VA = "0x185E57E10")]
	internal static void BMOONNNOEPC(EntityManager OKNGAOGEIDO, Entity DCLCDDGJKIC, Entity PPNMHLJNNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5E582E0", Offset = "0x5E576E0", VA = "0x185E582E0")]
	private static bool EHDCMGKPKPC(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, Entity JHJELAILOKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[FHOIBFDAOOA(typeof(OENIAEHPEJM), new string[] { })]
internal sealed class HNCKJNJLLFH : OENIAEHPEJM, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[DMNKPOGEHOO]
	private IBNLNIKJFKJ GHANGHOPLNK;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public AFGABMDBNMJ.ENAALMJHMPG.ODIPDJCHHHP DGECIEGMMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C170", Offset = "0x5E4B570", VA = "0x185E4C170", Slot = "4")]
		get
		{
			return default(AFGABMDBNMJ.ENAALMJHMPG.ODIPDJCHHHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C1E0", Offset = "0x5E4B5E0", VA = "0x185E4C1E0", Slot = "5")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public HNCKJNJLLFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class KKHMEBCOPHM
{
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly FJOGIBEAJHF EOANCOHLMBG;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static readonly FJOGIBEAJHF NAOCLJCNELN;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly ProfilerMarker KOENIIBBODL;

	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly ProfilerMarker JBMPMDDECMC;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly ProfilerMarker IOGLFBIEJFB;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private static readonly ProfilerMarker EDHELFKBKFE;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private static readonly ProfilerMarker NAJHIHEBOAF;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private static readonly ProfilerMarker JHBEMJCKPEH;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker NLKJJLEAIEJ;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly ProfilerMarker ONEDPIHKGPN;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly ProfilerMarker BPHMNIGLIDF;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly ProfilerMarker HEKEBBMNOEP;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly ProfilerMarker PINDNJADPGC;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker KNCBKKKNCEE;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static readonly ProfilerMarker ADEJAKGCPKD;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly ProfilerMarker BJBNGJHFOHM;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly ProfilerMarker LBJEBIHPMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly HAIABCMOIEJ BMMGLFGEFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private readonly ByteString KHPJJNGKJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly JMIBEAJAMBD MHCBJGOCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly KNLDJMFLGFE KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly BGDEDBPHGDF HOBNLPGFIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly EOJCJEFAOPN OMNHOGNBOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly ABINPCDKADH FAEBHCPPMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly TaskCompletionSource<bool> BPFHLDFGALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly ACNLBFFNDDL OJJNHGGGKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly KPEGALIANIK.JALHGADHNAJ KHOPNBJEGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private JEKOGBJNELB HHPKMKDIDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private KBADIJFHJMJ GDJPIHBFICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private AFGABMDBNMJ DGMKIJLJGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private PAEPNGDGNBO PMNHOPMJONO;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Action GCAIPFAKAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F50", Offset = "0x7F6350", VA = "0x1807F6F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x89BDE0", Offset = "0x89B1E0", VA = "0x18089BDE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Action OKPBLADPKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x89BB10", Offset = "0x89AF10", VA = "0x18089BB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x89BD80", Offset = "0x89B180", VA = "0x18089BD80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Action CFPFAKFIEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x7690D0", Offset = "0x7684D0", VA = "0x1807690D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x769100", Offset = "0x768500", VA = "0x180769100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IEnumerable<OPBDJAPIKJM> FGJNENOGIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BF0", Offset = "0x7F6FF0", VA = "0x1807F7BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x7F7C00", Offset = "0x7F7000", VA = "0x1807F7C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EEKDDPBIMAP AOECMCHHIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5E52420", Offset = "0x5E51820", VA = "0x185E52420")]
		[CompilerGenerated]
		get
		{
			return default(EEKDDPBIMAP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x5E50C10", Offset = "0x5E50010", VA = "0x185E50C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public PAEPNGDGNBO NFGALDMCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x89BB00", Offset = "0x89AF00", VA = "0x18089BB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public IFNNGLCOHHI JPGFBIKJPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x19EF320", Offset = "0x19EE720", VA = "0x1819EF320")]
		get
		{
			return default(IFNNGLCOHHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public LocalId KDDFGHHFEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x5E51ED0", Offset = "0x5E512D0", VA = "0x185E51ED0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Task EBDDGDCHACF
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x5E52690", Offset = "0x5E51A90", VA = "0x185E52690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5E53320", Offset = "0x5E52720", VA = "0x185E53320")]
	public KKHMEBCOPHM(ByteString KHPJJNGKJGC, IFNNGLCOHHI BDJAALIOCLJ, [In] ACNLBFFNDDL OJJNHGGGKOD, JMIBEAJAMBD MHCBJGOCOMD, KLDHNDGGMFO BMGKNOIDKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5E52A30", Offset = "0x5E51E30", VA = "0x185E52A30")]
	public void OCOEOHNAACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5E518D0", Offset = "0x5E50CD0", VA = "0x185E518D0")]
	public bool HPOJNLGPELL(IFNNGLCOHHI ADOGMMPMLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5E52150", Offset = "0x5E51550", VA = "0x185E52150")]
	private bool JOAAACHOAMM(IFNNGLCOHHI KBOPLLOOOBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5E52830", Offset = "0x5E51C30", VA = "0x185E52830")]
	private void MKKPIEMDCDE(IFNNGLCOHHI FDDLFIPELPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5E50EA0", Offset = "0x5E502A0", VA = "0x185E50EA0")]
	private bool EDDJKJPPING()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5E51FF0", Offset = "0x5E513F0", VA = "0x185E51FF0")]
	public bool JNCHKOBJHHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x5E518F0", Offset = "0x5E50CF0", VA = "0x185E518F0")]
	private bool INMJCLOFBLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5E52B10", Offset = "0x5E51F10", VA = "0x185E52B10")]
	private bool OJMKIILKOEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x5E51EE0", Offset = "0x5E512E0", VA = "0x185E51EE0")]
	private bool JLGDHGFOEEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5E50E70", Offset = "0x5E50270", VA = "0x185E50E70")]
	private bool EBLLBCGOPBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x5E51D90", Offset = "0x5E51190", VA = "0x185E51D90")]
	private bool JAHIDPBKBPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5E51270", Offset = "0x5E50670", VA = "0x185E51270")]
	public void FGLPKGAHHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5E516C0", Offset = "0x5E50AC0", VA = "0x185E516C0")]
	[CompilerGenerated]
	private void GIDNEPDJBPE(IFNNGLCOHHI KBOPLLOOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5E51C40", Offset = "0x5E51040", VA = "0x185E51C40")]
	[CompilerGenerated]
	private bool IOKKOMAKOLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x5E507B0", Offset = "0x5E4FBB0", VA = "0x185E507B0")]
	[CompilerGenerated]
	private void AJAFKDMAEOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x5E52900", Offset = "0x5E51D00", VA = "0x185E52900")]
	[CompilerGenerated]
	private World OCLLKPINFOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x5E52560", Offset = "0x5E51960", VA = "0x185E52560")]
	[CompilerGenerated]
	private void LINLOKCAAMD(World LEIPDCLIGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5E526D0", Offset = "0x5E51AD0", VA = "0x185E526D0")]
	[CompilerGenerated]
	private int MHDFFMNOECD(World LEIPDCLIGBA, ByteString KHPJJNGKJGC, AFGABMDBNMJ.ENAALMJHMPG.ODIPDJCHHHP KAHINILDCOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5E516F0", Offset = "0x5E50AF0", VA = "0x185E516F0")]
	[CompilerGenerated]
	private void GMILOJHPDNC(World KMPNHHILNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x5E510C0", Offset = "0x5E504C0", VA = "0x185E510C0")]
	[CompilerGenerated]
	internal static KEIADDADLII ENCLKBPEMOG(EntityManager JBEFLJPGPMI, EntityManager CPEIHGMACAO, int JLENMGKDJEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5E52450", Offset = "0x5E51850", VA = "0x185E52450")]
	[CompilerGenerated]
	private void LFBPONMFJBB(PAEPNGDGNBO PMNHOPMJONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x5E50CB0", Offset = "0x5E500B0", VA = "0x185E50CB0")]
	[CompilerGenerated]
	private void BBOEGAGCMMG(EntityManager OKNGAOGEIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5E52DE0", Offset = "0x5E521E0", VA = "0x185E52DE0")]
	[CompilerGenerated]
	private void PBBAGJKMANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5E528E0", Offset = "0x5E51CE0", VA = "0x185E528E0")]
	[CompilerGenerated]
	private void NNKACAMNCPE(string DKFEAPHKBMP, EntityManager OKNGAOGEIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5E50C40", Offset = "0x5E50040", VA = "0x185E50C40")]
	[CompilerGenerated]
	private FGANGKDGHOI<ACNLBFFNDDL> APCKCIDKEPM(EntityManager OKNGAOGEIDO)
	{
		return default(FGANGKDGHOI<ACNLBFFNDDL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class HAIABCMOIEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private enum OHPHGMDGAJC
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		Running,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		Disposed
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class NPJGDIHCHGC : IEnumerable<IFNNGLCOHHI>, IEnumerable, IEnumerator<IFNNGLCOHHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private IFNNGLCOHHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public HAIABCMOIEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private IFNNGLCOHHI target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public IFNNGLCOHHI <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private int <allowedTarget>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private IFNNGLCOHHI System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x8AE1F0", Offset = "0x8AD5F0", VA = "0x1808AE1F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(IFNNGLCOHHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x5E55EB0", Offset = "0x5E552B0", VA = "0x185E55EB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xC91170", Offset = "0xC90570", VA = "0x180C91170")]
		[DebuggerHidden]
		public NPJGDIHCHGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x5E55D30", Offset = "0x5E55130", VA = "0x185E55D30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x5E55E60", Offset = "0x5E55260", VA = "0x185E55E60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x5E55DB0", Offset = "0x5E551B0", VA = "0x185E55DB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IFNNGLCOHHI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x5E55DB0", Offset = "0x5E551B0", VA = "0x185E55DB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class DNNLGONHLCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public IFNNGLCOHHI phase;

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DNNLGONHLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x5E43980", Offset = "0x5E42D80", VA = "0x185E43980")]
		internal object NCGNDIHLBOI(IFNNGLCOHHI a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static readonly FJOGIBEAJHF NAOCLJCNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly IFNNGLCOHHI BDJAALIOCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly Func<IFNNGLCOHHI, bool> FLDMNHHNNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly Action<IFNNGLCOHHI> JPNCHGKABOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private int PAMDCLLNOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private OHPHGMDGAJC CGABFKIJBOC;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public IFNNGLCOHHI JPGFBIKJPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x762180", Offset = "0x761580", VA = "0x180762180")]
		get
		{
			return default(IFNNGLCOHHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x5E4BA10", Offset = "0x5E4AE10", VA = "0x185E4BA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BAE0", Offset = "0x5E4AEE0", VA = "0x185E4BAE0")]
	public HAIABCMOIEJ(IFNNGLCOHHI BDJAALIOCLJ, Func<IFNNGLCOHHI, bool> FLDMNHHNNLK, Action<IFNNGLCOHHI> JPNCHGKABOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B5B0", Offset = "0x5E4A9B0", VA = "0x185E4B5B0")]
	[IteratorStateMachine(typeof(NPJGDIHCHGC))]
	private IEnumerable<IFNNGLCOHHI> DLKEHAACHBP(IFNNGLCOHHI ADOGMMPMLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B640", Offset = "0x5E4AA40", VA = "0x185E4B640")]
	public bool HPOJNLGPELL(IFNNGLCOHHI ADOGMMPMLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B9D0", Offset = "0x5E4ADD0", VA = "0x185E4B9D0")]
	private void JGPNGJLKHJE(IFNNGLCOHHI KBOPLLOOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5E247A0", Offset = "0x5E23BA0", VA = "0x185E247A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal class FOAEIBPHDDD : CCDCMKEIGFA, KLDHNDGGMFO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly KKHMEBCOPHM PLBKMELAPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly KEMPNLKAPFH EHIPJPLBPBA;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IIOGBKCCMMK KIHKEBEEIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public LocalId JDBDAAELPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x5E48810", Offset = "0x5E47C10", VA = "0x185E48810", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Task EBDDGDCHACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x5E48940", Offset = "0x5E47D40", VA = "0x185E48940", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IEnumerable<OPBDJAPIKJM> FGJNENOGIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x5E48990", Offset = "0x5E47D90", VA = "0x185E48990", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public EEKDDPBIMAP AOECMCHHIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x5E488D0", Offset = "0x5E47CD0", VA = "0x185E488D0", Slot = "8")]
		get
		{
			return default(EEKDDPBIMAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public PAEPNGDGNBO PKDHCIJNEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x5E488B0", Offset = "0x5E47CB0", VA = "0x185E488B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5E489C0", Offset = "0x5E47DC0", VA = "0x185E489C0")]
	public FOAEIBPHDDD(ByteString KHPJJNGKJGC, IIOGBKCCMMK FNGGPECHLIF, [In] ACNLBFFNDDL OJJNHGGGKOD, JMIBEAJAMBD MHCBJGOCOMD, Action CHCAJAAKAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x5E48910", Offset = "0x5E47D10", VA = "0x185E48910", Slot = "5")]
	public void LAGINJJKIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x5E48880", Offset = "0x5E47C80", VA = "0x185E48880", Slot = "12")]
	public bool HPOJNLGPELL(IFNNGLCOHHI KBOPLLOOOBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x5E48860", Offset = "0x5E47C60", VA = "0x185E48860", Slot = "6")]
	public void FGLPKGAHHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5E48840", Offset = "0x5E47C40", VA = "0x185E48840", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal class MINANOLLMJI : GOPDDEOGDJM, KLDHNDGGMFO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly KKHMEBCOPHM PLBKMELAPOA;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public LocalId JDBDAAELPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5E54740", Offset = "0x5E53B40", VA = "0x185E54740", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IEnumerable<OPBDJAPIKJM> FGJNENOGIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5E48990", Offset = "0x5E47D90", VA = "0x185E48990", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public EEKDDPBIMAP AOECMCHHIDF
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x5E488D0", Offset = "0x5E47CD0", VA = "0x185E488D0", Slot = "5")]
		get
		{
			return default(EEKDDPBIMAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Task EBDDGDCHACF
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5E48940", Offset = "0x5E47D40", VA = "0x185E48940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public PAEPNGDGNBO PKDHCIJNEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5E488B0", Offset = "0x5E47CB0", VA = "0x185E488B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5E54750", Offset = "0x5E53B50", VA = "0x185E54750")]
	public MINANOLLMJI(ByteString KHPJJNGKJGC, JMIBEAJAMBD MHCBJGOCOMD, Action CDNLDGBJKNN, Action FICFJEBGFNH, Action CHCAJAAKAHP, bool ICBOADOHKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E48880", Offset = "0x5E47C80", VA = "0x185E48880", Slot = "9")]
	public bool HPOJNLGPELL(IFNNGLCOHHI KBOPLLOOOBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E48840", Offset = "0x5E47C40", VA = "0x185E48840", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal struct ACNLBFFNDDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public CJOBJHHCGGP EDKPGHPBAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public Entity DCLCDDGJKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public EKHFHKEJHJI EGJBIIEJEOI;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly EDFBLELCCFE<ACNLBFFNDDL> DFAIJMEJABN;
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class NDAFPPJJGFP : EINHHNIDDEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public PAEPNGDGNBO NFGALDMCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E55210", Offset = "0x5E54610", VA = "0x185E55210", Slot = "5")]
	public ByteString IEBDGLIPLJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public NDAFPPJJGFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[AKLGDNDGKKL(DPJKEJCGJEB.Application)]
public interface OENIAEHPEJM
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	AFGABMDBNMJ.ENAALMJHMPG.ODIPDJCHHHP DGECIEGMMKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal abstract class EDABIAPJDDJ : EINHHNIDDEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker IOGLFBIEJFB;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker OAADLFDMLCB;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker EDHELFKBKFE;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker MKBLGDGMKKC;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker JHBEMJCKPEH;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly ProfilerMarker EMOAHEFGICB;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker DLPMDCFKNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly JMIBEAJAMBD MHCBJGOCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly JEKOGBJNELB HHPKMKDIDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly ABINPCDKADH FAEBHCPPMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly EOJCJEFAOPN OMNHOGNBOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly FJOGIBEAJHF NAOCLJCNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly KPEGALIANIK.JALHGADHNAJ KHOPNBJEGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private World AKFDKNCMMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private PAEPNGDGNBO PMNHOPMJONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private IDisposable DBCNCPPNCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private ByteString ALPGCHPMFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private AFGABMDBNMJ.ENAALMJHMPG.ODIPDJCHHHP GCNILNGMEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private bool EECOHNALLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private KFIGKCHPCDA KGLLDELCPML;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	protected World IJOGDMOIGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x7665F0", Offset = "0x7659F0", VA = "0x1807665F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	protected World KMONKLDHPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E46590", Offset = "0x5E45990", VA = "0x185E46590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public PAEPNGDGNBO NFGALDMCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x7665C0", Offset = "0x7659C0", VA = "0x1807665C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E47430", Offset = "0x5E46830", VA = "0x185E47430")]
	public EDABIAPJDDJ(JMIBEAJAMBD MHCBJGOCOMD, FJOGIBEAJHF AABDFOONPNL, FJOGIBEAJHF NAOCLJCNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E46700", Offset = "0x5E45B00", VA = "0x185E46700", Slot = "5")]
	public ByteString IEBDGLIPLJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E46780", Offset = "0x5E45B80", VA = "0x185E46780", Slot = "7")]
	public void LAGINJJKIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E466A0", Offset = "0x5E45AA0", VA = "0x185E466A0", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E465E0", Offset = "0x5E459E0", VA = "0x185E465E0", Slot = "9")]
	protected virtual PAAEGOMLMON CLCCBNABFEK()
	{
		return default(PAAEGOMLMON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void CKJNCGHONDF();

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> DPIDHFDOEJM(NativeArray<EntityRemapUtility.EntityRemapInfo> LPOIMFDMNPO);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[BHEPKMIJCPL]
internal struct PAAEGOMLMON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	public CJOBJHHCGGP MGMGONHABNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	public DHIOCBGLFGF EGJBIIEJEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	public AFGABMDBNMJ.ENAALMJHMPG.ODIPDJCHHHP KAHINILDCOI;

	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public static readonly EDFBLELCCFE<PAAEGOMLMON> DFAIJMEJABN;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E579B0", Offset = "0x5E56DB0", VA = "0x185E579B0")]
	public static PAAEGOMLMON DFIMGLIPONE([In] CJOBJHHCGGP MGMGONHABNF)
	{
		return default(PAAEGOMLMON);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class DNCEDMFPNBJ : EDABIAPJDDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly FJOGIBEAJHF NAOCLJCNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private readonly PAAEGOMLMON OJJNHGGGKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private NativeList<Entity> HLDLLGKKEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private NativeArray<Entity> ICNCAGBBAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> AKABCAOAJJN;

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E437C0", Offset = "0x5E42BC0", VA = "0x185E437C0")]
	public DNCEDMFPNBJ(IEnumerable<CAKFEHOBCAO> MOMJNKBEDGK, [In] PAAEGOMLMON OJJNHGGGKOD, JMIBEAJAMBD MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E434D0", Offset = "0x5E428D0", VA = "0x185E434D0", Slot = "9")]
	protected override PAAEGOMLMON CLCCBNABFEK()
	{
		return default(PAAEGOMLMON);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E43340", Offset = "0x5E42740", VA = "0x185E43340", Slot = "10")]
	protected override void CKJNCGHONDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E43500", Offset = "0x5E42900", VA = "0x185E43500", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> DPIDHFDOEJM(NativeArray<EntityRemapUtility.EntityRemapInfo> LPOIMFDMNPO)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E43650", Offset = "0x5E42A50", VA = "0x185E43650", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal class PCFFPJEBEGA : EDABIAPJDDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly FJOGIBEAJHF NAOCLJCNELN;

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E57BF0", Offset = "0x5E56FF0", VA = "0x185E57BF0")]
	public PCFFPJEBEGA(JMIBEAJAMBD MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E57A80", Offset = "0x5E56E80", VA = "0x185E57A80", Slot = "10")]
	protected override void CKJNCGHONDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0xD2E1A0", Offset = "0xD2D5A0", VA = "0x180D2E1A0", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> DPIDHFDOEJM(NativeArray<EntityRemapUtility.EntityRemapInfo> LPOIMFDMNPO)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class JFIOMMPPLCO
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D7E0", Offset = "0x5E4CBE0", VA = "0x185E4D7E0")]
	public static KPEGALIANIK.JALHGADHNAJ JBBFJLGFDHF(JMIBEAJAMBD MHCBJGOCOMD)
	{
		return default(KPEGALIANIK.JALHGADHNAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D4A0", Offset = "0x5E4C8A0", VA = "0x185E4D4A0")]
	public static NativeList<Entity> EMPLGGMMLKO(EntityManager OKNGAOGEIDO, IEnumerable<CAKFEHOBCAO> MOMJNKBEDGK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D3F0", Offset = "0x5E4C7F0", VA = "0x185E4D3F0")]
	public static void DPIDHFDOEJM(NativeArray<Entity> ICNCAGBBAEH, NativeList<Entity> HLDLLGKKEAK, NativeArray<EntityRemapUtility.EntityRemapInfo> LPOIMFDMNPO, NativeArray<EntityRemapUtility.EntityRemapInfo> AKABCAOAJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2410030", Offset = "0x240F430", VA = "0x182410030")]
	public static Entity HNIHFBDDHNH<T>(EntityManager OKNGAOGEIDO, [In] T LPCGJALKADL) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class PCLDEOFFBIO
{
	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E57CB0", Offset = "0x5E570B0", VA = "0x185E57CB0")]
	public static CJOBJHHCGGP HKPKFDOMIIH(BAJJJAGOPJE DCLCDDGJKIC)
	{
		return default(CJOBJHHCGGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct FGANGKDGHOI<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private readonly Entity MLONPGPEIEE;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x33AEAF0", Offset = "0x33ADEF0", VA = "0x1833AEAF0")]
	public FGANGKDGHOI(EntityManager OKNGAOGEIDO, [In] T OJJNHGGGKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x33AEA90", Offset = "0x33ADE90", VA = "0x1833AEA90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[FHOIBFDAOOA(typeof(JPNIIOOOMOP), new string[] { })]
public class HECJPBCACDJ : JPNIIOOOMOP, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public MIHEJMLNMCP CJFLBIONFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x764460", Offset = "0x763860", VA = "0x180764460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private HEKCKKAGEFC EBECCBJNMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x7644F0", VA = "0x1807650F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private OPAANNDNOCG LELGKHLMJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x764500", VA = "0x180765100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private JMLLBGKNGCC KDMJCMIKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x76DDB0", Offset = "0x76D1B0", VA = "0x18076DDB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public NFFPLOOJDLP OPEJFEANDJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A830", VA = "0x18076B430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public MKGHLKFDBNM JNJLHAFPLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x767760", Offset = "0x766B60", VA = "0x180767760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public BKIMEPBHNGA CDLANPMGNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x76A450", Offset = "0x769850", VA = "0x18076A450", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x767710", Offset = "0x766B10", VA = "0x180767710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public MLEALBJMIOH IGDOIILIPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7653E0", Offset = "0x7647E0", VA = "0x1807653E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x765460", Offset = "0x764860", VA = "0x180765460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private KNLDJMFLGFE PDOJDDFLFHK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x766630", Offset = "0x765A30", VA = "0x180766630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public GENLJBHGPDA BOIAFBECOND
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x766610", Offset = "0x765A10", VA = "0x180766610", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x7665E0", Offset = "0x7659E0", VA = "0x1807665E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public ENDHDICDHJA HNEDLGOLDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x7665F0", Offset = "0x7659F0", VA = "0x1807665F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x766600", Offset = "0x765A00", VA = "0x180766600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private KIMFLBFDMNG HPBLMCEOKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x7665D0", Offset = "0x7659D0", VA = "0x1807665D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public CPKNDJKPEFJ IALKDHMOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7699F0", Offset = "0x768DF0", VA = "0x1807699F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x769A00", Offset = "0x768E00", VA = "0x180769A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private JJOAKEFCJNP CPCCPCBLEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7654B0", Offset = "0x7648B0", VA = "0x1807654B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private DDJENBEKAAO BKAHBECLEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x7653D0", Offset = "0x7647D0", VA = "0x1807653D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BB50", Offset = "0x5E4AF50", VA = "0x185E4BB50", Slot = "12")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public HECJPBCACDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[FHOIBFDAOOA(typeof(CPBLFKHDDGN), new string[] { })]
public class CLFPOFKAHIG : CPBLFKHDDGN, PNLMNOEHBNA, KJICHBMECLA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private FIMDMOFKGJF MHCBJGOCOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private JPNIIOOOMOP KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private KBADIJFHJMJ GDJPIHBFICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private LMFELGCOCBG AKMKBNFOGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private GMEBHOOMEDK PIKEAKJOJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private EPEIHHNCIHD EHJFODOFCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private JFKABFIKFCO BADPICBHGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private DFLIKLKNDFH MJHCCCCPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private HGBLHAOBLKK NFBPBIFODIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private EEJAONCFMLK MNDGNFAOOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private FHBDOMJNNEJ JHBBLDGKGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private NCBLCPIDIEA JBLBJMHLOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private AEMEMLHFPNC NLGALCGOGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private JFDAFKCNFNC PJNMDDGPIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private EJLACCPBJAD GBEFHPGABOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private CMLGHDCNGPG EJMBOKJJOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private GLJHEKCADEF EKEDKPJCHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private CAMBFJGGDMI IJNDFBIKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private IBNLNIKJFKJ OOCONJNDKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private EKBKOBJCEAO DIHODDBACDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public FIMDMOFKGJF AGOENIEKEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public JPNIIOOOMOP IBEJPPJAKBH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public HONAKLLNIOE DELMCPMFCJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CDJJECGMMII LCJLLGELGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public GMEBHOOMEDK EFBMJCLPBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x76A450", Offset = "0x769850", VA = "0x18076A450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public EPEIHHNCIHD FIHFHBBKOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7653E0", Offset = "0x7647E0", VA = "0x1807653E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public JFKABFIKFCO LJIAHPNMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x766620", Offset = "0x765A20", VA = "0x180766620", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public HGBLHAOBLKK EHBCBJJGHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x7665F0", Offset = "0x7659F0", VA = "0x1807665F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public EEJAONCFMLK NIEPLNGJGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x7665C0", Offset = "0x7659C0", VA = "0x1807665C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public FHBDOMJNNEJ BGDAAGBHOIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x7699F0", Offset = "0x768DF0", VA = "0x1807699F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public NCBLCPIDIEA CPCCPCBLEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x7653B0", Offset = "0x7647B0", VA = "0x1807653B0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public AEMEMLHFPNC CEAOLLGHOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x765410", Offset = "0x764810", VA = "0x180765410", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public JFDAFKCNFNC MACMDECLGED
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7654E0", Offset = "0x7648E0", VA = "0x1807654E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public EJLACCPBJAD OJIKIGPDDLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x80AA90", Offset = "0x809E90", VA = "0x18080AA90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public CMLGHDCNGPG HMFFELCEKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x7653F0", Offset = "0x7647F0", VA = "0x1807653F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public GLJHEKCADEF BHKIMOFNAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8877D0", Offset = "0x886BD0", VA = "0x1808877D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public CAMBFJGGDMI GKBLEPDKEKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x769120", Offset = "0x768520", VA = "0x180769120", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IBNLNIKJFKJ IEECJPHCDDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x824280", Offset = "0x823680", VA = "0x180824280", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public EKBKOBJCEAO KFDKCHBJAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x89BB30", Offset = "0x89AF30", VA = "0x18089BB30", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public PKBFGGPEDBK EPEIEKGKMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x8015E0", Offset = "0x8009E0", VA = "0x1808015E0", Slot = "23")]
		get
		{
			return default(PKBFGGPEDBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E41810", Offset = "0x5E40C10", VA = "0x185E41810", Slot = "24")]
	public void KLMMKHHBOHM(FIMDMOFKGJF AACLFMKNBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E417E0", Offset = "0x5E40BE0", VA = "0x185E417E0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E417F0", Offset = "0x5E40BF0", VA = "0x185E417F0", Slot = "25")]
	public void GAPJGIMLFIN(FIMDMOFKGJF AACLFMKNBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public CLFPOFKAHIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[DefaultMember("Item")]
public class FJAGLNHDJEG : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class GLKPDGJPECE : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public FJAGLNHDJEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x8AE1F0", Offset = "0x8AD5F0", VA = "0x1808AE1F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0x5E4B560", Offset = "0x5E4A960", VA = "0x185E4B560", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public GLKPDGJPECE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B3A0", Offset = "0x5E4A7A0", VA = "0x185E4B3A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B510", Offset = "0x5E4A910", VA = "0x185E4B510", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private readonly List<ulong> NFFLCAOLBIM;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E477F0", Offset = "0x5E46BF0", VA = "0x185E477F0")]
	public FJAGLNHDJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E47770", Offset = "0x5E46B70", VA = "0x185E47770", Slot = "4")]
	[IteratorStateMachine(typeof(GLKPDGJPECE))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E47770", Offset = "0x5E46B70", VA = "0x185E47770", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[EAMFOLJMGFH(typeof(ILMDBJJKHAL))]
[FHOIBFDAOOA(typeof(MDENMKNBFKL), new string[] { })]
public class NGJGLFMOFLG : MDENMKNBFKL, IFKHMGNDLHA, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly Dictionary<int, NPCOHFDIHDL> CDLGPKCMADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private readonly Dictionary<NPCOHFDIHDL, int> FEEKEGCJLME;

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5E558C0", Offset = "0x5E54CC0", VA = "0x185E558C0", Slot = "6")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5E55540", Offset = "0x5E54940", VA = "0x185E55540", Slot = "7")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5E556B0", Offset = "0x5E54AB0", VA = "0x185E556B0")]
	private void MFDNEAILNFP(List<(NPCOHFDIHDL nameHash, HOFAJMHGPOB stableTypeHash, Type type)> NMLNNLIOHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5E553F0", Offset = "0x5E547F0", VA = "0x185E553F0", Slot = "4")]
	public NPCOHFDIHDL IOHABDODGHF(int CEOOILAHGGI)
	{
		return default(NPCOHFDIHDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x5E55640", Offset = "0x5E54A40", VA = "0x185E55640", Slot = "5")]
	public int LGPEKMMIDMH(NPCOHFDIHDL LJBNFNGNFKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5E55980", Offset = "0x5E54D80", VA = "0x185E55980")]
	public NGJGLFMOFLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[FHOIBFDAOOA(typeof(KNKIEHNOADO), new string[] { })]
public class IHDKNOKCPEO : KNKIEHNOADO, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	[DMNKPOGEHOO]
	private GENLJBHGPDA KDDNMNODBLK;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	private uint PNDBBIAHIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C950", Offset = "0x5E4BD50", VA = "0x185E4C950", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C9A0", Offset = "0x5E4BDA0", VA = "0x185E4C9A0", Slot = "5")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public IHDKNOKCPEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[FHOIBFDAOOA(typeof(LIKHNKHJBKG), new string[] { })]
public class ECBHILJCHJC : LIKHNKHJBKG, IFKHMGNDLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private ODDANHNKOCH BJAKFNBOKAA;

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5E46150", Offset = "0x5E45550", VA = "0x185E46150", Slot = "8")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x5E45C90", Offset = "0x5E45090", VA = "0x185E45C90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x5E45A30", Offset = "0x5E44E30", VA = "0x185E45A30", Slot = "4")]
	public void BIDOBNAKMAB(IKAJAHLJFMC PCOAABDKEED, NHGDGBFBAIF LNAKMGONIOO, ReadOnlySpan<byte> HOPEEMIHCOI, ReadOnlySpan<byte> FLPEKKAACDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x5E45D70", Offset = "0x5E45170", VA = "0x185E45D70", Slot = "7")]
	public bool FPLKEFDEEJM(IKAJAHLJFMC PCOAABDKEED, NHGDGBFBAIF LNAKMGONIOO, Span<byte> HOPEEMIHCOI, Span<byte> FLPEKKAACDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5E45CE0", Offset = "0x5E450E0", VA = "0x185E45CE0", Slot = "5")]
	public bool EEADKPFANCG(IKAJAHLJFMC PCOAABDKEED, NHGDGBFBAIF LNAKMGONIOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x5E46120", Offset = "0x5E45520", VA = "0x185E46120", Slot = "6")]
	public bool GFMKBBPNBAE(IKAJAHLJFMC PCOAABDKEED, NHGDGBFBAIF LNAKMGONIOO, ReadOnlySpan<byte> FLPEKKAACDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x5E45690", Offset = "0x5E44A90", VA = "0x185E45690")]
	private bool ALGDHPBCLBI(IKAJAHLJFMC PCOAABDKEED, NHGDGBFBAIF LNAKMGONIOO, ReadOnlySpan<byte> FLPEKKAACDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public ECBHILJCHJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class HNFOKJENMCL<T> : HAHLCCIPCJD<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	protected EDPNOIGGJDF<T> LPHIDJFAKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	protected NDBFJOJPCAL<T> LFDFOFHAJJE;

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x348DB40", Offset = "0x348CF40", VA = "0x18348DB40")]
	public HNFOKJENMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x3525EE0", Offset = "0x35252E0", VA = "0x183525EE0")]
	public HNFOKJENMCL(EDPNOIGGJDF<T> LPHIDJFAKCI, NDBFJOJPCAL<T> LFDFOFHAJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x3525770", Offset = "0x3524B70", VA = "0x183525770", Slot = "10")]
	protected override T HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x3525B40", Offset = "0x3524F40", VA = "0x183525B40", Slot = "11")]
	protected override void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM, T LPCGJALKADL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class MPFNAPOEIAI
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class LPCDKGMCFJF<T> : HNFOKJENMCL<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x39321A0", Offset = "0x39315A0", VA = "0x1839321A0")]
	public LPCDKGMCFJF(T MAKCHOBJLOO, T NFJOIFHGCKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class MCJIAGBJPPJ<T> : HAHLCCIPCJD<T> where T : struct, GJJMNANPJKP
{
	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE490", Offset = "0x3AED890", VA = "0x183AEE490", Slot = "10")]
	protected override T HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE520", Offset = "0x3AED920", VA = "0x183AEE520", Slot = "11")]
	protected override void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM, T LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x300F8F0", Offset = "0x300ECF0", VA = "0x18300F8F0")]
	public MCJIAGBJPPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class JPFBJOOINBB
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class JHKCBEJONOD
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private sealed class MLNDGJBDLMI<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public MLNDGJBDLMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x3B81170", Offset = "0x3B80570", VA = "0x183B81170")]
			internal void NLPCNKIFEEH(BMMCFOKNLEA writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0x3B80D80", Offset = "0x3B80180", VA = "0x183B80D80")]
			internal T MJDHGEJGAEC(FGNCKLJOJDM reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D8A0", Offset = "0x5E4CCA0", VA = "0x185E4D8A0")]
		public static void MFBOLCGHOHC(HOHOJKILAFG BKMNGPLOJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x29B0450", Offset = "0x29AF850", VA = "0x1829B0450")]
		private static void IDOMOFICBJE<T>(HOHOJKILAFG BKMNGPLOJED, int NFJOIFHGCKE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x29B0580", Offset = "0x29AF980", VA = "0x1829B0580")]
		private static void NFLODDIDNEF<T>(BMMCFOKNLEA OKFNJFEOHFM, T JMKAEDPOKOH, int NFJOIFHGCKE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x29AFE90", Offset = "0x29AF290", VA = "0x1829AFE90")]
		private static T DCHNEHPEHOF<T>(FGNCKLJOJDM FCCGPHFBEFP, int NFJOIFHGCKE) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public JHKCBEJONOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class CKAIDOHKPKA : EPJDDHOKMFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private HOHOJKILAFG BKMNGPLOJED;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x29AF130", Offset = "0x29AE530", VA = "0x1829AF130", Slot = "6")]
		public override void LFLFMBAAJCP<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x5E41720", Offset = "0x5E40B20", VA = "0x185E41720")]
		public static void FIKEBHJAJAN(HOHOJKILAFG BKMNGPLOJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x5E417D0", Offset = "0x5E40BD0", VA = "0x185E417D0")]
		public CKAIDOHKPKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E160", Offset = "0x5E4D560", VA = "0x185E4E160")]
	public static void GEJMAAIEBDG(HOHOJKILAFG BKMNGPLOJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E060", Offset = "0x5E4D460", VA = "0x185E4E060")]
	private static void BBEAMOMCEKI(BMMCFOKNLEA PCOIPGEOEOP, quaternion JMKAEDPOKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FC10", Offset = "0x5E4F010", VA = "0x185E4FC10")]
	private static quaternion JICHMMLNPEJ(FGNCKLJOJDM OADEONFPOBE)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2419C40", Offset = "0x2419040", VA = "0x182419C40")]
	public static void DLNJFALHNCL<T>(HOHOJKILAFG BKMNGPLOJED, EDPNOIGGJDF<T> LPHIDJFAKCI, NDBFJOJPCAL<T> LFDFOFHAJJE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2419BC0", Offset = "0x2418FC0", VA = "0x182419BC0")]
	public static void CCNHFDJMCEP<T>(HOHOJKILAFG EHDKAJFMMFD) where T : struct, GJJMNANPJKP
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public abstract class CGOCDENNOAH : BJHMFLEMCLP
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public abstract Type GKAOFJPDKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP, Span<byte> LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM, ReadOnlySpan<byte> LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected CGOCDENNOAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public abstract class HAHLCCIPCJD<T> : CGOCDENNOAH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public override Type GKAOFJPDKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x34FD8E0", Offset = "0x34FCCE0", VA = "0x1834FD8E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP);

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM, T LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x34FDDB0", Offset = "0x34FD1B0", VA = "0x1834FDDB0", Slot = "8")]
	public override void HNNKJEMPCFP(FGNCKLJOJDM FCCGPHFBEFP, Span<byte> ADOGMMPMLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x34FE5A0", Offset = "0x34FD9A0", VA = "0x1834FE5A0", Slot = "9")]
	public override void MFIMBGNEKOH(BMMCFOKNLEA OKFNJFEOHFM, ReadOnlySpan<byte> OFAFLOECBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
	protected HAHLCCIPCJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class CDFGCLFEHED
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct LNNLMGIDAPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CDJJECGMMII JJMFHKECKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public EGMLFPKLELH KKMKCLBNOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public KHBOFPBPOBG NCJPABNBAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public DJOMFACBNME IEDKLDPPILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public LIKHNKHJBKG NONGOADOCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public FAIPBIJPAFL BKMNGPLOJED;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5E53F80", Offset = "0x5E53380", VA = "0x185E53F80")]
		public void EGBIPNOEPPP(FIMDMOFKGJF MHCBJGOCOMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public struct KIDHPGMICDH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public NativeList<IKAJAHLJFMC> HOKMMKNDGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public NativeList<CHCOMAAHOED> CPBGBMAIAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public NativeList<IKAJAHLJFMC> MHGMJCFOGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public NativeParallelMultiHashMap<IKAJAHLJFMC, OJMPJJENPNO> MJHCCCCPHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public NativeList<byte> DGACLJAGMMB;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool OADCCJFALFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x5E4FD90", Offset = "0x5E4F190", VA = "0x185E4FD90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FCF0", Offset = "0x5E4F0F0", VA = "0x185E4FCF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private struct PJIDFINEJFJ : IComparer<OJMPJJENPNO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5E59100", Offset = "0x5E58500", VA = "0x185E59100", Slot = "4")]
		public int Compare(OJMPJJENPNO DCLOFHDPPBE, OJMPJJENPNO JMNKJKLHIOM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private static readonly FJOGIBEAJHF GGNNKBIIFDK;

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5E40780", Offset = "0x5E3FB80", VA = "0x185E40780")]
	public static void MGGNHIJOKPG(BMMCFOKNLEA OKFNJFEOHFM, KIDHPGMICDH OOIBMCBCEPD, LNNLMGIDAPF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5E40B90", Offset = "0x5E3FF90", VA = "0x185E40B90")]
	public static KIDHPGMICDH ONMJEBKLCPJ(FGNCKLJOJDM FCCGPHFBEFP, Allocator JIIMEDFKEME, LNNLMGIDAPF MHCBJGOCOMD)
	{
		return default(KIDHPGMICDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EC30", Offset = "0x5E3E030", VA = "0x185E3EC30")]
	public static void BIDOBNAKMAB(KIDHPGMICDH OOIBMCBCEPD, LNNLMGIDAPF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FD50", Offset = "0x5E3F150", VA = "0x185E3FD50")]
	public static void GFMKBBPNBAE(KIDHPGMICDH OOIBMCBCEPD, LNNLMGIDAPF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5E40A20", Offset = "0x5E3FE20", VA = "0x185E40A20")]
	public static int NFFLHNDKKED(KIDHPGMICDH OOIBMCBCEPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x5E40060", Offset = "0x5E3F460", VA = "0x185E40060")]
	private static void LCHMDJOMJOF(BMMCFOKNLEA OKFNJFEOHFM, NativeArray<IKAJAHLJFMC> HOKMMKNDGPI, NativeArray<CHCOMAAHOED> CPBGBMAIAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F030", Offset = "0x5E3E430", VA = "0x185E3F030")]
	private static void CFJMHHLJKNE(FGNCKLJOJDM FCCGPHFBEFP, Allocator JIIMEDFKEME, [Out] NativeList<IKAJAHLJFMC> HOKMMKNDGPI, [Out] NativeList<CHCOMAAHOED> AICDLFEPIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FBC0", Offset = "0x5E3EFC0", VA = "0x185E3FBC0")]
	private static void CPJONHCBEMD(BMMCFOKNLEA OKFNJFEOHFM, NativeArray<IKAJAHLJFMC> MHGMJCFOGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FC50", Offset = "0x5E3F050", VA = "0x185E3FC50")]
	private static void CPPDEMHHBLP(FGNCKLJOJDM FCCGPHFBEFP, Allocator JIIMEDFKEME, [Out] NativeList<IKAJAHLJFMC> MHGMJCFOGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F1C0", Offset = "0x5E3E5C0", VA = "0x185E3F1C0")]
	private static void CKHFKONCADD(BMMCFOKNLEA OKFNJFEOHFM, NativeParallelMultiHashMap<IKAJAHLJFMC, OJMPJJENPNO> MJHCCCCPHBO, NativeList<byte> DGACLJAGMMB, LNNLMGIDAPF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x5E40130", Offset = "0x5E3F530", VA = "0x185E40130")]
	private static void LFLKGMILGGO(FGNCKLJOJDM FCCGPHFBEFP, Allocator JIIMEDFKEME, [Out] NativeParallelMultiHashMap<IKAJAHLJFMC, OJMPJJENPNO> MJHCCCCPHBO, [Out] NativeList<byte> DGACLJAGMMB, LNNLMGIDAPF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x5E40B70", Offset = "0x5E3FF70", VA = "0x185E40B70")]
	private static void ONKLJKAPLGM(int BKMHAMCJDDF, int CANBHFODBOL, BMMCFOKNLEA OKFNJFEOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x5E40040", Offset = "0x5E3F440", VA = "0x185E40040")]
	private static int ILBJPGLNFCP(int CANBHFODBOL, FGNCKLJOJDM FCCGPHFBEFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[FHOIBFDAOOA(typeof(HNKKIALLFBA), new string[] { })]
internal sealed class NODAGECAOKM : HNKKIALLFBA, IFKHMGNDLHA, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Dictionary<NHGDGBFBAIF, EFJKFDNPHHB> LHLENCFMAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private EGMLFPKLELH MJHCCCCPHBO;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x5E55C50", Offset = "0x5E55050", VA = "0x185E55C50", Slot = "6")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x5E55BF0", Offset = "0x5E54FF0", VA = "0x185E55BF0", Slot = "7")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x5E55B80", Offset = "0x5E54F80", VA = "0x185E55B80", Slot = "4")]
	public void GFCMFFOEFBO(NHGDGBFBAIF LNAKMGONIOO, Type GHFMALLEBKD, EFJKFDNPHHB HENPJKGACEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x5E55B10", Offset = "0x5E54F10", VA = "0x185E55B10", Slot = "5")]
	public bool CKBEIJEBHOM(NHGDGBFBAIF LNAKMGONIOO, [Out] EFJKFDNPHHB HENPJKGACEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x5E55CA0", Offset = "0x5E550A0", VA = "0x185E55CA0")]
	public NODAGECAOKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[FHOIBFDAOOA(typeof(JCFKEMAHKEJ), new string[] { })]
internal class KLKKLEMOEEA : ENDDIKHKCDF, JCFKEMAHKEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[DMNKPOGEHOO]
	private KNKIEHNOADO JKFKBDCHGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private HNCJOLMBHOI NHDEOLLOJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private int MMIIBGANAFB;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x5E53860", Offset = "0x5E52C60", VA = "0x185E53860", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x5E53730", Offset = "0x5E52B30", VA = "0x185E53730", Slot = "5")]
	public KFHEKKOEHDF HALOCBBBACF(ReadOnlySpan<byte> CJFCIOOMJGN)
	{
		return default(KFHEKKOEHDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5E53720", Offset = "0x5E52B20", VA = "0x185E53720", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KLKKLEMOEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[FHOIBFDAOOA(typeof(DJOMFACBNME), new string[] { })]
internal sealed class CEFAEBBMMPE : DJOMFACBNME, ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	[DMNKPOGEHOO]
	private EGMLFPKLELH MJHCCCCPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private NativeBitArray GJFOJEDJCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private NativeParallelHashMap<IKAJAHLJFMC, int> DLPKMMJLNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private NativeList<int> BEGGMAKMIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private int AONFHIALIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private int BECMBIAKMKI;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool ENLBFFMNMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x5E41640", Offset = "0x5E40A40", VA = "0x185E41640", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public FLHKGHBAAMG IFFBKABLDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x5E40F70", Offset = "0x5E40370", VA = "0x185E40F70", Slot = "7")]
		get
		{
			return default(FLHKGHBAAMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x5E411E0", Offset = "0x5E405E0", VA = "0x185E411E0", Slot = "4")]
	public bool EBCGHJDNCEE(IKAJAHLJFMC MIPKLHDFLBO, NHGDGBFBAIF OIBKEMMFJDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x5E41260", Offset = "0x5E40660", VA = "0x185E41260", Slot = "8")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5E40FC0", Offset = "0x5E403C0", VA = "0x185E40FC0", Slot = "6")]
	public void DJECLGDMNGP(NativeArray<IKAJAHLJFMC> LLBGDKONGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x5E413C0", Offset = "0x5E407C0", VA = "0x185E413C0", Slot = "5")]
	public void JCFDCBAHABD(IKAJAHLJFMC MIPKLHDFLBO, Span<NHGDGBFBAIF> MJHCCCCPHBO, bool IJMJAJBCLEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x5E41150", Offset = "0x5E40550", VA = "0x185E41150", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public CEFAEBBMMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[FHOIBFDAOOA(typeof(FAIPBIJPAFL), new string[] { })]
public sealed class NAJJHAOOEIJ : FAIPBIJPAFL, KGOEGJIDJFF<FAIPBIJPAFL>, IFKHMGNDLHA, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly Dictionary<NHGDGBFBAIF, BJHMFLEMCLP> BKMNGPLOJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private HOHOJKILAFG BCGHIKJDMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private EGMLFPKLELH MJHCCCCPHBO;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool KPKEIHPMAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x7E06E0", Offset = "0x7DFAE0", VA = "0x1807E06E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5E55180", Offset = "0x5E54580", VA = "0x185E55180")]
	public NAJJHAOOEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5E55090", Offset = "0x5E54490", VA = "0x185E55090", Slot = "5")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5E55010", Offset = "0x5E54410", VA = "0x185E55010", Slot = "6")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5E54DF0", Offset = "0x5E541F0", VA = "0x185E54DF0", Slot = "4")]
	public bool ICFEPCNMLOH(NHGDGBFBAIF KOJKDECJOKK, [Out] BJHMFLEMCLP EHDKAJFMMFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[FHOIBFDAOOA(typeof(HOHOJKILAFG), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal sealed class HOHOJKILAFG : IFKHMGNDLHA
{
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private readonly Dictionary<Type, BJHMFLEMCLP> BKMNGPLOJED;

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C490", Offset = "0x5E4B890", VA = "0x185E4C490", Slot = "4")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C2A0", Offset = "0x5E4B6A0", VA = "0x185E4C2A0")]
	public void GFCMFFOEFBO(Type DJMKKNDNCBM, BJHMFLEMCLP EHDKAJFMMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C3C0", Offset = "0x5E4B7C0", VA = "0x185E4C3C0")]
	public bool ICFEPCNMLOH(Type DJMKKNDNCBM, [Out] BJHMFLEMCLP EHDKAJFMMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C570", Offset = "0x5E4B970", VA = "0x185E4C570")]
	public HOHOJKILAFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class IMJGEFBKDPE
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C9F0", Offset = "0x5E4BDF0", VA = "0x185E4C9F0")]
	public static void GFCMFFOEFBO(this HOHOJKILAFG CDNLGICPHJL, BJHMFLEMCLP EHDKAJFMMFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class BHMNOBJBAJP : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private HEKCKKAGEFC KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private EntityQuery GKKJHMLNAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private EntityQuery PAEOBGECBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private EntityQuery NJJDLBJJNJP;

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E5D0", Offset = "0x5E3D9D0", VA = "0x185E3E5D0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E9C0", Offset = "0x5E3DDC0", VA = "0x185E3E9C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EB60", Offset = "0x5E3DF60", VA = "0x185E3EB60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EB30", Offset = "0x5E3DF30", VA = "0x185E3EB30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E640", Offset = "0x5E3DA40", VA = "0x185E3E640")]
	private void NKJOIJGJFKG(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DC30", Offset = "0x5E3D030", VA = "0x185E3DC30")]
	private void FILFNHOMGGC(NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E2E0", Offset = "0x5E3D6E0", VA = "0x185E3E2E0")]
	private void IEKLNLKPMAK(NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DED0", Offset = "0x5E3D2D0", VA = "0x185E3DED0")]
	private void GDKKLKGIJJM(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E0D0", Offset = "0x5E3D4D0", VA = "0x185E3E0D0")]
	private void GFFBGBHFLEE(NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DDD0", Offset = "0x5E3D1D0", VA = "0x185E3DDD0")]
	private void FKMFJENMHNA(CAKFEHOBCAO AJAFIOGCMHP, int JNIFDEFBBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public BHMNOBJBAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class OJLNMJAMGMH : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private HEKCKKAGEFC KDDNMNODBLK;

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5E572E0", Offset = "0x5E566E0", VA = "0x185E572E0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x5E57330", Offset = "0x5E56730", VA = "0x185E57330", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x5E573F0", Offset = "0x5E567F0", VA = "0x185E573F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x5E56D50", Offset = "0x5E56150", VA = "0x185E56D50")]
	private void FFJLDLHIIAN(NativeArray<Entity> JIBDNODJOAB, NativeList<Entity> OEABJNDFPJF, ComponentDataFromEntity<DBBMMELOINJ> KFGFMCEHFON, BufferFromEntity<ChildrenData> DFKNIPLOJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public OJLNMJAMGMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[AlwaysUpdateSystem]
internal class LAAJLJINGKH : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public LAAJLJINGKH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class UpdateAuthoredChildrenFromParent : ParentSystemBase<AuthoredParentData, AuthoredPreviousParentData, AuthoredChildrenData>
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x5E59D30", Offset = "0x5E59130", VA = "0x185E59D30", Slot = "14")]
		protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x880870", Offset = "0x87FC70", VA = "0x180880870", Slot = "15")]
		protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x5E59CF0", Offset = "0x5E590F0", VA = "0x185E59CF0", Slot = "16")]
		protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x5E59CB0", Offset = "0x5E590B0", VA = "0x185E59CB0", Slot = "17")]
		protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5E59D70", Offset = "0x5E59170", VA = "0x185E59D70")]
		public UpdateAuthoredChildrenFromParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class FOIGDIMJKDE : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private object NOJOGHAGAIG;

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x5E48AD0", Offset = "0x5E47ED0", VA = "0x185E48AD0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E48B50", Offset = "0x5E47F50", VA = "0x185E48B50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E48C00", Offset = "0x5E48000", VA = "0x185E48C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public FOIGDIMJKDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class LEIJAFONBDM : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private object NOJOGHAGAIG;

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E53920", Offset = "0x5E52D20", VA = "0x185E53920", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E539A0", Offset = "0x5E52DA0", VA = "0x185E539A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E53A50", Offset = "0x5E52E50", VA = "0x185E53A50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public LEIJAFONBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[InternalBufferCapacity(1)]
internal struct HIMFPHIKGHO : ISystemStateBufferElementData, IBufferElementData, IEquatable<HIMFPHIKGHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public DCHJNMLMIEC EKHBDCNGFLP;

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E41F10", Offset = "0x5E41310", VA = "0x185E41F10", Slot = "4")]
	public bool Equals(HIMFPHIKGHO KEEHOGPOIFD)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	public static HIMFPHIKGHO DLNOOKJDMMJ(DCHJNMLMIEC EKHBDCNGFLP)
	{
		return default(HIMFPHIKGHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[InternalBufferCapacity(4)]
internal struct JMHBKGKHCED : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public DCHJNMLMIEC EKHBDCNGFLP;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal abstract class AMMHBADCADN : JENCGOOIOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D810", Offset = "0x5E3CC10", VA = "0x185E3D810", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DAF0", Offset = "0x5E3CEF0", VA = "0x185E3DAF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DBE0", Offset = "0x5E3CFE0", VA = "0x185E3DBE0")]
	protected AMMHBADCADN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[MEBHHNIGJKC]
internal abstract class JENCGOOIOFH : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected CAMBFJGGDMI IJNDFBIKOFO;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	protected abstract GEBKBDKDAKJ GJHJNOFLKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CDB0", Offset = "0x5E4C1B0", VA = "0x185E4CDB0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CE20", Offset = "0x5E4C220", VA = "0x185E4CE20")]
	protected void JBICGCJPGJE(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D0C0", Offset = "0x5E4C4C0", VA = "0x185E4D0C0")]
	protected void KNKDBHBAALB(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CD40", Offset = "0x5E4C140", VA = "0x185E4CD40")]
	protected KLCLLLJMBOO AJACMJHHLOJ(EntityQuery OGHCNPNLAEN)
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	protected JENCGOOIOFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal abstract class MKBGENMIGKG : JENCGOOIOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private EntityQuery BHBHBFGMPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private EntityQuery JJHHOCEAOFM;

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E549E0", Offset = "0x5E53DE0", VA = "0x185E549E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E54D40", Offset = "0x5E54140", VA = "0x185E54D40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E548F0", Offset = "0x5E53CF0", VA = "0x185E548F0")]
	private void MMCODMPMMEK(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E45420", Offset = "0x5E44820", VA = "0x185E45420")]
	protected MKBGENMIGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class LKINLHGEDOI : AMMHBADCADN
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	protected override GEBKBDKDAKJ GJHJNOFLKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E53EB0", Offset = "0x5E532B0", VA = "0x185E53EB0", Slot = "15")]
		get
		{
			return default(GEBKBDKDAKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DBE0", Offset = "0x5E3CFE0", VA = "0x185E3DBE0")]
	public LKINLHGEDOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class EAAJDIIIEJJ : MKBGENMIGKG
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	protected override GEBKBDKDAKJ GJHJNOFLKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E453B0", Offset = "0x5E447B0", VA = "0x185E453B0", Slot = "15")]
		get
		{
			return default(GEBKBDKDAKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E45420", Offset = "0x5E44820", VA = "0x185E45420")]
	public EAAJDIIIEJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal class NGLNPBBPEMF : AMMHBADCADN
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	protected override GEBKBDKDAKJ GJHJNOFLKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E55AA0", Offset = "0x5E54EA0", VA = "0x185E55AA0", Slot = "15")]
		get
		{
			return default(GEBKBDKDAKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DBE0", Offset = "0x5E3CFE0", VA = "0x185E3DBE0")]
	public NGLNPBBPEMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class HKKFOJAOLJC : MKBGENMIGKG
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	protected override GEBKBDKDAKJ GJHJNOFLKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E4BE10", Offset = "0x5E4B210", VA = "0x185E4BE10", Slot = "15")]
		get
		{
			return default(GEBKBDKDAKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E45420", Offset = "0x5E44820", VA = "0x185E45420")]
	public HKKFOJAOLJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal class HNONHKPNIIP : AMMHBADCADN
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	protected override GEBKBDKDAKJ GJHJNOFLKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C230", Offset = "0x5E4B630", VA = "0x185E4C230", Slot = "15")]
		get
		{
			return default(GEBKBDKDAKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DBE0", Offset = "0x5E3CFE0", VA = "0x185E3DBE0")]
	public HNONHKPNIIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class IEPEIEKDHJC : MKBGENMIGKG
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected override GEBKBDKDAKJ GJHJNOFLKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C8E0", Offset = "0x5E4BCE0", VA = "0x185E4C8E0", Slot = "15")]
		get
		{
			return default(GEBKBDKDAKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E45420", Offset = "0x5E44820", VA = "0x185E45420")]
	public IEPEIEKDHJC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal struct HPADFOLJEHH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct INDLHADPMGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal struct JDIELDEDKMJ : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public readonly struct GEBKBDKDAKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public readonly ComponentType? JAICPDJLPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public readonly ComponentType? CAPGPELFIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public readonly ComponentType HHDBBMPPLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public readonly object IBLOMPOENGH;

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E492B0", Offset = "0x5E486B0", VA = "0x185E492B0")]
	public GEBKBDKDAKJ(ComponentType? JAICPDJLPOO, ComponentType? CAPGPELFIFP, ComponentType HHDBBMPPLPN, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x23C19C0", Offset = "0x23C0DC0", VA = "0x1823C19C0")]
	public static GEBKBDKDAKJ FAKANCHAAFF<TReq, TTag>(object IBLOMPOENGH)
	{
		return default(GEBKBDKDAKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x23C17A0", Offset = "0x23C0BA0", VA = "0x1823C17A0")]
	public static GEBKBDKDAKJ EFMEFKKOKFF<TReq, TMissing, TTag>(object IBLOMPOENGH)
	{
		return default(GEBKBDKDAKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class NENCPNCFNIA
{
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly GEBKBDKDAKJ OJIKIGPDDLG;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly GEBKBDKDAKJ MODOGNEKGEM;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly GEBKBDKDAKJ FBJHPECEFDK;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal struct DCHJNMLMIEC : CEILLBLPNIE, IEquatable<DCHJNMLMIEC>
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public int ICOODGEKGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D2F60", Offset = "0x7D2360", VA = "0x1807D2F60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public int CIBDPGBBMPH
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x5220E10", Offset = "0x5220210", VA = "0x185220E10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E41F10", Offset = "0x5E41310", VA = "0x185E41F10", Slot = "8")]
	public bool Equals(DCHJNMLMIEC KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E41F60", Offset = "0x5E41360", VA = "0x185E41F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	[MEBHHNIGJKC]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	public class UpdateConnectableVisuals : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		private struct HandlePosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public DCHJNMLMIEC handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public float3 position;

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x4296AA0", Offset = "0x4295EA0", VA = "0x184296AA0")]
			public HandlePosition(DCHJNMLMIEC handle, float3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E6A740", Offset = "0x5E69B40", VA = "0x185E6A740")]
			public void MJDAIICEPID([Out] DCHJNMLMIEC handle, [Out] float3 position)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		private struct UpdateVisualPositions_ParentWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public UpdateConnectableVisuals __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[ReadOnly]
			public ComponentTypeHandle<NJLFDIIMCKB> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public BufferTypeHandle<JMHBKGKHCED> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x5E7EE70", Offset = "0x5E7E270", VA = "0x185E7EE70")]
			private void DGGBDJJHEJJ(Entity entity, [In] NJLFDIIMCKB pose, DynamicBuffer<JMHBKGKHCED> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F120", Offset = "0x5E7E520", VA = "0x185E7F120", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct UpdateVisualPositions_ChildWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			[ReadOnly]
			public ComponentTypeHandle<NJLFDIIMCKB> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			public BufferTypeHandle<HIMFPHIKGHO> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x5E7EC10", Offset = "0x5E7E010", VA = "0x185E7EC10")]
			private void DGGBDJJHEJJ([In][NoAlias] NJLFDIIMCKB pose, DynamicBuffer<HIMFPHIKGHO> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x5E7ED00", Offset = "0x5E7E100", VA = "0x185E7ED00", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct UpdateVisualPositions_ChildWithCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			[ReadOnly]
			public ComponentTypeHandle<NJLFDIIMCKB> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			[ReadOnly]
			public ComponentTypeHandle<OKHCIHCBDMO> __comTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public BufferTypeHandle<HIMFPHIKGHO> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x5E7E8C0", Offset = "0x5E7DCC0", VA = "0x185E7E8C0")]
			private void DGGBDJJHEJJ([In][NoAlias] NJLFDIIMCKB pose, [In][NoAlias] OKHCIHCBDMO com, DynamicBuffer<HIMFPHIKGHO> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x5E7EA30", Offset = "0x5E7DE30", VA = "0x185E7EA30", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery addGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery addGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery updateGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery updateGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery removeExpiredGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery removeExpiredGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery removeAllGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private EntityQuery queryLegacyGizmoParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private EntityQuery queryChildrenWoutCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private EntityQuery queryChildrenWithCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private BMOENLKLHFA<DCHJNMLMIEC, HMJPDGHCKHI> linkVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private GLJHEKCADEF connectables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private CDJJECGMMII objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private NCBLCPIDIEA scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private KIOMKHMJPMB makerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery UpdateVisualPositions_ParentWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private EntityQuery UpdateVisualPositions_ChildWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private EntityQuery UpdateVisualPositions_ChildWithCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private ComponentTypeHandle<NJLFDIIMCKB> __RecRoom_Components_WorldPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private ComponentTypeHandle<OKHCIHCBDMO> __RecRoom_Rbex_RbexLocalCenterOfMassOfSelfData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x5E5B620", Offset = "0x5E5AA20", VA = "0x185E5B620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E660", Offset = "0x5E5DA60", VA = "0x185E5E660")]
		internal HMJPDGHCKHI POCABIMFNHP(DCHJNMLMIEC handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C4B0", Offset = "0x5E5B8B0", VA = "0x185E5C4B0", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E0D0", Offset = "0x5E5D4D0", VA = "0x185E5E0D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E360", Offset = "0x5E5D760", VA = "0x185E5E360", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E4F0", Offset = "0x5E5D8F0", VA = "0x185E5E4F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E320", Offset = "0x5E5D720", VA = "0x185E5E320", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B280", Offset = "0x5E5A680", VA = "0x185E5B280")]
		private void FOLLDDIKPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A980", Offset = "0x5E59D80", VA = "0x185E5A980")]
		private void COEHDILCIOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5BE80", Offset = "0x5E5B280", VA = "0x185E5BE80")]
		private void ICPMNCPEOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E530", Offset = "0x5E5D930", VA = "0x185E5E530", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE70", Offset = "0x5E5C270", VA = "0x185E5CE70")]
		private void MCPJDCOFDHA(EntityQuery add, EntityQuery update, EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B660", Offset = "0x5E5AA60", VA = "0x185E5B660")]
		private void HFJFDMFKDND(EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D670", Offset = "0x5E5CA70", VA = "0x185E5D670")]
		private void OAPDEOPGLCD(NativeArrayAsync<Entity> oldEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B7D0", Offset = "0x5E5ABD0", VA = "0x185E5B7D0")]
		private void HKDAOIIIPKN(NativeArrayAsync<Entity> newEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E59DB0", Offset = "0x5E591B0", VA = "0x185E59DB0")]
		private void ABHGMGNBNDO(NativeArrayAsync<Entity> updateEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A800", Offset = "0x5E59C00", VA = "0x185E5A800")]
		private void CIFOPMJJCGJ(NativeList<DCHJNMLMIEC> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A0F0", Offset = "0x5E594F0", VA = "0x185E5A0F0")]
		private NativeList<DCHJNMLMIEC> ALGJHFLHJPM(NativeArray<Entity> entities)
		{
			return default(NativeList<DCHJNMLMIEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5AAD0", Offset = "0x5E59ED0", VA = "0x185E5AAD0")]
		private void DAOCFPIFPCD(NativeArray<Entity> entities, NativeList<DCHJNMLMIEC> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B8D0", Offset = "0x5E5ACD0", VA = "0x185E5B8D0")]
		private void ICHBDCGDILH(NativeArray<Entity> addParents, NativeArray<Entity> addChildren, NativeList<DCHJNMLMIEC> freeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C990", Offset = "0x5E5BD90", VA = "0x185E5C990")]
		private void MBEPOIAIAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B4E0", Offset = "0x5E5A8E0", VA = "0x185E5B4E0")]
		private NativeListAsync<HandlePosition> GNDHJMMKNEL(EntityQuery query, Func<NativeList<HandlePosition>, JobHandle> populateHandles)
		{
			return default(NativeListAsync<HandlePosition>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D510", Offset = "0x5E5C910", VA = "0x185E5D510")]
		private JobHandle NKABNECJNCB(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C820", Offset = "0x5E5BC20", VA = "0x185E5C820")]
		private JobHandle LMCDKNJILHP(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E59F60", Offset = "0x5E59360", VA = "0x185E59F60")]
		private JobHandle AICCABGNKMN(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C200", Offset = "0x5E5B600", VA = "0x185E5C200")]
		private void IIGJLGLOMHJ(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C570", Offset = "0x5E5B970", VA = "0x185E5C570")]
		private void KDHNFGDLKDM(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B750", Offset = "0x5E5AB50", VA = "0x185E5B750")]
		private bool HGCLFALLELB(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D930", Offset = "0x5E5CD30", VA = "0x185E5D930")]
		private NativeArray<Entity> OEOFPDNPDCL(Entity entity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B0C0", Offset = "0x5E5A4C0", VA = "0x185E5B0C0")]
		private DCHJNMLMIEC FNMGFBCONAM(NativeList<DCHJNMLMIEC> freeList)
		{
			return default(DCHJNMLMIEC);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DA00", Offset = "0x5E5CE00", VA = "0x185E5DA00")]
		private void OEPAPMOMILM(DCHJNMLMIEC handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B3A0", Offset = "0x5E5A7A0", VA = "0x185E5B3A0")]
		private void GHKBMMIALHF(NativeList<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A6A0", Offset = "0x5E59AA0", VA = "0x185E5A6A0")]
		private JobHandle CHCPFNIAHAB(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D380", Offset = "0x5E5C780", VA = "0x185E5D380")]
		private JobHandle MOOFAIKPJFG(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DA90", Offset = "0x5E5CE90", VA = "0x185E5DA90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public UpdateConnectableVisuals()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	public class CalculateCollisionIslandUpdatesSystem : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct CalculateCollisionIslandUpdatesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<Entity> rootsWithForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public NativeList<Entity> rootsWithoutForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[ReadOnly]
			public ComponentTypeHandle<FMKBPPGJGLB> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			[ReadOnly]
			public ComponentDataFromEntity<FMKBPPGJGLB> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			[ReadOnly]
			public ComponentTypeHandle<JLDGOFKMBDC> splineParentHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			public EntityQueryInJob changedLocalPoseQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			public EntityQueryInJob changedSplinePointsQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			public EntityQueryInJob splinesWithChangedChildrenQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			public EntityQueryInJob changedCollisionModeQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public EntityQueryInJob changedScopeRootQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x5E61BA0", Offset = "0x5E60FA0", VA = "0x185E61BA0")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x5E623A0", Offset = "0x5E617A0", VA = "0x185E623A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private EntityQuery changedLocalPoseQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private EntityQuery changedSplinePointsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private EntityQuery splinesWithChangedChildrenQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private EntityQuery changedCollisionModeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private EntityQuery scopeRootChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private DPIEMLJJLCJ collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E61B50", Offset = "0x5E60F50", VA = "0x185E61B50", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x5E623B0", Offset = "0x5E617B0", VA = "0x185E623B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x5E62740", Offset = "0x5E61B40", VA = "0x185E62740", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x5E619B0", Offset = "0x5E60DB0", VA = "0x185E619B0")]
		private JobHandle IGJLCLAFHNO(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<FMKBPPGJGLB> collisionIslandRootDataHandleRO, ComponentDataFromEntity<FMKBPPGJGLB> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<JLDGOFKMBDC> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[BurstCompatible]
internal readonly struct HDDDHLHLGAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly KPBKEHJCKKA KGIKLOFHJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private readonly PBNNEOGGDLO NOIHOGLAIJL;

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x962380", Offset = "0x961780", VA = "0x180962380")]
	public HDDDHLHLGAH(KPBKEHJCKKA KGIKLOFHJCB, PBNNEOGGDLO NOIHOGLAIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x1B4D870", Offset = "0x1B4CC70", VA = "0x181B4D870")]
	public bool GCPEMCOJBGP(HDDDHLHLGAH DCLCDDGJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x1B4D870", Offset = "0x1B4CC70", VA = "0x181B4D870")]
	public bool DMGLINMCLOI(HDDDHLHLGAH PPNMHLJNNKC)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	public class CalculateContainerCollisionIslandGraphChangesSystem : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[BurstCompile]
		private struct FindChangedIslandsJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			[ReadOnly]
			public EntityQueryInJob deletedConnectablesQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			[ReadOnly]
			public EntityQueryInJob changedIslandQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			[ReadOnly]
			public EntityQueryInJob hierarchyChangeQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			[ReadOnly]
			public EntityQueryInJob newRootsQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			[ReadOnly]
			public ChunkFilterAnyOf2ComponentsChanged islandSplitChangeFilterRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			[ReadOnly]
			public ComponentTypeHandle<MDODANHOEAN> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			[ReadOnly]
			public ComponentDataFromEntity<DDHBJPEDLDC> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			[ReadOnly]
			public ComponentDataFromEntity<KPBKEHJCKKA> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			[ReadOnly]
			public ComponentDataFromEntity<PBNNEOGGDLO> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			[ReadOnly]
			public ComponentDataFromEntity<MAEDGDFFCIF> containerCollisionIslandRootTagRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			[ReadOnly]
			public ComponentDataFromEntity<ParentData> parentRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> childrenRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			[WriteOnly]
			public NativeList<Entity> changedIslandComponentsBufferWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			[WriteOnly]
			public NativeList<NIGMGKHOBML> changedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[WriteOnly]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[WriteOnly]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			public ComponentDataFromEntity<FMKBPPGJGLB> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x5E65850", Offset = "0x5E64C50", VA = "0x185E65850", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x5E656A0", Offset = "0x5E64AA0", VA = "0x185E656A0")]
			private void ENCBMIEPNED(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x5E66170", Offset = "0x5E65570", VA = "0x185E66170")]
			private Entity JEMIGAMMPOE(Entity curEntity, HDDDHLHLGAH classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x5E65450", Offset = "0x5E64850", VA = "0x185E65450")]
			private bool CBKMEGEEFNL(Entity curEntity, HDDDHLHLGAH classifier, [Out] Entity parentEntity, [Out] HDDDHLHLGAH parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x5E66280", Offset = "0x5E65680", VA = "0x185E66280")]
			private void KGLMKHJMCAH(Entity islandRoot, HDDDHLHLGAH classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0x5E65F00", Offset = "0x5E65300", VA = "0x185E65F00")]
			private void ILDAFIBFFPH(Entity islandRoot, Entity entity, HDDDHLHLGAH classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x5E65510", Offset = "0x5E64910", VA = "0x185E65510")]
			private void DJOAKMHPDMM(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x5E661F0", Offset = "0x5E655F0", VA = "0x185E661F0")]
			private bool KGHINHEDGKK(Entity entity, [Out] HDDDHLHLGAH classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x5E65620", Offset = "0x5E64A20", VA = "0x185E65620")]
			private HDDDHLHLGAH DKCEKLMHGJB(Entity entity)
			{
				return default(HDDDHLHLGAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct CalculateContainerCollisionIslandGraphChangesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			[ReadOnly]
			public EntityTypeHandle entityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x5E638D0", Offset = "0x5E62CD0", VA = "0x185E638D0")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x5E63A00", Offset = "0x5E62E00", VA = "0x185E63A00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		[DMNKPOGEHOO]
		private DPIEMLJJLCJ collisionIslandService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private EntityQuery changedIslandStructureQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private EntityQuery hierarchyChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private EntityQuery newRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private EntityQuery deletedConnectablesQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private EntityQuery deletedRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private EntityQuery islandRootDataQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private EntityQuery islandRootTagQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private LOIGKNDBNGH ecbs;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x5E63880", Offset = "0x5E62C80", VA = "0x185E63880", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x5E63A10", Offset = "0x5E62E10", VA = "0x185E63A10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x5E63E60", Offset = "0x5E63260", VA = "0x185E63E60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x5E63020", Offset = "0x5E62420", VA = "0x185E63020")]
		private JobHandle DAKOHEJBJEC(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x5E62D60", Offset = "0x5E62160", VA = "0x185E62D60")]
		private JobHandle BGIBBLLOGKF(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x5E63780", Offset = "0x5E62B80", VA = "0x185E63780")]
		private JobHandle IAIAKPNLCPK(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
[AlwaysUpdateSystem]
public class CDDHENBMBPO : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	[DMNKPOGEHOO]
	private DPIEMLJJLCJ KOPFILKLHFF;

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x5E60C90", Offset = "0x5E60090", VA = "0x185E60C90", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x5E60CE0", Offset = "0x5E600E0", VA = "0x185E60CE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CDDHENBMBPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class OCEFNJNIBIM : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private GMEBHOOMEDK PIKEAKJOJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private NAFMALLINPC NBFFDCDNEHP;

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x5E74560", Offset = "0x5E73960", VA = "0x185E74560", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x5E744D0", Offset = "0x5E738D0", VA = "0x185E744D0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x5E74670", Offset = "0x5E73A70", VA = "0x185E74670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public OCEFNJNIBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class FANNBBCPEMM : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public CGNNELOIABF LKCOHANNNDC;

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FANNBBCPEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public FANNBBCPEMM(CGNNELOIABF LKCOHANNNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x5E649F0", Offset = "0x5E63DF0", VA = "0x185E649F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public abstract class NINOIMJMOGK : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private HFHCOKNIOMB GIKKACIEGBJ;

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x5E73350", Offset = "0x5E72750", VA = "0x185E73350", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x5E733B0", Offset = "0x5E727B0", VA = "0x185E733B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x5E733E0", Offset = "0x5E727E0", VA = "0x185E733E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	protected NINOIMJMOGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public class NJPJOODBIOM : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery MPHHNLOJFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private EntityQuery BLDHGBHLNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private EntityQuery BFDNKMJEDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private EntityQuery OJKNKLHAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private HFHCOKNIOMB JBNGLCLDNKN;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public int GGLIIBAHGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x5E73500", Offset = "0x5E72900", VA = "0x185E73500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x5E738D0", Offset = "0x5E72CD0", VA = "0x185E738D0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x5E73A10", Offset = "0x5E72E10", VA = "0x185E73A10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x5E73C40", Offset = "0x5E73040", VA = "0x185E73C40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x5E739F0", Offset = "0x5E72DF0", VA = "0x185E739F0")]
	public int MKOLLPMKNFD(SceneTag KJAEFLADAPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x5E735E0", Offset = "0x5E729E0", VA = "0x185E735E0")]
	protected void FMHJDHDFBKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x5E737A0", Offset = "0x5E72BA0", VA = "0x185E737A0")]
	protected void GACAOKCMBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x5E73590", Offset = "0x5E72990", VA = "0x185E73590")]
	public NativeArrayAsync<Entity> FGIDHPBGAHD(SceneTag KJAEFLADAPH, Allocator JIIMEDFKEME = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x5E739A0", Offset = "0x5E72DA0", VA = "0x185E739A0")]
	public NativeArrayAsync<Entity> LOLIFLFKGJO(SceneTag KJAEFLADAPH, Allocator JIIMEDFKEME = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x5E73C60", Offset = "0x5E73060", VA = "0x185E73C60")]
	public bool PGCIGFGHAGG(SceneTag KJAEFLADAPH, [Out] NativeArrayAsync<Entity> LKCOHANNNDC, Allocator JIIMEDFKEME = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x5E73400", Offset = "0x5E72800", VA = "0x185E73400")]
	public bool BDLMEDCBLOE(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x5E73930", Offset = "0x5E72D30", VA = "0x185E73930")]
	public bool KEDFCEGBEDG(Entity AHNNJNFIHFM, [Out] FANNBBCPEMM LKCOHANNNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x5E73480", Offset = "0x5E72880", VA = "0x185E73480")]
	public void DCFCICBAKIK(Entity AHNNJNFIHFM, FANNBBCPEMM LKCOHANNNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x5E73510", Offset = "0x5E72910", VA = "0x185E73510")]
	public bool FDHBMIKOIMN(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public NJPJOODBIOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal class FKGKIACGJPM : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private EntityQuery KNPLLCJBFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private DDJENBEKAAO KDDNMNODBLK;

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x5E64AF0", Offset = "0x5E63EF0", VA = "0x185E64AF0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x5E64B40", Offset = "0x5E63F40", VA = "0x185E64B40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x5E64C00", Offset = "0x5E64000", VA = "0x185E64C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x23B90D0", Offset = "0x23B84D0", VA = "0x1823B90D0")]
	private bool MHIBHBKMDML<TComponentData>(EntityQuery OGHCNPNLAEN, [Out] NativeArray<Entity> JIBDNODJOAB, [Out] NativeArray<TComponentData> DJKCBPMDJBO) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x5E64A60", Offset = "0x5E63E60", VA = "0x185E64A60")]
	public CGNNELOIABF HIGGALDLLHE(Entity AHNNJNFIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public FKGKIACGJPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public class GPHEIJHFMEH : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private EntityQuery FJFPDAENNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private EntityQuery MMHOHAPFKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private EntityQuery LBCLLNFKBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private EntityQuery NJJDLBJJNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private NFFPLOOJDLP KDDNMNODBLK;

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x5E68690", Offset = "0x5E67A90", VA = "0x185E68690", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x5E686E0", Offset = "0x5E67AE0", VA = "0x185E686E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x5E68960", Offset = "0x5E67D60", VA = "0x185E68960", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x5E68570", Offset = "0x5E67970", VA = "0x185E68570")]
	private void GIHKKMKIIOJ(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x5E68600", Offset = "0x5E67A00", VA = "0x185E68600")]
	private void HFJFDMFKDND(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x5E688D0", Offset = "0x5E67CD0", VA = "0x185E688D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x5E68B00", Offset = "0x5E67F00", VA = "0x185E68B00")]
	private void PKLAAIDKGFD(EntityQuery OGHCNPNLAEN, bool NGEFJHDPCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public GPHEIJHFMEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public sealed class IGHEODPKPED : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private DCFMFEJHJBD FKDFFFLBOLK;

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A760", Offset = "0x5E69B60", VA = "0x185E6A760", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A7C0", Offset = "0x5E69BC0", VA = "0x185E6A7C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public IGHEODPKPED()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	public class GatherModifiedParents : FILNMLJOIDH, ICKLGHMJPBB
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public NativeList<OJKDLDANCCG> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x5E69170", Offset = "0x5E68570", VA = "0x185E69170")]
			private void DGGBDJJHEJJ(Entity entity, [In][NoAlias] ParentData current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x5E691F0", Offset = "0x5E685F0", VA = "0x185E691F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherModifiedParents_AddChangedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public NativeList<FFIEFAIFGJM> changedParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __currentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			[ReadOnly]
			public ComponentTypeHandle<PreviousParentData> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x5E68F10", Offset = "0x5E68310", VA = "0x185E68F10")]
			private void DGGBDJJHEJJ(Entity entity, [In][NoAlias] ParentData current, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x5E68FD0", Offset = "0x5E683D0", VA = "0x185E68FD0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherModifiedParents_AddRemovedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public NativeList<OJKDLDANCCG> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			[ReadOnly]
			public ComponentTypeHandle<PreviousParentData> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x5E69310", Offset = "0x5E68710", VA = "0x185E69310")]
			private void DGGBDJJHEJJ(Entity entity, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x5E69390", Offset = "0x5E68790", VA = "0x185E69390", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private AEPEJGKFDPK parentEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private EntityQuery GatherModifiedParents_AddNewParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private EntityQuery GatherModifiedParents_AddChangedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private EntityQuery GatherModifiedParents_AddRemovedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private ComponentTypeHandle<PreviousParentData> __RecRoom_Components_PreviousParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x5E694B0", Offset = "0x5E688B0", VA = "0x185E694B0", Slot = "14")]
		public void EKLELFOFPLK(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x5E69F00", Offset = "0x5E69300", VA = "0x185E69F00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x5E696B0", Offset = "0x5E68AB0", VA = "0x185E696B0")]
		private JobHandle GFOKBOCOAKF(NativeList<OJKDLDANCCG> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x5E697D0", Offset = "0x5E68BD0", VA = "0x185E697D0")]
		private JobHandle GHEPJMAAFHB(NativeList<FFIEFAIFGJM> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x5E69590", Offset = "0x5E68990", VA = "0x185E69590")]
		private JobHandle EOCFECDPHLF(NativeList<OJKDLDANCCG> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x5E69930", Offset = "0x5E68D30", VA = "0x185E69930", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public GatherModifiedParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class DLCAOLAINBG : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x5E64040", Offset = "0x5E63440", VA = "0x185E64040", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc OGHCNPNLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x880870", Offset = "0x87FC70", VA = "0x180880870", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc OGHCNPNLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x5E64000", Offset = "0x5E63400", VA = "0x185E64000", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc OGHCNPNLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x5E63FC0", Offset = "0x5E633C0", VA = "0x185E63FC0", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc OGHCNPNLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x5E64080", Offset = "0x5E63480", VA = "0x185E64080")]
	public DLCAOLAINBG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : FILNMLJOIDH where TParentData : struct, IComponentData, KMPHIOOOMFB where TPreviousParentData : struct, IComponentData, KMPHIOOOMFB where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, KMPHIOOOMFB
	{
		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		[BurstCompile]
		internal struct GatherChangedParents : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter ParentChildrenToAdd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter ParentChildrenToRemove;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeParallelHashMap<Entity, int>.ParallelWriter UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public ComponentTypeHandle<TPreviousParentData> PreviousParentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			[ReadOnly]
			public ComponentTypeHandle<TParentData> ParentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public EntityTypeHandle EntityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public uint LastSystemVersion;

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x34A7150", Offset = "0x34A6550", VA = "0x1834A7150", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		[BurstCompile]
		internal struct FindMissingChild : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public NativeList<Entity> ParentsMissingChild;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x33DB960", Offset = "0x33DAD60", VA = "0x1833DB960", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		[BurstCompile]
		internal struct FixupChangedChildren : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> ParentChildrenToAdd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> ParentChildrenToRemove;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x33E4040", Offset = "0x33E3440", VA = "0x1833E4040")]
			private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x33E4120", Offset = "0x33E3520", VA = "0x1833E4120")]
			private void RemoveChildrenFromParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x33E3B60", Offset = "0x33E2F60", VA = "0x1833E3B60")]
			private void AddChildrenToParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x33E3CA0", Offset = "0x33E30A0", VA = "0x1833E3CA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[BurstCompile]
		private struct GatherChildEntities : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			[ReadOnly]
			public NativeArray<Entity> Parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeList<Entity> Children;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			[ReadOnly]
			public ComponentDataFromEntity<TParentData> ParentFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0x34A7870", Offset = "0x34A6C70", VA = "0x1834A7870", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected EntityQuery m_NewParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery m_RemovedParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery m_ExistingParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery m_DeletedParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected ProfilerMarker m_ProfileDeletedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker m_ProfileRemoveParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker m_ProfileChangeParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker m_ProfileNewParents;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x3E9D4A0", Offset = "0x3E9C8A0", VA = "0x183E9D4A0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x3E9AD50", Offset = "0x3E9A150", VA = "0x183E9AD50")]
		private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B840", Offset = "0x3E9AC40", VA = "0x183E9B840")]
		private void RemoveChildFromParent(Entity childEntity, Entity parentEntity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x880870", Offset = "0x87FC70", VA = "0x180880870", Slot = "14")]
		protected virtual EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x880870", Offset = "0x87FC70", VA = "0x180880870", Slot = "15")]
		protected virtual EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x880870", Offset = "0x87FC70", VA = "0x180880870", Slot = "16")]
		protected virtual EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query);

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x3E9AE50", Offset = "0x3E9A250", VA = "0x183E9AE50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x3E9CFD0", Offset = "0x3E9C3D0", VA = "0x183E9CFD0")]
		private void UpdateNewParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x3E9D2B0", Offset = "0x3E9C6B0", VA = "0x183E9D2B0")]
		private void UpdateRemoveParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C040", Offset = "0x3E9B440", VA = "0x183E9C040")]
		private JobHandle UpdateChangeParents(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x3E9CAC0", Offset = "0x3E9BEC0", VA = "0x183E9CAC0")]
		private void UpdateDeletedParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B5C0", Offset = "0x3E9A9C0", VA = "0x183E9B5C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B590", Offset = "0x3E9A990", VA = "0x183E9B590", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[AlwaysUpdateSystem]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public abstract class GEPDBFLIOMG : FILNMLJOIDH, ICKLGHMJPBB
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private struct OCBKIAFMJNG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> GHJIHCCCEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> MDJNBLKDICP;

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x5E743E0", Offset = "0x5E737E0", VA = "0x185E743E0")]
		public OCBKIAFMJNG(NativeList<Entity> GHJIHCCCEBP, NativeList<Entity> MDJNBLKDICP, JobHandle HDIPEJPBMFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x5E74360", Offset = "0x5E73760", VA = "0x185E74360")]
		public JobHandle JEDKEOIBNDG(JobHandle INOHAEAJFAP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x5E742D0", Offset = "0x5E736D0", VA = "0x185E742D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[BurstCompile]
	private struct OIBFIAPJEJI : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[Flags]
		public enum LOLJMKPNGGB
		{
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		[WriteOnly]
		public NativeList<Entity> MEDEEDGAAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> HDLLIMBGHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> PPMPCNCMNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> IFDLMAMOIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity PBBNKCOPBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity OAIPILOHCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> LHOGCJBPCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int HFPALPAEMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int EKFJEKKLFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private LOLJMKPNGGB EKCJMLNNFAI;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x5E75E50", Offset = "0x5E75250", VA = "0x185E75E50", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x5E76160", Offset = "0x5E75560", VA = "0x185E76160")]
		private bool KNADPDGIMOD(Entity AHNNJNFIHFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x5E75BE0", Offset = "0x5E74FE0", VA = "0x185E75BE0")]
		private void DBPKEOLEPFM(Entity AHNNJNFIHFM, bool NILPMJAFBHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x5E76060", Offset = "0x5E75460", VA = "0x185E76060")]
		private void GNGPMIOJJJG(Entity AHNNJNFIHFM, bool NILPMJAFBHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x5E75C70", Offset = "0x5E75070", VA = "0x185E75C70")]
		public OCBKIAFMJNG EGIFMAAJNKG(NativeArray<Entity> ALDIHCKBCEP, JobHandle INOHAEAJFAP)
		{
			return default(OCBKIAFMJNG);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x5E75CF0", Offset = "0x5E750F0", VA = "0x185E75CF0")]
		public OCBKIAFMJNG EGPPPEBKIMD(NativeArray<Entity> ALDIHCKBCEP, JobHandle INOHAEAJFAP)
		{
			return default(OCBKIAFMJNG);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x5E75D70", Offset = "0x5E75170", VA = "0x185E75D70")]
		public OCBKIAFMJNG ELKPIDFOLJM(NativeList<OJKDLDANCCG> NMLNNLIOHNF, JobHandle INOHAEAJFAP)
		{
			return default(OCBKIAFMJNG);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x5E76210", Offset = "0x5E75610", VA = "0x185E76210")]
		public OCBKIAFMJNG LEKFICBPIKJ(NativeList<OJKDLDANCCG> NMLNNLIOHNF, JobHandle INOHAEAJFAP)
		{
			return default(OCBKIAFMJNG);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x5E75F80", Offset = "0x5E75380", VA = "0x185E75F80")]
		public OCBKIAFMJNG FAMMKEJIMBD(NativeList<FFIEFAIFGJM> NMLNNLIOHNF, JobHandle INOHAEAJFAP)
		{
			return default(OCBKIAFMJNG);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x29B2CE0", Offset = "0x29B20E0", VA = "0x1829B2CE0")]
		private OCBKIAFMJNG BMKHCBIDOMJ<T>(NativeList<T> NMLNNLIOHNF, int HNPPPADMCBI, int FPMJDOKDHDK, LOLJMKPNGGB OHCLHGENEBF, JobHandle INOHAEAJFAP) where T : struct
		{
			return default(OCBKIAFMJNG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x5E75960", Offset = "0x5E74D60", VA = "0x185E75960")]
		private OCBKIAFMJNG BMKHCBIDOMJ(NativeArray<Entity> JIBDNODJOAB, int HNPPPADMCBI, int FPMJDOKDHDK, LOLJMKPNGGB OHCLHGENEBF, JobHandle INOHAEAJFAP)
		{
			return default(OCBKIAFMJNG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery BPMDLBGBAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery OFFNBMONHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private AEPEJGKFDPK DHOCDJNOHPL;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	protected abstract ComponentType GAIOJIAHKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	protected abstract ComponentType AJJGODJIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	protected abstract ComponentType NIEIPOPLNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x5E68540", Offset = "0x5E67940", VA = "0x185E68540")]
	protected GEPDBFLIOMG(FJOGIBEAJHF AABDFOONPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x5E66B30", Offset = "0x5E65F30", VA = "0x185E66B30", Slot = "14")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x5E66DC0", Offset = "0x5E661C0", VA = "0x185E66DC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x5E66FD0", Offset = "0x5E663D0", VA = "0x185E66FD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3130", Offset = "0x7E2530", VA = "0x1807E3130", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x5E66C10", Offset = "0x5E66010", VA = "0x185E66C10")]
	private void FHDJIKJPFBJ(NativeArray<Entity> NMLNNLIOHNF, EntityCommandBuffer DBMEKMBMPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x5E66D20", Offset = "0x5E66120", VA = "0x185E66D20")]
	private void JMKIMHECPDK(NativeArray<Entity> NMLNNLIOHNF, EntityCommandBuffer DBMEKMBMPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x5E682C0", Offset = "0x5E676C0", VA = "0x185E682C0")]
	private void PPIJEIHKNDK(OCBKIAFMJNG DGNIJCDALMM, string AOPEKGKJIAM, EntityCommandBuffer DBMEKMBMPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x5E68410", Offset = "0x5E67810", VA = "0x185E68410")]
	private void PPIJEIHKNDK(NativeListAsync<Entity> DBDCMBLAEID, string AOPEKGKJIAM, EntityCommandBuffer DBMEKMBMPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x5E668B0", Offset = "0x5E65CB0", VA = "0x185E668B0")]
	private void EIMCGFJNGLM(OCBKIAFMJNG DGNIJCDALMM, string AOPEKGKJIAM, EntityCommandBuffer DBMEKMBMPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x5E66A00", Offset = "0x5E65E00", VA = "0x185E66A00")]
	private void EIMCGFJNGLM(NativeListAsync<Entity> DBDCMBLAEID, string AOPEKGKJIAM, EntityCommandBuffer DBMEKMBMPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x5E66CB0", Offset = "0x5E660B0", VA = "0x185E66CB0")]
	private bool GAHANDKAPEK()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	[CompilerGenerated]
	public class PhysicsSceneAddCollidersSystem : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		private struct PhysicsSceneAddCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public PhysicsSceneAddCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0x5E77BE0", Offset = "0x5E76FE0", VA = "0x185E77BE0")]
			private void DGGBDJJHEJJ(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0x5E77D00", Offset = "0x5E77100", VA = "0x185E77D00", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private LAHFILKOFBJ ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private NGDPKGKNNBP colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x5E77F80", Offset = "0x5E77380", VA = "0x185E77F80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x5E77B80", Offset = "0x5E76F80", VA = "0x185E77B80", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x5E77FE0", Offset = "0x5E773E0", VA = "0x185E77FE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x5E77A90", Offset = "0x5E76E90", VA = "0x185E77A90")]
		private void CCLABBPCEFO(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x5E77DB0", Offset = "0x5E771B0", VA = "0x185E77DB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
[AGNACEIDMIN(DPJKEJCGJEB.OMRoom)]
[MEBHHNIGJKC]
public class GDIOBFIEMBH : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private NGDPKGKNNBP MHGEGMPBDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private BNKPHKHKLHD KMCCKENJIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x5E66390", Offset = "0x5E65790", VA = "0x185E66390", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x5E66400", Offset = "0x5E65800", VA = "0x185E66400", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x5E664B0", Offset = "0x5E658B0", VA = "0x185E664B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public GDIOBFIEMBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct APGFCONDMIC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public HMGDPCDJKDM EKHBDCNGFLP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00")]
	public static APGFCONDMIC DLNOOKJDMMJ([In] HMGDPCDJKDM LKIGEMCCJAB)
	{
		return default(APGFCONDMIC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00")]
	public static HMGDPCDJKDM DLNOOKJDMMJ([In] APGFCONDMIC GEMEMDCGKOP)
	{
		return default(HMGDPCDJKDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
[AlwaysUpdateSystem]
public class LAHFILKOFBJ : MEMILACELCP
{
	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F2F0", Offset = "0x5E6E6F0", VA = "0x185E6F2F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public LAHFILKOFBJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	public class PhysicsSceneRemoveCollidersSystem : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		private struct PhysicsSceneRemoveCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public PhysicsSceneRemoveCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			[ReadOnly]
			public ComponentTypeHandle<APGFCONDMIC> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x5E78270", Offset = "0x5E77670", VA = "0x185E78270")]
			private void DGGBDJJHEJJ(Entity e, [In] APGFCONDMIC ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x5E78320", Offset = "0x5E77720", VA = "0x185E78320", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private LAHFILKOFBJ ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private NGDPKGKNNBP colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private ComponentTypeHandle<APGFCONDMIC> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E78650", Offset = "0x5E77A50", VA = "0x185E78650", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E78210", Offset = "0x5E77610", VA = "0x185E78210", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E786B0", Offset = "0x5E77AB0", VA = "0x185E786B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E780E0", Offset = "0x5E774E0", VA = "0x185E780E0")]
		private void FHEIFIGFKGK(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E78440", Offset = "0x5E77840", VA = "0x185E78440", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public class LOKMPLFKHLO : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private struct ODMMBLLKGLI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public NDPAEDKCNFI EHJFODOFCKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public NativeParallelHashSet<Entity> JIBDNODJOAB;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E74D70", Offset = "0x5E74170", VA = "0x185E74D70")]
		public ODMMBLLKGLI(int ACGAEDNGFFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E74D00", Offset = "0x5E74100", VA = "0x185E74D00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[BurstCompile]
	private struct EKFACNIOCAJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		[ReadOnly]
		public NativeArray<Entity> JIBDNODJOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		[ReadOnly]
		public ComponentDataFromEntity<NJLFDIIMCKB> OLIAKEOPGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		[ReadOnly]
		public ComponentDataFromEntity<BFFJMHOAOGI> DHPOEKAOEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		[ReadOnly]
		public ComponentDataFromEntity<NDPCMDFICAO> NJENDJIKJBF;

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E64840", Offset = "0x5E63C40", VA = "0x185E64840", Slot = "4")]
		public void Execute(int JPEMHHILGGG, TransformAccess IJKPFNCIDCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct NEINMFIKNFL : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		[ReadOnly]
		public NativeArray<Entity> JIBDNODJOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		[ReadOnly]
		public ComponentDataFromEntity<NJLFDIIMCKB> OLIAKEOPGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		[ReadOnly]
		public ComponentDataFromEntity<NDPCMDFICAO> NJENDJIKJBF;

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E731F0", Offset = "0x5E725F0", VA = "0x185E731F0", Slot = "4")]
		public void Execute(int JPEMHHILGGG, TransformAccess IJKPFNCIDCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private NGDPKGKNNBP MHGEGMPBDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private EntityQuery GJDNGFLMGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	private EntityQuery EKKPFIAEKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private EntityQuery GJEODLNIBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private EntityQuery PNHMNDOPLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private EntityQuery FONIJOKOOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private JobHandle NPHJLMPILFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private ODMMBLLKGLI AJODLGIIKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private ODMMBLLKGLI GFKMELKCKDP;

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E71D10", Offset = "0x5E71110", VA = "0x185E71D10", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E71D70", Offset = "0x5E71170", VA = "0x185E71D70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E72050", Offset = "0x5E71450", VA = "0x185E72050", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E72060", Offset = "0x5E71460", VA = "0x185E72060", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E71400", Offset = "0x5E70800", VA = "0x185E71400")]
	private void HLLBEBABINM(EntityQuery OGHCNPNLAEN, [Out] (NativeArrayAsync<APGFCONDMIC> handles, NativeArrayAsync<JABAMAIPKGD> bounds) OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E71960", Offset = "0x5E70D60", VA = "0x185E71960")]
	private void IMKGHBFGIJM((NativeArrayAsync<APGFCONDMIC> handles, NativeArrayAsync<JABAMAIPKGD> bounds) OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E711C0", Offset = "0x5E705C0", VA = "0x185E711C0")]
	private void EMAFCGJFAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E712C0", Offset = "0x5E706C0", VA = "0x185E712C0")]
	private void HDDBJHBEECI(EntityQuery OGHCNPNLAEN, [Out] (NativeArrayAsync<Entity> entities, NativeArrayAsync<APGFCONDMIC> handles) OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E71540", Offset = "0x5E70940", VA = "0x185E71540")]
	private void IINPMLNPOJP((NativeArrayAsync<Entity> entities, NativeArrayAsync<APGFCONDMIC> handles) OOIBMCBCEPD, ODMMBLLKGLI EGLHFCPNJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E71800", Offset = "0x5E70C00", VA = "0x185E71800")]
	private JobHandle IMAIIINKCED(ODMMBLLKGLI EGLHFCPNJBK, ComponentDataFromEntity<NJLFDIIMCKB> OLIAKEOPGLP, ComponentDataFromEntity<NDPCMDFICAO> NJENDJIKJBF, ComponentDataFromEntity<BFFJMHOAOGI> DHPOEKAOEEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E71BB0", Offset = "0x5E70FB0", VA = "0x185E71BB0")]
	private JobHandle IOEHKKGEJFF(ODMMBLLKGLI EGLHFCPNJBK, ComponentDataFromEntity<NJLFDIIMCKB> OLIAKEOPGLP, ComponentDataFromEntity<NDPCMDFICAO> NJENDJIKJBF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public LOKMPLFKHLO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010F")]
public struct ODCBECBLOPG : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[MEBHHNIGJKC]
public class JOLENAOMADD : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct BHGMFIGICGL : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		[ReadOnly]
		public NativeArray<Entity> ODJLGHIHEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		[ReadOnly]
		public ComponentDataFromEntity<JLDGOFKMBDC> IDCOAMLEJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		[ReadOnly]
		public ComponentDataFromEntity<JABAMAIPKGD> BFAAKJLBIAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter JPPLGKNAIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter EBBAIOBDGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter FEJAPLGEOJN;

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E60B40", Offset = "0x5E5FF40", VA = "0x185E60B40", Slot = "4")]
		public void Execute(int JPEMHHILGGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[BurstCompile]
	private struct KNNLOEBBFBD : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		[ReadOnly]
		public NativeArray<Entity> ABKGECODOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> MDEPKFOOMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[ReadOnly]
		public ComponentDataFromEntity<AECIBMNAFMF> GFPGDELGJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		[ReadOnly]
		public ComponentDataFromEntity<JOPAFADPKGF> KGEEBPGDHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<JABAMAIPKGD> KGAHHPDLAHN;

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F070", Offset = "0x5E6E470", VA = "0x185E6F070", Slot = "4")]
		public void Execute(int JPEMHHILGGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private EntityQuery OPBMLFILBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private EntityQuery DICGEPAOLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private EntityQuery LDAJGDNNMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private EntityQuery HCKHNGPEOMN;

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E2B0", Offset = "0x5E6D6B0", VA = "0x185E6E2B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E4E0", Offset = "0x5E6D8E0", VA = "0x185E6E4E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EB00", Offset = "0x5E6DF00", VA = "0x185E6EB00")]
	private JobHandle PEICELLNKOA(NativeArrayAsync<Entity> FOAJABBKLPB, int FADEBHLHEEP, JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EBE0", Offset = "0x5E6DFE0", VA = "0x185E6EBE0")]
	private JobHandle PEICELLNKOA(NativeArray<Entity> NHELHBAJJKN, int FADEBHLHEEP, [Optional] JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DE70", Offset = "0x5E6D270", VA = "0x185E6DE70")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) IKLEIPAEFPK(NativeArrayAsync<Entity> PGBLLPKGDNO)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EDF0", Offset = "0x5E6E1F0", VA = "0x185E6EDF0")]
	private void PLGOJGOAMNK([Out] NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EF50", Offset = "0x5E6E350", VA = "0x185E6EF50")]
	private void PPNDPPPBNFM(NativeList<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EE70", Offset = "0x5E6E270", VA = "0x185E6EE70")]
	private void PPNDPPPBNFM(NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DD00", Offset = "0x5E6D100", VA = "0x185E6DD00")]
	private void ANEMPJEGDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void ICIKBPFENIN(int KEPOKBPEGJL, int NJCDNNAEOEM, int GNOCFKFPGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DA20", Offset = "0x5E6CE20", VA = "0x185E6DA20")]
	private static JABAMAIPKGD AKGGGGJBBKI(NativeArray<Entity> OIPOKEEENIG, ComponentDataFromEntity<AECIBMNAFMF> GFPGDELGJCG, ComponentDataFromEntity<JOPAFADPKGF> KGEEBPGDHKD)
	{
		return default(JABAMAIPKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public JOLENAOMADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[MEBHHNIGJKC]
public class EHDDEACDFDO : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	private static readonly FJOGIBEAJHF CFBFDAHIOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	[DMNKPOGEHOO]
	private GICCNDIODFI EKNAGPONANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	private EntityQuery NKPKBGNFOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	private EntityQuery NJJDLBJJNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E641C0", Offset = "0x5E635C0", VA = "0x185E641C0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E640C0", Offset = "0x5E634C0", VA = "0x185E640C0")]
	public bool CDPCGGHCFJC(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E64360", Offset = "0x5E63760", VA = "0x185E64360", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E641A0", Offset = "0x5E635A0", VA = "0x185E641A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F9AF0", Offset = "0x7F8EF0", VA = "0x1807F9AF0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E64450", Offset = "0x5E63850", VA = "0x185E64450", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E641A0", Offset = "0x5E635A0", VA = "0x185E641A0")]
	private void EOGJLJFIEFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E64470", Offset = "0x5E63870", VA = "0x185E64470")]
	private void PGGPHLPNKMB(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E64210", Offset = "0x5E63610", VA = "0x185E64210")]
	private void KAGNDJIIMLE(NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public EHDDEACDFDO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal struct MAOINCMPNBM : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[AlwaysUpdateSystem]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public class JEIGABGLCDA : FILNMLJOIDH, ENDDIKHKCDF, IFKHMGNDLHA
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class LEPBJJEKCJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public CAKFEHOBCAO localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public GIPDCNOKOFM collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public ADGEOGFCGOG containerFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public bool physicsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public bool gravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public bool hasUnityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public JEIGABGLCDA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public LEPBJJEKCJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E70E30", Offset = "0x5E70230", VA = "0x185E70E30")]
		internal void DLGMIOFHJNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E70F50", Offset = "0x5E70350", VA = "0x185E70F50")]
		internal void ENJFKANPFCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E71080", Offset = "0x5E70480", VA = "0x185E71080")]
		internal void LBKJDPOGNLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	[DMNKPOGEHOO]
	private FEGCGGPGJLI EHEIIHLHBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	[DMNKPOGEHOO]
	private BOJOADFJNML PCCBNHMLCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	[DMNKPOGEHOO]
	private IBNLNIKJFKJ OOCONJNDKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public ComponentTypeHandle<ADGEOGFCGOG> POMONCEGJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public ComponentTypeHandle<KPBKEHJCKKA> EMCMPDBIBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public ComponentTypeHandle<PBNNEOGGDLO> FGEMPLGAAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public ComponentTypeHandle<BIDCHAAGDGC> FKINKNFBNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public ComponentTypeHandle<LJIOMBCKNCF> EACIJKKCMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public DynamicComponentTypeHandle LCFBALEDKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public EntityTypeHandle HPJPLLGDGMM;

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C570", Offset = "0x5E6B970", VA = "0x185E6C570", Slot = "15")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C4C0", Offset = "0x5E6B8C0", VA = "0x185E6C4C0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C640", Offset = "0x5E6BA40", VA = "0x185E6C640", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C000", Offset = "0x5E6B400", VA = "0x185E6C000")]
	private void EEAKONKLLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C1C0", Offset = "0x5E6B5C0", VA = "0x185E6C1C0")]
	private bool GAHANDKAPEK([Out] int GBEGAPBFFCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public JEIGABGLCDA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	public class UpdateSplineGameCollidersSystem : FILNMLJOIDH, ENDDIKHKCDF
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
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[ReadOnly]
			public ComponentDataFromEntity<GEJEAEPKOAF> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			[ReadOnly]
			public ComponentTypeHandle<KPBKEHJCKKA> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public BufferTypeHandle<ChildrenData> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x5E78A00", Offset = "0x5E77E00", VA = "0x185E78A00")]
			private void DGGBDJJHEJJ([In] KPBKEHJCKKA collisionMode, DynamicBuffer<ChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x5E78D80", Offset = "0x5E78180", VA = "0x185E78D80", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011A")]
		private struct ProcessActiveSplineReparentsForGameCollision_Job : IJobEntityBatch
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
			public ComponentDataFromEntity<KPBKEHJCKKA> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x5E78800", Offset = "0x5E77C00", VA = "0x185E78800")]
			private void DGGBDJJHEJJ(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x5E788E0", Offset = "0x5E77CE0", VA = "0x185E788E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct ProcessInactiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			[ReadOnly]
			public ComponentDataFromEntity<KPBKEHJCKKA> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x5E78EF0", Offset = "0x5E782F0", VA = "0x185E78EF0")]
			private void DGGBDJJHEJJ(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x5E78FC0", Offset = "0x5E783C0", VA = "0x185E78FC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011C")]
		private struct UpdateSplineGameCollidersSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x5E7CFD0", Offset = "0x5E7C3D0", VA = "0x185E7CFD0")]
			private void DGGBDJJHEJJ(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D080", Offset = "0x5E7C480", VA = "0x185E7D080", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011D")]
		private struct ProcessSplineEditsForGameCollision_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			[ReadOnly]
			public ComponentTypeHandle<JLDGOFKMBDC> splinePointParentHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			[ReadOnly]
			public EntityTypeHandle entityHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public EntityQueryInJob splinePointEditedQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public EntityQueryInJob splineStructureChangedQueryInJob;

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E790E0", Offset = "0x5E784E0", VA = "0x185E790E0")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x5E79630", Offset = "0x5E78A30", VA = "0x185E79630", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x5E79640", Offset = "0x5E78A40", VA = "0x185E79640")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void GBPHJAFBJCI(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private JCGFEEDFAOG splineCollisionService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private EntityQuery collisionModeChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private EntityQuery activeSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private EntityQuery inactiveSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private EntityQuery splinePointEditedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private EntityQuery splineStructureChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery splinesDeletedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery ProcessCollisionModeChangesForSplineGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery ProcessActiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private EntityQuery ProcessInactiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private EntityQuery UpdateSplineGameCollidersSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private ComponentTypeHandle<KPBKEHJCKKA> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CB80", Offset = "0x5E7BF80", VA = "0x185E7CB80", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DE50", Offset = "0x5E7D250", VA = "0x185E7DE50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E030", Offset = "0x5E7D430", VA = "0x185E7E030", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CBD0", Offset = "0x5E7BFD0", VA = "0x185E7CBD0")]
		private void JFPGKIEGAFO(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D290", Offset = "0x5E7C690", VA = "0x185E7D290")]
		private void MKIAPJKBMNH(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C780", Offset = "0x5E7BB80", VA = "0x185E7C780")]
		private void DBBKFDKDJPI(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CA90", Offset = "0x5E7BE90", VA = "0x185E7CA90")]
		private void GDJPEOJICJO(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CDE0", Offset = "0x5E7C1E0", VA = "0x185E7CDE0")]
		private void KABHIJLMALP(EntityCommandBuffer ecb, ComponentDataFromEntity<GEJEAEPKOAF> splineComponentAccess, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C930", Offset = "0x5E7BD30", VA = "0x185E7C930")]
		private void DHAHONOPEIL(EntityCommandBuffer ecb, ComponentDataFromEntity<KPBKEHJCKKA> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D130", Offset = "0x5E7C530", VA = "0x185E7D130")]
		private void MCJFJEFMCBC(EntityCommandBuffer ecb, ComponentDataFromEntity<KPBKEHJCKKA> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E7D0", Offset = "0x5E7DBD0", VA = "0x185E7E7D0")]
		private void POCCJGMLLIC(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D550", Offset = "0x5E7C950", VA = "0x185E7D550")]
		private void MKMDBAFGBCF(ComponentTypeHandle<JLDGOFKMBDC> splinePointParentHandle, EntityTypeHandle entityHandle, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, EntityQueryInJob splinePointEditedQueryInJob, EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D690", Offset = "0x5E7CA90", VA = "0x185E7D690", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
[MEBHHNIGJKC]
public class OEOMNEDMKAH : FILNMLJOIDH, IFKHMGNDLHA, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[BurstCompile]
	private struct FMIOLODFANP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		[ReadOnly]
		public EntityTypeHandle JFFMCPDOLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		[ReadOnly]
		public ComponentTypeHandle<NJLFDIIMCKB> PHGEDMEJGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		[WriteOnly]
		public NativeList<OMALCGLLKKB>.ParallelWriter HHLIMIJGGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public ComponentTypeHandle<LMFJIMCCJHC> DAAHBIMKFMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public float3 ADOGMMPMLJB;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private static readonly float4x2 HPGCEEPLNME;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly float4x2 EFFPMHEFOCD;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private static readonly int4x2 EIDFKHODJDG;

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x5E64EF0", Offset = "0x5E642F0", VA = "0x185E64EF0", Slot = "4")]
		public void Execute(ArchetypeChunk LPPKICFIEJM, int ADOGCNALFGH, int ILCIGNLDBCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private static FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private EntityQuery NFIPIEIFEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private EntityQuery OMJLGBCBHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private double FDGNHPENLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private GENLJBHGPDA KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private PMGCPLLNMOO BEAMEFBGJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private EJAPLNPOEKH JMLFNACGIOI;

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E75190", Offset = "0x5E74590", VA = "0x185E75190", Slot = "14")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E75100", Offset = "0x5E74500", VA = "0x185E75100", Slot = "15")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E751A0", Offset = "0x5E745A0", VA = "0x185E751A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E75310", Offset = "0x5E74710", VA = "0x185E75310", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E75530", Offset = "0x5E74930", VA = "0x185E75530")]
	private bool PMNEDMEODNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E74E10", Offset = "0x5E74210", VA = "0x185E74E10")]
	private void BPKKDFDGPHH(EntityQuery OGHCNPNLAEN, float3 DHEEGHHMLMO, string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public OEOMNEDMKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public struct OMALCGLLKKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public Entity AHNNJNFIHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public OJEJFFJPFHH HDAGINFADOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public OJEJFFJPFHH LFEAEFFENHM;
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public class CBILGAOJBEG : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private PMGCPLLNMOO BEAMEFBGJOK;

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x5E60C20", Offset = "0x5E60020", VA = "0x185E60C20", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x5E60C70", Offset = "0x5E60070", VA = "0x185E60C70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CBILGAOJBEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public class OFLIFEHOCPI : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x5E75630", Offset = "0x5E74A30", VA = "0x185E75630", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x5E756F0", Offset = "0x5E74AF0", VA = "0x185E756F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public OFLIFEHOCPI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	[CompilerGenerated]
	public class UpdateInertialProperties : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct UpdateInertialProperties_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x2000125")]
			public delegate void RunWithoutJobSystem_000008A0$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000126")]
			internal static class RunWithoutJobSystem_000008A0$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000400")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000401")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x5E79860", Offset = "0x5E78C60", VA = "0x185E79860")]
				[BurstDiscard]
				private static void JMEDLGAJLPK(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600071A")]
				[Cpp2IlInjected.Address(RVA = "0x5E79990", Offset = "0x5E78D90", VA = "0x185E79990")]
				private static IntPtr JNIJBLGCHBM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x600071B")]
				[Cpp2IlInjected.Address(RVA = "0x5E79AF0", Offset = "0x5E78EF0", VA = "0x185E79AF0")]
				public static void NAAFEMAKKBL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600071C")]
				[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
				public static void OMELHDOHHCI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600071E")]
				[Cpp2IlInjected.Address(RVA = "0x5E79690", Offset = "0x5E78A90", VA = "0x185E79690")]
				public static void DFPIJIPLDKJ(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public EntityQueryInJob isTaggedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public EntityQueryInJob rootRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public EntityQueryInJob deformationScaleChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public EntityQueryInJob generalRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public ChunkFilterAnyOf5ComponentsChanged changeFilter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public int maxEntityCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public NativeList<Entity> changedRoots;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			[ReadOnly]
			public EntityExistenceLookupByEntity entityExists;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			[ReadOnly]
			public EntityTypeHandle entityTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			[ReadOnly]
			public ComponentTypeHandle<EFFCNMNNAHE> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			[ReadOnly]
			public ComponentDataFromEntity<NOAAEPNPGCN> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A410", Offset = "0x5E79810", VA = "0x185E7A410")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AA60", Offset = "0x5E79E60", VA = "0x185E7AA60", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AA70", Offset = "0x5E79E70", VA = "0x185E7AA70")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void GBPHJAFBJCI(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AC80", Offset = "0x5E7A080", VA = "0x185E7AC80")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void KOKNNIPBNLL(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private EntityQuery isTaggedForUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private EntityQuery generalRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private EntityQuery rootRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private EntityQuery deformationScaleChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery removeMassOfHierarchyQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private FEGCGGPGJLI rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private CDJJECGMMII objects;

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A030", Offset = "0x5E79430", VA = "0x185E7A030", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B1F0", Offset = "0x5E7A5F0", VA = "0x185E7B1F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B590", Offset = "0x5E7A990", VA = "0x185E7B590", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A0A0", Offset = "0x5E794A0", VA = "0x185E7A0A0")]
		protected void KIPNPCMDEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x5E79F90", Offset = "0x5E79390", VA = "0x185E79F90")]
		protected void GECNMGFBBMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7ACD0", Offset = "0x5E7A0D0", VA = "0x185E7ACD0")]
		private bool ODBKFHEDADL(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, [Out] NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x5E79CB0", Offset = "0x5E790B0", VA = "0x185E79CB0")]
		private void FCLPDJCLECF(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, ChunkFilterAnyOf5ComponentsChanged changeFilter, int maxEntityCount, NativeList<Entity> changedRoots, EntityExistenceLookupByEntity entityExists, EntityTypeHandle entityTypeRO, ComponentTypeHandle<EFFCNMNNAHE> rbexRootTypeRO, ComponentDataFromEntity<NOAAEPNPGCN> rbexIsKinematicRO, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B100", Offset = "0x5E7A500", VA = "0x185E7B100", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x5E79C70", Offset = "0x5E79070", VA = "0x185E79C70")]
		public static void CPAPLBDEHBG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	public class UpdateMassOfShapes : FILNMLJOIDH
	{
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct UpdateMassOfShapes_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			[ReadOnly]
			public ComponentDataFromEntity<PKHNNEBJACH> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			[ReadOnly]
			public ComponentDataFromEntity<NDPCMDFICAO> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			[ReadOnly]
			public ComponentDataFromEntity<PDCEHDJOHGM> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			[ReadOnly]
			public ComponentDataFromEntity<DIBFPGJGPCF> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			[ReadOnly]
			public ComponentDataFromEntity<KMCDAKDJLDL> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public ComponentDataFromEntity<DIHEJGGAGDD> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public ComponentDataFromEntity<OKHCIHCBDMO> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BB20", Offset = "0x5E7AF20", VA = "0x185E7BB20")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BF70", Offset = "0x5E7B370", VA = "0x185E7BF70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BF80", Offset = "0x5E7B380", VA = "0x185E7BF80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C0C0", Offset = "0x5E7B4C0", VA = "0x185E7C0C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B640", Offset = "0x5E7AA40", VA = "0x185E7B640")]
		private void HKDFCDJNMCC(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B950", Offset = "0x5E7AD50", VA = "0x185E7B950")]
		private JobHandle JFANHKLHKLD(NativeList<Entity> entities, ComponentDataFromEntity<PKHNNEBJACH> worldDeformableScalesRO, ComponentDataFromEntity<NDPCMDFICAO> worldUniformScalesRO, ComponentDataFromEntity<PDCEHDJOHGM> physicsMaterialsRO, ComponentDataFromEntity<DIBFPGJGPCF> primitiveShapesRO, ComponentDataFromEntity<KMCDAKDJLDL> localUniformScalesRO, ComponentDataFromEntity<DIHEJGGAGDD> massesRW, ComponentDataFromEntity<OKHCIHCBDMO> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public UpdateMassOfShapes()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public class NLCLNABCPHP : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[BurstCompile]
	private struct BDLFLADFNDM : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[ReadOnly]
		public int DOEBOPMAMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[ReadOnly]
		public EntityQueryInJob CKHPJPBLNIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		[ReadOnly]
		public EntityQueryInJob JJAOAPLFCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged HOBMKOJPIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		[ReadOnly]
		public EntityTypeHandle HPJPLLGDGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		[ReadOnly]
		public ComponentDataFromEntity<PDCEHDJOHGM> NBABOLDMPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		[ReadOnly]
		public ComponentDataFromEntity<NDPCMDFICAO> IKBIAEGLOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> LLEPIIKBLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		[ReadOnly]
		public ComponentTypeHandle<JLDGOFKMBDC> BLHIJCDFMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		[ReadOnly]
		public ComponentDataFromEntity<AECIBMNAFMF> PDAMJKJHBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		[ReadOnly]
		public ComponentDataFromEntity<JOPAFADPKGF> KGEEBPGDHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		[WriteOnly]
		public ComponentDataFromEntity<DIHEJGGAGDD> NABIHNKFJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		[WriteOnly]
		public ComponentDataFromEntity<OKHCIHCBDMO> AGLIGDJGKEL;

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x5E604C0", Offset = "0x5E5F8C0", VA = "0x185E604C0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FF80", Offset = "0x5E5F380", VA = "0x185E5FF80")]
		private void BNHIHHCPOAG(NativeList<Entity> MNDGNFAOOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x5E60680", Offset = "0x5E5FA80", VA = "0x185E60680")]
		private void FBNKECLPHEJ(Entity ALKPGICEAHM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private EntityQuery KBDONMACPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private EntityQuery DFJICIMNFFK;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x5E73CF0", Offset = "0x5E730F0", VA = "0x185E73CF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x5E73EB0", Offset = "0x5E732B0", VA = "0x185E73EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x24E6470", Offset = "0x24E5870", VA = "0x1824E6470")]
	private bool NAKHODPHEOC<T>(T HPLIJINHCFF, [Out] int AGOJAKBMAHC) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public NLCLNABCPHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
[MEBHHNIGJKC]
public class IJBFELJFCMP : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MLINCCBOIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> GDOPHBCGCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> KDCNJFIAKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private FJIPHEGHMFE JBDNMCGJOAH;

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B010", Offset = "0x5E6A410", VA = "0x185E6B010", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B910", Offset = "0x5E6AD10", VA = "0x185E6B910", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B1A0", Offset = "0x5E6A5A0", VA = "0x185E6B1A0")]
	private void KKPEDOBACPJ(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NMLNNLIOHNF, EntityQueryDesc DFKBGGLEHGO, bool DKNAEDLPCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B310", Offset = "0x5E6A710", VA = "0x185E6B310")]
	private void KKPEDOBACPJ(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NMLNNLIOHNF, EntityQueryDesc DFKBGGLEHGO, bool DKNAEDLPCJA, bool FJGOAHOCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BB80", Offset = "0x5E6AF80", VA = "0x185E6BB80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B700", Offset = "0x5E6AB00", VA = "0x185E6B700")]
	private void MKJFDFJNGLE(EntityQuery OGHCNPNLAEN, bool OJFIBLBMKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AC60", Offset = "0x5E6A060", VA = "0x185E6AC60")]
	private void HEIIGLJINBE(EntityQuery OGHCNPNLAEN, bool DMKOJIDKHDA, bool OJFIBLBMKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A7E0", Offset = "0x5E69BE0", VA = "0x185E6A7E0")]
	private void ADKLDFAEIOA(NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AE80", Offset = "0x5E6A280", VA = "0x185E6AE80")]
	private void HFIGNMGOCCN(NativeList<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B060", Offset = "0x5E6A460", VA = "0x185E6B060")]
	private void JNNDAFNONDH(NativeArray<Entity> JIBDNODJOAB, bool DMKOJIDKHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AA50", Offset = "0x5E69E50", VA = "0x185E6AA50")]
	private NativeList<Entity> GCHOOAAEHNJ(NativeArray<Entity> JIBDNODJOAB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B4A0", Offset = "0x5E6A8A0", VA = "0x185E6B4A0")]
	private NativeList<Entity> KPPOMALBAFL(NativeArray<Entity> JIBDNODJOAB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B4E0", Offset = "0x5E6A8E0", VA = "0x185E6B4E0")]
	private NativeList<Entity> LFGFCNMMEPM(NativeArray<Entity> JIBDNODJOAB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B520", Offset = "0x5E6A920", VA = "0x185E6B520")]
	private NativeList<Entity> LJFJMJMGNIH(NativeArray<Entity> JIBDNODJOAB, bool IEMJFNLMPJA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BF10", Offset = "0x5E6B310", VA = "0x185E6BF10")]
	public IJBFELJFCMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public class DEPEKOAIMPP : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private FJIPHEGHMFE JBDNMCGJOAH;

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x5E63F50", Offset = "0x5E63350", VA = "0x185E63F50", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x5E63FA0", Offset = "0x5E633A0", VA = "0x185E63FA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public DEPEKOAIMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public class CJBCHFGDINN : NEKPFIPDOIF
{
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private static FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private EntityQuery KCBCNONBNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private EntityQuery FLKNEJBEMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private EntityQuery GHIFFHPPBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private EntityQuery CMILJFIKOBL;

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x5E616C0", Offset = "0x5E60AC0", VA = "0x185E616C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x5E618A0", Offset = "0x5E60CA0", VA = "0x185E618A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x5E614F0", Offset = "0x5E608F0", VA = "0x185E614F0")]
	private void HLIDPMDJDIG(EntityQuery OGHCNPNLAEN, bool BBGNHGDCHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x5E61320", Offset = "0x5E60720", VA = "0x185E61320")]
	private void FPDJHCKFLMP(EntityQuery OGHCNPNLAEN, bool BBGNHGDCHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CJBCHFGDINN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
[AlwaysUpdateSystem]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public class HCEMHLHHMIC : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	[DMNKPOGEHOO]
	private OMMEEFHEKMM OCNOLDKMEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	[DMNKPOGEHOO]
	private FEGCGGPGJLI EHEIIHLHBIP;

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A2F0", Offset = "0x5E696F0", VA = "0x185E6A2F0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A270", Offset = "0x5E69670", VA = "0x185E6A270")]
	protected void HBEBPCBOOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A380", Offset = "0x5E69780", VA = "0x185E6A380", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public HCEMHLHHMIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class OIOIECFEODN : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private GENLJBHGPDA KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private EntityQuery LLMFAFOLIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private EntityQuery PEPOJNKNCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private BNKPHKHKLHD CNIFLPLFONI;

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x5E76600", Offset = "0x5E75A00", VA = "0x185E76600", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x5E76D00", Offset = "0x5E76100", VA = "0x185E76D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x5E76E20", Offset = "0x5E76220", VA = "0x185E76E20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x5E762F0", Offset = "0x5E756F0", VA = "0x185E762F0")]
	private void HFLFLEEHJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x5E76440", Offset = "0x5E75840", VA = "0x185E76440")]
	private void IODHIKPENNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x5E76990", Offset = "0x5E75D90", VA = "0x185E76990")]
	private void OLINDINIMOA(NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x5E76670", Offset = "0x5E75A70", VA = "0x185E76670")]
	private void JLAJGGDDEKD(NativeArray<Entity> JIBDNODJOAB, int DHPDIOILGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x5E76880", Offset = "0x5E75C80", VA = "0x185E76880")]
	private void MCHBNDAFKNL(NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x5E76800", Offset = "0x5E75C00", VA = "0x185E76800")]
	private void LKMKNAKCFAJ(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void JMJHINOCGIB(int JNIFDEFBBOF, Transform IJKPFNCIDCJ, Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public OIOIECFEODN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal static class PBDFFLEDIOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x5E76ED0", Offset = "0x5E762D0", VA = "0x185E76ED0")]
	public static bool EMFFBNLPNKP(this SystemBase FIPLOBJLBLA, [Out] Entity AHNNJNFIHFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class JJFALLOJMOC : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private EntityQuery BGHKBOICHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private NCBLCPIDIEA LPDLAAIFPJB;

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D810", Offset = "0x5E6CC10", VA = "0x185E6D810", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D860", Offset = "0x5E6CC60", VA = "0x185E6D860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D920", Offset = "0x5E6CD20", VA = "0x185E6D920", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public JJFALLOJMOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class PGDEHOKHKKJ : CPFJJINCILO<JNPGJMICMGJ>, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private JFDAFKCNFNC PJNMDDGPIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private EntityQuery GAOFGLKHCJA;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private Entity ICHPFOEFDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x5E77420", Offset = "0x5E76820", VA = "0x185E77420")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x5E777A0", Offset = "0x5E76BA0", VA = "0x185E777A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public CAKFEHOBCAO LGLBOPNAOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x5E775B0", Offset = "0x5E769B0", VA = "0x185E775B0")]
		get
		{
			return default(CAKFEHOBCAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x5E77300", Offset = "0x5E76700", VA = "0x185E77300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(RVA = "0x5E77870", Offset = "0x5E76C70", VA = "0x185E77870", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000763")]
	[Cpp2IlInjected.Address(RVA = "0x5E77800", Offset = "0x5E76C00", VA = "0x185E77800", Slot = "15")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(RVA = "0x5E77920", Offset = "0x5E76D20", VA = "0x185E77920", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(RVA = "0x5E77660", Offset = "0x5E76A60", VA = "0x185E77660", Slot = "14")]
	protected override void GHOAAIKOLPB(NativeArray<Entity> JIBDNODJOAB, NativeArray<Entity> OOEKLCNPOLM, NativeArray<Entity> DENBIMFLLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(RVA = "0x5E774D0", Offset = "0x5E768D0", VA = "0x185E774D0")]
	private void EMHOJBPKNIH(NativeArray<Entity> JIBDNODJOAB, NativeArray<Entity> DENBIMFLLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x5E76F60", Offset = "0x5E76360", VA = "0x185E76F60")]
	private void ADGNKMLPDDB(Entity AHNNJNFIHFM, Entity LFLCOMAPABB, Entity PGGDGHFACKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000768")]
	[Cpp2IlInjected.Address(RVA = "0x254C6E0", Offset = "0x254BAE0", VA = "0x18254C6E0")]
	private bool ICFEPCNMLOH<T>([Out] T LPCGJALKADL) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000769")]
	[Cpp2IlInjected.Address(RVA = "0x254C770", Offset = "0x254BB70", VA = "0x18254C770")]
	private void MEMBNFDJADK<T>(T LPCGJALKADL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x5E77370", Offset = "0x5E76770", VA = "0x185E77370")]
	public bool DGFIIMGAEJB(CAKFEHOBCAO JCBPGJKAHOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x5E77480", Offset = "0x5E76880", VA = "0x185E77480")]
	private static bool EHJBIDKJBMC(CAKFEHOBCAO LPJLNCPGODB, CAKFEHOBCAO GBCMLKCHJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x5E77A50", Offset = "0x5E76E50", VA = "0x185E77A50")]
	public PGDEHOKHKKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class NBODKGFHPDN : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x5E72A40", Offset = "0x5E71E40", VA = "0x185E72A40", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076F")]
	[Cpp2IlInjected.Address(RVA = "0x5E72A90", Offset = "0x5E71E90", VA = "0x185E72A90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000770")]
	[Cpp2IlInjected.Address(RVA = "0x5E72B60", Offset = "0x5E71F60", VA = "0x185E72B60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(RVA = "0x5E72FF0", Offset = "0x5E723F0", VA = "0x185E72FF0")]
	private NativeArray<Entity> PPNONDPFKCC(int CHEGLPEPHED)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(RVA = "0x5E72910", Offset = "0x5E71D10", VA = "0x185E72910")]
	private void FJNENPDBKAJ(NativeArray<Entity> CIBDFGAAMID, NativeArray<Entity> OGKCPJAEDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public NBODKGFHPDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class CIHKPEGCDIE : FILNMLJOIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private EntityQuery DMOFICMNJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private EntityQuery KOAKEBOLBKL;

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x5E61160", Offset = "0x5E60560", VA = "0x185E61160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x5E61260", Offset = "0x5E60660", VA = "0x185E61260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CIHKPEGCDIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal static class CIGIMMFNLBH
{
	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x22068C0", Offset = "0x2205CC0", VA = "0x1822068C0")]
	public static NativeArray<T> BMKHCBIDOMJ<T>(NativeArray<Entity> JIBDNODJOAB, EntityManager OKNGAOGEIDO) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x5E60E80", Offset = "0x5E60280", VA = "0x185E60E80")]
	public static void HJCKMPKOADD(EntityQuery OGHCNPNLAEN, EntityManager OKNGAOGEIDO, CDJJECGMMII JJMFHKECKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x5E60D30", Offset = "0x5E60130", VA = "0x185E60D30")]
	public static void GDEEBLIIMMK(NativeArray<Entity> CIBDFGAAMID, CDJJECGMMII JJMFHKECKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x5E61010", Offset = "0x5E60410", VA = "0x185E61010")]
	public static void NEKDFAMCDCC(NativeArray<Entity> CIBDFGAAMID, CDJJECGMMII JJMFHKECKEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class LDCCOIKMDNK : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private JFKNGONJIPL EHJFODOFCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private OELIJJIDAJD FBGBGEJBECH;

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x5E70C50", Offset = "0x5E70050", VA = "0x185E70C50", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x5E70CE0", Offset = "0x5E700E0", VA = "0x185E70CE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x5E70D90", Offset = "0x5E70190", VA = "0x185E70D90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x5E70090", Offset = "0x5E6F490", VA = "0x185E70090")]
	private void CDCAOMHJFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x5E70B40", Offset = "0x5E6FF40", VA = "0x185E70B40")]
	private void EHAACAJMODP(NativeArray<Entity> CIBDFGAAMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F320", Offset = "0x5E6E720", VA = "0x185E6F320")]
	private void BHBEEJEPGJP(NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x5E706A0", Offset = "0x5E6FAA0", VA = "0x185E706A0")]
	private void CNACOGLDBAO(NativeArray<Entity> OGKCPJAEDLJ, NativeArray<RigidTransform> MKLFFKJOAKN, NativeArray<RigidTransform> LHGGEJECAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FC00", Offset = "0x5E6F000", VA = "0x185E6FC00")]
	private void BHFJFJKKMOA(NativeArray<RigidTransform> LHGGEJECAJE, NativeArray<Entity> OGKCPJAEDLJ, NativeList<Entity> JPACNNLOCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public LDCCOIKMDNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal class JMHJHHPGDNF : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private EntityQuery BGHKBOICHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private EntityQuery GNMCFAMHANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private JJOAKEFCJNP KDDNMNODBLK;

	[Cpp2IlInjected.Token(Token = "0x6000786")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E650", Offset = "0x5E8DA50", VA = "0x185E8E650", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000787")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E710", Offset = "0x5E8DB10", VA = "0x185E8E710", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E870", Offset = "0x5E8DC70", VA = "0x185E8E870", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E6A0", Offset = "0x5E8DAA0", VA = "0x185E8E6A0")]
	private void MMCODMPMMEK(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public JMHJHHPGDNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class AFEACHCBFFO : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery LMAJMIKLAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private MDBBBKIBFGG NMABGJCEKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private NCBLCPIDIEA LPDLAAIFPJB;

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x5E80DB0", Offset = "0x5E801B0", VA = "0x185E80DB0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x5E80E40", Offset = "0x5E80240", VA = "0x185E80E40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x5E80EF0", Offset = "0x5E802F0", VA = "0x185E80EF0", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public AFEACHCBFFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class NNIAJIKPBBI : CPFJJINCILO<AFHLKEPOMBO>
{
	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x5E91C60", Offset = "0x5E91060", VA = "0x185E91C60", Slot = "14")]
	protected override void GHOAAIKOLPB(NativeArray<Entity> JIBDNODJOAB, NativeArray<Entity> OOEKLCNPOLM, NativeArray<Entity> DENBIMFLLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x5E91DC0", Offset = "0x5E911C0", VA = "0x185E91DC0")]
	private static void GHOAAIKOLPB(NativeArray<Entity> JIBDNODJOAB, NativeArray<Entity> DENBIMFLLKF, ComponentDataFromEntity<global::LDNOCNPONFN> NDEAHMKCKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x5E91E90", Offset = "0x5E91290", VA = "0x185E91E90")]
	public NNIAJIKPBBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal abstract class CPFJJINCILO<TPlayerTag> : FILNMLJOIDH where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	private EntityQuery FCFBKMEPDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	private EntityQuery HDLOBEPNAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	private EntityQuery MFDGPNALPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private EntityQuery FLOCFLBEIBH;

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x4A9ADF0", Offset = "0x4A9A1F0", VA = "0x184A9ADF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x4A9B240", Offset = "0x4A9A640", VA = "0x184A9B240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x4A9B210", Offset = "0x4A9A610", VA = "0x184A9B210", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x4A9A790", Offset = "0x4A99B90", VA = "0x184A9A790")]
	private void NONDAGHNBNH(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x4A9A4E0", Offset = "0x4A998E0", VA = "0x184A9A4E0")]
	private void IGFMIMDLPHI(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x4A99BB0", Offset = "0x4A98FB0", VA = "0x184A99BB0")]
	private void ACAIBICMICN(EntityQuery OGHCNPNLAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void GHOAAIKOLPB(NativeArray<Entity> JIBDNODJOAB, NativeArray<Entity> OOEKLCNPOLM, NativeArray<Entity> DENBIMFLLKF);

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	protected CPFJJINCILO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct MAKLEAFPAID : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public int ICOODGEKGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public int CIBDPGBBMPH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct LAEDEMIFACI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public static class LBJKIAIGNOB
{
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] JBKELOLAJIH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal struct JLMLLBNDHII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct DMKEJPIGBBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public class DDODGGFFNLA : FILNMLJOIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private EntityQuery NBENCIOIANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private ComponentTypes HCDBKBDMHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private NativeParallelHashSet<int> ACBKCGPLPDE;

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x5E85650", Offset = "0x5E84A50", VA = "0x185E85650", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x5E859E0", Offset = "0x5E84DE0", VA = "0x185E859E0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E85A60", Offset = "0x5E84E60", VA = "0x185E85A60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E855B0", Offset = "0x5E849B0", VA = "0x185E855B0")]
	public JobHandle FIOJDHAEJEM(JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public DDODGGFFNLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public struct DCPAGDAEDDN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private NativeArray<OMGHOAKAFHB> PABKANKNHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private NativeArray<int> IKLPLNNCEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private NativeParallelHashMap<int, OMGHOAKAFHB> JEHJJMNNNFH;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public readonly int NNCCBPPBFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x76DDA0", Offset = "0x76D1A0", VA = "0x18076DDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public readonly int FDIKFBFHIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xAD2B20", Offset = "0xAD1F20", VA = "0x180AD2B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E84F60", Offset = "0x5E84360", VA = "0x185E84F60")]
	public DCPAGDAEDDN(IReadOnlyCollection<BPMBFEJHHKF> DJKCBPMDJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E84DF0", Offset = "0x5E841F0", VA = "0x185E84DF0")]
	public readonly NHKJBDIFHCN DDAKKFPKNCG(int CEOOILAHGGI)
	{
		return default(NHKJBDIFHCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E84EE0", Offset = "0x5E842E0", VA = "0x185E84EE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
[DefaultMember("Item")]
public readonly struct NHKJBDIFHCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	private readonly int CEOOILAHGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	private readonly int FDFEAMCGDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private readonly NativeArray<OMGHOAKAFHB>.ReadOnly MJHCCCCPHBO;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int JBNGEMMLBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E90EA0", Offset = "0x5E902A0", VA = "0x185E90EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public NPHPOOMJPEJ ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E90DD0", Offset = "0x5E901D0", VA = "0x185E90DD0")]
		get
		{
			return default(NPHPOOMJPEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public int EBKAPCNPGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public NativeArray<OMGHOAKAFHB>.ReadOnly DIGPHPGOBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x38AC400", Offset = "0x38AB800", VA = "0x1838AC400")]
		get
		{
			return default(NativeArray<OMGHOAKAFHB>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E90ED0", Offset = "0x5E902D0", VA = "0x185E90ED0")]
	public NHKJBDIFHCN(int CEOOILAHGGI, int FDFEAMCGDDE, NativeArray<OMGHOAKAFHB>.ReadOnly MJHCCCCPHBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct JKKLCJEMGPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public NativeList<Entity> HGONJGHJKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public NativeList<Entity> BAPIMOLGPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0xA40000", Offset = "0xA3F400", VA = "0x180A40000")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public NativeList<byte> KGJDOKAPHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xD6E3E0", Offset = "0xD6D7E0", VA = "0x180D6E3E0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public NativeList<byte> AKMIGMGJLJH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xD230A0", Offset = "0xD224A0", VA = "0x180D230A0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public NativeList<byte> AICOBHEOALD
	{
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x88A1D0", Offset = "0x8895D0", VA = "0x18088A1D0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public ComponentType FHHPCIOOFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x766620", Offset = "0x765A20", VA = "0x180766620")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public JobHandle NGPOIHIFCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x93E100", Offset = "0x93D500", VA = "0x18093E100")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public int EBKAPCNPGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x93E110", Offset = "0x93D510", VA = "0x18093E110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public int EIPMCGLHEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x79A8E0", Offset = "0x799CE0", VA = "0x18079A8E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool JHDHANFMCMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E050", Offset = "0x5E8D450", VA = "0x185E8E050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E0D0", Offset = "0x5E8D4D0", VA = "0x185E8E0D0")]
	public JKKLCJEMGPF(ComponentType BCNHGHNJOMA, JobHandle EKHBDCNGFLP, NativeList<Entity> JIBDNODJOAB, NativeList<Entity> CMCKGJIOFIJ, NativeList<byte> LLNAFNHKLOP, NativeList<byte> AGJBCDLKBBJ, NativeList<byte> NPEFBKGKLLB, int FDFEAMCGDDE, int NHFBKBBPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DF30", Offset = "0x5E8D330", VA = "0x185E8DF30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal interface DKHCPOOKLEC
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	bool JHDHANFMCMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	NativeArray<IKAJAHLJFMC> NFJPKDODHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	NativeArray<CHCOMAAHOED> HFAIBICCOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	NativeArray<IKAJAHLJFMC> OCHKCHGKLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool APPEMKJFLNC([Out] NativeArray<int> HLJHPEOJMMK, Allocator JIIMEDFKEME);

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EMFNIBHIGLN(ComponentType BCNHGHNJOMA, [Out] JKKLCJEMGPF IOCCJJABDLM, [Out] NHKJBDIFHCN JLHKFPKCNHB);

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, AMHMPNCOKND> FJFANLLFKKH();
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal static class MAGJJJGDPGO
{
	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E904D0", Offset = "0x5E8F8D0", VA = "0x185E904D0")]
	public static bool OADCCJFALFJ(this DKHCPOOKLEC CGABFKIJBOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
internal interface PFGIGJNFFGK
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	NativeParallelMultiHashMap<Entity, AMHMPNCOKND> JPFINKAIANE
	{
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	uint KBMPIFGKEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JFFCNGHOCKP(NativeArray<IKAJAHLJFMC> HOKMMKNDGPI, NativeArray<CHCOMAAHOED> CPBGBMAIAGD, NativeArray<IKAJAHLJFMC> MHGMJCFOGOB, int IOHFNPPOHNI);

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOJPAKKKOEJ([In] JKKLCJEMGPF GNOADEOLHMJ);

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OANBIEHFINM(JobHandle EKHBDCNGFLP);
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public readonly struct OJMPJJENPNO : IEquatable<OJMPJJENPNO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly NHGDGBFBAIF KOJKDECJOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly int NHFBKBBPJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private readonly int JFFBKBCFPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private readonly int APOKEOFHLHM;

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NHGDGBFBAIF GDLLGPKKPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0")]
		get
		{
			return default(NHGDGBFBAIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E925B0", Offset = "0x5E919B0", VA = "0x185E925B0")]
	public unsafe ReadOnlySpan<byte> CFOMEOJJOBL(void* GKAAMDMBCKE)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E92850", Offset = "0x5E91C50", VA = "0x185E92850")]
	public unsafe ReadOnlySpan<byte> KEABDMCGODF(void* GKAAMDMBCKE)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D19E30", Offset = "0x5D19230", VA = "0x185D19E30")]
	public OJMPJJENPNO(NHGDGBFBAIF KOJKDECJOKK, int JGDHMDLNCOL, int JFFBKBCFPNG, int APOKEOFHLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E92750", Offset = "0x5E91B50", VA = "0x185E92750", Slot = "4")]
	public bool Equals(OJMPJJENPNO KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E92640", Offset = "0x5E91A40", VA = "0x185E92640", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E927E0", Offset = "0x5E91BE0", VA = "0x185E927E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public readonly struct AMHMPNCOKND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly NHGDGBFBAIF KOJKDECJOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private readonly int NHFBKBBPJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private unsafe readonly byte* JFFBKBCFPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private unsafe readonly byte* APOKEOFHLHM;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public NHGDGBFBAIF GDLLGPKKPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x9786C0", Offset = "0x977AC0", VA = "0x1809786C0")]
		get
		{
			return default(NHGDGBFBAIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int NLNGCCHEOCA
	{
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0070", Offset = "0x1F9F470", VA = "0x181FA0070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public unsafe byte* IEGAOMOGFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x978670", Offset = "0x977A70", VA = "0x180978670")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public unsafe byte* GIOFLKMGGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E817A0", Offset = "0x5E80BA0", VA = "0x185E817A0")]
	public JGFJHAANPIB KEABDMCGODF(Type DJMKKNDNCBM)
	{
		return default(JGFJHAANPIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x29F3110", Offset = "0x29F2510", VA = "0x1829F3110")]
	public T CFOMEOJJOBL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x29F3130", Offset = "0x29F2530", VA = "0x1829F3130")]
	public T KEABDMCGODF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E81890", Offset = "0x5E80C90", VA = "0x185E81890")]
	public unsafe AMHMPNCOKND(NHGDGBFBAIF KOJKDECJOKK, int JGDHMDLNCOL, byte* JFFBKBCFPNG, byte* APOKEOFHLHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public readonly struct NPHPOOMJPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private readonly int CEOOILAHGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private readonly int KOJKDECJOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private readonly OMGHOAKAFHB DKFJHNAPKHH;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public OMGHOAKAFHB NLENAAKGKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x978670", Offset = "0x977A70", VA = "0x180978670")]
		get
		{
			return default(OMGHOAKAFHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E91ED0", Offset = "0x5E912D0", VA = "0x185E91ED0")]
	public NPHPOOMJPEJ(int CEOOILAHGGI, int KOJKDECJOKK, OMGHOAKAFHB DKFJHNAPKHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal abstract class GOEHEFJKIEI : EBJOJOKGOLF, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private KEMPNLKAPFH EHIPJPLBPBA;

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	protected abstract JDIKJEAMOOG AIIJBIEKCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B460", Offset = "0x5E8A860", VA = "0x185E8B460", Slot = "16")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B850", Offset = "0x5E8AC50", VA = "0x185E8B850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B4B0", Offset = "0x5E8A8B0", VA = "0x185E8B4B0", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	protected GOEHEFJKIEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal class LBIJIHECEHE : GOEHEFJKIEI
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected override JDIKJEAMOOG AIIJBIEKCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "17")]
		get
		{
			return default(JDIKJEAMOOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FFA0", Offset = "0x5E8F3A0", VA = "0x185E8FFA0")]
	public LBIJIHECEHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class POGLKBEKOAI : GOEHEFJKIEI
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected override JDIKJEAMOOG AIIJBIEKCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x8015E0", Offset = "0x8009E0", VA = "0x1808015E0", Slot = "17")]
		get
		{
			return default(JDIKJEAMOOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E92960", Offset = "0x5E91D60", VA = "0x185E92960")]
	public POGLKBEKOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
public class KEMIFIDGKCP : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	[DMNKPOGEHOO]
	private KEMPNLKAPFH OEPHCJKDDND;

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E9C0", Offset = "0x5E8DDC0", VA = "0x185E8E9C0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EA10", Offset = "0x5E8DE10", VA = "0x185E8EA10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public KEMIFIDGKCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[AlwaysUpdateSystem]
public class CEDBLHKIJIL : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public enum ELLLACAJOKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		Remove
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	[DMNKPOGEHOO]
	private KEMPNLKAPFH EHIPJPLBPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private KJAFPNOPCLH OIDCMGJLMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private CMMEMOIBFML CBHCJJMLIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private NJPEPKGEBDB GIAMJGNONNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private KNGKOABEDPD LMAFADEADNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private EBPHCLBENMO KENOMMGHIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EPEJDMDOFFP MGMHKPHCEHF;

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E836B0", Offset = "0x5E82AB0", VA = "0x185E836B0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E83BC0", Offset = "0x5E82FC0", VA = "0x185E83BC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E83D30", Offset = "0x5E83130", VA = "0x185E83D30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E83A40", Offset = "0x5E82E40", VA = "0x185E83A40")]
	private void KNABENHPJMC([Out] NativeArray<IKAJAHLJFMC> HOKMMKNDGPI, [Out] NativeArray<CHCOMAAHOED> CPBGBMAIAGD, [Out] NativeArray<IKAJAHLJFMC> MHGMJCFOGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E83CE0", Offset = "0x5E830E0", VA = "0x185E83CE0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E83C40", Offset = "0x5E83040", VA = "0x185E83C40", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CEDBLHKIJIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal readonly struct KJAFPNOPCLH
{
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private static readonly ProfilerMarker FMHCJMMNHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private readonly FILNMLJOIDH FIPLOBJLBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private readonly World GFDIPPMMOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private readonly EntityQuery LKMDEIOGNIL;

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F070", Offset = "0x5E8E470", VA = "0x185E8F070")]
	public KJAFPNOPCLH(FILNMLJOIDH FIPLOBJLBLA, World GFDIPPMMOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EA30", Offset = "0x5E8DE30", VA = "0x185E8EA30")]
	public (NativeArray<IKAJAHLJFMC>, NativeArray<CHCOMAAHOED>) MCPJDCOFDHA()
	{
		return default((NativeArray<IKAJAHLJFMC>, NativeArray<CHCOMAAHOED>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct EPEJDMDOFFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private static readonly ProfilerMarker FMHCJMMNHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private readonly FILNMLJOIDH FIPLOBJLBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private NativeList<(EntityQuery query, int componentIndex)> PGPOBKFOPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private NativeList<(EntityQuery query, int componentIndex)> JLLCPOJLNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private NativeList<(EntityQuery query, int componentIndex)> HOPAPIOGEPJ;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A5A0", Offset = "0x5E899A0", VA = "0x185E8A5A0")]
	public EPEJDMDOFFP(FILNMLJOIDH FIPLOBJLBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E89730", Offset = "0x5E88B30", VA = "0x185E89730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E89790", Offset = "0x5E88B90", VA = "0x185E89790")]
	public NativeList<(EntityQuery, int, int, CEDBLHKIJIL.ELLLACAJOKG)> EJODEAJJFHO(uint LFPIMOJLAJB, [Out] int AHNDKIGIIPJ)
	{
		return default(NativeList<(EntityQuery, int, int, CEDBLHKIJIL.ELLLACAJOKG)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A200", Offset = "0x5E89600", VA = "0x185E8A200")]
	private int GKJNMEHBAAP(CEDBLHKIJIL.ELLLACAJOKG OHCLHGENEBF, NativeList<(EntityQuery query, int typeIndex)> INCBMJFBGNP, NativeList<(EntityQuery query, int typeIndex, int count, CEDBLHKIJIL.ELLLACAJOKG mode)> JLPFPEEBHJE, uint LFPIMOJLAJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A450", Offset = "0x5E89850", VA = "0x185E8A450")]
	private NativeList<(EntityQuery, int)> MADGKKIIHHH(NativeParallelHashSet<int> DJKCBPMDJBO, int FDIDILLDLFK)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A3B0", Offset = "0x5E897B0", VA = "0x185E8A3B0")]
	private NativeList<(EntityQuery, int)> LJMDKEGCKGH(NativeParallelHashSet<int> DJKCBPMDJBO, int FDIDILLDLFK)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E89B60", Offset = "0x5E88F60", VA = "0x185E89B60")]
	private NativeList<(EntityQuery, int)> FBKIGNMNKIA(NativeParallelHashSet<int> DJKCBPMDJBO, int FDIDILLDLFK, CEDBLHKIJIL.ELLLACAJOKG OHCLHGENEBF)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E89F10", Offset = "0x5E89310", VA = "0x185E89F10")]
	private NativeList<(EntityQuery, int)> GIBGPNMMMAJ()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal readonly struct EBPHCLBENMO
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[BurstCompile]
	private struct DIDFONGBEPP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		[ReadOnly]
		public EntityTypeHandle IKHFBEFJMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		[ReadOnly]
		public ComponentDataFromEntity<MAKLEAFPAID> INPADAEJEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		[ReadOnly]
		public DynamicComponentTypeHandle HFLJLMKKGEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> PFEIKCOKMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> DBKMEBDNNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		[ReadOnly]
		public ComponentDataFromEntity HBJIJBIGOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly KAFJIIKLNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		[ReadOnly]
		public NativeArray<OMGHOAKAFHB>.ReadOnly EJDBDEMAJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public ComponentDataFromEntity OHGPODNHFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public NativeList<Entity> APNOJHLECKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public NativeList<Entity> HDEEGHPMJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public NativeList<byte> DEALKPHGJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public NativeList<byte> ECHIEBLIPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public NativeList<byte> PJLPKJHMOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public int NHFBKBBPJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int FDFEAMCGDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public bool MBFEBMDOFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CEDBLHKIJIL.ELLLACAJOKG OHCLHGENEBF;

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x5E865F0", Offset = "0x5E859F0", VA = "0x185E865F0", Slot = "4")]
		public void Execute(ArchetypeChunk LPPKICFIEJM, int ADOGCNALFGH, int ILCIGNLDBCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x5E86B60", Offset = "0x5E85F60", VA = "0x185E86B60")]
		private unsafe bool NPIBGIADGGD(Entity EGKFEABOBJC, Entity BKGDGNCOJBL, byte* ABLHOGCPIEK, byte* KOCPOGNCLFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x5E86D80", Offset = "0x5E86180", VA = "0x185E86D80")]
		private unsafe void PCONDBHNLLG(byte* ABLHOGCPIEK, byte* KOCPOGNCLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x5E86AC0", Offset = "0x5E85EC0", VA = "0x185E86AC0")]
		private unsafe byte* MLEIPHDPGKP(NativeArray<byte> BMOOHBLEHBO, int PBOOCHALMNO)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x5E86580", Offset = "0x5E85980", VA = "0x185E86580")]
		private unsafe byte* BNFFGJPNBDE(Entity BKGDGNCOJBL)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x5E869A0", Offset = "0x5E85DA0", VA = "0x185E869A0")]
		private unsafe byte* KEDIEKECDJD(ArchetypeChunk LPPKICFIEJM)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x5E86A90", Offset = "0x5E85E90", VA = "0x185E86A90")]
		private static Entity LDDEIAOBEMN([In] MAKLEAFPAID OOIBMCBCEPD)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[BurstCompile]
	private struct IALABGDIPGN : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[ReadOnly]
		public NativeList<Entity> NHDIIJGJAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		[ReadOnly]
		public NativeList<byte> IBHJHAEENBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		[ReadOnly]
		public NativeList<byte> PHIEOHHCLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		[ReadOnly]
		public NativeList<byte> POMHEPGDGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		[ReadOnly]
		public NativeArray<OMGHOAKAFHB>.ReadOnly EJDBDEMAJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public NativeParallelMultiHashMap<Entity, AMHMPNCOKND> NPCKCKKJLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public int NHFBKBBPJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public int FDFEAMCGDDE;

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x5E8BD40", Offset = "0x5E8B140", VA = "0x185E8BD40", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private static readonly ProfilerMarker FMHCJMMNHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private readonly FILNMLJOIDH FIPLOBJLBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private readonly World GFDIPPMMOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private readonly DCPAGDAEDDN LNOECNPDHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private readonly NativeParallelHashMap<int, Entity> PMHCKMDJPNF;

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E896B0", Offset = "0x5E88AB0", VA = "0x185E896B0")]
	public EBPHCLBENMO(FILNMLJOIDH FIPLOBJLBLA, World GFDIPPMMOGM, KEMPNLKAPFH EHIPJPLBPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E88E10", Offset = "0x5E88210", VA = "0x185E88E10")]
	public JobHandle MCPJDCOFDHA(PFGIGJNFFGK CGABFKIJBOC, NativeList<(EntityQuery query, int typeIndex, int count, CEDBLHKIJIL.ELLLACAJOKG mode)> MNIFNPOEFCE, JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x5E895F0", Offset = "0x5E889F0", VA = "0x185E895F0")]
	private IALABGDIPGN NFMABOKAABL([In] DIDFONGBEPP GODHNNBCFKE, NativeParallelMultiHashMap<Entity, AMHMPNCOKND> OKJEBPIJLNN)
	{
		return default(IALABGDIPGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x5E88A00", Offset = "0x5E87E00", VA = "0x185E88A00")]
	private DIDFONGBEPP IMACGEHIFAF(ComponentType BCNHGHNJOMA, EntityManager KAONBPOKDJI, int CJLBDFMFLGP, CEDBLHKIJIL.ELLLACAJOKG OHCLHGENEBF)
	{
		return default(DIDFONGBEPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x5E888A0", Offset = "0x5E87CA0", VA = "0x185E888A0")]
	private static void DDAGBANLEKK(PFGIGJNFFGK CGABFKIJBOC, ComponentType BCNHGHNJOMA, JobHandle HDIPEJPBMFJ, [In] DIDFONGBEPP GODHNNBCFKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal readonly struct KNGKOABEDPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private readonly DDODGGFFNLA OODKEDDMEPH;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private static readonly ProfilerMarker FMHCJMMNHOF;

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FB30", Offset = "0x5E8EF30", VA = "0x185E8FB30")]
	public KNGKOABEDPD(World GFDIPPMMOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F900", Offset = "0x5E8ED00", VA = "0x185E8F900")]
	public JobHandle MCPJDCOFDHA(JobHandle PHHDFGLNBBL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal readonly struct CMMEMOIBFML
{
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private static readonly ProfilerMarker FMHCJMMNHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private readonly FILNMLJOIDH FIPLOBJLBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private readonly World GFDIPPMMOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private readonly EntityQuery PBCNKBFDFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private readonly EntityQuery JICDAOLHPAH;

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x5E84CC0", Offset = "0x5E840C0", VA = "0x185E84CC0")]
	public CMMEMOIBFML(FILNMLJOIDH FIPLOBJLBLA, World GFDIPPMMOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x5E84A90", Offset = "0x5E83E90", VA = "0x185E84A90")]
	public NativeArray<IKAJAHLJFMC> MCPJDCOFDHA()
	{
		return default(NativeArray<IKAJAHLJFMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x5E849F0", Offset = "0x5E83DF0", VA = "0x185E849F0")]
	public void JGHMILEGGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x5E84590", Offset = "0x5E83990", VA = "0x185E84590")]
	private NativeArray<IKAJAHLJFMC> HPOJNLGPELL(EntityQuery OGHCNPNLAEN)
	{
		return default(NativeArray<IKAJAHLJFMC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal readonly struct NJPEPKGEBDB
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class AFGDIINFNAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public FILNMLJOIDH system;

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public AFGDIINFNAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x5E80F90", Offset = "0x5E80390", VA = "0x185E80F90")]
		internal (EntityQuery, ComponentType) LFKFGILDLND((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private static readonly ProfilerMarker FMHCJMMNHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private readonly FILNMLJOIDH FIPLOBJLBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] LHBJBIFPLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private readonly EntityQuery NIOCDPODDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private readonly EntityQuery OBEKADOPHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private readonly ComponentTypes FEBNIFLJHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private readonly ComponentTypes OKPENLLHFCF;

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x5E91480", Offset = "0x5E90880", VA = "0x185E91480")]
	public NJPEPKGEBDB(FILNMLJOIDH FIPLOBJLBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x5E91100", Offset = "0x5E90500", VA = "0x185E91100")]
	public void MCPJDCOFDHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal class ICNABLKBAOD : GEPDBFLIOMG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	public struct GNPONPFKBAM : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected override ComponentType GAIOJIAHKNI
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C2F0", Offset = "0x5E8B6F0", VA = "0x185E8C2F0", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	protected override ComponentType AJJGODJIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C320", Offset = "0x5E8B720", VA = "0x185E8C320", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	protected override ComponentType NIEIPOPLNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C2C0", Offset = "0x5E8B6C0", VA = "0x185E8C2C0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C3E0", Offset = "0x5E8B7E0", VA = "0x185E8C3E0")]
	public ICNABLKBAOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class MNPKAOFKICM : GEPDBFLIOMG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct KFBNKDPOHFM : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	protected override ComponentType GAIOJIAHKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x5E90AF0", Offset = "0x5E8FEF0", VA = "0x185E90AF0", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	protected override ComponentType AJJGODJIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x5E90B20", Offset = "0x5E8FF20", VA = "0x185E90B20", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected override ComponentType NIEIPOPLNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x5E90AC0", Offset = "0x5E8FEC0", VA = "0x185E90AC0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x5E90BE0", Offset = "0x5E8FFE0", VA = "0x185E90BE0")]
	public MNPKAOFKICM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
public struct DPHPLFAGOPL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
[MEBHHNIGJKC]
public class OIONLGHGLKF : NEKPFIPDOIF
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	private struct JJIMCIJGMEB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		[ReadOnly]
		public NativeParallelHashSet<int> KBBHHFJDCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		[ReadOnly]
		public EntityTypeHandle HPJPLLGDGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> PGFOCMBMFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public NativeList<Entity>.ParallelWriter DALKIGMPNLG;

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DE50", Offset = "0x5E8D250", VA = "0x185E8DE50", Slot = "4")]
		public void Execute(ArchetypeChunk LPPKICFIEJM, int ADOGCNALFGH, int ILCIGNLDBCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x5E92040", Offset = "0x5E91440", VA = "0x185E92040", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x5E920D0", Offset = "0x5E914D0", VA = "0x185E920D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x5E91FF0", Offset = "0x5E913F0", VA = "0x185E91FF0")]
	private EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public OIONLGHGLKF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[MEBHHNIGJKC]
	[CompilerGenerated]
	public class DebugPostDeserializeRemoveOrphanedSplinePoints : NEKPFIPDOIF
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[ReadOnly]
			public ComponentDataFromEntity<GEJEAEPKOAF> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			[ReadOnly]
			public ComponentTypeHandle<JLDGOFKMBDC> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x5E872B0", Offset = "0x5E866B0", VA = "0x185E872B0")]
			private void DGGBDJJHEJJ(Entity entity, [In][NoAlias] JLDGOFKMBDC point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x5E87340", Offset = "0x5E86740", VA = "0x185E87340", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private EntityQuery DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private ComponentTypeHandle<JLDGOFKMBDC> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x5E87640", Offset = "0x5E86A40", VA = "0x185E87640", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x5E871D0", Offset = "0x5E865D0", VA = "0x185E871D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void ACOODLCLANO(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x5E87260", Offset = "0x5E86660", VA = "0x185E87260")]
		private EntityCommandBufferSystem BAHPIGNLNHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x5E87880", Offset = "0x5E86C80", VA = "0x185E87880")]
		private JobHandle PHPJIEPAJEP(EntityCommandBuffer ecb, ComponentDataFromEntity<GEJEAEPKOAF> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x5E87460", Offset = "0x5E86860", VA = "0x185E87460", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public DebugPostDeserializeRemoveOrphanedSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[MEBHHNIGJKC]
public class FFMJOFGNIEH : NEKPFIPDOIF
{
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AA10", Offset = "0x5E89E10", VA = "0x185E8AA10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AAB0", Offset = "0x5E89EB0", VA = "0x185E8AAB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A9C0", Offset = "0x5E89DC0", VA = "0x185E8A9C0")]
	private EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public FFMJOFGNIEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[MEBHHNIGJKC]
public class KOJIOFBHFFG : NEKPFIPDOIF
{
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FBE0", Offset = "0x5E8EFE0", VA = "0x185E8FBE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FCA0", Offset = "0x5E8F0A0", VA = "0x185E8FCA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FB90", Offset = "0x5E8EF90", VA = "0x185E8FB90")]
	private EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public KOJIOFBHFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[UpdateAfter(typeof(OIONLGHGLKF))]
public class CFGJFFNCGPC : FILNMLJOIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private EntityArchetype GBBKJGLLHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x5E842A0", Offset = "0x5E836A0", VA = "0x185E842A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x5E843C0", Offset = "0x5E837C0", VA = "0x185E843C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x5E84250", Offset = "0x5E83650", VA = "0x185E84250")]
	private EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CFGJFFNCGPC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplines : FILNMLJOIDH
	{
		[Cpp2IlInjected.Token(Token = "0x2000169")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x5E92B50", Offset = "0x5E91F50", VA = "0x185E92B50")]
			private void DGGBDJJHEJJ(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x5E92C00", Offset = "0x5E92000", VA = "0x185E92C00", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016A")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentTypeHandle<JLDGOFKMBDC> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x5E92CB0", Offset = "0x5E920B0", VA = "0x185E92CB0")]
			private void DGGBDJJHEJJ(Entity splinePoint, [In][NoAlias] JLDGOFKMBDC splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x5E92D60", Offset = "0x5E92160", VA = "0x185E92D60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private ComponentTypeHandle<JLDGOFKMBDC> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x5E93290", Offset = "0x5E92690", VA = "0x185E93290", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x5E93350", Offset = "0x5E92750", VA = "0x185E93350", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x5E929B0", Offset = "0x5E91DB0", VA = "0x185E929B0")]
		private EntityCommandBufferSystem BAHPIGNLNHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x5E92E80", Offset = "0x5E92280", VA = "0x185E92E80")]
		private void NMIBFFBHBPJ(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x5E92A00", Offset = "0x5E91E00", VA = "0x185E92A00")]
		private void KFCLMNAEFGN(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x5E92F80", Offset = "0x5E92380", VA = "0x185E92F80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostDeserializeAddSplinePointsToSplines()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public class AJAHNPMFPJN : FILNMLJOIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x5E81080", Offset = "0x5E80480", VA = "0x185E81080", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x5E81150", Offset = "0x5E80550", VA = "0x185E81150", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public AJAHNPMFPJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal sealed class HPHNCDKDMNG : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x880870", Offset = "0x87FC70", VA = "0x180880870", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc OGHCNPNLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x880870", Offset = "0x87FC70", VA = "0x180880870", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc OGHCNPNLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x880870", Offset = "0x87FC70", VA = "0x180880870", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc OGHCNPNLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BCC0", Offset = "0x5E8B0C0", VA = "0x185E8BCC0", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc OGHCNPNLAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BD00", Offset = "0x5E8B100", VA = "0x185E8BD00")]
	public HPHNCDKDMNG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[MEBHHNIGJKC]
	[CompilerGenerated]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : FILNMLJOIDH
	{
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x5E93860", Offset = "0x5E92C60", VA = "0x185E93860", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0x5E93900", Offset = "0x5E92D00", VA = "0x185E93900", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x5E93670", Offset = "0x5E92A70", VA = "0x185E93670")]
		private EntityCommandBufferSystem BAHPIGNLNHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x5E936C0", Offset = "0x5E92AC0", VA = "0x185E936C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
public class BKOHLLIHJDE : MKFJKMHDKAG
{
	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x5E83660", Offset = "0x5E82A60", VA = "0x185E83660", Slot = "14")]
	protected override EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public BKOHLLIHJDE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePoints : FILNMLJOIDH
	{
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			[ReadOnly]
			public ComponentDataFromEntity<NDHHNBFLAPP> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0x5E928E0", Offset = "0x5E91CE0", VA = "0x185E928E0", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeSortSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x5E93D50", Offset = "0x5E93150", VA = "0x185E93D50")]
			private void DGGBDJJHEJJ(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x5E93DE0", Offset = "0x5E931E0", VA = "0x185E93DE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private EntityQuery PostDeserializeSortSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x5E94210", Offset = "0x5E93610", VA = "0x185E94210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x5E93C20", Offset = "0x5E93020", VA = "0x185E93C20")]
		private void DDABNEBBCKD(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x5E93F10", Offset = "0x5E93310", VA = "0x185E93F10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostDeserializeSortSplinePoints()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	public class PostDeserializeTransformRoots : FILNMLJOIDH
	{
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public ComponentTypeHandle<JHKAHHLIAHN> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600086E")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F560", Offset = "0x5E7E960", VA = "0x185E7F560")]
			private void DGGBDJJHEJJ([NoAlias] JHKAHHLIAHN data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086F")]
			[Cpp2IlInjected.Address(RVA = "0x5E94990", Offset = "0x5E93D90", VA = "0x185E94990", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000174")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			public ComponentTypeHandle<KMCDAKDJLDL> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000870")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F790", Offset = "0x5E7EB90", VA = "0x185E7F790")]
			private void DGGBDJJHEJJ([NoAlias] KMCDAKDJLDL data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000871")]
			[Cpp2IlInjected.Address(RVA = "0x5E94A60", Offset = "0x5E93E60", VA = "0x185E94A60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public ComponentTypeHandle<BCKADNEGCAC> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			[ReadOnly]
			public ComponentTypeHandle<JHKAHHLIAHN> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000872")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F7A0", Offset = "0x5E7EBA0", VA = "0x185E7F7A0")]
			private void DGGBDJJHEJJ([NoAlias] BCKADNEGCAC authoredPose, [In][NoAlias] JHKAHHLIAHN pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0x5E94B30", Offset = "0x5E93F30", VA = "0x185E94B30", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRoots_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public ComponentTypeHandle<CNMCJMOMOIM> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			[ReadOnly]
			public ComponentTypeHandle<KMCDAKDJLDL> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000874")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F7C0", Offset = "0x5E7EBC0", VA = "0x185E7F7C0")]
			private void DGGBDJJHEJJ([NoAlias] CNMCJMOMOIM authoredScale, [In][NoAlias] KMCDAKDJLDL scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x5E94C80", Offset = "0x5E94080", VA = "0x185E94C80", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private EntityQuery __query_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private ComponentTypeHandle<JHKAHHLIAHN> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private ComponentTypeHandle<KMCDAKDJLDL> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private ComponentTypeHandle<BCKADNEGCAC> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private ComponentTypeHandle<JHKAHHLIAHN> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private ComponentTypeHandle<CNMCJMOMOIM> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private ComponentTypeHandle<KMCDAKDJLDL> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x5E95760", Offset = "0x5E94B60", VA = "0x185E95760", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x5E94500", Offset = "0x5E93900", VA = "0x185E94500")]
		private void FBJMFMIECOF([In] CJOBJHHCGGP transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x5E95C50", Offset = "0x5E95050", VA = "0x185E95C50")]
		private void PMLPDFCANDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x5E94860", Offset = "0x5E93C60", VA = "0x185E94860")]
		private JobHandle JCILABNAPBM(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x5E94DD0", Offset = "0x5E941D0", VA = "0x185E94DD0")]
		private JobHandle OJDIILLLMGI(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x5E94720", Offset = "0x5E93B20", VA = "0x185E94720")]
		private JobHandle IGIJIEOPFEK(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x5E943C0", Offset = "0x5E937C0", VA = "0x185E943C0")]
		private JobHandle AKKBEPEPGIJ(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x5E94ED0", Offset = "0x5E942D0", VA = "0x185E94ED0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostDeserializeTransformRoots()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public static class EIFMPNMJGHL
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	public interface FLPONCIIKGL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	public interface BIKIDAHEEOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public class GBCFEEMBFLG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	public class GGGMOJEEFOE : BIKIDAHEEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B030", Offset = "0x5E8A430", VA = "0x185E8B030")]
		public GGGMOJEEFOE(ComponentType OFAFLOECBGM, ComponentType OBIDCEBALPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	public class AMCJIHBBICD : BIKIDAHEEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x383A320", Offset = "0x3839720", VA = "0x18383A320")]
		public AMCJIHBBICD(ComponentType OFAFLOECBGM, ComponentType[] OBIDCEBALPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017E")]
	public class LDJEHBHPIKC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000878")]
	[Cpp2IlInjected.Address(RVA = "0x2257C40", Offset = "0x2257040", VA = "0x182257C40")]
	public static BIKIDAHEEOC KJKAJKCKHNK<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000879")]
	[Cpp2IlInjected.Address(RVA = "0x2257B20", Offset = "0x2256F20", VA = "0x182257B20")]
	public static BIKIDAHEEOC CBIIMFGOJLM<TFrom>(params ComponentType[] IAJADCLDFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public class GEJGMJLFKGE : IHEAACHMMDM
{
	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	public GEJGMJLFKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
public class KJBPCBBGEFM : NEKPFIPDOIF
{
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x600087D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F1F0", Offset = "0x5E8E5F0", VA = "0x185E8F1F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087E")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F1A0", Offset = "0x5E8E5A0", VA = "0x185E8F1A0")]
	private EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600087F")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public KJBPCBBGEFM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[GEJGMJLFKGE]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : HCDEMKPPBAD
	{
		[Cpp2IlInjected.Token(Token = "0x2000183")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			public KCCMBEDDPPK<GPICBPKHPPP> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000507")]
			public KCCMBEDDPPK<NNMJJBNOBBA> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000508")]
			public KCCMBEDDPPK<MFMALOPLMGO> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000509")]
			public KCCMBEDDPPK<OHFCKCCLMHB> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public HHKPKOIGIGD<NIMLEEDPPHK> v4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public MFMALOPLMGO v2Default;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x5E96BC0", Offset = "0x5E95FC0", VA = "0x185E96BC0")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x5E97280", Offset = "0x5E96680", VA = "0x185E97280", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		protected override FJOGIBEAJHF Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0x5E966C0", Offset = "0x5E95AC0", VA = "0x185E966C0", Slot = "14")]
			get
			{
				return default(FJOGIBEAJHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x5E97650", Offset = "0x5E96A50", VA = "0x185E97650", Slot = "15")]
		public override IEnumerable<EIFMPNMJGHL.BIKIDAHEEOC> PDNBJFKHGIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x5E96710", Offset = "0x5E95B10", VA = "0x185E96710", Slot = "16")]
		protected override void DMGNOLLAAMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x5E97290", Offset = "0x5E96690", VA = "0x185E97290")]
		private static void NFFDGDHPJNC(NBBBGFFIEAI<NNMJJBNOBBA> srcVersion, NBBBGFFIEAI<MFMALOPLMGO> dstVersion, MFMALOPLMGO dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x5E97830", Offset = "0x5E96C30", VA = "0x185E97830")]
		private static void PHNBCENJOEI(NBBBGFFIEAI<MFMALOPLMGO> srcVersion, NBBBGFFIEAI<OHFCKCCLMHB> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x5E96A90", Offset = "0x5E95E90", VA = "0x185E96A90")]
		private static void JDNDCOKBMDJ(NBBBGFFIEAI<OHFCKCCLMHB> srcVersion, NBBBGFFIEAI<NIMLEEDPPHK> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x5E97430", Offset = "0x5E96830", VA = "0x185E97430")]
		private JobHandle OKILAGCBGMI(KCCMBEDDPPK<GPICBPKHPPP> v0, KCCMBEDDPPK<NNMJJBNOBBA> v1, KCCMBEDDPPK<MFMALOPLMGO> v2, KCCMBEDDPPK<OHFCKCCLMHB> v3, HHKPKOIGIGD<NIMLEEDPPHK> v4, MFMALOPLMGO v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[GEJGMJLFKGE]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : HCDEMKPPBAD
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public KCCMBEDDPPK<DJPBNNMNDAF> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public HHKPKOIGIGD<BIDCHAAGDGC> v2;

			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0x5E96180", Offset = "0x5E95580", VA = "0x185E96180")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0x5E96490", Offset = "0x5E95890", VA = "0x185E96490", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		protected override FJOGIBEAJHF Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x5E95E90", Offset = "0x5E95290", VA = "0x185E95E90", Slot = "14")]
			get
			{
				return default(FJOGIBEAJHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x5E96570", Offset = "0x5E95970", VA = "0x185E96570", Slot = "15")]
		public override IEnumerable<EIFMPNMJGHL.BIKIDAHEEOC> PDNBJFKHGIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x5E95EE0", Offset = "0x5E952E0", VA = "0x185E95EE0", Slot = "16")]
		protected override void DMGNOLLAAMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x5E964A0", Offset = "0x5E958A0", VA = "0x185E964A0")]
		private static void NFFDGDHPJNC(NBBBGFFIEAI<DJPBNNMNDAF> srcVersion, NBBBGFFIEAI<BIDCHAAGDGC> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x5E96050", Offset = "0x5E95450", VA = "0x185E96050")]
		private JobHandle GACNDILJBIH(KCCMBEDDPPK<DJPBNNMNDAF> v1, HHKPKOIGIGD<BIDCHAAGDGC> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[MEBHHNIGJKC]
	[GEJGMJLFKGE]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : HCDEMKPPBAD, EIFMPNMJGHL.FLPONCIIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x2000187")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public KCCMBEDDPPK<AAJBENABJJE> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public KCCMBEDDPPK<MPLACFMMCHH> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x5E97C60", Offset = "0x5E97060", VA = "0x185E97C60")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x5E98080", Offset = "0x5E97480", VA = "0x185E98080", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		protected override FJOGIBEAJHF Log
		{
			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0x5E979E0", Offset = "0x5E96DE0", VA = "0x185E979E0", Slot = "14")]
			get
			{
				return default(FJOGIBEAJHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x5E98370", Offset = "0x5E97770", VA = "0x185E98370", Slot = "15")]
		public override IEnumerable<EIFMPNMJGHL.BIKIDAHEEOC> PDNBJFKHGIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x5E97A30", Offset = "0x5E96E30", VA = "0x185E97A30", Slot = "16")]
		protected override void DMGNOLLAAMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x5E98090", Offset = "0x5E97490", VA = "0x185E98090")]
		private static void NDABEPHJJOH(PLMICHLCHNC<MPLACFMMCHH> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x5E98220", Offset = "0x5E97620", VA = "0x185E98220")]
		private JobHandle NGMNJLJFJOP(KCCMBEDDPPK<AAJBENABJJE> v0, KCCMBEDDPPK<MPLACFMMCHH> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[GEJGMJLFKGE]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : HCDEMKPPBAD
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			public KCCMBEDDPPK<MOILEDNJIDM> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			public HHKPKOIGIGD<ELPJEOHAOJK> v1;

			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x5E98810", Offset = "0x5E97C10", VA = "0x185E98810")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0x5E98A60", Offset = "0x5E97E60", VA = "0x185E98A60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		protected override FJOGIBEAJHF Log
		{
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E98520", Offset = "0x5E97920", VA = "0x185E98520", Slot = "14")]
			get
			{
				return default(FJOGIBEAJHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E98A70", Offset = "0x5E97E70", VA = "0x185E98A70", Slot = "15")]
		public override IEnumerable<EIFMPNMJGHL.BIKIDAHEEOC> PDNBJFKHGIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E98570", Offset = "0x5E97970", VA = "0x185E98570", Slot = "16")]
		protected override void DMGNOLLAAMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E986E0", Offset = "0x5E97AE0", VA = "0x185E986E0")]
		private JobHandle LCNLHIOBGLN(KCCMBEDDPPK<MOILEDNJIDM> v0, HHKPKOIGIGD<ELPJEOHAOJK> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[GEJGMJLFKGE]
public class LJILMBAEJEL : FILNMLJOIDH, EIFMPNMJGHL.FLPONCIIKGL
{
	[Cpp2IlInjected.Token(Token = "0x60008AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E903C0", Offset = "0x5E8F7C0", VA = "0x185E903C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E90370", Offset = "0x5E8F770", VA = "0x185E90370")]
	private EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008AF")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public LJILMBAEJEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
public class DLBMJCLLKPC : LDEADJINIFO
{
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	protected override EPPFDODHFHJ IFNLNGGDMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "15")]
		get
		{
			return default(EPPFDODHFHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E86DF0", Offset = "0x5E861F0", VA = "0x185E86DF0", Slot = "16")]
	protected override void EIEJDGADPIP(EPPFDODHFHJ KAHINILDCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E86DA0", Offset = "0x5E861A0", VA = "0x185E86DA0")]
	private EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E87180", Offset = "0x5E86580", VA = "0x185E87180")]
	public DLBMJCLLKPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[GEJGMJLFKGE]
public class NFGDHFDJJGA : FILNMLJOIDH, EIFMPNMJGHL.FLPONCIIKGL
{
	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E90CC0", Offset = "0x5E900C0", VA = "0x185E90CC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E90C70", Offset = "0x5E90070", VA = "0x185E90C70")]
	private EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public NFGDHFDJJGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[GEJGMJLFKGE]
public class HDAAABLBAHP : FILNMLJOIDH, EIFMPNMJGHL.FLPONCIIKGL
{
	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BBB0", Offset = "0x5E8AFB0", VA = "0x185E8BBB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BB60", Offset = "0x5E8AF60", VA = "0x185E8BB60")]
	private EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public HDAAABLBAHP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	[GEJGMJLFKGE]
	public class PostDeserializeUpgrade_Split_ContainerData : FILNMLJOIDH, EIFMPNMJGHL.FLPONCIIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Split_ContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			public NativeArray<FDCHJMJKAJM> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x60008C2")]
			[Cpp2IlInjected.Address(RVA = "0x5E98D50", Offset = "0x5E98150", VA = "0x185E98D50")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008C3")]
			[Cpp2IlInjected.Address(RVA = "0x5E99030", Offset = "0x5E98430", VA = "0x185E99030", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E99490", Offset = "0x5E98890", VA = "0x185E99490", Slot = "14")]
		public IEnumerable<EIFMPNMJGHL.BIKIDAHEEOC> PDNBJFKHGIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E99040", Offset = "0x5E98440", VA = "0x185E99040", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E98BC0", Offset = "0x5E97FC0", VA = "0x185E98BC0")]
		private EntityCommandBufferSystem BAHPIGNLNHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E98C10", Offset = "0x5E98010", VA = "0x185E98C10")]
		private JobHandle CDPHBABOBFG(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<FDCHJMJKAJM> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E995E0", Offset = "0x5E989E0", VA = "0x185E995E0")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[AlwaysUpdateSystem]
public abstract class HCDEMKPPBAD : FILNMLJOIDH, EIFMPNMJGHL.FLPONCIIKGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private NativeList<EntityQuery> MNIFNPOEFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private bool KBCBILDHJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private EntityCommandBufferSystem FLDGJNGPMOE;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	protected bool NAKHODPHEOC
	{
		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x55E85D0", Offset = "0x55E79D0", VA = "0x1855E85D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	protected abstract FJOGIBEAJHF IJCNCIMJJJN
	{
		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<EIFMPNMJGHL.BIKIDAHEEOC> PDNBJFKHGIP();

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B9E0", Offset = "0x5E8ADE0", VA = "0x185E8B9E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BB00", Offset = "0x5E8AF00", VA = "0x185E8BB00", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BAB0", Offset = "0x5E8AEB0", VA = "0x185E8BAB0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void DMGNOLLAAMD();

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B990", Offset = "0x5E8AD90", VA = "0x185E8B990")]
	protected EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x23D1180", Offset = "0x23D0580", VA = "0x1823D1180")]
	protected EntityQuery OFLMJNNCHLH<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CD")]
	[Cpp2IlInjected.Address(RVA = "0x23D0480", Offset = "0x23CF880", VA = "0x1823D0480")]
	protected KCCMBEDDPPK<T> KOFHOICEHFG<T>() where T : struct, IComponentData
	{
		return default(KCCMBEDDPPK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x23D0030", Offset = "0x23CF430", VA = "0x1823D0030")]
	protected HHKPKOIGIGD<T> ABMDLFPKCMA<T>() where T : struct, IComponentData
	{
		return default(HHKPKOIGIGD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x23D0140", Offset = "0x23CF540", VA = "0x1823D0140")]
	protected static void DFAONDEEIFM<T1, T2>(PLMICHLCHNC<T1> DAHJEAKFLIN, PLMICHLCHNC<T2> LMCKFEMPEHN) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D0")]
	[Cpp2IlInjected.Address(RVA = "0x23D0140", Offset = "0x23CF540", VA = "0x1823D0140")]
	protected static void DFAONDEEIFM<T1, T2>(PLMICHLCHNC<T1> DAHJEAKFLIN, ICNIGKPFNBB<T2> LMCKFEMPEHN) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D1")]
	[Cpp2IlInjected.Address(RVA = "0x23D0240", Offset = "0x23CF640", VA = "0x1823D0240")]
	private static void DFAONDEEIFM<T1, T2>(NBBBGFFIEAI<T1> DAHJEAKFLIN, NBBBGFFIEAI<T2> LMCKFEMPEHN) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D2")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	protected HCDEMKPPBAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public abstract class LDEADJINIFO : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	protected virtual EPPFDODHFHJ FCFCCPDGIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "14")]
		get
		{
			return default(EPPFDODHFHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	protected virtual EPPFDODHFHJ IFNLNGGDMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x8015E0", Offset = "0x8009E0", VA = "0x1808015E0", Slot = "15")]
		get
		{
			return default(EPPFDODHFHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008D5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void EIEJDGADPIP(EPPFDODHFHJ KAHINILDCOI);

	[Cpp2IlInjected.Token(Token = "0x60008D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E90230", Offset = "0x5E8F630", VA = "0x185E90230", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E901D0", Offset = "0x5E8F5D0", VA = "0x185E901D0")]
	private EPPFDODHFHJ LNDPEHBIDBK()
	{
		return default(EPPFDODHFHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	protected LDEADJINIFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
public class EPNJOFCJAGK : FILNMLJOIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private GCCGGPIGBBG FLDGJNGPMOE;

	[Cpp2IlInjected.Token(Token = "0x60008DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A7A0", Offset = "0x5E89BA0", VA = "0x185E8A7A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A870", Offset = "0x5E89C70", VA = "0x185E8A870", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public EPNJOFCJAGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
public class KKGJGLDNJAI : FILNMLJOIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private GCCGGPIGBBG FLDGJNGPMOE;

	[Cpp2IlInjected.Token(Token = "0x60008DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F6E0", Offset = "0x5E8EAE0", VA = "0x185E8F6E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F7B0", Offset = "0x5E8EBB0", VA = "0x185E8F7B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public KKGJGLDNJAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public class GNOPIFMFJGF : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private OMHOJHJBKGP FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B0E0", Offset = "0x5E8A4E0", VA = "0x185E8B0E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B070", Offset = "0x5E8A470", VA = "0x185E8B070", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B1B0", Offset = "0x5E8A5B0", VA = "0x185E8B1B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E3")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public GNOPIFMFJGF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkId : NEKPFIPDOIF, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		private struct DebugPostLoadValidateNetworkId_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public NativeParallelHashMap<IKAJAHLJFMC, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			[ReadOnly]
			public ComponentTypeHandle<ACNBNJEPOMH> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60008EA")]
			[Cpp2IlInjected.Address(RVA = "0x5E87A20", Offset = "0x5E86E20", VA = "0x185E87A20")]
			private void DGGBDJJHEJJ(Entity entity, [In] ACNBNJEPOMH networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0x5E87AA0", Offset = "0x5E86EA0", VA = "0x185E87AA0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private GICCNDIODFI networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private EntityQuery DebugPostLoadValidateNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private ComponentTypeHandle<ACNBNJEPOMH> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E879C0", Offset = "0x5E86DC0", VA = "0x185E879C0", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E87EB0", Offset = "0x5E872B0", VA = "0x185E87EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E87BC0", Offset = "0x5E86FC0", VA = "0x185E87BC0")]
		private void OIOHPDCFLAK(NativeParallelHashMap<IKAJAHLJFMC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E87CB0", Offset = "0x5E870B0", VA = "0x185E87CB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public DebugPostLoadValidateNetworkId()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentData : NEKPFIPDOIF, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		private struct DebugPostLoadValidateParentData_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public DebugPostLoadValidateParentData __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x5E880D0", Offset = "0x5E874D0", VA = "0x185E880D0")]
			private void DGGBDJJHEJJ(Entity entity, [In] ParentData parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0x5E88330", Offset = "0x5E87730", VA = "0x185E88330", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private CDJJECGMMII objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private EntityQuery DebugPostLoadValidateParentData_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E88070", Offset = "0x5E87470", VA = "0x185E88070", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E87FA0", Offset = "0x5E873A0", VA = "0x185E87FA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E87FA0", Offset = "0x5E873A0", VA = "0x185E87FA0")]
		private void ECMPKKOLIPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E88450", Offset = "0x5E87850", VA = "0x185E88450", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public DebugPostLoadValidateParentData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E88650", Offset = "0x5E87A50", VA = "0x185E88650")]
		[CompilerGenerated]
		private void PHKECCDHPII(Entity entity, [In] ParentData parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class DDBEBPCKCMF : NEKPFIPDOIF, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private BNKPHKHKLHD CNIFLPLFONI;

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E85550", Offset = "0x5E84950", VA = "0x185E85550", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public DDBEBPCKCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[UpdateBefore(typeof(NNCDENFLEBF))]
public class NJIJABJJHFD : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E90EE0", Offset = "0x5E902E0", VA = "0x185E90EE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E90F90", Offset = "0x5E90390", VA = "0x185E90F90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public NJIJABJJHFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class APHDPADNCAP : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct OFJKMMIGBPB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		[ReadOnly]
		public NativeArray<GDONJJDLDOI> OPHBJIGPLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		[ReadOnly]
		public NativeArray<Entity> JIBDNODJOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public ComponentDataFromEntity MGPGBHCLBKE;

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x5E91EE0", Offset = "0x5E912E0", VA = "0x185E91EE0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[BurstCompile]
	private struct DHPDNHCCFBM : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> OKABHPKJNCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> FOHKBNNKJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> JOFKLMGJNLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> INPLCOAFKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> KHPNENHGFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public NativeList<EntityArchetype> BLOICIMELNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public NativeList<EntityArchetype> ECJPKPJAPIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public NativeList<OMGHOAKAFHB> MFDMOMMPLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public NativeList<OMGHOAKAFHB> EFJABFHBPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public NativeList<GDONJJDLDOI> MCBPEIPNMEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public NativeList<ComponentType> GABAJGJIIBJ;

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x5E86540", Offset = "0x5E85940", VA = "0x185E86540", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x5E85BA0", Offset = "0x5E84FA0", VA = "0x185E85BA0", Slot = "5")]
		public JobHandle Dispose(JobHandle EKHBDCNGFLP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x5E85DB0", Offset = "0x5E851B0", VA = "0x185E85DB0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x5E864A0", Offset = "0x5E858A0", VA = "0x185E864A0")]
		private int LFAMEKNFJCC(OMGHOAKAFHB HJJJECIFKNK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x5E862B0", Offset = "0x5E856B0", VA = "0x185E862B0")]
		private bool KDNJBDJLHLD(int HIEBFIBHHGA, EntityArchetype AGHMFFANACM, [Out] EntityArchetype DIGKIHPCEJH, [Out] Entity GICKCOJIMAK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct KGAPOHKHKJG : IComparer<GDONJJDLDOI>
	{
		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x93A220", Offset = "0x939620", VA = "0x18093A220", Slot = "4")]
		public int Compare(GDONJJDLDOI DCLOFHDPPBE, GDONJJDLDOI JMNKJKLHIOM)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[BurstCompile]
	private struct LHNFHDJHJDM : MDKNBLGBOFF<GDONJJDLDOI, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0xDD3170", Offset = "0xDD2570", VA = "0x180DD3170")]
		public int LEFOCAFCCCD([In] GDONJJDLDOI KECAMMIJJDM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0xDD3170", Offset = "0xDD2570", VA = "0x180DD3170", Slot = "4")]
		private int HLLJEDAMKLI([In] GDONJJDLDOI LPCGJALKADL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	private struct GDONJJDLDOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public Entity GICKCOJIMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public OMGHOAKAFHB JIBDNODJOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int HMNBJEMACFA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private KHHBHMMACPM FNIMMOLDOMI;

	[Cpp2IlInjected.Token(Token = "0x60008FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E820F0", Offset = "0x5E814F0", VA = "0x185E820F0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E82720", Offset = "0x5E81B20", VA = "0x185E82720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E827E0", Offset = "0x5E81BE0", VA = "0x185E827E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E81EA0", Offset = "0x5E812A0", VA = "0x185E81EA0")]
	private DHPDNHCCFBM FOIJJMFOGAD(NativeArray<ArchetypeChunk> LPKGOPKLMOH)
	{
		return default(DHPDNHCCFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E81D20", Offset = "0x5E81120", VA = "0x185E81D20")]
	private void FBHCMAAMHKP(NativeArray<EntityArchetype> ECJPKPJAPIN, NativeArray<OMGHOAKAFHB> MFDMOMMPLOB, NativeArray<OMGHOAKAFHB> EFJABFHBPPK, NativeArray<ComponentType> GABAJGJIIBJ, NativeArray<ArchetypeChunk> LPKGOPKLMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0x5E818B0", Offset = "0x5E80CB0", VA = "0x185E818B0")]
	private EntityArchetype ACHPOMDDJLL(EntityArchetype IAJMIBNGMKC, NativeArray<ComponentType> GABAJGJIIBJ, OMGHOAKAFHB DKFJHNAPKHH)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x5E82140", Offset = "0x5E81540", VA = "0x185E82140")]
	private JobHandle JPCKGNMAHMB(NativeList<GDONJJDLDOI> OPHBJIGPLEP, NativeArray<Entity> JIBDNODJOAB, JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000902")]
	[Cpp2IlInjected.Address(RVA = "0x5E81B50", Offset = "0x5E80F50", VA = "0x185E81B50")]
	private JobHandle ELCHJGDBPCD(NativeArray<Entity> JIBDNODJOAB, NativeArray<GDONJJDLDOI> OPHBJIGPLEP, int CEOOILAHGGI, OMGHOAKAFHB DKFJHNAPKHH, JobHandle INOHAEAJFAP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000903")]
	[Cpp2IlInjected.Address(RVA = "0x5E820E0", Offset = "0x5E814E0", VA = "0x185E820E0")]
	public static bool IMCNBIBGAAG(ComponentType BCNHGHNJOMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000904")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public APHDPADNCAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[UpdateBefore(typeof(APHDPADNCAP))]
public class NNCDENFLEBF : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private BNKPHKHKLHD CNIFLPLFONI;

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x5E91980", Offset = "0x5E90D80", VA = "0x185E91980", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000910")]
	[Cpp2IlInjected.Address(RVA = "0x5E919D0", Offset = "0x5E90DD0", VA = "0x185E919D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000911")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public NNCDENFLEBF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[CompilerGenerated]
	[AGNACEIDMIN(DPJKEJCGJEB.OMRoom)]
	public class PostLoadInitializeNetworkId : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x20001A3")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostLoadInitializeNetworkId_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x20001A4")]
			public delegate void RunWithoutJobSystem_00000AD2$PostfixBurstDelegate(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001A5")]
			internal static class RunWithoutJobSystem_00000AD2$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000561")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000562")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x600092B")]
				[Cpp2IlInjected.Address(RVA = "0x5E9F990", Offset = "0x5E9ED90", VA = "0x185E9F990")]
				[BurstDiscard]
				private static void JMEDLGAJLPK(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092C")]
				[Cpp2IlInjected.Address(RVA = "0x5E9FAC0", Offset = "0x5E9EEC0", VA = "0x185E9FAC0")]
				private static IntPtr JNIJBLGCHBM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x600092D")]
				[Cpp2IlInjected.Address(RVA = "0x5E9FC20", Offset = "0x5E9F020", VA = "0x185E9FC20")]
				public static void NAAFEMAKKBL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092E")]
				[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
				public static void OMELHDOHHCI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000930")]
				[Cpp2IlInjected.Address(RVA = "0x5E9F7A0", Offset = "0x5E9EBA0", VA = "0x185E9F7A0")]
				public static void DFPIJIPLDKJ(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400055A")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x400055B")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			public NativeParallelHashMap<IKAJAHLJFMC, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			public uint playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			public uint offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			public ComponentTypeHandle<ACNBNJEPOMH> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0x5E9A980", Offset = "0x5E99D80", VA = "0x185E9A980")]
			private void DGGBDJJHEJJ(Entity entity, int entityInQueryIndex, [NoAlias] ACNBNJEPOMH dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0x5E9AA10", Offset = "0x5E99E10", VA = "0x185E9AA10", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0x5E9AB50", Offset = "0x5E99F50", VA = "0x185E9AB50")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void GBPHJAFBJCI(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0x5E9AD70", Offset = "0x5E9A170", VA = "0x185E9AD70")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void KOKNNIPBNLL(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostLoadInitializeNetworkId_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.Token(Token = "0x20001A7")]
			public delegate void RunWithoutJobSystem_00000AD5$PostfixBurstDelegate(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001A8")]
			internal static class RunWithoutJobSystem_00000AD5$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000569")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x400056A")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000937")]
				[Cpp2IlInjected.Address(RVA = "0x5E9FEC0", Offset = "0x5E9F2C0", VA = "0x185E9FEC0")]
				[BurstDiscard]
				private static void JMEDLGAJLPK(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000938")]
				[Cpp2IlInjected.Address(RVA = "0x5E9FFF0", Offset = "0x5E9F3F0", VA = "0x185E9FFF0")]
				private static IntPtr JNIJBLGCHBM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000939")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0150", Offset = "0x5E9F550", VA = "0x185EA0150")]
				public static void NAAFEMAKKBL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600093A")]
				[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
				public static void OMELHDOHHCI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600093C")]
				[Cpp2IlInjected.Address(RVA = "0x5E9FCD0", Offset = "0x5E9F0D0", VA = "0x185E9FCD0")]
				public static void DFPIJIPLDKJ(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000563")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000564")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			public NativeParallelHashMap<IKAJAHLJFMC, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public ComponentTypeHandle<ACNBNJEPOMH> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000931")]
			[Cpp2IlInjected.Address(RVA = "0x5E9ADE0", Offset = "0x5E9A1E0", VA = "0x185E9ADE0")]
			private void DGGBDJJHEJJ(Entity entity, [NoAlias] ACNBNJEPOMH dstValue, [In][NoAlias] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0x5E9AE50", Offset = "0x5E9A250", VA = "0x185E9AE50", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000933")]
			[Cpp2IlInjected.Address(RVA = "0x5E9AFF0", Offset = "0x5E9A3F0", VA = "0x185E9AFF0")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void GBPHJAFBJCI(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B210", Offset = "0x5E9A610", VA = "0x185E9B210")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void KOKNNIPBNLL(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		private struct PostLoadInitializeNetworkId_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public NativeParallelHashMap<IKAJAHLJFMC, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600093D")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B280", Offset = "0x5E9A680", VA = "0x185E9B280")]
			private void DGGBDJJHEJJ(Entity entity, [In] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600093E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B390", Offset = "0x5E9A790", VA = "0x185E9B390", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		[DMNKPOGEHOO]
		private GICCNDIODFI networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		[DMNKPOGEHOO]
		private BNKPHKHKLHD scenes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private EntityQuery queryAllInScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private EntityQuery queryAllInActiveRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private EntityQuery additiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private EntityQuery __query_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private ComponentTypeHandle<ACNBNJEPOMH> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x5E99D20", Offset = "0x5E99120", VA = "0x185E99D20", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BCE0", Offset = "0x5E9B0E0", VA = "0x185E9BCE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BE20", Offset = "0x5E9B220", VA = "0x185E9BE20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E99AB0", VA = "0x185E9A6B0")]
		public void KDCNHLFHFMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x5E99EE0", Offset = "0x5E992E0", VA = "0x185E99EE0")]
		private void JJKMJNNFGAP(NativeParallelHashMap<IKAJAHLJFMC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x5E997F0", Offset = "0x5E98BF0", VA = "0x185E997F0")]
		private void DCKFMFDPAAD(NativeParallelHashMap<IKAJAHLJFMC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A4B0", Offset = "0x5E998B0", VA = "0x185E9A4B0")]
		private void KAFPKILAGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A810", Offset = "0x5E99C10", VA = "0x185E9A810")]
		private void KICOCEMCMIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x5E99D00", Offset = "0x5E99100", VA = "0x185E99D00")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void FFMHJKAEFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B4B0", Offset = "0x5E9A8B0", VA = "0x185E9B4B0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void MCOIADFDHJC(NativeParallelHashMap<IKAJAHLJFMC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x5E99D90", Offset = "0x5E99190", VA = "0x185E99D90")]
		private void JDOEBMGIJLE(NativeParallelHashMap<IKAJAHLJFMC, Entity> map, uint playerId, uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x5E99B90", Offset = "0x5E98F90", VA = "0x185E99B90")]
		private void FDIINACMOFC(NativeParallelHashMap<IKAJAHLJFMC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A720", Offset = "0x5E99B20", VA = "0x185E9A720")]
		private void KGFCMOPDJEJ(NativeParallelHashMap<IKAJAHLJFMC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B590", Offset = "0x5E9A990", VA = "0x185E9B590", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x5E997B0", Offset = "0x5E98BB0", VA = "0x185E997B0")]
		public static void BFMFIOPIDGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C230", Offset = "0x5E9B630", VA = "0x185E9C230")]
		public static void PHKMHIPMPHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParent : FILNMLJOIDH
	{
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C4A0", Offset = "0x5E9B8A0", VA = "0x185E9C4A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C580", Offset = "0x5E9B980", VA = "0x185E9C580", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C300", Offset = "0x5E9B700", VA = "0x185E9C300", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostLoadMoveRootsUnderParent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	[AGNACEIDMIN(DPJKEJCGJEB.OMRoom)]
	public class PostLoadRemapCircuitIds : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x20001AC")]
		private struct PostLoadRemapCircuitIds_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			public IIOGBKCCMMK remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			public ComponentTypeHandle<BCGFIGGPKKM> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9CC30", Offset = "0x5E9C030", VA = "0x185E9CC30")]
			private void DGGBDJJHEJJ(BCGFIGGPKKM node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9CE40", Offset = "0x5E9C240", VA = "0x185E9CE40", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		[DMNKPOGEHOO]
		private JFKABFIKFCO serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private EntityQuery PostLoadRemapCircuitIds_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private ComponentTypeHandle<BCGFIGGPKKM> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CB00", Offset = "0x5E9BF00", VA = "0x185E9CB00", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D110", Offset = "0x5E9C510", VA = "0x185E9D110", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CB50", Offset = "0x5E9BF50", VA = "0x185E9CB50")]
		private void LMBEGKPDMAI(IIOGBKCCMMK remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CA20", Offset = "0x5E9BE20", VA = "0x185E9CA20")]
		private void CEMFFHJJCKB(IIOGBKCCMMK remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CF10", Offset = "0x5E9C310", VA = "0x185E9CF10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PostLoadRemapCircuitIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public class IGFBHPPMJIN : FILNMLJOIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C440", Offset = "0x5E8B840", VA = "0x185E8C440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C4D0", Offset = "0x5E8B8D0", VA = "0x185E8C4D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public IGFBHPPMJIN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : FILNMLJOIDH
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PreSerializeDowngrade_RRObjectPrefabTypeData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			[ReadOnly]
			public SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunksRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			[ReadOnly]
			public NativeParallelHashMap<int, int> prefabTypeFromIndexRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public MJLNBOHDIGD.ABECBNAFFOM<ArchetypeChunk, DGEMEBNOAJP<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public NativeList<MPLACFMMCHH> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x6000956")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D2C0", Offset = "0x5E9C6C0", VA = "0x185E9D2C0")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000957")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D580", Offset = "0x5E9C980", VA = "0x185E9D580", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D8E0", Offset = "0x5E9CCE0", VA = "0x185E9D8E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D980", Offset = "0x5E9CD80", VA = "0x185E9D980", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D270", Offset = "0x5E9C670", VA = "0x185E9D270")]
		private EntityCommandBufferSystem BAHPIGNLNHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D590", Offset = "0x5E9C990", VA = "0x185E9D590")]
		private JobHandle MLBOJAKACKN(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, MJLNBOHDIGD.ABECBNAFFOM<ArchetypeChunk, DGEMEBNOAJP<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<MPLACFMMCHH> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D740", Offset = "0x5E9CB40", VA = "0x185E9D740", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class FJDBDHNGICB : FILNMLJOIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private EntityQuery MPHHNLOJFCO;

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x5E8ADC0", Offset = "0x5E8A1C0", VA = "0x185E8ADC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AE50", Offset = "0x5E8A250", VA = "0x185E8AE50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AFE0", Offset = "0x5E8A3E0", VA = "0x185E8AFE0")]
	private EntityCommandBufferSystem PGMIFOINOGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public FJDBDHNGICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
[AlwaysUpdateSystem]
public class IPEIALGAEDL : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DD10", Offset = "0x5E8D110", VA = "0x185E8DD10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public IPEIALGAEDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class AKNKCGAAGFI : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private static FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private EntityQuery EHLABPGMIBN;

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x5E813C0", Offset = "0x5E807C0", VA = "0x185E813C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x5E81640", Offset = "0x5E80A40", VA = "0x185E81640", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public AKNKCGAAGFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class CLCLBCNNDCD : MKFJKMHDKAG
{
	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x5E84540", Offset = "0x5E83940", VA = "0x185E84540", Slot = "14")]
	protected override EntityCommandBufferSystem BAHPIGNLNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CLCLBCNNDCD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIds : FILNMLJOIDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E5A0", Offset = "0x5E9D9A0", VA = "0x185E9E5A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E630", Offset = "0x5E9DA30", VA = "0x185E9E630", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E9B0", Offset = "0x5E9DDB0", VA = "0x185E9E9B0")]
		private EntityCommandBufferSystem PGMIFOINOGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E400", Offset = "0x5E9D800", VA = "0x185E9E400", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PreSerializeSaveNetworkIds()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[CompilerGenerated]
	public class PreSerializeTransformRoots : FILNMLJOIDH
	{
		[Cpp2IlInjected.Token(Token = "0x20001B6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PreSerializeTransformRoots_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public ComponentTypeHandle<JHKAHHLIAHN> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0x5E80B70", Offset = "0x5E7FF70", VA = "0x185E80B70")]
			private void DGGBDJJHEJJ([NoAlias] JHKAHHLIAHN data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0x5E9EE50", Offset = "0x5E9E250", VA = "0x185E9EE50", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B7")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PreSerializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public ComponentTypeHandle<KMCDAKDJLDL> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000971")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F790", Offset = "0x5E7EB90", VA = "0x185E7F790")]
			private void DGGBDJJHEJJ([NoAlias] KMCDAKDJLDL data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0x5E9EF20", Offset = "0x5E9E320", VA = "0x185E9EF20", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private EntityQuery PreSerializeTransformRoots_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private EntityQuery PreSerializeTransformRoots_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private EntityQuery __query_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private ComponentTypeHandle<JHKAHHLIAHN> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private ComponentTypeHandle<KMCDAKDJLDL> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F4C0", Offset = "0x5E9E8C0", VA = "0x185E9F4C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EA00", Offset = "0x5E9DE00", VA = "0x185E9EA00")]
		private void FBJMFMIECOF([In] CJOBJHHCGGP transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9ED20", Offset = "0x5E9E120", VA = "0x185E9ED20")]
		private JobHandle JCDNFACKPOJ(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EC20", Offset = "0x5E9E020", VA = "0x185E9EC20")]
		private JobHandle GEBMOFJGBME(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EFF0", Offset = "0x5E9E3F0", VA = "0x185E9EFF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public PreSerializeTransformRoots()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
[AlwaysUpdateSystem]
public class BGDJAIABIIN : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(RVA = "0x5E82ED0", Offset = "0x5E822D0", VA = "0x185E82ED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public BGDJAIABIIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public static class IJCDOLEBDME
{
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[BurstCompile]
	private struct ICBBAPPNOJC : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		[ReadOnly]
		public NativeParallelHashSet<int> LPMEHOFJLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> INPLCOAFKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public NativeList<EntityArchetype> EKINKIHNGFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public NativeList<OMGHOAKAFHB> MFDMOMMPLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public NativeList<OMGHOAKAFHB> EFJABFHBPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public NativeList<ComponentType> HLOHDKBFLJF;

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C010", Offset = "0x5E8B410", VA = "0x185E8C010", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x5E8BF80", Offset = "0x5E8B380", VA = "0x185E8BF80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C560", Offset = "0x5E8B960", VA = "0x185E8C560")]
	public static NativeParallelHashSet<int> AFIFHKFPMBA(Allocator JIIMEDFKEME)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CD70", Offset = "0x5E8C170", VA = "0x185E8CD70")]
	public static NativeParallelHashSet<int> GFGFNKECPIB(Allocator JIIMEDFKEME)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C7C0", Offset = "0x5E8BBC0", VA = "0x185E8C7C0")]
	private static void FAHBJGJBDCC(NativeParallelHashSet<int> EGLHFCPNJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D9F0", Offset = "0x5E8CDF0", VA = "0x185E8D9F0")]
	private static bool MFKJLODNKCK(Type DJMKKNDNCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DAD0", Offset = "0x5E8CED0", VA = "0x185E8DAD0")]
	private static void MNBPCILEDHF(NativeParallelHashSet<int> EGLHFCPNJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CB30", Offset = "0x5E8BF30", VA = "0x185E8CB30")]
	private static void FBENLAKJEOO(NativeParallelHashSet<int> EGLHFCPNJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CEB0", Offset = "0x5E8C2B0", VA = "0x185E8CEB0")]
	private static void JBBCBMOFGPO(NativeParallelHashSet<int> EGLHFCPNJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D0F0", Offset = "0x5E8C4F0", VA = "0x185E8D0F0")]
	public static void JFAJCMKJCJK(EntityManager OKNGAOGEIDO, EntityQuery OGHCNPNLAEN, NativeParallelHashSet<int> ACBKCGPLPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C620", Offset = "0x5E8BA20", VA = "0x185E8C620")]
	public static void AHOMAOHGODA(EntityManager OKNGAOGEIDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public static class JLMICOKBAJH
{
	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E2F0", Offset = "0x5E8D6F0", VA = "0x185E8E2F0")]
	public static NativeParallelHashSet<int> GICKGCFMEMP(EntityManager OKNGAOGEIDO, Allocator JIIMEDFKEME)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E130", Offset = "0x5E8D530", VA = "0x185E8E130")]
	public static NativeParallelHashMap<int, int> AGKKJKEHAPI(EntityManager OKNGAOGEIDO, Allocator JIIMEDFKEME)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public abstract class MKFJKMHDKAG : FILNMLJOIDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private EntityQuery OGHCNPNLAEN;

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem BAHPIGNLNHL();

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x5E905E0", Offset = "0x5E8F9E0", VA = "0x185E905E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x5E90670", Offset = "0x5E8FA70", VA = "0x185E90670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	protected MKFJKMHDKAG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public struct MOLEMNMJCPC : DDJMNOHICJD<ParentData>
{
	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x5E90C40", Offset = "0x5E90040", VA = "0x185E90C40", Slot = "4")]
	public bool ENCCMEAEGLN(ParentData LPCGJALKADL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[BurstCompile]
public struct DGEMEBNOAJP<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> KHPNENHGFDA;

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x15F95C0", Offset = "0x15F89C0", VA = "0x1815F95C0")]
	public DGEMEBNOAJP(SharedComponentTypeHandle<T> KHPNENHGFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2760", Offset = "0x4CF1B60", VA = "0x184CF2760", Slot = "4")]
	public bool Equals(ArchetypeChunk DCLOFHDPPBE, ArchetypeChunk JMNKJKLHIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x4CF2860", Offset = "0x4CF1C60", VA = "0x184CF2860", Slot = "5")]
	public int GetHashCode(ArchetypeChunk LPPKICFIEJM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public struct ICNIGKPFNBB<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private NBBBGFFIEAI<T> KAHINILDCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059A")]
	private EntityCommandBuffer DBMEKMBMPIL;

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x35C2B10", Offset = "0x35C1F10", VA = "0x1835C2B10")]
	public ICNIGKPFNBB(NBBBGFFIEAI<T> KAHINILDCOI, EntityCommandBuffer DBMEKMBMPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x35C28E0", Offset = "0x35C1CE0", VA = "0x1835C28E0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x35C2420", Offset = "0x35C1820", VA = "0x1835C2420")]
	public static NBBBGFFIEAI<T> DLNOOKJDMMJ(ICNIGKPFNBB<T> JMKAEDPOKOH)
	{
		return default(NBBBGFFIEAI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public struct HHKPKOIGIGD<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	private HIPFKGOLFJG<T> KAHINILDCOI;

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x351CF50", Offset = "0x351C350", VA = "0x18351CF50")]
	public HHKPKOIGIGD(HIPFKGOLFJG<T> KAHINILDCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x351CE50", Offset = "0x351C250", VA = "0x18351CE50")]
	public ICNIGKPFNBB<T> GDAIMFAFCKC()
	{
		return default(ICNIGKPFNBB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public struct PLMICHLCHNC<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private NBBBGFFIEAI<T> KAHINILDCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	private EntityCommandBuffer DBMEKMBMPIL;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public NBBBGFFIEAI<T> BEELPBCCFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x35C2420", Offset = "0x35C1820", VA = "0x1835C2420")]
		get
		{
			return default(NBBBGFFIEAI<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x35C2B10", Offset = "0x35C1F10", VA = "0x1835C2B10")]
	public PLMICHLCHNC(NBBBGFFIEAI<T> KAHINILDCOI, EntityCommandBuffer DBMEKMBMPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x3E70CB0", Offset = "0x3E700B0", VA = "0x183E70CB0")]
	public void KEBBCLCADMA(HIPFKGOLFJG<T> MGFFKKAPKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x3E70460", Offset = "0x3E6F860", VA = "0x183E70460", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x35C2420", Offset = "0x35C1820", VA = "0x1835C2420")]
	public static NBBBGFFIEAI<T> DLNOOKJDMMJ(PLMICHLCHNC<T> JMKAEDPOKOH)
	{
		return default(NBBBGFFIEAI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
public struct KCCMBEDDPPK<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	private HIPFKGOLFJG<T> KAHINILDCOI;

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x351CF50", Offset = "0x351C350", VA = "0x18351CF50")]
	public KCCMBEDDPPK(HIPFKGOLFJG<T> KAHINILDCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0x37E2AD0", Offset = "0x37E1ED0", VA = "0x1837E2AD0")]
	public PLMICHLCHNC<T> MMINKDLNEKL()
	{
		return default(PLMICHLCHNC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
[DefaultMember("Item")]
public struct NBBBGFFIEAI<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	public NativeList<Entity> JIBDNODJOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A0")]
	public NativeList<T> OOIBMCBCEPD;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public int JBNGEMMLBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC890", Offset = "0x3BCBC90", VA = "0x183BCC890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public (Entity entity, T value) ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC510", Offset = "0x3BCB910", VA = "0x183BCC510")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCB50", Offset = "0x3BCBF50", VA = "0x183BCCB50")]
	public void GIHKKMKIIOJ(Entity AHNNJNFIHFM, T LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099A")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB7D0", Offset = "0x3BCABD0", VA = "0x183BCB7D0")]
	public void CHIKBOMFKCF(NativeArray<Entity> AHNNJNFIHFM, NativeArray<T> LPCGJALKADL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
public struct HIPFKGOLFJG<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	[ReadOnly]
	public EntityQueryInJob OGHCNPNLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	[ReadOnly]
	public EntityTypeHandle KDBPEMHGGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	[ReadOnly]
	public ComponentTypeHandle<T> MAAIOPDMFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	[WriteOnly]
	public EntityCommandBuffer DBMEKMBMPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	public AllocatorManager.AllocatorHandle JIIMEDFKEME;

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x351E320", Offset = "0x351D720", VA = "0x18351E320")]
	public NBBBGFFIEAI<T> GDAIMFAFCKC()
	{
		return default(NBBBGFFIEAI<T>);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	[CompilerGenerated]
	internal class SplinePointOrderingUpdateSystem : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x20001C6")]
		[BurstCompile]
		private struct UpdateSplineIndexJob : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			[ReadOnly]
			public NativeArray<global::EOEJBDFFKPH> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			[ReadOnly]
			public ComponentDataFromEntity<JLDGOFKMBDC> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			public ComponentDataFromEntity<NDHHNBFLAPP> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x60009A4")]
			[Cpp2IlInjected.Address(RVA = "0x5EA10E0", Offset = "0x5EA04E0", VA = "0x185EA10E0", Slot = "4")]
			public void Execute(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C7")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			[ReadOnly]
			public ComponentDataFromEntity<NDHHNBFLAPP> orderRO;

			[Cpp2IlInjected.Token(Token = "0x60009A5")]
			[Cpp2IlInjected.Address(RVA = "0x5EBDFC0", Offset = "0x5EBD3C0", VA = "0x185EBDFC0", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C8")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SplinePointOrderingUpdateSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009A6")]
			[Cpp2IlInjected.Address(RVA = "0x5EC0B30", Offset = "0x5EBFF30", VA = "0x185EC0B30")]
			private void DGGBDJJHEJJ(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0x5EC0BC0", Offset = "0x5EBFFC0", VA = "0x185EC0BC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		[DMNKPOGEHOO]
		private OMMEEFHEKMM singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA06F0", Offset = "0x5E9FAF0", VA = "0x185EA06F0", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0BC0", Offset = "0x5E9FFC0", VA = "0x185EA0BC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0360", Offset = "0x5E9F760", VA = "0x185EA0360")]
		private void GFODMKMBPGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0200", Offset = "0x5E9F600", VA = "0x185EA0200")]
		private void CJHJOKEPKOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0870", Offset = "0x5E9FC70", VA = "0x185EA0870")]
		private static KIEGJAEKKEG ODBKEHDOHPH(int insertionIndex, ComponentDataFromEntity<NDHHNBFLAPP> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(KIEGJAEKKEG);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0740", Offset = "0x5E9FB40", VA = "0x185EA0740")]
		private JobHandle KICGCJIOBFA(OrderComparer comparer, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA09B0", Offset = "0x5E9FDB0", VA = "0x185EA09B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[CompilerGenerated]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	internal class SplinePointParentChangedSystem : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SplinePointParentChangedSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005B9")]
			public DynamicBuffer<global::EOEJBDFFKPH> splineIndexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005BB")]
			[ReadOnly]
			public ComponentTypeHandle<JLDGOFKMBDC> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x5EC13B0", Offset = "0x5EC07B0", VA = "0x185EC13B0")]
			private void DGGBDJJHEJJ(Entity splinePoint, [In][NoAlias] JLDGOFKMBDC splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1500", Offset = "0x5EC0900", VA = "0x185EC1500", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			[ReadOnly]
			public ComponentTypeHandle<global::FMKMGABDEPP> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009B4")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1620", Offset = "0x5EC0A20", VA = "0x185EC1620")]
			private void DGGBDJJHEJJ(Entity splinePoint, [In][NoAlias] global::FMKMGABDEPP splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1750", Offset = "0x5EC0B50", VA = "0x185EC1750", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private EntityQuery needsAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private EntityQuery needsRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[DMNKPOGEHOO]
		private OMMEEFHEKMM singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private ComponentTypeHandle<JLDGOFKMBDC> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private ComponentTypeHandle<global::FMKMGABDEPP> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1360", Offset = "0x5EC0760", VA = "0x185EC1360", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D70", Offset = "0x5EC1170", VA = "0x185EC1D70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D60", Offset = "0x5EC1160", VA = "0x185EC1D60", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0CF0", Offset = "0x5EC00F0", VA = "0x185EC0CF0")]
		private void ACIIFBAMKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0F80", Offset = "0x5EC0380", VA = "0x185EC0F80")]
		private void HFAFHDKHDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0F30", Offset = "0x5EC0330", VA = "0x185EC0F30")]
		private EntityCommandBufferSystem BAHPIGNLNHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1870", Offset = "0x5EC0C70", VA = "0x185EC1870")]
		private JobHandle OLDNDLNDKKN(EntityCommandBuffer ecb, DynamicBuffer<global::EOEJBDFFKPH> splineIndexUpdatesRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1230", Offset = "0x5EC0630", VA = "0x185EC1230")]
		private JobHandle HJLNMAMOEHM(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x5EC19C0", Offset = "0x5EC0DC0", VA = "0x185EC19C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public SplinePointParentChangedSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class OGMDIBCDPFJ : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD050", Offset = "0x5EBC450", VA = "0x185EBD050", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public OGMDIBCDPFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class JBBPFBDJFMP : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0270", Offset = "0x5EAF670", VA = "0x185EB0270", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public JBBPFBDJFMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class HBPOFPOHDJD : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x60009BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA99E0", Offset = "0x5EA8DE0", VA = "0x185EA99E0", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public HBPOFPOHDJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class FCAGNAELJBL : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7B20", Offset = "0x5EA6F20", VA = "0x185EA7B20", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public FCAGNAELJBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class CGOIEKBEOOI : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x60009BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6150", Offset = "0x5EA5550", VA = "0x185EA6150", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public CGOIEKBEOOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class IJMHJMAHCNF : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x60009C0")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF320", Offset = "0x5EAE720", VA = "0x185EAF320", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public IJMHJMAHCNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[ExecuteAlways]
public class LOIGKNDBNGH : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	public LOIGKNDBNGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class JHLJHPCHOAC : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0970", Offset = "0x5EAFD70", VA = "0x185EB0970", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public JHLJHPCHOAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
internal class POBJDADJGBO : CFPNJCFEKNO
{
	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public POBJDADJGBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class PBHONECDAJA : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE040", Offset = "0x5EBD440", VA = "0x185EBE040", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public PBHONECDAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
internal class BLLMCPPAIHE : CFPNJCFEKNO
{
	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public BLLMCPPAIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
internal class OCKOFMKHBDH : CFPNJCFEKNO
{
	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public OCKOFMKHBDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public sealed class DFKBAMFNDML : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6FB0", Offset = "0x5EA63B0", VA = "0x185EA6FB0", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public DFKBAMFNDML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
[ExecuteAlways]
public class GCCGGPIGBBG : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009CC")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	public GCCGGPIGBBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public class HANHFDKPCKF : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public HANHFDKPCKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
[MEBHHNIGJKC]
public class GPIDNPNLKPD : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private EJAPLNPOEKH JMLFNACGIOI;

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9970", Offset = "0x5EA8D70", VA = "0x185EA9970", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA99C0", Offset = "0x5EA8DC0", VA = "0x185EA99C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public GPIDNPNLKPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public class NDJKJFLKKMP : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[BurstCompile]
	private struct KNFEBCILDNP : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		[ReadOnly]
		public NativeArray<Entity> JIBDNODJOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<JHKAHHLIAHN> JEEDFBDCNNJ;

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x5EB54A0", Offset = "0x5EB48A0", VA = "0x185EB54A0", Slot = "4")]
		public void Execute(int JPEMHHILGGG, TransformAccess IJKPFNCIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EB56E0", Offset = "0x5EB4AE0", VA = "0x185EB56E0")]
		private bool JLLDANBDEGN(float3 LFEAEFFENHM, float3 HDAGINFADOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x5EB5670", Offset = "0x5EB4A70", VA = "0x185EB5670")]
		private bool JCFEPNDEJDE(quaternion LFEAEFFENHM, quaternion HDAGINFADOG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[BurstCompile]
	private struct DDIGEEAALLH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		[ReadOnly]
		public NativeArray<Entity> JIBDNODJOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<KMCDAKDJLDL> AIHHEGIKHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<PKHNNEBJACH> NGNAOEHJOIP;

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6D50", Offset = "0x5EA6150", VA = "0x185EA6D50", Slot = "4")]
		public void Execute(int JPEMHHILGGG, TransformAccess IJKPFNCIDCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private static readonly FJOGIBEAJHF FFJAFEIFPNH;

	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private static readonly FJOGIBEAJHF PMPNPPONEKB;

	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private static readonly FJOGIBEAJHF GLJNEKBNHGL;

	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private static readonly ProfilerMarker OGIANGBHFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private AJMHHCCGIGG IOINNCNDNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9F20", Offset = "0x5EB9320", VA = "0x185EB9F20", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9F90", Offset = "0x5EB9390", VA = "0x185EB9F90", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9FD0", Offset = "0x5EB93D0", VA = "0x185EB9FD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public NDJKJFLKKMP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001DF")]
	[CompilerGenerated]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	public class RegisterTransforms : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x20001E0")]
		private struct RegisterTransforms_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			public RegisterTransforms __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			[ReadOnly]
			public ComponentTypeHandle<OKFNLLOPCFB> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0x5EBFA20", Offset = "0x5EBEE20", VA = "0x185EBFA20")]
			private void OriginalLambdaBody(Entity entity, [In] OKFNLLOPCFB arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0x5EBF830", Offset = "0x5EBEC30", VA = "0x185EBF830", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private AJMHHCCGIGG embodiedTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private EntityQuery allTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private EntityQuery addNewTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private EntityQuery removeOldTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private EntityQuery clearTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private EntityQuery RegisterTransforms_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private ComponentTypeHandle<OKFNLLOPCFB> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF7E0", Offset = "0x5EBEBE0", VA = "0x185EBF7E0", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x5EBFD30", Offset = "0x5EBF130", VA = "0x185EBFD30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0000", Offset = "0x5EBF400", VA = "0x185EC0000", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF3F0", Offset = "0x5EBE7F0", VA = "0x185EBF3F0")]
		private void AddTransforms(EntityQuery query, NDPAEDKCNFI accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0310", Offset = "0x5EBF710", VA = "0x185EC0310")]
		private void RemoveTransforms(EntityQuery query, NDPAEDKCNFI accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x5EBFF70", Offset = "0x5EBF370", VA = "0x185EBFF70", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF290", Offset = "0x5EBE690", VA = "0x185EBF290")]
		private void AddNewTransforms(NativeArray<Entity> entities, NDPAEDKCNFI accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC00F0", Offset = "0x5EBF4F0", VA = "0x185EC00F0")]
		internal static void RemoveOldTransforms(NativeArray<OKFNLLOPCFB> arrayIndices, ComponentDataFromEntity<OKFNLLOPCFB> transformAccess, NDPAEDKCNFI accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
		private static void DebugLogRemove(int index, NDPAEDKCNFI accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF690", Offset = "0x5EBEA90", VA = "0x185EBF690")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF690", Offset = "0x5EBEA90", VA = "0x185EBF690")]
		private void RegisterTransforms_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x5EBFB30", Offset = "0x5EBEF30", VA = "0x185EBFB30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public RegisterTransforms()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public class FHKAFJACNFL : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x20001E3")]
	[BurstCompile]
	private struct IMLPOENFFDE : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		[ReadOnly]
		public ComponentDataFromEntity<JHKAHHLIAHN> JEEDFBDCNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		[ReadOnly]
		public NativeArray<Entity> JIBDNODJOAB;

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFB20", Offset = "0x5EAEF20", VA = "0x185EAFB20", Slot = "4")]
		public void Execute(int JPEMHHILGGG, TransformAccess IJKPFNCIDCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001E4")]
	[BurstCompile]
	private struct IDJBKMJPNIN : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		[ReadOnly]
		public ComponentDataFromEntity<KMCDAKDJLDL> AIHHEGIKHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		[ReadOnly]
		public NativeArray<Entity> JIBDNODJOAB;

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x5EAEB90", Offset = "0x5EADF90", VA = "0x185EAEB90", Slot = "4")]
		public void Execute(int JPEMHHILGGG, TransformAccess IJKPFNCIDCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001E5")]
	[BurstCompile]
	private struct MPIBKGPONAJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		[ReadOnly]
		public ComponentDataFromEntity<KMCDAKDJLDL> AIHHEGIKHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		[ReadOnly]
		public ComponentDataFromEntity<PKHNNEBJACH> NGNAOEHJOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		[ReadOnly]
		public NativeArray<Entity> JIBDNODJOAB;

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9E20", Offset = "0x5EB9220", VA = "0x185EB9E20", Slot = "4")]
		public void Execute(int JPEMHHILGGG, TransformAccess IJKPFNCIDCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private static readonly FJOGIBEAJHF FFJAFEIFPNH;

	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private static readonly FJOGIBEAJHF PMPNPPONEKB;

	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private static readonly FJOGIBEAJHF GLJNEKBNHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private AJMHHCCGIGG IOINNCNDNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private EntityQuery BJBFNEBLPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private EntityQuery JFGHHHINEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private EntityQuery CCGBKKFIIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private TransformAccessArray OCJKJHOIFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private TransformAccessArray AJNIHCLCCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private TransformAccessArray IPHJMBIOHIG;

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8310", Offset = "0x5EA7710", VA = "0x185EA8310", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8360", Offset = "0x5EA7760", VA = "0x185EA8360", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8570", Offset = "0x5EA7970", VA = "0x185EA8570", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8600", Offset = "0x5EA7A00", VA = "0x185EA8600", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8630", Offset = "0x5EA7A30", VA = "0x185EA8630", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8190", Offset = "0x5EA7590", VA = "0x185EA8190")]
	private NativeArray<Entity> FCEOCBHGOCK(NativeArray<OKFNLLOPCFB> FDAPJIJNFKC, NativeList<Entity> BNEGPODEIJO, TransformAccessArray POHPLONCJDN, TransformAccessArray OILDDKLEMFG)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public FHKAFJACNFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public class JINHMEBHAOE : FILNMLJOIDH, ICKLGHMJPBB
{
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private DCFMFEJHJBD FKDFFFLBOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private AEPEJGKFDPK IBCFCPNGPOO;

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E80EF0", Offset = "0x5E802F0", VA = "0x185E80EF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x5EB14B0", Offset = "0x5EB08B0", VA = "0x185EB14B0", Slot = "14")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB17C0", Offset = "0x5EB0BC0", VA = "0x185EB17C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x5EB15B0", Offset = "0x5EB09B0", VA = "0x185EB15B0")]
	private static void HGELLMIPIBN(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, Entity DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1720", Offset = "0x5EB0B20", VA = "0x185EB1720")]
	private static bool NHKFAJGADBA(EntityManager OKNGAOGEIDO, Entity AHNNJNFIHFM, [Out] Transform IJKPFNCIDCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public JINHMEBHAOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
public class CEOBJKBGIHI : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x20001E8")]
	[BurstCompile]
	private struct IFFAEMDNJAO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		[ReadOnly]
		public ComponentTypeHandle<NFEPIODLPJH> MEMELDDEHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		[ReadOnly]
		public BufferTypeHandle<ChildrenData> KDGLBPOIBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> IFDLMAMOIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		[ReadOnly]
		public ComponentDataFromEntity<NFEPIODLPJH> CJELLDCLNAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public ComponentTypeHandle<JEMPGDCEMGA> BGPBINPECML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<JEMPGDCEMGA> CIPADDOLGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public uint KBMPIFGKEAK;

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x5EAEC40", Offset = "0x5EAE040", VA = "0x185EAEC40", Slot = "4")]
		public void Execute(ArchetypeChunk LPPKICFIEJM, int JPEMHHILGGG, int FIMJFALMBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x5EAEF40", Offset = "0x5EAE340", VA = "0x185EAEF40")]
		private void IDGNDMCKIHI(float4x4 EGIAJIPCHJN, Entity AHNNJNFIHFM, bool NOPLJBNHJCM, int LPDDNEHFNHJ = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private EntityQuery PPNIFGLGIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private EntityQuery HFEONHBAMBF;

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5450", Offset = "0x5EA4850", VA = "0x185EA5450", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5580", Offset = "0x5EA4980", VA = "0x185EA5580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CEOBJKBGIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
public class AKPEOEDEAKJ : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[BurstCompile]
	private struct ANCEIAFDFEJ : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		[ReadOnly]
		public ComponentTypeHandle<NFEPIODLPJH> MEMELDDEHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public ComponentTypeHandle<JEMPGDCEMGA> BGPBINPECML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public uint KBMPIFGKEAK;

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x5EA25D0", Offset = "0x5EA19D0", VA = "0x185EA25D0", Slot = "4")]
		public void Execute(ArchetypeChunk LPPKICFIEJM, int JPEMHHILGGG, int FIMJFALMBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x5EA26E0", Offset = "0x5EA1AE0", VA = "0x185EA26E0")]
		public bool NJGKIPDANBB(ArchetypeChunk LPPKICFIEJM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private EntityQuery PPNIFGLGIFP;

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2360", Offset = "0x5EA1760", VA = "0x185EA2360", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2490", Offset = "0x5EA1890", VA = "0x185EA2490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public AKPEOEDEAKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class CGDGMAJDOJH : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	[BurstCompile]
	private struct FFFIFCFOEFA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		[ReadOnly]
		public ComponentTypeHandle<JEMPGDCEMGA> HKIIOLLMKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public ComponentTypeHandle<NJLFDIIMCKB> BBOAAJLMOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public ComponentTypeHandle<NDPCMDFICAO> HOHAEDNLMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public ComponentTypeHandle<BFFJMHOAOGI> GKFICEJNOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public uint KBMPIFGKEAK;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7B70", Offset = "0x5EA6F70", VA = "0x185EA7B70", Slot = "4")]
		public void Execute(ArchetypeChunk LPPKICFIEJM, int JPEMHHILGGG, int FIMJFALMBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7F60", Offset = "0x5EA7360", VA = "0x185EA7F60")]
		public bool NJGKIPDANBB(ArchetypeChunk LPPKICFIEJM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005FC")]
	private EntityQuery EHJFODOFCKF;

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA58B0", Offset = "0x5EA4CB0", VA = "0x185EA58B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA59C0", Offset = "0x5EA4DC0", VA = "0x185EA59C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CGDGMAJDOJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001ED")]
public class HJCDPLCEEKC : FILNMLJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x20001EE")]
	[BurstCompile]
	private struct IBHOGJJHKLN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		[ReadOnly]
		public ComponentTypeHandle<JHKAHHLIAHN> ANCHDJPHBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		[ReadOnly]
		public ComponentTypeHandle<PKHNNEBJACH> LMKHNHADDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		[ReadOnly]
		public ComponentTypeHandle<KMCDAKDJLDL> FDBMMOAOEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public ComponentTypeHandle<NFEPIODLPJH> IDOOAJJJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public uint KBMPIFGKEAK;

		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE320", Offset = "0x5EAD720", VA = "0x185EAE320", Slot = "4")]
		public void Execute(ArchetypeChunk LPPKICFIEJM, int JPEMHHILGGG, int FIMJFALMBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x5EAEA90", Offset = "0x5EADE90", VA = "0x185EAEA90")]
		public bool NJGKIPDANBB(ArchetypeChunk LPPKICFIEJM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private EntityQuery EHJFODOFCKF;

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE030", Offset = "0x5EAD430", VA = "0x185EAE030", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE160", Offset = "0x5EAD560", VA = "0x185EAE160", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public HJCDPLCEEKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EF")]
public class CGLJPECFJBC : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	[DMNKPOGEHOO]
	private KEMPNLKAPFH OEPHCJKDDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	[DMNKPOGEHOO]
	private GICCNDIODFI BGMBELGJBAH;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5F30", Offset = "0x5EA5330", VA = "0x185EA5F30", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5FA0", Offset = "0x5EA53A0", VA = "0x185EA5FA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5B80", Offset = "0x5EA4F80", VA = "0x185EA5B80")]
	private void EAINNKIDKAM(NativeArray<IKAJAHLJFMC> JPILEBIECMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CGLJPECFJBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F0")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class CKLANIILCBO : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private KEMPNLKAPFH IPFKJDGMBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private OELIJJIDAJD FBGBGEJBECH;

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x5EA63A0", Offset = "0x5EA57A0", VA = "0x185EA63A0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6430", Offset = "0x5EA5830", VA = "0x185EA6430", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public CKLANIILCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F1")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public sealed class FGLPICMAAKL : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private MJHGFDFFPLH CCJFCCENPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private KEMPNLKAPFH EHIPJPLBPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private AOGMODGMOLB KBOPLLOOOBM;

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7FF0", Offset = "0x5EA73F0", VA = "0x185EA7FF0", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8080", Offset = "0x5EA7480", VA = "0x185EA8080", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public FGLPICMAAKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F2")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class LLCAGCPHBFD : FILNMLJOIDH, ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private static readonly FJOGIBEAJHF AFLBEGFFPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	[DMNKPOGEHOO]
	private KNKIEHNOADO JKFKBDCHGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	[DMNKPOGEHOO]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	[DMNKPOGEHOO]
	private LIKHNKHJBKG NONGOADOCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	[DMNKPOGEHOO]
	private HNKKIALLFBA HENPJKGACEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	[DMNKPOGEHOO]
	private BGJJBIGDGID HIPJHPNLHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	[DMNKPOGEHOO]
	private IENHIAPIEPB KGLLDELCPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private CDFGCLFEHED.LNNLMGIDAPF LLFNFEEFDJP;

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6C60", Offset = "0x5EB6060", VA = "0x185EB6C60", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6480", Offset = "0x5EB5880", VA = "0x185EB6480", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x5EB79A0", Offset = "0x5EB6DA0", VA = "0x185EB79A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6600", Offset = "0x5EB5A00", VA = "0x185EB6600")]
	private void HNJCMLMLLIC(KFHEKKOEHDF IHHOPACLNAK, NativeArray<byte> GIDDIHFAJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6420", Offset = "0x5EB5820", VA = "0x185EB6420")]
	private bool DJAACDOOFGL(KFHEKKOEHDF IHHOPACLNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7850", Offset = "0x5EB6C50", VA = "0x185EB7850")]
	private CDFGCLFEHED.KIDHPGMICDH ONMJEBKLCPJ(NativeArray<byte> GIDDIHFAJPP, Allocator JIIMEDFKEME)
	{
		return default(CDFGCLFEHED.KIDHPGMICDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6520", Offset = "0x5EB5920", VA = "0x185EB6520")]
	private void GFMKBBPNBAE(CDFGCLFEHED.KIDHPGMICDH BJAKFNBOKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A27")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6A60", Offset = "0x5EB5E60", VA = "0x185EB6A60")]
	private void IGIMPHPBHCF(NativeList<IKAJAHLJFMC> HOKMMKNDGPI, NativeList<CHCOMAAHOED> CPBGBMAIAGD, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A28")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7090", Offset = "0x5EB6490", VA = "0x185EB7090")]
	private void LMGACHBCIDM(NativeParallelMultiHashMap<IKAJAHLJFMC, OJMPJJENPNO> AJLIOGCGLNN, NativeList<byte> HKNFEMOKNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6E00", Offset = "0x5EB6200", VA = "0x185EB6E00")]
	private void KKLPDGMILAP(NativeList<IKAJAHLJFMC> MHGMJCFOGOB, Allocator JIIMEDFKEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7580", Offset = "0x5EB6980", VA = "0x185EB7580")]
	private void NICPFIOFPEH(CDFGCLFEHED.KIDHPGMICDH OOIBMCBCEPD, bool GDIBAPNNPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0x5EB62B0", Offset = "0x5EB56B0", VA = "0x185EB62B0")]
	private void BGMBDJIKKOA(NativeList<IKAJAHLJFMC> HOKMMKNDGPI, NativeList<CHCOMAAHOED> CPBGBMAIAGD, bool GDIBAPNNPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5C80", Offset = "0x5EB5080", VA = "0x185EB5C80")]
	private void AMDNDBJCLEB(NativeParallelMultiHashMap<IKAJAHLJFMC, OJMPJJENPNO> AJLIOGCGLNN, NativeList<byte> HKNFEMOKNML, bool GDIBAPNNPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB79C0", Offset = "0x5EB6DC0", VA = "0x185EB79C0")]
	private void PAJFCAJKFAM(NativeList<IKAJAHLJFMC> MHGMJCFOGOB, bool GDIBAPNNPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void HMIHMIBEDAA(KFHEKKOEHDF IHHOPACLNAK, bool GDIBAPNNPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public LLCAGCPHBFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F3")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class LHKMECCALEA : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private HFHCOKNIOMB GIKKACIEGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private KEMPNLKAPFH IPFKJDGMBFP;

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5710", Offset = "0x5EB4B10", VA = "0x185EB5710", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5780", Offset = "0x5EB4B80", VA = "0x185EB5780", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public LHKMECCALEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F4")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal class MKGNCOGILHC : FILNMLJOIDH, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private DJOMFACBNME IEDKLDPPILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	private KEMPNLKAPFH IPFKJDGMBFP;

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9B60", Offset = "0x5EB8F60", VA = "0x185EB9B60", Slot = "14")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9BD0", Offset = "0x5EB8FD0", VA = "0x185EB9BD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public MKGNCOGILHC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001F5")]
	[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	internal sealed class WriteDiffChangePacketToNetworkSystem : FILNMLJOIDH, ENDDIKHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x20001F6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct WriteDiffChangePacketToNetworkSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20001F7")]
			public delegate void RunWithoutJobSystem_00000BEC$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001F8")]
			internal static class RunWithoutJobSystem_00000BEC$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000636")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000637")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000A52")]
				[Cpp2IlInjected.Address(RVA = "0x5EC07F0", Offset = "0x5EBFBF0", VA = "0x185EC07F0")]
				[BurstDiscard]
				private static void JMEDLGAJLPK(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A53")]
				[Cpp2IlInjected.Address(RVA = "0x5EC0920", Offset = "0x5EBFD20", VA = "0x185EC0920")]
				private static IntPtr JNIJBLGCHBM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A54")]
				[Cpp2IlInjected.Address(RVA = "0x5EC0A80", Offset = "0x5EBFE80", VA = "0x185EC0A80")]
				public static void NAAFEMAKKBL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A55")]
				[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
				public static void OMELHDOHHCI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A57")]
				[Cpp2IlInjected.Address(RVA = "0x5EC0620", Offset = "0x5EBFA20", VA = "0x185EC0620")]
				public static void DFPIJIPLDKJ(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000628")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000629")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			public FLHKGHBAAMG replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			[ReadOnly]
			public NativeArray<IKAJAHLJFMC> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			[ReadOnly]
			public NativeArray<CHCOMAAHOED> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400062E")]
			[ReadOnly]
			public NativeArray<IKAJAHLJFMC> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, AMHMPNCOKND> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000630")]
			public NativeList<IKAJAHLJFMC> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000631")]
			public NativeList<CHCOMAAHOED> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000632")]
			public NativeList<IKAJAHLJFMC> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000633")]
			public NativeParallelMultiHashMap<IKAJAHLJFMC, OJMPJJENPNO> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000634")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000635")]
			public ComponentDataFromEntity<ACNBNJEPOMH> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3790", Offset = "0x5EC2B90", VA = "0x185EC3790")]
			private void DGGBDJJHEJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3BF0", Offset = "0x5EC2FF0", VA = "0x185EC3BF0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3C00", Offset = "0x5EC3000", VA = "0x185EC3C00")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void GBPHJAFBJCI(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3E10", Offset = "0x5EC3210", VA = "0x185EC3E10")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void KOKNNIPBNLL(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private static readonly FJOGIBEAJHF log;

		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private static readonly FJOGIBEAJHF logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		[DMNKPOGEHOO]
		private JCFKEMAHKEJ packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		[DMNKPOGEHOO]
		private KEMPNLKAPFH diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		[DMNKPOGEHOO]
		private KFIGKCHPCDA editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		[DMNKPOGEHOO]
		private DGCKHDEMBFP transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private CDFGCLFEHED.LNNLMGIDAPF utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3A")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		private JBBOGPBFINA EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3E60", Offset = "0x5EC3260", VA = "0x185EC3E60")]
			get
			{
				return default(JBBOGPBFINA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2B50", Offset = "0x5EC1F50", VA = "0x185EC2B50", Slot = "14")]
		public void InitReferences(FIMDMOFKGJF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4940", Offset = "0x5EC3D40", VA = "0x185EC4940", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2A80", Offset = "0x5EC1E80", VA = "0x185EC2A80")]
		private bool GOFDDDFDAFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3F00", Offset = "0x5EC3300", VA = "0x185EC3F00")]
		private bool MKFFCGCKMDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC51B0", Offset = "0x5EC45B0", VA = "0x185EC51B0")]
		private bool PPOHNLHJNFA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2C10", Offset = "0x5EC2010", VA = "0x185EC2C10")]
		private CDFGCLFEHED.KIDHPGMICDH JDIOGMFGNDF(DKHCPOOKLEC state)
		{
			return default(CDFGCLFEHED.KIDHPGMICDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4020", Offset = "0x5EC3420", VA = "0x185EC4020")]
		private NativeKeyValueArrays<Entity, AMHMPNCOKND> MLOOJPFPFFC(DKHCPOOKLEC state, [Out] int capacity)
		{
			return default(NativeKeyValueArrays<Entity, AMHMPNCOKND>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4E80", Offset = "0x5EC4280", VA = "0x185EC4E80")]
		private void PNCIJENJFFG(CDFGCLFEHED.KIDHPGMICDH data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x5EC29A0", Offset = "0x5EC1DA0", VA = "0x185EC29A0")]
		private void BIDOBNAKMAB(CDFGCLFEHED.KIDHPGMICDH data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4320", Offset = "0x5EC3720", VA = "0x185EC4320")]
		private void NICPFIOFPEH(CDFGCLFEHED.KIDHPGMICDH data, DKHCPOOKLEC state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x5EC28B0", Offset = "0x5EC1CB0", VA = "0x185EC28B0")]
		private void BGMBDJIKKOA(NativeArray<IKAJAHLJFMC> createdIds, NativeArray<CHCOMAAHOED> creationData, JBBOGPBFINA flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2110", Offset = "0x5EC1510", VA = "0x185EC2110")]
		private void AMDNDBJCLEB(NativeMultiHashMapAsync<Entity, AMHMPNCOKND> differences, JBBOGPBFINA flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4DE0", Offset = "0x5EC41E0", VA = "0x185EC4DE0")]
		private void PAJFCAJKFAM(NativeArray<IKAJAHLJFMC> destroyedIds, JBBOGPBFINA flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x5EC34C0", Offset = "0x5EC28C0", VA = "0x185EC34C0")]
		private void LABLMMLHIJC(FLHKGHBAAMG replication, NativeBitArray entityByProperty, NativeArray<IKAJAHLJFMC> srcCreatedIds, NativeArray<CHCOMAAHOED> srcCreationData, NativeArray<IKAJAHLJFMC> srcDestroyedIds, NativeKeyValueArrays<Entity, AMHMPNCOKND> srcPropertyKeyValues, NativeList<IKAJAHLJFMC> dstCreatedIds, NativeList<CHCOMAAHOED> dstCreationData, NativeList<IKAJAHLJFMC> dstDestroyedIds, NativeParallelMultiHashMap<IKAJAHLJFMC, OJMPJJENPNO> dstProperties, NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x5EC46D0", Offset = "0x5EC3AD0", VA = "0x185EC46D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4690", Offset = "0x5EC3A90", VA = "0x185EC4690")]
		public static void OPILEMBPKAP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F9")]
internal class AFJHKACFLOB : GEPDBFLIOMG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001FA")]
	public struct HMKNMIFCPDG : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000638")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	protected override ComponentType GAIOJIAHKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1D20", Offset = "0x5EA1120", VA = "0x185EA1D20", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	protected override ComponentType AJJGODJIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1D50", Offset = "0x5EA1150", VA = "0x185EA1D50", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	protected override ComponentType NIEIPOPLNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1CF0", Offset = "0x5EA10F0", VA = "0x185EA1CF0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1E10", Offset = "0x5EA1210", VA = "0x185EA1E10")]
	public AFJHKACFLOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FB")]
public sealed class CCNDDIDDKDF : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4C00", Offset = "0x5EA4000", VA = "0x185EA4C00", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public CCNDDIDDKDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FC")]
[ExecuteAlways]
public class GJKOPDNAOLM : MEMILACELCP
{
	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public GJKOPDNAOLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FD")]
public sealed class KCNDJNJHMMA : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2010", Offset = "0x5EB1410", VA = "0x185EB2010", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public KCNDJNJHMMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FE")]
public sealed class INAAJNDJLAA : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFC00", Offset = "0x5EAF000", VA = "0x185EAFC00", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public INAAJNDJLAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FF")]
[ExecuteAlways]
public class ELDINMCMFCB : MEMILACELCP
{
	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FDA0", Offset = "0x3E4F1A0", VA = "0x183E4FDA0")]
	public ELDINMCMFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000200")]
public sealed class DPKLCGBEBAM : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7900", Offset = "0x5EA6D00", VA = "0x185EA7900", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public DPKLCGBEBAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000201")]
[FHOIBFDAOOA(typeof(EKBKOBJCEAO), new string[] { })]
[EAMFOLJMGFH(typeof(ILMDBJJKHAL))]
public class ILOMBOCGGIH : EKBKOBJCEAO, IFKHMGNDLHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	private readonly Dictionary<int, BPMBFEJHHKF> CMOOMHLJJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	private readonly Dictionary<Type, BPMBFEJHHKF> MECJBJNHFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private readonly Dictionary<Type, BPMBFEJHHKF> GBJJBPEMDNC;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public IReadOnlyCollection<BPMBFEJHHKF> GLIHDJHBKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF600", Offset = "0x5EAEA00", VA = "0x185EAF600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF650", Offset = "0x5EAEA50", VA = "0x185EAF650", Slot = "7")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF990", Offset = "0x5EAED90", VA = "0x185EAF990", Slot = "6")]
	public BPMBFEJHHKF OLHPKJLDOEH(Type DJMKKNDNCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF540", Offset = "0x5EAE940", VA = "0x185EAF540", Slot = "5")]
	public bool CPEBJLMJNCJ(int CEOOILAHGGI, [Out] BPMBFEJHHKF MJHCCCCPHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF5B0", Offset = "0x5EAE9B0", VA = "0x185EAF5B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFA10", Offset = "0x5EAEE10", VA = "0x185EAFA10")]
	public ILOMBOCGGIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000202")]
[EAMFOLJMGFH(typeof(ILMDBJJKHAL))]
[FHOIBFDAOOA(typeof(MIEDEIBEABA), new string[] { })]
public class MBNNAHEGLFD : MIEDEIBEABA, IFKHMGNDLHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private readonly Dictionary<int, GEECJLGCMBE> KBJHCAGMHOI;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public IEnumerable<GEECJLGCMBE> KLOFONBIABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB7B90", Offset = "0x5EB6F90", VA = "0x185EB7B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7CA0", Offset = "0x5EB70A0", VA = "0x185EB7CA0", Slot = "6")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7C30", Offset = "0x5EB7030", VA = "0x185EB7C30", Slot = "5")]
	public bool LKCGCPACHJB(int CEOOILAHGGI, [Out] GEECJLGCMBE EHDKAJFMMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7BE0", Offset = "0x5EB6FE0", VA = "0x185EB7BE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8090", Offset = "0x5EB7490", VA = "0x185EB8090")]
	public MBNNAHEGLFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000203")]
[EAMFOLJMGFH(typeof(ILMDBJJKHAL))]
[FHOIBFDAOOA(typeof(AODHIDPNNDN), new string[] { })]
public class AGIAMFDHIKA : AODHIDPNNDN, IFKHMGNDLHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private static readonly Dictionary<int, int> LLIALAPFHAB;

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1F80", Offset = "0x5EA1380", VA = "0x185EA1F80", Slot = "5")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1EE0", Offset = "0x5EA12E0", VA = "0x185EA1EE0", Slot = "4")]
	public int LNDPEHBIDBK(int CEOOILAHGGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1E70", Offset = "0x5EA1270", VA = "0x185EA1E70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public AGIAMFDHIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000204")]
[FHOIBFDAOOA(typeof(FKJFPLLMKFH), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal class FKJFPLLMKFH : ICKLGHMJPBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	private IAEHJFIPCAC<AuthoredParentData, AuthoredPreviousParentData, HNHJOMCPKFI, AuthoredChildrenData> LADMOPMLCNC;

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8FA0", Offset = "0x5EA83A0", VA = "0x185EA8FA0", Slot = "4")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FKJFPLLMKFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000205")]
[FHOIBFDAOOA(typeof(MDBBBKIBFGG), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal sealed class MDBBBKIBFGG : ENDDIKHKCDF, ICKLGHMJPBB
{
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000640")]
	[DMNKPOGEHOO]
	private EPEIHHNCIHD EHJFODOFCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private MKIKBAICGGB<Entity> OIBKEMMFJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private IAEHJFIPCAC<ParentData, PreviousParentData, HJNKEOEKKOH, ChildrenData> LADMOPMLCNC;

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x5EB82A0", Offset = "0x5EB76A0", VA = "0x185EB82A0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8120", Offset = "0x5EB7520", VA = "0x185EB8120", Slot = "5")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8390", Offset = "0x5EB7790", VA = "0x185EB8390")]
	public Entity NALNAGAMHFP(Entity AHNNJNFIHFM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8240", Offset = "0x5EB7640", VA = "0x185EB8240")]
	public bool GNMLKPBGKPO(Entity AHNNJNFIHFM, Entity KJOCICNOINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB82F0", Offset = "0x5EB76F0", VA = "0x185EB82F0")]
	public bool LEKFLKBIABP(Entity AHNNJNFIHFM, Entity KJOCICNOINI, bool HLAFCEMDKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB83E0", Offset = "0x5EB77E0", VA = "0x185EB83E0")]
	private bool OBJJCMMLEBB(Entity AHNNJNFIHFM, Entity KJOCICNOINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public MDBBBKIBFGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000206")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(DJAIMNHGDHI), new string[] { })]
internal sealed class DJAIMNHGDHI : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private EntityQuery CINFOINBMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7800", Offset = "0x5EA6C00", VA = "0x185EA7800")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x5EA76B0", Offset = "0x5EA6AB0", VA = "0x185EA76B0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7480", Offset = "0x5EA6880", VA = "0x185EA7480", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7850", Offset = "0x5EA6C50", VA = "0x185EA7850")]
	public bool OMHDFCIKAMC(Entity AHNNJNFIHFM, Entity JHJELAILOKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A85")]
	[Cpp2IlInjected.Address(RVA = "0x5EA74A0", Offset = "0x5EA68A0", VA = "0x185EA74A0")]
	public bool GBDKGPAEEJJ(Entity AHNNJNFIHFM, Entity JBFHBGCJGMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7610", Offset = "0x5EA6A10", VA = "0x185EA7610")]
	public Entity IKLADMFFKPA(Entity AHNNJNFIHFM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x5EA77B0", Offset = "0x5EA6BB0", VA = "0x185EA77B0")]
	public NativeArray<Entity> JCEFKGHBPFN()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7550", Offset = "0x5EA6950", VA = "0x185EA7550")]
	public bool HMBKMODMMCG(Entity ADOGMMPMLJB, Entity EOFPNCBMKHP, [Out] Entity AFMEONIJNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public DJAIMNHGDHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000207")]
public static class EALOBFDKIMG
{
	[Cpp2IlInjected.Token(Token = "0x4000646")]
	internal static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x224C7E0", Offset = "0x224BBE0", VA = "0x18224C7E0")]
	public static void EGBIPNOEPPP<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(FIMDMOFKGJF MHCBJGOCOMD, EMNGLKONKEK<Entity> OKJGMJDJMMC, [Out] IAEHJFIPCAC<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> IIPFCEFGFDM) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, KMPHIOOOMFB where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, KMPHIOOOMFB, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7A40", Offset = "0x5EA6E40", VA = "0x185EA7A40")]
	public static bool HMKCFPNKCMH(BAJJJAGOPJE MBDMIIMHHNK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
public class IAEHJFIPCAC<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, KMPHIOOOMFB where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, KMPHIOOOMFB, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x4000647")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000648")]
	private readonly HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	private readonly MKIKBAICGGB<Entity> OIBKEMMFJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private readonly DDPCONHAGKM EDAIENHGCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private readonly DNHFDIEHCPF DCLCDDGJKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private readonly EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private readonly AEPEJGKFDPK IBCFCPNGPOO;

	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x35B1D70", Offset = "0x35B1170", VA = "0x1835B1D70")]
	public IAEHJFIPCAC(FIMDMOFKGJF MHCBJGOCOMD, EMNGLKONKEK<Entity> OKJGMJDJMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x35B0BA0", Offset = "0x35AFFA0", VA = "0x1835B0BA0")]
	private bool MLCJKMBJMGG(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x35B0AA0", Offset = "0x35AFEA0", VA = "0x1835B0AA0")]
	private bool IGCDANBBJGN(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x35B0960", Offset = "0x35AFD60", VA = "0x1835B0960")]
	private bool GJHGKFBHFJL(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x35B09E0", Offset = "0x35AFDE0", VA = "0x1835B09E0")]
	public bool GNMLKPBGKPO(Entity AHNNJNFIHFM, [In] Entity KJOCICNOINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x35B1300", Offset = "0x35B0700", VA = "0x1835B1300")]
	public bool NKNKEOOCLDE(Entity AHNNJNFIHFM, [In] Entity KJOCICNOINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x35B0F90", Offset = "0x35B0390", VA = "0x1835B0F90")]
	private bool NKNKEOOCLDE(Entity AHNNJNFIHFM, [In] Entity KJOCICNOINI, bool GLDCJILHFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void KDANGBFDMLJ(Entity AHNNJNFIHFM, [In] Entity KJOCICNOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void NCPKIOONFEA(Entity AHNNJNFIHFM, [In] Entity KJOCICNOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void MDMLFPJPEDK(Entity AHNNJNFIHFM, [In] Entity KJOCICNOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void NGOPKHDCAFJ(Entity AHNNJNFIHFM, [In] Entity KJOCICNOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void OLHHOPBEOCL(Entity AHNNJNFIHFM, [In] Entity KJOCICNOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x35B1580", Offset = "0x35B0980", VA = "0x1835B1580")]
	private bool OMHDFCIKAMC(Entity AHNNJNFIHFM, Entity JHJELAILOKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x35B1340", Offset = "0x35B0740", VA = "0x1835B1340")]
	private void OJHIJMEPKNL(Entity AHNNJNFIHFM, [In] Entity CLBKMLECIHH, [In] Entity KJOCICNOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(RVA = "0x35B0120", Offset = "0x35AF520", VA = "0x1835B0120")]
	private void DCAGJMPHOCG(Entity AHNNJNFIHFM, [In] Entity CLBKMLECIHH, [In] Entity KJOCICNOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x35B0530", Offset = "0x35AF930", VA = "0x1835B0530")]
	private bool EDNPJLCDJHO(LIKHNKHJBKG NACJMGHLEIJ, [In] IKAJAHLJFMC AOEGFEEAJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x35AFD80", Offset = "0x35AF180", VA = "0x1835AFD80")]
	private void BOJDPHNKIJA(Entity DCLCDDGJKIC, Entity PPNMHLJNNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x35B0720", Offset = "0x35AFB20", VA = "0x1835B0720")]
	private void FFBCIDBKJPK(Entity DCLCDDGJKIC, Entity PPNMHLJNNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private void APGOBAPLGNC(Entity AHNNJNFIHFM, Entity CLBKMLECIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private void ELHPMGOAGBF(Entity AHNNJNFIHFM, Entity KJOCICNOINI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
[FHOIBFDAOOA(typeof(HFHCOKNIOMB), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal sealed class HFHCOKNIOMB : BJJLPKDABKC, IFKHMGNDLHA, ENDDIKHKCDF, ICKLGHMJPBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	[DMNKPOGEHOO]
	private EPEIHHNCIHD EHJFODOFCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	[DMNKPOGEHOO]
	private JPNIIOOOMOP KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	[DMNKPOGEHOO]
	private MAICAFPPDGB BADPICBHGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	[DMNKPOGEHOO]
	private KLNNOPHINFN NKPPLBIKGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	[DMNKPOGEHOO]
	private OACDJAJNOAN FAKFKFACCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	[DMNKPOGEHOO]
	private AOGMODGMOLB KBOPLLOOOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private readonly Dictionary<IKAJAHLJFMC, CGNNELOIABF> AGEJLHDAMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private NJPJOODBIOM EEODHMLMGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD490", Offset = "0x5EAC890", VA = "0x185EAD490")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0xB14FE0", Offset = "0xB143E0", VA = "0x180B14FE0", Slot = "4")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x5EACB90", Offset = "0x5EABF90", VA = "0x185EACB90", Slot = "5")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD320", Offset = "0x5EAC720", VA = "0x185EAD320")]
	public void NHHDNDEOBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB290", Offset = "0x5EAA690", VA = "0x185EAB290", Slot = "6")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB0F0", Offset = "0x5EAA4F0", VA = "0x185EAB0F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD280", Offset = "0x5EAC680", VA = "0x185EAD280")]
	public int MKOLLPMKNFD(SceneTag KJAEFLADAPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA320", Offset = "0x5EA9720", VA = "0x185EAA320")]
	public bool AKOCEDFHGCD(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA5E0", Offset = "0x5EA99E0", VA = "0x185EAA5E0")]
	public bool BDLMEDCBLOE(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD210", Offset = "0x5EAC610", VA = "0x185EAD210")]
	public bool KEDFCEGBEDG(Entity AHNNJNFIHFM, [Out] CGNNELOIABF LKCOHANNNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAC")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD170", Offset = "0x5EAC570", VA = "0x185EAD170")]
	private bool KEDFCEGBEDG(Transform IJKPFNCIDCJ, [Out] CGNNELOIABF LKCOHANNNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAF80", Offset = "0x5EAA380", VA = "0x185EAAF80")]
	private void DCFCICBAKIK(Entity AHNNJNFIHFM, CGNNELOIABF LKCOHANNNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB4C0", Offset = "0x5EAA8C0", VA = "0x185EAB4C0")]
	private bool FDHBMIKOIMN(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC5D0", Offset = "0x5EAB9D0", VA = "0x185EAC5D0")]
	public void GFCMFFOEFBO(IKAJAHLJFMC MIPKLHDFLBO, CGNNELOIABF BIAMFCLNIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9CC0", Offset = "0x5EA90C0", VA = "0x185EA9CC0")]
	public bool AGHMNBIOGGD(CAKFEHOBCAO AJAFIOGCMHP, object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9C50", Offset = "0x5EA9050", VA = "0x185EA9C50")]
	public bool AGHMNBIOGGD(Entity AHNNJNFIHFM, [Optional] object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA2C0", Offset = "0x5EA96C0", VA = "0x185EAA2C0")]
	public bool AGHMNBIOGGD(CGNNELOIABF MBDMIIMHHNK, object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA990", Offset = "0x5EA9D90", VA = "0x185EAA990")]
	public bool DAFHNGHAEML(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA2F0", Offset = "0x5EA96F0", VA = "0x185EAA2F0")]
	public bool AGHMNBIOGGD(CGNNELOIABF LKCOHANNNDC, bool EAJNNLJOPDA, [Optional] object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD660", Offset = "0x5EACA60", VA = "0x185EAD660")]
	private bool PHEEPFHCOCJ(CGNNELOIABF LKCOHANNNDC, object IBLOMPOENGH, bool EAJNNLJOPDA, bool EBOGAFAGNMB, bool LDNACDJOHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA600", Offset = "0x5EA9A00", VA = "0x185EAA600")]
	public Transform BIEJPEGJFPL(Entity AHNNJNFIHFM, [Optional] object IBLOMPOENGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD370", Offset = "0x5EAC770", VA = "0x185EAD370")]
	public bool NHKFAJGADBA(Entity AHNNJNFIHFM, [Out] Transform IJKPFNCIDCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA4F0", Offset = "0x5EA98F0", VA = "0x185EAA4F0")]
	public CGNNELOIABF ALDDGBMMJNL(Entity AHNNJNFIHFM, [Optional] object IBLOMPOENGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC860", Offset = "0x5EABC60", VA = "0x185EAC860")]
	public void IGIAHLHPAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x5EACCC0", Offset = "0x5EAC0C0", VA = "0x185EACCC0")]
	public void JEPEDNEGHNN(SceneTag KJAEFLADAPH, bool EBOGAFAGNMB, NativeParallelHashSet<int> JNBGCOHHPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0x5EABBB0", Offset = "0x5EAAFB0", VA = "0x185EABBB0")]
	private void FLPLJOENHKK(Entity AHNNJNFIHFM, bool EBOGAFAGNMB, bool LDNACDJOHDF, NativeParallelHashSet<int> JNBGCOHHPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD2A0", Offset = "0x5EAC6A0", VA = "0x185EAD2A0")]
	public bool NFIDNGBGDFA(Entity AHNNJNFIHFM, object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB440", Offset = "0x5EAA840", VA = "0x185EAB440")]
	public bool FDDJPIDFEJE(Entity AHNNJNFIHFM, object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD580", Offset = "0x5EAC980", VA = "0x185EAD580")]
	public bool PBGJDEHGLBG(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB1B0", Offset = "0x5EAA5B0", VA = "0x185EAB1B0")]
	private void ECDEGELAGEB(bool FEKKHPGNBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC7A0", Offset = "0x5EABBA0", VA = "0x185EAC7A0")]
	private bool HDLMNOCKGFE(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD440", Offset = "0x5EAC840", VA = "0x185EAD440")]
	public CGNNELOIABF OGFHOMKENKB(Entity AHNNJNFIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD4E0", Offset = "0x5EAC8E0", VA = "0x185EAD4E0")]
	private CGNNELOIABF ONECHFEIDEG(Entity AHNNJNFIHFM, object IBLOMPOENGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB940", Offset = "0x5EAAD40", VA = "0x185EAB940")]
	private CGNNELOIABF FHFMDOOPBNM(Entity AHNNJNFIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA7F0", Offset = "0x5EA9BF0", VA = "0x185EAA7F0")]
	public void COKJMENCOOI(NativeArray<IKAJAHLJFMC> LLBGDKONGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD0A0", Offset = "0x5EAC4A0", VA = "0x185EAD0A0")]
	private void JMCGACOJLIE(CAKFEHOBCAO AJAFIOGCMHP, CGNNELOIABF BIAMFCLNIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB370", Offset = "0x5EAA770", VA = "0x185EAB370")]
	private void EONJCJCOPCP(CGNNELOIABF BIAMFCLNIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x5EADBE0", Offset = "0x5EACFE0", VA = "0x185EADBE0")]
	private void PLDPMMLAEAK(CGNNELOIABF LKCOHANNNDC, Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB4E0", Offset = "0x5EAA8E0", VA = "0x185EAB4E0")]
	private void FGPKJNDHPPN(Entity AHNNJNFIHFM, CGNNELOIABF LKCOHANNNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB010", Offset = "0x5EAA410", VA = "0x185EAB010")]
	private void DCPOKPKIJEB(Entity AHNNJNFIHFM, Transform IJKPFNCIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x5E32390", Offset = "0x5E31790", VA = "0x185E32390")]
	private CAKFEHOBCAO IMEEFMHHMIM(Entity AHNNJNFIHFM)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x5EADFA0", Offset = "0x5EAD3A0", VA = "0x185EADFA0")]
	public HFHCOKNIOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9B80", Offset = "0x5EA8F80", VA = "0x185EA9B80")]
	[CompilerGenerated]
	private void AEDFCGDNIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020A")]
[FHOIBFDAOOA(typeof(OELIJJIDAJD), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal sealed class OELIJJIDAJD : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400065A")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065B")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	private HFHCOKNIOMB LKCOHANNNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private EHDDEACDFDO OFIBBBPPBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x5EBB870", Offset = "0x5EBAC70", VA = "0x185EBB870")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<KLCLLLJMBOO, NativeArray<HNGHCMBBKEB>> ABCOPLNBDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x5EBB930", Offset = "0x5EBAD30", VA = "0x185EBB930")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x5EBB100", Offset = "0x5EBA500", VA = "0x185EBB100")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<KLCLLLJMBOO> CHDCLLPLJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD0")]
		[Cpp2IlInjected.Address(RVA = "0x5EBA930", Offset = "0x5EB9D30", VA = "0x185EBA930")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x5EBB2F0", Offset = "0x5EBA6F0", VA = "0x185EBB2F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB1F0", Offset = "0x5EBA5F0", VA = "0x185EBB1F0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x1212720", Offset = "0x1211B20", VA = "0x181212720", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB7C0", Offset = "0x5EBABC0", VA = "0x185EBB7C0")]
	public bool NDBJGAPFHCF(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBB30", Offset = "0x5EBAF30", VA = "0x185EBBB30")]
	public void PMDLPBBGJKF(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAA40", Offset = "0x5EB9E40", VA = "0x185EBAA40")]
	public void BDLKDNOMLME(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB670", Offset = "0x5EBAA70", VA = "0x185EBB670")]
	private bool MCGKPFALPDK(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB8C0", Offset = "0x5EBACC0", VA = "0x185EBB8C0")]
	public void OMMIKAHKMGL(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAD10", Offset = "0x5EBA110", VA = "0x185EBAD10")]
	private bool GPHPBJAGGJH(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB9E0", Offset = "0x5EBADE0", VA = "0x185EBB9E0")]
	public void PICMAPEPIMK(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA9E0", Offset = "0x5EB9DE0", VA = "0x185EBA9E0")]
	private void BCCHBMDIDLA(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAAE0", Offset = "0x5EB9EE0", VA = "0x185EBAAE0")]
	private void GGMLAJFFMNI(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB290", Offset = "0x5EBA690", VA = "0x185EBB290")]
	private void JPIJGOKFKGF(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB3A0", Offset = "0x5EBA7A0", VA = "0x185EBB3A0")]
	private void LOILJAAPKPI(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAA90", Offset = "0x5EB9E90", VA = "0x185EBAA90")]
	public void FEBNALHDKIA(KLCLLLJMBOO GIIACOBGMNH, NativeArray<HNGHCMBBKEB> HDDEBDIKCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB1B0", Offset = "0x5EBA5B0", VA = "0x185EBB1B0")]
	public void ICMEOKEOIJK(KLCLLLJMBOO GIIACOBGMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private void HOPEEMIFPNK(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAEF0", Offset = "0x5EBA2F0", VA = "0x185EBAEF0")]
	private void HDNJBLAHHFF(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public OELIJJIDAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020B")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(KHHBHMMACPM), new string[] { })]
internal class KHHBHMMACPM : NLFDLEBCDME, ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200020D")]
	[CompilerGenerated]
	private sealed class ONBHLILCDFL : IEnumerable<(JHDIEJNPMMJ, HNGHCMBBKEB)>, IEnumerable, IEnumerator<(JHDIEJNPMMJ, HNGHCMBBKEB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private (JHDIEJNPMMJ primitiveType, HNGHCMBBKEB prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public KHHBHMMACPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		private (JHDIEJNPMMJ, HNGHCMBBKEB) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B03")]
			[Cpp2IlInjected.Address(RVA = "0x30A2300", Offset = "0x30A1700", VA = "0x1830A2300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((JHDIEJNPMMJ, HNGHCMBBKEB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B05")]
			[Cpp2IlInjected.Address(RVA = "0x5EBDF70", Offset = "0x5EBD370", VA = "0x185EBDF70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x32E0260", Offset = "0x32DF660", VA = "0x1832E0260")]
		[DebuggerHidden]
		public ONBHLILCDFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B01")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x5EBDD70", Offset = "0x5EBD170", VA = "0x185EBDD70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x5EBDF20", Offset = "0x5EBD320", VA = "0x185EBDF20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x5EBDE70", Offset = "0x5EBD270", VA = "0x185EBDE70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(JHDIEJNPMMJ, HNGHCMBBKEB)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B07")]
		[Cpp2IlInjected.Address(RVA = "0x5EBDE70", Offset = "0x5EBD270", VA = "0x185EBDE70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private World KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private NativeParallelHashMap<int, Entity> FNIMMOLDOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private NativeParallelHashMap<int, EntityArchetype> EKINKIHNGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private NativeParallelHashMap<int, int> JOFKLMGJNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private HNGHCMBBKEB[] HDDEBDIKCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private readonly Dictionary<JHDIEJNPMMJ, HNGHCMBBKEB> PHNBGNOIAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private readonly Dictionary<PGIPCBAJLMP, HNGHCMBBKEB> OBONOPOMBGA;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3610", Offset = "0x5EB2A10", VA = "0x185EB3610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x7665C0", Offset = "0x7659C0", VA = "0x1807665C0")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x184A710", Offset = "0x1849B10", VA = "0x18184A710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3AD0", Offset = "0x5EB2ED0", VA = "0x185EB3AD0", Slot = "5")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB31D0", Offset = "0x5EB25D0", VA = "0x185EB31D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0xD6E3E0", Offset = "0xD6D7E0", VA = "0x180D6E3E0")]
	internal NativeParallelHashMap<int, Entity> ABPALFLLAFC()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0xD230A0", Offset = "0xD224A0", VA = "0x180D230A0")]
	internal NativeParallelHashMap<int, EntityArchetype> AIJHFOLLJCE()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x88A1D0", Offset = "0x8895D0", VA = "0x18088A1D0")]
	internal NativeParallelHashMap<int, int> ODIAIPFJJJO()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3170", Offset = "0x5EB2570", VA = "0x185EB3170")]
	internal IEnumerable<Type> ANEEBEOCOOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4AD0", Offset = "0x5EB3ED0", VA = "0x185EB4AD0")]
	internal BLJHFCKHOAL OEBIAMOGJHL(Type DJMKKNDNCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4B40", Offset = "0x5EB3F40", VA = "0x185EB4B40")]
	public EntityArchetype OGKLJBOGNGD(HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4970", Offset = "0x5EB3D70", VA = "0x185EB4970", Slot = "4")]
	[IteratorStateMachine(typeof(ONBHLILCDFL))]
	public IEnumerable<(JHDIEJNPMMJ, HNGHCMBBKEB)> MADBHAKNFNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3650", Offset = "0x5EB2A50", VA = "0x185EB3650")]
	public Entity GPLBOIIHMOK(HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4D40", Offset = "0x5EB4140", VA = "0x185EB4D40")]
	public void PFLKFOKABPO(NativeArray<HNGHCMBBKEB> HDDEBDIKCHN, NativeArray<Entity> AEPCAGKMEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3580", Offset = "0x5EB2980", VA = "0x185EB3580")]
	public void FBPDBHJKPIE(HNGHCMBBKEB HOAIKLJFCGK, NativeArray<Entity> JIBDNODJOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3770", Offset = "0x5EB2B70", VA = "0x185EB3770")]
	public HNGHCMBBKEB HHHMIGOGAJK(JHDIEJNPMMJ DJMKKNDNCBM)
	{
		return default(HNGHCMBBKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x5EB49F0", Offset = "0x5EB3DF0", VA = "0x185EB49F0")]
	public Entity NMBACABEJHK(HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x5EB37D0", Offset = "0x5EB2BD0", VA = "0x185EB37D0")]
	private void HKNNNBMMKPM(BLJHFCKHOAL MMNIOGOHLMO, NativeList<int> HDDEBDIKCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4660", Offset = "0x5EB3A60", VA = "0x185EB4660")]
	internal void LOOHJIBIIJB(HNGHCMBBKEB HOAIKLJFCGK, ComponentTypeList GABAJGJIIBJ, JJHJAIMLOHJ AOMGJGDNNKD, BLJHFCKHOAL MMNIOGOHLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4BB0", Offset = "0x5EB3FB0", VA = "0x185EB4BB0")]
	private EntityArchetype PFIOCONACAK(HNGHCMBBKEB HOAIKLJFCGK, ComponentTypeList DJKCBPMDJBO)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4F80", Offset = "0x5EB4380", VA = "0x185EB4F80")]
	public KHHBHMMACPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020E")]
public enum JDIKJEAMOOG
{
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200020F")]
internal interface PJNBGGDPLML
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	World KMONKLDHPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	World CACIINNIHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	DCPAGDAEDDN IEOCOMGOKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	uint KBMPIFGKEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000210")]
internal class MHAPNMCOHHL : PFGIGJNFFGK, DKHCPOOKLEC
{
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private readonly PJNBGGDPLML DAAGIBDGGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly JDIKJEAMOOG KBOPLLOOOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private readonly World GFDIPPMMOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400067C")]
	private readonly List<JKKLCJEMGPF> AMFOGDMKAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	private NativeParallelMultiHashMap<Entity, AMHMPNCOKND> LIBGCMJBPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private NativeParallelHashMap<int, int> IDEKJKEJCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private NativeArray<IKAJAHLJFMC> HOKMMKNDGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private NativeArray<CHCOMAAHOED> CPBGBMAIAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private NativeArray<IKAJAHLJFMC> MHGMJCFOGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private JobHandle CHAACDJFNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private JobHandle BLJJLBJOIHB;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private NativeParallelMultiHashMap<Entity, AMHMPNCOKND> IDBLPGBKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0xD230A0", Offset = "0xD224A0", VA = "0x180D230A0", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, AMHMPNCOKND>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private uint NMKOHOMNHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9430", Offset = "0x5EB8830", VA = "0x185EB9430", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool IIAIJPNAMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x5EB8730", Offset = "0x5EB7B30", VA = "0x185EB8730", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private NativeArray<IKAJAHLJFMC> CLKPDKLIFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x19D8220", Offset = "0x19D7620", VA = "0x1819D8220", Slot = "10")]
		get
		{
			return default(NativeArray<IKAJAHLJFMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private NativeArray<CHCOMAAHOED> BCENNPKLGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0xED32B0", Offset = "0xED26B0", VA = "0x180ED32B0", Slot = "11")]
		get
		{
			return default(NativeArray<CHCOMAAHOED>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private NativeArray<IKAJAHLJFMC> BFELBOMIDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3520", Offset = "0x3CF2920", VA = "0x183CF3520", Slot = "12")]
		get
		{
			return default(NativeArray<IKAJAHLJFMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9510", Offset = "0x5EB8910", VA = "0x185EB9510")]
	public MHAPNMCOHHL(PJNBGGDPLML DAAGIBDGGJE, JDIKJEAMOOG KBOPLLOOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8CC0", Offset = "0x5EB80C0", VA = "0x185EB8CC0", Slot = "6")]
	private bool MLAIKPFGACM(NativeArray<IKAJAHLJFMC> HOKMMKNDGPI, NativeArray<CHCOMAAHOED> CPBGBMAIAGD, NativeArray<IKAJAHLJFMC> MHGMJCFOGOB, int IOHFNPPOHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8B50", Offset = "0x5EB7F50", VA = "0x185EB8B50", Slot = "7")]
	private void LPNPPLBENHK([In] JKKLCJEMGPF GNOADEOLHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8740", Offset = "0x5EB7B40", VA = "0x185EB8740", Slot = "8")]
	private void EJINIIAOEIM(JobHandle EKHBDCNGFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B18")]
	[Cpp2IlInjected.Address(RVA = "0x5EB88C0", Offset = "0x5EB7CC0", VA = "0x185EB88C0", Slot = "13")]
	private bool GCPACLJOLEF([Out] NativeArray<int> HLJHPEOJMMK, Allocator JIIMEDFKEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B19")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8970", Offset = "0x5EB7D70", VA = "0x185EB8970", Slot = "14")]
	private bool ILELBEFKBAA(ComponentType BCNHGHNJOMA, [Out] JKKLCJEMGPF IOCCJJABDLM, [Out] NHKJBDIFHCN JLHKFPKCNHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB86B0", Offset = "0x5EB7AB0", VA = "0x185EB86B0", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, AMHMPNCOKND> ALEJACGJNFF()
	{
		return default(NativeMultiHashMapAsync<Entity, AMHMPNCOKND>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1B")]
	[Cpp2IlInjected.Address(RVA = "0x5EB90E0", Offset = "0x5EB84E0", VA = "0x185EB90E0")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8EB0", Offset = "0x5EB82B0", VA = "0x185EB8EB0")]
	private bool OEKPLJODNME()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000211")]
[FHOIBFDAOOA(typeof(KEMPNLKAPFH), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal class KEMPNLKAPFH : ENDDIKHKCDF, ICKLGHMJPBB, PJNBGGDPLML, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000212")]
	internal readonly struct EAINOGAEJHK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private readonly JDIKJEAMOOG IIOANPCINPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private readonly KEMPNLKAPFH CDNLGICPHJL;

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x5EA79F0", Offset = "0x5EA6DF0", VA = "0x185EA79F0")]
		public EAINOGAEJHK(KEMPNLKAPFH CDNLGICPHJL, JDIKJEAMOOG BJEJOLIPJHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x5EA79D0", Offset = "0x5EA6DD0", VA = "0x185EA79D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private static readonly FJOGIBEAJHF NLFKNOAAIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	[DMNKPOGEHOO]
	private EKBKOBJCEAO DIHODDBACDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	[DMNKPOGEHOO]
	private KHHBHMMACPM FNIMMOLDOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private readonly MHAPNMCOHHL[] FLFKNNALHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private DCPAGDAEDDN LNOECNPDHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private NativeParallelHashMap<int, Entity> PMHCKMDJPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	private JDIKJEAMOOG IKMJOEDCMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public World KMONKLDHPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2770", Offset = "0x5EB1B70", VA = "0x185EB2770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public World CACIINNIHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x765410", Offset = "0x764810", VA = "0x180765410", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x7653D0", Offset = "0x7647D0", VA = "0x1807653D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public DCPAGDAEDDN IEOCOMGOKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x1FBFD30", Offset = "0x1FBF130", VA = "0x181FBFD30", Slot = "8")]
		get
		{
			return default(DCPAGDAEDDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public uint KBMPIFGKEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0xCC7890", Offset = "0xCC6C90", VA = "0x180CC7890", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0xCC7D70", Offset = "0xCC7170", VA = "0x180CC7D70", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private bool LJNDNFAALHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x992140", Offset = "0x991540", VA = "0x180992140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0xCB0010", Offset = "0xCAF410", VA = "0x180CB0010", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public NativeParallelHashMap<int, Entity> ODDNKAELNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x34CE5D0", Offset = "0x34CD9D0", VA = "0x1834CE5D0")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public DKHCPOOKLEC BEPOHKBAEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x5EB27C0", Offset = "0x5EB1BC0", VA = "0x185EB27C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public PFGIGJNFFGK LMDBNOMGJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x5EB27C0", Offset = "0x5EB1BC0", VA = "0x185EB27C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public JDIKJEAMOOG BECHHFIHLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x93E0F0", Offset = "0x93D4F0", VA = "0x18093E0F0")]
		get
		{
			return default(JDIKJEAMOOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B27")]
	[Cpp2IlInjected.Address(RVA = "0x1B54E00", Offset = "0x1B54200", VA = "0x181B54E00")]
	public DKHCPOOKLEC FPHJGLPNJPG(JDIKJEAMOOG KBOPLLOOOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B28")]
	[Cpp2IlInjected.Address(RVA = "0x1B54E00", Offset = "0x1B54200", VA = "0x181B54E00")]
	public PFGIGJNFFGK LIOODDMBAJI(JDIKJEAMOOG KBOPLLOOOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2E30", Offset = "0x5EB2230", VA = "0x185EB2E30", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2900", Offset = "0x5EB1D00", VA = "0x185EB2900", Slot = "5")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2BB0", Offset = "0x5EB1FB0", VA = "0x185EB2BB0")]
	private NativeParallelHashMap<int, Entity> GIBEBPJIDDP()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2F00", Offset = "0x5EB2300", VA = "0x185EB2F00")]
	public void LFNKIAJKDMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B30")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3010", Offset = "0x5EB2410", VA = "0x185EB3010")]
	public void OOAOJFKKMLN(JDIKJEAMOOG KBOPLLOOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B31")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2F50", Offset = "0x5EB2350", VA = "0x185EB2F50")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B32")]
	[Cpp2IlInjected.Address(RVA = "0x5EB27F0", Offset = "0x5EB1BF0", VA = "0x185EB27F0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B33")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2B50", Offset = "0x5EB1F50", VA = "0x185EB2B50")]
	public EAINOGAEJHK FKHLBCBBCBB(JDIKJEAMOOG KBOPLLOOOBM)
	{
		return default(EAINOGAEJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B34")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3110", Offset = "0x5EB2510", VA = "0x185EB3110")]
	public KEMPNLKAPFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000213")]
[FHOIBFDAOOA(typeof(BNKPHKHKLHD), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal class BNKPHKHKLHD : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x4000694")]
	public static readonly SceneTag CHGHPHAKGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	[DMNKPOGEHOO]
	private KBADIJFHJMJ GDJPIHBFICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	[DMNKPOGEHOO]
	private HFHCOKNIOMB LKCOHANNNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	[DMNKPOGEHOO]
	private DDPCONHAGKM MNIFNPOEFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	[DMNKPOGEHOO]
	private OMMEEFHEKMM CGFIECMKFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	[DMNKPOGEHOO]
	private ILNJHJKGMAN ILJBHBBBFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private EntityQuery NNHOLAEGMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private EntityQuery PEBPGBOGGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private EntityQuery JAFOACODEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private Entity CCAINEOPODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public NativeArray<Entity> JACFBAOMEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0xBEB940", Offset = "0xBEAD40", VA = "0x180BEB940")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0xBEA830", Offset = "0xBE9C30", VA = "0x180BEA830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Entity FAKDNKDCIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3B30", Offset = "0x5EA2F30", VA = "0x185EA3B30")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public SceneTag JBMMFKFEGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3620", Offset = "0x5EA2A20", VA = "0x185EA3620")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Entity CHHJCENEPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3620", Offset = "0x5EA2A20", VA = "0x185EA3620")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3520", Offset = "0x5EA2920", VA = "0x185EA3520")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4300", Offset = "0x5EA3700", VA = "0x185EA4300")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3C40", Offset = "0x5EA3040", VA = "0x185EA3C40", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B40")]
	[Cpp2IlInjected.Address(RVA = "0x5EA35E0", Offset = "0x5EA29E0", VA = "0x185EA35E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B41")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4350", Offset = "0x5EA3750", VA = "0x185EA4350")]
	public void OMMBBCDEIAG(Entity AHNNJNFIHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B42")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4B30", Offset = "0x5EA3F30", VA = "0x185EA4B30")]
	public NativeArray<Entity> PMNGABIMCCG(Allocator JIIMEDFKEME = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B43")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3340", Offset = "0x5EA2740", VA = "0x185EA3340")]
	public void AGBLJKODCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B44")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3A10", Offset = "0x5EA2E10", VA = "0x185EA3A10")]
	public void IBENJAINKLM(Entity KJAEFLADAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B45")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3D40", Offset = "0x5EA3140", VA = "0x185EA3D40")]
	public Entity KMKGIHGHIPI(string DKFEAPHKBMP = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B46")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3EE0", Offset = "0x5EA32E0", VA = "0x185EA3EE0")]
	public void MJJOCKLIADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B47")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3590", Offset = "0x5EA2990", VA = "0x185EA3590")]
	public void CONPNMHNOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B48")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	public void MKAJMIMGJKN(Entity KJAEFLADAPH, string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B49")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3390", Offset = "0x5EA2790", VA = "0x185EA3390")]
	public void AOCPHAMNJCH(Entity KJAEFLADAPH, bool EIJFMBGDKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4510", Offset = "0x5EA3910", VA = "0x185EA4510")]
	public void PGKFLAKMBDG(Entity AHNNJNFIHFM, Entity KJAEFLADAPH, bool HIBBEJKHBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4740", Offset = "0x5EA3B40", VA = "0x185EA4740")]
	public void PGKFLAKMBDG(NativeArray<Entity> JIBDNODJOAB, Entity KJAEFLADAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4970", Offset = "0x5EA3D70", VA = "0x185EA4970")]
	private void PICKIEIJJHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA35B0", Offset = "0x5EA29B0", VA = "0x185EA35B0")]
	private void DHIHJDLPGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3B30", Offset = "0x5EA2F30", VA = "0x185EA3B30")]
	private Entity IOPKPLMFNBP()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3F00", Offset = "0x5EA3300", VA = "0x185EA3F00")]
	private void OGAOCOGDGPF(EntityQuery AFEFPGJFILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3FE0", Offset = "0x5EA33E0", VA = "0x185EA3FE0")]
	private void OGAOCOGDGPF(NativeArray<Entity> KMCCKENJIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3DF0", Offset = "0x5EA31F0", VA = "0x185EA3DF0")]
	private void LGNFLEGKFMH(Entity KJAEFLADAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B52")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3710", Offset = "0x5EA2B10", VA = "0x185EA3710")]
	private void GCKCMNGFBDO(Entity KJAEFLADAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B53")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4390", Offset = "0x5EA3790", VA = "0x185EA4390")]
	private void PDMJNKGHDFK(SceneTag KJAJHGBEJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B54")]
	[Cpp2IlInjected.Address(RVA = "0x5EA34E0", Offset = "0x5EA28E0", VA = "0x185EA34E0")]
	private void CAJJKJEGHCN(SceneTag KJAJHGBEJIK, NativeParallelHashSet<int> JNBGCOHHPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B55")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3840", Offset = "0x5EA2C40", VA = "0x185EA3840")]
	private void HNOJICNEKLL(SceneTag KJAJHGBEJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B56")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3670", Offset = "0x5EA2A70", VA = "0x185EA3670")]
	private void FFALMCHDEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B57")]
	[Cpp2IlInjected.Address(RVA = "0x21A21B0", Offset = "0x21A15B0", VA = "0x1821A21B0")]
	private void LHMGIHMOMGP<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B58")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public BNKPHKHKLHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000214")]
[AKLGDNDGKKL(DPJKEJCGJEB.PhotonRoom)]
[FHOIBFDAOOA(typeof(LAKGPMMKLEK), new string[] { })]
internal class MIGHOJACFMH : ENDDIKHKCDF, LAKGPMMKLEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	[DMNKPOGEHOO]
	private BNKPHKHKLHD KMCCKENJIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private readonly Dictionary<int, Entity> AEEJBHCNNMG;

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9900", Offset = "0x5EB8D00", VA = "0x185EB9900")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5B")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9670", Offset = "0x5EB8A70", VA = "0x185EB9670", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9950", Offset = "0x5EB8D50", VA = "0x185EB9950", Slot = "5")]
	public void OMMBBCDEIAG(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9700", Offset = "0x5EB8B00", VA = "0x185EB9700", Slot = "6")]
	public bool OCGICDDBFKB(CAKFEHOBCAO AJAFIOGCMHP, Transform IJKPFNCIDCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9600", Offset = "0x5EB8A00", VA = "0x185EB9600")]
	private bool FECIFFGAGPA(Scene KJAEFLADAPH, [Out] Entity PLCAMKLGOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9AD0", Offset = "0x5EB8ED0", VA = "0x185EB9AD0")]
	public MIGHOJACFMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000215")]
[FHOIBFDAOOA(typeof(OMMEEFHEKMM), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal sealed class OMMEEFHEKMM : ENDDIKHKCDF, ICKLGHMJPBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	[DMNKPOGEHOO]
	private DDPCONHAGKM MNIFNPOEFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private Entity AHNNJNFIHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private ComponentTypeList DJKCBPMDJBO;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x5EBDC90", Offset = "0x5EBD090", VA = "0x185EBDC90")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B61")]
	[Cpp2IlInjected.Address(RVA = "0x253B110", Offset = "0x253A510", VA = "0x18253B110")]
	public T KJBHHOOLCCM<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B62")]
	[Cpp2IlInjected.Address(RVA = "0x253AFF0", Offset = "0x253A3F0", VA = "0x18253AFF0")]
	public void FAJCEJLMNJF<T>(T LPCGJALKADL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B63")]
	[Cpp2IlInjected.Address(RVA = "0x253AE90", Offset = "0x253A290", VA = "0x18253AE90")]
	public DynamicBuffer<T> DCJIEPDKNJE<T>(bool ACHJCHKHOEH = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B64")]
	[Cpp2IlInjected.Address(RVA = "0x253B220", Offset = "0x253A620", VA = "0x18253B220")]
	public void LDLFPLHEGPK<T>(T LPCGJALKADL) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B65")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDB20", Offset = "0x5EBCF20", VA = "0x185EBDB20", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B66")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD930", Offset = "0x5EBCD30", VA = "0x185EBD930", Slot = "5")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B67")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD930", Offset = "0x5EBCD30", VA = "0x185EBD930")]
	private void NHBMPCJIOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B68")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD190", Offset = "0x5EBC590", VA = "0x185EBD190", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B69")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD4F0", Offset = "0x5EBC8F0", VA = "0x185EBD4F0")]
	private ComponentTypeList EBJLHIDAPLC()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void COIHAPMDJFP(int CHEGLPEPHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void DKAILJFFJPB(Type DJMKKNDNCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDB90", Offset = "0x5EBCF90", VA = "0x185EBDB90")]
	private static void KIBGEEFKELO(Type DJMKKNDNCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public OMMEEFHEKMM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000216")]
[PLPMKAGKLMA]
internal struct NCLAKJEOAPK : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000217")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(OACDJAJNOAN), new string[] { })]
internal sealed class OACDJAJNOAN : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private static readonly FJOGIBEAJHF POPFAECCGKH;

	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private static readonly FJOGIBEAJHF BFNCONPGMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private PNKPENPEALM<LOEHFBCMKLI, Entity> DGDCAPGJMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private FHDCGHPCKOL<EBMLJLFBLEN> LADOPHFFKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private FHDCGHPCKOL<NOAAEPNPGCN> CIGOCOJPMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006AF")]
	private FHDCGHPCKOL<OKLGPBILBNL> OLIFECHLGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	private FHDCGHPCKOL<BKNMJPFLODP> GIBHLBJCFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	private FHDCGHPCKOL<JGBMKLBMIAK> GIKKACIEGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public BJBKJIMPOKB<Entity> KDLLHKBCPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public CCPHPPNFFDG IAEPOPHOEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public CCPHPPNFFDG DEMJOEFKMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public CCPHPPNFFDG PBPBBDBPMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public CCPHPPNFFDG HBFPHLKGMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public CCPHPPNFFDG JOMDAMBCGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x76A450", Offset = "0x769850", VA = "0x18076A450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x5EBA820", Offset = "0x5EB9C20", VA = "0x185EBA820")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B76")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA5E0", Offset = "0x5EB99E0", VA = "0x185EBA5E0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B77")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA4F0", Offset = "0x5EB98F0", VA = "0x185EBA4F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x25056F0", Offset = "0x2504AF0", VA = "0x1825056F0")]
	private void EGBIPNOEPPP<T>(FHDCGHPCKOL<T> PFLMOHAKNCJ, EntityCommandBufferSystem FLDGJNGPMOE, FJOGIBEAJHF AABDFOONPNL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x25057A0", Offset = "0x2504BA0", VA = "0x1825057A0")]
	private void EGBIPNOEPPP<TC, TV>(PNKPENPEALM<TC, TV> PFLMOHAKNCJ) where TC : struct, AKJDOCOCMOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public OACDJAJNOAN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000218")]
public struct NOAAEPNPGCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000219")]
public struct EBMLJLFBLEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200021A")]
public struct OKLGPBILBNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200021B")]
public struct BKNMJPFLODP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200021C")]
public struct JGBMKLBMIAK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200021D")]
[ExecuteAlways]
public class GMAHOLAPCPJ : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	public GMAHOLAPCPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021E")]
[FHOIBFDAOOA(typeof(AJMHHCCGIGG), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal sealed class AJMHHCCGIGG : IFKHMGNDLHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private NDPAEDKCNFI LBJAJCFLLAP;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public NDPAEDKCNFI NHFLJIFBKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x1BC97D0", Offset = "0x1BC8BD0", VA = "0x181BC97D0")]
		get
		{
			return default(NDPAEDKCNFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2310", Offset = "0x5EA1710", VA = "0x185EA2310", Slot = "4")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2300", Offset = "0x5EA1700", VA = "0x185EA2300", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public AJMHHCCGIGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021F")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(AOGMODGMOLB), new string[] { })]
internal sealed class AOGMODGMOLB
{
	[Cpp2IlInjected.Token(Token = "0x2000220")]
	public enum JECPKGIAJNL
	{
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x2000221")]
	public struct GHMDJLENJLA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private JECPKGIAJNL LGMBCMJMOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private readonly AOGMODGMOLB DCLCDDGJKIC;

		[Cpp2IlInjected.Token(Token = "0x6000B88")]
		[Cpp2IlInjected.Address(RVA = "0x5EA96C0", Offset = "0x5EA8AC0", VA = "0x185EA96C0")]
		public GHMDJLENJLA(AOGMODGMOLB DCLCDDGJKIC, JECPKGIAJNL KBOPLLOOOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x5EA96A0", Offset = "0x5EA8AA0", VA = "0x185EA96A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	public JECPKGIAJNL KBOPLLOOOBM;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public JECPKGIAJNL BECHHFIHLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B81")]
		[Cpp2IlInjected.Address(RVA = "0x762180", Offset = "0x761580", VA = "0x180762180")]
		get
		{
			return default(JECPKGIAJNL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B82")]
		[Cpp2IlInjected.Address(RVA = "0x7712D0", Offset = "0x7706D0", VA = "0x1807712D0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool JJKPEDNCKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B83")]
		[Cpp2IlInjected.Address(RVA = "0x4FDC000", Offset = "0x4FDB400", VA = "0x184FDC000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2770", Offset = "0x5EA1B70", VA = "0x185EA2770")]
	public GHMDJLENJLA LCDMJAOIEOG()
	{
		return default(GHMDJLENJLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x5EA27C0", Offset = "0x5EA1BC0", VA = "0x185EA27C0")]
	public GHMDJLENJLA NIMFIJKFGHA()
	{
		return default(GHMDJLENJLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public AOGMODGMOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000222")]
[FHOIBFDAOOA(typeof(JEKOGBJNELB), new string[] { })]
internal class PLDAIPDLOLM : JEKOGBJNELB, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	[DMNKPOGEHOO]
	private MOHMCBFIKAN FANNEIHEMKC;

	[Cpp2IlInjected.Token(Token = "0x6000B8A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF110", Offset = "0x5EBE510", VA = "0x185EBF110", Slot = "8")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBEEC0", Offset = "0x5EBE2C0", VA = "0x185EBEEC0", Slot = "4")]
	public World AICLFEIEJFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF070", Offset = "0x5EBE470", VA = "0x185EBF070", Slot = "5")]
	public World IHKNANCMGFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBEFD0", Offset = "0x5EBE3D0", VA = "0x185EBEFD0", Slot = "6")]
	public World AIHGPEGGMAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8E")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF160", Offset = "0x5EBE560", VA = "0x185EBF160", Slot = "7")]
	public World PEOJJJINLLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF200", Offset = "0x5EBE600", VA = "0x185EBF200")]
	private World PPCJEJKKONB(string DKFEAPHKBMP, NBFMNJCODMI PLINNFIDOFF, Type HCLGMOEEJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B90")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public PLDAIPDLOLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000223")]
[FHOIBFDAOOA(typeof(CMLGHDCNGPG), new string[] { })]
public class OFHBJFAOLBI : ENDDIKHKCDF, CMLGHDCNGPG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000224")]
	[CompilerGenerated]
	private struct FNEOBOINCAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public CAKFEHOBCAO parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public OFHBJFAOLBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public ALMEJJCLCED objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private BAJJJAGOPJE <parentObject>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private Vector3 <pos>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private Quaternion <rot>5__4;

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9060", Offset = "0x5EA8460", VA = "0x185EA9060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9640", Offset = "0x5EA8A40", VA = "0x185EA9640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000225")]
	[CompilerGenerated]
	private struct JHBDELEAFCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public OFHBJFAOLBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public BAJJJAGOPJE obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0410", Offset = "0x5EAF810", VA = "0x185EB0410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0910", Offset = "0x5EAFD10", VA = "0x185EB0910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	[DMNKPOGEHOO]
	private MFLEFLGGBDF FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.Token(Token = "0x6000B91")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC550", Offset = "0x5EBB950", VA = "0x185EBC550", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B92")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC850", Offset = "0x5EBBC50", VA = "0x185EBC850", Slot = "5")]
	public bool KLBBHODBIHC(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC250", Offset = "0x5EBB650", VA = "0x185EBC250", Slot = "7")]
	public bool CDOEEOBKFMM(CAKFEHOBCAO AJAFIOGCMHP, [Out] Guid OFLFFIGFOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC930", Offset = "0x5EBBD30", VA = "0x185EBC930", Slot = "8")]
	public Guid LKCOGBHFJMM(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCD50", Offset = "0x5EBC150", VA = "0x185EBCD50", Slot = "9")]
	public void NHOBFOFGMLM(CAKFEHOBCAO AJAFIOGCMHP, Guid OFLFFIGFOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCC80", Offset = "0x5EBC080", VA = "0x185EBCC80", Slot = "10")]
	public bool MFKCFCIAJIF(CAKFEHOBCAO AJAFIOGCMHP, [Out] Guid CNCFOBBIEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B97")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBC00", Offset = "0x5EBB000", VA = "0x185EBBC00", Slot = "11")]
	public Guid ANJIMKAHKEO(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B98")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCA10", Offset = "0x5EBBE10", VA = "0x185EBCA10", Slot = "12")]
	public void LNBGIIMKAPM(CAKFEHOBCAO AJAFIOGCMHP, Guid CNCFOBBIEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC320", Offset = "0x5EBB720", VA = "0x185EBC320", Slot = "13")]
	public void CMBOGPPCDHK(CAKFEHOBCAO AJAFIOGCMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBEA0", Offset = "0x5EBB2A0", VA = "0x185EBBEA0", Slot = "14")]
	public void CBKFCLMBIHF(CAKFEHOBCAO ADOGMMPMLJB, CAKFEHOBCAO DCLCDDGJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBD70", Offset = "0x5EBB170", VA = "0x185EBBD70")]
	[AsyncStateMachine(typeof(FNEOBOINCAD))]
	private Task BOBIOGDCFLG(ALMEJJCLCED EPCMAIECDOM, CAKFEHOBCAO DCLCDDGJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC3C0", Offset = "0x5EBB7C0", VA = "0x185EBC3C0")]
	private void DCNGPGKLCMF(ALMEJJCLCED EPCMAIECDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC5F0", Offset = "0x5EBB9F0", VA = "0x185EBC5F0")]
	[AsyncStateMachine(typeof(JHBDELEAFCM))]
	private Task JDCAKEKLAKM(BAJJJAGOPJE IBBNLILJNEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC6E0", Offset = "0x5EBBAE0", VA = "0x185EBC6E0")]
	private Task KCPAMPIDNPA(BAJJJAGOPJE IBBNLILJNEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBCE0", Offset = "0x5EBB0E0", VA = "0x185EBBCE0", Slot = "6")]
	public bool BHLPKBKNODM(CAKFEHOBCAO PCOAABDKEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public OFHBJFAOLBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000226")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(GMHNIACPINN), new string[] { })]
public class GMHNIACPINN : ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	[DMNKPOGEHOO]
	private EKBKOBJCEAO DIHODDBACDE;

	[Cpp2IlInjected.Token(Token = "0x6000BA6")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9710", Offset = "0x5EA8B10", VA = "0x185EA9710", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA7")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public GMHNIACPINN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000227")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[FHOIBFDAOOA(typeof(BFCOAGBJGDN), new string[] { })]
internal sealed class BFCOAGBJGDN : ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	[DMNKPOGEHOO]
	private JFKPCOBONKJ KNPPJNCAIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	[DMNKPOGEHOO]
	private CONBBCGFLGK GCLLOKNNAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	[DMNKPOGEHOO]
	private GICCNDIODFI EKNAGPONANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	[DMNKPOGEHOO]
	private KHHBHMMACPM FNIMMOLDOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	[DMNKPOGEHOO]
	private KPEDMHIOJHN JCHDKHDJJMJ;

	[Cpp2IlInjected.Token(Token = "0x6000BA8")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2D20", Offset = "0x5EA2120", VA = "0x185EA2D20", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA9")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2C80", Offset = "0x5EA2080", VA = "0x185EA2C80")]
	public void FIOLIIPCNDJ(NativeArray<HNGHCMBBKEB> HDDEBDIKCHN, NativeArray<IKAJAHLJFMC> LLBGDKONGBO, NativeArray<Entity> AEPCAGKMEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2C70", Offset = "0x5EA2070", VA = "0x185EA2C70")]
	public Entity FIOLIIPCNDJ(HNGHCMBBKEB HOAIKLJFCGK, IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2A90", Offset = "0x5EA1E90", VA = "0x185EA2A90")]
	public Entity KEABAAMENCA(HNGHCMBBKEB HOAIKLJFCGK, bool BONNBAOJEFF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAC")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2A50", Offset = "0x5EA1E50", VA = "0x185EA2A50")]
	public Entity KEABAAMENCA(HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAD")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2F40", Offset = "0x5EA2340", VA = "0x185EA2F40")]
	public Entity MDIMLHEMGML()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAE")]
	[Cpp2IlInjected.Address(RVA = "0x5EA28A0", Offset = "0x5EA1CA0", VA = "0x185EA28A0")]
	public Entity BCBCDPHCOFG(JHDIEJNPMMJ DJMKKNDNCBM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAF")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2CC0", Offset = "0x5EA20C0", VA = "0x185EA2CC0")]
	public KLCLLLJMBOO GPLBOIIHMOK(KLCLLLJMBOO KPFNJKBFGEC, Allocator JIIMEDFKEME)
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2F80", Offset = "0x5EA2380", VA = "0x185EA2F80")]
	public EntityArchetype OGKLJBOGNGD(HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB1")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2E10", Offset = "0x5EA2210", VA = "0x185EA2E10")]
	public Entity KCANJMAFAGK(HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB2")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2A90", Offset = "0x5EA1E90", VA = "0x185EA2A90")]
	private Entity FHPDOCHLJFG(HNGHCMBBKEB HOAIKLJFCGK, bool BONNBAOJEFF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB3")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2A50", Offset = "0x5EA1E50", VA = "0x185EA2A50")]
	private Entity FHPDOCHLJFG(HNGHCMBBKEB HOAIKLJFCGK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2AE0", Offset = "0x5EA1EE0", VA = "0x185EA2AE0")]
	private Entity FHPDOCHLJFG(HNGHCMBBKEB HOAIKLJFCGK, IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2930", Offset = "0x5EA1D30", VA = "0x185EA2930")]
	private void FBPDBHJKPIE(HNGHCMBBKEB HOAIKLJFCGK, NativeArray<IKAJAHLJFMC> LLBGDKONGBO, NativeArray<Entity> AEPCAGKMEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB6")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3000", Offset = "0x5EA2400", VA = "0x185EA3000")]
	private void PFLKFOKABPO(NativeArray<HNGHCMBBKEB> HDDEBDIKCHN, NativeArray<IKAJAHLJFMC> LLBGDKONGBO, NativeArray<Entity> AEPCAGKMEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB7")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public BFCOAGBJGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000228")]
[FHOIBFDAOOA(typeof(GICCNDIODFI), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
internal sealed class GICCNDIODFI : ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	public static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	[DMNKPOGEHOO]
	private HONAKLLNIOE BDMHHEHOOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	[DMNKPOGEHOO]
	private JFKPCOBONKJ HCGKIGBGFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	[DMNKPOGEHOO]
	private CONBBCGFLGK FJCAEKADLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private NativeParallelHashMap<IKAJAHLJFMC, Entity> PGHMKDPKHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	internal NativeParallelHashMap<IKAJAHLJFMC, Entity> CLHEDILNNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0xD230A0", Offset = "0xD224A0", VA = "0x180D230A0")]
		get
		{
			return default(NativeParallelHashMap<IKAJAHLJFMC, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	internal uint CHFPEOBLHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x5EC77D0", Offset = "0x5EC6BD0", VA = "0x185EC77D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x830750", Offset = "0x82FB50", VA = "0x180830750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7800", Offset = "0x5EC6C00", VA = "0x185EC7800", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBD")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7550", Offset = "0x5EC6950", VA = "0x185EC7550", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBE")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7CD0", Offset = "0x5EC70D0", VA = "0x185EC7CD0")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBF")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7C00", Offset = "0x5EC7000", VA = "0x185EC7C00")]
	public IKAJAHLJFMC NINDLKCKGBE(int CHEGLPEPHED)
	{
		return default(IKAJAHLJFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC0")]
	[Cpp2IlInjected.Address(RVA = "0x5EC75C0", Offset = "0x5EC69C0", VA = "0x185EC75C0")]
	public void GKHPHINAHPA(IKAJAHLJFMC MIPKLHDFLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC1")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7920", Offset = "0x5EC6D20", VA = "0x185EC7920")]
	public CAKFEHOBCAO MBBJHIFDBPF(IKAJAHLJFMC MIPKLHDFLBO)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC2")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7420", Offset = "0x5EC6820", VA = "0x185EC7420")]
	public bool DMFHNPPLLIH(IKAJAHLJFMC MIPKLHDFLBO, [Out] CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC3")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7AD0", Offset = "0x5EC6ED0", VA = "0x185EC7AD0")]
	public KLCLLLJMBOO MBBJHIFDBPF(NativeArray<IKAJAHLJFMC> MIPKLHDFLBO, Allocator JIIMEDFKEME)
	{
		return default(KLCLLLJMBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC4")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7380", Offset = "0x5EC6780", VA = "0x185EC7380")]
	public IKAJAHLJFMC CDLFJKIJIFJ(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(IKAJAHLJFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC5")]
	[Cpp2IlInjected.Address(RVA = "0x5EC72F0", Offset = "0x5EC66F0", VA = "0x185EC72F0")]
	public IKAJAHLJFMC CDLFJKIJIFJ(Entity AHNNJNFIHFM)
	{
		return default(IKAJAHLJFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC6")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7110", Offset = "0x5EC6510", VA = "0x185EC7110")]
	public void BIJECAJAFGP(NativeArray<Entity> JIBDNODJOAB, NativeArray<IKAJAHLJFMC> LLBGDKONGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC7")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7780", Offset = "0x5EC6B80", VA = "0x185EC7780")]
	private CAKFEHOBCAO IMEEFMHHMIM(Entity AHNNJNFIHFM)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC8")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public GICCNDIODFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
[FHOIBFDAOOA(typeof(NGDPKGKNNBP), new string[] { })]
public sealed class JPGNCJLDMAE : NGDPKGKNNBP, FOAPOKJFCAL, IFKHMGNDLHA, ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	[DMNKPOGEHOO]
	private MAICAFPPDGB BADPICBHGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private Collider[] ANGNHANNICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private RaycastHit[] NFCFFDOHAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private BMOENLKLHFA<HMGDPCDJKDM, BoxCollider> DBDKBHNEOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private Scene KJAEFLADAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	private PhysicsScene IJMBHCFMMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private GameObject BDNIDEKLIGD;

	[Cpp2IlInjected.Token(Token = "0x6000BCA")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9AE0", Offset = "0x5EC8EE0", VA = "0x185EC9AE0", Slot = "9")]
	public void MONICAJFPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCB")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9360", Offset = "0x5EC8760", VA = "0x185EC9360", Slot = "10")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC91F0", Offset = "0x5EC85F0", VA = "0x185EC91F0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCD")]
	[Cpp2IlInjected.Address(RVA = "0x5EC90B0", Offset = "0x5EC84B0", VA = "0x185EC90B0", Slot = "4")]
	public HMGDPCDJKDM DHMHMLBLFOJ(Entity AHNNJNFIHFM)
	{
		return default(HMGDPCDJKDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCE")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9D00", Offset = "0x5EC9100", VA = "0x185EC9D00", Slot = "5")]
	public void PAIFIIADEJB(NativeArray<HMGDPCDJKDM> HHPNPODNLFG, NativeArray<JABAMAIPKGD> AKLEIOCDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCF")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9C40", Offset = "0x5EC9040", VA = "0x185EC9C40", Slot = "6")]
	public void NGBINGGPKBF(HMGDPCDJKDM EKHBDCNGFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD0")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9F60", Offset = "0x5EC9360", VA = "0x185EC9F60", Slot = "7")]
	public bool PDILAFMNMHO(HMGDPCDJKDM EKHBDCNGFLP, [Out] Collider MHOODELGFIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD1")]
	[Cpp2IlInjected.Address(RVA = "0x5EC94B0", Offset = "0x5EC88B0", VA = "0x185EC94B0")]
	public bool KIILMPOMDOF([In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, float FECAAKMJJAF, Allocator JIIMEDFKEME, [Out] NativeArray<Entity> JIBDNODJOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD2")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9310", Offset = "0x5EC8710", VA = "0x185EC9310")]
	private void HHCJODECELE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD3")]
	[Cpp2IlInjected.Address(RVA = "0xD14DE0", Offset = "0xD141E0", VA = "0x180D14DE0")]
	private void FIBIMFHCAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD4")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9020", Offset = "0x5EC8420", VA = "0x185EC9020")]
	private void BBMMFIHJHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD5")]
	[Cpp2IlInjected.Address(RVA = "0x82B3E0", Offset = "0x82A7E0", VA = "0x18082B3E0")]
	private void AGPJJHDACDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD6")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA000", Offset = "0x5EC9400", VA = "0x185ECA000")]
	private BoxCollider PEINNJDCLJG(Entity AHNNJNFIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD7")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9430", Offset = "0x5EC8830", VA = "0x185EC9430")]
	private void JMJPHEEPPON(BoxCollider LPEKDLLHIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD8")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8E70", Offset = "0x5EC8270", VA = "0x185EC8E70")]
	private void AFFNFJFIIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD9")]
	[Cpp2IlInjected.Address(RVA = "0x5EC99E0", Offset = "0x5EC8DE0", VA = "0x185EC99E0")]
	private void LNEAFNCFHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDA")]
	[Cpp2IlInjected.Address(RVA = "0x5EC97D0", Offset = "0x5EC8BD0", VA = "0x185EC97D0")]
	private void LIBHCOEPDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDB")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9080", Offset = "0x5EC8480", VA = "0x185EC9080")]
	private void CBFDFEJFGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9300", Offset = "0x5EC8700", VA = "0x185EC9300")]
	private void EMPNOLCKGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDD")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9790", Offset = "0x5EC8B90", VA = "0x185EC9790")]
	private void LBJLKLLFMGM(Scene NHLIGKKJDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDE")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public JPGNCJLDMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE0")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9070", Offset = "0x5EC8470", VA = "0x185EC9070", Slot = "8")]
	private bool BMGDCMFMHLJ([In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, float FECAAKMJJAF, Allocator JIIMEDFKEME, [Out] NativeArray<Entity> JIBDNODJOAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200022A")]
[AKLGDNDGKKL(DPJKEJCGJEB.OMRoom)]
[AIFOCBABFAO(typeof(OAFEOPGEEED))]
[FHOIBFDAOOA(typeof(BGJJBIGDGID), new string[] { })]
internal class BGJJBIGDGID : ENDDIKHKCDF, OAFEOPGEEED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006E5")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E7")]
	[DMNKPOGEHOO]
	private DGCKHDEMBFP EMJCANGJNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006E8")]
	private KFIGKCHPCDA MFNAGJJMGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private NativeList<byte> OOIBMCBCEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private NativeList<KFHEKKOEHDF> IGGDJPBNHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	private NativeList<OMGHOAKAFHB> HNOMDOCBMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	private int LEPDGODJIBM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<KFHEKKOEHDF, NativeArray<byte>> BKLFKLAGDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5460", Offset = "0x5EC4860", VA = "0x185EC5460")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5860", Offset = "0x5EC4C60", VA = "0x185EC5860")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE3")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5590", Offset = "0x5EC4990", VA = "0x185EC5590", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE4")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5510", Offset = "0x5EC4910", VA = "0x185EC5510", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE5")]
	[Cpp2IlInjected.Address(RVA = "0x5EC56C0", Offset = "0x5EC4AC0", VA = "0x185EC56C0", Slot = "5")]
	public void MODFCKCNHMB(KFHEKKOEHDF OFAFLOECBGM, ReadOnlySpan<byte> CJFCIOOMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE6")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5910", Offset = "0x5EC4D10", VA = "0x185EC5910")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public BGJJBIGDGID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022B")]
[FHOIBFDAOOA(typeof(GLJHEKCADEF), new string[] { })]
internal class LKEMPNCFIDL : GLJHEKCADEF, ENDDIKHKCDF, ICKLGHMJPBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200022C")]
	[CompilerGenerated]
	private sealed class PAIEKCKKLIL : IEnumerable<CAKFEHOBCAO>, IEnumerable, IEnumerator<CAKFEHOBCAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private CAKFEHOBCAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public LKEMPNCFIDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private CAKFEHOBCAO localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public CAKFEHOBCAO <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private NativeArray<Entity> <childEntitiesCopy>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private NativeArray<Entity>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private CAKFEHOBCAO System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x30A23D0", Offset = "0x30A17D0", VA = "0x1830A23D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CAKFEHOBCAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x5ED0B80", Offset = "0x5ECFF80", VA = "0x185ED0B80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public PAIEKCKKLIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0BD0", Offset = "0x5ECFFD0", VA = "0x185ED0BD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0630", Offset = "0x5ECFA30", VA = "0x185ED0630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED09D0", Offset = "0x5ECFDD0", VA = "0x185ED09D0")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A20", Offset = "0x5ECFE20", VA = "0x185ED0A20")]
		private void POMJOEIOKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0B30", Offset = "0x5ECFF30", VA = "0x185ED0B30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C11")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A70", Offset = "0x5ECFE70", VA = "0x185ED0A70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CAKFEHOBCAO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C12")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A70", Offset = "0x5ECFE70", VA = "0x185ED0A70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	private static readonly FJOGIBEAJHF KBCJLIPADHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private OPAANNDNOCG KDDNMNODBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private MJHGFDFFPLH MGJAOFDCMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	private MKIKBAICGGB<Entity> FEFODEEKLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private MKIKBAICGGB<float3> OIEPFFDODAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006F9")]
	private MKIKBAICGGB<quaternion> DFHIEFBEOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private MKIKBAICGGB<float> ECHGNLKKLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private HashSet<Entity> GPKCLHOAGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40006FC")]
	private HashSet<Entity> KFGIDFKIHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private EntityQuery CINFOINBMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public Func<HMJPDGHCKHI> LBALBOHAPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x7653F0", Offset = "0x7647F0", VA = "0x1807653F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x765420", Offset = "0x764820", VA = "0x180765420", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<CAKFEHOBCAO, CAKFEHOBCAO> BBIJGGGHIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBEB0", Offset = "0x5ECB2B0", VA = "0x185ECBEB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA780", Offset = "0x5EC9B80", VA = "0x185ECA780", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<CAKFEHOBCAO, CAKFEHOBCAO> CBCOGKMIMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA9C0", Offset = "0x5EC9DC0", VA = "0x185ECA9C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA6D0", Offset = "0x5EC9AD0", VA = "0x185ECA6D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<CAKFEHOBCAO, CAKFEHOBCAO, CAKFEHOBCAO> CAIPHDJOBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC2E0", Offset = "0x5ECB6E0", VA = "0x185ECC2E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC390", Offset = "0x5ECB790", VA = "0x185ECC390", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<CAKFEHOBCAO> BCKIJKIILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA620", Offset = "0x5EC9A20", VA = "0x185ECA620", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB080", Offset = "0x5ECA480", VA = "0x185ECB080", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF3")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBD50", Offset = "0x5ECB150", VA = "0x185ECBD50", Slot = "26")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF4")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB130", Offset = "0x5ECA530", VA = "0x185ECB130", Slot = "27")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAC90", Offset = "0x5ECA090", VA = "0x185ECAC90", Slot = "28")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF6")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBC30", Offset = "0x5ECB030", VA = "0x185ECBC30")]
	private void FNIMLEHMFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF7")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA480", Offset = "0x5EC9880", VA = "0x185ECA480")]
	private void BLOJBGDPNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF8")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB610", Offset = "0x5ECAA10", VA = "0x185ECB610")]
	private void ELDNANCBGIO(DMMDOJFOBIA OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF9")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA3A0", Offset = "0x5EC97A0", VA = "0x185ECA3A0")]
	private void BEPNBPPLCBN(DMMDOJFOBIA OOIBMCBCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFA")]
	[Cpp2IlInjected.Address(RVA = "0x7F89B0", Offset = "0x7F7DB0", VA = "0x1807F89B0", Slot = "14")]
	public Color ABLENOAFODI(CAKFEHOBCAO AJAFIOGCMHP, int CHLEKMDCCGF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFB")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAA70", Offset = "0x5EC9E70", VA = "0x185ECAA70", Slot = "15")]
	public float3 DOCFILCILKH(CAKFEHOBCAO AJAFIOGCMHP, int CHLEKMDCCGF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFC")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBC90", Offset = "0x5ECB090", VA = "0x185ECBC90", Slot = "16")]
	public bool GFKGOEMFKKA(CAKFEHOBCAO AJAFIOGCMHP, CAKFEHOBCAO PIFNMNCMMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFD")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC170", Offset = "0x5ECB570", VA = "0x185ECC170", Slot = "17")]
	public CAKFEHOBCAO LDBCOCPEGCB(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFE")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBF60", Offset = "0x5ECB360", VA = "0x185ECBF60", Slot = "20")]
	public void JJBGCHDCBLA(CAKFEHOBCAO AJAFIOGCMHP, Vector3 MGNPLBJCIGD, Quaternion BPBIOAIOLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFF")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC0E0", Offset = "0x5ECB4E0", VA = "0x185ECC0E0", Slot = "21")]
	public void KNKDAAHKKIM(CAKFEHOBCAO AJAFIOGCMHP, float CBLNFJJIPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB8E0", Offset = "0x5ECACE0", VA = "0x185ECB8E0", Slot = "24")]
	public float3 FAMKHIGHLDC(EBLBJNHIABP DICNEHFKPLG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAFE0", Offset = "0x5ECA3E0", VA = "0x185ECAFE0", Slot = "25")]
	public quaternion EAKKGLDGNHJ(EBLBJNHIABP DICNEHFKPLG)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA1A0", Offset = "0x5EC95A0", VA = "0x185ECA1A0", Slot = "22")]
	public bool ANLHDNLDAEB(CAKFEHOBCAO AJAFIOGCMHP, [Out] RigidTransform JADIKJPFLKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA830", Offset = "0x5EC9C30", VA = "0x185ECA830", Slot = "23")]
	public bool DCBGOLFHNIM(CAKFEHOBCAO AJAFIOGCMHP, [Out] float CBLNFJJIPNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC240", Offset = "0x5ECB640", VA = "0x185ECC240", Slot = "18")]
	[IteratorStateMachine(typeof(PAIEKCKKLIL))]
	public IEnumerable<CAKFEHOBCAO> NEBPMCOAEIH(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C05")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBAA0", Offset = "0x5ECAEA0", VA = "0x185ECBAA0", Slot = "19")]
	public CAKFEHOBCAO FNCIEIIHFBM(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB980", Offset = "0x5ECAD80", VA = "0x185ECB980")]
	private Entity FNCIEIIHFBM(Entity AHNNJNFIHFM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC500", Offset = "0x5ECB900", VA = "0x185ECC500")]
	public LKEMPNCFIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
[FHOIBFDAOOA(typeof(FHBDOMJNNEJ), new string[] { })]
public sealed class NMFEPKCODNM : FHBDOMJNNEJ, ENDDIKHKCDF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200022E")]
	private struct DEENIBFIJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public float AKGCOEOHLAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public uint EPDKOFDFLPG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	[DMNKPOGEHOO]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	[DMNKPOGEHOO]
	private FOAPOKJFCAL NLBLAGPLJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	[DMNKPOGEHOO]
	private ABLMCLHDBNO OMMPMHHGBML;

	[Cpp2IlInjected.Token(Token = "0x6000C13")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFED0", Offset = "0x5ECF2D0", VA = "0x185ECFED0", Slot = "5")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C14")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0040", Offset = "0x5ECF440", VA = "0x185ED0040")]
	public bool KIILMPOMDOF([In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, float FECAAKMJJAF, [Out] MKOEHACBNCO HMKJLANMADO, [Out] CAKFEHOBCAO ALKPGICEAHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C15")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFF60", Offset = "0x5ECF360", VA = "0x185ECFF60")]
	public static bool KFJAPKEPEOI([In] Span<MKOEHACBNCO> GCCIGIJPPGH, float FECAAKMJJAF, [Out] int JPEMHHILGGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C16")]
	[Cpp2IlInjected.Address(RVA = "0x5ED04F0", Offset = "0x5ECF8F0", VA = "0x185ED04F0")]
	public static float OBLBCHCIDBN(float AKGCOEOHLAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C17")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public NMFEPKCODNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C18")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFEC0", Offset = "0x5ECF2C0", VA = "0x185ECFEC0", Slot = "4")]
	private bool EFLEMGAFDGN([In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, float FECAAKMJJAF, [Out] MKOEHACBNCO HMKJLANMADO, [Out] CAKFEHOBCAO ALKPGICEAHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200022F")]
[FHOIBFDAOOA(typeof(ABLMCLHDBNO), new string[] { })]
public sealed class GPHGOPLHPBH : ABLMCLHDBNO, ENDDIKHKCDF
{
	[Cpp2IlInjected.Token(Token = "0x2000230")]
	[BurstCompile]
	private struct NBFLJOPLNEP : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		[ReadOnly]
		public NativeArray<Entity> JIBDNODJOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		[ReadOnly]
		public float3 KCJFIMBCLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		[ReadOnly]
		public float3 EGLKPNOLKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> JIGILPPAGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		[ReadOnly]
		public ComponentDataFromEntity<JEMPGDCEMGA> MCPFONEFLKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> MDEPKFOOMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		[ReadOnly]
		public ComponentDataFromEntity<AECIBMNAFMF> PDAMJKJHBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		[ReadOnly]
		public ComponentDataFromEntity<JOPAFADPKGF> KGEEBPGDHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		[WriteOnly]
		public NativeArray<MKOEHACBNCO> FKMOPJDPEPF;

		[Cpp2IlInjected.Token(Token = "0x4000717")]
		private static readonly MKOEHACBNCO OCMFOMCFIKP;

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECECB0", Offset = "0x5ECE0B0", VA = "0x185ECECB0", Slot = "4")]
		public void Execute(int JPEMHHILGGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEC00", Offset = "0x5ECE000", VA = "0x185ECEC00")]
		private static float3 EBPDODLAAAM([In] float4x4 GPMBDODCIFN, [In] float3 HGOEIFPLBFO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF050", Offset = "0x5ECE450", VA = "0x185ECF050")]
		private static float3 KLLLPLNEECD([In] float4x4 GPMBDODCIFN, [In] float3 NHFCBHANLPL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEF50", Offset = "0x5ECE350", VA = "0x185ECEF50")]
		private static float3 ILAMALEBPLN([In] float4x4 GPMBDODCIFN, [In] float3 HGOEIFPLBFO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEA20", Offset = "0x5ECDE20", VA = "0x185ECEA20")]
		private static float3 DIOKIJJLHDB([In] float4x4 GPMBDODCIFN, [In] float3 NHFCBHANLPL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF820", Offset = "0x5ECEC20", VA = "0x185ECF820")]
		private bool NEJAOEPCOGA([In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, [In] NativeArray<Entity> IAEOFHLENLM, [Out] float3 HMKJLANMADO, [Out] float3 DDEDMKGDKMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF1D0", Offset = "0x5ECE5D0", VA = "0x185ECF1D0")]
		public static bool LEDJGJEOJKC([In] float3 DODICFBEFLB, [In] float3 MAKFOKDLEFL, [In] float3 AIIMOKDKLPL, [In] float3 JAHNKBAMPIM, float MPGCGDJMPPJ, float JJOFKPICNBF, [Out] float BFGAGBINHNP, [Out] float3 AJKNMOMPICG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	private EntityManager OKNGAOGEIDO;

	[Cpp2IlInjected.Token(Token = "0x6000C19")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7E60", Offset = "0x5EC7260", VA = "0x185EC7E60", Slot = "5")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7EF0", Offset = "0x5EC72F0", VA = "0x185EC7EF0")]
	public void KIILMPOMDOF([In] NativeArray<Entity> JIBDNODJOAB, [In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, [In] NativeArray<MKOEHACBNCO> HDMFOJGBNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1B")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public GPHGOPLHPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7EE0", Offset = "0x5EC72E0", VA = "0x185EC7EE0", Slot = "4")]
	private void KFAAGBNAMMN([In] NativeArray<Entity> JIBDNODJOAB, [In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, [In] NativeArray<MKOEHACBNCO> HDMFOJGBNEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000231")]
[FHOIBFDAOOA(typeof(MJHGFDFFPLH), new string[] { })]
[AIFOCBABFAO(typeof(HGBLHAOBLKK))]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
public class MJHGFDFFPLH : HGBLHAOBLKK, ENDDIKHKCDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000232")]
	private struct BADDCHDLEIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public GGCLCHAMHEE KNPKDOPBDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public Type DJMKKNDNCBM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000233")]
	private struct EMKKANCIPJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public BADDCHDLEIL[] MJHCCCCPHBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000234")]
	[BurstCompile]
	private struct CLOMIMBPBOI : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		[ReadOnly]
		public NativeArray<byte> LPIMHPLJAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		[ReadOnly]
		public NativeArray<Entity> JFFMCPDOLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		[ReadOnly]
		public NativeArray<byte> KALKJLMKNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		[ReadOnly]
		public NativeArray<byte> OHPEIDJOOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		[WriteOnly]
		public NativeList<Entity> CCGAMHBAFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		[WriteOnly]
		public NativeList<byte> AAEBBDJEMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		[WriteOnly]
		public NativeList<byte> NEOFAJJKHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public int BECMBIAKMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public int JOJLKDEDFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public int DIIHBLLEBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int KNIOECFCABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public int OFJLIEHLNCL;

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x5EC69F0", Offset = "0x5EC5DF0", VA = "0x185EC69F0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private readonly Dictionary<NHGDGBFBAIF, GGCLCHAMHEE> AJPGCENGAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	private readonly Dictionary<int, EMKKANCIPJL> BODCBIFFJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	private KHBOFPBPOBG MJHCCCCPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action MAPEDKCNHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDB10", Offset = "0x5ECCF10", VA = "0x185ECDB10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD9A0", Offset = "0x5ECCDA0", VA = "0x185ECD9A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action HLNNEKGCLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE1F0", Offset = "0x5ECD5F0", VA = "0x185ECE1F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD890", Offset = "0x5ECCC90", VA = "0x185ECD890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C29")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD930", Offset = "0x5ECCD30", VA = "0x185ECD930", Slot = "6")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD400", Offset = "0x5ECC800", VA = "0x185ECD400", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD740", Offset = "0x5ECCB40", VA = "0x185ECD740", Slot = "4")]
	public void GFCMFFOEFBO(AMAMFBGBCKA OIBKEMMFJDM, GGCLCHAMHEE LNKIKCGJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDF80", Offset = "0x5ECD380", VA = "0x185ECDF80", Slot = "5")]
	public void OOFKJBAJEMO(AMAMFBGBCKA OIBKEMMFJDM, GGCLCHAMHEE LNKIKCGJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD650", Offset = "0x5ECCA50", VA = "0x185ECD650", Slot = "8")]
	public void GFCMFFOEFBO(NHGDGBFBAIF LNAKMGONIOO, GGCLCHAMHEE AIBILCAOCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE0D0", Offset = "0x5ECD4D0", VA = "0x185ECE0D0", Slot = "9")]
	public void OOFKJBAJEMO(NHGDGBFBAIF LNAKMGONIOO, GGCLCHAMHEE AIBILCAOCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD490", Offset = "0x5ECC890", VA = "0x185ECD490")]
	private void GCFNJPPNJOH(NHGDGBFBAIF LNAKMGONIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC7D0", Offset = "0x5ECBBD0", VA = "0x185ECC7D0")]
	internal void AOFPGGHJMBO(DKHCPOOKLEC CGABFKIJBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCAC0", Offset = "0x5ECBEC0", VA = "0x185ECCAC0")]
	private void CMEKGMDHEDE(DKHCPOOKLEC CGABFKIJBOC, int CEOOILAHGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDD30", Offset = "0x5ECD130", VA = "0x185ECDD30")]
	private void OJAGAMFAKIE(BLKKNKJIPKI AGIINHOJANJ, JKAOACKGDOB DDEEFMKIPDD, BADDCHDLEIL GCKNJCKMOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDBB0", Offset = "0x5ECCFB0", VA = "0x185ECDBB0")]
	private EMKKANCIPJL NAEDFECPPIJ(BLKKNKJIPKI AGIINHOJANJ, JKAOACKGDOB DDEEFMKIPDD)
	{
		return default(EMKKANCIPJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C34")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDA40", Offset = "0x5ECCE40", VA = "0x185ECDA40")]
	private BADDCHDLEIL LJGIDJFKKMG(EMKKANCIPJL JLHKFPKCNHB, BLKKNKJIPKI AGIINHOJANJ, JKAOACKGDOB DDEEFMKIPDD)
	{
		return default(BADDCHDLEIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C35")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE320", Offset = "0x5ECD720", VA = "0x185ECE320")]
	public MJHGFDFFPLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000235")]
[FHOIBFDAOOA(typeof(EEJAONCFMLK), new string[] { })]
public class BPGFADKBJJF : ENDDIKHKCDF, ICKLGHMJPBB, EEJAONCFMLK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000236")]
	[CompilerGenerated]
	private sealed class CMLLBHJLEHL : IEnumerable<CAKFEHOBCAO>, IEnumerable, IEnumerator<CAKFEHOBCAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private CAKFEHOBCAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public BPGFADKBJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private CAKFEHOBCAO splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public CAKFEHOBCAO <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		private CAKFEHOBCAO System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4D")]
			[Cpp2IlInjected.Address(RVA = "0x30A23D0", Offset = "0x30A17D0", VA = "0x1830A23D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CAKFEHOBCAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC6E00", Offset = "0x5EC6200", VA = "0x185EC6E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4A")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public CMLLBHJLEHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6BB0", Offset = "0x5EC5FB0", VA = "0x185EC6BB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6DB0", Offset = "0x5EC61B0", VA = "0x185EC6DB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6CF0", Offset = "0x5EC60F0", VA = "0x185EC6CF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CAKFEHOBCAO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6CF0", Offset = "0x5EC60F0", VA = "0x185EC6CF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private CDJJECGMMII JJMFHKECKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	private EKBKOBJCEAO DIHODDBACDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	private BFCOAGBJGDN FNIMMOLDOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	private OELIJJIDAJD FBGBGEJBECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	private OMMEEFHEKMM OCNOLDKMEPI;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6950", Offset = "0x5EC5D50", VA = "0x185EC6950")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C39")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6670", Offset = "0x5EC5A70", VA = "0x185EC6670", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3A")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
	public void EKLELFOFPLK(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3B")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5DB0", Offset = "0x5EC51B0", VA = "0x185EC5DB0")]
	private void APEMDJKBLKK(Entity EMLMPKDDJFJ, int JPEMHHILGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6800", Offset = "0x5EC5C00", VA = "0x185EC6800", Slot = "10")]
	public void MEMANMIEHGD(CAKFEHOBCAO AJAFIOGCMHP, LOAAMPEDBNJ OJJNHGGGKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6130", Offset = "0x5EC5530", VA = "0x185EC6130", Slot = "9")]
	public LOAAMPEDBNJ CLCCBNABFEK(CAKFEHOBCAO AJAFIOGCMHP)
	{
		return default(LOAAMPEDBNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6090", Offset = "0x5EC5490", VA = "0x185EC6090", Slot = "11")]
	public CAKFEHOBCAO CEPJOKGIHKA(CAKFEHOBCAO FONDFDHEBCB, [Optional] float3? BAONBICGOEJ, [Optional] quaternion? CKFJFCLIANA, [Optional] float3? IJMHENINMDB)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C40")]
	[Cpp2IlInjected.Address(RVA = "0x5EC68B0", Offset = "0x5EC5CB0", VA = "0x185EC68B0", Slot = "12")]
	public CAKFEHOBCAO OAILJPFJCKI(CAKFEHOBCAO FONDFDHEBCB, int JPEMHHILGGG, [Optional] float3? BAONBICGOEJ, [Optional] quaternion? CKFJFCLIANA, [Optional] float3? IJMHENINMDB)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C41")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5AC0", Offset = "0x5EC4EC0", VA = "0x185EC5AC0")]
	private CAKFEHOBCAO AGDONGHIGIK(CAKFEHOBCAO FONDFDHEBCB, int JPEMHHILGGG, [Optional] float3? BAONBICGOEJ, [Optional] quaternion? CKFJFCLIANA, [Optional] float3? IJMHENINMDB)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C42")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5ED0", Offset = "0x5EC52D0", VA = "0x185EC5ED0", Slot = "7")]
	public CAKFEHOBCAO CAPDGJPGLFG(CAKFEHOBCAO FONDFDHEBCB, int JPEMHHILGGG)
	{
		return default(CAKFEHOBCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C43")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5E30", Offset = "0x5EC5230", VA = "0x185EC5E30", Slot = "16")]
	public void BMNDOGIJNLO(CAKFEHOBCAO FONDFDHEBCB, CAKFEHOBCAO EMLMPKDDJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C44")]
	[Cpp2IlInjected.Address(RVA = "0x5EC64F0", Offset = "0x5EC58F0", VA = "0x185EC64F0", Slot = "13")]
	public void GCPHEPDOAJG(CAKFEHOBCAO FONDFDHEBCB, int JPEMHHILGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C45")]
	[Cpp2IlInjected.Address(RVA = "0x5EC61E0", Offset = "0x5EC55E0", VA = "0x185EC61E0", Slot = "14")]
	public void DJHKJFCACCA(CAKFEHOBCAO FONDFDHEBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C46")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5FE0", Offset = "0x5EC53E0", VA = "0x185EC5FE0", Slot = "8")]
	public int CBDDKDJFEPL(CAKFEHOBCAO FONDFDHEBCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5A20", Offset = "0x5EC4E20", VA = "0x185EC5A20", Slot = "6")]
	[IteratorStateMachine(typeof(CMLLBHJLEHL))]
	public IEnumerable<CAKFEHOBCAO> ADPGBGFKCGP(CAKFEHOBCAO FONDFDHEBCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6760", Offset = "0x5EC5B60", VA = "0x185EC6760")]
	private bool KEMPECBJBPP(CAKFEHOBCAO FONDFDHEBCB, [Out] NativeArray<Entity> FEGECHNBDFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public BPGFADKBJJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000237")]
[FHOIBFDAOOA(typeof(GOAPDCLOKJB), new string[] { })]
[AKLGDNDGKKL(DPJKEJCGJEB.LoadInstance)]
internal sealed class GOAPDCLOKJB : ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private HONAKLLNIOE KMPNHHILNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private AOGMODGMOLB IIGCFGNJAPJ;

	[Cpp2IlInjected.Token(Token = "0x6000C52")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7DE0", Offset = "0x5EC71E0", VA = "0x185EC7DE0", Slot = "4")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C53")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public GOAPDCLOKJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000238")]
[DefaultMember("Item")]
public struct DMFDPJBMHAA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	private T[] OOIBMCBCEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	private int FADEBHLHEEP;

	[Cpp2IlInjected.Token(Token = "0x6000C54")]
	[Cpp2IlInjected.Address(RVA = "0x4D13C10", Offset = "0x4D13010", VA = "0x184D13C10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000239")]
[DefaultMember("Item")]
public struct DFBNLMEGOAA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	private DMFDPJBMHAA<T> OOIBMCBCEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	private int FADEBHLHEEP;

	[Cpp2IlInjected.Token(Token = "0x6000C55")]
	[Cpp2IlInjected.Address(RVA = "0x4CEE990", Offset = "0x4CEDD90", VA = "0x184CEE990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C56")]
	[Cpp2IlInjected.Address(RVA = "0x4CEE9D0", Offset = "0x4CEDDD0", VA = "0x184CEE9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200023A")]
public struct NDPAEDKCNFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	private NativeList<Entity> JIBDNODJOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	private TransformAccessArray EHJFODOFCKF;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFD70", Offset = "0x5ECF170", VA = "0x185ECFD70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public NativeList<Entity> HGONJGHJKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public TransformAccessArray IGMLOABBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool DMGAPDBKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFE10", Offset = "0x5ECF210", VA = "0x185ECFE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C57")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFE30", Offset = "0x5ECF230", VA = "0x185ECFE30")]
	public NDPAEDKCNFI(int ACGAEDNGFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFBF0", Offset = "0x5ECEFF0", VA = "0x185ECFBF0")]
	public Entity EHFFKECONDD(int JPEMHHILGGG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFDC0", Offset = "0x5ECF1C0", VA = "0x185ECFDC0")]
	public void IECNMKKJKDN(int ACGAEDNGFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFCB0", Offset = "0x5ECF0B0", VA = "0x185ECFCB0")]
	public int GIHKKMKIIOJ(Transform IJKPFNCIDCJ, Entity AHNNJNFIHFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFC40", Offset = "0x5ECF040", VA = "0x185ECFC40")]
	public int GHLENKDKBHL(int JPEMHHILGGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFB70", Offset = "0x5ECEF70", VA = "0x185ECFB70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFD80", Offset = "0x5ECF180", VA = "0x185ECFD80")]
	private void GPJCKLCJOEE(int JBJJLNAIFKI = 0)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200023B")]
public struct JKEAHIHBKIG : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	public static readonly JKEAHIHBKIG DFAIJMEJABN;

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8BF0", Offset = "0x5EC7FF0", VA = "0x185EC8BF0", Slot = "4")]
	public bool Equals(LinkedEntityGroup DCLOFHDPPBE, LinkedEntityGroup JMNKJKLHIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8C10", Offset = "0x5EC8010", VA = "0x185EC8C10", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup IBBNLILJNEB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200023C")]
internal class LBNPLDBDFEI
{
	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public LBNPLDBDFEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023D")]
public struct FFIEFAIFGJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	public Entity AHNNJNFIHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000746")]
	public Entity CLBKMLECIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	public Entity KJOCICNOINI;

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x4308AE0", Offset = "0x4307EE0", VA = "0x184308AE0")]
	public FFIEFAIFGJM(Entity AHNNJNFIHFM, Entity CLBKMLECIHH, Entity KJOCICNOINI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7060", Offset = "0x5EC6460", VA = "0x185EC7060")]
	public static FFIEFAIFGJM DLNOOKJDMMJ((Entity entity, Entity oldParent, Entity newParent) LMFHIINLPOK)
	{
		return default(FFIEFAIFGJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7080", Offset = "0x5EC6480", VA = "0x185EC7080")]
	public void MJDAIICEPID([Out] Entity AHNNJNFIHFM, [Out] Entity CLBKMLECIHH, [Out] Entity KJOCICNOINI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023E")]
public struct OJKDLDANCCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	public Entity AHNNJNFIHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	public Entity DCLCDDGJKIC;

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8A30", Offset = "0x1FB7E30", VA = "0x181FB8A30")]
	public OJKDLDANCCG(Entity AHNNJNFIHFM, Entity DCLCDDGJKIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0530", Offset = "0x5ECF930", VA = "0x185ED0530")]
	public static OJKDLDANCCG DLNOOKJDMMJ((Entity entity, Entity parent) LMFHIINLPOK)
	{
		return default(OJKDLDANCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0550", Offset = "0x5ECF950", VA = "0x185ED0550")]
	public void MJDAIICEPID([Out] Entity AHNNJNFIHFM, [Out] Entity DCLCDDGJKIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023F")]
public struct ALGDFPMDPBG<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	private GCHandle EKHBDCNGFLP;

	[Cpp2IlInjected.Token(Token = "0x6000C6B")]
	[Cpp2IlInjected.Address(RVA = "0x35DD630", Offset = "0x35DCA30", VA = "0x1835DD630", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000240")]
public enum FMHHFKELPMN
{
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x400074E")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
public struct NOJABDMKHEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074F")]
	public FMHHFKELPMN AKCDJHCJKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000750")]
	public int KHDPHINBIAJ;

	[Cpp2IlInjected.Token(Token = "0x6000C6C")]
	[Cpp2IlInjected.Address(RVA = "0x962380", Offset = "0x961780", VA = "0x180962380")]
	public NOJABDMKHEO(FMHHFKELPMN AKCDJHCJKFH, int KHDPHINBIAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C6D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3950", Offset = "0x5DB2D50", VA = "0x185DB3950")]
	public static NOJABDMKHEO DLNOOKJDMMJ((FMHHFKELPMN eventType, int eventIndex) DCLOFHDPPBE)
	{
		return default(NOJABDMKHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0520", Offset = "0x5ECF920", VA = "0x185ED0520")]
	public void MJDAIICEPID([Out] FMHHFKELPMN AKCDJHCJKFH, [Out] int KHDPHINBIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
[FHOIBFDAOOA(typeof(FOAPOKJFCAL), new string[] { })]
public sealed class ABIAMMIHEDC : FOAPOKJFCAL, ENDDIKHKCDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private NGDPKGKNNBP MHGEGMPBDPC;

	[Cpp2IlInjected.Token(Token = "0x6000C6F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5410", Offset = "0x5EC4810", VA = "0x185EC5410", Slot = "5")]
	public void InitReferences(FIMDMOFKGJF MHCBJGOCOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C70")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5370", Offset = "0x5EC4770", VA = "0x185EC5370")]
	public bool KIILMPOMDOF([In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, float FECAAKMJJAF, Allocator JIIMEDFKEME, [Out] NativeArray<Entity> JIBDNODJOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C71")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public ABIAMMIHEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C72")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5370", Offset = "0x5EC4770", VA = "0x185EC5370", Slot = "4")]
	private bool BMGDCMFMHLJ([In] float3 PKOLMJEBDFI, [In] float3 DDLNIHBIJPM, float FECAAKMJJAF, Allocator JIIMEDFKEME, [Out] NativeArray<Entity> JIBDNODJOAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
public sealed class JLKANCKJGDM : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000C73")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8C70", Offset = "0x5EC8070", VA = "0x185EC8C70", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C74")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public JLKANCKJGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class HIPFKIAOEND : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000C75")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8330", Offset = "0x5EC7730", VA = "0x185EC8330", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C76")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public HIPFKIAOEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
internal class EMBEEGPDGAL : CFPNJCFEKNO
{
	[Cpp2IlInjected.Token(Token = "0x6000C77")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public EMBEEGPDGAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000246")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class OKNAJFJEBBD : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000C78")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0560", Offset = "0x5ECF960", VA = "0x185ED0560", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C79")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public OKNAJFJEBBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
internal class CEBNIMCKBLL : GOEHEFJKIEI
{
	[Cpp2IlInjected.Token(Token = "0x17000158")]
	protected override JDIKJEAMOOG AIIJBIEKCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0xA0AE30", Offset = "0xA0A230", VA = "0x180A0AE30", Slot = "17")]
		get
		{
			return default(JDIKJEAMOOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC69A0", Offset = "0x5EC5DA0", VA = "0x185EC69A0")]
	public CEBNIMCKBLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
[AGNACEIDMIN(DPJKEJCGJEB.LoadInstance)]
internal sealed class MPGGGICMBAP : EBJOJOKGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE3F0", Offset = "0x5ECD7F0", VA = "0x185ECE3F0", Slot = "15")]
	protected override ComponentSystemBase KNBJJOMOIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF250", Offset = "0x5DFE650", VA = "0x185DFF250")]
	public MPGGGICMBAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000249")]
[EAPLCJEALLA(typeof(BCKADNEGCAC))]
public sealed class LOILDAKCKLG : BDAOCABPOIC
{
	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC5C0", Offset = "0x5ECB9C0", VA = "0x185ECC5C0", Slot = "8")]
	protected override bool MMFHAPLPAMF(ReadOnlySpan<BCKADNEGCAC> PGHBEEJMEAP, ILNADNNCEJM JHHKBGNPJPD, [Out] ReadOnlySpan<byte> KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC6C0", Offset = "0x5ECBAC0", VA = "0x185ECC6C0", Slot = "9")]
	protected override bool NFCGGKJMNAI(int KAHINILDCOI, Span<BCKADNEGCAC> PGHBEEJMEAP, [In] ReadOnlySpan<byte> KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC7C0", Offset = "0x5ECBBC0", VA = "0x185ECC7C0")]
	public LOILDAKCKLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
[EAPLCJEALLA(typeof(JHKAHHLIAHN))]
public sealed class EOPBCHDAHJI : HHOEHCNNMJB
{
	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6E50", Offset = "0x5EC6250", VA = "0x185EC6E50", Slot = "8")]
	protected override bool MMFHAPLPAMF(ReadOnlySpan<JHKAHHLIAHN> PGHBEEJMEAP, ILNADNNCEJM JHHKBGNPJPD, [Out] ReadOnlySpan<byte> KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6F50", Offset = "0x5EC6350", VA = "0x185EC6F50", Slot = "9")]
	protected override bool NFCGGKJMNAI(int KAHINILDCOI, Span<JHKAHHLIAHN> PGHBEEJMEAP, [In] ReadOnlySpan<byte> KHPJJNGKJGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7050", Offset = "0x5EC6450", VA = "0x185EC7050")]
	public EOPBCHDAHJI()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200024B")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : GHHKFIIHMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x5ED10A0", Offset = "0x5ED04A0", VA = "0x185ED10A0", Slot = "6")]
		public sealed override void LHBGMEBPDNO(IOIHKDFKKJB AIBILCAOCLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0EB0", Offset = "0x5ED02B0", VA = "0x185ED0EB0", Slot = "4")]
		public sealed override void HKGCGLFIJJG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200024C")]
internal class __UnmanagedPostProcessorOutput__3833997904
{
	[Cpp2IlInjected.Token(Token = "0x6000C87")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3260", Offset = "0x5ED2660", VA = "0x185ED3260")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024D")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3833997904
{
	[Cpp2IlInjected.Token(Token = "0x6000C88")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2200", Offset = "0x5ED1600", VA = "0x185ED2200")]
	public static void HMMCOPCIPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C89")]
	[Cpp2IlInjected.Address(RVA = "0x5ED21F0", Offset = "0x5ED15F0", VA = "0x185ED21F0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024E")]
internal class NAKPAPAALHE : ContainerPropertyBag<FANNBBCPEMM>
{
	[Cpp2IlInjected.Token(Token = "0x200024F")]
	private class FHIEGGFPJGJ : Property<FANNBBCPEMM, CGNNELOIABF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public override string PDBKHDHIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8B")]
			[Cpp2IlInjected.Address(RVA = "0x5EC70E0", Offset = "0x5EC64E0", VA = "0x185EC70E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public override bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8C")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC70A0", Offset = "0x5EC64A0", VA = "0x185EC70A0")]
		public FHIEGGFPJGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CB0", Offset = "0x5D800B0", VA = "0x185D80CB0", Slot = "14")]
		public override CGNNELOIABF GetValue(FANNBBCPEMM MIPCMNILFEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x5D80CD0", Offset = "0x5D800D0", VA = "0x185D80CD0", Slot = "15")]
		public override void SetValue(FANNBBCPEMM MIPCMNILFEO, CGNNELOIABF LPCGJALKADL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE940", Offset = "0x5ECDD40", VA = "0x185ECE940")]
	public NAKPAPAALHE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000250")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0D10", Offset = "0x5ED0110", VA = "0x185ED0D10")]
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
	[Cpp2IlInjected.Token(Token = "0x6000C91")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0E30", Offset = "0x5ED0230", VA = "0x185ED0E30")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000252")]
public class FCJMKIHNMJN
{
	[Cpp2IlInjected.Token(Token = "0x6000C92")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FCJMKIHNMJN()
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
