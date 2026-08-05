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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x18FB810", Offset = "0x18FAA10", VA = "0x1818FB810")]
		public static HMLOAEDBHLH<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(HMLOAEDBHLH<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct FOEEJHELHHN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LMEPOJGEOJO]
public static class FNBBCMCALPM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27C9BE0", Offset = "0x27C8DE0", VA = "0x1827C9BE0")]
	static FNBBCMCALPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E23340", Offset = "0x1E22540", VA = "0x181E23340")]
	public static void GPOHNMGDBID<T>(T LBIBKCFHCIL, ref T GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27C9720", Offset = "0x27C8920", VA = "0x1827C9720")]
	public static void GPOHNMGDBID(FixedString32Bytes LBIBKCFHCIL, ref string GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27C9750", Offset = "0x27C8950", VA = "0x1827C9750")]
	public static void GPOHNMGDBID(string LBIBKCFHCIL, ref FixedString32Bytes GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27C9BB0", Offset = "0x27C8DB0", VA = "0x1827C9BB0")]
	public static void GPOHNMGDBID(FixedString64Bytes LBIBKCFHCIL, ref string GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x27C9810", Offset = "0x27C8A10", VA = "0x1827C9810")]
	public static void GPOHNMGDBID(string LBIBKCFHCIL, ref FixedString64Bytes GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27C9B60", Offset = "0x27C8D60", VA = "0x1827C9B60")]
	public static void GPOHNMGDBID(AEONHEPPMGP LBIBKCFHCIL, ref Vector3 GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27C9790", Offset = "0x27C8990", VA = "0x1827C9790")]
	public static void GPOHNMGDBID(Vector3 LBIBKCFHCIL, ref AEONHEPPMGP GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27C9900", Offset = "0x27C8B00", VA = "0x1827C9900")]
	public static void GPOHNMGDBID(PAIPNEJMMNE LBIBKCFHCIL, ref Vector4 GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27C9870", Offset = "0x27C8A70", VA = "0x1827C9870")]
	public static void GPOHNMGDBID(Vector4 LBIBKCFHCIL, ref PAIPNEJMMNE GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27C9900", Offset = "0x27C8B00", VA = "0x1827C9900")]
	public static void GPOHNMGDBID(PAIPNEJMMNE LBIBKCFHCIL, ref Quaternion GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27C9870", Offset = "0x27C8A70", VA = "0x1827C9870")]
	public static void GPOHNMGDBID(Quaternion LBIBKCFHCIL, ref PAIPNEJMMNE GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27C9AF0", Offset = "0x27C8CF0", VA = "0x1827C9AF0")]
	public static void GPOHNMGDBID(AEONHEPPMGP LBIBKCFHCIL, ref float3 GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27C9790", Offset = "0x27C8990", VA = "0x1827C9790")]
	public static void GPOHNMGDBID(float3 LBIBKCFHCIL, ref AEONHEPPMGP GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x27C99E0", Offset = "0x27C8BE0", VA = "0x1827C99E0")]
	public static void GPOHNMGDBID(PAIPNEJMMNE LBIBKCFHCIL, ref float4 GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27C9870", Offset = "0x27C8A70", VA = "0x1827C9870")]
	public static void GPOHNMGDBID(float4 LBIBKCFHCIL, ref PAIPNEJMMNE GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27C99E0", Offset = "0x27C8BE0", VA = "0x1827C99E0")]
	public static void GPOHNMGDBID(PAIPNEJMMNE LBIBKCFHCIL, ref quaternion GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x27C9960", Offset = "0x27C8B60", VA = "0x1827C9960")]
	public static void GPOHNMGDBID(quaternion LBIBKCFHCIL, ref PAIPNEJMMNE GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x27C9A80", Offset = "0x27C8C80", VA = "0x1827C9A80")]
	public static void GPOHNMGDBID(Entity LBIBKCFHCIL, ref HAOLCPCNAMG GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x27C9AC0", Offset = "0x27C8CC0", VA = "0x1827C9AC0")]
	public static void GPOHNMGDBID(HAOLCPCNAMG LBIBKCFHCIL, ref Entity GLDKECDCJGE, NKGDHPLFPDK DJHOCJBGPEK)
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
		public SerializableGuid HEIKMODINOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA1FE10", Offset = "0xA1F010", VA = "0x180A1FE10")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2467260", Offset = "0x2466460", VA = "0x182467260")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DefaultMember("Item")]
[DDDGJOKMEDO(typeof(JOHINJPAKCH), new string[] { })]
public class KMGJBFMJKOE : JOHINJPAKCH, IEnumerable<GHANKHPHMBP>, IEnumerable, OHFLHEPJPJP, PNKPNDDLHPG, DCLDDNDKGBL, PJIPLCPBFIL, ANJJHLMIOKD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[MOHONECELPE]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[MOHONECELPE]
	private EIFIFHHKJPI NPHDLLPIABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private GHANKHPHMBP[] OKOILBCEPLO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x25C0510", Offset = "0x25BF710", VA = "0x1825C0510", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GHANKHPHMBP JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x25C0170", Offset = "0x25BF370", VA = "0x1825C0170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "10")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x25C0280", Offset = "0x25BF480", VA = "0x1825C0280", Slot = "11")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "12")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x25C0520", Offset = "0x25BF720", VA = "0x1825C0520", Slot = "6")]
	public GHANKHPHMBP LMABDHPJKGG(FAODENBHDMK LPNKBGEMCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25C01B0", Offset = "0x25BF3B0", VA = "0x1825C01B0", Slot = "7")]
	public MCNHINHNBBI HKIJCBIHCIH(FAODENBHDMK LPNKBGEMCBF)
	{
		return default(MCNHINHNBBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x25C0090", Offset = "0x25BF290", VA = "0x1825C0090", Slot = "8")]
	public IEnumerator<GHANKHPHMBP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x25C0650", Offset = "0x25BF850", VA = "0x1825C0650", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6500", Offset = "0x1CD5700", VA = "0x181CD6500", Slot = "13")]
	public void NDCMNMAJOBE<TKey, T>(FLNCDPNCALM<TKey, T> BGOCDAGKFNE, [Optional] object JDFBABENAGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x25BFF50", Offset = "0x25BF150", VA = "0x1825BFF50", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public KMGJBFMJKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25C0170", Offset = "0x25BF370", VA = "0x1825C0170")]
	[CompilerGenerated]
	private GHANKHPHMBP HAEGPFAOCPG(int LHPGLCOPMKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DDDGJOKMEDO(typeof(HNMHAJLPHMH), new string[] { })]
[KFAABLOJCJD(typeof(MLNEJMIMNEF))]
public class MLNEJMIMNEF : HNMHAJLPHMH, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PEKDFCFCENH ALOEPPCDEGE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly PEKDFCFCENH FADLBCAIIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HJKDEOOCPAC CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private JKNDJOAONLH FMLLOEFLKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private ALOPNKJDLEE HBHMCMADCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private IBMCNLNFCOD POGALJMHEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private MGGGBEIHFIJ KMCFNHCIMAG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private EntityManager NMHMIPEFENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2A91FE0", Offset = "0x2A911E0", VA = "0x182A91FE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2A91220", Offset = "0x2A90420", VA = "0x182A91220", Slot = "34")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2A91040", Offset = "0x2A90240", VA = "0x182A91040", Slot = "35")]
	public bool IOELLMAPGAA(Transform LNNHFELGMNI, out BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2A92CE0", Offset = "0x2A91EE0", VA = "0x182A92CE0", Slot = "36")]
	public Transform PPPHIBONNGL(Entity BLNICJMKCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A901B0", Offset = "0x2A8F3B0", VA = "0x182A901B0", Slot = "31")]
	public bool ELAJOLEBEAL(Entity BLNICJMKCEF, out Transform LNNHFELGMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A90E50", Offset = "0x2A90050", VA = "0x182A90E50")]
	private void ICCDIOBDONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2A923A0", Offset = "0x2A915A0", VA = "0x182A923A0", Slot = "30")]
	public void MNMJOEKBIGF(Entity BLNICJMKCEF, out float4x4 BMFIICIOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A92700", Offset = "0x2A91900", VA = "0x182A92700", Slot = "4")]
	public void OBGPJNHGHCH(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2A92460", Offset = "0x2A91660", VA = "0x182A92460", Slot = "28")]
	public void NCGBHDOACHC(Entity BLNICJMKCEF, out float4x4 BMFIICIOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FDA0", Offset = "0x2A8EFA0", VA = "0x182A8FDA0")]
	public void EAIMFEAJCJB(Entity BLNICJMKCEF, in float4x4 BMFIICIOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2A90900", Offset = "0x2A8FB00", VA = "0x182A90900")]
	public void PFJMDJGLEDF(Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EEC0", Offset = "0x2A8E0C0", VA = "0x182A8EEC0", Slot = "6")]
	public float3 ACMHBINOKCP(Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2A90E70", Offset = "0x2A90070", VA = "0x182A90E70")]
	public void IKOIHALOCIP(Entity BLNICJMKCEF, in quaternion NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2A90A50", Offset = "0x2A8FC50", VA = "0x182A90A50", Slot = "8")]
	public quaternion HMFNAHFKGJD(Entity BLNICJMKCEF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A902B0", Offset = "0x2A8F4B0", VA = "0x182A902B0")]
	public void FCAHDNKELNN(Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A8ECF0", Offset = "0x2A8DEF0", VA = "0x182A8ECF0", Slot = "12")]
	public float3 ACMFOJKOGHF(Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A90810", Offset = "0x2A8FA10", VA = "0x182A90810", Slot = "15")]
	public float GKKLEPNPMII(Entity BLNICJMKCEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A903F0", Offset = "0x2A8F5F0", VA = "0x182A903F0", Slot = "14")]
	public void FKPDMGOHFMC(Entity BLNICJMKCEF, float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A91E10", Offset = "0x2A91010", VA = "0x182A91E10", Slot = "17")]
	public float3 KNPJMCMOEDL(Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A92200", Offset = "0x2A91400", VA = "0x182A92200")]
	public void MOPJNNFCKCP(Entity BLNICJMKCEF, in float3 IJMILJJGNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A91AD0", Offset = "0x2A90CD0", VA = "0x182A91AD0", Slot = "9")]
	public void KANMFOJNIKE(Entity BLNICJMKCEF, out float3 BOEKENJNLKP, out quaternion ELGEECMLAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A918B0", Offset = "0x2A90AB0", VA = "0x182A918B0", Slot = "10")]
	public void KANMFOJNIKE(Entity BLNICJMKCEF, out RigidTransform JMLNOEBANEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F570", Offset = "0x2A8E770", VA = "0x182A8F570", Slot = "37")]
	public void BGAMEEBKDIH(Entity BLNICJMKCEF, out float3 BOEKENJNLKP, out quaternion ELGEECMLAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F3F0", Offset = "0x2A8E5F0", VA = "0x182A8F3F0", Slot = "11")]
	public void BGAMEEBKDIH(Entity BLNICJMKCEF, out RigidTransform JMLNOEBANEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A905E0", Offset = "0x2A8F7E0", VA = "0x182A905E0")]
	public void FLCLONCKBII(Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A929F0", Offset = "0x2A91BF0", VA = "0x182A929F0", Slot = "19")]
	public float3 OFCLBOMLFLK(Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A90080", Offset = "0x2A8F280", VA = "0x182A90080")]
	public void ECHMCPKNDDE(Entity BLNICJMKCEF, in quaternion NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A91CF0", Offset = "0x2A90EF0", VA = "0x182A91CF0", Slot = "21")]
	public quaternion KBPBNFKMDEB(Entity BLNICJMKCEF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F6F0", Offset = "0x2A8E8F0", VA = "0x182A8F6F0")]
	public void CEKLBAMACNE(Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FA00", Offset = "0x2A8EC00", VA = "0x182A8FA00", Slot = "22")]
	public float3 CPIGLLAIOHB(Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2A90C10", Offset = "0x2A8FE10", VA = "0x182A90C10", Slot = "24")]
	public void HOLBLMIEKBF(Entity BLNICJMKCEF, float IHNHFHPFFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F910", Offset = "0x2A8EB10", VA = "0x182A8F910", Slot = "25")]
	public float CJJFPGBIEOK(Entity BLNICJMKCEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F0B0", Offset = "0x2A8E2B0", VA = "0x182A8F0B0")]
	public void BDONNKCHBEP(Entity BLNICJMKCEF, in float3 GDAFEFPAMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2A92B20", Offset = "0x2A91D20", VA = "0x182A92B20", Slot = "27")]
	public float3 OFJJPGKOJOP(Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A91330", Offset = "0x2A90530", VA = "0x182A91330", Slot = "32")]
	public void JANNHKCNGPB(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2A90720", Offset = "0x2A8F920", VA = "0x182A90720")]
	private BMDJOHDFBDL GFODPEEAADG(Transform LNNHFELGMNI)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FB30", Offset = "0x2A8ED30", VA = "0x182A8FB30")]
	private static TransformEntity DDLKMNEAEMN(IANCKMHPHEB FBNKHAJKFLM, GameObject AEMIIPGDKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x124A320", Offset = "0x1249520", VA = "0x18124A320")]
	private static T DGIKHFKAMEF<T>(GameObject AEMIIPGDKOE) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2A925E0", Offset = "0x2A917E0", VA = "0x182A925E0", Slot = "33")]
	public void NOFCIMJIFCL(Entity BLNICJMKCEF, Entity IFMGHGFKKAF, Entity PCCOHMIFFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MLNEJMIMNEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A90900", Offset = "0x2A8FB00", VA = "0x182A90900", Slot = "5")]
	private void GLGKKNGLOKA(Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A92030", Offset = "0x2A91230", VA = "0x182A92030", Slot = "7")]
	private void LCOEINKBOGM(Entity BLNICJMKCEF, in quaternion NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A902B0", Offset = "0x2A8F4B0", VA = "0x182A902B0", Slot = "13")]
	private void HMPJHBBACDM(Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A92200", Offset = "0x2A91400", VA = "0x182A92200", Slot = "16")]
	private void LPKNIDFBBPC(Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A905E0", Offset = "0x2A8F7E0", VA = "0x182A905E0", Slot = "18")]
	private void KKMENCCLGLG(Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A90080", Offset = "0x2A8F280", VA = "0x182A90080", Slot = "20")]
	private void MNGCDJHEKPM(Entity BLNICJMKCEF, in quaternion NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A90A40", Offset = "0x2A8FC40", VA = "0x182A90A40", Slot = "23")]
	private void HCLHGKOEKEG(Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A918A0", Offset = "0x2A90AA0", VA = "0x182A918A0", Slot = "26")]
	private void JHEEPLECNLB(Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A90800", Offset = "0x2A8FA00", VA = "0x182A90800", Slot = "29")]
	private void GIFPMGDPOBK(Entity BLNICJMKCEF, in float4x4 CELAMPCHIFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NNDIAIIJGEM
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class OMPNMJPGFEG : GGMDGLIEABN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string HLHDHLOJEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly OMPNMJPGFEG GPCKMMJANLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly List<OMPNMJPGFEG> JDFJBPPENCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly List<HADCJDEHJDC> EAAEGPDMONP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string CFMIKOIFIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GGMDGLIEABN NNONAMBMKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<GGMDGLIEABN> EIOPDDCPIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D150", Offset = "0x2A9C350", VA = "0x182A9D150")]
	public OMPNMJPGFEG(string JPKENOAMLIN, OMPNMJPGFEG OJEMCPHOKBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DDDGJOKMEDO(typeof(COAPHLBOHFB), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
internal class COAPHLBOHFB : PNKPNDDLHPG
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2631F00", Offset = "0x2631100", VA = "0x182631F00", Slot = "4")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public COAPHLBOHFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DDDGJOKMEDO(typeof(DDHMFKIBELN), new string[] { })]
public class PKMJFNINOOJ : DCLDDNDKGBL, DDHMFKIBELN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private FOEBEFHCPPN IHKDFCCKBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private EIKGLGIJAHC CLOALEEOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2455930", Offset = "0x2454B30", VA = "0x182455930", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2455730", Offset = "0x2454930", VA = "0x182455730", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2455A00", Offset = "0x2454C00", VA = "0x182455A00", Slot = "5")]
	public bool PHBLIOAHLKM(BMDJOHDFBDL JHJPAJMEGAG, out Collider NAKCMDMIPAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2455740", Offset = "0x2454940", VA = "0x182455740", Slot = "6")]
	public GameObject HHINJPNHDNM(BMDJOHDFBDL BGLAACKDGIN, GameObject POGNPIAMOGA, Vector3 DGDMDKFMBBA, Quaternion KGFPECIFPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2455630", Offset = "0x2454830", VA = "0x182455630", Slot = "7")]
	public void BAFGGJCGLJM(GameObject NAKCMDMIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x234BCB0", Offset = "0x234AEB0", VA = "0x18234BCB0", Slot = "8")]
	public TCollider JKBAICIJLLE<TCollider>(GameObject BKGNPKPLLFD) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x24556D0", Offset = "0x24548D0", VA = "0x1824556D0", Slot = "9")]
	public void BIMNLOHMINO(Collider NAKCMDMIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x234BD70", Offset = "0x234AF70", VA = "0x18234BD70", Slot = "10")]
	public GameObject KPDGEBPAHOG<TCollider>(string JPKENOAMLIN) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public PKMJFNINOOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MACJANEDPGE
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MODEADMIGAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeList<DFKKJKBKACB> HHEOCKKODBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NativeList<PPIJPPICKFO> GBJFIOPPNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private NativeList<FCIJDIMNMDP> LPABNDIAFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NativeList<PPIJPPICKFO> OOONAMIJMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NativeList<DFKKJKBKACB> ONKLDDMDBKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x99B850", Offset = "0x99AA50", VA = "0x18099B850")]
		get
		{
			return default(NativeList<DFKKJKBKACB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NativeList<PPIJPPICKFO> JCHHJDGDMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99B860", Offset = "0x99AA60", VA = "0x18099B860")]
		get
		{
			return default(NativeList<PPIJPPICKFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<FCIJDIMNMDP> FIGMEBPENLL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xD0D200", Offset = "0xD0C400", VA = "0x180D0D200")]
		get
		{
			return default(NativeList<FCIJDIMNMDP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NativeList<PPIJPPICKFO> FNKPNPHGAND
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x99B880", Offset = "0x99AA80", VA = "0x18099B880")]
		get
		{
			return default(NativeList<PPIJPPICKFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JobHandle DBKHDKLGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x13EDE30", Offset = "0x13ED030", VA = "0x1813EDE30")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x13EC800", Offset = "0x13EBA00", VA = "0x1813EC800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GEMBAHNAMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A93C10", Offset = "0x2A92E10", VA = "0x182A93C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2A93D60", Offset = "0x2A92F60", VA = "0x182A93D60")]
	public MODEADMIGAP(Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2A93CD0", Offset = "0x2A92ED0", VA = "0x182A93CD0")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A93AE0", Offset = "0x2A92CE0", VA = "0x182A93AE0")]
	public void DFBADGMPLED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2A93790", Offset = "0x2A92990", VA = "0x182A93790")]
	public void CKPKOIJGHLD(Entity BLNICJMKCEF, Entity IFMGHGFKKAF, Entity PCCOHMIFFHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class EPIGFLPEAHI : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x27C3CD0", Offset = "0x27C2ED0", VA = "0x1827C3CD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27C3D70", Offset = "0x27C2F70", VA = "0x1827C3D70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public EPIGFLPEAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AKEFOBLNEPL(CCDGJKNFPNB.OMRoom)]
internal class FLPBFHHAPFE : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private BCLIKNODFFN PBHPOGODKPB;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x27C96B0", Offset = "0x27C88B0", VA = "0x1827C96B0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x27C9700", Offset = "0x27C8900", VA = "0x1827C9700", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public FLPBFHHAPFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FIJIJKJDBFL
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KKGMJHCDFHA
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class EDPKFCPBJNP<T> : AMOLHCFCJBC<T>, FLNCDPNCALM<NACALKPEILN, T>, GCIMBJDHENP<NACALKPEILN>, AELOMMACAOB, IDisposable, GHANKHPHMBP where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GCIMBJDHENP<Entity> BGOCDAGKFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Delegate OGHHHIOGEBA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2C2FCC0", Offset = "0x2C2EEC0", VA = "0x182C2FCC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type GLGPHBABLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2C2FFA0", Offset = "0x2C2F1A0", VA = "0x182C2FFA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JHNBELMGFMH JLMOKFABNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2C306A0", Offset = "0x2C2F8A0", VA = "0x182C306A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int GBCPOFPGEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2C33170", Offset = "0x2C32370", VA = "0x182C33170", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public OHEODOENDEE CNIKDLGMEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2C30240", Offset = "0x2C2F440", VA = "0x182C30240", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FPMEHGMLMEM<NACALKPEILN> JJKMLFDPEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2C31C60", Offset = "0x2C30E60", VA = "0x182C31C60", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2C2F950", Offset = "0x2C2EB50", VA = "0x182C2F950", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2296E80", Offset = "0x2296080", VA = "0x182296E80")]
	public EDPKFCPBJNP(GCIMBJDHENP<Entity> BGOCDAGKFNE, JPLJDCFLDIF KPFCGANDCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2C35C40", Offset = "0x2C34E40", VA = "0x182C35C40")]
	private Entity LKEFLLNHKFJ(NACALKPEILN EPGIOGIKNGK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2C35C10", Offset = "0x2C34E10", VA = "0x182C35C10")]
	private NACALKPEILN LKEFLLNHKFJ(Entity BLNICJMKCEF)
	{
		return default(NACALKPEILN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2C36620", Offset = "0x2C35820", VA = "0x182C36620", Slot = "4")]
	public T MCKGCJAFOEM(NACALKPEILN EPGIOGIKNGK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DE50", Offset = "0x2C2D050", VA = "0x182C2DE50")]
	public bool BNDJKAKDCIM(NACALKPEILN EPGIOGIKNGK, in T FDDLNHNDPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F270", Offset = "0x2C2E470", VA = "0x182C2F270", Slot = "7")]
	public bool CCLPLAGPKBK(NACALKPEILN EPGIOGIKNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2C37520", Offset = "0x2C36720", VA = "0x182C37520", Slot = "8")]
	public void MCKGCJAFOEM(NACALKPEILN EPGIOGIKNGK, PMJFNECPFPH NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EAB0", Offset = "0x2C2DCB0", VA = "0x182C2EAB0", Slot = "9")]
	public bool BNDJKAKDCIM(NACALKPEILN EPGIOGIKNGK, LKEBNILDCHH FDDLNHNDPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2290E20", Offset = "0x2290020", VA = "0x182290E20", Slot = "16")]
	public void EIPBKFMEANK(ANJJHLMIOKD NGBDCJPCMID, [Optional] object JDFBABENAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F540", Offset = "0x2C2E740", VA = "0x182C2F540", Slot = "10")]
	public bool DLOFCDEOECF(NACALKPEILN GLDKECDCJGE, NACALKPEILN LBIBKCFHCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F710", Offset = "0x2C2E910", VA = "0x182C2F710", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2C37A50", Offset = "0x2C36C50", VA = "0x182C37A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2C32450", Offset = "0x2C31650", VA = "0x182C32450")]
	private void JMCNGKPIEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2C30FC0", Offset = "0x2C301C0", VA = "0x182C30FC0")]
	private void HFECKHLKIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2C34DF0", Offset = "0x2C33FF0", VA = "0x182C34DF0")]
	private void LIFKDDHHBCI(Entity BLNICJMKCEF, in LKEBNILDCHH EJOKGCNJEPM, in LKEBNILDCHH FDDLNHNDPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2C334E0", Offset = "0x2C326E0", VA = "0x182C334E0")]
	private void KDBOFGJFJPN(Entity BLNICJMKCEF, in LKEBNILDCHH EJOKGCNJEPM, in LKEBNILDCHH FDDLNHNDPFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class OMCMMADKKCM : JFNDONHKHIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D0C0", Offset = "0x2A9C2C0", VA = "0x182A9D0C0", Slot = "5")]
	public override Action GHBBLAOCPNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void BOMLCLDIBCI<T>() where T : INGMBGOCEKO;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D030", Offset = "0x2A9C230", VA = "0x182A9D030")]
	[UnityEngine.Scripting.Preserve]
	public void APHCOPBMBGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27B7EF0", Offset = "0x27B70F0", VA = "0x1827B7EF0")]
	protected OMCMMADKKCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DDDGJOKMEDO(typeof(CFNPKKKFCDJ), new string[] { })]
public class ACDAILIEKLB : DCLDDNDKGBL, CFNPKKKFCDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x26205E0", Offset = "0x261F7E0", VA = "0x1826205E0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2620660", Offset = "0x261F860", VA = "0x182620660", Slot = "5")]
	public void PFEKFOALLEK(BMDJOHDFBDL KHBBAOCDKFN, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC150", Offset = "0x1FCB350", VA = "0x181FCC150")]
	private void BNDJKAKDCIM<T>(BMDJOHDFBDL KHBBAOCDKFN, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public ACDAILIEKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
[DDDGJOKMEDO(typeof(DKFFIBCBDBB), new string[] { })]
public class DKFFIBCBDBB : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GJNBNDPMPIC : IEnumerable<JGABCBFOGEC>, IEnumerable, IEnumerator<JGABCBFOGEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private JGABCBFOGEC <>2__current;

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
		public DKFFIBCBDBB <>4__this;

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
		private IGKIKGDPCOF <rbex>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private JGABCBFOGEC System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public GJNBNDPMPIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x221FA50", Offset = "0x221EC50", VA = "0x18221FA50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x221F750", Offset = "0x221E950", VA = "0x18221F750", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x221F700", Offset = "0x221E900", VA = "0x18221F700")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x221FA10", Offset = "0x221EC10", VA = "0x18221FA10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x221F960", Offset = "0x221EB60", VA = "0x18221F960", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JGABCBFOGEC> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x221F960", Offset = "0x221EB60", VA = "0x18221F960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> KMBANGACECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x263A320", Offset = "0x2639520", VA = "0x18263A320", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x263A370", Offset = "0x2639570", VA = "0x18263A370")]
	public void JAANHLMMGOP(NativeArray<Entity> IBGFBPGPJKP, bool NFFGHPJGDBO, bool KDBFEKCIOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x263A490", Offset = "0x2639690", VA = "0x18263A490")]
	public void KGAJCPMNKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x263A6C0", Offset = "0x26398C0", VA = "0x18263A6C0")]
	private void KOJBBCDLIHL(NativeArray<Entity> IBGFBPGPJKP, bool NFFGHPJGDBO, bool KDBFEKCIOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x263AD70", Offset = "0x2639F70", VA = "0x18263AD70")]
	[IteratorStateMachine(typeof(GJNBNDPMPIC))]
	private IEnumerable<JGABCBFOGEC> PHOCEPLENNH(NativeArray<Entity> IBGFBPGPJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x263A1C0", Offset = "0x26393C0", VA = "0x18263A1C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x263AE90", Offset = "0x263A090", VA = "0x18263AE90")]
	public DKFFIBCBDBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
[DDDGJOKMEDO(typeof(BEDIIKOKEPM), new string[] { })]
public class BEDIIKOKEPM : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<NativeListAsync<BONPPKDBCCB>> OLECPKCOLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2628410", Offset = "0x2627610", VA = "0x182628410", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2628460", Offset = "0x2627660", VA = "0x182628460")]
	public void JAANHLMMGOP(NativeListAsync<BONPPKDBCCB> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x26284D0", Offset = "0x26276D0", VA = "0x1826284D0")]
	public void KGAJCPMNKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x26282B0", Offset = "0x26274B0", VA = "0x1826282B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2628960", Offset = "0x2627B60", VA = "0x182628960")]
	public BEDIIKOKEPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class GGDPOPIGFLC
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly ProfilerMarker ODLAMGFGHCF;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly ProfilerMarker JKKNIGKIJGJ;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x27CF390", Offset = "0x27CE590", VA = "0x1827CF390")]
	public static void LKAMFIMFKPG(this BHIKEJGKPLP DAJKBHKJPOA, BMMLCIMMEMO HCCLEJHCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x27CF1E0", Offset = "0x27CE3E0", VA = "0x1827CF1E0")]
	public static void KKGNNLLCPGM(this BHIKEJGKPLP DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x27CEFE0", Offset = "0x27CE1E0", VA = "0x1827CEFE0")]
	private static string[] EAECHLMHBOK(BMMLCIMMEMO HCCLEJHCLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x27CF780", Offset = "0x27CE980", VA = "0x1827CF780")]
	private static bool PHCEDOJLKOF(BMMLCIMMEMO HCCLEJHCLJP, out string[] PCPBNMGLNFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x929790", Offset = "0x928990", VA = "0x180929790")]
	private static bool LLABDEACLNP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DDDGJOKMEDO(typeof(JPLJDCFLDIF), new string[] { })]
public class FOIMAENMPKC : DCLDDNDKGBL, JPLJDCFLDIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly PEKDFCFCENH KFPMAAAAFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[MOHONECELPE]
	private HEDLOJKNBDM BLJLNGLFFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[MOHONECELPE]
	private BEEILEEPNEP BNMBMDEENEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[MOHONECELPE]
	private MGGGBEIHFIJ KMCFNHCIMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[MOHONECELPE]
	private AKFLDBGLGDA MKADFFOHHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[MOHONECELPE]
	private EFIGCPCEPCG AOHLHGPBOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private GGPANEIKFII JGDGCNOJDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MHGCAFFKDBL CJBOPCIHIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public LOGMGCPJHJB OMMPADAGKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x95D1F0", Offset = "0x95C3F0", VA = "0x18095D1F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(LOGMGCPJHJB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x95CD30", Offset = "0x95BF30", VA = "0x18095CD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<ILOOFJFGECE, NativeArray<IANCKMHPHEB>> JOOPAPLBMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x27CB220", Offset = "0x27CA420", VA = "0x1827CB220", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x27CC2A0", Offset = "0x27CB4A0", VA = "0x1827CC2A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<ILOOFJFGECE> BLEHOEMJDDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x27CBE10", Offset = "0x27CB010", VA = "0x1827CBE10", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x27CB850", Offset = "0x27CAA50", VA = "0x1827CB850", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x27CBEB0", Offset = "0x27CB0B0", VA = "0x1827CBEB0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x27CB4E0", Offset = "0x27CA6E0", VA = "0x1827CB4E0", Slot = "39")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27CAEC0", Offset = "0x27CA0C0", VA = "0x1827CAEC0")]
	private void CEMPPDJOBAH(ILOOFJFGECE IJPPGDHIGGN, NativeArray<IANCKMHPHEB> MBFFOEIOABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x27CAE10", Offset = "0x27CA010", VA = "0x1827CAE10")]
	private void BHKOHLPMJIE(ILOOFJFGECE IJPPGDHIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x27CC420", Offset = "0x27CB620", VA = "0x1827CC420")]
	internal BMDJOHDFBDL MOFMBJBKHDP(Entity BLNICJMKCEF)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x27CB8F0", Offset = "0x27CAAF0", VA = "0x1827CB8F0", Slot = "11")]
	public FHOKMDLBODC FAFBPKCECOE(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(FHOKMDLBODC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x27CC730", Offset = "0x27CB930", VA = "0x1827CC730", Slot = "12")]
	public IANCKMHPHEB NFFGGPDBEPF(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(IANCKMHPHEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x27CAE80", Offset = "0x27CA080", VA = "0x1827CAE80", Slot = "38")]
	public bool CCLPLAGPKBK(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x27CB300", Offset = "0x27CA500", VA = "0x1827CB300", Slot = "33")]
	public void DOHCNDEFFMO(ILOOFJFGECE BOIJHJLHIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x27CC5E0", Offset = "0x27CB7E0", VA = "0x1827CC5E0", Slot = "34")]
	public void NDBCAEEMEJN(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x27CCA00", Offset = "0x27CBC00", VA = "0x1827CCA00", Slot = "35")]
	public void PFGELJGDKOG(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x27CB2C0", Offset = "0x27CA4C0", VA = "0x1827CB2C0", Slot = "36")]
	public void DOHCNDEFFMO(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x27CC680", Offset = "0x27CB880", VA = "0x1827CC680", Slot = "23")]
	public ILOOFJFGECE NEEBBCDLDON(NativeArray<NACALKPEILN> EPGIOGIKNGK, Allocator KPFKDHLBOGB)
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x27CBA60", Offset = "0x27CAC60", VA = "0x1827CBA60", Slot = "24")]
	public ILOOFJFGECE IMHJGEENMOL(NativeArray<NACALKPEILN> EPGIOGIKNGK, NativeArray<DLGBACOGEKM> NBHGMLCGCLE, Allocator KPFKDHLBOGB)
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x27CB050", Offset = "0x27CA250", VA = "0x1827CB050", Slot = "25")]
	public OCHPAAEIANL DDDBLPKECIO(IANCKMHPHEB GLKDKMADKLI, bool FHGCFHCOHHO)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x27CB140", Offset = "0x27CA340", VA = "0x1827CB140", Slot = "26")]
	public OCHPAAEIANL DDDBLPKECIO(IANCKMHPHEB GLKDKMADKLI)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x27CC340", Offset = "0x27CB540", VA = "0x1827CC340", Slot = "27")]
	public OCHPAAEIANL MFJDPGPEFOM(IANCKMHPHEB GLKDKMADKLI)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x27CC470", Offset = "0x27CB670", VA = "0x1827CC470", Slot = "28")]
	public OCHPAAEIANL NAIKANDMOOF(IANCKMHPHEB GLKDKMADKLI)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x27CBBB0", Offset = "0x27CADB0", VA = "0x1827CBBB0", Slot = "29")]
	public OCHPAAEIANL IMHJGEENMOL(NACALKPEILN EPGIOGIKNGK, IANCKMHPHEB GLKDKMADKLI)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x27CC8F0", Offset = "0x27CBAF0", VA = "0x1827CC8F0", Slot = "30")]
	public LMELMGLGCDI OKBLFOPMDOP()
	{
		return default(LMELMGLGCDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x27CB760", Offset = "0x27CA960", VA = "0x1827CB760", Slot = "31")]
	public LOBHMBEDOPE EMFECKAHCMJ()
	{
		return default(LOBHMBEDOPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x27CB3E0", Offset = "0x27CA5E0", VA = "0x1827CB3E0", Slot = "32")]
	public AEGPJNKHODP DPKJFINENPM(EKGFPCGJLIK FBNKHAJKFLM)
	{
		return default(AEGPJNKHODP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x27CC130", Offset = "0x27CB330", VA = "0x1827CC130", Slot = "13")]
	public void JJOABFDKIHC(NACALKPEILN EPGIOGIKNGK, BGNCONALOOG PDGBOKGMGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x27CC150", Offset = "0x27CB350", VA = "0x1827CC150", Slot = "14")]
	public OCHPAAEIANL KJNINLFGCFK(BMDJOHDFBDL JHJPAJMEGAG, [Optional] object FDCOCHLAHJD)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x27CAD70", Offset = "0x27C9F70", VA = "0x1827CAD70", Slot = "15")]
	public bool BEEFCOHBNDM(BMDJOHDFBDL JHJPAJMEGAG, out BGNCONALOOG GAMJEJDMFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x27CB6C0", Offset = "0x27CA8C0", VA = "0x1827CB6C0", Slot = "16")]
	public bool ELAJOLEBEAL(BMDJOHDFBDL JHJPAJMEGAG, out Transform LNNHFELGMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x27CB9D0", Offset = "0x27CABD0", VA = "0x1827CB9D0", Slot = "17")]
	public bool IDPBDNBNHFE(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x27CB630", Offset = "0x27CA830", VA = "0x1827CB630", Slot = "18")]
	public void ECAIDIAPEHP(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x27CC6E0", Offset = "0x27CB8E0", VA = "0x1827CC6E0", Slot = "19")]
	public bool NEEIPHPAMEG(LocalId JHJPAJMEGAG, object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x27CC0E0", Offset = "0x27CB2E0", VA = "0x1827CC0E0", Slot = "20")]
	public bool JEJLPBHJMJA(LocalId JHJPAJMEGAG, object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x27CC890", Offset = "0x27CBA90", VA = "0x1827CC890", Slot = "37")]
	public ILOOFJFGECE OGHNPGAIFHF(ILOOFJFGECE LIKELALOOEJ, Allocator KPFKDHLBOGB)
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x27CC850", Offset = "0x27CBA50", VA = "0x1827CC850", Slot = "22")]
	public NACALKPEILN NHPDIBJHNEF(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(NACALKPEILN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x27CC640", Offset = "0x27CB840", VA = "0x1827CC640", Slot = "21")]
	public BMDJOHDFBDL NEEBBCDLDON(NACALKPEILN EPGIOGIKNGK)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x27CAF40", Offset = "0x27CA140", VA = "0x1827CAF40")]
	private void CLGGMKFAPEN(IANCKMHPHEB LHACNDMACAN, BMDJOHDFBDL JHJPAJMEGAG, NACALKPEILN EPGIOGIKNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public FOIMAENMPKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DDDGJOKMEDO(typeof(KNKOHPGNOPB), new string[] { })]
public class ELLHCFLHCMF : DCLDDNDKGBL, KNKOHPGNOPB
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[MOHONECELPE]
	private DFFEELNDGLN KAKKOCFGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[MOHONECELPE]
	private NBMHDDHKDOO CLIODOKHJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[MOHONECELPE]
	private JHHABMNLDEN DLJJINDIADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[MOHONECELPE]
	private IBMCNLNFCOD IOMHDMPPFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[MOHONECELPE]
	private GLHCMEBBKOL EJNAPPPBKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private World MLDBPMLFENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private PBJKHKOIGNG PKNCIJIJBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private PBJKHKOIGNG JOEKGNHJBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private PBJKHKOIGNG JMPJEOOMNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private PBJKHKOIGNG IJJJFODFAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PBJKHKOIGNG GBEJAOHOFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private PBJKHKOIGNG FEBKEHCMNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private PBJKHKOIGNG ABMCAGBDIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private PBJKHKOIGNG PKHGKDLEADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PBJKHKOIGNG NOOPDPBIBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PBJKHKOIGNG DKBFIKOGPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private PBJKHKOIGNG BJPHJKPBNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private PBJKHKOIGNG GCIHOCOCGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private PBJKHKOIGNG EELGEBLAHGM;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool GDJFIACKOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x27BEF00", Offset = "0x27BE100", VA = "0x1827BEF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool CPBPHDPHCEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x27BEFF0", Offset = "0x27BE1F0", VA = "0x1827BEFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool PBBIOHDNLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x27BEF00", Offset = "0x27BE100", VA = "0x1827BEF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool AFMJALHDIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x27BEF00", Offset = "0x27BE100", VA = "0x1827BEF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x27BF0E0", Offset = "0x27BE2E0", VA = "0x1827BF0E0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xF24FF0", Offset = "0xF241F0", VA = "0x180F24FF0")]
	private PBJKHKOIGNG CIKABCGCJMD<T>() where T : GIMHMHOIKPI
	{
		return default(PBJKHKOIGNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x27BECF0", Offset = "0x27BDEF0", VA = "0x1827BECF0")]
	private PBJKHKOIGNG CIKABCGCJMD(Type FBNKHAJKFLM)
	{
		return default(PBJKHKOIGNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x27BF4E0", Offset = "0x27BE6E0", VA = "0x1827BF4E0", Slot = "14")]
	public void LMEOGDJPPKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x27BEF70", Offset = "0x27BE170", VA = "0x1827BEF70", Slot = "15")]
	public void FBCLJBKDJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x27BF770", Offset = "0x27BE970", VA = "0x1827BF770", Slot = "5")]
	public void OCAJOLMOOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x27BF6F0", Offset = "0x27BE8F0", VA = "0x1827BF6F0", Slot = "6")]
	public void MDDELGHBEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x27BF790", Offset = "0x27BE990", VA = "0x1827BF790", Slot = "7")]
	public void OELFDBNFEGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x27BF7D0", Offset = "0x27BE9D0", VA = "0x1827BF7D0", Slot = "8")]
	public void PJMMILMAJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x27BF730", Offset = "0x27BE930", VA = "0x1827BF730", Slot = "9")]
	public void NNDFOCLEHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x27BF5E0", Offset = "0x27BE7E0", VA = "0x1827BF5E0", Slot = "10")]
	public void LPBPDOCAILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x27BEC90", Offset = "0x27BDE90", VA = "0x1827BEC90", Slot = "11")]
	public void AENGHJMKIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x27BF0A0", Offset = "0x27BE2A0", VA = "0x1827BF0A0", Slot = "12")]
	public void HKPNAGFAPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x27BED20", Offset = "0x27BDF20", VA = "0x1827BED20", Slot = "13")]
	public void DCBBIJOJAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x27BF670", Offset = "0x27BE870", VA = "0x1827BF670")]
	private void MALCNDHJDAB(PBJKHKOIGNG FMGKDHAODCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x27BF560", Offset = "0x27BE760", VA = "0x1827BF560")]
	private void LOEPOLMHIFB(PBJKHKOIGNG FMGKDHAODCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x27BECD0", Offset = "0x27BDED0", VA = "0x1827BECD0")]
	private void AFOMIFHCAEC(PBJKHKOIGNG FMGKDHAODCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public ELLHCFLHCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
[DDDGJOKMEDO(typeof(HBBBCINFOON), new string[] { "Editor" })]
public sealed class HBBBCINFOON
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void GHEHNCLCGPI(NACALKPEILN NLILKIKKNLO, DLGBACOGEKM JFGIPFOFKHL, bool JFNOFJPOPFP);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void NPBMBHNHFED(NACALKPEILN NLILKIKKNLO, bool JFNOFJPOPFP);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void EMGOJLPAPKK(NACALKPEILN NLILKIKKNLO, MCNHINHNBBI BGOCDAGKFNE, in LKEBNILDCHH NABCGCEIEGG, bool JFNOFJPOPFP);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public HBBBCINFOON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DDDGJOKMEDO(typeof(global::ODALGMFMJHI), new string[] { })]
internal class PLELJMPIHDA : global::ODALGMFMJHI, DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[MOHONECELPE]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[MOHONECELPE]
	private ALOPNKJDLEE HBHMCMADCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[MOHONECELPE]
	private DJIHMLHHNFC EAAEGPDMONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[MOHONECELPE]
	private CJBMEKLNLMM LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Action<IIJEOPOHPBE> JHGMNDBGFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private LGOHODJFODN<Entity> OJEMCPHOKBP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<IIJEOPOHPBE> LFHCJLBBJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2455EB0", Offset = "0x24550B0", VA = "0x182455EB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2455C00", Offset = "0x2454E00", VA = "0x182455C00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2455FF0", Offset = "0x24551F0", VA = "0x182455FF0", Slot = "6")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2455D40", Offset = "0x2454F40", VA = "0x182455D40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2455EB0", Offset = "0x24550B0", VA = "0x182455EB0")]
	private void JGMMOMDPKLI(Action<IIJEOPOHPBE> NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2455C00", Offset = "0x2454E00", VA = "0x182455C00")]
	private void KAJMBIKCBPP(Action<IIJEOPOHPBE> NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2455B60", Offset = "0x2454D60", VA = "0x182455B60")]
	private void CMJPPDAMMNA(DNPJHPKBIAD JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public PLELJMPIHDA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct IJAELFDBNJN : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "4")]
	public void OnCreate(ref SystemState NJGLKOBADEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
	public void OnDestroy(ref SystemState NJGLKOBADEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x25B0FF0", Offset = "0x25B01F0", VA = "0x1825B0FF0", Slot = "6")]
	public void OnUpdate(ref SystemState NJGLKOBADEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void HMAICALGKFN(IntPtr KPIHKJNPOFH, IntPtr NJGLKOBADEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x25B0FF0", Offset = "0x25B01F0", VA = "0x1825B0FF0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void HCPGCLAOPFG(IntPtr KPIHKJNPOFH, IntPtr NJGLKOBADEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void NJFOHCJEEOO(IntPtr KPIHKJNPOFH, IntPtr NJGLKOBADEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[AKEFOBLNEPL(CCDGJKNFPNB.OMRoom)]
internal class IEEADPFJCPC : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private JGPGIDINFEG FMLLOEFLKIL;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x25AFC10", Offset = "0x25AEE10", VA = "0x1825AFC10", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x25AFC60", Offset = "0x25AEE60", VA = "0x1825AFC60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public IEEADPFJCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class DLKKJPGBHCP : JFNDONHKHIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private enum POEIHPIFGCI
	{

	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x27B7E60", Offset = "0x27B7060", VA = "0x1827B7E60", Slot = "5")]
	public override Action GHBBLAOCPNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void AEDMKMGIEDL<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x27B7DD0", Offset = "0x27B6FD0", VA = "0x1827B7DD0")]
	[UnityEngine.Scripting.Preserve]
	public void APHCOPBMBGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x27B7EF0", Offset = "0x27B70F0", VA = "0x1827B7EF0")]
	protected DLKKJPGBHCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(NFJCJEFFMGP), new string[] { })]
public class NFJCJEFFMGP : DCLDDNDKGBL, PJIPLCPBFIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private GGPANEIKFII JGDGCNOJDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private JOHINJPAKCH EAAEGPDMONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private MCNHINHNBBI[] GINFOKIFCBI;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2A96530", Offset = "0x2A95730", VA = "0x182A96530", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2A966C0", Offset = "0x2A958C0", VA = "0x182A966C0", Slot = "5")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2A965A0", Offset = "0x2A957A0", VA = "0x182A965A0")]
	public void KKNNGGPPPIF(NACALKPEILN EPGIOGIKNGK, bool NCAOMFCEFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public NFJCJEFFMGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
[DDDGJOKMEDO(typeof(EIFIFHHKJPI), new string[] { })]
public class HJHLMCDPNMD : EIFIFHHKJPI, IEnumerable<PLBLNCEJEDA>, IEnumerable, OHFLHEPJPJP, PNKPNDDLHPG, DCLDDNDKGBL, PJIPLCPBFIL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[MOHONECELPE]
	private DJIHMLHHNFC EAAEGPDMONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(Type, string), int> IENGEIJPIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeBitArray OIDINFJKAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<int> ENGODFKMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private IOPCPGDBHOD IINDDMNEJJN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public NativeBitArray APKLEHCPEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x99B860", Offset = "0x99AA60", VA = "0x18099B860", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NativeArray<int> HMIFNMMDHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xD0D200", Offset = "0xD0C400", VA = "0x180D0D200", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private int CEIOHOGOJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA92BA0", Offset = "0xA91DA0", VA = "0x180A92BA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x25A8F10", Offset = "0x25A8110", VA = "0x1825A8F10", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public PLBLNCEJEDA JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x25A90E0", Offset = "0x25A82E0", VA = "0x1825A90E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PLBLNCEJEDA JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x25A90E0", Offset = "0x25A82E0", VA = "0x1825A90E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x25A8EC0", Offset = "0x25A80C0", VA = "0x1825A8EC0", Slot = "13")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x25A8E40", Offset = "0x25A8040", VA = "0x1825A8E40", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "15")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x25A8830", Offset = "0x25A7A30", VA = "0x1825A8830")]
	private void HCNBDGKCNGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x25A8F30", Offset = "0x25A8130", VA = "0x1825A8F30", Slot = "9")]
	public PLBLNCEJEDA LMABDHPJKGG(FAODENBHDMK LPNKBGEMCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x25A86C0", Offset = "0x25A78C0", VA = "0x1825A86C0")]
	private bool GPGBLBFDLHB(Type INJKFIICBLK, string JPKENOAMLIN, out PLBLNCEJEDA ENMMGDOAMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x25A8C40", Offset = "0x25A7E40", VA = "0x1825A8C40", Slot = "10")]
	public MCNHINHNBBI HKIJCBIHCIH(FAODENBHDMK LPNKBGEMCBF)
	{
		return default(MCNHINHNBBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x25A8810", Offset = "0x25A7A10", VA = "0x1825A8810", Slot = "11")]
	public IEnumerator<PLBLNCEJEDA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x25A8810", Offset = "0x25A7A10", VA = "0x1825A8810", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x25A8670", Offset = "0x25A7870", VA = "0x1825A8670", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x25A9100", Offset = "0x25A8300", VA = "0x1825A9100")]
	public HJHLMCDPNMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KEIMNBBMGDG
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x25BBD10", Offset = "0x25BAF10", VA = "0x1825BBD10")]
	public static void GOHJMHDFLKI(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in float3 DGDMDKFMBBA, in quaternion KGFPECIFPNA, in float3 PBHILHOLGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x25BC7B0", Offset = "0x25BB9B0", VA = "0x1825BC7B0")]
	public static void MNMJOEKBIGF(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, out float4x4 BMFIICIOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x25BC8F0", Offset = "0x25BBAF0", VA = "0x1825BC8F0")]
	private static void MNMJOEKBIGF(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, Entity OJEMCPHOKBP, out float4x4 BMFIICIOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x25BB1C0", Offset = "0x25BA3C0", VA = "0x1825BB1C0")]
	public static void EAIMFEAJCJB(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in float4x4 BMFIICIOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x25BADD0", Offset = "0x25B9FD0", VA = "0x1825BADD0")]
	public static void DCFFEEKNJIO(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, out float4x4 FHOIDBKJJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x25BBFE0", Offset = "0x25BB1E0", VA = "0x1825BBFE0")]
	public static void IHABINNOEDO(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in float4x4 FHOIDBKJJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x25BA070", Offset = "0x25B9270", VA = "0x1825BA070")]
	public static float3 ACMHBINOKCP(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x25BCFC0", Offset = "0x25BC1C0", VA = "0x1825BCFC0")]
	public static void PFJMDJGLEDF(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x25BBDB0", Offset = "0x25BAFB0", VA = "0x1825BBDB0")]
	public static quaternion HMFNAHFKGJD(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x25BC120", Offset = "0x25BB320", VA = "0x1825BC120")]
	public static void IKOIHALOCIP(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in quaternion NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x25B9FA0", Offset = "0x25B91A0", VA = "0x1825B9FA0")]
	public static float3 ACMFOJKOGHF(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x25BB7A0", Offset = "0x25BA9A0", VA = "0x1825BB7A0")]
	public static void FCAHDNKELNN(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x25BBC40", Offset = "0x25BAE40", VA = "0x1825BBC40")]
	public static float GKKLEPNPMII(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x25BB920", Offset = "0x25BAB20", VA = "0x1825BB920")]
	public static void FKPDMGOHFMC(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x25BC620", Offset = "0x25BB820", VA = "0x1825BC620")]
	public static float3 KNPJMCMOEDL(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x25BCA50", Offset = "0x25BBC50", VA = "0x1825BCA50")]
	public static void MOPJNNFCKCP(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x25BC300", Offset = "0x25BB500", VA = "0x1825BC300")]
	public static void KANMFOJNIKE(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, out RigidTransform FHOIDBKJJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x25BC1E0", Offset = "0x25BB3E0", VA = "0x1825BC1E0")]
	public static void KANMFOJNIKE(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, out float3 BOEKENJNLKP, out quaternion ELGEECMLAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x25B9EE0", Offset = "0x25B90E0", VA = "0x1825B9EE0")]
	public static void ABIMINHJLLE(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in float3 DGDMDKFMBBA, in quaternion KGFPECIFPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x25BA450", Offset = "0x25B9650", VA = "0x1825BA450")]
	public static void BGAMEEBKDIH(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, out float3 BOEKENJNLKP, out quaternion ELGEECMLAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x25BCAE0", Offset = "0x25BBCE0", VA = "0x1825BCAE0")]
	public static float3 OFCLBOMLFLK(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x25BB9A0", Offset = "0x25BABA0", VA = "0x1825BB9A0")]
	public static void FLCLONCKBII(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x25BB5B0", Offset = "0x25BA7B0", VA = "0x1825BB5B0")]
	public static void ECHMCPKNDDE(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in quaternion NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x25BC3F0", Offset = "0x25BB5F0", VA = "0x1825BC3F0")]
	public static quaternion KBPBNFKMDEB(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x25BAB10", Offset = "0x25B9D10", VA = "0x1825BAB10")]
	public static float3 CPIGLLAIOHB(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x25BA6B0", Offset = "0x25B98B0", VA = "0x1825BA6B0")]
	public static void CEKLBAMACNE(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x25BA920", Offset = "0x25B9B20", VA = "0x1825BA920")]
	public static float CJJFPGBIEOK(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x25BBEA0", Offset = "0x25BB0A0", VA = "0x1825BBEA0")]
	public static void HOLBLMIEKBF(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, float IHNHFHPFFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x25BCD50", Offset = "0x25BBF50", VA = "0x1825BCD50")]
	public static float3 OFJJPGKOJOP(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x25BA170", Offset = "0x25B9370", VA = "0x1825BA170")]
	public static void BDONNKCHBEP(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, in float3 GDAFEFPAMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x25BC710", Offset = "0x25BB910", VA = "0x1825BC710")]
	public static bool MHKDLDIKIKH(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, out Entity OJEMCPHOKBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DDDGJOKMEDO(typeof(HEJIKGNEDOI), new string[] { })]
public class ACAKIPBGKGH : DCLDDNDKGBL, HEJIKGNEDOI
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NLIGFKBFNHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public BMDJOHDFBDL localId;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NLIGFKBFNHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x22240B0", Offset = "0x22232B0", VA = "0x1822240B0")]
		internal object HJIHMJJEHFP(ACAKIPBGKGH a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class PIMMMONLOLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public BMDJOHDFBDL localId;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PIMMMONLOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2225620", Offset = "0x2224820", VA = "0x182225620")]
		internal object MICJKGNGEIE(ACAKIPBGKGH a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private HNMHAJLPHMH AMPOACOBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private World OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private MLJBBEFEOND MKOMLEILGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[MOHONECELPE]
	private JCKOIKCNGOK JMKJGIHBADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private EntityManager LOOMLEGKLIO;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x261E630", Offset = "0x261D830", VA = "0x18261E630", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x261D3F0", Offset = "0x261C5F0", VA = "0x18261D3F0", Slot = "6")]
	public JGABCBFOGEC FBJALINOBAA(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x261C550", Offset = "0x261B750", VA = "0x18261C550", Slot = "5")]
	public void CHOEIKBIHAG(BMDJOHDFBDL JHJPAJMEGAG, JGABCBFOGEC NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x261E5A0", Offset = "0x261D7A0", VA = "0x18261E5A0", Slot = "31")]
	public CollisionDetectionMode IIDFOHGNLBA(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x261F8D0", Offset = "0x261EAD0", VA = "0x18261F8D0", Slot = "32")]
	public void MPDHMFFBPAG(BMDJOHDFBDL JHJPAJMEGAG, CollisionDetectionMode NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x261C900", Offset = "0x261BB00", VA = "0x18261C900", Slot = "33")]
	public LGJDBCELJGC DJAEPIIKALA(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(LGJDBCELJGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x261F300", Offset = "0x261E500", VA = "0x18261F300", Slot = "34")]
	public void LLONFBJMMBJ(BMDJOHDFBDL JHJPAJMEGAG, LGJDBCELJGC NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x261D4C0", Offset = "0x261C6C0", VA = "0x18261D4C0", Slot = "35")]
	public bool FLCPCOPJENH(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x261EB30", Offset = "0x261DD30", VA = "0x18261EB30", Slot = "36")]
	public void JJPGMBPJOAJ(BMDJOHDFBDL JHJPAJMEGAG, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x261D100", Offset = "0x261C300", VA = "0x18261D100", Slot = "37")]
	public BMDJOHDFBDL ELNKALNLELD(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x261F230", Offset = "0x261E430", VA = "0x18261F230", Slot = "38")]
	public void LBCEDGFJDLM(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x261D5F0", Offset = "0x261C7F0", VA = "0x18261D5F0", Slot = "39")]
	public BMDJOHDFBDL FOMIAGBPCIG(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x261C2E0", Offset = "0x261B4E0", VA = "0x18261C2E0", Slot = "40")]
	public void BPMJPILKAOG(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x261BEE0", Offset = "0x261B0E0", VA = "0x18261BEE0", Slot = "7")]
	public void BIBGAGBKMNG(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x261D1E0", Offset = "0x261C3E0", VA = "0x18261D1E0", Slot = "8")]
	public void EOEHEOKPEGA(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x26203B0", Offset = "0x261F5B0", VA = "0x1826203B0", Slot = "9")]
	public int PIEOLGNFKFJ(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x261EF40", Offset = "0x261E140", VA = "0x18261EF40", Slot = "10")]
	public BMDJOHDFBDL KLAGIJJDGIC(BMDJOHDFBDL JHJPAJMEGAG, int NNAODBDJDNJ)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x261E2C0", Offset = "0x261D4C0", VA = "0x18261E2C0", Slot = "11")]
	public void HNFLFELDMEP(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x261F970", Offset = "0x261EB70", VA = "0x18261F970", Slot = "12")]
	public void NDPAJAFHMPE(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD, BMDJOHDFBDL NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x261D950", Offset = "0x261CB50", VA = "0x18261D950", Slot = "13")]
	public void GDMDNBEIBPC(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x261CD20", Offset = "0x261BF20", VA = "0x18261CD20", Slot = "14")]
	public bool ECPOGCDEBGK(BMDJOHDFBDL JHJPAJMEGAG, out BMDJOHDFBDL NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x261DA10", Offset = "0x261CC10", VA = "0x18261DA10", Slot = "15")]
	public void GFPFFJACKDF(BMDJOHDFBDL JHJPAJMEGAG, float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x261DCF0", Offset = "0x261CEF0", VA = "0x18261DCF0", Slot = "16")]
	public bool GKLGHHEPEBO(BMDJOHDFBDL JHJPAJMEGAG, out float3 NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x261BE20", Offset = "0x261B020", VA = "0x18261BE20", Slot = "17")]
	public void BDHDBELPBPJ(BMDJOHDFBDL JHJPAJMEGAG, float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x261CEC0", Offset = "0x261C0C0", VA = "0x18261CEC0", Slot = "18")]
	public bool EHHKMNJKPGO(BMDJOHDFBDL JHJPAJMEGAG, out float3 NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x261C790", Offset = "0x261B990", VA = "0x18261C790", Slot = "23")]
	[Obsolete]
	public float3 DEFMICGMPPK(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x261E750", Offset = "0x261D950", VA = "0x18261E750", Slot = "24")]
	public float3 JAAJAOMLGGD(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x261CA10", Offset = "0x261BC10", VA = "0x18261CA10", Slot = "25")]
	public void DLLJDJDFPMK(BMDJOHDFBDL JHJPAJMEGAG, float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x261F4A0", Offset = "0x261E6A0", VA = "0x18261F4A0", Slot = "26")]
	public void LPBIPCDHPIP(BMDJOHDFBDL JHJPAJMEGAG, float3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x261E450", Offset = "0x261D650", VA = "0x18261E450", Slot = "27")]
	[Obsolete]
	public float IEFAPLEBGNL(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x261D550", Offset = "0x261C750", VA = "0x18261D550", Slot = "28")]
	public float FLJCDOENPMN(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x261DE90", Offset = "0x261D090", VA = "0x18261DE90", Slot = "29")]
	public void GLNLPFFODII(BMDJOHDFBDL JHJPAJMEGAG, float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x261F0A0", Offset = "0x261E2A0", VA = "0x18261F0A0", Slot = "30")]
	public void KNKFOBAGPOL(BMDJOHDFBDL JHJPAJMEGAG, float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x261E860", Offset = "0x261DA60", VA = "0x18261E860", Slot = "19")]
	public void JDAFPEBJHGA(BMDJOHDFBDL JHJPAJMEGAG, (Quaternion rot, Vector3 moments) BCLEDNCILCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x261D6F0", Offset = "0x261C8F0", VA = "0x18261D6F0", Slot = "20")]
	public bool GCFAPJMKALL(BMDJOHDFBDL JHJPAJMEGAG, out quaternion IBNMCFBIENP, out float3 KCCJNFIBEPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x261B9F0", Offset = "0x261ABF0", VA = "0x18261B9F0", Slot = "41")]
	public FOILGMPPBAK AAOBFABDJFP(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(FOILGMPPBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x26201B0", Offset = "0x261F3B0", VA = "0x1826201B0", Slot = "42")]
	public void OMMCNFDKKAH(BMDJOHDFBDL JHJPAJMEGAG, FOILGMPPBAK NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x261BD60", Offset = "0x261AF60", VA = "0x18261BD60", Slot = "66")]
	public void AIGLBFDNNFC(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x261C6D0", Offset = "0x261B8D0", VA = "0x18261C6D0", Slot = "67")]
	public void DCKNMMOKNPI(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x261FE50", Offset = "0x261F050", VA = "0x18261FE50", Slot = "68")]
	public bool OFHJOBAELCI(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x261E160", Offset = "0x261D360", VA = "0x18261E160", Slot = "82")]
	public bool HLNAEHOELNP(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x261EC90", Offset = "0x261DE90", VA = "0x18261EC90", Slot = "83")]
	public void KKGFEBAHIGL(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD, bool ALGGMCABHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x261F850", Offset = "0x261EA50", VA = "0x18261F850", Slot = "84")]
	public void MMGIAHLBPJK(BMDJOHDFBDL JHJPAJMEGAG, bool HPKMDNDEEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x261C400", Offset = "0x261B600", VA = "0x18261C400", Slot = "86")]
	public bool CBPLKBHHKNO(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x261C4B0", Offset = "0x261B6B0", VA = "0x18261C4B0", Slot = "85")]
	public void CFGAJHAHGDK(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x261C1B0", Offset = "0x261B3B0", VA = "0x18261C1B0", Slot = "43")]
	public bool BIKHMAMCJMM(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x261D060", Offset = "0x261C260", VA = "0x18261D060", Slot = "44")]
	public void EIONPDFCPOD(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x261FF00", Offset = "0x261F100", VA = "0x18261FF00", Slot = "45")]
	public bool OIBAMAGOGML(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x261DB80", Offset = "0x261CD80", VA = "0x18261DB80", Slot = "46")]
	public void GJKMMPMFFGE(BMDJOHDFBDL JHJPAJMEGAG, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x261F410", Offset = "0x261E610", VA = "0x18261F410", Slot = "47")]
	public bool LNELKMFIFKK(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x261DF40", Offset = "0x261D140", VA = "0x18261DF40", Slot = "48")]
	public void GNOMLDJNCII(BMDJOHDFBDL JHJPAJMEGAG, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x261E3C0", Offset = "0x261D5C0", VA = "0x18261E3C0", Slot = "49")]
	public RigidbodyConstraints IBOIHIHHFHP(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x261FAD0", Offset = "0x261ECD0", VA = "0x18261FAD0", Slot = "50")]
	public void NGKFOFGOIHN(BMDJOHDFBDL JHJPAJMEGAG, RigidbodyConstraints NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x261E0C0", Offset = "0x261D2C0", VA = "0x18261E0C0", Slot = "51")]
	public float HJIEKHJCAPC(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x261F680", Offset = "0x261E880", VA = "0x18261F680", Slot = "52")]
	public void MHKBILMMHKD(BMDJOHDFBDL JHJPAJMEGAG, float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x26204B0", Offset = "0x261F6B0", VA = "0x1826204B0", Slot = "53")]
	public float PKECNDBOBCK(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2620100", Offset = "0x261F300", VA = "0x182620100", Slot = "54")]
	public void OMDFFHILOPG(BMDJOHDFBDL JHJPAJMEGAG, float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x261C640", Offset = "0x261B840", VA = "0x18261C640", Slot = "55")]
	public bool CLBCGODNJNN(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x261D340", Offset = "0x261C540", VA = "0x18261D340", Slot = "56")]
	public void FAJDCMECNIM(BMDJOHDFBDL JHJPAJMEGAG, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x261EAA0", Offset = "0x261DCA0", VA = "0x18261EAA0", Slot = "57")]
	public bool JHDCCFGPCJA(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x261FB70", Offset = "0x261ED70", VA = "0x18261FB70", Slot = "58")]
	public void NMBAEDECDIC(BMDJOHDFBDL JHJPAJMEGAG, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2620250", Offset = "0x261F450", VA = "0x182620250", Slot = "59")]
	public void OMPJINNPJJB(BMDJOHDFBDL JHJPAJMEGAG, int NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x261DFF0", Offset = "0x261D1F0", VA = "0x18261DFF0", Slot = "73")]
	public Rigidbody HEFLGOHHBBE(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x261FF90", Offset = "0x261F190", VA = "0x18261FF90", Slot = "74")]
	public void OMCLGMIMMBJ(BMDJOHDFBDL JHJPAJMEGAG, Rigidbody NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x261BCA0", Offset = "0x261AEA0", VA = "0x18261BCA0", Slot = "75")]
	public void AGNJHCMHGPC(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x26202F0", Offset = "0x261F4F0", VA = "0x1826202F0", Slot = "76")]
	public void PDDIPNMKOKI(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x261EBE0", Offset = "0x261DDE0", VA = "0x18261EBE0", Slot = "77")]
	public bool JOGDCHOKMLI(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x261CB70", Offset = "0x261BD70", VA = "0x18261CB70", Slot = "60")]
	public object ECGFEDDLFGJ(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x261BB30", Offset = "0x261AD30", VA = "0x18261BB30", Slot = "61")]
	public void AGHIIAFLCKB(BMDJOHDFBDL JHJPAJMEGAG, object NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x261FC20", Offset = "0x261EE20", VA = "0x18261FC20", Slot = "62")]
	public object NOLDBAJDEOI(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x261C040", Offset = "0x261B240", VA = "0x18261C040", Slot = "63")]
	public void BIECLLDHNPB(BMDJOHDFBDL JHJPAJMEGAG, object NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x261C240", Offset = "0x261B440", VA = "0x18261C240", Slot = "64")]
	public float BLDDFLBNCBO(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x261BA80", Offset = "0x261AC80", VA = "0x18261BA80", Slot = "65")]
	public void ADCPGHCAFFF(BMDJOHDFBDL JHJPAJMEGAG, float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x261FD90", Offset = "0x261EF90", VA = "0x18261FD90", Slot = "69")]
	public void OEALKPKHMIB(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x261DC30", Offset = "0x261CE30", VA = "0x18261DC30", Slot = "70")]
	public void GJLLHDMDJNG(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x261DAD0", Offset = "0x261CCD0", VA = "0x18261DAD0", Slot = "71")]
	public bool GHBPACDFHBK(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x261FCF0", Offset = "0x261EEF0", VA = "0x18261FCF0", Slot = "21")]
	public void NPFOLLCFNHC(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x261CAD0", Offset = "0x261BCD0", VA = "0x18261CAD0", Slot = "22")]
	public void DMCEHMDDAHP(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x261EA10", Offset = "0x261DC10", VA = "0x18261EA10", Slot = "72")]
	public bool JDNFKAPCCPN(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x261F560", Offset = "0x261E760", VA = "0x18261F560", Slot = "78")]
	public void MCJIJBOFDJD(BMDJOHDFBDL JHJPAJMEGAG, float3 NHADPEGDINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x261F730", Offset = "0x261E930", VA = "0x18261F730", Slot = "79")]
	public void MKKIGJGGOHG(BMDJOHDFBDL JHJPAJMEGAG, float3 FDDOLPLJELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x261C3B0", Offset = "0x261B5B0", VA = "0x18261C3B0", Slot = "80")]
	public bool CBBIDNNAKFH(BMDJOHDFBDL JHJPAJMEGAG, out float3 NHADPEGDINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x261E810", Offset = "0x261DA10", VA = "0x18261E810", Slot = "81")]
	public bool JBBPENCGCPL(BMDJOHDFBDL JHJPAJMEGAG, out float3 FDDOLPLJELI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x261CC40", Offset = "0x261BE40", VA = "0x18261CC40")]
	private DynamicBuffer<Entity> ECPNEKFNIBC(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x261F150", Offset = "0x261E350", VA = "0x18261F150")]
	private DynamicBuffer<Entity> KOCFBIKNNBC(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC020", Offset = "0x1FCB220", VA = "0x181FCC020")]
	private void ECCPBPAGEIA<T>(BMDJOHDFBDL JHJPAJMEGAG, object NABCGCEIEGG, Func<object, T> GBFHENMJIDO) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public ACAKIPBGKGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[UnityEngine.Scripting.Preserve]
internal sealed class DJAFEFDCPIK<T> : KNNEOPGGIBD where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x21DCE70", Offset = "0x21DC070", VA = "0x1821DCE70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x21DCF90", Offset = "0x21DC190", VA = "0x1821DCF90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x21DD000", Offset = "0x21DC200", VA = "0x1821DD000")]
	public DJAFEFDCPIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(EFIGCPCEPCG), new string[] { })]
internal sealed class EFIGCPCEPCG : OHFLHEPJPJP, PNKPNDDLHPG, DCLDDNDKGBL, PJIPLCPBFIL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[MOHONECELPE]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EntityQuery JGNIIBNKLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private EntityQuery JMOPEDDLJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private EntityQuery PJGPJJBONNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery GCPDADJIAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery BPGIIFBLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery AABGLEOJJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery MOPJOPCIEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x27BC430", Offset = "0x27BB630", VA = "0x1827BC430")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityQuery IHAFICAKFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xFCB390", Offset = "0xFCA590", VA = "0x180FCB390")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "4")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x27BC620", Offset = "0x27BB820", VA = "0x1827BC620", Slot = "5")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x27BC670", Offset = "0x27BB870", VA = "0x1827BC670", Slot = "6")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x27BC4F0", Offset = "0x27BB6F0", VA = "0x1827BC4F0")]
	private EntityQueryDesc EEKCJPLCDOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x27BC480", Offset = "0x27BB680", VA = "0x1827BC480", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x27BC550", Offset = "0x27BB750", VA = "0x1827BC550")]
	public FHOKMDLBODC FAFBPKCECOE(BMDJOHDFBDL KHBBAOCDKFN)
	{
		return default(FHOKMDLBODC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x27BCB90", Offset = "0x27BBD90", VA = "0x1827BCB90")]
	public IANCKMHPHEB NFFGGPDBEPF(Entity BLNICJMKCEF)
	{
		return default(IANCKMHPHEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC40", Offset = "0x27BBE40", VA = "0x1827BCC40")]
	public EFIGCPCEPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class JOPFDBGMCFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[KFAABLOJCJD(typeof(BEAJGHBNKNP))]
[DDDGJOKMEDO(typeof(CHOMHKHHFDB), new string[] { })]
internal class BEAJGHBNKNP : CHOMHKHHFDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<BDNEDPOFMOK> LNHIOMOJNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<BDNEDPOFMOK> IHMJKAFGOHO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action LFDHBMCCKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2627EF0", Offset = "0x26270F0", VA = "0x182627EF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2628170", Offset = "0x2627370", VA = "0x182628170", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BLOMAOGEMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x26280D0", Offset = "0x26272D0", VA = "0x1826280D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2627FE0", Offset = "0x26271E0", VA = "0x182627FE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MDMPALHBKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2628210", Offset = "0x2627410", VA = "0x182628210", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2627E50", Offset = "0x2627050", VA = "0x182627E50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8BEB00", Offset = "0x8BDD00", VA = "0x1808BEB00")]
	public void IJJOAOJLFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3D0", Offset = "0x8BE5D0", VA = "0x1808BF3D0")]
	public void OJEODHCFPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xAED340", Offset = "0xAEC540", VA = "0x180AED340")]
	public void DEBHFDDGNDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2628080", Offset = "0x2627280", VA = "0x182628080")]
	public void EPGDILPFPCP(BDNEDPOFMOK OGIMCFPJDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2627F90", Offset = "0x2627190", VA = "0x182627F90")]
	public void EHNMOMLHENA(BDNEDPOFMOK OGIMCFPJDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public BEAJGHBNKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AKEFOBLNEPL(CCDGJKNFPNB.OMRoom)]
internal class BNEFJDBBJNC : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private BCLIKNODFFN PBHPOGODKPB;

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x262A030", Offset = "0x2629230", VA = "0x18262A030", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x262A080", Offset = "0x2629280", VA = "0x18262A080", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public BNEFJDBBJNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class DELGLFGBNMP
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class OEJLOKCKGAN
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OEJLOKCKGAN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum JJOOBNGIPMA
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
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
[DDDGJOKMEDO(typeof(KKJKOBMDCHM), new string[] { "Editor" })]
public sealed class KKJKOBMDCHM
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate void IPDAJLFIOPD(NACALKPEILN EPGIOGIKNGK, DLGBACOGEKM JFGIPFOFKHL, JJOOBNGIPMA HCCLEJHCLJP);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void DFKMBLOJOKP(NACALKPEILN EPGIOGIKNGK, JJOOBNGIPMA HCCLEJHCLJP);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void BDFNDHFLLNG(NACALKPEILN EPGIOGIKNGK, MCNHINHNBBI BGOCDAGKFNE, LKEBNILDCHH CNPGLHEDJDI, LKEBNILDCHH KJOKOFBOJIE, JJOOBNGIPMA HCCLEJHCLJP);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate void FOLMLNLMEGJ(PKINEBOAGLJ JCEGKCPOPDM, ReadOnlySpan<byte> GJNKBDPFGGF);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public KKJKOBMDCHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class GCHFMCIAPBJ : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x27CDB20", Offset = "0x27CCD20", VA = "0x1827CDB20", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public GCHFMCIAPBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DDDGJOKMEDO(typeof(PMDPEMDAEAF), new string[] { })]
public class NJHIBPGNHFK : PMDPEMDAEAF, DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[MOHONECELPE]
	private JPLJDCFLDIF KDHINPHNJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[MOHONECELPE]
	private EIKGLGIJAHC CLOALEEOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<NativeListAsync<Entity>> DEEEJAKPJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<(NativeListAsync<Entity>, bool)> HBEBJLPLOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private CGAPDPKGPAD PJPMLDAICFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Dictionary<Entity, IFMFKMLAHFG> HJJKJMBHIJD;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A99750", Offset = "0x2A98950", VA = "0x182A99750", Slot = "8")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A998A0", Offset = "0x2A98AA0", VA = "0x182A998A0", Slot = "4")]
	public void MDILOGOPGKH(NativeListAsync<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A98DD0", Offset = "0x2A97FD0", VA = "0x182A98DD0", Slot = "5")]
	public void CONIMFHHKGE(CGAPDPKGPAD PJPMLDAICFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A997C0", Offset = "0x2A989C0", VA = "0x182A997C0", Slot = "6")]
	public void MBGKNDGHEDC(NativeListAsync<Entity> IBGFBPGPJKP, bool MCIMDKDHFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A99910", Offset = "0x2A98B10", VA = "0x182A99910", Slot = "7")]
	public void MEFFCFBCKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A98E20", Offset = "0x2A98020", VA = "0x182A98E20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A992B0", Offset = "0x2A984B0", VA = "0x182A992B0")]
	private int FOMDICOIAGE(NativeListAsync<Entity> DEEEJAKPJJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A98B30", Offset = "0x2A97D30", VA = "0x182A98B30")]
	private int ACBHJCNDCJA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A99510", Offset = "0x2A98710", VA = "0x182A99510")]
	private int GAEDFHOACCJ(NativeListAsync<Entity> HBEBJLPLOPH, bool NACIOIJPHMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A99D70", Offset = "0x2A98F70", VA = "0x182A99D70")]
	public NJHIBPGNHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A99C90", Offset = "0x2A98E90", VA = "0x182A99C90")]
	[CompilerGenerated]
	private BMDJOHDFBDL OJDKOEPENHC(Entity BLNICJMKCEF)
	{
		return default(BMDJOHDFBDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(DNKBKNOAAGM), new string[] { })]
public class DNKBKNOAAGM
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool EECCCGAOPOH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool JLHLDBCJPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAB280", Offset = "0xAAA480", VA = "0x180AAB280")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x25B6C00", Offset = "0x25B5E00", VA = "0x1825B6C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public DNKBKNOAAGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal abstract class AJIFMENAHLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private uint PPKLMGDKPAD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract uint HHJBKGIFHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2624990", Offset = "0x2623B90", VA = "0x182624990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2624A50", Offset = "0x2623C50", VA = "0x182624A50")]
	public NACALKPEILN PBCMEHBNCDH()
	{
		return default(NACALKPEILN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2624920", Offset = "0x2623B20", VA = "0x182624920")]
	public void ADCCMMJNBEK(NativeArray<NACALKPEILN> FIPCNCFGHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2624810", Offset = "0x2623A10", VA = "0x182624810")]
	public void ADCCMMJNBEK(NACALKPEILN EPGIOGIKNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x94C790", Offset = "0x94B990", VA = "0x18094C790", Slot = "6")]
	public virtual void FNKHNDBLOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x26249B0", Offset = "0x2623BB0", VA = "0x1826249B0")]
	private unsafe void NAEACAIFCMO(NACALKPEILN* PKEAPCMBMMC, int BKHJHJOLNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2624830", Offset = "0x2623A30", VA = "0x182624830")]
	private unsafe void ADCCMMJNBEK(NACALKPEILN* PKEAPCMBMMC, int BKHJHJOLNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x11A0D50", Offset = "0x119FF50", VA = "0x1811A0D50")]
	protected AJIFMENAHLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DDDGJOKMEDO(typeof(IECGGEGBNLL), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal sealed class IECGGEGBNLL : AJIFMENAHLG, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[MOHONECELPE]
	private LGMPOOCECDN CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private uint MIOMNEOFMJG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public override uint HHJBKGIFHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B2840", Offset = "0x8B1A40", VA = "0x1808B2840", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x25AEEC0", Offset = "0x25AE0C0", VA = "0x1825AEEC0", Slot = "7")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x25AEE10", Offset = "0x25AE010", VA = "0x1825AEE10")]
	private void ADPCFLIGHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x25AEE60", Offset = "0x25AE060", VA = "0x1825AEE60", Slot = "6")]
	public override void FNKHNDBLOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x25AEF50", Offset = "0x25AE150", VA = "0x1825AEF50")]
	public IECGGEGBNLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
[DDDGJOKMEDO(typeof(HGAHEFINGOF), new string[] { })]
internal sealed class HGAHEFINGOF : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[MOHONECELPE]
	private CPJBOBMOPIJ CKIBMJIJHCL;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x25A5A30", Offset = "0x25A4C30", VA = "0x1825A5A30", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x25A59E0", Offset = "0x25A4BE0", VA = "0x1825A59E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public HGAHEFINGOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DDDGJOKMEDO(typeof(MGGEHIBFFNH), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public class MGGEHIBFFNH : FHBJALEEHFO, OHFLHEPJPJP, PNKPNDDLHPG, DCLDDNDKGBL, PJIPLCPBFIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class NKBFBGKNGAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public POCHLGNFBCE services;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NKBFBGKNGAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2224050", Offset = "0x2223250", VA = "0x182224050")]
		internal void LMNCKNKANGO(DCLDDNDKGBL svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class NEDGLGIFKJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public POCHLGNFBCE services;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NEDGLGIFKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2223FF0", Offset = "0x22231F0", VA = "0x182223FF0")]
		internal void NOCALOKLNEL(PJIPLCPBFIL svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[MOHONECELPE]
	private FIADFNDFLMG AGLEJOOLDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[MOHONECELPE]
	private LFBNOCAADDA EFGGIEHCPKE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public JKBMNBGOHLH DLPNNLBMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xB4DB40", Offset = "0xB4CD40", VA = "0x180B4DB40", Slot = "4")]
		get
		{
			return default(JKBMNBGOHLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2A87A20", Offset = "0x2A86C20", VA = "0x182A87A20", Slot = "5")]
	public void AOIILMDJJDP(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2A87CC0", Offset = "0x2A86EC0", VA = "0x182A87CC0", Slot = "6")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2A87BE0", Offset = "0x2A86DE0", VA = "0x182A87BE0", Slot = "7")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2A87DF0", Offset = "0x2A86FF0", VA = "0x182A87DF0", Slot = "8")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2A87AB0", Offset = "0x2A86CB0", VA = "0x182A87AB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x1242D00", Offset = "0x1241F00", VA = "0x181242D00")]
	private void BPDLICIIHDM<T>(Action<T> BOLLBMEDMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MGGEHIBFFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[DDDGJOKMEDO(typeof(JGJKKEPGAGN), new string[] { })]
public sealed class NFPEHNMFGFH : JGJKKEPGAGN, OHFLHEPJPJP, PNKPNDDLHPG, DCLDDNDKGBL, PJIPLCPBFIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JECGFPHOCMJ : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
		public NFPEHNMFGFH <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xA1FE10", Offset = "0xA1F010", VA = "0x180A1FE10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x2221730", Offset = "0x2220930", VA = "0x182221730", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1E613C0", Offset = "0x1E605C0", VA = "0x181E613C0")]
		[DebuggerHidden]
		public JECGFPHOCMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x22213F0", Offset = "0x22205F0", VA = "0x1822213F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x22216F0", Offset = "0x22208F0", VA = "0x1822216F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2221640", Offset = "0x2220840", VA = "0x182221640", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2221640", Offset = "0x2220840", VA = "0x182221640", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[MOHONECELPE]
	private IHPPALHFKFG EAAEGPDMONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly HHGLODKFBFJ OCMJAJLIGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Dictionary<string, OMPNMJPGFEG> HPOKOPJEECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<int, GGMDGLIEABN> MPDLLHDCELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<HADCJDEHJDC> EPALOPHINAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private CJBMEKLNLMM PALBIMEBCCA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public GGMDGLIEABN CEDOLNJMLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2A96F90", Offset = "0x2A96190", VA = "0x182A96F90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public List<HADCJDEHJDC> MLEDKIPJDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "9")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2A970F0", Offset = "0x2A962F0", VA = "0x182A970F0", Slot = "10")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2A97960", Offset = "0x2A96B60", VA = "0x182A97960", Slot = "11")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2A96CE0", Offset = "0x2A95EE0", VA = "0x182A96CE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2A97B90", Offset = "0x2A96D90", VA = "0x182A97B90", Slot = "6")]
	public bool PJPAPGAIKGL(HADCJDEHJDC BGOCDAGKFNE, out GGMDGLIEABN MFKCFHJMFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2A97480", Offset = "0x2A96680", VA = "0x182A97480")]
	private void LKDDHGJMHNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2A97290", Offset = "0x2A96490", VA = "0x182A97290")]
	private void LCIHOEGJLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2A96F30", Offset = "0x2A96130", VA = "0x182A96F30")]
	private OMPNMJPGFEG FIPMABEEDLL(string JNJHFGHBBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2A96F90", Offset = "0x2A96190", VA = "0x182A96F90")]
	private OMPNMJPGFEG FNPMGBACMPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2A96A70", Offset = "0x2A95C70", VA = "0x182A96A70")]
	private OMPNMJPGFEG CFADNFIAELB(string JNJHFGHBBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2A979C0", Offset = "0x2A96BC0", VA = "0x182A979C0")]
	private OMPNMJPGFEG MJPLAANOPOD(string NOFBJAIDPEL, string FDCOCHLAHJD, [Optional] OMPNMJPGFEG GPCKMMJANLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2A96EA0", Offset = "0x2A960A0", VA = "0x182A96EA0")]
	[IteratorStateMachine(typeof(JECGFPHOCMJ))]
	private IEnumerable<(string, string)> FFLAIHNHBMG(string JNJHFGHBBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2A970A0", Offset = "0x2A962A0", VA = "0x182A970A0")]
	private bool ILNJNAHAJHI(HADCJDEHJDC BGOCDAGKFNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2A96D70", Offset = "0x2A95F70", VA = "0x182A96D70")]
	private HHGLODKFBFJ ENAIMNNKAIP(HADCJDEHJDC BGOCDAGKFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2A97430", Offset = "0x2A96630", VA = "0x182A97430")]
	private HHGLODKFBFJ LFFNPNGEEBI(HADCJDEHJDC BGOCDAGKFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2A96990", Offset = "0x2A95B90", VA = "0x182A96990")]
	private HHGLODKFBFJ BOBAEBHHKLK(HADCJDEHJDC BGOCDAGKFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x380EBC0", Offset = "0x380DDC0", VA = "0x18380EBC0")]
	private T JLNICPKMLGC<T>(HADCJDEHJDC BGOCDAGKFNE) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2A97880", Offset = "0x2A96A80", VA = "0x182A97880")]
	private FieldInfo MAPMFGGOFCF(HADCJDEHJDC BGOCDAGKFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2A97150", Offset = "0x2A96350", VA = "0x182A97150", Slot = "7")]
	public void JJOABFDKIHC(HADCJDEHJDC BGOCDAGKFNE, ABPCAMPCFCK GMILFHAIGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2A96FF0", Offset = "0x2A961F0", VA = "0x182A96FF0", Slot = "8")]
	public void FPJBABEEDGM(HADCJDEHJDC BGOCDAGKFNE, ABPCAMPCFCK GMILFHAIGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2A97C20", Offset = "0x2A96E20", VA = "0x182A97C20")]
	public NFPEHNMFGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2A97200", Offset = "0x2A96400", VA = "0x182A97200")]
	[CompilerGenerated]
	private int KNHJIPJBBEE(HADCJDEHJDC GGFLAOCNMAP, HADCJDEHJDC PIINDHALINJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DAIOLBIBBOH
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class FLDBPKLAFEJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class LICKFGAMOEO
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2A82FF0", Offset = "0x2A821F0", VA = "0x182A82FF0")]
	public static void HJMPBPAEJFF(PEKDFCFCENH LHCMKIAHBCL, string CAAILKKDKCI, BMDJOHDFBDL PODPIDDLOCF, Action GBFHENMJIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2A83250", Offset = "0x2A82450", VA = "0x182A83250")]
	public static void HJMPBPAEJFF(PEKDFCFCENH LHCMKIAHBCL, string CAAILKKDKCI, ILOOFJFGECE JLJIKEELLJE, Action GBFHENMJIDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DDDGJOKMEDO(typeof(BODOIGGIMGD), new string[] { })]
public class BNJILILMOAP : DCLDDNDKGBL, BODOIGGIMGD
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x262A1B0", Offset = "0x26293B0", VA = "0x18262A1B0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x262A0D0", Offset = "0x26292D0", VA = "0x18262A0D0", Slot = "5")]
	public void ANKMCEGBNDG(BMDJOHDFBDL KHBBAOCDKFN, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x262A140", Offset = "0x2629340", VA = "0x18262A140", Slot = "6")]
	public void IDLJALAKIGD(BMDJOHDFBDL KHBBAOCDKFN, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x262A230", Offset = "0x2629430", VA = "0x18262A230", Slot = "7")]
	public void PCJBNLGGOBJ(BMDJOHDFBDL KHBBAOCDKFN, int NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x24494E0", Offset = "0x24486E0", VA = "0x1824494E0")]
	private void BNDJKAKDCIM<T>(BMDJOHDFBDL KHBBAOCDKFN, bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x24495D0", Offset = "0x24487D0", VA = "0x1824495D0")]
	private void BNDJKAKDCIM<T>(BMDJOHDFBDL KHBBAOCDKFN, T JFGIPFOFKHL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public BNJILILMOAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DDDGJOKMEDO(typeof(AICIPFJDBCL), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public sealed class AICIPFJDBCL : DCLDDNDKGBL, PJIPLCPBFIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class HELEOOFNLEE : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
		public AICIPFJDBCL <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public HELEOOFNLEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2220770", Offset = "0x221F970", VA = "0x182220770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2220350", Offset = "0x221F550", VA = "0x182220350", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2220300", Offset = "0x221F500", VA = "0x182220300")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2220730", Offset = "0x221F930", VA = "0x182220730", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2220690", Offset = "0x221F890", VA = "0x182220690", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2220690", Offset = "0x221F890", VA = "0x182220690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Dictionary<SerializableGuid, LGOCNEHIALI> EDGNIEHABPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly List<SerializableGuid> IPBPHMKEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<SerializableGuid, GameObject> MKADFFOHHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private IHPPALHFKFG EAAEGPDMONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private AOIKACBNBJM CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private CHOMHKHHFDB KAKKOCFGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private LFBNOCAADDA EFGGIEHCPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private HAMPBFOIKKB<LGOCNEHIALI> INCLADNHCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private GameObject HOAFHHEFPDE;

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x26240A0", Offset = "0x26232A0", VA = "0x1826240A0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2624490", Offset = "0x2623690", VA = "0x182624490", Slot = "5")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2623380", Offset = "0x2622580", VA = "0x182623380", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2622EB0", Offset = "0x26220B0", VA = "0x182622EB0")]
	private void BFCMDJADCAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2623520", Offset = "0x2622720", VA = "0x182623520")]
	internal void GBIMPHOKJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x26242B0", Offset = "0x26234B0", VA = "0x1826242B0")]
	private void MCCAKGBKIGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2623FA0", Offset = "0x26231A0", VA = "0x182623FA0")]
	private void IKCJHJMMEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2623960", Offset = "0x2622B60", VA = "0x182623960")]
	[IteratorStateMachine(typeof(HELEOOFNLEE))]
	private IEnumerable<RRCustomPropTag> HBDFNNBDCCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2622EC0", Offset = "0x26220C0", VA = "0x182622EC0")]
	private void CBEBAPHGGGH(BMDJOHDFBDL JHJPAJMEGAG, in LKEBNILDCHH EJOKGCNJEPM, in LKEBNILDCHH FDDLNHNDPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2624170", Offset = "0x2623370", VA = "0x182624170")]
	private void JJOABFDKIHC(SerializableGuid BHKAMCELBPN, GameObject HAAGKPEGEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x26239D0", Offset = "0x2622BD0", VA = "0x1826239D0")]
	private void HCGNIGBLFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2623D80", Offset = "0x2622F80", VA = "0x182623D80")]
	private bool HGJFEILMKBB(LGOCNEHIALI GKKBCECKKHN, Transform OJEMCPHOKBP, out GameObject PEJFNLJIKME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2623F50", Offset = "0x2623150", VA = "0x182623F50")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x26246B0", Offset = "0x26238B0", VA = "0x1826246B0")]
	public AICIPFJDBCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DDDGJOKMEDO(typeof(IHPPALHFKFG), new string[] { })]
[DefaultMember("Item")]
public class HFLLIGODDNM : IHPPALHFKFG, IEnumerable<HADCJDEHJDC>, IEnumerable, DCLDDNDKGBL, PJIPLCPBFIL, ANJJHLMIOKD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[MOHONECELPE]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[MOHONECELPE]
	private EIFIFHHKJPI NPHDLLPIABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private HADCJDEHJDC[] OKOILBCEPLO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x25A5620", Offset = "0x25A4820", VA = "0x1825A5620", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HADCJDEHJDC JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x25A54D0", Offset = "0x25A46D0", VA = "0x1825A54D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x25A55B0", Offset = "0x25A47B0", VA = "0x1825A55B0", Slot = "10")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x25A5790", Offset = "0x25A4990", VA = "0x1825A5790", Slot = "11")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x25A5240", Offset = "0x25A4440", VA = "0x1825A5240")]
	private HADCJDEHJDC CBLICIDEGBO(int NNAODBDJDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x25A5670", Offset = "0x25A4870", VA = "0x1825A5670", Slot = "6")]
	public HADCJDEHJDC LMABDHPJKGG(FAODENBHDMK LPNKBGEMCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x25A54E0", Offset = "0x25A46E0", VA = "0x1825A54E0", Slot = "7")]
	public MCNHINHNBBI HKIJCBIHCIH(FAODENBHDMK LPNKBGEMCBF)
	{
		return default(MCNHINHNBBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x25A53C0", Offset = "0x25A45C0", VA = "0x1825A53C0", Slot = "8")]
	public IEnumerator<HADCJDEHJDC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x25A53C0", Offset = "0x25A45C0", VA = "0x1825A53C0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1E31A70", Offset = "0x1E30C70", VA = "0x181E31A70", Slot = "12")]
	public void NDCMNMAJOBE<TKey, T>(FLNCDPNCALM<TKey, T> BGOCDAGKFNE, [Optional] object JDFBABENAGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x25A5320", Offset = "0x25A4520", VA = "0x1825A5320", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public HFLLIGODDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x25A54D0", Offset = "0x25A46D0", VA = "0x1825A54D0")]
	[CompilerGenerated]
	private HADCJDEHJDC HAEGPFAOCPG(int LHPGLCOPMKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal class KJLHFFFBLOM : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private EntityQuery OMAFKCNFLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x25BFE30", Offset = "0x25BF030", VA = "0x1825BFE30", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x25BFE80", Offset = "0x25BF080", VA = "0x1825BFE80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x25BFF10", Offset = "0x25BF110", VA = "0x1825BFF10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public KJLHFFFBLOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class FNIKNJHGJJF<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(BCOCDICMKNO), new string[] { })]
public class BCOCDICMKNO : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[MOHONECELPE]
	private JGPGIDINFEG NJFMCLNALDN;

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2627B30", Offset = "0x2626D30", VA = "0x182627B30", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2627B10", Offset = "0x2626D10", VA = "0x182627B10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public BCOCDICMKNO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class DisembodiedObjectView : MonoBehaviour, HOFBHJGKIFM
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DILEBBOMEIA
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public BMDJOHDFBDL CFLIMOEMLBM
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xA8E0A0", Offset = "0xA8D2A0", VA = "0x180A8E0A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(BMDJOHDFBDL);
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xA8E090", Offset = "0xA8D290", VA = "0x180A8E090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x27BBB30", Offset = "0x27BAD30", VA = "0x1827BBB30")]
		public void SetName(string JPKENOAMLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public DisembodiedObjectView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class POGDMLLCFJG
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x245ABD0", Offset = "0x2459DD0", VA = "0x18245ABD0")]
	public static void FLCLFCJOIPH(ComponentSystemBase FMGKDHAODCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(CDNOCINFNBD), new string[] { })]
internal sealed class CDNOCINFNBD : AJIFMENAHLG
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public override uint HHJBKGIFHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x11A0D50", Offset = "0x119FF50", VA = "0x1811A0D50")]
	public CDNOCINFNBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class LBCAKBMDALI
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class INOIOHHLEPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public POCHLGNFBCE services;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public INOIOHHLEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2220FA0", Offset = "0x22201A0", VA = "0x182220FA0")]
		internal void HBBAFJPIMLG(DCLDDNDKGBL svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2220F40", Offset = "0x2220140", VA = "0x182220F40")]
		internal void COMANNHHCNO(PJIPLCPBFIL svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x25C1120", Offset = "0x25C0320", VA = "0x1825C1120")]
	public static void MJAHIOACBGL(this World OOHHGMIKJFD, POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x19E9F70", Offset = "0x19E9170", VA = "0x1819E9F70")]
	public static void PAMOGAIHEDP<T>(this World OOHHGMIKJFD, Action<T> BOLLBMEDMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x19E9AF0", Offset = "0x19E8CF0", VA = "0x1819E9AF0")]
	public static void APABKAILFCO<T>(this World OOHHGMIKJFD, Action<T> BOLLBMEDMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x19E9D40", Offset = "0x19E8F40", VA = "0x1819E9D40")]
	public static void APABKAILFCO<T>(IEnumerable<ComponentSystemBase> BLJLNGLFFBB, Action<T> BOLLBMEDMCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DDDGJOKMEDO(typeof(MKDGDMAKODP), new string[] { })]
internal class DKNNPNABIKH : MKDGDMAKODP, DCLDDNDKGBL, IDisposable
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
	private sealed class KKHIGMJPNGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KKHIGMJPNGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2222A80", Offset = "0x2221C80", VA = "0x182222A80")]
		internal object EMPJDBJBMKL((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[MOHONECELPE]
	private AFKHAAIJADF CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[MOHONECELPE]
	private PKKEKIECBNE EECCCGAOPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NativeBitArray OGIGPDCFLCE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IFDCBBODBGC OLOKFOACKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x27B7720", Offset = "0x27B6920", VA = "0x1827B7720", Slot = "4")]
		get
		{
			return default(IFDCBBODBGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IFDCBBODBGC FMFDGLMFPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x27B7360", Offset = "0x27B6560", VA = "0x1827B7360", Slot = "5")]
		get
		{
			return default(IFDCBBODBGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IFDCBBODBGC DLOFCDEOECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x27B7090", Offset = "0x27B6290", VA = "0x1827B7090", Slot = "6")]
		get
		{
			return default(IFDCBBODBGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IFDCBBODBGC OMDGIJHMDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x27B71D0", Offset = "0x27B63D0", VA = "0x1827B71D0", Slot = "7")]
		get
		{
			return default(IFDCBBODBGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IFDCBBODBGC FHIECECDLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x27B73C0", Offset = "0x27B65C0", VA = "0x1827B73C0", Slot = "8")]
		get
		{
			return default(IFDCBBODBGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IFDCBBODBGC LCFKIDEHIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x27B7710", Offset = "0x27B6910", VA = "0x1827B7710", Slot = "9")]
		get
		{
			return default(IFDCBBODBGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IFDCBBODBGC KJJAKHBHFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x27B73D0", Offset = "0x27B65D0", VA = "0x1827B73D0", Slot = "10")]
		get
		{
			return default(IFDCBBODBGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IFDCBBODBGC BJFMFAJHJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x27B7650", Offset = "0x27B6850", VA = "0x1827B7650", Slot = "11")]
		get
		{
			return default(IFDCBBODBGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private int CHJGONDAJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x27B7660", Offset = "0x27B6860", VA = "0x1827B7660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x27B7200", Offset = "0x27B6400", VA = "0x1827B7200", Slot = "12")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x27B7120", Offset = "0x27B6320", VA = "0x1827B7120", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x27B7370", Offset = "0x27B6570", VA = "0x1827B7370")]
	private void KEGAADMFLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x27B73E0", Offset = "0x27B65E0", VA = "0x1827B73E0")]
	private void NIJFECNIEIF(Flag NEPBCPCCOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x27B70A0", Offset = "0x27B62A0", VA = "0x1827B70A0")]
	private IFDCBBODBGC BGGJOLDAFEO(Flag NEPBCPCCOKF)
	{
		return default(IFDCBBODBGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x27B71E0", Offset = "0x27B63E0", VA = "0x1827B71E0")]
	private IFDCBBODBGC HEJPADMJAGK(Flag NEPBCPCCOKF)
	{
		return default(IFDCBBODBGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public DKNNPNABIKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DDDGJOKMEDO(typeof(CFHHLPHHLOO), new string[] { })]
public class LJACPALDIDK : DCLDDNDKGBL, PJIPLCPBFIL, CFHHLPHHLOO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private ALOPNKJDLEE HBHMCMADCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private EMNPBOOGNLC CMEFNIKNDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CJBMEKLNLMM PALBIMEBCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private BAAFMINJIBI PABJNGAKHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private int FILNMGBOIDK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool CABKPJABLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2A83D80", Offset = "0x2A82F80", VA = "0x182A83D80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BMDJOHDFBDL DPBGHLBFFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2A83DD0", Offset = "0x2A82FD0", VA = "0x182A83DD0", Slot = "9")]
		get
		{
			return default(BMDJOHDFBDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2A84420", Offset = "0x2A83620", VA = "0x182A84420", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public OCHPAAEIANL KJFJNDPMFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2A83BA0", Offset = "0x2A82DA0", VA = "0x182A83BA0", Slot = "11")]
		get
		{
			return default(OCHPAAEIANL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2A84420", Offset = "0x2A83620", VA = "0x182A84420", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private uint GFEICLPCFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2A83790", Offset = "0x2A82990", VA = "0x182A83790")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event PBGAIMDLAHE EIOJNCNDJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2A839E0", Offset = "0x2A82BE0", VA = "0x182A839E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2A84380", Offset = "0x2A83580", VA = "0x182A84380", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2A83E10", Offset = "0x2A83010", VA = "0x182A83E10", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2A841E0", Offset = "0x2A833E0", VA = "0x182A841E0", Slot = "5")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2A838F0", Offset = "0x2A82AF0", VA = "0x182A838F0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2A834C0", Offset = "0x2A826C0", VA = "0x182A834C0")]
	private void CCANDJPPFKP(DNPJHPKBIAD JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2A83F10", Offset = "0x2A83110", VA = "0x182A83F10", Slot = "13")]
	public BMDJOHDFBDL LOBKECFHJIB(BMDJOHDFBDL BJPEGONLJEK, BMDJOHDFBDL NPIENNHDDHE)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2A837E0", Offset = "0x2A829E0", VA = "0x182A837E0", Slot = "14")]
	public bool DFLGDIJJHGG(BMDJOHDFBDL BJPEGONLJEK, BMDJOHDFBDL NPIENNHDDHE, out BMDJOHDFBDL ILDPFGGCFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A83C10", Offset = "0x2A82E10", VA = "0x182A83C10", Slot = "15")]
	public void HLCJBDOONLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A83EE0", Offset = "0x2A830E0", VA = "0x182A83EE0", Slot = "16")]
	public void KOMAIKIKCFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A84030", Offset = "0x2A83230", VA = "0x182A84030", Slot = "17")]
	public bool MEMOHFIGJLO(BMDJOHDFBDL BJPEGONLJEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A83A80", Offset = "0x2A82C80", VA = "0x182A83A80")]
	private void FHLJFJJKHDD(BMDJOHDFBDL CBPDIJFOOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public LJACPALDIDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DDDGJOKMEDO(typeof(DNHKLOJOOME), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
internal class DNHKLOJOOME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public void CECMKCOCHKD(string JPKENOAMLIN, EntityManager NMHMIPEFENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public DNHKLOJOOME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class LABAEDMACAA
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x25C0DF0", Offset = "0x25BFFF0", VA = "0x1825C0DF0")]
	public static bool KFAGNCOPLIN(BGNCONALOOG FILDAHGGHEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x25C0BB0", Offset = "0x25BFDB0", VA = "0x1825C0BB0")]
	public static BGNCONALOOG JJOABFDKIHC(GameObject HAAGKPEGEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x25C09D0", Offset = "0x25BFBD0", VA = "0x1825C09D0")]
	public static BGNCONALOOG JJOABFDKIHC(GameObject HAAGKPEGEHP, NACALKPEILN EPGIOGIKNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x25C0EA0", Offset = "0x25C00A0", VA = "0x1825C0EA0")]
	public static bool MBBDBHDECCK(GameObject AEMIIPGDKOE, string CEIPDMHAAOM, bool FFMILDILFKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal readonly struct PBJKHKOIGNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly ComponentSystemBase FMGKDHAODCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly ProfilerMarker OBEGNKLMOHF;

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DF20", Offset = "0x2A9D120", VA = "0x182A9DF20")]
	public PBJKHKOIGNG(World OOHHGMIKJFD, Type FBNKHAJKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DEA0", Offset = "0x2A9D0A0", VA = "0x182A9DEA0")]
	public void AFOMIFHCAEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(CPNCOLPGCPB), new string[] { })]
internal sealed class CPNCOLPGCPB : DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private AKFLDBGLGDA MKADFFOHHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[MOHONECELPE]
	private EFIGCPCEPCG AOHLHGPBOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[MOHONECELPE]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[MOHONECELPE]
	private LFBNOCAADDA KGNNKALBBFF;

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2632980", Offset = "0x2631B80", VA = "0x182632980", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2633120", Offset = "0x2632320", VA = "0x182633120")]
	public ILOOFJFGECE OGHNPGAIFHF(ILOOFJFGECE LIKELALOOEJ, Allocator KPFKDHLBOGB)
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2632F80", Offset = "0x2632180", VA = "0x182632F80")]
	private void MMJJPDKPFCJ(NativeParallelMultiHashMap<int, (BMDJOHDFBDL src, BMDJOHDFBDL dst)> MKGMLBHAGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x26324F0", Offset = "0x26316F0", VA = "0x1826324F0")]
	private void HJIJBMDJIAD(NativeParallelMultiHashMap<int, (BMDJOHDFBDL src, BMDJOHDFBDL dst)> MKGMLBHAGMB, int GLKDKMADKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2632D80", Offset = "0x2631F80", VA = "0x182632D80")]
	private void MHHFBIBNJMA(NativeParallelMultiHashMap<int, (BMDJOHDFBDL src, BMDJOHDFBDL dst)> MKGMLBHAGMB, int GLKDKMADKLI, DCLNFEIOJHB EAAEGPDMONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2632A30", Offset = "0x2631C30", VA = "0x182632A30")]
	private NativeParallelMultiHashMap<int, (BMDJOHDFBDL, BMDJOHDFBDL)> LAGBICNEAPC(Allocator KPFKDHLBOGB, ILOOFJFGECE LIKELALOOEJ, out ILOOFJFGECE JEHLMNAAMNI)
	{
		return default(NativeParallelMultiHashMap<int, (BMDJOHDFBDL, BMDJOHDFBDL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public CPNCOLPGCPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DDDGJOKMEDO(typeof(HOIONLAMHJM), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public class HOIONLAMHJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Dictionary<EKGFPCGJLIK, string> BJFDLBAAIMD;

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x25A9910", Offset = "0x25A8B10", VA = "0x1825A9910")]
	public GameObject HHAPMFOBOME(EKGFPCGJLIK NONIDCJCBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x25A99E0", Offset = "0x25A8BE0", VA = "0x1825A99E0")]
	public HOIONLAMHJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class CCPMGLHJAHE<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[LJJFMBKPAEC(CCDGJKNFPNB.PhotonRoom)]
[DDDGJOKMEDO(typeof(ADMPGHOFGDK), new string[] { })]
public class ADMPGHOFGDK : OHFLHEPJPJP, PNKPNDDLHPG, DCLDDNDKGBL, PJIPLCPBFIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private AOIKACBNBJM CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private GFNGPKFFJEL KKMEEDAFBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NativeList<int> EEMNLIHOIGA;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2620A10", Offset = "0x261FC10", VA = "0x182620A10", Slot = "4")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2620960", Offset = "0x261FB60", VA = "0x182620960", Slot = "5")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2620A70", Offset = "0x261FC70", VA = "0x182620A70", Slot = "6")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x26206D0", Offset = "0x261F8D0", VA = "0x1826206D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2620790", Offset = "0x261F990", VA = "0x182620790")]
	public void HHHCNAMONOK(NativeParallelHashSet<int> NANPLDNPBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x26209D0", Offset = "0x261FBD0", VA = "0x1826209D0")]
	public void KAMAIEAEKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public ADMPGHOFGDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DDDGJOKMEDO(typeof(CMDPJABIGOB), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal class CMDPJABIGOB : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly PEKDFCFCENH JPBCLIIMIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[MOHONECELPE]
	private FLAEPGHGFAB CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[MOHONECELPE]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[MOHONECELPE]
	private HNMHAJLPHMH AMPOACOBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private DFFEELNDGLN KAKKOCFGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private EntityQuery HAHPCKABNEG;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x262F3E0", Offset = "0x262E5E0", VA = "0x18262F3E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2630ED0", Offset = "0x26300D0", VA = "0x182630ED0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x262FF50", Offset = "0x262F150", VA = "0x18262FF50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x262FF60", Offset = "0x262F160", VA = "0x18262FF60")]
	public LGMOGAKCIAN EEOIJHPMINF(IEnumerable<EHDODNDLPHI> DOHHLAIHOPN)
	{
		return default(LGMOGAKCIAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x262FCC0", Offset = "0x262EEC0", VA = "0x18262FCC0")]
	public static bool CLIEGFHLANF(EHDODNDLPHI DMFMJBFFPPI, out NACALKPEILN EPGIOGIKNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x262EF00", Offset = "0x262E100", VA = "0x18262EF00")]
	private LGMOGAKCIAN APNINLNFMGI(IEnumerable<EHDODNDLPHI> DOHHLAIHOPN)
	{
		return default(LGMOGAKCIAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2630CF0", Offset = "0x262FEF0", VA = "0x182630CF0")]
	private (List<EHDODNDLPHI>, int[], int) HMCGOACCMEB(IEnumerable<EHDODNDLPHI> DOHHLAIHOPN)
	{
		return default((List<EHDODNDLPHI>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x262FE10", Offset = "0x262F010", VA = "0x18262FE10")]
	private Dictionary<NACALKPEILN, (EHDODNDLPHI, int)> CNMPEOFCHCM(IEnumerable<EHDODNDLPHI> DOHHLAIHOPN, Entity GIPDACIEGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2631200", Offset = "0x2630400", VA = "0x182631200")]
	private void LKJLLPABHCF(Dictionary<NACALKPEILN, (EHDODNDLPHI request, int srcIndex)> JODMKJKDNCL, IEnumerable<EHDODNDLPHI> DOHHLAIHOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x262F430", Offset = "0x262E630", VA = "0x18262F430")]
	private void BCNLBMFGHOK(Dictionary<NACALKPEILN, (EHDODNDLPHI request, int srcIndex)> JODMKJKDNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2630070", Offset = "0x262F270", VA = "0x182630070")]
	private void FGCKNCFBHEI(Dictionary<NACALKPEILN, (EHDODNDLPHI request, int srcIndex)> JODMKJKDNCL, NACALKPEILN EPGIOGIKNGK, string JPKENOAMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x26305D0", Offset = "0x262F7D0", VA = "0x1826305D0")]
	private void GAHMHOFFMAE(Dictionary<NACALKPEILN, (EHDODNDLPHI request, int srcIndex)> JODMKJKDNCL, Entity GIPDACIEGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x262F610", Offset = "0x262E810", VA = "0x18262F610")]
	private (List<EHDODNDLPHI>, int[], int) BKBIFHCJPII(Dictionary<NACALKPEILN, (EHDODNDLPHI request, int srcIndex)> JODMKJKDNCL, Entity GIPDACIEGMF)
	{
		return default((List<EHDODNDLPHI>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2631570", Offset = "0x2630770", VA = "0x182631570")]
	private void MIPAHFJPEJN(Dictionary<NACALKPEILN, (EHDODNDLPHI request, int srcIndex)> JODMKJKDNCL, List<EHDODNDLPHI> GOKNPLHINEM, int[] BLHCBNMJABF, NativeArray<Entity> IBGFBPGPJKP, NativeList<NACALKPEILN> FIPCNCFGHMC, NativeList<Entity> OEEAGFCAOKP, Entity GIPDACIEGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2631130", Offset = "0x2630330", VA = "0x182631130")]
	private static bool KNDEMEKBKJA(Entity BLNICJMKCEF, ComponentDataFromEntity<BGFGOLHGEPN> KPJIDCHEFGK, Entity GIPDACIEGMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x262EBB0", Offset = "0x262DDB0", VA = "0x18262EBB0")]
	private void APCIPODBNPE(Dictionary<NACALKPEILN, (EHDODNDLPHI request, int srcIndex)> JODMKJKDNCL, List<EHDODNDLPHI> GOKNPLHINEM, int[] BLHCBNMJABF, NativeList<Entity> OEEAGFCAOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x262E9A0", Offset = "0x262DBA0", VA = "0x18262E9A0")]
	private NativeList<NACALKPEILN> AFMGEIKMMBE(Dictionary<NACALKPEILN, (EHDODNDLPHI request, int srcIndex)> JODMKJKDNCL)
	{
		return default(NativeList<NACALKPEILN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2630B00", Offset = "0x262FD00", VA = "0x182630B00")]
	private NativeArray<Entity> GHPJCCECHKE(NativeList<NACALKPEILN> FIPCNCFGHMC)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x26309E0", Offset = "0x262FBE0", VA = "0x1826309E0")]
	private static void GEGMMIIDHDJ(Dictionary<NACALKPEILN, (EHDODNDLPHI request, int srcIndex)> JODMKJKDNCL, NACALKPEILN EPGIOGIKNGK, EHDODNDLPHI DMFMJBFFPPI, string JPKENOAMLIN, int JBBNJDLJKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x262FEC0", Offset = "0x262F0C0", VA = "0x18262FEC0")]
	private void COBOPGBKFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public CMDPJABIGOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(GLHCMEBBKOL), new string[] { })]
public class GLHCMEBBKOL : PNKPNDDLHPG, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[MOHONECELPE]
	private JCKOIKCNGOK JMKJGIHBADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool OJMDAEOGALN;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public TimeData OALAGKEBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x27D0B70", Offset = "0x27CFD70", VA = "0x1827D0B70")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x27D0CD0", Offset = "0x27CFED0", VA = "0x1827D0CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KPJPMALDLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x94D950", Offset = "0x94CB50", VA = "0x18094D950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1B47930", Offset = "0x1B46B30", VA = "0x181B47930", Slot = "4")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x27D0BE0", Offset = "0x27CFDE0", VA = "0x1827D0BE0", Slot = "5")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x27D0C30", Offset = "0x27CFE30", VA = "0x1827D0C30")]
	public void LOODLEHPDLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	public void IAHENDCDCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public GLHCMEBBKOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DDDGJOKMEDO(typeof(ALOPNKJDLEE), new string[] { })]
public class GOCLELMJPNO : ALOPNKJDLEE, OHFLHEPJPJP, PNKPNDDLHPG, DCLDDNDKGBL, PJIPLCPBFIL, IDisposable, GOCLELMJPNO.CMPODPDMBGA
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal interface CMPODPDMBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HEDHGBHBDBH(global::ODALGMFMJHI GGOJAFBHOED);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private CPECIHFFCAK AEILOOJABFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private EINAEGLAJFO AOHLHGPBOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private MGGGBEIHFIJ OJKDJMFOHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private global::ODALGMFMJHI HNMNNCDFKAI;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private HAMPBFOIKKB<BMDJOHDFBDL> OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9ED510", Offset = "0x9EC710", VA = "0x1809ED510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x27D0DC0", Offset = "0x27CFFC0", VA = "0x1827D0DC0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<IIJEOPOHPBE> LFHCJLBBJPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x27D12E0", Offset = "0x27D04E0", VA = "0x1827D12E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x27D0E90", Offset = "0x27D0090", VA = "0x1827D0E90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1539990", Offset = "0x1538B90", VA = "0x181539990", Slot = "17")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x27D14D0", Offset = "0x27D06D0", VA = "0x1827D14D0", Slot = "18")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x27D19F0", Offset = "0x27D0BF0", VA = "0x1827D19F0", Slot = "19")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8C35B0", Offset = "0x8C27B0", VA = "0x1808C35B0", Slot = "21")]
	private void IGMFDOLCDMK(global::ODALGMFMJHI GGOJAFBHOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x15398D0", Offset = "0x1538AD0", VA = "0x1815398D0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x27D1AE0", Offset = "0x27D0CE0", VA = "0x1827D1AE0")]
	private BMDJOHDFBDL MOFMBJBKHDP(Entity BLNICJMKCEF)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x27D11C0", Offset = "0x27D03C0", VA = "0x1827D11C0", Slot = "6")]
	public BMDJOHDFBDL ELNKALNLELD(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x27D15A0", Offset = "0x27D07A0", VA = "0x1827D15A0", Slot = "7")]
	public void LANDOEMDGKM(ref List<BMDJOHDFBDL> EBANKOKIHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x27D1C20", Offset = "0x27D0E20", VA = "0x1827D1C20", Slot = "11")]
	public int PIEOLGNFKFJ(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x27D0EF0", Offset = "0x27D00F0", VA = "0x1827D0EF0", Slot = "12")]
	public ILOOFJFGECE COLLMPJBLJN(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x27D1830", Offset = "0x27D0A30", VA = "0x1827D1830", Slot = "15")]
	public BMDJOHDFBDL LOBKECFHJIB(BMDJOHDFBDL BJPEGONLJEK, BMDJOHDFBDL NPIENNHDDHE)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x27D1010", Offset = "0x27D0210", VA = "0x1827D1010", Slot = "16")]
	public bool DFLGDIJJHGG(BMDJOHDFBDL BJPEGONLJEK, BMDJOHDFBDL NPIENNHDDHE, out BMDJOHDFBDL ILDPFGGCFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x27D1430", Offset = "0x27D0630", VA = "0x1827D1430", Slot = "8")]
	public BMDJOHDFBDL FOMIAGBPCIG(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x27D1340", Offset = "0x27D0540", VA = "0x1827D1340", Slot = "14")]
	public bool FGHHNJKOBON(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL FMMAMOIMPOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x27D1B30", Offset = "0x27D0D30", VA = "0x1827D1B30", Slot = "13")]
	public bool OOGFDOGPFLJ(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL FGNNHDMBMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x27D0E10", Offset = "0x27D0010", VA = "0x1827D0E10", Slot = "9")]
	public bool BPMJPILKAOG(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL OJEMCPHOKBP, bool BJCOCCDMHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x27D17D0", Offset = "0x27D09D0", VA = "0x1827D17D0", Slot = "10")]
	public bool LKLFJDNGDMK(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL OJEMCPHOKBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public GOCLELMJPNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MIGIDCOOAJI : BDNEDPOFMOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> NDNMIEGGHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int LMKEMKPKIOL;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> GFOFCACBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x99B850", Offset = "0x99AA50", VA = "0x18099B850", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GDLPBMDOFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B2840", Offset = "0x8B1A40", VA = "0x1808B2840", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D9F0", Offset = "0x2A8CBF0", VA = "0x182A8D9F0")]
	public MIGIDCOOAJI(NativeArray<EntityRemapUtility.EntityRemapInfo> NDNMIEGGHLI, int LMKEMKPKIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D910", Offset = "0x2A8CB10", VA = "0x182A8D910", Slot = "6")]
	public BMDJOHDFBDL MHDKDDDADDG(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D9B0", Offset = "0x2A8CBB0", VA = "0x182A8D9B0", Slot = "8")]
	public LocalId MHDKDDDADDG(LocalId BLNICJMKCEF)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D8B0", Offset = "0x2A8CAB0", VA = "0x182A8D8B0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[KFAABLOJCJD(typeof(PKKEKIECBNE))]
[DDDGJOKMEDO(typeof(FLFMIDDEJIH), new string[] { })]
public class KGMPCOJKFJJ : FLFMIDDEJIH, FHBJALEEHFO, PKKEKIECBNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker NCNGKCCDCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private BHIKEJGKPLP DAJKBHKJPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private HEDLOJKNBDM BLJLNGLFFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private OEFLNLBOHFB CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private JHHABMNLDEN NHGBHEDDDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private GFNGPKFFJEL OFIGJNDNAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public BHIKEJGKPLP FBCEAFFBAED
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public OEFLNLBOHFB OIIAJNFHDML
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public GFNGPKFFJEL BGLACJCFDJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA32400", Offset = "0xA31600", VA = "0x180A32400", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool JLHLDBCJPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x25BEE80", Offset = "0x25BE080", VA = "0x1825BEE80", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public JKBMNBGOHLH DLPNNLBMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xB4DB40", Offset = "0xB4CD40", VA = "0x180B4DB40", Slot = "9")]
		get
		{
			return default(JKBMNBGOHLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x25BEFD0", Offset = "0x25BE1D0", VA = "0x1825BEFD0")]
	public static KGMPCOJKFJJ JKAAGGANCJG(BHIKEJGKPLP DAJKBHKJPOA, BMMLCIMMEMO HCCLEJHCLJP = BMMLCIMMEMO.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void BKEHDGBLOJD(BHIKEJGKPLP DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void EKBEAOGIGNC(BHIKEJGKPLP DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x25BED50", Offset = "0x25BDF50", VA = "0x1825BED50", Slot = "10")]
	public void AOIILMDJJDP(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x1539990", Offset = "0x1538B90", VA = "0x181539990")]
	private void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x25BEF00", Offset = "0x25BE100", VA = "0x1825BEF00")]
	private void JHNELGEJDAH(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x25BEEA0", Offset = "0x25BE0A0", VA = "0x1825BEEA0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public KGMPCOJKFJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class LJAIPEMMLAI
{
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, HOFBHJGKIFM
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly PEKDFCFCENH LHCMKIAHBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private IANCKMHPHEB prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private BMDJOHDFBDL JHJPAJMEGAG;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual IANCKMHPHEB GIBGFMAHINI
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C20", Offset = "0x8C7E20", VA = "0x1808C8C20", Slot = "6")]
			get
			{
				return default(IANCKMHPHEB);
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x902EF0", Offset = "0x9020F0", VA = "0x180902EF0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public BMDJOHDFBDL CFLIMOEMLBM
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xFB89A0", Offset = "0xFB7BA0", VA = "0x180FB89A0", Slot = "5")]
			get
			{
				return default(BMDJOHDFBDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool DILEBBOMEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAC0", Offset = "0x7EACC0", VA = "0x1807EBAC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x7EB9E0", Offset = "0x7EABE0", VA = "0x1807EB9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal Entity LFHLHOCLJPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x246A220", Offset = "0x2469420", VA = "0x18246A220")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		internal JPLJDCFLDIF DDOKPBDICDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x246A210", Offset = "0x2469410", VA = "0x18246A210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		internal HNMHAJLPHMH OACPGOFIBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2469D40", Offset = "0x2468F40", VA = "0x182469D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x2469D30", Offset = "0x2468F30", VA = "0x182469D30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x246A230", Offset = "0x2469430", VA = "0x18246A230")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2469E90", Offset = "0x2469090", VA = "0x182469E90")]
		internal void KCEHONPEIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2469DC0", Offset = "0x2468FC0", VA = "0x182469DC0")]
		private bool EPMFOHOIGDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2469E60", Offset = "0x2469060", VA = "0x182469E60")]
		private void GJOOMGPCMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x246A230", Offset = "0x2469430", VA = "0x18246A230")]
		internal void KOGPOOGFLGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x246A340", Offset = "0x2469540", VA = "0x18246A340")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x246A4A0", Offset = "0x24696A0", VA = "0x18246A4A0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class DMOFNCAFEEC : JFNDONHKHIJ
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x27B9580", Offset = "0x27B8780", VA = "0x1827B9580", Slot = "5")]
	public override Action GHBBLAOCPNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void IEDDFLGAAKH<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x27B94F0", Offset = "0x27B86F0", VA = "0x1827B94F0")]
	[UnityEngine.Scripting.Preserve]
	public void APHCOPBMBGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x27B7EF0", Offset = "0x27B70F0", VA = "0x1827B7EF0")]
	protected DMOFNCAFEEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[DDDGJOKMEDO(typeof(MMIPKKPAOLG), new string[] { })]
public class MPIEEOACBEN : MMIPKKPAOLG, IDisposable, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[MOHONECELPE]
	private MNCDKBBELAG OCNFBKOIOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[MOHONECELPE]
	private KKJKOBMDCHM BNNJAPHFIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private World MLDBPMLFENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private World DGIKFFNILOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool EFPOPENDPFH;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public World OFIFOCNNODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public World EPJHBKFCPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2A93E70", Offset = "0x2A93070", VA = "0x182A93E70", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x127DD60", Offset = "0x127CF60", VA = "0x18127DD60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2A941B0", Offset = "0x2A933B0", VA = "0x182A941B0", Slot = "10")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2A943D0", Offset = "0x2A935D0", VA = "0x182A943D0")]
	private void JKAAGGANCJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2A93EB0", Offset = "0x2A930B0", VA = "0x182A93EB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2A93E90", Offset = "0x2A93090", VA = "0x182A93E90", Slot = "8")]
	public ComponentSystemBase CIKABCGCJMD(Type FBNKHAJKFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MPIEEOACBEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(HJCCJNBKKCH), new string[] { })]
public class HJCCJNBKKCH : DCLDDNDKGBL, DFEMCICPEOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct BEGJIHEFBJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private NativeArray<int> PPLDLOCIFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private NativeArray<int> FGPMAMJJHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Dictionary<ComponentSystemBase, int> NHLFOMPGMGO;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2217A70", Offset = "0x2216C70", VA = "0x182217A70")]
		public BEGJIHEFBJJ(NativeArray<int> PPLDLOCIFIB, NativeArray<int> FGPMAMJJHFD, Dictionary<ComponentSystemBase, int> NHLFOMPGMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2217940", Offset = "0x2216B40", VA = "0x182217940")]
		public static void MMAPGIEOLNJ(World OOHHGMIKJFD, CCDGJKNFPNB GDCCFNINLPP, NativeArray<int> PPLDLOCIFIB, NativeArray<int> FGPMAMJJHFD, Dictionary<ComponentSystemBase, int> NHLFOMPGMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2217660", Offset = "0x2216860", VA = "0x182217660")]
		public void DNPDKKFECLI(IEnumerable<ComponentSystemBase> BLJLNGLFFBB, CCDGJKNFPNB GDCCFNINLPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class EABOEFGEDCM : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
		public HJCCJNBKKCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private int <i>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public EABOEFGEDCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x221C530", Offset = "0x221B730", VA = "0x18221C530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x221C700", Offset = "0x221B900", VA = "0x18221C700", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x221C650", Offset = "0x221B850", VA = "0x18221C650", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x221C650", Offset = "0x221B850", VA = "0x18221C650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly PEKDFCFCENH GFKHEMKIJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private World OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private POCHLGNFBCE DAJKBHKJPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private NativeArray<int> HFGBJBNMMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private NativeArray<int> AEOJAEDOEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int KBIJDJHCEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private CCDGJKNFPNB LPNBDPDIBEH;

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x25A8250", Offset = "0x25A7450", VA = "0x1825A8250", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x25A76B0", Offset = "0x25A68B0", VA = "0x1825A76B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x25A81C0", Offset = "0x25A73C0", VA = "0x1825A81C0")]
	[IteratorStateMachine(typeof(EABOEFGEDCM))]
	private IEnumerable<ComponentSystemBase> IIGABDOJFBP(int KACNNGPFBFG, int GLFOLGBEBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x25A7830", Offset = "0x25A6A30", VA = "0x1825A7830", Slot = "5")]
	public void EIOJNCNDJBC(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x25A7830", Offset = "0x25A6A30", VA = "0x1825A7830")]
	private void OPHBBKJJBCM(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x25A83F0", Offset = "0x25A75F0", VA = "0x1825A83F0")]
	public void OPHBBKJJBCM(CCDGJKNFPNB IBKMLLGLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x25A78B0", Offset = "0x25A6AB0", VA = "0x1825A78B0")]
	private void FPBLDONKFMN(CCDGJKNFPNB IBKMLLGLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x25A7B50", Offset = "0x25A6D50", VA = "0x1825A7B50")]
	private void FPGPKEFIOKG(CCDGJKNFPNB IBKMLLGLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x25A8520", Offset = "0x25A7720", VA = "0x1825A8520")]
	private void PIKDKBKBLJK(CCDGJKNFPNB IBKMLLGLNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x25A8330", Offset = "0x25A7530", VA = "0x1825A8330")]
	private void LMPHPNECJKO(int KACNNGPFBFG, int GLFOLGBEBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x25A8100", Offset = "0x25A7300", VA = "0x1825A8100")]
	private void IGEBJCANLBM(int KACNNGPFBFG, int GLFOLGBEBEM, bool EECCCGAOPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x25A8500", Offset = "0x25A7700", VA = "0x1825A8500")]
	private int OPNLMLIDBDD(CCDGJKNFPNB IBKMLLGLNFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x25A7BF0", Offset = "0x25A6DF0", VA = "0x1825A7BF0")]
	private bool ICHJJDFFDEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x25A7740", Offset = "0x25A6940", VA = "0x1825A7740")]
	private Dictionary<ComponentSystemBase, int> EBAGEIKGLAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x25A75B0", Offset = "0x25A67B0", VA = "0x1825A75B0")]
	private void AMKHFOIMPII(NativeArray<int> PPLDLOCIFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x25A7500", Offset = "0x25A6700", VA = "0x1825A7500")]
	private void AIONMJAIDGK(NativeArray<int> FGPMAMJJHFD, NativeArray<int> PPLDLOCIFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x25A75F0", Offset = "0x25A67F0", VA = "0x1825A75F0")]
	private static CCDGJKNFPNB DFADFKNHIBB(Type FBNKHAJKFLM, CCDGJKNFPNB HMGHIIACOGF)
	{
		return default(CCDGJKNFPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x25A8660", Offset = "0x25A7860", VA = "0x1825A8660")]
	public HJCCJNBKKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x25A74A0", Offset = "0x25A66A0", VA = "0x1825A74A0")]
	[CompilerGenerated]
	private void AFLJELJMMKN(DCLDDNDKGBL LFEKOKCEFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x25A7650", Offset = "0x25A6850", VA = "0x1825A7650")]
	[CompilerGenerated]
	private void DJGNAAECEOA(PJIPLCPBFIL LFEKOKCEFGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class OFACNKJJHBL : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C5F0", Offset = "0x2A9B7F0", VA = "0x182A9C5F0", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C830", Offset = "0x2A9BA30", VA = "0x182A9C830")]
	[UnityEngine.Scripting.Preserve]
	private void NFKFNLLMGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public OFACNKJJHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DDDGJOKMEDO(typeof(GFNGPKFFJEL), new string[] { })]
public class PKAIOJDIOOC : GFNGPKFFJEL, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly PEKDFCFCENH HMFKDAPADAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private BHIKEJGKPLP DAJKBHKJPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private JHHABMNLDEN NHGBHEDDDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private OEFLNLBOHFB CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private FLFMIDDEJIH ONMNMDAFEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private DFFEELNDGLN KAKKOCFGLCD;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool ILEECDDANLI
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x24553C0", Offset = "0x24545C0", VA = "0x1824553C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action EGBHDCJEJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2454CC0", Offset = "0x2453EC0", VA = "0x182454CC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2454D60", Offset = "0x2453F60", VA = "0x182454D60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2454F70", Offset = "0x2454170", VA = "0x182454F70", Slot = "15")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2455430", Offset = "0x2454630", VA = "0x182455430", Slot = "11")]
	public Task OEPDCGJGIKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2454E70", Offset = "0x2454070", VA = "0x182454E70", Slot = "12")]
	public Task HGOGONEOKDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2454E00", Offset = "0x2454000", VA = "0x182454E00", Slot = "13")]
	public Task HDONPMFCPHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2455100", Offset = "0x2454300", VA = "0x182455100", Slot = "8")]
	public void LOAPFNKGENF(bool EECCCGAOPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x24554A0", Offset = "0x24546A0", VA = "0x1824554A0", Slot = "9")]
	public bool OMHHDPFHBOM(ByteString CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x2454EE0", Offset = "0x24540E0", VA = "0x182454EE0", Slot = "6")]
	public void IAMEPKNIOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x98AE00", Offset = "0x98A000", VA = "0x18098AE00", Slot = "7")]
	public void GENJNDHFMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2455040", Offset = "0x2454240", VA = "0x182455040", Slot = "14")]
	public void LFDHBMCCKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public PKAIOJDIOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[Flags]
public enum BMMLCIMMEMO
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
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
[DDDGJOKMEDO(typeof(NGFLDMJJNII), new string[] { })]
public class NGFLDMJJNII : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[MOHONECELPE]
	private DNKBKNOAAGM NGKPOKOIJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[MOHONECELPE]
	private HJCCJNBKKCH BODFKEMMOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[MOHONECELPE]
	private JGPGIDINFEG NJFMCLNALDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[MOHONECELPE]
	private MGGGBEIHFIJ OJKDJMFOHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2A97EF0", Offset = "0x2A970F0", VA = "0x182A97EF0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2A97E50", Offset = "0x2A97050", VA = "0x182A97E50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x2A97D90", Offset = "0x2A96F90", VA = "0x182A97D90")]
	private void BCAHIAGBCIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2A97E50", Offset = "0x2A97050", VA = "0x182A97E50")]
	private void JFKGMINPCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2A97EA0", Offset = "0x2A970A0", VA = "0x182A97EA0")]
	private void GGPGECMGHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public NGFLDMJJNII()
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

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public EntityReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[DDDGJOKMEDO(typeof(DJIHMLHHNFC), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal class DJIHMLHHNFC : DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private EIFIFHHKJPI NPHDLLPIABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private IHPPALHFKFG IPMJKCFABPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private JOHINJPAKCH CALNFLAMDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[MOHONECELPE]
	private LFBNOCAADDA EFGGIEHCPKE;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public IOPCPGDBHOD BFIDGCAACMO
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x89A3F0", VA = "0x18089B1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x26396C0", Offset = "0x26388C0", VA = "0x1826396C0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2639620", Offset = "0x2638820", VA = "0x182639620")]
	private void EDIOLHNANAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2639550", Offset = "0x2638750", VA = "0x182639550")]
	public PLBLNCEJEDA CMIBIICIECB(FAODENBHDMK JPKENOAMLIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x29D3BC0", Offset = "0x29D2DC0", VA = "0x1829D3BC0")]
	public KDJHKMDPMBJ<T> MFFGPFFECON<T>(FAODENBHDMK JPKENOAMLIN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public DJIHMLHHNFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal static class KAAIHKHGHKK
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x23E3F60", Offset = "0x23E3160", VA = "0x1823E3F60")]
	public static LGOHODJFODN<T> CMIBIICIECB<T>(this DJIHMLHHNFC OOKHKFKHNMJ, CPFKEJJKDHF<T> JPKENOAMLIN) where T : struct
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
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D4D0", Offset = "0x2A9C6D0", VA = "0x182A9D4D0")]
		public static ObjectModelConfigAsset PLEDDKKABHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x99A150", Offset = "0x999350", VA = "0x18099A150")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class JFNDONHKHIJ : AGFJNPCJKNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly MethodInfo GFHDHDHKIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Type[] LCGFCGNMPHN;

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x25B5380", Offset = "0x25B4580", VA = "0x1825B5380")]
	public JFNDONHKHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action GHBBLAOCPNJ();

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x25B5340", Offset = "0x25B4540", VA = "0x1825B5340")]
	public MethodInfo NDCEJOAICKD(Action AMEKOPCKNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x25B5190", Offset = "0x25B4390", VA = "0x1825B5190", Slot = "4")]
	public void JJOABFDKIHC(Type FBNKHAJKFLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[KFAABLOJCJD(typeof(LHDFLJJMNGO))]
[DDDGJOKMEDO(typeof(DFFEELNDGLN), new string[] { })]
internal class LHDFLJJMNGO : DFFEELNDGLN, IDisposable, DCLDDNDKGBL, DFEMCICPEOE
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class ICAIICOAFID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public LHDFLJJMNGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ICAIICOAFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2220BE0", Offset = "0x221FDE0", VA = "0x182220BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly PEKDFCFCENH HMFKDAPADAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[MOHONECELPE]
	private OEFLNLBOHFB CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[MOHONECELPE]
	private GFNGPKFFJEL OFIGJNDNAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[MOHONECELPE]
	private BEAJGHBNKNP GMLEHOPIEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[MOHONECELPE]
	private JHHABMNLDEN NHGBHEDDDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private FLFMIDDEJIH ONMNMDAFEKP;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool OLGOLJPMKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA32400", Offset = "0xA31600", VA = "0x180A32400", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA32340", Offset = "0xA31540", VA = "0x180A32340", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool GAKKDGNNPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xCBA910", Offset = "0xCB9B10", VA = "0x180CBA910", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool HJGBLHHMELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA32410", Offset = "0xA31610", VA = "0x180A32410", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA31DB0", Offset = "0xA30FB0", VA = "0x180A31DB0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public JHFDKBHOKBE LGOIABLEFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8C35B0", Offset = "0x8C27B0", VA = "0x1808C35B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2A82B10", Offset = "0x2A81D10", VA = "0x182A82B10", Slot = "16")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2A81FF0", Offset = "0x2A811F0", VA = "0x182A81FF0", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2A82560", Offset = "0x2A81760", VA = "0x182A82560", Slot = "8")]
	public JONKJOHGAPG FDOAEHLNAKO(bool FCKAPKLMOAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2A81E20", Offset = "0x2A81020", VA = "0x182A81E20")]
	public JONKJOHGAPG DBCKJGNHKIP(IEnumerable<BMDJOHDFBDL> BOIJHJLHIPE, in LBIKKMMNADH CPAEGLDKAOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2A82900", Offset = "0x2A81B00", VA = "0x182A82900", Slot = "10")]
	public KPICKPJENBH INIAGPEAOOE(ByteString CCBKAEHNCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2A82050", Offset = "0x2A81250", VA = "0x182A82050")]
	public JNHLGEOHJON EBNJLKABHDP(ByteString CCBKAEHNCPH, BMDJOHDFBDL OJEMCPHOKBP, in LBIKKMMNADH LLCBNCMAJAP, KEAMHPDKNJO NEAPKBOPGJI, bool DAIHICNGAAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2A82740", Offset = "0x2A81940", VA = "0x182A82740", Slot = "12")]
	public void IJJOAOJLFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2A82280", Offset = "0x2A81480", VA = "0x182A82280", Slot = "14")]
	public LGMOGAKCIAN EEOIJHPMINF(IEnumerable<EHDODNDLPHI> BKLFKAMPCOO)
	{
		return default(LGMOGAKCIAN);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2A82E20", Offset = "0x2A82020", VA = "0x182A82E20")]
	public static bool OMHHDPFHBOM(ByteString CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2A81C80", Offset = "0x2A80E80", VA = "0x182A81C80", Slot = "13")]
	public void AMOECHPPGIP(bool HOPKILAOGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2A82CA0", Offset = "0x2A81EA0", VA = "0x182A82CA0")]
	private void LOAPFNKGENF(bool EECCCGAOPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2A81FF0", Offset = "0x2A811F0", VA = "0x182A81FF0")]
	private void KBAGGAGGJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x1012E70", Offset = "0x1012070", VA = "0x181012E70")]
	private void GIAKGPDMLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2A82BE0", Offset = "0x2A81DE0", VA = "0x182A82BE0")]
	private void LFHFPGCFOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2A824B0", Offset = "0x2A816B0", VA = "0x182A824B0", Slot = "17")]
	public void EIOJNCNDJBC(POCHLGNFBCE KIHGLKLDAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public LHDFLJJMNGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2A81E20", Offset = "0x2A81020", VA = "0x182A81E20", Slot = "9")]
	private JONKJOHGAPG IBAGNLKBAKK(IEnumerable<BMDJOHDFBDL> BOIJHJLHIPE, in LBIKKMMNADH CPAEGLDKAOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2A81FA0", Offset = "0x2A811A0", VA = "0x182A81FA0", Slot = "11")]
	private JNHLGEOHJON DELGJIHKGIF(ByteString CCBKAEHNCPH, BMDJOHDFBDL OJEMCPHOKBP, in LBIKKMMNADH LLCBNCMAJAP, KEAMHPDKNJO NEAPKBOPGJI, bool DAIHICNGAAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2A82D00", Offset = "0x2A81F00", VA = "0x182A82D00")]
	[CompilerGenerated]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICAIICOAFID))]
	private Task NPDGNNMFICJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct FOLCKOGKMPF : IEnumerable<DJPLEBGJKKI>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum NFCPJEMEAHL
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct JJBDIAALLHH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private NativeList<byte> JFGIPFOFKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private FOLCKOGKMPF MLEOGHHEJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly DJPLEBGJKKI FGIADOJFAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private readonly int KACNNGPFBFG;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2222740", Offset = "0x2221940", VA = "0x182222740")]
		internal JJBDIAALLHH(FOLCKOGKMPF MLEOGHHEJOI, DJPLEBGJKKI FGIADOJFAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2222610", Offset = "0x2221810", VA = "0x182222610", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2222560", Offset = "0x2221760", VA = "0x182222560")]
		public void CLHCGBHOKHM(ReadOnlySpan<byte> NABCGCEIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x22226A0", Offset = "0x22218A0", VA = "0x1822226A0")]
		private void KKMBNPJAOML(ReadOnlySpan<byte> NABCGCEIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2222640", Offset = "0x2221840", VA = "0x182222640")]
		private unsafe void KKMBNPJAOML(void* PKEAPCMBMMC, int AAALINBAMFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct DJCAJFLKKHJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private FOLCKOGKMPF MLEOGHHEJOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private NativeArray<byte> JFGIPFOFKHL;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x221B9A0", Offset = "0x221ABA0", VA = "0x18221B9A0")]
		internal DJCAJFLKKHJ(FOLCKOGKMPF MLEOGHHEJOI, NativeArray<byte> JFGIPFOFKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x221B790", Offset = "0x221A990", VA = "0x18221B790", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x221B7A0", Offset = "0x221A9A0", VA = "0x18221B7A0")]
		public NativeArray<byte> IAPLGNCPHJD(int AAALINBAMFJ)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x221B860", Offset = "0x221AA60", VA = "0x18221B860")]
		public void ILGDFJBEHBK(Span<byte> NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public struct JHHCLCCCDDJ : IEnumerator<DJPLEBGJKKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly NativeList<DJPLEBGJKKI> LMFDNLBGHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int NNAODBDJDNJ;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public DJPLEBGJKKI JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x2222510", Offset = "0x2221710", VA = "0x182222510", Slot = "4")]
			get
			{
				return default(DJPLEBGJKKI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x22224D0", Offset = "0x22216D0", VA = "0x1822224D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2222380", Offset = "0x2221580", VA = "0x182222380", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2222490", Offset = "0x2221690", VA = "0x182222490", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private struct LOBGGBFHKBG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private NativeArray<int> JFGIPFOFKHL;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool BNBLLGADOKH
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x2223D50", Offset = "0x2222F50", VA = "0x182223D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int NHIFOICAPKI
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x2223E10", Offset = "0x2223010", VA = "0x182223E10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x2223E20", Offset = "0x2223020", VA = "0x182223E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public NFCPJEMEAHL JOBGPPPGDHA
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x2223E30", Offset = "0x2223030", VA = "0x182223E30")]
			get
			{
				return default(NFCPJEMEAHL);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2223DD0", Offset = "0x2222FD0", VA = "0x182223DD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool PADEHNBBKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2223DB0", Offset = "0x2222FB0", VA = "0x182223DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool PHFLAPHPMHG
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2223D90", Offset = "0x2222F90", VA = "0x182223D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2223E40", Offset = "0x2223040", VA = "0x182223E40")]
		public LOBGGBFHKBG(NFCPJEMEAHL DPNCGBHDIEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2223DE0", Offset = "0x2222FE0", VA = "0x182223DE0")]
		private int MCKGCJAFOEM(int MLHOBKJDKGI, int FPDCPCGJKNM = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2223CD0", Offset = "0x2222ED0", VA = "0x182223CD0")]
		private void BNDJKAKDCIM(int MLHOBKJDKGI, int NABCGCEIEGG, int FPDCPCGJKNM = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2223D10", Offset = "0x2222F10", VA = "0x182223D10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly DJPLEBGJKKI LPMDJMDGJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeParallelHashMap<DJPLEBGJKKI, int> EOMCIPKFLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NativeList<DJPLEBGJKKI> GMLEHOPIEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private NativeList<int> AEOJAEDOEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeList<byte> AEFHAAHFBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private NativeList<byte> JFGIPFOFKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private LOBGGBFHKBG HPANENBGKED;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x27CD050", Offset = "0x27CC250", VA = "0x1827CD050")]
	public static FOLCKOGKMPF JKAAGGANCJG(NFCPJEMEAHL DPNCGBHDIEM = NFCPJEMEAHL.Last, int OILIHLHKMMN = 16, int CCMENOKCACE = 256)
	{
		return default(FOLCKOGKMPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x27CD5B0", Offset = "0x27CC7B0", VA = "0x1827CD5B0")]
	private FOLCKOGKMPF(NFCPJEMEAHL DPNCGBHDIEM, int OILIHLHKMMN, int CCMENOKCACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x27CCAE0", Offset = "0x27CBCE0", VA = "0x1827CCAE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x27CCBC0", Offset = "0x27CBDC0", VA = "0x1827CCBC0")]
	public JJBDIAALLHH GDBEHDFABLN(DJPLEBGJKKI FGIADOJFAEB)
	{
		return default(JJBDIAALLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x27CCCB0", Offset = "0x27CBEB0", VA = "0x1827CCCB0")]
	public bool GFFCOMDFHME(DJPLEBGJKKI FGIADOJFAEB, out DJCAJFLKKHJ MNFEDONOPCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x27CD180", Offset = "0x27CC380", VA = "0x1827CD180")]
	public bool MAEHLEDABAG(DJPLEBGJKKI FGIADOJFAEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x27CCEA0", Offset = "0x27CC0A0", VA = "0x1827CCEA0")]
	public bool HJAFCKMAMIB(DJPLEBGJKKI FGIADOJFAEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x27CCF70", Offset = "0x27CC170", VA = "0x1827CCF70")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x27CD2C0", Offset = "0x27CC4C0", VA = "0x1827CD2C0")]
	private void NKJEPELBAIJ(DJPLEBGJKKI FGIADOJFAEB, int KACNNGPFBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x27CD090", Offset = "0x27CC290", VA = "0x1827CD090")]
	private void KDOAOILMCME(int EIDAOCLPGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x27CD1D0", Offset = "0x27CC3D0", VA = "0x1827CD1D0")]
	private void NBGHHDOOHMP(DJPLEBGJKKI FGIADOJFAEB, int KACNNGPFBFG, int AAALINBAMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x27CD4F0", Offset = "0x27CC6F0", VA = "0x1827CD4F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x27CD4B0", Offset = "0x27CC6B0", VA = "0x1827CD4B0", Slot = "4")]
	private IEnumerator<DJPLEBGJKKI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
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
		public override IANCKMHPHEB GIBGFMAHINI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x2467340", Offset = "0x2466540", VA = "0x182467340", Slot = "6")]
			get
			{
				return default(IANCKMHPHEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x24672E0", Offset = "0x24664E0", VA = "0x1824672E0")]
		public RbexEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class IPLAOFGKEDL
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public static class CFPNJAEAANE
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly PEKDFCFCENH LHCMKIAHBCL;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2219D80", Offset = "0x2218F80", VA = "0x182219D80")]
		public static NACALKPEILN OPBNJJJALMO(int ALAILAMCBCK, JHFDKBHOKBE BGHGOMFIAIP)
		{
			return default(NACALKPEILN);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2219A00", Offset = "0x2218C00", VA = "0x182219A00")]
		private static BMDJOHDFBDL ACDCHMDEEFA(JHFDKBHOKBE BAHHAJJNELP, BMDJOHDFBDL GPHEGEDLJCA)
		{
			return default(BMDJOHDFBDL);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x221A220", Offset = "0x2219420", VA = "0x18221A220")]
		private static void PDPPNGFMINA(BMDJOHDFBDL HMAFFNEENND, BMDJOHDFBDL DCFHHBJEGPM, NACALKPEILN EPGIOGIKNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2219B20", Offset = "0x2218D20", VA = "0x182219B20")]
		public static int LIIPEJBMBOB(GameObject HAAGKPEGEHP, JONKJOHGAPG OOMPAJGJHMK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static BHIKEJGKPLP BBKHJBNFCAB;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static FLFMIDDEJIH ONMNMDAFEKP;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public static FLFMIDDEJIH IEBGHCDHFEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x25B33A0", Offset = "0x25B25A0", VA = "0x1825B33A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public static bool KOPMLBIFDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x25B2EA0", Offset = "0x25B20A0", VA = "0x1825B2EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public static POCHLGNFBCE FBCEAFFBAED
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x25B3500", Offset = "0x25B2700", VA = "0x1825B3500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public static HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x25B2A00", Offset = "0x25B1C00", VA = "0x1825B2A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public static CFHHLPHHLOO EDBIJJOPMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x25B2840", Offset = "0x25B1A40", VA = "0x1825B2840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public static JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x25B2E20", Offset = "0x25B2020", VA = "0x1825B2E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public static ALOPNKJDLEE NMACKCAFKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x25B3040", Offset = "0x25B2240", VA = "0x1825B3040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public static MKDGDMAKODP GFMMJHEFHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x25B27C0", Offset = "0x25B19C0", VA = "0x1825B27C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public static bool CABKPJABLFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x25B2DA0", Offset = "0x25B1FA0", VA = "0x1825B2DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public static bool CFDANBBANMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x25B2630", Offset = "0x25B1830", VA = "0x1825B2630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public static OCHPAAEIANL KJFJNDPMFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x25B28C0", Offset = "0x25B1AC0", VA = "0x1825B28C0")]
		get
		{
			return default(OCHPAAEIANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public static bool AEHELBCDICA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x25B2D00", Offset = "0x25B1F00", VA = "0x1825B2D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public static byte APDGBHNPEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x25B2BE0", Offset = "0x25B1DE0", VA = "0x1825B2BE0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public static bool GHBLCGADFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x25B3580", Offset = "0x25B2780", VA = "0x1825B3580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public static bool AMLPOOBHMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x25B2180", Offset = "0x25B1380", VA = "0x1825B2180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x25B2A80", Offset = "0x25B1C80", VA = "0x1825B2A80")]
	public static void GHNMFLNJPLD(BHIKEJGKPLP NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x25B30C0", Offset = "0x25B22C0", VA = "0x1825B30C0")]
	public static BMDJOHDFBDL NEEBBCDLDON(GameObject HAAGKPEGEHP)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x25B24C0", Offset = "0x25B16C0", VA = "0x1825B24C0")]
	public static OCHPAAEIANL EBJLDAHNILL(NACALKPEILN EPGIOGIKNGK)
	{
		return default(OCHPAAEIANL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x25B21E0", Offset = "0x25B13E0", VA = "0x1825B21E0")]
	public static bool BLAKOECPHBF(GameObject HAAGKPEGEHP, out NACALKPEILN EPGIOGIKNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x25B2680", Offset = "0x25B1880", VA = "0x1825B2680")]
	public static LGMOGAKCIAN EEOIJHPMINF(IEnumerable<EHDODNDLPHI> BKLFKAMPCOO)
	{
		return default(LGMOGAKCIAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x25B2320", Offset = "0x25B1520", VA = "0x1825B2320")]
	public static void DAPPCPEGHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x25B35E0", Offset = "0x25B27E0", VA = "0x1825B35E0")]
	private static FLFMIDDEJIH PMMFKNAPDNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x25B3240", Offset = "0x25B2440", VA = "0x1825B3240")]
	private static bool OJOPHFPHHMO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class PAKBOJEPOMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct DJPLEBGJKKI : IComparable<DJPLEBGJKKI>, IEquatable<DJPLEBGJKKI>
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly DJPLEBGJKKI MOBOMNFBKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public NACALKPEILN KHBBAOCDKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public MCNHINHNBBI HAGDCDMAFAF;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public bool HEOJOBHHAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2639810", Offset = "0x2638A10", VA = "0x182639810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5C50", VA = "0x1808B6A50")]
	public DJPLEBGJKKI(NACALKPEILN KHBBAOCDKFN, MCNHINHNBBI HAGDCDMAFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2639820", Offset = "0x2638A20", VA = "0x182639820", Slot = "4")]
	public int CompareTo(DJPLEBGJKKI JMNBIHILIIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2639990", Offset = "0x2638B90", VA = "0x182639990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x26398B0", Offset = "0x2638AB0", VA = "0x1826398B0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2639860", Offset = "0x2638A60", VA = "0x182639860", Slot = "5")]
	public bool Equals(DJPLEBGJKKI JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2639950", Offset = "0x2638B50", VA = "0x182639950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DDDGJOKMEDO(typeof(HGAPJJGIOOA), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
internal class HGAPJJGIOOA : DCLDDNDKGBL, PJIPLCPBFIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private HNMHAJLPHMH AMPOACOBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private LGOHODJFODN<Entity> OJEMCPHOKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private MGGGBEIHFIJ KMCFNHCIMAG;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x25A5B80", Offset = "0x25A4D80", VA = "0x1825A5B80", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x25A5D20", Offset = "0x25A4F20", VA = "0x1825A5D20", Slot = "5")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x25A5AE0", Offset = "0x25A4CE0", VA = "0x1825A5AE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x25A5BF0", Offset = "0x25A4DF0", VA = "0x1825A5BF0")]
	private void KCHFFDMDKOB(Entity BLNICJMKCEF, in LKEBNILDCHH EJOKGCNJEPM, in LKEBNILDCHH FDDLNHNDPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public HGAPJJGIOOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(CJCFNJEIKLC), new string[] { })]
internal class CJCFNJEIKLC : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[MOHONECELPE]
	private EIFIFHHKJPI EAAEGPDMONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Dictionary<int, MODEADMIGAP> DDHLEBPJKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x262E790", Offset = "0x262D990", VA = "0x18262E790", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x262E1C0", Offset = "0x262D3C0", VA = "0x18262E1C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x262E320", Offset = "0x262D520", VA = "0x18262E320")]
	public MODEADMIGAP HFBNOPKNLCJ(FAODENBHDMK LPNKBGEMCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x262E530", Offset = "0x262D730", VA = "0x18262E530")]
	public MODEADMIGAP HFBNOPKNLCJ(MCNHINHNBBI HAGDCDMAFAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x262E670", Offset = "0x262D870", VA = "0x18262E670")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x262E7E0", Offset = "0x262D9E0", VA = "0x18262E7E0")]
	public CJCFNJEIKLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(EFOHDIHDKJF), new string[] { })]
public class EFOHDIHDKJF
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public struct MJHMLKBFEBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly EFOHDIHDKJF OJEMCPHOKBP;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2223FD0", Offset = "0x22231D0", VA = "0x182223FD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private int LHBILCHPADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action IDJGGLFNFBA;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC50", Offset = "0x27BBE50", VA = "0x1827BCC50")]
	public void IHIENPGJOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public EFOHDIHDKJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DefaultMember("Item")]
public class HENOIDBGIPI<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly Func<From, To> BNMBBNKGCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly Func<To, From> CILAAJKAIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<From> LMFDNLBGHBA;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public To JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2096C60", Offset = "0x2095E60", VA = "0x182096C60", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2096CB0", Offset = "0x2095EB0", VA = "0x182096CB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x2096C20", Offset = "0x2095E20", VA = "0x182096C20", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool HPJMOKLCNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1EC27E0", Offset = "0x1EC19E0", VA = "0x181EC27E0")]
	public HENOIDBGIPI(Func<From, To> BNMBBNKGCGK, Func<To, From> CILAAJKAIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2096800", Offset = "0x2095A00", VA = "0x182096800", Slot = "11")]
	public void Add(To JJJLNAPHHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2096840", Offset = "0x2095A40", VA = "0x182096840", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2096880", Offset = "0x2095A80", VA = "0x182096880", Slot = "13")]
	public bool Contains(To JJJLNAPHHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2096940", Offset = "0x2095B40", VA = "0x182096940", Slot = "14")]
	public void CopyTo(To[] LMFDNLBGHBA, int PAENDODKMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2096A00", Offset = "0x2095C00", VA = "0x182096A00", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2096AC0", Offset = "0x2095CC0", VA = "0x182096AC0", Slot = "6")]
	public int IndexOf(To JJJLNAPHHCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x2096B30", Offset = "0x2095D30", VA = "0x182096B30", Slot = "7")]
	public void Insert(int NNAODBDJDNJ, To JJJLNAPHHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2096BB0", Offset = "0x2095DB0", VA = "0x182096BB0", Slot = "15")]
	public bool Remove(To JJJLNAPHHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2096B70", Offset = "0x2095D70", VA = "0x182096B70", Slot = "8")]
	public void RemoveAt(int NNAODBDJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2096BF0", Offset = "0x2095DF0", VA = "0x182096BF0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[IPBFKBDDJKA]
public class ENADJCBBBPI : ComponentSystem, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private POCHLGNFBCE FBCEAFFBAED
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x89A3F0", VA = "0x18089B1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private HEDLOJKNBDM KINNDLLBLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8C35B0", Offset = "0x8C27B0", VA = "0x1808C35B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x27BF8A0", Offset = "0x27BEAA0", VA = "0x1827BF8A0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
	public ENADJCBBBPI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, BGNCONALOOG, HOFBHJGKIFM
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private static readonly PEKDFCFCENH LHCMKIAHBCL;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private const string JKKNAFEMBKL = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private ACNKOFALKFG NJGLKOBADEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private BMDJOHDFBDL KHBBAOCDKFN;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public BMDJOHDFBDL CFLIMOEMLBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x27C5E90", Offset = "0x27C5090", VA = "0x1827C5E90", Slot = "15")]
			get
			{
				return default(BMDJOHDFBDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public OCHPAAEIANL GCHLLMNMNPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x27C5F40", Offset = "0x27C5140", VA = "0x1827C5F40", Slot = "6")]
			get
			{
				return default(OCHPAAEIANL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool DILEBBOMEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x27C5E80", Offset = "0x27C5080", VA = "0x1827C5E80", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public ACNKOFALKFG GGNFHLDOMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xAC3780", Offset = "0xAC2980", VA = "0x180AC3780", Slot = "7")]
			get
			{
				return default(ACNKOFALKFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		private HEDLOJKNBDM KINNDLLBLJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x27C52E0", Offset = "0x27C44E0", VA = "0x1827C52E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool KDNGCINBFEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAC0", Offset = "0x7EACC0", VA = "0x1807EBAC0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x7EB9E0", Offset = "0x7EABE0", VA = "0x1807EB9E0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<bool> LAFPBJEOAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x27C5D40", Offset = "0x27C4F40", VA = "0x1827C5D40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x27C5F80", Offset = "0x27C5180", VA = "0x1827C5F80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<BGNCONALOOG> KOHMGGFFLEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x27C5DE0", Offset = "0x27C4FE0", VA = "0x1827C5DE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x27C6020", Offset = "0x27C5220", VA = "0x1827C6020", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x27C51C0", Offset = "0x27C43C0", VA = "0x1827C51C0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x27C5A90", Offset = "0x27C4C90", VA = "0x1827C5A90", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x27C5540", Offset = "0x27C4740", VA = "0x1827C5540", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x27C5A20", Offset = "0x27C4C20", VA = "0x1827C5A20", Slot = "10")]
		public void OnEmbody(MMIPKKPAOLG OOHHGMIKJFD, BMDJOHDFBDL KHBBAOCDKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x26388D0", Offset = "0x2637AD0", VA = "0x1826388D0", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x27C5870", Offset = "0x27C4A70", VA = "0x1827C5870", Slot = "12")]
		public void OnDisembody(bool HABHBALDBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x27C5370", Offset = "0x27C4570", VA = "0x1827C5370")]
		private void JICLJIFDEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x27C54E0", Offset = "0x27C46E0", VA = "0x1827C54E0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x966BD0", Offset = "0x965DD0", VA = "0x180966BD0", Slot = "9")]
		private GameObject OLFCDGJOADM()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public class KDJHKMDPMBJ<T> : HAMPBFOIKKB<T>, FLNCDPNCALM<BMDJOHDFBDL, T>, GCIMBJDHENP<BMDJOHDFBDL>, AELOMMACAOB, IDisposable, HADCJDEHJDC where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly GCIMBJDHENP<Entity> BGOCDAGKFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Delegate OGHHHIOGEBA;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x22D5AD0", Offset = "0x22D4CD0", VA = "0x1822D5AD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Type GLGPHBABLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x22D5B70", Offset = "0x22D4D70", VA = "0x1822D5B70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public JHNBELMGFMH JLMOKFABNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x22D5E20", Offset = "0x22D5020", VA = "0x1822D5E20", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int GBCPOFPGEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x22D6DE0", Offset = "0x22D5FE0", VA = "0x1822D6DE0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public OHEODOENDEE CNIKDLGMEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x22D5CE0", Offset = "0x22D4EE0", VA = "0x1822D5CE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event FPMEHGMLMEM<BMDJOHDFBDL> JJKMLFDPEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x22D64D0", Offset = "0x22D56D0", VA = "0x1822D64D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x22D5870", Offset = "0x22D4A70", VA = "0x1822D5870", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x2296E80", Offset = "0x2296080", VA = "0x182296E80")]
	public KDJHKMDPMBJ(GCIMBJDHENP<Entity> BGOCDAGKFNE, JPLJDCFLDIF KPFCGANDCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x22955D0", Offset = "0x22947D0", VA = "0x1822955D0")]
	private Entity LKEFLLNHKFJ(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x22955E0", Offset = "0x22947E0", VA = "0x1822955E0")]
	private BMDJOHDFBDL LKEFLLNHKFJ(Entity BLNICJMKCEF)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x22D84A0", Offset = "0x22D76A0", VA = "0x1822D84A0", Slot = "4")]
	public T MCKGCJAFOEM(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x22D5120", Offset = "0x22D4320", VA = "0x1822D5120")]
	public bool BNDJKAKDCIM(BMDJOHDFBDL JHJPAJMEGAG, in T FDDLNHNDPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x22D5570", Offset = "0x22D4770", VA = "0x1822D5570", Slot = "7")]
	public bool CCLPLAGPKBK(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x22960B0", Offset = "0x22952B0", VA = "0x1822960B0", Slot = "8")]
	public void MCKGCJAFOEM(BMDJOHDFBDL JHJPAJMEGAG, PMJFNECPFPH NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x228FA30", Offset = "0x228EC30", VA = "0x18228FA30", Slot = "9")]
	public bool BNDJKAKDCIM(BMDJOHDFBDL JHJPAJMEGAG, LKEBNILDCHH FDDLNHNDPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2290E20", Offset = "0x2290020", VA = "0x182290E20", Slot = "16")]
	public void EIPBKFMEANK(ANJJHLMIOKD NGBDCJPCMID, [Optional] object JDFBABENAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x2290760", Offset = "0x228F960", VA = "0x182290760", Slot = "10")]
	public bool DLOFCDEOECF(BMDJOHDFBDL GLDKECDCJGE, BMDJOHDFBDL LBIBKCFHCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x22D66E0", Offset = "0x22D58E0", VA = "0x1822D66E0")]
	private void JMCNGKPIEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x22D62B0", Offset = "0x22D54B0", VA = "0x1822D62B0")]
	private void HFECKHLKIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x22D7070", Offset = "0x22D6270", VA = "0x1822D7070")]
	private void LIFKDDHHBCI(Entity BLNICJMKCEF, in LKEBNILDCHH EJOKGCNJEPM, in LKEBNILDCHH FDDLNHNDPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x22D6EF0", Offset = "0x22D60F0", VA = "0x1822D6EF0")]
	private void KDBOFGJFJPN(Entity BLNICJMKCEF, in LKEBNILDCHH EJOKGCNJEPM, in LKEBNILDCHH FDDLNHNDPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x22909D0", Offset = "0x228FBD0", VA = "0x1822909D0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x22D87D0", Offset = "0x22D79D0", VA = "0x1822D87D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
[DDDGJOKMEDO(typeof(JHHABMNLDEN), new string[] { })]
internal class JHHABMNLDEN
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private bool EECCCGAOPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool HKGOFIANLII;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool JLHLDBCJPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xAAB280", Offset = "0xAAA480", VA = "0x180AAB280")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x25B6C00", Offset = "0x25B5E00", VA = "0x1825B6C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool CLOLCECLCOC
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4F20", Offset = "0xAC4120", VA = "0x180AC4F20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x25B6C10", Offset = "0x25B5E10", VA = "0x1825B6C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public JHHABMNLDEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DDDGJOKMEDO(typeof(MPENABBNJNJ), new string[] { })]
public class PNNKHFDHOMG : MPENABBNJNJ, DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class COFOMOKBMHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public List<CapsuleCollider> KHOANKGFJHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<SphereCollider> BNCBDDEMKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public GameObject IIOGGBEPGDF;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x221A7F0", Offset = "0x22199F0", VA = "0x18221A7F0")]
		public COFOMOKBMHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	[MOHONECELPE]
	private JPLJDCFLDIF KDHINPHNJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[MOHONECELPE]
	private DDHMFKIBELN MJJPECGIFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly Dictionary<Entity, COFOMOKBMHD> GNIIFMMANDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private GameObject KHAPJGKOPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private GameObject FJMHONAFBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject OBICFFILJFA;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private GameObject GHJHIIIOKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x245A630", Offset = "0x2459830", VA = "0x18245A630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x245A5C0", Offset = "0x24597C0", VA = "0x18245A5C0", Slot = "6")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2459C00", Offset = "0x2458E00", VA = "0x182459C00", Slot = "4")]
	public void HFOMMCKNDHN(Entity AMBJIIKIPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2459FF0", Offset = "0x24591F0", VA = "0x182459FF0", Slot = "5")]
	public void HINMJEHEIMG(Entity AMBJIIKIPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2458C00", Offset = "0x2457E00", VA = "0x182458C00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2458A90", Offset = "0x2457C90", VA = "0x182458A90")]
	private COFOMOKBMHD DFOIMNALBOD(Entity AMBJIIKIPJO, LOBHMBEDOPE IEFMFCGPBPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2458D60", Offset = "0x2457F60", VA = "0x182458D60")]
	private void ECPGKEEAIOJ(LOBHMBEDOPE IEFMFCGPBPC, COFOMOKBMHD OLNCIIPPHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x245A6F0", Offset = "0x24598F0", VA = "0x18245A6F0")]
	private void OCGPKNLCKCM(LOBHMBEDOPE IEFMFCGPBPC, COFOMOKBMHD OLNCIIPPHJO, int DDJFEHLDOBG, Vector3 BOEKENJNLKP, Quaternion ELGEECMLAMI, float ADBNNNLLGEN, float CPPKAEGLEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x245A900", Offset = "0x2459B00", VA = "0x18245A900")]
	private void ONFBGBIFDIJ(COFOMOKBMHD OLNCIIPPHJO, int MDBEEBIPNFA, Vector3 BOEKENJNLKP, float ADBNNNLLGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2459900", Offset = "0x2458B00", VA = "0x182459900")]
	private void GCONGGHDPIH(LOBHMBEDOPE IEFMFCGPBPC, COFOMOKBMHD OLNCIIPPHJO, int IFBKCLMDLJI, int EBCEHDKGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x234EF20", Offset = "0x234E120", VA = "0x18234EF20")]
	private T AIOINCNJEHK<T>(LOBHMBEDOPE IEFMFCGPBPC, ref GameObject NJPHBJKHIEL, Vector3 DGDMDKFMBBA, Quaternion KGFPECIFPNA) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x245AB50", Offset = "0x2459D50", VA = "0x18245AB50")]
	public PNNKHFDHOMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DefaultMember("Item")]
public class IINIELAJLNH<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[FBPICDCAGAD(typeof(COAPHLBOHFB))]
[DDDGJOKMEDO(typeof(JHBOCIKNAIN), new string[] { })]
public class EDGKNGPJPHJ : JHBOCIKNAIN, PNKPNDDLHPG, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly Dictionary<int, LOBNDPHFMLE> EMBCIKANLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly Dictionary<LOBNDPHFMLE, int> KAHAPNCADHG;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x27BC140", Offset = "0x27BB340", VA = "0x1827BC140", Slot = "6")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x27BBF00", Offset = "0x27BB100", VA = "0x1827BBF00", Slot = "7")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x27BBCF0", Offset = "0x27BAEF0", VA = "0x1827BBCF0")]
	private void CLGGBIHHOOI(List<(LOBNDPHFMLE nameHash, DPOIMOJBLLE stableTypeHash, Type type)> MLEOGHHEJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x27BBFF0", Offset = "0x27BB1F0", VA = "0x1827BBFF0", Slot = "4")]
	public LOBNDPHFMLE KHNMHOLHNNE(int CNBPDHPGPFI)
	{
		return default(LOBNDPHFMLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x27BBC80", Offset = "0x27BAE80", VA = "0x1827BBC80", Slot = "5")]
	public int CGALLAMFFOC(LOBNDPHFMLE HNCGIJMEPDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x27BC210", Offset = "0x27BB410", VA = "0x1827BC210")]
	public EDGKNGPJPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class PNLNMODBNJL
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class MDOOHOKPKCP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EJJPBAHOGLB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class NBLALEPMIIG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2457890", Offset = "0x2456A90", VA = "0x182457890")]
	public static Entity CNCLJKFPJHO(this EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x24584B0", Offset = "0x24576B0", VA = "0x1824584B0")]
	public static DynamicBuffer<JFFGLDLIPLN> KOCFBIKNNBC(this EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(DynamicBuffer<JFFGLDLIPLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2457B50", Offset = "0x2456D50", VA = "0x182457B50")]
	public static bool EHDFICJONKO(this EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, Allocator KPFKDHLBOGB, out NativeArray<Entity> GEJLPBOFNDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2458340", Offset = "0x2457540", VA = "0x182458340")]
	public static NativeArray<Entity> GKDPBCMHHMP(this EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x24588F0", Offset = "0x2457AF0", VA = "0x1824588F0")]
	public static int PIEOLGNFKFJ(this EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2457D50", Offset = "0x2456F50", VA = "0x182457D50")]
	public static void EPHMDEBKGEK(NativeArray<Entity> AEILOOJABFG, NativeArray<Entity> KNNJOFGDFGM, EntityManager NMHMIPEFENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2457FB0", Offset = "0x24571B0", VA = "0x182457FB0")]
	public static bool FGHHNJKOBON(this EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, Entity FMMAMOIMPOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2458750", Offset = "0x2457950", VA = "0x182458750")]
	public static bool OOGFDOGPFLJ(this EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, Entity FGNNHDMBMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2458120", Offset = "0x2457320", VA = "0x182458120")]
	public static NativeList<Entity> FGNPEKOIFDC(this EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, bool MAFGKEELIDD = false, Allocator KPFKDHLBOGB = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2457C50", Offset = "0x2456E50", VA = "0x182457C50")]
	public static Entity ELNKALNLELD(this EntityManager NMHMIPEFENM, Entity BLNICJMKCEF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2457900", Offset = "0x2456B00", VA = "0x182457900")]
	public static bool DFLGDIJJHGG(this EntityManager NMHMIPEFENM, Entity BJPEGONLJEK, Entity NPIENNHDDHE, out Entity JCNPPLBIDFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2458540", Offset = "0x2457740", VA = "0x182458540")]
	internal static void LOJBGADEHED(EntityManager NMHMIPEFENM, Entity OJEMCPHOKBP, Entity PPANDIPJOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2458660", Offset = "0x2457860", VA = "0x182458660")]
	private static bool OLILNJHJFEH(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, Entity FMMAMOIMPOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[IIOIOPJOFOO]
internal struct JPNNIGLELPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public LBIKKMMNADH CPAEGLDKAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public KFNGOAOOLPO BDIHIOJPHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public LKEKFLMHAOA.KIOHNINKNOH.GNGDFKGALGL KBIJDJHCEBH;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static readonly DDKHFNGLFEP<JPNNIGLELPN> NBIAOCJLGIM;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x25B7CC0", Offset = "0x25B6EC0", VA = "0x1825B7CC0")]
	public static JPNNIGLELPN GGNOANJJIBO(in LBIKKMMNADH CPAEGLDKAOP)
	{
		return default(JPNNIGLELPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface LCAPGECPAMK
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	LKEKFLMHAOA.KIOHNINKNOH.GNGDFKGALGL LIIDDPIHEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class CKKANLIFEON
{
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x262E860", Offset = "0x262DA60", VA = "0x18262E860")]
	public static LBIKKMMNADH JPLAGNFFJNM(OCHPAAEIANL OJEMCPHOKBP)
	{
		return default(LBIKKMMNADH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class JAKIOKKPLJC : JONKJOHGAPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private readonly bool EECCCGAOPOH;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public BDNEDPOFMOK NBMLOFPALLM
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3700", Offset = "0x7E2900", VA = "0x1807E3700")]
	public JAKIOKKPLJC(bool EECCCGAOPOH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x25B3800", Offset = "0x25B2A00", VA = "0x1825B3800", Slot = "5")]
	public ByteString PDFKDPENEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class LBNHDDDNAIH
{
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly PEKDFCFCENH CLOGHEDOPFF;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly PEKDFCFCENH HMFKDAPADAM;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly ProfilerMarker OEMOLGBDELD;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly ProfilerMarker ILJILMIPFJF;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly ProfilerMarker MBAJACDBKNN;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly ProfilerMarker ADDLOGFCEPE;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly ProfilerMarker FDBNEEFGAHE;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly ProfilerMarker PAENCNJMHOF;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly ProfilerMarker GIHDFEPHLCG;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly ProfilerMarker PNKDBHODEKD;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly ProfilerMarker PKLBJBHCFDN;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly ProfilerMarker PKKOKCPGMMN;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly ProfilerMarker HDDNABDCMKN;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly ProfilerMarker ONJKKMLJJML;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly ProfilerMarker EJLFHIJOCMF;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly ProfilerMarker NIMJFEFENKK;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker BPGLHEADBAL;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker OEGFHBEGMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private readonly DIJKGDPBAPA FBNGNJPLKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private readonly ByteString CCBKAEHNCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private readonly BHIKEJGKPLP DAJKBHKJPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private readonly POFDHBBBAEI CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly LHDFLJJMNGO OBJIAFLHCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly BEAJGHBNKNP GMLEHOPIEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly DNHKLOJOOME KKMICPLPDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly JHHABMNLDEN NHGBHEDDDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly TaskCompletionSource<bool> HOKLKCIMMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly EDGPEBAJCFE HPANENBGKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private readonly IOHOFDNHACB.OJDIJOMMIEP OHPNDHNAGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private MNCDKBBELAG MJFIBAIIPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private KNKOHPGNOPB IHIGFPCIIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private LKEKFLMHAOA JDPAEKCKPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private BDNEDPOFMOK OGIMCFPJDGD;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Action<bool> JJBOGJBHLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x8CC480", Offset = "0x8CB680", VA = "0x1808CC480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x8CAA40", Offset = "0x8C9C40", VA = "0x1808CAA40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Action KCKMPGJJPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x96DB70", Offset = "0x96CD70", VA = "0x18096DB70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x96DA00", Offset = "0x96CC00", VA = "0x18096DA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Action EBBHNKFJEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BCA0", VA = "0x18099CAA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xD75100", Offset = "0xD74300", VA = "0x180D75100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Action CIFJCBHDFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xC9B750", Offset = "0xC9A950", VA = "0x180C9B750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xD69FF0", Offset = "0xD691F0", VA = "0x180D69FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<EHDODNDLPHI> ABAOCMOJMIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x898D10", Offset = "0x897F10", VA = "0x180898D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8A2550", Offset = "0x8A1750", VA = "0x1808A2550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public LGMOGAKCIAN KBDMAINAOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x1691020", Offset = "0x1690220", VA = "0x181691020")]
		[CompilerGenerated]
		get
		{
			return default(LGMOGAKCIAN);
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x168C290", Offset = "0x168B490", VA = "0x18168C290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public BDNEDPOFMOK NBMLOFPALLM
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4B0", Offset = "0x8CB6B0", VA = "0x1808CC4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public KMMLKGKMKMM DOPPMNEEMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xC0B570", Offset = "0xC0A770", VA = "0x180C0B570")]
		get
		{
			return default(KMMLKGKMKMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public LocalId OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x25C3510", Offset = "0x25C2710", VA = "0x1825C3510")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Task NKHCGNBKOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x25C4C80", Offset = "0x25C3E80", VA = "0x1825C4C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x25C5FE0", Offset = "0x25C51E0", VA = "0x1825C5FE0")]
	public LBNHDDDNAIH(ByteString CCBKAEHNCPH, KMMLKGKMKMM JHICLJAOFBC, in EDGPEBAJCFE HPANENBGKED, BHIKEJGKPLP DAJKBHKJPOA, JHFDKBHOKBE ELIOMKBNADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x25C3A50", Offset = "0x25C2C50", VA = "0x1825C3A50")]
	public void DFBADGMPLED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x25C4530", Offset = "0x25C3730", VA = "0x1825C4530")]
	public bool HJLCKJBAGNL(KMMLKGKMKMM BJPEGONLJEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x25C57A0", Offset = "0x25C49A0", VA = "0x1825C57A0")]
	private bool NIAAPMKFMCM(KMMLKGKMKMM DLHBAJIIOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x25C5120", Offset = "0x25C4320", VA = "0x1825C5120")]
	private void KKOFFKOBAEA(KMMLKGKMKMM LEDELBMLBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x25C55E0", Offset = "0x25C47E0", VA = "0x1825C55E0")]
	private bool NAAOIGLEAEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x25C4CC0", Offset = "0x25C3EC0", VA = "0x1825C4CC0")]
	private bool JFNJMDCIBHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x25C4EE0", Offset = "0x25C40E0", VA = "0x1825C4EE0")]
	public bool JKIENOOOAGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x25C3C80", Offset = "0x25C2E80", VA = "0x1825C3C80")]
	private bool FEFHNPPODOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x25C4550", Offset = "0x25C3750", VA = "0x1825C4550")]
	private bool ICBHKPADPMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x25C4E10", Offset = "0x25C4010", VA = "0x1825C4E10")]
	private bool JILJOGEAOLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x25C40D0", Offset = "0x25C32D0", VA = "0x1825C40D0")]
	private bool GAJNPNBJGBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x25C54E0", Offset = "0x25C46E0", VA = "0x1825C54E0")]
	private bool MPLMMMJNLEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x25C4810", Offset = "0x25C3A10", VA = "0x1825C4810")]
	public void JCPFNIHJNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x25C5070", Offset = "0x25C4270", VA = "0x1825C5070")]
	[CompilerGenerated]
	private void KFDPKIEDDLJ(KMMLKGKMKMM DLHBAJIIOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x25C38D0", Offset = "0x25C2AD0", VA = "0x1825C38D0")]
	[CompilerGenerated]
	private bool BOHKOGAEFNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x25C40F0", Offset = "0x25C32F0", VA = "0x1825C40F0")]
	[CompilerGenerated]
	private void GNPKNPLBHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x25C53F0", Offset = "0x25C45F0", VA = "0x1825C53F0")]
	[CompilerGenerated]
	private World MLFMEPAPCMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x25C5170", Offset = "0x25C4370", VA = "0x1825C5170")]
	[CompilerGenerated]
	private void KPPFJGNOBLP(World LCMOKDPDKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x25C3FC0", Offset = "0x25C31C0", VA = "0x1825C3FC0")]
	[CompilerGenerated]
	private int FKHLAHICMMM(World LCMOKDPDKIE, ByteString CCBKAEHNCPH, LKEKFLMHAOA.KIOHNINKNOH.GNGDFKGALGL KBIJDJHCEBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x25C36F0", Offset = "0x25C28F0", VA = "0x1825C36F0")]
	[CompilerGenerated]
	private void BJLHBNEPANO(World OOHHGMIKJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x25C3B40", Offset = "0x25C2D40", VA = "0x1825C3B40")]
	[CompilerGenerated]
	internal static MIGIDCOOAJI EFGGBJDJDJP(EntityManager HHHCFJFNOPE, EntityManager LHIDHECKOEH, int LMKEMKPKIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x25C5260", Offset = "0x25C4460", VA = "0x1825C5260")]
	[CompilerGenerated]
	private void MCAEHBAEONF(BDNEDPOFMOK OGIMCFPJDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x25C3520", Offset = "0x25C2720", VA = "0x1825C3520")]
	[CompilerGenerated]
	private void BHAHJIMHEGL(EntityManager NMHMIPEFENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x25C5330", Offset = "0x25C4530", VA = "0x1825C5330")]
	[CompilerGenerated]
	private void MHGJCGNMGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x25C5B40", Offset = "0x25C4D40", VA = "0x1825C5B40")]
	[CompilerGenerated]
	private void ONLDFAOLNJK(string JPKENOAMLIN, EntityManager NMHMIPEFENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x25C5AC0", Offset = "0x25C4CC0", VA = "0x1825C5AC0")]
	[CompilerGenerated]
	private HMLOAEDBHLH<EDGPEBAJCFE> NPEFHDLFFHD(EntityManager NMHMIPEFENM)
	{
		return default(HMLOAEDBHLH<EDGPEBAJCFE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal class BIKLOJDCECK : FDILNOMJFLI
{
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly PEKDFCFCENH HMFKDAPADAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly bool EECCCGAOPOH;

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x2629EA0", Offset = "0x26290A0", VA = "0x182629EA0")]
	public BIKLOJDCECK(bool EECCCGAOPOH, BHIKEJGKPLP DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x9B1810", Offset = "0x9B0A10", VA = "0x1809B1810", Slot = "10")]
	protected override bool IOHFDBEFFKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2629D70", Offset = "0x2628F70", VA = "0x182629D70", Slot = "11")]
	protected override void JPDDKADGBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2629D60", Offset = "0x2628F60", VA = "0x182629D60", Slot = "12")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> CFKFKAMMBFF(NativeArray<EntityRemapUtility.EntityRemapInfo> KNKOALFFAEO)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal struct EDGPEBAJCFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public LBIKKMMNADH LLCBNCMAJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public Entity OJEMCPHOKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public NHIMFAGPJEC BDIHIOJPHJO;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly DDKHFNGLFEP<EDGPEBAJCFE> NBIAOCJLGIM;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class DIJKGDPBAPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private enum BGPDIKLICJA
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
	private sealed class HIKFOOGJJMA : IEnumerable<KMMLKGKMKMM>, IEnumerable, IEnumerator<KMMLKGKMKMM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private KMMLKGKMKMM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private KMMLKGKMKMM target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public KMMLKGKMKMM <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public DIJKGDPBAPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private int <allowedTarget>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int <nextCompletedPhases>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private KMMLKGKMKMM <phase>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private KMMLKGKMKMM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x99B8A0", Offset = "0x99AAA0", VA = "0x18099B8A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KMMLKGKMKMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x2220980", Offset = "0x221FB80", VA = "0x182220980", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x11AFAA0", Offset = "0x11AECA0", VA = "0x1811AFAA0")]
		[DebuggerHidden]
		public HIKFOOGJJMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2220800", Offset = "0x221FA00", VA = "0x182220800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x2220940", Offset = "0x221FB40", VA = "0x182220940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x2220890", Offset = "0x221FA90", VA = "0x182220890", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KMMLKGKMKMM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2220890", Offset = "0x221FA90", VA = "0x182220890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class EPMAOMHLBOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public KMMLKGKMKMM phase;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EPMAOMHLBOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x221D980", Offset = "0x221CB80", VA = "0x18221D980")]
		internal object CCEBDCGNPFE(KMMLKGKMKMM a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly PEKDFCFCENH HMFKDAPADAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly KMMLKGKMKMM JHICLJAOFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly Func<KMMLKGKMKMM, bool> LEHOAMCGKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Action<KMMLKGKMKMM> FHGBFPONGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private int AAKAIICICML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private BGPDIKLICJA NJGLKOBADEO;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public KMMLKGKMKMM DOPPMNEEMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E2180", Offset = "0x7E1380", VA = "0x1807E2180")]
		get
		{
			return default(KMMLKGKMKMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x2638C80", Offset = "0x2637E80", VA = "0x182638C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2638DE0", Offset = "0x2637FE0", VA = "0x182638DE0")]
	public DIJKGDPBAPA(KMMLKGKMKMM JHICLJAOFBC, Func<KMMLKGKMKMM, bool> LEHOAMCGKEL, Action<KMMLKGKMKMM> FHGBFPONGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2638C90", Offset = "0x2637E90", VA = "0x182638C90")]
	[IteratorStateMachine(typeof(HIKFOOGJJMA))]
	private IEnumerable<KMMLKGKMKMM> OOLLFPFEFMH(KMMLKGKMKMM BJPEGONLJEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x26388E0", Offset = "0x2637AE0", VA = "0x1826388E0")]
	public bool HJLCKJBAGNL(KMMLKGKMKMM BJPEGONLJEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x2638870", Offset = "0x2637A70", VA = "0x182638870")]
	private void ACJHAMOBBFB(KMMLKGKMKMM DLHBAJIIOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x26388D0", Offset = "0x2637AD0", VA = "0x1826388D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct HMLOAEDBHLH<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Entity GKFFDGPAFOA;

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x257F200", Offset = "0x257E400", VA = "0x18257F200")]
	public HMLOAEDBHLH(EntityManager NMHMIPEFENM, in T HPANENBGKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x257F1F0", Offset = "0x257E3F0", VA = "0x18257F1F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class PPMFIIONKOL : FDILNOMJFLI
{
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private static readonly PEKDFCFCENH HMFKDAPADAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private readonly JPNNIGLELPN HPANENBGKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private NativeList<Entity> MIFHFKMHOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private NativeArray<Entity> GLDJMPKMACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HEPIACAPFNF;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x245C650", Offset = "0x245B850", VA = "0x18245C650")]
	public PPMFIIONKOL(IEnumerable<BMDJOHDFBDL> BOIJHJLHIPE, in JPNNIGLELPN HPANENBGKED, BHIKEJGKPLP DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "10")]
	protected override bool IOHFDBEFFKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x245C550", Offset = "0x245B750", VA = "0x18245C550", Slot = "9")]
	protected override JPNNIGLELPN ODFEEHOPACB()
	{
		return default(JPNNIGLELPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x245C440", Offset = "0x245B640", VA = "0x18245C440", Slot = "11")]
	protected override void JPDDKADGBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x245C310", Offset = "0x245B510", VA = "0x18245C310", Slot = "12")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> CFKFKAMMBFF(NativeArray<EntityRemapUtility.EntityRemapInfo> KNKOALFFAEO)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x245C3D0", Offset = "0x245B5D0", VA = "0x18245C3D0", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal abstract class FDILNOMJFLI : JONKJOHGAPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly ProfilerMarker ADDLOGFCEPE;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly ProfilerMarker GGCGCFCDJBF;

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static readonly ProfilerMarker FDBNEEFGAHE;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private static readonly ProfilerMarker HJHLAFIEIDA;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly ProfilerMarker GIHDFEPHLCG;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly ProfilerMarker CLMNJLJCDKK;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static readonly ProfilerMarker EIOIINKAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private readonly BHIKEJGKPLP DAJKBHKJPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly MNCDKBBELAG MJFIBAIIPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private readonly DNHKLOJOOME KKMICPLPDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly BEAJGHBNKNP GMLEHOPIEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly PEKDFCFCENH HMFKDAPADAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private readonly IOHOFDNHACB.OJDIJOMMIEP OHPNDHNAGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private World BFHPOLFOECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private BDNEDPOFMOK OGIMCFPJDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private IDisposable CIHOPJJPAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private ByteString JNNBCEFKFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private LKEKFLMHAOA.KIOHNINKNOH.GNGDFKGALGL KACAEMGBKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private bool JEDLFHMNLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private KKJKOBMDCHM BNNJAPHFIAN;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	protected World NMEOLLGGKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	protected World OFIFOCNNODF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x27C7550", Offset = "0x27C6750", VA = "0x1827C7550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public BDNEDPOFMOK NBMLOFPALLM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x27C7930", Offset = "0x27C6B30", VA = "0x1827C7930")]
	public FDILNOMJFLI(BHIKEJGKPLP DAJKBHKJPOA, PEKDFCFCENH LHCMKIAHBCL, PEKDFCFCENH HMFKDAPADAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x27C7670", Offset = "0x27C6870", VA = "0x1827C7670", Slot = "5")]
	public ByteString PDFKDPENEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x27C6BE0", Offset = "0x27C5DE0", VA = "0x1827C6BE0", Slot = "7")]
	public void GNJLBDDANJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x27C6B80", Offset = "0x27C5D80", VA = "0x1827C6B80", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x27C75A0", Offset = "0x27C67A0", VA = "0x1827C75A0", Slot = "9")]
	protected virtual JPNNIGLELPN ODFEEHOPACB()
	{
		return default(JPNNIGLELPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool IOHFDBEFFKO();

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void JPDDKADGBDM();

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> CFKFKAMMBFF(NativeArray<EntityRemapUtility.EntityRemapInfo> KNKOALFFAEO);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[DDDGJOKMEDO(typeof(LCAPGECPAMK), new string[] { })]
internal sealed class LEDFKEMMKFA : LCAPGECPAMK, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	[MOHONECELPE]
	private MKDGDMAKODP BGHLPJDBPOE;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LKEKFLMHAOA.KIOHNINKNOH.GNGDFKGALGL LIIDDPIHEGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A80330", Offset = "0x2A7F530", VA = "0x182A80330", Slot = "4")]
		get
		{
			return default(LKEKFLMHAOA.KIOHNINKNOH.GNGDFKGALGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A802E0", Offset = "0x2A7F4E0", VA = "0x182A802E0", Slot = "5")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public LEDFKEMMKFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal class JPFCNANGNDA : KPICKPJENBH, JHFDKBHOKBE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private readonly LBNHDDDNAIH BGHGOMFIAIP;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public LocalId NNDIAMNJMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x25B7B00", Offset = "0x25B6D00", VA = "0x1825B7B00", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IEnumerable<EHDODNDLPHI> ABAOCMOJMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x25B78F0", Offset = "0x25B6AF0", VA = "0x1825B78F0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public LGMOGAKCIAN KBDMAINAOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x25B7920", Offset = "0x25B6B20", VA = "0x1825B7920", Slot = "5")]
		get
		{
			return default(LGMOGAKCIAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Task NKHCGNBKOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x25B7AB0", Offset = "0x25B6CB0", VA = "0x1825B7AB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public BDNEDPOFMOK BDNFJHHFADD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x25B7A60", Offset = "0x25B6C60", VA = "0x1825B7A60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x25B7B10", Offset = "0x25B6D10", VA = "0x1825B7B10")]
	public JPFCNANGNDA(ByteString CCBKAEHNCPH, BHIKEJGKPLP DAJKBHKJPOA, Action<bool> PACPKCKKHCA, Action DLJBCDJHJBG, Action DGJLKEEFAIC, Action IFCDFOBKGCM, bool FBOEGKMDBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x25B7A80", Offset = "0x25B6C80", VA = "0x1825B7A80", Slot = "9")]
	public bool HJLCKJBAGNL(KMMLKGKMKMM DLHBAJIIOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x25B7960", Offset = "0x25B6B60", VA = "0x1825B7960", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class NNNDNCDKHDM
{
	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A330", Offset = "0x2A99530", VA = "0x182A9A330")]
	public static IOHOFDNHACB.OJDIJOMMIEP JFEFOGBCKNA(BHIKEJGKPLP DAJKBHKJPOA)
	{
		return default(IOHOFDNHACB.OJDIJOMMIEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A410", Offset = "0x2A99610", VA = "0x182A9A410")]
	public static NativeList<Entity> MIDHNMPLODA(EntityManager NMHMIPEFENM, IEnumerable<BMDJOHDFBDL> BOIJHJLHIPE)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A280", Offset = "0x2A99480", VA = "0x182A9A280")]
	public static void CFKFKAMMBFF(NativeArray<Entity> GLDJMPKMACN, NativeList<Entity> MIFHFKMHOND, NativeArray<EntityRemapUtility.EntityRemapInfo> KNKOALFFAEO, NativeArray<EntityRemapUtility.EntityRemapInfo> HEPIACAPFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x26EE090", Offset = "0x26ED290", VA = "0x1826EE090")]
	public static Entity AJNGMLINLDG<T>(EntityManager NMHMIPEFENM, in T NABCGCEIEGG) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class OGLNCNIOOJL : JNHLGEOHJON, JHFDKBHOKBE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly LBNHDDDNAIH BGHGOMFIAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private readonly BCLIKNODFFN IMHPCMMAFGL;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public KEAMHPDKNJO EKKMIBCAGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public LocalId NNDIAMNJMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C970", Offset = "0x2A9BB70", VA = "0x182A9C970", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Task NKHCGNBKOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C950", Offset = "0x2A9BB50", VA = "0x182A9C950", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IEnumerable<EHDODNDLPHI> ABAOCMOJMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x25B78F0", Offset = "0x25B6AF0", VA = "0x1825B78F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public LGMOGAKCIAN KBDMAINAOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x25B7920", Offset = "0x25B6B20", VA = "0x1825B7920", Slot = "8")]
		get
		{
			return default(LGMOGAKCIAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public BDNEDPOFMOK BDNFJHHFADD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x25B7A60", Offset = "0x25B6C60", VA = "0x1825B7A60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C990", Offset = "0x2A9BB90", VA = "0x182A9C990")]
	public OGLNCNIOOJL(ByteString CCBKAEHNCPH, KEAMHPDKNJO IDOGNNLLNHF, in EDGPEBAJCFE HPANENBGKED, BHIKEJGKPLP DAJKBHKJPOA, Action IFCDFOBKGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C8D0", Offset = "0x2A9BAD0", VA = "0x182A9C8D0", Slot = "5")]
	public void GNJLBDDANJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C910", Offset = "0x2A9BB10", VA = "0x182A9C910", Slot = "12")]
	public bool HJLCKJBAGNL(KMMLKGKMKMM DLHBAJIIOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C930", Offset = "0x2A9BB30", VA = "0x182A9C930", Slot = "6")]
	public void JCPFNIHJNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C8B0", Offset = "0x2A9BAB0", VA = "0x182A9C8B0", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[DDDGJOKMEDO(typeof(HEDLOJKNBDM), new string[] { })]
public class NJHFNDOGHGF : HEDLOJKNBDM, FHBJALEEHFO, DFEMCICPEOE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private POCHLGNFBCE DAJKBHKJPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private OEFLNLBOHFB CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private KNKOHPGNOPB IHIGFPCIIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private FLFMIDDEJIH ONMNMDAFEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private ALOPNKJDLEE HBHMCMADCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private HNMHAJLPHMH AMPOACOBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private DFFEELNDGLN KAKKOCFGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private IHPPALHFKFG EAAEGPDMONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private JLJMMGONAJH APLHFLOJOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private DBIJIJBKMMK PPJAICKPJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private OOMBIJKANHD BKACNKMBAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private CFHHLPHHLOO MNFEDONOPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private DDHMFKIBELN HBMDCKMDJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private CFNPKKKFCDJ INGFBFNFPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private BODOIGGIMGD JAFNPLPHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private HKGANBMDICA LCMPEGHJHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private GDAEOFPGCHD BHFAMPMNBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private HEJIKGNEDOI IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private MKDGDMAKODP PPLNMLEIDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private LFBNOCAADDA EFGGIEHCPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public POCHLGNFBCE FBCEAFFBAED
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public OEFLNLBOHFB OIIAJNFHDML
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public MMIPKKPAOLG IJIGCGEAIBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public JPLJDCFLDIF DDOKPBDICDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public ALOPNKJDLEE NMACKCAFKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public HNMHAJLPHMH OACPGOFIBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public DFFEELNDGLN BOKIONJFPGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public JLJMMGONAJH CNPFIIIKGIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public DBIJIJBKMMK MIHPOMIGBEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public OOMBIJKANHD NFEANMEALDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x9CCD40", Offset = "0x9CBF40", VA = "0x1809CCD40", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public CFHHLPHHLOO EDBIJJOPMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFD0", Offset = "0x8DB1D0", VA = "0x1808DBFD0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public DDHMFKIBELN LCFKIDEHIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x999860", Offset = "0x998A60", VA = "0x180999860", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CFNPKKKFCDJ KNMILDHLGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4E0", Offset = "0x8D96E0", VA = "0x1808DA4E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public BODOIGGIMGD LNNHHFJGCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xA15620", Offset = "0xA14820", VA = "0x180A15620", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public HKGANBMDICA AEHOKEFKIAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EA0", Offset = "0x8D40A0", VA = "0x1808D4EA0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public GDAEOFPGCHD GAHNAGGKJMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xA13AD0", Offset = "0xA12CD0", VA = "0x180A13AD0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public HEJIKGNEDOI BDHLLNEAOED
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xB1D850", Offset = "0xB1CA50", VA = "0x180B1D850", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MKDGDMAKODP GFMMJHEFHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA07360", Offset = "0xA06560", VA = "0x180A07360", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public LFBNOCAADDA BLIIDALJLMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xA2EC30", Offset = "0xA2DE30", VA = "0x180A2EC30", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public JKBMNBGOHLH DLPNNLBMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x890110", Offset = "0x88F310", VA = "0x180890110", Slot = "23")]
		get
		{
			return default(JKBMNBGOHLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A987F0", Offset = "0x2A979F0", VA = "0x182A987F0", Slot = "24")]
	public void AOIILMDJJDP(POCHLGNFBCE KIHGLKLDAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2A98B00", Offset = "0x2A97D00", VA = "0x182A98B00", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2A98B10", Offset = "0x2A97D10", VA = "0x182A98B10", Slot = "25")]
	public void EIOJNCNDJBC(POCHLGNFBCE KIHGLKLDAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public NJHFNDOGHGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[DDDGJOKMEDO(typeof(OEFLNLBOHFB), new string[] { })]
public class PDIIDLBLEMA : OEFLNLBOHFB, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public CPJBOBMOPIJ MELFIOLJGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private JHLOBONCNLI LEIKMJFHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private EEAHAAKHGLK OLCGBKFPPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private AFKHAAIJADF CMLGHPBCCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x88F7E0", Offset = "0x88E9E0", VA = "0x18088F7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public FLAEPGHGFAB JMJFNMJIKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DD0", Offset = "0x8D2FD0", VA = "0x1808D3DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public CIBCMPCFKJH LJPOGGEAOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x89A3F0", VA = "0x18089B1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public AOIKACBNBJM MHJMCLBLOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8C35B0", Offset = "0x8C27B0", VA = "0x1808C35B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public GKMACPCGMIC NFCNKHJNIBG
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x9ED510", Offset = "0x9EC710", VA = "0x1809ED510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public POFDHBBBAEI BIGFODCNCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x903CE0", Offset = "0x902EE0", VA = "0x180903CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public LGMPOOCECDN JDAGHOBEHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x9ED500", Offset = "0x9EC700", VA = "0x1809ED500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public CHIIOLBAOJH IKOCBPPJCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x99DCE0", Offset = "0x99CEE0", VA = "0x18099DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private FALEHKILAHO EIFOEKMGJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x9AF470", Offset = "0x9AE670", VA = "0x1809AF470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public DFGILHNBIEM GPMDLAFIEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x9CCD40", Offset = "0x9CBF40", VA = "0x1809CCD40", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x978C00", Offset = "0x977E00", VA = "0x180978C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private FBGEPJKMLBI EDBIJJOPMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BA0", Offset = "0x8D7DA0", VA = "0x1808D8BA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private HJKDEOOCPAC NGGDJBFCMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD00", Offset = "0x9ACF00", VA = "0x1809ADD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E0A0", Offset = "0x2A9D2A0", VA = "0x182A9E0A0", Slot = "13")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public PDIIDLBLEMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[DefaultMember("Item")]
public class EIIAJEBBDAE : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class HOKOPBCGJDH : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public EIIAJEBBDAE <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0x99B8A0", Offset = "0x99AAA0", VA = "0x18099B8A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0x2220B90", Offset = "0x221FD90", VA = "0x182220B90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public HOKOPBCGJDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x22209D0", Offset = "0x221FBD0", VA = "0x1822209D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x2220B50", Offset = "0x221FD50", VA = "0x182220B50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly List<ulong> HOKBPKEGIPJ;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C20", Offset = "0x8C7E20", VA = "0x1808C8C20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x27BE750", Offset = "0x27BD950", VA = "0x1827BE750")]
	public EIIAJEBBDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x27BE6E0", Offset = "0x27BD8E0", VA = "0x1827BE6E0", Slot = "4")]
	[IteratorStateMachine(typeof(HOKOPBCGJDH))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x27BE6E0", Offset = "0x27BD8E0", VA = "0x1827BE6E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class LKCJALKIDLL
{
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly ComponentType[] PIDLCGNMHIO;

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2A849D0", Offset = "0x2A83BD0", VA = "0x182A849D0")]
	public static Entity HJEFLBIGJBE(this EntityManager NMHMIPEFENM)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class JDMJGJIIEJP<T> : NCPAKEMJFAO<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2FE9E20", Offset = "0x2FE9020", VA = "0x182FE9E20")]
	public JDMJGJIIEJP(T JGECELACBDE, T CBOHJJDJGAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[DDDGJOKMEDO(typeof(LJMLPOJGJJE), new string[] { })]
public sealed class EGFNJHOGEHK : LJMLPOJGJJE, JOECCMCPHLC<LJMLPOJGJJE>, PNKPNDDLHPG, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private readonly Dictionary<MCNHINHNBBI, ILODKGMDNJL> HDOHLHPKBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private KHHMNMFJCLM BMJPLBNAOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private JOHINJPAKCH EAAEGPDMONP;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool HNPFDAKNFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAC0", Offset = "0x7EACC0", VA = "0x1807EBAC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x27BDD40", Offset = "0x27BCF40", VA = "0x1827BDD40")]
	public EGFNJHOGEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x27BDC50", Offset = "0x27BCE50", VA = "0x1827BDC50", Slot = "5")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x27BDBD0", Offset = "0x27BCDD0", VA = "0x1827BDBD0", Slot = "6")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x27BDA40", Offset = "0x27BCC40", VA = "0x1827BDA40", Slot = "4")]
	public bool FCPLDEOENIG(MCNHINHNBBI CJNGPAPKKID, out ILODKGMDNJL KADEEFPKHJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[DDDGJOKMEDO(typeof(KHHMNMFJCLM), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal sealed class KHHMNMFJCLM : PNKPNDDLHPG
{
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private readonly Dictionary<Type, ILODKGMDNJL> HDOHLHPKBCB;

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x25BFC30", Offset = "0x25BEE30", VA = "0x1825BFC30", Slot = "4")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x25BFB20", Offset = "0x25BED20", VA = "0x1825BFB20")]
	public void JJOABFDKIHC(Type FBNKHAJKFLM, ILODKGMDNJL KADEEFPKHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x25BFA40", Offset = "0x25BEC40", VA = "0x1825BFA40")]
	public bool FCPLDEOENIG(Type FBNKHAJKFLM, out ILODKGMDNJL KADEEFPKHJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x25BFD10", Offset = "0x25BEF10", VA = "0x1825BFD10")]
	public KHHMNMFJCLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class CEMONADINCN
{
	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x262AFA0", Offset = "0x262A1A0", VA = "0x18262AFA0")]
	public static void JJOABFDKIHC(this KHHMNMFJCLM INBMBKDICBE, ILODKGMDNJL KADEEFPKHJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class NCPAKEMJFAO<T> : BGEBHCFLCGP<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	protected DHPDNMFBNLF<T> MDEJPJFEGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	protected LGMOOOHAOPH<T> IABAMLLBBIA;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0xD34620", Offset = "0xD33820", VA = "0x180D34620")]
	public NCPAKEMJFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x1C53320", Offset = "0x1C52520", VA = "0x181C53320")]
	public NCPAKEMJFAO(DHPDNMFBNLF<T> MDEJPJFEGEG, LGMOOOHAOPH<T> IABAMLLBBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x1C53040", Offset = "0x1C52240", VA = "0x181C53040", Slot = "10")]
	protected override T JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x1C52C70", Offset = "0x1C51E70", VA = "0x181C52C70", Slot = "11")]
	protected override void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP, T NABCGCEIEGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class ICBCADDJPFB
{
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[DDDGJOKMEDO(typeof(IFABAGNNEHF), new string[] { })]
internal sealed class GFBGCIPLOHK : IFABAGNNEHF, PNKPNDDLHPG, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<MCNHINHNBBI, MNJPLNLGGHG> HDJICMJPMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private JOHINJPAKCH EAAEGPDMONP;

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x27CEBE0", Offset = "0x27CDDE0", VA = "0x1827CEBE0", Slot = "6")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x27CEB10", Offset = "0x27CDD10", VA = "0x1827CEB10", Slot = "7")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x27CEB70", Offset = "0x27CDD70", VA = "0x1827CEB70", Slot = "4")]
	public void JJOABFDKIHC(MCNHINHNBBI HAGDCDMAFAF, Type HFJFBKDLIFC, MNJPLNLGGHG HPCHEPAMAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x27CEC30", Offset = "0x27CDE30", VA = "0x1827CEC30", Slot = "5")]
	public bool MAABIBMCOEN(MCNHINHNBBI HAGDCDMAFAF, out MNJPLNLGGHG HPCHEPAMAJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x27CECA0", Offset = "0x27CDEA0", VA = "0x1827CECA0")]
	public GFBGCIPLOHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[DDDGJOKMEDO(typeof(GGPANEIKFII), new string[] { })]
internal sealed class FAKODGNDAGF : GGPANEIKFII, DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	[MOHONECELPE]
	private JOHINJPAKCH EAAEGPDMONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private NativeBitArray OGIGPDCFLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private NativeParallelHashMap<NACALKPEILN, int> BFFKGOKEKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private NativeList<int> HBJLGJIIDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private int OOCNLGCNJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private int NECPDAJPBOK;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool JLHLDBCJPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x27C6340", Offset = "0x27C5540", VA = "0x1827C6340", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public JJACLKAAFCB JHGBPDNOPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x27C63F0", Offset = "0x27C55F0", VA = "0x1827C63F0", Slot = "7")]
		get
		{
			return default(JJACLKAAFCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x27C65D0", Offset = "0x27C57D0", VA = "0x1827C65D0", Slot = "4")]
	public bool HDOHHONGEII(NACALKPEILN EPGIOGIKNGK, MCNHINHNBBI BGOCDAGKFNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x27C6650", Offset = "0x27C5850", VA = "0x1827C6650", Slot = "8")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x27C6440", Offset = "0x27C5640", VA = "0x1827C6440", Slot = "6")]
	public void GOMCOLJJABD(NativeArray<NACALKPEILN> FIPCNCFGHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x27C60C0", Offset = "0x27C52C0", VA = "0x1827C60C0", Slot = "5")]
	public void BPHBIMCGGOO(NACALKPEILN EPGIOGIKNGK, Span<MCNHINHNBBI> EAAEGPDMONP, bool JDEANBFNBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x27C6360", Offset = "0x27C5560", VA = "0x1827C6360", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public FAKODGNDAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[DDDGJOKMEDO(typeof(EMNPBOOGNLC), new string[] { })]
public class PFILJAIGGEA : EMNPBOOGNLC, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	[MOHONECELPE]
	private LGMPOOCECDN CKIBMJIJHCL;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private uint FJPMIMACEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x24549A0", Offset = "0x2453BA0", VA = "0x1824549A0", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2454A50", Offset = "0x2453C50", VA = "0x182454A50", Slot = "5")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public PFILJAIGGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public abstract class NNOJOCCAEEO : ILODKGMDNJL
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public abstract Type MKEOKAGBPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD, Span<byte> NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP, ReadOnlySpan<byte> NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	protected NNOJOCCAEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public abstract class BGEBHCFLCGP<T> : NNOJOCCAEEO where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public override Type MKEOKAGBPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x2313C80", Offset = "0x2312E80", VA = "0x182313C80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP, T NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2314770", Offset = "0x2313970", VA = "0x182314770", Slot = "8")]
	public override void JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD, Span<byte> BJPEGONLJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x23140C0", Offset = "0x23132C0", VA = "0x1823140C0", Slot = "9")]
	public override void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP, ReadOnlySpan<byte> FGIADOJFAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x21FF520", Offset = "0x21FE720", VA = "0x1821FF520")]
	protected BGEBHCFLCGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class ICEKLGJJGAE
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public struct KPBPFBMHNDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public JPLJDCFLDIF KPFCGANDCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public JOHINJPAKCH PGOMFIDKJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public EIFIFHHKJPI NPHDLLPIABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public GGPANEIKFII JGDGCNOJDID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public KDHIEDDFGEM FOLMCJCIONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public LJMLPOJGJJE HDOHLHPKBCB;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2222B00", Offset = "0x2221D00", VA = "0x182222B00")]
		public void FGNOPHJIAHN(POCHLGNFBCE DAJKBHKJPOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct CKOOMFNPKAB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NativeList<NACALKPEILN> CJGGJGGNMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public NativeList<DLGBACOGEKM> NBHGMLCGCLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public NativeList<NACALKPEILN> KPKKLHACPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public NativeParallelMultiHashMap<NACALKPEILN, AIBGADIMBJB> EAAEGPDMONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public NativeList<byte> KMJANGHMGFK;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool JOGPCNPEIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x221A760", Offset = "0x2219960", VA = "0x18221A760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x221A6C0", Offset = "0x22198C0", VA = "0x18221A6C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct EMCEOHPCJON : IComparer<AIBGADIMBJB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x221D390", Offset = "0x221C590", VA = "0x18221D390", Slot = "4")]
		public int Compare(AIBGADIMBJB JPBGAMDOIJA, AIBGADIMBJB IIJHAMIHIMK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private static readonly PEKDFCFCENH DEBJKOHKBBF;

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x25AD0C0", Offset = "0x25AC2C0", VA = "0x1825AD0C0")]
	public static void IHKEJOJNIFP(ref BNCPNGEELJE CEPBCDHNGKP, CKOOMFNPKAB JFGIPFOFKHL, KPBPFBMHNDE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x25ACB10", Offset = "0x25ABD10", VA = "0x1825ACB10")]
	public static CKOOMFNPKAB DCEAPOJAIBK(ref INAJGCDGPOG EGONDKPIJPD, Allocator KPFKDHLBOGB, KPBPFBMHNDE DAJKBHKJPOA)
	{
		return default(CKOOMFNPKAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x25ADE10", Offset = "0x25AD010", VA = "0x1825ADE10")]
	public static void KIFIFDBNBPK(CKOOMFNPKAB JFGIPFOFKHL, KPBPFBMHNDE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x25AC5E0", Offset = "0x25AB7E0", VA = "0x1825AC5E0")]
	public static void BIFJKCODHOM(CKOOMFNPKAB JFGIPFOFKHL, KPBPFBMHNDE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x25AC8D0", Offset = "0x25ABAD0", VA = "0x1825AC8D0")]
	public static int CILKPNAOGFI(CKOOMFNPKAB JFGIPFOFKHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x25ACA50", Offset = "0x25ABC50", VA = "0x1825ACA50")]
	private static void CPEBFEDKAJH(ref BNCPNGEELJE CEPBCDHNGKP, NativeArray<NACALKPEILN> CJGGJGGNMNO, NativeArray<DLGBACOGEKM> NBHGMLCGCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x25ACE30", Offset = "0x25AC030", VA = "0x1825ACE30")]
	private static void DFCELHFLFFL(ref INAJGCDGPOG EGONDKPIJPD, Allocator KPFKDHLBOGB, out NativeList<NACALKPEILN> CJGGJGGNMNO, out NativeList<DLGBACOGEKM> EHNEKEGBPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x25AE1E0", Offset = "0x25AD3E0", VA = "0x1825AE1E0")]
	private static void LMNPECMCKAO(ref BNCPNGEELJE CEPBCDHNGKP, NativeArray<NACALKPEILN> KPKKLHACPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x25ACFC0", Offset = "0x25AC1C0", VA = "0x1825ACFC0")]
	private static void HIICLIDBHMB(ref INAJGCDGPOG EGONDKPIJPD, Allocator KPFKDHLBOGB, out NativeList<NACALKPEILN> KPKKLHACPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x25AD360", Offset = "0x25AC560", VA = "0x1825AD360")]
	private static void JCEAFNILKEO(ref BNCPNGEELJE CEPBCDHNGKP, NativeParallelMultiHashMap<NACALKPEILN, AIBGADIMBJB> EAAEGPDMONP, NativeList<byte> KMJANGHMGFK, KPBPFBMHNDE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x25AE270", Offset = "0x25AD470", VA = "0x1825AE270")]
	private static void MMANFBIDIHF(ref INAJGCDGPOG EGONDKPIJPD, Allocator KPFKDHLBOGB, out NativeParallelMultiHashMap<NACALKPEILN, AIBGADIMBJB> EAAEGPDMONP, out NativeList<byte> KMJANGHMGFK, KPBPFBMHNDE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x25AE1C0", Offset = "0x25AD3C0", VA = "0x1825AE1C0")]
	private static void LBOMFMGMKCD(int AFEDACNGBEG, ref int JPPMELAFLAM, ref BNCPNGEELJE CEPBCDHNGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x25AE1A0", Offset = "0x25AD3A0", VA = "0x1825AE1A0")]
	private static int KLMLIDJHEPH(int JPPMELAFLAM, ref INAJGCDGPOG EGONDKPIJPD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal static class KFLHLDDLPAJ
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class AJOLLDAOJME
	{
		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class OJMEIJLHHMO<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public OJMEIJLHHMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x2020CA0", Offset = "0x201FEA0", VA = "0x182020CA0")]
			internal void IHICFMKHDKM(ref BNCPNGEELJE writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x2020A20", Offset = "0x201FC20", VA = "0x182020A20")]
			internal T GLBDKGCPHDI(ref INAJGCDGPOG reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2216260", Offset = "0x2215460", VA = "0x182216260")]
		public static void KOMPOFAAEDJ(KHHMNMFJCLM HDOHLHPKBCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x263B4A0", Offset = "0x263A6A0", VA = "0x18263B4A0")]
		private static void EFOAHNFLCOB<T>(KHHMNMFJCLM HDOHLHPKBCB, int CBOHJJDJGAA) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x263B400", Offset = "0x263A600", VA = "0x18263B400")]
		private static void DBIIJGHCAMH<T>(ref BNCPNGEELJE CEPBCDHNGKP, T DGJKEMKCNIO, int CBOHJJDJGAA) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x263B5C0", Offset = "0x263A7C0", VA = "0x18263B5C0")]
		private static T MPFCEPIGILG<T>(ref INAJGCDGPOG EGONDKPIJPD, int CBOHJJDJGAA) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AJOLLDAOJME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class ANJEAJFIPCD : DLKKJPGBHCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private KHHMNMFJCLM HDOHLHPKBCB;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x263BC70", Offset = "0x263AE70", VA = "0x18263BC70", Slot = "6")]
		public override void AEDMKMGIEDL<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x2216320", Offset = "0x2215520", VA = "0x182216320")]
		public static void EPJLDLOMKBE(KHHMNMFJCLM HDOHLHPKBCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x22163D0", Offset = "0x22155D0", VA = "0x1822163D0")]
		public ANJEAJFIPCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x25BD210", Offset = "0x25BC410", VA = "0x1825BD210")]
	public static void IEEDLMJMANH(KHHMNMFJCLM HDOHLHPKBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x25BD110", Offset = "0x25BC310", VA = "0x1825BD110")]
	private static void CIGHPFBLADM(ref BNCPNGEELJE PAOCKMKCBDM, quaternion DGJKEMKCNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x25BEC70", Offset = "0x25BDE70", VA = "0x1825BEC70")]
	private static quaternion JNNDAPAANKG(ref INAJGCDGPOG CINIEBHLBCG)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x1CD2BF0", Offset = "0x1CD1DF0", VA = "0x181CD2BF0")]
	public static void JPGOLEKJEMM<T>(KHHMNMFJCLM HDOHLHPKBCB, DHPDNMFBNLF<T> MDEJPJFEGEG, LGMOOOHAOPH<T> IABAMLLBBIA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x1CD2C80", Offset = "0x1CD1E80", VA = "0x181CD2C80")]
	public static void OBOIHKOAEAI<T>(KHHMNMFJCLM KADEEFPKHJE) where T : struct, INGMBGOCEKO
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DDDGJOKMEDO(typeof(AEAIJMEJGNK), new string[] { })]
internal class OJNDMOEFOEE : DCLDDNDKGBL, AEAIJMEJGNK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[MOHONECELPE]
	private EMNPBOOGNLC CMEFNIKNDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private JOIPDLIOENJ AJMOMKGODKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private int GLCABCMGHGM;

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CFC0", Offset = "0x2A9C1C0", VA = "0x182A9CFC0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CE80", Offset = "0x2A9C080", VA = "0x182A9CE80", Slot = "5")]
	public PKINEBOAGLJ DLFIHHHEMBL(ReadOnlySpan<byte> GJNKBDPFGGF)
	{
		return default(PKINEBOAGLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CFB0", Offset = "0x2A9C1B0", VA = "0x182A9CFB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public OJNDMOEFOEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DDDGJOKMEDO(typeof(KDHIEDDFGEM), new string[] { })]
public class PBGELGLHGPD : KDHIEDDFGEM, PNKPNDDLHPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private FOLCKOGKMPF BLDGCGCNMHM;

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DBA0", Offset = "0x2A9CDA0", VA = "0x182A9DBA0", Slot = "8")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D5B0", Offset = "0x2A9C7B0", VA = "0x182A9D5B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DA30", Offset = "0x2A9CC30", VA = "0x182A9DA30", Slot = "4")]
	public void KIFIFDBNBPK(NACALKPEILN KHBBAOCDKFN, MCNHINHNBBI HAGDCDMAFAF, ReadOnlySpan<byte> LLKIDGKPJPD, ReadOnlySpan<byte> HIKFJBBEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DC80", Offset = "0x2A9CE80", VA = "0x182A9DC80", Slot = "7")]
	public bool OHOFJHBMDAN(NACALKPEILN KHBBAOCDKFN, MCNHINHNBBI HAGDCDMAFAF, Span<byte> LLKIDGKPJPD, Span<byte> HIKFJBBEHDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9DC40", Offset = "0x2A9CE40", VA = "0x182A9DC40", Slot = "5")]
	public bool LFKOFILDNBF(NACALKPEILN KHBBAOCDKFN, MCNHINHNBBI HAGDCDMAFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D570", Offset = "0x2A9C770", VA = "0x182A9D570", Slot = "6")]
	public bool BIFJKCODHOM(NACALKPEILN KHBBAOCDKFN, MCNHINHNBBI HAGDCDMAFAF, ReadOnlySpan<byte> HIKFJBBEHDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D5C0", Offset = "0x2A9C7C0", VA = "0x182A9D5C0")]
	private bool GGFDHAAJLAL(NACALKPEILN KHBBAOCDKFN, MCNHINHNBBI HAGDCDMAFAF, ReadOnlySpan<byte> HIKFJBBEHDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public PBGELGLHGPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class MHJGDFNAKCK<T> : BGEBHCFLCGP<T> where T : struct, INGMBGOCEKO
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2E90", Offset = "0x3AA2090", VA = "0x183AA2E90", Slot = "10")]
	protected override T JHIOLOAEPHF(ref INAJGCDGPOG EGONDKPIJPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2E60", Offset = "0x3AA2060", VA = "0x183AA2E60", Slot = "11")]
	protected override void IOAMGHHAJNN(ref BNCPNGEELJE CEPBCDHNGKP, T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0B10", Offset = "0x1FBFD10", VA = "0x181FC0B10")]
	public MHJGDFNAKCK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	public class PhysicsSceneAddCollidersSystem : KNNEOPGGIBD, DCLDDNDKGBL
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

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x2225E30", Offset = "0x2225030", VA = "0x182225E30")]
			private void CHEGCCDBFJM(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x2225F30", Offset = "0x2225130", VA = "0x182225F30", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private IMHEJHMCEPI ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private FOEBEFHCPPN colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x245CB40", Offset = "0x245BD40", VA = "0x18245CB40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x245C8E0", Offset = "0x245BAE0", VA = "0x18245C8E0", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x245CBA0", Offset = "0x245BDA0", VA = "0x18245CBA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x245C7F0", Offset = "0x245B9F0", VA = "0x18245C7F0")]
		private void BDNCKHOOMFB(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x245C940", Offset = "0x245BB40", VA = "0x18245C940", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class CFBFKHICKHM : ILHFNJMEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	protected override LCOECJPMODN GCCLHHLKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "17")]
		get
		{
			return default(LCOECJPMODN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x262B010", Offset = "0x262A210", VA = "0x18262B010")]
	public CFBFKHICKHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class BDFOFFBCODG : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[BurstCompile]
	private struct CAFJNPCOMJA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		[ReadOnly]
		public ComponentTypeHandle<NMNIMNAKHFI> PMLMHFLJNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public ComponentTypeHandle<GMIHIEHPGOF> IDHCAIINEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public ComponentTypeHandle<LLPDNIBHICC> BHHBFHIOFHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public ComponentTypeHandle<JNNEGLMKDKE> ADGNKAGJODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public uint LDIKCCIHMGG;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x22194F0", Offset = "0x22186F0", VA = "0x1822194F0", Slot = "4")]
		public void Execute(ArchetypeChunk PEHGOEJDGEP, int NNAODBDJDNJ, int ADEAHANFGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x2219460", Offset = "0x2218660", VA = "0x182219460")]
		public bool COAGMNJHOFB(ArchetypeChunk PEHGOEJDGEP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private EntityQuery AMPOACOBJJO;

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2627B80", Offset = "0x2626D80", VA = "0x182627B80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2627C90", Offset = "0x2626E90", VA = "0x182627C90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public BDFOFFBCODG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public sealed class NGKDBHLDIMB : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private CJBMEKLNLMM MHGFMGGOLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private BCLIKNODFFN IMHPCMMAFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private IBMCNLNFCOD DLHBAJIIOKJ;

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A98080", Offset = "0x2A97280", VA = "0x182A98080", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A98110", Offset = "0x2A97310", VA = "0x182A98110", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public NGKDBHLDIMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class DKKGNNMHJLK : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x263AF10", Offset = "0x263A110", VA = "0x18263AF10", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public DKKGNNMHJLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(KALKCCNKOML), new string[] { })]
internal class KALKCCNKOML : PJIPLCPBFIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private BLMHHHAEPPE<BELHIIPNIDA, HLNFABHIAIF, AAEOEFNFMEE, FBIOENFOJHC> DGMGGGFGHEK;

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x25B9130", Offset = "0x25B8330", VA = "0x1825B9130", Slot = "4")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public KALKCCNKOML()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	public class PreSerializeTransformRoots : KNNEOPGGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[BurstCompile]
		[NoAlias]
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
			public ComponentTypeHandle<CHDOFCKIBBD> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x60989A0", Offset = "0x6097BA0", VA = "0x1860989A0")]
			private void CHEGCCDBFJM([NoAlias] ref CHDOFCKIBBD data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x609B130", Offset = "0x609A330", VA = "0x18609B130", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[NoAlias]
		[BurstCompile]
		private struct PreSerializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			public ComponentTypeHandle<BOHGFEOLDLP> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x2214E70", Offset = "0x2214070", VA = "0x182214E70")]
			private void CHEGCCDBFJM([NoAlias] ref BOHGFEOLDLP data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x609B200", Offset = "0x609A400", VA = "0x18609B200", Slot = "4")]
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
		private ComponentTypeHandle<CHDOFCKIBBD> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private ComponentTypeHandle<BOHGFEOLDLP> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x2466F30", Offset = "0x2466130", VA = "0x182466F30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x2466580", Offset = "0x2465780", VA = "0x182466580")]
		private void AEJHJAJBACA(in LBIKKMMNADH transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x24667A0", Offset = "0x24659A0", VA = "0x1824667A0")]
		private JobHandle CPGANLKEKJP(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x24668E0", Offset = "0x2465AE0", VA = "0x1824668E0")]
		private JobHandle OGNGAHPAEGF(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x24669F0", Offset = "0x2465BF0", VA = "0x1824669F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PreSerializeTransformRoots()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class HCCGEBBNPAL : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x25A4420", Offset = "0x25A3620", VA = "0x1825A4420", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public HCCGEBBNPAL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	public class PhysicsSceneRemoveCollidersSystem : KNNEOPGGIBD, DCLDDNDKGBL
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
			public ComponentTypeHandle<ILPNINIGIPH> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2225FE0", Offset = "0x22251E0", VA = "0x182225FE0")]
			private void CHEGCCDBFJM(Entity e, in ILPNINIGIPH ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x22260E0", Offset = "0x22252E0", VA = "0x1822260E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private IMHEJHMCEPI ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private FOEBEFHCPPN colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private ComponentTypeHandle<ILPNINIGIPH> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x245D080", Offset = "0x245C280", VA = "0x18245D080", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x245CCA0", Offset = "0x245BEA0", VA = "0x18245CCA0", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x245D0E0", Offset = "0x245C2E0", VA = "0x18245D0E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x245CD00", Offset = "0x245BF00", VA = "0x18245CD00")]
		private void MDIMDNIBEOO(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x245CE40", Offset = "0x245C040", VA = "0x18245CE40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class AHDNCFNIEKI : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[BurstCompile]
	private struct LPCINOJBCFO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		[ReadOnly]
		public NativeArray<OAALOOBPLKH> OHAFILNOIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[ReadOnly]
		public NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public ComponentDataFromEntity IAACJMLJPBM;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2223EC0", Offset = "0x22230C0", VA = "0x182223EC0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[BurstCompile]
	private struct EEBJOBCJEFL : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> NDILAFPPFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> DHCJIIECNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> JHGPJIMHKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> NIKGJBNIIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> DGMIIKJELLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public NativeList<EntityArchetype> OOCCKNJHGGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public NativeList<EntityArchetype> KIIGDDMBBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public NativeList<JJDOOCODKMA> KGHNKDJFCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public NativeList<JJDOOCODKMA> OGJNHCCNPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public NativeList<OAALOOBPLKH> DNEPCKNMOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public NativeList<ComponentType> APJOFAMJHAH;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x221D350", Offset = "0x221C550", VA = "0x18221D350", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x221CC30", Offset = "0x221BE30", VA = "0x18221CC30", Slot = "5")]
		public JobHandle Dispose(JobHandle EMCKGOPIABN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x221CE30", Offset = "0x221C030", VA = "0x18221CE30", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x221CB90", Offset = "0x221BD90", VA = "0x18221CB90")]
		private int CIBHIDGCOBE(JJDOOCODKMA BHOHECEALMG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x221C990", Offset = "0x221BB90", VA = "0x18221C990")]
		private bool CEBMLBAFDCC(int HPIIDKHBNJB, EntityArchetype MPJGLLFEDLN, out EntityArchetype JOBJHHFIFKE, out Entity ILAKMPOLAGO)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[BurstCompile]
	private struct BPFHMOMBJID : IComparer<OAALOOBPLKH>
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2219440", Offset = "0x2218640", VA = "0x182219440", Slot = "4")]
		public int Compare(OAALOOBPLKH JPBGAMDOIJA, OAALOOBPLKH IIJHAMIHIMK)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[BurstCompile]
	private struct DLAGFFAPLON : DCJMLDOFHBP<OAALOOBPLKH, int>
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x1A565F0", Offset = "0x1A557F0", VA = "0x181A565F0")]
		public int DKJAIIGAJBI(in OAALOOBPLKH LBIBKCFHCIL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x1A565F0", Offset = "0x1A557F0", VA = "0x181A565F0", Slot = "4")]
		private int KAEKFLCNFIM(in OAALOOBPLKH NABCGCEIEGG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private struct OAALOOBPLKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Entity ILAKMPOLAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public JJDOOCODKMA IBGFBPGPJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int HHPKNKHAHOB;
	}

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private LBGBICCEAMB MKADFFOHHLL;

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x2621C20", Offset = "0x2620E20", VA = "0x182621C20", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x26224D0", Offset = "0x26216D0", VA = "0x1826224D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x2622580", Offset = "0x2621780", VA = "0x182622580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2621C70", Offset = "0x2620E70", VA = "0x182621C70")]
	private EEBJOBCJEFL JECPJOEKFFK(NativeArray<ArchetypeChunk> AELKLIHNPOK)
	{
		return default(EEBJOBCJEFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x2621880", Offset = "0x2620A80", VA = "0x182621880")]
	private void IGMNHGKJAMN(NativeArray<EntityArchetype> KIIGDDMBBCF, NativeArray<JJDOOCODKMA> KGHNKDJFCJJ, NativeArray<JJDOOCODKMA> OGJNHCCNPIC, NativeArray<ComponentType> APJOFAMJHAH, NativeArray<ArchetypeChunk> AELKLIHNPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x26219E0", Offset = "0x2620BE0", VA = "0x1826219E0")]
	private EntityArchetype IMLPJLDGKED(EntityArchetype JCLMNOIDJPG, NativeArray<ComponentType> APJOFAMJHAH, JJDOOCODKMA LPHPDIBJEMD)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x2621F20", Offset = "0x2621120", VA = "0x182621F20")]
	private JobHandle OIMBPDCHJAA(NativeList<OAALOOBPLKH> OHAFILNOIMM, NativeArray<Entity> IBGFBPGPJKP, JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x26216B0", Offset = "0x26208B0", VA = "0x1826216B0")]
	private JobHandle GFOLFGMNEHI(NativeArray<Entity> IBGFBPGPJKP, NativeArray<OAALOOBPLKH> OHAFILNOIMM, int CNBPDHPGPFI, JJDOOCODKMA LPHPDIBJEMD, JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x26216A0", Offset = "0x26208A0", VA = "0x1826216A0")]
	public static bool EPBIGENMGNG(ComponentType PKEBPHKAGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public AHDNCFNIEKI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	public class PostDeserializeTransformRoots : KNNEOPGGIBD
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
			public ComponentTypeHandle<CHDOFCKIBBD> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0x2214D90", Offset = "0x2213F90", VA = "0x182214D90")]
			private void CHEGCCDBFJM([NoAlias] ref CHDOFCKIBBD data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x22266B0", Offset = "0x22258B0", VA = "0x1822266B0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public ComponentTypeHandle<BOHGFEOLDLP> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x2214E70", Offset = "0x2214070", VA = "0x182214E70")]
			private void CHEGCCDBFJM([NoAlias] ref BOHGFEOLDLP data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2226780", Offset = "0x2225980", VA = "0x182226780", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeTransformRoots_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			public ComponentTypeHandle<EIMFLLKDNCD> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			[ReadOnly]
			public ComponentTypeHandle<CHDOFCKIBBD> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2214E80", Offset = "0x2214080", VA = "0x182214E80")]
			private void CHEGCCDBFJM([NoAlias] ref EIMFLLKDNCD authoredPose, [NoAlias] in CHDOFCKIBBD pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x2226850", Offset = "0x2225A50", VA = "0x182226850", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeTransformRoots_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public ComponentTypeHandle<KKBPIMDFIGE> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			public ComponentTypeHandle<BOHGFEOLDLP> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x2214EA0", Offset = "0x22140A0", VA = "0x182214EA0")]
			private void CHEGCCDBFJM([NoAlias] ref KKBPIMDFIGE authoredScale, [NoAlias] in BOHGFEOLDLP scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x22269A0", Offset = "0x2225BA0", VA = "0x1822269A0", Slot = "4")]
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
		private ComponentTypeHandle<CHDOFCKIBBD> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private ComponentTypeHandle<BOHGFEOLDLP> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private ComponentTypeHandle<EIMFLLKDNCD> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private ComponentTypeHandle<CHDOFCKIBBD> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private ComponentTypeHandle<KKBPIMDFIGE> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private ComponentTypeHandle<BOHGFEOLDLP> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x245F960", Offset = "0x245EB60", VA = "0x18245F960", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x245E7A0", Offset = "0x245D9A0", VA = "0x18245E7A0")]
		private void AEJHJAJBACA(in LBIKKMMNADH transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x245E9D0", Offset = "0x245DBD0", VA = "0x18245E9D0")]
		private void AOCDAEMNDNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x245FE40", Offset = "0x245F040", VA = "0x18245FE40")]
		private JobHandle PANPMPEGLNC(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x245EEE0", Offset = "0x245E0E0", VA = "0x18245EEE0")]
		private JobHandle OBDIICPLOLA(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x245EC20", Offset = "0x245DE20", VA = "0x18245EC20")]
		private JobHandle HIFGFPNAINI(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x245ED80", Offset = "0x245DF80", VA = "0x18245ED80")]
		private JobHandle HONOBPIMMGL(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x245EFF0", Offset = "0x245E1F0", VA = "0x18245EFF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PostDeserializeTransformRoots()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal struct CBMFCKHEFLO : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	internal class SplinePointParentChangedSystem : KNNEOPGGIBD, DCLDDNDKGBL
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
			public DynamicBuffer<global::LPHFGDMHOBO> splineIndexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			[ReadOnly]
			public ComponentTypeHandle<GAAIHPAGNAD> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x609E7C0", Offset = "0x609D9C0", VA = "0x18609E7C0")]
			private void CHEGCCDBFJM(Entity splinePoint, [NoAlias] in GAAIHPAGNAD splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x609E8D0", Offset = "0x609DAD0", VA = "0x18609E8D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[NoAlias]
		[BurstCompile]
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
			public ComponentTypeHandle<global::MGGPMFEKEHP> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x609E9F0", Offset = "0x609DBF0", VA = "0x18609E9F0")]
			private void CHEGCCDBFJM(Entity splinePoint, [NoAlias] in global::MGGPMFEKEHP splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x609EB20", Offset = "0x609DD20", VA = "0x18609EB20", Slot = "4")]
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
		[MOHONECELPE]
		private JCKOIKCNGOK singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private ComponentTypeHandle<GAAIHPAGNAD> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private ComponentTypeHandle<global::MGGPMFEKEHP> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x24692E0", Offset = "0x24684E0", VA = "0x1824692E0", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x2469AE0", Offset = "0x2468CE0", VA = "0x182469AE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x2469AD0", Offset = "0x2468CD0", VA = "0x182469AD0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2469330", Offset = "0x2468530", VA = "0x182469330")]
		private void JJIBNIBEABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x2468E90", Offset = "0x2468090", VA = "0x182468E90")]
		private void AHIIOMDDPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2469290", Offset = "0x2468490", VA = "0x182469290")]
		private EntityCommandBufferSystem IMLBAKBFEOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2469130", Offset = "0x2468330", VA = "0x182469130")]
		private JobHandle EOEFEHCJHED(EntityCommandBuffer ecb, DynamicBuffer<global::LPHFGDMHOBO> splineIndexUpdatesRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2469580", Offset = "0x2468780", VA = "0x182469580")]
		private JobHandle LIOAFJCHJPA(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x24696D0", Offset = "0x24688D0", VA = "0x1824696D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public SplinePointParentChangedSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	public class UpdateInertialProperties : KNNEOPGGIBD, DCLDDNDKGBL
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

				[Cpp2IlInjected.Token(Token = "0x6000616")]
				[Cpp2IlInjected.Address(RVA = "0x609C890", Offset = "0x609BA90", VA = "0x18609C890")]
				[BurstDiscard]
				private static void MBNJCHNMFGD(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000617")]
				[Cpp2IlInjected.Address(RVA = "0x609C420", Offset = "0x609B620", VA = "0x18609C420")]
				private static IntPtr EECPEFMCGAC()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000618")]
				[Cpp2IlInjected.Address(RVA = "0x609C5B0", Offset = "0x609B7B0", VA = "0x18609C5B0")]
				public static void GNEKIDIALPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000619")]
				[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
				public static void KCEHONPEIFO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600061B")]
				[Cpp2IlInjected.Address(RVA = "0x609C670", Offset = "0x609B870", VA = "0x18609C670")]
				public static void LDFPBHJMNFE(IntPtr jobPtr)
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
			public ComponentTypeHandle<ONEBNOCDFJN> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			[ReadOnly]
			public ComponentDataFromEntity<OOJJMLNHELB> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x609EDB0", Offset = "0x609DFB0", VA = "0x18609EDB0")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x609F430", Offset = "0x609E630", VA = "0x18609F430", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x609F3D0", Offset = "0x609E5D0", VA = "0x18609F3D0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void EIHJACMIDKF(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x609F440", Offset = "0x609E640", VA = "0x18609F440")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void LFPBDECHIIM(IntPtr jobPtr)
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
		private BDHDJNEMBDK rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private JPLJDCFLDIF objects;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x246F130", Offset = "0x246E330", VA = "0x18246F130", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x246F8D0", Offset = "0x246EAD0", VA = "0x18246F8D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x246FC40", Offset = "0x246EE40", VA = "0x18246FC40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x246F1A0", Offset = "0x246E3A0", VA = "0x18246F1A0")]
		protected void KPEJLEKGJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x246FCC0", Offset = "0x246EEC0", VA = "0x18246FCC0")]
		protected void POJOHPGICJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x246ED20", Offset = "0x246DF20", VA = "0x18246ED20")]
		private bool HPNODMCNHPG(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, out NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x246F4E0", Offset = "0x246E6E0", VA = "0x18246F4E0")]
		private void LBHKNPCNHHP(ref EntityQueryInJob isTaggedForUpdate, ref EntityQueryInJob rootRbexChangedQuery, ref EntityQueryInJob deformationScaleChangedQuery, ref EntityQueryInJob generalRbexChangedQuery, ref ChunkFilterAnyOf5ComponentsChanged changeFilter, ref int maxEntityCount, ref NativeList<Entity> changedRoots, ref EntityExistenceLookupByEntity entityExists, ref EntityTypeHandle entityTypeRO, ref ComponentTypeHandle<ONEBNOCDFJN> rbexRootTypeRO, ref ComponentDataFromEntity<OOJJMLNHELB> rbexIsKinematicRO, ref Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x246F810", Offset = "0x246EA10", VA = "0x18246F810", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x246F7C0", Offset = "0x246E9C0", VA = "0x18246F7C0")]
		public static void NDFGKNAFJAD()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[DefaultMember("Item")]
public readonly struct AGCHFHEBBNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private readonly int CNBPDHPGPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private readonly int IAONMEHCAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private readonly NativeArray<JJDOOCODKMA>.ReadOnly EAAEGPDMONP;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public int CKAIEHNDOML
	{
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2620C00", Offset = "0x261FE00", VA = "0x182620C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public CLCCDDHEJID JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2620C50", Offset = "0x261FE50", VA = "0x182620C50")]
		get
		{
			return default(CLCCDDHEJID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public int BJGIHMMFLJB
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC50", Offset = "0x15BCE50", VA = "0x1815BDC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public NativeArray<JJDOOCODKMA>.ReadOnly MCLBOEJOHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC00", Offset = "0x15BCE00", VA = "0x1815BDC00")]
		get
		{
			return default(NativeArray<JJDOOCODKMA>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x2620CE0", Offset = "0x261FEE0", VA = "0x182620CE0")]
	public AGCHFHEBBNM(int CNBPDHPGPFI, int IAONMEHCAFB, NativeArray<JJDOOCODKMA>.ReadOnly EAAEGPDMONP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class JBHEEDMMBDI : HCCDJHNELLM
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected override ABAPOMGFJBP DHOHAFONONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x25B38C0", Offset = "0x25B2AC0", VA = "0x1825B38C0", Slot = "15")]
		get
		{
			return default(ABAPOMGFJBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x25B0FE0", Offset = "0x25B01E0", VA = "0x1825B0FE0")]
	public JBHEEDMMBDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class POHIKEDCCNK : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private struct EPFGOHLKHAB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public NAGMBDLGMDD AMPOACOBJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public NativeParallelHashSet<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x221D8E0", Offset = "0x221CAE0", VA = "0x18221D8E0")]
		public EPFGOHLKHAB(int HCKHKGKDPCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x221D860", Offset = "0x221CA60", VA = "0x18221D860", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[BurstCompile]
	private struct ECCCDIGBJPC : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		[ReadOnly]
		public NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		[ReadOnly]
		public ComponentDataFromEntity<GMIHIEHPGOF> ODJPEMKMEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		[ReadOnly]
		public ComponentDataFromEntity<JNNEGLMKDKE> NPCGHKELAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[ReadOnly]
		public ComponentDataFromEntity<LLPDNIBHICC> PLNJOCFJLEJ;

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x221C800", Offset = "0x221BA00", VA = "0x18221C800", Slot = "4")]
		public void Execute(int NNAODBDJDNJ, TransformAccess LNNHFELGMNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[BurstCompile]
	private struct LFPJNPMCMLA : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		[ReadOnly]
		public NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		[ReadOnly]
		public ComponentDataFromEntity<GMIHIEHPGOF> ODJPEMKMEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		[ReadOnly]
		public ComponentDataFromEntity<LLPDNIBHICC> PLNJOCFJLEJ;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x2223300", Offset = "0x2222500", VA = "0x182223300", Slot = "4")]
		public void Execute(int NNAODBDJDNJ, TransformAccess LNNHFELGMNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private FOEBEFHCPPN BKHAEGCLDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private EntityQuery IFOJILDAIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private EntityQuery GIFFHCAOPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private EntityQuery OKNCJDPDNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private EntityQuery NOCBOPCKAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private EntityQuery ODFOILOEEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private JobHandle HDLJBCBCLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private EPFGOHLKHAB LFFLLEPCMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private EPFGOHLKHAB DKAONBPJLHK;

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x245AF10", Offset = "0x245A110", VA = "0x18245AF10", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x245B430", Offset = "0x245A630", VA = "0x18245B430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x245AC30", Offset = "0x2459E30", VA = "0x18245AC30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x245B6E0", Offset = "0x245A8E0", VA = "0x18245B6E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x245ADD0", Offset = "0x2459FD0", VA = "0x18245ADD0")]
	private void GOIPOMFFHOI(EntityQuery JIAIANFJBDB, out (NativeArrayAsync<ILPNINIGIPH> handles, NativeArrayAsync<LMHFDKFEBHE> bounds) JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x245B0D0", Offset = "0x245A2D0", VA = "0x18245B0D0")]
	private void OGFHBNGIKFL((NativeArrayAsync<ILPNINIGIPH> handles, NativeArrayAsync<LMHFDKFEBHE> bounds) JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x245AC30", Offset = "0x2459E30", VA = "0x18245AC30")]
	private void AAFKJCDMPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x245B2F0", Offset = "0x245A4F0", VA = "0x18245B2F0")]
	private void OHEDHFIHILJ(EntityQuery JIAIANFJBDB, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<ILPNINIGIPH> handles) JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x245BE90", Offset = "0x245B090", VA = "0x18245BE90")]
	private void PNCBHEJODLA((NativeArrayAsync<Entity> entities, NativeArrayAsync<ILPNINIGIPH> handles) JFGIPFOFKHL, EPFGOHLKHAB PNAKIENPNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x245AF70", Offset = "0x245A170", VA = "0x18245AF70")]
	private JobHandle MPJDOPEHLOL(EPFGOHLKHAB PNAKIENPNBK, ComponentDataFromEntity<GMIHIEHPGOF> ODJPEMKMEPI, ComponentDataFromEntity<LLPDNIBHICC> PLNJOCFJLEJ, ComponentDataFromEntity<JNNEGLMKDKE> NPCGHKELAPD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x245AC70", Offset = "0x2459E70", VA = "0x18245AC70")]
	private JobHandle GMGAHKNGLBN(EPFGOHLKHAB PNAKIENPNBK, ComponentDataFromEntity<GMIHIEHPGOF> ODJPEMKMEPI, ComponentDataFromEntity<LLPDNIBHICC> PLNJOCFJLEJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public POHIKEDCCNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[JBFEHGAKKCF]
public class PGBODOPGJIM : KNNEOPGGIBD, KHDDPCDLICB.MKMILBFMLLC
{
	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x2454BA0", Offset = "0x2453DA0", VA = "0x182454BA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x2454B50", Offset = "0x2453D50", VA = "0x182454B50")]
	private EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public PGBODOPGJIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[KFAABLOJCJD(typeof(JCPMCJOEMDC))]
[DDDGJOKMEDO(typeof(ENJJBFBECCF), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal class ENJJBFBECCF : DCLDDNDKGBL, JCPMCJOEMDC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	[MOHONECELPE]
	private DNKBKNOAAGM NGKPOKOIJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private KKJKOBMDCHM IGJHGFLEJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private NativeList<byte> JFGIPFOFKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private NativeList<PKINEBOAGLJ> CHCFFHEBIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private NativeList<JJDOOCODKMA> OHLDJHJNNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private int DGBPGIEBICG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<PKINEBOAGLJ, NativeArray<byte>> BNKENHMGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x27BF990", Offset = "0x27BEB90", VA = "0x1827BF990")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x27BFC60", Offset = "0x27BEE60", VA = "0x1827BFC60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x27BFD00", Offset = "0x27BEF00", VA = "0x1827BFD00", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x27BF910", Offset = "0x27BEB10", VA = "0x1827BF910", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x27BFA30", Offset = "0x27BEC30", VA = "0x1827BFA30", Slot = "5")]
	public void FKKCHDBOPML(PKINEBOAGLJ FGIADOJFAEB, ReadOnlySpan<byte> GJNKBDPFGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x27BFBE0", Offset = "0x27BEDE0", VA = "0x1827BFBE0")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x27BFEC0", Offset = "0x27BF0C0", VA = "0x1827BFEC0")]
	public ENJJBFBECCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class JBFEHGAKKCF : BILDCBEKACL
{
	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x8C2A40", Offset = "0x8C1C40", VA = "0x1808C2A40")]
	public JBFEHGAKKCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class NGMNFMKLFGD : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[BurstCompile]
	private struct OEBIKMBGFDF : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		[ReadOnly]
		public NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<CHDOFCKIBBD> LEHJGJLGJFH;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x2224660", Offset = "0x2223860", VA = "0x182224660", Slot = "4")]
		public void Execute(int NNAODBDJDNJ, TransformAccess LNNHFELGMNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x2224830", Offset = "0x2223A30", VA = "0x182224830")]
		private bool HIGJHHAPEFM(float3 KJOKOFBOJIE, float3 CNPGLHEDJDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x2224860", Offset = "0x2223A60", VA = "0x182224860")]
		private bool NONOKBDJKPA(quaternion KJOKOFBOJIE, quaternion CNPGLHEDJDI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[BurstCompile]
	private struct HELBNKAPGAF : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[ReadOnly]
		public NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<BOHGFEOLDLP> BJFBANDDNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<EPFNMOOOKJI> CLCECONGDEJ;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x2220080", Offset = "0x221F280", VA = "0x182220080", Slot = "4")]
		public void Execute(int NNAODBDJDNJ, TransformAccess LNNHFELGMNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly PEKDFCFCENH IPAHDCDIGHM;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly PEKDFCFCENH ADMNIANIDJA;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private static readonly PEKDFCFCENH FLDODGALNGM;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly ProfilerMarker LIOOCPGLKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private PKGBNCCFPJF GNEPDPIHPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x2A981D0", Offset = "0x2A973D0", VA = "0x182A981D0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x2A98240", Offset = "0x2A97440", VA = "0x182A98240", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x2A98280", Offset = "0x2A97480", VA = "0x182A98280", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public NGMNFMKLFGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class OCMDIKDLCPL : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private ALOPNKJDLEE HBHMCMADCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private AIGDDGKGBKN JOCOFLDOOJF;

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B530", Offset = "0x2A9A730", VA = "0x182A9B530", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B4A0", Offset = "0x2A9A6A0", VA = "0x182A9B4A0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B630", Offset = "0x2A9A830", VA = "0x182A9B630", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public OCMDIKDLCPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[OLMIFJOAIBG]
internal abstract class DKOPOEOBCPK : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	protected JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	protected HEJIKGNEDOI IPECNCNJKEI;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	protected abstract ABAPOMGFJBP DHOHAFONONK
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x27B77C0", Offset = "0x27B69C0", VA = "0x1827B77C0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x27B7AF0", Offset = "0x27B6CF0", VA = "0x1827B7AF0")]
	protected void MKNNICHCKIL(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x27B78A0", Offset = "0x27B6AA0", VA = "0x1827B78A0")]
	protected void LGOMIHOBOAP(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x27B7830", Offset = "0x27B6A30", VA = "0x1827B7830")]
	protected ILOOFJFGECE JGCIPPPADCC(EntityQuery JIAIANFJBDB)
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	protected DKOPOEOBCPK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal struct ICMODPKMNMI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public struct NAGMBDLGMDD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private NativeList<Entity> IBGFBPGPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private TransformAccessArray AMPOACOBJJO;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x2A94830", Offset = "0x2A93A30", VA = "0x182A94830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public NativeList<Entity> FHOFPCEBBAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public TransformAccessArray JFHNCGGPCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x2A94780", Offset = "0x2A93980", VA = "0x182A94780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2A948C0", Offset = "0x2A93AC0", VA = "0x182A948C0")]
	public NAGMBDLGMDD(int HCKHKGKDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x2A947A0", Offset = "0x2A939A0", VA = "0x182A947A0")]
	public Entity IAHJNFJBKFB(int NNAODBDJDNJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x2A946B0", Offset = "0x2A938B0", VA = "0x182A946B0")]
	public void CMGELGMDBDL(int HCKHKGKDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x2A945F0", Offset = "0x2A937F0", VA = "0x182A945F0")]
	public int CKPKOIJGHLD(Transform LNNHFELGMNI, Entity BLNICJMKCEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x2A94840", Offset = "0x2A93A40", VA = "0x182A94840")]
	public int LLLNCBEHFGH(int NNAODBDJDNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x2A94700", Offset = "0x2A93900", VA = "0x182A94700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2A947F0", Offset = "0x2A939F0", VA = "0x182A947F0")]
	private void KAMIENIHHDL(int NLCNOJGELNK = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class KOLJBLHKFIP : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private OPFIHGCEBIO LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x25C06E0", Offset = "0x25BF8E0", VA = "0x1825C06E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x25C0670", Offset = "0x25BF870", VA = "0x1825C0670", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x25C07B0", Offset = "0x25BF9B0", VA = "0x1825C07B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public KOLJBLHKFIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
[DDDGJOKMEDO(typeof(FOEBEFHCPPN), new string[] { })]
public sealed class KAKKLIGPBFI : FOEBEFHCPPN, PLEFLDKFGFP, PNKPNDDLHPG, DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	[MOHONECELPE]
	private CHOMHKHHFDB KAKKOCFGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private Collider[] MGNGPCEJCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private RaycastHit[] GGCNFPFEPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private HGANPBCHOHB<AOAANDAGBNG, BoxCollider> IBNHMIAAFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private Scene IBENPLAEBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private PhysicsScene OKDLIBBEGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private GameObject NJPHBJKHIEL;

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x25B8BB0", Offset = "0x25B7DB0", VA = "0x1825B8BB0", Slot = "9")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x25B8AC0", Offset = "0x25B7CC0", VA = "0x1825B8AC0", Slot = "10")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x25B8340", Offset = "0x25B7540", VA = "0x1825B8340", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x25B8D60", Offset = "0x25B7F60", VA = "0x1825B8D60", Slot = "4")]
	public AOAANDAGBNG OIFCGEHGFMG(Entity BLNICJMKCEF)
	{
		return default(AOAANDAGBNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x25B8510", Offset = "0x25B7710", VA = "0x1825B8510", Slot = "5")]
	public void EMHJMNPGEIH(NativeArray<AOAANDAGBNG> IBJHJABBAML, NativeArray<LMHFDKFEBHE> GOCOAPIJJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x25B8440", Offset = "0x25B7640", VA = "0x1825B8440", Slot = "6")]
	public void EDOKMMAPEDE(AOAANDAGBNG EMCKGOPIABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x25B7FD0", Offset = "0x25B71D0", VA = "0x1825B7FD0", Slot = "7")]
	public bool BGIOPOJCEPG(AOAANDAGBNG EMCKGOPIABN, out Collider NAKCMDMIPAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x25B87C0", Offset = "0x25B79C0", VA = "0x1825B87C0")]
	public bool HIKLJPGBGIK(in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, float EKIBGBMDOJP, Allocator KPFKDHLBOGB, out NativeArray<Entity> IBGFBPGPJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x25B8720", Offset = "0x25B7920", VA = "0x1825B8720")]
	private void GBOJNGJIIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x10C0120", Offset = "0x10BF320", VA = "0x1810C0120")]
	private void BJFEDLGKAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x25B8770", Offset = "0x25B7970", VA = "0x1825B8770")]
	private void GGMONGDJPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x1C190F0", Offset = "0x1C182F0", VA = "0x181C190F0")]
	private void FIBKGCFDGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x25B8060", Offset = "0x25B7260", VA = "0x1825B8060")]
	private BoxCollider BIKAKEGFNPC(Entity BLNICJMKCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x25B82B0", Offset = "0x25B74B0", VA = "0x1825B82B0")]
	private void DCNGBHNNFEB(BoxCollider CKGFOMHNGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x25B8EB0", Offset = "0x25B80B0", VA = "0x1825B8EB0")]
	private void PINJEEIBFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x25B8190", Offset = "0x25B7390", VA = "0x1825B8190")]
	private void CMGMGBNIGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x25B7DA0", Offset = "0x25B6FA0", VA = "0x1825B7DA0")]
	private void ABBFBCCLBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x25B8B80", Offset = "0x25B7D80", VA = "0x1825B8B80")]
	private void JHDEMJCCBPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x25B8180", Offset = "0x25B7380", VA = "0x1825B8180")]
	private void BNCDGNFBFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x25B8D20", Offset = "0x25B7F20", VA = "0x1825B8D20")]
	private void NNNCAGKPEEP(Scene OMHKNPIHOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public KAKKLIGPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x25B8330", Offset = "0x25B7530", VA = "0x1825B8330", Slot = "8")]
	private bool DKFGOCLJNIE(in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, float EKIBGBMDOJP, Allocator KPFKDHLBOGB, out NativeArray<Entity> IBGFBPGPJKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public readonly struct ABAPOMGFJBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly ComponentType? EGBACINIKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly ComponentType? NJOGJGBMHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly ComponentType FJFCKHJECMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public readonly object FDCOCHLAHJD;

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x261B9B0", Offset = "0x261ABB0", VA = "0x18261B9B0")]
	public ABAPOMGFJBP(ComponentType? EGBACINIKNK, ComponentType? NJOGJGBMHCB, ComponentType FJFCKHJECMC, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBD50", Offset = "0x1FCAF50", VA = "0x181FCBD50")]
	public static ABAPOMGFJBP JCPBNMDENGE<TReq, TTag>(object FDCOCHLAHJD)
	{
		return default(ABAPOMGFJBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBB30", Offset = "0x1FCAD30", VA = "0x181FCBB30")]
	public static ABAPOMGFJBP BGMLGMAHBHJ<TReq, TMissing, TTag>(object FDCOCHLAHJD)
	{
		return default(ABAPOMGFJBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class BPKNJCJIIPM : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private GGPANEIKFII JGDGCNOJDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private BCLIKNODFFN HIONPLEGOME;

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x262A390", Offset = "0x2629590", VA = "0x18262A390", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x262A400", Offset = "0x2629600", VA = "0x18262A400", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public BPKNJCJIIPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[DDDGJOKMEDO(typeof(FIADFNDFLMG), new string[] { })]
[FBPICDCAGAD(typeof(COAPHLBOHFB))]
public class DPJKEGEGFFB : FIADFNDFLMG, PNKPNDDLHPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private readonly Dictionary<int, HDGGNFNNNFC> JCOLDCHHAIL;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public IEnumerable<HDGGNFNNNFC> PLNMDHMDDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x27BA600", Offset = "0x27B9800", VA = "0x1827BA600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x27BA650", Offset = "0x27B9850", VA = "0x1827BA650", Slot = "6")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x27BA590", Offset = "0x27B9790", VA = "0x1827BA590", Slot = "5")]
	public bool EACPFECEPDP(int CNBPDHPGPFI, out HDGGNFNNNFC KADEEFPKHJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x27BA540", Offset = "0x27B9740", VA = "0x1827BA540", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x27BAA00", Offset = "0x27B9C00", VA = "0x1827BAA00")]
	public DPJKEGEGFFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal class IIAOPNCCMFH : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private EntityQuery PFOMPPMLJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private HJKDEOOCPAC CKIBMJIJHCL;

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x25B0BE0", Offset = "0x25AFDE0", VA = "0x1825B0BE0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x25B0C30", Offset = "0x25AFE30", VA = "0x1825B0C30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x25B0CE0", Offset = "0x25AFEE0", VA = "0x1825B0CE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x21876F0", Offset = "0x21868F0", VA = "0x1821876F0")]
	private bool LOLKOFBNHEE<TComponentData>(EntityQuery JIAIANFJBDB, out NativeArray<Entity> IBGFBPGPJKP, out NativeArray<TComponentData> KJOIBOGAONC) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x25B0B70", Offset = "0x25AFD70", VA = "0x1825B0B70")]
	public BGNCONALOOG FACCEEFACHF(Entity BLNICJMKCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public IIAOPNCCMFH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000103")]
public struct KDJLHCELALP : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[OLMIFJOAIBG]
public class PLNLMAMOAGC : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[BurstCompile]
	private struct DKKDIGICFBG : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		[ReadOnly]
		public NativeArray<Entity> FFMCHKJEKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		[ReadOnly]
		public ComponentDataFromEntity<GAAIHPAGNAD> DNMNONLBJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		[ReadOnly]
		public ComponentDataFromEntity<LMHFDKFEBHE> AAMKCEBMINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter GBKIKNGBGDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter IBBLIAEGNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter JKCOHDNMGBD;

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x221BD70", Offset = "0x221AF70", VA = "0x18221BD70", Slot = "4")]
		public void Execute(int NNAODBDJDNJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[BurstCompile]
	private struct JMOKJKDPHHH : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		[ReadOnly]
		public NativeArray<Entity> GJFNMKGHOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> ALEHKKOLINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		[ReadOnly]
		public ComponentDataFromEntity<AJALCLPOENM> JPMIFMOKDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		[ReadOnly]
		public ComponentDataFromEntity<MIKHADPILJF> GHAGKOAHCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[NativeDisableParallelForRestriction]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<LMHFDKFEBHE> CPNNBNNIGNI;

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x22227E0", Offset = "0x22219E0", VA = "0x1822227E0", Slot = "4")]
		public void Execute(int NNAODBDJDNJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery HGHICINPBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EntityQuery IOLJBPKKJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery NNEBCCNAIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private EntityQuery JOGGNIDMBIM;

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x2456F50", Offset = "0x2456150", VA = "0x182456F50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x2457160", Offset = "0x2456360", VA = "0x182457160", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x2456720", Offset = "0x2455920", VA = "0x182456720")]
	private JobHandle FOHKOEHOMOL(NativeArrayAsync<Entity> LMFDNLBGHBA, int AAALINBAMFJ, JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x2456800", Offset = "0x2455A00", VA = "0x182456800")]
	private JobHandle FOHKOEHOMOL(NativeArray<Entity> JCMCOGMBJEO, int AAALINBAMFJ, [Optional] JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x24562D0", Offset = "0x24554D0", VA = "0x1824562D0")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) FCANHHKDHEG(NativeArrayAsync<Entity> ECOOEILKAHH)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x2456A30", Offset = "0x2455C30", VA = "0x182456A30")]
	private void GMAOPFHMEBH(out NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x2456AC0", Offset = "0x2455CC0", VA = "0x182456AC0")]
	private void HHHJPNICPEK(NativeList<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2456B50", Offset = "0x2455D50", VA = "0x182456B50")]
	private void HHHJPNICPEK(NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x24561A0", Offset = "0x24553A0", VA = "0x1824561A0")]
	private void EABJNHMFGLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void KPBKKLEPFJM(int PNALEIGHILH, int NJIIMCBFFFI, int MOJFPHKMEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x2456C20", Offset = "0x2455E20", VA = "0x182456C20")]
	private static LMHFDKFEBHE ONJMIMLDFBF(NativeArray<Entity> PNGOMAEMIPO, ComponentDataFromEntity<AJALCLPOENM> JPMIFMOKDMG, ComponentDataFromEntity<MIKHADPILJF> GHAGKOAHCBD)
	{
		return default(LMHFDKFEBHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public PLNLMAMOAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct KDJINJGKOPM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private NativeArray<JJDOOCODKMA> CPPNCGLMOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private NativeArray<int> HLNBEBHAONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private NativeParallelHashMap<int, JJDOOCODKMA> JPEIKOAJFKG;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public readonly int COEOBDOOMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x9E7BA0", Offset = "0x9E6DA0", VA = "0x1809E7BA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public readonly int JEOGNNBECOE
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xBB0680", Offset = "0xBAF880", VA = "0x180BB0680")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x25B98F0", Offset = "0x25B8AF0", VA = "0x1825B98F0")]
	public KDJINJGKOPM(IReadOnlyCollection<DCLNFEIOJHB> KJOIBOGAONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x25B97B0", Offset = "0x25B89B0", VA = "0x1825B97B0")]
	public readonly AGCHFHEBBNM IHKJEMCDOKK(int CNBPDHPGPFI)
	{
		return default(AGCHFHEBBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x25B9730", Offset = "0x25B8930", VA = "0x1825B9730", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
[AlwaysUpdateSystem]
public abstract class PELLODHLJDK : KNNEOPGGIBD, KHDDPCDLICB.MKMILBFMLLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	private NativeList<EntityQuery> AOHLHGPBOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private bool MDJMJPOEBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private EntityCommandBufferSystem FBICPICMEOC;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected bool AIIPHFCAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E350", Offset = "0x2A9D550", VA = "0x182A9E350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected abstract PEKDFCFCENH GMDPMBHBMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<KHDDPCDLICB.OBJAMBDMJFG> MCKNKLJMKML();

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E3B0", Offset = "0x2A9D5B0", VA = "0x182A9E3B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E4D0", Offset = "0x2A9D6D0", VA = "0x182A9E4D0", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E480", Offset = "0x2A9D680", VA = "0x182A9E480", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void CBOEHLOFBDC();

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A9E360", Offset = "0x2A9D560", VA = "0x182A9E360")]
	protected EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2343EA0", Offset = "0x23430A0", VA = "0x182343EA0")]
	protected EntityQuery LBJJBMNENBP<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2343000", Offset = "0x2342200", VA = "0x182343000")]
	protected OCIJEOIMNEM<T> GGPPMMKHGII<T>() where T : struct, IComponentData
	{
		return default(OCIJEOIMNEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x2344300", Offset = "0x2343500", VA = "0x182344300")]
	protected OCNKOMDFBIA<T> PJOKFECLEHB<T>() where T : struct, IComponentData
	{
		return default(OCNKOMDFBIA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x2343C20", Offset = "0x2342E20", VA = "0x182343C20")]
	protected static void KAIJFPAEOEL<T1, T2>(NLFEFIAHPPB<T1> DKPOIKKJFDI, NLFEFIAHPPB<T2> IEMDKFFMGCO) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x2343C20", Offset = "0x2342E20", VA = "0x182343C20")]
	protected static void KAIJFPAEOEL<T1, T2>(NLFEFIAHPPB<T1> DKPOIKKJFDI, LBOEPCMIIHK<T2> IEMDKFFMGCO) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x2343B60", Offset = "0x2342D60", VA = "0x182343B60")]
	private static void KAIJFPAEOEL<T1, T2>(OCIPEIPIJCB<T1> DKPOIKKJFDI, OCIPEIPIJCB<T2> IEMDKFFMGCO) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	protected PELLODHLJDK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	[JBFEHGAKKCF]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : PELLODHLJDK
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public OCIJEOIMNEM<NMMEPJKLIPI> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public OCIJEOIMNEM<NELMEDAHHKH> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public OCIJEOIMNEM<DHGBDJJKCDH> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public OCNKOMDFBIA<AOGLDAFPMJF> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public DHGBDJJKCDH v2Default;

			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x2226D90", Offset = "0x2225F90", VA = "0x182226D90")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x2227330", Offset = "0x2226530", VA = "0x182227330", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		protected override PEKDFCFCENH Log
		{
			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x2460A80", Offset = "0x245FC80", VA = "0x182460A80", Slot = "14")]
			get
			{
				return default(PEKDFCFCENH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2460CC0", Offset = "0x245FEC0", VA = "0x182460CC0", Slot = "15")]
		public override IEnumerable<KHDDPCDLICB.OBJAMBDMJFG> MCKNKLJMKML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x24604B0", Offset = "0x245F6B0", VA = "0x1824604B0", Slot = "16")]
		protected override void CBOEHLOFBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x24607C0", Offset = "0x245F9C0", VA = "0x1824607C0")]
		private static void EEGANCLNFIM(OCIPEIPIJCB<NELMEDAHHKH> srcVersion, OCIPEIPIJCB<DHGBDJJKCDH> dstVersion, DHGBDJJKCDH dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2460960", Offset = "0x245FB60", VA = "0x182460960")]
		private static void GCIPICGCPAG(OCIPEIPIJCB<DHGBDJJKCDH> srcVersion, OCIPEIPIJCB<AOGLDAFPMJF> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2460AE0", Offset = "0x245FCE0", VA = "0x182460AE0")]
		private JobHandle JJFFKHPGNGF(OCIJEOIMNEM<NMMEPJKLIPI> v0, OCIJEOIMNEM<NELMEDAHHKH> v1, OCIJEOIMNEM<DHGBDJJKCDH> v2, OCNKOMDFBIA<AOGLDAFPMJF> v3, DHGBDJJKCDH v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x24604A0", Offset = "0x245F6A0", VA = "0x1824604A0")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[AlwaysUpdateSystem]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public abstract class NEOFDAGELGL : KNNEOPGGIBD, PJIPLCPBFIL
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private struct AENCPBCCJCL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public NativeListAsync<Entity> BCOOMEEDGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public NativeListAsync<Entity> FNGEKMFABEC;

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2216170", Offset = "0x2215370", VA = "0x182216170")]
		public AENCPBCCJCL(NativeList<Entity> BCOOMEEDGJM, NativeList<Entity> FNGEKMFABEC, JobHandle FHGDOMMIJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x22160F0", Offset = "0x22152F0", VA = "0x1822160F0")]
		public JobHandle MFPFOBKDBON(JobHandle FOFFIFNKDII)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2216060", Offset = "0x2215260", VA = "0x182216060", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct PIAEDAIAOKI : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		public enum DPNIELNLJBO
		{
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		[WriteOnly]
		public NativeList<Entity> HBGFDGMCPGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		[WriteOnly]
		public NativeList<Entity> EBLAFBIJLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		[ReadOnly]
		public NativeArray<Entity> NFBFAAHGEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		[ReadOnly]
		public BufferFromEntity<JFFGLDLIPLN> KHAIAEPHLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		[ReadOnly]
		public ComponentDataFromEntity LBPHACKMHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		[ReadOnly]
		public ComponentDataFromEntity GGMGMKPBCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		[ReadOnly]
		public ComponentDataFromEntity<BGFGOLHGEPN> PBGPJPANANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public int IHDKJDLBDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int ONDONCBJAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private DPNIELNLJBO BLIMLNECNLH;

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2224DB0", Offset = "0x2223FB0", VA = "0x182224DB0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2224D00", Offset = "0x2223F00", VA = "0x182224D00")]
		private bool DMKLOJBFAJA(Entity BLNICJMKCEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2225430", Offset = "0x2224630", VA = "0x182225430")]
		private void KCEHMEFGECN(Entity BLNICJMKCEF, bool DOKEMPODMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2224FC0", Offset = "0x22241C0", VA = "0x182224FC0")]
		private void GCCEIEHFCJP(Entity BLNICJMKCEF, bool DOKEMPODMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2224C80", Offset = "0x2223E80", VA = "0x182224C80")]
		public AENCPBCCJCL AONLDBIEBIP(NativeArray<Entity> EBANKOKIHCJ, JobHandle FOFFIFNKDII)
		{
			return default(AENCPBCCJCL);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x22255A0", Offset = "0x22247A0", VA = "0x1822255A0")]
		public AENCPBCCJCL PJPEBHAELHN(NativeArray<Entity> EBANKOKIHCJ, JobHandle FOFFIFNKDII)
		{
			return default(AENCPBCCJCL);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2224EE0", Offset = "0x22240E0", VA = "0x182224EE0")]
		public AENCPBCCJCL FJOMGBPDENA(NativeList<PPIJPPICKFO> MLEOGHHEJOI, JobHandle FOFFIFNKDII)
		{
			return default(AENCPBCCJCL);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x22254C0", Offset = "0x22246C0", VA = "0x1822254C0")]
		public AENCPBCCJCL LAAMJPDNINF(NativeList<PPIJPPICKFO> MLEOGHHEJOI, JobHandle FOFFIFNKDII)
		{
			return default(AENCPBCCJCL);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2225350", Offset = "0x2224550", VA = "0x182225350")]
		public AENCPBCCJCL HFIKLPCBDKO(NativeList<FCIJDIMNMDP> MLEOGHHEJOI, JobHandle FOFFIFNKDII)
		{
			return default(AENCPBCCJCL);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2640620", Offset = "0x263F820", VA = "0x182640620")]
		private AENCPBCCJCL GMAHLKIDOGM<T>(NativeList<T> MLEOGHHEJOI, int NDDIJJFOFMB, int BPKDMHPLHCB, DPNIELNLJBO KEDBGMBBPLF, JobHandle FOFFIFNKDII) where T : struct
		{
			return default(AENCPBCCJCL);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x22250D0", Offset = "0x22242D0", VA = "0x1822250D0")]
		private AENCPBCCJCL GMAHLKIDOGM(NativeArray<Entity> IBGFBPGPJKP, int NDDIJJFOFMB, int BPKDMHPLHCB, DPNIELNLJBO KEDBGMBBPLF, JobHandle FOFFIFNKDII)
		{
			return default(AENCPBCCJCL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private EntityQuery DMNDIKNHPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private EntityQuery KGDKOFPMFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private MODEADMIGAP AMDCJCLFNDD;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	protected abstract ComponentType AGMPKCPBLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	protected abstract ComponentType IADFPMAIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected abstract ComponentType PNDMHBPIHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A96500", Offset = "0x2A95700", VA = "0x182A96500")]
	protected NEOFDAGELGL(PEKDFCFCENH LHCMKIAHBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A950D0", Offset = "0x2A942D0", VA = "0x182A950D0", Slot = "14")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A95200", Offset = "0x2A94400", VA = "0x182A95200", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A95430", Offset = "0x2A94630", VA = "0x182A95430", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x15D4390", Offset = "0x15D3590", VA = "0x1815D4390", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A94AF0", Offset = "0x2A93CF0", VA = "0x182A94AF0")]
	private void CIEMBOMAELK(NativeArray<Entity> MLEOGHHEJOI, EntityCommandBuffer HEDKIIMNAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A951B0", Offset = "0x2A943B0", VA = "0x182A951B0")]
	private void MJJMDOCOGCN(NativeArray<Entity> MLEOGHHEJOI, EntityCommandBuffer HEDKIIMNAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A94B40", Offset = "0x2A93D40", VA = "0x182A94B40")]
	private void EOOJALFDHJI(AENCPBCCJCL GAMBBKPFIPK, string CPNIJHHHHFN, EntityCommandBuffer HEDKIIMNAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A94C70", Offset = "0x2A93E70", VA = "0x182A94C70")]
	private void EOOJALFDHJI(NativeListAsync<Entity> KKLAEJANJGM, string CPNIJHHHHFN, EntityCommandBuffer HEDKIIMNAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A94E90", Offset = "0x2A94090", VA = "0x182A94E90")]
	private void FLNKCJAPJJC(AENCPBCCJCL GAMBBKPFIPK, string CPNIJHHHHFN, EntityCommandBuffer HEDKIIMNAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A94D80", Offset = "0x2A93F80", VA = "0x182A94D80")]
	private void FLNKCJAPJJC(NativeListAsync<Entity> KKLAEJANJGM, string CPNIJHHHHFN, EntityCommandBuffer HEDKIIMNAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A94FC0", Offset = "0x2A941C0", VA = "0x182A94FC0")]
	private bool HNPAKDOOAKN()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	public class RegisterTransforms : KNNEOPGGIBD, DCLDDNDKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		private struct RegisterTransforms_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public RegisterTransforms __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public ComponentTypeHandle<JNGGGJCNGDE> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x609C310", Offset = "0x609B510", VA = "0x18609C310")]
			private void OriginalLambdaBody(Entity entity, in JNGGGJCNGDE arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x609C120", Offset = "0x609B320", VA = "0x18609C120", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private PKGBNCCFPJF embodiedTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery allTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private EntityQuery addNewTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private EntityQuery removeOldTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private EntityQuery clearTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private EntityQuery RegisterTransforms_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private ComponentTypeHandle<JNGGGJCNGDE> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2467810", Offset = "0x2466A10", VA = "0x182467810", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2467A90", Offset = "0x2466C90", VA = "0x182467A90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2467D00", Offset = "0x2466F00", VA = "0x182467D00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2467490", Offset = "0x2466690", VA = "0x182467490")]
		private void AddTransforms(EntityQuery query, NAGMBDLGMDD accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2468030", Offset = "0x2467230", VA = "0x182468030")]
		private void RemoveTransforms(EntityQuery query, NAGMBDLGMDD accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2467CA0", Offset = "0x2466EA0", VA = "0x182467CA0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2467350", Offset = "0x2466550", VA = "0x182467350")]
		private void AddNewTransforms(NativeArray<Entity> entities, NAGMBDLGMDD accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2467DF0", Offset = "0x2466FF0", VA = "0x182467DF0")]
		internal static void RemoveOldTransforms(NativeArray<JNGGGJCNGDE> arrayIndices, ComponentDataFromEntity<JNGGGJCNGDE> transformAccess, NAGMBDLGMDD accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		private static void DebugLogRemove(int index, NAGMBDLGMDD accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x24676E0", Offset = "0x24668E0", VA = "0x1824676E0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x24676E0", Offset = "0x24668E0", VA = "0x1824676E0")]
		private void RegisterTransforms_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2467860", Offset = "0x2466A60", VA = "0x182467860", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public RegisterTransforms()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[DDDGJOKMEDO(typeof(MGGGBEIHFIJ), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal sealed class MGGGBEIHFIJ : OHFLHEPJPJP, PNKPNDDLHPG, DCLDDNDKGBL, PJIPLCPBFIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	[MOHONECELPE]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	[MOHONECELPE]
	private HNMHAJLPHMH AMPOACOBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	[MOHONECELPE]
	private OEFLNLBOHFB CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	[MOHONECELPE]
	private CHOMHKHHFDB KAKKOCFGLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	[MOHONECELPE]
	private NFJCJEFFMGP DGLMGGFGGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	[MOHONECELPE]
	private MLJBBEFEOND FBGJBDICMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	[MOHONECELPE]
	private IBMCNLNFCOD DLHBAJIIOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly Dictionary<NACALKPEILN, BGNCONALOOG> BDDINJHFACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private MFCKCFHCGCF LDPHDFMOKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A87ED0", Offset = "0x2A870D0", VA = "0x182A87ED0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0xB87D70", Offset = "0xB86F70", VA = "0x180B87D70", Slot = "4")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A0C0", Offset = "0x2A892C0", VA = "0x182A8A0C0", Slot = "5")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B360", Offset = "0x2A8A560", VA = "0x182A8B360")]
	public void OPHAEIOMFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AC20", Offset = "0x2A89E20", VA = "0x182A8AC20", Slot = "6")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A89590", Offset = "0x2A88790", VA = "0x182A89590", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A89F10", Offset = "0x2A89110", VA = "0x182A89F10")]
	public int HIPDAJJBHFH(SceneTag IBENPLAEBFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A520", Offset = "0x2A89720", VA = "0x182A8A520")]
	public bool JJOCLDFBEJK(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A050", Offset = "0x2A89250", VA = "0x182A8A050")]
	public bool IDPBDNBNHFE(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A87F20", Offset = "0x2A87120", VA = "0x182A87F20")]
	public bool BEEFCOHBNDM(Entity BLNICJMKCEF, out BGNCONALOOG OJKDJMFOHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A87FD0", Offset = "0x2A871D0", VA = "0x182A87FD0")]
	private bool BEEFCOHBNDM(Transform LNNHFELGMNI, out BGNCONALOOG OJKDJMFOHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AD00", Offset = "0x2A89F00", VA = "0x182A8AD00")]
	private void NBPMDMOGPMB(Entity BLNICJMKCEF, BGNCONALOOG OJKDJMFOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A89F40", Offset = "0x2A89140", VA = "0x182A89F40")]
	private bool HMCCMODAGCL(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A330", Offset = "0x2A89530", VA = "0x182A8A330")]
	public void JJOABFDKIHC(NACALKPEILN EPGIOGIKNGK, BGNCONALOOG PDGBOKGMGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A8BBB0", Offset = "0x2A8ADB0", VA = "0x182A8BBB0")]
	public bool PMDHGCOOOBC(BMDJOHDFBDL JHJPAJMEGAG, object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A8BB10", Offset = "0x2A8AD10", VA = "0x182A8BB10")]
	public bool PMDHGCOOOBC(Entity BLNICJMKCEF, [Optional] object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C190", Offset = "0x2A8B390", VA = "0x182A8C190")]
	public bool PMDHGCOOOBC(BGNCONALOOG NLBPABLMMCP, object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A89640", Offset = "0x2A88840", VA = "0x182A89640")]
	public bool ECAIDIAPEHP(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x2A8BB80", Offset = "0x2A8AD80", VA = "0x182A8BB80")]
	public bool PMDHGCOOOBC(BGNCONALOOG OJKDJMFOHNB, bool BEIAPGFNLDJ, [Optional] object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x2A88C40", Offset = "0x2A87E40", VA = "0x182A88C40")]
	private bool CGHLAGMIMOC(BGNCONALOOG OJKDJMFOHNB, object FDCOCHLAHJD, bool BEIAPGFNLDJ, bool ANCHCKHGFLH, bool HKDNOCICFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x2A88080", Offset = "0x2A87280", VA = "0x182A88080")]
	public Transform BEPOGOPLAII(Entity BLNICJMKCEF, [Optional] object FDCOCHLAHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x2A89BF0", Offset = "0x2A88DF0", VA = "0x182A89BF0")]
	public bool ELAJOLEBEAL(Entity BLNICJMKCEF, out Transform LNNHFELGMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A7D0", Offset = "0x2A899D0", VA = "0x182A8A7D0")]
	public BGNCONALOOG KJNINLFGCFK(Entity BLNICJMKCEF, [Optional] object FDCOCHLAHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2A89270", Offset = "0x2A88470", VA = "0x182A89270")]
	public void DDPNIIBFELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x2A8AE20", Offset = "0x2A8A020", VA = "0x182A8AE20")]
	public void NJEAJJELEHN(SceneTag IBENPLAEBFE, bool ANCHCKHGFLH, NativeParallelHashSet<int> FHIFABFDGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x2A88290", Offset = "0x2A87490", VA = "0x182A88290")]
	private void BKICFCLJECK(Entity BLNICJMKCEF, bool ANCHCKHGFLH, bool HKDNOCICFIH, NativeParallelHashSet<int> FHIFABFDGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x2A8ADA0", Offset = "0x2A89FA0", VA = "0x182A8ADA0")]
	public bool NEEIPHPAMEG(Entity BLNICJMKCEF, object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A1F0", Offset = "0x2A893F0", VA = "0x182A8A1F0")]
	public bool JEJLPBHJMJA(Entity BLNICJMKCEF, object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A270", Offset = "0x2A89470", VA = "0x182A8A270")]
	public bool JHHBICNMIEK(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C1C0", Offset = "0x2A8B3C0", VA = "0x182A8C1C0")]
	private void PPGNOGKOENG(bool EOAJDPBANKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x2A89E80", Offset = "0x2A89080", VA = "0x182A89E80")]
	private bool GPLANHINCJA(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x2A89150", Offset = "0x2A88350", VA = "0x182A89150")]
	public BGNCONALOOG CGHNOMEKKCE(Entity BLNICJMKCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x2A89FB0", Offset = "0x2A891B0", VA = "0x182A89FB0")]
	private BGNCONALOOG HPHHLJPJPJH(Entity BLNICJMKCEF, object FDCOCHLAHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A9B0", Offset = "0x2A89BB0", VA = "0x182A8A9B0")]
	private BGNCONALOOG MDGFEPNKPJJ(Entity BLNICJMKCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B1C0", Offset = "0x2A8A3C0", VA = "0x182A8B1C0")]
	public void OMLOHBLNAJL(NativeArray<NACALKPEILN> FIPCNCFGHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x2A89D80", Offset = "0x2A88F80", VA = "0x182A89D80")]
	private void GIAOJAKDCEP(BMDJOHDFBDL JHJPAJMEGAG, BGNCONALOOG PDGBOKGMGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x2A891A0", Offset = "0x2A883A0", VA = "0x182A891A0")]
	private void COLNFLHADLO(BGNCONALOOG PDGBOKGMGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B3B0", Offset = "0x2A8A5B0", VA = "0x182A8B3B0")]
	private void PDAHHALNHGI(BGNCONALOOG OJKDJMFOHNB, Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x2A8B710", Offset = "0x2A8A910", VA = "0x182A8B710")]
	private void PJPPHCMILOF(Entity BLNICJMKCEF, BGNCONALOOG OJKDJMFOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x2A8A8D0", Offset = "0x2A89AD0", VA = "0x182A8A8D0")]
	private void LCBKLPINCGK(Entity BLNICJMKCEF, Transform LNNHFELGMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x27D1AE0", Offset = "0x27D0CE0", VA = "0x1827D1AE0")]
	private BMDJOHDFBDL KCHCNGIHGOL(Entity BLNICJMKCEF)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C310", Offset = "0x2A8B510", VA = "0x182A8C310")]
	public MGGGBEIHFIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2A89CB0", Offset = "0x2A88EB0", VA = "0x182A89CB0")]
	[CompilerGenerated]
	private void GFPINKILAPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public struct ILPNINIGIPH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public AOAANDAGBNG EMCKGOPIABN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0")]
	public static ILPNINIGIPH OMHOCPNBHHH(in AOAANDAGBNG BKPNDENCKKN)
	{
		return default(ILPNINIGIPH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0")]
	public static AOAANDAGBNG OMHOCPNBHHH(in ILPNINIGIPH PGHACOFEBBK)
	{
		return default(AOAANDAGBNG);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	[JBFEHGAKKCF]
	public class PostDeserializeUpgrade_Split_ContainerData : KNNEOPGGIBD, KHDDPCDLICB.MKMILBFMLLC
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Split_ContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public NativeArray<PCMGFFJLBIH> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x2227920", Offset = "0x2226B20", VA = "0x182227920")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x2227BD0", Offset = "0x2226DD0", VA = "0x182227BD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x2461BA0", Offset = "0x2460DA0", VA = "0x182461BA0", Slot = "14")]
		public IEnumerable<KHDDPCDLICB.OBJAMBDMJFG> MCKNKLJMKML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x2461C70", Offset = "0x2460E70", VA = "0x182461C70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x2461B50", Offset = "0x2460D50", VA = "0x182461B50")]
		private EntityCommandBufferSystem IMLBAKBFEOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x2461A00", Offset = "0x2460C00", VA = "0x182461A00")]
		private JobHandle EFPDKNJMFDJ(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<PCMGFFJLBIH> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x2462140", Offset = "0x2461340", VA = "0x182462140")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class GHADJNJAPJA : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x27CFB50", Offset = "0x27CED50", VA = "0x1827CFB50", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x27CFD60", Offset = "0x27CEF60", VA = "0x1827CFD60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x27CFE20", Offset = "0x27CF020", VA = "0x1827CFE20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x27CFBA0", Offset = "0x27CEDA0", VA = "0x1827CFBA0")]
	private NativeArray<Entity> NMMOCKNJNJF(int BKHJHJOLNNF)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x27CFA40", Offset = "0x27CEC40", VA = "0x1827CFA40")]
	private void BLDDNNBADKM(NativeArray<Entity> JKLGMHCFNCC, NativeArray<Entity> OFNHBJAMLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public GHADJNJAPJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[DefaultMember("Item")]
public struct JGANLDMIDHI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private FNAOHLCHFEG<T> JFGIPFOFKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private int AAALINBAMFJ;

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x2FF7890", Offset = "0x2FF6A90", VA = "0x182FF7890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x2FF78E0", Offset = "0x2FF6AE0", VA = "0x182FF78E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[BurstCompile]
public struct NCKNJGBOLHK<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> DGMIIKJELLD;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x1A326A0", Offset = "0x1A318A0", VA = "0x181A326A0")]
	public NCKNJGBOLHK(SharedComponentTypeHandle<T> DGMIIKJELLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x1C527B0", Offset = "0x1C519B0", VA = "0x181C527B0", Slot = "4")]
	public bool Equals(ArchetypeChunk JPBGAMDOIJA, ArchetypeChunk IIJHAMIHIMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x1C528C0", Offset = "0x1C51AC0", VA = "0x181C528C0", Slot = "5")]
	public int GetHashCode(ArchetypeChunk PEHGOEJDGEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[OLMIFJOAIBG]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class IAOKFJEAAHF : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private GLHCMEBBKOL EJNAPPPBKFD;

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x25AA4B0", Offset = "0x25A96B0", VA = "0x1825AA4B0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x25AA500", Offset = "0x25A9700", VA = "0x1825AA500", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public IAOKFJEAAHF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	[OLMIFJOAIBG]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	public class UpdateConnectableVisuals : KNNEOPGGIBD, DCLDDNDKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x200011C")]
		private struct HandlePosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public PFJMGBBLOEJ handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public float3 position;

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x47F0E30", Offset = "0x47F0030", VA = "0x1847F0E30")]
			public HandlePosition(PFJMGBBLOEJ handle, float3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x6099FB0", Offset = "0x60991B0", VA = "0x186099FB0")]
			public void LOLPJHCGKNM(out PFJMGBBLOEJ handle, out float3 position)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011D")]
		private struct UpdateVisualPositions_ParentWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public UpdateConnectableVisuals __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			[ReadOnly]
			public ComponentTypeHandle<GMIHIEHPGOF> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public BufferTypeHandle<MMGHILJIDIN> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x60A01F0", Offset = "0x609F3F0", VA = "0x1860A01F0")]
			private void CHEGCCDBFJM(Entity entity, in GMIHIEHPGOF pose, DynamicBuffer<MMGHILJIDIN> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x60A0470", Offset = "0x609F670", VA = "0x1860A0470", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011E")]
		[BurstCompile]
		[NoAlias]
		private struct UpdateVisualPositions_ChildWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			[ReadOnly]
			public ComponentTypeHandle<GMIHIEHPGOF> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public BufferTypeHandle<AHGNDLOGKJF> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x609FF90", Offset = "0x609F190", VA = "0x18609FF90")]
			private void CHEGCCDBFJM([NoAlias] in GMIHIEHPGOF pose, DynamicBuffer<AHGNDLOGKJF> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x60A0080", Offset = "0x609F280", VA = "0x1860A0080", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[NoAlias]
		[BurstCompile]
		private struct UpdateVisualPositions_ChildWithCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			[ReadOnly]
			public ComponentTypeHandle<GMIHIEHPGOF> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			[ReadOnly]
			public ComponentTypeHandle<NPAEBGIHHKC> __comTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public BufferTypeHandle<AHGNDLOGKJF> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0x609FC70", Offset = "0x609EE70", VA = "0x18609FC70")]
			private void CHEGCCDBFJM([NoAlias] in GMIHIEHPGOF pose, [NoAlias] in NPAEBGIHHKC com, DynamicBuffer<AHGNDLOGKJF> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x609FDB0", Offset = "0x609EFB0", VA = "0x18609FDB0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private EntityQuery addGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private EntityQuery addGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private EntityQuery updateGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery updateGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery removeExpiredGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery removeExpiredGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery removeAllGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private EntityQuery queryLegacyGizmoParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private EntityQuery queryChildrenWoutCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery queryChildrenWithCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private HGANPBCHOHB<PFJMGBBLOEJ, JPHECNJHLAN> linkVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private GDAEOFPGCHD connectables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private JPLJDCFLDIF objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private CFHHLPHHLOO scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private HAGLBAACHAP makerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private EntityQuery UpdateVisualPositions_ParentWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private EntityQuery UpdateVisualPositions_ChildWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private EntityQuery UpdateVisualPositions_ChildWithCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private ComponentTypeHandle<GMIHIEHPGOF> __RecRoom_Components_WorldPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private ComponentTypeHandle<NPAEBGIHHKC> __RecRoom_Rbex_RbexLocalCenterOfMassOfSelfData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x246DA10", Offset = "0x246CC10", VA = "0x18246DA10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x246DF20", Offset = "0x246D120", VA = "0x18246DF20")]
		internal JPHECNJHLAN ONJLCHBJHJD(PFJMGBBLOEJ handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x246D230", Offset = "0x246C430", VA = "0x18246D230", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x246E690", Offset = "0x246D890", VA = "0x18246E690", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x246E900", Offset = "0x246DB00", VA = "0x18246E900", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x246EA90", Offset = "0x246DC90", VA = "0x18246EA90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x246E8C0", Offset = "0x246DAC0", VA = "0x18246E8C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x246AE50", Offset = "0x246A050", VA = "0x18246AE50")]
		private void BPNIPJDLCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x246AF60", Offset = "0x246A160", VA = "0x18246AF60")]
		private void CCEDIFOOJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x246B620", Offset = "0x246A820", VA = "0x18246B620")]
		private void DBOEJHIHIJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x246EAD0", Offset = "0x246DCD0", VA = "0x18246EAD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x246D560", Offset = "0x246C760", VA = "0x18246D560")]
		private void KGILAIAHHCE(EntityQuery add, EntityQuery update, EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x246CA10", Offset = "0x246BC10", VA = "0x18246CA10")]
		private void HCICIMHFKFM(EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x246A620", Offset = "0x2469820", VA = "0x18246A620")]
		private void BBMFKAFHDEN(NativeArrayAsync<Entity> oldEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x246DC10", Offset = "0x246CE10", VA = "0x18246DC10")]
		private void NEMHPHKAFOD(NativeArrayAsync<Entity> newEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x246CAF0", Offset = "0x246BCF0", VA = "0x18246CAF0")]
		private void HJLJBKIGNKG(NativeArrayAsync<Entity> updateEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x246BDD0", Offset = "0x246AFD0", VA = "0x18246BDD0")]
		private void FIIIJABJGLD(NativeList<PFJMGBBLOEJ> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x246A8D0", Offset = "0x2469AD0", VA = "0x18246A8D0")]
		private NativeList<PFJMGBBLOEJ> BIFOIBAIEPD(NativeArray<Entity> entities)
		{
			return default(NativeList<PFJMGBBLOEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x246B0A0", Offset = "0x246A2A0", VA = "0x18246B0A0")]
		private void CKMDHIMBCID(NativeArray<Entity> entities, NativeList<PFJMGBBLOEJ> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x246C4A0", Offset = "0x246B6A0", VA = "0x18246C4A0")]
		private void GDNCJMFIANP(NativeArray<Entity> addParents, NativeArray<Entity> addChildren, NativeList<PFJMGBBLOEJ> freeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x246CDE0", Offset = "0x246BFE0", VA = "0x18246CDE0")]
		private void INOPAHMLKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x246C340", Offset = "0x246B540", VA = "0x18246C340")]
		private NativeListAsync<HandlePosition> FPCDCIDDHJC(EntityQuery query, Func<NativeList<HandlePosition>, JobHandle> populateHandles)
		{
			return default(NativeListAsync<HandlePosition>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x246BF40", Offset = "0x246B140", VA = "0x18246BF40")]
		private JobHandle FJHKGKGJJEL(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x246A4B0", Offset = "0x24696B0", VA = "0x18246A4B0")]
		private JobHandle AJEGAOKMJOH(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x246D2F0", Offset = "0x246C4F0", VA = "0x18246D2F0")]
		private JobHandle JOAGCBBMMEL(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x246BB40", Offset = "0x246AD40", VA = "0x18246BB40")]
		private void FFAFHMFMHNF(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x246C0B0", Offset = "0x246B2B0", VA = "0x18246C0B0")]
		private void FJOCKAAHJJD(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x246DEC0", Offset = "0x246D0C0", VA = "0x18246DEC0")]
		private bool OEFELAHHBKA(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x246D490", Offset = "0x246C690", VA = "0x18246D490")]
		private NativeArray<Entity> KFLDCGKGBNC(Entity entity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x246DA50", Offset = "0x246CC50", VA = "0x18246DA50")]
		private PFJMGBBLOEJ MFGKBPJEIPB(NativeList<PFJMGBBLOEJ> freeList)
		{
			return default(PFJMGBBLOEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x246EC00", Offset = "0x246DE00", VA = "0x18246EC00")]
		private void PCMLGIHDNJD(PFJMGBBLOEJ handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x246CC90", Offset = "0x246BE90", VA = "0x18246CC90")]
		private void HMAAMCAAKAE(ref NativeList<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x246B9D0", Offset = "0x246ABD0", VA = "0x18246B9D0")]
		private JobHandle DCFHENEPEJP(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x246DD20", Offset = "0x246CF20", VA = "0x18246DD20")]
		private JobHandle NFLAKAPHKFB(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x246DF70", Offset = "0x246D170", VA = "0x18246DF70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public UpdateConnectableVisuals()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	internal sealed class WriteDiffChangePacketToNetworkSystem : KNNEOPGGIBD, DCLDDNDKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		[NoAlias]
		private struct WriteDiffChangePacketToNetworkSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x2000123")]
			public delegate void RunWithoutJobSystem_0000090E$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000124")]
			internal static class RunWithoutJobSystem_0000090E$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40003F6")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40003F7")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x600077F")]
				[Cpp2IlInjected.Address(RVA = "0x609CED0", Offset = "0x609C0D0", VA = "0x18609CED0")]
				[BurstDiscard]
				private static void MBNJCHNMFGD(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000780")]
				[Cpp2IlInjected.Address(RVA = "0x609CA60", Offset = "0x609BC60", VA = "0x18609CA60")]
				private static IntPtr EECPEFMCGAC()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000781")]
				[Cpp2IlInjected.Address(RVA = "0x609CBF0", Offset = "0x609BDF0", VA = "0x18609CBF0")]
				public static void GNEKIDIALPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000782")]
				[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
				public static void KCEHONPEIFO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x609CCB0", Offset = "0x609BEB0", VA = "0x18609CCB0")]
				public static void LDFPBHJMNFE(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public JJACLKAAFCB replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			[ReadOnly]
			public NativeArray<NACALKPEILN> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			[ReadOnly]
			public NativeArray<DLGBACOGEKM> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			[ReadOnly]
			public NativeArray<NACALKPEILN> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, GOECINKNCJI> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public NativeList<NACALKPEILN> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public NativeList<DLGBACOGEKM> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public NativeList<NACALKPEILN> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public NativeParallelMultiHashMap<NACALKPEILN, AIBGADIMBJB> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public ComponentDataFromEntity<GODAIDEBOAI> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x60A0630", Offset = "0x609F830", VA = "0x1860A0630")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x60A0B80", Offset = "0x609FD80", VA = "0x1860A0B80", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x60A0B20", Offset = "0x609FD20", VA = "0x1860A0B20")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void EIHJACMIDKF(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x60A0B90", Offset = "0x609FD90", VA = "0x1860A0B90")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void LFPBDECHIIM(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private static readonly PEKDFCFCENH logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		[MOHONECELPE]
		private AEAIJMEJGNK packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		[MOHONECELPE]
		private BCLIKNODFFN diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		[MOHONECELPE]
		private KKJKOBMDCHM editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		[MOHONECELPE]
		private DNKBKNOAAGM transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private ICEKLGJJGAE.KPBPFBMHNDE utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		private JJOOBNGIPMA EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(RVA = "0x2474560", Offset = "0x2473760", VA = "0x182474560")]
			get
			{
				return default(JJOOBNGIPMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2474140", Offset = "0x2473340", VA = "0x182474140", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2474D30", Offset = "0x2473F30", VA = "0x182474D30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2472B20", Offset = "0x2471D20", VA = "0x182472B20")]
		private bool AGGLOIIEBKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2472BF0", Offset = "0x2471DF0", VA = "0x182472BF0")]
		private bool BNDNKKPALIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2473780", Offset = "0x2472980", VA = "0x182473780")]
		private bool DLGMOKEAEDN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x24737D0", Offset = "0x24729D0", VA = "0x1824737D0")]
		private ICEKLGJJGAE.CKOOMFNPKAB HLFJMCNBOFE(JMFALELBNFD state)
		{
			return default(ICEKLGJJGAE.CKOOMFNPKAB);
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2475180", Offset = "0x2474380", VA = "0x182475180")]
		private NativeKeyValueArrays<Entity, GOECINKNCJI> PBJLKAMKNNO(JMFALELBNFD state, out int capacity)
		{
			return default(NativeKeyValueArrays<Entity, GOECINKNCJI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2474200", Offset = "0x2473400", VA = "0x182474200")]
		private void JJENHJCCHIL(ICEKLGJJGAE.CKOOMFNPKAB data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x24749E0", Offset = "0x2473BE0", VA = "0x1824749E0")]
		private void KIFIFDBNBPK(ICEKLGJJGAE.CKOOMFNPKAB data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2472D00", Offset = "0x2471F00", VA = "0x182472D00")]
		private void CMLJJJFMICL(ICEKLGJJGAE.CKOOMFNPKAB data, JMFALELBNFD state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x24748D0", Offset = "0x2473AD0", VA = "0x1824748D0")]
		private void KGPHADJMBGE(NativeArray<NACALKPEILN> createdIds, NativeArray<DLGBACOGEKM> creationData, JJOOBNGIPMA flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x24730B0", Offset = "0x24722B0", VA = "0x1824730B0")]
		private void DFGGLPILEMA(NativeMultiHashMapAsync<Entity, GOECINKNCJI> differences, JJOOBNGIPMA flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2474080", Offset = "0x2473280", VA = "0x182474080")]
		private void ILHLMLKGBCO(NativeArray<NACALKPEILN> destroyedIds, JJOOBNGIPMA flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2474600", Offset = "0x2473800", VA = "0x182474600")]
		private void KANAEGLKMKO(ref JJACLKAAFCB replication, ref NativeBitArray entityByProperty, ref NativeArray<NACALKPEILN> srcCreatedIds, ref NativeArray<DLGBACOGEKM> srcCreationData, ref NativeArray<NACALKPEILN> srcDestroyedIds, ref NativeKeyValueArrays<Entity, GOECINKNCJI> srcPropertyKeyValues, ref NativeList<NACALKPEILN> dstCreatedIds, ref NativeList<DLGBACOGEKM> dstCreationData, ref NativeList<NACALKPEILN> dstDestroyedIds, ref NativeParallelMultiHashMap<NACALKPEILN, AIBGADIMBJB> dstProperties, ref NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2474AD0", Offset = "0x2473CD0", VA = "0x182474AD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2474030", Offset = "0x2473230", VA = "0x182474030")]
		public static void IGLFPNMIPON()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal readonly struct OIHEJNBHEGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	private readonly MBEMEDEEACC MNABPPJOONC;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private static readonly ProfilerMarker OBEGNKLMOHF;

	[Cpp2IlInjected.Token(Token = "0x6000785")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CE20", Offset = "0x2A9C020", VA = "0x182A9CE20")]
	public OIHEJNBHEGJ(World DGIKFFNILOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000786")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CC30", Offset = "0x2A9BE30", VA = "0x182A9CC30")]
	public JobHandle KGILAIAHHCE(JobHandle ENMGEBPBMMN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal static class IMBBGEDGBIH
{
	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x1D14680", Offset = "0x1D13880", VA = "0x181D14680")]
	public static NativeArray<T> GMAHLKIDOGM<T>(NativeArray<Entity> IBGFBPGPJKP, EntityManager NMHMIPEFENM) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x25B1E50", Offset = "0x25B1050", VA = "0x1825B1E50")]
	public static void LGCCALDJNMP(EntityQuery JIAIANFJBDB, EntityManager NMHMIPEFENM, JPLJDCFLDIF KPFCGANDCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x25B1D00", Offset = "0x25B0F00", VA = "0x1825B1D00")]
	public static void HGPILFCOGNP(NativeArray<Entity> JKLGMHCFNCC, JPLJDCFLDIF KPFCGANDCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x25B1BB0", Offset = "0x25B0DB0", VA = "0x1825B1BB0")]
	public static void FPHKOPMPBKJ(NativeArray<Entity> JKLGMHCFNCC, JPLJDCFLDIF KPFCGANDCJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class PMBCPBCGALP : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	private DKFFIBCBDBB ANFEMFHHJAL;

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x2457820", Offset = "0x2456A20", VA = "0x182457820", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x2457870", Offset = "0x2456A70", VA = "0x182457870", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public PMBCPBCGALP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public class FHIHFBHJNDH : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private static PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private EntityQuery MCMKBAJNCDD;

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x27C8BE0", Offset = "0x27C7DE0", VA = "0x1827C8BE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x27C8E80", Offset = "0x27C8080", VA = "0x1827C8E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public FHIHFBHJNDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct DGIJLHOHCDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private static readonly ProfilerMarker OBEGNKLMOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private readonly KNNEOPGGIBD FMGKDHAODCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private NativeList<(EntityQuery query, int componentIndex)> LOJNFDMBLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private NativeList<(EntityQuery query, int componentIndex)> GCDKDJANJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private NativeList<(EntityQuery query, int componentIndex)> OCGJAAMGHFF;

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x26386A0", Offset = "0x26378A0", VA = "0x1826386A0")]
	public DGIJLHOHCDF(KNNEOPGGIBD FMGKDHAODCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x2638110", Offset = "0x2637310", VA = "0x182638110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x26383B0", Offset = "0x26375B0", VA = "0x1826383B0")]
	public NativeList<(EntityQuery, int, int, BAIECHLHPEI.JLMACFODIIC)> KNIDCGOHILK(uint NPKHDADJEIA, out int DCODKFFEHOB)
	{
		return default(NativeList<(EntityQuery, int, int, BAIECHLHPEI.JLMACFODIIC)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x2638200", Offset = "0x2637400", VA = "0x182638200")]
	private int HCMBIJHBIBC(BAIECHLHPEI.JLMACFODIIC KEDBGMBBPLF, NativeList<(EntityQuery query, int typeIndex)> FBJAKOEONGA, NativeList<(EntityQuery query, int typeIndex, int count, BAIECHLHPEI.JLMACFODIIC mode)> DPLIIGPJAPF, uint NPKHDADJEIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x2638170", Offset = "0x2637370", VA = "0x182638170")]
	private NativeList<(EntityQuery, int)> GHGDDHLGNEK(NativeParallelHashSet<int> KJOIBOGAONC, int HFDOPHEECBF)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x26381B0", Offset = "0x26373B0", VA = "0x1826381B0")]
	private NativeList<(EntityQuery, int)> GPPKLFBJGPM(NativeParallelHashSet<int> KJOIBOGAONC, int HFDOPHEECBF)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x2637A40", Offset = "0x2636C40", VA = "0x182637A40")]
	private NativeList<(EntityQuery, int)> ACDGOPGFPFD(NativeParallelHashSet<int> KJOIBOGAONC, int HFDOPHEECBF, BAIECHLHPEI.JLMACFODIIC KEDBGMBBPLF)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x2637E20", Offset = "0x2637020", VA = "0x182637E20")]
	private NativeList<(EntityQuery, int)> BGPLFHJFDLL()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public enum IGONCMPFPOI
{
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public struct DFKKJKBKACB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public IGONCMPFPOI JHNLOGNHNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public int EIDAOCLPGFP;

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5C50", VA = "0x1808B6A50")]
	public DFKKJKBKACB(IGONCMPFPOI JHNLOGNHNGO, int EIDAOCLPGFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x2635580", Offset = "0x2634780", VA = "0x182635580")]
	public static DFKKJKBKACB OMHOCPNBHHH((IGONCMPFPOI eventType, int eventIndex) JPBGAMDOIJA)
	{
		return default(DFKKJKBKACB);
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x2635570", Offset = "0x2634770", VA = "0x182635570")]
	public void LOLPJHCGKNM(out IGONCMPFPOI JHNLOGNHNGO, out int EIDAOCLPGFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct OCNKOMDFBIA<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private NMBGDHMMLIG<T> KBIJDJHCEBH;

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D010", Offset = "0x2D9C210", VA = "0x182D9D010")]
	public OCNKOMDFBIA(NMBGDHMMLIG<T> KBIJDJHCEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x2DA10F0", Offset = "0x2DA02F0", VA = "0x182DA10F0")]
	public LBOEPCMIIHK<T> IAAIOOJOEJC()
	{
		return default(LBOEPCMIIHK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public readonly struct GOECINKNCJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private readonly MCNHINHNBBI CJNGPAPKKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private readonly int LNKNEHIJKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private unsafe readonly byte* GJDKPILBPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private unsafe readonly byte* MIAMOCAHHCC;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public MCNHINHNBBI BGDCEHONODN
	{
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0")]
		get
		{
			return default(MCNHINHNBBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public int EGAKMGBHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC50", Offset = "0x15BCE50", VA = "0x1815BDC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public unsafe byte* JLIHDMAMBAO
	{
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x902ED0", Offset = "0x9020D0", VA = "0x180902ED0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public unsafe byte* NCEGMMPJDDB
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x27D1CD0", Offset = "0x27D0ED0", VA = "0x1827D1CD0")]
	public LKEBNILDCHH KJHICLPEELE(Type FBNKHAJKFLM)
	{
		return default(LKEBNILDCHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C670", Offset = "0x1E2B870", VA = "0x181E2C670")]
	public T JNEJJIHMOMI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C690", Offset = "0x1E2B890", VA = "0x181E2C690")]
	public T KJHICLPEELE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x27D1EB0", Offset = "0x27D10B0", VA = "0x1827D1EB0")]
	public unsafe GOECINKNCJI(MCNHINHNBBI CJNGPAPKKID, int JPJMMBFGIEG, byte* GJDKPILBPJA, byte* MIAMOCAHHCC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal struct MOGHCNJKHFB : IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	[JBFEHGAKKCF]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : PELLODHLJDK
	{
		[Cpp2IlInjected.Token(Token = "0x2000130")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public OCIJEOIMNEM<FPOBAOLIOFC> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public OCNKOMDFBIA<BDMAHJJMIAA> v2;

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0x2226AF0", Offset = "0x2225CF0", VA = "0x182226AF0")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x2226D80", Offset = "0x2225F80", VA = "0x182226D80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		protected override PEKDFCFCENH Log
		{
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x24601C0", Offset = "0x245F3C0", VA = "0x1824601C0", Slot = "14")]
			get
			{
				return default(PEKDFCFCENH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x2460220", Offset = "0x245F420", VA = "0x182460220", Slot = "15")]
		public override IEnumerable<KHDDPCDLICB.OBJAMBDMJFG> MCKNKLJMKML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x245FF80", Offset = "0x245F180", VA = "0x18245FF80", Slot = "16")]
		protected override void CBOEHLOFBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x24600F0", Offset = "0x245F2F0", VA = "0x1824600F0")]
		private static void EEGANCLNFIM(OCIPEIPIJCB<FPOBAOLIOFC> srcVersion, OCIPEIPIJCB<BDMAHJJMIAA> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x24602E0", Offset = "0x245F4E0", VA = "0x1824602E0")]
		private JobHandle NKPJEPCAEBN(OCIJEOIMNEM<FPOBAOLIOFC> v1, OCNKOMDFBIA<BDMAHJJMIAA> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x24604A0", Offset = "0x245F6A0", VA = "0x1824604A0")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class FBMMLJNCDOI : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private EntityQuery DACNGCDAPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private EntityQuery MDBGCMKIHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private FBGEPJKMLBI CKIBMJIJHCL;

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x27C6820", Offset = "0x27C5A20", VA = "0x1827C6820", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x27C6870", Offset = "0x27C5A70", VA = "0x1827C6870", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x27C69C0", Offset = "0x27C5BC0", VA = "0x1827C69C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x27C67B0", Offset = "0x27C59B0", VA = "0x1827C67B0")]
	private void FBLPHOAMODP(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public FBMMLJNCDOI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
public struct PHEKJLFJBID : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal class FEJOJNGLNGN : DCIJLGIBKEE, JMFALELBNFD
{
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly FFJELJCPNLF LFEKOKCEFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly LCOECJPMODN DLHBAJIIOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly World DGIKFFNILOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly List<FFHIFLEKAAF> CMJJBENKNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private NativeParallelMultiHashMap<Entity, GOECINKNCJI> CDKPCCIOKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private NativeParallelHashMap<int, int> FOFCHMHOODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private NativeArray<NACALKPEILN> CJGGJGGNMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private NativeArray<DLGBACOGEKM> NBHGMLCGCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private NativeArray<NACALKPEILN> KPKKLHACPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private JobHandle BJMJCPPKHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private JobHandle HDONOKFJBLF;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private NativeParallelMultiHashMap<Entity, GOECINKNCJI> LIKMGKOOBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xD0D200", Offset = "0xD0C400", VA = "0x180D0D200", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, GOECINKNCJI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private uint ICDABCFIDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x27C7CE0", Offset = "0x27C6EE0", VA = "0x1827C7CE0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	private bool EOEHCNOGECL
	{
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x27C8280", Offset = "0x27C7480", VA = "0x1827C8280", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private NativeArray<NACALKPEILN> ELMCHAEIJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xB0A220", Offset = "0xB09420", VA = "0x180B0A220", Slot = "10")]
		get
		{
			return default(NativeArray<NACALKPEILN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private NativeArray<DLGBACOGEKM> KCDENKAKJGB
	{
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xB0A130", Offset = "0xB09330", VA = "0x180B0A130", Slot = "11")]
		get
		{
			return default(NativeArray<DLGBACOGEKM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private NativeArray<NACALKPEILN> OEOLBHHOHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x27C7AD0", Offset = "0x27C6CD0", VA = "0x1827C7AD0", Slot = "12")]
		get
		{
			return default(NativeArray<NACALKPEILN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x27C8900", Offset = "0x27C7B00", VA = "0x1827C8900")]
	public FEJOJNGLNGN(FFJELJCPNLF LFEKOKCEFGN, LCOECJPMODN DLHBAJIIOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x27C7AE0", Offset = "0x27C6CE0", VA = "0x1827C7AE0", Slot = "6")]
	private bool FGLHLBKDMDI(NativeArray<NACALKPEILN> CJGGJGGNMNO, NativeArray<DLGBACOGEKM> NBHGMLCGCLE, NativeArray<NACALKPEILN> KPKKLHACPOP, int ONFNCJBBOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x27C8290", Offset = "0x27C7490", VA = "0x1827C8290", Slot = "7")]
	private void JJNDEGBMJDM(in FFHIFLEKAAF MLOLIBCACCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x27C8130", Offset = "0x27C7330", VA = "0x1827C8130", Slot = "8")]
	private void JECOCHDFEJE(JobHandle EMCKGOPIABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x27C8550", Offset = "0x27C7750", VA = "0x1827C8550", Slot = "13")]
	private bool NIECFHPFJDN(out NativeArray<int> HFBINPOOEPB, Allocator KPFKDHLBOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x27C8370", Offset = "0x27C7570", VA = "0x1827C8370", Slot = "14")]
	private bool LANOAFPBAED(ComponentType PKEBPHKAGGB, out FFHIFLEKAAF LEMPMGHCAGF, out AGCHFHEBBNM HGLCHOPBPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x27C80B0", Offset = "0x27C72B0", VA = "0x1827C80B0", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, GOECINKNCJI> IICPPAAHJKM()
	{
		return default(NativeMultiHashMapAsync<Entity, GOECINKNCJI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x27C7D90", Offset = "0x27C6F90", VA = "0x1827C7D90")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x27C8600", Offset = "0x27C7800", VA = "0x1827C8600")]
	private bool PIMLIJPCNOH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[InternalBufferCapacity(4)]
internal struct MMGHILJIDIN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public PFJMGBBLOEJ EMCKGOPIABN;
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class IECPOBIHCFN : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x25AEF60", Offset = "0x25AE160", VA = "0x1825AEF60", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public IECPOBIHCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class IMMENEPDIEE : JAGPBMEIJKO
{
	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public IMMENEPDIEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal class GIBLLKCHCGO
{
	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public GIBLLKCHCGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
public readonly struct AIBGADIMBJB : IEquatable<AIBGADIMBJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly MCNHINHNBBI CJNGPAPKKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly int LNKNEHIJKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly int GJDKPILBPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly int MIAMOCAHHCC;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public MCNHINHNBBI BGDCEHONODN
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0")]
		get
		{
			return default(MCNHINHNBBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x2622DD0", Offset = "0x2621FD0", VA = "0x182622DD0")]
	public unsafe ReadOnlySpan<byte> JNEJJIHMOMI(void* JPBDHMAOBNL)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0x2622E40", Offset = "0x2622040", VA = "0x182622E40")]
	public unsafe ReadOnlySpan<byte> KJHICLPEELE(void* JPBDHMAOBNL)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x2092620", Offset = "0x2091820", VA = "0x182092620")]
	public AIBGADIMBJB(MCNHINHNBBI CJNGPAPKKID, int JPJMMBFGIEG, int GJDKPILBPJA, int MIAMOCAHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0x2622C50", Offset = "0x2621E50", VA = "0x182622C50", Slot = "4")]
	public bool Equals(AIBGADIMBJB JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D2")]
	[Cpp2IlInjected.Address(RVA = "0x2622CC0", Offset = "0x2621EC0", VA = "0x182622CC0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0x2622D90", Offset = "0x2621F90", VA = "0x182622D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	[OLMIFJOAIBG]
	[JBFEHGAKKCF]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : PELLODHLJDK, KHDDPCDLICB.MKMILBFMLLC
	{
		[Cpp2IlInjected.Token(Token = "0x200013A")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public OCIJEOIMNEM<FFHIPEJHOGA> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public OCIJEOIMNEM<NJKGKIMPNLN> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0x2227340", Offset = "0x2226540", VA = "0x182227340")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DD")]
			[Cpp2IlInjected.Address(RVA = "0x22276A0", Offset = "0x22268A0", VA = "0x1822276A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		protected override PEKDFCFCENH Log
		{
			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x2461390", Offset = "0x2460590", VA = "0x182461390", Slot = "14")]
			get
			{
				return default(PEKDFCFCENH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x24613F0", Offset = "0x24605F0", VA = "0x1824613F0", Slot = "15")]
		public override IEnumerable<KHDDPCDLICB.OBJAMBDMJFG> MCKNKLJMKML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x2461190", Offset = "0x2460390", VA = "0x182461190", Slot = "16")]
		protected override void CBOEHLOFBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2460F00", Offset = "0x2460100", VA = "0x182460F00")]
		private static void AGFINJFKCLD(NLFEFIAHPPB<NJKGKIMPNLN> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2461040", Offset = "0x2460240", VA = "0x182461040")]
		private JobHandle CAELIMHOJDF(OCIJEOIMNEM<FFHIPEJHOGA> v0, OCIJEOIMNEM<NJKGKIMPNLN> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x24604A0", Offset = "0x245F6A0", VA = "0x1824604A0")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
public readonly struct FFHIFLEKAAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NativeList<Entity> FHOFPCEBBAF
	{
		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public NativeList<Entity> HLJAJDLFGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x99B850", Offset = "0x99AA50", VA = "0x18099B850")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public NativeList<byte> AHHEKPAKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x99B860", Offset = "0x99AA60", VA = "0x18099B860")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public NativeList<byte> FGKEDHAHNKD
	{
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xD0D200", Offset = "0xD0C400", VA = "0x180D0D200")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public NativeList<byte> DLPJFBJIKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x99B880", Offset = "0x99AA80", VA = "0x18099B880")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public ComponentType LKKCKNADAGP
	{
		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public JobHandle OMMPADAGKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x13EDE30", Offset = "0x13ED030", VA = "0x1813EDE30")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public int BJGIHMMFLJB
	{
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0xFCB3F0", Offset = "0xFCA5F0", VA = "0x180FCB3F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public int KJDOBNOALCM
	{
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x905890", Offset = "0x904A90", VA = "0x180905890")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public bool OOKGMFOCCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x27C8B00", Offset = "0x27C7D00", VA = "0x1827C8B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x27C8B80", Offset = "0x27C7D80", VA = "0x1827C8B80")]
	public FFHIFLEKAAF(ComponentType PKEBPHKAGGB, JobHandle EMCKGOPIABN, NativeList<Entity> IBGFBPGPJKP, NativeList<Entity> LJFCABCNOGF, NativeList<byte> NLDAGDBNCNC, NativeList<byte> GAEBCCJAMIL, NativeList<byte> IOKJCDNCOML, int IAONMEHCAFB, int LNKNEHIJKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x27C89E0", Offset = "0x27C7BE0", VA = "0x1827C89E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public abstract class NBEGILHGCNC : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	protected virtual OIGCJBPECJE DDNCHKDKCIL
	{
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "14")]
		get
		{
			return default(OIGCJBPECJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	protected virtual OIGCJBPECJE PCICOCDAOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x890110", Offset = "0x88F310", VA = "0x180890110", Slot = "15")]
		get
		{
			return default(OIGCJBPECJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void GAKNNJLMJKB(OIGCJBPECJE KBIJDJHCEBH);

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A949B0", Offset = "0x2A93BB0", VA = "0x182A949B0", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A94950", Offset = "0x2A93B50", VA = "0x182A94950")]
	private OIGCJBPECJE HFLLCEAHCAL()
	{
		return default(OIGCJBPECJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	protected NBEGILHGCNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[KFAABLOJCJD(typeof(JLJMMGONAJH))]
[DDDGJOKMEDO(typeof(CJBMEKLNLMM), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
public class CJBMEKLNLMM : JLJMMGONAJH, DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	private struct JFNLBGCGEKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public ABPCAMPCFCK MANBMFPNPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public Type FBNKHAJKFLM;
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	private struct GJNPMLNNLEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public JFNLBGCGEKN[] EAAEGPDMONP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[BurstCompile]
	private struct OCNANKKHCHK : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		[ReadOnly]
		public NativeArray<byte> NLEDAHFFCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		[ReadOnly]
		public NativeArray<Entity> ELMBEFIILCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		[ReadOnly]
		public NativeArray<byte> LLOILFGADCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[ReadOnly]
		public NativeArray<byte> MFKBNJPNPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		[WriteOnly]
		public NativeList<Entity> IHJIIPEDCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		[WriteOnly]
		public NativeList<byte> FMCBHHNOHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		[WriteOnly]
		public NativeList<byte> MOBLJKDGECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public int NECPDAJPBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public int FOJPMDJPODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public int APMJOOKCDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public int FLKOIGFFCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int KOMFIMNBNJE;

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x22244A0", Offset = "0x22236A0", VA = "0x1822244A0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly Dictionary<MCNHINHNBBI, ABPCAMPCFCK> DKGFJNKBLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private readonly Dictionary<int, GJNPMLNNLEJ> BDOCMBDPLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private EIFIFHHKJPI EAAEGPDMONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action EKKGFKOJPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x262C7A0", Offset = "0x262B9A0", VA = "0x18262C7A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x262D5E0", Offset = "0x262C7E0", VA = "0x18262D5E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action LAHLHPBAPKN
	{
		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x262C9F0", Offset = "0x262BBF0", VA = "0x18262C9F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x262DFD0", Offset = "0x262D1D0", VA = "0x18262DFD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x262CE80", Offset = "0x262C080", VA = "0x18262CE80", Slot = "6")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x262CA90", Offset = "0x262BC90", VA = "0x18262CA90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x262CEF0", Offset = "0x262C0F0", VA = "0x18262CEF0", Slot = "4")]
	public void JJOABFDKIHC(FAODENBHDMK BGOCDAGKFNE, ABPCAMPCFCK GMILFHAIGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x262CD30", Offset = "0x262BF30", VA = "0x18262CD30", Slot = "5")]
	public void FPJBABEEDGM(FAODENBHDMK BGOCDAGKFNE, ABPCAMPCFCK GMILFHAIGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x262D040", Offset = "0x262C240", VA = "0x18262D040", Slot = "8")]
	public void JJOABFDKIHC(MCNHINHNBBI HAGDCDMAFAF, ABPCAMPCFCK JHGMNDBGFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x262CC10", Offset = "0x262BE10", VA = "0x18262CC10", Slot = "9")]
	public void FPJBABEEDGM(MCNHINHNBBI HAGDCDMAFAF, ABPCAMPCFCK JHGMNDBGFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x262C840", Offset = "0x262BA40", VA = "0x18262C840")]
	private void DIBCDJPDAMA(MCNHINHNBBI HAGDCDMAFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x262D130", Offset = "0x262C330", VA = "0x18262D130")]
	internal void JKGGGEPFGIP(JMFALELBNFD NJGLKOBADEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x262D680", Offset = "0x262C880", VA = "0x18262D680")]
	private void OBFEBLNHCDB(JMFALELBNFD NJGLKOBADEO, int CNBPDHPGPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x262D370", Offset = "0x262C570", VA = "0x18262D370")]
	private void JNCBEJNLHEC(PLBLNCEJEDA ENMMGDOAMCO, JHNBELMGFMH PLJIFGLOMAD, JFNLBGCGEKN IKJNLAFNMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x262C620", Offset = "0x262B820", VA = "0x18262C620")]
	private GJNPMLNNLEJ BIPIADFBOOL(PLBLNCEJEDA ENMMGDOAMCO, JHNBELMGFMH PLJIFGLOMAD)
	{
		return default(GJNPMLNNLEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x262CB20", Offset = "0x262BD20", VA = "0x18262CB20")]
	private JFNLBGCGEKN ELIBACAIIDP(GJNPMLNNLEJ HGLCHOPBPCB, PLBLNCEJEDA ENMMGDOAMCO, JHNBELMGFMH PLJIFGLOMAD)
	{
		return default(JFNLBGCGEKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x262E100", Offset = "0x262D300", VA = "0x18262E100")]
	public CJBMEKLNLMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal class FJFCFMGNFEA : ILHFNJMEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000108")]
	protected override LCOECJPMODN GCCLHHLKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x890110", Offset = "0x88F310", VA = "0x180890110", Slot = "17")]
		get
		{
			return default(LCOECJPMODN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x27C9650", Offset = "0x27C8850", VA = "0x1827C9650")]
	public FJFCFMGNFEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public class IDNPCMMJECN : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[BurstCompile]
	private struct LAKLGGABLEN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		[ReadOnly]
		public ComponentTypeHandle<KHKFGBALMEN> EMBMCNKFOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		[ReadOnly]
		public BufferTypeHandle<JFFGLDLIPLN> PLFGDAKPBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		[ReadOnly]
		public BufferFromEntity<JFFGLDLIPLN> KHAIAEPHLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		[ReadOnly]
		public ComponentDataFromEntity<KHKFGBALMEN> FLDDHGBJFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public ComponentTypeHandle<NMNIMNAKHFI> ECDGIGKOPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<NMNIMNAKHFI> EJLLFAJCCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public uint LDIKCCIHMGG;

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2222BF0", Offset = "0x2221DF0", VA = "0x182222BF0", Slot = "4")]
		public void Execute(ArchetypeChunk PEHGOEJDGEP, int NNAODBDJDNJ, int ADEAHANFGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x2222EF0", Offset = "0x22220F0", VA = "0x182222EF0")]
		private void GJNOPMGNIGB(float4x4 CEJEEMELODG, Entity BLNICJMKCEF, bool FEAMNOPBJMG, int NIEBCEEAAGL = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private EntityQuery FAKFOFLBGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private EntityQuery PPFINCNJCAF;

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x25AE9C0", Offset = "0x25ADBC0", VA = "0x1825AE9C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x25AEAE0", Offset = "0x25ADCE0", VA = "0x1825AEAE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000808")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public IDNPCMMJECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
[OLMIFJOAIBG]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class GEMIKIKFHGM : KNNEOPGGIBD, PNKPNDDLHPG, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[BurstCompile]
	private struct FADKCILEJBF : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		[ReadOnly]
		public EntityTypeHandle ELMBEFIILCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		[ReadOnly]
		public ComponentTypeHandle<GMIHIEHPGOF> MPOHFHNOFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		[WriteOnly]
		public NativeList<BONPPKDBCCB>.ParallelWriter HCJDMGAANDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public ComponentTypeHandle<IKHBCCAECIK> HEJOJKDFHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public float3 BJPEGONLJEK;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static readonly float4x2 JAJILAOBMKO;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private static readonly float4x2 HBIGPIBLIJN;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private static readonly int4x2 OKLCGIJAKIP;

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x221D9F0", Offset = "0x221CBF0", VA = "0x18221D9F0", Slot = "4")]
		public void Execute(ArchetypeChunk PEHGOEJDGEP, int NPCAADALBBC, int MHCLOCKEOJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private static PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private EntityQuery DBHHOBJGLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery HLKFDONHIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private double EEHFKOMNDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private LGMPOOCECDN CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private BEDIIKOKEPM DFHCKKOLOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private GLHCMEBBKOL EJNAPPPBKFD;

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x27CE6F0", Offset = "0x27CD8F0", VA = "0x1827CE6F0", Slot = "14")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x27CE660", Offset = "0x27CD860", VA = "0x1827CE660", Slot = "15")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x27CE700", Offset = "0x27CD900", VA = "0x1827CE700", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x27CE850", Offset = "0x27CDA50", VA = "0x1827CE850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x27CE2C0", Offset = "0x27CD4C0", VA = "0x1827CE2C0")]
	private bool CKBEDJABNFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x27CE370", Offset = "0x27CD570", VA = "0x1827CE370")]
	private void HHIPIAHGKNI(EntityQuery JIAIANFJBDB, float3 EGHKEBHMBGF, string JPKENOAMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public GEMIKIKFHGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
[DDDGJOKMEDO(typeof(LFBNOCAADDA), new string[] { })]
[FBPICDCAGAD(typeof(COAPHLBOHFB))]
public class HBLCCNMDNLH : LFBNOCAADDA, PNKPNDDLHPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private readonly Dictionary<int, DCLNFEIOJHB> MADDEBHHKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private readonly Dictionary<Type, DCLNFEIOJHB> FCFFDKFFGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly Dictionary<Type, DCLNFEIOJHB> LFHDKHLFKEI;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public IReadOnlyCollection<DCLNFEIOJHB> LHBAIFFNKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x27D3530", Offset = "0x27D2730", VA = "0x1827D3530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x27D3600", Offset = "0x27D2800", VA = "0x1827D3600", Slot = "7")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(RVA = "0x27D3580", Offset = "0x27D2780", VA = "0x1827D3580", Slot = "6")]
	public DCLNFEIOJHB IOFJGFADENK(Type FBNKHAJKFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(RVA = "0x27D3470", Offset = "0x27D2670", VA = "0x1827D3470", Slot = "5")]
	public bool ABDIFJJOHAK(int CNBPDHPGPFI, out DCLNFEIOJHB EAAEGPDMONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x27D34E0", Offset = "0x27D26E0", VA = "0x1827D34E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x27D38A0", Offset = "0x27D2AA0", VA = "0x1827D38A0")]
	public HBLCCNMDNLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal class ODGPNBODHKG : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private JHLOBONCNLI CKIBMJIJHCL;

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BC30", Offset = "0x2A9AE30", VA = "0x182A9BC30", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C1B0", Offset = "0x2A9B3B0", VA = "0x182A9C1B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9C260", Offset = "0x2A9B460", VA = "0x182A9C260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9BC80", Offset = "0x2A9AE80", VA = "0x182A9BC80")]
	private void MOAAFJHGLLM(NativeArray<Entity> IBGFBPGPJKP, NativeList<Entity> OLECPKCOLHK, ComponentDataFromEntity<BIIDNNEAIEC> JCHMNNJAOGM, BufferFromEntity<JFFGLDLIPLN> AHBAEIFJOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public ODGPNBODHKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public class HDEGMLJLHCD : KNNEOPGGIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private FJMAADPHJAA FBICPICMEOC;

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x25A4E60", Offset = "0x25A4060", VA = "0x1825A4E60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x25A4F30", Offset = "0x25A4130", VA = "0x1825A4F30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public HDEGMLJLHCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public static class MGHBINLDFAG
{
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly ABAPOMGFJBP LNNHHFJGCGB;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly ABAPOMGFJBP OEHFFEHKKOD;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly ABAPOMGFJBP JLKJGKPFEEM;
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public class IFGNBHELLJM : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[BurstCompile]
	private struct LLMCHFEILBC : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		[ReadOnly]
		public ComponentTypeHandle<CHDOFCKIBBD> BFEHPOOOLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		[ReadOnly]
		public ComponentTypeHandle<EPFNMOOOKJI> AALOFAAHFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[ReadOnly]
		public ComponentTypeHandle<BOHGFEOLDLP> PDINMOANGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public ComponentTypeHandle<KHKFGBALMEN> DDGODJFANPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public uint LDIKCCIHMGG;

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2223590", Offset = "0x2222790", VA = "0x182223590", Slot = "4")]
		public void Execute(ArchetypeChunk PEHGOEJDGEP, int NNAODBDJDNJ, int ADEAHANFGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2223490", Offset = "0x2222690", VA = "0x182223490")]
		public bool COAGMNJHOFB(ArchetypeChunk PEHGOEJDGEP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private EntityQuery AMPOACOBJJO;

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x25B01A0", Offset = "0x25AF3A0", VA = "0x1825B01A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x25B02D0", Offset = "0x25AF4D0", VA = "0x1825B02D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public IFGNBHELLJM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePoints : KNNEOPGGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x200014D")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			[ReadOnly]
			public ComponentDataFromEntity<GACBCEKGGOB> orderRO;

			[Cpp2IlInjected.Token(Token = "0x600082E")]
			[Cpp2IlInjected.Address(RVA = "0x2224B70", Offset = "0x2223D70", VA = "0x182224B70", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200014E")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeSortSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600082F")]
			[Cpp2IlInjected.Address(RVA = "0x22264F0", Offset = "0x22256F0", VA = "0x1822264F0")]
			private void CHEGCCDBFJM(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x2226580", Offset = "0x2225780", VA = "0x182226580", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private EntityQuery PostDeserializeSortSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x245E5F0", Offset = "0x245D7F0", VA = "0x18245E5F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x245E180", Offset = "0x245D380", VA = "0x18245E180")]
		private void HNNKDAAFNLF(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x245E2B0", Offset = "0x245D4B0", VA = "0x18245E2B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PostDeserializeSortSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
public static class KHDDPCDLICB
{
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public interface MKMILBFMLLC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface OBJAMBDMJFG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public class DNCNJFCFONA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public class LKMCIAGAALP : OBJAMBDMJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x2223450", Offset = "0x2222650", VA = "0x182223450")]
		public LKMCIAGAALP(ComponentType FGIADOJFAEB, ComponentType FHGCBDDJBEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public class EMOADONJCGC : OBJAMBDMJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x221D810", Offset = "0x221CA10", VA = "0x18221D810")]
		public EMOADONJCGC(ComponentType FGIADOJFAEB, ComponentType[] FHGCBDDJBEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public class MFCLAMDDEOL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000831")]
	[Cpp2IlInjected.Address(RVA = "0x1CD3F90", Offset = "0x1CD3190", VA = "0x181CD3F90")]
	public static OBJAMBDMJFG GPOHNMGDBID<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000832")]
	[Cpp2IlInjected.Address(RVA = "0x1CD4410", Offset = "0x1CD3610", VA = "0x181CD4410")]
	public static OBJAMBDMJFG NAPIKLIOBDD<TFrom>(params ComponentType[] OFKOJGJGMJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(BEEILEEPNEP), new string[] { })]
internal sealed class BEEILEEPNEP : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private MGGGBEIHFIJ OJKDJMFOHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private JLKPDDHOHDB EIDDFFCFLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x2628C00", Offset = "0x2627E00", VA = "0x182628C00")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<ILOOFJFGECE, NativeArray<IANCKMHPHEB>> JOOPAPLBMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x2628FD0", Offset = "0x26281D0", VA = "0x182628FD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x2629580", Offset = "0x2628780", VA = "0x182629580")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<ILOOFJFGECE> BLEHOEMJDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x2629310", Offset = "0x2628510", VA = "0x182629310")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x2629200", Offset = "0x2628400", VA = "0x182629200")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x26293B0", Offset = "0x26285B0", VA = "0x1826293B0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0xAEF0E0", Offset = "0xAEE2E0", VA = "0x180AEF0E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2628F50", Offset = "0x2628150", VA = "0x182628F50")]
	public bool CCLPLAGPKBK(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2629C90", Offset = "0x2628E90", VA = "0x182629C90")]
	public void PFGELJGDKOG(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x2629BE0", Offset = "0x2628DE0", VA = "0x182629BE0")]
	public void OCNAIOCIFLN(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2629460", Offset = "0x2628660", VA = "0x182629460")]
	private bool KHFOGIJFKCA(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2629620", Offset = "0x2628820", VA = "0x182629620")]
	public void NDBCAEEMEJN(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2629820", Offset = "0x2628A20", VA = "0x182629820")]
	private bool NGOJNNCLENE(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2629070", Offset = "0x2628270", VA = "0x182629070")]
	public void DOHCNDEFFMO(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x2628EF0", Offset = "0x26280F0", VA = "0x182628EF0")]
	private void BHJADKAJINN(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x26289E0", Offset = "0x2627BE0", VA = "0x1826289E0")]
	private void ANPAIKKOOPG(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2629C30", Offset = "0x2628E30", VA = "0x182629C30")]
	private void OIBPILIEMJG(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x2628C50", Offset = "0x2627E50", VA = "0x182628C50")]
	private void BDADJBJMPGI(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x2629180", Offset = "0x2628380", VA = "0x182629180")]
	public void EFJOALHPEHA(ILOOFJFGECE IJPPGDHIGGN, NativeArray<IANCKMHPHEB> MBFFOEIOABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x26292A0", Offset = "0x26284A0", VA = "0x1826292A0")]
	public void GOHAACOFJFK(ILOOFJFGECE IJPPGDHIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private void CFGIPDOFBIC(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x26299E0", Offset = "0x2628BE0", VA = "0x1826299E0")]
	private void NOGMPACKENJ(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084B")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public BEEILEEPNEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
public class MFCKCFHCGCF : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private EntityQuery NKNNOGHMCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private EntityQuery EJJEDAAFFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private EntityQuery NKKKGCBGNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private EntityQuery CELEIKHOBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private MGGGBEIHFIJ HAAOHFMCCEJ;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public int CCMJBPOOGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x2A873D0", Offset = "0x2A865D0", VA = "0x182A873D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x2A87500", Offset = "0x2A86700", VA = "0x182A87500", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x2A87800", Offset = "0x2A86A00", VA = "0x182A87800", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x2A87A00", Offset = "0x2A86C00", VA = "0x182A87A00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x2A872F0", Offset = "0x2A864F0", VA = "0x182A872F0")]
	public int HIPDAJJBHFH(SceneTag IBENPLAEBFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x2A87560", Offset = "0x2A86760", VA = "0x182A87560")]
	protected void JELNPDBFKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x2A873E0", Offset = "0x2A865E0", VA = "0x182A873E0")]
	protected void IKLGAPHKLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x2A87250", Offset = "0x2A86450", VA = "0x182A87250")]
	public NativeArrayAsync<Entity> DPMNPHNNPGI(SceneTag IBENPLAEBFE, Allocator KPFKDHLBOGB = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x2A872A0", Offset = "0x2A864A0", VA = "0x182A872A0")]
	public NativeArrayAsync<Entity> GMGBALJDIBI(SceneTag IBENPLAEBFE, Allocator KPFKDHLBOGB = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x2A87730", Offset = "0x2A86930", VA = "0x182A87730")]
	public bool LJCHPGDDFHM(SceneTag IBENPLAEBFE, out NativeArrayAsync<Entity> OJKDJMFOHNB, Allocator KPFKDHLBOGB = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x2A87370", Offset = "0x2A86570", VA = "0x182A87370")]
	public bool IDPBDNBNHFE(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x2A871E0", Offset = "0x2A863E0", VA = "0x182A871E0")]
	public bool BEEFCOHBNDM(Entity BLNICJMKCEF, out DHOMGICDHJI OJKDJMFOHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x2A877C0", Offset = "0x2A869C0", VA = "0x182A877C0")]
	public void NBPMDMOGPMB(Entity BLNICJMKCEF, DHOMGICDHJI OJKDJMFOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x2A87310", Offset = "0x2A86510", VA = "0x182A87310")]
	public bool HMCCMODAGCL(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public MFCKCFHCGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(IBMCNLNFCOD), new string[] { })]
internal sealed class IBMCNLNFCOD
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public enum ADJCHJIICKP
	{
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public struct PCDHHKMLOHJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private ADJCHJIICKP IJEPGENFDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private readonly IBMCNLNFCOD OJEMCPHOKBP;

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x2224C20", Offset = "0x2223E20", VA = "0x182224C20")]
		public PCDHHKMLOHJ(IBMCNLNFCOD OJEMCPHOKBP, ADJCHJIICKP DLHBAJIIOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x2224BF0", Offset = "0x2223DF0", VA = "0x182224BF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public ADJCHJIICKP DLHBAJIIOKJ;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public ADJCHJIICKP PMDOGKABEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x7E2180", Offset = "0x7E1380", VA = "0x1807E2180")]
		get
		{
			return default(ADJCHJIICKP);
		}
		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xB4F8A0", Offset = "0xB4EAA0", VA = "0x180B4F8A0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool BDOJEGNCGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x21BB4F0", Offset = "0x21BA6F0", VA = "0x1821BB4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x25AA550", Offset = "0x25A9750", VA = "0x1825AA550")]
	public PCDHHKMLOHJ EELBDHPDLGC()
	{
		return default(PCDHHKMLOHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x25AA520", Offset = "0x25A9720", VA = "0x1825AA520")]
	public PCDHHKMLOHJ EEHKGCFIOLM()
	{
		return default(PCDHHKMLOHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000861")]
	[Cpp2IlInjected.Address(RVA = "0x11A0D50", Offset = "0x119FF50", VA = "0x1811A0D50")]
	public IBMCNLNFCOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal readonly struct LDIBMBNPDEL
{
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private static readonly ProfilerMarker OBEGNKLMOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private readonly KNNEOPGGIBD FMGKDHAODCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private readonly World DGIKFFNILOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private readonly EntityQuery KDCJIAIALCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private readonly EntityQuery ICPAMOFMFIH;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x2A801C0", Offset = "0x2A7F3C0", VA = "0x182A801C0")]
	public LDIBMBNPDEL(KNNEOPGGIBD FMGKDHAODCH, World DGIKFFNILOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FFF0", Offset = "0x2A7F1F0", VA = "0x182A7FFF0")]
	public NativeArray<NACALKPEILN> KGILAIAHHCE()
	{
		return default(NativeArray<NACALKPEILN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FB70", Offset = "0x2A7ED70", VA = "0x182A7FB70")]
	public void HAAHPOJMKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FBE0", Offset = "0x2A7EDE0", VA = "0x182A7FBE0")]
	private NativeArray<NACALKPEILN> HJLCKJBAGNL(EntityQuery JIAIANFJBDB)
	{
		return default(NativeArray<NACALKPEILN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class EPLKMNIHMEG : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x27C4140", Offset = "0x27C3340", VA = "0x1827C4140", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public EPLKMNIHMEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal class ODNFDANDGLG : JAGPBMEIJKO
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public ODNFDANDGLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class FCHFPLKIHHA : JAGPBMEIJKO
{
	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public FCHFPLKIHHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct MICACMLIGKF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public int BBOMBIMAMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public int DGOHENJLBBP;
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
public class IAEODCKFLEJ : ParentSystemBase<BELHIIPNIDA, HLNFABHIAIF, FBIOENFOJHC>
{
	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x25AA090", Offset = "0x25A9290", VA = "0x1825AA090", Slot = "14")]
	protected override EntityQueryDesc PHHOGLDJMGC(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x9B0260", Offset = "0x9AF460", VA = "0x1809B0260", Slot = "15")]
	protected override EntityQueryDesc MKENBAHNLHG(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x25AA050", Offset = "0x25A9250", VA = "0x1825AA050", Slot = "16")]
	protected override EntityQueryDesc FEFPMAHJJCP(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x25AA010", Offset = "0x25A9210", VA = "0x1825AA010", Slot = "17")]
	protected override EntityQueryDesc BIGECHHJANE(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x25AA0D0", Offset = "0x25A92D0", VA = "0x1825AA0D0")]
	public IAEODCKFLEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal class CAFEEJIJJMC : HCCDJHNELLM
{
	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	protected override ABAPOMGFJBP DHOHAFONONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x262A650", Offset = "0x2629850", VA = "0x18262A650", Slot = "15")]
		get
		{
			return default(ABAPOMGFJBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x25B0FE0", Offset = "0x25B01E0", VA = "0x1825B0FE0")]
	public CAFEEJIJJMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
public sealed class ENNDNCNEOCO : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0x27C0250", Offset = "0x27BF450", VA = "0x1827C0250", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public ENNDNCNEOCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[ExecuteAlways]
public class AHILOAIJAJE : KFPLABIADMD
{
	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0x8C2A40", Offset = "0x8C1C40", VA = "0x1808C2A40")]
	public AHILOAIJAJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class KHEMJBDEODP : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private EntityQuery ENAKPLMAAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private EntityQuery PBCEBCLHOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private EntityQuery LPPNMLPIEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private EntityQuery KBODDKLBACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private FLAEPGHGFAB CKIBMJIJHCL;

	[Cpp2IlInjected.Token(Token = "0x6000878")]
	[Cpp2IlInjected.Address(RVA = "0x25BF600", Offset = "0x25BE800", VA = "0x1825BF600", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000879")]
	[Cpp2IlInjected.Address(RVA = "0x25BF650", Offset = "0x25BE850", VA = "0x1825BF650", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087A")]
	[Cpp2IlInjected.Address(RVA = "0x25BF880", Offset = "0x25BEA80", VA = "0x1825BF880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087B")]
	[Cpp2IlInjected.Address(RVA = "0x25BF210", Offset = "0x25BE410", VA = "0x1825BF210")]
	private void CKPKOIJGHLD(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0x25BF590", Offset = "0x25BE790", VA = "0x1825BF590")]
	private void HCICIMHFKFM(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087D")]
	[Cpp2IlInjected.Address(RVA = "0x25BF810", Offset = "0x25BEA10", VA = "0x1825BF810", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087E")]
	[Cpp2IlInjected.Address(RVA = "0x25BF280", Offset = "0x25BE480", VA = "0x1825BF280")]
	private void ECCABMDLGJC(EntityQuery JIAIANFJBDB, bool GMKKJGOMPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087F")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public KHEMJBDEODP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
public sealed class CDOKDADNLKF : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(RVA = "0x262A750", Offset = "0x2629950", VA = "0x18262A750", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000882")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public CDOKDADNLKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[DDDGJOKMEDO(typeof(CBAEGILJCHA), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
internal sealed class CBAEGILJCHA : DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private IBMCNLNFCOD IOMHDMPPFAM;

	[Cpp2IlInjected.Token(Token = "0x6000883")]
	[Cpp2IlInjected.Address(RVA = "0x262A6D0", Offset = "0x26298D0", VA = "0x18262A6D0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000884")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public CBAEGILJCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal class HKAAIEEDNFJ : IAFEDJPGFJM
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	protected override ABAPOMGFJBP DHOHAFONONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x25A9890", Offset = "0x25A8A90", VA = "0x1825A9890", Slot = "15")]
		get
		{
			return default(ABAPOMGFJBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000886")]
	[Cpp2IlInjected.Address(RVA = "0x25A7440", Offset = "0x25A6640", VA = "0x1825A7440")]
	public HKAAIEEDNFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
[DDDGJOKMEDO(typeof(GDAEOFPGCHD), new string[] { })]
internal class DFOGBKNJFJJ : GDAEOFPGCHD, DCLDDNDKGBL, PJIPLCPBFIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class BAKHKKKDAEB : IEnumerable<BMDJOHDFBDL>, IEnumerable, IEnumerator<BMDJOHDFBDL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private BMDJOHDFBDL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private BMDJOHDFBDL localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public BMDJOHDFBDL <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public DFOGBKNJFJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private EntityManager <entityManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private LocalId <entity>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private DynamicBuffer<FBIOENFOJHC> <children>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private NativeArray<Entity> <childEntities>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private NativeArray<Entity> <childEntitiesCopy>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private NativeArray<Entity>.Enumerator <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private Entity <child>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		private BMDJOHDFBDL System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0x2216870", Offset = "0x2215A70", VA = "0x182216870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(BMDJOHDFBDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x22168D0", Offset = "0x2215AD0", VA = "0x1822168D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public BAKHKKKDAEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2216920", Offset = "0x2215B20", VA = "0x182216920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x2216430", Offset = "0x2215630", VA = "0x182216430", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x22163E0", Offset = "0x22155E0", VA = "0x1822163E0")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2216770", Offset = "0x2215970", VA = "0x182216770")]
		private void OGHDDOHNOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2216890", Offset = "0x2215A90", VA = "0x182216890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x22167C0", Offset = "0x22159C0", VA = "0x1822167C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BMDJOHDFBDL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x22167C0", Offset = "0x22159C0", VA = "0x1822167C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private static readonly PEKDFCFCENH BAIJKGCKFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private EEAHAAKHGLK CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private CJBMEKLNLMM PALBIMEBCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private LGOHODJFODN<Entity> JKBOPDKCJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private LGOHODJFODN<float3> DDPMHLBIABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private LGOHODJFODN<quaternion> PKEJIJLGFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private LGOHODJFODN<float> MBCKFEAAELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private HashSet<Entity> CFNMMCLIMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private HashSet<Entity> LCFJCMMKBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private EntityQuery HOAJAMLLHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Func<JPHECNJHLAN> EDLHFIHAJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EA0", Offset = "0x8D40A0", VA = "0x1808D4EA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E70", Offset = "0x8D4070", VA = "0x1808D4E70", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<BMDJOHDFBDL, BMDJOHDFBDL> NMKJLEOPNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x2637820", Offset = "0x2636A20", VA = "0x182637820", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2636AE0", Offset = "0x2635CE0", VA = "0x182636AE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<BMDJOHDFBDL, BMDJOHDFBDL> JJCLCLKJGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x26364F0", Offset = "0x26356F0", VA = "0x1826364F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2636630", Offset = "0x2635830", VA = "0x182636630", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<BMDJOHDFBDL, BMDJOHDFBDL, BMDJOHDFBDL> KLFEIKOABPE
	{
		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x2637060", Offset = "0x2636260", VA = "0x182637060", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x26368E0", Offset = "0x2635AE0", VA = "0x1826368E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<BMDJOHDFBDL> IHMFBEHIIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x26355A0", Offset = "0x26347A0", VA = "0x1826355A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x2636590", Offset = "0x2635790", VA = "0x182636590", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000891")]
	[Cpp2IlInjected.Address(RVA = "0x2636980", Offset = "0x2635B80", VA = "0x182636980", Slot = "26")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000892")]
	[Cpp2IlInjected.Address(RVA = "0x2636B80", Offset = "0x2635D80", VA = "0x182636B80", Slot = "27")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000893")]
	[Cpp2IlInjected.Address(RVA = "0x2635990", Offset = "0x2634B90", VA = "0x182635990", Slot = "28")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000894")]
	[Cpp2IlInjected.Address(RVA = "0x26366D0", Offset = "0x26358D0", VA = "0x1826366D0")]
	private void HAODNENNCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x2636360", Offset = "0x2635560", VA = "0x182636360")]
	private void GKOMFPIJDGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x2637100", Offset = "0x2636300", VA = "0x182637100")]
	private void NJKJPLCKMGG(DNPJHPKBIAD JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x2635640", Offset = "0x2634840", VA = "0x182635640")]
	private void CKJCCNPCKGH(DNPJHPKBIAD JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x1803B60", Offset = "0x1802D60", VA = "0x181803B60", Slot = "14")]
	public Color GBKKILMJHEP(BMDJOHDFBDL JHJPAJMEGAG, int KGKCEFEHGDE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x2635760", Offset = "0x2634960", VA = "0x182635760", Slot = "15")]
	public float3 CLNIHBFJNMJ(BMDJOHDFBDL JHJPAJMEGAG, int KGKCEFEHGDE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0x2636730", Offset = "0x2635930", VA = "0x182636730", Slot = "16")]
	public bool IBCGFLHIBHD(BMDJOHDFBDL JHJPAJMEGAG, BMDJOHDFBDL EHOPIGAHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0x2635CD0", Offset = "0x2634ED0", VA = "0x182635CD0", Slot = "17")]
	public BMDJOHDFBDL EEOIOLEHPLN(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x2636100", Offset = "0x2635300", VA = "0x182636100", Slot = "20")]
	public void FJJEDFIKMJP(BMDJOHDFBDL JHJPAJMEGAG, Vector3 MIBJEBFEADH, Quaternion LPLCNLNEJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x2635FB0", Offset = "0x26351B0", VA = "0x182635FB0", Slot = "21")]
	public void EMHBCLPLOHJ(BMDJOHDFBDL JHJPAJMEGAG, float MELLDFCPCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x2636810", Offset = "0x2635A10", VA = "0x182636810", Slot = "24")]
	public float3 IKLBCHLJCAE(DHOAHHJIBFN AHLGFMHKKGF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x26362A0", Offset = "0x26354A0", VA = "0x1826362A0", Slot = "25")]
	public quaternion FNHCOICKBNE(DHOAHHJIBFN AHLGFMHKKGF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A0")]
	[Cpp2IlInjected.Address(RVA = "0x2635DD0", Offset = "0x2634FD0", VA = "0x182635DD0", Slot = "22")]
	public bool EHCFCCILFNP(BMDJOHDFBDL JHJPAJMEGAG, out RigidTransform JBACNHIBOEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A1")]
	[Cpp2IlInjected.Address(RVA = "0x2637410", Offset = "0x2636610", VA = "0x182637410", Slot = "23")]
	public bool OBDCNBJDBDF(BMDJOHDFBDL JHJPAJMEGAG, out float MELLDFCPCOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A2")]
	[Cpp2IlInjected.Address(RVA = "0x2636070", Offset = "0x2635270", VA = "0x182636070", Slot = "18")]
	[IteratorStateMachine(typeof(BAKHKKKDAEB))]
	public IEnumerable<BMDJOHDFBDL> FJDFEOBEIEA(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008A3")]
	[Cpp2IlInjected.Address(RVA = "0x26376A0", Offset = "0x26368A0", VA = "0x1826376A0", Slot = "19")]
	public BMDJOHDFBDL OJMDJGIMIDI(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0x2637590", Offset = "0x2636790", VA = "0x182637590")]
	private Entity OJMDJGIMIDI(Entity BLNICJMKCEF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0x2637990", Offset = "0x2636B90", VA = "0x182637990")]
	public DFOGBKNJFJJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : KNNEOPGGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		[NoAlias]
		[BurstCompile]
		private struct PreSerializeDowngrade_RRObjectPrefabTypeData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			[ReadOnly]
			public SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunksRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			[ReadOnly]
			public NativeParallelHashMap<int, int> prefabTypeFromIndexRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			public NGJGJFADPFD.DGNCLKPIMPD<ArchetypeChunk, NCKNJGBOLHK<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			public NativeList<NJKGKIMPNLN> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0x609AE60", Offset = "0x609A060", VA = "0x18609AE60")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0x609B120", Offset = "0x609A320", VA = "0x18609B120", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x2465450", Offset = "0x2464650", VA = "0x182465450", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x24654E0", Offset = "0x24646E0", VA = "0x1824654E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x2465090", Offset = "0x2464290", VA = "0x182465090")]
		private EntityCommandBufferSystem IMLBAKBFEOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x24650E0", Offset = "0x24642E0", VA = "0x1824650E0")]
		private JobHandle IPFMDMNJNME(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, NGJGJFADPFD.DGNCLKPIMPD<ArchetypeChunk, NCKNJGBOLHK<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<NJKGKIMPNLN> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x2465290", Offset = "0x2464490", VA = "0x182465290", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal struct PFJMGBBLOEJ : GBHJAOJCEHA, IEquatable<PFJMGBBLOEJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public int BBOMBIMAMPK
	{
		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int DGOHENJLBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x15BDC50", Offset = "0x15BCE50", VA = "0x1815BDC50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2454AF0", Offset = "0x2453CF0", VA = "0x182454AF0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(RVA = "0x2454AA0", Offset = "0x2453CA0", VA = "0x182454AA0", Slot = "8")]
	public bool Equals(PFJMGBBLOEJ JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0x2454B00", Offset = "0x2453D00", VA = "0x182454B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(AKFLDBGLGDA), new string[] { })]
internal sealed class AKFLDBGLGDA : DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	[MOHONECELPE]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	[MOHONECELPE]
	private CDNOCINFNBD LPKNINKGFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	[MOHONECELPE]
	private IECGGEGBNLL MNAMKCHNOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	[MOHONECELPE]
	private MHGCAFFKDBL CJBOPCIHIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	[MOHONECELPE]
	private LBGBICCEAMB MKADFFOHHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	[MOHONECELPE]
	private CPNCOLPGCPB LLKONLJFDNK;

	[Cpp2IlInjected.Token(Token = "0x60008C0")]
	[Cpp2IlInjected.Address(RVA = "0x26250A0", Offset = "0x26242A0", VA = "0x1826250A0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C1")]
	[Cpp2IlInjected.Address(RVA = "0x2624EB0", Offset = "0x26240B0", VA = "0x182624EB0")]
	public void IMHJGEENMOL(NativeArray<IANCKMHPHEB> MBFFOEIOABB, NativeArray<NACALKPEILN> FIPCNCFGHMC, NativeArray<Entity> DJNNIABCGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C2")]
	[Cpp2IlInjected.Address(RVA = "0x2625090", Offset = "0x2624290", VA = "0x182625090")]
	public Entity IMHJGEENMOL(IANCKMHPHEB GLKDKMADKLI, NACALKPEILN EPGIOGIKNGK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C3")]
	[Cpp2IlInjected.Address(RVA = "0x2624AA0", Offset = "0x2623CA0", VA = "0x182624AA0")]
	public Entity DDDBLPKECIO(IANCKMHPHEB GLKDKMADKLI, bool FHGCFHCOHHO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0x2624B30", Offset = "0x2623D30", VA = "0x182624B30")]
	public Entity DDDBLPKECIO(IANCKMHPHEB GLKDKMADKLI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x2624CD0", Offset = "0x2623ED0", VA = "0x182624CD0")]
	public Entity EMFECKAHCMJ()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x2624B40", Offset = "0x2623D40", VA = "0x182624B40")]
	public Entity DPKJFINENPM(EKGFPCGJLIK FBNKHAJKFLM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x26254C0", Offset = "0x26246C0", VA = "0x1826254C0")]
	public ILOOFJFGECE OGHNPGAIFHF(ILOOFJFGECE LIKELALOOEJ, Allocator KPFKDHLBOGB)
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C8")]
	[Cpp2IlInjected.Address(RVA = "0x2625190", Offset = "0x2624390", VA = "0x182625190")]
	public EntityArchetype JALBINOAAPO(IANCKMHPHEB GLKDKMADKLI)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0x26254A0", Offset = "0x26246A0", VA = "0x1826254A0")]
	public Entity MFJDPGPEFOM(IANCKMHPHEB GLKDKMADKLI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0x2625410", Offset = "0x2624610", VA = "0x182625410")]
	private Entity LAMDAIEMOEF(IANCKMHPHEB GLKDKMADKLI, bool FHGCFHCOHHO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x2625380", Offset = "0x2624580", VA = "0x182625380")]
	private Entity LAMDAIEMOEF(IANCKMHPHEB GLKDKMADKLI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x26251D0", Offset = "0x26243D0", VA = "0x1826251D0")]
	private Entity LAMDAIEMOEF(IANCKMHPHEB GLKDKMADKLI, NACALKPEILN EPGIOGIKNGK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CD")]
	[Cpp2IlInjected.Address(RVA = "0x2624B80", Offset = "0x2623D80", VA = "0x182624B80")]
	private void EGHNJMNHOEL(IANCKMHPHEB GLKDKMADKLI, NativeArray<NACALKPEILN> FIPCNCFGHMC, NativeArray<Entity> DJNNIABCGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x2624CE0", Offset = "0x2623EE0", VA = "0x182624CE0")]
	private void HFPIGANCDJB(NativeArray<IANCKMHPHEB> MBFFOEIOABB, NativeArray<NACALKPEILN> FIPCNCFGHMC, NativeArray<Entity> DJNNIABCGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public AKFLDBGLGDA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	[OLMIFJOAIBG]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : KNNEOPGGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x245DE00", Offset = "0x245D000", VA = "0x18245DE00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x245DE90", Offset = "0x245D090", VA = "0x18245DE90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x245DBF0", Offset = "0x245CDF0", VA = "0x18245DBF0")]
		private EntityCommandBufferSystem IMLBAKBFEOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x245DC40", Offset = "0x245CE40", VA = "0x18245DC40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[ExecuteAlways]
public class FJMAADPHJAA : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60008D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
	public FJMAADPHJAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[DDDGJOKMEDO(typeof(JGPGIDINFEG), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal class JGPGIDINFEG : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly SceneTag PNLCIEGAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	[MOHONECELPE]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	[MOHONECELPE]
	private KNKOHPGNOPB IHIGFPCIIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	[MOHONECELPE]
	private MGGGBEIHFIJ OJKDJMFOHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	[MOHONECELPE]
	private EFIGCPCEPCG AOHLHGPBOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	[MOHONECELPE]
	private JCKOIKCNGOK INGKHOMFELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	[MOHONECELPE]
	private ADMPGHOFGDK HCIBEJPOOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private EntityQuery BGAEONKIGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery AEDBKKAKJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private EntityQuery NPHGCGILJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private Entity ENPKBPCKEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public NativeArray<Entity> BIOCCGOKPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xA30B50", Offset = "0xA2FD50", VA = "0x180A30B50")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0xA2FA90", Offset = "0xA2EC90", VA = "0x180A2FA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Entity GOGGIOEKNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x25B5560", Offset = "0x25B4760", VA = "0x1825B5560")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public SceneTag IMKCKELFANA
	{
		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x25B5510", Offset = "0x25B4710", VA = "0x1825B5510")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Entity AEIPFIBBHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x25B5510", Offset = "0x25B4710", VA = "0x1825B5510")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x25B6940", Offset = "0x25B5B40", VA = "0x1825B6940")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x25B5470", Offset = "0x25B4670", VA = "0x1825B5470")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0x25B5CB0", Offset = "0x25B4EB0", VA = "0x1825B5CB0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0x25B5650", Offset = "0x25B4850", VA = "0x1825B5650", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0x25B5A80", Offset = "0x25B4C80", VA = "0x1825B5A80")]
	public void IIMJGOMAKFK(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E2")]
	[Cpp2IlInjected.Address(RVA = "0x25B5DB0", Offset = "0x25B4FB0", VA = "0x1825B5DB0")]
	public NativeArray<Entity> JLLDNBFKFHP(Allocator KPFKDHLBOGB = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E3")]
	[Cpp2IlInjected.Address(RVA = "0x25B54C0", Offset = "0x25B46C0", VA = "0x1825B54C0")]
	public void BHGPMONKHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0x25B5690", Offset = "0x25B4890", VA = "0x1825B5690")]
	public void EIEJLAELKHG(Entity IBENPLAEBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0x25B66F0", Offset = "0x25B58F0", VA = "0x1825B66F0")]
	public Entity NGMOJPHONCJ(string JPKENOAMLIN = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x25B5790", Offset = "0x25B4990", VA = "0x1825B5790")]
	public void EKEJNCEDMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0x25B66D0", Offset = "0x25B58D0", VA = "0x1825B66D0")]
	public void MICDJMGGKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public void IGIAJNHKAAD(Entity IBENPLAEBFE, string JPKENOAMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E9")]
	[Cpp2IlInjected.Address(RVA = "0x25B5BA0", Offset = "0x25B4DA0", VA = "0x1825B5BA0")]
	public void IJKPIFEJECK(Entity IBENPLAEBFE, bool EEIOLPDAOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EA")]
	[Cpp2IlInjected.Address(RVA = "0x25B5DE0", Offset = "0x25B4FE0", VA = "0x1825B5DE0")]
	public void KHPCAMIMCOD(Entity BLNICJMKCEF, Entity IBENPLAEBFE, bool EDIBEOOIDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EB")]
	[Cpp2IlInjected.Address(RVA = "0x25B5FD0", Offset = "0x25B51D0", VA = "0x1825B5FD0")]
	public void KHPCAMIMCOD(NativeArray<Entity> IBGFBPGPJKP, Entity IBENPLAEBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EC")]
	[Cpp2IlInjected.Address(RVA = "0x25B69B0", Offset = "0x25B5BB0", VA = "0x1825B69B0")]
	private void PFNCLCLNCNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0x25B59A0", Offset = "0x25B4BA0", VA = "0x1825B59A0")]
	private void FMHEDLBHHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0x25B5560", Offset = "0x25B4760", VA = "0x1825B5560")]
	private Entity FIPLADALMAA()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x25B6490", Offset = "0x25B5690", VA = "0x1825B6490")]
	private void KOKCFHMPGOJ(EntityQuery BFCPMGGLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0x25B61B0", Offset = "0x25B53B0", VA = "0x1825B61B0")]
	private void KOKCFHMPGOJ(NativeArray<Entity> FMLLOEFLKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F1")]
	[Cpp2IlInjected.Address(RVA = "0x25B59D0", Offset = "0x25B4BD0", VA = "0x1825B59D0")]
	private void HBGLEPAMDPA(Entity IBENPLAEBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0x25B5870", Offset = "0x25B4A70", VA = "0x1825B5870")]
	private void FKHFIGPDHDM(Entity IBENPLAEBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0x25B6560", Offset = "0x25B5760", VA = "0x1825B6560")]
	private void LDLMMNCPADP(SceneTag KODLKIANFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0x25B5430", Offset = "0x25B4630", VA = "0x1825B5430")]
	private void AGIHDMAFKMB(SceneTag KODLKIANFJC, NativeParallelHashSet<int> FHIFABFDGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x25B67A0", Offset = "0x25B59A0", VA = "0x1825B67A0")]
	private void NHJANHLHEBE(SceneTag KODLKIANFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x25B57B0", Offset = "0x25B49B0", VA = "0x1825B57B0")]
	private void EKKNIFODKLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x1B332D0", Offset = "0x1B324D0", VA = "0x181B332D0")]
	private void NLJIGGOKHJH<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public JGPGIDINFEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class GKDCCFLEDEJ : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private MGGGBEIHFIJ KMCFNHCIMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private BCLIKNODFFN HIONPLEGOME;

	[Cpp2IlInjected.Token(Token = "0x60008FA")]
	[Cpp2IlInjected.Address(RVA = "0x27D0320", Offset = "0x27CF520", VA = "0x1827D0320", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FB")]
	[Cpp2IlInjected.Address(RVA = "0x27D0390", Offset = "0x27CF590", VA = "0x1827D0390", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public GKDCCFLEDEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(MHGCAFFKDBL), new string[] { })]
internal sealed class MHGCAFFKDBL : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	[MOHONECELPE]
	private CDNOCINFNBD OILAPBOBIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	[MOHONECELPE]
	private IECGGEGBNLL DAJHHAAGFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private NativeParallelHashMap<NACALKPEILN, Entity> LHEBKODNOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	internal NativeParallelHashMap<NACALKPEILN, Entity> GLFJAFAANMH
	{
		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0xD0D200", Offset = "0xD0C400", VA = "0x180D0D200")]
		get
		{
			return default(NativeParallelHashMap<NACALKPEILN, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	internal uint MLLNBHEHEOI
	{
		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D2C0", Offset = "0x2A8C4C0", VA = "0x182A8D2C0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0xA4C070", Offset = "0xA4B270", VA = "0x180A4C070")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D140", Offset = "0x2A8C340", VA = "0x182A8D140", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000902")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CEF0", Offset = "0x2A8C0F0", VA = "0x182A8CEF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000903")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CF60", Offset = "0x2A8C160", VA = "0x182A8CF60")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000904")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CA60", Offset = "0x2A8BC60", VA = "0x182A8CA60")]
	public NACALKPEILN AHGKFLDFOCP(int BKHJHJOLNNF)
	{
		return default(NACALKPEILN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CD30", Offset = "0x2A8BF30", VA = "0x182A8CD30")]
	public void BKBLAFDFGCP(NACALKPEILN EPGIOGIKNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D2F0", Offset = "0x2A8C4F0", VA = "0x182A8D2F0")]
	public BMDJOHDFBDL NEEBBCDLDON(NACALKPEILN EPGIOGIKNGK)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CFE0", Offset = "0x2A8C1E0", VA = "0x182A8CFE0")]
	public bool IOELLMAPGAA(NACALKPEILN EPGIOGIKNGK, out BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D510", Offset = "0x2A8C710", VA = "0x182A8D510")]
	public ILOOFJFGECE NEEBBCDLDON(NativeArray<NACALKPEILN> EPGIOGIKNGK, Allocator KPFKDHLBOGB)
	{
		return default(ILOOFJFGECE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000909")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D670", Offset = "0x2A8C870", VA = "0x182A8D670")]
	public NACALKPEILN NHPDIBJHNEF(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(NACALKPEILN);
	}

	[Cpp2IlInjected.Token(Token = "0x600090A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D750", Offset = "0x2A8C950", VA = "0x182A8D750")]
	public NACALKPEILN NHPDIBJHNEF(Entity BLNICJMKCEF)
	{
		return default(NACALKPEILN);
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8CB50", Offset = "0x2A8BD50", VA = "0x182A8CB50")]
	public void APEHANMCMKA(NativeArray<Entity> IBGFBPGPJKP, NativeArray<NACALKPEILN> FIPCNCFGHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D270", Offset = "0x2A8C470", VA = "0x182A8D270")]
	private BMDJOHDFBDL KCHCNGIHGOL(Entity BLNICJMKCEF)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MHGCAFFKDBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(JCKOIKCNGOK), new string[] { })]
internal sealed class JCKOIKCNGOK : DCLDDNDKGBL, PJIPLCPBFIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	[MOHONECELPE]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	[MOHONECELPE]
	private EFIGCPCEPCG AOHLHGPBOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private Entity BLNICJMKCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	private ComponentTypeList KJOIBOGAONC;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x25B3A90", Offset = "0x25B2C90", VA = "0x1825B3A90")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000910")]
	[Cpp2IlInjected.Address(RVA = "0x1B316E0", Offset = "0x1B308E0", VA = "0x181B316E0")]
	public T MCKGCJAFOEM<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000911")]
	[Cpp2IlInjected.Address(RVA = "0x1B313E0", Offset = "0x1B305E0", VA = "0x181B313E0")]
	public void BNDJKAKDCIM<T>(T NABCGCEIEGG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000912")]
	[Cpp2IlInjected.Address(RVA = "0x1B314B0", Offset = "0x1B306B0", VA = "0x181B314B0")]
	public DynamicBuffer<T> HCIFFGAEAEL<T>(bool JMPIAKIDPLJ = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000913")]
	[Cpp2IlInjected.Address(RVA = "0x1B315B0", Offset = "0x1B307B0", VA = "0x181B315B0")]
	public void HEDCECNDJPA<T>(T NABCGCEIEGG) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000914")]
	[Cpp2IlInjected.Address(RVA = "0x25B43D0", Offset = "0x25B35D0", VA = "0x1825B43D0", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000915")]
	[Cpp2IlInjected.Address(RVA = "0x25B3AE0", Offset = "0x25B2CE0", VA = "0x1825B3AE0", Slot = "5")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000916")]
	[Cpp2IlInjected.Address(RVA = "0x25B3AE0", Offset = "0x25B2CE0", VA = "0x1825B3AE0")]
	private void BDBGCEDDGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000917")]
	[Cpp2IlInjected.Address(RVA = "0x25B3D80", Offset = "0x25B2F80", VA = "0x1825B3D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000918")]
	[Cpp2IlInjected.Address(RVA = "0x25B4030", Offset = "0x25B3230", VA = "0x1825B4030")]
	private ComponentTypeList EFCIJDHCBKM()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x6000919")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void CMMPLFELNHD(int BKHJHJOLNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091A")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void BNPLBIHOGDF(Type FBNKHAJKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091B")]
	[Cpp2IlInjected.Address(RVA = "0x25B3C80", Offset = "0x25B2E80", VA = "0x1825B3C80")]
	private static void BOJGMLHKNNM(Type FBNKHAJKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public JCKOIKCNGOK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000174")]
[HKHGONOPDJJ]
internal struct PPOGIGEIOEC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class FNGBOFFOLDB : KNNEOPGGIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private EntityQuery DMBNBHMPHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private EntityQuery BHNPOIAOCDH;

	[Cpp2IlInjected.Token(Token = "0x600091E")]
	[Cpp2IlInjected.Address(RVA = "0x27CA5C0", Offset = "0x27C97C0", VA = "0x1827CA5C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091F")]
	[Cpp2IlInjected.Address(RVA = "0x27CA6B0", Offset = "0x27C98B0", VA = "0x1827CA6B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000920")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public FNGBOFFOLDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[JBFEHGAKKCF]
public class GPAAFCAGNDL : KNNEOPGGIBD, KHDDPCDLICB.MKMILBFMLLC
{
	[Cpp2IlInjected.Token(Token = "0x6000921")]
	[Cpp2IlInjected.Address(RVA = "0x27D1F20", Offset = "0x27D1120", VA = "0x1827D1F20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000922")]
	[Cpp2IlInjected.Address(RVA = "0x27D1ED0", Offset = "0x27D10D0", VA = "0x1827D1ED0")]
	private EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000923")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public GPAAFCAGNDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[AlwaysUpdateSystem]
public class IMHEJHMCEPI : KFPLABIADMD
{
	[Cpp2IlInjected.Token(Token = "0x6000924")]
	[Cpp2IlInjected.Address(RVA = "0x25B1F90", Offset = "0x25B1190", VA = "0x1825B1F90", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x8C2A40", Offset = "0x8C1C40", VA = "0x1808C2A40")]
	public IMHEJHMCEPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[DDDGJOKMEDO(typeof(BCLIKNODFFN), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal class BCLIKNODFFN : DCLDDNDKGBL, PJIPLCPBFIL, FFJELJCPNLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	internal readonly struct IKJFGJOKBLA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private readonly LCOECJPMODN DFPBBKAFGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private readonly BCLIKNODFFN INBMBKDICBE;

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x2220EF0", Offset = "0x22200F0", VA = "0x182220EF0")]
		public IKJFGJOKBLA(BCLIKNODFFN INBMBKDICBE, LCOECJPMODN KOLMADEBKMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2220ED0", Offset = "0x22200D0", VA = "0x182220ED0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private static readonly PEKDFCFCENH LEEOHGFKMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	[MOHONECELPE]
	private LFBNOCAADDA EFGGIEHCPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	[MOHONECELPE]
	private LBGBICCEAMB MKADFFOHHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly FEJOJNGLNGN[] AHMHJEDCGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private KDJINJGKOPM EJNOCFMJPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private NativeParallelHashMap<int, Entity> FHGAPCLFNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private LCOECJPMODN LENIFIBFEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public World OFIFOCNNODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2627300", Offset = "0x2626500", VA = "0x182627300", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public World EPJHBKFCPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x999860", Offset = "0x998A60", VA = "0x180999860", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD00", Offset = "0x9ACF00", VA = "0x1809ADD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public KDJINJGKOPM JKCNGOBBILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2627560", Offset = "0x2626760", VA = "0x182627560", Slot = "8")]
		get
		{
			return default(KDJINJGKOPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public uint LDIKCCIHMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x16C81A0", Offset = "0x16C73A0", VA = "0x1816C81A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x8C9F20", Offset = "0x8C9120", VA = "0x1808C9F20", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool GHONKJPACED
	{
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x16C8720", Offset = "0x16C7920", VA = "0x1816C8720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x13D1C80", Offset = "0x13D0E80", VA = "0x1813D1C80", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public NativeParallelHashMap<int, Entity> MKFACEMFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x158F540", Offset = "0x158E740", VA = "0x18158F540")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public JMFALELBNFD LDNONLHCDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x26272C0", Offset = "0x26264C0", VA = "0x1826272C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public DCIJLGIBKEE LMBOBNKEJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x26272C0", Offset = "0x26264C0", VA = "0x1826272C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public LCOECJPMODN PMDOGKABEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x992100", Offset = "0x991300", VA = "0x180992100")]
		get
		{
			return default(LCOECJPMODN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600092F")]
	[Cpp2IlInjected.Address(RVA = "0x2627160", Offset = "0x2626360", VA = "0x182627160")]
	public JMFALELBNFD DPEBPPEJHCM(LCOECJPMODN DLHBAJIIOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000930")]
	[Cpp2IlInjected.Address(RVA = "0x2627160", Offset = "0x2626360", VA = "0x182627160")]
	public DCIJLGIBKEE EENPLGMPAGJ(LCOECJPMODN DLHBAJIIOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000934")]
	[Cpp2IlInjected.Address(RVA = "0x2627490", Offset = "0x2626690", VA = "0x182627490", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000935")]
	[Cpp2IlInjected.Address(RVA = "0x2627590", Offset = "0x2626790", VA = "0x182627590", Slot = "5")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000936")]
	[Cpp2IlInjected.Address(RVA = "0x2627780", Offset = "0x2626980", VA = "0x182627780")]
	private NativeParallelHashMap<int, Entity> OOFAFACEJGP()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x2627730", Offset = "0x2626930", VA = "0x182627730")]
	public void NPECAOIKLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x2627350", Offset = "0x2626550", VA = "0x182627350")]
	public void HNOBOGMOMNO(LCOECJPMODN DLHBAJIIOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x26273A0", Offset = "0x26265A0", VA = "0x1826273A0")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x26271A0", Offset = "0x26263A0", VA = "0x1826271A0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x2627470", Offset = "0x2626670", VA = "0x182627470")]
	public IKJFGJOKBLA IBEBGJHFBFF(LCOECJPMODN DLHBAJIIOKJ)
	{
		return default(IKJFGJOKBLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x2627AA0", Offset = "0x2626CA0", VA = "0x182627AA0")]
	public BCLIKNODFFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class APHJAHFKLMH : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private EntityQuery DAEMAAPCIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private CPECIHFFCAK AEILOOJABFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private CFHHLPHHLOO CKCMCCKOKEH;

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x26258F0", Offset = "0x2624AF0", VA = "0x1826258F0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x2625980", Offset = "0x2624B80", VA = "0x182625980", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x25B4800", Offset = "0x25B3A00", VA = "0x1825B4800", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public APHJAHFKLMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[OLMIFJOAIBG]
public class KCAFPPBAGDM : AFFEALIJNOO
{
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x25B93A0", Offset = "0x25B85A0", VA = "0x1825B93A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x25B9450", Offset = "0x25B8650", VA = "0x1825B9450", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x25B9350", Offset = "0x25B8550", VA = "0x1825B9350")]
	private EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public KCAFPPBAGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
public class FNOFBJDMCAJ : AFFEALIJNOO
{
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x27CA7A0", Offset = "0x27C99A0", VA = "0x1827CA7A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x27CA750", Offset = "0x27C9950", VA = "0x1827CA750")]
	private EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public FNOFBJDMCAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public struct NIPJAIIGFCG<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private GCHandle EMCKGOPIABN;

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D700", Offset = "0x2C9C900", VA = "0x182C9D700", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[JBFEHGAKKCF]
public class DFHADHHFLHJ : KNNEOPGGIBD, KHDDPCDLICB.MKMILBFMLLC
{
	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x2635460", Offset = "0x2634660", VA = "0x182635460", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x2635410", Offset = "0x2634610", VA = "0x182635410")]
	private EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public DFHADHHFLHJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIds : KNNEOPGGIBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x2466180", Offset = "0x2465380", VA = "0x182466180", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x2466210", Offset = "0x2465410", VA = "0x182466210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x2465F70", Offset = "0x2465170", VA = "0x182465F70")]
		private EntityCommandBufferSystem BELMJICDGGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x2465FC0", Offset = "0x24651C0", VA = "0x182465FC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PreSerializeSaveNetworkIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[AlwaysUpdateSystem]
public class OCFODPBMPJE : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AD60", Offset = "0x2A99F60", VA = "0x182A9AD60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public OCFODPBMPJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[OLMIFJOAIBG]
[AKEFOBLNEPL(CCDGJKNFPNB.OMRoom)]
public class OCEFHJBBGFC : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private FOEBEFHCPPN BKHAEGCLDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private JGPGIDINFEG FMLLOEFLKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A910", Offset = "0x2A99B10", VA = "0x182A9A910", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A980", Offset = "0x2A99B80", VA = "0x182A9A980", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x2A9AA20", Offset = "0x2A99C20", VA = "0x182A9AA20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public OCEFHJBBGFC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	internal class SplinePointOrderingUpdateSystem : KNNEOPGGIBD, DCLDDNDKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000184")]
		[BurstCompile]
		private struct UpdateSplineIndexJob : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			[ReadOnly]
			public NativeArray<global::LPHFGDMHOBO> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			[ReadOnly]
			public ComponentDataFromEntity<GAAIHPAGNAD> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			public ComponentDataFromEntity<GACBCEKGGOB> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x600096A")]
			[Cpp2IlInjected.Address(RVA = "0x609FA40", Offset = "0x609EC40", VA = "0x18609FA40", Slot = "4")]
			public void Execute(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000185")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			[ReadOnly]
			public ComponentDataFromEntity<GACBCEKGGOB> orderRO;

			[Cpp2IlInjected.Token(Token = "0x600096B")]
			[Cpp2IlInjected.Address(RVA = "0x6099FD0", Offset = "0x60991D0", VA = "0x186099FD0", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		[NoAlias]
		private struct SplinePointOrderingUpdateSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x609E600", Offset = "0x609D800", VA = "0x18609E600")]
			private void CHEGCCDBFJM(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0x609E690", Offset = "0x609D890", VA = "0x18609E690", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[MOHONECELPE]
		private JCKOIKCNGOK singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x24687D0", Offset = "0x24679D0", VA = "0x1824687D0", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x2468BD0", Offset = "0x2467DD0", VA = "0x182468BD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x2468300", Offset = "0x2467500", VA = "0x182468300")]
		private void ADNGEIIEODK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x2468820", Offset = "0x2467A20", VA = "0x182468820")]
		private void KPIFKHLDFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x2468D30", Offset = "0x2467F30", VA = "0x182468D30")]
		private static HNPMAFNAGGH POMOBGDCDBM(int insertionIndex, ComponentDataFromEntity<GACBCEKGGOB> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(HNPMAFNAGGH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x2468690", Offset = "0x2467890", VA = "0x182468690")]
		private JobHandle IKONBFIAIGA(OrderComparer comparer, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x2468980", Offset = "0x2467B80", VA = "0x182468980", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	public class UpdateMassOfShapes : KNNEOPGGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		[NoAlias]
		private struct UpdateMassOfShapes_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			[ReadOnly]
			public ComponentDataFromEntity<EPFNMOOOKJI> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			[ReadOnly]
			public ComponentDataFromEntity<LLPDNIBHICC> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			[ReadOnly]
			public ComponentDataFromEntity<EDICBKLMJAO> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			[ReadOnly]
			public ComponentDataFromEntity<FIMBLCDCKDG> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			[ReadOnly]
			public ComponentDataFromEntity<BOHGFEOLDLP> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			public ComponentDataFromEntity<GJMKIKKIJMF> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			public ComponentDataFromEntity<NPAEBGIHHKC> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0x609F4A0", Offset = "0x609E6A0", VA = "0x18609F4A0")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x609F900", Offset = "0x609EB00", VA = "0x18609F900", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x2470230", Offset = "0x246F430", VA = "0x182470230", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x2470360", Offset = "0x246F560", VA = "0x182470360", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x246FF20", Offset = "0x246F120", VA = "0x18246FF20")]
		private void HMDABMEHLKD(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x246FD40", Offset = "0x246EF40", VA = "0x18246FD40")]
		private JobHandle ANGGOBKPGNK(NativeList<Entity> entities, ComponentDataFromEntity<EPFNMOOOKJI> worldDeformableScalesRO, ComponentDataFromEntity<LLPDNIBHICC> worldUniformScalesRO, ComponentDataFromEntity<EDICBKLMJAO> physicsMaterialsRO, ComponentDataFromEntity<FIMBLCDCKDG> primitiveShapesRO, ComponentDataFromEntity<BOHGFEOLDLP> localUniformScalesRO, ComponentDataFromEntity<GJMKIKKIJMF> massesRW, ComponentDataFromEntity<NPAEBGIHHKC> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public UpdateMassOfShapes()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal struct JAEAEIHFMNB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public class DNKGJOFFMAM : HBIAMONPJOO
{
	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x27B96A0", Offset = "0x27B88A0", VA = "0x1827B96A0", Slot = "14")]
	protected override EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public DNKGJOFFMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class LGMAEBIBJBI : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private JHLOBONCNLI CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private EntityQuery MDANIAMGCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private EntityQuery AFNLGFCFBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private EntityQuery KBODDKLBACF;

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x2A816C0", Offset = "0x2A808C0", VA = "0x182A816C0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x2A81A30", Offset = "0x2A80C30", VA = "0x182A81A30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x2A81BB0", Offset = "0x2A80DB0", VA = "0x182A81BB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x2A81B80", Offset = "0x2A80D80", VA = "0x182A81B80", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x2A811D0", Offset = "0x2A803D0", VA = "0x182A811D0")]
	private void FMJGDPNONJD(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x2A81510", Offset = "0x2A80710", VA = "0x182A81510")]
	private void IONAHNGCLBM(NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x2A80ED0", Offset = "0x2A800D0", VA = "0x182A80ED0")]
	private void FEMLOHFCMBK(NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x2A81730", Offset = "0x2A80930", VA = "0x182A81730")]
	private void NCDCDFBPCDB(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x2A80CC0", Offset = "0x2A7FEC0", VA = "0x182A80CC0")]
	private void EIKOEOPCGOF(NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x2A818F0", Offset = "0x2A80AF0", VA = "0x182A818F0")]
	private void NJOBDODMGCJ(BMDJOHDFBDL JHJPAJMEGAG, int MIOMNEOFMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public LGMAEBIBJBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[FBPICDCAGAD(typeof(COAPHLBOHFB))]
[DDDGJOKMEDO(typeof(IMCMCGKOBCF), new string[] { })]
public class AGDONHJPCAI : IMCMCGKOBCF, PNKPNDDLHPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private static readonly Dictionary<int, int> OCFDBLJAJMA;

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x2620E10", Offset = "0x2620010", VA = "0x182620E10", Slot = "5")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x2620D70", Offset = "0x261FF70", VA = "0x182620D70", Slot = "4")]
	public int HFLLCEAHCAL(int CNBPDHPGPFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x2620CF0", Offset = "0x261FEF0", VA = "0x182620CF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public AGDONHJPCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[DDDGJOKMEDO(typeof(DBIJIJBKMMK), new string[] { })]
public class CIDNCEBPICK : DCLDDNDKGBL, PJIPLCPBFIL, DBIJIJBKMMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private sealed class GDFMKFPBEAF : IEnumerable<BMDJOHDFBDL>, IEnumerable, IEnumerator<BMDJOHDFBDL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private BMDJOHDFBDL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private BMDJOHDFBDL splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public BMDJOHDFBDL <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public CIDNCEBPICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private NativeArray<Entity> <children>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		private BMDJOHDFBDL System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600099F")]
			[Cpp2IlInjected.Address(RVA = "0x2216870", Offset = "0x2215A70", VA = "0x182216870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(BMDJOHDFBDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60009A1")]
			[Cpp2IlInjected.Address(RVA = "0x221F2C0", Offset = "0x221E4C0", VA = "0x18221F2C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0xA122A0", Offset = "0xA114A0", VA = "0x180A122A0")]
		[DebuggerHidden]
		public GDFMKFPBEAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x221F0E0", Offset = "0x221E2E0", VA = "0x18221F0E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x221F280", Offset = "0x221E480", VA = "0x18221F280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x221F1D0", Offset = "0x221E3D0", VA = "0x18221F1D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BMDJOHDFBDL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x221F1D0", Offset = "0x221E3D0", VA = "0x18221F1D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private LFBNOCAADDA EFGGIEHCPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private AKFLDBGLGDA MKADFFOHHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private BEEILEEPNEP BNMBMDEENEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private JCKOIKCNGOK JMKJGIHBADE;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x262B370", Offset = "0x262A570", VA = "0x18262B370")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x262C120", Offset = "0x262B320", VA = "0x18262C120", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x262C0A0", Offset = "0x262B2A0", VA = "0x18262C0A0")]
	private void IILPDMDFINP(Entity DHGONMBIOKE, int NNAODBDJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x262BAD0", Offset = "0x262ACD0", VA = "0x18262BAD0", Slot = "10")]
	public void GIJOKBMLGHJ(BMDJOHDFBDL JHJPAJMEGAG, MGOHIBGGGFF HPANENBGKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x262C410", Offset = "0x262B610", VA = "0x18262C410", Slot = "9")]
	public MGOHIBGGGFF ODFEEHOPACB(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(MGOHIBGGGFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x262B8C0", Offset = "0x262AAC0", VA = "0x18262B8C0", Slot = "11")]
	public BMDJOHDFBDL FAAKGEHJAGC(BMDJOHDFBDL KFBDMIOBMLG, [Optional] float3? BOEKENJNLKP, [Optional] quaternion? ELGEECMLAMI, [Optional] float3? KIJNMGBKNIP)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x262BBB0", Offset = "0x262ADB0", VA = "0x18262BBB0", Slot = "12")]
	public BMDJOHDFBDL HIHKFLKFCLP(BMDJOHDFBDL KFBDMIOBMLG, int NNAODBDJDNJ, [Optional] float3? BOEKENJNLKP, [Optional] quaternion? ELGEECMLAMI, [Optional] float3? KIJNMGBKNIP)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x262B520", Offset = "0x262A720", VA = "0x18262B520")]
	private BMDJOHDFBDL CIPKKGGLFEK(BMDJOHDFBDL KFBDMIOBMLG, int NNAODBDJDNJ, [Optional] float3? BOEKENJNLKP, [Optional] quaternion? ELGEECMLAMI, [Optional] float3? KIJNMGBKNIP)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x262B3C0", Offset = "0x262A5C0", VA = "0x18262B3C0", Slot = "7")]
	public BMDJOHDFBDL CAMCIOPGOPO(BMDJOHDFBDL KFBDMIOBMLG, int NNAODBDJDNJ)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x262BA00", Offset = "0x262AC00", VA = "0x18262BA00", Slot = "16")]
	public void FFOALJIIDEK(BMDJOHDFBDL KFBDMIOBMLG, BMDJOHDFBDL DHGONMBIOKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0x262C210", Offset = "0x262B410", VA = "0x18262C210", Slot = "13")]
	public void JEOBJJBAAOD(BMDJOHDFBDL KFBDMIOBMLG, int NNAODBDJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000997")]
	[Cpp2IlInjected.Address(RVA = "0x262BC60", Offset = "0x262AE60", VA = "0x18262BC60", Slot = "14")]
	public void IBAHCEONIEP(BMDJOHDFBDL KFBDMIOBMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0x262B7E0", Offset = "0x262A9E0", VA = "0x18262B7E0", Slot = "8")]
	public int COIMGBHJOOI(BMDJOHDFBDL KFBDMIOBMLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0x262B970", Offset = "0x262AB70", VA = "0x18262B970", Slot = "6")]
	[IteratorStateMachine(typeof(GDFMKFPBEAF))]
	public IEnumerable<BMDJOHDFBDL> FEODAKODAKJ(BMDJOHDFBDL KFBDMIOBMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600099A")]
	[Cpp2IlInjected.Address(RVA = "0x262BFC0", Offset = "0x262B1C0", VA = "0x18262BFC0")]
	private bool ICPFENFDMIG(BMDJOHDFBDL KFBDMIOBMLG, out NativeArray<Entity> KNNJOFGDFGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public CIDNCEBPICK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[AlwaysUpdateSystem]
public class POMEOPLHGHO : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x245C1C0", Offset = "0x245B3C0", VA = "0x18245C1C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public POMEOPLHGHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
internal class INHCPGAEGMD : NEOFDAGELGL
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	public struct GPLIBCDFOFF : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	protected override ComponentType AGMPKCPBLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x25B2020", Offset = "0x25B1220", VA = "0x1825B2020", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	protected override ComponentType IADFPMAIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x25B1FF0", Offset = "0x25B11F0", VA = "0x1825B1FF0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	protected override ComponentType PNDMHBPIHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x25B2050", Offset = "0x25B1250", VA = "0x1825B2050", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x25B2110", Offset = "0x25B1310", VA = "0x1825B2110")]
	public INHCPGAEGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class JEEINGJFALL : KNNEOPGGIBD, PJIPLCPBFIL
{
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private CJCFNJEIKLC BOBEKOFDFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private MODEADMIGAP EKPKHDPLAGE;

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x25B4800", Offset = "0x25B3A00", VA = "0x1825B4800", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x25B46F0", Offset = "0x25B38F0", VA = "0x1825B46F0", Slot = "14")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x25B4810", Offset = "0x25B3A10", VA = "0x1825B4810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x25B4570", Offset = "0x25B3770", VA = "0x1825B4570")]
	private static void KLKNMMIMAJJ(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, Entity OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0x25B44D0", Offset = "0x25B36D0", VA = "0x1825B44D0")]
	private static bool ELAJOLEBEAL(EntityManager NMHMIPEFENM, Entity BLNICJMKCEF, out Transform LNNHFELGMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public JEEINGJFALL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
public struct NLFEFIAHPPB<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private OCIPEIPIJCB<T> KBIJDJHCEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private EntityCommandBuffer HEDKIIMNAJF;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public OCIPEIPIJCB<T> FEBNBICEEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x15BDA90", Offset = "0x15BCC90", VA = "0x1815BDA90")]
		get
		{
			return default(OCIPEIPIJCB<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x15C4710", Offset = "0x15C3910", VA = "0x1815C4710")]
	public NLFEFIAHPPB(OCIPEIPIJCB<T> KBIJDJHCEBH, EntityCommandBuffer HEDKIIMNAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x2D622B0", Offset = "0x2D614B0", VA = "0x182D622B0")]
	public void POKIFDGIAEP(NMBGDHMMLIG<T> DFKLHLFIGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D61DB0", Offset = "0x2D60FB0", VA = "0x182D61DB0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x15C46F0", Offset = "0x15C38F0", VA = "0x1815C46F0")]
	public static OCIPEIPIJCB<T> OMHOCPNBHHH(NLFEFIAHPPB<T> DGJKEMKCNIO)
	{
		return default(OCIPEIPIJCB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public class DHOMGICDHJI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public BGNCONALOOG OJKDJMFOHNB;

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public DHOMGICDHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	public DHOMGICDHJI(BGNCONALOOG OJKDJMFOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0x2638800", Offset = "0x2637A00", VA = "0x182638800", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[JBFEHGAKKCF]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : PELLODHLJDK
	{
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			public OCIJEOIMNEM<NOCIMDECKCD> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public OCNKOMDFBIA<LCAGEBOGKAB> v1;

			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x22276B0", Offset = "0x22268B0", VA = "0x1822276B0")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x2227910", Offset = "0x2226B10", VA = "0x182227910", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		protected override PEKDFCFCENH Log
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x2461720", Offset = "0x2460920", VA = "0x182461720", Slot = "14")]
			get
			{
				return default(PEKDFCFCENH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x24618B0", Offset = "0x2460AB0", VA = "0x1824618B0", Slot = "15")]
		public override IEnumerable<KHDDPCDLICB.OBJAMBDMJFG> MCKNKLJMKML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x24615B0", Offset = "0x24607B0", VA = "0x1824615B0", Slot = "16")]
		protected override void CBOEHLOFBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2461780", Offset = "0x2460980", VA = "0x182461780")]
		private JobHandle GPLNJDLPJPA(OCIJEOIMNEM<NOCIMDECKCD> v0, OCNKOMDFBIA<LCAGEBOGKAB> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x24604A0", Offset = "0x245F6A0", VA = "0x1824604A0")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
[AlwaysUpdateSystem]
internal class MOLPLDHODPK : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public MOLPLDHODPK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentData : AFFEALIJNOO, DCLDDNDKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private struct DebugPostLoadValidateParentData_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public DebugPostLoadValidateParentData __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			[ReadOnly]
			public ComponentTypeHandle<BGFGOLHGEPN> __parentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0x221C1B0", Offset = "0x221B3B0", VA = "0x18221C1B0")]
			private void CHEGCCDBFJM(Entity entity, in BGFGOLHGEPN parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0x221C410", Offset = "0x221B610", VA = "0x18221C410", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private JPLJDCFLDIF objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private EntityQuery DebugPostLoadValidateParentData_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private ComponentTypeHandle<BGFGOLHGEPN> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x27BB650", Offset = "0x27BA850", VA = "0x1827BB650", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x27BB570", Offset = "0x27BA770", VA = "0x1827BB570", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x27BB570", Offset = "0x27BA770", VA = "0x1827BB570")]
		private void HGLMNAHENKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x27BB900", Offset = "0x27BAB00", VA = "0x1827BB900", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public DebugPostLoadValidateParentData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x27BB6B0", Offset = "0x27BA8B0", VA = "0x1827BB6B0")]
		[CompilerGenerated]
		private void MPPKHHMCBOD(Entity entity, in BGFGOLHGEPN parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class ENKOIPDCLAK : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private object EJMFJEDFPHK;

	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x27BFED0", Offset = "0x27BF0D0", VA = "0x1827BFED0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x27BFF50", Offset = "0x27BF150", VA = "0x1827BFF50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x27BFFF0", Offset = "0x27BF1F0", VA = "0x1827BFFF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public ENKOIPDCLAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
[BurstCompatible]
internal readonly struct OEHOGGOLNLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private readonly MHKJKOAIFPO DEJDKAPODIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private readonly BHPCOGAHMLN IBNAGLHFLOO;

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5C50", VA = "0x1808B6A50")]
	public OEHOGGOLNLF(MHKJKOAIFPO DEJDKAPODIK, BHPCOGAHMLN IBNAGLHFLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x28C68F0", Offset = "0x28C5AF0", VA = "0x1828C68F0")]
	public bool DKGELKDALOG(OEHOGGOLNLF OJEMCPHOKBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x28C68F0", Offset = "0x28C5AF0", VA = "0x1828C68F0")]
	public bool DNAMPIFONKP(OEHOGGOLNLF PPANDIPJOLP)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	public class CalculateContainerCollisionIslandGraphChangesSystem : KNNEOPGGIBD, DCLDDNDKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		[BurstCompile]
		private struct FindChangedIslandsJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			[ReadOnly]
			public EntityQueryInJob deletedConnectablesQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			[ReadOnly]
			public EntityQueryInJob changedIslandQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			[ReadOnly]
			public EntityQueryInJob hierarchyChangeQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			[ReadOnly]
			public EntityQueryInJob newRootsQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			[ReadOnly]
			public ChunkFilterAnyOf2ComponentsChanged islandSplitChangeFilterRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			[ReadOnly]
			public ComponentTypeHandle<OLADFJFFPGB> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			[ReadOnly]
			public ComponentDataFromEntity<HLIALJLAJPE> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			[ReadOnly]
			public ComponentDataFromEntity<MHKJKOAIFPO> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			[ReadOnly]
			public ComponentDataFromEntity<BHPCOGAHMLN> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			[ReadOnly]
			public ComponentDataFromEntity<MINHJFKAHHL> containerCollisionIslandRootTagRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			[ReadOnly]
			public ComponentDataFromEntity<BGFGOLHGEPN> parentRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			[ReadOnly]
			public BufferFromEntity<JFFGLDLIPLN> childrenRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			[WriteOnly]
			public NativeList<Entity> changedIslandComponentsBufferWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			[WriteOnly]
			public NativeList<ACLBMNIEIDO> changedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			[WriteOnly]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			[WriteOnly]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public ComponentDataFromEntity<AKFBEAGBHPP> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x60009DC")]
			[Cpp2IlInjected.Address(RVA = "0x221E500", Offset = "0x221D700", VA = "0x18221E500", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0x221EE80", Offset = "0x221E080", VA = "0x18221EE80")]
			private void KLCKGPMLMOD(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009DE")]
			[Cpp2IlInjected.Address(RVA = "0x221E480", Offset = "0x221D680", VA = "0x18221E480")]
			private Entity DOGNPGKDDDL(Entity curEntity, OEHOGGOLNLF classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60009DF")]
			[Cpp2IlInjected.Address(RVA = "0x221ECE0", Offset = "0x221DEE0", VA = "0x18221ECE0")]
			private bool IDBBJCBILJI(Entity curEntity, OEHOGGOLNLF classifier, out Entity parentEntity, out OEHOGGOLNLF parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009E0")]
			[Cpp2IlInjected.Address(RVA = "0x221EDB0", Offset = "0x221DFB0", VA = "0x18221EDB0")]
			private void INMOIEFLGOE(Entity islandRoot, OEHOGGOLNLF classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009E1")]
			[Cpp2IlInjected.Address(RVA = "0x221E280", Offset = "0x221D480", VA = "0x18221E280")]
			private void DJMJHBPEKDH(Entity islandRoot, Entity entity, OEHOGGOLNLF classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009E2")]
			[Cpp2IlInjected.Address(RVA = "0x221EB70", Offset = "0x221DD70", VA = "0x18221EB70")]
			private void HIJCHNIGDAG(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009E3")]
			[Cpp2IlInjected.Address(RVA = "0x221EC50", Offset = "0x221DE50", VA = "0x18221EC50")]
			private bool HJOLIFCJIHN(Entity entity, out OEHOGGOLNLF classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009E4")]
			[Cpp2IlInjected.Address(RVA = "0x221F040", Offset = "0x221E240", VA = "0x18221F040")]
			private OEHOGGOLNLF NBLONGFOOFA(Entity entity)
			{
				return default(OEHOGGOLNLF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200019E")]
		[NoAlias]
		[BurstCompile]
		private struct CalculateContainerCollisionIslandGraphChangesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			[ReadOnly]
			public EntityTypeHandle entityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0x221B0C0", Offset = "0x221A2C0", VA = "0x18221B0C0")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009E6")]
			[Cpp2IlInjected.Address(RVA = "0x221B1B0", Offset = "0x221A3B0", VA = "0x18221B1B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[MOHONECELPE]
		private PMDPEMDAEAF collisionIslandService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private EntityQuery changedIslandStructureQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private EntityQuery hierarchyChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private EntityQuery newRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private EntityQuery deletedConnectablesQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery deletedRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery islandRootDataQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery islandRootTagQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private PMJDKHDHGJC ecbs;

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x26340B0", Offset = "0x26332B0", VA = "0x1826340B0", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0x2634960", Offset = "0x2633B60", VA = "0x182634960", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x2634D70", Offset = "0x2633F70", VA = "0x182634D70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x2634200", Offset = "0x2633400", VA = "0x182634200")]
		private JobHandle OFPMMOIEIGD(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0x2633DF0", Offset = "0x2632FF0", VA = "0x182633DF0")]
		private JobHandle DHLBODNJNBD(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x2634100", Offset = "0x2633300", VA = "0x182634100")]
		private JobHandle NCJIJFCBHIP(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[OLMIFJOAIBG]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class DMGLMIPEJMD : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> GCFFELKNDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DCFNOBJDABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> PHJDIILHEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private DKFFIBCBDBB ANFEMFHHJAL;

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x27B85E0", Offset = "0x27B77E0", VA = "0x1827B85E0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0x27B8A00", Offset = "0x27B7C00", VA = "0x1827B8A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0x27B9280", Offset = "0x27B8480", VA = "0x1827B9280")]
	private void PNIMIFOBKPA(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MLEOGHHEJOI, EntityQueryDesc FEDKNLJALCB, bool JPHDKFDHOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0x27B9140", Offset = "0x27B8340", VA = "0x1827B9140")]
	private void PNIMIFOBKPA(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MLEOGHHEJOI, EntityQueryDesc FEDKNLJALCB, bool JPHDKFDHOEE, bool NHADPEGDINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0x27B8C60", Offset = "0x27B7E60", VA = "0x1827B8C60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x27B8210", Offset = "0x27B7410", VA = "0x1827B8210")]
	private void ELIFEDCAFMF(EntityQuery JIAIANFJBDB, bool OEBKHBJCBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x27B8060", Offset = "0x27B7260", VA = "0x1827B8060")]
	private void DIKHODPNELJ(EntityQuery JIAIANFJBDB, bool KDBFEKCIOCO, bool OEBKHBJCBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x27B83C0", Offset = "0x27B75C0", VA = "0x1827B83C0")]
	private void HOFAAMJCNKG(NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x27B8630", Offset = "0x27B7830", VA = "0x1827B8630")]
	private void NIKPFLECMHF(NativeList<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x27B7F40", Offset = "0x27B7140", VA = "0x1827B7F40")]
	private void BDAGHPOECEI(NativeArray<Entity> IBGFBPGPJKP, bool KDBFEKCIOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x27B87E0", Offset = "0x27B79E0", VA = "0x1827B87E0")]
	private NativeList<Entity> OHLEHIGABBD(NativeArray<Entity> IBGFBPGPJKP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x27B7F00", Offset = "0x27B7100", VA = "0x1827B7F00")]
	private NativeList<Entity> AOFIJFPPCNH(NativeArray<Entity> IBGFBPGPJKP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x27B87A0", Offset = "0x27B79A0", VA = "0x1827B87A0")]
	private NativeList<Entity> OBMHGDOMFJM(NativeArray<Entity> IBGFBPGPJKP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x27B8F80", Offset = "0x27B8180", VA = "0x1827B8F80")]
	private NativeList<Entity> PCKOJBFNPDB(NativeArray<Entity> IBGFBPGPJKP, bool FJAOBEPJCGB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x27B9420", Offset = "0x27B8620", VA = "0x1827B9420")]
	public DMGLMIPEJMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class IIDMHANDNGK : HCCDJHNELLM
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	protected override ABAPOMGFJBP DHOHAFONONK
	{
		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x25B0F60", Offset = "0x25B0160", VA = "0x1825B0F60", Slot = "15")]
		get
		{
			return default(ABAPOMGFJBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x25B0FE0", Offset = "0x25B01E0", VA = "0x1825B0FE0")]
	public IIDMHANDNGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[UpdateBefore(typeof(GFEKFLINPBD))]
public class IKGLLKEMDCC : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x25B1430", Offset = "0x25B0630", VA = "0x1825B1430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x25B14D0", Offset = "0x25B06D0", VA = "0x1825B14D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public IKGLLKEMDCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class EGAFKBKNCGJ : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[BurstCompile]
	private struct PODKPEACOLJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[ReadOnly]
		public ComponentDataFromEntity<CHDOFCKIBBD> LEHJGJLGJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		[ReadOnly]
		public NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x2225D50", Offset = "0x2224F50", VA = "0x182225D50", Slot = "4")]
		public void Execute(int NNAODBDJDNJ, TransformAccess LNNHFELGMNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[BurstCompile]
	private struct JEPPMCBNMLE : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		[ReadOnly]
		public ComponentDataFromEntity<BOHGFEOLDLP> BJFBANDDNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[ReadOnly]
		public NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x2221780", Offset = "0x2220980", VA = "0x182221780", Slot = "4")]
		public void Execute(int NNAODBDJDNJ, TransformAccess LNNHFELGMNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[BurstCompile]
	private struct OEELGBHHKJH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[ReadOnly]
		public ComponentDataFromEntity<BOHGFEOLDLP> BJFBANDDNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		[ReadOnly]
		public ComponentDataFromEntity<EPFNMOOOKJI> CLCECONGDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		[ReadOnly]
		public NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x2224A70", Offset = "0x2223C70", VA = "0x182224A70", Slot = "4")]
		public void Execute(int NNAODBDJDNJ, TransformAccess LNNHFELGMNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private static readonly PEKDFCFCENH IPAHDCDIGHM;

	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private static readonly PEKDFCFCENH ADMNIANIDJA;

	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private static readonly PEKDFCFCENH FLDODGALNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private PKGBNCCFPJF GNEPDPIHPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private EntityQuery FBIKHENLLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private EntityQuery NKKNIFBBCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private EntityQuery MBPIEKPMGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	private TransformAccessArray PIJIJOJOECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private TransformAccessArray APAAPKEPBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private TransformAccessArray MEIAICKMKJH;

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x27BCE10", Offset = "0x27BC010", VA = "0x1827BCE10", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x27BCE60", Offset = "0x27BC060", VA = "0x1827BCE60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x27BD050", Offset = "0x27BC250", VA = "0x1827BD050", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x27BD0E0", Offset = "0x27BC2E0", VA = "0x1827BD0E0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x27BD110", Offset = "0x27BC310", VA = "0x1827BD110", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC70", Offset = "0x27BBE70", VA = "0x1827BCC70")]
	private NativeArray<Entity> GBICKFDBOJO(NativeArray<JNGGGJCNGDE> FGPMAMJJHFD, NativeList<Entity> BOMLLFOALBE, TransformAccessArray DECKIONDGEP, TransformAccessArray KJPHLKAPPIP)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public EGAFKBKNCGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class JBJMFFMGCND : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x25B3940", Offset = "0x25B2B40", VA = "0x1825B3940", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public JBJMFFMGCND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
[DDDGJOKMEDO(typeof(MLJBBEFEOND), new string[] { })]
internal sealed class MLJBBEFEOND : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private static readonly PEKDFCFCENH HPLKLDCEBID;

	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private static readonly PEKDFCFCENH DKMANHJIHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	[MOHONECELPE]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private FEFNNKAJBMA<OFEJBHGNNGK, Entity> MFIBPNNMJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private LDMKCLHFENF<DFOADIEACGB> OBGLOGLELGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private LDMKCLHFENF<OOJJMLNHELB> DBNIDCBKMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private LDMKCLHFENF<NGEMPDDJGKB> HLIEDBGPGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private LDMKCLHFENF<CBJNPMHHAFI> NPJPMNPOFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private LDMKCLHFENF<HDBFPHDKCNL> KMCFNHCIMAG;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public FHHKGGGPNKC<Entity> CDMEHCIDEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public AOJDBHGLIIG HHJAGGKKCHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public AOJDBHGLIIG GKDFACNGAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public AOJDBHGLIIG BMAHEOBLDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public AOJDBHGLIIG LPHIKBGDAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public AOJDBHGLIIG EDHOBPMMJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E8C0", Offset = "0x2A8DAC0", VA = "0x182A8E8C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EA00", Offset = "0x2A8DC00", VA = "0x182A8EA00", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E910", Offset = "0x2A8DB10", VA = "0x182A8E910", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x124A1E0", Offset = "0x12493E0", VA = "0x18124A1E0")]
	private void FGNOPHJIAHN<T>(ref LDMKCLHFENF<T> PPKNEMOJKIB, EntityCommandBufferSystem FBICPICMEOC, PEKDFCFCENH LHCMKIAHBCL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x124A290", Offset = "0x1249490", VA = "0x18124A290")]
	private void FGNOPHJIAHN<TC, TV>(ref FEFNNKAJBMA<TC, TV> PPKNEMOJKIB) where TC : struct, GDNHGAGIENF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MLJBBEFEOND()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public struct OOJJMLNHELB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct DFOADIEACGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public struct NGEMPDDJGKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public struct CBJNPMHHAFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct HDBFPHDKCNL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
[ExecuteAlways]
public class LNMKKHPMBAN : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
	public LNMKKHPMBAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal readonly struct MMJJLGIGKNK
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[CompilerGenerated]
	private sealed class CEGMNBCELHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public KNNEOPGGIBD system;

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CEGMNBCELHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x22198E0", Offset = "0x2218AE0", VA = "0x1822198E0")]
		internal (EntityQuery, ComponentType) KLCBDMDNNBA((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private static readonly ProfilerMarker OBEGNKLMOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private readonly KNNEOPGGIBD FMGKDHAODCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] LDPAMNJIEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059A")]
	private readonly EntityQuery HHOLKFLPEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	private readonly EntityQuery KMFPKDKCLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private readonly ComponentTypes FHIOOLMALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	private readonly ComponentTypes FCCNLKEDKKL;

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x2A93160", Offset = "0x2A92360", VA = "0x182A93160")]
	public MMJJLGIGKNK(KNNEOPGGIBD FMGKDHAODCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x2A92EA0", Offset = "0x2A920A0", VA = "0x182A92EA0")]
	public void KGILAIAHHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class GJNNOPMAGPA : HBIAMONPJOO
{
	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x27D02D0", Offset = "0x27CF4D0", VA = "0x1827D02D0", Slot = "14")]
	protected override EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public GJNNOPMAGPA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	[CompilerGenerated]
	[OLMIFJOAIBG]
	public class DebugPostDeserializeRemoveOrphanedSplinePoints : AFFEALIJNOO
	{
		[Cpp2IlInjected.Token(Token = "0x20001B3")]
		[NoAlias]
		[BurstCompile]
		private struct DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			[ReadOnly]
			public ComponentDataFromEntity<BKCCEEBHOIE> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			[ReadOnly]
			public ComponentTypeHandle<GAAIHPAGNAD> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x221BE50", Offset = "0x221B050", VA = "0x18221BE50")]
			private void CHEGCCDBFJM(Entity entity, [NoAlias] in GAAIHPAGNAD point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x221BEC0", Offset = "0x221B0C0", VA = "0x18221BEC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private EntityQuery DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private ComponentTypeHandle<GAAIHPAGNAD> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x27BAEB0", Offset = "0x27BA0B0", VA = "0x1827BAEB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x27BAA80", Offset = "0x27B9C80", VA = "0x1827BAA80")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void CINAAKEFNDO(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x27BAB20", Offset = "0x27B9D20", VA = "0x1827BAB20")]
		private EntityCommandBufferSystem IMLBAKBFEOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x27BAB70", Offset = "0x27B9D70", VA = "0x1827BAB70")]
		private JobHandle NIOEMNAMFHE(EntityCommandBuffer ecb, ComponentDataFromEntity<BKCCEEBHOIE> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x27BACB0", Offset = "0x27B9EB0", VA = "0x1827BACB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public DebugPostDeserializeRemoveOrphanedSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
public struct NMBGDHMMLIG<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A9")]
	[ReadOnly]
	public EntityQueryInJob JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AA")]
	[ReadOnly]
	public EntityTypeHandle GOGJOAEDHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AB")]
	[ReadOnly]
	public ComponentTypeHandle<T> HEJEJPHFLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	[WriteOnly]
	public EntityCommandBuffer HEDKIIMNAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	public AllocatorManager.AllocatorHandle KPFKDHLBOGB;

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0x2D6E750", Offset = "0x2D6D950", VA = "0x182D6E750")]
	public OCIPEIPIJCB<T> IAAIOOJOEJC()
	{
		return default(OCIPEIPIJCB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public static class HGPJHIEEBAC
{
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[BurstCompile]
	private struct PNHIGDOKPPA : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		[ReadOnly]
		public NativeParallelHashSet<int> PBDLGMAEEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> NIKGJBNIIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public NativeList<EntityArchetype> AMGGPMBBAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public NativeList<JJDOOCODKMA> KGHNKDJFCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public NativeList<JJDOOCODKMA> OGJNHCCNPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public NativeList<ComponentType> JKHFHJIGFLJ;

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x2225720", Offset = "0x2224920", VA = "0x182225720", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x2225690", Offset = "0x2224890", VA = "0x182225690", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x25A67D0", Offset = "0x25A59D0", VA = "0x1825A67D0")]
	public static NativeParallelHashSet<int> LOJHOIOPEDJ(Allocator KPFKDHLBOGB)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x25A6360", Offset = "0x25A5560", VA = "0x1825A6360")]
	public static NativeParallelHashSet<int> GGOAPALBDJP(Allocator KPFKDHLBOGB)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x25A5EE0", Offset = "0x25A50E0", VA = "0x1825A5EE0")]
	private static void CMKEHFEDCKD(NativeParallelHashSet<int> PNAKIENPNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x25A72D0", Offset = "0x25A64D0", VA = "0x1825A72D0")]
	private static bool OGIDILLJGAO(Type FBNKHAJKFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0x25A7140", Offset = "0x25A6340", VA = "0x1825A7140")]
	private static void NGNBCBHGBGK(NativeParallelHashSet<int> PNAKIENPNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x25A64C0", Offset = "0x25A56C0", VA = "0x1825A64C0")]
	private static void ICGCFBHJCLL(NativeParallelHashSet<int> PNAKIENPNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x25A61D0", Offset = "0x25A53D0", VA = "0x1825A61D0")]
	private static void EFBMJGCDDBE(NativeParallelHashSet<int> PNAKIENPNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x25A68B0", Offset = "0x25A5AB0", VA = "0x1825A68B0")]
	public static void MNMONNNCMBB(EntityManager NMHMIPEFENM, EntityQuery JIAIANFJBDB, NativeParallelHashSet<int> ABFNCDKFNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x25A6650", Offset = "0x25A5850", VA = "0x1825A6650")]
	public static void JAIEHBIDNPC(EntityManager NMHMIPEFENM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public class MMOCDBOIFKL : ParentSystemBase<BGFGOLHGEPN, LIFFAKCHIOD, JFFGLDLIPLN>
{
	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x2A93710", Offset = "0x2A92910", VA = "0x182A93710", Slot = "14")]
	protected override EntityQueryDesc PHHOGLDJMGC(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x9B0260", Offset = "0x9AF460", VA = "0x1809B0260", Slot = "15")]
	protected override EntityQueryDesc MKENBAHNLHG(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2A936D0", Offset = "0x2A928D0", VA = "0x182A936D0", Slot = "16")]
	protected override EntityQueryDesc FEFPMAHJJCP(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2A93690", Offset = "0x2A92890", VA = "0x182A93690", Slot = "17")]
	protected override EntityQueryDesc BIGECHHJANE(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x2A93750", Offset = "0x2A92950", VA = "0x182A93750")]
	public MMOCDBOIFKL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : KNNEOPGGIBD where TParentData : struct, IComponentData, GBELNJMIIOO where TPreviousParentData : struct, IComponentData, GBELNJMIIOO where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, GBELNJMIIOO
	{
		[Cpp2IlInjected.Token(Token = "0x20001B9")]
		[BurstCompile]
		internal struct HPKMMBFCOIB : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter CKGFDDMJPDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter MINODEOHPIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			public NativeParallelHashMap<Entity, int>.ParallelWriter CEHBCHOEKLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public ComponentTypeHandle<TPreviousParentData> MOODKMGMECL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			[ReadOnly]
			public ComponentTypeHandle<TParentData> BOELHMOEFJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			[ReadOnly]
			public EntityTypeHandle PMMHBBKJPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public uint LDIKCCIHMGG;

			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0x25A35F0", Offset = "0x25A27F0", VA = "0x1825A35F0", Slot = "4")]
			public void Execute(ArchetypeChunk PEHGOEJDGEP, int NPCAADALBBC, int MHCLOCKEOJJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BA")]
		[BurstCompile]
		internal struct FPANMIHDFHP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> CEHBCHOEKLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> EFBMBIACEIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public NativeList<Entity> AAPGKKAJFIB;

			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0x5158760", Offset = "0x5157960", VA = "0x185158760", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BB")]
		[BurstCompile]
		internal struct KIPBFOCEJHI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> CKGFDDMJPDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> MINODEOHPIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> CEHBCHOEKLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			public BufferFromEntity<TChildrenData> EFBMBIACEIM;

			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x22A14D0", Offset = "0x22A06D0", VA = "0x1822A14D0")]
			private int NOAJFGBCOOE(DynamicBuffer<TChildrenData> KNNJOFGDFGM, Entity BLNICJMKCEF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x22A1650", Offset = "0x22A0850", VA = "0x1822A1650")]
			private void OKONBJOABGM(Entity OJEMCPHOKBP, DynamicBuffer<TChildrenData> KNNJOFGDFGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x22A0F90", Offset = "0x22A0190", VA = "0x1822A0F90")]
			private void ENDPOJAKBLN(Entity OJEMCPHOKBP, DynamicBuffer<TChildrenData> KNNJOFGDFGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x22A11F0", Offset = "0x22A03F0", VA = "0x1822A11F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BC")]
		[BurstCompile]
		private struct BFNPAMBEDOI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			[ReadOnly]
			public NativeArray<Entity> ALINJDMIPGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public NativeList<Entity> IELDKDGLEJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> EFBMBIACEIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			[ReadOnly]
			public ComponentDataFromEntity<TParentData> PNDEHGJPDAF;

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x2311160", Offset = "0x2310360", VA = "0x182311160", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		protected EntityQuery IPHCBMBBNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		protected EntityQuery IHKOMBEJLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		protected EntityQuery NKPKIGANHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		protected EntityQuery ENAINBHKPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		protected ProfilerMarker ABPOMDLIHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		protected ProfilerMarker OCGHLBEIHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		protected ProfilerMarker IFPAMKGAPCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		protected ProfilerMarker EBKPLJHBKND;

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x2278010", Offset = "0x2277210", VA = "0x182278010")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x2277B70", Offset = "0x2276D70", VA = "0x182277B70")]
		private int NOAJFGBCOOE(DynamicBuffer<TChildrenData> KNNJOFGDFGM, Entity BLNICJMKCEF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x2277650", Offset = "0x2276850", VA = "0x182277650")]
		private void GNOPFJPPAIE(Entity KAGDAGKLNMD, Entity DALBOOIOEBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3F")]
		[Cpp2IlInjected.Address(RVA = "0x9B0260", Offset = "0x9AF460", VA = "0x1809B0260", Slot = "14")]
		protected virtual EntityQueryDesc PHHOGLDJMGC(EntityQueryDesc JIAIANFJBDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x9B0260", Offset = "0x9AF460", VA = "0x1809B0260", Slot = "15")]
		protected virtual EntityQueryDesc MKENBAHNLHG(EntityQueryDesc JIAIANFJBDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x9B0260", Offset = "0x9AF460", VA = "0x1809B0260", Slot = "16")]
		protected virtual EntityQueryDesc FEFPMAHJJCP(EntityQueryDesc JIAIANFJBDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc BIGECHHJANE(EntityQueryDesc JIAIANFJBDB);

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x2277C60", Offset = "0x2276E60", VA = "0x182277C60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x2277580", Offset = "0x2276780", VA = "0x182277580")]
		private void FONPKBBMKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x22773A0", Offset = "0x22765A0", VA = "0x1822773A0")]
		private void CNLNFCLCCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2276DE0", Offset = "0x2275FE0", VA = "0x182276DE0")]
		private JobHandle CGNGKPMJMBO(JobHandle FOFFIFNKDII)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x22777B0", Offset = "0x22769B0", VA = "0x1822777B0")]
		private void NCKJLFJFODG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x2277F40", Offset = "0x2277140", VA = "0x182277F40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x1C4DCB0", Offset = "0x1C4CEB0", VA = "0x181C4DCB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public class NNHAEGNGGOM : NBEGILHGCNC
{
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	protected override OIGCJBPECJE PCICOCDAOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "15")]
		get
		{
			return default(OIGCJBPECJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2A99E70", Offset = "0x2A99070", VA = "0x182A99E70", Slot = "16")]
	protected override void GAKNNJLMJKB(OIGCJBPECJE KBIJDJHCEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A140", Offset = "0x2A99340", VA = "0x182A9A140")]
	private EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A220", Offset = "0x2A99420", VA = "0x182A9A220")]
	public NNHAEGNGGOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[OLMIFJOAIBG]
public class AHCHAACOCIC : AFFEALIJNOO
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	private struct BDICJHCPOLM : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		[ReadOnly]
		public NativeParallelHashSet<int> PKKANOHLBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		[ReadOnly]
		public EntityTypeHandle LDKGPDMDLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> HAFAGLOAHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public NativeList<Entity>.ParallelWriter MOLLKDNDMBP;

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x2217580", Offset = "0x2216780", VA = "0x182217580", Slot = "4")]
		public void Execute(ArchetypeChunk PEHGOEJDGEP, int NPCAADALBBC, int MHCLOCKEOJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2621140", Offset = "0x2620340", VA = "0x182621140", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x26211D0", Offset = "0x26203D0", VA = "0x1826211D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x26210F0", Offset = "0x26202F0", VA = "0x1826210F0")]
	private EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public AHCHAACOCIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public struct BONPPKDBCCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	public Entity BLNICJMKCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	public PABPBCLLOCG CNPGLHEDJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public PABPBCLLOCG KJOKOFBOJIE;
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
[DDDGJOKMEDO(typeof(PKGBNCCFPJF), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal sealed class PKGBNCCFPJF : PNKPNDDLHPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	private NAGMBDLGMDD IDAKJPFJHAO;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public NAGMBDLGMDD IOEOJGAJCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x24555C0", Offset = "0x24547C0", VA = "0x1824555C0")]
		get
		{
			return default(NAGMBDLGMDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x24555E0", Offset = "0x24547E0", VA = "0x1824555E0", Slot = "4")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x24555B0", Offset = "0x24547B0", VA = "0x1824555B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public PKGBNCCFPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
internal sealed class ONLFMJKELMI : ParentSystemBase<BGFGOLHGEPN, LIFFAKCHIOD, JFFGLDLIPLN>
{
	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x9B0260", Offset = "0x9AF460", VA = "0x1809B0260", Slot = "14")]
	protected override EntityQueryDesc PHHOGLDJMGC(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x9B0260", Offset = "0x9AF460", VA = "0x1809B0260", Slot = "15")]
	protected override EntityQueryDesc MKENBAHNLHG(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x9B0260", Offset = "0x9AF460", VA = "0x1809B0260", Slot = "16")]
	protected override EntityQueryDesc FEFPMAHJJCP(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D450", Offset = "0x2A9C650", VA = "0x182A9D450", Slot = "17")]
	protected override EntityQueryDesc BIGECHHJANE(EntityQueryDesc JIAIANFJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D490", Offset = "0x2A9C690", VA = "0x182A9D490")]
	public ONLFMJKELMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
[DDDGJOKMEDO(typeof(MNCDKBBELAG), new string[] { })]
internal class DOIAJAOECOH : MNCDKBBELAG, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	[MOHONECELPE]
	private NBMHDDHKDOO CLIODOKHJHI;

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x27B98D0", Offset = "0x27B8AD0", VA = "0x1827B98D0", Slot = "8")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x27B99B0", Offset = "0x27B8BB0", VA = "0x1827B99B0", Slot = "4")]
	public World MLEMFBKEIPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x27B96F0", Offset = "0x27B88F0", VA = "0x1827B96F0", Slot = "5")]
	public World BCDPIFHGLBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x27B9790", Offset = "0x27B8990", VA = "0x1827B9790", Slot = "6")]
	public World HFCAFFPLGPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x27B9830", Offset = "0x27B8A30", VA = "0x1827B9830", Slot = "7")]
	public World HKLEOENPOOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x27B9920", Offset = "0x27B8B20", VA = "0x1827B9920")]
	private World JOOAPLIFFIP(string JPKENOAMLIN, GNGBDELHNDD HCCLEJHCLJP, Type LGELPOKJLAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public DOIAJAOECOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
public enum LCOECJPMODN
{
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal class DKKMKIHCMKC : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private object EJMFJEDFPHK;

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x263AFF0", Offset = "0x263A1F0", VA = "0x18263AFF0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x263B070", Offset = "0x263A270", VA = "0x18263B070", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x263B110", Offset = "0x263A310", VA = "0x18263B110", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public DKKMKIHCMKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
internal class DPABNLKACGI : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private LGMPOOCECDN CKIBMJIJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private EntityQuery ONKGGDDPBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private EntityQuery PCOEOEOENNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private JGPGIDINFEG NJFMCLNALDN;

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x27BA2B0", Offset = "0x27B94B0", VA = "0x1827BA2B0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x27BA380", Offset = "0x27B9580", VA = "0x1827BA380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x27BA490", Offset = "0x27B9690", VA = "0x1827BA490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x27B9C10", Offset = "0x27B8E10", VA = "0x1827B9C10")]
	private void BPBEADGDDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x27BA140", Offset = "0x27B9340", VA = "0x1827BA140")]
	private void IKDCHJKPAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x27B9E30", Offset = "0x27B9030", VA = "0x1827B9E30")]
	private void IBEACFOEEHN(NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x27B9AD0", Offset = "0x27B8CD0", VA = "0x1827B9AD0")]
	private void AIGFJDBIBIB(NativeArray<Entity> IBGFBPGPJKP, int ALKCHBOHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x27B9D20", Offset = "0x27B8F20", VA = "0x1827B9D20")]
	private void FKGICCNJHNI(NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x27BA320", Offset = "0x27B9520", VA = "0x1827BA320")]
	private void MPDCGICOAEM(Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x90C160", Offset = "0x90B360", VA = "0x18090C160")]
	private static void CKJPCEIBBNE(int MIOMNEOFMJG, Transform LNNHFELGMNI, Entity BLNICJMKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public DPABNLKACGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
internal static class NHKKAHNIEEG
{
	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x2A98760", Offset = "0x2A97960", VA = "0x182A98760")]
	public static bool KIKIEPEMIGO(this SystemBase FMGKDHAODCH, out Entity BLNICJMKCEF)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	[AKEFOBLNEPL(CCDGJKNFPNB.OMRoom)]
	public class PostLoadRemapCircuitIds : KNNEOPGGIBD, DCLDDNDKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x20001C9")]
		private struct PostLoadRemapCircuitIds_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005E9")]
			public KEAMHPDKNJO remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005EA")]
			public ComponentTypeHandle<FLFCLFLDKKG> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x609AB50", Offset = "0x6099D50", VA = "0x18609AB50")]
			private void CHEGCCDBFJM(ref FLFCLFLDKKG node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0x609AD90", Offset = "0x6099F90", VA = "0x18609AD90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		[MOHONECELPE]
		private DFFEELNDGLN serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private EntityQuery PostLoadRemapCircuitIds_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private ComponentTypeHandle<FLFCLFLDKKG> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x2464AC0", Offset = "0x2463CC0", VA = "0x182464AC0", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x2464D40", Offset = "0x2463F40", VA = "0x182464D40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0x2464EB0", Offset = "0x24640B0", VA = "0x182464EB0")]
		private void PGBCCOFMDGN(KEAMHPDKNJO remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A80")]
		[Cpp2IlInjected.Address(RVA = "0x2464FA0", Offset = "0x24641A0", VA = "0x182464FA0")]
		private void POOGBMMBOAN(ref KEAMHPDKNJO remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0x2464B10", Offset = "0x2463D10", VA = "0x182464B10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A82")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PostLoadRemapCircuitIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class IBNEPLJIBIB : KNNEOPGGIBD, DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private static readonly PEKDFCFCENH NOCBMGMFCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	[MOHONECELPE]
	private EMNPBOOGNLC CMEFNIKNDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	[MOHONECELPE]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	[MOHONECELPE]
	private KDHIEDDFGEM FOLMCJCIONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	[MOHONECELPE]
	private IFABAGNNEHF HPCHEPAMAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	[MOHONECELPE]
	private ENJJBFBECCF MPHJIJOJBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	[MOHONECELPE]
	private HBBBCINFOON BNNJAPHFIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private ICEKLGJJGAE.KPBPFBMHNDE GANOICKHJOC;

	[Cpp2IlInjected.Token(Token = "0x6000A85")]
	[Cpp2IlInjected.Address(RVA = "0x25ABAF0", Offset = "0x25AACF0", VA = "0x1825ABAF0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0x25AB940", Offset = "0x25AAB40", VA = "0x1825AB940", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x25AC4F0", Offset = "0x25AB6F0", VA = "0x1825AC4F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x25ABCA0", Offset = "0x25AAEA0", VA = "0x1825ABCA0")]
	private void KCBHFBEEOOJ(PKINEBOAGLJ JCEGKCPOPDM, NativeArray<byte> GFPBHPMOCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x25AA610", Offset = "0x25A9810", VA = "0x1825AA610")]
	private bool ABEODIHCIKD(PKINEBOAGLJ JCEGKCPOPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x25AB190", Offset = "0x25AA390", VA = "0x1825AB190")]
	private ICEKLGJJGAE.CKOOMFNPKAB DCEAPOJAIBK(NativeArray<byte> GFPBHPMOCNL, Allocator KPFKDHLBOGB)
	{
		return default(ICEKLGJJGAE.CKOOMFNPKAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x25AAD80", Offset = "0x25A9F80", VA = "0x1825AAD80")]
	private void BIFJKCODHOM(ICEKLGJJGAE.CKOOMFNPKAB BLDGCGCNMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x25AC300", Offset = "0x25AB500", VA = "0x1825AC300")]
	private void OLNGJCJFIBL(NativeList<NACALKPEILN> CJGGJGGNMNO, NativeList<DLGBACOGEKM> NBHGMLCGCLE, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x25AA6D0", Offset = "0x25A98D0", VA = "0x1825AA6D0")]
	private void ADJCNFJDOBM(NativeParallelMultiHashMap<NACALKPEILN, AIBGADIMBJB> KLMIJEDOKOK, NativeList<byte> DDPOPGNFMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x25AAB90", Offset = "0x25A9D90", VA = "0x1825AAB90")]
	private void ADLLGGIFKBJ(NativeList<NACALKPEILN> KPKKLHACPOP, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x25AAE70", Offset = "0x25AA070", VA = "0x1825AAE70")]
	private void CMLJJJFMICL(ICEKLGJJGAE.CKOOMFNPKAB JFGIPFOFKHL, bool OJHJIGGBPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x25AC180", Offset = "0x25AB380", VA = "0x1825AC180")]
	private void KGPHADJMBGE(NativeList<NACALKPEILN> CJGGJGGNMNO, NativeList<DLGBACOGEKM> NBHGMLCGCLE, bool OJHJIGGBPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x25AB310", Offset = "0x25AA510", VA = "0x1825AB310")]
	private void DFGGLPILEMA(NativeParallelMultiHashMap<NACALKPEILN, AIBGADIMBJB> KLMIJEDOKOK, NativeList<byte> DDPOPGNFMKH, bool OJHJIGGBPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x25AB9E0", Offset = "0x25AABE0", VA = "0x1825AB9E0")]
	private void ILHLMLKGBCO(NativeList<NACALKPEILN> KPKKLHACPOP, bool OJHJIGGBPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void DNAMKKDODMM(PKINEBOAGLJ JCEGKCPOPDM, bool OJHJIGGBPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public IBNEPLJIBIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class EPEJMBIMAOH : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x27C2270", Offset = "0x27C1470", VA = "0x1827C2270", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public EPEJMBIMAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
[LJJFMBKPAEC(CCDGJKNFPNB.LoadInstance)]
internal interface DCIJLGIBKEE
{
	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	NativeParallelMultiHashMap<Entity, GOECINKNCJI> KHLFCDCDNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	uint LDIKCCIHMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DMOGLJKCHMB(NativeArray<NACALKPEILN> CJGGJGGNMNO, NativeArray<DLGBACOGEKM> NBHGMLCGCLE, NativeArray<NACALKPEILN> KPKKLHACPOP, int ONFNCJBBOFM);

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAFPCGCPMJG(in FFHIFLEKAAF MLOLIBCACCF);

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CHPFHLEFCKI(JobHandle EMCKGOPIABN);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	public class CalculateCollisionIslandUpdatesSystem : KNNEOPGGIBD, DCLDDNDKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		[BurstCompile]
		[NoAlias]
		private struct CalculateCollisionIslandUpdatesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			public NativeList<Entity> rootsWithForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			public NativeList<Entity> rootsWithoutForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			[ReadOnly]
			public ComponentTypeHandle<AKFBEAGBHPP> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			[ReadOnly]
			public ComponentDataFromEntity<AKFBEAGBHPP> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			[ReadOnly]
			public ComponentTypeHandle<GAAIHPAGNAD> splineParentHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			public EntityQueryInJob changedLocalPoseQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			public EntityQueryInJob changedSplinePointsQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			public EntityQueryInJob splinesWithChangedChildrenQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public EntityQueryInJob changedCollisionModeQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public EntityQueryInJob changedScopeRootQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x6000AA3")]
			[Cpp2IlInjected.Address(RVA = "0x221A8B0", Offset = "0x2219AB0", VA = "0x18221A8B0")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA4")]
			[Cpp2IlInjected.Address(RVA = "0x221B0B0", Offset = "0x221A2B0", VA = "0x18221B0B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private EntityQuery changedLocalPoseQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private EntityQuery changedSplinePointsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private EntityQuery splinesWithChangedChildrenQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private EntityQuery changedCollisionModeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private EntityQuery scopeRootChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private PMDPEMDAEAF collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x2633400", Offset = "0x2632600", VA = "0x182633400", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x2633450", Offset = "0x2632650", VA = "0x182633450", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x26337B0", Offset = "0x26329B0", VA = "0x1826337B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x2633250", Offset = "0x2632450", VA = "0x182633250")]
		private JobHandle AOMLDKMCGMP(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<AKFBEAGBHPP> collisionIslandRootDataHandleRO, ComponentDataFromEntity<AKFBEAGBHPP> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<GAAIHPAGNAD> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[OLMIFJOAIBG]
public class GAADNDEMCKB : AFFEALIJNOO
{
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x27CD7A0", Offset = "0x27CC9A0", VA = "0x1827CD7A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x27CD830", Offset = "0x27CCA30", VA = "0x1827CD830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x27CD750", Offset = "0x27CC950", VA = "0x1827CD750")]
	private EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public GAADNDEMCKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class HJJEEFLELIK : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[BurstCompile]
	private struct JFJFMIOCJMO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		[ReadOnly]
		public int OJBPEOLKKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		[ReadOnly]
		public EntityQueryInJob MFEHGPLOEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		[ReadOnly]
		public EntityQueryInJob MJKDEFKCEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged PLJENKNPMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		[ReadOnly]
		public EntityTypeHandle LDKGPDMDLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		[ReadOnly]
		public ComponentDataFromEntity<EDICBKLMJAO> EMGLJJDCNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		[ReadOnly]
		public ComponentDataFromEntity<LLPDNIBHICC> LOIGKGGOCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> FDPEIHEIMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		[ReadOnly]
		public ComponentTypeHandle<GAAIHPAGNAD> BLKIMMPOLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		[ReadOnly]
		public ComponentDataFromEntity<AJALCLPOENM> NMDCHLGGHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		[ReadOnly]
		public ComponentDataFromEntity<MIKHADPILJF> GHAGKOAHCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		[WriteOnly]
		public ComponentDataFromEntity<GJMKIKKIJMF> CMMLNLPFBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		[WriteOnly]
		public ComponentDataFromEntity<NPAEBGIHHKC> HKIDBGBEOFN;

		[Cpp2IlInjected.Token(Token = "0x6000AAE")]
		[Cpp2IlInjected.Address(RVA = "0x2221D30", Offset = "0x2220F30", VA = "0x182221D30", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAF")]
		[Cpp2IlInjected.Address(RVA = "0x2221820", Offset = "0x2220A20", VA = "0x182221820")]
		private void ADBKEALNJHJ(NativeList<Entity> PPJAICKPJJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB0")]
		[Cpp2IlInjected.Address(RVA = "0x2221ED0", Offset = "0x22210D0", VA = "0x182221ED0")]
		private void LKDOPOMFKIA(Entity IEFMFCGPBPC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private EntityQuery JAFHIBEEMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private EntityQuery KNIKLJIBFPA;

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x25A9180", Offset = "0x25A8380", VA = "0x1825A9180", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x25A9320", Offset = "0x25A8520", VA = "0x1825A9320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAC")]
	[Cpp2IlInjected.Address(RVA = "0x217B210", Offset = "0x217A410", VA = "0x18217B210")]
	private bool AIIPHFCAOIP<T>(T CJBMIKALAFE, out int AEDBCMIFFPB) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public HJJEEFLELIK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkId : AFFEALIJNOO, DCLDDNDKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x20001D3")]
		private struct DebugPostLoadValidateNetworkId_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public NativeParallelHashMap<NACALKPEILN, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			[ReadOnly]
			public ComponentTypeHandle<GODAIDEBOAI> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000AB6")]
			[Cpp2IlInjected.Address(RVA = "0x221BFE0", Offset = "0x221B1E0", VA = "0x18221BFE0")]
			private void CHEGCCDBFJM(Entity entity, in GODAIDEBOAI networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AB7")]
			[Cpp2IlInjected.Address(RVA = "0x221C090", Offset = "0x221B290", VA = "0x18221C090", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private MHGCAFFKDBL networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private EntityQuery DebugPostLoadValidateNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private ComponentTypeHandle<GODAIDEBOAI> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x27BB1F0", Offset = "0x27BA3F0", VA = "0x1827BB1F0", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x27BB480", Offset = "0x27BA680", VA = "0x1827BB480", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x27BB100", Offset = "0x27BA300", VA = "0x1827BB100")]
		private void IOKOOONBHJC(ref NativeParallelHashMap<NACALKPEILN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x27BB250", Offset = "0x27BA450", VA = "0x1827BB250", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public DebugPostLoadValidateNetworkId()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public readonly struct CLCCDDHEJID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private readonly int CNBPDHPGPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private readonly int CJNGPAPKKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private readonly JJDOOCODKMA LPHPDIBJEMD;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public JJDOOCODKMA JOLJGLCLNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x902ED0", Offset = "0x9020D0", VA = "0x180902ED0")]
		get
		{
			return default(JJDOOCODKMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x262E990", Offset = "0x262DB90", VA = "0x18262E990")]
	public CLCCDDHEJID(int CNBPDHPGPFI, int CJNGPAPKKID, JJDOOCODKMA LPHPDIBJEMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[InternalBufferCapacity(1)]
internal struct AHGNDLOGKJF : ISystemStateBufferElementData, IBufferElementData, IEquatable<AHGNDLOGKJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	public PFJMGBBLOEJ EMCKGOPIABN;

	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x2622C40", Offset = "0x2621E40", VA = "0x182622C40", Slot = "4")]
	public bool Equals(AHGNDLOGKJF JMNBIHILIIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static AHGNDLOGKJF OMHOCPNBHHH(PFJMGBBLOEJ EMCKGOPIABN)
	{
		return default(AHGNDLOGKJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DDDGJOKMEDO(typeof(OOMBIJKANHD), new string[] { })]
public sealed class FHLGMOFFJCA : OOMBIJKANHD, DCLDDNDKGBL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001D7")]
	private struct JNLHALNPACA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public float APODEFIALKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public uint JCLNDFMBPFE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	[MOHONECELPE]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000621")]
	[MOHONECELPE]
	private PLEFLDKFGFP PLIKBHOEPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000622")]
	[MOHONECELPE]
	private EAECNFFNPIO MGOIGANPMDN;

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x27C95B0", Offset = "0x27C87B0", VA = "0x1827C95B0", Slot = "5")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x27C90D0", Offset = "0x27C82D0", VA = "0x1827C90D0")]
	public bool HIKLJPGBGIK(in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, float EKIBGBMDOJP, out EIPOHBGDCNM GMKMPBEKJDH, out BMDJOHDFBDL IEFMFCGPBPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x27C8FC0", Offset = "0x27C81C0", VA = "0x1827C8FC0")]
	public static bool BHDIJBDJHLN(in Span<EIPOHBGDCNM> FNICDEBHOFM, float EKIBGBMDOJP, out int NNAODBDJDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x27C90A0", Offset = "0x27C82A0", VA = "0x1827C90A0")]
	public static float DAIDHHAIJKH(float APODEFIALKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public FHLGMOFFJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x27C9640", Offset = "0x27C8840", VA = "0x1827C9640", Slot = "4")]
	private bool NJHHPAJLMIB(in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, float EKIBGBMDOJP, out EIPOHBGDCNM GMKMPBEKJDH, out BMDJOHDFBDL IEFMFCGPBPC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal struct HNLMJGLLBEJ : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public class MBEMEDEEACC : KNNEOPGGIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000626")]
	private EntityQuery GDFBLGJDKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	private ComponentTypes KDNNPLHLILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	private NativeParallelHashSet<int> ABFNCDKFNFI;

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2A86AE0", Offset = "0x2A85CE0", VA = "0x182A86AE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x2A86EB0", Offset = "0x2A860B0", VA = "0x182A86EB0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x2A86F30", Offset = "0x2A86130", VA = "0x182A86F30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x2A86A40", Offset = "0x2A85C40", VA = "0x182A86A40")]
	public JobHandle AACGNADPMDC(JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public MBEMEDEEACC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class JLHLCMFDKOO : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x20001DC")]
	[BurstCompile]
	private struct OEBJJHJLCKD : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		[ReadOnly]
		public ComponentTypeHandle<KHKFGBALMEN> EMBMCNKFOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public ComponentTypeHandle<NMNIMNAKHFI> ECDGIGKOPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public uint LDIKCCIHMGG;

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x2224960", Offset = "0x2223B60", VA = "0x182224960", Slot = "4")]
		public void Execute(ArchetypeChunk PEHGOEJDGEP, int NNAODBDJDNJ, int ADEAHANFGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x22248D0", Offset = "0x2223AD0", VA = "0x1822248D0")]
		public bool COAGMNJHOFB(ArchetypeChunk PEHGOEJDGEP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private EntityQuery FAKFOFLBGIH;

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x25B6F10", Offset = "0x25B6110", VA = "0x1825B6F10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x25B7040", Offset = "0x25B6240", VA = "0x1825B7040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public JLHLCMFDKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
[ExecuteAlways]
public class PMJDKHDHGJC : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
	public PMJDKHDHGJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct OCIJEOIMNEM<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private NMBGDHMMLIG<T> KBIJDJHCEBH;

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D010", Offset = "0x2D9C210", VA = "0x182D9D010")]
	public OCIJEOIMNEM(NMBGDHMMLIG<T> KBIJDJHCEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CB90", Offset = "0x2D9BD90", VA = "0x182D9CB90")]
	public NLFEFIAHPPB<T> NPDGCPMNFLO()
	{
		return default(NLFEFIAHPPB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[DDDGJOKMEDO(typeof(ONBMCFIKOHO), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
public class ONBMCFIKOHO : DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	[MOHONECELPE]
	private LFBNOCAADDA EFGGIEHCPKE;

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D250", Offset = "0x2A9C450", VA = "0x182A9D250", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public ONBMCFIKOHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class JJOFPMHPLEP : CMMFKLLOOOK<PGBILDHAAAA>
{
	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x25B6CB0", Offset = "0x25B5EB0", VA = "0x1825B6CB0", Slot = "14")]
	protected override void AOFBFAGNEAO(NativeArray<Entity> IBGFBPGPJKP, NativeArray<Entity> LOAABKDHPBH, NativeArray<Entity> NCGMPIHPALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0x25B6E00", Offset = "0x25B6000", VA = "0x1825B6E00")]
	private static void AOFBFAGNEAO(NativeArray<Entity> IBGFBPGPJKP, NativeArray<Entity> NCGMPIHPALB, ComponentDataFromEntity<global::NKBEDDLCDIC> PLBAOOGECGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x25B6ED0", Offset = "0x25B60D0", VA = "0x1825B6ED0")]
	public JJOFPMHPLEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class LFCECNGPFLI : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x2A803A0", Offset = "0x2A7F5A0", VA = "0x182A803A0", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public LFCECNGPFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
public abstract class NPEEKLCCBNJ : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private MGGGBEIHFIJ KMCFNHCIMAG;

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A860", Offset = "0x2A99A60", VA = "0x182A9A860", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A8C0", Offset = "0x2A99AC0", VA = "0x182A9A8C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A8F0", Offset = "0x2A99AF0", VA = "0x182A9A8F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	protected NPEEKLCCBNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
public static class IKAMAJNCMEN
{
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] KMCFABCOJOI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001E4")]
internal struct LDOLNFEOBHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001E5")]
internal struct MHHBLPOFGKA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class GDHOEHNIFNK : AFFEALIJNOO
{
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private static PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private EntityQuery BFDCJNAAEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private EntityQuery GLHCPPIEBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	private EntityQuery KLJHBDCCPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	private EntityQuery GIPLBJNGDFH;

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x27CDFF0", Offset = "0x27CD1F0", VA = "0x1827CDFF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x27CE1B0", Offset = "0x27CD3B0", VA = "0x1827CE1B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x27CDE30", Offset = "0x27CD030", VA = "0x1827CDE30")]
	private void GAHKFFFMMGL(EntityQuery JIAIANFJBDB, bool LHACNDMACAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x27CDC70", Offset = "0x27CCE70", VA = "0x1827CDC70")]
	private void EOGHLDJNLGK(EntityQuery JIAIANFJBDB, bool LHACNDMACAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public GDHOEHNIFNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
internal class HHIAKPDLHHO : IAFEDJPGFJM
{
	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	protected override ABAPOMGFJBP DHOHAFONONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0x25A73C0", Offset = "0x25A65C0", VA = "0x1825A73C0", Slot = "15")]
		get
		{
			return default(ABAPOMGFJBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x25A7440", Offset = "0x25A6640", VA = "0x1825A7440")]
	public HHIAKPDLHHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[DefaultMember("Item")]
public struct OCIPEIPIJCB<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	public NativeList<Entity> IBGFBPGPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	public NativeList<T> JFGIPFOFKHL;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public int CKAIEHNDOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x2D9DD40", Offset = "0x2D9CF40", VA = "0x182D9DD40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public (Entity entity, T value) JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x2D9E410", Offset = "0x2D9D610", VA = "0x182D9E410")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D210", Offset = "0x2D9C410", VA = "0x182D9D210")]
	public void CKPKOIJGHLD(Entity BLNICJMKCEF, T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D780", Offset = "0x2D9C980", VA = "0x182D9D780")]
	public void HAIOOILOIBG(NativeArray<Entity> BLNICJMKCEF, NativeArray<T> NABCGCEIEGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[OLMIFJOAIBG]
public class JLKPDDHOHDB : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private static readonly PEKDFCFCENH MDKPEMHPMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	[MOHONECELPE]
	private MHGCAFFKDBL CJBOPCIHIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private EntityQuery FGONEBPBGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private EntityQuery KBODDKLBACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x25B73C0", Offset = "0x25B65C0", VA = "0x1825B73C0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x25B7310", Offset = "0x25B6510", VA = "0x1825B7310")]
	public bool IDNBLOOBINI(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x25B7720", Offset = "0x25B6920", VA = "0x1825B7720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x25B7180", Offset = "0x25B6380", VA = "0x1825B7180", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0xB80B80", Offset = "0xB7FD80", VA = "0x180B80B80", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x25B7800", Offset = "0x25B6A00", VA = "0x1825B7800", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x25B7180", Offset = "0x25B6380", VA = "0x1825B7180")]
	private void EHFLJENNKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x25B7410", Offset = "0x25B6610", VA = "0x1825B7410")]
	private void MILDFCBNLBC(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x25B71A0", Offset = "0x25B63A0", VA = "0x1825B71A0")]
	private void IDCNLDGBEIB(NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public JLKPDDHOHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EA")]
public struct LBOEPCMIIHK<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private OCIPEIPIJCB<T> KBIJDJHCEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private EntityCommandBuffer HEDKIIMNAJF;

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x15C4710", Offset = "0x15C3910", VA = "0x1815C4710")]
	public LBOEPCMIIHK(OCIPEIPIJCB<T> KBIJDJHCEBH, EntityCommandBuffer HEDKIIMNAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x15C42F0", Offset = "0x15C34F0", VA = "0x1815C42F0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x15C46F0", Offset = "0x15C38F0", VA = "0x1815C46F0")]
	public static OCIPEIPIJCB<T> OMHOCPNBHHH(LBOEPCMIIHK<T> DGJKEMKCNIO)
	{
		return default(OCIPEIPIJCB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public static class NOPPEOAIKIC
{
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	internal static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x26EECD0", Offset = "0x26EDED0", VA = "0x1826EECD0")]
	public static void FGNOPHJIAHN<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(POCHLGNFBCE DAJKBHKJPOA, CPFKEJJKDHF<Entity> LPNKBGEMCBF, out BLMHHHAEPPE<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> AEAAOAENKCO) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, GBELNJMIIOO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, GBELNJMIIOO, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x2A9A780", Offset = "0x2A99980", VA = "0x182A9A780")]
	public static bool EDPNEAMLDMF(OCHPAAEIANL NLBPABLMMCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EC")]
public class BLMHHHAEPPE<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, GBELNJMIIOO where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, GBELNJMIIOO, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private readonly MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000647")]
	private readonly LGOHODJFODN<Entity> BGOCDAGKFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000648")]
	private readonly EFIGCPCEPCG LHFJKKLCJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	private readonly GHANKHPHMBP OJEMCPHOKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private readonly EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private readonly MODEADMIGAP EKPKHDPLAGE;

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x2E5F1F0", Offset = "0x2E5E3F0", VA = "0x182E5F1F0")]
	public BLMHHHAEPPE(POCHLGNFBCE DAJKBHKJPOA, CPFKEJJKDHF<Entity> LPNKBGEMCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x2E5EFC0", Offset = "0x2E5E1C0", VA = "0x182E5EFC0")]
	private bool KGPIIDPFBGK(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x2E5EE40", Offset = "0x2E5E040", VA = "0x182E5EE40")]
	private bool IAOMBPPFDPO(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x2E5EF00", Offset = "0x2E5E100", VA = "0x182E5EF00")]
	private bool IGIGPLJODED(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x2E5F080", Offset = "0x2E5E280", VA = "0x182E5F080")]
	public bool LKLFJDNGDMK(Entity BLNICJMKCEF, in Entity PCCOHMIFFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E9B0", Offset = "0x2E5DBB0", VA = "0x182E5E9B0")]
	public bool GMCGJCBIDBA(Entity BLNICJMKCEF, in Entity PCCOHMIFFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B02")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E9E0", Offset = "0x2E5DBE0", VA = "0x182E5E9E0")]
	private bool GMCGJCBIDBA(Entity BLNICJMKCEF, in Entity PCCOHMIFFHJ, bool EOINLLJKNKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B03")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void MAJKPEKBKBL(Entity BLNICJMKCEF, in Entity PCCOHMIFFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void NMFOIGCGIKJ(Entity BLNICJMKCEF, in Entity PCCOHMIFFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void ELCOPNPNOIA(Entity BLNICJMKCEF, in Entity PCCOHMIFFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void OBJPGHACKFI(Entity BLNICJMKCEF, in Entity PCCOHMIFFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private static void KLCJGFDOJJK(Entity BLNICJMKCEF, in Entity PCCOHMIFFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E8D0", Offset = "0x2E5DAD0", VA = "0x182E5E8D0")]
	private bool FGHHNJKOBON(Entity BLNICJMKCEF, Entity FMMAMOIMPOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DC60", Offset = "0x2E5CE60", VA = "0x182E5DC60")]
	private void AKAIGHOCGDB(Entity BLNICJMKCEF, in Entity IFMGHGFKKAF, in Entity PCCOHMIFFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E270", Offset = "0x2E5D470", VA = "0x182E5E270")]
	private void CPEAJDNEGHF(Entity BLNICJMKCEF, in Entity IFMGHGFKKAF, in Entity PCCOHMIFFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DE70", Offset = "0x2E5D070", VA = "0x182E5DE70")]
	private bool CLIOJLAHHAE(KDHIEDDFGEM KPMBDOJKLKM, in NACALKPEILN DABMLPHNFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E5B0", Offset = "0x2E5D7B0", VA = "0x182E5E5B0")]
	private void EOEHEOKPEGA(Entity OJEMCPHOKBP, Entity PPANDIPJOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DDE0", Offset = "0x2E5CFE0", VA = "0x182E5DDE0")]
	private void BIBGAGBKMNG(Entity OJEMCPHOKBP, Entity PPANDIPJOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private void LPIKNGBKPND(Entity BLNICJMKCEF, Entity IFMGHGFKKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	private void KDAAOOMOMMC(Entity BLNICJMKCEF, Entity PCCOHMIFFHJ)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001ED")]
	[CompilerGenerated]
	public class GatherModifiedParents : KNNEOPGGIBD, PJIPLCPBFIL
	{
		[Cpp2IlInjected.Token(Token = "0x20001EE")]
		[NoAlias]
		[BurstCompile]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public NativeList<PPIJPPICKFO> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			[ReadOnly]
			public ComponentTypeHandle<BGFGOLHGEPN> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B18")]
			[Cpp2IlInjected.Address(RVA = "0x221FD40", Offset = "0x221EF40", VA = "0x18221FD40")]
			private void CHEGCCDBFJM(Entity entity, [NoAlias] in BGFGOLHGEPN current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B19")]
			[Cpp2IlInjected.Address(RVA = "0x221FDC0", Offset = "0x221EFC0", VA = "0x18221FDC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001EF")]
		[NoAlias]
		[BurstCompile]
		private struct GatherModifiedParents_AddChangedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			public NativeList<FCIJDIMNMDP> changedParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			[ReadOnly]
			public ComponentTypeHandle<BGFGOLHGEPN> __currentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000658")]
			[ReadOnly]
			public ComponentTypeHandle<LIFFAKCHIOD> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x221FAE0", Offset = "0x221ECE0", VA = "0x18221FAE0")]
			private void CHEGCCDBFJM(Entity entity, [NoAlias] in BGFGOLHGEPN current, [NoAlias] in LIFFAKCHIOD previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B1B")]
			[Cpp2IlInjected.Address(RVA = "0x221FBA0", Offset = "0x221EDA0", VA = "0x18221FBA0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001F0")]
		[BurstCompile]
		[NoAlias]
		private struct GatherModifiedParents_AddRemovedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000659")]
			public NativeList<PPIJPPICKFO> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400065B")]
			[ReadOnly]
			public ComponentTypeHandle<LIFFAKCHIOD> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B1C")]
			[Cpp2IlInjected.Address(RVA = "0x221FEE0", Offset = "0x221F0E0", VA = "0x18221FEE0")]
			private void CHEGCCDBFJM(Entity entity, [NoAlias] in LIFFAKCHIOD previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B1D")]
			[Cpp2IlInjected.Address(RVA = "0x221FF60", Offset = "0x221F160", VA = "0x18221FF60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private MODEADMIGAP parentEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private EntityQuery GatherModifiedParents_AddNewParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private EntityQuery GatherModifiedParents_AddChangedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private EntityQuery GatherModifiedParents_AddRemovedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private ComponentTypeHandle<BGFGOLHGEPN> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private ComponentTypeHandle<LIFFAKCHIOD> __RecRoom_Components_PreviousParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x27D2380", Offset = "0x27D1580", VA = "0x1827D2380", Slot = "14")]
		public void MIJKNKHBLCE(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x27D2AF0", Offset = "0x27D1CF0", VA = "0x1827D2AF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x27D2E80", Offset = "0x27D2080", VA = "0x1827D2E80")]
		private JobHandle PBBCJOJEJKO(NativeList<PPIJPPICKFO> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x27D2210", Offset = "0x27D1410", VA = "0x1827D2210")]
		private JobHandle EJHHJJPGBBE(NativeList<FCIJDIMNMDP> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x27D20E0", Offset = "0x27D12E0", VA = "0x1827D20E0")]
		private JobHandle CCJGNHCLIDI(NativeList<PPIJPPICKFO> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x27D2460", Offset = "0x27D1660", VA = "0x1827D2460", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public GatherModifiedParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F1")]
[UpdateBefore(typeof(AHDNCFNIEKI))]
public class GFEKFLINPBD : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private JGPGIDINFEG NJFMCLNALDN;

	[Cpp2IlInjected.Token(Token = "0x6000B1E")]
	[Cpp2IlInjected.Address(RVA = "0x27CED20", Offset = "0x27CDF20", VA = "0x1827CED20", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1F")]
	[Cpp2IlInjected.Address(RVA = "0x27CED70", Offset = "0x27CDF70", VA = "0x1827CED70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B20")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public GFEKFLINPBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F2")]
[DDDGJOKMEDO(typeof(LBGBICCEAMB), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal class LBGBICCEAMB : ADLMCGEFLCG, DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001F4")]
	[CompilerGenerated]
	private sealed class DGKBCOMLBIB : IEnumerable<(EKGFPCGJLIK, IANCKMHPHEB)>, IEnumerable, IEnumerator<(EKGFPCGJLIK, IANCKMHPHEB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private (EKGFPCGJLIK primitiveType, IANCKMHPHEB prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public LBGBICCEAMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private int <i>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private EKGFPCGJLIK <primitiveType>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private IANCKMHPHEB <prefabType>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		private (EKGFPCGJLIK, IANCKMHPHEB) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3F")]
			[Cpp2IlInjected.Address(RVA = "0x221B6C0", Offset = "0x221A8C0", VA = "0x18221B6C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((EKGFPCGJLIK, IANCKMHPHEB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B41")]
			[Cpp2IlInjected.Address(RVA = "0x221B710", Offset = "0x221A910", VA = "0x18221B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x221B760", Offset = "0x221A960", VA = "0x18221B760")]
		[DebuggerHidden]
		public DGKBCOMLBIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x221B540", Offset = "0x221A740", VA = "0x18221B540", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x221B6D0", Offset = "0x221A8D0", VA = "0x18221B6D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x221B620", Offset = "0x221A820", VA = "0x18221B620", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(EKGFPCGJLIK, IANCKMHPHEB)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x221B620", Offset = "0x221A820", VA = "0x18221B620", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private World OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private NativeParallelHashMap<int, Entity> MKADFFOHHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	private NativeParallelHashMap<int, EntityArchetype> AMGGPMBBAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private NativeParallelHashMap<int, int> JHGPJIMHKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private IANCKMHPHEB[] MBFFOEIOABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private readonly Dictionary<EKGFPCGJLIK, IANCKMHPHEB> BFKKCENMDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private readonly Dictionary<LNPONMIIMBL, IANCKMHPHEB> PNKMHJMILLO;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x25C2DD0", Offset = "0x25C1FD0", VA = "0x1825C2DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x126DBD0", Offset = "0x126CDD0", VA = "0x18126DBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B25")]
	[Cpp2IlInjected.Address(RVA = "0x25C2200", Offset = "0x25C1400", VA = "0x1825C2200", Slot = "5")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B26")]
	[Cpp2IlInjected.Address(RVA = "0x25C1810", Offset = "0x25C0A10", VA = "0x1825C1810", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B27")]
	[Cpp2IlInjected.Address(RVA = "0x99B860", Offset = "0x99AA60", VA = "0x18099B860")]
	internal NativeParallelHashMap<int, Entity> EMNEIFAICOP()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B28")]
	[Cpp2IlInjected.Address(RVA = "0xD0D200", Offset = "0xD0C400", VA = "0x180D0D200")]
	internal NativeParallelHashMap<int, EntityArchetype> KEJGJLMMOEJ()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B29")]
	[Cpp2IlInjected.Address(RVA = "0x99B880", Offset = "0x99AA80", VA = "0x18099B880")]
	internal NativeParallelHashMap<int, int> NJPFMBOHKBA()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2A")]
	[Cpp2IlInjected.Address(RVA = "0x25C1C40", Offset = "0x25C0E40", VA = "0x1825C1C40")]
	internal IEnumerable<Type> GNKONIJFDOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2B")]
	[Cpp2IlInjected.Address(RVA = "0x25C1BD0", Offset = "0x25C0DD0", VA = "0x1825C1BD0")]
	internal GDCDLFBODIJ FEFGJPHODAE(Type FBNKHAJKFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2C")]
	[Cpp2IlInjected.Address(RVA = "0x25C2CF0", Offset = "0x25C1EF0", VA = "0x1825C2CF0")]
	public EntityArchetype JALBINOAAPO(IANCKMHPHEB GLKDKMADKLI)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2D")]
	[Cpp2IlInjected.Address(RVA = "0x25C2D60", Offset = "0x25C1F60", VA = "0x1825C2D60", Slot = "4")]
	[IteratorStateMachine(typeof(DGKBCOMLBIB))]
	public IEnumerable<(EKGFPCGJLIK, IANCKMHPHEB)> JIOAIEDNHFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2E")]
	[Cpp2IlInjected.Address(RVA = "0x25C2E70", Offset = "0x25C2070", VA = "0x1825C2E70")]
	public Entity OGHNPGAIFHF(IANCKMHPHEB GLKDKMADKLI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2F")]
	[Cpp2IlInjected.Address(RVA = "0x25C1CA0", Offset = "0x25C0EA0", VA = "0x1825C1CA0")]
	public void HFPIGANCDJB(NativeArray<IANCKMHPHEB> MBFFOEIOABB, NativeArray<Entity> DJNNIABCGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B30")]
	[Cpp2IlInjected.Address(RVA = "0x25C1B80", Offset = "0x25C0D80", VA = "0x1825C1B80")]
	public void EGHNJMNHOEL(IANCKMHPHEB GLKDKMADKLI, NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B31")]
	[Cpp2IlInjected.Address(RVA = "0x25C2E10", Offset = "0x25C2010", VA = "0x1825C2E10")]
	public IANCKMHPHEB NFFGGPDBEPF(EKGFPCGJLIK FBNKHAJKFLM)
	{
		return default(IANCKMHPHEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B32")]
	[Cpp2IlInjected.Address(RVA = "0x25C2120", Offset = "0x25C1320", VA = "0x1825C2120")]
	public Entity IPCEOHNANAC(IANCKMHPHEB GLKDKMADKLI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B33")]
	[Cpp2IlInjected.Address(RVA = "0x25C1E20", Offset = "0x25C1020", VA = "0x1825C1E20")]
	private void ICHMNHBHFAH(GDCDLFBODIJ FDJGPDJCFHA, NativeList<int> MBFFOEIOABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B34")]
	[Cpp2IlInjected.Address(RVA = "0x25C1370", Offset = "0x25C0570", VA = "0x1825C1370")]
	internal void AJFJIBADFFL(IANCKMHPHEB GLKDKMADKLI, ComponentTypeList APJOFAMJHAH, BIGKDEKAMGP OCDILIEJPLL, GDCDLFBODIJ FDJGPDJCFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B35")]
	[Cpp2IlInjected.Address(RVA = "0x25C16A0", Offset = "0x25C08A0", VA = "0x1825C16A0")]
	private EntityArchetype DJHKODGCAFK(IANCKMHPHEB GLKDKMADKLI, ComponentTypeList KJOIBOGAONC)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B36")]
	[Cpp2IlInjected.Address(RVA = "0x25C2FF0", Offset = "0x25C21F0", VA = "0x1825C2FF0")]
	public LBGBICCEAMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F5")]
[DDDGJOKMEDO(typeof(HKGANBMDICA), new string[] { })]
public class LLJHGPPMMDC : DCLDDNDKGBL, HKGANBMDICA
{
	[Cpp2IlInjected.Token(Token = "0x20001F6")]
	[CompilerGenerated]
	private sealed class BDHNNBPCOMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public IBOPAMBBGDD objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public BMDJOHDFBDL parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public LLJHGPPMMDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private OCHPAAEIANL <parentObject>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private Vector3 <pos>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private Quaternion <rot>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public BDHNNBPCOMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2216FF0", Offset = "0x22161F0", VA = "0x182216FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001F7")]
	[CompilerGenerated]
	private sealed class DJGLKOGDLEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public OCHPAAEIANL obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public LLJHGPPMMDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DJGLKOGDLEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x221B9E0", Offset = "0x221ABE0", VA = "0x18221B9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	[MOHONECELPE]
	private DKEFNOMEIGJ LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.Token(Token = "0x6000B44")]
	[Cpp2IlInjected.Address(RVA = "0x2A85B20", Offset = "0x2A84D20", VA = "0x182A85B20", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B45")]
	[Cpp2IlInjected.Address(RVA = "0x2A84DF0", Offset = "0x2A83FF0", VA = "0x182A84DF0", Slot = "5")]
	public bool BKLJBAOLMEH(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B46")]
	[Cpp2IlInjected.Address(RVA = "0x2A85BC0", Offset = "0x2A84DC0", VA = "0x182A85BC0", Slot = "7")]
	public bool KJICLCGOGDA(BMDJOHDFBDL JHJPAJMEGAG, out Guid MKJGAIOAKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B47")]
	[Cpp2IlInjected.Address(RVA = "0x2A84CA0", Offset = "0x2A83EA0", VA = "0x182A84CA0", Slot = "8")]
	public Guid ANNAFJLDFLG(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B48")]
	[Cpp2IlInjected.Address(RVA = "0x2A84F20", Offset = "0x2A84120", VA = "0x182A84F20", Slot = "9")]
	public void CKKFNDIKEIA(BMDJOHDFBDL JHJPAJMEGAG, Guid MKJGAIOAKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B49")]
	[Cpp2IlInjected.Address(RVA = "0x2A854A0", Offset = "0x2A846A0", VA = "0x182A854A0", Slot = "10")]
	public bool FKDIKHEBIJB(BMDJOHDFBDL JHJPAJMEGAG, out Guid ICCMHBOIOOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4A")]
	[Cpp2IlInjected.Address(RVA = "0x2A84B50", Offset = "0x2A83D50", VA = "0x182A84B50", Slot = "11")]
	public Guid AMOJHEKNAHA(BMDJOHDFBDL JHJPAJMEGAG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4B")]
	[Cpp2IlInjected.Address(RVA = "0x2A86130", Offset = "0x2A85330", VA = "0x182A86130", Slot = "12")]
	public void PDKOCIGBIGH(BMDJOHDFBDL JHJPAJMEGAG, Guid ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4C")]
	[Cpp2IlInjected.Address(RVA = "0x2A859E0", Offset = "0x2A84BE0", VA = "0x182A859E0", Slot = "13")]
	public void HLMACHCJLFO(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4D")]
	[Cpp2IlInjected.Address(RVA = "0x2A855C0", Offset = "0x2A847C0", VA = "0x182A855C0", Slot = "14")]
	public void HBMLGEMFOCG(BMDJOHDFBDL BJPEGONLJEK, BMDJOHDFBDL OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4E")]
	[Cpp2IlInjected.Address(RVA = "0x2A85CE0", Offset = "0x2A84EE0", VA = "0x182A85CE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BDHNNBPCOMA))]
	private Task KPHOFCBCNAK(IBOPAMBBGDD MJOPFBOKDPF, BMDJOHDFBDL OJEMCPHOKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x2A85FB0", Offset = "0x2A851B0", VA = "0x182A85FB0")]
	private void MNAPLODLLCG(IBOPAMBBGDD MJOPFBOKDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x2A85E60", Offset = "0x2A85060", VA = "0x182A85E60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DJGLKOGDLEJ))]
	private Task LKLEIOMKMGP(OCHPAAEIANL PPNJOAJJOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x2A85210", Offset = "0x2A84410", VA = "0x182A85210")]
	private Task FEOMDMIPCEG(OCHPAAEIANL PPNJOAJJOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B52")]
	[Cpp2IlInjected.Address(RVA = "0x2A85A90", Offset = "0x2A84C90", VA = "0x182A85A90", Slot = "6")]
	public bool IOAJOBJCEBC(BMDJOHDFBDL KHBBAOCDKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B53")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public LLJHGPPMMDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F8")]
internal class BCDGOAMCPAL : NEOFDAGELGL
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001F9")]
	public struct JKIFFGEJICF : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	protected override ComponentType AGMPKCPBLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2627000", Offset = "0x2626200", VA = "0x182627000", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	protected override ComponentType IADFPMAIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2626FD0", Offset = "0x26261D0", VA = "0x182626FD0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	protected override ComponentType PNDMHBPIHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2627030", Offset = "0x2626230", VA = "0x182627030", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5B")]
	[Cpp2IlInjected.Address(RVA = "0x26270F0", Offset = "0x26262F0", VA = "0x1826270F0")]
	public BCDGOAMCPAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FA")]
internal abstract class CMMFKLLOOOK<TPlayerTag> : KNNEOPGGIBD where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private EntityQuery DJACLBNAKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private EntityQuery OHEDJBMIPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private EntityQuery JPHMMPLCANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private EntityQuery AEOHODBGGNE;

	[Cpp2IlInjected.Token(Token = "0x6000B60")]
	[Cpp2IlInjected.Address(RVA = "0x26B33F0", Offset = "0x26B25F0", VA = "0x1826B33F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B61")]
	[Cpp2IlInjected.Address(RVA = "0x26B35F0", Offset = "0x26B27F0", VA = "0x1826B35F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B62")]
	[Cpp2IlInjected.Address(RVA = "0x26B35C0", Offset = "0x26B27C0", VA = "0x1826B35C0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B63")]
	[Cpp2IlInjected.Address(RVA = "0x26B2A60", Offset = "0x26B1C60", VA = "0x1826B2A60")]
	private void OIABCCODAEA(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B64")]
	[Cpp2IlInjected.Address(RVA = "0x26B26B0", Offset = "0x26B18B0", VA = "0x1826B26B0")]
	private void KJPOIOEAKDM(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B65")]
	[Cpp2IlInjected.Address(RVA = "0x26B1F10", Offset = "0x26B1110", VA = "0x1826B1F10")]
	private void DBDGMJDBKJE(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B66")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void AOFBFAGNEAO(NativeArray<Entity> IBGFBPGPJKP, NativeArray<Entity> LOAABKDHPBH, NativeArray<Entity> NCGMPIHPALB);

	[Cpp2IlInjected.Token(Token = "0x6000B67")]
	[Cpp2IlInjected.Address(RVA = "0x21DD000", Offset = "0x21DC200", VA = "0x1821DD000")]
	protected CMMFKLLOOOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FB")]
[AlwaysUpdateSystem]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class GKMCFGGNPLL : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	[MOHONECELPE]
	private JCKOIKCNGOK JMKJGIHBADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	[MOHONECELPE]
	private BDHDJNEMBDK CKGAHLICKCB;

	[Cpp2IlInjected.Token(Token = "0x6000B68")]
	[Cpp2IlInjected.Address(RVA = "0x27D0760", Offset = "0x27CF960", VA = "0x1827D0760", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B69")]
	[Cpp2IlInjected.Address(RVA = "0x27D06E0", Offset = "0x27CF8E0", VA = "0x1827D06E0")]
	protected void BFLPBONLKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x27D07F0", Offset = "0x27CF9F0", VA = "0x1827D07F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public GKMCFGGNPLL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001FC")]
public struct LBPCEJEKJFL : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	public static readonly LBPCEJEKJFL NBIAOCJLGIM;

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FA90", Offset = "0x2A7EC90", VA = "0x182A7FA90", Slot = "4")]
	public bool Equals(LinkedEntityGroup JPBGAMDOIJA, LinkedEntityGroup IIJHAMIHIMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FAB0", Offset = "0x2A7ECB0", VA = "0x182A7FAB0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup PPNJOAJJOFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FD")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class CGBBDHOEEMN : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	private BEDIIKOKEPM DFHCKKOLOHN;

	[Cpp2IlInjected.Token(Token = "0x6000B6F")]
	[Cpp2IlInjected.Address(RVA = "0x262B300", Offset = "0x262A500", VA = "0x18262B300", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B70")]
	[Cpp2IlInjected.Address(RVA = "0x262B350", Offset = "0x262A550", VA = "0x18262B350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B71")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public CGBBDHOEEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FE")]
internal abstract class HCCDJHNELLM : DKOPOEOBCPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private EntityQuery LDHJBKLMIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	private EntityQuery INFNOOJLLIJ;

	[Cpp2IlInjected.Token(Token = "0x6000B72")]
	[Cpp2IlInjected.Address(RVA = "0x27D3A40", Offset = "0x27D2C40", VA = "0x1827D3A40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x27D3DC0", Offset = "0x27D2FC0", VA = "0x1827D3DC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B74")]
	[Cpp2IlInjected.Address(RVA = "0x27D3990", Offset = "0x27D2B90", VA = "0x1827D3990")]
	private void FBLPHOAMODP(EntityQuery JIAIANFJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B75")]
	[Cpp2IlInjected.Address(RVA = "0x27D3E70", Offset = "0x27D3070", VA = "0x1827D3E70")]
	protected HCCDJHNELLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000200")]
public class DPOFNCAGJCL : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public DPOFNCAGJCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000201")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class EIHPHJOHKDP : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private BCLIKNODFFN HIONPLEGOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private BEEILEEPNEP BNMBMDEENEH;

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x27BDDC0", Offset = "0x27BCFC0", VA = "0x1827BDDC0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x27BDE50", Offset = "0x27BD050", VA = "0x1827BDE50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public EIHPHJOHKDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000202")]
[DDDGJOKMEDO(typeof(CPECIHFFCAK), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal sealed class CPECIHFFCAK : DCLDDNDKGBL, PJIPLCPBFIL
{
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	[MOHONECELPE]
	private HNMHAJLPHMH AMPOACOBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private LGOHODJFODN<Entity> BGOCDAGKFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private BLMHHHAEPPE<BGFGOLHGEPN, LIFFAKCHIOD, KOBDKGMOAOL, JFFGLDLIPLN> DGMGGGFGHEK;

	[Cpp2IlInjected.Token(Token = "0x6000B7E")]
	[Cpp2IlInjected.Address(RVA = "0x2632270", Offset = "0x2631470", VA = "0x182632270", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7F")]
	[Cpp2IlInjected.Address(RVA = "0x2632320", Offset = "0x2631520", VA = "0x182632320", Slot = "5")]
	public void MIJKNKHBLCE(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x2632220", Offset = "0x2631420", VA = "0x182632220")]
	public Entity FOMIAGBPCIG(Entity BLNICJMKCEF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x26322C0", Offset = "0x26314C0", VA = "0x1826322C0")]
	public bool LKLFJDNGDMK(Entity BLNICJMKCEF, Entity PCCOHMIFFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x2631F50", Offset = "0x2631150", VA = "0x182631F50")]
	public bool BPMJPILKAOG(Entity BLNICJMKCEF, Entity PCCOHMIFFHJ, bool BJCOCCDMHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x2631FF0", Offset = "0x26311F0", VA = "0x182631FF0")]
	private bool FGPMOIDFPEF(Entity BLNICJMKCEF, Entity PCCOHMIFFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public CPECIHFFCAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000203")]
internal readonly struct MKKEMJAJOAP
{
	[Cpp2IlInjected.Token(Token = "0x2000204")]
	[BurstCompile]
	private struct BJLKJHAJLLE : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		[ReadOnly]
		public EntityTypeHandle GGOENCDLKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		[ReadOnly]
		public ComponentDataFromEntity<MICACMLIGKF> BOLAMBIIINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		[ReadOnly]
		public DynamicComponentTypeHandle EJGNONJONII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> JEJBJCOBGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> CHMCOEABLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		[ReadOnly]
		public ComponentDataFromEntity ENJHGIFELGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly CLFJDLFGBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		[ReadOnly]
		public NativeArray<JJDOOCODKMA>.ReadOnly EMAGGHNNCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public ComponentDataFromEntity EPALDICFFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public NativeList<Entity> CDOEKBOBHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public NativeList<Entity> NFEPJJOHJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public NativeList<byte> JMHOCJIOELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public NativeList<byte> IPDGHHFGCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public NativeList<byte> KGCIHIKJGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int LNKNEHIJKCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public int IAONMEHCAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public bool HFGFPCNDKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public BAIECHLHPEI.JLMACFODIIC KEDBGMBBPLF;

		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x2218D90", Offset = "0x2217F90", VA = "0x182218D90", Slot = "4")]
		public void Execute(ArchetypeChunk PEHGOEJDGEP, int NPCAADALBBC, int MHCLOCKEOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x2219100", Offset = "0x2218300", VA = "0x182219100")]
		private unsafe bool IIIHKMMCCGD(Entity CHANLKLFAPE, Entity AEHIKGDHCKG, byte* IBHPNFFBFBJ, byte* LCGBJJFODBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2218D70", Offset = "0x2217F70", VA = "0x182218D70")]
		private unsafe void DLOFCDEOECF(byte* IBHPNFFBFBJ, byte* LCGBJJFODBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x2218C90", Offset = "0x2217E90", VA = "0x182218C90")]
		private unsafe byte* CKPEOJBNJCI(NativeArray<byte> PJHCFMLIFLJ, int LHPGLCOPMKK)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x22193D0", Offset = "0x22185D0", VA = "0x1822193D0")]
		private unsafe byte* PGBCHJEFKOI(Entity AEHIKGDHCKG)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x22192D0", Offset = "0x22184D0", VA = "0x1822192D0")]
		private unsafe byte* LFHIFCIOHEJ(ArchetypeChunk PEHGOEJDGEP)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x2218D30", Offset = "0x2217F30", VA = "0x182218D30")]
		private static Entity DFNGDCHHIEM(in MICACMLIGKF JFGIPFOFKHL)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000205")]
	[BurstCompile]
	private struct CJEKLJHALEK : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		[ReadOnly]
		public NativeList<Entity> NHHDACLKFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		[ReadOnly]
		public NativeList<byte> NAFBFBFPKOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		[ReadOnly]
		public NativeList<byte> EGOHACHFNBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		[ReadOnly]
		public NativeList<byte> PJMCIMEONNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		[ReadOnly]
		public NativeArray<JJDOOCODKMA>.ReadOnly EMAGGHNNCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public NativeParallelMultiHashMap<Entity, GOECINKNCJI> FOIMKMMPBIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int LNKNEHIJKCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public int IAONMEHCAFB;

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x221A450", Offset = "0x2219650", VA = "0x18221A450", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private static readonly ProfilerMarker OBEGNKLMOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly KNNEOPGGIBD FMGKDHAODCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private readonly World DGIKFFNILOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private readonly KDJINJGKOPM EJNOCFMJPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private readonly NativeParallelHashMap<int, Entity> FHGAPCLFNFG;

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E840", Offset = "0x2A8DA40", VA = "0x182A8E840")]
	public MKKEMJAJOAP(KNNEOPGGIBD FMGKDHAODCH, World DGIKFFNILOO, BCLIKNODFFN IMHPCMMAFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x2A8DA30", Offset = "0x2A8CC30", VA = "0x182A8DA30")]
	public JobHandle KGILAIAHHCE(DCIJLGIBKEE NJGLKOBADEO, NativeList<(EntityQuery query, int typeIndex, int count, BAIECHLHPEI.JLMACFODIIC mode)> AOHLHGPBOHA, JobHandle FOFFIFNKDII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E110", Offset = "0x2A8D310", VA = "0x182A8E110")]
	private CJEKLJHALEK LOGODBFHJIA(in BJLKJHAJLLE AACGFFENBMK, NativeParallelMultiHashMap<Entity, GOECINKNCJI> JGBJDCJEDOM)
	{
		return default(CJEKLJHALEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B89")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E350", Offset = "0x2A8D550", VA = "0x182A8E350")]
	private BJLKJHAJLLE MINABEHMBPP(ComponentType PKEBPHKAGGB, EntityManager JLBCPDFEPMJ, int ALFEFLANFKP, BAIECHLHPEI.JLMACFODIIC KEDBGMBBPLF)
	{
		return default(BJLKJHAJLLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E180", Offset = "0x2A8D380", VA = "0x182A8E180")]
	private static void MCCLIMFOKOA(DCIJLGIBKEE NJGLKOBADEO, ComponentType PKEBPHKAGGB, JobHandle FHGDOMMIJLE, in BJLKJHAJLLE AACGFFENBMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000206")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class EPHJNBOMHFN : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private MLNEJMIMNEF AMPOACOBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private BEEILEEPNEP BNMBMDEENEH;

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x27C3490", Offset = "0x27C2690", VA = "0x1827C3490", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x27C3B90", Offset = "0x27C2D90", VA = "0x1827C3B90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x27C3C30", Offset = "0x27C2E30", VA = "0x1827C3C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B97")]
	[Cpp2IlInjected.Address(RVA = "0x27C3520", Offset = "0x27C2720", VA = "0x1827C3520")]
	private void NGJDMLOMHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B98")]
	[Cpp2IlInjected.Address(RVA = "0x27C2F00", Offset = "0x27C2100", VA = "0x1827C2F00")]
	private void EPDOMECFENH(NativeArray<Entity> JKLGMHCFNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x27C26C0", Offset = "0x27C18C0", VA = "0x1827C26C0")]
	private void EGKIHOGIIKF(NativeArray<Entity> IBGFBPGPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x27C2550", Offset = "0x27C1750", VA = "0x1827C2550")]
	private void DOOOLCCBMFP(NativeArray<Entity> OFNHBJAMLID, NativeArray<RigidTransform> IIGNJOBJMMD, NativeArray<RigidTransform> BKEFJACIFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x27C3010", Offset = "0x27C2210", VA = "0x1827C3010")]
	private void HOINJODGHAC(NativeArray<RigidTransform> BKEFJACIFGI, NativeArray<Entity> OFNHBJAMLID, NativeList<Entity> DIKJOOCALBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public EPHJNBOMHFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000207")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class CMOKLIGENFJ : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x2631B30", Offset = "0x2630D30", VA = "0x182631B30", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public CMOKLIGENFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
internal abstract class ILHFNJMEGEJ : IDOKENEHHKM, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private BCLIKNODFFN IMHPCMMAFGL;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	protected abstract LCOECJPMODN GCCLHHLKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x25B1A30", Offset = "0x25B0C30", VA = "0x1825B1A30", Slot = "16")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x25B1A80", Offset = "0x25B0C80", VA = "0x1825B1A80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x25B1620", Offset = "0x25B0820", VA = "0x1825B1620", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	protected ILHFNJMEGEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
public class MEPFKCHFKMJ : KNNEOPGGIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private FJMAADPHJAA FBICPICMEOC;

	[Cpp2IlInjected.Token(Token = "0x6000BA6")]
	[Cpp2IlInjected.Address(RVA = "0x2A87000", Offset = "0x2A86200", VA = "0x182A87000", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA7")]
	[Cpp2IlInjected.Address(RVA = "0x2A870D0", Offset = "0x2A862D0", VA = "0x182A870D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA8")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public MEPFKCHFKMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020A")]
[UpdateAfter(typeof(AHCHAACOCIC))]
public class CFDJLHAKDBN : KNNEOPGGIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	private EntityArchetype IEMKHCADMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x6000BA9")]
	[Cpp2IlInjected.Address(RVA = "0x262B0C0", Offset = "0x262A2C0", VA = "0x18262B0C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x262B1B0", Offset = "0x262A3B0", VA = "0x18262B1B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x262B070", Offset = "0x262A270", VA = "0x18262B070")]
	private EntityCommandBufferSystem IMLBAKBFEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAC")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public CFDJLHAKDBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020B")]
internal class OHODJJEPAHF : NEOFDAGELGL
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200020C")]
	public struct KGOEHCHHCHD : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	protected override ComponentType AGMPKCPBLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CAC0", Offset = "0x2A9BCC0", VA = "0x182A9CAC0", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	protected override ComponentType IADFPMAIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CA90", Offset = "0x2A9BC90", VA = "0x182A9CA90", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	protected override ComponentType PNDMHBPIHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CAF0", Offset = "0x2A9BCF0", VA = "0x182A9CAF0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAD")]
	[Cpp2IlInjected.Address(RVA = "0x2A9CBB0", Offset = "0x2A9BDB0", VA = "0x182A9CBB0")]
	public OHODJJEPAHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020D")]
[AlwaysUpdateSystem]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class EPEIHLDIAPE : KNNEOPGGIBD, DCLDDNDKGBL, PNKPNDDLHPG
{
	[Cpp2IlInjected.Token(Token = "0x200020E")]
	[CompilerGenerated]
	private sealed class PNOCNBBEFHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public BMDJOHDFBDL localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public BCCEBHKEABG collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public COFCBIMKLHI containerFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public bool physicsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public bool gravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public bool hasUnityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public EPEIHLDIAPE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PNOCNBBEFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x2225C30", Offset = "0x2224E30", VA = "0x182225C30")]
		internal void OBHHIFMCAFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x22259D0", Offset = "0x2224BD0", VA = "0x1822259D0")]
		internal void DJFOHCOEPDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2225AF0", Offset = "0x2224CF0", VA = "0x182225AF0")]
		internal void FMFBHBMAHCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	[MOHONECELPE]
	private BDHDJNEMBDK CKGAHLICKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	[MOHONECELPE]
	private EIKGLGIJAHC CLOALEEOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	[MOHONECELPE]
	private MKDGDMAKODP PPLNMLEIDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	public ComponentTypeHandle<COFCBIMKLHI> EEBPENPGJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	public ComponentTypeHandle<MHKJKOAIFPO> APMAFDEDAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	public ComponentTypeHandle<BHPCOGAHMLN> JMOMHENOGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	public ComponentTypeHandle<BDMAHJJMIAA> ECKOGEJCIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	public ComponentTypeHandle<DNALICBCDBG> EIONNDPNJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	public DynamicComponentTypeHandle NDABNFEOLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	public EntityTypeHandle LDKGPDMDLKI;

	[Cpp2IlInjected.Token(Token = "0x6000BB2")]
	[Cpp2IlInjected.Address(RVA = "0x27C0F00", Offset = "0x27C0100", VA = "0x1827C0F00", Slot = "15")]
	public void LCNCNPMDENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB3")]
	[Cpp2IlInjected.Address(RVA = "0x27C0E50", Offset = "0x27C0050", VA = "0x1827C0E50", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB4")]
	[Cpp2IlInjected.Address(RVA = "0x27C1190", Offset = "0x27C0390", VA = "0x1827C1190", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x27C0FC0", Offset = "0x27C01C0", VA = "0x1827C0FC0")]
	private void NPNNLIPPHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB6")]
	[Cpp2IlInjected.Address(RVA = "0x27C0B40", Offset = "0x27BFD40", VA = "0x1827C0B40")]
	private bool HNPAKDOOAKN(out int MMBCAIKPCOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB7")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public EPEIHLDIAPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020F")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public sealed class IEPANGKFIEE : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private CJCFNJEIKLC BOBEKOFDFLC;

	[Cpp2IlInjected.Token(Token = "0x6000BBD")]
	[Cpp2IlInjected.Address(RVA = "0x25B0120", Offset = "0x25AF320", VA = "0x1825B0120", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBE")]
	[Cpp2IlInjected.Address(RVA = "0x25B0180", Offset = "0x25AF380", VA = "0x1825B0180", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBF")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public IEPANGKFIEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000210")]
internal abstract class IAFEDJPGFJM : DKOPOEOBCPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x6000BC0")]
	[Cpp2IlInjected.Address(RVA = "0x25AA110", Offset = "0x25A9310", VA = "0x1825AA110", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC1")]
	[Cpp2IlInjected.Address(RVA = "0x25AA3F0", Offset = "0x25A95F0", VA = "0x1825AA3F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC2")]
	[Cpp2IlInjected.Address(RVA = "0x25A7440", Offset = "0x25A6640", VA = "0x1825A7440")]
	protected IAFEDJPGFJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000211")]
[AlwaysUpdateSystem]
public class BAIECHLHPEI : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x2000212")]
	public enum JLMACFODIIC
	{
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		Remove
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	[MOHONECELPE]
	private MMIPKKPAOLG JEAODICNNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	[MOHONECELPE]
	private BCLIKNODFFN IMHPCMMAFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private DJFKEPKGAHF FFODHJBNDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private LDIBMBNPDEL KJIFKJGADDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private MMJJLGIGKNK PHNKEGECADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private OIHEJNBHEGJ FFPAACALCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private MKKEMJAJOAP GJFGHLJHFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private DGIJLHOHCDF JILHJJFHAAC;

	[Cpp2IlInjected.Token(Token = "0x6000BC3")]
	[Cpp2IlInjected.Address(RVA = "0x2626810", Offset = "0x2625A10", VA = "0x182626810", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC4")]
	[Cpp2IlInjected.Address(RVA = "0x2626AB0", Offset = "0x2625CB0", VA = "0x182626AB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC5")]
	[Cpp2IlInjected.Address(RVA = "0x2626BA0", Offset = "0x2625DA0", VA = "0x182626BA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC6")]
	[Cpp2IlInjected.Address(RVA = "0x2626740", Offset = "0x2625940", VA = "0x182626740")]
	private void AJEFFFGFMAH(out NativeArray<NACALKPEILN> CJGGJGGNMNO, out NativeArray<DLGBACOGEKM> NBHGMLCGCLE, out NativeArray<NACALKPEILN> KPKKLHACPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC7")]
	[Cpp2IlInjected.Address(RVA = "0x2626B90", Offset = "0x2625D90", VA = "0x182626B90", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC8")]
	[Cpp2IlInjected.Address(RVA = "0x2626B20", Offset = "0x2625D20", VA = "0x182626B20", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC9")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public BAIECHLHPEI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000213")]
	[CompilerGenerated]
	[AKEFOBLNEPL(CCDGJKNFPNB.OMRoom)]
	public class PostLoadInitializeNetworkId : KNNEOPGGIBD, DCLDDNDKGBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000214")]
		[BurstCompile]
		[NoAlias]
		private struct PostLoadInitializeNetworkId_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x2000215")]
			public delegate void RunWithoutJobSystem_00000DDA$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000216")]
			internal static class RunWithoutJobSystem_00000DDA$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40006F7")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40006F8")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BE6")]
				[Cpp2IlInjected.Address(RVA = "0x609D530", Offset = "0x609C730", VA = "0x18609D530")]
				[BurstDiscard]
				private static void MBNJCHNMFGD(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BE7")]
				[Cpp2IlInjected.Address(RVA = "0x609D0A0", Offset = "0x609C2A0", VA = "0x18609D0A0")]
				private static IntPtr EECPEFMCGAC()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BE8")]
				[Cpp2IlInjected.Address(RVA = "0x609D230", Offset = "0x609C430", VA = "0x18609D230")]
				public static void GNEKIDIALPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BE9")]
				[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
				public static void KCEHONPEIFO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BEB")]
				[Cpp2IlInjected.Address(RVA = "0x609D2F0", Offset = "0x609C4F0", VA = "0x18609D2F0")]
				public static void LDFPBHJMNFE(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006F3")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006F4")]
			public NativeParallelHashMap<NACALKPEILN, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F5")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F6")]
			public ComponentTypeHandle<GODAIDEBOAI> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BDE")]
			[Cpp2IlInjected.Address(RVA = "0x609A050", Offset = "0x6099250", VA = "0x18609A050")]
			private void CHEGCCDBFJM(Entity entity, int entityInQueryIndex, [NoAlias] ref GODAIDEBOAI networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BDF")]
			[Cpp2IlInjected.Address(RVA = "0x609A150", Offset = "0x6099350", VA = "0x18609A150", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE0")]
			[Cpp2IlInjected.Address(RVA = "0x609A0E0", Offset = "0x60992E0", VA = "0x18609A0E0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void EIHJACMIDKF(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE1")]
			[Cpp2IlInjected.Address(RVA = "0x609A290", Offset = "0x6099490", VA = "0x18609A290")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void LFPBDECHIIM(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000217")]
		[BurstCompile]
		[NoAlias]
		private struct PostLoadInitializeNetworkId_LambdaJob_1_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x2000218")]
			public delegate void RunWithoutJobSystem_00000DDD$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000219")]
			internal static class RunWithoutJobSystem_00000DDD$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000700")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000701")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BF4")]
				[Cpp2IlInjected.Address(RVA = "0x609DD90", Offset = "0x609CF90", VA = "0x18609DD90")]
				[BurstDiscard]
				private static void MBNJCHNMFGD(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BF5")]
				[Cpp2IlInjected.Address(RVA = "0x609D900", Offset = "0x609CB00", VA = "0x18609D900")]
				private static IntPtr EECPEFMCGAC()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BF6")]
				[Cpp2IlInjected.Address(RVA = "0x609DA90", Offset = "0x609CC90", VA = "0x18609DA90")]
				public static void GNEKIDIALPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BF7")]
				[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
				public static void KCEHONPEIFO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BF9")]
				[Cpp2IlInjected.Address(RVA = "0x609DB50", Offset = "0x609CD50", VA = "0x18609DB50")]
				public static void LDFPBHJMNFE(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public NativeParallelHashMap<NACALKPEILN, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public uint playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			public uint offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			public ComponentTypeHandle<GODAIDEBOAI> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x609A310", Offset = "0x6099510", VA = "0x18609A310")]
			private void CHEGCCDBFJM(Entity entity, int entityInQueryIndex, [NoAlias] ref GODAIDEBOAI dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BED")]
			[Cpp2IlInjected.Address(RVA = "0x609A410", Offset = "0x6099610", VA = "0x18609A410", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BEE")]
			[Cpp2IlInjected.Address(RVA = "0x609A3A0", Offset = "0x60995A0", VA = "0x18609A3A0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void EIHJACMIDKF(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BEF")]
			[Cpp2IlInjected.Address(RVA = "0x609A550", Offset = "0x6099750", VA = "0x18609A550")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void LFPBDECHIIM(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200021A")]
		[BurstCompile]
		[NoAlias]
		private struct PostLoadInitializeNetworkId_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.Token(Token = "0x200021B")]
			public delegate void RunWithoutJobSystem_00000DE0$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x200021C")]
			internal static class RunWithoutJobSystem_00000DE0$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000708")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000709")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000C02")]
				[Cpp2IlInjected.Address(RVA = "0x609E410", Offset = "0x609D610", VA = "0x18609E410")]
				[BurstDiscard]
				private static void MBNJCHNMFGD(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C03")]
				[Cpp2IlInjected.Address(RVA = "0x609DF80", Offset = "0x609D180", VA = "0x18609DF80")]
				private static IntPtr EECPEFMCGAC()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000C04")]
				[Cpp2IlInjected.Address(RVA = "0x609E110", Offset = "0x609D310", VA = "0x18609E110")]
				public static void GNEKIDIALPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C05")]
				[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
				public static void KCEHONPEIFO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000C07")]
				[Cpp2IlInjected.Address(RVA = "0x609E1D0", Offset = "0x609D3D0", VA = "0x18609E1D0")]
				public static void LDFPBHJMNFE(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000702")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000703")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000704")]
			public NativeParallelHashMap<NACALKPEILN, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000705")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000706")]
			public ComponentTypeHandle<GODAIDEBOAI> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000707")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BFA")]
			[Cpp2IlInjected.Address(RVA = "0x609A5D0", Offset = "0x60997D0", VA = "0x18609A5D0")]
			private void CHEGCCDBFJM(Entity entity, [NoAlias] ref GODAIDEBOAI dstValue, [NoAlias] in OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BFB")]
			[Cpp2IlInjected.Address(RVA = "0x609A6E0", Offset = "0x60998E0", VA = "0x18609A6E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BFC")]
			[Cpp2IlInjected.Address(RVA = "0x609A670", Offset = "0x6099870", VA = "0x18609A670")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void EIHJACMIDKF(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BFD")]
			[Cpp2IlInjected.Address(RVA = "0x609A880", Offset = "0x6099A80", VA = "0x18609A880")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void LFPBDECHIIM(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200021D")]
		private struct PostLoadInitializeNetworkId_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400070A")]
			public NativeParallelHashMap<NACALKPEILN, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400070B")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400070C")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C08")]
			[Cpp2IlInjected.Address(RVA = "0x609A900", Offset = "0x6099B00", VA = "0x18609A900")]
			private void CHEGCCDBFJM(Entity entity, in OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x609AA30", Offset = "0x6099C30", VA = "0x18609AA30", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		[MOHONECELPE]
		private MHGCAFFKDBL networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		[MOHONECELPE]
		private JGPGIDINFEG scenes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private EntityQuery queryAllInScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private EntityQuery additiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private EntityQuery __query_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private ComponentTypeHandle<GODAIDEBOAI> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2462F60", Offset = "0x2462160", VA = "0x182462F60", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2463FF0", Offset = "0x24631F0", VA = "0x182463FF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x24640B0", Offset = "0x24632B0", VA = "0x1824640B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2462D30", Offset = "0x2461F30", VA = "0x182462D30")]
		public void GGPGECMGHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x24625A0", Offset = "0x24617A0", VA = "0x1824625A0")]
		private void AKMFGJAINGG(NativeParallelHashMap<NACALKPEILN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2462AC0", Offset = "0x2461CC0", VA = "0x182462AC0")]
		private void BHCOINEBNPO(NativeParallelHashMap<NACALKPEILN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2462380", Offset = "0x2461580", VA = "0x182462380")]
		private void ACKKHAALEOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2463180", Offset = "0x2462380", VA = "0x182463180")]
		private void NEJJEMNOEML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2462D10", Offset = "0x2461F10", VA = "0x182462D10")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void EGNKPGEENMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2463580", Offset = "0x2462780", VA = "0x182463580")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ONBLFFFHKDP(NativeParallelHashMap<NACALKPEILN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2462DA0", Offset = "0x2461FA0", VA = "0x182462DA0")]
		private void HILOCJNAFLD(ref NativeParallelHashMap<NACALKPEILN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2462FD0", Offset = "0x24621D0", VA = "0x182462FD0")]
		private void MOPPHPPJCCJ(ref NativeParallelHashMap<NACALKPEILN, Entity> map, ref uint playerId, ref uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2463400", Offset = "0x2462600", VA = "0x182463400")]
		private void OMMIBELIGKK(ref NativeParallelHashMap<NACALKPEILN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2463300", Offset = "0x2462500", VA = "0x182463300")]
		private void NKHMEFIGEFK(ref NativeParallelHashMap<NACALKPEILN, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2463670", Offset = "0x2462870", VA = "0x182463670", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x2463130", Offset = "0x2462330", VA = "0x182463130")]
		public static void MPNMJJAHKEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x2462A70", Offset = "0x2461C70", VA = "0x182462A70")]
		public static void ALJGIJHMFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x2462F10", Offset = "0x2462110", VA = "0x182462F10")]
		public static void IMOEBMAFDDH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200021E")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class HFABJOMACNO : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private EntityQuery DACNGCDAPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private CFHHLPHHLOO CKCMCCKOKEH;

	[Cpp2IlInjected.Token(Token = "0x6000C0A")]
	[Cpp2IlInjected.Address(RVA = "0x25A5040", Offset = "0x25A4240", VA = "0x1825A5040", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0B")]
	[Cpp2IlInjected.Address(RVA = "0x25A5090", Offset = "0x25A4290", VA = "0x1825A5090", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0C")]
	[Cpp2IlInjected.Address(RVA = "0x25A5140", Offset = "0x25A4340", VA = "0x1825A5140", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0D")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public HFABJOMACNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021F")]
[LJJFMBKPAEC(CCDGJKNFPNB.PhotonRoom)]
[DDDGJOKMEDO(typeof(JKNDJOAONLH), new string[] { })]
internal class DCBOBBBGCCP : DCLDDNDKGBL, JKNDJOAONLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	[MOHONECELPE]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000711")]
	[MOHONECELPE]
	private JGPGIDINFEG FMLLOEFLKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000712")]
	private readonly Dictionary<int, Entity> OFBCFAMMAIH;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x2634E60", Offset = "0x2634060", VA = "0x182634E60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(RVA = "0x2635290", Offset = "0x2634490", VA = "0x182635290", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C11")]
	[Cpp2IlInjected.Address(RVA = "0x2634EB0", Offset = "0x26340B0", VA = "0x182634EB0", Slot = "5")]
	public void IIMJGOMAKFK(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C12")]
	[Cpp2IlInjected.Address(RVA = "0x2635040", Offset = "0x2634240", VA = "0x182635040", Slot = "6")]
	public bool IMHDMFGBCPD(BMDJOHDFBDL JHJPAJMEGAG, Transform LNNHFELGMNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C13")]
	[Cpp2IlInjected.Address(RVA = "0x2635320", Offset = "0x2634520", VA = "0x182635320")]
	private bool MNGKMMNACMH(Scene IBENPLAEBFE, out Entity DAKADCCHADB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C14")]
	[Cpp2IlInjected.Address(RVA = "0x2635390", Offset = "0x2634590", VA = "0x182635390")]
	public DCBOBBBGCCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000220")]
public class BKJCHLCALOO : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	[MOHONECELPE]
	private BCLIKNODFFN CJAKEHPIILM;

	[Cpp2IlInjected.Token(Token = "0x6000C15")]
	[Cpp2IlInjected.Address(RVA = "0x2629F80", Offset = "0x2629180", VA = "0x182629F80", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C16")]
	[Cpp2IlInjected.Address(RVA = "0x2629FD0", Offset = "0x26291D0", VA = "0x182629FD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C17")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public BKJCHLCALOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000221")]
public abstract class HBIAMONPJOO : KNNEOPGGIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000714")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x6000C18")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem IMLBAKBFEOF();

	[Cpp2IlInjected.Token(Token = "0x6000C19")]
	[Cpp2IlInjected.Address(RVA = "0x27D2FB0", Offset = "0x27D21B0", VA = "0x1827D2FB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1A")]
	[Cpp2IlInjected.Address(RVA = "0x27D3040", Offset = "0x27D2240", VA = "0x1827D3040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1B")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	protected HBIAMONPJOO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000222")]
public struct IMLBMDLOING : HBMOGNJLPON<BGFGOLHGEPN>
{
	[Cpp2IlInjected.Token(Token = "0x6000C1C")]
	[Cpp2IlInjected.Address(RVA = "0x25B1FC0", Offset = "0x25B11C0", VA = "0x1825B1FC0", Slot = "4")]
	public bool AIODCINPHKB(BGFGOLHGEPN NABCGCEIEGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000223")]
public static class IGNMHCCGCEN
{
	[Cpp2IlInjected.Token(Token = "0x6000C1D")]
	[Cpp2IlInjected.Address(RVA = "0x25B0650", Offset = "0x25AF850", VA = "0x1825B0650")]
	public static NativeParallelHashSet<int> NJEDNEMICOJ(EntityManager NMHMIPEFENM, Allocator KPFKDHLBOGB)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(RVA = "0x25B0490", Offset = "0x25AF690", VA = "0x1825B0490")]
	public static NativeParallelHashMap<int, int> CEGOJCBFJBH(EntityManager NMHMIPEFENM, Allocator KPFKDHLBOGB)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000224")]
internal readonly struct DJFKEPKGAHF
{
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private static readonly ProfilerMarker OBEGNKLMOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private readonly KNNEOPGGIBD FMGKDHAODCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private readonly World DGIKFFNILOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private readonly EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private readonly EntityQuery POLPCMHAJMD;

	[Cpp2IlInjected.Token(Token = "0x6000C1F")]
	[Cpp2IlInjected.Address(RVA = "0x2639430", Offset = "0x2638630", VA = "0x182639430")]
	public DJFKEPKGAHF(KNNEOPGGIBD FMGKDHAODCH, World DGIKFFNILOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C20")]
	[Cpp2IlInjected.Address(RVA = "0x2638E50", Offset = "0x2638050", VA = "0x182638E50")]
	public (NativeArray<NACALKPEILN>, NativeArray<DLGBACOGEKM>) KGILAIAHHCE()
	{
		return default((NativeArray<NACALKPEILN>, NativeArray<DLGBACOGEKM>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000225")]
internal interface JMFALELBNFD
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	bool OOKGMFOCCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	NativeArray<NACALKPEILN> GJBACECCMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	NativeArray<DLGBACOGEKM> JIMHPAELIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	NativeArray<NACALKPEILN> ABBECBPKOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C26")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OBGPNAICODD(out NativeArray<int> HFBINPOOEPB, Allocator KPFKDHLBOGB);

	[Cpp2IlInjected.Token(Token = "0x6000C27")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GOOCOCKEDEA(ComponentType PKEBPHKAGGB, out FFHIFLEKAAF LEMPMGHCAGF, out AGCHFHEBBNM HGLCHOPBPCB);

	[Cpp2IlInjected.Token(Token = "0x6000C28")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, GOECINKNCJI> HBFLKNOKCJI();
}
[Cpp2IlInjected.Token(Token = "0x2000226")]
internal static class CIFLDLADADM
{
	[Cpp2IlInjected.Token(Token = "0x6000C29")]
	[Cpp2IlInjected.Address(RVA = "0x262C4F0", Offset = "0x262B6F0", VA = "0x18262C4F0")]
	public static bool JOGPCNPEIBA(this JMFALELBNFD NJGLKOBADEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000227")]
[DDDGJOKMEDO(typeof(EAECNFFNPIO), new string[] { })]
public sealed class LKBDHDGAOHD : EAECNFFNPIO, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x2000228")]
	[BurstCompile]
	private struct BHLFEGDOEBD : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		[ReadOnly]
		public NativeArray<Entity> IBGFBPGPJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		[ReadOnly]
		public float3 GHBOCIAANAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		[ReadOnly]
		public float3 CIMMOKAKNML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		[ReadOnly]
		public ComponentDataFromEntity<BGFGOLHGEPN> KPBBEIBHLKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		[ReadOnly]
		public ComponentDataFromEntity<NMNIMNAKHFI> HMHGFLNBIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> ALEHKKOLINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		[ReadOnly]
		public ComponentDataFromEntity<AJALCLPOENM> NMDCHLGGHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		[ReadOnly]
		public ComponentDataFromEntity<MIKHADPILJF> GHAGKOAHCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		[WriteOnly]
		public NativeArray<EIPOHBGDCNM> GJOFEMKLEKB;

		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private static readonly EIPOHBGDCNM PAEPBGEDAHN;

		[Cpp2IlInjected.Token(Token = "0x6000C2E")]
		[Cpp2IlInjected.Address(RVA = "0x2217A90", Offset = "0x2216C90", VA = "0x182217A90", Slot = "4")]
		public void Execute(int NNAODBDJDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x2217D80", Offset = "0x2216F80", VA = "0x182217D80")]
		private static float3 FCKLKGOODAI(in float4x4 PNGMEMLGCGB, in float3 DJFHFDKDHMO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x22185C0", Offset = "0x22177C0", VA = "0x1822185C0")]
		private static float3 MAJHJCDHMHB(in float4x4 PNGMEMLGCGB, in float3 ANIFGLPKOMK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x2217E50", Offset = "0x2217050", VA = "0x182217E50")]
		private static float3 IKHHIBKKLCI(in float4x4 PNGMEMLGCGB, in float3 DJFHFDKDHMO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x2218A50", Offset = "0x2217C50", VA = "0x182218A50")]
		private static float3 PKHNCOPOEJO(in float4x4 PNGMEMLGCGB, in float3 ANIFGLPKOMK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x2218730", Offset = "0x2217930", VA = "0x182218730")]
		private bool PCEIHCPOPFP(in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, in NativeArray<Entity> EKLFLCALFAO, out float3 GMKMPBEKJDH, out float3 AHEOGBFEFAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x2217F60", Offset = "0x2217160", VA = "0x182217F60")]
		public static bool KFCIHHFLGON(in float3 CMNGAPALKJI, in float3 OANMFDAPLPD, in float3 IMPDGFNABKG, in float3 DODIGDHMBDK, float MIMCHNNJICJ, float FFNFBCHKGBE, out float APIDLMAPAPO, out float3 HHDIDFKPEKO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.Token(Token = "0x6000C2A")]
	[Cpp2IlInjected.Address(RVA = "0x2A84950", Offset = "0x2A83B50", VA = "0x182A84950", Slot = "5")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2B")]
	[Cpp2IlInjected.Address(RVA = "0x2A84460", Offset = "0x2A83660", VA = "0x182A84460")]
	public void HIKLJPGBGIK(in NativeArray<Entity> IBGFBPGPJKP, in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, in NativeArray<EIPOHBGDCNM> HLJMBHGAANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public LKBDHDGAOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2D")]
	[Cpp2IlInjected.Address(RVA = "0x2A84450", Offset = "0x2A83650", VA = "0x182A84450", Slot = "4")]
	private void CBMNMDHMLMF(in NativeArray<Entity> IBGFBPGPJKP, in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, in NativeArray<EIPOHBGDCNM> HLJMBHGAANB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
[DefaultMember("Item")]
public struct FNAOHLCHFEG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private T[] JFGIPFOFKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private int AAALINBAMFJ;

	[Cpp2IlInjected.Token(Token = "0x6000C36")]
	[Cpp2IlInjected.Address(RVA = "0x513BAD0", Offset = "0x513ACD0", VA = "0x18513BAD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022A")]
public struct FCIJDIMNMDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	public Entity BLNICJMKCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	public Entity IFMGHGFKKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	public Entity PCCOHMIFFHJ;

	[Cpp2IlInjected.Token(Token = "0x6000C37")]
	[Cpp2IlInjected.Address(RVA = "0x27C6B70", Offset = "0x27C5D70", VA = "0x1827C6B70")]
	public FCIJDIMNMDP(Entity BLNICJMKCEF, Entity IFMGHGFKKAF, Entity PCCOHMIFFHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C38")]
	[Cpp2IlInjected.Address(RVA = "0x27C6B30", Offset = "0x27C5D30", VA = "0x1827C6B30")]
	public static FCIJDIMNMDP OMHOCPNBHHH((Entity entity, Entity oldParent, Entity newParent) JAIKKOHGMLH)
	{
		return default(FCIJDIMNMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C39")]
	[Cpp2IlInjected.Address(RVA = "0x27C6B10", Offset = "0x27C5D10", VA = "0x1827C6B10")]
	public void LOLPJHCGKNM(out Entity BLNICJMKCEF, out Entity IFMGHGFKKAF, out Entity PCCOHMIFFHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022B")]
public class AOMLBCCJLMF : KNNEOPGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072C")]
	private EntityQuery JIAIANFJBDB;

	[Cpp2IlInjected.Token(Token = "0x6000C3A")]
	[Cpp2IlInjected.Address(RVA = "0x26255B0", Offset = "0x26247B0", VA = "0x1826255B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3B")]
	[Cpp2IlInjected.Address(RVA = "0x2625660", Offset = "0x2624860", VA = "0x182625660", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3C")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public AOMLBCCJLMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022C")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal class BAAFMINJIBI : CMMFKLLOOOK<IMNLGLPNFGM>, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x400072D")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	private JPLJDCFLDIF KPFCGANDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private CFNPKKKFCDJ INGFBFNFPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	private EntityQuery EICNMCMHIKJ;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private Entity CIAONFPHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2625CA0", Offset = "0x2624EA0", VA = "0x182625CA0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2625F40", Offset = "0x2625140", VA = "0x182625F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public BMDJOHDFBDL OPCONLMGHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2625FA0", Offset = "0x26251A0", VA = "0x182625FA0")]
		get
		{
			return default(BMDJOHDFBDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x26264A0", Offset = "0x26256A0", VA = "0x1826264A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C42")]
	[Cpp2IlInjected.Address(RVA = "0x2626550", Offset = "0x2625750", VA = "0x182626550", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C43")]
	[Cpp2IlInjected.Address(RVA = "0x2625ED0", Offset = "0x26250D0", VA = "0x182625ED0", Slot = "15")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C44")]
	[Cpp2IlInjected.Address(RVA = "0x26265F0", Offset = "0x26257F0", VA = "0x1826265F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C45")]
	[Cpp2IlInjected.Address(RVA = "0x2625AB0", Offset = "0x2624CB0", VA = "0x182625AB0", Slot = "14")]
	protected override void AOFBFAGNEAO(NativeArray<Entity> IBGFBPGPJKP, NativeArray<Entity> LOAABKDHPBH, NativeArray<Entity> NCGMPIHPALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C46")]
	[Cpp2IlInjected.Address(RVA = "0x2625D00", Offset = "0x2624F00", VA = "0x182625D00")]
	private void GOKBOCOFFOK(NativeArray<Entity> IBGFBPGPJKP, NativeArray<Entity> NCGMPIHPALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0x2626040", Offset = "0x2625240", VA = "0x182626040")]
	private void NBNJAENACKE(Entity BLNICJMKCEF, Entity ILIKJPGLHJL, Entity NLBHDJFMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0x243BD90", Offset = "0x243AF90", VA = "0x18243BD90")]
	private bool FCPLDEOENIG<T>(out T NABCGCEIEGG) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x243BE20", Offset = "0x243B020", VA = "0x18243BE20")]
	private void ONKKEHNKDMK<T>(T NABCGCEIEGG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x2625DE0", Offset = "0x2624FE0", VA = "0x182625DE0")]
	public bool INCNBOKJAGH(BMDJOHDFBDL KCLEINCKFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x2625C10", Offset = "0x2624E10", VA = "0x182625C10")]
	private static bool CAMKPAIFOAC(BMDJOHDFBDL HGAAPGHCMEG, BMDJOHDFBDL HNMNKNFENFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4C")]
	[Cpp2IlInjected.Address(RVA = "0x2626700", Offset = "0x2625900", VA = "0x182626700")]
	public BAAFMINJIBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
internal class IJENNOBJDOB : IAFEDJPGFJM
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	protected override ABAPOMGFJBP DHOHAFONONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x25B1000", Offset = "0x25B0200", VA = "0x1825B1000", Slot = "15")]
		get
		{
			return default(ABAPOMGFJBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4F")]
	[Cpp2IlInjected.Address(RVA = "0x25A7440", Offset = "0x25A6640", VA = "0x1825A7440")]
	public IJENNOBJDOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022E")]
public class LGCNBLEKAAH : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	[MOHONECELPE]
	private BCLIKNODFFN CJAKEHPIILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	[MOHONECELPE]
	private MHGCAFFKDBL KFBDHNDCMMC;

	[Cpp2IlInjected.Token(Token = "0x6000C50")]
	[Cpp2IlInjected.Address(RVA = "0x2A80AC0", Offset = "0x2A7FCC0", VA = "0x182A80AC0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C51")]
	[Cpp2IlInjected.Address(RVA = "0x2A80B30", Offset = "0x2A7FD30", VA = "0x182A80B30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C52")]
	[Cpp2IlInjected.Address(RVA = "0x2A80570", Offset = "0x2A7F770", VA = "0x182A80570")]
	private void IDMPFJJNPMP(NativeArray<NACALKPEILN> NDHEBPMINJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C53")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public LGCNBLEKAAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022F")]
public class CMJANADMBAE : KNNEOPGGIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	private EntityQuery NKNNOGHMCPO;

	[Cpp2IlInjected.Token(Token = "0x6000C55")]
	[Cpp2IlInjected.Address(RVA = "0x2631910", Offset = "0x2630B10", VA = "0x182631910", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C56")]
	[Cpp2IlInjected.Address(RVA = "0x26319A0", Offset = "0x2630BA0", VA = "0x1826319A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C57")]
	[Cpp2IlInjected.Address(RVA = "0x26318C0", Offset = "0x2630AC0", VA = "0x1826318C0")]
	private EntityCommandBufferSystem BELMJICDGGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C58")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public CMJANADMBAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000230")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class IKGLJANNFKN : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000C59")]
	[Cpp2IlInjected.Address(RVA = "0x25B1260", Offset = "0x25B0460", VA = "0x1825B1260", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5A")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public IKGLJANNFKN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000231")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParent : KNNEOPGGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private static readonly PEKDFCFCENH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2464560", Offset = "0x2463760", VA = "0x182464560", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2464640", Offset = "0x2463840", VA = "0x182464640", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x24643A0", Offset = "0x24635A0", VA = "0x1824643A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PostLoadMoveRootsUnderParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000232")]
public struct PPIJPPICKFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	public Entity BLNICJMKCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	public Entity OJEMCPHOKBP;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x15BCC60", Offset = "0x15BBE60", VA = "0x1815BCC60")]
	public PPIJPPICKFO(Entity BLNICJMKCEF, Entity OJEMCPHOKBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x245C2E0", Offset = "0x245B4E0", VA = "0x18245C2E0")]
	public static PPIJPPICKFO OMHOCPNBHHH((Entity entity, Entity parent) JAIKKOHGMLH)
	{
		return default(PPIJPPICKFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x245C2D0", Offset = "0x245B4D0", VA = "0x18245C2D0")]
	public void LOLPJHCGKNM(out Entity BLNICJMKCEF, out Entity OJEMCPHOKBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000233")]
[AlwaysUpdateSystem]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public class KIAMFLCBFGH : KNNEOPGGIBD, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	[MOHONECELPE]
	private PMDPEMDAEAF CIDOJJABGDE;

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x25BFD90", Offset = "0x25BEF90", VA = "0x1825BFD90", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x25BFDE0", Offset = "0x25BEFE0", VA = "0x1825BFDE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public KIAMFLCBFGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000234")]
[DDDGJOKMEDO(typeof(EINAEGLAJFO), new string[] { })]
[LJJFMBKPAEC(CCDGJKNFPNB.OMRoom)]
internal sealed class EINAEGLAJFO : DCLDDNDKGBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	[MOHONECELPE]
	private MMIPKKPAOLG OOHHGMIKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private EntityQuery HOAJAMLLHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x27BE7D0", Offset = "0x27BD9D0", VA = "0x1827BE7D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x27BEA80", Offset = "0x27BDC80", VA = "0x1827BEA80", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x27BE8F0", Offset = "0x27BDAF0", VA = "0x1827BE8F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x27BE9C0", Offset = "0x27BDBC0", VA = "0x1827BE9C0")]
	public bool FGHHNJKOBON(Entity BLNICJMKCEF, Entity FMMAMOIMPOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6A")]
	[Cpp2IlInjected.Address(RVA = "0x27BEBD0", Offset = "0x27BDDD0", VA = "0x1827BEBD0")]
	public bool OOGFDOGPFLJ(Entity BLNICJMKCEF, Entity FGNNHDMBMMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6B")]
	[Cpp2IlInjected.Address(RVA = "0x27BE910", Offset = "0x27BDB10", VA = "0x1827BE910")]
	public Entity ELNKALNLELD(Entity BLNICJMKCEF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6C")]
	[Cpp2IlInjected.Address(RVA = "0x27BEB80", Offset = "0x27BDD80", VA = "0x1827BEB80")]
	public NativeArray<Entity> LANDOEMDGKM()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6D")]
	[Cpp2IlInjected.Address(RVA = "0x27BE820", Offset = "0x27BDA20", VA = "0x1827BE820")]
	public bool DFLGDIJJHGG(Entity BJPEGONLJEK, Entity NPIENNHDDHE, out Entity ILDPFGGCFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6E")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public EINAEGLAJFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000235")]
internal interface FFJELJCPNLF
{
	[Cpp2IlInjected.Token(Token = "0x17000154")]
	World OFIFOCNNODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	World EPJHBKFCPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	KDJINJGKOPM JKCNGOBBILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	uint LDIKCCIHMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000236")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplines : KNNEOPGGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000237")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000742")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000743")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C7C")]
			[Cpp2IlInjected.Address(RVA = "0x2226200", Offset = "0x2225400", VA = "0x182226200")]
			private void CHEGCCDBFJM(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C7D")]
			[Cpp2IlInjected.Address(RVA = "0x2226290", Offset = "0x2225490", VA = "0x182226290", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000238")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000744")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000745")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000746")]
			[ReadOnly]
			public ComponentTypeHandle<GAAIHPAGNAD> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C7E")]
			[Cpp2IlInjected.Address(RVA = "0x2226340", Offset = "0x2225540", VA = "0x182226340")]
			private void CHEGCCDBFJM(Entity splinePoint, [NoAlias] in GAAIHPAGNAD splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C7F")]
			[Cpp2IlInjected.Address(RVA = "0x22263D0", Offset = "0x22255D0", VA = "0x1822263D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private ComponentTypeHandle<GAAIHPAGNAD> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x245D830", Offset = "0x245CA30", VA = "0x18245D830", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x245D8E0", Offset = "0x245CAE0", VA = "0x18245D8E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x245D490", Offset = "0x245C690", VA = "0x18245D490")]
		private EntityCommandBufferSystem IMLBAKBFEOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x245D240", Offset = "0x245C440", VA = "0x18245D240")]
		private void EBIECCLGFEP(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x245D340", Offset = "0x245C540", VA = "0x18245D340")]
		private void GFCNNLINJNI(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x245D4E0", Offset = "0x245C6E0", VA = "0x18245D4E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public PostDeserializeAddSplinePointsToSplines()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000239")]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
	public class UpdateSplineGameCollidersSystem : KNNEOPGGIBD, DCLDDNDKGBL
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200023A")]
		public struct SplineGameCollisionSystemTag : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200023B")]
		private struct ProcessCollisionModeChangesForSplineGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000754")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000755")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000756")]
			[ReadOnly]
			public ComponentDataFromEntity<BKCCEEBHOIE> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000757")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			[ReadOnly]
			public ComponentTypeHandle<MHKJKOAIFPO> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			public BufferTypeHandle<JFFGLDLIPLN> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x609B4B0", Offset = "0x609A6B0", VA = "0x18609B4B0")]
			private void CHEGCCDBFJM(in MHKJKOAIFPO collisionMode, DynamicBuffer<JFFGLDLIPLN> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x609B800", Offset = "0x609AA00", VA = "0x18609B800", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023C")]
		private struct ProcessActiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400075A")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400075B")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400075C")]
			[ReadOnly]
			public ComponentDataFromEntity<MHKJKOAIFPO> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400075D")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400075E")]
			[ReadOnly]
			public ComponentTypeHandle<BGFGOLHGEPN> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0x609B2D0", Offset = "0x609A4D0", VA = "0x18609B2D0")]
			private void CHEGCCDBFJM(Entity entity, in BGFGOLHGEPN parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C91")]
			[Cpp2IlInjected.Address(RVA = "0x609B390", Offset = "0x609A590", VA = "0x18609B390", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023D")]
		private struct ProcessInactiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400075F")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000760")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000761")]
			[ReadOnly]
			public ComponentDataFromEntity<MHKJKOAIFPO> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000762")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000763")]
			[ReadOnly]
			public ComponentTypeHandle<BGFGOLHGEPN> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C92")]
			[Cpp2IlInjected.Address(RVA = "0x609B970", Offset = "0x609AB70", VA = "0x18609B970")]
			private void CHEGCCDBFJM(Entity entity, in BGFGOLHGEPN parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C93")]
			[Cpp2IlInjected.Address(RVA = "0x609BA20", Offset = "0x609AC20", VA = "0x18609BA20", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023E")]
		private struct UpdateSplineGameCollidersSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000764")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000765")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000766")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C94")]
			[Cpp2IlInjected.Address(RVA = "0x609F910", Offset = "0x609EB10", VA = "0x18609F910")]
			private void CHEGCCDBFJM(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C95")]
			[Cpp2IlInjected.Address(RVA = "0x609F990", Offset = "0x609EB90", VA = "0x18609F990", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023F")]
		private struct ProcessSplineEditsForGameCollision_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000768")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000769")]
			[ReadOnly]
			public ComponentTypeHandle<GAAIHPAGNAD> splinePointParentHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400076A")]
			[ReadOnly]
			public EntityTypeHandle entityHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400076B")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400076C")]
			public EntityQueryInJob splinePointEditedQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400076D")]
			public EntityQueryInJob splineStructureChangedQueryInJob;

			[Cpp2IlInjected.Token(Token = "0x6000C96")]
			[Cpp2IlInjected.Address(RVA = "0x609BB40", Offset = "0x609AD40", VA = "0x18609BB40")]
			private void CHEGCCDBFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C97")]
			[Cpp2IlInjected.Address(RVA = "0x609C110", Offset = "0x609B310", VA = "0x18609C110", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C98")]
			[Cpp2IlInjected.Address(RVA = "0x609C0B0", Offset = "0x609B2B0", VA = "0x18609C0B0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void EIHJACMIDKF(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private MPENABBNJNJ splineCollisionService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private EntityQuery collisionModeChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private EntityQuery activeSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		private EntityQuery inactiveSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private EntityQuery splinePointEditedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private EntityQuery splineStructureChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private EntityQuery splinesDeletedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private EntityQuery ProcessCollisionModeChangesForSplineGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private EntityQuery ProcessActiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		private EntityQuery ProcessInactiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private EntityQuery UpdateSplineGameCollidersSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private ComponentTypeHandle<MHKJKOAIFPO> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private ComponentTypeHandle<BGFGOLHGEPN> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x2471410", Offset = "0x2470610", VA = "0x182471410", Slot = "14")]
		public void InitReferences(POCHLGNFBCE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x24721E0", Offset = "0x24713E0", VA = "0x1824721E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0x24723B0", Offset = "0x24715B0", VA = "0x1824723B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0x2470D00", Offset = "0x246FF00", VA = "0x182470D00")]
		private void EIGLOFKAHIO(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0x2470F20", Offset = "0x2470120", VA = "0x182470F20")]
		private void FAOKMGJDKEF(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x2470A60", Offset = "0x246FC60", VA = "0x182470A60")]
		private void ALIOBMNKOGO(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x24711E0", Offset = "0x24703E0", VA = "0x1824711E0")]
		private void HHELOIGLFCI(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x2471460", Offset = "0x2470660", VA = "0x182471460")]
		private void JFAABFIBHPK(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<BKCCEEBHOIE> splineComponentAccess, ref ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x2471650", Offset = "0x2470850", VA = "0x182471650")]
		private void MJALKGGDFCF(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<MHKJKOAIFPO> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x24717C0", Offset = "0x24709C0", VA = "0x1824717C0")]
		private void NBPKJGOFCKA(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<MHKJKOAIFPO> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x2470C10", Offset = "0x246FE10", VA = "0x182470C10")]
		private void CPLIHFLFDFD(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x24712D0", Offset = "0x24704D0", VA = "0x1824712D0")]
		private void IAEDOHIBEHM(ref ComponentTypeHandle<GAAIHPAGNAD> splinePointParentHandle, ref EntityTypeHandle entityHandle, ref ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, ref EntityQueryInJob splinePointEditedQueryInJob, ref EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x2471930", Offset = "0x2470B30", VA = "0x182471930", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000240")]
public sealed class DKBNOBOLEIE : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x2639A90", Offset = "0x2638C90", VA = "0x182639A90", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public DKBNOBOLEIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
[ExecuteAlways]
public class CBCJIHDPGNO : KFPLABIADMD
{
	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x8C2A40", Offset = "0x8C1C40", VA = "0x1808C2A40")]
	public CBCJIHDPGNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
public sealed class MGIBGGEAEBP : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C4F0", Offset = "0x2A8B6F0", VA = "0x182A8C4F0", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public MGIBGGEAEBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
public class AJIBELHGJBH : AFFEALIJNOO, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400076E")]
	private JGPGIDINFEG NJFMCLNALDN;

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x26247B0", Offset = "0x26239B0", VA = "0x1826247B0", Slot = "14")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x2454CB0", Offset = "0x2453EB0", VA = "0x182454CB0")]
	public AJIBELHGJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class MBABFILNADJ : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x2A864B0", Offset = "0x2A856B0", VA = "0x182A864B0", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public MBABFILNADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
internal class AFOIBCKHDAL : ILHFNJMEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000159")]
	protected override LCOECJPMODN GCCLHHLKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE50", Offset = "0x8AE050", VA = "0x1808AEE50", Slot = "17")]
		get
		{
			return default(LCOECJPMODN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x2620BA0", Offset = "0x261FDA0", VA = "0x182620BA0")]
	public AFOIBCKHDAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000246")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
public sealed class JFDOFHGIKJE : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x25B4F50", Offset = "0x25B4150", VA = "0x1825B4F50", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public JFDOFHGIKJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class FOCBKOGGMPK : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x27CAC90", Offset = "0x27C9E90", VA = "0x1827CAC90", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public FOCBKOGGMPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
[OHLCAKOBJLJ(typeof(CHDOFCKIBBD))]
public sealed class KBJEBNLIOIK : JIEKOGJHADG
{
	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x25B92C0", Offset = "0x25B84C0", VA = "0x1825B92C0", Slot = "8")]
	protected override bool LJJDJGAKJMB(ReadOnlySpan<CHDOFCKIBBD> FBIMPHNMCAK, NKGDHPLFPDK DJHOCJBGPEK, out ReadOnlySpan<byte> CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAA")]
	[Cpp2IlInjected.Address(RVA = "0x25B9200", Offset = "0x25B8400", VA = "0x1825B9200", Slot = "9")]
	protected override bool HMKBPPPJBFA(int KBIJDJHCEBH, Span<CHDOFCKIBBD> FBIMPHNMCAK, in ReadOnlySpan<byte> CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAB")]
	[Cpp2IlInjected.Address(RVA = "0x25B9340", Offset = "0x25B8540", VA = "0x1825B9340")]
	public KBJEBNLIOIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000249")]
[OHLCAKOBJLJ(typeof(EIMFLLKDNCD))]
public sealed class HJKBCEIPPEI : BNCAFAPJOOI
{
	[Cpp2IlInjected.Token(Token = "0x6000CAC")]
	[Cpp2IlInjected.Address(RVA = "0x25A9800", Offset = "0x25A8A00", VA = "0x1825A9800", Slot = "8")]
	protected override bool LJJDJGAKJMB(ReadOnlySpan<EIMFLLKDNCD> FBIMPHNMCAK, NKGDHPLFPDK DJHOCJBGPEK, out ReadOnlySpan<byte> CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAD")]
	[Cpp2IlInjected.Address(RVA = "0x25A9740", Offset = "0x25A8940", VA = "0x1825A9740", Slot = "9")]
	protected override bool HMKBPPPJBFA(int KBIJDJHCEBH, Span<EIMFLLKDNCD> FBIMPHNMCAK, in ReadOnlySpan<byte> CCBKAEHNCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAE")]
	[Cpp2IlInjected.Address(RVA = "0x25A9880", Offset = "0x25A8A80", VA = "0x1825A9880")]
	public HJKBCEIPPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
[AKEFOBLNEPL(CCDGJKNFPNB.LoadInstance)]
internal sealed class HCLALIIFCGB : IDOKENEHHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000CAF")]
	[Cpp2IlInjected.Address(RVA = "0x25A4480", Offset = "0x25A3680", VA = "0x1825A4480", Slot = "15")]
	protected override ComponentSystemBase FGKBKPLMNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB0")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public HCLALIIFCGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024B")]
internal class BNJMEJDHIAB : JAGPBMEIJKO
{
	[Cpp2IlInjected.Token(Token = "0x6000CB1")]
	[Cpp2IlInjected.Address(RVA = "0x25A4470", Offset = "0x25A3670", VA = "0x1825A4470")]
	public BNJMEJDHIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024C")]
[DDDGJOKMEDO(typeof(PLEFLDKFGFP), new string[] { })]
public sealed class CNILLODOMAL : PLEFLDKFGFP, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400076F")]
	private FOEBEFHCPPN BKHAEGCLDIO;

	[Cpp2IlInjected.Token(Token = "0x6000CB2")]
	[Cpp2IlInjected.Address(RVA = "0x2631EB0", Offset = "0x26310B0", VA = "0x182631EB0", Slot = "5")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2631DD0", Offset = "0x2630FD0", VA = "0x182631DD0")]
	public bool HIKLJPGBGIK(in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, float EKIBGBMDOJP, Allocator KPFKDHLBOGB, out NativeArray<Entity> IBGFBPGPJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public CNILLODOMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x2631DD0", Offset = "0x2630FD0", VA = "0x182631DD0", Slot = "4")]
	private bool DKFGOCLJNIE(in float3 BIBNBENFBDB, in float3 KCEMMLEMANI, float EKIBGBMDOJP, Allocator KPFKDHLBOGB, out NativeArray<Entity> IBGFBPGPJKP)
	{
		return default(bool);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200024D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : MCOMHBDOHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB6")]
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB7")]
		[Cpp2IlInjected.Address(RVA = "0x2229040", Offset = "0x2228240", VA = "0x182229040", Slot = "6")]
		public sealed override void LKAMFIMFKPG(FBLIJCAPIKE JHGMNDBGFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x2228E40", Offset = "0x2228040", VA = "0x182228E40", Slot = "4")]
		public sealed override void DCMFIKPGBKK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200024E")]
internal class __UnmanagedPostProcessorOutput__3051310927
{
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x222B7F0", Offset = "0x222A9F0", VA = "0x18222B7F0")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024F")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3051310927
{
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x222A1C0", Offset = "0x22293C0", VA = "0x18222A1C0")]
	public static void PLBHNCBKHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x222A1B0", Offset = "0x22293B0", VA = "0x18222A1B0")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000250")]
internal class GPMEKBMMGIC : ContainerPropertyBag<DHOMGICDHJI>
{
	[Cpp2IlInjected.Token(Token = "0x2000251")]
	private class EBMBFKOGHBG : Property<DHOMGICDHJI, BGNCONALOOG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public override string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000CBD")]
			[Cpp2IlInjected.Address(RVA = "0x221C7D0", Offset = "0x221B9D0", VA = "0x18221C7D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public override bool HPJMOKLCNEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000CBE")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBF")]
		[Cpp2IlInjected.Address(RVA = "0x221C790", Offset = "0x221B990", VA = "0x18221C790")]
		public EBMBFKOGHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC0")]
		[Cpp2IlInjected.Address(RVA = "0x221C740", Offset = "0x221B940", VA = "0x18221C740", Slot = "14")]
		public override BGNCONALOOG GetValue(ref DHOMGICDHJI AKLNKNCLGHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC1")]
		[Cpp2IlInjected.Address(RVA = "0x221C760", Offset = "0x221B960", VA = "0x18221C760", Slot = "15")]
		public override void SetValue(ref DHOMGICDHJI AKLNKNCLGHB, BGNCONALOOG NABCGCEIEGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x27D2030", Offset = "0x27D1230", VA = "0x1827D2030")]
	public GPMEKBMMGIC()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000252")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000CC2")]
		[Cpp2IlInjected.Address(RVA = "0x2467200", Offset = "0x2466400", VA = "0x182467200")]
		[RuntimeInitializeOnLoadMethod]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000253")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x263B370", Offset = "0x263A570", VA = "0x18263B370")]
	[RuntimeInitializeOnLoadMethod]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000254")]
public class MDBJHPDEIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MDBJHPDEIOP()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000255")]
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
