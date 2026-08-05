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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EE0CF0", Offset = "0x2EDF2F0", VA = "0x182EE0CF0")]
		public static GBOCNFMJKOB<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(GBOCNFMJKOB<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct EILCGMDKMAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[FDPKGHKBDDG]
public static class HHHCEDIGKIL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x24BE2B0", Offset = "0x24BC8B0", VA = "0x1824BE2B0")]
	static HHHCEDIGKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E380", Offset = "0x1F5C980", VA = "0x181F5E380")]
	public static void HGBLABAFCKF<T>(T POIAHNIMHKJ, ref T GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x24BE230", Offset = "0x24BC830", VA = "0x1824BE230")]
	public static void HGBLABAFCKF(FixedString32Bytes POIAHNIMHKJ, ref string GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24BE1F0", Offset = "0x24BC7F0", VA = "0x1824BE1F0")]
	public static void HGBLABAFCKF(string POIAHNIMHKJ, ref FixedString32Bytes GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24BDE70", Offset = "0x24BC470", VA = "0x1824BDE70")]
	public static void HGBLABAFCKF(FixedString64Bytes POIAHNIMHKJ, ref string GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x24BDF90", Offset = "0x24BC590", VA = "0x1824BDF90")]
	public static void HGBLABAFCKF(string POIAHNIMHKJ, ref FixedString64Bytes GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24BE260", Offset = "0x24BC860", VA = "0x1824BE260")]
	public static void HGBLABAFCKF(LPOKHFLPIEJ POIAHNIMHKJ, ref Vector3 GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24BDDF0", Offset = "0x24BC3F0", VA = "0x1824BDDF0")]
	public static void HGBLABAFCKF(Vector3 POIAHNIMHKJ, ref LPOKHFLPIEJ GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x24BDF30", Offset = "0x24BC530", VA = "0x1824BDF30")]
	public static void HGBLABAFCKF(MHLLFPNEFOD POIAHNIMHKJ, ref Vector4 GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x24BDEA0", Offset = "0x24BC4A0", VA = "0x1824BDEA0")]
	public static void HGBLABAFCKF(Vector4 POIAHNIMHKJ, ref MHLLFPNEFOD GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24BDF30", Offset = "0x24BC530", VA = "0x1824BDF30")]
	public static void HGBLABAFCKF(MHLLFPNEFOD POIAHNIMHKJ, ref Quaternion GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24BDEA0", Offset = "0x24BC4A0", VA = "0x1824BDEA0")]
	public static void HGBLABAFCKF(Quaternion POIAHNIMHKJ, ref MHLLFPNEFOD GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24BE060", Offset = "0x24BC660", VA = "0x1824BE060")]
	public static void HGBLABAFCKF(LPOKHFLPIEJ POIAHNIMHKJ, ref float3 GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x24BDDF0", Offset = "0x24BC3F0", VA = "0x1824BDDF0")]
	public static void HGBLABAFCKF(float3 POIAHNIMHKJ, ref LPOKHFLPIEJ GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x24BE0D0", Offset = "0x24BC6D0", VA = "0x1824BE0D0")]
	public static void HGBLABAFCKF(MHLLFPNEFOD POIAHNIMHKJ, ref float4 GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x24BDEA0", Offset = "0x24BC4A0", VA = "0x1824BDEA0")]
	public static void HGBLABAFCKF(float4 POIAHNIMHKJ, ref MHLLFPNEFOD GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x24BE0D0", Offset = "0x24BC6D0", VA = "0x1824BE0D0")]
	public static void HGBLABAFCKF(MHLLFPNEFOD POIAHNIMHKJ, ref quaternion GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x24BE170", Offset = "0x24BC770", VA = "0x1824BE170")]
	public static void HGBLABAFCKF(quaternion POIAHNIMHKJ, ref MHLLFPNEFOD GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x24BE020", Offset = "0x24BC620", VA = "0x1824BE020")]
	public static void HGBLABAFCKF(Entity POIAHNIMHKJ, ref LCEINMBCAHD GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x24BDFF0", Offset = "0x24BC5F0", VA = "0x1824BDFF0")]
	public static void HGBLABAFCKF(LCEINMBCAHD POIAHNIMHKJ, ref Entity GGCKOLILJHC, LFPMKGDJPHH IMICHANCJBJ)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public SerializableGuid DAPCIOPNLKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9C97A0", Offset = "0x9C7DA0", VA = "0x1809C97A0")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x261F8B0", Offset = "0x261DEB0", VA = "0x18261F8B0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DefaultMember("Item")]
[OJJOJOKIEBL(typeof(HMNOEMALJPC), new string[] { })]
public class ODPBBADNHIJ : HMNOEMALJPC, IEnumerable<AAOPIAOGDMN>, IEnumerable, GFOPHFDOHAP, EECDFKAILMM, LPOKOJIEHOF, EMBHBGCIFNL, KJPEBAGBPMP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[LABJLBKOJHN]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[LABJLBKOJHN]
	private MKPEFGNMDIP KGHDEFAENMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private AAOPIAOGDMN[] NOPOGKAHHKA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x260BA90", Offset = "0x260A090", VA = "0x18260BA90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AAOPIAOGDMN ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x260BAA0", Offset = "0x260A0A0", VA = "0x18260BAA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "10")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x260BC90", Offset = "0x260A290", VA = "0x18260BC90", Slot = "11")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "12")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x260B960", Offset = "0x2609F60", VA = "0x18260B960", Slot = "6")]
	public AAOPIAOGDMN EGCDMNKOBNB(CNGBAJDBKGM EFINPLKEDMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x260BBC0", Offset = "0x260A1C0", VA = "0x18260BBC0", Slot = "7")]
	public BENLOGNDJHK INBAPLHOGPD(CNGBAJDBKGM EFINPLKEDMK)
	{
		return default(BENLOGNDJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x260BAE0", Offset = "0x260A0E0", VA = "0x18260BAE0", Slot = "8")]
	public IEnumerator<AAOPIAOGDMN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x260BF20", Offset = "0x260A520", VA = "0x18260BF20", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x22EC770", Offset = "0x22EAD70", VA = "0x1822EC770", Slot = "13")]
	public void ACLOJBGGCPJ<TKey, T>(CGAFBLACJDG<TKey, T> JCPKNOEICEG, [Optional] object MFPELEJLJLD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x260B820", Offset = "0x2609E20", VA = "0x18260B820", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public ODPBBADNHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x260BAA0", Offset = "0x260A0A0", VA = "0x18260BAA0")]
	[CompilerGenerated]
	private AAOPIAOGDMN GHNDGGBDKAM(int GPAKLECDLDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[OKNNJFAGDOM(typeof(KJEDAGLJFHE))]
[OJJOJOKIEBL(typeof(KKJOECNGBND), new string[] { })]
public class KJEDAGLJFHE : KKJOECNGBND, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IAMDAJKPFJC IANKKAAANME;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly IAMDAJKPFJC EPNGOECAEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KDGOMGPPJAN KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CFANJNBMIIA CAEMHEKKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DEMCMMGHLIH PFGMPLPGGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EKOLMNJLLEE GAGKLMFDGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private LKEACJPELBE NNKCFAHPEMD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private EntityManager PHHGGAMLDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2AED360", Offset = "0x2AEB960", VA = "0x182AED360")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF3C0", Offset = "0x2AED9C0", VA = "0x182AEF3C0", Slot = "34")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEA80", Offset = "0x2AED080", VA = "0x182AEEA80", Slot = "35")]
	public bool ELLJKDEAPPH(Transform DMECJMCKFAG, out ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0240", Offset = "0x2AEE840", VA = "0x182AF0240", Slot = "36")]
	public Transform KKNCEBIEIHE(Entity MPAGCMNFGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2AED3D0", Offset = "0x2AEB9D0", VA = "0x182AED3D0", Slot = "31")]
	public bool AMJHHOCDEFA(Entity MPAGCMNFGMI, out Transform DMECJMCKFAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2AED3B0", Offset = "0x2AEB9B0", VA = "0x182AED3B0")]
	private void AJLAHGBGHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDE20", Offset = "0x2AEC420", VA = "0x182AEDE20", Slot = "30")]
	public void DANGMACAEMN(Entity MPAGCMNFGMI, out float4x4 BHECBPBIBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2AED4D0", Offset = "0x2AEBAD0", VA = "0x182AED4D0", Slot = "4")]
	public void ANAHIJBHGGK(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0BC0", Offset = "0x2AEF1C0", VA = "0x182AF0BC0", Slot = "28")]
	public void LJIIGANLFDN(Entity MPAGCMNFGMI, out float4x4 BHECBPBIBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDB30", Offset = "0x2AEC130", VA = "0x182AEDB30")]
	public void BMFCDBMEJMK(Entity MPAGCMNFGMI, in float4x4 BHECBPBIBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2AED220", Offset = "0x2AEB820", VA = "0x182AED220")]
	public void AEMJAJFBJEJ(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE7A0", Offset = "0x2AECDA0", VA = "0x182AEE7A0", Slot = "6")]
	public float3 ECIGICCJJFE(Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2AED7C0", Offset = "0x2AEBDC0", VA = "0x182AED7C0")]
	public void BDAGEKPJKOA(Entity MPAGCMNFGMI, in quaternion MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFFA0", Offset = "0x2AEE5A0", VA = "0x182AEFFA0", Slot = "8")]
	public quaternion JOKMHACHIMP(Entity MPAGCMNFGMI)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF0B0", Offset = "0x2AED6B0", VA = "0x182AEF0B0")]
	public void LNEBKPMEOIB(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0D50", Offset = "0x2AEF350", VA = "0x182AF0D50", Slot = "12")]
	public float3 LPOOPMBABGF(Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEFC0", Offset = "0x2AED5C0", VA = "0x182AEEFC0", Slot = "15")]
	public float FGGMJPNJDEC(Entity MPAGCMNFGMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0300", Offset = "0x2AEE900", VA = "0x182AF0300", Slot = "14")]
	public void KLEIDPCLBMA(Entity MPAGCMNFGMI, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF1F0", Offset = "0x2AED7F0", VA = "0x182AEF1F0", Slot = "17")]
	public float3 GFEPOBPFOMH(Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2AED990", Offset = "0x2AEBF90", VA = "0x182AED990")]
	public void GANOCGGJLOD(Entity MPAGCMNFGMI, in float3 ENMMMLINDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF5F0", Offset = "0x2AEDBF0", VA = "0x182AEF5F0", Slot = "9")]
	public void JHGHBHCJHAO(Entity MPAGCMNFGMI, out float3 POOFJFBIOJJ, out quaternion MEHKCJCIOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF810", Offset = "0x2AEDE10", VA = "0x182AEF810", Slot = "10")]
	public void JHGHBHCJHAO(Entity MPAGCMNFGMI, out RigidTransform HODCICPOGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE2D0", Offset = "0x2AEC8D0", VA = "0x182AEE2D0", Slot = "37")]
	public void DKNFMLLPKMA(Entity MPAGCMNFGMI, out float3 POOFJFBIOJJ, out quaternion MEHKCJCIOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE150", Offset = "0x2AEC750", VA = "0x182AEE150", Slot = "11")]
	public void DKNFMLLPKMA(Entity MPAGCMNFGMI, out RigidTransform HODCICPOGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE010", Offset = "0x2AEC610", VA = "0x182AEE010")]
	public void PHDDEJKAPNO(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE670", Offset = "0x2AECC70", VA = "0x182AEE670", Slot = "19")]
	public float3 ECBAFEIAPBC(Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDEE0", Offset = "0x2AEC4E0", VA = "0x182AEDEE0")]
	public void DCGBGKJKHLA(Entity MPAGCMNFGMI, in quaternion MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF4D0", Offset = "0x2AEDAD0", VA = "0x182AEF4D0", Slot = "21")]
	public quaternion JEEIFJCJBAI(Entity MPAGCMNFGMI)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE450", Offset = "0x2AECA50", VA = "0x182AEE450")]
	public void DOHKANKFLDI(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2AF11A0", Offset = "0x2AEF7A0", VA = "0x182AF11A0", Slot = "22")]
	public float3 ONEALIHAOMC(Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEC60", Offset = "0x2AED260", VA = "0x182AEEC60", Slot = "24")]
	public void FBEJDKOBJAB(Entity MPAGCMNFGMI, float HBIJEGODDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE990", Offset = "0x2AECF90", VA = "0x182AEE990", Slot = "25")]
	public float EEBLBDOBPKP(Entity MPAGCMNFGMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0880", Offset = "0x2AEEE80", VA = "0x182AF0880")]
	public void LBPPCPGFOCB(Entity MPAGCMNFGMI, in float3 IJJFGJAFMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2AF06C0", Offset = "0x2AEECC0", VA = "0x182AF06C0", Slot = "27")]
	public float3 KOBDNGABLMF(Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFA30", Offset = "0x2AEE030", VA = "0x182AEFA30", Slot = "32")]
	public void JNKIHMPDDHF(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0160", Offset = "0x2AEE760", VA = "0x182AF0160")]
	private ENMPPPDAMHN KAIGDEIPKMA(Transform DMECJMCKFAG)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0F30", Offset = "0x2AEF530", VA = "0x182AF0F30")]
	private static TransformEntity OHBMPIFNPLC(BLIAAMDKPNO KLGGKKGCLHM, GameObject LFMEKIMOADD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xF39BA0", Offset = "0xF381A0", VA = "0x180F39BA0")]
	private static T NCGIAJEKICI<T>(GameObject LFMEKIMOADD) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEEA0", Offset = "0x2AED4A0", VA = "0x182AEEEA0", Slot = "33")]
	public void FFPMMBHCKDC(Entity MPAGCMNFGMI, Entity ELDCHLKBIGE, Entity EPBIFMJLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public KJEDAGLJFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2AED220", Offset = "0x2AEB820", VA = "0x182AED220", Slot = "5")]
	private void GCLHAJGMCAG(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2AF04F0", Offset = "0x2AEEAF0", VA = "0x182AF04F0", Slot = "7")]
	private void KNMIGNBMLMD(Entity MPAGCMNFGMI, in quaternion MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF0B0", Offset = "0x2AED6B0", VA = "0x182AEF0B0", Slot = "13")]
	private void FHAGPPPAIJG(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2AED990", Offset = "0x2AEBF90", VA = "0x182AED990", Slot = "16")]
	private void BIDJJHAEOJD(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE010", Offset = "0x2AEC610", VA = "0x182AEE010", Slot = "18")]
	private void DKEHHGHOLIP(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDEE0", Offset = "0x2AEC4E0", VA = "0x182AEDEE0", Slot = "20")]
	private void GFBOEAKCCPJ(Entity MPAGCMNFGMI, in quaternion MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0F20", Offset = "0x2AEF520", VA = "0x182AF0F20", Slot = "23")]
	private void NLCLDFBIANI(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDE10", Offset = "0x2AEC410", VA = "0x182AEDE10", Slot = "26")]
	private void CKHNDBPAJCC(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0D40", Offset = "0x2AEF340", VA = "0x182AF0D40", Slot = "29")]
	private void LKOCLBEOBMM(Entity MPAGCMNFGMI, in float4x4 CNKALCHPDKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OFICMABAFAE
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CIEBLHNDGFH : BMPAEHPFBCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string DBAADELPMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly CIEBLHNDGFH LHOJKOPNLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly List<CIEBLHNDGFH> AONMIKJBPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly List<GCPINDOJNBO> EGDOOPNCMJB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string LDGOGEKFNPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BMPAEHPFBCF EMOIDKCIIFO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<BMPAEHPFBCF> MOAFIMFFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27D1E70", Offset = "0x27D0470", VA = "0x1827D1E70")]
	public CIEBLHNDGFH(string ECMAPGHKHFB, CIEBLHNDGFH HDBBNLFBJKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
[OJJOJOKIEBL(typeof(EOMEEBLCJPE), new string[] { })]
internal class EOMEEBLCJPE : EECDFKAILMM
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24A1CD0", Offset = "0x24A02D0", VA = "0x1824A1CD0", Slot = "4")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public EOMEEBLCJPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[OJJOJOKIEBL(typeof(MGCDDMFMGJA), new string[] { })]
public class GMCAEDCDMFJ : LPOKOJIEHOF, MGCDDMFMGJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NAKDAPLIPPO AGBLOKPGLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private HGMEOKAAKKA GEMLEDKAAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24B9340", Offset = "0x24B7940", VA = "0x1824B9340", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x24B9140", Offset = "0x24B7740", VA = "0x1824B9140", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24B9000", Offset = "0x24B7600", VA = "0x1824B9000", Slot = "5")]
	public bool AAHFEBKDDMN(ENMPPPDAMHN HMLJKOHAJKN, out Collider HCHCJABNKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x24B9150", Offset = "0x24B7750", VA = "0x1824B9150", Slot = "6")]
	public GameObject HPPKJCCGKMI(ENMPPPDAMHN LPAMBDOOHKM, GameObject ONHJAKOALON, Vector3 IPKLBGKEJKA, Quaternion EOGEEAFFCFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x24B9410", Offset = "0x24B7A10", VA = "0x1824B9410", Slot = "7")]
	public void JKFMGDBJMBP(GameObject HCHCJABNKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B41A50", Offset = "0x2B40050", VA = "0x182B41A50", Slot = "8")]
	public TCollider IKBLOAHDMFN<TCollider>(GameObject OLCMLKKFBEP) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x24B9510", Offset = "0x24B7B10", VA = "0x1824B9510", Slot = "9")]
	public void KCEJLACONPF(Collider HCHCJABNKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B41A50", Offset = "0x2B40050", VA = "0x182B41A50", Slot = "10")]
	public GameObject JOMPJOOIBMD<TCollider>(string ECMAPGHKHFB) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public GMCAEDCDMFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GPGPAHPANIB
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class DEECNKLJPLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeList<JKEHBJKPGBK> MEFOJFKCNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NativeList<GDJICEPBCLA> EIFHBGOHIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private NativeList<GPLDEABEJMM> FPABDGAHNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NativeList<GDJICEPBCLA> DPGPMIMBLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NativeList<JKEHBJKPGBK> MDJKNKMOIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x90BEC0", Offset = "0x90A4C0", VA = "0x18090BEC0")]
		get
		{
			return default(NativeList<JKEHBJKPGBK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NativeList<GDJICEPBCLA> NBPBLJOPAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9358D0", Offset = "0x933ED0", VA = "0x1809358D0")]
		get
		{
			return default(NativeList<GDJICEPBCLA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<GPLDEABEJMM> EPKLDANHOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xCEA020", Offset = "0xCE8620", VA = "0x180CEA020")]
		get
		{
			return default(NativeList<GPLDEABEJMM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NativeList<GDJICEPBCLA> ONDLLGEKBME
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9358F0", Offset = "0x933EF0", VA = "0x1809358F0")]
		get
		{
			return default(NativeList<GDJICEPBCLA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JobHandle FGFOHCMBCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xB9C0F0", Offset = "0xB9A6F0", VA = "0x180B9C0F0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xE38600", Offset = "0xE36C00", VA = "0x180E38600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool OEAAKDCPNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x27D6B80", Offset = "0x27D5180", VA = "0x1827D6B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x27D7150", Offset = "0x27D5750", VA = "0x1827D7150")]
	public DEECNKLJPLJ(Allocator HINEEPDGLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x27D6D70", Offset = "0x27D5370", VA = "0x1827D6D70")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27D6C40", Offset = "0x27D5240", VA = "0x1827D6C40")]
	public void CDAHFAFMGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x27D6E00", Offset = "0x27D5400", VA = "0x1827D6E00")]
	public void PDDBDHJNBOH(Entity MPAGCMNFGMI, Entity ELDCHLKBIGE, Entity EPBIFMJLJFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class PFEBIHCJINM : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2610CE0", Offset = "0x260F2E0", VA = "0x182610CE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2610D80", Offset = "0x260F380", VA = "0x182610D80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public PFEBIHCJINM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AIBFCFMKILK(AGPDIMMFKMP.OMRoom)]
internal class PLFKOPCKLPL : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private MBKAKKEBAGC ICBHCLKGJNH;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2611CF0", Offset = "0x26102F0", VA = "0x182611CF0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2611D40", Offset = "0x2610340", VA = "0x182611D40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public PLFKOPCKLPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JNOCGLFOMAK
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IFKHJNODEDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class FGPMDBHKJKH<T> : JDBPLBJBOMG<T>, CGAFBLACJDG<EEKJFDFIEGN, T>, ELEHKEJLDOI<EEKJFDFIEGN>, DPMGHPGKEOP, IDisposable, AAOPIAOGDMN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly ELEHKEJLDOI<Entity> JCPKNOEICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Delegate ABBOCJPHDAE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x50B6CF0", Offset = "0x50B52F0", VA = "0x1850B6CF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type BJFLOLKBEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x50B89F0", Offset = "0x50B6FF0", VA = "0x1850B89F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public ELBEJOMIKKE BPNKBLLBHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x50B5790", Offset = "0x50B3D90", VA = "0x1850B5790", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DACJLJGFJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x50B6000", Offset = "0x50B4600", VA = "0x1850B6000", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GFLOPFFPDHK KEMBFLMAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x50B5F10", Offset = "0x50B4510", VA = "0x1850B5F10", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OOHBGLFCNLM<EEKJFDFIEGN> NBFJOBLBGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x50B6DF0", Offset = "0x50B53F0", VA = "0x1850B6DF0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x50B8650", Offset = "0x50B6C50", VA = "0x1850B8650", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2277860", Offset = "0x2275E60", VA = "0x182277860")]
	public FGPMDBHKJKH(ELEHKEJLDOI<Entity> JCPKNOEICEG, JBBANOPACMB OKJDHECIFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x50B8970", Offset = "0x50B6F70", VA = "0x1850B8970")]
	private Entity NIOOODEFKMO(EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x391BB80", Offset = "0x391A180", VA = "0x18391BB80")]
	private EEKJFDFIEGN NIOOODEFKMO(Entity MPAGCMNFGMI)
	{
		return default(EEKJFDFIEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x50B82D0", Offset = "0x50B68D0", VA = "0x1850B82D0", Slot = "4")]
	public T MBNHJLNEIKL(EEKJFDFIEGN HGGMFNJGHIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x50B6110", Offset = "0x50B4710", VA = "0x1850B6110")]
	public bool FGMAFKALEHD(EEKJFDFIEGN HGGMFNJGHIP, in T KIFJIAOCCHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x50B56B0", Offset = "0x50B3CB0", VA = "0x1850B56B0", Slot = "7")]
	public bool AFPHGIBLJIN(EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50B7CD0", Offset = "0x50B62D0", VA = "0x1850B7CD0", Slot = "8")]
	public void MBNHJLNEIKL(EEKJFDFIEGN HGGMFNJGHIP, CIACNBAJNFM MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x50B60A0", Offset = "0x50B46A0", VA = "0x1850B60A0", Slot = "9")]
	public bool FGMAFKALEHD(EEKJFDFIEGN HGGMFNJGHIP, NGKHEJGAHGD KIFJIAOCCHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2275C20", Offset = "0x2274220", VA = "0x182275C20", Slot = "16")]
	public void IBBEGLBGAJD(KJPEBAGBPMP MIBBABDJMFM, [Optional] object MFPELEJLJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x50B87B0", Offset = "0x50B6DB0", VA = "0x1850B87B0", Slot = "10")]
	public bool MOAONFLIEIF(EEKJFDFIEGN GGCKOLILJHC, EEKJFDFIEGN POIAHNIMHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3915910", Offset = "0x3913F10", VA = "0x183915910", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x50B8CF0", Offset = "0x50B72F0", VA = "0x1850B8CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x50B5830", Offset = "0x50B3E30", VA = "0x1850B5830")]
	private void ANOBDMNCICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x50B6810", Offset = "0x50B4E10", VA = "0x1850B6810")]
	private void IHOLHNOFLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x50B6F50", Offset = "0x50B5550", VA = "0x1850B6F50")]
	private void KLOOKBOPLCB(Entity MPAGCMNFGMI, in NGKHEJGAHGD MDNKPPKLBGD, in NGKHEJGAHGD KIFJIAOCCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x50B8BB0", Offset = "0x50B71B0", VA = "0x1850B8BB0")]
	private void PAEJCCBAFDL(Entity MPAGCMNFGMI, in NGKHEJGAHGD MDNKPPKLBGD, in NGKHEJGAHGD KIFJIAOCCHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class NFGJPAFAJEK : OFHJMNAOPCE
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B6D0", Offset = "0x2A89CD0", VA = "0x182A8B6D0", Slot = "5")]
	public override Action AKNEMOCDEEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void DEIMMPHOICK<T>() where T : HLLDBJJMAKE;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B760", Offset = "0x2A89D60", VA = "0x182A8B760")]
	[UnityEngine.Scripting.Preserve]
	public void NNBIMJFEELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B7F0", Offset = "0x2A89DF0", VA = "0x182A8B7F0")]
	protected NFGJPAFAJEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[OJJOJOKIEBL(typeof(CDONNANOMBA), new string[] { })]
public class NHANFLFOONO : LPOKOJIEHOF, CDONNANOMBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A8BC50", Offset = "0x2A8A250", VA = "0x182A8BC50", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A8BBE0", Offset = "0x2A8A1E0", VA = "0x182A8BBE0", Slot = "5")]
	public void FAFNIIMAHPO(ENMPPPDAMHN GIAMACBDIFH, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x20AEFF0", Offset = "0x20AD5F0", VA = "0x1820AEFF0")]
	private void FGMAFKALEHD<T>(ENMPPPDAMHN GIAMACBDIFH, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public NHANFLFOONO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[OJJOJOKIEBL(typeof(BDMBICNIMIJ), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public class BDMBICNIMIJ : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class MACGGKEJIHE : IEnumerable<NBAPNPGIPAA>, IEnumerable, IEnumerator<NBAPNPGIPAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NBAPNPGIPAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NativeArray<Entity> <>3__entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public BDMBICNIMIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private EntityManager <entityManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeArray<Entity>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Entity <entity>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private NLEMIJLGCLO <rbex>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private NBAPNPGIPAA System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x97B9F0", Offset = "0x979FF0", VA = "0x18097B9F0")]
		[DebuggerHidden]
		public MACGGKEJIHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x28F9D40", Offset = "0x28F8340", VA = "0x1828F9D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x28F9A40", Offset = "0x28F8040", VA = "0x1828F9A40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x28F99F0", Offset = "0x28F7FF0", VA = "0x1828F99F0")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x28F9D00", Offset = "0x28F8300", VA = "0x1828F9D00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x28F9C50", Offset = "0x28F8250", VA = "0x1828F9C50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NBAPNPGIPAA> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x28F9C50", Offset = "0x28F8250", VA = "0x1828F9C50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> KIKKAIPMLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x27C49F0", Offset = "0x27C2FF0", VA = "0x1827C49F0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x27C4030", Offset = "0x27C2630", VA = "0x1827C4030")]
	public void AIGIKCJKFCD(NativeArray<Entity> NCEOACJJMCN, bool FGFCIGHBGMG, bool GBFFHMOOEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x27C4A40", Offset = "0x27C3040", VA = "0x1827C4A40")]
	public void JGIGHJNAHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x27C4340", Offset = "0x27C2940", VA = "0x1827C4340")]
	private void GMCEMCHBEIB(NativeArray<Entity> NCEOACJJMCN, bool FGFCIGHBGMG, bool GBFFHMOOEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x27C4150", Offset = "0x27C2750", VA = "0x1827C4150")]
	[IteratorStateMachine(typeof(MACGGKEJIHE))]
	private IEnumerable<NBAPNPGIPAA> AKNOLAMGPIB(NativeArray<Entity> NCEOACJJMCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x27C41E0", Offset = "0x27C27E0", VA = "0x1827C41E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x27C4D00", Offset = "0x27C3300", VA = "0x1827C4D00")]
	public BDMBICNIMIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
[OJJOJOKIEBL(typeof(FBCFPEGCOHB), new string[] { })]
public class FBCFPEGCOHB : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<NativeListAsync<BMMBGICDGOH>> MIHPPCEFACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x24A3D30", Offset = "0x24A2330", VA = "0x1824A3D30", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x24A3B60", Offset = "0x24A2160", VA = "0x1824A3B60")]
	public void AIGIKCJKFCD(NativeListAsync<BMMBGICDGOH> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x24A3D80", Offset = "0x24A2380", VA = "0x1824A3D80")]
	public void JGIGHJNAHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x24A3BD0", Offset = "0x24A21D0", VA = "0x1824A3BD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x24A4210", Offset = "0x24A2810", VA = "0x1824A4210")]
	public FBCFPEGCOHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class PDKACIEMFHN
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly ProfilerMarker GMKCCDKGBBK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly ProfilerMarker MHDLNKINJHE;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2610630", Offset = "0x260EC30", VA = "0x182610630")]
	public static void LDMPECOOOEM(this PLONEGJPBHK CBMJEICKDDL, MJBNKJMPJPB EJBKGMJFFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2610480", Offset = "0x260EA80", VA = "0x182610480")]
	public static void JKKIBGCEOKK(this PLONEGJPBHK CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2610280", Offset = "0x260E880", VA = "0x182610280")]
	private static string[] ALNLKPJDNHF(MJBNKJMPJPB EJBKGMJFFOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2610A20", Offset = "0x260F020", VA = "0x182610A20")]
	private static bool MDAOACNFLEA(MJBNKJMPJPB EJBKGMJFFOC, out string[] ACMBOBECMME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x928C00", Offset = "0x927200", VA = "0x180928C00")]
	private static bool JFLIBPOGGGE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[OJJOJOKIEBL(typeof(JBBANOPACMB), new string[] { })]
public class LGLEOEBGPLJ : LPOKOJIEHOF, JBBANOPACMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly IAMDAJKPFJC DPONDMBFBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[LABJLBKOJHN]
	private KGPIAKEFEHB NPKGKGEPBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[LABJLBKOJHN]
	private MCCOHLNACPH NMLCLDDPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[LABJLBKOJHN]
	private LKEACJPELBE NNKCFAHPEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[LABJLBKOJHN]
	private JMGAPHGFIPO LKGDMEFDKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[LABJLBKOJHN]
	private GEMKDFICLBK KGLOBJOCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private FNLKBDOKFGP PGINAOKHABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private LDONCAMGPOJ BLBDABPHPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public PHGPCEHAGAA CCFABJCJIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA2D310", Offset = "0xA2B910", VA = "0x180A2D310", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(PHGPCEHAGAA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA2BAA0", Offset = "0xA2A0A0", VA = "0x180A2BAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<KIHFNANBKDD, NativeArray<BLIAAMDKPNO>> EIBMMCALJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A78FA0", Offset = "0x2A775A0", VA = "0x182A78FA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A79AC0", Offset = "0x2A780C0", VA = "0x182A79AC0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<KIHFNANBKDD> JOCBHBNJMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A79C60", Offset = "0x2A78260", VA = "0x182A79C60", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A77DA0", Offset = "0x2A763A0", VA = "0x182A77DA0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A791E0", Offset = "0x2A777E0", VA = "0x182A791E0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A784A0", Offset = "0x2A76AA0", VA = "0x182A784A0", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A79D00", Offset = "0x2A78300", VA = "0x182A79D00")]
	private void PACJHCGEIAD(KIHFNANBKDD BFIMLFNBNGO, NativeArray<BLIAAMDKPNO> EBCEGDCHNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A79B60", Offset = "0x2A78160", VA = "0x182A79B60")]
	private void MOLMKOOLHGF(KIHFNANBKDD BFIMLFNBNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A794E0", Offset = "0x2A77AE0", VA = "0x182A794E0")]
	internal ENMPPPDAMHN JACBKPHDPNI(Entity MPAGCMNFGMI)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A79530", Offset = "0x2A77B30", VA = "0x182A79530", Slot = "11")]
	public DLBKPAILIEM LGLNCHECMNH(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(DLBKPAILIEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A786C0", Offset = "0x2A76CC0", VA = "0x182A786C0", Slot = "12")]
	public BLIAAMDKPNO EBNGCMIBIEG(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(BLIAAMDKPNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A77B80", Offset = "0x2A76180", VA = "0x182A77B80", Slot = "39")]
	public bool AFPHGIBLJIN(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A78940", Offset = "0x2A76F40", VA = "0x182A78940", Slot = "34")]
	public void ENNCOPBPMIP(KIHFNANBKDD LNIELCFLEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A77B20", Offset = "0x2A76120", VA = "0x182A77B20", Slot = "35")]
	public void AFFJDJOCMDN(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A77AB0", Offset = "0x2A760B0", VA = "0x182A77AB0", Slot = "36")]
	public void AEEAPLHBKLI(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A78B40", Offset = "0x2A77140", VA = "0x182A78B40", Slot = "37")]
	public void ENNCOPBPMIP(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A78C70", Offset = "0x2A77270", VA = "0x182A78C70", Slot = "24")]
	public KIHFNANBKDD FBGOFHNIPBN(NativeArray<EEKJFDFIEGN> HGGMFNJGHIP, Allocator HINEEPDGLPG)
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A797E0", Offset = "0x2A77DE0", VA = "0x182A797E0", Slot = "25")]
	public KIHFNANBKDD LJAELKGMCMD(NativeArray<EEKJFDFIEGN> HGGMFNJGHIP, NativeArray<FNDBMHENIMP> HNMKHJBPNJK, Allocator HINEEPDGLPG)
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A78830", Offset = "0x2A76E30", VA = "0x182A78830", Slot = "26")]
	public NILFLMGAFIC EGMBMOKGKKD(BLIAAMDKPNO POJMFCODLHG, bool JFCBHFIDNFJ)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2A78750", Offset = "0x2A76D50", VA = "0x182A78750", Slot = "27")]
	public NILFLMGAFIC EGMBMOKGKKD(BLIAAMDKPNO POJMFCODLHG)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A78EC0", Offset = "0x2A774C0", VA = "0x182A78EC0", Slot = "28")]
	public NILFLMGAFIC GEOAAGIPFLI(BLIAAMDKPNO POJMFCODLHG)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A79930", Offset = "0x2A77F30", VA = "0x182A79930", Slot = "29")]
	public NILFLMGAFIC LMGLKFKGBGA(BLIAAMDKPNO POJMFCODLHG)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A79570", Offset = "0x2A77B70", VA = "0x182A79570", Slot = "30")]
	public NILFLMGAFIC LJAELKGMCMD(EEKJFDFIEGN HGGMFNJGHIP, BLIAAMDKPNO POJMFCODLHG)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A77EA0", Offset = "0x2A764A0", VA = "0x182A77EA0", Slot = "31")]
	public AMCLHOADFGH CEGCFDKFBOF()
	{
		return default(AMCLHOADFGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A783B0", Offset = "0x2A769B0", VA = "0x182A783B0", Slot = "32")]
	public CJNJIJCNICA DKAGGLAKDJP()
	{
		return default(CJNJIJCNICA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A790E0", Offset = "0x2A776E0", VA = "0x182A790E0", Slot = "33")]
	public LILNNJOPOJO IIJCEINICFO(IFEBDPAFELD KLGGKKGCLHM)
	{
		return default(LILNNJOPOJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A79AA0", Offset = "0x2A780A0", VA = "0x182A79AA0", Slot = "13")]
	public void MBACIJOLGCB(EEKJFDFIEGN HGGMFNJGHIP, FCLHKJAHMCN PDIAKCKMCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A781D0", Offset = "0x2A767D0", VA = "0x182A781D0", Slot = "14")]
	public NILFLMGAFIC DDIJEPCNDPH(ENMPPPDAMHN HMLJKOHAJKN, [Optional] object DCEGGIJLHGI)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A77C20", Offset = "0x2A76220", VA = "0x182A77C20", Slot = "15")]
	public bool AHHLAGNLFJP(ENMPPPDAMHN HMLJKOHAJKN, out FCLHKJAHMCN NKONLKNLFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A77D00", Offset = "0x2A76300", VA = "0x182A77D00", Slot = "16")]
	public bool AMJHHOCDEFA(ENMPPPDAMHN HMLJKOHAJKN, out Transform DMECJMCKFAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A79040", Offset = "0x2A77640", VA = "0x182A79040", Slot = "17")]
	public bool IDOBKJNCGOE(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A78140", Offset = "0x2A76740", VA = "0x182A78140", Slot = "18")]
	public void DDFNBOCHOND(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A780B0", Offset = "0x2A766B0", VA = "0x182A780B0", Slot = "19")]
	public bool CKFCPFNJLCG(LocalId HMLJKOHAJKN, object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A79D80", Offset = "0x2A78380", VA = "0x182A79D80", Slot = "20")]
	public bool PHKIGIFCEFF(LocalId HMLJKOHAJKN, object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A77E40", Offset = "0x2A76440", VA = "0x182A77E40", Slot = "38")]
	public KIHFNANBKDD BKAFCMHHBBL(KIHFNANBKDD BEDADBBGMAL, Allocator HINEEPDGLPG)
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A77FB0", Offset = "0x2A765B0", VA = "0x182A77FB0", Slot = "23")]
	public EEKJFDFIEGN CFEAEMLGJDL(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(EEKJFDFIEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A78DE0", Offset = "0x2A773E0", VA = "0x182A78DE0", Slot = "21")]
	public ENMPPPDAMHN FBGOFHNIPBN(EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A78920", Offset = "0x2A76F20", VA = "0x182A78920", Slot = "22")]
	public bool ELLJKDEAPPH(EEKJFDFIEGN HGGMFNJGHIP, out ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A79BD0", Offset = "0x2A781D0", VA = "0x182A79BD0")]
	private void ODPKMGICBCE(BLIAAMDKPNO CJCKMIMPOLC, ENMPPPDAMHN HMLJKOHAJKN, EEKJFDFIEGN HGGMFNJGHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public LGLEOEBGPLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OJJOJOKIEBL(typeof(GDPCNPLLJEI), new string[] { })]
public class BMBGOLPJGHC : LPOKOJIEHOF, GDPCNPLLJEI
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[LABJLBKOJHN]
	private KIMCOPEIFEL JBAGHABAFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[LABJLBKOJHN]
	private PPKCEEEDIDM MHIIEIDIAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[LABJLBKOJHN]
	private JFAJDFHGGNE BJJCIGGCOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[LABJLBKOJHN]
	private EKOLMNJLLEE NDCKHGGLFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[LABJLBKOJHN]
	private PGEMPCHAFFA PCCLEKIMKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private World MBCLAANGHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private IBHJNJDCKDB PHEEFCNLDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private IBHJNJDCKDB KEGJNGKDPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IBHJNJDCKDB KJBKIDAFGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private IBHJNJDCKDB PJFBDFINGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private IBHJNJDCKDB MFBACDHLHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private IBHJNJDCKDB COKENMBKIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private IBHJNJDCKDB BFFIBKJGKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private IBHJNJDCKDB BDLMJMNGKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private IBHJNJDCKDB JEGGCINHGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private IBHJNJDCKDB FBCFBANJFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private IBHJNJDCKDB KBNFPCPGEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private IBHJNJDCKDB AEBAJOAGALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private IBHJNJDCKDB HLJCPHOFEHJ;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool EDLCAPFNFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x27C9520", Offset = "0x27C7B20", VA = "0x1827C9520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool FKHCNLONENK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x27C9780", Offset = "0x27C7D80", VA = "0x1827C9780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool NGLKPJCIIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x27C9520", Offset = "0x27C7B20", VA = "0x1827C9520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool PAECHOHEGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x27C9520", Offset = "0x27C7B20", VA = "0x1827C9520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x27C9B60", Offset = "0x27C8160", VA = "0x1827C9B60", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x359D720", Offset = "0x359BD20", VA = "0x18359D720")]
	private IBHJNJDCKDB AMDBIEEGCPG<T>() where T : PIPKMIGGODP
	{
		return default(IBHJNJDCKDB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x27C9590", Offset = "0x27C7B90", VA = "0x1827C9590")]
	private IBHJNJDCKDB AMDBIEEGCPG(Type KLGGKKGCLHM)
	{
		return default(IBHJNJDCKDB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x27C95C0", Offset = "0x27C7BC0", VA = "0x1827C95C0", Slot = "14")]
	public void CLMNAHDIDKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x27C9830", Offset = "0x27C7E30", VA = "0x1827C9830", Slot = "15")]
	public void HOAMAEIIDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x27C9F60", Offset = "0x27C8560", VA = "0x1827C9F60", Slot = "5")]
	public void JHGPEIDMJCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x27C9FA0", Offset = "0x27C85A0", VA = "0x1827C9FA0", Slot = "6")]
	public void LHNHKGEGIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x27C96C0", Offset = "0x27C7CC0", VA = "0x1827C96C0", Slot = "7")]
	public void ECOENIEIAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x27C9700", Offset = "0x27C7D00", VA = "0x1827C9700", Slot = "8")]
	public void FLGNBPKPHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x27C9B20", Offset = "0x27C8120", VA = "0x1827C9B20", Slot = "9")]
	public void IIJLMLEFHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x27CA020", Offset = "0x27C8620", VA = "0x1827CA020", Slot = "10")]
	public void PGFLNLPFLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x27C9FE0", Offset = "0x27C85E0", VA = "0x1827C9FE0", Slot = "11")]
	public void OCCCPIBAAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x27C9740", Offset = "0x27C7D40", VA = "0x1827C9740", Slot = "12")]
	public void HILAIJLKACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x27C98B0", Offset = "0x27C7EB0", VA = "0x1827C98B0", Slot = "13")]
	public void IDBHAABNBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x27C9AA0", Offset = "0x27C80A0", VA = "0x1827C9AA0")]
	private void IHPCMKPIFLF(IBHJNJDCKDB CPDLEGJAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x27C9640", Offset = "0x27C7C40", VA = "0x1827C9640")]
	private void CPEFODMHCLI(IBHJNJDCKDB CPDLEGJAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x27C9F80", Offset = "0x27C8580", VA = "0x1827C9F80")]
	private void KAHGAFNKOCI(IBHJNJDCKDB CPDLEGJAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BMBGOLPJGHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
[OJJOJOKIEBL(typeof(ELKDKDDOJGN), new string[] { "Editor" })]
public sealed class ELKDKDDOJGN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void MDEJCEGEIDC(EEKJFDFIEGN OOIPPLLNGHO, FNDBMHENIMP JAIGDBINGHO, bool DNMDLMDFDPD);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void CJEBLFNENED(EEKJFDFIEGN OOIPPLLNGHO, bool DNMDLMDFDPD);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void JJNDJJEKDAD(EEKJFDFIEGN OOIPPLLNGHO, BENLOGNDJHK JCPKNOEICEG, in NGKHEJGAHGD MOLEJFDINLH, bool DNMDLMDFDPD);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public ELKDKDDOJGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[OJJOJOKIEBL(typeof(global::KPIICLIMLAK), new string[] { })]
internal class NKEOFAOPBGA : global::KPIICLIMLAK, LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[LABJLBKOJHN]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[LABJLBKOJHN]
	private DEMCMMGHLIH PFGMPLPGGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[LABJLBKOJHN]
	private MBOAMGKJHBK EGDOOPNCMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[LABJLBKOJHN]
	private JJPMDANOJAP FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Action<AMICGDPKLIC> AJNAMFOHMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private FEHHJLHONFC<Entity> HDBBNLFBJKG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<AMICGDPKLIC> LNFJLNBDNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CE50", Offset = "0x2A8B450", VA = "0x182A8CE50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CD10", Offset = "0x2A8B310", VA = "0x182A8CD10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D030", Offset = "0x2A8B630", VA = "0x182A8D030", Slot = "6")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CBA0", Offset = "0x2A8B1A0", VA = "0x182A8CBA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CE50", Offset = "0x2A8B450", VA = "0x182A8CE50")]
	private void LGCGEMJEFNN(Action<AMICGDPKLIC> MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CD10", Offset = "0x2A8B310", VA = "0x182A8CD10")]
	private void EBJHJEFIFBG(Action<AMICGDPKLIC> MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CF90", Offset = "0x2A8B590", VA = "0x182A8CF90")]
	private void GECEMKDOMNA(HPCDDCJODHI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public NKEOFAOPBGA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CENMPPBCCCD : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	public void OnCreate(ref SystemState ILFDGGGKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
	public void OnDestroy(ref SystemState ILFDGGGKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x27D0C40", Offset = "0x27CF240", VA = "0x1827D0C40", Slot = "6")]
	public void OnUpdate(ref SystemState ILFDGGGKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void DGHFKJFCPAC(IntPtr CDBMADFDGCE, IntPtr ILFDGGGKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x27D0C40", Offset = "0x27CF240", VA = "0x1827D0C40")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void NLCIMBNHEDN(IntPtr CDBMADFDGCE, IntPtr ILFDGGGKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void CENKHIDAGFL(IntPtr CDBMADFDGCE, IntPtr ILFDGGGKIBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[AIBFCFMKILK(AGPDIMMFKMP.OMRoom)]
internal class NCDCPPOCABK : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private MKBGHPFKLIO CAEMHEKKBCE;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A0E0", Offset = "0x2A886E0", VA = "0x182A8A0E0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A130", Offset = "0x2A88730", VA = "0x182A8A130", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public NCDCPPOCABK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class NIGKLPOJFNA : OFHJMNAOPCE
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private enum JOADDCEDJFK
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CA80", Offset = "0x2A8B080", VA = "0x182A8CA80", Slot = "5")]
	public override Action AKNEMOCDEEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void AJBCKMPMMDH<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CB10", Offset = "0x2A8B110", VA = "0x182A8CB10")]
	[UnityEngine.Scripting.Preserve]
	public void NNBIMJFEELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B7F0", Offset = "0x2A89DF0", VA = "0x182A8B7F0")]
	protected NIGKLPOJFNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(LGEKFEKPHDG), new string[] { })]
public class LGEKFEKPHDG : LPOKOJIEHOF, EMBHBGCIFNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private FNLKBDOKFGP PGINAOKHABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private HMNOEMALJPC EGDOOPNCMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private BENLOGNDJHK[] JLLOEMECFPL;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2A77650", Offset = "0x2A75C50", VA = "0x182A77650", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2A776C0", Offset = "0x2A75CC0", VA = "0x182A776C0", Slot = "5")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2A77990", Offset = "0x2A75F90", VA = "0x182A77990")]
	public void NKLNBEPFEEK(EEKJFDFIEGN HGGMFNJGHIP, bool LBCOGNFNMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public LGEKFEKPHDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
[OJJOJOKIEBL(typeof(MKPEFGNMDIP), new string[] { })]
public class POKFPPEOABE : MKPEFGNMDIP, IEnumerable<EPFAAOCCGEJ>, IEnumerable, GFOPHFDOHAP, EECDFKAILMM, LPOKOJIEHOF, EMBHBGCIFNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[LABJLBKOJHN]
	private MBOAMGKJHBK EGDOOPNCMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(Type, string), int> NANMNBMECAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeBitArray ANLJBNKOAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<int> POIBDPPIFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private GBEMJDIMABH ENGHHDBLJGI;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public NativeBitArray LLAMNGFIEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9358D0", Offset = "0x933ED0", VA = "0x1809358D0", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NativeArray<int> IHCHDMOGKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCEA020", Offset = "0xCE8620", VA = "0x180CEA020", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private int GMDHOLDNJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xBBB300", Offset = "0xBB9900", VA = "0x180BBB300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x26145C0", Offset = "0x2612BC0", VA = "0x1826145C0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public EPFAAOCCGEJ ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x26145E0", Offset = "0x2612BE0", VA = "0x1826145E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public EPFAAOCCGEJ ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x26145E0", Offset = "0x2612BE0", VA = "0x1826145E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2614CB0", Offset = "0x26132B0", VA = "0x182614CB0", Slot = "13")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2614820", Offset = "0x2612E20", VA = "0x182614820", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "15")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x26148A0", Offset = "0x2612EA0", VA = "0x1826148A0")]
	private void OCGCKBFGNMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2614410", Offset = "0x2612A10", VA = "0x182614410", Slot = "9")]
	public EPFAAOCCGEJ EGCDMNKOBNB(CNGBAJDBKGM EFINPLKEDMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2614270", Offset = "0x2612870", VA = "0x182614270")]
	private bool DAKPHHCJBMH(Type BJDOACDNPGH, string ECMAPGHKHFB, out EPFAAOCCGEJ MHJDBAPOFEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2614620", Offset = "0x2612C20", VA = "0x182614620", Slot = "10")]
	public BENLOGNDJHK INBAPLHOGPD(CNGBAJDBKGM EFINPLKEDMK)
	{
		return default(BENLOGNDJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2614600", Offset = "0x2612C00", VA = "0x182614600", Slot = "11")]
	public IEnumerator<EPFAAOCCGEJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2614600", Offset = "0x2612C00", VA = "0x182614600", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x26143C0", Offset = "0x26129C0", VA = "0x1826143C0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2614D00", Offset = "0x2613300", VA = "0x182614D00")]
	public POKFPPEOABE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FFOJEPALPLA
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x24AB390", Offset = "0x24A9990", VA = "0x1824AB390")]
	public static void EFPFCHNCMCE(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in float3 IPKLBGKEJKA, in quaternion EOGEEAFFCFC, in float3 IJEBNGNKLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x24AA630", Offset = "0x24A8C30", VA = "0x1824AA630")]
	public static void DANGMACAEMN(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, out float4x4 BHECBPBIBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x24AA4D0", Offset = "0x24A8AD0", VA = "0x1824AA4D0")]
	private static void DANGMACAEMN(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, Entity HDBBNLFBJKG, out float4x4 BHECBPBIBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x24AA0E0", Offset = "0x24A86E0", VA = "0x1824AA0E0")]
	public static void BMFCDBMEJMK(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in float4x4 BHECBPBIBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x24AC7B0", Offset = "0x24AADB0", VA = "0x1824AC7B0")]
	public static void NAKNMIFPEHM(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, out float4x4 ELMHJHHOMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x24AB860", Offset = "0x24A9E60", VA = "0x1824AB860")]
	public static void IIFEKFGPPMF(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in float4x4 ELMHJHHOMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x24AB0A0", Offset = "0x24A96A0", VA = "0x1824AB0A0")]
	public static float3 ECIGICCJJFE(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x24A9F60", Offset = "0x24A8560", VA = "0x1824A9F60")]
	public static void AEMJAJFBJEJ(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x24ABDE0", Offset = "0x24AA3E0", VA = "0x1824ABDE0")]
	public static quaternion JOKMHACHIMP(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x24AA020", Offset = "0x24A8620", VA = "0x1824AA020")]
	public static void BDAGEKPJKOA(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in quaternion MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x24AC620", Offset = "0x24AAC20", VA = "0x1824AC620")]
	public static float3 LPOOPMBABGF(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x24AC4A0", Offset = "0x24AAAA0", VA = "0x1824AC4A0")]
	public static void LNEBKPMEOIB(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x24AB570", Offset = "0x24A9B70", VA = "0x1824AB570")]
	public static float FGGMJPNJDEC(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x24ABED0", Offset = "0x24AA4D0", VA = "0x1824ABED0")]
	public static void KLEIDPCLBMA(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x24AB6D0", Offset = "0x24A9CD0", VA = "0x1824AB6D0")]
	public static float3 GFEPOBPFOMH(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x24AB640", Offset = "0x24A9C40", VA = "0x1824AB640")]
	public static void GANOCGGJLOD(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x24ABCF0", Offset = "0x24AA2F0", VA = "0x1824ABCF0")]
	public static void JHGHBHCJHAO(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, out RigidTransform ELMHJHHOMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x24ABBD0", Offset = "0x24AA1D0", VA = "0x1824ABBD0")]
	public static void JHGHBHCJHAO(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, out float3 POOFJFBIOJJ, out quaternion MEHKCJCIOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x24AC6F0", Offset = "0x24AACF0", VA = "0x1824AC6F0")]
	public static void NAFDKGFCPND(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in float3 IPKLBGKEJKA, in quaternion EOGEEAFFCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x24AA960", Offset = "0x24A8F60", VA = "0x1824AA960")]
	public static void DKNFMLLPKMA(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, out float3 POOFJFBIOJJ, out quaternion MEHKCJCIOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x24AAE30", Offset = "0x24A9430", VA = "0x1824AAE30")]
	public static float3 ECBAFEIAPBC(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x24ACE60", Offset = "0x24AB460", VA = "0x1824ACE60")]
	public static void PHDDEJKAPNO(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x24AA770", Offset = "0x24A8D70", VA = "0x1824AA770")]
	public static void DCGBGKJKHLA(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in quaternion MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x24AB9A0", Offset = "0x24A9FA0", VA = "0x1824AB9A0")]
	public static quaternion JEEIFJCJBAI(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x24ACBA0", Offset = "0x24AB1A0", VA = "0x1824ACBA0")]
	public static float3 ONEALIHAOMC(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x24AABC0", Offset = "0x24A91C0", VA = "0x1824AABC0")]
	public static void DOHKANKFLDI(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x24AB1A0", Offset = "0x24A97A0", VA = "0x1824AB1A0")]
	public static float EEBLBDOBPKP(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x24AB430", Offset = "0x24A9A30", VA = "0x1824AB430")]
	public static void FBEJDKOBJAB(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, float HBIJEGODDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x24ABF50", Offset = "0x24AA550", VA = "0x1824ABF50")]
	public static float3 KOBDNGABLMF(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x24AC1C0", Offset = "0x24AA7C0", VA = "0x1824AC1C0")]
	public static void LBPPCPGFOCB(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, in float3 IJJFGJAFMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x24AB7C0", Offset = "0x24A9DC0", VA = "0x1824AB7C0")]
	public static bool IENBHBEIJDP(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, out Entity HDBBNLFBJKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[OJJOJOKIEBL(typeof(CMJAGJHDBFI), new string[] { })]
public class FCDFGFBJHMA : LPOKOJIEHOF, CMJAGJHDBFI
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LLMGIJCOFJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public ENMPPPDAMHN localId;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LLMGIJCOFJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x28F9170", Offset = "0x28F7770", VA = "0x1828F9170")]
		internal object BJFLJJIMIKO(FCDFGFBJHMA a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class OOCMEHEPGAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public ENMPPPDAMHN localId;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OOCMEHEPGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x28FB250", Offset = "0x28F9850", VA = "0x1828FB250")]
		internal object LHNDPKBCCHF(FCDFGFBJHMA a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private KKJOECNGBND JEAKBAFPNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private World DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private DIHPJNIDFNC GPHBFEDNJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[LABJLBKOJHN]
	private KDFIBOBNBIO GIGEAGEKEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private EntityManager MAHJPOPMBKN;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x24A7400", Offset = "0x24A5A00", VA = "0x1824A7400", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x24A7BD0", Offset = "0x24A61D0", VA = "0x1824A7BD0", Slot = "6")]
	public NBAPNPGIPAA KNCAAIPCOIK(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x24A6730", Offset = "0x24A4D30", VA = "0x1824A6730", Slot = "5")]
	public void FHBFPEMPLNK(ENMPPPDAMHN HMLJKOHAJKN, NBAPNPGIPAA MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x24A49E0", Offset = "0x24A2FE0", VA = "0x1824A49E0", Slot = "31")]
	public CollisionDetectionMode ACLFKBMKICI(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x24A52F0", Offset = "0x24A38F0", VA = "0x1824A52F0", Slot = "32")]
	public void CEGOHJFMOHF(ENMPPPDAMHN HMLJKOHAJKN, CollisionDetectionMode MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x24A8F90", Offset = "0x24A7590", VA = "0x1824A8F90", Slot = "33")]
	public LMDIKFABHDL PNEMEODCGPJ(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(LMDIKFABHDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x24A4E10", Offset = "0x24A3410", VA = "0x1824A4E10", Slot = "34")]
	public void BKOCFMGLCLF(ENMPPPDAMHN HMLJKOHAJKN, LMDIKFABHDL MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x24A6350", Offset = "0x24A4950", VA = "0x1824A6350", Slot = "35")]
	public bool EJAFOGFEHOJ(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x24A6980", Offset = "0x24A4F80", VA = "0x1824A6980", Slot = "36")]
	public void GDCOKEDOAIH(ENMPPPDAMHN HMLJKOHAJKN, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x24A4C70", Offset = "0x24A3270", VA = "0x1824A4C70", Slot = "37")]
	public ENMPPPDAMHN BGKMIAGKHHM(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x24A7B00", Offset = "0x24A6100", VA = "0x1824A7B00", Slot = "38")]
	public void KKGODJCIMGG(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x24A8A10", Offset = "0x24A7010", VA = "0x1824A8A10", Slot = "39")]
	public ENMPPPDAMHN OPPJHONDIOF(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x24A7520", Offset = "0x24A5B20", VA = "0x1824A7520", Slot = "40")]
	public void JAMGDJKMPGM(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x24A5420", Offset = "0x24A3A20", VA = "0x1824A5420", Slot = "7")]
	public void CNLHCEJCBPI(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x24A6820", Offset = "0x24A4E20", VA = "0x1824A6820", Slot = "8")]
	public void FNKCMBBPENL(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x24A57A0", Offset = "0x24A3DA0", VA = "0x1824A57A0", Slot = "9")]
	public int DCMOHGLHEDJ(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x24A6C80", Offset = "0x24A5280", VA = "0x1824A6C80", Slot = "10")]
	public ENMPPPDAMHN HBJBEJLBDDL(ENMPPPDAMHN HMLJKOHAJKN, int OLGOBCPPPBB)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x24A78E0", Offset = "0x24A5EE0", VA = "0x1824A78E0", Slot = "11")]
	public void KJOKNOBFEPI(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x24A5580", Offset = "0x24A3B80", VA = "0x1824A5580", Slot = "12")]
	public void COOCJKCKJJP(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI, ENMPPPDAMHN MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x24A4880", Offset = "0x24A2E80", VA = "0x1824A4880", Slot = "13")]
	public void ABJGPDHGOHD(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x24A75F0", Offset = "0x24A5BF0", VA = "0x1824A75F0", Slot = "14")]
	public bool JCPJPFOAFMG(ENMPPPDAMHN HMLJKOHAJKN, out ENMPPPDAMHN MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x24A5950", Offset = "0x24A3F50", VA = "0x1824A5950", Slot = "15")]
	public void DEHNBPELOHH(ENMPPPDAMHN HMLJKOHAJKN, float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x24A6A30", Offset = "0x24A5030", VA = "0x1824A6A30", Slot = "16")]
	public bool GGCGAPIHACE(ENMPPPDAMHN HMLJKOHAJKN, out float3 MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x24A7D70", Offset = "0x24A6370", VA = "0x1824A7D70", Slot = "17")]
	public void LCJNHEPBGAG(ENMPPPDAMHN HMLJKOHAJKN, float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x24A8870", Offset = "0x24A6E70", VA = "0x1824A8870", Slot = "18")]
	public bool OOLKOKCHMKO(ENMPPPDAMHN HMLJKOHAJKN, out float3 MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x24A4A70", Offset = "0x24A3070", VA = "0x1824A4A70", Slot = "23")]
	[Obsolete]
	public float3 AJJDOJBIGKO(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x24A8670", Offset = "0x24A6C70", VA = "0x1824A8670", Slot = "24")]
	public float3 NNGGMNKPBLP(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x24A6470", Offset = "0x24A4A70", VA = "0x1824A6470", Slot = "25")]
	public void ENBDOGDIGKA(ENMPPPDAMHN HMLJKOHAJKN, float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x24A6040", Offset = "0x24A4640", VA = "0x1824A6040", Slot = "26")]
	public void EEHBOFMJCHM(ENMPPPDAMHN HMLJKOHAJKN, float3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x24A90A0", Offset = "0x24A76A0", VA = "0x1824A90A0", Slot = "27")]
	[Obsolete]
	public float POBGEEKFMOC(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x24A5250", Offset = "0x24A3850", VA = "0x1824A5250", Slot = "28")]
	public float CDMCMCOOIHE(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x24A6BD0", Offset = "0x24A51D0", VA = "0x1824A6BD0", Slot = "29")]
	public void HAHBLFJGLIA(ENMPPPDAMHN HMLJKOHAJKN, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x24A7F60", Offset = "0x24A6560", VA = "0x1824A7F60", Slot = "30")]
	public void MGHPAGNHIMC(ENMPPPDAMHN HMLJKOHAJKN, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x24A5DF0", Offset = "0x24A43F0", VA = "0x1824A5DF0", Slot = "19")]
	public void ECOKPIOLIJF(ENMPPPDAMHN HMLJKOHAJKN, (Quaternion rot, Vector3 moments) FDPFMJCBPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x24A71A0", Offset = "0x24A57A0", VA = "0x1824A71A0", Slot = "20")]
	public bool IPODNLMJNFJ(ENMPPPDAMHN HMLJKOHAJKN, out quaternion ANIGKMMOJOB, out float3 LOPAPNDCGMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x24A4BE0", Offset = "0x24A31E0", VA = "0x1824A4BE0", Slot = "41")]
	public LMAKLIPDGJL BEIEGLKLGCP(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(LMAKLIPDGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x24A8450", Offset = "0x24A6A50", VA = "0x1824A8450", Slot = "42")]
	public void NDHGGPDHONL(ENMPPPDAMHN HMLJKOHAJKN, LMAKLIPDGJL MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x24A4D50", Offset = "0x24A3350", VA = "0x1824A4D50", Slot = "66")]
	public void BHHGLOEPIAH(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x24A56E0", Offset = "0x24A3CE0", VA = "0x1824A56E0", Slot = "67")]
	public void DCGILPKHPCC(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x24A7790", Offset = "0x24A5D90", VA = "0x1824A7790", Slot = "68")]
	public bool KADKMFOJIFG(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x24A8010", Offset = "0x24A6610", VA = "0x1824A8010", Slot = "82")]
	public bool MHOHHABFNAG(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x24A5B40", Offset = "0x24A4140", VA = "0x1824A5B40", Slot = "83")]
	public void DLJKBDBNBIK(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI, bool IBEINHPEJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x24A5AC0", Offset = "0x24A40C0", VA = "0x1824A5AC0", Slot = "84")]
	public void DHFHOCLGGHD(ENMPPPDAMHN HMLJKOHAJKN, bool NGEHFLNPGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x24A6DE0", Offset = "0x24A53E0", VA = "0x1824A6DE0", Slot = "86")]
	public bool HDMGNGBHBMN(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x24A8C80", Offset = "0x24A7280", VA = "0x1824A8C80", Slot = "85")]
	public void PCNHFMLJPDE(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x24A8D70", Offset = "0x24A7370", VA = "0x1824A8D70", Slot = "43")]
	public bool PIEELPKHJOE(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x24A9340", Offset = "0x24A7940", VA = "0x1824A9340", Slot = "44")]
	public void PPGJHJEMMBG(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x24A87E0", Offset = "0x24A6DE0", VA = "0x1824A87E0", Slot = "45")]
	public bool OLGBEFDDJDD(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x24A82F0", Offset = "0x24A68F0", VA = "0x1824A82F0", Slot = "46")]
	public void NAKCCLMAIKO(ENMPPPDAMHN HMLJKOHAJKN, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x24A5390", Offset = "0x24A3990", VA = "0x1824A5390", Slot = "47")]
	public bool CMFLIJDNPHL(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x24A84F0", Offset = "0x24A6AF0", VA = "0x1824A84F0", Slot = "48")]
	public void NDNFBAMAINA(ENMPPPDAMHN HMLJKOHAJKN, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x24A63E0", Offset = "0x24A49E0", VA = "0x1824A63E0", Slot = "49")]
	public RigidbodyConstraints EKOEAHFMEPH(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x24A91F0", Offset = "0x24A77F0", VA = "0x1824A91F0", Slot = "50")]
	public void PPBNMCNHPHM(ENMPPPDAMHN HMLJKOHAJKN, RigidbodyConstraints MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x24A8250", Offset = "0x24A6850", VA = "0x1824A8250", Slot = "51")]
	public float MPAOIKNBAPB(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x24A8730", Offset = "0x24A6D30", VA = "0x1824A8730", Slot = "52")]
	public void OLANIHBDKLF(ENMPPPDAMHN HMLJKOHAJKN, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x24A7840", Offset = "0x24A5E40", VA = "0x1824A7840", Slot = "53")]
	public float KFPNNEPFIHP(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x24A58A0", Offset = "0x24A3EA0", VA = "0x1824A58A0", Slot = "54")]
	public void DDFEPAIPIOD(ENMPPPDAMHN HMLJKOHAJKN, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x24A62C0", Offset = "0x24A48C0", VA = "0x1824A62C0", Slot = "55")]
	public bool EIBHEFJMGOL(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x24A9290", Offset = "0x24A7890", VA = "0x1824A9290", Slot = "56")]
	public void PPDMNLPGLKF(ENMPPPDAMHN HMLJKOHAJKN, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x24A7E30", Offset = "0x24A6430", VA = "0x1824A7E30", Slot = "57")]
	public bool LNADLDGEJOK(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x24A83A0", Offset = "0x24A69A0", VA = "0x1824A83A0", Slot = "58")]
	public void NBIMMLIJNIC(ENMPPPDAMHN HMLJKOHAJKN, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x24A7EC0", Offset = "0x24A64C0", VA = "0x1824A7EC0", Slot = "59")]
	public void MCIBNBBNLID(ENMPPPDAMHN HMLJKOHAJKN, int MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x24A85A0", Offset = "0x24A6BA0", VA = "0x1824A85A0", Slot = "73")]
	public Rigidbody NNFDPHKEOAH(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x24A65C0", Offset = "0x24A4BC0", VA = "0x1824A65C0", Slot = "74")]
	public void FFJCJJPBLNC(ENMPPPDAMHN HMLJKOHAJKN, Rigidbody MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x24A6F40", Offset = "0x24A5540", VA = "0x1824A6F40", Slot = "75")]
	public void IBONCPCMLEF(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x24A70E0", Offset = "0x24A56E0", VA = "0x1824A70E0", Slot = "76")]
	public void IOAGCIAEOEF(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x24A6E90", Offset = "0x24A5490", VA = "0x1824A6E90", Slot = "77")]
	public bool HOGIEJCBEKL(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x24A8E00", Offset = "0x24A7400", VA = "0x1824A8E00", Slot = "60")]
	public object PJNFHDEDOAO(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x24A8B10", Offset = "0x24A7110", VA = "0x1824A8B10", Slot = "61")]
	public void PCCPMJONGLB(ENMPPPDAMHN HMLJKOHAJKN, object MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x24A7CA0", Offset = "0x24A62A0", VA = "0x1824A7CA0", Slot = "62")]
	public object KPHAKFLDGAO(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x24A5040", Offset = "0x24A3640", VA = "0x1824A5040", Slot = "63")]
	public void BPNMEOEFFOG(ENMPPPDAMHN HMLJKOHAJKN, object MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x24A5FA0", Offset = "0x24A45A0", VA = "0x1824A5FA0", Slot = "64")]
	public float EEBIDACFFFP(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x24A6150", Offset = "0x24A4750", VA = "0x1824A6150", Slot = "65")]
	public void EGIKGPEOFBN(ENMPPPDAMHN HMLJKOHAJKN, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x24A6200", Offset = "0x24A4800", VA = "0x1824A6200", Slot = "69")]
	public void EIAHIFLJPPC(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x24A8ED0", Offset = "0x24A74D0", VA = "0x1824A8ED0", Slot = "70")]
	public void PMGHANFGMCL(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x24A5A10", Offset = "0x24A4010", VA = "0x1824A5A10", Slot = "71")]
	public bool DHCNMNDPCEK(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x24A4940", Offset = "0x24A2F40", VA = "0x1824A4940", Slot = "21")]
	public void ACHDPLKDGOD(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x24A51B0", Offset = "0x24A37B0", VA = "0x1824A51B0", Slot = "22")]
	public void CBLCEMOKJGB(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x24A6530", Offset = "0x24A4B30", VA = "0x1824A6530", Slot = "72")]
	public bool EOCICADGOJE(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x24A4F20", Offset = "0x24A3520", VA = "0x1824A4F20", Slot = "78")]
	public void BOJLENGDLGN(ENMPPPDAMHN HMLJKOHAJKN, float3 KEMGHPMICGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x24A79E0", Offset = "0x24A5FE0", VA = "0x1824A79E0", Slot = "79")]
	public void KJPBBCOOEBA(ENMPPPDAMHN HMLJKOHAJKN, float3 FKNMMHBCHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x24A6100", Offset = "0x24A4700", VA = "0x1824A6100", Slot = "80")]
	public bool EGBDOOIMGCO(ENMPPPDAMHN HMLJKOHAJKN, out float3 KEMGHPMICGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x24A8D20", Offset = "0x24A7320", VA = "0x1824A8D20", Slot = "81")]
	public bool PHFCOHFGAFA(ENMPPPDAMHN HMLJKOHAJKN, out float3 FKNMMHBCHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x24A8170", Offset = "0x24A6770", VA = "0x1824A8170")]
	private DynamicBuffer<Entity> MNOANGOLEMJ(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x24A7000", Offset = "0x24A5600", VA = "0x1824A7000")]
	private DynamicBuffer<Entity> IGAMMDLBLJG(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1C61DB0", Offset = "0x1C603B0", VA = "0x181C61DB0")]
	private void OFBCEAIDIKC<T>(ENMPPPDAMHN HMLJKOHAJKN, object MOLEJFDINLH, Func<object, T> KJFADEJENCC) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public FCDFGFBJHMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[UnityEngine.Scripting.Preserve]
internal sealed class BMEPJCGKDDI<T> : DIIPAOKEIKC where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1E682F0", Offset = "0x1E668F0", VA = "0x181E682F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1E68410", Offset = "0x1E66A10", VA = "0x181E68410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1E68480", Offset = "0x1E66A80", VA = "0x181E68480")]
	public BMEPJCGKDDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[OJJOJOKIEBL(typeof(GEMKDFICLBK), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal sealed class GEMKDFICLBK : GFOPHFDOHAP, EECDFKAILMM, LPOKOJIEHOF, EMBHBGCIFNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EntityQuery JKKAOIJLIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private EntityQuery NCJCKNCGGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private EntityQuery LCGEEDPCCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery COCCGGMJPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery DNEEJBCODBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery DLHAILONKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery JPEGNKLGPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x24B3B10", Offset = "0x24B2110", VA = "0x1824B3B10")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityQuery EEJJGMCONAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x136BF60", Offset = "0x136A560", VA = "0x18136BF60")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x24B35A0", Offset = "0x24B1BA0", VA = "0x1824B35A0", Slot = "5")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x24B35F0", Offset = "0x24B1BF0", VA = "0x1824B35F0", Slot = "6")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x24B3420", Offset = "0x24B1A20", VA = "0x1824B3420")]
	private EntityQueryDesc CMONKPGKJKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x24B3480", Offset = "0x24B1A80", VA = "0x1824B3480", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x24B3B60", Offset = "0x24B2160", VA = "0x1824B3B60")]
	public DLBKPAILIEM LGLNCHECMNH(ENMPPPDAMHN GIAMACBDIFH)
	{
		return default(DLBKPAILIEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x24B34F0", Offset = "0x24B1AF0", VA = "0x1824B34F0")]
	public BLIAAMDKPNO EBNGCMIBIEG(Entity MPAGCMNFGMI)
	{
		return default(BLIAAMDKPNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x24B3C30", Offset = "0x24B2230", VA = "0x1824B3C30")]
	public GEMKDFICLBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class BEBEJPIIKHC
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[OKNNJFAGDOM(typeof(FALLAGCDOFB))]
[OJJOJOKIEBL(typeof(IFGBMAJAPAC), new string[] { })]
internal class FALLAGCDOFB : IFGBMAJAPAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<HCJLJOEKAAD> ANPLFBAKNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<HCJLJOEKAAD> FHNNENNDJDF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action HBACKNBGODH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x24A3A20", Offset = "0x24A2020", VA = "0x1824A3A20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x24A3700", Offset = "0x24A1D00", VA = "0x1824A3700", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action MBAENNOCCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x24A37A0", Offset = "0x24A1DA0", VA = "0x1824A37A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x24A3AC0", Offset = "0x24A20C0", VA = "0x1824A3AC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MEAPKHPPMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x24A38E0", Offset = "0x24A1EE0", VA = "0x1824A38E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x24A3840", Offset = "0x24A1E40", VA = "0x1824A3840", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0xA17710", Offset = "0xA15D10", VA = "0x180A17710")]
	public void JJBLIOOKDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xA48110", Offset = "0xA46710", VA = "0x180A48110")]
	public void CHJMEPGAAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0xA6F5F0", Offset = "0xA6DBF0", VA = "0x180A6F5F0")]
	public void FPPAHHDMMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x24A39D0", Offset = "0x24A1FD0", VA = "0x1824A39D0")]
	public void JBNIGAFJJKM(HCJLJOEKAAD AHJEFHIJPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x24A3980", Offset = "0x24A1F80", VA = "0x1824A3980")]
	public void IAGAEBEIEBO(HCJLJOEKAAD AHJEFHIJPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public FALLAGCDOFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AIBFCFMKILK(AGPDIMMFKMP.OMRoom)]
internal class FDBAANCMFFK : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private MBKAKKEBAGC ICBHCLKGJNH;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x24A9600", Offset = "0x24A7C00", VA = "0x1824A9600", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x24A9650", Offset = "0x24A7C50", VA = "0x1824A9650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public FDBAANCMFFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KBJBMALCHMB
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FLAAMLPAECE
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FLAAMLPAECE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum HJKCHEKLGOP
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Main = 2,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Load = 4,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	NetworkReceive = 8,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Suppressed = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
[OJJOJOKIEBL(typeof(DLBAJHIENKP), new string[] { "Editor" })]
public sealed class DLBAJHIENKP
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate void IMLNNIFLOOI(EEKJFDFIEGN HGGMFNJGHIP, FNDBMHENIMP JAIGDBINGHO, HJKCHEKLGOP EJBKGMJFFOC);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void IMAOGOAHLCG(EEKJFDFIEGN HGGMFNJGHIP, HJKCHEKLGOP EJBKGMJFFOC);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void CLOMMCMGEAN(EEKJFDFIEGN HGGMFNJGHIP, BENLOGNDJHK JCPKNOEICEG, NGKHEJGAHGD LKPPDEOAPDB, NGKHEJGAHGD ENDLICBNMBH, HJKCHEKLGOP EJBKGMJFFOC);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate void FFGEANBNIPE(MODKFNDEKMI BOMEFJIOGGM, ReadOnlySpan<byte> GFHGIIOIPBN);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public DLBAJHIENKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class FBNCGMCHHAP : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x24A4320", Offset = "0x24A2920", VA = "0x1824A4320", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public FBNCGMCHHAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[OJJOJOKIEBL(typeof(BPFOPFGDLFP), new string[] { })]
public class FPGNENBGDIL : BPFOPFGDLFP, LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[LABJLBKOJHN]
	private JBBANOPACMB NDJMBFAHEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[LABJLBKOJHN]
	private HGMEOKAAKKA GEMLEDKAAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<NativeListAsync<Entity>> KDLCPOFNJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<(NativeListAsync<Entity>, bool)> DNBNJHFCCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private MOPLMCMCOIP NDCEMCGOMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Dictionary<Entity, IHCBJKJDAMN> AKEANHNKJKL;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x24B2870", Offset = "0x24B0E70", VA = "0x1824B2870", Slot = "8")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x24B19C0", Offset = "0x24AFFC0", VA = "0x1824B19C0", Slot = "4")]
	public void AHFKEHNENKC(NativeListAsync<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x24B2740", Offset = "0x24B0D40", VA = "0x1824B2740", Slot = "5")]
	public void HMFMIAPNFGA(MOPLMCMCOIP NDCEMCGOMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x24B2790", Offset = "0x24B0D90", VA = "0x1824B2790", Slot = "6")]
	public void IBKCNNIJCHD(NativeListAsync<Entity> NCEOACJJMCN, bool IAMHOKFEKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x24B23C0", Offset = "0x24B09C0", VA = "0x1824B23C0", Slot = "7")]
	public void GGPHJNLENHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x24B1CD0", Offset = "0x24B02D0", VA = "0x1824B1CD0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x24B2160", Offset = "0x24B0760", VA = "0x1824B2160")]
	private int FNEKPODLNMD(NativeListAsync<Entity> KDLCPOFNJJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x24B1A30", Offset = "0x24B0030", VA = "0x1824B1A30")]
	private int BEGPGGHKJPE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x24B28E0", Offset = "0x24B0EE0", VA = "0x1824B28E0")]
	private int KKPAEICOCKO(NativeListAsync<Entity> DNBNJHFCCJF, bool HHGCMHKNDIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x24B2C00", Offset = "0x24B1200", VA = "0x1824B2C00")]
	public FPGNENBGDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x24B2B20", Offset = "0x24B1120", VA = "0x1824B2B20")]
	[CompilerGenerated]
	private ENMPPPDAMHN OHKKPEIIDIK(Entity MPAGCMNFGMI)
	{
		return default(ENMPPPDAMHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(JJNJPCKJNLO), new string[] { })]
public class JJNJPCKJNLO
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool LHEAMNILFLF;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool JLMOFFAFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x979990", Offset = "0x977F90", VA = "0x180979990")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA6F0", Offset = "0x2AD8CF0", VA = "0x182ADA6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JJNJPCKJNLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal abstract class EIFNHJCLOFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private uint CPAKBOCGKGC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract uint PIPBAICBICM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x24A0F30", Offset = "0x249F530", VA = "0x1824A0F30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x24A1170", Offset = "0x249F770", VA = "0x1824A1170")]
	public EEKJFDFIEGN IGEIAFNCBBM()
	{
		return default(EEKJFDFIEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x24A0F70", Offset = "0x249F570", VA = "0x1824A0F70")]
	public void EGMHDLFFEIG(NativeArray<EEKJFDFIEGN> LDNMHAEAEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x24A0F50", Offset = "0x249F550", VA = "0x1824A0F50")]
	public void EGMHDLFFEIG(EEKJFDFIEGN HGGMFNJGHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8D1DD0", Offset = "0x8D03D0", VA = "0x1808D1DD0", Slot = "6")]
	public virtual void KINBCCGCMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x24A10D0", Offset = "0x249F6D0", VA = "0x1824A10D0")]
	private unsafe void ICKPHIMJPMA(EEKJFDFIEGN* GIODGDIBNNN, int FJLPCOJGEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x24A0FE0", Offset = "0x249F5E0", VA = "0x1824A0FE0")]
	private unsafe void EGMHDLFFEIG(EEKJFDFIEGN* GIODGDIBNNN, int FJLPCOJGEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x10A5F20", Offset = "0x10A4520", VA = "0x1810A5F20")]
	protected EIFNHJCLOFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(CBIHOPCFCDD), new string[] { })]
internal sealed class CBIHOPCFCDD : EIFNHJCLOFI, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[LABJLBKOJHN]
	private FFIEDGLJPJJ KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private uint JFFCAOEMPPP;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public override uint PIPBAICBICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x90DC40", Offset = "0x90C240", VA = "0x18090DC40", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x27CE290", Offset = "0x27CC890", VA = "0x1827CE290", Slot = "7")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x27CE240", Offset = "0x27CC840", VA = "0x1827CE240")]
	private void BAHMDPAHGHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x27CE320", Offset = "0x27CC920", VA = "0x1827CE320", Slot = "6")]
	public override void KINBCCGCMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x27CE380", Offset = "0x27CC980", VA = "0x1827CE380")]
	public CBIHOPCFCDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[OJJOJOKIEBL(typeof(HPNJCCDKDOJ), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
internal sealed class HPNJCCDKDOJ : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[LABJLBKOJHN]
	private FOGGGIMKHHH KOBLJDIMIFH;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6210", Offset = "0x2AD4810", VA = "0x182AD6210", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2AD61C0", Offset = "0x2AD47C0", VA = "0x182AD61C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public HPNJCCDKDOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[OJJOJOKIEBL(typeof(DHGNDOFADND), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public class DHGNDOFADND : GFDBIECGPKC, GFOPHFDOHAP, EECDFKAILMM, LPOKOJIEHOF, EMBHBGCIFNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class NHNHNHKNGJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LIFCBCFOLBC services;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NHNHNHKNGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x28FAEA0", Offset = "0x28F94A0", VA = "0x1828FAEA0")]
		internal void EIFMKBLOHAL(LPOKOJIEHOF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class CPIIAPEBLNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LIFCBCFOLBC services;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CPIIAPEBLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x28EF5B0", Offset = "0x28EDBB0", VA = "0x1828EF5B0")]
		internal void PHFMNAONNOB(EMBHBGCIFNL svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[LABJLBKOJHN]
	private IBFLLPBIJGL NAHCELMBFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[LABJLBKOJHN]
	private FOKGJFJPKEK FJNPCKPLFNE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public INLEBFHADPP FECBIDCJBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x952C20", Offset = "0x951220", VA = "0x180952C20", Slot = "4")]
		get
		{
			return default(INLEBFHADPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x27D7C00", Offset = "0x27D6200", VA = "0x1827D7C00", Slot = "5")]
	public void GAPKOLLNHGD(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x27D7E50", Offset = "0x27D6450", VA = "0x1827D7E50", Slot = "6")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x27D7C90", Offset = "0x27D6290", VA = "0x1827D7C90", Slot = "7")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x27D7D70", Offset = "0x27D6370", VA = "0x1827D7D70", Slot = "8")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x27D7AD0", Offset = "0x27D60D0", VA = "0x1827D7AD0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x243E000", Offset = "0x243C600", VA = "0x18243E000")]
	private void MKBKGNMOGDJ<T>(Action<T> PCGICOAPIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public DHGNDOFADND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[OJJOJOKIEBL(typeof(JAJEJKEGFGN), new string[] { })]
public sealed class FIEANKKPGOG : JAJEJKEGFGN, GFOPHFDOHAP, EECDFKAILMM, LPOKOJIEHOF, EMBHBGCIFNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class APAPFHEFGKO : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public FIEANKKPGOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string[] <tokens>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private StringBuilder <path>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private string <token>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x9C97A0", Offset = "0x9C7DA0", VA = "0x1809C97A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x28ED300", Offset = "0x28EB900", VA = "0x1828ED300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2832EC0", Offset = "0x28314C0", VA = "0x182832EC0")]
		[DebuggerHidden]
		public APAPFHEFGKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x28ECFC0", Offset = "0x28EB5C0", VA = "0x1828ECFC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x28ED2C0", Offset = "0x28EB8C0", VA = "0x1828ED2C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x28ED210", Offset = "0x28EB810", VA = "0x1828ED210", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x28ED210", Offset = "0x28EB810", VA = "0x1828ED210", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[LABJLBKOJHN]
	private MLDDOPEDHJJ EGDOOPNCMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly FGHCPEJMPAH JNLEHOAIBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Dictionary<string, CIEBLHNDGFH> HOCCGKMPCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<int, BMPAEHPFBCF> HMNNPJCGDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<GCPINDOJNBO> FIJEJPKHNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private JJPMDANOJAP CFBGPMFMALA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BMPAEHPFBCF MBMGKBCFEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x24AFDE0", Offset = "0x24AE3E0", VA = "0x1824AFDE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public List<GCPINDOJNBO> BPFADEADMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "9")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x24B0310", Offset = "0x24AE910", VA = "0x1824B0310", Slot = "10")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x24B0560", Offset = "0x24AEB60", VA = "0x1824B0560", Slot = "11")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x24AFD50", Offset = "0x24AE350", VA = "0x1824AFD50", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x24B0BC0", Offset = "0x24AF1C0", VA = "0x1824B0BC0", Slot = "6")]
	public bool OILCKJDFMPE(GCPINDOJNBO JCPKNOEICEG, out BMPAEHPFBCF KEJDPMGJDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x24B05C0", Offset = "0x24AEBC0", VA = "0x1824B05C0")]
	private void LCLKKMPJILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x24B03C0", Offset = "0x24AE9C0", VA = "0x1824B03C0")]
	private void KCGIHIICAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x24B02B0", Offset = "0x24AE8B0", VA = "0x1824B02B0")]
	private CIEBLHNDGFH IPCFKKMAHCG(string NDPGLBIMDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x24AFDE0", Offset = "0x24AE3E0", VA = "0x1824AFDE0")]
	private CIEBLHNDGFH GHLMCGFNHKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x24AFE40", Offset = "0x24AE440", VA = "0x1824AFE40")]
	private CIEBLHNDGFH EHPJDDANNOE(string NDPGLBIMDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x24B0C50", Offset = "0x24AF250", VA = "0x1824B0C50")]
	private CIEBLHNDGFH PKNJOJDJCEF(string KMNDPDKPPEJ, string DCEGGIJLHGI, [Optional] CIEBLHNDGFH LHOJKOPNLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x24B00B0", Offset = "0x24AE6B0", VA = "0x1824B00B0")]
	[IteratorStateMachine(typeof(APAPFHEFGKO))]
	private IEnumerable<(string, string)> GFCLIPDEKKO(string NDPGLBIMDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x24B0950", Offset = "0x24AEF50", VA = "0x1824B0950")]
	private bool LJKJHEHPPLB(GCPINDOJNBO JCPKNOEICEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x24B01D0", Offset = "0x24AE7D0", VA = "0x1824B01D0")]
	private FGHCPEJMPAH IEHDKGHLDDC(GCPINDOJNBO JCPKNOEICEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x24B0370", Offset = "0x24AE970", VA = "0x1824B0370")]
	private FGHCPEJMPAH KBIIAIEABKH(GCPINDOJNBO JCPKNOEICEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x24B0140", Offset = "0x24AE740", VA = "0x1824B0140")]
	private FGHCPEJMPAH HIFFPKMFBHB(GCPINDOJNBO JCPKNOEICEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1C654A0", Offset = "0x1C63AA0", VA = "0x181C654A0")]
	private T FCIKINPKKEO<T>(GCPINDOJNBO JCPKNOEICEG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x24B0A30", Offset = "0x24AF030", VA = "0x1824B0A30")]
	private FieldInfo LPLNDNMLIAL(GCPINDOJNBO JCPKNOEICEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x24B0B10", Offset = "0x24AF110", VA = "0x1824B0B10", Slot = "7")]
	public void MBACIJOLGCB(GCPINDOJNBO JCPKNOEICEG, NJFNDPOIPIK LELMIPHHCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x24AFCA0", Offset = "0x24AE2A0", VA = "0x1824AFCA0", Slot = "8")]
	public void BDNBMIGFIII(GCPINDOJNBO JCPKNOEICEG, NJFNDPOIPIK LELMIPHHCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x24B0D60", Offset = "0x24AF360", VA = "0x1824B0D60")]
	public FIEANKKPGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x24B09A0", Offset = "0x24AEFA0", VA = "0x1824B09A0")]
	[CompilerGenerated]
	private int LNBJIJABDLC(GCPINDOJNBO GNJGFBLEGKK, GCPINDOJNBO HEPECHBEGLE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GEJKHBKCMOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KHEMMLFOHAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class PNNLHOKLPHA
{
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2612D50", Offset = "0x2611350", VA = "0x182612D50")]
	public static void JNFDHAGOCDA(IAMDAJKPFJC BILPDCGHAAG, string OCKPOCCIODA, ENMPPPDAMHN MIGKAMMIMKO, Action KJFADEJENCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2612FB0", Offset = "0x26115B0", VA = "0x182612FB0")]
	public static void JNFDHAGOCDA(IAMDAJKPFJC BILPDCGHAAG, string OCKPOCCIODA, KIHFNANBKDD GODELLPEDEK, Action KJFADEJENCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[OJJOJOKIEBL(typeof(OBPAHFKOKAC), new string[] { })]
public class KOAEJDPCLMJ : LPOKOJIEHOF, OBPAHFKOKAC
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2A73770", Offset = "0x2A71D70", VA = "0x182A73770", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2A737F0", Offset = "0x2A71DF0", VA = "0x182A737F0", Slot = "5")]
	public void MNFAMGHJOLE(ENMPPPDAMHN GIAMACBDIFH, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2A73700", Offset = "0x2A71D00", VA = "0x182A73700", Slot = "6")]
	public void BOOMILABPFA(ENMPPPDAMHN GIAMACBDIFH, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2A73860", Offset = "0x2A71E60", VA = "0x182A73860", Slot = "7")]
	public void OMNDJOBKOJM(ENMPPPDAMHN GIAMACBDIFH, int MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0xF3D1E0", Offset = "0xF3B7E0", VA = "0x180F3D1E0")]
	private void FGMAFKALEHD<T>(ENMPPPDAMHN GIAMACBDIFH, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0xF3D4B0", Offset = "0xF3BAB0", VA = "0x180F3D4B0")]
	private void FGMAFKALEHD<T>(ENMPPPDAMHN GIAMACBDIFH, T JAIGDBINGHO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public KOAEJDPCLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
[OJJOJOKIEBL(typeof(NCCBPOFEBGJ), new string[] { })]
public sealed class NCCBPOFEBGJ : LPOKOJIEHOF, EMBHBGCIFNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IPNEHEBJKBG : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public NCCBPOFEBGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private List<RRCustomPropTag> <list>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private Scene <scene>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private GameObject[] <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private GameObject <root>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<RRCustomPropTag>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private RRCustomPropTag <tag>5__8;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x97B9F0", Offset = "0x979FF0", VA = "0x18097B9F0")]
		[DebuggerHidden]
		public IPNEHEBJKBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x28F56F0", Offset = "0x28F3CF0", VA = "0x1828F56F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x28F52D0", Offset = "0x28F38D0", VA = "0x1828F52D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x28F5280", Offset = "0x28F3880", VA = "0x1828F5280")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x28F56B0", Offset = "0x28F3CB0", VA = "0x1828F56B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x28F5610", Offset = "0x28F3C10", VA = "0x1828F5610", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x28F5610", Offset = "0x28F3C10", VA = "0x1828F5610", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Dictionary<SerializableGuid, MGJBCBDODFM> CFNMPCBJGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly List<SerializableGuid> PLALBLLJEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<SerializableGuid, GameObject> LKGDMEFDKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private MLDDOPEDHJJ EGDOOPNCMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private MIJOAPHHMJE KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private IFGBMAJAPAC JBAGHABAFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private FOKGJFJPKEK FJNPCKPLFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private GBHPCKEHPBF<MGJBCBDODFM> AHPGKLPDJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private GameObject LBCHPKEKLPC;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2A88E60", Offset = "0x2A87460", VA = "0x182A88E60", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2A88F30", Offset = "0x2A87530", VA = "0x182A88F30", Slot = "5")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2A88C70", Offset = "0x2A87270", VA = "0x182A88C70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2A888B0", Offset = "0x2A86EB0", VA = "0x182A888B0")]
	private void CFJKCGOGBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2A890C0", Offset = "0x2A876C0", VA = "0x182A890C0")]
	internal void KJMELDKBGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2A89B00", Offset = "0x2A88100", VA = "0x182A89B00")]
	private void OIMAIMJCFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2A887B0", Offset = "0x2A86DB0", VA = "0x182A887B0")]
	private void BHGMBJOHAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2A89CE0", Offset = "0x2A882E0", VA = "0x182A89CE0")]
	[IteratorStateMachine(typeof(IPNEHEBJKBG))]
	private IEnumerable<RRCustomPropTag> PHJIICGDLMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2A89500", Offset = "0x2A87B00", VA = "0x182A89500")]
	private void KOGOFOIFLNI(ENMPPPDAMHN HMLJKOHAJKN, in NGKHEJGAHGD MDNKPPKLBGD, in NGKHEJGAHGD KIFJIAOCCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2A899C0", Offset = "0x2A87FC0", VA = "0x182A899C0")]
	private void MBACIJOLGCB(SerializableGuid NAMBIBPENHK, GameObject FLCGKEKAMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2A888C0", Offset = "0x2A86EC0", VA = "0x182A888C0")]
	private void DLOFKFONBNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2A885E0", Offset = "0x2A86BE0", VA = "0x182A885E0")]
	private bool BBEHNFDAPKA(MGJBCBDODFM DHABLNNJHLM, Transform HDBBNLFBJKG, out GameObject DFKGLOBLDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2A88E10", Offset = "0x2A87410", VA = "0x182A88E10")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2A89DE0", Offset = "0x2A883E0", VA = "0x182A89DE0")]
	public NCCBPOFEBGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
[OJJOJOKIEBL(typeof(MLDDOPEDHJJ), new string[] { })]
public class GIOLMFCPIHE : MLDDOPEDHJJ, IEnumerable<GCPINDOJNBO>, IEnumerable, LPOKOJIEHOF, EMBHBGCIFNL, KJPEBAGBPMP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[LABJLBKOJHN]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[LABJLBKOJHN]
	private MKPEFGNMDIP KGHDEFAENMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private GCPINDOJNBO[] NOPOGKAHHKA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x24B75C0", Offset = "0x24B5BC0", VA = "0x1824B75C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public GCPINDOJNBO ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x24B7610", Offset = "0x24B5C10", VA = "0x1824B7610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x24B7800", Offset = "0x24B5E00", VA = "0x1824B7800", Slot = "10")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x24B7870", Offset = "0x24B5E70", VA = "0x1824B7870", Slot = "11")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x24B7AC0", Offset = "0x24B60C0", VA = "0x1824B7AC0")]
	private GCPINDOJNBO OMMBBGLMGLD(int OLGOBCPPPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x24B74A0", Offset = "0x24B5AA0", VA = "0x1824B74A0", Slot = "6")]
	public GCPINDOJNBO EGCDMNKOBNB(CNGBAJDBKGM EFINPLKEDMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x24B7730", Offset = "0x24B5D30", VA = "0x1824B7730", Slot = "7")]
	public BENLOGNDJHK INBAPLHOGPD(CNGBAJDBKGM EFINPLKEDMK)
	{
		return default(BENLOGNDJHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x24B7620", Offset = "0x24B5C20", VA = "0x1824B7620", Slot = "8")]
	public IEnumerator<GCPINDOJNBO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x24B7620", Offset = "0x24B5C20", VA = "0x1824B7620", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2B340F0", Offset = "0x2B326F0", VA = "0x182B340F0", Slot = "12")]
	public void ACLOJBGGCPJ<TKey, T>(CGAFBLACJDG<TKey, T> JCPKNOEICEG, [Optional] object MFPELEJLJLD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x24B7400", Offset = "0x24B5A00", VA = "0x1824B7400", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public GIOLMFCPIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x24B7610", Offset = "0x24B5C10", VA = "0x1824B7610")]
	[CompilerGenerated]
	private GCPINDOJNBO GHNDGGBDKAM(int GPAKLECDLDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal class AIMPLNLLPPE : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private EntityQuery HBEANALKECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x27C0BC0", Offset = "0x27BF1C0", VA = "0x1827C0BC0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x27C0C10", Offset = "0x27BF210", VA = "0x1827C0C10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x27C0CA0", Offset = "0x27BF2A0", VA = "0x1827C0CA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public AIMPLNLLPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class IPPLNEMOKBL<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(GCDCLMKPGCD), new string[] { })]
public class GCDCLMKPGCD : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[LABJLBKOJHN]
	private MKBGHPFKLIO HLHINDIFOED;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x24B3390", Offset = "0x24B1990", VA = "0x1824B3390", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x24B3370", Offset = "0x24B1970", VA = "0x1824B3370", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public GCDCLMKPGCD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class DisembodiedObjectView : MonoBehaviour, EOACBFHBFAO
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DONKHGNKKGP
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public ENMPPPDAMHN ILMEFPJAMNB
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xE6A930", Offset = "0xE68F30", VA = "0x180E6A930", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(ENMPPPDAMHN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xE6A960", Offset = "0xE68F60", VA = "0x180E6A960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x249DB60", Offset = "0x249C160", VA = "0x18249DB60")]
		public void SetName(string ECMAPGHKHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public DisembodiedObjectView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FHJKJDEFFFH
{
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x24AFC40", Offset = "0x24AE240", VA = "0x1824AFC40")]
	public static void KCAMEPEJJCN(ComponentSystemBase CPDLEGJAIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[OJJOJOKIEBL(typeof(JEEOIALHEAK), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal sealed class JEEOIALHEAK : EIFNHJCLOFI
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public override uint PIPBAICBICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x27CE380", Offset = "0x27CC980", VA = "0x1827CE380")]
	public JEEOIALHEAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FKBEGLEHAFD
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AHAIODGCJJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public LIFCBCFOLBC services;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AHAIODGCJJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x28ECE90", Offset = "0x28EB490", VA = "0x1828ECE90")]
		internal void EKKNGAJCOAP(LPOKOJIEHOF svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x28ECEF0", Offset = "0x28EB4F0", VA = "0x1828ECEF0")]
		internal void JHCFBNONKAD(EMBHBGCIFNL svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x24B0ED0", Offset = "0x24AF4D0", VA = "0x1824B0ED0")]
	public static void OBJEACMIIDB(this World DDODGIBMPPP, LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0xF3F060", Offset = "0xF3D660", VA = "0x180F3F060")]
	public static void MKEAFNKCIOD<T>(this World DDODGIBMPPP, Action<T> PCGICOAPIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1C65670", Offset = "0x1C63C70", VA = "0x181C65670")]
	public static void LEBFHHAPEHP<T>(this World DDODGIBMPPP, Action<T> PCGICOAPIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1C658C0", Offset = "0x1C63EC0", VA = "0x181C658C0")]
	public static void LEBFHHAPEHP<T>(IEnumerable<ComponentSystemBase> NPKGKGEPBBI, Action<T> PCGICOAPIJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[OJJOJOKIEBL(typeof(MDHPMKEGPDB), new string[] { })]
internal class KPELBNBLAND : MDHPMKEGPDB, LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private enum Flag
	{
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Allowed,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Clone,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Copy,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Undo,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		UndoCreation,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Physics,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		SerializationV4,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		HierarchyViewVisible
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class CEMECIBMDDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CEMECIBMDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x28EDDE0", Offset = "0x28EC3E0", VA = "0x1828EDDE0")]
		internal object NCBBCCFJEEM((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[LABJLBKOJHN]
	private KGBMKPKFLLI KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[LABJLBKOJHN]
	private HMKFBCDDIDP LHEAMNILFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NativeBitArray POKDAMLGAFJ;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ODHLOBENJON DCECOBGOMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2A74310", Offset = "0x2A72910", VA = "0x182A74310", Slot = "4")]
		get
		{
			return default(ODHLOBENJON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public ODHLOBENJON LDBNMNNFHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2A73C80", Offset = "0x2A72280", VA = "0x182A73C80", Slot = "5")]
		get
		{
			return default(ODHLOBENJON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ODHLOBENJON MOAONFLIEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2A73EB0", Offset = "0x2A724B0", VA = "0x182A73EB0", Slot = "6")]
		get
		{
			return default(ODHLOBENJON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ODHLOBENJON JFDAFJDPIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2A74030", Offset = "0x2A72630", VA = "0x182A74030", Slot = "7")]
		get
		{
			return default(ODHLOBENJON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public ODHLOBENJON MHKDGLOEBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2A742B0", Offset = "0x2A728B0", VA = "0x182A742B0", Slot = "8")]
		get
		{
			return default(ODHLOBENJON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ODHLOBENJON ANKIIHHGNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2A73DF0", Offset = "0x2A723F0", VA = "0x182A73DF0", Slot = "9")]
		get
		{
			return default(ODHLOBENJON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public ODHLOBENJON KGALHCNIIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2A73EC0", Offset = "0x2A724C0", VA = "0x182A73EC0", Slot = "10")]
		get
		{
			return default(ODHLOBENJON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ODHLOBENJON JGLELHPJOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2A73D30", Offset = "0x2A72330", VA = "0x182A73D30", Slot = "11")]
		get
		{
			return default(ODHLOBENJON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private int PNGJOAIOJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2A73E00", Offset = "0x2A72400", VA = "0x182A73E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2A73ED0", Offset = "0x2A724D0", VA = "0x182A73ED0", Slot = "12")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2A73D40", Offset = "0x2A72340", VA = "0x182A73D40", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2A742C0", Offset = "0x2A728C0", VA = "0x182A742C0")]
	private void PFGKCPEFNNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x2A74040", Offset = "0x2A72640", VA = "0x182A74040")]
	private void LJMJGPMFGFM(Flag PDLGJEIPEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2A73C90", Offset = "0x2A72290", VA = "0x182A73C90")]
	private ODHLOBENJON ANJHEOADNOP(Flag PDLGJEIPEDC)
	{
		return default(ODHLOBENJON);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2A73D10", Offset = "0x2A72310", VA = "0x182A73D10")]
	private ODHLOBENJON BHGMJKKKDON(Flag PDLGJEIPEDC)
	{
		return default(ODHLOBENJON);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public KPELBNBLAND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[OJJOJOKIEBL(typeof(LJIKPIOGIDO), new string[] { })]
public class PODJAJALJNO : LPOKOJIEHOF, EMBHBGCIFNL, LJIKPIOGIDO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private DEMCMMGHLIH PFGMPLPGGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private DKKKGDEMMBH OHACKIIBLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private JJPMDANOJAP CFBGPMFMALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private AMHHCFBJAJG GFGHOCAHHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private int HCCEKKKBDKA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BIOLNBKCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2613B50", Offset = "0x2612150", VA = "0x182613B50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ENMPPPDAMHN CCEMFKCELEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2613F00", Offset = "0x2612500", VA = "0x182613F00", Slot = "9")]
		get
		{
			return default(ENMPPPDAMHN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2613220", Offset = "0x2611820", VA = "0x182613220", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NILFLMGAFIC CFNMMJKEMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2613A10", Offset = "0x2612010", VA = "0x182613A10", Slot = "11")]
		get
		{
			return default(NILFLMGAFIC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2613220", Offset = "0x2611820", VA = "0x182613220", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private uint DLHHKECKODH
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2613E50", Offset = "0x2612450", VA = "0x182613E50")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event MEAOHDLFGLM FABNKKNBIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2613700", Offset = "0x2611D00", VA = "0x182613700", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2613660", Offset = "0x2611C60", VA = "0x182613660", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2613A80", Offset = "0x2612080", VA = "0x182613A80", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2613CB0", Offset = "0x26122B0", VA = "0x182613CB0", Slot = "5")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2613570", Offset = "0x2611B70", VA = "0x182613570", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2613F40", Offset = "0x2612540", VA = "0x182613F40")]
	private void NNONJMIPIEK(HPCDDCJODHI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x26138F0", Offset = "0x2611EF0", VA = "0x1826138F0", Slot = "13")]
	public ENMPPPDAMHN IBFCCLELLKC(ENMPPPDAMHN LIGIEJOGFAH, ENMPPPDAMHN LFGKHOBDGNE)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2613BA0", Offset = "0x26121A0", VA = "0x182613BA0", Slot = "14")]
	public bool JFELDPLAPKL(ENMPPPDAMHN LIGIEJOGFAH, ENMPPPDAMHN LFGKHOBDGNE, out ENMPPPDAMHN EKPEPIHNAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2613400", Offset = "0x2611A00", VA = "0x182613400", Slot = "15")]
	public void DODBKCPPLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x26138C0", Offset = "0x2611EC0", VA = "0x1826138C0", Slot = "16")]
	public void GPOBEAKBFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2613250", Offset = "0x2611850", VA = "0x182613250", Slot = "17")]
	public bool AMPIGGEALCC(ENMPPPDAMHN LIGIEJOGFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x26137A0", Offset = "0x2611DA0", VA = "0x1826137A0")]
	private void FLDNGMNGFLL(ENMPPPDAMHN GNLKCPLNOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public PODJAJALJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
[OJJOJOKIEBL(typeof(MLAMKEEJIFG), new string[] { })]
internal class MLAMKEEJIFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public void GIGANHKAECI(string ECMAPGHKHFB, EntityManager PHHGGAMLDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public MLAMKEEJIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class EACIFFLIOHF
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x249DCB0", Offset = "0x249C2B0", VA = "0x18249DCB0")]
	public static bool JDPCKHKMBAH(FCLHKJAHMCN ICJKFOEDBBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x249DDC0", Offset = "0x249C3C0", VA = "0x18249DDC0")]
	public static FCLHKJAHMCN MBACIJOLGCB(GameObject FLCGKEKAMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x249E000", Offset = "0x249C600", VA = "0x18249E000")]
	public static FCLHKJAHMCN MBACIJOLGCB(GameObject FLCGKEKAMCK, EEKJFDFIEGN HGGMFNJGHIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x249E1E0", Offset = "0x249C7E0", VA = "0x18249E1E0")]
	public static bool PEHFCMIFHGL(GameObject LFMEKIMOADD, string ICNEJAGANPG, bool PAOOJFELNBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal readonly struct IBHJNJDCKDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly ComponentSystemBase CPDLEGJAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly ProfilerMarker OGGGENHMLAP;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7CC0", Offset = "0x2AD62C0", VA = "0x182AD7CC0")]
	public IBHJNJDCKDB(World DDODGIBMPPP, Type KLGGKKGCLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7C40", Offset = "0x2AD6240", VA = "0x182AD7C40")]
	public void KAHGAFNKOCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(FHBCPABBPOI), new string[] { })]
internal sealed class FHBCPABBPOI : LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private JMGAPHGFIPO LKGDMEFDKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[LABJLBKOJHN]
	private GEMKDFICLBK KGLOBJOCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[LABJLBKOJHN]
	private FOKGJFJPKEK LGKOPPBPBHD;

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x24ADE90", Offset = "0x24AC490", VA = "0x1824ADE90", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x24ADB60", Offset = "0x24AC160", VA = "0x1824ADB60")]
	public KIHFNANBKDD BKAFCMHHBBL(KIHFNANBKDD BEDADBBGMAL, Allocator HINEEPDGLPG)
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x24AD9C0", Offset = "0x24ABFC0", VA = "0x1824AD9C0")]
	private void BHLBDLOLJNP(NativeParallelMultiHashMap<int, (ENMPPPDAMHN src, ENMPPPDAMHN dst)> PFNLGEAPKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x24AE290", Offset = "0x24AC890", VA = "0x1824AE290")]
	private void PDNPFBCHCCK(NativeParallelMultiHashMap<int, (ENMPPPDAMHN src, ENMPPPDAMHN dst)> PFNLGEAPKDO, int POJMFCODLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x24ADC90", Offset = "0x24AC290", VA = "0x1824ADC90")]
	private void IDFLAAGFDHE(NativeParallelMultiHashMap<int, (ENMPPPDAMHN src, ENMPPPDAMHN dst)> PFNLGEAPKDO, int POJMFCODLHG, IMNNLGNGPKK EGDOOPNCMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x24ADF40", Offset = "0x24AC540", VA = "0x1824ADF40")]
	private NativeParallelMultiHashMap<int, (ENMPPPDAMHN, ENMPPPDAMHN)> ONHFBKMPNJB(Allocator HINEEPDGLPG, KIHFNANBKDD BEDADBBGMAL, out KIHFNANBKDD NKDEBKDIFKG)
	{
		return default(NativeParallelMultiHashMap<int, (ENMPPPDAMHN, ENMPPPDAMHN)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public FHBCPABBPOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[OJJOJOKIEBL(typeof(ILDEPLLCBBO), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public class ILDEPLLCBBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Dictionary<IFEBDPAFELD, string> IBGDCJLEDJK;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8E80", Offset = "0x2AD7480", VA = "0x182AD8E80")]
	public GameObject ONGAOAMOJDC(IFEBDPAFELD ILDPIPJCHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8F50", Offset = "0x2AD7550", VA = "0x182AD8F50")]
	public ILDEPLLCBBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class GDLFAFLPCBD<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[KGDFJMDJLCH(AGPDIMMFKMP.PhotonRoom)]
[OJJOJOKIEBL(typeof(FNJJFCCLJPH), new string[] { })]
public class FNJJFCCLJPH : GFOPHFDOHAP, EECDFKAILMM, LPOKOJIEHOF, EMBHBGCIFNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private MIJOAPHHMJE KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private BJDDOFPNFNG AJKILBCGPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NativeList<int> MACLJEOLCPF;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x24B16C0", Offset = "0x24AFCC0", VA = "0x1824B16C0", Slot = "4")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x24B15B0", Offset = "0x24AFBB0", VA = "0x1824B15B0", Slot = "5")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x24B1620", Offset = "0x24AFC20", VA = "0x1824B1620", Slot = "6")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x24B14F0", Offset = "0x24AFAF0", VA = "0x1824B14F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x24B1760", Offset = "0x24AFD60", VA = "0x1824B1760")]
	public void OPJFOBKBIBH(NativeParallelHashSet<int> IPPOOIHKNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x24B1720", Offset = "0x24AFD20", VA = "0x1824B1720")]
	public void OMNGKNBGPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public FNJJFCCLJPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[OJJOJOKIEBL(typeof(KEEBBKGEOIP), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal class KEEBBKGEOIP : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly IAMDAJKPFJC DIAGAGCPBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[LABJLBKOJHN]
	private KGPKDCJJLAE KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[LABJLBKOJHN]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[LABJLBKOJHN]
	private KKJOECNGBND JEAKBAFPNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private KIMCOPEIFEL JBAGHABAFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private EntityQuery DHBECOOKCHB;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC860", Offset = "0x2AEAE60", VA = "0x182AEC860")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBE30", Offset = "0x2AEA430", VA = "0x182AEBE30", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB850", Offset = "0x2AE9E50", VA = "0x182AEB850", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB020", Offset = "0x2AE9620", VA = "0x182AEB020")]
	public FBGEKGCCCOL BGLNABMJEEI(IEnumerable<OPAIBEOPLMG> NOAGJDHFBLG)
	{
		return default(FBGEKGCCCOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAED0", Offset = "0x2AE94D0", VA = "0x182AEAED0")]
	public static bool BEIMCOKDALH(OPAIBEOPLMG FEBOEFLLEJB, out EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA2A0", Offset = "0x2AE88A0", VA = "0x182AEA2A0")]
	private FBGEKGCCCOL ALHIBHFMOFB(IEnumerable<OPAIBEOPLMG> NOAGJDHFBLG)
	{
		return default(FBGEKGCCCOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBA40", Offset = "0x2AEA040", VA = "0x182AEBA40")]
	private (List<OPAIBEOPLMG>, int[], int) IGHCAAGPJOF(IEnumerable<OPAIBEOPLMG> NOAGJDHFBLG)
	{
		return default((List<OPAIBEOPLMG>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AECCF0", Offset = "0x2AEB2F0", VA = "0x182AECCF0")]
	private Dictionary<EEKJFDFIEGN, (OPAIBEOPLMG, int)> PGBGKJKNKFC(IEnumerable<OPAIBEOPLMG> NOAGJDHFBLG, Entity MEAHNFJNALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC8B0", Offset = "0x2AEAEB0", VA = "0x182AEC8B0")]
	private void MPFCAPNKIKB(Dictionary<EEKJFDFIEGN, (OPAIBEOPLMG request, int srcIndex)> LAMHHEIMNAC, IEnumerable<OPAIBEOPLMG> NOAGJDHFBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB860", Offset = "0x2AE9E60", VA = "0x182AEB860")]
	private void HJBDPOBDPGF(Dictionary<EEKJFDFIEGN, (OPAIBEOPLMG request, int srcIndex)> LAMHHEIMNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA970", Offset = "0x2AE8F70", VA = "0x182AEA970")]
	private void BEANPKLDCIB(Dictionary<EEKJFDFIEGN, (OPAIBEOPLMG request, int srcIndex)> LAMHHEIMNAC, EEKJFDFIEGN HGGMFNJGHIP, string ECMAPGHKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB3B0", Offset = "0x2AE99B0", VA = "0x182AEB3B0")]
	private void CKPKDDKFHBA(Dictionary<EEKJFDFIEGN, (OPAIBEOPLMG request, int srcIndex)> LAMHHEIMNAC, Entity MEAHNFJNALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC1B0", Offset = "0x2AEA7B0", VA = "0x182AEC1B0")]
	private (List<OPAIBEOPLMG>, int[], int) KIDHADPFKHN(Dictionary<EEKJFDFIEGN, (OPAIBEOPLMG request, int srcIndex)> LAMHHEIMNAC, Entity MEAHNFJNALI)
	{
		return default((List<OPAIBEOPLMG>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB130", Offset = "0x2AE9730", VA = "0x182AEB130")]
	private void BJKGBJHCFBP(Dictionary<EEKJFDFIEGN, (OPAIBEOPLMG request, int srcIndex)> LAMHHEIMNAC, List<OPAIBEOPLMG> NMICJBHFFCG, int[] JNLHGFKOMMM, NativeArray<Entity> NCEOACJJMCN, NativeList<EEKJFDFIEGN> LDNMHAEAEME, NativeList<Entity> HBPDFGPCCHA, Entity MEAHNFJNALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2AECC20", Offset = "0x2AEB220", VA = "0x182AECC20")]
	private static bool OAIHKBBHIEJ(Entity MPAGCMNFGMI, ComponentDataFromEntity<BCIOGPLFNGO> HEHGEGODCBH, Entity MEAHNFJNALI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AECDA0", Offset = "0x2AEB3A0", VA = "0x182AECDA0")]
	private void PJOHNJLNLFG(Dictionary<EEKJFDFIEGN, (OPAIBEOPLMG request, int srcIndex)> LAMHHEIMNAC, List<OPAIBEOPLMG> NMICJBHFFCG, int[] JNLHGFKOMMM, NativeList<Entity> HBPDFGPCCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBC20", Offset = "0x2AEA220", VA = "0x182AEBC20")]
	private NativeList<EEKJFDFIEGN> ILMKEGHLCIK(Dictionary<EEKJFDFIEGN, (OPAIBEOPLMG request, int srcIndex)> LAMHHEIMNAC)
	{
		return default(NativeList<EEKJFDFIEGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA780", Offset = "0x2AE8D80", VA = "0x182AEA780")]
	private NativeArray<Entity> ANFBKMOMBKC(NativeList<EEKJFDFIEGN> LDNMHAEAEME)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC090", Offset = "0x2AEA690", VA = "0x182AEC090")]
	private static void JNFFCJDHMGH(Dictionary<EEKJFDFIEGN, (OPAIBEOPLMG request, int srcIndex)> LAMHHEIMNAC, EEKJFDFIEGN HGGMFNJGHIP, OPAIBEOPLMG FEBOEFLLEJB, string ECMAPGHKHFB, int NFPHHBBIOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB7C0", Offset = "0x2AE9DC0", VA = "0x182AEB7C0")]
	private void DHMOLENAAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public KEEBBKGEOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(PGEMPCHAFFA), new string[] { })]
public class PGEMPCHAFFA : EECDFKAILMM, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[LABJLBKOJHN]
	private KDFIBOBNBIO GIGEAGEKEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool MNBPKPMJGNO;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public TimeData IHFAEGLCKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2611150", Offset = "0x260F750", VA = "0x182611150")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x26112B0", Offset = "0x260F8B0", VA = "0x1826112B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KABEPMGIFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x95ED20", Offset = "0x95D320", VA = "0x18095ED20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x165D7B0", Offset = "0x165BDB0", VA = "0x18165D7B0", Slot = "4")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x26111C0", Offset = "0x260F7C0", VA = "0x1826111C0", Slot = "5")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2611210", Offset = "0x260F810", VA = "0x182611210")]
	public void MBHDMEEBGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	public void EAOGFNBDPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public PGEMPCHAFFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[OJJOJOKIEBL(typeof(DEMCMMGHLIH), new string[] { })]
public class NEGONCGLIME : DEMCMMGHLIH, GFOPHFDOHAP, EECDFKAILMM, LPOKOJIEHOF, EMBHBGCIFNL, IDisposable, NEGONCGLIME.KGACHMEDCDM
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal interface KGACHMEDCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GDMGCGNDAMJ(global::KPIICLIMLAK ANEACCBHMEN);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private DFALILEPNOG OJOAPPOPJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private KNHKLDHNHAO KGLOBJOCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private LKEACJPELBE CBIMOLNMMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private global::KPIICLIMLAK DHHNNDEKCEP;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private GBHPCKEHPBF<ENMPPPDAMHN> ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9B35C0", Offset = "0x9B1BC0", VA = "0x1809B35C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B350", Offset = "0x2A89950", VA = "0x182A8B350")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<AMICGDPKLIC> LNFJLNBDNID
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A8ABF0", Offset = "0x2A891F0", VA = "0x182A8ABF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B670", Offset = "0x2A89C70", VA = "0x182A8B670", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x95F6E0", Offset = "0x95DCE0", VA = "0x18095F6E0", Slot = "17")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AF60", Offset = "0x2A89560", VA = "0x182A8AF60", Slot = "18")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B260", Offset = "0x2A89860", VA = "0x182A8B260", Slot = "19")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0xA2A670", Offset = "0xA28C70", VA = "0x180A2A670", Slot = "21")]
	private void OIEBAPMONOC(global::KPIICLIMLAK ANEACCBHMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x95F620", Offset = "0x95DC20", VA = "0x18095F620", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DBF0", Offset = "0x2A7C1F0", VA = "0x182A7DBF0")]
	private ENMPPPDAMHN JACBKPHDPNI(Entity MPAGCMNFGMI)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AA20", Offset = "0x2A89020", VA = "0x182A8AA20", Slot = "6")]
	public ENMPPPDAMHN BGKMIAGKHHM(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B3A0", Offset = "0x2A899A0", VA = "0x182A8B3A0", Slot = "7")]
	public void KKOJGPNJJPO(ref List<ENMPPPDAMHN> BCPEGPJDFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AB40", Offset = "0x2A89140", VA = "0x182A8AB40", Slot = "11")]
	public int DCMOHGLHEDJ(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A900", Offset = "0x2A88F00", VA = "0x182A8A900", Slot = "12")]
	public KIHFNANBKDD AENDFFGDBIH(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A8ADA0", Offset = "0x2A893A0", VA = "0x182A8ADA0", Slot = "15")]
	public ENMPPPDAMHN IBFCCLELLKC(ENMPPPDAMHN LIGIEJOGFAH, ENMPPPDAMHN LFGKHOBDGNE)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B0B0", Offset = "0x2A896B0", VA = "0x182A8B0B0", Slot = "16")]
	public bool JFELDPLAPKL(ENMPPPDAMHN LIGIEJOGFAH, ENMPPPDAMHN LFGKHOBDGNE, out ENMPPPDAMHN EKPEPIHNAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B5D0", Offset = "0x2A89BD0", VA = "0x182A8B5D0", Slot = "8")]
	public ENMPPPDAMHN OPPJHONDIOF(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AC50", Offset = "0x2A89250", VA = "0x182A8AC50", Slot = "14")]
	public bool GGFOGAAPHID(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN IOKDMANFCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A810", Offset = "0x2A88E10", VA = "0x182A8A810", Slot = "13")]
	public bool AAPAIFFLBIH(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN JNMPHJHBJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B030", Offset = "0x2A89630", VA = "0x182A8B030", Slot = "9")]
	public bool JAMGDJKMPGM(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN HDBBNLFBJKG, bool HNOGDNKLDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD40", Offset = "0x2A89340", VA = "0x182A8AD40", Slot = "10")]
	public bool HABHLECNBOO(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN HDBBNLFBJKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public NEGONCGLIME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MDNOMONOICM : HCJLJOEKAAD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HPDFGDDFBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int IMIIEPNOGOA;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> JMBLCPDABCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x90BEC0", Offset = "0x90A4C0", VA = "0x18090BEC0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int JFKOKAMDKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x90DC40", Offset = "0x90C240", VA = "0x18090DC40", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A837A0", Offset = "0x2A81DA0", VA = "0x182A837A0")]
	public MDNOMONOICM(NativeArray<EntityRemapUtility.EntityRemapInfo> HPDFGDDFBDI, int IMIIEPNOGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A83700", Offset = "0x2A81D00", VA = "0x182A83700", Slot = "6")]
	public ENMPPPDAMHN IBMOACNLPCB(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A836C0", Offset = "0x2A81CC0", VA = "0x182A836C0", Slot = "8")]
	public LocalId IBMOACNLPCB(LocalId MPAGCMNFGMI)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A83660", Offset = "0x2A81C60", VA = "0x182A83660", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[OJJOJOKIEBL(typeof(GBHAJEIKFBB), new string[] { })]
[OKNNJFAGDOM(typeof(HMKFBCDDIDP))]
public class KADPNJJDBJD : GBHAJEIKFBB, GFDBIECGPKC, HMKFBCDDIDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker CCJGNAMFIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private PLONEGJPBHK CBMJEICKDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private KGPIAKEFEHB NPKGKGEPBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private LIACCBFBACG KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private JFAJDFHGGNE JBHOOKHIIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private BJDDOFPNFNG GKGOFPCFOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public PLONEGJPBHK FDCDBHOPKIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public LIACCBFBACG MILBJGFKLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BJDDOFPNFNG LJLIENEMEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x95F8C0", Offset = "0x95DEC0", VA = "0x18095F8C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool JLMOFFAFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2AE90B0", Offset = "0x2AE76B0", VA = "0x182AE90B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public INLEBFHADPP FECBIDCJBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x952C20", Offset = "0x951220", VA = "0x180952C20", Slot = "9")]
		get
		{
			return default(INLEBFHADPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9260", Offset = "0x2AE7860", VA = "0x182AE9260")]
	public static KADPNJJDBJD HKLENFAPHAP(PLONEGJPBHK CBMJEICKDDL, MJBNKJMPJPB EJBKGMJFFOC = MJBNKJMPJPB.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void JBMMKAMKAIF(PLONEGJPBHK CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void IBHOPPFGAJD(PLONEGJPBHK CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9130", Offset = "0x2AE7730", VA = "0x182AE9130", Slot = "10")]
	public void GAPKOLLNHGD(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x95F6E0", Offset = "0x95DCE0", VA = "0x18095F6E0")]
	private void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8FE0", Offset = "0x2AE75E0", VA = "0x182AE8FE0")]
	private void BNHNHGMBMLL(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE90D0", Offset = "0x2AE76D0", VA = "0x182AE90D0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public KADPNJJDBJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class KNKMIOAKOHN
{
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, EOACBFHBFAO
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly IAMDAJKPFJC BILPDCGHAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private BLIAAMDKPNO prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private ENMPPPDAMHN HMLJKOHAJKN;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual BLIAAMDKPNO KJCDAPGJJDC
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x928590", Offset = "0x926B90", VA = "0x180928590", Slot = "6")]
			get
			{
				return default(BLIAAMDKPNO);
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xB910F0", Offset = "0xB8F6F0", VA = "0x180B910F0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public ENMPPPDAMHN ILMEFPJAMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0xA72CF0", Offset = "0xA712F0", VA = "0x180A72CF0", Slot = "5")]
			get
			{
				return default(ENMPPPDAMHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool DONKHGNKKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x9C9820", Offset = "0x9C7E20", VA = "0x1809C9820", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x9C9C20", Offset = "0x9C8220", VA = "0x1809C9C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal Entity HIPHDCMNHBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2622950", Offset = "0x2620F50", VA = "0x182622950")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		internal JBBANOPACMB KOKMAEINHGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2622390", Offset = "0x2620990", VA = "0x182622390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		internal KKJOECNGBND MIBOLEGADCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x26228D0", Offset = "0x2620ED0", VA = "0x1826228D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2622380", Offset = "0x2620980", VA = "0x182622380")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x26223A0", Offset = "0x26209A0", VA = "0x1826223A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x26224B0", Offset = "0x2620AB0", VA = "0x1826224B0")]
		internal void GMAKAKECEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2622960", Offset = "0x2620F60", VA = "0x182622960")]
		private bool NABPIPAEPFO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x26228A0", Offset = "0x2620EA0", VA = "0x1826228A0")]
		private void JDIPILAKIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x26223A0", Offset = "0x26209A0", VA = "0x1826223A0")]
		internal void GIBKAEADFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2622A00", Offset = "0x2621000", VA = "0x182622A00")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2622B60", Offset = "0x2621160", VA = "0x182622B60")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class HIOLLPODNHP : OFHJMNAOPCE
{
	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4C60", Offset = "0x2AD3260", VA = "0x182AD4C60", Slot = "5")]
	public override Action AKNEMOCDEEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void NCENHNALHPD<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4CF0", Offset = "0x2AD32F0", VA = "0x182AD4CF0")]
	[UnityEngine.Scripting.Preserve]
	public void NNBIMJFEELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B7F0", Offset = "0x2A89DF0", VA = "0x182A8B7F0")]
	protected HIOLLPODNHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[OJJOJOKIEBL(typeof(MOFMKHOGCPA), new string[] { })]
public class LBFMOKCJLPO : MOFMKHOGCPA, IDisposable, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[LABJLBKOJHN]
	private AKLHOJFEEEF OPHCCOJAHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[LABJLBKOJHN]
	private DLBAJHIENKP DCDGMLDKCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private World MBCLAANGHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private World IJNKKJPPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool GLECDIBBKJJ;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public World FKLPOCBLLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public World DFLOMKCOJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2A75840", Offset = "0x2A73E40", VA = "0x182A75840", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1CDDF30", Offset = "0x1CDC530", VA = "0x181CDDF30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2A75620", Offset = "0x2A73C20", VA = "0x182A75620", Slot = "10")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2A75490", Offset = "0x2A73A90", VA = "0x182A75490")]
	private void HKLENFAPHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2A75190", Offset = "0x2A73790", VA = "0x182A75190", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2A75170", Offset = "0x2A73770", VA = "0x182A75170", Slot = "8")]
	public ComponentSystemBase AMDBIEEGCPG(Type KLGGKKGCLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public LBFMOKCJLPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[OJJOJOKIEBL(typeof(CHHJACLANGJ), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public class CHHJACLANGJ : LPOKOJIEHOF, IAJAPMLMEJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct EFGOOPEPFHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private NativeArray<int> OECPLGKNIHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private NativeArray<int> OAKNKJJEPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Dictionary<ComponentSystemBase, int> NLJMGLJOGCK;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x28F1DA0", Offset = "0x28F03A0", VA = "0x1828F1DA0")]
		public EFGOOPEPFHN(NativeArray<int> OECPLGKNIHG, NativeArray<int> OAKNKJJEPHP, Dictionary<ComponentSystemBase, int> NLJMGLJOGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x28F1C70", Offset = "0x28F0270", VA = "0x1828F1C70")]
		public static void IOCKIDIPDGN(World DDODGIBMPPP, AGPDIMMFKMP DHABJNALEDA, NativeArray<int> OECPLGKNIHG, NativeArray<int> OAKNKJJEPHP, Dictionary<ComponentSystemBase, int> NLJMGLJOGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x28F19E0", Offset = "0x28EFFE0", VA = "0x1828F19E0")]
		public void AAJFDFDEKBD(IEnumerable<ComponentSystemBase> NPKGKGEPBBI, AGPDIMMFKMP DHABJNALEDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class ECGBGINLIGI : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private ComponentSystemBase <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private int start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int <>3__start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private int end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public int <>3__end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public CHHJACLANGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private int <i>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x97B9F0", Offset = "0x979FF0", VA = "0x18097B9F0")]
		[DebuggerHidden]
		public ECGBGINLIGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x28F17D0", Offset = "0x28EFDD0", VA = "0x1828F17D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x28F19A0", Offset = "0x28EFFA0", VA = "0x1828F19A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x28F18F0", Offset = "0x28EFEF0", VA = "0x1828F18F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x28F18F0", Offset = "0x28EFEF0", VA = "0x1828F18F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly IAMDAJKPFJC FMGFIBBEAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private World DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private LIFCBCFOLBC CBMJEICKDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private NativeArray<int> EKCDPOKMAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private NativeArray<int> IMNPAGMFAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int MPNDOHBKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private AGPDIMMFKMP JPPDHNCANCP;

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x27D19A0", Offset = "0x27CFFA0", VA = "0x1827D19A0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x27D1460", Offset = "0x27CFA60", VA = "0x1827D1460", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x27D1A80", Offset = "0x27D0080", VA = "0x1827D1A80")]
	[IteratorStateMachine(typeof(ECGBGINLIGI))]
	private IEnumerable<ComponentSystemBase> JDGLLKDCFIJ(int FIDLKHDDPII, int HOLOHKLLGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x27D1380", Offset = "0x27CF980", VA = "0x1827D1380", Slot = "5")]
	public void FABNKKNBIDK(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x27D1380", Offset = "0x27CF980", VA = "0x1827D1380")]
	private void CHBPCBKDFIJ(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x27D1270", Offset = "0x27CF870", VA = "0x1827D1270")]
	public void CHBPCBKDFIJ(AGPDIMMFKMP NOFPDBLDIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x27D16C0", Offset = "0x27CFCC0", VA = "0x1827D16C0")]
	private void IOODGGMPENB(AGPDIMMFKMP NOFPDBLDIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x27D1B10", Offset = "0x27D0110", VA = "0x1827D1B10")]
	private void JLKDBCNPNIH(AGPDIMMFKMP NOFPDBLDIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x27D1D20", Offset = "0x27D0320", VA = "0x1827D1D20")]
	private void NLPNNDGEDGG(AGPDIMMFKMP NOFPDBLDIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x27D0CA0", Offset = "0x27CF2A0", VA = "0x1827D0CA0")]
	private void AHNEDEBCIAL(int FIDLKHDDPII, int HOLOHKLLGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x27D1BB0", Offset = "0x27D01B0", VA = "0x1827D1BB0")]
	private void MBCCELBELFD(int FIDLKHDDPII, int HOLOHKLLGJH, bool LHEAMNILFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x27D14F0", Offset = "0x27CFAF0", VA = "0x1827D14F0")]
	private int FBEJKMEKIBP(AGPDIMMFKMP NOFPDBLDIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x27D0D60", Offset = "0x27CF360", VA = "0x1827D0D60")]
	private bool AOFCODCHOAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x27D1510", Offset = "0x27CFB10", VA = "0x1827D1510")]
	private Dictionary<ComponentSystemBase, int> GNNBLODMKMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x27D1960", Offset = "0x27CFF60", VA = "0x1827D1960")]
	private void IPNBFIGDIOL(NativeArray<int> OECPLGKNIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x27D1C70", Offset = "0x27D0270", VA = "0x1827D1C70")]
	private void NFBJFOPEIEM(NativeArray<int> OAKNKJJEPHP, NativeArray<int> OECPLGKNIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x27D1600", Offset = "0x27CFC00", VA = "0x1827D1600")]
	private static AGPDIMMFKMP HCJJEBKKPLI(Type KLGGKKGCLHM, AGPDIMMFKMP INIEFLCMFEE)
	{
		return default(AGPDIMMFKMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x27D1E60", Offset = "0x27D0460", VA = "0x1827D1E60")]
	public CHHJACLANGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x27D1400", Offset = "0x27CFA00", VA = "0x1827D1400")]
	[CompilerGenerated]
	private void DIOEJJFKFIC(LPOKOJIEHOF NDNKHLAHDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x27D1660", Offset = "0x27CFC60", VA = "0x1827D1660")]
	[CompilerGenerated]
	private void IJJMEDNFOAH(EMBHBGCIFNL NDNKHLAHDDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class KOFNPKPLLLG : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2A73A40", Offset = "0x2A72040", VA = "0x182A73A40", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2A739C0", Offset = "0x2A71FC0", VA = "0x182A739C0")]
	[UnityEngine.Scripting.Preserve]
	private void CDAMGLICKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public KOFNPKPLLLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[OJJOJOKIEBL(typeof(BJDDOFPNFNG), new string[] { })]
public class EELFEKMIOKP : BJDDOFPNFNG, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly IAMDAJKPFJC HHNLPDLGNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private PLONEGJPBHK CBMJEICKDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private JFAJDFHGGNE JBHOOKHIIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private LIACCBFBACG KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private GBHAJEIKFBB DDHJCLEIKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private KIMCOPEIFEL JBAGHABAFME;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool NOOJJKLFPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x24A07B0", Offset = "0x249EDB0", VA = "0x1824A07B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action PFEALLMEGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x24A0C00", Offset = "0x249F200", VA = "0x1824A0C00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x24A0820", Offset = "0x249EE20", VA = "0x1824A0820", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x24A0AC0", Offset = "0x249F0C0", VA = "0x1824A0AC0", Slot = "15")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x24A0B90", Offset = "0x249F190", VA = "0x1824A0B90", Slot = "11")]
	public Task JDOJOAEDJKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x24A0990", Offset = "0x249EF90", VA = "0x1824A0990", Slot = "12")]
	public Task FOGFEPAAOAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x24A08C0", Offset = "0x249EEC0", VA = "0x1824A08C0", Slot = "13")]
	public Task ENHLJCPFJOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x24A04F0", Offset = "0x249EAF0", VA = "0x1824A04F0", Slot = "8")]
	public void BPMDNCBPCGA(bool LHEAMNILFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x24A0930", Offset = "0x249EF30", VA = "0x1824A0930", Slot = "9")]
	public bool FCDPDOGHPFL(ByteString NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x24A0460", Offset = "0x249EA60", VA = "0x1824A0460", Slot = "6")]
	public void AOJHDNCDBFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x924E20", Offset = "0x923420", VA = "0x180924E20", Slot = "7")]
	public void AHOCCNCOJEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x24A0A00", Offset = "0x249F000", VA = "0x1824A0A00", Slot = "14")]
	public void HBACKNBGODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public EELFEKMIOKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[Flags]
public enum MJBNKJMPJPB
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[OJJOJOKIEBL(typeof(HAHLNIGCPKJ), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public class HAHLNIGCPKJ : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[LABJLBKOJHN]
	private JJNJPCKJNLO EBBPNBJKOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[LABJLBKOJHN]
	private CHHJACLANGJ HBAIEOIONBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[LABJLBKOJHN]
	private MKBGHPFKLIO HLHINDIFOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[LABJLBKOJHN]
	private LKEACJPELBE CBIMOLNMMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x24BC4D0", Offset = "0x24BAAD0", VA = "0x1824BC4D0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x24BC3F0", Offset = "0x24BA9F0", VA = "0x1824BC3F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x24BC440", Offset = "0x24BAA40", VA = "0x1824BC440")]
	private void IOBDNLLPMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x24BC3F0", Offset = "0x24BA9F0", VA = "0x1824BC3F0")]
	private void HBLOCNDBLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x24BC630", Offset = "0x24BAC30", VA = "0x1824BC630")]
	private void JELIALKIODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public HAHLNIGCPKJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public EntityReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(MBOAMGKJHBK), new string[] { })]
internal class MBOAMGKJHBK : LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private MKPEFGNMDIP KGHDEFAENMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private MLDDOPEDHJJ PONLAGOFGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private HMNOEMALJPC LNDOGCKMLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[LABJLBKOJHN]
	private FOKGJFJPKEK FJNPCKPLFNE;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public GBEMJDIMABH CBGGKHBHMKM
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x9B3590", Offset = "0x9B1B90", VA = "0x1809B3590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2A81A40", Offset = "0x2A80040", VA = "0x182A81A40", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2A818D0", Offset = "0x2A7FED0", VA = "0x182A818D0")]
	private void ENDAHLLHHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2A81970", Offset = "0x2A7FF70", VA = "0x182A81970")]
	public EPFAAOCCGEJ HNBNOLKMJJE(CNGBAJDBKGM ECMAPGHKHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x1A97F20", Offset = "0x1A96520", VA = "0x181A97F20")]
	public DNOOFDDJJON<T> BOOAJBEEGJA<T>(CNGBAJDBKGM ECMAPGHKHFB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public MBOAMGKJHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal static class OJIGGMIDFHA
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2301B30", Offset = "0x2300130", VA = "0x182301B30")]
	public static FEHHJLHONFC<T> HNBNOLKMJJE<T>(this MBOAMGKJHBK KGKPHOOBHCK, GOHNKJBJJHB<T> ECMAPGHKHFB) where T : struct
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x260EB60", Offset = "0x260D160", VA = "0x18260EB60")]
		public static ObjectModelConfigAsset CPJCIBHBKEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9341D0", Offset = "0x9327D0", VA = "0x1809341D0")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class OFHJMNAOPCE : BJJALCMLNEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly MethodInfo LINBJOLFAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Type[] CHPIMGNELOI;

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x260C130", Offset = "0x260A730", VA = "0x18260C130")]
	public OFHJMNAOPCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action AKNEMOCDEEE();

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x260BF40", Offset = "0x260A540", VA = "0x18260BF40")]
	public MethodInfo CFHJGFMKHNL(Action ILLCNPCAHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x260BF80", Offset = "0x260A580", VA = "0x18260BF80", Slot = "4")]
	public void MBACIJOLGCB(Type KLGGKKGCLHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[OKNNJFAGDOM(typeof(FHGGPNINHMB))]
[OJJOJOKIEBL(typeof(KIMCOPEIFEL), new string[] { })]
internal class FHGGPNINHMB : KIMCOPEIFEL, IDisposable, LPOKOJIEHOF, IAJAPMLMEJC
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class KJDGPDDFLCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public FHGGPNINHMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public KJDGPDDFLCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x28F7F70", Offset = "0x28F6570", VA = "0x1828F7F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly IAMDAJKPFJC HHNLPDLGNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[LABJLBKOJHN]
	private LIACCBFBACG KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[LABJLBKOJHN]
	private BJDDOFPNFNG GKGOFPCFOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[LABJLBKOJHN]
	private FALLAGCDOFB IMCDONHNOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[LABJLBKOJHN]
	private JFAJDFHGGNE JBHOOKHIIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private GBHAJEIKFBB DDHJCLEIKGO;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool PLOAKCIGKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x95F8C0", Offset = "0x95DEC0", VA = "0x18095F8C0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x95F610", Offset = "0x95DC10", VA = "0x18095F610", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool KILEJPECOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xFFFDC0", Offset = "0xFFE3C0", VA = "0x180FFFDC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool DNPAFPKHOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEE0", Offset = "0x9DA4E0", VA = "0x1809DBEE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE50", Offset = "0x9DA450", VA = "0x1809DBE50", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public KOMGFJFAEGJ AJNFLPECFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA2A670", Offset = "0xA28C70", VA = "0x180A2A670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x24AF6B0", Offset = "0x24ADCB0", VA = "0x1824AF6B0", Slot = "16")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x24AF380", Offset = "0x24AD980", VA = "0x1824AF380", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x24AF950", Offset = "0x24ADF50", VA = "0x1824AF950", Slot = "8")]
	public CBENEIMMAGE OILCMLAGOGI(bool NPAEINNJCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x24AE770", Offset = "0x24ACD70", VA = "0x1824AE770")]
	public CBENEIMMAGE OADODCHKOBB(IEnumerable<ENMPPPDAMHN> LNIELCFLEJE, in ABJGEIBOMMO GOALPJDNEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x24AF130", Offset = "0x24AD730", VA = "0x1824AF130", Slot = "10")]
	public GGFHOFNANBO DKFOBHGHNEB(ByteString NFNCBDOMNAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x24AEB40", Offset = "0x24AD140", VA = "0x1824AEB40")]
	public CINHJBLABIP BOGGHPCCNBA(ByteString NFNCBDOMNAL, ENMPPPDAMHN HDBBNLFBJKG, in ABJGEIBOMMO KIGHPCHNDDE, HKACBKPJJFC FKCOMMJANEB, bool NNJNPPDBNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x24AF780", Offset = "0x24ADD80", VA = "0x1824AF780", Slot = "12")]
	public void JJBLIOOKDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x24AE910", Offset = "0x24ACF10", VA = "0x1824AE910", Slot = "14")]
	public FBGEKGCCCOL BGLNABMJEEI(IEnumerable<OPAIBEOPLMG> OGIMNFBMPBJ)
	{
		return default(FBGEKGCCCOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x24AF490", Offset = "0x24ADA90", VA = "0x1824AF490")]
	public static bool FCDPDOGHPFL(ByteString NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x24AED90", Offset = "0x24AD390", VA = "0x1824AED90", Slot = "13")]
	public void CAAFBHBLFHN(bool OAJAEIBGHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x24AED30", Offset = "0x24AD330", VA = "0x1824AED30")]
	private void BPMDNCBPCGA(bool LHEAMNILFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x24AF380", Offset = "0x24AD980", VA = "0x1824AF380")]
	private void MDPBMONELPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x113F570", Offset = "0x113DB70", VA = "0x18113F570")]
	private void BAEIBLMHMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x24AE710", Offset = "0x24ACD10", VA = "0x1824AE710")]
	private void AIOPCFMDJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x24AF3E0", Offset = "0x24AD9E0", VA = "0x1824AF3E0", Slot = "17")]
	public void FABNKKNBIDK(LIFCBCFOLBC JOHABFNLMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public FHGGPNINHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x24AE770", Offset = "0x24ACD70", VA = "0x1824AE770", Slot = "9")]
	private CBENEIMMAGE BBEKPDKBECA(IEnumerable<ENMPPPDAMHN> LNIELCFLEJE, in ABJGEIBOMMO GOALPJDNEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x24AEF30", Offset = "0x24AD530", VA = "0x1824AEF30", Slot = "11")]
	private CINHJBLABIP DDABKHGAFBB(ByteString NFNCBDOMNAL, ENMPPPDAMHN HDBBNLFBJKG, in ABJGEIBOMMO KIGHPCHNDDE, HKACBKPJJFC FKCOMMJANEB, bool NNJNPPDBNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x24AF590", Offset = "0x24ADB90", VA = "0x1824AF590")]
	[CompilerGenerated]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KJDGPDDFLCK))]
	private Task GOLPHJPNCNL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct AJFPGPJMNEB : IEnumerable<DJJFLCIGBCG>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum GHLGNFHBBHH
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct KHCLOBFONFE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private NativeList<byte> JAIGDBINGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private AJFPGPJMNEB CKIKFMIOAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly DJJFLCIGBCG PAKFOBAPADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private readonly int FIDLKHDDPII;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x28F7370", Offset = "0x28F5970", VA = "0x1828F7370")]
		internal KHCLOBFONFE(AJFPGPJMNEB CKIKFMIOAHP, DJJFLCIGBCG PAKFOBAPADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x28F7190", Offset = "0x28F5790", VA = "0x1828F7190", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x28F71C0", Offset = "0x28F57C0", VA = "0x1828F71C0")]
		public void GGELLKBBCGB(ReadOnlySpan<byte> MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x28F72D0", Offset = "0x28F58D0", VA = "0x1828F72D0")]
		private void KJPKKGJAHHG(ReadOnlySpan<byte> MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x28F7270", Offset = "0x28F5870", VA = "0x1828F7270")]
		private unsafe void KJPKKGJAHHG(void* GIODGDIBNNN, int BFDDLCIBNMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct LNPPHABOGLO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private AJFPGPJMNEB CKIKFMIOAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private NativeArray<byte> JAIGDBINGHO;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x28F93F0", Offset = "0x28F79F0", VA = "0x1828F93F0")]
		internal LNPPHABOGLO(AJFPGPJMNEB CKIKFMIOAHP, NativeArray<byte> JAIGDBINGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x28F91E0", Offset = "0x28F77E0", VA = "0x1828F91E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x28F91F0", Offset = "0x28F77F0", VA = "0x1828F91F0")]
		public NativeArray<byte> GHJPAECMLKP(int BFDDLCIBNMB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x28F92B0", Offset = "0x28F78B0", VA = "0x1828F92B0")]
		public void KGKHGDJJNFO(Span<byte> MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public struct LPENJLNGMDF : IEnumerator<DJJFLCIGBCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly NativeList<DJJFLCIGBCG> IACDCADJJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int OLGOBCPPPBB;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public DJJFLCIGBCG PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x28F9680", Offset = "0x28F7C80", VA = "0x1828F9680", Slot = "4")]
			get
			{
				return default(DJJFLCIGBCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x28F9640", Offset = "0x28F7C40", VA = "0x1828F9640", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x28F94F0", Offset = "0x28F7AF0", VA = "0x1828F94F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x28F9600", Offset = "0x28F7C00", VA = "0x1828F9600", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private struct LPMGHDBBBEG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private NativeArray<int> JAIGDBINGHO;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool ALFPHPKCOIP
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x28F9800", Offset = "0x28F7E00", VA = "0x1828F9800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int AAFEMOOMDEF
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x28F97C0", Offset = "0x28F7DC0", VA = "0x1828F97C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x28F9760", Offset = "0x28F7D60", VA = "0x1828F9760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public GHLGNFHBBHH GHDMPILDDBF
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x28F96F0", Offset = "0x28F7CF0", VA = "0x1828F96F0")]
			get
			{
				return default(GHLGNFHBBHH);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x28F97B0", Offset = "0x28F7DB0", VA = "0x1828F97B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool EGOIGDHGIHM
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x28F9740", Offset = "0x28F7D40", VA = "0x1828F9740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool LPBIACKLGCL
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x28F96D0", Offset = "0x28F7CD0", VA = "0x1828F96D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x28F9840", Offset = "0x28F7E40", VA = "0x1828F9840")]
		public LPMGHDBBBEG(GHLGNFHBBHH PEFLMFMOFNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x28F97D0", Offset = "0x28F7DD0", VA = "0x1828F97D0")]
		private int MBNHJLNEIKL(int EBMCNIDEEKK, int CFEPMABPDCD = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x28F9770", Offset = "0x28F7D70", VA = "0x1828F9770")]
		private void FGMAFKALEHD(int EBMCNIDEEKK, int MOLEJFDINLH, int CFEPMABPDCD = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x28F9700", Offset = "0x28F7D00", VA = "0x1828F9700", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly DJJFLCIGBCG IKDNBDPHELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeParallelHashMap<DJJFLCIGBCG, int> NNHOINBLHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NativeList<DJJFLCIGBCG> IMCDONHNOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private NativeList<int> IMNPAGMFAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeList<byte> HABGKHECPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private NativeList<byte> JAIGDBINGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private LPMGHDBBBEG FKGPFMNALNI;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x27C15D0", Offset = "0x27BFBD0", VA = "0x1827C15D0")]
	public static AJFPGPJMNEB HKLENFAPHAP(GHLGNFHBBHH PEFLMFMOFNM = GHLGNFHBBHH.Last, int KNPLBLPFEEM = 16, int GOMIINCCMOG = 256)
	{
		return default(AJFPGPJMNEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x27C1BB0", Offset = "0x27C01B0", VA = "0x1827C1BB0")]
	private AJFPGPJMNEB(GHLGNFHBBHH PEFLMFMOFNM, int KNPLBLPFEEM, int GOMIINCCMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x27C1320", Offset = "0x27BF920", VA = "0x1827C1320", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x27C1610", Offset = "0x27BFC10", VA = "0x1827C1610")]
	public KHCLOBFONFE JOMHLPAOCKJ(DJJFLCIGBCG PAKFOBAPADB)
	{
		return default(KHCLOBFONFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x27C1130", Offset = "0x27BF730", VA = "0x1827C1130")]
	public bool BHEOKFKOFPC(DJJFLCIGBCG PAKFOBAPADB, out LNPPHABOGLO GIPCEGJMFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x27C10E0", Offset = "0x27BF6E0", VA = "0x1827C10E0")]
	public bool AONGCONJBGE(DJJFLCIGBCG PAKFOBAPADB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x27C19E0", Offset = "0x27BFFE0", VA = "0x1827C19E0")]
	public bool PPMACKDNLMO(DJJFLCIGBCG PAKFOBAPADB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x27C14F0", Offset = "0x27BFAF0", VA = "0x1827C14F0")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x27C17F0", Offset = "0x27BFDF0", VA = "0x1827C17F0")]
	private void MMKLCEMHNDB(DJJFLCIGBCG PAKFOBAPADB, int FIDLKHDDPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x27C1700", Offset = "0x27BFD00", VA = "0x1827C1700")]
	private void KADMKAFAGGF(int MNPIGLOICMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x27C1400", Offset = "0x27BFA00", VA = "0x1827C1400")]
	private void EMEPEOMAIEC(DJJFLCIGBCG PAKFOBAPADB, int FIDLKHDDPII, int BFDDLCIBNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x27C1AF0", Offset = "0x27C00F0", VA = "0x1827C1AF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x27C1AB0", Offset = "0x27C00B0", VA = "0x1827C1AB0", Slot = "4")]
	private IEnumerator<DJJFLCIGBCG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[DisallowMultipleComponent]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public override BLIAAMDKPNO KJCDAPGJJDC
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x261F990", Offset = "0x261DF90", VA = "0x18261F990", Slot = "6")]
			get
			{
				return default(BLIAAMDKPNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x261F930", Offset = "0x261DF30", VA = "0x18261F930")]
		public RbexEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class GGKKIEOPDEN
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public static class GMHNNGGNHOE
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly IAMDAJKPFJC BILPDCGHAAG;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x28F3B70", Offset = "0x28F2170", VA = "0x1828F3B70")]
		public static EEKJFDFIEGN GFNNJBBDOJH(int DCCOPIIMEGC, KOMGFJFAEGJ KMPBAECDEGL)
		{
			return default(EEKJFDFIEGN);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x28F41C0", Offset = "0x28F27C0", VA = "0x1828F41C0")]
		private static ENMPPPDAMHN PFHBPGIHKIG(KOMGFJFAEGJ JFKFIHJGDNH, ENMPPPDAMHN BDHIOIDCJCA)
		{
			return default(ENMPPPDAMHN);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x28F4010", Offset = "0x28F2610", VA = "0x1828F4010")]
		private static void JBGAPBHNPHE(ENMPPPDAMHN AAKDCAADKKM, ENMPPPDAMHN JDCCNKODBOL, EEKJFDFIEGN HGGMFNJGHIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x28F3910", Offset = "0x28F1F10", VA = "0x1828F3910")]
		public static int EEANOGLLMJF(GameObject FLCGKEKAMCK, CBENEIMMAGE GKEPEHBMBBD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static PLONEGJPBHK KMDHBPEEFAG;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static GBHAJEIKFBB DDHJCLEIKGO;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public static GBHAJEIKFBB EIINDPADGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x24B3E00", Offset = "0x24B2400", VA = "0x1824B3E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public static bool PMMOIALJGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x24B4840", Offset = "0x24B2E40", VA = "0x1824B4840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public static LIFCBCFOLBC FDCDBHOPKIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x24B4D60", Offset = "0x24B3360", VA = "0x1824B4D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public static KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x24B4660", Offset = "0x24B2C60", VA = "0x1824B4660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public static LJIKPIOGIDO ICDANIPJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x24B4540", Offset = "0x24B2B40", VA = "0x1824B4540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public static JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x24B4200", Offset = "0x24B2800", VA = "0x1824B4200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public static DEMCMMGHLIH FBPKJDCDANM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x24B4FC0", Offset = "0x24B35C0", VA = "0x1824B4FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public static MDHPMKEGPDB PMDIGCLFBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x24B3C40", Offset = "0x24B2240", VA = "0x1824B3C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public static bool BIOLNBKCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x24B4CE0", Offset = "0x24B32E0", VA = "0x1824B4CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public static bool GDDGHECJBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x24B49E0", Offset = "0x24B2FE0", VA = "0x1824B49E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public static NILFLMGAFIC CFNMMJKEMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x24B4BA0", Offset = "0x24B31A0", VA = "0x1824B4BA0")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public static bool JBFLJDNKCBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x24B45C0", Offset = "0x24B2BC0", VA = "0x1824B45C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public static byte BMNDBCFOJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x24B4EA0", Offset = "0x24B34A0", VA = "0x1824B4EA0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public static bool EMGKOCNOGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x24B4DE0", Offset = "0x24B33E0", VA = "0x1824B4DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public static bool LAMJDIKNJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x24B4E40", Offset = "0x24B3440", VA = "0x1824B4E40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x24B40A0", Offset = "0x24B26A0", VA = "0x1824B40A0")]
	public static void BMGFMFECLCG(PLONEGJPBHK MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x24B4280", Offset = "0x24B2880", VA = "0x1824B4280")]
	public static ENMPPPDAMHN FBGOFHNIPBN(GameObject FLCGKEKAMCK)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x24B4A30", Offset = "0x24B3030", VA = "0x1824B4A30")]
	public static NILFLMGAFIC HGFDBJCIECH(EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x24B4400", Offset = "0x24B2A00", VA = "0x1824B4400")]
	public static bool FHLEAMPBBLD(GameObject FLCGKEKAMCK, out EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x24B3F60", Offset = "0x24B2560", VA = "0x1824B3F60")]
	public static FBGEKGCCCOL BGLNABMJEEI(IEnumerable<OPAIBEOPLMG> OGIMNFBMPBJ)
	{
		return default(FBGEKGCCCOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x24B3CC0", Offset = "0x24B22C0", VA = "0x1824B3CC0")]
	public static void AEEDBBLLMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x24B5040", Offset = "0x24B3640", VA = "0x1824B5040")]
	private static GBHAJEIKFBB ONNDJKOPKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x24B46E0", Offset = "0x24B2CE0", VA = "0x1824B46E0")]
	private static bool GLBMKPMDFKB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class CBDGFMKJMNB
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct DJJFLCIGBCG : IComparable<DJJFLCIGBCG>, IEquatable<DJJFLCIGBCG>
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly DJJFLCIGBCG CJBAGCINGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public EEKJFDFIEGN GIAMACBDIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public BENLOGNDJHK FPNKFNICEDM;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public bool JJDFFNAFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x27D8650", Offset = "0x27D6C50", VA = "0x1827D8650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xA54600", Offset = "0xA52C00", VA = "0x180A54600")]
	public DJJFLCIGBCG(EEKJFDFIEGN GIAMACBDIFH, BENLOGNDJHK FPNKFNICEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x27D84E0", Offset = "0x27D6AE0", VA = "0x1827D84E0", Slot = "4")]
	public int CompareTo(DJJFLCIGBCG FKJGPCABBJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x27D8660", Offset = "0x27D6C60", VA = "0x1827D8660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x27D8570", Offset = "0x27D6B70", VA = "0x1827D8570", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x27D8520", Offset = "0x27D6B20", VA = "0x1827D8520", Slot = "5")]
	public bool Equals(DJJFLCIGBCG FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x27D8610", Offset = "0x27D6C10", VA = "0x1827D8610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
[OJJOJOKIEBL(typeof(CDCLIAFLPOD), new string[] { })]
internal class CDCLIAFLPOD : LPOKOJIEHOF, EMBHBGCIFNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private KKJOECNGBND JEAKBAFPNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private FEHHJLHONFC<Entity> HDBBNLFBJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private LKEACJPELBE NNKCFAHPEMD;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x27CE6B0", Offset = "0x27CCCB0", VA = "0x1827CE6B0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x27CE850", Offset = "0x27CCE50", VA = "0x1827CE850", Slot = "5")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x27CE610", Offset = "0x27CCC10", VA = "0x1827CE610", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x27CE720", Offset = "0x27CCD20", VA = "0x1827CE720")]
	private void JMKPCFEEOBP(Entity MPAGCMNFGMI, in NGKHEJGAHGD MDNKPPKLBGD, in NGKHEJGAHGD KIFJIAOCCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public CDCLIAFLPOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(IECCFLHBGNJ), new string[] { })]
internal class IECCFLHBGNJ : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[LABJLBKOJHN]
	private MKPEFGNMDIP EGDOOPNCMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Dictionary<int, DEECNKLJPLJ> BMBBLGDPHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8410", Offset = "0x2AD6A10", VA = "0x182AD8410", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7E40", Offset = "0x2AD6440", VA = "0x182AD7E40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8200", Offset = "0x2AD6800", VA = "0x182AD8200")]
	public DEECNKLJPLJ IGCGEFGEINI(CNGBAJDBKGM EFINPLKEDMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AD80C0", Offset = "0x2AD66C0", VA = "0x182AD80C0")]
	public DEECNKLJPLJ IGCGEFGEINI(BENLOGNDJHK FPNKFNICEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7FA0", Offset = "0x2AD65A0", VA = "0x182AD7FA0")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8460", Offset = "0x2AD6A60", VA = "0x182AD8460")]
	public IECCFLHBGNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(LOJCBCHKHID), new string[] { })]
public class LOJCBCHKHID
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public struct LKKMIHODDLC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly LOJCBCHKHID HDBBNLFBJKG;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x28F9150", Offset = "0x28F7750", VA = "0x1828F9150", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private int BMMLHFLCANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action OAMHFLDPPFC;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A80B30", Offset = "0x2A7F130", VA = "0x182A80B30")]
	public void PNGOKJFKMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public LOJCBCHKHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DefaultMember("Item")]
public class BDIDKAHDKNJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly Func<From, To> NJEILCFGOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly Func<To, From> LOBHIBJKDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<From> IACDCADJJAN;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public To ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x250DF30", Offset = "0x250C530", VA = "0x18250DF30", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x250DF80", Offset = "0x250C580", VA = "0x18250DF80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x250DEF0", Offset = "0x250C4F0", VA = "0x18250DEF0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool MIKIMACELCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x22445A0", Offset = "0x2242BA0", VA = "0x1822445A0")]
	public BDIDKAHDKNJ(Func<From, To> NJEILCFGOPJ, Func<To, From> LOBHIBJKDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x250DB00", Offset = "0x250C100", VA = "0x18250DB00", Slot = "11")]
	public void Add(To MDCAOIKFJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x250DB40", Offset = "0x250C140", VA = "0x18250DB40", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x250DB80", Offset = "0x250C180", VA = "0x18250DB80", Slot = "13")]
	public bool Contains(To MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x250DC40", Offset = "0x250C240", VA = "0x18250DC40", Slot = "14")]
	public void CopyTo(To[] IACDCADJJAN, int AJIOAJHCAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x250DD00", Offset = "0x250C300", VA = "0x18250DD00", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x250DDC0", Offset = "0x250C3C0", VA = "0x18250DDC0", Slot = "6")]
	public int IndexOf(To MDCAOIKFJBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x250DE30", Offset = "0x250C430", VA = "0x18250DE30", Slot = "7")]
	public void Insert(int OLGOBCPPPBB, To MDCAOIKFJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x250DEB0", Offset = "0x250C4B0", VA = "0x18250DEB0", Slot = "15")]
	public bool Remove(To MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x250DE70", Offset = "0x250C470", VA = "0x18250DE70", Slot = "8")]
	public void RemoveAt(int OLGOBCPPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x218B370", Offset = "0x2189970", VA = "0x18218B370", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DKCELLAMNKK]
public class MFGGOCOFPHE : ComponentSystem, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private LIFCBCFOLBC FDCDBHOPKIM
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x9B3590", Offset = "0x9B1B90", VA = "0x1809B3590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xA2A670", Offset = "0xA28C70", VA = "0x180A2A670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2A83B40", Offset = "0x2A82140", VA = "0x182A83B40", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
	public MFGGOCOFPHE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, FCLHKJAHMCN, EOACBFHBFAO
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private static readonly IAMDAJKPFJC BILPDCGHAAG;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private const string PEKMOJFPEHK = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CBGIFDDBMPC ILFDGGGKIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private ENMPPPDAMHN GIAMACBDIFH;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public ENMPPPDAMHN ILMEFPJAMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x24A2AF0", Offset = "0x24A10F0", VA = "0x1824A2AF0", Slot = "15")]
			get
			{
				return default(ENMPPPDAMHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public NILFLMGAFIC LKMDIOHLICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x24A2BA0", Offset = "0x24A11A0", VA = "0x1824A2BA0", Slot = "6")]
			get
			{
				return default(NILFLMGAFIC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool DONKHGNKKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x24A2AE0", Offset = "0x24A10E0", VA = "0x1824A2AE0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public CBGIFDDBMPC JGKJEDKNFHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xBE6AB0", Offset = "0xBE50B0", VA = "0x180BE6AB0", Slot = "7")]
			get
			{
				return default(CBGIFDDBMPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		private KGPIAKEFEHB BPIOEGFNGKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x24A20A0", Offset = "0x24A06A0", VA = "0x1824A20A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool HNHJKJJOBEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x9C9820", Offset = "0x9C7E20", VA = "0x1809C9820", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x9C9C20", Offset = "0x9C8220", VA = "0x1809C9C20", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<bool> LJJJNBDDBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x24A29A0", Offset = "0x24A0FA0", VA = "0x1824A29A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x24A2BE0", Offset = "0x24A11E0", VA = "0x1824A2BE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<FCLHKJAHMCN> FIFJLAIOLNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x24A2A40", Offset = "0x24A1040", VA = "0x1824A2A40", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x24A2C80", Offset = "0x24A1280", VA = "0x1824A2C80", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x24A1E90", Offset = "0x24A0490", VA = "0x1824A1E90")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x24A26F0", Offset = "0x24A0CF0", VA = "0x1824A26F0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x24A2190", Offset = "0x24A0790", VA = "0x1824A2190", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x24A2670", Offset = "0x24A0C70", VA = "0x1824A2670", Slot = "10")]
		public void OnEmbody(MOFMKHOGCPA DDODGIBMPPP, ENMPPPDAMHN GIAMACBDIFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x24A26E0", Offset = "0x24A0CE0", VA = "0x1824A26E0", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x24A24C0", Offset = "0x24A0AC0", VA = "0x1824A24C0", Slot = "12")]
		public void OnDisembody(bool ICKNPJNMEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x24A1D20", Offset = "0x24A0320", VA = "0x1824A1D20")]
		private void ACEBCOLAFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x24A2130", Offset = "0x24A0730", VA = "0x1824A2130", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x9C9830", Offset = "0x9C7E30", VA = "0x1809C9830", Slot = "9")]
		private GameObject OEDBNPCBNBJ()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public class DNOOFDDJJON<T> : GBHPCKEHPBF<T>, CGAFBLACJDG<ENMPPPDAMHN, T>, ELEHKEJLDOI<ENMPPPDAMHN>, DPMGHPGKEOP, IDisposable, GCPINDOJNBO where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly ELEHKEJLDOI<Entity> JCPKNOEICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Delegate ABBOCJPHDAE;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x22760E0", Offset = "0x22746E0", VA = "0x1822760E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Type BJFLOLKBEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x22774E0", Offset = "0x2275AE0", VA = "0x1822774E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public ELBEJOMIKKE BPNKBLLBHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2275200", Offset = "0x2273800", VA = "0x182275200", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int DACJLJGFJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2275730", Offset = "0x2273D30", VA = "0x182275730", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public GFLOPFFPDHK KEMBFLMAFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x22756E0", Offset = "0x2273CE0", VA = "0x1822756E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event OOHBGLFCNLM<ENMPPPDAMHN> NBFJOBLBGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2276130", Offset = "0x2274730", VA = "0x182276130", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2277200", Offset = "0x2275800", VA = "0x182277200", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2277860", Offset = "0x2275E60", VA = "0x182277860")]
	public DNOOFDDJJON(ELEHKEJLDOI<Entity> JCPKNOEICEG, JBBANOPACMB OKJDHECIFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2277480", Offset = "0x2275A80", VA = "0x182277480")]
	private Entity NIOOODEFKMO(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2277490", Offset = "0x2275A90", VA = "0x182277490")]
	private ENMPPPDAMHN NIOOODEFKMO(Entity MPAGCMNFGMI)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2276EF0", Offset = "0x22754F0", VA = "0x182276EF0", Slot = "4")]
	public T MBNHJLNEIKL(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2275A50", Offset = "0x2274050", VA = "0x182275A50")]
	public bool FGMAFKALEHD(ENMPPPDAMHN HMLJKOHAJKN, in T KIFJIAOCCHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2275070", Offset = "0x2273670", VA = "0x182275070", Slot = "7")]
	public bool AFPHGIBLJIN(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2276B70", Offset = "0x2275170", VA = "0x182276B70", Slot = "8")]
	public void MBNHJLNEIKL(ENMPPPDAMHN HMLJKOHAJKN, CIACNBAJNFM MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2275800", Offset = "0x2273E00", VA = "0x182275800", Slot = "9")]
	public bool FGMAFKALEHD(ENMPPPDAMHN HMLJKOHAJKN, NGKHEJGAHGD KIFJIAOCCHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x2275C20", Offset = "0x2274220", VA = "0x182275C20", Slot = "16")]
	public void IBBEGLBGAJD(KJPEBAGBPMP MIBBABDJMFM, [Optional] object MFPELEJLJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x2277360", Offset = "0x2275960", VA = "0x182277360", Slot = "10")]
	public bool MOAONFLIEIF(ENMPPPDAMHN GGCKOLILJHC, ENMPPPDAMHN POIAHNIMHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2275470", Offset = "0x2273A70", VA = "0x182275470")]
	private void ANOBDMNCICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2275C50", Offset = "0x2274250", VA = "0x182275C50")]
	private void IHOLHNOFLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2276290", Offset = "0x2274890", VA = "0x182276290")]
	private void KLOOKBOPLCB(Entity MPAGCMNFGMI, in NGKHEJGAHGD MDNKPPKLBGD, in NGKHEJGAHGD KIFJIAOCCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2277660", Offset = "0x2275C60", VA = "0x182277660")]
	private void PAEJCCBAFDL(Entity MPAGCMNFGMI, in NGKHEJGAHGD MDNKPPKLBGD, in NGKHEJGAHGD KIFJIAOCCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x22757D0", Offset = "0x2273DD0", VA = "0x1822757D0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2277720", Offset = "0x2275D20", VA = "0x182277720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[OJJOJOKIEBL(typeof(JFAJDFHGGNE), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
internal class JFAJDFHGGNE
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private bool LHEAMNILFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool CPDEAPLOCGL;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool JLMOFFAFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x979990", Offset = "0x977F90", VA = "0x180979990")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA6F0", Offset = "0x2AD8CF0", VA = "0x182ADA6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool BMGFAJCPCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xA39300", Offset = "0xA37900", VA = "0x180A39300")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA700", Offset = "0x2AD8D00", VA = "0x182ADA700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JFAJDFHGGNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[OJJOJOKIEBL(typeof(HNNPHIGJKMK), new string[] { })]
public class CECPNIMEFAK : HNNPHIGJKMK, LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class GEGNGPLFBNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public List<CapsuleCollider> HADAKLBJPFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<SphereCollider> PPCFPCJAEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public GameObject CNNLHJBFKLD;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x28F3850", Offset = "0x28F1E50", VA = "0x1828F3850")]
		public GEGNGPLFBNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	[LABJLBKOJHN]
	private JBBANOPACMB NDJMBFAHEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[LABJLBKOJHN]
	private MGCDDMFMGJA OOMNOKNIMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly Dictionary<Entity, GEGNGPLFBNE> HAFDEDDNONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private GameObject HJHPGBEFBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private GameObject LDDDPNDEMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject FMGBMOPPDNC;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private GameObject PGDJMHNLOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x27CEB00", Offset = "0x27CD100", VA = "0x1827CEB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x27D0900", Offset = "0x27CEF00", VA = "0x1827D0900", Slot = "6")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x27CF3A0", Offset = "0x27CD9A0", VA = "0x1827CF3A0", Slot = "4")]
	public void EHAEGCGNNHA(Entity HBPLGEAHCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x27D0330", Offset = "0x27CE930", VA = "0x1827D0330", Slot = "5")]
	public void GFKBKFPPLCA(Entity HBPLGEAHCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x27CF030", Offset = "0x27CD630", VA = "0x1827CF030", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x27CEEC0", Offset = "0x27CD4C0", VA = "0x1827CEEC0")]
	private GEGNGPLFBNE BJNPLNLKGNF(Entity HBPLGEAHCKJ, CJNJIJCNICA JCPFBEJJJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x27CF790", Offset = "0x27CDD90", VA = "0x1827CF790")]
	private void FJBGBNEAKNC(CJNJIJCNICA JCPFBEJJJPM, GEGNGPLFBNE FJAOBCKAPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x27CF190", Offset = "0x27CD790", VA = "0x1827CF190")]
	private void EEJNJNOFALO(CJNJIJCNICA JCPFBEJJJPM, GEGNGPLFBNE FJAOBCKAPOJ, int CBEKEFKIDMF, Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL, float HDIPCMABEDD, float ALIBBMDECIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x27D0970", Offset = "0x27CEF70", VA = "0x1827D0970")]
	private void MMMJMNEIEED(GEGNGPLFBNE FJAOBCKAPOJ, int IIJGDFIFKOI, Vector3 POOFJFBIOJJ, float HDIPCMABEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x27CEBC0", Offset = "0x27CD1C0", VA = "0x1827CEBC0")]
	private void ANABFKGDIHH(CJNJIJCNICA JCPFBEJJJPM, GEGNGPLFBNE FJAOBCKAPOJ, int ACDLFKFKEGK, int KLMOMFIBDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x30950B0", Offset = "0x30936B0", VA = "0x1830950B0")]
	private T NEDCCDFGGCK<T>(CJNJIJCNICA JCPFBEJJJPM, ref GameObject LMLNLGDAFGM, Vector3 IPKLBGKEJKA, Quaternion EOGEEAFFCFC) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x27D0BC0", Offset = "0x27CF1C0", VA = "0x1827D0BC0")]
	public CECPNIMEFAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DefaultMember("Item")]
public class EJJLNHGFOJN<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[FIJBPDAJCNE(typeof(EOMEEBLCJPE))]
[OJJOJOKIEBL(typeof(BJPLNLDMPDD), new string[] { })]
public class AGIGEOBFLAD : BJPLNLDMPDD, EECDFKAILMM, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly Dictionary<int, FIFLCEFEDEL> GJGDEMLGEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly Dictionary<FIFLCEFEDEL, int> LGLEGDEDIAB;

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x27C0230", Offset = "0x27BE830", VA = "0x1827C0230", Slot = "6")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x27C00D0", Offset = "0x27BE6D0", VA = "0x1827C00D0", Slot = "7")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x27C0300", Offset = "0x27BE900", VA = "0x1827C0300")]
	private void ONIIJLOLIJL(List<(FIFLCEFEDEL nameHash, IMMBALAGBFO stableTypeHash, Type type)> CKIKFMIOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x27BFF80", Offset = "0x27BE580", VA = "0x1827BFF80", Slot = "4")]
	public FIFLCEFEDEL CBCDBDGKDMI(int MPGHGDABPMN)
	{
		return default(FIFLCEFEDEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x27C01C0", Offset = "0x27BE7C0", VA = "0x1827C01C0", Slot = "5")]
	public int JDHPHGKFOBE(FIFLCEFEDEL OJKNCEMGHDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x27C0510", Offset = "0x27BEB10", VA = "0x1827C0510")]
	public AGIGEOBFLAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class JLEHMEGBLJG
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class OOIELCBGGKJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EHJDOAAGHLI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class JPPDANPBOOG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5080", Offset = "0x2AE3680", VA = "0x182AE5080")]
	public static Entity JJAIJODAFPC(this EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4DA0", Offset = "0x2AE33A0", VA = "0x182AE4DA0")]
	public static DynamicBuffer<IHMGEAEOPIO> IGAMMDLBLJG(this EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(DynamicBuffer<IHMGEAEOPIO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE47A0", Offset = "0x2AE2DA0", VA = "0x182AE47A0")]
	public static bool DJGEHCMHFIL(this EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, Allocator HINEEPDGLPG, out NativeArray<Entity> JDIOFLFADHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE48A0", Offset = "0x2AE2EA0", VA = "0x182AE48A0")]
	public static NativeArray<Entity> EPFGFHMFMIO(this EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4690", Offset = "0x2AE2C90", VA = "0x182AE4690")]
	public static int DCMOHGLHEDJ(this EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4340", Offset = "0x2AE2940", VA = "0x182AE4340")]
	public static void BOGDBAGGHNG(NativeArray<Entity> OJOAPPOPJPA, NativeArray<Entity> LAKDMECIDBH, EntityManager PHHGGAMLDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4C30", Offset = "0x2AE3230", VA = "0x182AE4C30")]
	public static bool GGFOGAAPHID(this EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, Entity IOKDMANFCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2AE40A0", Offset = "0x2AE26A0", VA = "0x182AE40A0")]
	public static bool AAPAIFFLBIH(this EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, Entity JNMPHJHBJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4A10", Offset = "0x2AE3010", VA = "0x182AE4A10")]
	public static NativeList<Entity> FBEFGFNDILH(this EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, bool NLNCKNLEJLB = false, Allocator HINEEPDGLPG = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4240", Offset = "0x2AE2840", VA = "0x182AE4240")]
	public static Entity BGKMIAGKHHM(this EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4E30", Offset = "0x2AE3430", VA = "0x182AE4E30")]
	public static bool JFELDPLAPKL(this EntityManager PHHGGAMLDGB, Entity LIGIEJOGFAH, Entity LFGKHOBDGNE, out Entity MJEHPBFLFOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2AE50F0", Offset = "0x2AE36F0", VA = "0x182AE50F0")]
	internal static void PJHLMNGGNIF(EntityManager PHHGGAMLDGB, Entity HDBBNLFBJKG, Entity BIKOOLOFJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2AE45A0", Offset = "0x2AE2BA0", VA = "0x182AE45A0")]
	private static bool CFBKJDLFJMH(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, Entity IOKDMANFCEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[LENINONNOFO]
internal struct HHAHAPMPAGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public ABJGEIBOMMO GOALPJDNEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public IEENJOCNCOI PDMGHNGLHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public KNJBLAINGCG.HCLOBMCBNLC.PACMKLALMFH MPNDOHBKHJO;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static readonly OAJOHIJPGNL<HHAHAPMPAGB> EOJNEJPDGDL;

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x24BDD10", Offset = "0x24BC310", VA = "0x1824BDD10")]
	public static HHAHAPMPAGB JINPEEFJJMH(in ABJGEIBOMMO GOALPJDNEKG)
	{
		return default(HHAHAPMPAGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface KGCCGPEENIL
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	KNJBLAINGCG.HCLOBMCBNLC.PACMKLALMFH JDBOBILMLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class OIBBODILACM
{
	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x260D510", Offset = "0x260BB10", VA = "0x18260D510")]
	public static ABJGEIBOMMO EPPMLMDFMED(NILFLMGAFIC HDBBNLFBJKG)
	{
		return default(ABJGEIBOMMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class DBGDAEHJLOJ : CBENEIMMAGE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private readonly bool LHEAMNILFLF;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public HCJLJOEKAAD JMDIAKJHCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0xC87B50", Offset = "0xC86150", VA = "0x180C87B50")]
	public DBGDAEHJLOJ(bool LHEAMNILFLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x27D6350", Offset = "0x27D4950", VA = "0x1827D6350", Slot = "5")]
	public ByteString AEMGEGAIHLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class JFCIDKCFPHH
{
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly IAMDAJKPFJC NANBEKCHONK;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly IAMDAJKPFJC HHNLPDLGNOH;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly ProfilerMarker IPLDLFKBBAA;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly ProfilerMarker KCPCNJHFIIP;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly ProfilerMarker NKOIDLOEBHA;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly ProfilerMarker NJGIAGLDAAP;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly ProfilerMarker EPJFKFHNKFN;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly ProfilerMarker ENBHJHEGFKC;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly ProfilerMarker GNINDAFHGAP;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly ProfilerMarker BGEPOHJHFEJ;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly ProfilerMarker ADBIHNJFAFH;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly ProfilerMarker ICONOBOEDPL;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly ProfilerMarker ENCPJDPCBKO;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly ProfilerMarker HHICOBHMHCL;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly ProfilerMarker OAIMPAJLAFF;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly ProfilerMarker AJJAMIHLJPF;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker MNADLEALMAK;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker PHADNJOIGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private readonly MIBDDDPBJPM FOLGGDKHKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private readonly ByteString NFNCBDOMNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private readonly PLONEGJPBHK CBMJEICKDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private readonly FGGEKFFPMLE KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly FHGGPNINHMB GJDFMPGCMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly FALLAGCDOFB IMCDONHNOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly MLAMKEEJIFG AKPNMPBHLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly JFAJDFHGGNE JBHOOKHIIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly TaskCompletionSource<bool> BFAMIJBLGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly PGHHIFKACHK FKGPFMNALNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private readonly GLOBFOENEKN.GHLIPPBOFCC PANBKFPNFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private AKLHOJFEEEF DBBCDJGLDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private GDPCNPLLJEI OJOEDKOPODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private KNJBLAINGCG IJGBBCCFNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private HCJLJOEKAAD AHJEFHIJPOH;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Action<bool> EDGMKMCGDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA97E40", Offset = "0xA96440", VA = "0x180A97E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA97B00", Offset = "0xA96100", VA = "0x180A97B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Action NEOIOCKOPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x96A570", Offset = "0x968B70", VA = "0x18096A570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x969AD0", Offset = "0x9680D0", VA = "0x180969AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Action PLEGMMFBKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x937190", Offset = "0x935790", VA = "0x180937190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xC8E7F0", Offset = "0xC8CDF0", VA = "0x180C8E7F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Action NNOCECCKEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x937180", Offset = "0x935780", VA = "0x180937180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xA6D900", Offset = "0xA6BF00", VA = "0x180A6D900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<OPAIBEOPLMG> HPFHIJJMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xC78540", Offset = "0xC76B40", VA = "0x180C78540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xC8F4A0", Offset = "0xC8DAA0", VA = "0x180C8F4A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public FBGEKGCCCOL LACFGCFKPAA
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1753840", Offset = "0x1751E40", VA = "0x181753840")]
		[CompilerGenerated]
		get
		{
			return default(FBGEKGCCCOL);
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x174FD10", Offset = "0x174E310", VA = "0x18174FD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public HCJLJOEKAAD JMDIAKJHCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x923F80", Offset = "0x922580", VA = "0x180923F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public JAPFELDAJFH GPJHNGFDIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xF94030", Offset = "0xF92630", VA = "0x180F94030")]
		get
		{
			return default(JAPFELDAJFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public LocalId ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCE90", Offset = "0x2ADB490", VA = "0x182ADCE90")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Task KKANOEEBMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAF70", Offset = "0x2AD9570", VA = "0x182ADAF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD320", Offset = "0x2ADB920", VA = "0x182ADD320")]
	public JFCIDKCFPHH(ByteString NFNCBDOMNAL, JAPFELDAJFH AOEPODEMKDF, in PGHHIFKACHK FKGPFMNALNI, PLONEGJPBHK CBMJEICKDDL, KOMGFJFAEGJ PMHEMBJIPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB0A0", Offset = "0x2AD96A0", VA = "0x182ADB0A0")]
	public void CDAHFAFMGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB580", Offset = "0x2AD9B80", VA = "0x182ADB580")]
	public bool DMAOLGACNOI(JAPFELDAJFH LIGIEJOGFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB190", Offset = "0x2AD9790", VA = "0x182ADB190")]
	private bool CKHLHJKLILO(JAPFELDAJFH JHBJAKHPFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC1A0", Offset = "0x2ADA7A0", VA = "0x182ADC1A0")]
	private void KJBOBNEGKHH(JAPFELDAJFH CHHFHIMGFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC380", Offset = "0x2ADA980", VA = "0x182ADC380")]
	private bool LDCMLCGHGFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB680", Offset = "0x2AD9C80", VA = "0x182ADB680")]
	private bool FJHMKDJOFOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC1F0", Offset = "0x2ADA7F0", VA = "0x182ADC1F0")]
	public bool KMACHBEPGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2ADBDB0", Offset = "0x2ADA3B0", VA = "0x182ADBDB0")]
	private bool KDKBHGFNJBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA840", Offset = "0x2AD8E40", VA = "0x182ADA840")]
	private bool BAKIANHIHLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2ADBCE0", Offset = "0x2ADA2E0", VA = "0x182ADBCE0")]
	private bool KAGIHKEHGBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB660", Offset = "0x2AD9C60", VA = "0x182ADB660")]
	private bool FHNCGDHDNFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2ADCD90", Offset = "0x2ADB390", VA = "0x182ADCD90")]
	private bool OFLAFFIACME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2ADAB00", Offset = "0x2AD9100", VA = "0x182ADAB00")]
	public void BAKJOFHIMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC8A0", Offset = "0x2ADAEA0", VA = "0x182ADC8A0")]
	[CompilerGenerated]
	private void MJKMNKCNJPB(JAPFELDAJFH JHBJAKHPFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC540", Offset = "0x2ADAB40", VA = "0x182ADC540")]
	[CompilerGenerated]
	private bool LHHFPKBAAOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC950", Offset = "0x2ADAF50", VA = "0x182ADC950")]
	[CompilerGenerated]
	private void MLEBDDCICPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2ADBBF0", Offset = "0x2ADA1F0", VA = "0x182ADBBF0")]
	[CompilerGenerated]
	private World ILGHKMAHHII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2ADAFB0", Offset = "0x2AD95B0", VA = "0x182ADAFB0")]
	[CompilerGenerated]
	private void BFFIPOOAPIP(World NNHLPGJGEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB9A0", Offset = "0x2AD9FA0", VA = "0x182ADB9A0")]
	[CompilerGenerated]
	private int FMJKOEAJHHM(World NNHLPGJGEMB, ByteString NFNCBDOMNAL, KNJBLAINGCG.HCLOBMCBNLC.PACMKLALMFH MPNDOHBKHJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC6C0", Offset = "0x2ADACC0", VA = "0x182ADC6C0")]
	[CompilerGenerated]
	private void LMGEOMILKKE(World DDODGIBMPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2ADBAB0", Offset = "0x2ADA0B0", VA = "0x182ADBAB0")]
	[CompilerGenerated]
	internal static MDNOMONOICM IIFGOLPGHOH(EntityManager PLHDAPPKOKM, EntityManager CKPHGFDMKCF, int IMIIEPNOGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB4B0", Offset = "0x2AD9AB0", VA = "0x182ADB4B0")]
	[CompilerGenerated]
	private void DEMHNHLIHEC(HCJLJOEKAAD AHJEFHIJPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB7D0", Offset = "0x2AD9DD0", VA = "0x182ADB7D0")]
	[CompilerGenerated]
	private void FKAOKOLKGNG(EntityManager PHHGGAMLDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB5A0", Offset = "0x2AD9BA0", VA = "0x182ADB5A0")]
	[CompilerGenerated]
	private void EHEHJJAALCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA820", Offset = "0x2AD8E20", VA = "0x182ADA820")]
	[CompilerGenerated]
	private void AJLHCFHGHDG(string ECMAPGHKHFB, EntityManager PHHGGAMLDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA7A0", Offset = "0x2AD8DA0", VA = "0x182ADA7A0")]
	[CompilerGenerated]
	private GBOCNFMJKOB<PGHHIFKACHK> ACJBIBHDAJJ(EntityManager PHHGGAMLDGB)
	{
		return default(GBOCNFMJKOB<PGHHIFKACHK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal class NDJGFLADLFP : JLCHMIJEBPH
{
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly IAMDAJKPFJC HHNLPDLGNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly bool LHEAMNILFLF;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A730", Offset = "0x2A88D30", VA = "0x182A8A730")]
	public NDJGFLADLFP(bool LHEAMNILFLF, PLONEGJPBHK CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x9CABA0", Offset = "0x9C91A0", VA = "0x1809CABA0", Slot = "10")]
	protected override bool EBAFMHNGHAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A5F0", Offset = "0x2A88BF0", VA = "0x182A8A5F0", Slot = "11")]
	protected override void ENJHCLMBLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A650", Offset = "0x2A88C50", VA = "0x182A8A650", Slot = "12")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> PGDPALLLJEM(NativeArray<EntityRemapUtility.EntityRemapInfo> EBGODNGDKGE)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal struct PGHHIFKACHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public ABJGEIBOMMO KIGHPCHNDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public Entity HDBBNLFBJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public PMHKIJNLDHD PDMGHNGLHFN;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly OAJOHIJPGNL<PGHHIFKACHK> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class MIBDDDPBJPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private enum OAEJJHPAINJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		Running,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		Disposed
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class DDLLGNEIMDJ : IEnumerable<JAPFELDAJFH>, IEnumerable, IEnumerator<JAPFELDAJFH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private JAPFELDAJFH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private JAPFELDAJFH target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public JAPFELDAJFH <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public MIBDDDPBJPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private int <allowedTarget>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int <nextCompletedPhases>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private JAPFELDAJFH <phase>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private JAPFELDAJFH System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x935920", Offset = "0x933F20", VA = "0x180935920", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JAPFELDAJFH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x28F0310", Offset = "0x28EE910", VA = "0x1828F0310", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xEB8D00", Offset = "0xEB7300", VA = "0x180EB8D00")]
		[DebuggerHidden]
		public DDLLGNEIMDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x28F0190", Offset = "0x28EE790", VA = "0x1828F0190", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x28F02D0", Offset = "0x28EE8D0", VA = "0x1828F02D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x28F0220", Offset = "0x28EE820", VA = "0x1828F0220", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JAPFELDAJFH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x28F0220", Offset = "0x28EE820", VA = "0x1828F0220", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class MIIEOEFJDOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public JAPFELDAJFH phase;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MIIEOEFJDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x28FA990", Offset = "0x28F8F90", VA = "0x1828FA990")]
		internal object LGAMIOJHPHE(JAPFELDAJFH a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly IAMDAJKPFJC HHNLPDLGNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly JAPFELDAJFH AOEPODEMKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly Func<JAPFELDAJFH, bool> JEBIPMADDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Action<JAPFELDAJFH> NECFLDHGCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private int BIMGOJAIFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private OAEJJHPAINJ ILFDGGGKIBE;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public JAPFELDAJFH GPJHNGFDIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1A0", Offset = "0x7E87A0", VA = "0x1807EA1A0")]
		get
		{
			return default(JAPFELDAJFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A84180", Offset = "0x2A82780", VA = "0x182A84180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A84340", Offset = "0x2A82940", VA = "0x182A84340")]
	public MIBDDDPBJPM(JAPFELDAJFH AOEPODEMKDF, Func<JAPFELDAJFH, bool> JEBIPMADDFM, Action<JAPFELDAJFH> NECFLDHGCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A841F0", Offset = "0x2A827F0", VA = "0x182A841F0")]
	[IteratorStateMachine(typeof(DDLLGNEIMDJ))]
	private IEnumerable<JAPFELDAJFH> LCEECLMPFGA(JAPFELDAJFH LIGIEJOGFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A83DE0", Offset = "0x2A823E0", VA = "0x182A83DE0")]
	public bool DMAOLGACNOI(JAPFELDAJFH LIGIEJOGFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A84190", Offset = "0x2A82790", VA = "0x182A84190")]
	private void HGKDEANLLDM(JAPFELDAJFH JHBJAKHPFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x24A26E0", Offset = "0x24A0CE0", VA = "0x1824A26E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct GBOCNFMJKOB<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Entity CPBGLHPLNGH;

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x24DC4F0", Offset = "0x24DAAF0", VA = "0x1824DC4F0")]
	public GBOCNFMJKOB(EntityManager PHHGGAMLDGB, in T FKGPFMNALNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x24DC4E0", Offset = "0x24DAAE0", VA = "0x1824DC4E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class HMIBMGHCDCA : JLCHMIJEBPH
{
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private static readonly IAMDAJKPFJC HHNLPDLGNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private readonly HHAHAPMPAGB FKGPFMNALNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private NativeList<Entity> HKLAGMAOCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private NativeArray<Entity> ONPJEPIGJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> KIMPEMEBLEF;

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5DE0", Offset = "0x2AD43E0", VA = "0x182AD5DE0")]
	public HMIBMGHCDCA(IEnumerable<ENMPPPDAMHN> LNIELCFLEJE, in HHAHAPMPAGB FKGPFMNALNI, PLONEGJPBHK CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "10")]
	protected override bool EBAFMHNGHAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5C20", Offset = "0x2AD4220", VA = "0x182AD5C20", Slot = "9")]
	protected override HHAHAPMPAGB HCIFBNEECAP()
	{
		return default(HHAHAPMPAGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5AB0", Offset = "0x2AD40B0", VA = "0x182AD5AB0", Slot = "11")]
	protected override void ENJHCLMBLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5C50", Offset = "0x2AD4250", VA = "0x182AD5C50", Slot = "12")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> PGDPALLLJEM(NativeArray<EntityRemapUtility.EntityRemapInfo> EBGODNGDKGE)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5A00", Offset = "0x2AD4000", VA = "0x182AD5A00", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal abstract class JLCHMIJEBPH : CBENEIMMAGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly ProfilerMarker NJGIAGLDAAP;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly ProfilerMarker OBOBCHIEOKF;

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static readonly ProfilerMarker EPJFKFHNKFN;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private static readonly ProfilerMarker FPLNGEOAJJC;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly ProfilerMarker GNINDAFHGAP;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly ProfilerMarker ONIPMICPJLN;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static readonly ProfilerMarker IGKNHAFAPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private readonly PLONEGJPBHK CBMJEICKDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly AKLHOJFEEEF DBBCDJGLDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private readonly MLAMKEEJIFG AKPNMPBHLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly FALLAGCDOFB IMCDONHNOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly IAMDAJKPFJC HHNLPDLGNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private readonly GLOBFOENEKN.GHLIPPBOFCC PANBKFPNFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private World DOALMNJKPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private HCJLJOEKAAD AHJEFHIJPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private IDisposable NJEKJHOLFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private ByteString BIDDCOCFJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private KNJBLAINGCG.HCLOBMCBNLC.PACMKLALMFH ABNOGBHKNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private bool HHCNDINEIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private DLBAJHIENKP DCDGMLDKCOF;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	protected World IAACALGGCNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	protected World FKLPOCBLLPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3CF0", Offset = "0x2AE22F0", VA = "0x182AE3CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public HCJLJOEKAAD JMDIAKJHCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A0", Offset = "0x8CBAA0", VA = "0x1808CD4A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3F00", Offset = "0x2AE2500", VA = "0x182AE3F00")]
	public JLCHMIJEBPH(PLONEGJPBHK CBMJEICKDDL, IAMDAJKPFJC BILPDCGHAAG, IAMDAJKPFJC HHNLPDLGNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3150", Offset = "0x2AE1750", VA = "0x182AE3150", Slot = "5")]
	public ByteString AEMGEGAIHLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3380", Offset = "0x2AE1980", VA = "0x182AE3380", Slot = "7")]
	public void IHAIHLFLKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3250", Offset = "0x2AE1850", VA = "0x182AE3250", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE32B0", Offset = "0x2AE18B0", VA = "0x182AE32B0", Slot = "9")]
	protected virtual HHAHAPMPAGB HCIFBNEECAP()
	{
		return default(HHAHAPMPAGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool EBAFMHNGHAD();

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void ENJHCLMBLPG();

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> PGDPALLLJEM(NativeArray<EntityRemapUtility.EntityRemapInfo> EBGODNGDKGE);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[OJJOJOKIEBL(typeof(KGCCGPEENIL), new string[] { })]
internal sealed class DJHLKFKLHIO : KGCCGPEENIL, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	[LABJLBKOJHN]
	private MDHPMKEGPDB MKOCLAEHLCN;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public KNJBLAINGCG.HCLOBMCBNLC.PACMKLALMFH JDBOBILMLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x27D8470", Offset = "0x27D6A70", VA = "0x1827D8470", Slot = "4")]
		get
		{
			return default(KNJBLAINGCG.HCLOBMCBNLC.PACMKLALMFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x27D8420", Offset = "0x27D6A20", VA = "0x1827D8420", Slot = "5")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public DJHLKFKLHIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal class BJICIODCHEN : GGFHOFNANBO, KOMGFJFAEGJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private readonly JFCIDKCFPHH KMPBAECDEGL;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public LocalId BKKGIPGEKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x27C83D0", Offset = "0x27C69D0", VA = "0x1827C83D0", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IEnumerable<OPAIBEOPLMG> HPFHIJJMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x27C8480", Offset = "0x27C6A80", VA = "0x1827C8480", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public FBGEKGCCCOL LACFGCFKPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x27C8420", Offset = "0x27C6A20", VA = "0x1827C8420", Slot = "5")]
		get
		{
			return default(FBGEKGCCCOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Task KKANOEEBMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x27C83B0", Offset = "0x27C69B0", VA = "0x1827C83B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public HCJLJOEKAAD HBOMINEIGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x27C8460", Offset = "0x27C6A60", VA = "0x1827C8460", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x27C84B0", Offset = "0x27C6AB0", VA = "0x1827C84B0")]
	public BJICIODCHEN(ByteString NFNCBDOMNAL, PLONEGJPBHK CBMJEICKDDL, Action<bool> IFMECEFOJGF, Action MNDIEMCEDAB, Action ANGHCMIHELE, Action IPAONFGPPJE, bool LOOGPLHHFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x27C83E0", Offset = "0x27C69E0", VA = "0x1827C83E0", Slot = "9")]
	public bool DMAOLGACNOI(JAPFELDAJFH JHBJAKHPFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x27C8400", Offset = "0x27C6A00", VA = "0x1827C8400", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class NNIACOLDOKK
{
	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D7F0", Offset = "0x2A8BDF0", VA = "0x182A8D7F0")]
	public static GLOBFOENEKN.GHLIPPBOFCC FDALCFEDIDF(PLONEGJPBHK CBMJEICKDDL)
	{
		return default(GLOBFOENEKN.GHLIPPBOFCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D8D0", Offset = "0x2A8BED0", VA = "0x182A8D8D0")]
	public static NativeList<Entity> OGEGGOINDNA(EntityManager PHHGGAMLDGB, IEnumerable<ENMPPPDAMHN> LNIELCFLEJE)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A8DC40", Offset = "0x2A8C240", VA = "0x182A8DC40")]
	public static void PGDPALLLJEM(NativeArray<Entity> ONPJEPIGJOD, NativeList<Entity> HKLAGMAOCBG, NativeArray<EntityRemapUtility.EntityRemapInfo> EBGODNGDKGE, NativeArray<EntityRemapUtility.EntityRemapInfo> KIMPEMEBLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD6A0", Offset = "0x2FBBCA0", VA = "0x182FBD6A0")]
	public static Entity PBCBFKAKECM<T>(EntityManager PHHGGAMLDGB, in T MOLEJFDINLH) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class MGFLJOAIJHF : CINHJBLABIP, KOMGFJFAEGJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly JFCIDKCFPHH KMPBAECDEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private readonly MBKAKKEBAGC MHLMGNFDLIP;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public HKACBKPJJFC ENBLGLBONNE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public LocalId BKKGIPGEKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A83C80", Offset = "0x2A82280", VA = "0x182A83C80", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Task KKANOEEBMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x27C83B0", Offset = "0x27C69B0", VA = "0x1827C83B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IEnumerable<OPAIBEOPLMG> HPFHIJJMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x27C8480", Offset = "0x27C6A80", VA = "0x1827C8480", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FBGEKGCCCOL LACFGCFKPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x27C8420", Offset = "0x27C6A20", VA = "0x1827C8420", Slot = "8")]
		get
		{
			return default(FBGEKGCCCOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public HCJLJOEKAAD HBOMINEIGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x27C8460", Offset = "0x27C6A60", VA = "0x1827C8460", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A83CE0", Offset = "0x2A822E0", VA = "0x182A83CE0")]
	public MGFLJOAIJHF(ByteString NFNCBDOMNAL, HKACBKPJJFC DCKPEAJPHEG, in PGHHIFKACHK FKGPFMNALNI, PLONEGJPBHK CBMJEICKDDL, Action IPAONFGPPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A83CA0", Offset = "0x2A822A0", VA = "0x182A83CA0", Slot = "5")]
	public void IHAIHLFLKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x27C83E0", Offset = "0x27C69E0", VA = "0x1827C83E0", Slot = "12")]
	public bool DMAOLGACNOI(JAPFELDAJFH JHBJAKHPFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A83C60", Offset = "0x2A82260", VA = "0x182A83C60", Slot = "6")]
	public void BAKJOFHIMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x27C8400", Offset = "0x27C6A00", VA = "0x1827C8400", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[OJJOJOKIEBL(typeof(KGPIAKEFEHB), new string[] { })]
public class ODCCPBLNFLM : KGPIAKEFEHB, GFDBIECGPKC, IAJAPMLMEJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private LIFCBCFOLBC CBMJEICKDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private LIACCBFBACG KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private GDPCNPLLJEI OJOEDKOPODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private GBHAJEIKFBB DDHJCLEIKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private DEMCMMGHLIH PFGMPLPGGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private KKJOECNGBND JEAKBAFPNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private KIMCOPEIFEL JBAGHABAFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private MLDDOPEDHJJ EGDOOPNCMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private EMNFNBCOPIC LMLLIALHCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private HEONMBBDPJM DFPFFEGPPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private GHPFOIJGFBB AEGNAPOILPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private LJIKPIOGIDO GIPCEGJMFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private MGCDDMFMGJA LLOLNAMCJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private CDONNANOMBA NFFCNMOEBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private OBPAHFKOKAC HIBLGJFCNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private OCAAAEBGOCB KMMKDJOLCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private APFNGMLMBFH ELPGMGIOJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private CMJAGJHDBFI CMMIKMENMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private MDHPMKEGPDB AHLOBFDBJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private FOKGJFJPKEK FJNPCKPLFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public LIFCBCFOLBC FDCDBHOPKIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public LIACCBFBACG MILBJGFKLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public MOFMKHOGCPA LBFLAKEIFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public DEMCMMGHLIH FBPKJDCDANM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public KKJOECNGBND MIBOLEGADCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public KIMCOPEIFEL DNOEHJKKOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public EMNFNBCOPIC CNOCKCOFJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public HEONMBBDPJM PIBMOGJMBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A0", Offset = "0x8CBAA0", VA = "0x1808CD4A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GHPFOIJGFBB LGJOADANKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x974F50", Offset = "0x973550", VA = "0x180974F50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public LJIKPIOGIDO ICDANIPJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x9CC460", Offset = "0x9CAA60", VA = "0x1809CC460", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public MGCDDMFMGJA ANKIIHHGNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x929320", Offset = "0x927920", VA = "0x180929320", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CDONNANOMBA DLKIFLPIMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F2B30", Offset = "0x9F1130", VA = "0x1809F2B30", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public OBPAHFKOKAC JCEGIKLPKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F64E0", Offset = "0x7F4AE0", VA = "0x1807F64E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public OCAAAEBGOCB AEIHDONIHEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x9DA620", Offset = "0x9D8C20", VA = "0x1809DA620", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public APFNGMLMBFH KIDJHBNKDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB30", Offset = "0xA79130", VA = "0x180A7AB30", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public CMJAGJHDBFI HHDLOPLGBLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA37B90", Offset = "0xA36190", VA = "0x180A37B90", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MDHPMKEGPDB PMDIGCLFBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F3250", Offset = "0x9F1850", VA = "0x1809F3250", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public FOKGJFJPKEK CFAONPPIDOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x9EE500", Offset = "0x9ECB00", VA = "0x1809EE500", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public INLEBFHADPP FECBIDCJBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x952150", Offset = "0x950750", VA = "0x180952150", Slot = "23")]
		get
		{
			return default(INLEBFHADPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x260B510", Offset = "0x2609B10", VA = "0x18260B510", Slot = "24")]
	public void GAPKOLLNHGD(LIFCBCFOLBC JOHABFNLMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x260B4E0", Offset = "0x2609AE0", VA = "0x18260B4E0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x260B4F0", Offset = "0x2609AF0", VA = "0x18260B4F0", Slot = "25")]
	public void FABNKKNBIDK(LIFCBCFOLBC JOHABFNLMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public ODCCPBLNFLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[OJJOJOKIEBL(typeof(LIACCBFBACG), new string[] { })]
public class BJGHPJOEBNN : LIACCBFBACG, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public FOGGGIMKHHH OLEPBAAECFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private NDKPGBMKGJL HPKFMPPICDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private AJMKMBOMDNO EKBFDKMHCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private KGBMKPKFLLI NFCDDEDMAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9D0", Offset = "0x7E8FD0", VA = "0x1807EA9D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public KGPKDCJJLAE JJHCCKOJALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x919C70", Offset = "0x918270", VA = "0x180919C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IKMNPNDODOB AHBEEDIDIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x9B3590", Offset = "0x9B1B90", VA = "0x1809B3590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public MIJOAPHHMJE GCKMOHEBCDO
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA2A670", Offset = "0xA28C70", VA = "0x180A2A670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public MCHBLFAONEL EDFFDDENOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x9B35C0", Offset = "0x9B1BC0", VA = "0x1809B35C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public FGGEKFFPMLE EGGOONFNDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x99CEB0", Offset = "0x99B4B0", VA = "0x18099CEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public FFIEDGLJPJJ GOMEAPDLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x95A160", Offset = "0x958760", VA = "0x18095A160", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DE0", Offset = "0x9A53E0", VA = "0x1809A6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IFJOCADHACG IBMMOIONNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x9383D0", Offset = "0x9369D0", VA = "0x1809383D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private DHAENDLPHJA CJALFKNGGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x9585D0", Offset = "0x956BD0", VA = "0x1809585D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public GNONIHFGJDG OJNMJPHPDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x974F50", Offset = "0x973550", VA = "0x180974F50", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xA7E0B0", Offset = "0xA7C6B0", VA = "0x180A7E0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private GOMJAHLAFPG ICDANIPJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA0A480", Offset = "0xA08A80", VA = "0x180A0A480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private KDGOMGPPJAN PJOAAFKLBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3F0", Offset = "0x9AD9F0", VA = "0x1809AF3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x27C8100", Offset = "0x27C6700", VA = "0x1827C8100", Slot = "13")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BJGHPJOEBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[DefaultMember("Item")]
public class CEBHMJNIDND : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class IIMLMFEDDNE : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public CEBHMJNIDND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private int <indexOffset>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private int <intCount>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private ulong <value>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <index>5__5;

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x935920", Offset = "0x933F20", VA = "0x180935920", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0x28F4AC0", Offset = "0x28F30C0", VA = "0x1828F4AC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public IIMLMFEDDNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x28F4900", Offset = "0x28F2F00", VA = "0x1828F4900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x28F4A80", Offset = "0x28F3080", VA = "0x1828F4A80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly List<ulong> GLNDBFDKNFI;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x928590", Offset = "0x926B90", VA = "0x180928590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x27CEA80", Offset = "0x27CD080", VA = "0x1827CEA80")]
	public CEBHMJNIDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x27CEA10", Offset = "0x27CD010", VA = "0x1827CEA10", Slot = "4")]
	[IteratorStateMachine(typeof(IIMLMFEDDNE))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x27CEA10", Offset = "0x27CD010", VA = "0x1827CEA10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class NONJMMCGFAE
{
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly ComponentType[] DENLHDKPIEI;

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F280", Offset = "0x2A8D880", VA = "0x182A8F280")]
	public static Entity BHGGEHHOAPO(this EntityManager PHHGGAMLDGB)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class NDMGPOEJCKC<T> : LNELDEOMGHH<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x27842E0", Offset = "0x27828E0", VA = "0x1827842E0")]
	public NDMGPOEJCKC(T JKJLIBLKLFB, T OEJABJDKHOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[OJJOJOKIEBL(typeof(BMBAAOGODDL), new string[] { })]
public sealed class GADMKNGHBBB : BMBAAOGODDL, APKICOJHDCH<BMBAAOGODDL>, EECDFKAILMM, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private readonly Dictionary<BENLOGNDJHK, LBNIDADIEHM> OPDNPFCIODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private FEPMHCFGGFG ACNFFCGHPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private HMNOEMALJPC EGDOOPNCMJB;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool CNMFPKGLPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x9C9820", Offset = "0x9C7E20", VA = "0x1809C9820")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x24B3030", Offset = "0x24B1630", VA = "0x1824B3030")]
	public GADMKNGHBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x24B2F40", Offset = "0x24B1540", VA = "0x1824B2F40", Slot = "5")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x24B2EC0", Offset = "0x24B14C0", VA = "0x1824B2EC0", Slot = "6")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x24B2D00", Offset = "0x24B1300", VA = "0x1824B2D00", Slot = "4")]
	public bool BBDOIOJLDPI(BENLOGNDJHK MJBJADACIFB, out LBNIDADIEHM AACPPJHALGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(FEPMHCFGGFG), new string[] { })]
internal sealed class FEPMHCFGGFG : EECDFKAILMM
{
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private readonly Dictionary<Type, LBNIDADIEHM> OPDNPFCIODH;

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x24A9E00", Offset = "0x24A8400", VA = "0x1824A9E00", Slot = "4")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x24A9CF0", Offset = "0x24A82F0", VA = "0x1824A9CF0")]
	public void MBACIJOLGCB(Type KLGGKKGCLHM, LBNIDADIEHM AACPPJHALGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x24A9C10", Offset = "0x24A8210", VA = "0x1824A9C10")]
	public bool BBDOIOJLDPI(Type KLGGKKGCLHM, out LBNIDADIEHM AACPPJHALGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x24A9EE0", Offset = "0x24A84E0", VA = "0x1824A9EE0")]
	public FEPMHCFGGFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class DBKNDMFJIMH
{
	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x27D6410", Offset = "0x27D4A10", VA = "0x1827D6410")]
	public static void MBACIJOLGCB(this FEPMHCFGGFG GEDHMEAEIPA, LBNIDADIEHM AACPPJHALGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class LNELDEOMGHH<T> : IEHMLGJCIFL<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	protected HNDEJCPHBPD<T> HIFIJCDDFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	protected JDKABBFFNIB<T> IEHCOMDCCEB;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0xE24370", Offset = "0xE22970", VA = "0x180E24370")]
	public LNELDEOMGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x28E09F0", Offset = "0x28DEFF0", VA = "0x1828E09F0")]
	public LNELDEOMGHH(HNDEJCPHBPD<T> HIFIJCDDFOB, JDKABBFFNIB<T> IEHCOMDCCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x28E06B0", Offset = "0x28DECB0", VA = "0x1828E06B0", Slot = "10")]
	protected override T LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x28E0300", Offset = "0x28DE900", VA = "0x1828E0300", Slot = "11")]
	protected override void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE, T MOLEJFDINLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class OOAPGINONGF
{
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[OJJOJOKIEBL(typeof(ECGBJBIHLPJ), new string[] { })]
internal sealed class GAKDJBAHDKI : ECGBJBIHLPJ, EECDFKAILMM, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<BENLOGNDJHK, OLAJAOBOEEF> KCEOGFPNADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private HMNOEMALJPC EGDOOPNCMJB;

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x24B31F0", Offset = "0x24B17F0", VA = "0x1824B31F0", Slot = "6")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x24B30B0", Offset = "0x24B16B0", VA = "0x1824B30B0", Slot = "7")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x24B3110", Offset = "0x24B1710", VA = "0x1824B3110", Slot = "4")]
	public void MBACIJOLGCB(BENLOGNDJHK FPNKFNICEDM, Type JIKFCOCEENM, OLAJAOBOEEF EGAHPGKBOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x24B3180", Offset = "0x24B1780", VA = "0x1824B3180", Slot = "5")]
	public bool MBHAHKJEGMG(BENLOGNDJHK FPNKFNICEDM, out OLAJAOBOEEF EGAHPGKBOPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x24B3240", Offset = "0x24B1840", VA = "0x1824B3240")]
	public GAKDJBAHDKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[OJJOJOKIEBL(typeof(FNLKBDOKFGP), new string[] { })]
internal sealed class OJLBDLCFDKA : FNLKBDOKFGP, LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	[LABJLBKOJHN]
	private HMNOEMALJPC EGDOOPNCMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private NativeBitArray POKDAMLGAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private NativeParallelHashMap<EEKJFDFIEGN, int> HIBPPKGHFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private NativeList<int> CFGNNJIMCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private int JOJHGIJKAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private int INHIAICGHND;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool JLMOFFAFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x260E560", Offset = "0x260CB60", VA = "0x18260E560", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public CNCNDJOAIPP OLEBNJGPACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x260E510", Offset = "0x260CB10", VA = "0x18260E510", Slot = "7")]
		get
		{
			return default(CNCNDJOAIPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x260DF20", Offset = "0x260C520", VA = "0x18260DF20", Slot = "4")]
	public bool HDPEOPFIDBA(EEKJFDFIEGN HGGMFNJGHIP, BENLOGNDJHK JCPKNOEICEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x260E220", Offset = "0x260C820", VA = "0x18260E220", Slot = "8")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x260E380", Offset = "0x260C980", VA = "0x18260E380", Slot = "6")]
	public void JIDDGOBCGGJ(NativeArray<EEKJFDFIEGN> LDNMHAEAEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x260DFA0", Offset = "0x260C5A0", VA = "0x18260DFA0", Slot = "5")]
	public void IACGPIOJBGK(EEKJFDFIEGN HGGMFNJGHIP, Span<BENLOGNDJHK> EGDOOPNCMJB, bool COPKPKNCEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x260DE90", Offset = "0x260C490", VA = "0x18260DE90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public OJLBDLCFDKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[OJJOJOKIEBL(typeof(DKKKGDEMMBH), new string[] { })]
public class PGMGLNFIAIH : DKKKGDEMMBH, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	[LABJLBKOJHN]
	private FFIEDGLJPJJ KOBLJDIMIFH;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private uint KAMNPFMLLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x26114A0", Offset = "0x260FAA0", VA = "0x1826114A0", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x26114F0", Offset = "0x260FAF0", VA = "0x1826114F0", Slot = "5")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public PGMGLNFIAIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public abstract class OPGLKODNLJG : LBNIDADIEHM
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public abstract Type APKDCCGFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI, Span<byte> MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE, ReadOnlySpan<byte> MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	protected OPGLKODNLJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public abstract class IEHMLGJCIFL<T> : OPGLKODNLJG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public override Type APKDCCGFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x1CEF220", Offset = "0x1CED820", VA = "0x181CEF220", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE, T MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x1798750", Offset = "0x1796D50", VA = "0x181798750", Slot = "8")]
	public override void LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI, Span<byte> LIGIEJOGFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x1798410", Offset = "0x1796A10", VA = "0x181798410", Slot = "9")]
	public override void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE, ReadOnlySpan<byte> PAKFOBAPADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x1798FD0", Offset = "0x17975D0", VA = "0x181798FD0")]
	protected IEHMLGJCIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class LJHBFNNMDMA
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public struct PDBHNBPLDBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public JBBANOPACMB OKJDHECIFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public HMNOEMALJPC OKHKNBHIIFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public MKPEFGNMDIP KGHDEFAENMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public FNLKBDOKFGP PGINAOKHABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public LBGAFCFPELD JCGGJMJMODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public BMBAAOGODDL OPDNPFCIODH;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x28FB2C0", Offset = "0x28F98C0", VA = "0x1828FB2C0")]
		public void DOIFCEJGCCI(LIFCBCFOLBC CBMJEICKDDL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct LPPMMPJAIOJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NativeList<EEKJFDFIEGN> OPHACLOMLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public NativeList<FNDBMHENIMP> HNMKHJBPNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public NativeList<EEKJFDFIEGN> KIHBDEPGKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public NativeParallelMultiHashMap<EEKJFDFIEGN, IPFEKNFNPDF> EGDOOPNCMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public NativeList<byte> LHNLILEIDON;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool NKJCNHMFIIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x28F9960", Offset = "0x28F7F60", VA = "0x1828F9960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x28F98C0", Offset = "0x28F7EC0", VA = "0x1828F98C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct KEOAPGEAEKC : IComparer<IPFEKNFNPDF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x28F7160", Offset = "0x28F5760", VA = "0x1828F7160", Slot = "4")]
		public int Compare(IPFEKNFNPDF HEICJNINGBE, IPFEKNFNPDF DNLDNFFNIEF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private static readonly IAMDAJKPFJC HMGPJHMKDDK;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C500", Offset = "0x2A7AB00", VA = "0x182A7C500")]
	public static void OCMEMAHOBEH(ref CLDGGBNDBPF OCIIOHGMEPE, LPPMMPJAIOJ JAIGDBINGHO, PDBHNBPLDBE CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BBA0", Offset = "0x2A7A1A0", VA = "0x182A7BBA0")]
	public static LPPMMPJAIOJ IOFJDCPPEIP(ref FDAMBOMMBJG DOHACEMIKEI, Allocator HINEEPDGLPG, PDBHNBPLDBE CBMJEICKDDL)
	{
		return default(LPPMMPJAIOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A490", Offset = "0x2A78A90", VA = "0x182A7A490")]
	public static void COLODAOAIFG(LPPMMPJAIOJ JAIGDBINGHO, PDBHNBPLDBE CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C1F0", Offset = "0x2A7A7F0", VA = "0x182A7C1F0")]
	public static void MHFJOCHGDDJ(LPPMMPJAIOJ JAIGDBINGHO, PDBHNBPLDBE CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BEE0", Offset = "0x2A7A4E0", VA = "0x182A7BEE0")]
	public static int KFNIEFDKLGG(LPPMMPJAIOJ JAIGDBINGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A820", Offset = "0x2A78E20", VA = "0x182A7A820")]
	private static void DFKEMBGCIHB(ref CLDGGBNDBPF OCIIOHGMEPE, NativeArray<EEKJFDFIEGN> OPHACLOMLBN, NativeArray<FNDBMHENIMP> HNMKHJBPNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C060", Offset = "0x2A7A660", VA = "0x182A7C060")]
	private static void KKJIPKAGHJL(ref FDAMBOMMBJG DOHACEMIKEI, Allocator HINEEPDGLPG, out NativeList<EEKJFDFIEGN> OPHACLOMLBN, out NativeList<FNDBMHENIMP> AEAFLNCKMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BA10", Offset = "0x2A7A010", VA = "0x182A7BA10")]
	private static void FFGBFHDOPID(ref CLDGGBNDBPF OCIIOHGMEPE, NativeArray<EEKJFDFIEGN> KIHBDEPGKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BAA0", Offset = "0x2A7A0A0", VA = "0x182A7BAA0")]
	private static void INBEEIJEOJH(ref FDAMBOMMBJG DOHACEMIKEI, Allocator HINEEPDGLPG, out NativeList<EEKJFDFIEGN> KIHBDEPGKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A8E0", Offset = "0x2A78EE0", VA = "0x182A7A8E0")]
	private static void EFCOKMCLOKG(ref CLDGGBNDBPF OCIIOHGMEPE, NativeParallelMultiHashMap<EEKJFDFIEGN, IPFEKNFNPDF> EGDOOPNCMJB, NativeList<byte> LHNLILEIDON, PDBHNBPLDBE CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B390", Offset = "0x2A79990", VA = "0x182A7B390")]
	private static void EFFCICMKCJO(ref FDAMBOMMBJG DOHACEMIKEI, Allocator HINEEPDGLPG, out NativeParallelMultiHashMap<EEKJFDFIEGN, IPFEKNFNPDF> EGDOOPNCMJB, out NativeList<byte> LHNLILEIDON, PDBHNBPLDBE CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BEC0", Offset = "0x2A7A4C0", VA = "0x182A7BEC0")]
	private static void JFIDAALAECM(int CFOKNGNBMAP, ref int ANABHKHENBO, ref CLDGGBNDBPF OCIIOHGMEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C4E0", Offset = "0x2A7AAE0", VA = "0x182A7C4E0")]
	private static int NHHJNNBDPJE(int ANABHKHENBO, ref FDAMBOMMBJG DOHACEMIKEI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal static class JPDDECCGGBC
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class LOCLMDKBHBI
	{
		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class EEKCFNMJGFE<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public EEKCFNMJGFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x23DD970", Offset = "0x23DBF70", VA = "0x1823DD970")]
			internal void HBLHDDJOKKI(ref CLDGGBNDBPF writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x23DDAA0", Offset = "0x23DC0A0", VA = "0x1823DDAA0")]
			internal T IFKICIBMCKA(ref FDAMBOMMBJG reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x28F9430", Offset = "0x28F7A30", VA = "0x1828F9430")]
		public static void CBANDFMFMCI(FEPMHCFGGFG OPDNPFCIODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x2C94280", Offset = "0x2C92880", VA = "0x182C94280")]
		private static void IFALGJPCCNJ<T>(FEPMHCFGGFG OPDNPFCIODH, int OEJABJDKHOO) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x2C941E0", Offset = "0x2C927E0", VA = "0x182C941E0")]
		private static void EJHKBIGLJGO<T>(ref CLDGGBNDBPF OCIIOHGMEPE, T EMGLKKBADKE, int OEJABJDKHOO) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x2C943A0", Offset = "0x2C929A0", VA = "0x182C943A0")]
		private static T PKGCBBNBCBA<T>(ref FDAMBOMMBJG DOHACEMIKEI, int OEJABJDKHOO) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LOCLMDKBHBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class DIJFHNFPAKK : NIGKLPOJFNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private FEPMHCFGGFG OPDNPFCIODH;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x2C90E20", Offset = "0x2C8F420", VA = "0x182C90E20", Slot = "6")]
		public override void AJBCKMPMMDH<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x28F0400", Offset = "0x28EEA00", VA = "0x1828F0400")]
		public static void JAOIOCKAFJM(FEPMHCFGGFG OPDNPFCIODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x28F04B0", Offset = "0x28EEAB0", VA = "0x1828F04B0")]
		public DIJFHNFPAKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6290", Offset = "0x2AE4890", VA = "0x182AE6290")]
	public static void BJFHPPKADMM(FEPMHCFGGFG OPDNPFCIODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7CF0", Offset = "0x2AE62F0", VA = "0x182AE7CF0")]
	private static void IFJHDJKICJJ(ref CLDGGBNDBPF JNNIOKBNJHE, quaternion EMGLKKBADKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7DF0", Offset = "0x2AE63F0", VA = "0x182AE7DF0")]
	private static quaternion JIHIIJEEBGN(ref FDAMBOMMBJG EMOGFKKIBPO)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x1B3D0E0", Offset = "0x1B3B6E0", VA = "0x181B3D0E0")]
	public static void IGBCMBPLMOJ<T>(FEPMHCFGGFG OPDNPFCIODH, HNDEJCPHBPD<T> HIFIJCDDFOB, JDKABBFFNIB<T> IEHCOMDCCEB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x1B3D070", Offset = "0x1B3B670", VA = "0x181B3D070")]
	public static void DHOAKPCIBED<T>(FEPMHCFGGFG AACPPJHALGJ) where T : struct, HLLDBJJMAKE
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[OJJOJOKIEBL(typeof(BEGFKAEHLFO), new string[] { })]
internal class BHBMAEHDLBD : LPOKOJIEHOF, BEGFKAEHLFO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[LABJLBKOJHN]
	private DKKKGDEMMBH OHACKIIBLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private PKBDPKKLKNE DFLHHDCFNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private int DBGCKNDAMFL;

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x27C7CF0", Offset = "0x27C62F0", VA = "0x1827C7CF0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x27C7D60", Offset = "0x27C6360", VA = "0x1827C7D60", Slot = "5")]
	public MODKFNDEKMI NJEHPEEEGDG(ReadOnlySpan<byte> GFHGIIOIPBN)
	{
		return default(MODKFNDEKMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x27C7CE0", Offset = "0x27C62E0", VA = "0x1827C7CE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BHBMAEHDLBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[OJJOJOKIEBL(typeof(LBGAFCFPELD), new string[] { })]
public class NHCMDPJKKEM : LBGAFCFPELD, EECDFKAILMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private AJFPGPJMNEB GENNENCMDIB;

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C340", Offset = "0x2A8A940", VA = "0x182A8C340", Slot = "8")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8BE40", Offset = "0x2A8A440", VA = "0x182A8BE40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8BCD0", Offset = "0x2A8A2D0", VA = "0x182A8BCD0", Slot = "4")]
	public void COLODAOAIFG(EEKJFDFIEGN GIAMACBDIFH, BENLOGNDJHK FPNKFNICEDM, ReadOnlySpan<byte> LAMLBOAEFIH, ReadOnlySpan<byte> LCPMGAFAGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C3E0", Offset = "0x2A8A9E0", VA = "0x182A8C3E0", Slot = "7")]
	public bool PNCBNFNHNKO(EEKJFDFIEGN GIAMACBDIFH, BENLOGNDJHK FPNKFNICEDM, Span<byte> LAMLBOAEFIH, Span<byte> LCPMGAFAGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C2C0", Offset = "0x2A8A8C0", VA = "0x182A8C2C0", Slot = "5")]
	public bool FABMINKMEIG(EEKJFDFIEGN GIAMACBDIFH, BENLOGNDJHK FPNKFNICEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C300", Offset = "0x2A8A900", VA = "0x182A8C300", Slot = "6")]
	public bool MHFJOCHGDDJ(EEKJFDFIEGN GIAMACBDIFH, BENLOGNDJHK FPNKFNICEDM, ReadOnlySpan<byte> LCPMGAFAGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A8BE50", Offset = "0x2A8A450", VA = "0x182A8BE50")]
	private bool EMAAPJNNCDO(EEKJFDFIEGN GIAMACBDIFH, BENLOGNDJHK FPNKFNICEDM, ReadOnlySpan<byte> LCPMGAFAGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public NHCMDPJKKEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class KBLODJKKCDM<T> : IEHMLGJCIFL<T> where T : struct, HLLDBJJMAKE
{
	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x2544B90", Offset = "0x2543190", VA = "0x182544B90", Slot = "10")]
	protected override T LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x2544A10", Offset = "0x2543010", VA = "0x182544A10", Slot = "11")]
	protected override void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE, T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x1CDD830", Offset = "0x1CDBE30", VA = "0x181CDD830")]
	public KBLODJKKCDM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	public class PhysicsSceneAddCollidersSystem : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		private struct PhysicsSceneAddCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			public PhysicsSceneAddCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x3C0EF70", Offset = "0x3C0D570", VA = "0x183C0EF70")]
			private void DKBFAIHFAHI(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F070", Offset = "0x3C0D670", VA = "0x183C0F070", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private GONMEDAGBFK ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private NAKDAPLIPPO colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x2615040", Offset = "0x2613640", VA = "0x182615040", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x2614DE0", Offset = "0x26133E0", VA = "0x182614DE0", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x26150A0", Offset = "0x26136A0", VA = "0x1826150A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x26151A0", Offset = "0x26137A0", VA = "0x1826151A0")]
		private void PBOLMDEGNAA(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x2614E40", Offset = "0x2613440", VA = "0x182614E40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class JDLCCBFLNAN : FDPKALFDCJN
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	protected override ADMKFPPIBEF ANLHAKENMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "17")]
		get
		{
			return default(ADMKFPPIBEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA690", Offset = "0x2AD8C90", VA = "0x182ADA690")]
	public JDLCCBFLNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class HBJKHBEELLD : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[BurstCompile]
	private struct DOIDNINGIJK : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		[ReadOnly]
		public ComponentTypeHandle<JKCIFKNJAAP> JFLIPDDHPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public ComponentTypeHandle<GGKCINHFHOC> PNPNBKJJCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public ComponentTypeHandle<EOEAFFEAOLE> EFFGIFOGAFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public ComponentTypeHandle<ACMLALFAKEH> DJEFAMECJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public uint IAIKLPLKODM;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x28F0D00", Offset = "0x28EF300", VA = "0x1828F0D00", Slot = "4")]
		public void Execute(ArchetypeChunk FCONCDBMPAA, int OLGOBCPPPBB, int IHINDCCMJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x28F0C70", Offset = "0x28EF270", VA = "0x1828F0C70")]
		public bool AMHHHBOFGAN(ArchetypeChunk FCONCDBMPAA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private EntityQuery JEAKBAFPNAB;

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x24BCBC0", Offset = "0x24BB1C0", VA = "0x1824BCBC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x24BCCD0", Offset = "0x24BB2D0", VA = "0x1824BCCD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public HBJKHBEELLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public sealed class FCGLJBENBMO : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private JJPMDANOJAP AMKEFDBPHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private MBKAKKEBAGC MHLMGNFDLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private EKOLMNJLLEE JHBJAKHPFJI;

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x24A9470", Offset = "0x24A7A70", VA = "0x1824A9470", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x24A9500", Offset = "0x24A7B00", VA = "0x1824A9500", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public FCGLJBENBMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class JGDBNPMBBAL : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDD00", Offset = "0x2ADC300", VA = "0x182ADDD00", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public JGDBNPMBBAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[OJJOJOKIEBL(typeof(AGCNKMBAJEJ), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal class AGCNKMBAJEJ : EMBHBGCIFNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private CMPMKCLAGPD<OEMCDAHANNB, OEKKBLAFHKG, HGNDMLIGLLB, MJAGKJKNKOM> GCHLEKHNNCD;

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x27BFEB0", Offset = "0x27BE4B0", VA = "0x1827BFEB0", Slot = "4")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public AGCNKMBAJEJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	public class PreSerializeTransformRoots : DIIPAOKEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[NoAlias]
		[BurstCompile]
		private struct PreSerializeTransformRoots_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			public ComponentTypeHandle<OGEEBLLKOPC> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x3C0C140", Offset = "0x3C0A740", VA = "0x183C0C140")]
			private void DKBFAIHFAHI([NoAlias] ref OGEEBLLKOPC data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x3C11C70", Offset = "0x3C10270", VA = "0x183C11C70", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[BurstCompile]
		[NoAlias]
		private struct PreSerializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			public ComponentTypeHandle<GEELFDNKLBO> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x3C0ADA0", Offset = "0x3C093A0", VA = "0x183C0ADA0")]
			private void DKBFAIHFAHI([NoAlias] ref GEELFDNKLBO data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x3C11D40", Offset = "0x3C10340", VA = "0x183C11D40", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery PreSerializeTransformRoots_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery PreSerializeTransformRoots_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery __query_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private ComponentTypeHandle<OGEEBLLKOPC> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private ComponentTypeHandle<GEELFDNKLBO> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x261F580", Offset = "0x261DB80", VA = "0x18261F580", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x261ECE0", Offset = "0x261D2E0", VA = "0x18261ECE0")]
		private void IPHHBHCKEAN(in ABJGEIBOMMO transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x261EF00", Offset = "0x261D500", VA = "0x18261EF00")]
		private JobHandle NJAFNODEBEH(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x261EBD0", Offset = "0x261D1D0", VA = "0x18261EBD0")]
		private JobHandle DACNFFLPMKF(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x261F040", Offset = "0x261D640", VA = "0x18261F040", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PreSerializeTransformRoots()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class NKGJJNJALKC : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D1E0", Offset = "0x2A8B7E0", VA = "0x182A8D1E0", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public NKGJJNJALKC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	public class PhysicsSceneRemoveCollidersSystem : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		private struct PhysicsSceneRemoveCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			public PhysicsSceneRemoveCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C4")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			[ReadOnly]
			public ComponentTypeHandle<BJEMMMMLMIB> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F120", Offset = "0x3C0D720", VA = "0x183C0F120")]
			private void DKBFAIHFAHI(Entity e, in BJEMMMMLMIB ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F220", Offset = "0x3C0D820", VA = "0x183C0F220", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private GONMEDAGBFK ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private NAKDAPLIPPO colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private ComponentTypeHandle<BJEMMMMLMIB> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x2615670", Offset = "0x2613C70", VA = "0x182615670", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x26153D0", Offset = "0x26139D0", VA = "0x1826153D0", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x26156D0", Offset = "0x2613CD0", VA = "0x1826156D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x2615290", Offset = "0x2613890", VA = "0x182615290")]
		private void IEGKHMEOLBJ(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x2615430", Offset = "0x2613A30", VA = "0x182615430", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class PCEFIOLKLEF : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[BurstCompile]
	private struct BHKBOLMHDAK : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		[ReadOnly]
		public NativeArray<OLGOJNGNMGG> GLODEDPBEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[ReadOnly]
		public NativeArray<Entity> NCEOACJJMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public ComponentDataFromEntity NMPNMBAMPLP;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E390", Offset = "0x3C0C990", VA = "0x183C0E390", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[BurstCompile]
	private struct BCCFCADNLOM : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> BOMIGNLLDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> NNFMPODHIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> GNBMIPGKCPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> HEAFGMCPOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> FFMHECBDDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public NativeList<EntityArchetype> FABHHEOPKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public NativeList<EntityArchetype> LBAFFKOPKFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public NativeList<JDOBAEGPJED> CKIMAEONNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public NativeList<JDOBAEGPJED> DOGKHNAFKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public NativeList<OLGOJNGNMGG> FMOBMNGLCFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public NativeList<ComponentType> MDCDGJAHCMO;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E1B0", Offset = "0x3C0C7B0", VA = "0x183C0E1B0", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D890", Offset = "0x3C0BE90", VA = "0x183C0D890", Slot = "5")]
		public JobHandle Dispose(JobHandle FCDGNCOICKN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DA90", Offset = "0x3C0C090", VA = "0x183C0DA90", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D7F0", Offset = "0x3C0BDF0", VA = "0x183C0D7F0")]
		private int AKDKNDJNPBF(JDOBAEGPJED HIGOEHKEDHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DFB0", Offset = "0x3C0C5B0", VA = "0x183C0DFB0")]
		private bool GEFGHDBHCEK(int OOIDDNLMGIO, EntityArchetype LFONPNGHJOO, out EntityArchetype MDHFPNHJBKD, out Entity EFMHKLIFHKG)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[BurstCompile]
	private struct GCLHJAHPLPF : IComparer<OLGOJNGNMGG>
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E6A0", Offset = "0x3C0CCA0", VA = "0x183C0E6A0", Slot = "4")]
		public int Compare(OLGOJNGNMGG HEICJNINGBE, OLGOJNGNMGG DNLDNFFNIEF)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[BurstCompile]
	private struct KBFIPHNDMPO : DKBCPEINLOI<OLGOJNGNMGG, int>
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x19AFAC0", Offset = "0x19AE0C0", VA = "0x1819AFAC0")]
		public int KOCCOHMJDND(in OLGOJNGNMGG POIAHNIMHKJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x19AFAC0", Offset = "0x19AE0C0", VA = "0x1819AFAC0", Slot = "4")]
		private int FIGFLNPAKJA(in OLGOJNGNMGG MOLEJFDINLH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private struct OLGOJNGNMGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Entity EFMHKLIFHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public JDOBAEGPJED NCEOACJJMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int BCPKNPKKDFI;
	}

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private GHMKMBPEGGE LKGDMEFDKFH;

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x260F5D0", Offset = "0x260DBD0", VA = "0x18260F5D0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x260F780", Offset = "0x260DD80", VA = "0x18260F780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x260F830", Offset = "0x260DE30", VA = "0x18260F830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x260FE60", Offset = "0x260E460", VA = "0x18260FE60")]
	private BCCFCADNLOM PMDHGGDJPAE(NativeArray<ArchetypeChunk> IGOKMJEIOAE)
	{
		return default(BCCFCADNLOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x260F620", Offset = "0x260DC20", VA = "0x18260F620")]
	private void MHLIBMJHMIA(NativeArray<EntityArchetype> LBAFFKOPKFO, NativeArray<JDOBAEGPJED> CKIMAEONNPK, NativeArray<JDOBAEGPJED> DOGKHNAFKNC, NativeArray<ComponentType> MDCDGJAHCMO, NativeArray<ArchetypeChunk> IGOKMJEIOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x260F1B0", Offset = "0x260D7B0", VA = "0x18260F1B0")]
	private EntityArchetype GIAICMBOCNA(EntityArchetype CNLGFLDAONI, NativeArray<ComponentType> MDCDGJAHCMO, JDOBAEGPJED NILANNAAGKO)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x260EC00", Offset = "0x260D200", VA = "0x18260EC00")]
	private JobHandle CKLICNEBCOK(NativeList<OLGOJNGNMGG> GLODEDPBEAJ, NativeArray<Entity> NCEOACJJMCN, JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x260F400", Offset = "0x260DA00", VA = "0x18260F400")]
	private JobHandle IHDNBAEPBGG(NativeArray<Entity> NCEOACJJMCN, NativeArray<OLGOJNGNMGG> GLODEDPBEAJ, int MPGHGDABPMN, JDOBAEGPJED NILANNAAGKO, JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x260F3F0", Offset = "0x260D9F0", VA = "0x18260F3F0")]
	public static bool HMCJDDACMDP(ComponentType OLPLAHPNFFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public PCEFIOLKLEF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	public class PostDeserializeTransformRoots : DIIPAOKEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeTransformRoots_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			public ComponentTypeHandle<OGEEBLLKOPC> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x3C0ACC0", Offset = "0x3C092C0", VA = "0x183C0ACC0")]
			private void DKBFAIHFAHI([NoAlias] ref OGEEBLLKOPC data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F7F0", Offset = "0x3C0DDF0", VA = "0x183C0F7F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public ComponentTypeHandle<GEELFDNKLBO> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x3C0ADA0", Offset = "0x3C093A0", VA = "0x183C0ADA0")]
			private void DKBFAIHFAHI([NoAlias] ref GEELFDNKLBO data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F8C0", Offset = "0x3C0DEC0", VA = "0x183C0F8C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			public ComponentTypeHandle<JLEHAKNHCDI> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			[ReadOnly]
			public ComponentTypeHandle<OGEEBLLKOPC> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x3C0ADB0", Offset = "0x3C093B0", VA = "0x183C0ADB0")]
			private void DKBFAIHFAHI([NoAlias] ref JLEHAKNHCDI authoredPose, [NoAlias] in OGEEBLLKOPC pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F990", Offset = "0x3C0DF90", VA = "0x183C0F990", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public ComponentTypeHandle<PMBIOKAECJH> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			public ComponentTypeHandle<GEELFDNKLBO> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x3C0ADD0", Offset = "0x3C093D0", VA = "0x183C0ADD0")]
			private void DKBFAIHFAHI([NoAlias] ref PMBIOKAECJH authoredScale, [NoAlias] in GEELFDNKLBO scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x3C0FAE0", Offset = "0x3C0E0E0", VA = "0x183C0FAE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private EntityQuery __query_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private ComponentTypeHandle<OGEEBLLKOPC> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private ComponentTypeHandle<GEELFDNKLBO> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private ComponentTypeHandle<JLEHAKNHCDI> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private ComponentTypeHandle<OGEEBLLKOPC> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private ComponentTypeHandle<PMBIOKAECJH> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private ComponentTypeHandle<GEELFDNKLBO> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2618090", Offset = "0x2616690", VA = "0x182618090", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2617390", Offset = "0x2615990", VA = "0x182617390")]
		private void IPHHBHCKEAN(in ABJGEIBOMMO transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2616D90", Offset = "0x2615390", VA = "0x182616D90")]
		private void AHNAIEHBFGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x2617140", Offset = "0x2615740", VA = "0x182617140")]
		private JobHandle GGLJJJFEBHJ(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2617280", Offset = "0x2615880", VA = "0x182617280")]
		private JobHandle IBKBFGGJFDO(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x2616FE0", Offset = "0x26155E0", VA = "0x182616FE0")]
		private JobHandle EJCODCJFIAI(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x26175C0", Offset = "0x2615BC0", VA = "0x1826175C0")]
		private JobHandle NDGCHPMMGLA(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x2617720", Offset = "0x2615D20", VA = "0x182617720", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PostDeserializeTransformRoots()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal struct JHFJPJOGKIO : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	internal class SplinePointParentChangedSystem : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		private struct SplinePointParentChangedSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public DynamicBuffer<global::EJGDELKHAJG> splineIndexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			[ReadOnly]
			public ComponentTypeHandle<PCNIEMKNHNM> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x3C14C80", Offset = "0x3C13280", VA = "0x183C14C80")]
			private void DKBFAIHFAHI(Entity splinePoint, [NoAlias] in PCNIEMKNHNM splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x3C14D90", Offset = "0x3C13390", VA = "0x183C14D90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[BurstCompile]
		[NoAlias]
		private struct SplinePointParentChangedSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			[ReadOnly]
			public ComponentTypeHandle<global::DJFCHHDFPEB> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x3C14EB0", Offset = "0x3C134B0", VA = "0x183C14EB0")]
			private void DKBFAIHFAHI(Entity splinePoint, [NoAlias] in global::DJFCHHDFPEB splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x3C14FE0", Offset = "0x3C135E0", VA = "0x183C14FE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private EntityQuery needsAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private EntityQuery needsRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[LABJLBKOJHN]
		private KDFIBOBNBIO singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private ComponentTypeHandle<PCNIEMKNHNM> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private ComponentTypeHandle<global::DJFCHHDFPEB> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x2621CD0", Offset = "0x26202D0", VA = "0x182621CD0", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x2622130", Offset = "0x2620730", VA = "0x182622130", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2622120", Offset = "0x2620720", VA = "0x182622120", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x26214E0", Offset = "0x261FAE0", VA = "0x1826214E0")]
		private void AKLINLHCILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x26218D0", Offset = "0x261FED0", VA = "0x1826218D0")]
		private void IKMJOANJKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2621730", Offset = "0x261FD30", VA = "0x182621730")]
		private EntityCommandBufferSystem BDPMMNOPFAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2621B70", Offset = "0x2620170", VA = "0x182621B70")]
		private JobHandle IOLBDNDIOOM(EntityCommandBuffer ecb, DynamicBuffer<global::EJGDELKHAJG> splineIndexUpdatesRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2621780", Offset = "0x261FD80", VA = "0x182621780")]
		private JobHandle GDMGGFBJALI(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2621D20", Offset = "0x2620320", VA = "0x182621D20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public SplinePointParentChangedSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	public class UpdateInertialProperties : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		private struct UpdateInertialProperties_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			public delegate void RunWithoutJobSystem_00000783$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20000EC")]
			internal static class RunWithoutJobSystem_00000783$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000313")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000314")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000617")]
				[Cpp2IlInjected.Address(RVA = "0x3C12F60", Offset = "0x3C11560", VA = "0x183C12F60")]
				[BurstDiscard]
				private static void ABAONOAEPNG(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000618")]
				[Cpp2IlInjected.Address(RVA = "0x3C13390", Offset = "0x3C11990", VA = "0x183C13390")]
				private static IntPtr NEJLCENAIPL()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000619")]
				[Cpp2IlInjected.Address(RVA = "0x3C130B0", Offset = "0x3C116B0", VA = "0x183C130B0")]
				public static void AHKGFJNBLNO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600061A")]
				[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
				public static void GMAKAKECEDK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600061C")]
				[Cpp2IlInjected.Address(RVA = "0x3C13170", Offset = "0x3C11770", VA = "0x183C13170")]
				public static void JLDGENJLEHM(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000305")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000306")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public EntityQueryInJob isTaggedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public EntityQueryInJob rootRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public EntityQueryInJob deformationScaleChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public EntityQueryInJob generalRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public ChunkFilterAnyOf5ComponentsChanged changeFilter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public int maxEntityCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public NativeList<Entity> changedRoots;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[ReadOnly]
			public EntityExistenceLookupByEntity entityExists;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			[ReadOnly]
			public EntityTypeHandle entityTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			[ReadOnly]
			public ComponentTypeHandle<IDCOKLJNAOF> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			[ReadOnly]
			public ComponentDataFromEntity<NJBAHIJEALE> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x3C15390", Offset = "0x3C13990", VA = "0x183C15390")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x3C159B0", Offset = "0x3C13FB0", VA = "0x183C159B0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x3C15330", Offset = "0x3C13930", VA = "0x183C15330")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void APGMJEJLMLN(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x3C159C0", Offset = "0x3C13FC0", VA = "0x183C159C0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void JPANCAPNHHE(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private EntityQuery isTaggedForUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private EntityQuery generalRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private EntityQuery rootRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private EntityQuery deformationScaleChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private EntityQuery removeMassOfHierarchyQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private LJAFLCDDJAH rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private JBBANOPACMB objects;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2627460", Offset = "0x2625A60", VA = "0x182627460", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x2627FC0", Offset = "0x26265C0", VA = "0x182627FC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2628330", Offset = "0x2626930", VA = "0x182628330", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x26274D0", Offset = "0x2625AD0", VA = "0x1826274D0")]
		protected void JFEMDGPFPIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x26273E0", Offset = "0x26259E0", VA = "0x1826273E0")]
		protected void DGLCOMFLGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x2627AF0", Offset = "0x26260F0", VA = "0x182627AF0")]
		private bool OKAJAOJLDLL(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, out NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2627810", Offset = "0x2625E10", VA = "0x182627810")]
		private void OHHAGCOPCAI(ref EntityQueryInJob isTaggedForUpdate, ref EntityQueryInJob rootRbexChangedQuery, ref EntityQueryInJob deformationScaleChangedQuery, ref EntityQueryInJob generalRbexChangedQuery, ref ChunkFilterAnyOf5ComponentsChanged changeFilter, ref int maxEntityCount, ref NativeList<Entity> changedRoots, ref EntityExistenceLookupByEntity entityExists, ref EntityTypeHandle entityTypeRO, ref ComponentTypeHandle<IDCOKLJNAOF> rbexRootTypeRO, ref ComponentDataFromEntity<NJBAHIJEALE> rbexIsKinematicRO, ref Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2627F00", Offset = "0x2626500", VA = "0x182627F00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x26283B0", Offset = "0x26269B0", VA = "0x1826283B0")]
		public static void PGAJFFCKLIE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class LPAJCDNNFDG : DIIPAOKEIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x2A80B50", Offset = "0x2A7F150", VA = "0x182A80B50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x2A80C10", Offset = "0x2A7F210", VA = "0x182A80C10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public LPAJCDNNFDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[DefaultMember("Item")]
public readonly struct CLDDCIMIPFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private readonly int MPGHGDABPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private readonly int DLLLIMHAFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly NativeArray<JDOBAEGPJED>.ReadOnly EGDOOPNCMJB;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public int ALHMBJNHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x27D4650", Offset = "0x27D2C50", VA = "0x1827D4650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public BCABFJJOPJD ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x27D46A0", Offset = "0x27D2CA0", VA = "0x1827D46A0")]
		get
		{
			return default(BCABFJJOPJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public int PMFDAKBDJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x1D43610", Offset = "0x1D41C10", VA = "0x181D43610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public NativeArray<JDOBAEGPJED>.ReadOnly HMALLPNIBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x1D435C0", Offset = "0x1D41BC0", VA = "0x181D435C0")]
		get
		{
			return default(NativeArray<JDOBAEGPJED>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x27D4730", Offset = "0x27D2D30", VA = "0x1827D4730")]
	public CLDDCIMIPFO(int MPGHGDABPMN, int DLLLIMHAFHK, NativeArray<JDOBAEGPJED>.ReadOnly EGDOOPNCMJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class PCOIJFJPHKO : PMGDLHEJJAE
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected override DEKJDDCLMEB BJHKELLEKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x26101A0", Offset = "0x260E7A0", VA = "0x1826101A0", Slot = "15")]
		get
		{
			return default(DEKJDDCLMEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x2610220", Offset = "0x260E820", VA = "0x182610220")]
	public PCOIJFJPHKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class NNLNHIPDOJG : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct DACEAIPPFMI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public FMGNDFNEJOF JEAKBAFPNAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public NativeParallelHashSet<Entity> NCEOACJJMCN;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E600", Offset = "0x3C0CC00", VA = "0x183C0E600")]
		public DACEAIPPFMI(int LEFNHMBHKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E580", Offset = "0x3C0CB80", VA = "0x183C0E580", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[BurstCompile]
	private struct GPIFAMICLBL : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		[ReadOnly]
		public NativeArray<Entity> NCEOACJJMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		[ReadOnly]
		public ComponentDataFromEntity<GGKCINHFHOC> PNNJDMIACAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[ReadOnly]
		public ComponentDataFromEntity<ACMLALFAKEH> MEJKOHBENDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		[ReadOnly]
		public ComponentDataFromEntity<EOEAFFEAOLE> LBHOKAEDOJI;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E6C0", Offset = "0x3C0CCC0", VA = "0x183C0E6C0", Slot = "4")]
		public void Execute(int OLGOBCPPPBB, TransformAccess DMECJMCKFAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[BurstCompile]
	private struct NEPOEMELDNN : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		[ReadOnly]
		public NativeArray<Entity> NCEOACJJMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		[ReadOnly]
		public ComponentDataFromEntity<GGKCINHFHOC> PNNJDMIACAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		[ReadOnly]
		public ComponentDataFromEntity<EOEAFFEAOLE> LBHOKAEDOJI;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E870", Offset = "0x3C0CE70", VA = "0x183C0E870", Slot = "4")]
		public void Execute(int OLGOBCPPPBB, TransformAccess DMECJMCKFAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private NAKDAPLIPPO BDAGOAAJLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private EntityQuery KANHKMPMPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private EntityQuery CAMPKAIKOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private EntityQuery JFOBGDCBIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private EntityQuery LFJEKLAHIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private EntityQuery INCLMGIKFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private JobHandle BODAJAEOGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private DACEAIPPFMI LOFKOHOAHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private DACEAIPPFMI OPABLICHOPO;

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E250", Offset = "0x2A8C850", VA = "0x182A8E250", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E790", Offset = "0x2A8CD90", VA = "0x182A8E790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E610", Offset = "0x2A8CC10", VA = "0x182A8E610", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EA40", Offset = "0x2A8D040", VA = "0x182A8EA40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E650", Offset = "0x2A8CC50", VA = "0x182A8E650")]
	private void NBLHGEDGKFE(EntityQuery OGAAEGIJKLI, out (NativeArrayAsync<BJEMMMMLMIB> handles, NativeArrayAsync<JOBAKIHHCFN> bounds) JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E3F0", Offset = "0x2A8C9F0", VA = "0x182A8E3F0")]
	private void KDMIEMCDEAO((NativeArrayAsync<BJEMMMMLMIB> handles, NativeArrayAsync<JOBAKIHHCFN> bounds) JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E610", Offset = "0x2A8CC10", VA = "0x182A8E610")]
	private void KLFHMDDECLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E2B0", Offset = "0x2A8C8B0", VA = "0x182A8E2B0")]
	private void JHDJIALIKJI(EntityQuery OGAAEGIJKLI, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<BJEMMMMLMIB> handles) JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8DCF0", Offset = "0x2A8C2F0", VA = "0x182A8DCF0")]
	private void CGBBBEEAMNO((NativeArrayAsync<Entity> entities, NativeArrayAsync<BJEMMMMLMIB> handles) JAIGDBINGHO, DACEAIPPFMI GOGEJEOAIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x2A8DF90", Offset = "0x2A8C590", VA = "0x182A8DF90")]
	private JobHandle FJDANLCLBAE(DACEAIPPFMI GOGEJEOAIDE, ComponentDataFromEntity<GGKCINHFHOC> PNNJDMIACAI, ComponentDataFromEntity<EOEAFFEAOLE> LBHOKAEDOJI, ComponentDataFromEntity<ACMLALFAKEH> MEJKOHBENDG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E0F0", Offset = "0x2A8C6F0", VA = "0x182A8E0F0")]
	private JobHandle HEKDGJIOANO(DACEAIPPFMI GOGEJEOAIDE, ComponentDataFromEntity<GGKCINHFHOC> PNNJDMIACAI, ComponentDataFromEntity<EOEAFFEAOLE> LBHOKAEDOJI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public NNLNHIPDOJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[CKDDPEJBLMJ]
public class HIPGIEPOMIM : DIIPAOKEIKC, ICBJIAPAJOF.MHCJAJGDHBC
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4DD0", Offset = "0x2AD33D0", VA = "0x182AD4DD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4D80", Offset = "0x2AD3380", VA = "0x182AD4D80")]
	private EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public HIPGIEPOMIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[OKNNJFAGDOM(typeof(EMPFOOIHLNI))]
[OJJOJOKIEBL(typeof(HJFCNJLKICJ), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal class HJFCNJLKICJ : LPOKOJIEHOF, EMPFOOIHLNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	[LABJLBKOJHN]
	private JJNJPCKJNLO EBBPNBJKOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private DLBAJHIENKP DKEOKJMNEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private NativeList<byte> JAIGDBINGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private NativeList<MODKFNDEKMI> KGJAJGGGLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private NativeList<JDOBAEGPJED> MDJHFNIGIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private int FGHNMEMEJMK;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<MODKFNDEKMI, NativeArray<byte>> PIPBDAMBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5000", Offset = "0x2AD3600", VA = "0x182AD5000")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4EE0", Offset = "0x2AD34E0", VA = "0x182AD4EE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5120", Offset = "0x2AD3720", VA = "0x182AD5120", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4F80", Offset = "0x2AD3580", VA = "0x182AD4F80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5250", Offset = "0x2AD3850", VA = "0x182AD5250", Slot = "5")]
	public void LHCKIAAHGJM(MODKFNDEKMI PAKFOBAPADB, ReadOnlySpan<byte> GFHGIIOIPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x2AD50A0", Offset = "0x2AD36A0", VA = "0x182AD50A0")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5490", Offset = "0x2AD3A90", VA = "0x182AD5490")]
	public HJFCNJLKICJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public class CKDDPEJBLMJ : EAGNFDFLHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	public CKDDPEJBLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class DPLPPJANFBG : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[BurstCompile]
	private struct DCIDAHKGAIB : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		[ReadOnly]
		public NativeArray<Entity> NCEOACJJMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<OGEEBLLKOPC> HIMCLFEDNLF;

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x28EFF20", Offset = "0x28EE520", VA = "0x1828EFF20", Slot = "4")]
		public void Execute(int OLGOBCPPPBB, TransformAccess DMECJMCKFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x28F0160", Offset = "0x28EE760", VA = "0x1828F0160")]
		private bool ILNGIJOAKCP(float3 ENDLICBNMBH, float3 LKPPDEOAPDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x28F00F0", Offset = "0x28EE6F0", VA = "0x1828F00F0")]
		private bool GKHALPJHIAP(quaternion ENDLICBNMBH, quaternion LKPPDEOAPDB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[BurstCompile]
	private struct BHFMFPEFCNK : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[ReadOnly]
		public NativeArray<Entity> NCEOACJJMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<GEELFDNKLBO> BBOGFKCGHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<DDHBNLFNGBI> KGMJINMEOMB;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x28ED350", Offset = "0x28EB950", VA = "0x1828ED350", Slot = "4")]
		public void Execute(int OLGOBCPPPBB, TransformAccess DMECJMCKFAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly IAMDAJKPFJC KOALOEAJFHD;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private static readonly IAMDAJKPFJC AHMCGMPPPGB;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly IAMDAJKPFJC LMOAOANELPP;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly ProfilerMarker GOAFLCNKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private BAOLGEAKCOK FBAFNMOHHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x27DA500", Offset = "0x27D8B00", VA = "0x1827DA500", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x27DA570", Offset = "0x27D8B70", VA = "0x1827DA570", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x27DA5B0", Offset = "0x27D8BB0", VA = "0x1827DA5B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public DPLPPJANFBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class CIHKEJPNDCK : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private DEMCMMGHLIH PFGMPLPGGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private DMAKAEPJKDA IPLELLBKCCP;

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x27D2000", Offset = "0x27D0600", VA = "0x1827D2000", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x27D1F70", Offset = "0x27D0570", VA = "0x1827D1F70", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x27D2100", Offset = "0x27D0700", VA = "0x1827D2100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public CIHKEJPNDCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[GHIPPEMCIOG]
internal abstract class PKINIECGOME : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	protected JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	protected CMJAGJHDBFI CMMIKMENMLL;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	protected abstract DEKJDDCLMEB BJHKELLEKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2611790", Offset = "0x260FD90", VA = "0x182611790", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x2611540", Offset = "0x260FB40", VA = "0x182611540")]
	protected void APFIHEGLECN(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2611800", Offset = "0x260FE00", VA = "0x182611800")]
	protected void MILIHKIHEDJ(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x2611A50", Offset = "0x2610050", VA = "0x182611A50")]
	protected KIHFNANBKDD OAJEMBODHJI(EntityQuery OGAAEGIJKLI)
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	protected PKINIECGOME()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal struct EEMPBOKKOHE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public struct FMGNDFNEJOF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private NativeList<Entity> NCEOACJJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private TransformAccessArray JEAKBAFPNAB;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x24B1240", Offset = "0x24AF840", VA = "0x1824B1240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public NativeList<Entity> OHCFFCCPKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xB91190", Offset = "0xB8F790", VA = "0x180B91190")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public TransformAccessArray FAJKCCIHIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x24B1250", Offset = "0x24AF850", VA = "0x1824B1250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x24B13F0", Offset = "0x24AF9F0", VA = "0x1824B13F0")]
	public FMGNDFNEJOF(int LEFNHMBHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x24B1120", Offset = "0x24AF720", VA = "0x1824B1120")]
	public Entity AABIOFCDFPG(int OLGOBCPPPBB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x24B1170", Offset = "0x24AF770", VA = "0x1824B1170")]
	public void BKJCGPDGHIM(int LEFNHMBHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x24B1330", Offset = "0x24AF930", VA = "0x1824B1330")]
	public int PDDBDHJNBOH(Transform DMECJMCKFAG, Entity MPAGCMNFGMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x24B12B0", Offset = "0x24AF8B0", VA = "0x1824B12B0")]
	public int MPEKOJMOEGH(int OLGOBCPPPBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x24B11C0", Offset = "0x24AF7C0", VA = "0x1824B11C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x24B1270", Offset = "0x24AF870", VA = "0x1824B1270")]
	private void IDFMPKBHLFC(int FMLOPMIDBOM = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public class NFKHFLDHGBM : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private MIOGGIJDIDO FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B870", Offset = "0x2A89E70", VA = "0x182A8B870", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B800", Offset = "0x2A89E00", VA = "0x182A8B800", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B940", Offset = "0x2A89F40", VA = "0x182A8B940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public NFKHFLDHGBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[OJJOJOKIEBL(typeof(NAKDAPLIPPO), new string[] { })]
public sealed class BFFAAPDENCB : NAKDAPLIPPO, EMLPEGCKBCF, EECDFKAILMM, LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	[LABJLBKOJHN]
	private IFGBMAJAPAC JBAGHABAFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private Collider[] OIPDHJLDNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private RaycastHit[] ICGPIHCJLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private KMKKAEEIGLF<OMLPFNCGEAG, BoxCollider> NFDGLIGLEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private Scene GHAEGLKDDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private PhysicsScene PELJBFOKMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private GameObject LMLNLGDAFGM;

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x27C5F90", Offset = "0x27C4590", VA = "0x1827C5F90", Slot = "9")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x27C5C60", Offset = "0x27C4260", VA = "0x1827C5C60", Slot = "10")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x27C51F0", Offset = "0x27C37F0", VA = "0x1827C51F0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x27C52F0", Offset = "0x27C38F0", VA = "0x1827C52F0", Slot = "4")]
	public OMLPFNCGEAG EEMILIIDFAP(Entity MPAGCMNFGMI)
	{
		return default(OMLPFNCGEAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x27C5A50", Offset = "0x27C4050", VA = "0x1827C5A50", Slot = "5")]
	public void ILLOLDNCJCI(NativeArray<OMLPFNCGEAG> ELGFKJEBGOH, NativeArray<JOBAKIHHCFN> IKBGILGFONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x27C5D20", Offset = "0x27C4320", VA = "0x1827C5D20", Slot = "6")]
	public void JJPHNPMMNOB(OMLPFNCGEAG FCDGNCOICKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x27C6140", Offset = "0x27C4740", VA = "0x1827C6140", Slot = "7")]
	public bool PJLLCBFGNBF(OMLPFNCGEAG FCDGNCOICKN, out Collider HCHCJABNKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x27C5750", Offset = "0x27C3D50", VA = "0x1827C5750")]
	public bool FEGDNOKIPAB(in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, float JOJFLKALKOE, Allocator HINEEPDGLPG, out NativeArray<Entity> NCEOACJJMCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x27C4ED0", Offset = "0x27C34D0", VA = "0x1827C4ED0")]
	private void AOPPGCEMKLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0xB9B080", Offset = "0xB99680", VA = "0x180B9B080")]
	private void ILDJBIHMIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x27C5160", Offset = "0x27C3760", VA = "0x1827C5160")]
	private void COIIHFFMGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x1C75140", Offset = "0x1C73740", VA = "0x181C75140")]
	private void KEJPHOKOFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x27C5440", Offset = "0x27C3A40", VA = "0x1827C5440")]
	private BoxCollider EIIGPCNKBKA(Entity MPAGCMNFGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x27C5F10", Offset = "0x27C4510", VA = "0x1827C5F10")]
	private void ODINPDEPFMC(BoxCollider OMKHGMMLEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x27C5560", Offset = "0x27C3B60", VA = "0x1827C5560")]
	private void EONDIOIFGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x27C5DF0", Offset = "0x27C43F0", VA = "0x1827C5DF0")]
	private void JOAMDGPEDLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x27C4F20", Offset = "0x27C3520", VA = "0x1827C4F20")]
	private void BILIIGJEOGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x27C6110", Offset = "0x27C4710", VA = "0x1827C6110")]
	private void PCFOEDBNJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x27C6100", Offset = "0x27C4700", VA = "0x1827C6100")]
	private void OLNMEDIGNKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x27C51B0", Offset = "0x27C37B0", VA = "0x1827C51B0")]
	private void DFFFGCDJPEL(Scene LBGFPGAFLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BFFAAPDENCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x27C5150", Offset = "0x27C3750", VA = "0x1827C5150", Slot = "8")]
	private bool CJBPLMFJPBJ(in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, float JOJFLKALKOE, Allocator HINEEPDGLPG, out NativeArray<Entity> NCEOACJJMCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public readonly struct DEKJDDCLMEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly ComponentType? MNHCODCAMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly ComponentType? FOGLLCBFFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public readonly ComponentType DKNPLGBNFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public readonly object DCEGGIJLHGI;

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x27D7260", Offset = "0x27D5860", VA = "0x1827D7260")]
	public DEKJDDCLMEB(ComponentType? MNHCODCAMIO, ComponentType? FOGLLCBFFPM, ComponentType DKNPLGBNFNP, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x243D6A0", Offset = "0x243BCA0", VA = "0x18243D6A0")]
	public static DEKJDDCLMEB NJLBBNPBCMI<TReq, TTag>(object DCEGGIJLHGI)
	{
		return default(DEKJDDCLMEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x243D480", Offset = "0x243BA80", VA = "0x18243D480")]
	public static DEKJDDCLMEB DKLOIELPAAJ<TReq, TMissing, TTag>(object DCEGGIJLHGI)
	{
		return default(DEKJDDCLMEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class HKMMLOCCIGL : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private FNLKBDOKFGP PGINAOKHABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private MBKAKKEBAGC OIDCAANMDGE;

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5760", Offset = "0x2AD3D60", VA = "0x182AD5760", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x2AD57D0", Offset = "0x2AD3DD0", VA = "0x182AD57D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public HKMMLOCCIGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[OJJOJOKIEBL(typeof(IBFLLPBIJGL), new string[] { })]
[FIJBPDAJCNE(typeof(EOMEEBLCJPE))]
public class CAJJIFFGLBG : IBFLLPBIJGL, EECDFKAILMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private readonly Dictionary<int, ICJILNNOMND> DJMIGAPIPKG;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public IEnumerable<ICJILNNOMND> NACLIPNCEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x27CE170", Offset = "0x27CC770", VA = "0x1827CE170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x27CDDC0", Offset = "0x27CC3C0", VA = "0x1827CDDC0", Slot = "6")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x27CDD00", Offset = "0x27CC300", VA = "0x1827CDD00", Slot = "5")]
	public bool COEBIMJMEEK(int MPGHGDABPMN, out ICJILNNOMND AACPPJHALGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x27CDD70", Offset = "0x27CC370", VA = "0x1827CDD70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x27CE1C0", Offset = "0x27CC7C0", VA = "0x1827CE1C0")]
	public CAJJIFFGLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class AJABMLOKLEJ : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private EntityQuery CHLGBFDBOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private KDGOMGPPJAN KOBLJDIMIFH;

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x27C0CE0", Offset = "0x27BF2E0", VA = "0x1827C0CE0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x27C0DA0", Offset = "0x27BF3A0", VA = "0x1827C0DA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x27C0E50", Offset = "0x27BF450", VA = "0x1827C0E50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0xE190D0", Offset = "0xE176D0", VA = "0x180E190D0")]
	private bool HOMNBBOCPMA<TComponentData>(EntityQuery OGAAEGIJKLI, out NativeArray<Entity> NCEOACJJMCN, out NativeArray<TComponentData> CDMNKFEHHOM) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x27C0D30", Offset = "0x27BF330", VA = "0x1827C0D30")]
	public FCLHKJAHMCN KGADKMGNOGI(Entity MPAGCMNFGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public AJABMLOKLEJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000104")]
public struct KGDILCOFPGE : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[GHIPPEMCIOG]
public class BFHNFDCJGIN : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[BurstCompile]
	private struct LAAHAGFDPLM : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		[ReadOnly]
		public NativeArray<Entity> EBFELDBDOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		[ReadOnly]
		public ComponentDataFromEntity<PCNIEMKNHNM> KMBEPHKFMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[ReadOnly]
		public ComponentDataFromEntity<JOBAKIHHCFN> DEEBJCBNMMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter NCFHBLLLKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter OECLDGLDLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter FFDNKMMLOMG;

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x28F86D0", Offset = "0x28F6CD0", VA = "0x1828F86D0", Slot = "4")]
		public void Execute(int OLGOBCPPPBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[BurstCompile]
	private struct FGBONLAGDMI : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		[ReadOnly]
		public NativeArray<Entity> HOGICAHHDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> MIMILGOAEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		[ReadOnly]
		public ComponentDataFromEntity<EOJLFMPKHEN> JDMKLHODEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[ReadOnly]
		public ComponentDataFromEntity<FJEOOOCNEKL> KEPANENMBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<JOBAKIHHCFN> CIMONJIACMD;

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x28F25C0", Offset = "0x28F0BC0", VA = "0x1828F25C0", Slot = "4")]
		public void Execute(int OLGOBCPPPBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EntityQuery AJODHLOEDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery ENCNGCOGJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private EntityQuery NDDNEBHCACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private EntityQuery DBHAPFAJFEH;

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x27C6F80", Offset = "0x27C5580", VA = "0x1827C6F80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x27C7190", Offset = "0x27C5790", VA = "0x1827C7190", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x27C69E0", Offset = "0x27C4FE0", VA = "0x1827C69E0")]
	private JobHandle DKAFJBJBKEN(NativeArrayAsync<Entity> IACDCADJJAN, int BFDDLCIBNMB, JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x27C6AC0", Offset = "0x27C50C0", VA = "0x1827C6AC0")]
	private JobHandle DKAFJBJBKEN(NativeArray<Entity> OOIEAPLKMBA, int BFDDLCIBNMB, [Optional] JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x27C6260", Offset = "0x27C4860", VA = "0x1827C6260")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) ABAMGEKENKE(NativeArrayAsync<Entity> MMIPBFDHOBG)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x27C77C0", Offset = "0x27C5DC0", VA = "0x1827C77C0")]
	private void PMGLHBPOJBB(out NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x27C6DC0", Offset = "0x27C53C0", VA = "0x1827C6DC0")]
	private void JCHOHBPGHOE(NativeList<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x27C6CF0", Offset = "0x27C52F0", VA = "0x1827C6CF0")]
	private void JCHOHBPGHOE(NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x27C6E50", Offset = "0x27C5450", VA = "0x1827C6E50")]
	private void KODMMGJNIBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void HIAIJLEBKOO(int BOJEKHJEMOI, int HOPKMLGCANH, int EBLBKJBILBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x27C66B0", Offset = "0x27C4CB0", VA = "0x1827C66B0")]
	private static JOBAKIHHCFN CACBGMLIKKD(NativeArray<Entity> GHKKIAJMHGI, ComponentDataFromEntity<EOJLFMPKHEN> JDMKLHODEND, ComponentDataFromEntity<FJEOOOCNEKL> KEPANENMBDF)
	{
		return default(JOBAKIHHCFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public BFHNFDCJGIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public struct LACJKHKONMC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private NativeArray<JDOBAEGPJED> HKDLJOGEFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private NativeArray<int> DOPNJGAOLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private NativeParallelHashMap<int, JDOBAEGPJED> CDDJKAEDMND;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public readonly int BANLCIAODPM
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BE0", Offset = "0x9A81E0", VA = "0x1809A9BE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public readonly int DPLAPDBAFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BF0", Offset = "0x9A81F0", VA = "0x1809A9BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A74570", Offset = "0x2A72B70", VA = "0x182A74570")]
	public LACJKHKONMC(IReadOnlyCollection<IMNNLGNGPKK> CDMNKFEHHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A74430", Offset = "0x2A72A30", VA = "0x182A74430")]
	public readonly CLDDCIMIPFO JIFDAIIHPLK(int MPGHGDABPMN)
	{
		return default(CLDDCIMIPFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A743B0", Offset = "0x2A729B0", VA = "0x182A743B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[AlwaysUpdateSystem]
public abstract class MOMBEIOEHPD : DIIPAOKEIKC, ICBJIAPAJOF.MHCJAJGDHBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private NativeList<EntityQuery> KGLOBJOCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private bool JPNNKFANGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private EntityCommandBufferSystem NKHEOBELIKH;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected bool NAOMKKANDIK
	{
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A87670", Offset = "0x2A85C70", VA = "0x182A87670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected abstract IAMDAJKPFJC ICFDANBOLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<ICBJIAPAJOF.AOOJLFMPEFJ> OLJIPNADBOE();

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A87680", Offset = "0x2A85C80", VA = "0x182A87680", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A877A0", Offset = "0x2A85DA0", VA = "0x182A877A0", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A87750", Offset = "0x2A85D50", VA = "0x182A87750", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void CFJGNGELHJE();

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A87620", Offset = "0x2A85C20", VA = "0x182A87620")]
	protected EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x1AA2350", Offset = "0x1AA0950", VA = "0x181AA2350")]
	protected EntityQuery BLDDDJEEKDG<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x1AA2B90", Offset = "0x1AA1190", VA = "0x181AA2B90")]
	protected LMPIAGDKNOK<T> LOLBDIOBPDH<T>() where T : struct, IComponentData
	{
		return default(LMPIAGDKNOK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x1AA3890", Offset = "0x1AA1E90", VA = "0x181AA3890")]
	protected GFMIPAJHMDN<T> OABEPDPCLMJ<T>() where T : struct, IComponentData
	{
		return default(GFMIPAJHMDN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x1AA2910", Offset = "0x1AA0F10", VA = "0x181AA2910")]
	protected static void EENAAPJHAHD<T1, T2>(MINFALADENH<T1> PMHCHADBGDF, MINFALADENH<T2> ICCDADBCHCE) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x1AA2910", Offset = "0x1AA0F10", VA = "0x181AA2910")]
	protected static void EENAAPJHAHD<T1, T2>(MINFALADENH<T1> PMHCHADBGDF, PMJLKLGEBFH<T2> ICCDADBCHCE) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x1AA2850", Offset = "0x1AA0E50", VA = "0x181AA2850")]
	private static void EENAAPJHAHD<T1, T2>(ANGEJGLOKCL<T1> PMHCHADBGDF, ANGEJGLOKCL<T2> ICCDADBCHCE) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	protected MOMBEIOEHPD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CKDDPEJBLMJ]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : MOMBEIOEHPD
	{
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public LMPIAGDKNOK<NDMGNOFKACP> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public LMPIAGDKNOK<LHBAAFMGKHE> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public LMPIAGDKNOK<BEHAEGOGLIO> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public LMPIAGDKNOK<OJPEGELMFKM> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public GFMIPAJHMDN<NGCDNCDIPIJ> v4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public BEHAEGOGLIO v2Default;

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x3C0FED0", Offset = "0x3C0E4D0", VA = "0x183C0FED0")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x3C105A0", Offset = "0x3C0EBA0", VA = "0x183C105A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		protected override IAMDAJKPFJC Log
		{
			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0x26192A0", Offset = "0x26178A0", VA = "0x1826192A0", Slot = "14")]
			get
			{
				return default(IAMDAJKPFJC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2619300", Offset = "0x2617900", VA = "0x182619300", Slot = "15")]
		public override IEnumerable<ICBJIAPAJOF.AOOJLFMPEFJ> OLJIPNADBOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2618A90", Offset = "0x2617090", VA = "0x182618A90", Slot = "16")]
		protected override void CFJGNGELHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x2619520", Offset = "0x2617B20", VA = "0x182619520")]
		private static void PHDJHGNDNPB(ANGEJGLOKCL<LHBAAFMGKHE> srcVersion, ANGEJGLOKCL<BEHAEGOGLIO> dstVersion, BEHAEGOGLIO dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2618F50", Offset = "0x2617550", VA = "0x182618F50")]
		private static void INKBBBJNHEM(ANGEJGLOKCL<BEHAEGOGLIO> srcVersion, ANGEJGLOKCL<OJPEGELMFKM> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2618E20", Offset = "0x2617420", VA = "0x182618E20")]
		private static void IEPGPNMPPJI(ANGEJGLOKCL<OJPEGELMFKM> srcVersion, ANGEJGLOKCL<NGCDNCDIPIJ> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2619070", Offset = "0x2617670", VA = "0x182619070")]
		private JobHandle KLNIJFDKNGO(LMPIAGDKNOK<NDMGNOFKACP> v0, LMPIAGDKNOK<LHBAAFMGKHE> v1, LMPIAGDKNOK<BEHAEGOGLIO> v2, LMPIAGDKNOK<OJPEGELMFKM> v3, GFMIPAJHMDN<NGCDNCDIPIJ> v4, BEHAEGOGLIO v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2614DD0", Offset = "0x26133D0", VA = "0x182614DD0")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
[AlwaysUpdateSystem]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public abstract class KKMNKFHBJPI : DIIPAOKEIKC, EMBHBGCIFNL
{
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private struct BNEBNELOJNF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public NativeListAsync<Entity> CCEEEAKAPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public NativeListAsync<Entity> OCKPKMMOFFE;

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x28ED6E0", Offset = "0x28EBCE0", VA = "0x1828ED6E0")]
		public BNEBNELOJNF(NativeList<Entity> CCEEEAKAPLC, NativeList<Entity> OCKPKMMOFFE, JobHandle CJAPIGNMJBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x28ED660", Offset = "0x28EBC60", VA = "0x1828ED660")]
		public JobHandle FAEELABLECD(JobHandle AIKFNHNINEI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x28ED5D0", Offset = "0x28EBBD0", VA = "0x1828ED5D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[BurstCompile]
	private struct LDGNOPPJIAA : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[Flags]
		public enum LJLGOFKPEGH
		{
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		[WriteOnly]
		public NativeList<Entity> NDLAAFKGKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		[WriteOnly]
		public NativeList<Entity> DJKDCKFNGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		[ReadOnly]
		public NativeArray<Entity> FALFLAAMPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		[ReadOnly]
		public BufferFromEntity<IHMGEAEOPIO> NKJCLFLDLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		[ReadOnly]
		public ComponentDataFromEntity EEHPGGLMMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		[ReadOnly]
		public ComponentDataFromEntity NMOJBNCCNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		[ReadOnly]
		public ComponentDataFromEntity<BCIOGPLFNGO> MAMICLEICPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public int OKNIJNJBECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public int MFALKNBIJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private LJLGOFKPEGH BBPIGHCKMJF;

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x28F89F0", Offset = "0x28F6FF0", VA = "0x1828F89F0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x28F8940", Offset = "0x28F6F40", VA = "0x1828F8940")]
		private bool EDFOGKBOCNB(Entity MPAGCMNFGMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x28F8CE0", Offset = "0x28F72E0", VA = "0x1828F8CE0")]
		private void JENPNPIPHII(Entity MPAGCMNFGMI, bool NEBKMJHJGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x28F8830", Offset = "0x28F6E30", VA = "0x1828F8830")]
		private void CPAFOEIHABE(Entity MPAGCMNFGMI, bool NEBKMJHJGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x28F87B0", Offset = "0x28F6DB0", VA = "0x1828F87B0")]
		public BNEBNELOJNF BMLJMBHAINH(NativeArray<Entity> BCPEGPJDFMI, JobHandle AIKFNHNINEI)
		{
			return default(BNEBNELOJNF);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x28F90D0", Offset = "0x28F76D0", VA = "0x1828F90D0")]
		public BNEBNELOJNF ONLBOIHNLJA(NativeArray<Entity> BCPEGPJDFMI, JobHandle AIKFNHNINEI)
		{
			return default(BNEBNELOJNF);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x28F8C00", Offset = "0x28F7200", VA = "0x1828F8C00")]
		public BNEBNELOJNF GNOCPIKANPJ(NativeList<GDJICEPBCLA> CKIKFMIOAHP, JobHandle AIKFNHNINEI)
		{
			return default(BNEBNELOJNF);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x28F8B20", Offset = "0x28F7120", VA = "0x1828F8B20")]
		public BNEBNELOJNF GMOHDIGMIJP(NativeList<GDJICEPBCLA> CKIKFMIOAHP, JobHandle AIKFNHNINEI)
		{
			return default(BNEBNELOJNF);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x28F8FF0", Offset = "0x28F75F0", VA = "0x1828F8FF0")]
		public BNEBNELOJNF OFGCKAJGOCK(NativeList<GPLDEABEJMM> CKIKFMIOAHP, JobHandle AIKFNHNINEI)
		{
			return default(BNEBNELOJNF);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2C93F50", Offset = "0x2C92550", VA = "0x182C93F50")]
		private BNEBNELOJNF NKKKOCDMHGG<T>(NativeList<T> CKIKFMIOAHP, int GKIOPDGPJDO, int LCFNPNENDBO, LJLGOFKPEGH CFNBBPIIFMA, JobHandle AIKFNHNINEI) where T : struct
		{
			return default(BNEBNELOJNF);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x28F8D70", Offset = "0x28F7370", VA = "0x1828F8D70")]
		private BNEBNELOJNF NKKKOCDMHGG(NativeArray<Entity> NCEOACJJMCN, int GKIOPDGPJDO, int LCFNPNENDBO, LJLGOFKPEGH CFNBBPIIFMA, JobHandle AIKFNHNINEI)
		{
			return default(BNEBNELOJNF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private EntityQuery FHCDCKJFILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private EntityQuery MBBCNAHPNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private DEECNKLJPLJ PBOGFEDNEMH;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	protected abstract ComponentType MLHCMDMHHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	protected abstract ComponentType PEHDIFADNED
	{
		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected abstract ComponentType JKKAPJCCDKK
	{
		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2CB0", Offset = "0x2AF12B0", VA = "0x182AF2CB0")]
	protected KKMNKFHBJPI(IAMDAJKPFJC BILPDCGHAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1920", Offset = "0x2AEFF20", VA = "0x182AF1920", Slot = "14")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1A50", Offset = "0x2AF0050", VA = "0x182AF1A50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1C80", Offset = "0x2AF0280", VA = "0x182AF1C80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x15BD9C0", Offset = "0x15BBFC0", VA = "0x1815BD9C0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1A00", Offset = "0x2AF0000", VA = "0x182AF1A00")]
	private void MNLNKCMOCME(NativeArray<Entity> CKIKFMIOAHP, EntityCommandBuffer EJOBGFBIEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AF13D0", Offset = "0x2AEF9D0", VA = "0x182AF13D0")]
	private void DEKMKCIGEAB(NativeArray<Entity> CKIKFMIOAHP, EntityCommandBuffer EJOBGFBIEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x2AF16E0", Offset = "0x2AEFCE0", VA = "0x182AF16E0")]
	private void HAAHJIAJHHE(BNEBNELOJNF KBNPAFOFAEE, string BHLGPCEAOGF, EntityCommandBuffer EJOBGFBIEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1810", Offset = "0x2AEFE10", VA = "0x182AF1810")]
	private void HAAHJIAJHHE(NativeListAsync<Entity> HLKBNHPOPKD, string BHLGPCEAOGF, EntityCommandBuffer EJOBGFBIEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1530", Offset = "0x2AEFB30", VA = "0x182AF1530")]
	private void EAACDDPONIN(BNEBNELOJNF KBNPAFOFAEE, string BHLGPCEAOGF, EntityCommandBuffer EJOBGFBIEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1420", Offset = "0x2AEFA20", VA = "0x182AF1420")]
	private void EAACDDPONIN(NativeListAsync<Entity> HLKBNHPOPKD, string BHLGPCEAOGF, EntityCommandBuffer EJOBGFBIEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1660", Offset = "0x2AEFC60", VA = "0x182AF1660")]
	private bool GBHMNMBGFNG()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	public class RegisterTransforms : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct RegisterTransforms_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public RegisterTransforms __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentTypeHandle<ACIGAKLLBFH> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x3C12E50", Offset = "0x3C11450", VA = "0x183C12E50")]
			private void OriginalLambdaBody(Entity entity, in ACIGAKLLBFH arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x3C12C60", Offset = "0x3C11260", VA = "0x183C12C60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private BAOLGEAKCOK embodiedTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private EntityQuery allTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private EntityQuery addNewTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private EntityQuery removeOldTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private EntityQuery clearTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private EntityQuery RegisterTransforms_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private ComponentTypeHandle<ACIGAKLLBFH> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x261FE60", Offset = "0x261E460", VA = "0x18261FE60", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x26200E0", Offset = "0x261E6E0", VA = "0x1826200E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2620350", Offset = "0x261E950", VA = "0x182620350", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x261FAE0", Offset = "0x261E0E0", VA = "0x18261FAE0")]
		private void AddTransforms(EntityQuery query, FMGNDFNEJOF accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2620680", Offset = "0x261EC80", VA = "0x182620680")]
		private void RemoveTransforms(EntityQuery query, FMGNDFNEJOF accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x26202F0", Offset = "0x261E8F0", VA = "0x1826202F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x261F9A0", Offset = "0x261DFA0", VA = "0x18261F9A0")]
		private void AddNewTransforms(NativeArray<Entity> entities, FMGNDFNEJOF accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2620440", Offset = "0x261EA40", VA = "0x182620440")]
		internal static void RemoveOldTransforms(NativeArray<ACIGAKLLBFH> arrayIndices, ComponentDataFromEntity<ACIGAKLLBFH> transformAccess, FMGNDFNEJOF accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		private static void DebugLogRemove(int index, FMGNDFNEJOF accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x261FD30", Offset = "0x261E330", VA = "0x18261FD30")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x261FD30", Offset = "0x261E330", VA = "0x18261FD30")]
		private void RegisterTransforms_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x261FEB0", Offset = "0x261E4B0", VA = "0x18261FEB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public RegisterTransforms()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
[OJJOJOKIEBL(typeof(LKEACJPELBE), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal sealed class LKEACJPELBE : GFOPHFDOHAP, EECDFKAILMM, LPOKOJIEHOF, EMBHBGCIFNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	[LABJLBKOJHN]
	private KKJOECNGBND JEAKBAFPNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	[LABJLBKOJHN]
	private LIACCBFBACG KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	[LABJLBKOJHN]
	private IFGBMAJAPAC JBAGHABAFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	[LABJLBKOJHN]
	private LGEKFEKPHDG OIOAKGIHHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	[LABJLBKOJHN]
	private DIHPJNIDFNC GLJBALFDOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	[LABJLBKOJHN]
	private EKOLMNJLLEE JHBJAKHPFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly Dictionary<EEKJFDFIEGN, FCLHKJAHMCN> NNPDPAJGCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private CAHGBMMCDKO DAGHIMJICLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F6A0", Offset = "0x2A7DCA0", VA = "0x182A7F6A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0xF54BE0", Offset = "0xF531E0", VA = "0x180F54BE0", Slot = "4")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F490", Offset = "0x2A7DA90", VA = "0x182A7F490", Slot = "5")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D080", Offset = "0x2A7B680", VA = "0x182A7D080")]
	public void DCLOJIPMFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F5C0", Offset = "0x2A7DBC0", VA = "0x182A7F5C0", Slot = "6")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DB40", Offset = "0x2A7C140", VA = "0x182A7DB40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A808B0", Offset = "0x2A7EEB0", VA = "0x182A808B0")]
	public int NFDFLEKLJNN(SceneTag GHAEGLKDDJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DDE0", Offset = "0x2A7C3E0", VA = "0x182A7DDE0")]
	public bool FIONDPFDECI(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A7ED00", Offset = "0x2A7D300", VA = "0x182A7ED00")]
	public bool IDOBKJNCGOE(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C870", Offset = "0x2A7AE70", VA = "0x182A7C870")]
	public bool AHHLAGNLFJP(Entity MPAGCMNFGMI, out FCLHKJAHMCN CBIMOLNMMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C8F0", Offset = "0x2A7AEF0", VA = "0x182A7C8F0")]
	private bool AHHLAGNLFJP(Transform DMECJMCKFAG, out FCLHKJAHMCN CBIMOLNMMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A802D0", Offset = "0x2A7E8D0", VA = "0x182A802D0")]
	private void LPODCJKIIBF(Entity MPAGCMNFGMI, FCLHKJAHMCN CBIMOLNMMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E570", Offset = "0x2A7CB70", VA = "0x182A7E570")]
	private bool HIAGMDOFABG(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x2A80370", Offset = "0x2A7E970", VA = "0x182A80370")]
	public void MBACIJOLGCB(EEKJFDFIEGN HGGMFNJGHIP, FCLHKJAHMCN PDIAKCKMCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x2A7ED20", Offset = "0x2A7D320", VA = "0x182A7ED20")]
	public bool IEJOOPJEOKH(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F300", Offset = "0x2A7D900", VA = "0x182A7F300")]
	public bool IEJOOPJEOKH(Entity MPAGCMNFGMI, [Optional] object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F370", Offset = "0x2A7D970", VA = "0x182A7F370")]
	public bool IEJOOPJEOKH(FCLHKJAHMCN PCJDHJGLBFI, object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D0D0", Offset = "0x2A7B6D0", VA = "0x182A7D0D0")]
	public bool DDFNBOCHOND(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F3A0", Offset = "0x2A7D9A0", VA = "0x182A7F3A0")]
	public bool IEJOOPJEOKH(FCLHKJAHMCN CBIMOLNMMAP, bool ODPLBAPFKKP, [Optional] object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E040", Offset = "0x2A7C640", VA = "0x182A7E040")]
	private bool HCKPKCDILFE(FCLHKJAHMCN CBIMOLNMMAP, object DCEGGIJLHGI, bool ODPLBAPFKKP, bool DKDNKPGKMNK, bool EAKOMNNBNBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DC90", Offset = "0x2A7C290", VA = "0x182A7DC90")]
	public Transform ENHIPCOKIPF(Entity MPAGCMNFGMI, [Optional] object DCEGGIJLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CCB0", Offset = "0x2A7B2B0", VA = "0x182A7CCB0")]
	public bool AMJHHOCDEFA(Entity MPAGCMNFGMI, out Transform DMECJMCKFAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D670", Offset = "0x2A7BC70", VA = "0x182A7D670")]
	public FCLHKJAHMCN DDIJEPCNDPH(Entity MPAGCMNFGMI, [Optional] object DCEGGIJLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C9A0", Offset = "0x2A7AFA0", VA = "0x182A7C9A0")]
	public void AHOHPGKBNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E590", Offset = "0x2A7CB90", VA = "0x182A7E590")]
	public void HMNOCKNDKOB(SceneTag GHAEGLKDDJL, bool DKDNKPGKMNK, NativeParallelHashSet<int> JALNJBNJLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F6F0", Offset = "0x2A7DCF0", VA = "0x182A7F6F0")]
	private void KMDEIPBLOME(Entity MPAGCMNFGMI, bool DKDNKPGKMNK, bool EAKOMNNBNBH, NativeParallelHashSet<int> JALNJBNJLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CE00", Offset = "0x2A7B400", VA = "0x182A7CE00")]
	public bool CKFCPFNJLCG(Entity MPAGCMNFGMI, object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x2A809A0", Offset = "0x2A7EFA0", VA = "0x182A809A0")]
	public bool PHKIGIFCEFF(Entity MPAGCMNFGMI, object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F3D0", Offset = "0x2A7D9D0", VA = "0x182A7F3D0")]
	public bool IIFKIHADMBF(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E9D0", Offset = "0x2A7CFD0", VA = "0x182A7E9D0")]
	private void IBDIKBPJEMM(bool IPICFJHNEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CD70", Offset = "0x2A7B370", VA = "0x182A7CD70")]
	private bool BHJGPCDGAAH(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DC40", Offset = "0x2A7C240", VA = "0x182A7DC40")]
	public FCLHKJAHMCN ELCFHMNPDAC(Entity MPAGCMNFGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x2A80090", Offset = "0x2A7E690", VA = "0x182A80090")]
	private FCLHKJAHMCN LOAJHLBJLHF(Entity MPAGCMNFGMI, object DCEGGIJLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EA90", Offset = "0x2A7D090", VA = "0x182A7EA90")]
	private FCLHKJAHMCN ICODPMAFOLL(Entity MPAGCMNFGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x2A80130", Offset = "0x2A7E730", VA = "0x182A80130")]
	public void LOGBMLKHBHO(NativeArray<EEKJFDFIEGN> LDNMHAEAEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x2A808D0", Offset = "0x2A7EED0", VA = "0x182A808D0")]
	private void NJIKJLCGHLI(ENMPPPDAMHN HMLJKOHAJKN, FCLHKJAHMCN PDIAKCKMCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E900", Offset = "0x2A7CF00", VA = "0x182A7E900")]
	private void HPJDMPPEOPM(FCLHKJAHMCN PDIAKCKMCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2A80630", Offset = "0x2A7EC30", VA = "0x182A80630")]
	private void MLOGLBNIIPL(FCLHKJAHMCN CBIMOLNMMAP, Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D740", Offset = "0x2A7BD40", VA = "0x182A7D740")]
	private void DJBOODGNOKO(Entity MPAGCMNFGMI, FCLHKJAHMCN CBIMOLNMMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CE80", Offset = "0x2A7B480", VA = "0x182A7CE80")]
	private void DAOFKFBNLGG(Entity MPAGCMNFGMI, Transform DMECJMCKFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DBF0", Offset = "0x2A7C1F0", VA = "0x182A7DBF0")]
	private ENMPPPDAMHN EFJOLPLCHHI(Entity MPAGCMNFGMI)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x2A80AB0", Offset = "0x2A7F0B0", VA = "0x182A80AB0")]
	public LKEACJPELBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2A80560", Offset = "0x2A7EB60", VA = "0x182A80560")]
	[CompilerGenerated]
	private void MDIDAEENIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public struct BJEMMMMLMIB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public OMLPFNCGEAG FCDGNCOICKN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000")]
	public static BJEMMMMLMIB LBBGOAOJJNO(in OMLPFNCGEAG FGIAIOIFIIP)
	{
		return default(BJEMMMMLMIB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000")]
	public static OMLPFNCGEAG LBBGOAOJJNO(in BJEMMMMLMIB AAHHCMBALFB)
	{
		return default(OMLPFNCGEAG);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	[CKDDPEJBLMJ]
	public class PostDeserializeUpgrade_Split_ContainerData : DIIPAOKEIKC, ICBJIAPAJOF.MHCJAJGDHBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Split_ContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public NativeArray<HOGLDMLGMDM> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x3C10B90", Offset = "0x3C0F190", VA = "0x183C10B90")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x3C10E40", Offset = "0x3C0F440", VA = "0x183C10E40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x261A3F0", Offset = "0x26189F0", VA = "0x18261A3F0", Slot = "14")]
		public IEnumerable<ICBJIAPAJOF.AOOJLFMPEFJ> OLJIPNADBOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x261A4C0", Offset = "0x2618AC0", VA = "0x18261A4C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x261A250", Offset = "0x2618850", VA = "0x18261A250")]
		private EntityCommandBufferSystem BDPMMNOPFAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x261A2A0", Offset = "0x26188A0", VA = "0x18261A2A0")]
		private JobHandle MIELOFFPHIP(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<HOGLDMLGMDM> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x261A990", Offset = "0x2618F90", VA = "0x18261A990")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class APMKHELPHMH : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x27C3840", Offset = "0x27C1E40", VA = "0x1827C3840", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x27C3A50", Offset = "0x27C2050", VA = "0x1827C3A50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x27C3B10", Offset = "0x27C2110", VA = "0x1827C3B10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x27C3890", Offset = "0x27C1E90", VA = "0x1827C3890")]
	private NativeArray<Entity> JBIMAEENOAH(int FJLPCOJGEJP)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x27C3730", Offset = "0x27C1D30", VA = "0x1827C3730")]
	private void HFJOMIGJKJE(NativeArray<Entity> OLBGMIBDMBJ, NativeArray<Entity> AJDAOFDCHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public APMKHELPHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[DefaultMember("Item")]
public struct KLMFOANBCMG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private BDGMNKDAGJD<T> JAIGDBINGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private int BFDDLCIBNMB;

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x2663900", Offset = "0x2661F00", VA = "0x182663900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2663950", Offset = "0x2661F50", VA = "0x182663950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[BurstCompile]
public struct BFMGDHLJJOC<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> FFMHECBDDJE;

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90")]
	public BFMGDHLJJOC(SharedComponentTypeHandle<T> FFMHECBDDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x2516FE0", Offset = "0x25155E0", VA = "0x182516FE0", Slot = "4")]
	public bool Equals(ArchetypeChunk HEICJNINGBE, ArchetypeChunk DNLDNFFNIEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x25170F0", Offset = "0x25156F0", VA = "0x1825170F0", Slot = "5")]
	public int GetHashCode(ArchetypeChunk FCONCDBMPAA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[GHIPPEMCIOG]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class GMFNPAOPGDO : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	private PGEMPCHAFFA PCCLEKIMKLJ;

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x24B9660", Offset = "0x24B7C60", VA = "0x1824B9660", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x24B96B0", Offset = "0x24B7CB0", VA = "0x1824B96B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public GMFNPAOPGDO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	[GHIPPEMCIOG]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	public class UpdateConnectableVisuals : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x200011D")]
		private struct HandlePosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public MGCLCHOHDHP handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public float3 position;

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x3A57810", Offset = "0x3A55E10", VA = "0x183A57810")]
			public HandlePosition(MGCLCHOHDHP handle, float3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0x3C0E850", Offset = "0x3C0CE50", VA = "0x183C0E850")]
			public void MGGDHGPEKNI(out MGCLCHOHDHP handle, out float3 position)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct UpdateVisualPositions_ParentWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public UpdateConnectableVisuals __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			[ReadOnly]
			public ComponentTypeHandle<GGKCINHFHOC> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public BufferTypeHandle<KDAKBDEHECJ> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x3C16770", Offset = "0x3C14D70", VA = "0x183C16770")]
			private void DKBFAIHFAHI(Entity entity, in GGKCINHFHOC pose, DynamicBuffer<KDAKBDEHECJ> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x3C169F0", Offset = "0x3C14FF0", VA = "0x183C169F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[NoAlias]
		[BurstCompile]
		private struct UpdateVisualPositions_ChildWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			[ReadOnly]
			public ComponentTypeHandle<GGKCINHFHOC> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public BufferTypeHandle<MFGPIBOPNFC> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x3C16510", Offset = "0x3C14B10", VA = "0x183C16510")]
			private void DKBFAIHFAHI([NoAlias] in GGKCINHFHOC pose, DynamicBuffer<MFGPIBOPNFC> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x3C16600", Offset = "0x3C14C00", VA = "0x183C16600", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[BurstCompile]
		[NoAlias]
		private struct UpdateVisualPositions_ChildWithCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			[ReadOnly]
			public ComponentTypeHandle<GGKCINHFHOC> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			[ReadOnly]
			public ComponentTypeHandle<KBPIEDEACLP> __comTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public BufferTypeHandle<MFGPIBOPNFC> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x3C161F0", Offset = "0x3C147F0", VA = "0x183C161F0")]
			private void DKBFAIHFAHI([NoAlias] in GGKCINHFHOC pose, [NoAlias] in KBPIEDEACLP com, DynamicBuffer<MFGPIBOPNFC> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0x3C16330", Offset = "0x3C14930", VA = "0x183C16330", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private EntityQuery addGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery addGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery updateGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery updateGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery removeExpiredGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private EntityQuery removeExpiredGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private EntityQuery removeAllGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery queryLegacyGizmoParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery queryChildrenWoutCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private EntityQuery queryChildrenWithCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private KMKKAEEIGLF<MGCLCHOHDHP, MEEEHHLENLE> linkVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private APFNGMLMBFH connectables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private JBBANOPACMB objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private LJIKPIOGIDO scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private MGPDFABDGMJ makerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private EntityQuery UpdateVisualPositions_ParentWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private EntityQuery UpdateVisualPositions_ChildWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery UpdateVisualPositions_ChildWithCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private ComponentTypeHandle<GGKCINHFHOC> __RecRoom_Components_WorldPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private ComponentTypeHandle<KBPIEDEACLP> __RecRoom_Rbex_RbexLocalCenterOfMassOfSelfData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x26235F0", Offset = "0x2621BF0", VA = "0x1826235F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2626670", Offset = "0x2624C70", VA = "0x182626670")]
		internal MEEEHHLENLE OOBEGDJDIJG(MGCLCHOHDHP handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x2624920", Offset = "0x2622F20", VA = "0x182624920", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x2626DE0", Offset = "0x26253E0", VA = "0x182626DE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x2627050", Offset = "0x2625650", VA = "0x182627050", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x26271E0", Offset = "0x26257E0", VA = "0x1826271E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x2627010", Offset = "0x2625610", VA = "0x182627010", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x26264D0", Offset = "0x2624AD0", VA = "0x1826264D0")]
		private void OEKJALHIBAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x26242C0", Offset = "0x26228C0", VA = "0x1826242C0")]
		private void IGLKANFGDCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x2624400", Offset = "0x2622A00", VA = "0x182624400")]
		private void IOJJKGKKFBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x2627220", Offset = "0x2625820", VA = "0x182627220", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x26238C0", Offset = "0x2621EC0", VA = "0x1826238C0")]
		private void GFCEDFCLACE(EntityQuery add, EntityQuery update, EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x26234B0", Offset = "0x2621AB0", VA = "0x1826234B0")]
		private void EIILGGCBFDG(EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x26249E0", Offset = "0x2622FE0", VA = "0x1826249E0")]
		private void JKEFMAKANOP(NativeArrayAsync<Entity> oldEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2623240", Offset = "0x2621840", VA = "0x182623240")]
		private void DIEFOFPDFJG(NativeArrayAsync<Entity> newEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2624050", Offset = "0x2622650", VA = "0x182624050")]
		private void HHJOLGNEBBF(NativeArrayAsync<Entity> updateEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2625AE0", Offset = "0x26240E0", VA = "0x182625AE0")]
		private void NBJOCIBEJMI(NativeList<MGCLCHOHDHP> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2625200", Offset = "0x2623800", VA = "0x182625200")]
		private NativeList<MGCLCHOHDHP> LODKHMLOMKK(NativeArray<Entity> entities)
		{
			return default(NativeList<MGCLCHOHDHP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x2622B70", Offset = "0x2621170", VA = "0x182622B70")]
		private void AGIPJOLIMLG(NativeArray<Entity> entities, NativeList<MGCLCHOHDHP> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2624C90", Offset = "0x2623290", VA = "0x182624C90")]
		private void LFJJAEDCNJP(NativeArray<Entity> addParents, NativeArray<Entity> addChildren, NativeList<MGCLCHOHDHP> freeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2626080", Offset = "0x2624680", VA = "0x182626080")]
		private void NKBGMIEDJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x2623350", Offset = "0x2621950", VA = "0x182623350")]
		private NativeListAsync<HandlePosition> EGKDCPAINJH(EntityQuery query, Func<NativeList<HandlePosition>, JobHandle> populateHandles)
		{
			return default(NativeListAsync<HandlePosition>);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2623EE0", Offset = "0x26224E0", VA = "0x182623EE0")]
		private JobHandle HDPAPIKOCDI(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x26247B0", Offset = "0x2622DB0", VA = "0x1826247B0")]
		private JobHandle IPBAGOLMMAF(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2625EE0", Offset = "0x26244E0", VA = "0x182625EE0")]
		private JobHandle NJMJGOEFMDE(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x2623630", Offset = "0x2621C30", VA = "0x182623630")]
		private void FECAHCPNDCO(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2625C50", Offset = "0x2624250", VA = "0x182625C50")]
		private void NHFNFGJBICL(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2623590", Offset = "0x2621B90", VA = "0x182623590")]
		private bool EMMFAAGEDCE(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x26241F0", Offset = "0x26227F0", VA = "0x1826241F0")]
		private NativeArray<Entity> ICOFDBMALGI(Entity entity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2625780", Offset = "0x2623D80", VA = "0x182625780")]
		private MGCLCHOHDHP MAIGFNNACDL(NativeList<MGCLCHOHDHP> freeList)
		{
			return default(MGCLCHOHDHP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x26265E0", Offset = "0x2624BE0", VA = "0x1826265E0")]
		private void OMENCCHFMBF(MGCLCHOHDHP handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x26230F0", Offset = "0x26216F0", VA = "0x1826230F0")]
		private void APDPFMALFMF(ref NativeList<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2623D70", Offset = "0x2622370", VA = "0x182623D70")]
		private JobHandle GHDEOGMJKFN(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2625940", Offset = "0x2623F40", VA = "0x182625940")]
		private JobHandle MFMEHLFNEEN(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x26266C0", Offset = "0x2624CC0", VA = "0x1826266C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public UpdateConnectableVisuals()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	internal sealed class WriteDiffChangePacketToNetworkSystem : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		[NoAlias]
		private struct WriteDiffChangePacketToNetworkSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x2000124")]
			public delegate void RunWithoutJobSystem_00000913$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000125")]
			internal static class RunWithoutJobSystem_00000913$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40003F8")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40003F9")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x3C135A0", Offset = "0x3C11BA0", VA = "0x183C135A0")]
				[BurstDiscard]
				private static void ABAONOAEPNG(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x3C139D0", Offset = "0x3C11FD0", VA = "0x183C139D0")]
				private static IntPtr NEJLCENAIPL()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000786")]
				[Cpp2IlInjected.Address(RVA = "0x3C136F0", Offset = "0x3C11CF0", VA = "0x183C136F0")]
				public static void AHKGFJNBLNO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000787")]
				[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
				public static void GMAKAKECEDK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000789")]
				[Cpp2IlInjected.Address(RVA = "0x3C137B0", Offset = "0x3C11DB0", VA = "0x183C137B0")]
				public static void JLDGENJLEHM(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public CNCNDJOAIPP replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			[ReadOnly]
			public NativeArray<EEKJFDFIEGN> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			[ReadOnly]
			public NativeArray<FNDBMHENIMP> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			[ReadOnly]
			public NativeArray<EEKJFDFIEGN> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, CBJNCBOLPDM> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public NativeList<EEKJFDFIEGN> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public NativeList<FNDBMHENIMP> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public NativeList<EEKJFDFIEGN> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public NativeParallelMultiHashMap<EEKJFDFIEGN, IPFEKNFNPDF> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public ComponentDataFromEntity<GPFOFHIKGAP> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x3C16C10", Offset = "0x3C15210", VA = "0x183C16C10")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x3C17100", Offset = "0x3C15700", VA = "0x183C17100", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x3C16BB0", Offset = "0x3C151B0", VA = "0x183C16BB0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void APGMJEJLMLN(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x3C17110", Offset = "0x3C15710", VA = "0x183C17110")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void JPANCAPNHHE(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly IAMDAJKPFJC logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		[LABJLBKOJHN]
		private BEGFKAEHLFO packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		[LABJLBKOJHN]
		private MBKAKKEBAGC diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		[LABJLBKOJHN]
		private DLBAJHIENKP editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		[LABJLBKOJHN]
		private JJNJPCKJNLO transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private LJHBFNNMDMA.PDBHNBPLDBE utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		private HJKCHEKLGOP EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x28FFBC0", Offset = "0x28FE1C0", VA = "0x1828FFBC0")]
			get
			{
				return default(HJKCHEKLGOP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x28FF690", Offset = "0x28FDC90", VA = "0x1828FF690", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2900B20", Offset = "0x28FF120", VA = "0x182900B20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x28FF1E0", Offset = "0x28FD7E0", VA = "0x1828FF1E0")]
		private bool FEFGNAOAGFL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2900F70", Offset = "0x28FF570", VA = "0x182900F70")]
		private bool PHHAIJMCNPN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2900870", Offset = "0x28FEE70", VA = "0x182900870")]
		private bool NHFNPIEPALM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2900010", Offset = "0x28FE610", VA = "0x182900010")]
		private LJHBFNNMDMA.LPPMMPJAIOJ NAOEPMODJOB(GKCMNHOMNPL state)
		{
			return default(LJHBFNNMDMA.LPPMMPJAIOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x28FEF90", Offset = "0x28FD590", VA = "0x1828FEF90")]
		private NativeKeyValueArrays<Entity, CBJNCBOLPDM> EMOPKLKFLMM(GKCMNHOMNPL state, out int capacity)
		{
			return default(NativeKeyValueArrays<Entity, CBJNCBOLPDM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x28FF810", Offset = "0x28FDE10", VA = "0x1828FF810")]
		private void JMNIOEICJJO(LJHBFNNMDMA.LPPMMPJAIOJ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x28FEEA0", Offset = "0x28FD4A0", VA = "0x1828FEEA0")]
		private void COLODAOAIFG(LJHBFNNMDMA.LPPMMPJAIOJ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x28FFC60", Offset = "0x28FE260", VA = "0x1828FFC60")]
		private void MHLAGFBBDKG(LJHBFNNMDMA.LPPMMPJAIOJ data, GKCMNHOMNPL state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x28FF580", Offset = "0x28FDB80", VA = "0x1828FF580")]
		private void HDDBOGHBJLI(NativeArray<EEKJFDFIEGN> createdIds, NativeArray<FNDBMHENIMP> creationData, HJKCHEKLGOP flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x28FE7D0", Offset = "0x28FCDD0", VA = "0x1828FE7D0")]
		private void BMADEHNCJNI(NativeMultiHashMapAsync<Entity, CBJNCBOLPDM> differences, HJKCHEKLGOP flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x28FF750", Offset = "0x28FDD50", VA = "0x1828FF750")]
		private void JICNDINLFDG(NativeArray<EEKJFDFIEGN> destroyedIds, HJKCHEKLGOP flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x28FF2B0", Offset = "0x28FD8B0", VA = "0x1828FF2B0")]
		private void GEIMCFIFAIF(ref CNCNDJOAIPP replication, ref NativeBitArray entityByProperty, ref NativeArray<EEKJFDFIEGN> srcCreatedIds, ref NativeArray<FNDBMHENIMP> srcCreationData, ref NativeArray<EEKJFDFIEGN> srcDestroyedIds, ref NativeKeyValueArrays<Entity, CBJNCBOLPDM> srcPropertyKeyValues, ref NativeList<EEKJFDFIEGN> dstCreatedIds, ref NativeList<FNDBMHENIMP> dstCreationData, ref NativeList<EEKJFDFIEGN> dstDestroyedIds, ref NativeParallelMultiHashMap<EEKJFDFIEGN, IPFEKNFNPDF> dstProperties, ref NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x29008C0", Offset = "0x28FEEC0", VA = "0x1829008C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x28FFB70", Offset = "0x28FE170", VA = "0x1828FFB70")]
		public static void JNOMDIIMPBA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal readonly struct GLKLAEGLEIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	private readonly ADCENKMOEIJ HBJJFDLPOOD;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private static readonly ProfilerMarker OGGGENHMLAP;

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x24B8780", Offset = "0x24B6D80", VA = "0x1824B8780")]
	public GLKLAEGLEIJ(World IJNKKJPPAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x24B85F0", Offset = "0x24B6BF0", VA = "0x1824B85F0")]
	public JobHandle GFCEDFCLACE(JobHandle MABEBDOOFLD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal static class GNJGOKMDMCK
{
	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x2B423A0", Offset = "0x2B409A0", VA = "0x182B423A0")]
	public static NativeArray<T> NKKKOCDMHGG<T>(NativeArray<Entity> NCEOACJJMCN, EntityManager PHHGGAMLDGB) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x24B9E10", Offset = "0x24B8410", VA = "0x1824B9E10")]
	public static void CAFBIGMLBFG(EntityQuery OGAAEGIJKLI, EntityManager PHHGGAMLDGB, JBBANOPACMB OKJDHECIFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x24B9F50", Offset = "0x24B8550", VA = "0x1824B9F50")]
	public static void FJGCCHBFLJL(NativeArray<Entity> OLBGMIBDMBJ, JBBANOPACMB OKJDHECIFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x24BA0A0", Offset = "0x24B86A0", VA = "0x1824BA0A0")]
	public static void MFMGFMKBHKH(NativeArray<Entity> OLBGMIBDMBJ, JBBANOPACMB OKJDHECIFKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class FMPIMJCLEGM : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private BDMBICNIMIJ FMFGPJKCPPN;

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x24B1480", Offset = "0x24AFA80", VA = "0x1824B1480", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x24B14D0", Offset = "0x24AFAD0", VA = "0x1824B14D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public FMPIMJCLEGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public class IEIBCGEOGID : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	private static IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private EntityQuery EKHBFOIGKGC;

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x2AD84E0", Offset = "0x2AD6AE0", VA = "0x182AD84E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8780", Offset = "0x2AD6D80", VA = "0x182AD8780", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public IEIBCGEOGID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal struct OACBIDKHCGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private static readonly ProfilerMarker OGGGENHMLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private readonly DIIPAOKEIKC CPDLEGJAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private NativeList<(EntityQuery query, int componentIndex)> AMJJDLAGFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private NativeList<(EntityQuery query, int componentIndex)> LGGCGCKBANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private NativeList<(EntityQuery query, int componentIndex)> PNPOFMADIEC;

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x260B190", Offset = "0x2609790", VA = "0x18260B190")]
	public OACBIDKHCGE(DIIPAOKEIKC CPDLEGJAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x260A770", Offset = "0x2608D70", VA = "0x18260A770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x260ABB0", Offset = "0x26091B0", VA = "0x18260ABB0")]
	public NativeList<(EntityQuery, int, int, FGOEJDLKLFE.FNPAALKBFDA)> GJMACMLPFAJ(uint AAHGLBFOJJA, out int OCHAEEHMEFI)
	{
		return default(NativeList<(EntityQuery, int, int, FGOEJDLKLFE.FNPAALKBFDA)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0x260A5C0", Offset = "0x2608BC0", VA = "0x18260A5C0")]
	private int DGOMOCOCHOI(FGOEJDLKLFE.FNPAALKBFDA CFNBBPIIFMA, NativeList<(EntityQuery query, int typeIndex)> JDCGNJBJHCM, NativeList<(EntityQuery query, int typeIndex, int count, FGOEJDLKLFE.FNPAALKBFDA mode)> NOBPCAEDFEG, uint AAHGLBFOJJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x260A530", Offset = "0x2608B30", VA = "0x18260A530")]
	private NativeList<(EntityQuery, int)> ABAIHLFCAOH(NativeParallelHashSet<int> CDMNKFEHHOM, int LECMNBKKDBH)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x260A570", Offset = "0x2608B70", VA = "0x18260A570")]
	private NativeList<(EntityQuery, int)> AHFKLBOJNOM(NativeParallelHashSet<int> CDMNKFEHHOM, int LECMNBKKDBH)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x260A7D0", Offset = "0x2608DD0", VA = "0x18260A7D0")]
	private NativeList<(EntityQuery, int)> GBMMBDBOKPJ(NativeParallelHashSet<int> CDMNKFEHHOM, int LECMNBKKDBH, FGOEJDLKLFE.FNPAALKBFDA CFNBBPIIFMA)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x260ADE0", Offset = "0x26093E0", VA = "0x18260ADE0")]
	private NativeList<(EntityQuery, int)> OIBDCGFDBPP()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public enum MMADHJNGOCC
{
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct JKEHBJKPGBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public MMADHJNGOCC EFKKKPJODFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public int MNPIGLOICMH;

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0xA54600", Offset = "0xA52C00", VA = "0x180A54600")]
	public JKEHBJKPGBK(MMADHJNGOCC EFKKKPJODFJ, int MNPIGLOICMH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2FF0", Offset = "0x2AE15F0", VA = "0x182AE2FF0")]
	public static JKEHBJKPGBK LBBGOAOJJNO((MMADHJNGOCC eventType, int eventIndex) HEICJNINGBE)
	{
		return default(JKEHBJKPGBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3010", Offset = "0x2AE1610", VA = "0x182AE3010")]
	public void MGGDHGPEKNI(out MMADHJNGOCC EFKKKPJODFJ, out int MNPIGLOICMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public struct GFMIPAJHMDN<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private KAJIKMFGFBN<T> MPNDOHBKHJO;

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x24E0AD0", Offset = "0x24DF0D0", VA = "0x1824E0AD0")]
	public GFMIPAJHMDN(KAJIKMFGFBN<T> MPNDOHBKHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x24E09D0", Offset = "0x24DEFD0", VA = "0x1824E09D0")]
	public PMJLKLGEBFH<T> BBANEIMNFKI()
	{
		return default(PMJLKLGEBFH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public readonly struct CBJNCBOLPDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly BENLOGNDJHK MJBJADACIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private readonly int AJHFAKMNONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private unsafe readonly byte* EEIOJIEKIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private unsafe readonly byte* IHPGJHIDEGJ;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public BENLOGNDJHK HJEFIBFMHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0")]
		get
		{
			return default(BENLOGNDJHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public int JLLEAFLJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D43610", Offset = "0x1D41C10", VA = "0x181D43610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public unsafe byte* EJFHCAPNPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xACAB80", Offset = "0xAC9180", VA = "0x180ACAB80")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public unsafe byte* KDGBDFMJNEE
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x27CE390", Offset = "0x27CC990", VA = "0x1827CE390")]
	public NGKHEJGAHGD FJAMJKIIFFM(Type KLGGKKGCLHM)
	{
		return default(NGKHEJGAHGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x3092F80", Offset = "0x3091580", VA = "0x183092F80")]
	public T NFPAFCEBFJH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x3092F60", Offset = "0x3091560", VA = "0x183092F60")]
	public T FJAMJKIIFFM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x27CE570", Offset = "0x27CCB70", VA = "0x1827CE570")]
	public unsafe CBJNCBOLPDM(BENLOGNDJHK MJBJADACIFB, int OCMPILAHMAJ, byte* EEIOJIEKIPG, byte* IHPGJHIDEGJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal struct JBIENKHEKGA : IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	[CKDDPEJBLMJ]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : MOMBEIOEHPD
	{
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public LMPIAGDKNOK<KLOPGFFGGJH> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			public GFMIPAJHMDN<FLAKOIGHJDJ> v2;

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x3C0FC30", Offset = "0x3C0E230", VA = "0x183C0FC30")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x3C0FEC0", Offset = "0x3C0E4C0", VA = "0x183C0FEC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		protected override IAMDAJKPFJC Log
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x26186E0", Offset = "0x2616CE0", VA = "0x1826186E0", Slot = "14")]
			get
			{
				return default(IAMDAJKPFJC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x2618740", Offset = "0x2616D40", VA = "0x182618740", Slot = "15")]
		public override IEnumerable<ICBJIAPAJOF.AOOJLFMPEFJ> OLJIPNADBOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x2618570", Offset = "0x2616B70", VA = "0x182618570", Slot = "16")]
		protected override void CFJGNGELHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x2618800", Offset = "0x2616E00", VA = "0x182618800")]
		private static void PHDJHGNDNPB(ANGEJGLOKCL<KLOPGFFGGJH> srcVersion, ANGEJGLOKCL<FLAKOIGHJDJ> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x26188D0", Offset = "0x2616ED0", VA = "0x1826188D0")]
		private JobHandle PPPDDDPKLNK(LMPIAGDKNOK<KLOPGFFGGJH> v1, GFMIPAJHMDN<FLAKOIGHJDJ> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x2614DD0", Offset = "0x26133D0", VA = "0x182614DD0")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class MECJBEJCGBM : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private EntityQuery OOCEOAIPFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private EntityQuery IMLBFDJELFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private GOMJAHLAFPG KOBLJDIMIFH;

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x2A83850", Offset = "0x2A81E50", VA = "0x182A83850", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A838A0", Offset = "0x2A81EA0", VA = "0x182A838A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A839F0", Offset = "0x2A81FF0", VA = "0x182A839F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A837E0", Offset = "0x2A81DE0", VA = "0x182A837E0")]
	private void FKHPDMCCIHA(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public MECJBEJCGBM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
public struct KDOGNFMPOLG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal class KLDKGDMIODL : CAODOHKABMK, GKCMNHOMNPL
{
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly PMDMEBKMCNG NDNKHLAHDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly ADMKFPPIBEF JHBJAKHPFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly World IJNKKJPPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private readonly List<MMLPILKMICH> IPJBOCEFNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private NativeParallelMultiHashMap<Entity, CBJNCBOLPDM> PGBDHDAFIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private NativeParallelHashMap<int, int> BAIHKIPHDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private NativeArray<EEKJFDFIEGN> OPHACLOMLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private NativeArray<FNDBMHENIMP> HNMKHJBPNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private NativeArray<EEKJFDFIEGN> KIHBDEPGKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private JobHandle BMKMGHLLMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private JobHandle MBMEOIGAAOG;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private NativeParallelMultiHashMap<Entity, CBJNCBOLPDM> HPFDEJJHNKC
	{
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xCEA020", Offset = "0xCE8620", VA = "0x180CEA020", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, CBJNCBOLPDM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private uint KJBBOMDHODF
	{
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A71960", Offset = "0x2A6FF60", VA = "0x182A71960", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	private bool NFFPJGPLGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A726E0", Offset = "0x2A70CE0", VA = "0x182A726E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private NativeArray<EEKJFDFIEGN> GMFAAFNHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xE3A070", Offset = "0xE38670", VA = "0x180E3A070", Slot = "10")]
		get
		{
			return default(NativeArray<EEKJFDFIEGN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private NativeArray<FNDBMHENIMP> OJPPLCBMFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xE3A7C0", Offset = "0xE38DC0", VA = "0x180E3A7C0", Slot = "11")]
		get
		{
			return default(NativeArray<FNDBMHENIMP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private NativeArray<EEKJFDFIEGN> MKDAGAONGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A71E80", Offset = "0x2A70480", VA = "0x182A71E80", Slot = "12")]
		get
		{
			return default(NativeArray<EEKJFDFIEGN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A72780", Offset = "0x2A70D80", VA = "0x182A72780")]
	public KLDKGDMIODL(PMDMEBKMCNG NDNKHLAHDDC, ADMKFPPIBEF JHBJAKHPFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A721E0", Offset = "0x2A707E0", VA = "0x182A721E0", Slot = "6")]
	private bool KLCNKGIEOGE(NativeArray<EEKJFDFIEGN> OPHACLOMLBN, NativeArray<FNDBMHENIMP> HNMKHJBPNJK, NativeArray<EEKJFDFIEGN> KIHBDEPGKFD, int CBJFFAMBOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A72100", Offset = "0x2A70700", VA = "0x182A72100", Slot = "7")]
	private void INNNCFGHCOF(in MMLPILKMICH DABGDPOOFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A71A10", Offset = "0x2A70010", VA = "0x182A71A10", Slot = "8")]
	private void EDEDAKHHJDM(JobHandle FCDGNCOICKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A72630", Offset = "0x2A70C30", VA = "0x182A72630", Slot = "13")]
	private bool OOLEBPHDJOC(out NativeArray<int> INPAJCBPPEP, Allocator HINEEPDGLPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A72460", Offset = "0x2A70A60", VA = "0x182A72460", Slot = "14")]
	private bool NPEIBIKINBH(ComponentType OLPLAHPNFFJ, out MMLPILKMICH KEGHBKCBNAE, out CLDDCIMIPFO NKKBJPEDINK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A723E0", Offset = "0x2A709E0", VA = "0x182A723E0", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, CBJNCBOLPDM> MIKJBFKOAHN()
	{
		return default(NativeMultiHashMapAsync<Entity, CBJNCBOLPDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A71B60", Offset = "0x2A70160", VA = "0x182A71B60")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A71E90", Offset = "0x2A70490", VA = "0x182A71E90")]
	private bool GIKAAEJCMOG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[InternalBufferCapacity(4)]
internal struct KDAKBDEHECJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public MGCLCHOHDHP FCDGNCOICKN;
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class HEMCMDMMIHI : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x24BCFE0", Offset = "0x24BB5E0", VA = "0x1824BCFE0", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public HEMCMDMMIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal class BFHCBMKEBBO : GHDAJGIMJFL
{
	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public BFHCBMKEBBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal class MCOFPNMIKBM
{
	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public MCOFPNMIKBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
public readonly struct IPFEKNFNPDF : IEquatable<IPFEKNFNPDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly BENLOGNDJHK MJBJADACIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly int AJHFAKMNONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private readonly int EEIOJIEKIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private readonly int IHPGJHIDEGJ;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public BENLOGNDJHK HJEFIBFMHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0")]
		get
		{
			return default(BENLOGNDJHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA540", Offset = "0x2AD8B40", VA = "0x182ADA540")]
	public unsafe ReadOnlySpan<byte> NFPAFCEBFJH(void* JOJLBCINJFJ)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA490", Offset = "0x2AD8A90", VA = "0x182ADA490")]
	public unsafe ReadOnlySpan<byte> FJAMJKIIFFM(void* JOJLBCINJFJ)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0x2048F60", Offset = "0x2047560", VA = "0x182048F60")]
	public IPFEKNFNPDF(BENLOGNDJHK MJBJADACIFB, int OCMPILAHMAJ, int EEIOJIEKIPG, int IHPGJHIDEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA350", Offset = "0x2AD8950", VA = "0x182ADA350", Slot = "4")]
	public bool Equals(IPFEKNFNPDF FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA3C0", Offset = "0x2AD89C0", VA = "0x182ADA3C0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA500", Offset = "0x2AD8B00", VA = "0x182ADA500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CKDDPEJBLMJ]
	[CompilerGenerated]
	[GHIPPEMCIOG]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : MOMBEIOEHPD, ICBJIAPAJOF.MHCJAJGDHBC
	{
		[Cpp2IlInjected.Token(Token = "0x200013B")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public LMPIAGDKNOK<GPMDIEICLIM> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public LMPIAGDKNOK<CNOBHIGJNMG> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x3C105B0", Offset = "0x3C0EBB0", VA = "0x183C105B0")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x3C10910", Offset = "0x3C0EF10", VA = "0x183C10910", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		protected override IAMDAJKPFJC Log
		{
			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0x2619BE0", Offset = "0x26181E0", VA = "0x182619BE0", Slot = "14")]
			get
			{
				return default(IAMDAJKPFJC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x2619C40", Offset = "0x2618240", VA = "0x182619C40", Slot = "15")]
		public override IEnumerable<ICBJIAPAJOF.AOOJLFMPEFJ> OLJIPNADBOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x2619750", Offset = "0x2617D50", VA = "0x182619750", Slot = "16")]
		protected override void CFJGNGELHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x2619950", Offset = "0x2617F50", VA = "0x182619950")]
		private static void FDFGAGADCOP(MINFALADENH<CNOBHIGJNMG> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x2619A90", Offset = "0x2618090", VA = "0x182619A90")]
		private JobHandle KGCBGCPPPNH(LMPIAGDKNOK<GPMDIEICLIM> v0, LMPIAGDKNOK<CNOBHIGJNMG> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x2614DD0", Offset = "0x26133D0", VA = "0x182614DD0")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public readonly struct MMLPILKMICH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NativeList<Entity> OHCFFCCPKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0xB91190", Offset = "0xB8F790", VA = "0x180B91190")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public NativeList<Entity> EKFCEKFNLMD
	{
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x90BEC0", Offset = "0x90A4C0", VA = "0x18090BEC0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public NativeList<byte> KFOGDODBLPM
	{
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x9358D0", Offset = "0x933ED0", VA = "0x1809358D0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public NativeList<byte> NLLGJMOPAOA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0xCEA020", Offset = "0xCE8620", VA = "0x180CEA020")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public NativeList<byte> IANJOBJEKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x9358F0", Offset = "0x933EF0", VA = "0x1809358F0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public ComponentType GAAHIJOHEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public JobHandle CCFABJCJIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xB9C0F0", Offset = "0xB9A6F0", VA = "0x180B9C0F0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public int PMFDAKBDJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x1ED2020", Offset = "0x1ED0620", VA = "0x181ED2020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public int JNCAJNGPCLI
	{
		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xB9C120", Offset = "0xB9A720", VA = "0x180B9C120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public bool GDDAECHLOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A87540", Offset = "0x2A85B40", VA = "0x182A87540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A875C0", Offset = "0x2A85BC0", VA = "0x182A875C0")]
	public MMLPILKMICH(ComponentType OLPLAHPNFFJ, JobHandle FCDGNCOICKN, NativeList<Entity> NCEOACJJMCN, NativeList<Entity> GNOAIHHPMBN, NativeList<byte> LLIECHJGKKN, NativeList<byte> MLEAJEKKEAB, NativeList<byte> HJLIAKLHFKL, int DLLLIMHAFHK, int AJHFAKMNONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A87420", Offset = "0x2A85A20", VA = "0x182A87420", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public abstract class PLAJLNBHEFP : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	protected virtual FNILJLPBJPB PJPLOIDGGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "14")]
		get
		{
			return default(FNILJLPBJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	protected virtual FNILJLPBJPB IPPNJJNMCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x952150", Offset = "0x950750", VA = "0x180952150", Slot = "15")]
		get
		{
			return default(FNILJLPBJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void CNBNEFEHICO(FNILJLPBJPB MPNDOHBKHJO);

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x2611BB0", Offset = "0x26101B0", VA = "0x182611BB0", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x2611B50", Offset = "0x2610150", VA = "0x182611B50")]
	private FNILJLPBJPB GDKCFJKPHMK()
	{
		return default(FNILJLPBJPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	protected PLAJLNBHEFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[OJJOJOKIEBL(typeof(JJPMDANOJAP), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
[OKNNJFAGDOM(typeof(EMNFNBCOPIC))]
public class JJPMDANOJAP : EMNFNBCOPIC, LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	private struct FCFGEFJFOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public NJFNDPOIPIK HJAKFBBDPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public Type KLGGKKGCLHM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	private struct FIIGLNECNDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public FCFGEFJFOAM[] EGDOOPNCMJB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[BurstCompile]
	private struct PKEMNLPBCOI : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		[ReadOnly]
		public NativeArray<byte> DHDCDEOGFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[ReadOnly]
		public NativeArray<Entity> PLJCJCDJJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		[ReadOnly]
		public NativeArray<byte> NDHHJJLEOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		[ReadOnly]
		public NativeArray<byte> BBPGEDOIPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		[WriteOnly]
		public NativeList<Entity> PKKBCEDLGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		[WriteOnly]
		public NativeList<byte> HLOOLGIMFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		[WriteOnly]
		public NativeList<byte> GAMOEKEOMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public int INHIAICGHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public int OKJMCEPMBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int LJJLDFJMLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int BGLJMJDCPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public int ECNPOBONIKG;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x28FB3B0", Offset = "0x28F99B0", VA = "0x1828FB3B0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly Dictionary<BENLOGNDJHK, NJFNDPOIPIK> FHOFBNDKGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly Dictionary<int, FIIGLNECNDI> OKIFKHAADCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private MKPEFGNMDIP EGDOOPNCMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action KAOGOANPHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2E00", Offset = "0x2AE1400", VA = "0x182AE2E00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AE14A0", Offset = "0x2ADFAA0", VA = "0x182AE14A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action JMHNIFCCPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AE17B0", Offset = "0x2ADFDB0", VA = "0x182AE17B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2220", Offset = "0x2AE0820", VA = "0x182AE2220")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1DC0", Offset = "0x2AE03C0", VA = "0x182AE1DC0", Slot = "6")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1850", Offset = "0x2ADFE50", VA = "0x182AE1850", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE23B0", Offset = "0x2AE09B0", VA = "0x182AE23B0", Slot = "4")]
	public void MBACIJOLGCB(CNGBAJDBKGM JCPKNOEICEG, NJFNDPOIPIK LELMIPHHCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1540", Offset = "0x2ADFB40", VA = "0x182AE1540", Slot = "5")]
	public void BDNBMIGFIII(CNGBAJDBKGM JCPKNOEICEG, NJFNDPOIPIK LELMIPHHCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AE22C0", Offset = "0x2AE08C0", VA = "0x182AE22C0", Slot = "8")]
	public void MBACIJOLGCB(BENLOGNDJHK FPNKFNICEDM, NJFNDPOIPIK AJNAMFOHMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1690", Offset = "0x2ADFC90", VA = "0x182AE1690", Slot = "9")]
	public void BDNBMIGFIII(BENLOGNDJHK FPNKFNICEDM, NJFNDPOIPIK AJNAMFOHMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1E30", Offset = "0x2AE0430", VA = "0x182AE1E30")]
	private void KNOOJONJDHC(BENLOGNDJHK FPNKFNICEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1FE0", Offset = "0x2AE05E0", VA = "0x182AE1FE0")]
	internal void LDENHANLLCL(GKCMNHOMNPL ILFDGGGKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2500", Offset = "0x2AE0B00", VA = "0x182AE2500")]
	private void NGBIDJLJAGA(GKCMNHOMNPL ILFDGGGKIBE, int MPGHGDABPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x2AE18E0", Offset = "0x2ADFEE0", VA = "0x182AE18E0")]
	private void EDALGJHGOPE(EPFAAOCCGEJ MHJDBAPOFEE, ELBEJOMIKKE BAHMJFHOFEA, FCFGEFJFOAM IPABDNDEGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1C40", Offset = "0x2AE0240", VA = "0x182AE1C40")]
	private FIIGLNECNDI ELEDKJNAPNB(EPFAAOCCGEJ MHJDBAPOFEE, ELBEJOMIKKE BAHMJFHOFEA)
	{
		return default(FIIGLNECNDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1B50", Offset = "0x2AE0150", VA = "0x182AE1B50")]
	private FCFGEFJFOAM EGBIOHCNBJB(FIIGLNECNDI NKKBJPEDINK, EPFAAOCCGEJ MHJDBAPOFEE, ELBEJOMIKKE BAHMJFHOFEA)
	{
		return default(FCFGEFJFOAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2F30", Offset = "0x2AE1530", VA = "0x182AE2F30")]
	public JJPMDANOJAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal class HPLKLBMEPPM : FDPKALFDCJN
{
	[Cpp2IlInjected.Token(Token = "0x17000108")]
	protected override ADMKFPPIBEF ANLHAKENMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x952150", Offset = "0x950750", VA = "0x180952150", Slot = "17")]
		get
		{
			return default(ADMKFPPIBEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6160", Offset = "0x2AD4760", VA = "0x182AD6160")]
	public HPLKLBMEPPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
public class BOPGIECLGJI : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[BurstCompile]
	private struct MIGDAAMCJHB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		[ReadOnly]
		public ComponentTypeHandle<LCEGPOLIGKI> JFFLCAIIEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		[ReadOnly]
		public BufferTypeHandle<IHMGEAEOPIO> PFGMIEKMIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		[ReadOnly]
		public BufferFromEntity<IHMGEAEOPIO> NKJCLFLDLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		[ReadOnly]
		public ComponentDataFromEntity<LCEGPOLIGKI> OJIOKEBAMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public ComponentTypeHandle<JKCIFKNJAAP> KOJPHPKOKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<JKCIFKNJAAP> DANAPDENMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public uint IAIKLPLKODM;

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x28FA280", Offset = "0x28F8880", VA = "0x1828FA280", Slot = "4")]
		public void Execute(ArchetypeChunk FCONCDBMPAA, int OLGOBCPPPBB, int IHINDCCMJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x28FA580", Offset = "0x28F8B80", VA = "0x1828FA580")]
		private void OHBBKNIEPGP(float4x4 LJDDEHDOEFA, Entity MPAGCMNFGMI, bool HJCHHNBFLEM, int AJKFADODKIF = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private EntityQuery HNMMHAHAKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private EntityQuery JNCPFJEGBBI;

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x27CD090", Offset = "0x27CB690", VA = "0x1827CD090", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x27CD1B0", Offset = "0x27CB7B0", VA = "0x1827CD1B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public BOPGIECLGJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[GHIPPEMCIOG]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class OIDFGEFIFOO : DIIPAOKEIKC, EECDFKAILMM, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[BurstCompile]
	private struct OGBNHCOBMEA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		[ReadOnly]
		public EntityTypeHandle PLJCJCDJJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[ReadOnly]
		public ComponentTypeHandle<GGKCINHFHOC> APLOFGAJPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		[WriteOnly]
		public NativeList<BMMBGICDGOH>.ParallelWriter EDEJALHDJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public ComponentTypeHandle<NFNGNHNDHML> GKEBFEJJDNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public float3 LIGIEJOGFAH;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private static readonly float4x2 POBCHPDOABM;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private static readonly float4x2 ECGEHBAHPIM;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private static readonly int4x2 FNEOKEHBKPD;

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E9C0", Offset = "0x3C0CFC0", VA = "0x183C0E9C0", Slot = "4")]
		public void Execute(ArchetypeChunk FCONCDBMPAA, int GLFHEEDGKCK, int JAJGKGJOHJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private static IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery EOLHJBIECAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private EntityQuery IGNJNKMAIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private double HKPFCCDHOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private FFIEDGLJPJJ KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	private FBCFPEGCOHB LBHAJNMIHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private PGEMPCHAFFA PCCLEKIMKLJ;

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x260DA70", Offset = "0x260C070", VA = "0x18260DA70", Slot = "14")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x260D6F0", Offset = "0x260BCF0", VA = "0x18260D6F0", Slot = "15")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x260DA80", Offset = "0x260C080", VA = "0x18260DA80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x260DBD0", Offset = "0x260C1D0", VA = "0x18260DBD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x260D640", Offset = "0x260BC40", VA = "0x18260D640")]
	private bool IKFCOKILNOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x260D780", Offset = "0x260BD80", VA = "0x18260D780")]
	private void OCEPPAJNKPO(EntityQuery OGAAEGIJKLI, float3 IMFACANIECH, string ECMAPGHKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public OIDFGEFIFOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
[OJJOJOKIEBL(typeof(FOKGJFJPKEK), new string[] { })]
[FIJBPDAJCNE(typeof(EOMEEBLCJPE))]
public class OHPPJPOIADB : FOKGJFJPKEK, EECDFKAILMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly Dictionary<int, IMNNLGNGPKK> AFIGLKAFMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private readonly Dictionary<Type, IMNNLGNGPKK> BEKAHBIDKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly Dictionary<Type, IMNNLGNGPKK> ALLMOPLBHBK;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public IReadOnlyCollection<IMNNLGNGPKK> GIEKDLKKKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x260CB00", Offset = "0x260B100", VA = "0x18260CB00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x260CBD0", Offset = "0x260B1D0", VA = "0x18260CBD0", Slot = "7")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x260CB50", Offset = "0x260B150", VA = "0x18260CB50", Slot = "6")]
	public IMNNLGNGPKK KFJHOLCOHJM(Type KLGGKKGCLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x260CA40", Offset = "0x260B040", VA = "0x18260CA40", Slot = "5")]
	public bool BHGFLFPGFCO(int MPGHGDABPMN, out IMNNLGNGPKK EGDOOPNCMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x260CAB0", Offset = "0x260B0B0", VA = "0x18260CAB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x260CE70", Offset = "0x260B470", VA = "0x18260CE70")]
	public OHPPJPOIADB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal class LDCIMPLBGFF : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private NDKPGBMKGJL KOBLJDIMIFH;

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x2A75F80", Offset = "0x2A74580", VA = "0x182A75F80", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x2A76500", Offset = "0x2A74B00", VA = "0x182A76500", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x2A765B0", Offset = "0x2A74BB0", VA = "0x182A765B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x2A75FD0", Offset = "0x2A745D0", VA = "0x182A75FD0")]
	private void OOEBBCHAHLO(NativeArray<Entity> NCEOACJJMCN, NativeList<Entity> MIHPPCEFACI, ComponentDataFromEntity<MNIBFMPEFMN> HJJMDOKEIDE, BufferFromEntity<IHMGEAEOPIO> ELBFPPLJFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public LDCIMPLBGFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public class EEOMCOHFBIP : DIIPAOKEIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private OPLBKFHGADJ NKHEOBELIKH;

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x24A0D50", Offset = "0x249F350", VA = "0x1824A0D50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x24A0E20", Offset = "0x249F420", VA = "0x1824A0E20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public EEOMCOHFBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class OCIGFPPEMDJ
{
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly DEKJDDCLMEB JCEGIKLPKEF;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly DEKJDDCLMEB NPNBANGHNOC;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly DEKJDDCLMEB LDAABKCHFML;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public class ADJLOMBAHLI : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[BurstCompile]
	private struct CFNHEMMKOBI : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[ReadOnly]
		public ComponentTypeHandle<OGEEBLLKOPC> CJCAPHDGIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[ReadOnly]
		public ComponentTypeHandle<DDHBNLFNGBI> ECHCJHLCBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		[ReadOnly]
		public ComponentTypeHandle<GEELFDNKLBO> CBEOPDDPNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public ComponentTypeHandle<LCEGPOLIGKI> FNNJJGNGPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public uint IAIKLPLKODM;

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x28EDF60", Offset = "0x28EC560", VA = "0x1828EDF60", Slot = "4")]
		public void Execute(ArchetypeChunk FCONCDBMPAA, int OLGOBCPPPBB, int IHINDCCMJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x28EDE60", Offset = "0x28EC460", VA = "0x1828EDE60")]
		public bool AMHHHBOFGAN(ArchetypeChunk FCONCDBMPAA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private EntityQuery JEAKBAFPNAB;

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x27BF7E0", Offset = "0x27BDDE0", VA = "0x1827BF7E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x27BF910", Offset = "0x27BDF10", VA = "0x1827BF910", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public ADJLOMBAHLI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePoints : DIIPAOKEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			[ReadOnly]
			public ComponentDataFromEntity<GDEOBAAEKDF> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x3C0EEF0", Offset = "0x3C0D4F0", VA = "0x183C0EEF0", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200014F")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeSortSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F630", Offset = "0x3C0DC30", VA = "0x183C0F630")]
			private void DKBFAIHFAHI(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F6C0", Offset = "0x3C0DCC0", VA = "0x183C0F6C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private EntityQuery PostDeserializeSortSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2616AB0", Offset = "0x26150B0", VA = "0x182616AB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x2616C60", Offset = "0x2615260", VA = "0x182616C60")]
		private void PBBBNNIPAMP(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x2616770", Offset = "0x2614D70", VA = "0x182616770", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PostDeserializeSortSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public static class ICBJIAPAJOF
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface MHCJAJGDHBC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public interface AOOJLFMPEFJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public class LCFFGEEPJLN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public class FDLAJKLCHGH : AOOJLFMPEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x28F2150", Offset = "0x28F0750", VA = "0x1828F2150")]
		public FDLAJKLCHGH(ComponentType PAKFOBAPADB, ComponentType DOPBDOPAHMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public class EJOHGKBMMLM : AOOJLFMPEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x28F2100", Offset = "0x28F0700", VA = "0x1828F2100")]
		public EJOHGKBMMLM(ComponentType PAKFOBAPADB, ComponentType[] DOPBDOPAHMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public class JABJLELOIKD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x11D3DC0", Offset = "0x11D23C0", VA = "0x1811D3DC0")]
	public static AOOJLFMPEFJ HGBLABAFCKF<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0x11D4240", Offset = "0x11D2840", VA = "0x1811D4240")]
	public static AOOJLFMPEFJ JKEEPOBEEGL<TFrom>(params ComponentType[] CMDCMJNCHIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
[OJJOJOKIEBL(typeof(MCCOHLNACPH), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal sealed class MCCOHLNACPH : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private LKEACJPELBE CBIMOLNMMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private GMAFMCNFCKL HBNACONFCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x2A829B0", Offset = "0x2A80FB0", VA = "0x182A829B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<KIHFNANBKDD, NativeArray<BLIAAMDKPNO>> EIBMMCALJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x2A826B0", Offset = "0x2A80CB0", VA = "0x182A826B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x2A82A00", Offset = "0x2A81000", VA = "0x182A82A00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<KIHFNANBKDD> JOCBHBNJMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x2A82BC0", Offset = "0x2A811C0", VA = "0x182A82BC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x2A81E50", Offset = "0x2A80450", VA = "0x182A81E50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2A82820", Offset = "0x2A80E20", VA = "0x182A82820", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0xB878C0", Offset = "0xB85EC0", VA = "0x180B878C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2A81DD0", Offset = "0x2A803D0", VA = "0x182A81DD0")]
	public bool AFPHGIBLJIN(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2A81B90", Offset = "0x2A80190", VA = "0x182A81B90")]
	public void AEEAPLHBKLI(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x2A82660", Offset = "0x2A80C60", VA = "0x182A82660")]
	public void FDJNGBKNPHP(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x2A82AA0", Offset = "0x2A810A0", VA = "0x182A82AA0")]
	private bool NPCGBCOJHBC(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2A81BD0", Offset = "0x2A801D0", VA = "0x182A81BD0")]
	public void AFFJDJOCMDN(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x2A81EF0", Offset = "0x2A804F0", VA = "0x182A81EF0")]
	private bool CCENDLMMDAM(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x2A82550", Offset = "0x2A80B50", VA = "0x182A82550")]
	public void ENNCOPBPMIP(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x2A828D0", Offset = "0x2A80ED0", VA = "0x182A828D0")]
	private void JCHHHHLPCDB(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0x2A82C60", Offset = "0x2A81260", VA = "0x182A82C60")]
	private void PJOJDCFBOJH(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x2A827C0", Offset = "0x2A80DC0", VA = "0x182A827C0")]
	private void ICIHEAGJDNF(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084B")]
	[Cpp2IlInjected.Address(RVA = "0x2A822B0", Offset = "0x2A808B0", VA = "0x182A822B0")]
	private void EGJBNFBODPP(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x2A82930", Offset = "0x2A80F30", VA = "0x182A82930")]
	public void JCIAAHBMDIK(KIHFNANBKDD BFIMLFNBNGO, NativeArray<BLIAAMDKPNO> EBCEGDCHNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x2A82750", Offset = "0x2A80D50", VA = "0x182A82750")]
	public void IALHACCOMBM(KIHFNANBKDD BFIMLFNBNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private void PMHOMINMJCM(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x2A820B0", Offset = "0x2A806B0", VA = "0x182A820B0")]
	private void DGDFNMFBCKA(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public MCCOHLNACPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
public class CAHGBMMCDKO : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private EntityQuery NCFADLMJKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private EntityQuery JENFGJDDDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private EntityQuery CFJAOHCOAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private EntityQuery PPHCGICKGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private LKEACJPELBE FGAEPEHOJCK;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public int LGHMOCNLJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x27CD550", Offset = "0x27CBB50", VA = "0x1827CD550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x27CD7E0", Offset = "0x27CBDE0", VA = "0x1827CD7E0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x27CDAE0", Offset = "0x27CC0E0", VA = "0x1827CDAE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x27CDCE0", Offset = "0x27CC2E0", VA = "0x1827CDCE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x27CDAC0", Offset = "0x27CC0C0", VA = "0x1827CDAC0")]
	public int NFDFLEKLJNN(SceneTag GHAEGLKDDJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x27CD840", Offset = "0x27CBE40", VA = "0x1827CD840")]
	protected void JANCGCOPHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x27CD560", Offset = "0x27CBB60", VA = "0x1827CD560")]
	protected void DAKGAEJEIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x27CD680", Offset = "0x27CBC80", VA = "0x1827CD680")]
	public NativeArrayAsync<Entity> GINAEIOMODI(SceneTag GHAEGLKDDJL, Allocator HINEEPDGLPG = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x27CD730", Offset = "0x27CBD30", VA = "0x1827CD730")]
	public NativeArrayAsync<Entity> HOAPKMFMHAH(SceneTag GHAEGLKDDJL, Allocator HINEEPDGLPG = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x27CD9F0", Offset = "0x27CBFF0", VA = "0x1827CD9F0")]
	public bool JONBKFPGDLP(SceneTag GHAEGLKDDJL, out NativeArrayAsync<Entity> CBIMOLNMMAP, Allocator HINEEPDGLPG = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x27CD780", Offset = "0x27CBD80", VA = "0x1827CD780")]
	public bool IDOBKJNCGOE(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x27CD4E0", Offset = "0x27CBAE0", VA = "0x1827CD4E0")]
	public bool AHHLAGNLFJP(Entity MPAGCMNFGMI, out NBNGAHFIHPP CBIMOLNMMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(RVA = "0x27CDA80", Offset = "0x27CC080", VA = "0x1827CDA80")]
	public void LPODCJKIIBF(Entity MPAGCMNFGMI, NBNGAHFIHPP CBIMOLNMMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x27CD6D0", Offset = "0x27CBCD0", VA = "0x1827CD6D0")]
	public bool HIAGMDOFABG(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public CAHGBMMCDKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[OJJOJOKIEBL(typeof(EKOLMNJLLEE), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal sealed class EKOLMNJLLEE
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public enum KMDEHDFAELP
	{
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public struct FLPOFLDMMOD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private KMDEHDFAELP CENAKCMIOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private readonly EKOLMNJLLEE HDBBNLFBJKG;

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x28F2890", Offset = "0x28F0E90", VA = "0x1828F2890")]
		public FLPOFLDMMOD(EKOLMNJLLEE HDBBNLFBJKG, KMDEHDFAELP JHBJAKHPFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x28F2860", Offset = "0x28F0E60", VA = "0x1828F2860", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public KMDEHDFAELP JHBJAKHPFJI;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public KMDEHDFAELP PHOECLJKALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1A0", Offset = "0x7E87A0", VA = "0x1807EA1A0")]
		get
		{
			return default(KMDEHDFAELP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E30", Offset = "0x9B5430", VA = "0x1809B6E30")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool PLNKLJMHPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x227D060", Offset = "0x227B660", VA = "0x18227D060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000864")]
	[Cpp2IlInjected.Address(RVA = "0x24A1300", Offset = "0x249F900", VA = "0x1824A1300")]
	public FLPOFLDMMOD HHGALFGODLN()
	{
		return default(FLPOFLDMMOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x24A12D0", Offset = "0x249F8D0", VA = "0x1824A12D0")]
	public FLPOFLDMMOD ENOHNBEIEEJ()
	{
		return default(FLPOFLDMMOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x10A5F20", Offset = "0x10A4520", VA = "0x1810A5F20")]
	public EKOLMNJLLEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal readonly struct JMJFMCPHCCH
{
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private static readonly ProfilerMarker OGGGENHMLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private readonly DIIPAOKEIKC CPDLEGJAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private readonly World IJNKKJPPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private readonly EntityQuery AMIKDNIIBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private readonly EntityQuery PBDFAKBGAJB;

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE60F0", Offset = "0x2AE46F0", VA = "0x182AE60F0")]
	public JMJFMCPHCCH(DIIPAOKEIKC CPDLEGJAIIP, World IJNKKJPPAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5EB0", Offset = "0x2AE44B0", VA = "0x182AE5EB0")]
	public NativeArray<EEKJFDFIEGN> GFCEDFCLACE()
	{
		return default(NativeArray<EEKJFDFIEGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5FC0", Offset = "0x2AE45C0", VA = "0x182AE5FC0")]
	public void HEIMFKCENBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5AA0", Offset = "0x2AE40A0", VA = "0x182AE5AA0")]
	private NativeArray<EEKJFDFIEGN> DMAOLGACNOI(EntityQuery OGAAEGIJKLI)
	{
		return default(NativeArray<EEKJFDFIEGN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class CKLKAAIDPLF : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x27D2CB0", Offset = "0x27D12B0", VA = "0x1827D2CB0", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public CKLKAAIDPLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class EIJLHKEIJKM : GHDAJGIMJFL
{
	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public EIJLHKEIJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal class DLDNFNLGHLN : GHDAJGIMJFL
{
	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public DLDNFNLGHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct KAFPLLCKBLD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public int FIFIFGFPIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public int CHHMHDKPLJD;
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public class IAEMNAIMELJ : ParentSystemBase<OEMCDAHANNB, OEKKBLAFHKG, MJAGKJKNKOM>
{
	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6490", Offset = "0x2AD4A90", VA = "0x182AD6490", Slot = "14")]
	protected override EntityQueryDesc NHIGCDHIONJ(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x9491F0", Offset = "0x9477F0", VA = "0x1809491F0", Slot = "15")]
	protected override EntityQueryDesc FKEMAFFOLPO(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6450", Offset = "0x2AD4A50", VA = "0x182AD6450", Slot = "16")]
	protected override EntityQueryDesc LJLABPDKNOE(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6410", Offset = "0x2AD4A10", VA = "0x182AD6410", Slot = "17")]
	protected override EntityQueryDesc KNGCCHCHIKN(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0x2AD64D0", Offset = "0x2AD4AD0", VA = "0x182AD64D0")]
	public IAEMNAIMELJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal class DPFBGNIPIBL : PMGDLHEJJAE
{
	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	protected override DEKJDDCLMEB BJHKELLEKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x27D8DB0", Offset = "0x27D73B0", VA = "0x1827D8DB0", Slot = "15")]
		get
		{
			return default(DEKJDDCLMEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000879")]
	[Cpp2IlInjected.Address(RVA = "0x249E4E0", Offset = "0x249CAE0", VA = "0x18249E4E0")]
	public DPFBGNIPIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
public sealed class KLIDCLFLIFA : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x600087A")]
	[Cpp2IlInjected.Address(RVA = "0x2A728E0", Offset = "0x2A70EE0", VA = "0x182A728E0", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600087B")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public KLIDCLFLIFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[ExecuteAlways]
public class IAKLOJFPKOP : IHADAAMNPBN
{
	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	public IAKLOJFPKOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
public class PLKJBBCOFKD : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private EntityQuery GLBPCDDEBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private EntityQuery GINDGLJEBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private EntityQuery ACCEHEOMKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private EntityQuery AJJGAGBPNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private KGPKDCJJLAE KOBLJDIMIFH;

	[Cpp2IlInjected.Token(Token = "0x600087D")]
	[Cpp2IlInjected.Address(RVA = "0x2611DD0", Offset = "0x26103D0", VA = "0x182611DD0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087E")]
	[Cpp2IlInjected.Address(RVA = "0x2612130", Offset = "0x2610730", VA = "0x182612130", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087F")]
	[Cpp2IlInjected.Address(RVA = "0x2612360", Offset = "0x2610960", VA = "0x182612360", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000880")]
	[Cpp2IlInjected.Address(RVA = "0x2612490", Offset = "0x2610A90", VA = "0x182612490")]
	private void PDDBDHJNBOH(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(RVA = "0x2611D60", Offset = "0x2610360", VA = "0x182611D60")]
	private void EIILGGCBFDG(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000882")]
	[Cpp2IlInjected.Address(RVA = "0x26122F0", Offset = "0x26108F0", VA = "0x1826122F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000883")]
	[Cpp2IlInjected.Address(RVA = "0x2611E20", Offset = "0x2610420", VA = "0x182611E20")]
	private void NDAPGPHJNGL(EntityQuery OGAAEGIJKLI, bool OLELHLONAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000884")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public PLKJBBCOFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public sealed class MJAMOMBNEHO : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000886")]
	[Cpp2IlInjected.Address(RVA = "0x2A84580", Offset = "0x2A82B80", VA = "0x182A84580", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000887")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public MJAMOMBNEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
[OJJOJOKIEBL(typeof(NPNABHOPEBI), new string[] { })]
internal sealed class NPNABHOPEBI : LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private EKOLMNJLLEE NDCKHGGLFKB;

	[Cpp2IlInjected.Token(Token = "0x6000888")]
	[Cpp2IlInjected.Address(RVA = "0x260A4B0", Offset = "0x2608AB0", VA = "0x18260A4B0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000889")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public NPNABHOPEBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal class FFPCMIOCMCK : BKKPIKCCOMM
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	protected override DEKJDDCLMEB BJHKELLEKME
	{
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x24AD190", Offset = "0x24AB790", VA = "0x1824AD190", Slot = "15")]
		get
		{
			return default(DEKJDDCLMEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600088B")]
	[Cpp2IlInjected.Address(RVA = "0x24A4310", Offset = "0x24A2910", VA = "0x1824A4310")]
	public FFPCMIOCMCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
[OJJOJOKIEBL(typeof(APFNGMLMBFH), new string[] { })]
internal class JIBMJBBGEAJ : APFNGMLMBFH, LPOKOJIEHOF, EMBHBGCIFNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class CBOHMEPLBPO : IEnumerable<ENMPPPDAMHN>, IEnumerable, IEnumerator<ENMPPPDAMHN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private ENMPPPDAMHN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private ENMPPPDAMHN localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public ENMPPPDAMHN <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public JIBMJBBGEAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityManager <entityManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private LocalId <entity>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private DynamicBuffer<MJAGKJKNKOM> <children>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private NativeArray<Entity> <childEntities>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private NativeArray<Entity> <childEntitiesCopy>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private NativeArray<Entity>.Enumerator <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private Entity <child>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		private ENMPPPDAMHN System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x28EDC60", Offset = "0x28EC260", VA = "0x1828EDC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ENMPPPDAMHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0x28EDCC0", Offset = "0x28EC2C0", VA = "0x1828EDCC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x97B9F0", Offset = "0x979FF0", VA = "0x18097B9F0")]
		[DebuggerHidden]
		public CBOHMEPLBPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x28EDD10", Offset = "0x28EC310", VA = "0x1828EDD10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x28ED870", Offset = "0x28EBE70", VA = "0x1828ED870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x28ED7D0", Offset = "0x28EBDD0", VA = "0x1828ED7D0")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x28ED820", Offset = "0x28EBE20", VA = "0x1828ED820")]
		private void GKPOLPOJHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x28EDC80", Offset = "0x28EC280", VA = "0x1828EDC80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x28EDBB0", Offset = "0x28EC1B0", VA = "0x1828EDBB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ENMPPPDAMHN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x28EDBB0", Offset = "0x28EC1B0", VA = "0x1828EDBB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private static readonly IAMDAJKPFJC MEIOGNEDMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private AJMKMBOMDNO KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private JJPMDANOJAP CFBGPMFMALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private FEHHJLHONFC<Entity> IOJHJBMCLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private FEHHJLHONFC<float3> KJJJHKMPGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private FEHHJLHONFC<quaternion> ALCGLDFEPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private FEHHJLHONFC<float> HAFEOJCNLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private HashSet<Entity> DOEFEMFAAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private HashSet<Entity> ILPOIIJECHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private EntityQuery BLPFFBICPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Func<MEEEHHLENLE> GODGJIKJLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x9DA620", Offset = "0x9D8C20", VA = "0x1809DA620", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BA0", Offset = "0x9D81A0", VA = "0x1809D9BA0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<ENMPPPDAMHN, ENMPPPDAMHN> JALKHICLAML
	{
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE800", Offset = "0x2ADCE00", VA = "0x182ADE800", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE760", Offset = "0x2ADCD60", VA = "0x182ADE760", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<ENMPPPDAMHN, ENMPPPDAMHN> OMLJAFHPFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0030", Offset = "0x2ADE630", VA = "0x182AE0030", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE980", Offset = "0x2ADCF80", VA = "0x182ADE980", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<ENMPPPDAMHN, ENMPPPDAMHN, ENMPPPDAMHN> FJPLHHELKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDFB0", Offset = "0x2ADC5B0", VA = "0x182ADDFB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x2AE00D0", Offset = "0x2ADE6D0", VA = "0x182AE00D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<ENMPPPDAMHN> IAPIMCOJMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE630", Offset = "0x2ADCC30", VA = "0x182ADE630", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFC80", Offset = "0x2ADE280", VA = "0x182ADFC80", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEC50", Offset = "0x2ADD250", VA = "0x182ADEC50", Slot = "26")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF160", Offset = "0x2ADD760", VA = "0x182ADF160", Slot = "27")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE2F0", Offset = "0x2ADC8F0", VA = "0x182ADE2F0", Slot = "28")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0170", Offset = "0x2ADE770", VA = "0x182AE0170")]
	private void OPFPCGEOLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0x2ADFAF0", Offset = "0x2ADE0F0", VA = "0x182ADFAF0")]
	private void NKJBCOPIHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0x2ADFD20", Offset = "0x2ADE320", VA = "0x182ADFD20")]
	private void OEOFIOGOEKM(HPCDDCJODHI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEDB0", Offset = "0x2ADD3B0", VA = "0x182ADEDB0")]
	private void JCIMMICAKGJ(HPCDDCJODHI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x178E5D0", Offset = "0x178CBD0", VA = "0x18178E5D0", Slot = "14")]
	public Color NBJCJNGHDFO(ENMPPPDAMHN HMLJKOHAJKN, int OGHLIAOOOPG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEA20", Offset = "0x2ADD020", VA = "0x182ADEA20", Slot = "15")]
	public float3 IFJOHHLPIIC(ENMPPPDAMHN HMLJKOHAJKN, int OGHLIAOOOPG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE8A0", Offset = "0x2ADCEA0", VA = "0x182ADE8A0", Slot = "16")]
	public bool HCIIEFAKLFE(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN GNJOACJHOLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A0")]
	[Cpp2IlInjected.Address(RVA = "0x2AE01D0", Offset = "0x2ADE7D0", VA = "0x182AE01D0", Slot = "17")]
	public ENMPPPDAMHN PNFNAPBHDCP(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A1")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF950", Offset = "0x2ADDF50", VA = "0x182ADF950", Slot = "20")]
	public void NGCDIJDKJAH(ENMPPPDAMHN HMLJKOHAJKN, Vector3 PGFKMDCFOBF, Quaternion KPNEHIKPEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A2")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE050", Offset = "0x2ADC650", VA = "0x182ADE050", Slot = "21")]
	public void ABFFEHIFAED(ENMPPPDAMHN HMLJKOHAJKN, float LONBLMKEDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A3")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF7C0", Offset = "0x2ADDDC0", VA = "0x182ADF7C0", Slot = "24")]
	public float3 LAIJAGNGHNN(HLHJGCIDGNC MKCLCDAOEBD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF890", Offset = "0x2ADDE90", VA = "0x182ADF890", Slot = "25")]
	public quaternion MFDIJCMEGFK(HLHJGCIDGNC MKCLCDAOEBD)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE110", Offset = "0x2ADC710", VA = "0x182ADE110", Slot = "22")]
	public bool AEACPHECJKA(ENMPPPDAMHN HMLJKOHAJKN, out RigidTransform NHFMBKHAIMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF640", Offset = "0x2ADDC40", VA = "0x182ADF640", Slot = "23")]
	public bool KIIDBKLGBDA(ENMPPPDAMHN HMLJKOHAJKN, out float LONBLMKEDEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE6D0", Offset = "0x2ADCCD0", VA = "0x182ADE6D0", Slot = "18")]
	[IteratorStateMachine(typeof(CBOHMEPLBPO))]
	public IEnumerable<ENMPPPDAMHN> FDACOJKALHO(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEED0", Offset = "0x2ADD4D0", VA = "0x182ADEED0", Slot = "19")]
	public ENMPPPDAMHN KFPLAMJDOEC(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A9")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF050", Offset = "0x2ADD650", VA = "0x182ADF050")]
	private Entity KFPLAMJDOEC(Entity MPAGCMNFGMI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008AA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE03A0", Offset = "0x2ADE9A0", VA = "0x182AE03A0")]
	public JIBMJBBGEAJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : DIIPAOKEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		[BurstCompile]
		[NoAlias]
		private struct PreSerializeDowngrade_RRObjectPrefabTypeData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[ReadOnly]
			public SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunksRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			[ReadOnly]
			public NativeParallelHashMap<int, int> prefabTypeFromIndexRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			public KHCAGCKMDIL.MPMCABKELCG<ArchetypeChunk, BFMGDHLJJOC<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			public NativeList<CNOBHIGJNMG> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0x3C119A0", Offset = "0x3C0FFA0", VA = "0x183C119A0")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0x3C11C60", Offset = "0x3C10260", VA = "0x183C11C60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x261DAA0", Offset = "0x261C0A0", VA = "0x18261DAA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x261DB30", Offset = "0x261C130", VA = "0x18261DB30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x261D6E0", Offset = "0x261BCE0", VA = "0x18261D6E0")]
		private EntityCommandBufferSystem BDPMMNOPFAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x261D730", Offset = "0x261BD30", VA = "0x18261D730")]
		private JobHandle BNNEJHBDBHM(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, KHCAGCKMDIL.MPMCABKELCG<ArchetypeChunk, BFMGDHLJJOC<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<CNOBHIGJNMG> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x261D8E0", Offset = "0x261BEE0", VA = "0x18261D8E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
internal struct MGCLCHOHDHP : EPBCOPJMPPK, IEquatable<MGCLCHOHDHP>
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public int FIFIFGFPIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951740", VA = "0x180953140", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int CHHMHDKPLJD
	{
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D43610", Offset = "0x1D41C10", VA = "0x181D43610", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A83C00", Offset = "0x2A82200", VA = "0x182A83C00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A83BB0", Offset = "0x2A821B0", VA = "0x182A83BB0", Slot = "8")]
	public bool Equals(MGCLCHOHDHP FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A83C10", Offset = "0x2A82210", VA = "0x182A83C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[OJJOJOKIEBL(typeof(JMGAPHGFIPO), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal sealed class JMGAPHGFIPO : LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	[LABJLBKOJHN]
	private JEEOIALHEAK JLNLCDDIEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	[LABJLBKOJHN]
	private CBIHOPCFCDD EJKOPEGGPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	[LABJLBKOJHN]
	private LDONCAMGPOJ BLBDABPHPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	[LABJLBKOJHN]
	private GHMKMBPEGGE LKGDMEFDKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	[LABJLBKOJHN]
	private FHBCPABBPOI HJPKICIKNFH;

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x2AE56F0", Offset = "0x2AE3CF0", VA = "0x182AE56F0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AE58C0", Offset = "0x2AE3EC0", VA = "0x182AE58C0")]
	public void LJAELKGMCMD(NativeArray<BLIAAMDKPNO> EBCEGDCHNNH, NativeArray<EEKJFDFIEGN> LDNMHAEAEME, NativeArray<Entity> PKDJKKFMCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE58B0", Offset = "0x2AE3EB0", VA = "0x182AE58B0")]
	public Entity LJAELKGMCMD(BLIAAMDKPNO POJMFCODLHG, EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5380", Offset = "0x2AE3980", VA = "0x182AE5380")]
	public Entity EGMBMOKGKKD(BLIAAMDKPNO POJMFCODLHG, bool JFCBHFIDNFJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE53D0", Offset = "0x2AE39D0", VA = "0x182AE53D0")]
	public Entity EGMBMOKGKKD(BLIAAMDKPNO POJMFCODLHG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5340", Offset = "0x2AE3940", VA = "0x182AE5340")]
	public Entity DKAGGLAKDJP()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5570", Offset = "0x2AE3B70", VA = "0x182AE5570")]
	public Entity IIJCEINICFO(IFEBDPAFELD KLGGKKGCLHM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE52E0", Offset = "0x2AE38E0", VA = "0x182AE52E0")]
	public KIHFNANBKDD BKAFCMHHBBL(KIHFNANBKDD BEDADBBGMAL, Allocator HINEEPDGLPG)
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CD")]
	[Cpp2IlInjected.Address(RVA = "0x2AE52A0", Offset = "0x2AE38A0", VA = "0x182AE52A0")]
	public EntityArchetype AJIBOLKCHEE(BLIAAMDKPNO POJMFCODLHG)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5410", Offset = "0x2AE3A10", VA = "0x182AE5410")]
	public Entity GEOAAGIPFLI(BLIAAMDKPNO POJMFCODLHG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5380", Offset = "0x2AE3980", VA = "0x182AE5380")]
	private Entity INIDIOGECAO(BLIAAMDKPNO POJMFCODLHG, bool JFCBHFIDNFJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D0")]
	[Cpp2IlInjected.Address(RVA = "0x2AE53D0", Offset = "0x2AE39D0", VA = "0x182AE53D0")]
	private Entity INIDIOGECAO(BLIAAMDKPNO POJMFCODLHG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D1")]
	[Cpp2IlInjected.Address(RVA = "0x2AE55C0", Offset = "0x2AE3BC0", VA = "0x182AE55C0")]
	private Entity INIDIOGECAO(BLIAAMDKPNO POJMFCODLHG, EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D2")]
	[Cpp2IlInjected.Address(RVA = "0x2AE57E0", Offset = "0x2AE3DE0", VA = "0x182AE57E0")]
	private void JGGHGEINBFD(BLIAAMDKPNO POJMFCODLHG, NativeArray<EEKJFDFIEGN> LDNMHAEAEME, NativeArray<Entity> PKDJKKFMCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D3")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5430", Offset = "0x2AE3A30", VA = "0x182AE5430")]
	private void IHHBPOHEKCO(NativeArray<BLIAAMDKPNO> EBCEGDCHNNH, NativeArray<EEKJFDFIEGN> LDNMHAEAEME, NativeArray<Entity> PKDJKKFMCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JMGAPHGFIPO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	[GHIPPEMCIOG]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : DIIPAOKEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x26163F0", Offset = "0x26149F0", VA = "0x1826163F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x2616480", Offset = "0x2614A80", VA = "0x182616480", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x26161E0", Offset = "0x26147E0", VA = "0x1826161E0")]
		private EntityCommandBufferSystem BDPMMNOPFAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2616230", Offset = "0x2614830", VA = "0x182616230", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[ExecuteAlways]
public class OPLBKFHGADJ : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60008DC")]
	[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
	public OPLBKFHGADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(MKBGHPFKLIO), new string[] { })]
internal class MKBGHPFKLIO : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly SceneTag IFPBJJAMCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	[LABJLBKOJHN]
	private GDPCNPLLJEI OJOEDKOPODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	[LABJLBKOJHN]
	private LKEACJPELBE CBIMOLNMMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	[LABJLBKOJHN]
	private GEMKDFICLBK KGLOBJOCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	[LABJLBKOJHN]
	private KDFIBOBNBIO HDHOPILNEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	[LABJLBKOJHN]
	private FNJJFCCLJPH DCNHKJPCPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private EntityQuery GBFCAHDHOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private EntityQuery NJKAJDBIEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private EntityQuery DGDHMBCMKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private Entity PPPFLBIMOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public NativeArray<Entity> GFHPDBCDIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x9DA630", Offset = "0x9D8C30", VA = "0x1809DA630")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x9D9950", Offset = "0x9D7F50", VA = "0x1809D9950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Entity NNEDMKGFFME
	{
		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A861B0", Offset = "0x2A847B0", VA = "0x182A861B0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public SceneTag NLLMEFHEDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A86CE0", Offset = "0x2A852E0", VA = "0x182A86CE0")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Entity JLPKBHGHHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A86CE0", Offset = "0x2A852E0", VA = "0x182A86CE0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A86C70", Offset = "0x2A85270", VA = "0x182A86C70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A86C20", Offset = "0x2A85220", VA = "0x182A86C20")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A86650", Offset = "0x2A84C50", VA = "0x182A86650", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A86400", Offset = "0x2A84A00", VA = "0x182A86400", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A86750", Offset = "0x2A84D50", VA = "0x182A86750")]
	public void JPAHJPJDHJO(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A85C90", Offset = "0x2A84290", VA = "0x182A85C90")]
	public NativeArray<Entity> APLAKBAKLPA(Allocator HINEEPDGLPG = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A86440", Offset = "0x2A84A40", VA = "0x182A86440")]
	public void EHIFJPKININ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A862C0", Offset = "0x2A848C0", VA = "0x182A862C0")]
	public void DMKGOMGOBBD(Entity GHAEGLKDDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A85CC0", Offset = "0x2A842C0", VA = "0x182A85CC0")]
	public Entity CEJGMEDDMBO(string ECMAPGHKHFB = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A862A0", Offset = "0x2A848A0", VA = "0x182A862A0")]
	public void CNGBLBNOMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A86600", Offset = "0x2A84C00", VA = "0x182A86600")]
	public void FOAEFKMGJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	public void IKEMABHKPEJ(Entity GHAEGLKDDJL, string ECMAPGHKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A86EE0", Offset = "0x2A854E0", VA = "0x182A86EE0")]
	public void LJKGMGOGGID(Entity GHAEGLKDDJL, bool GBPGONOMGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A85DE0", Offset = "0x2A843E0", VA = "0x182A85DE0")]
	public void CIDFBOOKEOD(Entity MPAGCMNFGMI, Entity GHAEGLKDDJL, bool BCPLPHDLKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A85FD0", Offset = "0x2A845D0", VA = "0x182A85FD0")]
	public void CIDFBOOKEOD(NativeArray<Entity> NCEOACJJMCN, Entity GHAEGLKDDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A86D30", Offset = "0x2A85330", VA = "0x182A86D30")]
	private void LBEAHJGABIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A86620", Offset = "0x2A84C20", VA = "0x182A86620")]
	private void GGCANDECMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A861B0", Offset = "0x2A847B0", VA = "0x182A861B0")]
	private Entity CNEMABAFIND()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A86B50", Offset = "0x2A85150", VA = "0x182A86B50")]
	private void KDECDBBMNNG(EntityQuery DHOIMGPEGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A86870", Offset = "0x2A84E70", VA = "0x182A86870")]
	private void KDECDBBMNNG(NativeArray<Entity> CAEMHEKKBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A85BE0", Offset = "0x2A841E0", VA = "0x182A85BE0")]
	private void AOLIDCNEIBP(Entity GHAEGLKDDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A87250", Offset = "0x2A85850", VA = "0x182A87250")]
	private void OPGFFFIMBOO(Entity GHAEGLKDDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A86490", Offset = "0x2A84A90", VA = "0x182A86490")]
	private void FEOPAELDDPH(SceneTag ALDEHJKHMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A863C0", Offset = "0x2A849C0", VA = "0x182A863C0")]
	private void DPMEDEADOIJ(SceneTag ALDEHJKHMHK, NativeParallelHashSet<int> JALNJBNJLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A870B0", Offset = "0x2A856B0", VA = "0x182A870B0")]
	private void NDOOENINPDF(SceneTag ALDEHJKHMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A86FF0", Offset = "0x2A855F0", VA = "0x182A86FF0")]
	private void LNABPLIBDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0x1AA18A0", Offset = "0x1A9FEA0", VA = "0x181AA18A0")]
	private void BMEMOICKBFM<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public MKBGHPFKLIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class KALAEMMGINN : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private LKEACJPELBE NNKCFAHPEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private MBKAKKEBAGC OIDCAANMDGE;

	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE94A0", Offset = "0x2AE7AA0", VA = "0x182AE94A0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9510", Offset = "0x2AE7B10", VA = "0x182AE9510", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public KALAEMMGINN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(LDONCAMGPOJ), new string[] { })]
internal sealed class LDONCAMGPOJ : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	[LABJLBKOJHN]
	private JEEOIALHEAK IIGHFBHFIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	[LABJLBKOJHN]
	private CBIHOPCFCDD DGAADDBOCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	private NativeParallelHashMap<EEKJFDFIEGN, Entity> CNDFPIGEBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	internal NativeParallelHashMap<EEKJFDFIEGN, Entity> CMHNNCBLAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xCEA020", Offset = "0xCE8620", VA = "0x180CEA020")]
		get
		{
			return default(NativeParallelHashMap<EEKJFDFIEGN, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	internal uint MIEOIODPANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x2A76940", Offset = "0x2A74F40", VA = "0x182A76940")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x9F6FF0", Offset = "0x9F55F0", VA = "0x1809F6FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0x2A772D0", Offset = "0x2A758D0", VA = "0x182A772D0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0x2A76C10", Offset = "0x2A75210", VA = "0x182A76C10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0x2A77070", Offset = "0x2A75670", VA = "0x182A77070")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000909")]
	[Cpp2IlInjected.Address(RVA = "0x2A76B20", Offset = "0x2A75120", VA = "0x182A76B20")]
	public EEKJFDFIEGN CIMOAOJOFGC(int FJLPCOJGEJP)
	{
		return default(EEKJFDFIEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600090A")]
	[Cpp2IlInjected.Address(RVA = "0x2A77400", Offset = "0x2A75A00", VA = "0x182A77400")]
	public void KKAFEGFFKEG(EEKJFDFIEGN HGGMFNJGHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0x2A76F90", Offset = "0x2A75590", VA = "0x182A76F90")]
	public ENMPPPDAMHN FBGOFHNIPBN(EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x2A76CD0", Offset = "0x2A752D0", VA = "0x182A76CD0")]
	public bool ELLJKDEAPPH(EEKJFDFIEGN HGGMFNJGHIP, out ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x2A76E30", Offset = "0x2A75430", VA = "0x182A76E30")]
	public KIHFNANBKDD FBGOFHNIPBN(NativeArray<EEKJFDFIEGN> HGGMFNJGHIP, Allocator HINEEPDGLPG)
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x2A76A40", Offset = "0x2A75040", VA = "0x182A76A40")]
	public EEKJFDFIEGN CFEAEMLGJDL(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(EEKJFDFIEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x2A76970", Offset = "0x2A74F70", VA = "0x182A76970")]
	public EEKJFDFIEGN CFEAEMLGJDL(Entity MPAGCMNFGMI)
	{
		return default(EEKJFDFIEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000910")]
	[Cpp2IlInjected.Address(RVA = "0x2A770F0", Offset = "0x2A756F0", VA = "0x182A770F0")]
	public void IPGEBFPDOMK(NativeArray<Entity> NCEOACJJMCN, NativeArray<EEKJFDFIEGN> LDNMHAEAEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000911")]
	[Cpp2IlInjected.Address(RVA = "0x2A76C80", Offset = "0x2A75280", VA = "0x182A76C80")]
	private ENMPPPDAMHN EFJOLPLCHHI(Entity MPAGCMNFGMI)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000912")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public LDONCAMGPOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(KDFIBOBNBIO), new string[] { })]
internal sealed class KDFIBOBNBIO : LPOKOJIEHOF, EMBHBGCIFNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	[LABJLBKOJHN]
	private GEMKDFICLBK KGLOBJOCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private Entity MPAGCMNFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private ComponentTypeList CDMNKFEHHOM;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA0C0", Offset = "0x2AE86C0", VA = "0x182AEA0C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000915")]
	[Cpp2IlInjected.Address(RVA = "0xF364F0", Offset = "0xF34AF0", VA = "0x180F364F0")]
	public T MBNHJLNEIKL<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000916")]
	[Cpp2IlInjected.Address(RVA = "0xF36320", Offset = "0xF34920", VA = "0x180F36320")]
	public void FGMAFKALEHD<T>(T MOLEJFDINLH) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000917")]
	[Cpp2IlInjected.Address(RVA = "0xF363F0", Offset = "0xF349F0", VA = "0x180F363F0")]
	public DynamicBuffer<T> LBLGIMICEEM<T>(bool IIIFGLBBIHC = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000918")]
	[Cpp2IlInjected.Address(RVA = "0xF361F0", Offset = "0xF347F0", VA = "0x180F361F0")]
	public void BKGAGDEFMCE<T>(T MOLEJFDINLH) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000919")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9EB0", Offset = "0x2AE84B0", VA = "0x182AE9EB0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9F20", Offset = "0x2AE8520", VA = "0x182AE9F20", Slot = "5")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9F20", Offset = "0x2AE8520", VA = "0x182AE9F20")]
	private void LFKLGODCINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9860", Offset = "0x2AE7E60", VA = "0x182AE9860", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9B10", Offset = "0x2AE8110", VA = "0x182AE9B10")]
	private ComponentTypeList EMDIIGJNPOP()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x600091E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void HOJAGIOKKAI(int FJLPCOJGEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void AGOIKJAOBON(Type KLGGKKGCLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000920")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA110", Offset = "0x2AE8710", VA = "0x182AEA110")]
	private static void LEIFMABBOLB(Type KLGGKKGCLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000921")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public KDFIBOBNBIO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000175")]
[KIGOJLCLFMB]
internal struct NNBFCFKIPAI : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class MDBEFLPEILH : DIIPAOKEIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery NIBMJMJMGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private EntityQuery PNDHBLGBADH;

	[Cpp2IlInjected.Token(Token = "0x6000923")]
	[Cpp2IlInjected.Address(RVA = "0x2A834D0", Offset = "0x2A81AD0", VA = "0x182A834D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000924")]
	[Cpp2IlInjected.Address(RVA = "0x2A835C0", Offset = "0x2A81BC0", VA = "0x182A835C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public MDBEFLPEILH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[CKDDPEJBLMJ]
public class NALNONIINLM : DIIPAOKEIKC, ICBJIAPAJOF.MHCJAJGDHBC
{
	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x2A878E0", Offset = "0x2A85EE0", VA = "0x182A878E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2A87890", Offset = "0x2A85E90", VA = "0x182A87890")]
	private EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public NALNONIINLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public class LCGOAFBKODG : DIIPAOKEIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000929")]
	[Cpp2IlInjected.Address(RVA = "0x2A758F0", Offset = "0x2A73EF0", VA = "0x182A758F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092A")]
	[Cpp2IlInjected.Address(RVA = "0x2A75980", Offset = "0x2A73F80", VA = "0x182A75980", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092B")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public LCGOAFBKODG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[AlwaysUpdateSystem]
public class GONMEDAGBFK : IHADAAMNPBN
{
	[Cpp2IlInjected.Token(Token = "0x600092C")]
	[Cpp2IlInjected.Address(RVA = "0x24BA300", Offset = "0x24B8900", VA = "0x1824BA300", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092D")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	public GONMEDAGBFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[OJJOJOKIEBL(typeof(MBKAKKEBAGC), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal class MBKAKKEBAGC : LPOKOJIEHOF, EMBHBGCIFNL, PMDMEBKMCNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal readonly struct ALKKBFNNGMD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private readonly ADMKFPPIBEF OFPPHNLPCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private readonly MBKAKKEBAGC GEDHMEAEIPA;

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x28ECF70", Offset = "0x28EB570", VA = "0x1828ECF70")]
		public ALKKBFNNGMD(MBKAKKEBAGC GEDHMEAEIPA, ADMKFPPIBEF IKLIIDACDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x28ECF50", Offset = "0x28EB550", VA = "0x1828ECF50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private static readonly IAMDAJKPFJC LFJAJAKAIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	[LABJLBKOJHN]
	private FOKGJFJPKEK FJNPCKPLFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	[LABJLBKOJHN]
	private GHMKMBPEGGE LKGDMEFDKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly KLDKGDMIODL[] PHBAKOEKAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private LACJKHKONMC HDLKDIFGJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private NativeParallelHashMap<int, Entity> HICNCIBDEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	private ADMKFPPIBEF IECNILDANFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public World FKLPOCBLLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2A81460", Offset = "0x2A7FA60", VA = "0x182A81460", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public World DFLOMKCOJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x929320", Offset = "0x927920", VA = "0x180929320", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3F0", Offset = "0x9AD9F0", VA = "0x1809AF3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public LACJKHKONMC JOOEMNOPCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x2A81710", Offset = "0x2A7FD10", VA = "0x182A81710", Slot = "8")]
		get
		{
			return default(LACJKHKONMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public uint IAIKLPLKODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x1AD8150", Offset = "0x1AD6750", VA = "0x181AD8150", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xDCF450", Offset = "0xDCDA50", VA = "0x180DCF450", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool EEOLBBHKDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x1BE7120", Offset = "0x1BE5720", VA = "0x181BE7120")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x164DC70", Offset = "0x164C270", VA = "0x18164DC70", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public NativeParallelHashMap<int, Entity> ENABEMKLAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xEF1F20", Offset = "0xEF0520", VA = "0x180EF1F20")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public GKCMNHOMNPL DFGHCEJINFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x2A810C0", Offset = "0x2A7F6C0", VA = "0x182A810C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public CAODOHKABMK ANAFOPDJOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x2A810C0", Offset = "0x2A7F6C0", VA = "0x182A810C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public ADMKFPPIBEF PHOECLJKALF
	{
		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x92C190", Offset = "0x92A790", VA = "0x18092C190")]
		get
		{
			return default(ADMKFPPIBEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x2A81350", Offset = "0x2A7F950", VA = "0x182A81350")]
	public GKCMNHOMNPL HBFKMBKFBNC(ADMKFPPIBEF JHBJAKHPFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x2A81350", Offset = "0x2A7F950", VA = "0x182A81350")]
	public CAODOHKABMK PNLOBJJPOLF(ADMKFPPIBEF JHBJAKHPFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x2A81390", Offset = "0x2A7F990", VA = "0x182A81390", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093D")]
	[Cpp2IlInjected.Address(RVA = "0x2A814B0", Offset = "0x2A7FAB0", VA = "0x182A814B0", Slot = "5")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x2A81100", Offset = "0x2A7F700", VA = "0x182A81100")]
	private NativeParallelHashMap<int, Entity> HAMMFLPHJBO()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x2A81740", Offset = "0x2A7FD40", VA = "0x182A81740")]
	public void PJCLNKFBAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x2A81070", Offset = "0x2A7F670", VA = "0x182A81070")]
	public void FBJOPIHCMHF(ADMKFPPIBEF JHBJAKHPFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x2A80FA0", Offset = "0x2A7F5A0", VA = "0x182A80FA0")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x2A80E80", Offset = "0x2A7F480", VA = "0x182A80E80", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x2A816F0", Offset = "0x2A7FCF0", VA = "0x182A816F0")]
	public ALKKBFNNGMD LJMPHFCGDJG(ADMKFPPIBEF JHBJAKHPFJI)
	{
		return default(ALKKBFNNGMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0x2A81860", Offset = "0x2A7FE60", VA = "0x182A81860")]
	public MBKAKKEBAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class MIEALDAEMIF : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery HPJKMIDOKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private DFALILEPNOG OJOAPPOPJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private LJIKPIOGIDO LEPADDHJBOO;

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x2A843B0", Offset = "0x2A829B0", VA = "0x182A843B0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x2A84440", Offset = "0x2A82A40", VA = "0x182A84440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x2A844E0", Offset = "0x2A82AE0", VA = "0x182A844E0", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public MIEALDAEMIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[GHIPPEMCIOG]
public class LBDJGCHPMAB : AEKGPLOBAHI
{
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x2A74DE0", Offset = "0x2A733E0", VA = "0x182A74DE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x2A74E90", Offset = "0x2A73490", VA = "0x182A74E90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2A74D90", Offset = "0x2A73390", VA = "0x182A74D90")]
	private EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public LBDJGCHPMAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public class HBGOFPDINDM : AEKGPLOBAHI
{
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x24BC6D0", Offset = "0x24BACD0", VA = "0x1824BC6D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x24BC680", Offset = "0x24BAC80", VA = "0x1824BC680")]
	private EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public HBGOFPDINDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
public struct LINFGJPDCJL<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private GCHandle FCDGNCOICKN;

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x26370F0", Offset = "0x26356F0", VA = "0x1826370F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[CKDDPEJBLMJ]
public class NMGJAKCMBMC : DIIPAOKEIKC, ICBJIAPAJOF.MHCJAJGDHBC
{
	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D310", Offset = "0x2A8B910", VA = "0x182A8D310", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D2C0", Offset = "0x2A8B8C0", VA = "0x182A8D2C0")]
	private EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public NMGJAKCMBMC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIds : DIIPAOKEIKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x261E7D0", Offset = "0x261CDD0", VA = "0x18261E7D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x261E860", Offset = "0x261CE60", VA = "0x18261E860", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x261E5C0", Offset = "0x261CBC0", VA = "0x18261E5C0")]
		private EntityCommandBufferSystem KDONOHLNJDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x261E610", Offset = "0x261CC10", VA = "0x18261E610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PreSerializeSaveNetworkIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[AlwaysUpdateSystem]
public class GMPPAIOOEIE : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0x24B96D0", Offset = "0x24B7CD0", VA = "0x1824B96D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public GMPPAIOOEIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
[GHIPPEMCIOG]
[AIBFCFMKILK(AGPDIMMFKMP.OMRoom)]
public class NHNJOPCGHJC : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private NAKDAPLIPPO BDAGOAAJLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private MKBGHPFKLIO CAEMHEKKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C600", Offset = "0x2A8AC00", VA = "0x182A8C600", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C670", Offset = "0x2A8AC70", VA = "0x182A8C670", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C710", Offset = "0x2A8AD10", VA = "0x182A8C710", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public NHNJOPCGHJC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	internal class SplinePointOrderingUpdateSystem : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct UpdateSplineIndexJob : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			[ReadOnly]
			public NativeArray<global::EJGDELKHAJG> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			[ReadOnly]
			public ComponentDataFromEntity<PCNIEMKNHNM> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			public ComponentDataFromEntity<GDEOBAAEKDF> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0x3C15FC0", Offset = "0x3C145C0", VA = "0x183C15FC0", Slot = "4")]
			public void Execute(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000187")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			[ReadOnly]
			public ComponentDataFromEntity<GDEOBAAEKDF> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0x3C0EE70", Offset = "0x3C0D470", VA = "0x183C0EE70", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[NoAlias]
		[BurstCompile]
		private struct SplinePointOrderingUpdateSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0x3C14AC0", Offset = "0x3C130C0", VA = "0x183C14AC0")]
			private void DKBFAIHFAHI(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0x3C14B50", Offset = "0x3C13150", VA = "0x183C14B50", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[LABJLBKOJHN]
		private KDFIBOBNBIO singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x2620D50", Offset = "0x261F350", VA = "0x182620D50", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x2621380", Offset = "0x261F980", VA = "0x182621380", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x2620DA0", Offset = "0x261F3A0", VA = "0x182620DA0")]
		private void OBMOBAFDGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x2620950", Offset = "0x261EF50", VA = "0x182620950")]
		private void BCPBHHABBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x2620AB0", Offset = "0x261F0B0", VA = "0x182620AB0")]
		private static LBNLJFLJFKA DMOMBPGDPOL(int insertionIndex, ComponentDataFromEntity<GDEOBAAEKDF> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(LBNLJFLJFKA);
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x2620C10", Offset = "0x261F210", VA = "0x182620C10")]
		private JobHandle DNNGICOMKEE(OrderComparer comparer, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x2621130", Offset = "0x261F730", VA = "0x182621130", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	public class UpdateMassOfShapes : DIIPAOKEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x200018A")]
		[BurstCompile]
		[NoAlias]
		private struct UpdateMassOfShapes_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			[ReadOnly]
			public ComponentDataFromEntity<DDHBNLFNGBI> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			[ReadOnly]
			public ComponentDataFromEntity<EOEAFFEAOLE> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			[ReadOnly]
			public ComponentDataFromEntity<MPMDBHHLKDH> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			[ReadOnly]
			public ComponentDataFromEntity<OLFICOFHAAA> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			[ReadOnly]
			public ComponentDataFromEntity<GEELFDNKLBO> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public ComponentDataFromEntity<MNJGBFPFJCD> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public ComponentDataFromEntity<KBPIEDEACLP> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x600097D")]
			[Cpp2IlInjected.Address(RVA = "0x3C15A20", Offset = "0x3C14020", VA = "0x183C15A20")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0x3C15E80", Offset = "0x3C14480", VA = "0x183C15E80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x26288F0", Offset = "0x2626EF0", VA = "0x1826288F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x2628A20", Offset = "0x2627020", VA = "0x182628A20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x26285E0", Offset = "0x2626BE0", VA = "0x1826285E0")]
		private void DJGLNKFHGEH(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x2628400", Offset = "0x2626A00", VA = "0x182628400")]
		private JobHandle DAKFODKCLIE(NativeList<Entity> entities, ComponentDataFromEntity<DDHBNLFNGBI> worldDeformableScalesRO, ComponentDataFromEntity<EOEAFFEAOLE> worldUniformScalesRO, ComponentDataFromEntity<MPMDBHHLKDH> physicsMaterialsRO, ComponentDataFromEntity<OLFICOFHAAA> primitiveShapesRO, ComponentDataFromEntity<GEELFDNKLBO> localUniformScalesRO, ComponentDataFromEntity<MNJGBFPFJCD> massesRW, ComponentDataFromEntity<KBPIEDEACLP> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public UpdateMassOfShapes()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct OCENMLNOFKK : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public class POPPICEGHGA : LCPBKGABAHD
{
	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x2614D80", Offset = "0x2613380", VA = "0x182614D80", Slot = "14")]
	protected override EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x2614DD0", Offset = "0x26133D0", VA = "0x182614DD0")]
	public POPPICEGHGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class JJHGIBLFPLM : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private NDKPGBMKGJL KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private EntityQuery DLFFHENBDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private EntityQuery DJCFFCHMDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private EntityQuery AJJGAGBPNKI;

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0F40", Offset = "0x2ADF540", VA = "0x182AE0F40", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x2AE11C0", Offset = "0x2ADF7C0", VA = "0x182AE11C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1340", Offset = "0x2ADF940", VA = "0x182AE1340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1310", Offset = "0x2ADF910", VA = "0x182AE1310", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0C00", Offset = "0x2ADF200", VA = "0x182AE0C00")]
	private void GBLHKNMEILK(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0A50", Offset = "0x2ADF050", VA = "0x182AE0A50")]
	private void FKKHEFGCCDK(NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0750", Offset = "0x2ADED50", VA = "0x182AE0750")]
	private void FDDMPJLBGFP(NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0590", Offset = "0x2ADEB90", VA = "0x182AE0590")]
	private void EKMKFOIBKCD(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0FB0", Offset = "0x2ADF5B0", VA = "0x182AE0FB0")]
	private void KHFKIOLIFAN(NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0450", Offset = "0x2ADEA50", VA = "0x182AE0450")]
	private void BEFJDJHAJGI(ENMPPPDAMHN HMLJKOHAJKN, int JFFCAOEMPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public JJHGIBLFPLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[FIJBPDAJCNE(typeof(EOMEEBLCJPE))]
[OJJOJOKIEBL(typeof(CJMDCNKCPPO), new string[] { })]
public class BGAAGLKLILD : CJMDCNKCPPO, EECDFKAILMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private static readonly Dictionary<int, int> EAEEKGPNGGK;

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x27C7A00", Offset = "0x27C6000", VA = "0x1827C7A00", Slot = "5")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x27C7960", Offset = "0x27C5F60", VA = "0x1827C7960", Slot = "4")]
	public int GDKCFJKPHMK(int MPGHGDABPMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x27C78E0", Offset = "0x27C5EE0", VA = "0x1827C78E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BGAAGLKLILD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[OJJOJOKIEBL(typeof(HEONMBBDPJM), new string[] { })]
public class GPJPKMPMELG : LPOKOJIEHOF, EMBHBGCIFNL, HEONMBBDPJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class KPACKJOLPBI : IEnumerable<ENMPPPDAMHN>, IEnumerable, IEnumerator<ENMPPPDAMHN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private ENMPPPDAMHN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private ENMPPPDAMHN splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public ENMPPPDAMHN <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public GPJPKMPMELG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private NativeArray<Entity> <children>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		private ENMPPPDAMHN System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0x28EDC60", Offset = "0x28EC260", VA = "0x1828EDC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ENMPPPDAMHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60009A9")]
			[Cpp2IlInjected.Address(RVA = "0x28F8680", Offset = "0x28F6C80", VA = "0x1828F8680", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x97B9F0", Offset = "0x979FF0", VA = "0x18097B9F0")]
		[DebuggerHidden]
		public KPACKJOLPBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x28F84A0", Offset = "0x28F6AA0", VA = "0x1828F84A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x28F8640", Offset = "0x28F6C40", VA = "0x1828F8640", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x28F8590", Offset = "0x28F6B90", VA = "0x1828F8590", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ENMPPPDAMHN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x28F8590", Offset = "0x28F6B90", VA = "0x1828F8590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private FOKGJFJPKEK FJNPCKPLFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private JMGAPHGFIPO LKGDMEFDKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private MCCOHLNACPH NMLCLDDPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private KDFIBOBNBIO GIGEAGEKEOJ;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x24BAF80", Offset = "0x24B9580", VA = "0x1824BAF80")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x24BAD30", Offset = "0x24B9330", VA = "0x1824BAD30", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0x24BAE20", Offset = "0x24B9420", VA = "0x1824BAE20")]
	private void JJMGOHGJCJP(Entity NBDMJMAJLKP, int OLGOBCPPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000997")]
	[Cpp2IlInjected.Address(RVA = "0x24BA760", Offset = "0x24B8D60", VA = "0x1824BA760", Slot = "10")]
	public void FDEIJNOKCAM(ENMPPPDAMHN HMLJKOHAJKN, LCDOAODHHAO FKGPFMNALNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0x24BA840", Offset = "0x24B8E40", VA = "0x1824BA840", Slot = "9")]
	public LCDOAODHHAO HCIFBNEECAP(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(LCDOAODHHAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0x24BA920", Offset = "0x24B8F20", VA = "0x1824BA920", Slot = "11")]
	public ENMPPPDAMHN HODCDGFMEME(ENMPPPDAMHN MLBBKDICKBL, [Optional] float3? POOFJFBIOJJ, [Optional] quaternion? MEHKCJCIOOL, [Optional] float3? CHAPNJAEPMG)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600099A")]
	[Cpp2IlInjected.Address(RVA = "0x24BB130", Offset = "0x24B9730", VA = "0x1824BB130", Slot = "12")]
	public ENMPPPDAMHN LHGGACMOCDK(ENMPPPDAMHN MLBBKDICKBL, int OLGOBCPPPBB, [Optional] float3? POOFJFBIOJJ, [Optional] quaternion? MEHKCJCIOOL, [Optional] float3? CHAPNJAEPMG)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x24BA4A0", Offset = "0x24B8AA0", VA = "0x1824BA4A0")]
	private ENMPPPDAMHN EDMKFFEJGIH(ENMPPPDAMHN MLBBKDICKBL, int OLGOBCPPPBB, [Optional] float3? POOFJFBIOJJ, [Optional] quaternion? MEHKCJCIOOL, [Optional] float3? CHAPNJAEPMG)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x24BAFD0", Offset = "0x24B95D0", VA = "0x1824BAFD0", Slot = "7")]
	public ENMPPPDAMHN LBFGAKDHAMO(ENMPPPDAMHN MLBBKDICKBL, int OLGOBCPPPBB)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600099D")]
	[Cpp2IlInjected.Address(RVA = "0x24BB3E0", Offset = "0x24B99E0", VA = "0x1824BB3E0", Slot = "16")]
	public void PIKOPLLOGAJ(ENMPPPDAMHN MLBBKDICKBL, ENMPPPDAMHN NBDMJMAJLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099E")]
	[Cpp2IlInjected.Address(RVA = "0x24BB1E0", Offset = "0x24B97E0", VA = "0x1824BB1E0", Slot = "13")]
	public void LJFNKENDNMA(ENMPPPDAMHN MLBBKDICKBL, int OLGOBCPPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x24BA9D0", Offset = "0x24B8FD0", VA = "0x1824BA9D0", Slot = "14")]
	public void IPAMOOHHOPB(ENMPPPDAMHN MLBBKDICKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x24BAEA0", Offset = "0x24B94A0", VA = "0x1824BAEA0", Slot = "8")]
	public int KAKBFJAKKOM(ENMPPPDAMHN MLBBKDICKBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x24BA410", Offset = "0x24B8A10", VA = "0x1824BA410", Slot = "6")]
	[IteratorStateMachine(typeof(KPACKJOLPBI))]
	public IEnumerable<ENMPPPDAMHN> CCHBHGGPMAE(ENMPPPDAMHN MLBBKDICKBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x24BA330", Offset = "0x24B8930", VA = "0x1824BA330")]
	private bool BHFEJKJMDCC(ENMPPPDAMHN MLBBKDICKBL, out NativeArray<Entity> LAKDMECIDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public GPJPKMPMELG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[AlwaysUpdateSystem]
public class GNPIAPFNDJB : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x24BA1F0", Offset = "0x24B87F0", VA = "0x1824BA1F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public GNPIAPFNDJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class OMAANHAMENH : KKMNKFHBJPI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	public struct MGKKIPLLGEJ : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	protected override ComponentType MLHCMDMHHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x260E820", Offset = "0x260CE20", VA = "0x18260E820", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	protected override ComponentType PEHDIFADNED
	{
		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x260E7F0", Offset = "0x260CDF0", VA = "0x18260E7F0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	protected override ComponentType JKKAPJCCDKK
	{
		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x260E850", Offset = "0x260CE50", VA = "0x18260E850", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x260E910", Offset = "0x260CF10", VA = "0x18260E910")]
	public OMAANHAMENH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class JPOPMBBIFMG : DIIPAOKEIKC, EMBHBGCIFNL
{
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private IECCFLHBGNJ ODJLFIOBPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private DEECNKLJPLJ OBJFKAPAMCI;

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A844E0", Offset = "0x2A82AE0", VA = "0x182A844E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x2AE87D0", Offset = "0x2AE6DD0", VA = "0x182AE87D0", Slot = "14")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x2AE88E0", Offset = "0x2AE6EE0", VA = "0x182AE88E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8650", Offset = "0x2AE6C50", VA = "0x182AE8650")]
	private static void EFHIIFEMGCD(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, Entity HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE85B0", Offset = "0x2AE6BB0", VA = "0x182AE85B0")]
	private static bool AMJHHOCDEFA(EntityManager PHHGGAMLDGB, Entity MPAGCMNFGMI, out Transform DMECJMCKFAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public JPOPMBBIFMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public struct MINFALADENH<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private ANGEJGLOKCL<T> MPNDOHBKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private EntityCommandBuffer EJOBGFBIEJO;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public ANGEJGLOKCL<T> DIMHHIMGCKK
	{
		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D433E0", Offset = "0x1D419E0", VA = "0x181D433E0")]
		get
		{
			return default(ANGEJGLOKCL<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x22BC150", Offset = "0x22BA750", VA = "0x1822BC150")]
	public MINFALADENH(ANGEJGLOKCL<T> MPNDOHBKHJO, EntityCommandBuffer EJOBGFBIEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B55480", Offset = "0x2B53A80", VA = "0x182B55480")]
	public void CNJDOFJHPHE(KAJIKMFGFBN<T> JCMHPKBBMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B556B0", Offset = "0x2B53CB0", VA = "0x182B556B0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009BE")]
	[Cpp2IlInjected.Address(RVA = "0x22BC130", Offset = "0x22BA730", VA = "0x1822BC130")]
	public static ANGEJGLOKCL<T> LBBGOAOJJNO(MINFALADENH<T> EMGLKKBADKE)
	{
		return default(ANGEJGLOKCL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class NBNGAHFIHPP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public FCLHKJAHMCN CBIMOLNMMAP;

	[Cpp2IlInjected.Token(Token = "0x60009BF")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public NBNGAHFIHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C0")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public NBNGAHFIHPP(FCLHKJAHMCN CBIMOLNMMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A879F0", Offset = "0x2A85FF0", VA = "0x182A879F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	[CKDDPEJBLMJ]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : MOMBEIOEHPD
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public LMPIAGDKNOK<HNKBLKLKNKK> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public GFMIPAJHMDN<FNMHBKFNLLP> v1;

			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0x3C10920", Offset = "0x3C0EF20", VA = "0x183C10920")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0x3C10B80", Offset = "0x3C0F180", VA = "0x183C10B80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		protected override IAMDAJKPFJC Log
		{
			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x261A0A0", Offset = "0x26186A0", VA = "0x18261A0A0", Slot = "14")]
			get
			{
				return default(IAMDAJKPFJC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x261A100", Offset = "0x2618700", VA = "0x18261A100", Slot = "15")]
		public override IEnumerable<ICBJIAPAJOF.AOOJLFMPEFJ> OLJIPNADBOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2619E00", Offset = "0x2618400", VA = "0x182619E00", Slot = "16")]
		protected override void CFJGNGELHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2619F70", Offset = "0x2618570", VA = "0x182619F70")]
		private JobHandle MHGBMLMLCHP(LMPIAGDKNOK<HNKBLKLKNKK> v0, GFMIPAJHMDN<FNMHBKFNLLP> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2614DD0", Offset = "0x26133D0", VA = "0x182614DD0")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[AlwaysUpdateSystem]
internal class ENPBLBDFAFF : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CC")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public ENPBLBDFAFF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentData : AEKGPLOBAHI, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x200019B")]
		private struct DebugPostLoadValidateParentData_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public DebugPostLoadValidateParentData __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			[ReadOnly]
			public ComponentTypeHandle<BCIOGPLFNGO> __parentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x28F1450", Offset = "0x28EFA50", VA = "0x1828F1450")]
			private void DKBFAIHFAHI(Entity entity, in BCIOGPLFNGO parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x28F16B0", Offset = "0x28EFCB0", VA = "0x1828F16B0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private JBBANOPACMB objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private EntityQuery DebugPostLoadValidateParentData_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private ComponentTypeHandle<BCIOGPLFNGO> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x249D8D0", Offset = "0x249BED0", VA = "0x18249D8D0", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x249D7F0", Offset = "0x249BDF0", VA = "0x18249D7F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x249D7F0", Offset = "0x249BDF0", VA = "0x18249D7F0")]
		private void GDBLCBKELIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x249D930", Offset = "0x249BF30", VA = "0x18249D930", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public DebugPostLoadValidateParentData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x249D5A0", Offset = "0x249BBA0", VA = "0x18249D5A0")]
		[CompilerGenerated]
		private void BFLPOFLKFEB(Entity entity, in BCIOGPLFNGO parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
internal class BLNCBNIELIO : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private object LCABJFDKCCO;

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x27C91A0", Offset = "0x27C77A0", VA = "0x1827C91A0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x27C9220", Offset = "0x27C7820", VA = "0x1827C9220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x27C92C0", Offset = "0x27C78C0", VA = "0x1827C92C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public BLNCBNIELIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[BurstCompatible]
internal readonly struct ELNLFLIIFAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private readonly AHALKBKLIJE KJHKBCEOCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private readonly DHJHEPJCIBI NLCFPEDLIMJ;

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xA54600", Offset = "0xA52C00", VA = "0x180A54600")]
	public ELNLFLIIFAI(AHALKBKLIJE KJHKBCEOCEI, DHJHEPJCIBI NLCFPEDLIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x24A13C0", Offset = "0x249F9C0", VA = "0x1824A13C0")]
	public bool MLGOJBGIIBN(ELNLFLIIFAI HDBBNLFBJKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x24A13C0", Offset = "0x249F9C0", VA = "0x1824A13C0")]
	public bool HEKIFPACEDG(ELNLFLIIFAI BIKOOLOFJJA)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	public class CalculateContainerCollisionIslandGraphChangesSystem : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x200019F")]
		[BurstCompile]
		private struct FindChangedIslandsJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			[ReadOnly]
			public EntityQueryInJob deletedConnectablesQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			[ReadOnly]
			public EntityQueryInJob changedIslandQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			[ReadOnly]
			public EntityQueryInJob hierarchyChangeQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			[ReadOnly]
			public EntityQueryInJob newRootsQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			[ReadOnly]
			public ChunkFilterAnyOf2ComponentsChanged islandSplitChangeFilterRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			[ReadOnly]
			public ComponentTypeHandle<EMEJBGNBNKI> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			[ReadOnly]
			public ComponentDataFromEntity<OPODNNPPPIB> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			[ReadOnly]
			public ComponentDataFromEntity<AHALKBKLIJE> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			[ReadOnly]
			public ComponentDataFromEntity<DHJHEPJCIBI> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			[ReadOnly]
			public ComponentDataFromEntity<FABBAFGEKLI> containerCollisionIslandRootTagRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			[ReadOnly]
			public ComponentDataFromEntity<BCIOGPLFNGO> parentRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			[ReadOnly]
			public BufferFromEntity<IHMGEAEOPIO> childrenRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			[WriteOnly]
			public NativeList<Entity> changedIslandComponentsBufferWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			[WriteOnly]
			public NativeList<MAMGMBCFDON> changedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			[WriteOnly]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			[WriteOnly]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			public ComponentDataFromEntity<MGKCNAGGBBM> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x60009E4")]
			[Cpp2IlInjected.Address(RVA = "0x28F2AC0", Offset = "0x28F10C0", VA = "0x1828F2AC0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0x28F3320", Offset = "0x28F1920", VA = "0x1828F3320")]
			private void LNIHLGHFJKP(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009E6")]
			[Cpp2IlInjected.Address(RVA = "0x28F3130", Offset = "0x28F1730", VA = "0x1828F3130")]
			private Entity IDCKEPFBCDC(Entity curEntity, ELNLFLIIFAI classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60009E7")]
			[Cpp2IlInjected.Address(RVA = "0x28F29F0", Offset = "0x28F0FF0", VA = "0x1828F29F0")]
			private bool BJCJLNEIGFM(Entity curEntity, ELNLFLIIFAI classifier, out Entity parentEntity, out ELNLFLIIFAI parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009E8")]
			[Cpp2IlInjected.Address(RVA = "0x28F3580", Offset = "0x28F1B80", VA = "0x1828F3580")]
			private void NILCMLILAOI(Entity islandRoot, ELNLFLIIFAI classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0x28F3650", Offset = "0x28F1C50", VA = "0x1828F3650")]
			private void PNDIOLONBOC(Entity islandRoot, Entity entity, ELNLFLIIFAI classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0x28F3240", Offset = "0x28F1840", VA = "0x1828F3240")]
			private void KGGIGOBDNHH(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EB")]
			[Cpp2IlInjected.Address(RVA = "0x28F31B0", Offset = "0x28F17B0", VA = "0x1828F31B0")]
			private bool JOMHLOIEOED(Entity entity, out ELNLFLIIFAI classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x28F34E0", Offset = "0x28F1AE0", VA = "0x1828F34E0")]
			private ELNLFLIIFAI LONIOIEKPDJ(Entity entity)
			{
				return default(ELNLFLIIFAI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		[NoAlias]
		[BurstCompile]
		private struct CalculateContainerCollisionIslandGraphChangesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			[ReadOnly]
			public EntityTypeHandle entityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x28EFE20", Offset = "0x28EE420", VA = "0x1828EFE20")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x28EFF10", Offset = "0x28EE510", VA = "0x1828EFF10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[LABJLBKOJHN]
		private BPFOPFGDLFP collisionIslandService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private EntityQuery changedIslandStructureQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery hierarchyChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery newRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery deletedConnectablesQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private EntityQuery deletedRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private EntityQuery islandRootDataQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private EntityQuery islandRootTagQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private IBLIFDHPKCF ecbs;

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x27D5B40", Offset = "0x27D4140", VA = "0x1827D5B40", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0x27D5E50", Offset = "0x27D4450", VA = "0x1827D5E50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x27D6260", Offset = "0x27D4860", VA = "0x1827D6260", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x27D53E0", Offset = "0x27D39E0", VA = "0x1827D53E0")]
		private JobHandle HFIHOEHMKFJ(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x27D5B90", Offset = "0x27D4190", VA = "0x1827D5B90")]
		private JobHandle NLMGBBJCFIJ(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x27D52E0", Offset = "0x27D38E0", VA = "0x1827D52E0")]
		private JobHandle FEELNBIKNNG(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[GHIPPEMCIOG]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class BMNLIBIHNIJ : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> ILEGIDMDOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DPOMPCGABEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OHBHOPHBENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private BDMBICNIMIJ FMFGPJKCPPN;

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x27CA9C0", Offset = "0x27C8FC0", VA = "0x1827CA9C0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x27CAE60", Offset = "0x27C9460", VA = "0x1827CAE60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x27CAD50", Offset = "0x27C9350", VA = "0x1827CAD50")]
	private void OKJCDKMDILA(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> CKIKFMIOAHP, EntityQueryDesc GGEEHOKGEHO, bool FMPHIOBBCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x27CAC10", Offset = "0x27C9210", VA = "0x1827CAC10")]
	private void OKJCDKMDILA(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> CKIKFMIOAHP, EntityQueryDesc GGEEHOKGEHO, bool FMPHIOBBCLL, bool KEMGHPMICGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x27CB0C0", Offset = "0x27C96C0", VA = "0x1827CB0C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x27CA810", Offset = "0x27C8E10", VA = "0x1827CA810")]
	private void HBNCPLGMEPG(EntityQuery OGAAEGIJKLI, bool OBKEIPBOOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x27CB3E0", Offset = "0x27C99E0", VA = "0x1827CB3E0")]
	private void PMJOGHOLPDN(EntityQuery OGAAEGIJKLI, bool GBFFHMOOEPO, bool OBKEIPBOOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x27CA5F0", Offset = "0x27C8BF0", VA = "0x1827CA5F0")]
	private void GOEIKAFEOKB(NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x27CA480", Offset = "0x27C8A80", VA = "0x1827CA480")]
	private void FOJDNBIGKFC(NativeList<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x27CA140", Offset = "0x27C8740", VA = "0x1827CA140")]
	private void BDMHLOAJGLC(NativeArray<Entity> NCEOACJJMCN, bool GBFFHMOOEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x27CA260", Offset = "0x27C8860", VA = "0x1827CA260")]
	private NativeList<Entity> EKLAHLOLCEF(NativeArray<Entity> NCEOACJJMCN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x27CB590", Offset = "0x27C9B90", VA = "0x1827CB590")]
	private NativeList<Entity> PNEPNAOLBDI(NativeArray<Entity> NCEOACJJMCN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x27CAA10", Offset = "0x27C9010", VA = "0x1827CAA10")]
	private NativeList<Entity> JKGDNEMJIOF(NativeArray<Entity> NCEOACJJMCN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x27CAA50", Offset = "0x27C9050", VA = "0x1827CAA50")]
	private NativeList<Entity> MHDCPFOHCPN(NativeArray<Entity> NCEOACJJMCN, bool ECCKBHCCNKL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x27CB660", Offset = "0x27C9C60", VA = "0x1827CB660")]
	public BMNLIBIHNIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class EBGINPFLJGF : PMGDLHEJJAE
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	protected override DEKJDDCLMEB BJHKELLEKME
	{
		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x249E460", Offset = "0x249CA60", VA = "0x18249E460", Slot = "15")]
		get
		{
			return default(DEKJDDCLMEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x249E4E0", Offset = "0x249CAE0", VA = "0x18249E4E0")]
	public EBGINPFLJGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[UpdateBefore(typeof(HJNBLAAHKCL))]
public class DPHLOOIDNOE : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x27D8E30", Offset = "0x27D7430", VA = "0x1827D8E30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x27D8ED0", Offset = "0x27D74D0", VA = "0x1827D8ED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public DPHLOOIDNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class INHKKIJFGHI : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[BurstCompile]
	private struct OABPKNEGDIM : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[ReadOnly]
		public ComponentDataFromEntity<OGEEBLLKOPC> HIMCLFEDNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[ReadOnly]
		public NativeArray<Entity> NCEOACJJMCN;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x28FAF00", Offset = "0x28F9500", VA = "0x1828FAF00", Slot = "4")]
		public void Execute(int OLGOBCPPPBB, TransformAccess DMECJMCKFAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[BurstCompile]
	private struct DHEJFHMODFH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		[ReadOnly]
		public ComponentDataFromEntity<GEELFDNKLBO> BBOGFKCGHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		[ReadOnly]
		public NativeArray<Entity> NCEOACJJMCN;

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x28F0360", Offset = "0x28EE960", VA = "0x1828F0360", Slot = "4")]
		public void Execute(int OLGOBCPPPBB, TransformAccess DMECJMCKFAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[BurstCompile]
	private struct FOAGELNLJHC : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		[ReadOnly]
		public ComponentDataFromEntity<GEELFDNKLBO> BBOGFKCGHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		[ReadOnly]
		public ComponentDataFromEntity<DDHBNLFNGBI> KGMJINMEOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		[ReadOnly]
		public NativeArray<Entity> NCEOACJJMCN;

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x28F28F0", Offset = "0x28F0EF0", VA = "0x1828F28F0", Slot = "4")]
		public void Execute(int OLGOBCPPPBB, TransformAccess DMECJMCKFAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private static readonly IAMDAJKPFJC KOALOEAJFHD;

	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private static readonly IAMDAJKPFJC AHMCGMPPPGB;

	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private static readonly IAMDAJKPFJC LMOAOANELPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private BAOLGEAKCOK FBAFNMOHHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	private EntityQuery BFGEKBJHOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private EntityQuery OLDMFJHLMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private EntityQuery AGLIBJNDGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private TransformAccessArray KMFLLNLAMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private TransformAccessArray BGLMMFDDHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private TransformAccessArray KIOJKCGDAEI;

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9720", Offset = "0x2AD7D20", VA = "0x182AD9720", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9770", Offset = "0x2AD7D70", VA = "0x182AD9770", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9960", Offset = "0x2AD7F60", VA = "0x182AD9960", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x2AD99F0", Offset = "0x2AD7FF0", VA = "0x182AD99F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9A20", Offset = "0x2AD8020", VA = "0x182AD9A20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD9580", Offset = "0x2AD7B80", VA = "0x182AD9580")]
	private NativeArray<Entity> COOKDHIICOB(NativeArray<ACIGAKLLBFH> OAKNKJJEPHP, NativeList<Entity> OLBKEPEGOFH, TransformAccessArray EMKIGCIEKJE, TransformAccessArray KBJKNDOAHAA)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public INHKKIJFGHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class HEDAFFHAHKP : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x24BCE90", Offset = "0x24BB490", VA = "0x1824BCE90", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public HEDAFFHAHKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(DIHPJNIDFNC), new string[] { })]
internal sealed class DIHPJNIDFNC : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private static readonly IAMDAJKPFJC JDCJANOOACN;

	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private static readonly IAMDAJKPFJC HHPKDFEPGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private KLIIOIBMNEI<OIPDKILGLCN, Entity> KFBHDCFFHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private DEILPLKIBNJ<GGMHHKHMCFM> GHOBJLMDEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private DEILPLKIBNJ<NJBAHIJEALE> ABFEMFMLCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private DEILPLKIBNJ<EMOCDIHJDEH> OJAAEEEDEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private DEILPLKIBNJ<LHIFOMBDGCI> LOKLDCFNLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private DEILPLKIBNJ<CDECNFIGIFJ> NNKCFAHPEMD;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public DMBMMLONJCJ<Entity> BKMCAPGDANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public NNNHDPACMOP MLMACIGBONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public NNNHDPACMOP JFFDBACPBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public NNNHDPACMOP BHACDHDNPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public NNNHDPACMOP HKBBDHIAKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public NNNHDPACMOP BIAPCKGBLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x27D8310", Offset = "0x27D6910", VA = "0x1827D8310")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x27D80E0", Offset = "0x27D66E0", VA = "0x1827D80E0", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x27D7FF0", Offset = "0x27D65F0", VA = "0x1827D7FF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x2441BA0", Offset = "0x24401A0", VA = "0x182441BA0")]
	private void DOIFCEJGCCI<T>(ref DEILPLKIBNJ<T> JFMMDEMIFBN, EntityCommandBufferSystem NKHEOBELIKH, IAMDAJKPFJC BILPDCGHAAG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x2441C50", Offset = "0x2440250", VA = "0x182441C50")]
	private void DOIFCEJGCCI<TC, TV>(ref KLIIOIBMNEI<TC, TV> JFMMDEMIFBN) where TC : struct, FNCDDBGLKGE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public DIHPJNIDFNC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public struct NJBAHIJEALE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public struct GGMHHKHMCFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct EMOCDIHJDEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public struct LHIFOMBDGCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public struct CDECNFIGIFJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
[ExecuteAlways]
public class IIHPAGFAKGC : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
	public IIHPAGFAKGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
internal readonly struct GKPKCHDHCAI
{
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	[CompilerGenerated]
	private sealed class NGLDGNJOLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public DIIPAOKEIKC system;

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NGLDGNJOLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x28FAD80", Offset = "0x28F9380", VA = "0x1828FAD80")]
		internal (EntityQuery, ComponentType) OCCJNDEMBPJ((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400059A")]
	private static readonly ProfilerMarker OGGGENHMLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	private readonly DIIPAOKEIKC CPDLEGJAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] MJDIAFFAAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	private readonly EntityQuery MOICKAIDKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	private readonly EntityQuery JABHBPOKNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	private readonly ComponentTypes NGOBONCJKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40005A0")]
	private readonly ComponentTypes LLOMOFHOOFG;

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x24B80C0", Offset = "0x24B66C0", VA = "0x1824B80C0")]
	public GKPKCHDHCAI(DIIPAOKEIKC CPDLEGJAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x24B7E00", Offset = "0x24B6400", VA = "0x1824B7E00")]
	public void GFCEDFCLACE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class CFJDIGOKHME : LCPBKGABAHD
{
	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x27D0C50", Offset = "0x27CF250", VA = "0x1827D0C50", Slot = "14")]
	protected override EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x2614DD0", Offset = "0x26133D0", VA = "0x182614DD0")]
	public CFJDIGOKHME()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[GHIPPEMCIOG]
	[CompilerGenerated]
	public class DebugPostDeserializeRemoveOrphanedSplinePoints : AEKGPLOBAHI
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		[BurstCompile]
		[NoAlias]
		private struct DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			[ReadOnly]
			public ComponentDataFromEntity<DKMEAPNDDIB> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			[ReadOnly]
			public ComponentTypeHandle<PCNIEMKNHNM> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x28F10F0", Offset = "0x28EF6F0", VA = "0x1828F10F0")]
			private void DKBFAIHFAHI(Entity entity, [NoAlias] in PCNIEMKNHNM point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A32")]
			[Cpp2IlInjected.Address(RVA = "0x28F1160", Offset = "0x28EF760", VA = "0x1828F1160", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private EntityQuery DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private ComponentTypeHandle<PCNIEMKNHNM> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x27DAEC0", Offset = "0x27D94C0", VA = "0x1827DAEC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x27DAAE0", Offset = "0x27D90E0", VA = "0x1827DAAE0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void BGCBAGLLMHB(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x27DAA90", Offset = "0x27D9090", VA = "0x1827DAA90")]
		private EntityCommandBufferSystem BDPMMNOPFAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x27DAB80", Offset = "0x27D9180", VA = "0x1827DAB80")]
		private JobHandle OHJFJCHIOKP(EntityCommandBuffer ecb, ComponentDataFromEntity<DKMEAPNDDIB> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x27DACC0", Offset = "0x27D92C0", VA = "0x1827DACC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public DebugPostDeserializeRemoveOrphanedSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public struct KAJIKMFGFBN<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	[ReadOnly]
	public EntityQueryInJob OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	[ReadOnly]
	public EntityTypeHandle HBBNCJLDNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	[ReadOnly]
	public ComponentTypeHandle<T> MFCIFPPOHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	[WriteOnly]
	public EntityCommandBuffer EJOBGFBIEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	public AllocatorManager.AllocatorHandle HINEEPDGLPG;

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x253DDE0", Offset = "0x253C3E0", VA = "0x18253DDE0")]
	public ANGEJGLOKCL<T> BBANEIMNFKI()
	{
		return default(ANGEJGLOKCL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public static class DPLCLIGOJLN
{
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[BurstCompile]
	private struct EFKEHNBBLPC : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		[ReadOnly]
		public NativeParallelHashSet<int> NOPNDKHNMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> HEAFGMCPOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public NativeList<EntityArchetype> LKIGJKOLJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public NativeList<JDOBAEGPJED> CKIMAEONNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public NativeList<JDOBAEGPJED> DOGKHNAFKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public NativeList<ComponentType> AIPLHEGOKDL;

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x28F1E50", Offset = "0x28F0450", VA = "0x1828F1E50", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x28F1DC0", Offset = "0x28F03C0", VA = "0x1828F1DC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x27D9310", Offset = "0x27D7910", VA = "0x1827D9310")]
	public static NativeParallelHashSet<int> FMEGKCOCPCK(Allocator HINEEPDGLPG)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x27DA3A0", Offset = "0x27D89A0", VA = "0x1827DA3A0")]
	public static NativeParallelHashSet<int> PIKBAAMAENK(Allocator HINEEPDGLPG)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x27D9020", Offset = "0x27D7620", VA = "0x1827D9020")]
	private static void EEPKIGCDFEC(NativeParallelHashSet<int> GOGEJEOAIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x27DA2B0", Offset = "0x27D88B0", VA = "0x1827DA2B0")]
	private static bool OMBBIEOOEGM(Type KLGGKKGCLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x27DA120", Offset = "0x27D8720", VA = "0x1827DA120")]
	private static void NPNCNOLCKJG(NativeParallelHashSet<int> GOGEJEOAIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x27D9F90", Offset = "0x27D8590", VA = "0x1827D9F90")]
	private static void LHKLJAJGPIM(NativeParallelHashSet<int> GOGEJEOAIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x27D93F0", Offset = "0x27D79F0", VA = "0x1827D93F0")]
	private static void IGLHNGCJJNC(NativeParallelHashSet<int> GOGEJEOAIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x27D9580", Offset = "0x27D7B80", VA = "0x1827D9580")]
	public static void IMIEHCLCKCC(EntityManager PHHGGAMLDGB, EntityQuery OGAAEGIJKLI, NativeParallelHashSet<int> EHDIPPAHMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x27D9E10", Offset = "0x27D8410", VA = "0x1827D9E10")]
	public static void KHDLAEFDONA(EntityManager PHHGGAMLDGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public class EKBBHINHNEL : ParentSystemBase<BCIOGPLFNGO, MJMBIIBNCJB, IHMGEAEOPIO>
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x24A1250", Offset = "0x249F850", VA = "0x1824A1250", Slot = "14")]
	protected override EntityQueryDesc NHIGCDHIONJ(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x9491F0", Offset = "0x9477F0", VA = "0x1809491F0", Slot = "15")]
	protected override EntityQueryDesc FKEMAFFOLPO(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x24A1210", Offset = "0x249F810", VA = "0x1824A1210", Slot = "16")]
	protected override EntityQueryDesc LJLABPDKNOE(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x24A11D0", Offset = "0x249F7D0", VA = "0x1824A11D0", Slot = "17")]
	protected override EntityQueryDesc KNGCCHCHIKN(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x24A1290", Offset = "0x249F890", VA = "0x1824A1290")]
	public EKBBHINHNEL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : DIIPAOKEIKC where TParentData : struct, IComponentData, IINMBNDBECP where TPreviousParentData : struct, IComponentData, IINMBNDBECP where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, IINMBNDBECP
	{
		[Cpp2IlInjected.Token(Token = "0x20001BB")]
		[BurstCompile]
		internal struct HGDPFNHFPKA : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter GHIJAKGIEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter MDNEHFNDMMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			public NativeParallelHashMap<Entity, int>.ParallelWriter BMNJKHPPNJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public ComponentTypeHandle<TPreviousParentData> APLBFNDINDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			[ReadOnly]
			public ComponentTypeHandle<TParentData> LGNPOABMCEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			[ReadOnly]
			public EntityTypeHandle FLELIFFFPPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public uint IAIKLPLKODM;

			[Cpp2IlInjected.Token(Token = "0x6000A52")]
			[Cpp2IlInjected.Address(RVA = "0x218A8A0", Offset = "0x2188EA0", VA = "0x18218A8A0", Slot = "4")]
			public void Execute(ArchetypeChunk FCONCDBMPAA, int GLFHEEDGKCK, int JAJGKGJOHJN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BC")]
		[BurstCompile]
		internal struct GLAFKPMKNOP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> BMNJKHPPNJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> CFPOLONNPBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			public NativeList<Entity> CHFLKHKJBHC;

			[Cpp2IlInjected.Token(Token = "0x6000A53")]
			[Cpp2IlInjected.Address(RVA = "0x4013090", Offset = "0x4011690", VA = "0x184013090", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		[BurstCompile]
		internal struct HLKMFGAENGH : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> GHIJAKGIEAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> MDNEHFNDMMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> BMNJKHPPNJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public BufferFromEntity<TChildrenData> CFPOLONNPBH;

			[Cpp2IlInjected.Token(Token = "0x6000A54")]
			[Cpp2IlInjected.Address(RVA = "0x2F08A10", Offset = "0x2F07010", VA = "0x182F08A10")]
			private int KDOPGLMHDCH(DynamicBuffer<TChildrenData> LAKDMECIDBH, Entity MPAGCMNFGMI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0x2F08590", Offset = "0x2F06B90", VA = "0x182F08590")]
			private void GHBCEDJOFBH(Entity HDBBNLFBJKG, DynamicBuffer<TChildrenData> LAKDMECIDBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A56")]
			[Cpp2IlInjected.Address(RVA = "0x2F08820", Offset = "0x2F06E20", VA = "0x182F08820")]
			private void IEAABBFOADP(Entity HDBBNLFBJKG, DynamicBuffer<TChildrenData> LAKDMECIDBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A57")]
			[Cpp2IlInjected.Address(RVA = "0x2F08150", Offset = "0x2F06750", VA = "0x182F08150", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		[BurstCompile]
		private struct FNBPEPNHJGO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			[ReadOnly]
			public NativeArray<Entity> OAFNOLJKOEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			public NativeList<Entity> NJANFDAOLBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CF")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> CFPOLONNPBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D0")]
			[ReadOnly]
			public ComponentDataFromEntity<TParentData> LNIFLIEFEFH;

			[Cpp2IlInjected.Token(Token = "0x6000A58")]
			[Cpp2IlInjected.Address(RVA = "0x31C8740", Offset = "0x31C6D40", VA = "0x1831C8740", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		protected EntityQuery NFLAJGBBAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		protected EntityQuery PLBCADIDJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		protected EntityQuery DFNNAPEMOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		protected EntityQuery LDPODPILFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		protected ProfilerMarker IMGCCKLPHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		protected ProfilerMarker HMKNAANOEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		protected ProfilerMarker IOHDDHKFNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		protected ProfilerMarker PNPDFPDMHLN;

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x224C9E0", Offset = "0x224AFE0", VA = "0x18224C9E0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x224AD30", Offset = "0x2249330", VA = "0x18224AD30")]
		private int KDOPGLMHDCH(DynamicBuffer<TChildrenData> LAKDMECIDBH, Entity MPAGCMNFGMI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x224C060", Offset = "0x224A660", VA = "0x18224C060")]
		private void OCBGACJIAHO(Entity GHODILCDGDL, Entity IIIOPKIOMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x9491F0", Offset = "0x9477F0", VA = "0x1809491F0", Slot = "14")]
		protected virtual EntityQueryDesc NHIGCDHIONJ(EntityQueryDesc OGAAEGIJKLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x9491F0", Offset = "0x9477F0", VA = "0x1809491F0", Slot = "15")]
		protected virtual EntityQueryDesc FKEMAFFOLPO(EntityQueryDesc OGAAEGIJKLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x9491F0", Offset = "0x9477F0", VA = "0x1809491F0", Slot = "16")]
		protected virtual EntityQueryDesc LJLABPDKNOE(EntityQueryDesc OGAAEGIJKLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc KNGCCHCHIKN(EntityQueryDesc OGAAEGIJKLI);

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x224C4A0", Offset = "0x224AAA0", VA = "0x18224C4A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x224BA70", Offset = "0x224A070", VA = "0x18224BA70")]
		private void NLLDMLCADGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x224BD20", Offset = "0x224A320", VA = "0x18224BD20")]
		private void NMGGJIBHHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x224AE20", Offset = "0x2249420", VA = "0x18224AE20")]
		private JobHandle KHDAJMGLHBI(JobHandle AIKFNHNINEI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x224A880", Offset = "0x2248E80", VA = "0x18224A880")]
		private void CKGGPJGGPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x224C7B0", Offset = "0x224ADB0", VA = "0x18224C7B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x224C780", Offset = "0x224AD80", VA = "0x18224C780", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public class FCBEIIOKIKJ : PLAJLNBHEFP
{
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	protected override FNILJLPBJPB IPPNJJNMCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "15")]
		get
		{
			return default(FNILJLPBJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x24A44C0", Offset = "0x24A2AC0", VA = "0x1824A44C0", Slot = "16")]
	protected override void CNBNEFEHICO(FNILJLPBJPB MPNDOHBKHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x24A4470", Offset = "0x24A2A70", VA = "0x1824A4470")]
	private EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x24A4820", Offset = "0x24A2E20", VA = "0x1824A4820")]
	public FCBEIIOKIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
[GHIPPEMCIOG]
public class OIAMPCOHOFM : AEKGPLOBAHI
{
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	private struct CGANDLPHPJP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		[ReadOnly]
		public NativeParallelHashSet<int> FLFKFCHBGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		[ReadOnly]
		public EntityTypeHandle APFOCJEDBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> NBPIMFMNNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public NativeList<Entity>.ParallelWriter KEMAKCMEEDB;

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E4A0", Offset = "0x3C0CAA0", VA = "0x183C0E4A0", Slot = "4")]
		public void Execute(ArchetypeChunk FCONCDBMPAA, int GLFHEEDGKCK, int JAJGKGJOHJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x260CFB0", Offset = "0x260B5B0", VA = "0x18260CFB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x260D040", Offset = "0x260B640", VA = "0x18260D040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x260CF60", Offset = "0x260B560", VA = "0x18260CF60")]
	private EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public OIAMPCOHOFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
public struct BMMBGICDGOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public Entity MPAGCMNFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public PLHLBCMJFLC LKPPDEOAPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	public PLHLBCMJFLC ENDLICBNMBH;
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
[OJJOJOKIEBL(typeof(BAOLGEAKCOK), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal sealed class BAOLGEAKCOK : EECDFKAILMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private FMGNDFNEJOF EDAJBFCDDFJ;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public FMGNDFNEJOF ENOMOFDAPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x278F7B0", Offset = "0x278DDB0", VA = "0x18278F7B0")]
		get
		{
			return default(FMGNDFNEJOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x27C3FD0", Offset = "0x27C25D0", VA = "0x1827C3FD0", Slot = "4")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x27C3FC0", Offset = "0x27C25C0", VA = "0x1827C3FC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BAOLGEAKCOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal sealed class KLGCBBDLAJG : ParentSystemBase<BCIOGPLFNGO, MJMBIIBNCJB, IHMGEAEOPIO>
{
	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x9491F0", Offset = "0x9477F0", VA = "0x1809491F0", Slot = "14")]
	protected override EntityQueryDesc NHIGCDHIONJ(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x9491F0", Offset = "0x9477F0", VA = "0x1809491F0", Slot = "15")]
	protected override EntityQueryDesc FKEMAFFOLPO(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x9491F0", Offset = "0x9477F0", VA = "0x1809491F0", Slot = "16")]
	protected override EntityQueryDesc LJLABPDKNOE(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x2A72860", Offset = "0x2A70E60", VA = "0x182A72860", Slot = "17")]
	protected override EntityQueryDesc KNGCCHCHIKN(EntityQueryDesc OGAAEGIJKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2A728A0", Offset = "0x2A70EA0", VA = "0x182A728A0")]
	public KLGCBBDLAJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
[OJJOJOKIEBL(typeof(AKLHOJFEEEF), new string[] { })]
internal class AFAPGEOBBNO : AKLHOJFEEEF, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	[LABJLBKOJHN]
	private PPKCEEEDIDM MHIIEIDIAJL;

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x27BFE60", Offset = "0x27BE460", VA = "0x1827BFE60", Slot = "8")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x27BFC10", Offset = "0x27BE210", VA = "0x1827BFC10", Slot = "4")]
	public World FFIKLLCPMEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x27BFB70", Offset = "0x27BE170", VA = "0x1827BFB70", Slot = "5")]
	public World FALMOHOOEPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x27BFDC0", Offset = "0x27BE3C0", VA = "0x1827BFDC0", Slot = "6")]
	public World IKOMPELDNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x27BFAD0", Offset = "0x27BE0D0", VA = "0x1827BFAD0", Slot = "7")]
	public World FADMPHNMKJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x27BFD30", Offset = "0x27BE330", VA = "0x1827BFD30")]
	private World FLBIJHJPEJF(string ECMAPGHKHFB, JCCPMAHLPOA EJBKGMJFFOC, Type MGLFOLFIHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public AFAPGEOBBNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
public enum ADMKFPPIBEF
{
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
internal class EMHJELMDCDA : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private object LCABJFDKCCO;

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x24A1950", Offset = "0x249FF50", VA = "0x1824A1950", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x24A19D0", Offset = "0x249FFD0", VA = "0x1824A19D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x24A1A70", Offset = "0x24A0070", VA = "0x1824A1A70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public EMHJELMDCDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal class NBOLAAIFCPE : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private FFIEDGLJPJJ KOBLJDIMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private EntityQuery AHKDIFFLCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private EntityQuery JCECPCNNGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private MKBGHPFKLIO HLHINDIFOED;

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x2A87D10", Offset = "0x2A86310", VA = "0x182A87D10", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x2A88420", Offset = "0x2A86A20", VA = "0x182A88420", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x2A88530", Offset = "0x2A86B30", VA = "0x182A88530", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x2A88090", Offset = "0x2A86690", VA = "0x182A88090")]
	private void JFGNKDAKCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x2A87BA0", Offset = "0x2A861A0", VA = "0x182A87BA0")]
	private void EPMLGJDLLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x2A87D80", Offset = "0x2A86380", VA = "0x182A87D80")]
	private void JCLJKIPOMPH(NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x2A87A60", Offset = "0x2A86060", VA = "0x182A87A60")]
	private void CHPDMDEHOAG(NativeArray<Entity> NCEOACJJMCN, int LDGNJOHCGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x2A881A0", Offset = "0x2A867A0", VA = "0x182A881A0")]
	private void LNLBMOBGJKD(NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x2A883C0", Offset = "0x2A869C0", VA = "0x182A883C0")]
	private void MFHCOENEGIJ(Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x9601D0", Offset = "0x95E7D0", VA = "0x1809601D0")]
	private static void MGNOBPFACPC(int JFFCAOEMPPP, Transform DMECJMCKFAG, Entity MPAGCMNFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public NBOLAAIFCPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal static class MPGACIMDDEA
{
	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x2A87800", Offset = "0x2A85E00", VA = "0x182A87800")]
	public static bool DPHDMILNOMN(this SystemBase CPDLEGJAIIP, out Entity MPAGCMNFGMI)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[CompilerGenerated]
	[AIBFCFMKILK(AGPDIMMFKMP.OMRoom)]
	public class PostLoadRemapCircuitIds : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct PostLoadRemapCircuitIds_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			public HKACBKPJJFC remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public ComponentTypeHandle<JJCLPAEIJMF> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A8B")]
			[Cpp2IlInjected.Address(RVA = "0x3C11690", Offset = "0x3C0FC90", VA = "0x183C11690")]
			private void DKBFAIHFAHI(ref JJCLPAEIJMF node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A8C")]
			[Cpp2IlInjected.Address(RVA = "0x3C118D0", Offset = "0x3C0FED0", VA = "0x183C118D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		[LABJLBKOJHN]
		private KIMCOPEIFEL serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private EntityQuery PostLoadRemapCircuitIds_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private ComponentTypeHandle<JJCLPAEIJMF> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x261D2F0", Offset = "0x261B8F0", VA = "0x18261D2F0", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x261D570", Offset = "0x261BB70", VA = "0x18261D570", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x261D110", Offset = "0x261B710", VA = "0x18261D110")]
		private void ACOEBCJHADD(HKACBKPJJFC remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x261D200", Offset = "0x261B800", VA = "0x18261D200")]
		private void EHGGDHPNNGB(ref HKACBKPJJFC remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x261D340", Offset = "0x261B940", VA = "0x18261D340", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PostLoadRemapCircuitIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class EDKEGPGAMKF : DIIPAOKEIKC, LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private static readonly IAMDAJKPFJC EECOPHNOLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	[LABJLBKOJHN]
	private DKKKGDEMMBH OHACKIIBLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	[LABJLBKOJHN]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	[LABJLBKOJHN]
	private LBGAFCFPELD JCGGJMJMODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	[LABJLBKOJHN]
	private ECGBJBIHLPJ EGAHPGKBOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	[LABJLBKOJHN]
	private HJFCNJLKICJ BMEJKOEHPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	[LABJLBKOJHN]
	private ELKDKDDOJGN DCDGMLDKCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private LJHBFNNMDMA.PDBHNBPLDBE CNCPKLPFIDO;

	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x249F7E0", Offset = "0x249DDE0", VA = "0x18249F7E0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x249EF90", Offset = "0x249D590", VA = "0x18249EF90", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x24A0370", Offset = "0x249E970", VA = "0x1824A0370", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x249E4F0", Offset = "0x249CAF0", VA = "0x18249E4F0")]
	private void AHDIAIALOBE(MODKFNDEKMI BOMEFJIOGGM, NativeArray<byte> ILBIAAFPAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x249F600", Offset = "0x249DC00", VA = "0x18249F600")]
	private bool ILKEOMIPGEB(MODKFNDEKMI BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x249F660", Offset = "0x249DC60", VA = "0x18249F660")]
	private LJHBFNNMDMA.LPPMMPJAIOJ IOFJDCPPEIP(NativeArray<byte> ILBIAAFPAAJ, Allocator HINEEPDGLPG)
	{
		return default(LJHBFNNMDMA.LPPMMPJAIOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x249FF60", Offset = "0x249E560", VA = "0x18249FF60")]
	private void MHFJOCHGDDJ(LJHBFNNMDMA.LPPMMPJAIOJ GENNENCMDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x249F030", Offset = "0x249D630", VA = "0x18249F030")]
	private void FIOPMBPEOMD(NativeList<EEKJFDFIEGN> OPHACLOMLBN, NativeList<FNDBMHENIMP> HNMKHJBPNJK, Allocator HINEEPDGLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x249F990", Offset = "0x249DF90", VA = "0x18249F990")]
	private void JBCEENPOIAO(NativeParallelMultiHashMap<EEKJFDFIEGN, IPFEKNFNPDF> JLJMGIGGGDL, NativeList<byte> OIJGAKCLNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x249F3A0", Offset = "0x249D9A0", VA = "0x18249F3A0")]
	private void HKJPKADACLK(NativeList<EEKJFDFIEGN> KIHBDEPGKFD, Allocator HINEEPDGLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0x24A0050", Offset = "0x249E650", VA = "0x1824A0050")]
	private void MHLAGFBBDKG(LJHBFNNMDMA.LPPMMPJAIOJ JAIGDBINGHO, bool OKJMNCJOLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x249F220", Offset = "0x249D820", VA = "0x18249F220")]
	private void HDDBOGHBJLI(NativeList<EEKJFDFIEGN> OPHACLOMLBN, NativeList<FNDBMHENIMP> HNMKHJBPNJK, bool OKJMNCJOLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x249E960", Offset = "0x249CF60", VA = "0x18249E960")]
	private void BMADEHNCJNI(NativeParallelMultiHashMap<EEKJFDFIEGN, IPFEKNFNPDF> JLJMGIGGGDL, NativeList<byte> OIJGAKCLNIO, bool OKJMNCJOLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x249FE50", Offset = "0x249E450", VA = "0x18249FE50")]
	private void JICNDINLFDG(NativeList<EEKJFDFIEGN> KIHBDEPGKFD, bool OKJMNCJOLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void ANHJDFCPNDI(MODKFNDEKMI BOMEFJIOGGM, bool OKJMNCJOLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public EDKEGPGAMKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class PNLHCCMIDAF : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x2612A70", Offset = "0x2611070", VA = "0x182612A70", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public PNLHCCMIDAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
internal interface CAODOHKABMK
{
	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	NativeParallelMultiHashMap<Entity, CBJNCBOLPDM> DALEOPMMAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	uint IAIKLPLKODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FIAGEBMHMBL(NativeArray<EEKJFDFIEGN> OPHACLOMLBN, NativeArray<FNDBMHENIMP> HNMKHJBPNJK, NativeArray<EEKJFDFIEGN> KIHBDEPGKFD, int CBJFFAMBOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCEFNNOPOLO(in MMLPILKMICH DABGDPOOFFH);

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAHCNNGJLOO(JobHandle FCDGNCOICKN);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	public class CalculateCollisionIslandUpdatesSystem : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x20001D0")]
		[BurstCompile]
		[NoAlias]
		private struct CalculateCollisionIslandUpdatesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			public NativeList<Entity> rootsWithForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			public NativeList<Entity> rootsWithoutForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			[ReadOnly]
			public ComponentTypeHandle<MGKCNAGGBBM> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			[ReadOnly]
			public ComponentDataFromEntity<MGKCNAGGBBM> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			[ReadOnly]
			public ComponentTypeHandle<PCNIEMKNHNM> splineParentHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public EntityQueryInJob changedLocalPoseQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public EntityQueryInJob changedSplinePointsQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			public EntityQueryInJob splinesWithChangedChildrenQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000605")]
			public EntityQueryInJob changedCollisionModeQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000606")]
			public EntityQueryInJob changedScopeRootQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000607")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0x28EF610", Offset = "0x28EDC10", VA = "0x1828EF610")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAC")]
			[Cpp2IlInjected.Address(RVA = "0x28EFE10", Offset = "0x28EE410", VA = "0x1828EFE10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private EntityQuery changedLocalPoseQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private EntityQuery changedSplinePointsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private EntityQuery splinesWithChangedChildrenQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private EntityQuery changedCollisionModeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private EntityQuery scopeRootChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private BPFOPFGDLFP collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x27D4740", Offset = "0x27D2D40", VA = "0x1827D4740", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x27D4940", Offset = "0x27D2F40", VA = "0x1827D4940", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x27D4CA0", Offset = "0x27D32A0", VA = "0x1827D4CA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x27D4790", Offset = "0x27D2D90", VA = "0x1827D4790")]
		private JobHandle ODDBMPECHFH(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<MGKCNAGGBBM> collisionIslandRootDataHandleRO, ComponentDataFromEntity<MGKCNAGGBBM> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<PCNIEMKNHNM> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
[GHIPPEMCIOG]
public class NMHDHCBMACA : AEKGPLOBAHI
{
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D470", Offset = "0x2A8BA70", VA = "0x182A8D470", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D500", Offset = "0x2A8BB00", VA = "0x182A8D500", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D420", Offset = "0x2A8BA20", VA = "0x182A8D420")]
	private EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public NMHDHCBMACA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class MCPEJELGHFI : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	[BurstCompile]
	private struct KHPAFKNLJCK : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		[ReadOnly]
		public int AAEFJLGNJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		[ReadOnly]
		public EntityQueryInJob AEOLFCIJHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		[ReadOnly]
		public EntityQueryInJob NODMDFPCJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged MAIKAKBIIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		[ReadOnly]
		public EntityTypeHandle APFOCJEDBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		[ReadOnly]
		public ComponentDataFromEntity<MPMDBHHLKDH> IIFJEOBGEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		[ReadOnly]
		public ComponentDataFromEntity<EOEAFFEAOLE> OIBKAHEDHIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> AKEDNLAIFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		[ReadOnly]
		public ComponentTypeHandle<PCNIEMKNHNM> ADAIDIHGHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		[ReadOnly]
		public ComponentDataFromEntity<EOJLFMPKHEN> NDBPBBOJGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		[ReadOnly]
		public ComponentDataFromEntity<FJEOOOCNEKL> KEPANENMBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		[WriteOnly]
		public ComponentDataFromEntity<MNJGBFPFJCD> PDEFOPGAIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		[WriteOnly]
		public ComponentDataFromEntity<KBPIEDEACLP> GCCIIFKACJF;

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x28F7DD0", Offset = "0x28F63D0", VA = "0x1828F7DD0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x28F7410", Offset = "0x28F5A10", VA = "0x1828F7410")]
		private void BMDDOBLKBJF(NativeList<Entity> DFPFFEGPPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x28F7920", Offset = "0x28F5F20", VA = "0x1828F7920")]
		private void EABJKNEFLAP(Entity JCPFBEJJJPM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private EntityQuery DENCCHKDEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private EntityQuery LHMAOMGPHME;

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x2A82F10", Offset = "0x2A81510", VA = "0x182A82F10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x2A830B0", Offset = "0x2A816B0", VA = "0x182A830B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x1A981A0", Offset = "0x1A967A0", VA = "0x181A981A0")]
	private bool NAOMKKANDIK<T>(T OHHGCOCIFAK, out int PLNIIDMBBNN) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public MCPEJELGHFI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001D4")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkId : AEKGPLOBAHI, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x20001D5")]
		private struct DebugPostLoadValidateNetworkId_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public NativeParallelHashMap<EEKJFDFIEGN, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			[ReadOnly]
			public ComponentTypeHandle<GPFOFHIKGAP> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x28F1280", Offset = "0x28EF880", VA = "0x1828F1280")]
			private void DKBFAIHFAHI(Entity entity, in GPFOFHIKGAP networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x28F1330", Offset = "0x28EF930", VA = "0x1828F1330", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private LDONCAMGPOJ networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private EntityQuery DebugPostLoadValidateNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private ComponentTypeHandle<GPFOFHIKGAP> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x249D120", Offset = "0x249B720", VA = "0x18249D120", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x249D4A0", Offset = "0x249BAA0", VA = "0x18249D4A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x249D180", Offset = "0x249B780", VA = "0x18249D180")]
		private void NMFNKEIOBMF(ref NativeParallelHashMap<EEKJFDFIEGN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABC")]
		[Cpp2IlInjected.Address(RVA = "0x249D270", Offset = "0x249B870", VA = "0x18249D270", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public DebugPostLoadValidateNetworkId()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public readonly struct BCABFJJOPJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	private readonly int MPGHGDABPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	private readonly int MJBJADACIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000621")]
	private readonly JDOBAEGPJED NILANNAAGKO;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public JDOBAEGPJED IEKCODBLFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC1")]
		[Cpp2IlInjected.Address(RVA = "0xACAB80", Offset = "0xAC9180", VA = "0x180ACAB80")]
		get
		{
			return default(JDOBAEGPJED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x27C4020", Offset = "0x27C2620", VA = "0x1827C4020")]
	public BCABFJJOPJD(int MPGHGDABPMN, int MJBJADACIFB, JDOBAEGPJED NILANNAAGKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
[InternalBufferCapacity(1)]
internal struct MFGPIBOPNFC : ISystemStateBufferElementData, IBufferElementData, IEquatable<MFGPIBOPNFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000622")]
	public MGCLCHOHDHP FCDGNCOICKN;

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2A83BB0", Offset = "0x2A821B0", VA = "0x182A83BB0", Slot = "4")]
	public bool Equals(MFGPIBOPNFC FKJGPCABBJN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static MFGPIBOPNFC LBBGOAOJJNO(MGCLCHOHDHP FCDGNCOICKN)
	{
		return default(MFGPIBOPNFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
[OJJOJOKIEBL(typeof(GHPFOIJGFBB), new string[] { })]
public sealed class AMGJHIMLFCK : GHPFOIJGFBB, LPOKOJIEHOF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001D9")]
	private struct AKFLHMILHMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public float GEKPJGOKBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public uint CMMPCJPBGDK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	[LABJLBKOJHN]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	[LABJLBKOJHN]
	private EMLPEGCKBCF OIIDABCIELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	[LABJLBKOJHN]
	private ANBDFDAFPGK FLOOBDLIDJK;

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x27C25C0", Offset = "0x27C0BC0", VA = "0x1827C25C0", Slot = "5")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x27C20D0", Offset = "0x27C06D0", VA = "0x1827C20D0")]
	public bool FEGDNOKIPAB(in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, float JOJFLKALKOE, out JNJODLALMOB AAIJPFEJJAO, out ENMPPPDAMHN JCPFBEJJJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x27C1FF0", Offset = "0x27C05F0", VA = "0x1827C1FF0")]
	public static bool CLACJFONDDD(in Span<JNJODLALMOB> GIOPIAALFBK, float JOJFLKALKOE, out int OLGOBCPPPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x27C2650", Offset = "0x27C0C50", VA = "0x1827C2650")]
	public static float PGDJPCNJABO(float GEKPJGOKBCE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public AMGJHIMLFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x27C25B0", Offset = "0x27C0BB0", VA = "0x1827C25B0", Slot = "4")]
	private bool GECCNIBEONJ(in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, float JOJFLKALKOE, out JNJODLALMOB AAIJPFEJJAO, out ENMPPPDAMHN JCPFBEJJJPM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001DA")]
internal struct LCPOAOCCIPN : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class ADCENKMOEIJ : DIIPAOKEIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private EntityQuery JKLFKKIOBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private ComponentTypes LMDIEOHFPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private NativeParallelHashSet<int> EHDIPPAHMME;

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x27BF220", Offset = "0x27BD820", VA = "0x1827BF220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x27BF690", Offset = "0x27BDC90", VA = "0x1827BF690", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x27BF710", Offset = "0x27BDD10", VA = "0x1827BF710", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x27BF180", Offset = "0x27BD780", VA = "0x1827BF180")]
	public JobHandle MAKKJLGGDDP(JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public ADCENKMOEIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public class OJPCBFCIIGO : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[BurstCompile]
	private struct BHEDHKOHJHJ : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		[ReadOnly]
		public ComponentTypeHandle<LCEGPOLIGKI> JFFLCAIIEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public ComponentTypeHandle<JKCIFKNJAAP> KOJPHPKOKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public uint IAIKLPLKODM;

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E280", Offset = "0x3C0C880", VA = "0x183C0E280", Slot = "4")]
		public void Execute(ArchetypeChunk FCONCDBMPAA, int OLGOBCPPPBB, int IHINDCCMJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E1F0", Offset = "0x3C0C7F0", VA = "0x183C0E1F0")]
		public bool AMHHHBOFGAN(ArchetypeChunk FCONCDBMPAA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private EntityQuery HNMMHAHAKOI;

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x260E580", Offset = "0x260CB80", VA = "0x18260E580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x260E6B0", Offset = "0x260CCB0", VA = "0x18260E6B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public OJPCBFCIIGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[ExecuteAlways]
public class IBLIFDHPKCF : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
	public IBLIFDHPKCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public struct LMPIAGDKNOK<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private KAJIKMFGFBN<T> MPNDOHBKHJO;

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x24E0AD0", Offset = "0x24DF0D0", VA = "0x1824E0AD0")]
	public LMPIAGDKNOK(KAJIKMFGFBN<T> MPNDOHBKHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x28DFD00", Offset = "0x28DE300", VA = "0x1828DFD00")]
	public MINFALADENH<T> BAPGMDPFJDH()
	{
		return default(MINFALADENH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(BHKOPFADEBN), new string[] { })]
public class BHKOPFADEBN : LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	[LABJLBKOJHN]
	private FOKGJFJPKEK FJNPCKPLFNE;

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x27C7F00", Offset = "0x27C6500", VA = "0x1827C7F00", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BHKOPFADEBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class GJHACPAHACJ : EADBPNDNIAC<NDNKLODDEKL>
{
	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x24B7C70", Offset = "0x24B6270", VA = "0x1824B7C70", Slot = "14")]
	protected override void CNOIAAHCHKK(NativeArray<Entity> NCEOACJJMCN, NativeArray<Entity> MIFIHODCNOA, NativeArray<Entity> NGFGIMEBOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x24B7BA0", Offset = "0x24B61A0", VA = "0x1824B7BA0")]
	private static void CNOIAAHCHKK(NativeArray<Entity> NCEOACJJMCN, NativeArray<Entity> NGFGIMEBOFL, ComponentDataFromEntity<global::EKDDJPACKIG> NKEMPFDMOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x24B7DC0", Offset = "0x24B63C0", VA = "0x1824B7DC0")]
	public GJHACPAHACJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class OHJKFDBADFE : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x260C630", Offset = "0x260AC30", VA = "0x18260C630", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public OHJKFDBADFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
public abstract class GBDAEECGOJF : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private LKEACJPELBE NNKCFAHPEMD;

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x24B32C0", Offset = "0x24B18C0", VA = "0x1824B32C0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x24B3320", Offset = "0x24B1920", VA = "0x1824B3320", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x24B3350", Offset = "0x24B1950", VA = "0x1824B3350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	protected GBDAEECGOJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
public static class OPDFBPKHKBN
{
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] PJLPHIDBEBB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal struct OLEOLMMGAFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001E7")]
internal struct GLMDPCMNLDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class DOLGCNAEGLG : AEKGPLOBAHI
{
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	private static IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	private EntityQuery BGMLJBEPENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	private EntityQuery FNGDAHGGOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private EntityQuery DMNBPBMGFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private EntityQuery CNHKCFBMKOL;

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x27D8AE0", Offset = "0x27D70E0", VA = "0x1827D8AE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x27D8CA0", Offset = "0x27D72A0", VA = "0x1827D8CA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x27D8760", Offset = "0x27D6D60", VA = "0x1827D8760")]
	private void ALJMLAKDLFG(EntityQuery OGAAEGIJKLI, bool CJCKMIMPOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x27D8920", Offset = "0x27D6F20", VA = "0x1827D8920")]
	private void DGLFFFJJLFA(EntityQuery OGAAEGIJKLI, bool CJCKMIMPOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public DOLGCNAEGLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
internal class JNOOELIBLMP : BKKPIKCCOMM
{
	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	protected override DEKJDDCLMEB BJHKELLEKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6210", Offset = "0x2AE4810", VA = "0x182AE6210", Slot = "15")]
		get
		{
			return default(DEKJDDCLMEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x24A4310", Offset = "0x24A2910", VA = "0x1824A4310")]
	public JNOOELIBLMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EA")]
[DefaultMember("Item")]
public struct ANGEJGLOKCL<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	public NativeList<Entity> NCEOACJJMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	public NativeList<T> JAIGDBINGHO;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public int ALHMBJNHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x2083330", Offset = "0x2081930", VA = "0x182083330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public (Entity entity, T value) ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x2083960", Offset = "0x2081F60", VA = "0x182083960")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x2084AB0", Offset = "0x20830B0", VA = "0x182084AB0")]
	public void PDDBDHJNBOH(Entity MPAGCMNFGMI, T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x20845E0", Offset = "0x2082BE0", VA = "0x1820845E0")]
	public void KGACBIKGAOI(NativeArray<Entity> MPAGCMNFGMI, NativeArray<T> MOLEJFDINLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EB")]
[GHIPPEMCIOG]
public class GMAFMCNFCKL : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private static readonly IAMDAJKPFJC BDKIDOKAPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	[LABJLBKOJHN]
	private LDONCAMGPOJ BLBDABPHPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private EntityQuery MOBHENDMHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private EntityQuery AJJGAGBPNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x24B8BA0", Offset = "0x24B71A0", VA = "0x1824B8BA0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x24B8D80", Offset = "0x24B7380", VA = "0x1824B8D80")]
	public bool NJMOIBAEJPF(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x24B8E30", Offset = "0x24B7430", VA = "0x1824B8E30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x24B8D60", Offset = "0x24B7360", VA = "0x1824B8D60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0xE413B0", Offset = "0xE3F9B0", VA = "0x180E413B0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x24B8F10", Offset = "0x24B7510", VA = "0x1824B8F10", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x24B8D60", Offset = "0x24B7360", VA = "0x1824B8D60")]
	private void KEAGPBOPKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x24B8890", Offset = "0x24B6E90", VA = "0x1824B8890")]
	private void CHCEOMLHLPN(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x24B8BF0", Offset = "0x24B71F0", VA = "0x1824B8BF0")]
	private void JPGHNAFJJMB(NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public GMAFMCNFCKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EC")]
public struct PMJLKLGEBFH<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private ANGEJGLOKCL<T> MPNDOHBKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private EntityCommandBuffer EJOBGFBIEJO;

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x22BC150", Offset = "0x22BA750", VA = "0x1822BC150")]
	public PMJLKLGEBFH(ANGEJGLOKCL<T> MPNDOHBKHJO, EntityCommandBuffer EJOBGFBIEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x22BBB40", Offset = "0x22BA140", VA = "0x1822BBB40", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x22BC130", Offset = "0x22BA730", VA = "0x1822BC130")]
	public static ANGEJGLOKCL<T> LBBGOAOJJNO(PMJLKLGEBFH<T> EMGLKKBADKE)
	{
		return default(ANGEJGLOKCL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001ED")]
public static class LCMEJCBMJNF
{
	[Cpp2IlInjected.Token(Token = "0x4000647")]
	internal static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0xF43070", Offset = "0xF41670", VA = "0x180F43070")]
	public static void DOIFCEJGCCI<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(LIFCBCFOLBC CBMJEICKDDL, GOHNKJBJJHB<Entity> EFINPLKEDMK, out CMPMKCLAGPD<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> NOJBGJIGPNG) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, IINMBNDBECP where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, IINMBNDBECP, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B02")]
	[Cpp2IlInjected.Address(RVA = "0x2A759E0", Offset = "0x2A73FE0", VA = "0x182A759E0")]
	public static bool EHLHCBKGGAA(NILFLMGAFIC PCJDHJGLBFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EE")]
public class CMPMKCLAGPD<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, IINMBNDBECP where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, IINMBNDBECP, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x4000648")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	private readonly MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private readonly FEHHJLHONFC<Entity> JCPKNOEICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private readonly GEMKDFICLBK DIKJKJDPFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private readonly AAOPIAOGDMN HDBBNLFBJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private readonly EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private readonly DEECNKLJPLJ OBJFKAPAMCI;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x34644A0", Offset = "0x3462AA0", VA = "0x1834644A0")]
	public CMPMKCLAGPD(LIFCBCFOLBC CBMJEICKDDL, GOHNKJBJJHB<Entity> EFINPLKEDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x3463DB0", Offset = "0x34623B0", VA = "0x183463DB0")]
	private bool HDNGMAJEIGA(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x3463800", Offset = "0x3461E00", VA = "0x183463800")]
	private bool CHHOKHFCDAI(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x3463FC0", Offset = "0x34625C0", VA = "0x183463FC0")]
	private bool MOGKGLHBIPE(Entity MPAGCMNFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x3463D80", Offset = "0x3462380", VA = "0x183463D80")]
	public bool HABHLECNBOO(Entity MPAGCMNFGMI, in Entity EPBIFMJLJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x3463370", Offset = "0x3461970", VA = "0x183463370")]
	public bool AHPEEELCLEB(Entity MPAGCMNFGMI, in Entity EPBIFMJLJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x3462F10", Offset = "0x3461510", VA = "0x183462F10")]
	private bool AHPEEELCLEB(Entity MPAGCMNFGMI, in Entity EPBIFMJLJFE, bool PJBPPKAHDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void NJMLBAFKGOC(Entity MPAGCMNFGMI, in Entity EPBIFMJLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void DFFBCKNIJAD(Entity MPAGCMNFGMI, in Entity EPBIFMJLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void JDIGCLKMMBM(Entity MPAGCMNFGMI, in Entity EPBIFMJLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void DFHFDDKOKHN(Entity MPAGCMNFGMI, in Entity EPBIFMJLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private static void IJOLBFGIMCC(Entity MPAGCMNFGMI, in Entity EPBIFMJLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x3463CA0", Offset = "0x34622A0", VA = "0x183463CA0")]
	private bool GGFOGAAPHID(Entity MPAGCMNFGMI, Entity IOKDMANFCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x3463E70", Offset = "0x3462470", VA = "0x183463E70")]
	private void HEGLOJIKMHC(Entity MPAGCMNFGMI, in Entity ELDCHLKBIGE, in Entity EPBIFMJLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x34641C0", Offset = "0x34627C0", VA = "0x1834641C0")]
	private void PMCAJMGBGEH(Entity MPAGCMNFGMI, in Entity ELDCHLKBIGE, in Entity EPBIFMJLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x34633A0", Offset = "0x34619A0", VA = "0x1834633A0")]
	private bool BHLPFAEDMLI(LBGAFCFPELD LLFJDOLINHG, in EEKJFDFIEGN CDIAFKHKJLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x3463980", Offset = "0x3461F80", VA = "0x183463980")]
	private void FNKCMBBPENL(Entity HDBBNLFBJKG, Entity BIKOOLOFJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x34638F0", Offset = "0x3461EF0", VA = "0x1834638F0")]
	private void CNLHCEJCBPI(Entity HDBBNLFBJKG, Entity BIKOOLOFJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private void IEPHIOFFMAF(Entity MPAGCMNFGMI, Entity ELDCHLKBIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B17")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
	private void DPGFOMMKMIO(Entity MPAGCMNFGMI, Entity EPBIFMJLJFE)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001EF")]
	[CompilerGenerated]
	public class GatherModifiedParents : DIIPAOKEIKC, EMBHBGCIFNL
	{
		[Cpp2IlInjected.Token(Token = "0x20001F0")]
		[BurstCompile]
		[NoAlias]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			public NativeList<GDJICEPBCLA> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			[ReadOnly]
			public ComponentTypeHandle<BCIOGPLFNGO> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x28F45C0", Offset = "0x28F2BC0", VA = "0x1828F45C0")]
			private void DKBFAIHFAHI(Entity entity, [NoAlias] in BCIOGPLFNGO current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x28F4640", Offset = "0x28F2C40", VA = "0x1828F4640", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001F1")]
		[BurstCompile]
		[NoAlias]
		private struct GatherModifiedParents_AddChangedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000658")]
			public NativeList<GPLDEABEJMM> changedParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000659")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			[ReadOnly]
			public ComponentTypeHandle<BCIOGPLFNGO> __currentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400065B")]
			[ReadOnly]
			public ComponentTypeHandle<MJMBIIBNCJB> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B22")]
			[Cpp2IlInjected.Address(RVA = "0x28F4360", Offset = "0x28F2960", VA = "0x1828F4360")]
			private void DKBFAIHFAHI(Entity entity, [NoAlias] in BCIOGPLFNGO current, [NoAlias] in MJMBIIBNCJB previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B23")]
			[Cpp2IlInjected.Address(RVA = "0x28F4420", Offset = "0x28F2A20", VA = "0x1828F4420", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001F2")]
		[BurstCompile]
		[NoAlias]
		private struct GatherModifiedParents_AddRemovedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400065C")]
			public NativeList<GDJICEPBCLA> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400065D")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400065E")]
			[ReadOnly]
			public ComponentTypeHandle<MJMBIIBNCJB> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B24")]
			[Cpp2IlInjected.Address(RVA = "0x28F4760", Offset = "0x28F2D60", VA = "0x1828F4760")]
			private void DKBFAIHFAHI(Entity entity, [NoAlias] in MJMBIIBNCJB previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B25")]
			[Cpp2IlInjected.Address(RVA = "0x28F47E0", Offset = "0x28F2DE0", VA = "0x1828F47E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private DEECNKLJPLJ parentEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private EntityQuery GatherModifiedParents_AddNewParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private EntityQuery GatherModifiedParents_AddChangedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private EntityQuery GatherModifiedParents_AddRemovedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private ComponentTypeHandle<BCIOGPLFNGO> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private ComponentTypeHandle<MJMBIIBNCJB> __RecRoom_Components_PreviousParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x24BB780", Offset = "0x24B9D80", VA = "0x1824BB780", Slot = "14")]
		public void KGCINGIMMLM(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x24BC060", Offset = "0x24BA660", VA = "0x1824BC060", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x24BB520", Offset = "0x24B9B20", VA = "0x1824BB520")]
		private JobHandle DCHEAOCEOBJ(NativeList<GDJICEPBCLA> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x24BB860", Offset = "0x24B9E60", VA = "0x1824BB860")]
		private JobHandle KKGNKNABEHJ(NativeList<GPLDEABEJMM> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x24BB650", Offset = "0x24B9C50", VA = "0x1824BB650")]
		private JobHandle IIBLHHDPPMG(NativeList<GDJICEPBCLA> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x24BB9D0", Offset = "0x24B9FD0", VA = "0x1824BB9D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public GatherModifiedParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F3")]
[UpdateBefore(typeof(PCEFIOLKLEF))]
public class HJNBLAAHKCL : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private MKBGHPFKLIO HLHINDIFOED;

	[Cpp2IlInjected.Token(Token = "0x6000B26")]
	[Cpp2IlInjected.Address(RVA = "0x2AD54A0", Offset = "0x2AD3AA0", VA = "0x182AD54A0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B27")]
	[Cpp2IlInjected.Address(RVA = "0x2AD54F0", Offset = "0x2AD3AF0", VA = "0x182AD54F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B28")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public HJNBLAAHKCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F4")]
[OJJOJOKIEBL(typeof(GHMKMBPEGGE), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal class GHMKMBPEGGE : DAMJNMDABPA, LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001F6")]
	[CompilerGenerated]
	private sealed class KNAJOBIMICD : IEnumerable<(IFEBDPAFELD, BLIAAMDKPNO)>, IEnumerable, IEnumerator<(IFEBDPAFELD, BLIAAMDKPNO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private (IFEBDPAFELD primitiveType, BLIAAMDKPNO prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public GHMKMBPEGGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private int <i>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private IFEBDPAFELD <primitiveType>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private BLIAAMDKPNO <prefabType>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		private (IFEBDPAFELD, BLIAAMDKPNO) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B47")]
			[Cpp2IlInjected.Address(RVA = "0x22DAE80", Offset = "0x22D9480", VA = "0x1822DAE80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((IFEBDPAFELD, BLIAAMDKPNO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B49")]
			[Cpp2IlInjected.Address(RVA = "0x28F8420", Offset = "0x28F6A20", VA = "0x1828F8420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x28F8470", Offset = "0x28F6A70", VA = "0x1828F8470")]
		[DebuggerHidden]
		public KNAJOBIMICD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x28F8260", Offset = "0x28F6860", VA = "0x1828F8260", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x28F83E0", Offset = "0x28F69E0", VA = "0x1828F83E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x28F8340", Offset = "0x28F6940", VA = "0x1828F8340", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(IFEBDPAFELD, BLIAAMDKPNO)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x28F8340", Offset = "0x28F6940", VA = "0x1828F8340", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private World DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private NativeParallelHashMap<int, Entity> LKGDMEFDKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private NativeParallelHashMap<int, EntityArchetype> LKIGJKOLJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private NativeParallelHashMap<int, int> GNBMIPGKCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private BLIAAMDKPNO[] EBCEGDCHNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private readonly Dictionary<IFEBDPAFELD, BLIAAMDKPNO> HLOFFJKGGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private readonly Dictionary<MMLPKMBDFID, BLIAAMDKPNO> ONANLHLBEBP;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x24B5790", Offset = "0x24B3D90", VA = "0x1824B5790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A0", Offset = "0x8CBAA0", VA = "0x1808CD4A0")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x1909E50", Offset = "0x1908450", VA = "0x181909E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2D")]
	[Cpp2IlInjected.Address(RVA = "0x24B59C0", Offset = "0x24B3FC0", VA = "0x1824B59C0", Slot = "5")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2E")]
	[Cpp2IlInjected.Address(RVA = "0x24B53C0", Offset = "0x24B39C0", VA = "0x1824B53C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2F")]
	[Cpp2IlInjected.Address(RVA = "0x9358D0", Offset = "0x933ED0", VA = "0x1809358D0")]
	internal NativeParallelHashMap<int, Entity> JMCGJHKILKO()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B30")]
	[Cpp2IlInjected.Address(RVA = "0xCEA020", Offset = "0xCE8620", VA = "0x180CEA020")]
	internal NativeParallelHashMap<int, EntityArchetype> KFLJABCCEGE()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B31")]
	[Cpp2IlInjected.Address(RVA = "0x9358F0", Offset = "0x933EF0", VA = "0x1809358F0")]
	internal NativeParallelHashMap<int, int> BILEJLMEGIF()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B32")]
	[Cpp2IlInjected.Address(RVA = "0x24B6500", Offset = "0x24B4B00", VA = "0x1824B6500")]
	internal IEnumerable<Type> JJHNDPICIED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B33")]
	[Cpp2IlInjected.Address(RVA = "0x24B66D0", Offset = "0x24B4CD0", VA = "0x1824B66D0")]
	internal FCJOBAGOILJ KBBMNDBMPFM(Type KLGGKKGCLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B34")]
	[Cpp2IlInjected.Address(RVA = "0x24B5260", Offset = "0x24B3860", VA = "0x1824B5260")]
	public EntityArchetype AJIBOLKCHEE(BLIAAMDKPNO POJMFCODLHG)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B35")]
	[Cpp2IlInjected.Address(RVA = "0x24B57D0", Offset = "0x24B3DD0", VA = "0x1824B57D0", Slot = "4")]
	[IteratorStateMachine(typeof(KNAJOBIMICD))]
	public IEnumerable<(IFEBDPAFELD, BLIAAMDKPNO)> HKHFIHNCILB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B36")]
	[Cpp2IlInjected.Address(RVA = "0x24B52D0", Offset = "0x24B38D0", VA = "0x1824B52D0")]
	public Entity BKAFCMHHBBL(BLIAAMDKPNO POJMFCODLHG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x24B5840", Offset = "0x24B3E40", VA = "0x1824B5840")]
	public void IHHBPOHEKCO(NativeArray<BLIAAMDKPNO> EBCEGDCHNNH, NativeArray<Entity> PKDJKKFMCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B38")]
	[Cpp2IlInjected.Address(RVA = "0x24B64B0", Offset = "0x24B4AB0", VA = "0x1824B64B0")]
	public void JGGHGEINBFD(BLIAAMDKPNO POJMFCODLHG, NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B39")]
	[Cpp2IlInjected.Address(RVA = "0x24B5730", Offset = "0x24B3D30", VA = "0x1824B5730")]
	public BLIAAMDKPNO EBNGCMIBIEG(IFEBDPAFELD KLGGKKGCLHM)
	{
		return default(BLIAAMDKPNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3A")]
	[Cpp2IlInjected.Address(RVA = "0x24B6D70", Offset = "0x24B5370", VA = "0x1824B6D70")]
	public Entity NAKDFEFJKEK(BLIAAMDKPNO POJMFCODLHG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3B")]
	[Cpp2IlInjected.Address(RVA = "0x24B6740", Offset = "0x24B4D40", VA = "0x1824B6740")]
	private void KIKOIPCJNKG(FCJOBAGOILJ KHPPIADMCCK, NativeList<int> EBCEGDCHNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3C")]
	[Cpp2IlInjected.Address(RVA = "0x24B6A40", Offset = "0x24B5040", VA = "0x1824B6A40")]
	internal void MPAACPAOMKF(BLIAAMDKPNO POJMFCODLHG, ComponentTypeList MDCDGJAHCMO, JDLDLAOBEIE HKPLDADPLLL, FCJOBAGOILJ KHPPIADMCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3D")]
	[Cpp2IlInjected.Address(RVA = "0x24B6560", Offset = "0x24B4B60", VA = "0x1824B6560")]
	private EntityArchetype KBAGPJMLAOD(BLIAAMDKPNO POJMFCODLHG, ComponentTypeList CDMNKFEHHOM)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3E")]
	[Cpp2IlInjected.Address(RVA = "0x24B6EE0", Offset = "0x24B54E0", VA = "0x1824B6EE0")]
	public GHMKMBPEGGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F7")]
[OJJOJOKIEBL(typeof(OCAAAEBGOCB), new string[] { })]
public class BOJODAKBBEN : LPOKOJIEHOF, OCAAAEBGOCB
{
	[Cpp2IlInjected.Token(Token = "0x20001F8")]
	[CompilerGenerated]
	private sealed class CKPHIEONCCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public HNCGOEFKEPC objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public ENMPPPDAMHN parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public BOJODAKBBEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private NILFLMGAFIC <parentObject>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private Vector3 <pos>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private Quaternion <rot>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CKPHIEONCCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x28EEA20", Offset = "0x28ED020", VA = "0x1828EEA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001F9")]
	[CompilerGenerated]
	private sealed class JGHBAJFFCAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public NILFLMGAFIC obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public BOJODAKBBEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JGHBAJFFCAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x28F6980", Offset = "0x28F4F80", VA = "0x1828F6980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	[LABJLBKOJHN]
	private JBOGDOHNMAC FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.Token(Token = "0x6000B4C")]
	[Cpp2IlInjected.Address(RVA = "0x27CCA60", Offset = "0x27CB060", VA = "0x1827CCA60", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4D")]
	[Cpp2IlInjected.Address(RVA = "0x27CB730", Offset = "0x27C9D30", VA = "0x1827CB730", Slot = "5")]
	public bool COEEJLLJBGI(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4E")]
	[Cpp2IlInjected.Address(RVA = "0x27CBF70", Offset = "0x27CA570", VA = "0x1827CBF70", Slot = "7")]
	public bool FGMCBHHMPLH(ENMPPPDAMHN HMLJKOHAJKN, out Guid DJLOBGOMBEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x27CCB00", Offset = "0x27CB100", VA = "0x1827CCB00", Slot = "8")]
	public Guid JIACGLMFONM(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x27CBC80", Offset = "0x27CA280", VA = "0x1827CBC80", Slot = "9")]
	public void EEGEHIONIOF(ENMPPPDAMHN HMLJKOHAJKN, Guid DJLOBGOMBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x27CC5C0", Offset = "0x27CABC0", VA = "0x1827CC5C0", Slot = "10")]
	public bool HKLCIMHPABK(ENMPPPDAMHN HMLJKOHAJKN, out Guid NEDBLEJEGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B52")]
	[Cpp2IlInjected.Address(RVA = "0x27CC470", Offset = "0x27CAA70", VA = "0x1827CC470", Slot = "11")]
	public Guid HIIPJLDEBKH(ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B53")]
	[Cpp2IlInjected.Address(RVA = "0x27CC6E0", Offset = "0x27CACE0", VA = "0x1827CC6E0", Slot = "12")]
	public void HNKIGPOGDOM(ENMPPPDAMHN HMLJKOHAJKN, Guid NEDBLEJEGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B54")]
	[Cpp2IlInjected.Address(RVA = "0x27CCDD0", Offset = "0x27CB3D0", VA = "0x1827CCDD0", Slot = "13")]
	public void KGNBNLGADEK(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B55")]
	[Cpp2IlInjected.Address(RVA = "0x27CB860", Offset = "0x27C9E60", VA = "0x1827CB860", Slot = "14")]
	public void EBFKLAHKADD(ENMPPPDAMHN LIGIEJOGFAH, ENMPPPDAMHN HDBBNLFBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B56")]
	[Cpp2IlInjected.Address(RVA = "0x27CCC50", Offset = "0x27CB250", VA = "0x1827CCC50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKPHIEONCCP))]
	private Task JLNJFELMAII(HNCGOEFKEPC LLOIMLOIPCA, ENMPPPDAMHN HDBBNLFBJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B57")]
	[Cpp2IlInjected.Address(RVA = "0x27CCE80", Offset = "0x27CB480", VA = "0x1827CCE80")]
	private void NKOOEPAAINF(HNCGOEFKEPC LLOIMLOIPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B58")]
	[Cpp2IlInjected.Address(RVA = "0x27CC320", Offset = "0x27CA920", VA = "0x1827CC320")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGHBAJFFCAE))]
	private Task FPLHLBGGGDC(NILFLMGAFIC NKFOPKJGBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B59")]
	[Cpp2IlInjected.Address(RVA = "0x27CC090", Offset = "0x27CA690", VA = "0x1827CC090")]
	private Task FKOKIAGEBGN(NILFLMGAFIC NKFOPKJGBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5A")]
	[Cpp2IlInjected.Address(RVA = "0x27CC9D0", Offset = "0x27CAFD0", VA = "0x1827CC9D0", Slot = "6")]
	public bool IMHJKLCKNFO(ENMPPPDAMHN GIAMACBDIFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5B")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public BOJODAKBBEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FA")]
internal class LAPMPMBHLJE : KKMNKFHBJPI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001FB")]
	public struct CLFNNABECOP : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	protected override ComponentType MLHCMDMHHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x2A74C30", Offset = "0x2A73230", VA = "0x182A74C30", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	protected override ComponentType PEHDIFADNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x2A74C00", Offset = "0x2A73200", VA = "0x182A74C00", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	protected override ComponentType JKKAPJCCDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0x2A74C60", Offset = "0x2A73260", VA = "0x182A74C60", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B63")]
	[Cpp2IlInjected.Address(RVA = "0x2A74D20", Offset = "0x2A73320", VA = "0x182A74D20")]
	public LAPMPMBHLJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FC")]
internal abstract class EADBPNDNIAC<TPlayerTag> : DIIPAOKEIKC where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private EntityQuery PBAPJJKENFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private EntityQuery KECMBHHLPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private EntityQuery KCELGCAIFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private EntityQuery BECLEBNHDJC;

	[Cpp2IlInjected.Token(Token = "0x6000B68")]
	[Cpp2IlInjected.Address(RVA = "0x37E1DD0", Offset = "0x37E03D0", VA = "0x1837E1DD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B69")]
	[Cpp2IlInjected.Address(RVA = "0x37E1FD0", Offset = "0x37E05D0", VA = "0x1837E1FD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x37E1FA0", Offset = "0x37E05A0", VA = "0x1837E1FA0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x37E0500", Offset = "0x37DEB00", VA = "0x1837E0500")]
	private void FIOBHKJDFLC(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x37E1070", Offset = "0x37DF670", VA = "0x1837E1070")]
	private void ICMOJBDPOOH(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x37E1420", Offset = "0x37DFA20", VA = "0x1837E1420")]
	private void MNHAHKPMGKG(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void CNOIAAHCHKK(NativeArray<Entity> NCEOACJJMCN, NativeArray<Entity> MIFIHODCNOA, NativeArray<Entity> NGFGIMEBOFL);

	[Cpp2IlInjected.Token(Token = "0x6000B6F")]
	[Cpp2IlInjected.Address(RVA = "0x1E68480", Offset = "0x1E66A80", VA = "0x181E68480")]
	protected EADBPNDNIAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FD")]
[AlwaysUpdateSystem]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class IJODGNNKHHI : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	[LABJLBKOJHN]
	private KDFIBOBNBIO GIGEAGEKEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	[LABJLBKOJHN]
	private LJAFLCDDJAH OHNOBGPIGOJ;

	[Cpp2IlInjected.Token(Token = "0x6000B70")]
	[Cpp2IlInjected.Address(RVA = "0x2AD89F0", Offset = "0x2AD6FF0", VA = "0x182AD89F0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B71")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8A80", Offset = "0x2AD7080", VA = "0x182AD8A80")]
	protected void JLOKMAIAGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B72")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8B00", Offset = "0x2AD7100", VA = "0x182AD8B00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public IJODGNNKHHI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001FE")]
public struct JDALIFEEKHA : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	public static readonly JDALIFEEKHA EOJNEJPDGDL;

	[Cpp2IlInjected.Token(Token = "0x6000B74")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA5B0", Offset = "0x2AD8BB0", VA = "0x182ADA5B0", Slot = "4")]
	public bool Equals(LinkedEntityGroup HEICJNINGBE, LinkedEntityGroup DNLDNFFNIEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B75")]
	[Cpp2IlInjected.Address(RVA = "0x2ADA5D0", Offset = "0x2AD8BD0", VA = "0x182ADA5D0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup NKFOPKJGBEM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FF")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class DHKLEOADGMG : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private FBCFPEGCOHB LBHAJNMIHHB;

	[Cpp2IlInjected.Token(Token = "0x6000B77")]
	[Cpp2IlInjected.Address(RVA = "0x27D7F80", Offset = "0x27D6580", VA = "0x1827D7F80", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x27D7FD0", Offset = "0x27D65D0", VA = "0x1827D7FD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public DHKLEOADGMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000200")]
internal abstract class PMGDLHEJJAE : PKINIECGOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private EntityQuery BMFHAHNOMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private EntityQuery NDJFEKPOOGD;

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x2612640", Offset = "0x2610C40", VA = "0x182612640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x26129C0", Offset = "0x2610FC0", VA = "0x1826129C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x2612590", Offset = "0x2610B90", VA = "0x182612590")]
	private void FKHPDMCCIHA(EntityQuery OGAAEGIJKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x2610220", Offset = "0x260E820", VA = "0x182610220")]
	protected PMGDLHEJJAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000202")]
public class PKAHPJPCOMI : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public PKAHPJPCOMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000203")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class CKOEMGICLBA : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private MBKAKKEBAGC OIDCAANMDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private MCCOHLNACPH NMLCLDDPDNM;

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x27D3D30", Offset = "0x27D2330", VA = "0x1827D3D30", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x27D3DC0", Offset = "0x27D23C0", VA = "0x1827D3DC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public CKOEMGICLBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000204")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[OJJOJOKIEBL(typeof(DFALILEPNOG), new string[] { })]
internal sealed class DFALILEPNOG : LPOKOJIEHOF, EMBHBGCIFNL
{
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	[LABJLBKOJHN]
	private KKJOECNGBND JEAKBAFPNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private FEHHJLHONFC<Entity> JCPKNOEICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private CMPMKCLAGPD<BCIOGPLFNGO, MJMBIIBNCJB, OFBDJCKAPOI, IHMGEAEOPIO> GCHLEKHNNCD;

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x27D7530", Offset = "0x27D5B30", VA = "0x1827D7530", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x27D7620", Offset = "0x27D5C20", VA = "0x1827D7620", Slot = "5")]
	public void KGCINGIMMLM(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x27D7760", Offset = "0x27D5D60", VA = "0x1827D7760")]
	public Entity OPPJHONDIOF(Entity MPAGCMNFGMI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B89")]
	[Cpp2IlInjected.Address(RVA = "0x27D74D0", Offset = "0x27D5AD0", VA = "0x1827D74D0")]
	public bool HABHLECNBOO(Entity MPAGCMNFGMI, Entity EPBIFMJLJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8A")]
	[Cpp2IlInjected.Address(RVA = "0x27D7580", Offset = "0x27D5B80", VA = "0x1827D7580")]
	public bool JAMGDJKMPGM(Entity MPAGCMNFGMI, Entity EPBIFMJLJFE, bool HNOGDNKLDPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x27D72A0", Offset = "0x27D58A0", VA = "0x1827D72A0")]
	private bool EIJMDEKFDFH(Entity MPAGCMNFGMI, Entity EPBIFMJLJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public DFALILEPNOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000205")]
internal readonly struct MJGKNDCPAKB
{
	[Cpp2IlInjected.Token(Token = "0x2000206")]
	[BurstCompile]
	private struct DJMDLINAAKH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		[ReadOnly]
		public EntityTypeHandle HPHNIBNHJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		[ReadOnly]
		public ComponentDataFromEntity<KAFPLLCKBLD> AJLKEFBDFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		[ReadOnly]
		public DynamicComponentTypeHandle IJHOELDGEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> MNCKPPPAMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> OOFDLBOBGIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		[ReadOnly]
		public ComponentDataFromEntity CNMBIBNOHPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly AJEMDDCOALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		[ReadOnly]
		public NativeArray<JDOBAEGPJED>.ReadOnly JLPMIPJDICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public ComponentDataFromEntity NBBDDKAFJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public NativeList<Entity> OCPHIAAAJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public NativeList<Entity> HNFOEACBCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public NativeList<byte> IDKEMEBJLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public NativeList<byte> OFOGLFNFFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public NativeList<byte> BGJHBOFMNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public int AJHFAKMNONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int DLLLIMHAFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public bool AMGDIJPHPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public FGOEJDLKLFE.FNPAALKBFDA CFNBBPIIFMA;

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x28F08E0", Offset = "0x28EEEE0", VA = "0x1828F08E0", Slot = "4")]
		public void Execute(ArchetypeChunk FCONCDBMPAA, int GLFHEEDGKCK, int JAJGKGJOHJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x28F04C0", Offset = "0x28EEAC0", VA = "0x1828F04C0")]
		private unsafe bool BBPPJFGIEHE(Entity KNAAALKIEHE, Entity ADLHHBHAKBL, byte* HEOEMJMKBLB, byte* PDDECOOCPLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x28F0C50", Offset = "0x28EF250", VA = "0x1828F0C50")]
		private unsafe void MOAONFLIEIF(byte* HEOEMJMKBLB, byte* PDDECOOCPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x28F0700", Offset = "0x28EED00", VA = "0x1828F0700")]
		private unsafe byte* CMFCOFGPLGH(NativeArray<byte> BMIOELJAAEO, int GPAKLECDLDD)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x28F0690", Offset = "0x28EEC90", VA = "0x1828F0690")]
		private unsafe byte* BHDBABJKIAH(Entity ADLHHBHAKBL)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x28F07E0", Offset = "0x28EEDE0", VA = "0x1828F07E0")]
		private unsafe byte* EIKFGNBPKND(ArchetypeChunk FCONCDBMPAA)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x28F07A0", Offset = "0x28EEDA0", VA = "0x1828F07A0")]
		private static Entity CPHMBMOPOEP(in KAFPLLCKBLD JAIGDBINGHO)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000207")]
	[BurstCompile]
	private struct OMJAOIPBEPG : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		[ReadOnly]
		public NativeList<Entity> INPOJMEPBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		[ReadOnly]
		public NativeList<byte> KKBKJJOGPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		[ReadOnly]
		public NativeList<byte> GAMMDJIBFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		[ReadOnly]
		public NativeList<byte> DLJOEBCNOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		[ReadOnly]
		public NativeArray<JDOBAEGPJED>.ReadOnly JLPMIPJDICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public NativeParallelMultiHashMap<Entity, CBJNCBOLPDM> PNHGIJBPPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public int AJHFAKMNONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public int DLLLIMHAFHK;

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0x28FAFE0", Offset = "0x28F95E0", VA = "0x1828FAFE0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private static readonly ProfilerMarker OGGGENHMLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private readonly DIIPAOKEIKC CPDLEGJAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private readonly World IJNKKJPPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private readonly LACJKHKONMC HDLKDIFGJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private readonly NativeParallelHashMap<int, Entity> HICNCIBDEPH;

	[Cpp2IlInjected.Token(Token = "0x6000B8E")]
	[Cpp2IlInjected.Address(RVA = "0x2A85B60", Offset = "0x2A84160", VA = "0x182A85B60")]
	public MJGKNDCPAKB(DIIPAOKEIKC CPDLEGJAIIP, World IJNKKJPPAGC, MBKAKKEBAGC MHLMGNFDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8F")]
	[Cpp2IlInjected.Address(RVA = "0x2A84F20", Offset = "0x2A83520", VA = "0x182A84F20")]
	public JobHandle GFCEDFCLACE(CAODOHKABMK ILFDGGGKIBE, NativeList<(EntityQuery query, int typeIndex, int count, FGOEJDLKLFE.FNPAALKBFDA mode)> KGLOBJOCAJB, JobHandle AIKFNHNINEI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B90")]
	[Cpp2IlInjected.Address(RVA = "0x2A85A90", Offset = "0x2A84090", VA = "0x182A85A90")]
	private OMJAOIPBEPG PHMNKHKGEID(in DJMDLINAAKH JLKDLNBBHNK, NativeParallelMultiHashMap<Entity, CBJNCBOLPDM> DDIAGPALIOK)
	{
		return default(OMJAOIPBEPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B91")]
	[Cpp2IlInjected.Address(RVA = "0x2A85600", Offset = "0x2A83C00", VA = "0x182A85600")]
	private DJMDLINAAKH NNEEABDKBNH(ComponentType OLPLAHPNFFJ, EntityManager IJANLEHMIAF, int OFJEMOLEAJC, FGOEJDLKLFE.FNPAALKBFDA CFNBBPIIFMA)
	{
		return default(DJMDLINAAKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B92")]
	[Cpp2IlInjected.Address(RVA = "0x2A84DD0", Offset = "0x2A833D0", VA = "0x182A84DD0")]
	private static void CIBLLCLAANL(CAODOHKABMK ILFDGGGKIBE, ComponentType OLPLAHPNFFJ, JobHandle CJAPIGNMJBN, in DJMDLINAAKH JLKDLNBBHNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class NOPAHHGBBIP : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private KJEDAGLJFHE JEAKBAFPNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private MCCOHLNACPH NMLCLDDPDNM;

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FBB0", Offset = "0x2A8E1B0", VA = "0x182A8FBB0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x2A90A70", Offset = "0x2A8F070", VA = "0x182A90A70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x2A90B10", Offset = "0x2A8F110", VA = "0x182A90B10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F400", Offset = "0x2A8DA00", VA = "0x182A8F400")]
	private void FGBFKKCNFGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FA70", Offset = "0x2A8E070", VA = "0x182A8FA70")]
	private void FJDCNKMMIAI(NativeArray<Entity> OLBGMIBDMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2A90230", Offset = "0x2A8E830", VA = "0x182A90230")]
	private void NHGKDAEGPJD(NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FC40", Offset = "0x2A8E240", VA = "0x182A8FC40")]
	private void KFAMPABONJA(NativeArray<Entity> AJDAOFDCHNM, NativeArray<RigidTransform> NHDLLJFGOIF, NativeArray<RigidTransform> MIOFLJKOJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FDB0", Offset = "0x2A8E3B0", VA = "0x182A8FDB0")]
	private void LDINDCOLAOM(NativeArray<RigidTransform> MIOFLJKOJEE, NativeArray<Entity> AJDAOFDCHNM, NativeList<Entity> FMHIOLCOIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public NOPAHHGBBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class AKECEEFHKBA : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000BA6")]
	[Cpp2IlInjected.Address(RVA = "0x27C1D50", Offset = "0x27C0350", VA = "0x1827C1D50", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA7")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public AKECEEFHKBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020A")]
internal abstract class FDPKALFDCJN : OGKEHGMFKCC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	private MBKAKKEBAGC MHLMGNFDLIP;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	protected abstract ADMKFPPIBEF ANLHAKENMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA9")]
	[Cpp2IlInjected.Address(RVA = "0x24A9680", Offset = "0x24A7C80", VA = "0x1824A9680", Slot = "16")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x24A9AE0", Offset = "0x24A80E0", VA = "0x1824A9AE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x24A96D0", Offset = "0x24A7CD0", VA = "0x1824A96D0", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAC")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	protected FDPKALFDCJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020B")]
public class OGAJNFDCCPJ : DIIPAOKEIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private OPLBKFHGADJ NKHEOBELIKH;

	[Cpp2IlInjected.Token(Token = "0x6000BAE")]
	[Cpp2IlInjected.Address(RVA = "0x260C1E0", Offset = "0x260A7E0", VA = "0x18260C1E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAF")]
	[Cpp2IlInjected.Address(RVA = "0x260C2B0", Offset = "0x260A8B0", VA = "0x18260C2B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB0")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public OGAJNFDCCPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020C")]
[UpdateAfter(typeof(OIAMPCOHOFM))]
public class DGDIIBKLMOA : DIIPAOKEIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private EntityArchetype PBKLDKHDBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000BB1")]
	[Cpp2IlInjected.Address(RVA = "0x27D7890", Offset = "0x27D5E90", VA = "0x1827D7890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB2")]
	[Cpp2IlInjected.Address(RVA = "0x27D7980", Offset = "0x27D5F80", VA = "0x1827D7980", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB3")]
	[Cpp2IlInjected.Address(RVA = "0x27D7840", Offset = "0x27D5E40", VA = "0x1827D7840")]
	private EntityCommandBufferSystem BDPMMNOPFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB4")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public DGDIIBKLMOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020D")]
internal class JFHEMPMBLGG : KKMNKFHBJPI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200020E")]
	public struct DHLCEIBELGJ : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	protected override ComponentType MLHCMDMHHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDB90", Offset = "0x2ADC190", VA = "0x182ADDB90", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	protected override ComponentType PEHDIFADNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDB60", Offset = "0x2ADC160", VA = "0x182ADDB60", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	protected override ComponentType JKKAPJCCDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDBC0", Offset = "0x2ADC1C0", VA = "0x182ADDBC0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDC80", Offset = "0x2ADC280", VA = "0x182ADDC80")]
	public JFHEMPMBLGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020F")]
[AlwaysUpdateSystem]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class IBHHIFIHKKE : DIIPAOKEIKC, LPOKOJIEHOF, EECDFKAILMM
{
	[Cpp2IlInjected.Token(Token = "0x2000210")]
	[CompilerGenerated]
	private sealed class NCABODEEHEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public ENMPPPDAMHN localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public CNDOOEKNEFJ collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public MHHBPGDPMOE containerFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public bool physicsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public bool gravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public bool hasUnityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public IBHHIFIHKKE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NCABODEEHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x28FAB20", Offset = "0x28F9120", VA = "0x1828FAB20")]
		internal void HOOCKKPOHAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x28FAA00", Offset = "0x28F9000", VA = "0x1828FAA00")]
		internal void BOEKLKFCNHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x28FAC40", Offset = "0x28F9240", VA = "0x1828FAC40")]
		internal void NDIIIEAEOLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	[LABJLBKOJHN]
	private LJAFLCDDJAH OHNOBGPIGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	[LABJLBKOJHN]
	private HGMEOKAAKKA GEMLEDKAAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	[LABJLBKOJHN]
	private MDHPMKEGPDB AHLOBFDBJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	public ComponentTypeHandle<MHHBPGDPMOE> IENMMINAPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	public ComponentTypeHandle<AHALKBKLIJE> JABMFDLHKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	public ComponentTypeHandle<DHJHEPJCIBI> OADDCCNLDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	public ComponentTypeHandle<FLAKOIGHJDJ> LPMELCLKMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	public ComponentTypeHandle<NBHLOOFJEDB> BAHAAGNFOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	public DynamicComponentTypeHandle IBFPFEGLNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	public EntityTypeHandle APFOCJEDBKB;

	[Cpp2IlInjected.Token(Token = "0x6000BBA")]
	[Cpp2IlInjected.Address(RVA = "0x2AD68D0", Offset = "0x2AD4ED0", VA = "0x182AD68D0", Slot = "15")]
	public void ODPLCMHKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBB")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6820", Offset = "0x2AD4E20", VA = "0x182AD6820", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBC")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6990", Offset = "0x2AD4F90", VA = "0x182AD6990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBD")]
	[Cpp2IlInjected.Address(RVA = "0x2AD79E0", Offset = "0x2AD5FE0", VA = "0x182AD79E0")]
	private void PLHPLMDJPJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBE")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6510", Offset = "0x2AD4B10", VA = "0x182AD6510")]
	private bool GBHMNMBGFNG(out int JHFAKELLNGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBF")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public IBHHIFIHKKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000211")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public sealed class CCNFIHBEOND : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private IECCFLHBGNJ ODJLFIOBPAC;

	[Cpp2IlInjected.Token(Token = "0x6000BC5")]
	[Cpp2IlInjected.Address(RVA = "0x27CE590", Offset = "0x27CCB90", VA = "0x1827CE590", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC6")]
	[Cpp2IlInjected.Address(RVA = "0x27CE5F0", Offset = "0x27CCBF0", VA = "0x1827CE5F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC7")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public CCNFIHBEOND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000212")]
internal abstract class BKKPIKCCOMM : PKINIECGOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000BC8")]
	[Cpp2IlInjected.Address(RVA = "0x27C8DA0", Offset = "0x27C73A0", VA = "0x1827C8DA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC9")]
	[Cpp2IlInjected.Address(RVA = "0x27C9080", Offset = "0x27C7680", VA = "0x1827C9080", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCA")]
	[Cpp2IlInjected.Address(RVA = "0x27C9140", Offset = "0x27C7740", VA = "0x1827C9140")]
	protected BKKPIKCCOMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000213")]
[AlwaysUpdateSystem]
public class FGOEJDLKLFE : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x2000214")]
	public enum FNPAALKBFDA
	{
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		Remove
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA AINGPNAHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	[LABJLBKOJHN]
	private MBKAKKEBAGC MHLMGNFDLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private DDFJCPCGBAE DBDEFFKAABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private JMJFMCPHCCH HKICJKLLBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private GKPKCHDHCAI FJKNBBIOJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private GLKLAEGLEIJ AIBIKFOIEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	private MJGKNDCPAKB MCPHEDINDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private OACBIDKHCGE PLMDEJOIKBN;

	[Cpp2IlInjected.Token(Token = "0x6000BCB")]
	[Cpp2IlInjected.Address(RVA = "0x24AD2E0", Offset = "0x24AB8E0", VA = "0x1824AD2E0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCC")]
	[Cpp2IlInjected.Address(RVA = "0x24AD5B0", Offset = "0x24ABBB0", VA = "0x1824AD5B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCD")]
	[Cpp2IlInjected.Address(RVA = "0x24AD640", Offset = "0x24ABC40", VA = "0x1824AD640", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCE")]
	[Cpp2IlInjected.Address(RVA = "0x24AD210", Offset = "0x24AB810", VA = "0x1824AD210")]
	private void DMEFPAIPLIP(out NativeArray<EEKJFDFIEGN> OPHACLOMLBN, out NativeArray<FNDBMHENIMP> HNMKHJBPNJK, out NativeArray<EEKJFDFIEGN> KIHBDEPGKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCF")]
	[Cpp2IlInjected.Address(RVA = "0x24AD630", Offset = "0x24ABC30", VA = "0x1824AD630", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD0")]
	[Cpp2IlInjected.Address(RVA = "0x24AD620", Offset = "0x24ABC20", VA = "0x1824AD620", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD1")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public FGOEJDLKLFE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000215")]
	[CompilerGenerated]
	[AIBFCFMKILK(AGPDIMMFKMP.OMRoom)]
	public class PostLoadInitializeNetworkId : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[Cpp2IlInjected.Token(Token = "0x2000216")]
		[BurstCompile]
		[NoAlias]
		private struct PostLoadInitializeNetworkId_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x2000217")]
			public delegate void RunWithoutJobSystem_00000DE1$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000218")]
			internal static class RunWithoutJobSystem_00000DE1$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40006FC")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40006FD")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BEC")]
				[Cpp2IlInjected.Address(RVA = "0x3C13BE0", Offset = "0x3C121E0", VA = "0x183C13BE0")]
				[BurstDiscard]
				private static void ABAONOAEPNG(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BED")]
				[Cpp2IlInjected.Address(RVA = "0x3C14030", Offset = "0x3C12630", VA = "0x183C14030")]
				private static IntPtr NEJLCENAIPL()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BEE")]
				[Cpp2IlInjected.Address(RVA = "0x3C13D30", Offset = "0x3C12330", VA = "0x183C13D30")]
				public static void AHKGFJNBLNO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BEF")]
				[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
				public static void GMAKAKECEDK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BF1")]
				[Cpp2IlInjected.Address(RVA = "0x3C13DF0", Offset = "0x3C123F0", VA = "0x183C13DF0")]
				public static void JLDGENJLEHM(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006F5")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006F6")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006F7")]
			public NativeParallelHashMap<EEKJFDFIEGN, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F8")]
			public uint playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public uint offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public ComponentTypeHandle<GPFOFHIKGAP> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x3C10EC0", Offset = "0x3C0F4C0", VA = "0x183C10EC0")]
			private void DKBFAIHFAHI(Entity entity, int entityInQueryIndex, [NoAlias] ref GPFOFHIKGAP dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0x3C10F50", Offset = "0x3C0F550", VA = "0x183C10F50", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE6")]
			[Cpp2IlInjected.Address(RVA = "0x3C10E50", Offset = "0x3C0F450", VA = "0x183C10E50")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void APGMJEJLMLN(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE7")]
			[Cpp2IlInjected.Address(RVA = "0x3C11090", Offset = "0x3C0F690", VA = "0x183C11090")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void JPANCAPNHHE(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000219")]
		[NoAlias]
		[BurstCompile]
		private struct PostLoadInitializeNetworkId_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.Token(Token = "0x200021A")]
			public delegate void RunWithoutJobSystem_00000DE4$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x200021B")]
			internal static class RunWithoutJobSystem_00000DE4$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000704")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000705")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BFA")]
				[Cpp2IlInjected.Address(RVA = "0x3C14440", Offset = "0x3C12A40", VA = "0x183C14440")]
				[BurstDiscard]
				private static void ABAONOAEPNG(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BFB")]
				[Cpp2IlInjected.Address(RVA = "0x3C14890", Offset = "0x3C12E90", VA = "0x183C14890")]
				private static IntPtr NEJLCENAIPL()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BFC")]
				[Cpp2IlInjected.Address(RVA = "0x3C14590", Offset = "0x3C12B90", VA = "0x183C14590")]
				public static void AHKGFJNBLNO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BFD")]
				[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
				public static void GMAKAKECEDK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BFF")]
				[Cpp2IlInjected.Address(RVA = "0x3C14650", Offset = "0x3C12C50", VA = "0x183C14650")]
				public static void JLDGENJLEHM(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			public NativeParallelHashMap<EEKJFDFIEGN, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000701")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			public ComponentTypeHandle<GPFOFHIKGAP> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0x3C11180", Offset = "0x3C0F780", VA = "0x183C11180")]
			private void DKBFAIHFAHI(Entity entity, [NoAlias] ref GPFOFHIKGAP dstValue, [NoAlias] in OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x3C11220", Offset = "0x3C0F820", VA = "0x183C11220", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF4")]
			[Cpp2IlInjected.Address(RVA = "0x3C11110", Offset = "0x3C0F710", VA = "0x183C11110")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void APGMJEJLMLN(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF5")]
			[Cpp2IlInjected.Address(RVA = "0x3C113C0", Offset = "0x3C0F9C0", VA = "0x183C113C0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void JPANCAPNHHE(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200021C")]
		private struct PostLoadInitializeNetworkId_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000706")]
			public NativeParallelHashMap<EEKJFDFIEGN, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000707")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000708")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C00")]
			[Cpp2IlInjected.Address(RVA = "0x3C11440", Offset = "0x3C0FA40", VA = "0x183C11440")]
			private void DKBFAIHFAHI(Entity entity, in OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C01")]
			[Cpp2IlInjected.Address(RVA = "0x3C11570", Offset = "0x3C0FB70", VA = "0x183C11570", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		[LABJLBKOJHN]
		private LDONCAMGPOJ networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		[LABJLBKOJHN]
		private MKBGHPFKLIO scenes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private EntityQuery queryAllInScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private EntityQuery queryAllInActiveRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private EntityQuery additiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private EntityQuery __query_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private ComponentTypeHandle<GPFOFHIKGAP> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x261B6F0", Offset = "0x2619CF0", VA = "0x18261B6F0", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x261C580", Offset = "0x261AB80", VA = "0x18261C580", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x261C6B0", Offset = "0x261ACB0", VA = "0x18261C6B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x261B760", Offset = "0x2619D60", VA = "0x18261B760")]
		public void JELIALKIODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x261ABD0", Offset = "0x26191D0", VA = "0x18261ABD0")]
		private void EFMCBMGNBIO(NativeParallelHashMap<EEKJFDFIEGN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x261B1E0", Offset = "0x26197E0", VA = "0x18261B1E0")]
		private void IGIBHCNBGNJ(NativeParallelHashMap<EEKJFDFIEGN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x261B950", Offset = "0x2619F50", VA = "0x18261B950")]
		private void KEOEPFAPPOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x261B7D0", Offset = "0x2619DD0", VA = "0x18261B7D0")]
		private void JKMIIJOABLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x261BB70", Offset = "0x261A170", VA = "0x18261BB70")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void NPDJIHMAHAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x261B0A0", Offset = "0x26196A0", VA = "0x18261B0A0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void EKJHENMBEJI(NativeParallelHashMap<EEKJFDFIEGN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x261BB90", Offset = "0x261A190", VA = "0x18261BB90")]
		private void OHBLNNFLMFL(ref NativeParallelHashMap<EEKJFDFIEGN, Entity> map, ref uint playerId, ref uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x261B570", Offset = "0x2619B70", VA = "0x18261B570")]
		private void INIIPNIINGG(ref NativeParallelHashMap<EEKJFDFIEGN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x261BCF0", Offset = "0x261A2F0", VA = "0x18261BCF0")]
		private void OHCGCBDDCGM(ref NativeParallelHashMap<EEKJFDFIEGN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x261BDF0", Offset = "0x261A3F0", VA = "0x18261BDF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x261B190", Offset = "0x2619790", VA = "0x18261B190")]
		public static void GACAIAEOLJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x261C910", Offset = "0x261AF10", VA = "0x18261C910")]
		public static void PCDOONPJFDE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200021D")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class NCCLBGJAOGE : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	private EntityQuery OOCEOAIPFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400070B")]
	private LJIKPIOGIDO LEPADDHJBOO;

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x2A89EE0", Offset = "0x2A884E0", VA = "0x182A89EE0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x2A89F30", Offset = "0x2A88530", VA = "0x182A89F30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x2A89FE0", Offset = "0x2A885E0", VA = "0x182A89FE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C05")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public NCCLBGJAOGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021E")]
[KGDFJMDJLCH(AGPDIMMFKMP.PhotonRoom)]
[OJJOJOKIEBL(typeof(CFANJNBMIIA), new string[] { })]
internal class CJNNHCHFOOP : LPOKOJIEHOF, CFANJNBMIIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070C")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	[LABJLBKOJHN]
	private MKBGHPFKLIO CAEMHEKKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private readonly Dictionary<int, Entity> HPLPNMCECKN;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x27D2990", Offset = "0x27D0F90", VA = "0x1827D2990")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x27D2770", Offset = "0x27D0D70", VA = "0x1827D2770", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C09")]
	[Cpp2IlInjected.Address(RVA = "0x27D2800", Offset = "0x27D0E00", VA = "0x1827D2800", Slot = "5")]
	public void JPAHJPJDHJO(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0A")]
	[Cpp2IlInjected.Address(RVA = "0x27D29E0", Offset = "0x27D0FE0", VA = "0x1827D29E0", Slot = "6")]
	public bool OLJHHDOLJHL(ENMPPPDAMHN HMLJKOHAJKN, Transform DMECJMCKFAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0B")]
	[Cpp2IlInjected.Address(RVA = "0x27D2700", Offset = "0x27D0D00", VA = "0x1827D2700")]
	private bool CEAPNJOKJCL(Scene GHAEGLKDDJL, out Entity LGDGNPPBKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0C")]
	[Cpp2IlInjected.Address(RVA = "0x27D2C30", Offset = "0x27D1230", VA = "0x1827D2C30")]
	public CJNNHCHFOOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021F")]
public class HNFGNLJAICD : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	[LABJLBKOJHN]
	private MBKAKKEBAGC FJLOFMEHMAH;

	[Cpp2IlInjected.Token(Token = "0x6000C0D")]
	[Cpp2IlInjected.Address(RVA = "0x2AD60F0", Offset = "0x2AD46F0", VA = "0x182AD60F0", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6140", Offset = "0x2AD4740", VA = "0x182AD6140", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0F")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public HNFGNLJAICD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000220")]
public abstract class LCPBKGABAHD : DIIPAOKEIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem BDPMMNOPFAN();

	[Cpp2IlInjected.Token(Token = "0x6000C11")]
	[Cpp2IlInjected.Address(RVA = "0x2A75AC0", Offset = "0x2A740C0", VA = "0x182A75AC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C12")]
	[Cpp2IlInjected.Address(RVA = "0x2A75B50", Offset = "0x2A74150", VA = "0x182A75B50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C13")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	protected LCPBKGABAHD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000221")]
public struct OBBOOOFLIJP : LKDFNLJKLKK<BCIOGPLFNGO>
{
	[Cpp2IlInjected.Token(Token = "0x6000C14")]
	[Cpp2IlInjected.Address(RVA = "0x260B2F0", Offset = "0x26098F0", VA = "0x18260B2F0", Slot = "4")]
	public bool EOLIKBBBPPP(BCIOGPLFNGO MOLEJFDINLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000222")]
public static class JPKBJNCFJEP
{
	[Cpp2IlInjected.Token(Token = "0x6000C15")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8090", Offset = "0x2AE6690", VA = "0x182AE8090")]
	public static NativeParallelHashSet<int> JBIJKOOOGCE(EntityManager PHHGGAMLDGB, Allocator HINEEPDGLPG)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C16")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7ED0", Offset = "0x2AE64D0", VA = "0x182AE7ED0")]
	public static NativeParallelHashMap<int, int> GFGHCLGPOOO(EntityManager PHHGGAMLDGB, Allocator HINEEPDGLPG)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000223")]
internal readonly struct DDFJCPCGBAE
{
	[Cpp2IlInjected.Token(Token = "0x4000711")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.Token(Token = "0x4000712")]
	private static readonly ProfilerMarker OGGGENHMLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	private readonly DIIPAOKEIKC CPDLEGJAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000714")]
	private readonly World IJNKKJPPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private readonly EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private readonly EntityQuery FMAMMOKGPEA;

	[Cpp2IlInjected.Token(Token = "0x6000C17")]
	[Cpp2IlInjected.Address(RVA = "0x27D6A60", Offset = "0x27D5060", VA = "0x1827D6A60")]
	public DDFJCPCGBAE(DIIPAOKEIKC CPDLEGJAIIP, World IJNKKJPPAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C18")]
	[Cpp2IlInjected.Address(RVA = "0x27D6480", Offset = "0x27D4A80", VA = "0x1827D6480")]
	public (NativeArray<EEKJFDFIEGN>, NativeArray<FNDBMHENIMP>) GFCEDFCLACE()
	{
		return default((NativeArray<EEKJFDFIEGN>, NativeArray<FNDBMHENIMP>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000224")]
internal interface GKCMNHOMNPL
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	bool GDDAECHLOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	NativeArray<EEKJFDFIEGN> LOAIFHPHIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	NativeArray<FNDBMHENIMP> NEKBHEAMOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	NativeArray<EEKJFDFIEGN> OHLOBGHKKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LGOCKBGAFII(out NativeArray<int> INPAJCBPPEP, Allocator HINEEPDGLPG);

	[Cpp2IlInjected.Token(Token = "0x6000C1F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NMPCKDHDICL(ComponentType OLPLAHPNFFJ, out MMLPILKMICH KEGHBKCBNAE, out CLDDCIMIPFO NKKBJPEDINK);

	[Cpp2IlInjected.Token(Token = "0x6000C20")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, CBJNCBOLPDM> FKEOIAJIGHO();
}
[Cpp2IlInjected.Token(Token = "0x2000225")]
internal static class IHGFDNNONPF
{
	[Cpp2IlInjected.Token(Token = "0x6000C21")]
	[Cpp2IlInjected.Address(RVA = "0x2AD88C0", Offset = "0x2AD6EC0", VA = "0x182AD88C0")]
	public static bool NKJCNHMFIIP(this GKCMNHOMNPL ILFDGGGKIBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000226")]
[OJJOJOKIEBL(typeof(ANBDFDAFPGK), new string[] { })]
public sealed class JFDILJMFNCH : ANBDFDAFPGK, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x2000227")]
	[BurstCompile]
	private struct JEIDGLONCFN : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		[ReadOnly]
		public NativeArray<Entity> NCEOACJJMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		[ReadOnly]
		public float3 OECLNFLMOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		[ReadOnly]
		public float3 KOEICFCJCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		[ReadOnly]
		public ComponentDataFromEntity<BCIOGPLFNGO> GKPDIBBKGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		[ReadOnly]
		public ComponentDataFromEntity<JKCIFKNJAAP> KELNOADEBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> MIMILGOAEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		[ReadOnly]
		public ComponentDataFromEntity<EOJLFMPKHEN> NDBPBBOJGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		[ReadOnly]
		public ComponentDataFromEntity<FJEOOOCNEKL> KEPANENMBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		[WriteOnly]
		public NativeArray<JNJODLALMOB> KDDENIFDPEJ;

		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private static readonly JNJODLALMOB DOOLPFFCMOI;

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x28F5C10", Offset = "0x28F4210", VA = "0x1828F5C10", Slot = "4")]
		public void Execute(int OLGOBCPPPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x28F61E0", Offset = "0x28F47E0", VA = "0x1828F61E0")]
		private static float3 PIKKGALAOBK(in float4x4 DPPHOFDHKNN, in float3 GKJPNIMIKNH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x28F5AA0", Offset = "0x28F40A0", VA = "0x1828F5AA0")]
		private static float3 ALCAOBOCMAG(in float4x4 DPPHOFDHKNN, in float3 MMDGGJCJIAF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x28F60D0", Offset = "0x28F46D0", VA = "0x1828F60D0")]
		private static float3 OJFCHMAIMCF(in float4x4 DPPHOFDHKNN, in float3 GKJPNIMIKNH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2A")]
		[Cpp2IlInjected.Address(RVA = "0x28F5F00", Offset = "0x28F4500", VA = "0x1828F5F00")]
		private static float3 GNJBNDMGPHH(in float4x4 DPPHOFDHKNN, in float3 MMDGGJCJIAF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0x28F5780", Offset = "0x28F3D80", VA = "0x1828F5780")]
		private bool AECIELGOEHA(in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, in NativeArray<Entity> GJOEPHIHKOE, out float3 AAIJPFEJJAO, out float3 NGHPIMAKGOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0x28F62B0", Offset = "0x28F48B0", VA = "0x1828F62B0")]
		public static bool POIPDOFILON(in float3 LJJDOIMLHEN, in float3 KHMCJBAFNPJ, in float3 BKMPOMMOJJE, in float3 JFNMFGMAHBC, float AHPPMNOONAO, float CGGHAFJHFIN, out float KAIHGPIIHIB, out float3 LFKKIENKKGI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private EntityManager PHHGGAMLDGB;

	[Cpp2IlInjected.Token(Token = "0x6000C22")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDAD0", Offset = "0x2ADC0D0", VA = "0x182ADDAD0", Slot = "5")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C23")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD5E0", Offset = "0x2ADBBE0", VA = "0x182ADD5E0")]
	public void FEGDNOKIPAB(in NativeArray<Entity> NCEOACJJMCN, in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, in NativeArray<JNJODLALMOB> CACKIHOHHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C24")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JFDILJMFNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C25")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDB50", Offset = "0x2ADC150", VA = "0x182ADDB50", Slot = "4")]
	private void MLHNLPAPDAN(in NativeArray<Entity> NCEOACJJMCN, in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, in NativeArray<JNJODLALMOB> CACKIHOHHNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000228")]
[DefaultMember("Item")]
public struct BDGMNKDAGJD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	private T[] JAIGDBINGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	private int BFDDLCIBNMB;

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0x250DA50", Offset = "0x250C050", VA = "0x18250DA50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
public struct GPLDEABEJMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	public Entity MPAGCMNFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	public Entity ELDCHLKBIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	public Entity EPBIFMJLJFE;

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0x24BB510", Offset = "0x24B9B10", VA = "0x1824BB510")]
	public GPLDEABEJMM(Entity MPAGCMNFGMI, Entity ELDCHLKBIGE, Entity EPBIFMJLJFE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0x24BB4B0", Offset = "0x24B9AB0", VA = "0x1824BB4B0")]
	public static GPLDEABEJMM LBBGOAOJJNO((Entity entity, Entity oldParent, Entity newParent) PNJGILAIJEO)
	{
		return default(GPLDEABEJMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0x24BB4F0", Offset = "0x24B9AF0", VA = "0x1824BB4F0")]
	public void MGGDHGPEKNI(out Entity MPAGCMNFGMI, out Entity ELDCHLKBIGE, out Entity EPBIFMJLJFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022A")]
public class ANDOFCHOBLH : DIIPAOKEIKC
{
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private EntityQuery OGAAEGIJKLI;

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0x27C33F0", Offset = "0x27C19F0", VA = "0x1827C33F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0x27C34A0", Offset = "0x27C1AA0", VA = "0x1827C34A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C34")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public ANDOFCHOBLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022B")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal class AMHHCFBJAJG : EADBPNDNIAC<FIINPCOKHHA>, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private CDONNANOMBA NFFCNMOEBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400072C")]
	private EntityQuery BDMBKEAPJPE;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private Entity FPLLHBLKDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x27C2680", Offset = "0x27C0C80", VA = "0x1827C2680")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x27C2CA0", Offset = "0x27C12A0", VA = "0x1827C2CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public ENMPPPDAMHN IFICGBJLKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x27C2E20", Offset = "0x27C1420", VA = "0x1827C2E20")]
		get
		{
			return default(ENMPPPDAMHN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x27C2D00", Offset = "0x27C1300", VA = "0x1827C2D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3A")]
	[Cpp2IlInjected.Address(RVA = "0x27C3120", Offset = "0x27C1720", VA = "0x1827C3120", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3B")]
	[Cpp2IlInjected.Address(RVA = "0x27C2DB0", Offset = "0x27C13B0", VA = "0x1827C2DB0", Slot = "15")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3C")]
	[Cpp2IlInjected.Address(RVA = "0x27C31C0", Offset = "0x27C17C0", VA = "0x1827C31C0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3D")]
	[Cpp2IlInjected.Address(RVA = "0x27C26E0", Offset = "0x27C0CE0", VA = "0x1827C26E0", Slot = "14")]
	protected override void CNOIAAHCHKK(NativeArray<Entity> NCEOACJJMCN, NativeArray<Entity> MIFIHODCNOA, NativeArray<Entity> NGFGIMEBOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3E")]
	[Cpp2IlInjected.Address(RVA = "0x27C2EC0", Offset = "0x27C14C0", VA = "0x1827C2EC0")]
	private void JGOKHACEIMJ(NativeArray<Entity> NCEOACJJMCN, NativeArray<Entity> NGFGIMEBOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3F")]
	[Cpp2IlInjected.Address(RVA = "0x27C2840", Offset = "0x27C0E40", VA = "0x1827C2840")]
	private void DFPCGLAGDPD(Entity MPAGCMNFGMI, Entity AEFMGMKBMGB, Entity HCAMDIJMILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C40")]
	[Cpp2IlInjected.Address(RVA = "0xE19470", Offset = "0xE17A70", VA = "0x180E19470")]
	private bool BBDOIOJLDPI<T>(out T MOLEJFDINLH) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C41")]
	[Cpp2IlInjected.Address(RVA = "0xE19500", Offset = "0xE17B00", VA = "0x180E19500")]
	private void FIEEILGFMGJ<T>(T MOLEJFDINLH) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C42")]
	[Cpp2IlInjected.Address(RVA = "0x27C3030", Offset = "0x27C1630", VA = "0x1827C3030")]
	public bool NKBJPMPJNOC(ENMPPPDAMHN PLMOHKPJOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C43")]
	[Cpp2IlInjected.Address(RVA = "0x27C2FA0", Offset = "0x27C15A0", VA = "0x1827C2FA0")]
	private static bool LLAJBEPLFGE(ENMPPPDAMHN NMFEAMIEOPE, ENMPPPDAMHN AIPIKKGMLGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C44")]
	[Cpp2IlInjected.Address(RVA = "0x27C32D0", Offset = "0x27C18D0", VA = "0x1827C32D0")]
	public AMHHCFBJAJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022C")]
internal class FBJJGDJLHNK : BKKPIKCCOMM
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	protected override DEKJDDCLMEB BJHKELLEKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000C46")]
		[Cpp2IlInjected.Address(RVA = "0x24A4290", Offset = "0x24A2890", VA = "0x1824A4290", Slot = "15")]
		get
		{
			return default(DEKJDDCLMEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0x24A4310", Offset = "0x24A2910", VA = "0x1824A4310")]
	public FBJJGDJLHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
public class AHBCAENFDFD : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.Token(Token = "0x400072D")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	[LABJLBKOJHN]
	private MBKAKKEBAGC FJLOFMEHMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	[LABJLBKOJHN]
	private LDONCAMGPOJ DKABBECBKDF;

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0x27C0630", Offset = "0x27BEC30", VA = "0x1827C0630", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x27C0A30", Offset = "0x27BF030", VA = "0x1827C0A30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x27C06A0", Offset = "0x27BECA0", VA = "0x1827C06A0")]
	private void JMPIFMCLKEM(NativeArray<EEKJFDFIEGN> FMLOBCFBKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public AHBCAENFDFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022E")]
public class OGEOMPFKCAG : DIIPAOKEIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	private EntityQuery NCFADLMJKOM;

	[Cpp2IlInjected.Token(Token = "0x6000C4D")]
	[Cpp2IlInjected.Address(RVA = "0x260C410", Offset = "0x260AA10", VA = "0x18260C410", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4E")]
	[Cpp2IlInjected.Address(RVA = "0x260C4A0", Offset = "0x260AAA0", VA = "0x18260C4A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4F")]
	[Cpp2IlInjected.Address(RVA = "0x260C3C0", Offset = "0x260A9C0", VA = "0x18260C3C0")]
	private EntityCommandBufferSystem KDONOHLNJDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C50")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public OGEOMPFKCAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022F")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class JGDLFFFPHBN : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000C51")]
	[Cpp2IlInjected.Address(RVA = "0x2ADDDE0", Offset = "0x2ADC3E0", VA = "0x182ADDDE0", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C52")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public JGDLFFFPHBN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000230")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParent : DIIPAOKEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private static readonly IAMDAJKPFJC log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x261CBB0", Offset = "0x261B1B0", VA = "0x18261CBB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x261CC90", Offset = "0x261B290", VA = "0x18261CC90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x261C9F0", Offset = "0x261AFF0", VA = "0x18261C9F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PostLoadMoveRootsUnderParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000231")]
public struct GDJICEPBCLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	public Entity MPAGCMNFGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	public Entity HDBBNLFBJKG;

	[Cpp2IlInjected.Token(Token = "0x6000C58")]
	[Cpp2IlInjected.Address(RVA = "0x1D428D0", Offset = "0x1D40ED0", VA = "0x181D428D0")]
	public GDJICEPBCLA(Entity MPAGCMNFGMI, Entity HDBBNLFBJKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C59")]
	[Cpp2IlInjected.Address(RVA = "0x24B33E0", Offset = "0x24B19E0", VA = "0x1824B33E0")]
	public static GDJICEPBCLA LBBGOAOJJNO((Entity entity, Entity parent) PNJGILAIJEO)
	{
		return default(GDJICEPBCLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5A")]
	[Cpp2IlInjected.Address(RVA = "0x24B3410", Offset = "0x24B1A10", VA = "0x1824B3410")]
	public void MGGDHGPEKNI(out Entity MPAGCMNFGMI, out Entity HDBBNLFBJKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000232")]
[AlwaysUpdateSystem]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public class LAKFGIOGIHB : DIIPAOKEIKC, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	[LABJLBKOJHN]
	private BPFOPFGDLFP DAMMFPEMFKN;

	[Cpp2IlInjected.Token(Token = "0x6000C5B")]
	[Cpp2IlInjected.Address(RVA = "0x2A74B60", Offset = "0x2A73160", VA = "0x182A74B60", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5C")]
	[Cpp2IlInjected.Address(RVA = "0x2A74BB0", Offset = "0x2A731B0", VA = "0x182A74BB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5D")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public LAKFGIOGIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000233")]
[OJJOJOKIEBL(typeof(KNHKLDHNHAO), new string[] { })]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
internal sealed class KNHKLDHNHAO : LPOKOJIEHOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	[LABJLBKOJHN]
	private MOFMKHOGCPA DDODGIBMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private EntityQuery BLPFFBICPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private bool IBKDBEFOCFL;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2A73660", Offset = "0x2A71C60", VA = "0x182A73660")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5F")]
	[Cpp2IlInjected.Address(RVA = "0x2A73490", Offset = "0x2A71A90", VA = "0x182A73490", Slot = "4")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x2A733B0", Offset = "0x2A719B0", VA = "0x182A733B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x2A733D0", Offset = "0x2A719D0", VA = "0x182A733D0")]
	public bool GGFOGAAPHID(Entity MPAGCMNFGMI, Entity IOKDMANFCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x2A73240", Offset = "0x2A71840", VA = "0x182A73240")]
	public bool AAPAIFFLBIH(Entity MPAGCMNFGMI, Entity JNMPHJHBJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x2A73300", Offset = "0x2A71900", VA = "0x182A73300")]
	public Entity BGKMIAGKHHM(Entity MPAGCMNFGMI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x2A736B0", Offset = "0x2A71CB0", VA = "0x182A736B0")]
	public NativeArray<Entity> KKOJGPNJJPO()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x2A73590", Offset = "0x2A71B90", VA = "0x182A73590")]
	public bool JFELDPLAPKL(Entity LIGIEJOGFAH, Entity LFGKHOBDGNE, out Entity EKPEPIHNAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public KNHKLDHNHAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000234")]
internal interface PMDMEBKMCNG
{
	[Cpp2IlInjected.Token(Token = "0x17000154")]
	World FKLPOCBLLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	World DFLOMKCOJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	LACJKHKONMC JOOEMNOPCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	uint IAIKLPLKODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000235")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplines : DIIPAOKEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x2000236")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400073E")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400073F")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F340", Offset = "0x3C0D940", VA = "0x183C0F340")]
			private void DKBFAIHFAHI(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F3D0", Offset = "0x3C0D9D0", VA = "0x183C0F3D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000237")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000740")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000741")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000742")]
			[ReadOnly]
			public ComponentTypeHandle<PCNIEMKNHNM> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C76")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F480", Offset = "0x3C0DA80", VA = "0x183C0F480")]
			private void DKBFAIHFAHI(Entity splinePoint, [NoAlias] in PCNIEMKNHNM splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C77")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F510", Offset = "0x3C0DB10", VA = "0x183C0F510", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private ComponentTypeHandle<PCNIEMKNHNM> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2615E20", Offset = "0x2614420", VA = "0x182615E20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x2615ED0", Offset = "0x26144D0", VA = "0x182615ED0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2615830", Offset = "0x2613E30", VA = "0x182615830")]
		private EntityCommandBufferSystem BDPMMNOPFAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x26159D0", Offset = "0x2613FD0", VA = "0x1826159D0")]
		private void IBPENNPBKHK(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2615880", Offset = "0x2613E80", VA = "0x182615880")]
		private void HHDLHGBEJCG(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x2615AD0", Offset = "0x26140D0", VA = "0x182615AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public PostDeserializeAddSplinePointsToSplines()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000238")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
	public class UpdateSplineGameCollidersSystem : DIIPAOKEIKC, LPOKOJIEHOF
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000239")]
		public struct SplineGameCollisionSystemTag : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200023A")]
		private struct ProcessCollisionModeChangesForSplineGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000751")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000752")]
			[ReadOnly]
			public ComponentDataFromEntity<DKMEAPNDDIB> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000753")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000754")]
			[ReadOnly]
			public ComponentTypeHandle<AHALKBKLIJE> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000755")]
			public BufferTypeHandle<IHMGEAEOPIO> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x3C11FF0", Offset = "0x3C105F0", VA = "0x183C11FF0")]
			private void DKBFAIHFAHI(in AHALKBKLIJE collisionMode, DynamicBuffer<IHMGEAEOPIO> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C87")]
			[Cpp2IlInjected.Address(RVA = "0x3C12340", Offset = "0x3C10940", VA = "0x183C12340", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023B")]
		private struct ProcessActiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000756")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000757")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			[ReadOnly]
			public ComponentDataFromEntity<AHALKBKLIJE> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400075A")]
			[ReadOnly]
			public ComponentTypeHandle<BCIOGPLFNGO> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C88")]
			[Cpp2IlInjected.Address(RVA = "0x3C11E10", Offset = "0x3C10410", VA = "0x183C11E10")]
			private void DKBFAIHFAHI(Entity entity, in BCIOGPLFNGO parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C89")]
			[Cpp2IlInjected.Address(RVA = "0x3C11ED0", Offset = "0x3C104D0", VA = "0x183C11ED0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023C")]
		private struct ProcessInactiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400075B")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400075C")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400075D")]
			[ReadOnly]
			public ComponentDataFromEntity<AHALKBKLIJE> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400075E")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400075F")]
			[ReadOnly]
			public ComponentTypeHandle<BCIOGPLFNGO> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C8A")]
			[Cpp2IlInjected.Address(RVA = "0x3C124B0", Offset = "0x3C10AB0", VA = "0x183C124B0")]
			private void DKBFAIHFAHI(Entity entity, in BCIOGPLFNGO parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C8B")]
			[Cpp2IlInjected.Address(RVA = "0x3C12560", Offset = "0x3C10B60", VA = "0x183C12560", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023D")]
		private struct UpdateSplineGameCollidersSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000760")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000761")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000762")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C8C")]
			[Cpp2IlInjected.Address(RVA = "0x3C15E90", Offset = "0x3C14490", VA = "0x183C15E90")]
			private void DKBFAIHFAHI(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0x3C15F10", Offset = "0x3C14510", VA = "0x183C15F10", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023E")]
		private struct ProcessSplineEditsForGameCollision_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x4000763")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000764")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000765")]
			[ReadOnly]
			public ComponentTypeHandle<PCNIEMKNHNM> splinePointParentHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000766")]
			[ReadOnly]
			public EntityTypeHandle entityHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000768")]
			public EntityQueryInJob splinePointEditedQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000769")]
			public EntityQueryInJob splineStructureChangedQueryInJob;

			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x3C126E0", Offset = "0x3C10CE0", VA = "0x183C126E0")]
			private void DKBFAIHFAHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x3C12C50", Offset = "0x3C11250", VA = "0x183C12C50", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0x3C12680", Offset = "0x3C10C80", VA = "0x183C12680")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void APGMJEJLMLN(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private HNNPHIGJKMK splineCollisionService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private EntityQuery collisionModeChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private EntityQuery activeSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private EntityQuery inactiveSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private EntityQuery splinePointEditedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private EntityQuery splineStructureChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private EntityQuery splinesDeletedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		private EntityQuery ProcessCollisionModeChangesForSplineGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private EntityQuery ProcessActiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private EntityQuery ProcessInactiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private EntityQuery UpdateSplineGameCollidersSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private ComponentTypeHandle<AHALKBKLIJE> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private ComponentTypeHandle<BCIOGPLFNGO> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x28FCDE0", Offset = "0x28FB3E0", VA = "0x1828FCDE0", Slot = "14")]
		public void InitReferences(LIFCBCFOLBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x28FDE90", Offset = "0x28FC490", VA = "0x1828FDE90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x28FE060", Offset = "0x28FC660", VA = "0x1828FE060", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x28FCFA0", Offset = "0x28FB5A0", VA = "0x1828FCFA0")]
		private void JFFIGIBJFPO(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x28FC970", Offset = "0x28FAF70", VA = "0x1828FC970")]
		private void EHPBIFAPHCD(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x28FCC30", Offset = "0x28FB230", VA = "0x1828FCC30")]
		private void IDODFICGKDG(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x28FC710", Offset = "0x28FAD10", VA = "0x1828FC710")]
		private void AFJBNHPLCKK(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x28FD300", Offset = "0x28FB900", VA = "0x1828FD300")]
		private void NOFDIBLFDFD(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<DKMEAPNDDIB> splineComponentAccess, ref ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x28FCE30", Offset = "0x28FB430", VA = "0x1828FCE30")]
		private void JEJEIFEKKPM(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<AHALKBKLIJE> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x28FC800", Offset = "0x28FAE00", VA = "0x1828FC800")]
		private void AFPPKJPMMHD(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<AHALKBKLIJE> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0x28FD4F0", Offset = "0x28FBAF0", VA = "0x1828FD4F0")]
		private void OIKHCAFIOOA(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0x28FD1C0", Offset = "0x28FB7C0", VA = "0x1828FD1C0")]
		private void NKDLHEJFODM(ref ComponentTypeHandle<PCNIEMKNHNM> splinePointParentHandle, ref EntityTypeHandle entityHandle, ref ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, ref EntityQueryInJob splinePointEditedQueryInJob, ref EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0x28FD5E0", Offset = "0x28FBBE0", VA = "0x1828FD5E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200023F")]
public sealed class BKAMJIFKFIE : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000C91")]
	[Cpp2IlInjected.Address(RVA = "0x27C8670", Offset = "0x27C6C70", VA = "0x1827C8670", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C92")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public BKAMJIFKFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000240")]
[ExecuteAlways]
public class MGADNIHEIDB : IHADAAMNPBN
{
	[Cpp2IlInjected.Token(Token = "0x6000C93")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	public MGADNIHEIDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
public sealed class EMEPBJACFME : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000C94")]
	[Cpp2IlInjected.Address(RVA = "0x24A13E0", Offset = "0x249F9E0", VA = "0x1824A13E0", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C95")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public EMEPBJACFME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
public class ODABGJKIBOE : AEKGPLOBAHI, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400076A")]
	private MKBGHPFKLIO HLHINDIFOED;

	[Cpp2IlInjected.Token(Token = "0x6000C96")]
	[Cpp2IlInjected.Address(RVA = "0x260B480", Offset = "0x2609A80", VA = "0x18260B480", Slot = "14")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C97")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public ODABGJKIBOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class LIBMLMOHFBM : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x2A79E90", Offset = "0x2A78490", VA = "0x182A79E90", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public LIBMLMOHFBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
internal class KIKCPAEMCMD : FDPKALFDCJN
{
	[Cpp2IlInjected.Token(Token = "0x17000159")]
	protected override ADMKFPPIBEF ANLHAKENMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x8C58E0", Offset = "0x8C3EE0", VA = "0x1808C58E0", Slot = "17")]
		get
		{
			return default(ADMKFPPIBEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x2AED1C0", Offset = "0x2AEB7C0", VA = "0x182AED1C0")]
	public KIKCPAEMCMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
public sealed class OHPPBGHPLJP : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x260C800", Offset = "0x260AE00", VA = "0x18260C800", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public OHPPBGHPLJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000246")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class AMLDBHGLIBB : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x27C3310", Offset = "0x27C1910", VA = "0x1827C3310", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public AMLDBHGLIBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
[BEPOGFEHFHC(typeof(OGEEBLLKOPC))]
public sealed class IAAEGDLIPIH : NHJIHJNKBGF
{
	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6380", Offset = "0x2AD4980", VA = "0x182AD6380", Slot = "8")]
	protected override bool PGJCKELNAHG(ReadOnlySpan<OGEEBLLKOPC> NCBGBGGOJOG, LFPMKGDJPHH IMICHANCJBJ, out ReadOnlySpan<byte> NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x2AD62C0", Offset = "0x2AD48C0", VA = "0x182AD62C0", Slot = "9")]
	protected override bool ICFKHIBHCNH(int MPNDOHBKHJO, Span<OGEEBLLKOPC> NCBGBGGOJOG, in ReadOnlySpan<byte> NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6400", Offset = "0x2AD4A00", VA = "0x182AD6400")]
	public IAAEGDLIPIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
[BEPOGFEHFHC(typeof(JLEHAKNHCDI))]
public sealed class BDOJBLNIMMG : LEBPAAPNFEL
{
	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x27C4E40", Offset = "0x27C3440", VA = "0x1827C4E40", Slot = "8")]
	protected override bool PGJCKELNAHG(ReadOnlySpan<JLEHAKNHCDI> NCBGBGGOJOG, LFPMKGDJPHH IMICHANCJBJ, out ReadOnlySpan<byte> NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x27C4D80", Offset = "0x27C3380", VA = "0x1827C4D80", Slot = "9")]
	protected override bool ICFKHIBHCNH(int MPNDOHBKHJO, Span<JLEHAKNHCDI> NCBGBGGOJOG, in ReadOnlySpan<byte> NFNCBDOMNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x27C4EC0", Offset = "0x27C34C0", VA = "0x1827C4EC0")]
	public BDOJBLNIMMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000249")]
[AIBFCFMKILK(AGPDIMMFKMP.LoadInstance)]
internal sealed class FAHPGKPKNHP : OGKEHGMFKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x24A2D20", Offset = "0x24A1320", VA = "0x1824A2D20", Slot = "15")]
	protected override ComponentSystemBase LKCJPAMAHDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public FAHPGKPKNHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
internal class INNKAJCLDOE : GHDAJGIMJFL
{
	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x24A11C0", Offset = "0x249F7C0", VA = "0x1824A11C0")]
	public INNKAJCLDOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024B")]
[OJJOJOKIEBL(typeof(EMLPEGCKBCF), new string[] { })]
public sealed class JKNAPPHLCMI : EMLPEGCKBCF, LPOKOJIEHOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400076B")]
	private NAKDAPLIPPO BDAGOAAJLAM;

	[Cpp2IlInjected.Token(Token = "0x6000CAA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3100", Offset = "0x2AE1700", VA = "0x182AE3100", Slot = "5")]
	public void InitReferences(LIFCBCFOLBC CBMJEICKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3020", Offset = "0x2AE1620", VA = "0x182AE3020")]
	public bool FEGDNOKIPAB(in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, float JOJFLKALKOE, Allocator HINEEPDGLPG, out NativeArray<Entity> NCEOACJJMCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JKNAPPHLCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAD")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3020", Offset = "0x2AE1620", VA = "0x182AE3020", Slot = "4")]
	private bool CJBPLMFJPBJ(in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, float JOJFLKALKOE, Allocator HINEEPDGLPG, out NativeArray<Entity> NCEOACJJMCN)
	{
		return default(bool);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200024C")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : KHJNECAEAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAF")]
		[Cpp2IlInjected.Address(RVA = "0x2901350", Offset = "0x28FF950", VA = "0x182901350", Slot = "6")]
		public sealed override void LDMPECOOOEM(CIILENBPBII AJNAMFOHMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x2901150", Offset = "0x28FF750", VA = "0x182901150", Slot = "4")]
		public sealed override void HLIMFKHODMA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200024D")]
internal class __UnmanagedPostProcessorOutput__3051310927
{
	[Cpp2IlInjected.Token(Token = "0x6000CB1")]
	[Cpp2IlInjected.Address(RVA = "0x2903A70", Offset = "0x2902070", VA = "0x182903A70")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024E")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3051310927
{
	[Cpp2IlInjected.Token(Token = "0x6000CB2")]
	[Cpp2IlInjected.Address(RVA = "0x29024C0", Offset = "0x2900AC0", VA = "0x1829024C0")]
	public static void BBFJPKGOMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2903A60", Offset = "0x2902060", VA = "0x182903A60")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024F")]
internal class GLMBEOJNHMK : ContainerPropertyBag<NBNGAHFIHPP>
{
	[Cpp2IlInjected.Token(Token = "0x2000250")]
	private class MFDICNOEHNI : Property<NBNGAHFIHPP, FCLHKJAHMCN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB5")]
			[Cpp2IlInjected.Address(RVA = "0x28FA250", Offset = "0x28F8850", VA = "0x1828FA250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB6")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB7")]
		[Cpp2IlInjected.Address(RVA = "0x28FA210", Offset = "0x28F8810", VA = "0x1828FA210")]
		public MFDICNOEHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1C0", Offset = "0x28F87C0", VA = "0x1828FA1C0", Slot = "14")]
		public override FCLHKJAHMCN GetValue(ref NBNGAHFIHPP IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB9")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1E0", Offset = "0x28F87E0", VA = "0x1828FA1E0", Slot = "15")]
		public override void SetValue(ref NBNGAHFIHPP IBEPDAFMEAD, FCLHKJAHMCN MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x24B87E0", Offset = "0x24B6DE0", VA = "0x1824B87E0")]
	public GLMBEOJNHMK()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000251")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000CBA")]
		[Cpp2IlInjected.Address(RVA = "0x261F850", Offset = "0x261DE50", VA = "0x18261F850")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000252")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x27DB110", Offset = "0x27D9710", VA = "0x1827DB110")]
	[RuntimeInitializeOnLoadMethod]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000253")]
public class JCIBJNJLFPG
{
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JCIBJNJLFPG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000254")]
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
