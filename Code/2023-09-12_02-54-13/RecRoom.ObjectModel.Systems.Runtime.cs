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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D0CD10", Offset = "0x2D0C110", VA = "0x182D0CD10")]
		public static MKDAMMLEKFE<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(MKDAMMLEKFE<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct LLFKHMENLKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[EIHIJGBHNAM]
public static class GFMDINPBBJN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28DC0A0", Offset = "0x28DB4A0", VA = "0x1828DC0A0")]
	static GFMDINPBBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16D8630", Offset = "0x16D7A30", VA = "0x1816D8630")]
	public static void JKELMLILMEJ<T>(T CIDBOBPIINF, ref T NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28DBC50", Offset = "0x28DB050", VA = "0x1828DBC50")]
	public static void JKELMLILMEJ(FixedString32Bytes CIDBOBPIINF, ref string NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28DBEF0", Offset = "0x28DB2F0", VA = "0x1828DBEF0")]
	public static void JKELMLILMEJ(string CIDBOBPIINF, ref FixedString32Bytes NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28DBFF0", Offset = "0x28DB3F0", VA = "0x1828DBFF0")]
	public static void JKELMLILMEJ(FixedString64Bytes CIDBOBPIINF, ref string NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28DBF30", Offset = "0x28DB330", VA = "0x1828DBF30")]
	public static void JKELMLILMEJ(string CIDBOBPIINF, ref FixedString64Bytes NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28DBE20", Offset = "0x28DB220", VA = "0x1828DBE20")]
	public static void JKELMLILMEJ(PNGEGIDHLIL CIDBOBPIINF, ref Vector3 NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28DBE70", Offset = "0x28DB270", VA = "0x1828DBE70")]
	public static void JKELMLILMEJ(Vector3 CIDBOBPIINF, ref PNGEGIDHLIL NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x28DBF90", Offset = "0x28DB390", VA = "0x1828DBF90")]
	public static void JKELMLILMEJ(AMHLJMGDDMA CIDBOBPIINF, ref Vector4 NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28DBC80", Offset = "0x28DB080", VA = "0x1828DBC80")]
	public static void JKELMLILMEJ(Vector4 CIDBOBPIINF, ref AMHLJMGDDMA NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x28DBF90", Offset = "0x28DB390", VA = "0x1828DBF90")]
	public static void JKELMLILMEJ(AMHLJMGDDMA CIDBOBPIINF, ref Quaternion NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x28DBC80", Offset = "0x28DB080", VA = "0x1828DBC80")]
	public static void JKELMLILMEJ(Quaternion CIDBOBPIINF, ref AMHLJMGDDMA NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x28DBBE0", Offset = "0x28DAFE0", VA = "0x1828DBBE0")]
	public static void JKELMLILMEJ(PNGEGIDHLIL CIDBOBPIINF, ref float3 NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x28DBE70", Offset = "0x28DB270", VA = "0x1828DBE70")]
	public static void JKELMLILMEJ(float3 CIDBOBPIINF, ref PNGEGIDHLIL NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x28DBD80", Offset = "0x28DB180", VA = "0x1828DBD80")]
	public static void JKELMLILMEJ(AMHLJMGDDMA CIDBOBPIINF, ref float4 NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x28DBC80", Offset = "0x28DB080", VA = "0x1828DBC80")]
	public static void JKELMLILMEJ(float4 CIDBOBPIINF, ref AMHLJMGDDMA NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x28DBD80", Offset = "0x28DB180", VA = "0x1828DBD80")]
	public static void JKELMLILMEJ(AMHLJMGDDMA CIDBOBPIINF, ref quaternion NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x28DC020", Offset = "0x28DB420", VA = "0x1828DC020")]
	public static void JKELMLILMEJ(quaternion CIDBOBPIINF, ref AMHLJMGDDMA NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x28DBD10", Offset = "0x28DB110", VA = "0x1828DBD10")]
	public static void JKELMLILMEJ(Entity CIDBOBPIINF, ref JHFJJELHCKN NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28DBD50", Offset = "0x28DB150", VA = "0x1828DBD50")]
	public static void JKELMLILMEJ(JHFJJELHCKN CIDBOBPIINF, ref Entity NBCAFBHOFIE, CNPNLDAEMGP JNKBIJELCHM)
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
		public SerializableGuid OAJALJJKEAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9D48A0", Offset = "0x9D3CA0", VA = "0x1809D48A0")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x24938D0", Offset = "0x2492CD0", VA = "0x1824938D0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[EPJIKDLNGEH(typeof(KCPMLDAAPLA), new string[] { })]
[DefaultMember("Item")]
public class EJNFKKKFKDH : KCPMLDAAPLA, IEnumerable<GPKGHEJLJCL>, IEnumerable, BLHEKNIGKIO, GMHONDBOJEM, NEHPEGODEDF, BKHNPHMEICP, EJLEFJCKIEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[BOJGNOMIPCG]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[BOJGNOMIPCG]
	private IJGPMAMDKLF KCJJGLLIALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private GPKGHEJLJCL[] KKHLCEENFDE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2954790", Offset = "0x2953B90", VA = "0x182954790", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GPKGHEJLJCL ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2954670", Offset = "0x2953A70", VA = "0x182954670", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "10")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x29547A0", Offset = "0x2953BA0", VA = "0x1829547A0", Slot = "11")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "12")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2954400", Offset = "0x2953800", VA = "0x182954400", Slot = "6")]
	public GPKGHEJLJCL DNDGKGKJHCH(LOHCJILDMLL OCFGMKDOPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2954A30", Offset = "0x2953E30", VA = "0x182954A30", Slot = "7")]
	public FDOJMOENJAL LEEAMPOIODD(LOHCJILDMLL OCFGMKDOPDP)
	{
		return default(FDOJMOENJAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x29546B0", Offset = "0x2953AB0", VA = "0x1829546B0", Slot = "8")]
	public IEnumerator<GPKGHEJLJCL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2954B00", Offset = "0x2953F00", VA = "0x182954B00", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x223E930", Offset = "0x223DD30", VA = "0x18223E930", Slot = "13")]
	public void GEGICBEPEAB<TKey, T>(FIPEENHHKAO<TKey, T> LEMJCNJPDLJ, [Optional] object AKPCLGIGABA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2954530", Offset = "0x2953930", VA = "0x182954530", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EJNFKKKFKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2954670", Offset = "0x2953A70", VA = "0x182954670")]
	[CompilerGenerated]
	private GPKGHEJLJCL KHJDHHKFEMC(int APEMPONKPBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NECCFHPLDLJ(typeof(BLLGOKJBFOC))]
[EPJIKDLNGEH(typeof(GGNFHIGGHPN), new string[] { })]
public class BLLGOKJBFOC : GGNFHIGGHPN, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly EHKEPJIBENP MEKKLCELNHD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly EHKEPJIBENP JGNADNAEJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private PINCEFFEDIB DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private OAAFNCLLJOJ PFIBEKNCGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private OHAMPNBKDLP LJNICDIKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private MDPDEGLCMGA PIDNNJGBEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private COKHJGJNDIB HJBFJMLNKGK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private EntityManager BEBIJONEMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28FE260", Offset = "0x28FD660", VA = "0x1828FE260")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2900230", Offset = "0x28FF630", VA = "0x182900230", Slot = "34")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x28FE9F0", Offset = "0x28FDDF0", VA = "0x1828FE9F0", Slot = "35")]
	public bool EHDJALGIOME(Transform DKKDEHMFAEC, out HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x28FE930", Offset = "0x28FDD30", VA = "0x1828FE930", Slot = "36")]
	public Transform EFFKIBNCGJI(Entity GKMECPLEALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x28FE5C0", Offset = "0x28FD9C0", VA = "0x1828FE5C0", Slot = "31")]
	public bool DAJCKLBFICP(Entity GKMECPLEALF, out Transform DKKDEHMFAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x28FDFD0", Offset = "0x28FD3D0", VA = "0x1828FDFD0")]
	private void BHLIJBDBMAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2901E10", Offset = "0x2901210", VA = "0x182901E10", Slot = "30")]
	public void PJHLMELAEHD(Entity GKMECPLEALF, out float4x4 JDFCJELKELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2901450", Offset = "0x2900850", VA = "0x182901450", Slot = "4")]
	public void LFDJFBMMDIA(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2900340", Offset = "0x28FF740", VA = "0x182900340", Slot = "28")]
	public void JAPGEPGMPCE(Entity GKMECPLEALF, out float4x4 JDFCJELKELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x28FFF50", Offset = "0x28FF350", VA = "0x1828FFF50")]
	public void IOCOEGNBODE(Entity GKMECPLEALF, in float4x4 JDFCJELKELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x28FE120", Offset = "0x28FD520", VA = "0x1828FE120")]
	public void BOAKGFBBALM(Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2901170", Offset = "0x2900570", VA = "0x182901170", Slot = "6")]
	public float3 LEGOMAEJGKP(Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2901C40", Offset = "0x2901040", VA = "0x182901C40")]
	public void PEJHJFHKCAB(Entity GKMECPLEALF, in quaternion AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2900900", Offset = "0x28FFD00", VA = "0x182900900", Slot = "8")]
	public quaternion KAJNNNFBNMK(Entity GKMECPLEALF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28FDE90", Offset = "0x28FD290", VA = "0x1828FDE90")]
	public void KKIOCJEEKAD(Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2901A70", Offset = "0x2900E70", VA = "0x182901A70", Slot = "12")]
	public float3 OLGJOKILPEF(Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2901360", Offset = "0x2900760", VA = "0x182901360", Slot = "15")]
	public float LENHBKBDNOC(Entity GKMECPLEALF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x28FE3D0", Offset = "0x28FD7D0", VA = "0x1828FE3D0", Slot = "14")]
	public void CLJCMNEALKH(Entity GKMECPLEALF, float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28FF170", Offset = "0x28FE570", VA = "0x1828FF170", Slot = "17")]
	public float3 FPECNNNPDIO(Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x28FEBD0", Offset = "0x28FDFD0", VA = "0x1828FEBD0")]
	public void KLLOPNBMNLN(Entity GKMECPLEALF, in float3 IOFHDEKIFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29004C0", Offset = "0x28FF8C0", VA = "0x1829004C0", Slot = "9")]
	public void JHNJPPBMDFI(Entity GKMECPLEALF, out float3 FGLOAKJBDBO, out quaternion OCEJJKMFIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x29006E0", Offset = "0x28FFAE0", VA = "0x1829006E0", Slot = "10")]
	public void JHNJPPBMDFI(Entity GKMECPLEALF, out RigidTransform IGFAAHIBKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28FFDD0", Offset = "0x28FF1D0", VA = "0x1828FFDD0", Slot = "37")]
	public void IJHLFCJJJOP(Entity GKMECPLEALF, out float3 FGLOAKJBDBO, out quaternion OCEJJKMFIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28FFC50", Offset = "0x28FF050", VA = "0x1828FFC50", Slot = "11")]
	public void IJHLFCJJJOP(Entity GKMECPLEALF, out RigidTransform IGFAAHIBKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28FF460", Offset = "0x28FE860", VA = "0x1828FF460")]
	public void IKHKFNJOIDD(Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28FDFF0", Offset = "0x28FD3F0", VA = "0x1828FDFF0", Slot = "19")]
	public float3 BIBFBOKINNF(Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28FFB10", Offset = "0x28FEF10", VA = "0x1828FFB10")]
	public void HNDHIGLEAHI(Entity GKMECPLEALF, in quaternion AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28FE2B0", Offset = "0x28FD6B0", VA = "0x1828FE2B0", Slot = "21")]
	public quaternion CKDDLMCPCBJ(Entity GKMECPLEALF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28FEE50", Offset = "0x28FE250", VA = "0x1828FEE50")]
	public void FHKAOGFALKK(Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2901040", Offset = "0x2900440", VA = "0x182901040", Slot = "22")]
	public float3 LDLMKAEFKOI(Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2900AC0", Offset = "0x28FFEC0", VA = "0x182900AC0", Slot = "24")]
	public void KJGIBFOKIBF(Entity GKMECPLEALF, float DLPLCAGLFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28FF070", Offset = "0x28FE470", VA = "0x1828FF070", Slot = "25")]
	public float FKKMKADPJLM(Entity GKMECPLEALF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2900D00", Offset = "0x2900100", VA = "0x182900D00")]
	public void LDEMGJAMPIP(Entity GKMECPLEALF, in float3 GLOHAKILNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29018A0", Offset = "0x2900CA0", VA = "0x1829018A0", Slot = "27")]
	public float3 MLKKLKNFHGF(Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28FF5A0", Offset = "0x28FE9A0", VA = "0x1828FF5A0", Slot = "32")]
	public void HIFNJJPAOGJ(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28FED70", Offset = "0x28FE170", VA = "0x1828FED70")]
	private HEKFLAGDMLJ ENCENJCMCMP(Transform DKKDEHMFAEC)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28FE6C0", Offset = "0x28FDAC0", VA = "0x1828FE6C0")]
	private static TransformEntity DIFDEKBEOKL(IMPAOGMALJN GANFKPHKNKH, GameObject OEHOBCLILGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2BE99F0", Offset = "0x2BE8DF0", VA = "0x182BE99F0")]
	private static T LLBEMJHOPOD<T>(GameObject OEHOBCLILGI) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x28FF340", Offset = "0x28FE740", VA = "0x1828FF340", Slot = "33")]
	public void GLBMEPBJMGF(Entity GKMECPLEALF, Entity PCAHPLBOKJA, Entity ICPFLJENDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public BLLGOKJBFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28FE120", Offset = "0x28FD520", VA = "0x1828FE120", Slot = "5")]
	private void MCKFPIIBALF(Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x29016D0", Offset = "0x2900AD0", VA = "0x1829016D0", Slot = "7")]
	private void LJOMKKJMNNJ(Entity GKMECPLEALF, in quaternion AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x28FDE90", Offset = "0x28FD290", VA = "0x1828FDE90", Slot = "13")]
	private void AJKPDDIFHMI(Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x28FEBD0", Offset = "0x28FDFD0", VA = "0x1828FEBD0", Slot = "16")]
	private void EKCLAJGKHPP(Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x28FF460", Offset = "0x28FE860", VA = "0x1828FF460", Slot = "18")]
	private void HDEFDCFGJPJ(Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x28FFB10", Offset = "0x28FEF10", VA = "0x1828FFB10", Slot = "20")]
	private void PODBMNAEMCM(Entity GKMECPLEALF, in quaternion AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x28FFC40", Offset = "0x28FF040", VA = "0x1828FFC40", Slot = "23")]
	private void IAMLAEGMOAE(Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x28FF160", Offset = "0x28FE560", VA = "0x1828FF160", Slot = "26")]
	private void FMOCMBNJLHO(Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2901A60", Offset = "0x2900E60", VA = "0x182901A60", Slot = "29")]
	private void NHGJNLOHGEB(Entity GKMECPLEALF, in float4x4 KANIJOBCBKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FODJLPEBFPB
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class IDDIDOGCIFG : FIPBNNCGAFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string MPLAFOBMEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly IDDIDOGCIFG JJOACLKIOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly List<IDDIDOGCIFG> HCHDKEIGIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly List<FLJMOFPACJP> OEGNIABGFIK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string OHELEMNJIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FIPBNNCGAFF NFIKKLEFHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<FIPBNNCGAFF> FEDNICELKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28EB200", Offset = "0x28EA600", VA = "0x1828EB200")]
	public IDDIDOGCIFG(string GDKOBCHHFLB, IDDIDOGCIFG OJBGDMNECON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
[EPJIKDLNGEH(typeof(CBPMCDKGJGE), new string[] { })]
internal class CBPMCDKGJGE : GMHONDBOJEM
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2903340", Offset = "0x2902740", VA = "0x182903340", Slot = "4")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public CBPMCDKGJGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[EPJIKDLNGEH(typeof(ONIGLBMFNHJ), new string[] { })]
public class EOAEFINEJCP : NEHPEGODEDF, ONIGLBMFNHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private FOODIHPHGKA ONGFGJMIFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private BEAMFJPLEGH OBNOKFDCHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29554E0", Offset = "0x29548E0", VA = "0x1829554E0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29552E0", Offset = "0x29546E0", VA = "0x1829552E0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29555B0", Offset = "0x29549B0", VA = "0x1829555B0", Slot = "5")]
	public bool NPIIJNENMJN(HEKFLAGDMLJ LEMCMBEMOCB, out Collider MPDBOOOIMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29552F0", Offset = "0x29546F0", VA = "0x1829552F0", Slot = "6")]
	public GameObject GBGGIADKNGG(HEKFLAGDMLJ ECDJDEJDOIJ, GameObject CCILALECBFJ, Vector3 IEGBDEAOAGE, Quaternion IKMDCPAAKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x29556F0", Offset = "0x2954AF0", VA = "0x1829556F0", Slot = "7")]
	public void PJPDOOGDNJI(GameObject MPDBOOOIMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x224D670", Offset = "0x224CA70", VA = "0x18224D670", Slot = "8")]
	public TCollider EOKACEMHNHK<TCollider>(GameObject MFGCADNGCJE) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2955280", Offset = "0x2954680", VA = "0x182955280", Slot = "9")]
	public void CJPCMLGELKH(Collider MPDBOOOIMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x224D640", Offset = "0x224CA40", VA = "0x18224D640", Slot = "10")]
	public GameObject DLIFOBLKBKC<TCollider>(string GDKOBCHHFLB) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EOAEFINEJCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KOFHIFAMDFK
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class NFCKPDCDELJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeList<NKHAMFBDDCG> HBFKHOAFGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NativeList<NBMOHGNDFOG> GDPMHLIENGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private NativeList<BOEBMGGFPKG> ANGNEAEDAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NativeList<NBMOHGNDFOG> NAHJDLACPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NativeList<NKHAMFBDDCG> IKHLLEOOCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9857D0", Offset = "0x984BD0", VA = "0x1809857D0")]
		get
		{
			return default(NativeList<NKHAMFBDDCG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NativeList<NBMOHGNDFOG> HBMONPAKCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9857E0", Offset = "0x984BE0", VA = "0x1809857E0")]
		get
		{
			return default(NativeList<NBMOHGNDFOG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<BOEBMGGFPKG> KCDGKJHBEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E60", Offset = "0xCE6260", VA = "0x180CE6E60")]
		get
		{
			return default(NativeList<BOEBMGGFPKG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NativeList<NBMOHGNDFOG> DPHEHBONAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x985800", Offset = "0x984C00", VA = "0x180985800")]
		get
		{
			return default(NativeList<NBMOHGNDFOG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JobHandle LJACDLDCJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA48C60", Offset = "0xA48060", VA = "0x180A48C60")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA490E0", Offset = "0xA484E0", VA = "0x180A490E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GAJGCDEBDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A79370", Offset = "0x2A78770", VA = "0x182A79370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2A79920", Offset = "0x2A78D20", VA = "0x182A79920")]
	public NFCKPDCDELJ(Allocator DGGNDNPDKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2A79890", Offset = "0x2A78C90", VA = "0x182A79890")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A79430", Offset = "0x2A78830", VA = "0x182A79430")]
	public void KAEENGGDABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2A79560", Offset = "0x2A78960", VA = "0x182A79560")]
	public void NNFBEGDMHOD(Entity GKMECPLEALF, Entity PCAHPLBOKJA, Entity ICPFLJENDFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class JADHGGCMKLB : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x28ECFD0", Offset = "0x28EC3D0", VA = "0x1828ECFD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x28ED070", Offset = "0x28EC470", VA = "0x1828ED070", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public JADHGGCMKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BOFOINMHPHO(FGCKLJIPPNH.OMRoom)]
internal class APMCHMCDCJP : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private KPNAFCNKGOC EILANMHJFJA;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x28FC5F0", Offset = "0x28FB9F0", VA = "0x1828FC5F0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x28FC640", Offset = "0x28FBA40", VA = "0x1828FC640", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public APMCHMCDCJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DCMAIFOADIC
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DPIAKNFAJAD
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class BNOMLNFFKGO<T> : MBMDIHFFGKJ<T>, FIPEENHHKAO<JDPNCHCMAIA, T>, IEPDOHHLJHK<JDPNCHCMAIA>, LKKBEGLFKGM, IDisposable, GPKGHEJLJCL where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEPDOHHLJHK<Entity> LEMJCNJPDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Delegate PEBLALKDODH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x20719C0", Offset = "0x2070DC0", VA = "0x1820719C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type OILIJCDIDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x206E330", Offset = "0x206D730", VA = "0x18206E330", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LFHCENHMBCH GOPBFOMCJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x206D560", Offset = "0x206C960", VA = "0x18206D560", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HCGDGPKMKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x206D830", Offset = "0x206CC30", VA = "0x18206D830", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public ENOELDAICIL LMBDELGFHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x206D650", Offset = "0x206CA50", VA = "0x18206D650", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event IAFCDGIJOEA<JDPNCHCMAIA> HLFBHENDGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2070640", Offset = "0x206FA40", VA = "0x182070640", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2070900", Offset = "0x206FD00", VA = "0x182070900", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2073D80", Offset = "0x2073180", VA = "0x182073D80")]
	public BNOMLNFFKGO(IEPDOHHLJHK<Entity> LEMJCNJPDLJ, IMBCAHJKJCI CNNBPGGDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x206DE60", Offset = "0x206D260", VA = "0x18206DE60")]
	private Entity DJKLNEJICMK(JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x206DE30", Offset = "0x206D230", VA = "0x18206DE30")]
	private JDPNCHCMAIA DJKLNEJICMK(Entity GKMECPLEALF)
	{
		return default(JDPNCHCMAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2072B40", Offset = "0x2071F40", VA = "0x182072B40", Slot = "4")]
	public T PHGLOPEHIMO(JDPNCHCMAIA DDCHJBPICDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x206D230", Offset = "0x206C630", VA = "0x18206D230")]
	public bool AFLFAPDAOKF(JDPNCHCMAIA DDCHJBPICDC, in T PINJDLEFOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x206E510", Offset = "0x206D910", VA = "0x18206E510", Slot = "7")]
	public bool HFDNCCJGOAI(JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2072810", Offset = "0x2071C10", VA = "0x182072810", Slot = "8")]
	public void PHGLOPEHIMO(JDPNCHCMAIA DDCHJBPICDC, KKEKCMELKKJ AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x206D020", Offset = "0x206C420", VA = "0x18206D020", Slot = "9")]
	public bool AFLFAPDAOKF(JDPNCHCMAIA DDCHJBPICDC, CIMGDHMJEHM PINJDLEFOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2071A60", Offset = "0x2070E60", VA = "0x182071A60", Slot = "16")]
	public void OMAPCNDDLGL(EJLEFJCKIEJ ACLKHAFOJLC, [Optional] object AKPCLGIGABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x206E090", Offset = "0x206D490", VA = "0x18206E090", Slot = "10")]
	public bool EMCLIHJFPMF(JDPNCHCMAIA NBCAFBHOFIE, JDPNCHCMAIA CIDBOBPIINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x206E060", Offset = "0x206D460", VA = "0x18206E060", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2073A60", Offset = "0x2072E60", VA = "0x182073A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2071CC0", Offset = "0x20710C0", VA = "0x182071CC0")]
	private void PCAAFIDODME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2071220", Offset = "0x2070620", VA = "0x182071220")]
	private void KJOIKOBGPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x206FA80", Offset = "0x206EE80", VA = "0x18206FA80")]
	private void HFIELIGKBMK(Entity GKMECPLEALF, in CIMGDHMJEHM FNIKJMODJCE, in CIMGDHMJEHM PINJDLEFOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x206DA10", Offset = "0x206CE10", VA = "0x18206DA10")]
	private void CEIMEADLILL(Entity GKMECPLEALF, in CIMGDHMJEHM FNIKJMODJCE, in CIMGDHMJEHM PINJDLEFOFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class ENJLNBJHJBC : JFGEDJGHDDN
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2954D80", Offset = "0x2954180", VA = "0x182954D80", Slot = "5")]
	public override Action JBHGDLCJEJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void COKAJFENMLF<T>() where T : AKHJKCAIBOP;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2954CF0", Offset = "0x29540F0", VA = "0x182954CF0")]
	[UnityEngine.Scripting.Preserve]
	public void EDICCMGOAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2954E10", Offset = "0x2954210", VA = "0x182954E10")]
	protected ENJLNBJHJBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[EPJIKDLNGEH(typeof(EMGCNKHPFCN), new string[] { })]
public class CDKFPJFAMMB : NEHPEGODEDF, EMGCNKHPFCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2904630", Offset = "0x2903A30", VA = "0x182904630", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x29046B0", Offset = "0x2903AB0", VA = "0x1829046B0", Slot = "5")]
	public void KIPFBJDDMNG(HEKFLAGDMLJ JBFCCDGDFOM, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x21BF220", Offset = "0x21BE620", VA = "0x1821BF220")]
	private void AFLFAPDAOKF<T>(HEKFLAGDMLJ JBFCCDGDFOM, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public CDKFPJFAMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[EPJIKDLNGEH(typeof(ADEFNGMMPNA), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public class ADEFNGMMPNA : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class OAFPNFDGKCG : IEnumerable<COBFMFPIDNL>, IEnumerable, IEnumerator<COBFMFPIDNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private COBFMFPIDNL <>2__current;

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
		public ADEFNGMMPNA <>4__this;

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
		private KGCLIDEHBDE <rbex>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private COBFMFPIDNL System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public OAFPNFDGKCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x27BA660", Offset = "0x27B9A60", VA = "0x1827BA660", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x27BA310", Offset = "0x27B9710", VA = "0x1827BA310", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x27BA520", Offset = "0x27B9920", VA = "0x1827BA520")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x27BA620", Offset = "0x27B9A20", VA = "0x1827BA620", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x27BA570", Offset = "0x27B9970", VA = "0x1827BA570", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<COBFMFPIDNL> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x27BA570", Offset = "0x27B9970", VA = "0x1827BA570", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> MJMMCJPDANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x28F9F70", Offset = "0x28F9370", VA = "0x1828F9F70", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x28FA8A0", Offset = "0x28F9CA0", VA = "0x1828FA8A0")]
	public void PFEFDJFGFCD(NativeArray<Entity> NOEOKDNGNCK, bool NGPHFDLPKDK, bool IHKJAHPKJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x28FA670", Offset = "0x28F9A70", VA = "0x1828FA670")]
	public void LHMCJONPOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x28F9FC0", Offset = "0x28F93C0", VA = "0x1828F9FC0")]
	private void KIKCDAGBKIK(NativeArray<Entity> NOEOKDNGNCK, bool NGPHFDLPKDK, bool IHKJAHPKJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x28F9D80", Offset = "0x28F9180", VA = "0x1828F9D80")]
	[IteratorStateMachine(typeof(OAFPNFDGKCG))]
	private IEnumerable<COBFMFPIDNL> AFDADACBBPJ(NativeArray<Entity> NOEOKDNGNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x28F9E10", Offset = "0x28F9210", VA = "0x1828F9E10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x28FAA50", Offset = "0x28F9E50", VA = "0x1828FAA50")]
	public ADEFNGMMPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
[EPJIKDLNGEH(typeof(FDDOEJHEPEH), new string[] { })]
public class FDDOEJHEPEH : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<NativeListAsync<IICPIKDEMDN>> KHGEAFLMBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x295F870", Offset = "0x295EC70", VA = "0x18295F870", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x295FCC0", Offset = "0x295F0C0", VA = "0x18295FCC0")]
	public void PFEFDJFGFCD(NativeListAsync<IICPIKDEMDN> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x295F8C0", Offset = "0x295ECC0", VA = "0x18295F8C0")]
	public void LHMCJONPOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x295F710", Offset = "0x295EB10", VA = "0x18295F710", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x295FDC0", Offset = "0x295F1C0", VA = "0x18295FDC0")]
	public FDDOEJHEPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class KADMIOCINAO
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly ProfilerMarker LNONFLAIMPO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly ProfilerMarker KNPKGEHLDMI;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x28F7BF0", Offset = "0x28F6FF0", VA = "0x1828F7BF0")]
	public static void FIPMMMKIJLD(this DOFBPGFFJDE CEMAJLICLCP, NFLPKIOPICE BLBMFDIEDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x28F7880", Offset = "0x28F6C80", VA = "0x1828F7880")]
	public static void CDNAEEEMLOC(this DOFBPGFFJDE CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x28F7FE0", Offset = "0x28F73E0", VA = "0x1828F7FE0")]
	private static string[] KPEFHFAPPNI(NFLPKIOPICE BLBMFDIEDCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28F7A30", Offset = "0x28F6E30", VA = "0x1828F7A30")]
	private static bool FDPHFOAFLDN(NFLPKIOPICE BLBMFDIEDCO, out string[] GLNBKBOCGHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8228B0", Offset = "0x821CB0", VA = "0x1808228B0")]
	private static bool LOIJNMGNCJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[EPJIKDLNGEH(typeof(IMBCAHJKJCI), new string[] { })]
public class EOBGNHBCOHM : NEHPEGODEDF, IMBCAHJKJCI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly EHKEPJIBENP KOJDNDNCJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[BOJGNOMIPCG]
	private FFCBJDNAPKG NNFPDEGNOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[BOJGNOMIPCG]
	private LFMJEINKAPC BHEMNPHLEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[BOJGNOMIPCG]
	private COKHJGJNDIB HJBFJMLNKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[BOJGNOMIPCG]
	private JFEOPDDGNAJ PJGJLPEKIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[BOJGNOMIPCG]
	private CEPHAKHFAFK NEJHPGNLCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private NDDKNGFIEKO PCEDMCPKNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private GGPOHFHPOPM OJMPJGNAJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public OMJPGCFKPLM JHAIGONPOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xC2F760", Offset = "0xC2EB60", VA = "0x180C2F760", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(OMJPGCFKPLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x119A640", Offset = "0x1199A40", VA = "0x18119A640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<FDJPAKEFOJE, NativeArray<IMPAOGMALJN>> OJINPMLFCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2955EA0", Offset = "0x29552A0", VA = "0x182955EA0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2956380", Offset = "0x2955780", VA = "0x182956380", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<FDJPAKEFOJE> BKENOIEFKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2956750", Offset = "0x2955B50", VA = "0x182956750", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2956420", Offset = "0x2955820", VA = "0x182956420", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x29567F0", Offset = "0x2955BF0", VA = "0x1829567F0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2955F40", Offset = "0x2955340", VA = "0x182955F40", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x29558D0", Offset = "0x2954CD0", VA = "0x1829558D0")]
	private void BCNHGOGPCGE(FDJPAKEFOJE JCKPFMCHBED, NativeArray<IMPAOGMALJN> HGLHDDKIKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2956B50", Offset = "0x2955F50", VA = "0x182956B50")]
	private void LDIIHAPANEK(FDJPAKEFOJE JCKPFMCHBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2955820", Offset = "0x2954C20", VA = "0x182955820")]
	internal HEKFLAGDMLJ ABOPLEIFCAD(Entity GKMECPLEALF)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2955C90", Offset = "0x2955090", VA = "0x182955C90", Slot = "11")]
	public NILIGAKBOAA BOPDAANMFBE(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(NILIGAKBOAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2956CC0", Offset = "0x29560C0", VA = "0x182956CC0", Slot = "12")]
	public IMPAOGMALJN LOONLFGPLMG(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(IMPAOGMALJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x29565B0", Offset = "0x29559B0", VA = "0x1829565B0", Slot = "39")]
	public bool HFDNCCJGOAI(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2956170", Offset = "0x2955570", VA = "0x182956170", Slot = "34")]
	public void FCGGIDBOLFJ(FDJPAKEFOJE GAOJFDPACED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x29560D0", Offset = "0x29554D0", VA = "0x1829560D0", Slot = "35")]
	public void EHKLIGBABLK(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2955870", Offset = "0x2954C70", VA = "0x182955870", Slot = "36")]
	public void ADLMBBDHIJK(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2956130", Offset = "0x2955530", VA = "0x182956130", Slot = "37")]
	public void FCGGIDBOLFJ(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2956320", Offset = "0x2955720", VA = "0x182956320", Slot = "24")]
	public FDJPAKEFOJE FLILGDFALDL(NativeArray<JDPNCHCMAIA> DDCHJBPICDC, Allocator DGGNDNPDKKD)
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2955B40", Offset = "0x2954F40", VA = "0x182955B40", Slot = "25")]
	public FDJPAKEFOJE BEGKLCGFGLD(NativeArray<JDPNCHCMAIA> DDCHJBPICDC, NativeArray<BACOLBMJCKD> LHMBGJCLFKL, Allocator DGGNDNPDKKD)
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2956F80", Offset = "0x2956380", VA = "0x182956F80", Slot = "26")]
	public MDECDPGCMCD MAHAICGFPFA(IMPAOGMALJN JBGKOICMKNG, bool MBDCIOFDMHF)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2956EA0", Offset = "0x29562A0", VA = "0x182956EA0", Slot = "27")]
	public MDECDPGCMCD MAHAICGFPFA(IMPAOGMALJN JBGKOICMKNG)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2956A20", Offset = "0x2955E20", VA = "0x182956A20", Slot = "28")]
	public MDECDPGCMCD JAGJFGHADMB(IMPAOGMALJN JBGKOICMKNG)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2957140", Offset = "0x2956540", VA = "0x182957140", Slot = "29")]
	public MDECDPGCMCD NLOADONOICP(IMPAOGMALJN JBGKOICMKNG)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2955950", Offset = "0x2954D50", VA = "0x182955950", Slot = "30")]
	public MDECDPGCMCD BEGKLCGFGLD(JDPNCHCMAIA DDCHJBPICDC, IMPAOGMALJN JBGKOICMKNG)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2956640", Offset = "0x2955A40", VA = "0x182956640", Slot = "31")]
	public IGCAMFAHCMC IKLJBOFADML()
	{
		return default(IGCAMFAHCMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x29564C0", Offset = "0x29558C0", VA = "0x1829564C0", Slot = "32")]
	public MKIIJMKIKEO GIOEOGPFLEP()
	{
		return default(MKIIJMKIKEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2956BC0", Offset = "0x2955FC0", VA = "0x182956BC0", Slot = "33")]
	public OAGDIDHKOIF LEPFNPDPKPM(DJOJBOPMMAC GANFKPHKNKH)
	{
		return default(OAGDIDHKOIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2956090", Offset = "0x2955490", VA = "0x182956090", Slot = "13")]
	public void EHBDNPLCIKI(JDPNCHCMAIA DDCHJBPICDC, KINEJENHFEI GIMDOLBCAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2956D50", Offset = "0x2956150", VA = "0x182956D50", Slot = "14")]
	public MDECDPGCMCD LPGPBDHIJGJ(HEKFLAGDMLJ LEMCMBEMOCB, [Optional] object AEMEEHLIDCM)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2955E00", Offset = "0x2955200", VA = "0x182955E00", Slot = "15")]
	public bool DFFNJGBMJCN(HEKFLAGDMLJ LEMCMBEMOCB, out KINEJENHFEI MOOEDNDCGLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2955D60", Offset = "0x2955160", VA = "0x182955D60", Slot = "16")]
	public bool DAJCKLBFICP(HEKFLAGDMLJ LEMCMBEMOCB, out Transform DKKDEHMFAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2955CD0", Offset = "0x29550D0", VA = "0x182955CD0", Slot = "17")]
	public bool CNIFBOMIGIC(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2956250", Offset = "0x2955650", VA = "0x182956250", Slot = "18")]
	public void FDENDKGBGMI(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2956B00", Offset = "0x2955F00", VA = "0x182956B00", Slot = "19")]
	public bool KLHFNHDCKBB(LocalId LEMCMBEMOCB, object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x29565F0", Offset = "0x29559F0", VA = "0x1829565F0", Slot = "20")]
	public bool IBFCLOIPLKD(LocalId LEMCMBEMOCB, object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x29572B0", Offset = "0x29566B0", VA = "0x1829572B0", Slot = "38")]
	public FDJPAKEFOJE OHHBKCKEINJ(FDJPAKEFOJE HAMAKNIIOKD, Allocator DGGNDNPDKKD)
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2957100", Offset = "0x2956500", VA = "0x182957100", Slot = "23")]
	public JDPNCHCMAIA NLIKCLIKHPF(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(JDPNCHCMAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x29562E0", Offset = "0x29556E0", VA = "0x1829562E0", Slot = "21")]
	public HEKFLAGDMLJ FLILGDFALDL(JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x29560B0", Offset = "0x29554B0", VA = "0x1829560B0", Slot = "22")]
	public bool EHDJALGIOME(JDPNCHCMAIA DDCHJBPICDC, out HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2957070", Offset = "0x2956470", VA = "0x182957070")]
	private void NFIMEIFFODI(IMPAOGMALJN DHGLPENOPHB, HEKFLAGDMLJ LEMCMBEMOCB, JDPNCHCMAIA DDCHJBPICDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EOBGNHBCOHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[EPJIKDLNGEH(typeof(EHLKKIDPCHN), new string[] { })]
public class LCHBHEIFDKN : NEHPEGODEDF, EHLKKIDPCHN
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[BOJGNOMIPCG]
	private HMHHFNDBEKM OCKKDLPLKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[BOJGNOMIPCG]
	private NKIFCJBAGBF JPGDAAPDBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[BOJGNOMIPCG]
	private OEGCJPFACKE MFIKDLJMLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[BOJGNOMIPCG]
	private MDPDEGLCMGA NEDHMAOKAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[BOJGNOMIPCG]
	private AHJMHEDKMKK FIFIJDGGGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private World GPJPADMHJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private IBCENFMLMKG KKJPAAMLNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private IBCENFMLMKG NFFGMHNOLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IBCENFMLMKG MFBPNEFAHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private IBCENFMLMKG CMFLHIMELOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private IBCENFMLMKG GDPDGAOKOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private IBCENFMLMKG JPAAPBKLMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private IBCENFMLMKG HCKFODAKKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private IBCENFMLMKG CJHHIAINGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private IBCENFMLMKG LOHHCPBMGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private IBCENFMLMKG BEEEKNHAPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private IBCENFMLMKG KEKMEHGACKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private IBCENFMLMKG CAIOGLFEAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private IBCENFMLMKG AMKOFDJJJAH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool FCIFENNHMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A67020", Offset = "0x2A66420", VA = "0x182A67020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool DOBGIILCKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A668B0", Offset = "0x2A65CB0", VA = "0x182A668B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool PEFBEKDNAEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A66AF0", Offset = "0x2A65EF0", VA = "0x182A66AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool FFHCCFPBOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A66AF0", Offset = "0x2A65EF0", VA = "0x182A66AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A66B70", Offset = "0x2A65F70", VA = "0x182A66B70", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2374D80", Offset = "0x2374180", VA = "0x182374D80")]
	private IBCENFMLMKG DGLBDIOIPBK<T>() where T : GBPLGIOBJHG
	{
		return default(IBCENFMLMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A66920", Offset = "0x2A65D20", VA = "0x182A66920")]
	private IBCENFMLMKG DGLBDIOIPBK(Type GANFKPHKNKH)
	{
		return default(IBCENFMLMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A66FF0", Offset = "0x2A663F0", VA = "0x182A66FF0", Slot = "14")]
	public void LLJGJHNOFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A66B40", Offset = "0x2A65F40", VA = "0x182A66B40", Slot = "15")]
	public void IMONOOFMJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A669D0", Offset = "0x2A65DD0", VA = "0x182A669D0", Slot = "5")]
	public void GKGKJPMACBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A67130", Offset = "0x2A66530", VA = "0x182A67130", Slot = "6")]
	public void NIABPELNNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A670B0", Offset = "0x2A664B0", VA = "0x182A670B0", Slot = "7")]
	public void MJJHEMGMNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A67230", Offset = "0x2A66630", VA = "0x182A67230", Slot = "8")]
	public void OGBCMCOINPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A66950", Offset = "0x2A65D50", VA = "0x182A66950", Slot = "9")]
	public void FHFAJAIMJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A669F0", Offset = "0x2A65DF0", VA = "0x182A669F0", Slot = "10")]
	public void GKGOBDGENHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A671B0", Offset = "0x2A665B0", VA = "0x182A671B0", Slot = "11")]
	public void OFEBKDILOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A66B00", Offset = "0x2A65F00", VA = "0x182A66B00", Slot = "12")]
	public void IEMLMDBJMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A67330", Offset = "0x2A66730", VA = "0x182A67330", Slot = "13")]
	public void OONBANEIOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A672B0", Offset = "0x2A666B0", VA = "0x182A672B0")]
	private void OKBBEJELJJO(IBCENFMLMKG GDOFPEAGKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A66F70", Offset = "0x2A66370", VA = "0x182A66F70")]
	private void JOKLDLEEPLC(IBCENFMLMKG GDOFPEAGKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A66AD0", Offset = "0x2A65ED0", VA = "0x182A66AD0")]
	private void HEKKEPHAEDF(IBCENFMLMKG GDOFPEAGKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public LCHBHEIFDKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
[EPJIKDLNGEH(typeof(FEALACGMELJ), new string[] { "Editor" })]
public sealed class FEALACGMELJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void GDOJDDDBJCA(JDPNCHCMAIA LPDFIBCDEJA, BACOLBMJCKD CLCAIFLMLCJ, bool DPNFBOJEEKD);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void PDEKFHNGFGJ(JDPNCHCMAIA LPDFIBCDEJA, bool DPNFBOJEEKD);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void DFOMHIHBDGL(JDPNCHCMAIA LPDFIBCDEJA, FDOJMOENJAL LEMJCNJPDLJ, in CIMGDHMJEHM AGLCIEKHLEE, bool DPNFBOJEEKD);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public FEALACGMELJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[EPJIKDLNGEH(typeof(global::HDHFLPILNPM), new string[] { })]
internal class EIFLELBPCOM : global::HDHFLPILNPM, NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[BOJGNOMIPCG]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[BOJGNOMIPCG]
	private OHAMPNBKDLP LJNICDIKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[BOJGNOMIPCG]
	private FOMKJGJNDPD OEGNIABGFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[BOJGNOMIPCG]
	private DFIJJNIGPNA EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Action<JPKFBBKCAIK> IPDGCBIIEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private DFGKOFELELE<Entity> OJBGDMNECON;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<JPKFBBKCAIK> PMHLBEAPEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2953DF0", Offset = "0x29531F0", VA = "0x182953DF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2953CB0", Offset = "0x29530B0", VA = "0x182953CB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2953FD0", Offset = "0x29533D0", VA = "0x182953FD0", Slot = "6")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2953B40", Offset = "0x2952F40", VA = "0x182953B40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2953DF0", Offset = "0x29531F0", VA = "0x182953DF0")]
	private void FOBLIEAPGKL(Action<JPKFBBKCAIK> AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2953CB0", Offset = "0x29530B0", VA = "0x182953CB0")]
	private void KJJMMPMLEFF(Action<JPKFBBKCAIK> AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2953F30", Offset = "0x2953330", VA = "0x182953F30")]
	private void HGDNNEBCFNN(CNKGMANFGNC CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EIFLELBPCOM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct PEIKDMNHALO : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	public void OnCreate(ref SystemState HEAMCFPFNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
	public void OnDestroy(ref SystemState HEAMCFPFNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x24835A0", Offset = "0x24829A0", VA = "0x1824835A0", Slot = "6")]
	public void OnUpdate(ref SystemState HEAMCFPFNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void HCJMIJHKMGG(IntPtr ODBHDBFBMOB, IntPtr HEAMCFPFNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x24835A0", Offset = "0x24829A0", VA = "0x1824835A0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void KCKECNEJEHH(IntPtr ODBHDBFBMOB, IntPtr HEAMCFPFNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void OHMLBNDMFCD(IntPtr ODBHDBFBMOB, IntPtr HEAMCFPFNOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BOFOINMHPHO(FGCKLJIPPNH.OMRoom)]
internal class HAPHNHIPDNJ : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NBPNODCEBKF PFIBEKNCGIG;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x28E3400", Offset = "0x28E2800", VA = "0x1828E3400", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x28E3450", Offset = "0x28E2850", VA = "0x1828E3450", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public HAPHNHIPDNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class NJLPIFCFDMG : JFGEDJGHDDN
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private enum FKENHKBIDGF
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A980", Offset = "0x2A79D80", VA = "0x182A7A980", Slot = "5")]
	public override Action JBHGDLCJEJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void NGJNBPGHOAI<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A8F0", Offset = "0x2A79CF0", VA = "0x182A7A8F0")]
	[UnityEngine.Scripting.Preserve]
	public void EDICCMGOAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2954E10", Offset = "0x2954210", VA = "0x182954E10")]
	protected NJLPIFCFDMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(DBDLLHJFBEC), new string[] { })]
public class DBDLLHJFBEC : NEHPEGODEDF, BKHNPHMEICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NDDKNGFIEKO PCEDMCPKNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private KCPMLDAAPLA OEGNIABGFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private FDOJMOENJAL[] AHLBGLGKNGM;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2914870", Offset = "0x2913C70", VA = "0x182914870", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x29148E0", Offset = "0x2913CE0", VA = "0x1829148E0", Slot = "5")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2914BB0", Offset = "0x2913FB0", VA = "0x182914BB0")]
	public void PCLBKKBLHDI(JDPNCHCMAIA DDCHJBPICDC, bool FCCBJLFFLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public DBDLLHJFBEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[EPJIKDLNGEH(typeof(IJGPMAMDKLF), new string[] { })]
[DefaultMember("Item")]
public class JHNOMHJJAEF : IJGPMAMDKLF, IEnumerable<KEJDGFDNFFK>, IEnumerable, BLHEKNIGKIO, GMHONDBOJEM, NEHPEGODEDF, BKHNPHMEICP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[BOJGNOMIPCG]
	private FOMKJGJNDPD OEGNIABGFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(Type, string), int> GPDEAFMPGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeBitArray KOPBNELBMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<int> CAOBAELPIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private OPKICLGEFDB CNMPMFJNKBM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public NativeBitArray JLNKKAAIDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9857E0", Offset = "0x984BE0", VA = "0x1809857E0", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NativeArray<int> HIKFECLFIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E60", Offset = "0xCE6260", VA = "0x180CE6E60", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private int NFPKAJJCJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x904190", Offset = "0x903590", VA = "0x180904190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28F6980", Offset = "0x28F5D80", VA = "0x1828F6980", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public KEJDGFDNFFK ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28F6940", Offset = "0x28F5D40", VA = "0x1828F6940", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public KEJDGFDNFFK ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28F6940", Offset = "0x28F5D40", VA = "0x1828F6940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x28F66F0", Offset = "0x28F5AF0", VA = "0x1828F66F0", Slot = "13")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x28F6AF0", Offset = "0x28F5EF0", VA = "0x1828F6AF0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "15")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x28F6D70", Offset = "0x28F6170", VA = "0x1828F6D70")]
	private void MKKBPKINMNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x28F6740", Offset = "0x28F5B40", VA = "0x1828F6740", Slot = "9")]
	public KEJDGFDNFFK DNDGKGKJHCH(LOHCJILDMLL OCFGMKDOPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x28F69A0", Offset = "0x28F5DA0", VA = "0x1828F69A0")]
	private bool IOGFGMOOLCA(Type FEPLAPMKDOJ, string GDKOBCHHFLB, out KEJDGFDNFFK HAIJKGCOLFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x28F6B70", Offset = "0x28F5F70", VA = "0x1828F6B70", Slot = "10")]
	public FDOJMOENJAL LEEAMPOIODD(LOHCJILDMLL OCFGMKDOPDP)
	{
		return default(FDOJMOENJAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x28F6960", Offset = "0x28F5D60", VA = "0x1828F6960", Slot = "11")]
	public IEnumerator<KEJDGFDNFFK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x28F6960", Offset = "0x28F5D60", VA = "0x1828F6960", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x28F68F0", Offset = "0x28F5CF0", VA = "0x1828F68F0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x28F7180", Offset = "0x28F6580", VA = "0x1828F7180")]
	public JHNOMHJJAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class PMODBNNDECA
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2487920", Offset = "0x2486D20", VA = "0x182487920")]
	public static void LAAMJIICBMK(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in float3 IEGBDEAOAGE, in quaternion IKMDCPAAKBK, in float3 ANIJDMIGILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2488690", Offset = "0x2487A90", VA = "0x182488690")]
	public static void PJHLMELAEHD(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, out float4x4 JDFCJELKELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x24887D0", Offset = "0x2487BD0", VA = "0x1824887D0")]
	private static void PJHLMELAEHD(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, Entity OJBGDMNECON, out float4x4 JDFCJELKELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2486AF0", Offset = "0x2485EF0", VA = "0x182486AF0")]
	public static void IOCOEGNBODE(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in float4x4 JDFCJELKELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2486EE0", Offset = "0x24862E0", VA = "0x182486EE0")]
	public static void JAKKNINPMEM(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, out float4x4 MLDAHPKMLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2485D70", Offset = "0x2485170", VA = "0x182485D70")]
	public static void FDJKMGEMALN(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in float4x4 MLDAHPKMLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2487F60", Offset = "0x2487360", VA = "0x182487F60")]
	public static float3 LEGOMAEJGKP(EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2485A00", Offset = "0x2484E00", VA = "0x182485A00")]
	public static void BOAKGFBBALM(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x24874E0", Offset = "0x24868E0", VA = "0x1824874E0")]
	public static quaternion KAJNNNFBNMK(EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x24885D0", Offset = "0x24879D0", VA = "0x1824885D0")]
	public static void PEJHJFHKCAB(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in quaternion AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2488500", Offset = "0x2487900", VA = "0x182488500")]
	public static float3 OLGJOKILPEF(EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2487710", Offset = "0x2486B10", VA = "0x182487710")]
	public static void KKIOCJEEKAD(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2488060", Offset = "0x2487460", VA = "0x182488060")]
	public static float LENHBKBDNOC(EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2485CF0", Offset = "0x24850F0", VA = "0x182485CF0")]
	public static void CLJCMNEALKH(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2486310", Offset = "0x2485710", VA = "0x182486310")]
	public static float3 FPECNNNPDIO(EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2487890", Offset = "0x2486C90", VA = "0x182487890")]
	public static void KLLOPNBMNLN(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x24873F0", Offset = "0x24867F0", VA = "0x1824873F0")]
	public static void JHNJPPBMDFI(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, out RigidTransform MLDAHPKMLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x24872D0", Offset = "0x24866D0", VA = "0x1824872D0")]
	public static void JHNJPPBMDFI(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, out float3 FGLOAKJBDBO, out quaternion OCEJJKMFIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2488440", Offset = "0x2487840", VA = "0x182488440")]
	public static void OGPHCDEGMHE(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in float3 IEGBDEAOAGE, in quaternion IKMDCPAAKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x24865F0", Offset = "0x24859F0", VA = "0x1824865F0")]
	public static void IJHLFCJJJOP(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, out float3 FGLOAKJBDBO, out quaternion OCEJJKMFIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2485790", Offset = "0x2484B90", VA = "0x182485790")]
	public static float3 BIBFBOKINNF(EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2486850", Offset = "0x2485C50", VA = "0x182486850")]
	public static void IKHKFNJOIDD(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2486400", Offset = "0x2485800", VA = "0x182486400")]
	public static void HNDHIGLEAHI(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in quaternion AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2485AC0", Offset = "0x2484EC0", VA = "0x182485AC0")]
	public static quaternion CKDDLMCPCBJ(EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2487CA0", Offset = "0x24870A0", VA = "0x182487CA0")]
	public static float3 LDLMKAEFKOI(EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2485EB0", Offset = "0x24852B0", VA = "0x182485EB0")]
	public static void FHKAOGFALKK(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2486120", Offset = "0x2485520", VA = "0x182486120")]
	public static float FKKMKADPJLM(EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x24875D0", Offset = "0x24869D0", VA = "0x1824875D0")]
	public static void KJGIBFOKIBF(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, float DLPLCAGLFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2488130", Offset = "0x2487530", VA = "0x182488130")]
	public static float3 MLKKLKNFHGF(EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x24879C0", Offset = "0x2486DC0", VA = "0x1824879C0")]
	public static void LDEMGJAMPIP(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, in float3 GLOHAKILNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x24883A0", Offset = "0x24877A0", VA = "0x1824883A0")]
	public static bool NLIDJDEIIPL(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, out Entity OJBGDMNECON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[EPJIKDLNGEH(typeof(FIOENEMHNNB), new string[] { })]
public class JGAIJFGLLHM : NEHPEGODEDF, FIOENEMHNNB
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OJCLFEABINP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public HEKFLAGDMLJ localId;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OJCLFEABINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x27BB0D0", Offset = "0x27BA4D0", VA = "0x1827BB0D0")]
		internal object NGHBKOPCPFG(JGAIJFGLLHM a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class PGIPIKMBACJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HEKFLAGDMLJ localId;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PGIPIKMBACJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x27BCBC0", Offset = "0x27BBFC0", VA = "0x1827BCBC0")]
		internal object KMNHBDJKLAK(JGAIJFGLLHM a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private GGNFHIGGHPN IIGHBGGPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private World GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private KILFBCLKOFO FFDCACMLGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[BOJGNOMIPCG]
	private JEGMBOPKKDO PHLDDLGGOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private EntityManager IJFLNDEIEIK;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x28F39F0", Offset = "0x28F2DF0", VA = "0x1828F39F0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x28F2960", Offset = "0x28F1D60", VA = "0x1828F2960", Slot = "6")]
	public COBFMFPIDNL FFCDGIAACKB(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x28F1540", Offset = "0x28F0940", VA = "0x1828F1540", Slot = "5")]
	public void BEBJLEMGPFA(HEKFLAGDMLJ LEMCMBEMOCB, COBFMFPIDNL AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x28F3800", Offset = "0x28F2C00", VA = "0x1828F3800", Slot = "31")]
	public CollisionDetectionMode IJPMPCMJBOP(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x28F4400", Offset = "0x28F3800", VA = "0x1828F4400", Slot = "32")]
	public void KGNCMCNGCOH(HEKFLAGDMLJ LEMCMBEMOCB, CollisionDetectionMode AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x28F49C0", Offset = "0x28F3DC0", VA = "0x1828F49C0", Slot = "33")]
	public JDKBOLPCEHA LCOILKEDMPH(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(JDKBOLPCEHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x28F4260", Offset = "0x28F3660", VA = "0x1828F4260", Slot = "34")]
	public void KCNFJNJCNBH(HEKFLAGDMLJ LEMCMBEMOCB, JDKBOLPCEHA AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x28F3ED0", Offset = "0x28F32D0", VA = "0x1828F3ED0", Slot = "35")]
	public bool JNFEKFHHMJL(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x28F26C0", Offset = "0x28F1AC0", VA = "0x1828F26C0", Slot = "36")]
	public void EHOIIBCPCCF(HEKFLAGDMLJ LEMCMBEMOCB, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x28F4830", Offset = "0x28F3C30", VA = "0x1828F4830", Slot = "37")]
	public HEKFLAGDMLJ LAAKJDOAPFC(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x28F1B00", Offset = "0x28F0F00", VA = "0x1828F1B00", Slot = "38")]
	public void CKNPMPBKFGC(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x28F5A40", Offset = "0x28F4E40", VA = "0x1828F5A40", Slot = "39")]
	public HEKFLAGDMLJ OPCIHBBNLKJ(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x28F1A30", Offset = "0x28F0E30", VA = "0x1828F1A30", Slot = "40")]
	public void CILNNMACHKK(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x28F2F90", Offset = "0x28F2390", VA = "0x1828F2F90", Slot = "7")]
	public void GKKELJKGEHE(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x28F23E0", Offset = "0x28F17E0", VA = "0x1828F23E0", Slot = "8")]
	public void EFGKFCOBOBC(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x28F5940", Offset = "0x28F4D40", VA = "0x1828F5940", Slot = "9")]
	public int ONPGMOCNIHI(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x28F51E0", Offset = "0x28F45E0", VA = "0x1828F51E0", Slot = "10")]
	public HEKFLAGDMLJ MPHOKIEHNNB(HEKFLAGDMLJ LEMCMBEMOCB, int BNOAGGNAMKG)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x28F1BD0", Offset = "0x28F0FD0", VA = "0x1828F1BD0", Slot = "11")]
	public void CMHPBHFEGGF(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x28F1E50", Offset = "0x28F1250", VA = "0x1828F1E50", Slot = "12")]
	public void EAFBNGGMBCD(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM, HEKFLAGDMLJ AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x28F54A0", Offset = "0x28F48A0", VA = "0x1828F54A0", Slot = "13")]
	public void NOHIONLFOAF(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x28F1FB0", Offset = "0x28F13B0", VA = "0x1828F1FB0", Slot = "14")]
	public bool EBGGKBECIAA(HEKFLAGDMLJ LEMCMBEMOCB, out HEKFLAGDMLJ AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x28F4600", Offset = "0x28F3A00", VA = "0x1828F4600", Slot = "15")]
	public void KPOCBEJCLKH(HEKFLAGDMLJ LEMCMBEMOCB, float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x28F2B10", Offset = "0x28F1F10", VA = "0x1828F2B10", Slot = "16")]
	public bool FOAJNNOLAGH(HEKFLAGDMLJ LEMCMBEMOCB, out float3 AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x28F3C80", Offset = "0x28F3080", VA = "0x1828F3C80", Slot = "17")]
	public void JICAFHDOGBC(HEKFLAGDMLJ LEMCMBEMOCB, float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x28F4FA0", Offset = "0x28F43A0", VA = "0x1828F4FA0", Slot = "18")]
	public bool MKOPMMFIGLN(HEKFLAGDMLJ LEMCMBEMOCB, out float3 AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x28F4AD0", Offset = "0x28F3ED0", VA = "0x1828F4AD0", Slot = "23")]
	[Obsolete]
	public float3 LGLAHBBDGCK(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x28F1830", Offset = "0x28F0C30", VA = "0x1828F1830", Slot = "24")]
	public float3 CAPHDHAOJLK(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x28F3D40", Offset = "0x28F3140", VA = "0x1828F3D40", Slot = "25")]
	public void JJNBFKNAFII(HEKFLAGDMLJ LEMCMBEMOCB, float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x28F5B40", Offset = "0x28F4F40", VA = "0x1828F5B40", Slot = "26")]
	public void OPJPANPHJDP(HEKFLAGDMLJ LEMCMBEMOCB, float3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x28F13F0", Offset = "0x28F07F0", VA = "0x1828F13F0", Slot = "27")]
	[Obsolete]
	public float BBNMNDBCIBL(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x28F5140", Offset = "0x28F4540", VA = "0x1828F5140", Slot = "28")]
	public float MOHFNKIDGBP(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x28F1780", Offset = "0x28F0B80", VA = "0x1828F1780", Slot = "29")]
	public void BMIKFCMBODE(HEKFLAGDMLJ LEMCMBEMOCB, float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x28F4910", Offset = "0x28F3D10", VA = "0x1828F4910", Slot = "30")]
	public void LAMPCKKILIB(HEKFLAGDMLJ LEMCMBEMOCB, float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x28F40B0", Offset = "0x28F34B0", VA = "0x1828F40B0", Slot = "19")]
	public void KCIEPOKLJPH(HEKFLAGDMLJ LEMCMBEMOCB, (Quaternion rot, Vector3 moments) GHDEIKNJGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x28F1190", Offset = "0x28F0590", VA = "0x1828F1190", Slot = "20")]
	public bool APOEPBKOINO(HEKFLAGDMLJ LEMCMBEMOCB, out quaternion LMJFLEPCKIJ, out float3 HAIJAOPFIEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x28F19A0", Offset = "0x28F0DA0", VA = "0x1828F19A0", Slot = "41")]
	public HIECNPEDPHM CDJDNFPECBP(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(HIECNPEDPHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x28F2CB0", Offset = "0x28F20B0", VA = "0x1828F2CB0", Slot = "42")]
	public void FOIEKCNPJHA(HEKFLAGDMLJ LEMCMBEMOCB, HIECNPEDPHM AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x28F32E0", Offset = "0x28F26E0", VA = "0x1828F32E0", Slot = "66")]
	public void HKAJABCMKOP(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x28F44A0", Offset = "0x28F38A0", VA = "0x1828F44A0", Slot = "67")]
	public void KKGKDMMDENC(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x28F3B10", Offset = "0x28F2F10", VA = "0x1828F3B10", Slot = "68")]
	public bool JCDHDPIFIGN(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x28F3890", Offset = "0x28F2C90", VA = "0x1828F3890", Slot = "82")]
	public bool IOPFDHGCIEA(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x28F5610", Offset = "0x28F4A10", VA = "0x1828F5610", Slot = "83")]
	public void ODDGBDMMCPA(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM, bool PILGGODJCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x28F58C0", Offset = "0x28F4CC0", VA = "0x1828F58C0", Slot = "84")]
	public void ODPIHLBPGID(HEKFLAGDMLJ LEMCMBEMOCB, bool CFIMAAICCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x28F4CE0", Offset = "0x28F40E0", VA = "0x1828F4CE0", Slot = "86")]
	public bool MJBBEAEKFCB(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x28F4F00", Offset = "0x28F4300", VA = "0x1828F4F00", Slot = "85")]
	public void MKMKJDNOACK(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x28F28D0", Offset = "0x28F1CD0", VA = "0x1828F28D0", Slot = "43")]
	public bool FDPGMNHONNB(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x28F5340", Offset = "0x28F4740", VA = "0x1828F5340", Slot = "44")]
	public void NINOALKMLKM(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x28F2E70", Offset = "0x28F2270", VA = "0x1828F2E70", Slot = "45")]
	public bool GCNEHEHJLNN(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x28F3750", Offset = "0x28F2B50", VA = "0x1828F3750", Slot = "46")]
	public void IHLENMBMMFL(HEKFLAGDMLJ LEMCMBEMOCB, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x28F3F60", Offset = "0x28F3360", VA = "0x1828F3F60", Slot = "47")]
	public bool JOFJKDEEGHL(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x28F3530", Offset = "0x28F2930", VA = "0x1828F3530", Slot = "48")]
	public void HOGPJNGMLBM(HEKFLAGDMLJ LEMCMBEMOCB, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x28F2840", Offset = "0x28F1C40", VA = "0x1828F2840", Slot = "49")]
	public RigidbodyConstraints EMIJPPKJIKL(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x28F4C40", Offset = "0x28F4040", VA = "0x1828F4C40", Slot = "50")]
	public void MHKBPNKIDJN(HEKFLAGDMLJ LEMCMBEMOCB, RigidbodyConstraints AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x28F4560", Offset = "0x28F3960", VA = "0x1828F4560", Slot = "51")]
	public float KPGFGLGKMBM(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x28F4D90", Offset = "0x28F4190", VA = "0x1828F4D90", Slot = "52")]
	public void MJDJBNMOHKP(HEKFLAGDMLJ LEMCMBEMOCB, float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x28F31A0", Offset = "0x28F25A0", VA = "0x1828F31A0", Slot = "53")]
	public float HBGOGJFCNDI(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x28F33A0", Offset = "0x28F27A0", VA = "0x1828F33A0", Slot = "54")]
	public void HKEDGCCBNLP(HEKFLAGDMLJ LEMCMBEMOCB, float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x28F2A80", Offset = "0x28F1E80", VA = "0x1828F2A80", Slot = "55")]
	public bool FMBGIDFJOLB(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x28F1CD0", Offset = "0x28F10D0", VA = "0x1828F1CD0", Slot = "56")]
	public void DDCMFAHNJFG(HEKFLAGDMLJ LEMCMBEMOCB, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x28F2F00", Offset = "0x28F2300", VA = "0x1828F2F00", Slot = "57")]
	public bool GHGLJPCAHJB(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x28F1630", Offset = "0x28F0A30", VA = "0x1828F1630", Slot = "58")]
	public void BHNLOMFHFNO(HEKFLAGDMLJ LEMCMBEMOCB, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x28F10F0", Offset = "0x28F04F0", VA = "0x1828F10F0", Slot = "59")]
	public void AAPCMIEGFJJ(HEKFLAGDMLJ LEMCMBEMOCB, int AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x28F3E00", Offset = "0x28F3200", VA = "0x1828F3E00", Slot = "73")]
	public Rigidbody JLMFAOHPOAK(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x28F46C0", Offset = "0x28F3AC0", VA = "0x1828F46C0", Slot = "74")]
	public void KPOMNKGLPLL(HEKFLAGDMLJ LEMCMBEMOCB, Rigidbody AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x28F3FF0", Offset = "0x28F33F0", VA = "0x1828F3FF0", Slot = "75")]
	public void JOKNGAABFDH(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x28F53E0", Offset = "0x28F47E0", VA = "0x1828F53E0", Slot = "76")]
	public void NLHAGIMAHMP(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x28F30F0", Offset = "0x28F24F0", VA = "0x1828F30F0", Slot = "77")]
	public bool GPMJIKAHCBO(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x28F1D80", Offset = "0x28F1180", VA = "0x1828F1D80", Slot = "60")]
	public object EAAHBADNNND(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x28F35E0", Offset = "0x28F29E0", VA = "0x1828F35E0", Slot = "61")]
	public void IGKDEJOENAK(HEKFLAGDMLJ LEMCMBEMOCB, object AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x28F2770", Offset = "0x28F1B70", VA = "0x1828F2770", Slot = "62")]
	public object EJHGCFNPNOP(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x28F2270", Offset = "0x28F1670", VA = "0x1828F2270", Slot = "63")]
	public void EEONKCLCHFD(HEKFLAGDMLJ LEMCMBEMOCB, object AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x28F2540", Offset = "0x28F1940", VA = "0x1828F2540", Slot = "64")]
	public float EHJDBHIOPKE(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x28F5560", Offset = "0x28F4960", VA = "0x1828F5560", Slot = "65")]
	public void ODDDHNCAMHO(HEKFLAGDMLJ LEMCMBEMOCB, float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x28F4E40", Offset = "0x28F4240", VA = "0x1828F4E40", Slot = "69")]
	public void MKAJPLONEFN(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x28F3BC0", Offset = "0x28F2FC0", VA = "0x1828F3BC0", Slot = "70")]
	public void JFPLMBLHPHO(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x28F18F0", Offset = "0x28F0CF0", VA = "0x1828F18F0", Slot = "71")]
	public bool CCIFHFANONG(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x28F3240", Offset = "0x28F2640", VA = "0x1828F3240", Slot = "21")]
	public void HFGMNBJGNPF(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x28F16E0", Offset = "0x28F0AE0", VA = "0x1828F16E0", Slot = "22")]
	public void BIOMAMDGLOH(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x28F4370", Offset = "0x28F3770", VA = "0x1828F4370", Slot = "72")]
	public bool KFDFPJELOPB(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x28F2150", Offset = "0x28F1550", VA = "0x1828F2150", Slot = "78")]
	public void EENACCBAAKO(HEKFLAGDMLJ LEMCMBEMOCB, float3 EDAEDABCFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x28F2D50", Offset = "0x28F2150", VA = "0x1828F2D50", Slot = "79")]
	public void GBACCJEBBAD(HEKFLAGDMLJ LEMCMBEMOCB, float3 HLKCHKIFBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x28F5C00", Offset = "0x28F5000", VA = "0x1828F5C00", Slot = "80")]
	public bool PMHJJBKPJPB(HEKFLAGDMLJ LEMCMBEMOCB, out float3 EDAEDABCFDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x28F2A30", Offset = "0x28F1E30", VA = "0x1828F2A30", Slot = "81")]
	public bool FJNDIDONLLC(HEKFLAGDMLJ LEMCMBEMOCB, out float3 HLKCHKIFBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x28F25E0", Offset = "0x28F19E0", VA = "0x1828F25E0")]
	private DynamicBuffer<Entity> EHJENGIIBDE(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x28F3450", Offset = "0x28F2850", VA = "0x1828F3450")]
	private DynamicBuffer<Entity> HMDBADKJNGN(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x163E0C0", Offset = "0x163D4C0", VA = "0x18163E0C0")]
	private void LBFGJCALOJN<T>(HEKFLAGDMLJ LEMCMBEMOCB, object AGLCIEKHLEE, Func<object, T> FGLJNBIGPIN) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public JGAIJFGLLHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[UnityEngine.Scripting.Preserve]
internal sealed class FJHMLCOBEHL<T> : NILFPPHEEJF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x35F7C20", Offset = "0x35F7020", VA = "0x1835F7C20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x35F7CB0", Offset = "0x35F70B0", VA = "0x1835F7CB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2085020", Offset = "0x2084420", VA = "0x182085020")]
	public FJHMLCOBEHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[EPJIKDLNGEH(typeof(CEPHAKHFAFK), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal sealed class CEPHAKHFAFK : BLHEKNIGKIO, GMHONDBOJEM, NEHPEGODEDF, BKHNPHMEICP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EntityQuery KIFNMABALHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private EntityQuery DPMJENFEBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private EntityQuery OAKFIOELDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery NMDKCOPKBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery IHLDFDKJCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery CEOKOJPKHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery LILKLLBKGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x29048C0", Offset = "0x2903CC0", VA = "0x1829048C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityQuery GDPIMBLBMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xE8FFD0", Offset = "0xE8F3D0", VA = "0x180E8FFD0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2904910", Offset = "0x2903D10", VA = "0x182904910", Slot = "5")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2904A10", Offset = "0x2903E10", VA = "0x182904A10", Slot = "6")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2904720", Offset = "0x2903B20", VA = "0x182904720")]
	private EntityQueryDesc AHELANHLDBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2904850", Offset = "0x2903C50", VA = "0x182904850", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2904780", Offset = "0x2903B80", VA = "0x182904780")]
	public NILIGAKBOAA BOPDAANMFBE(HEKFLAGDMLJ JBFCCDGDFOM)
	{
		return default(NILIGAKBOAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2904960", Offset = "0x2903D60", VA = "0x182904960")]
	public IMPAOGMALJN LOONLFGPLMG(Entity GKMECPLEALF)
	{
		return default(IMPAOGMALJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2904F30", Offset = "0x2904330", VA = "0x182904F30")]
	public CEPHAKHFAFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class MEEKOKEIAOM
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[EPJIKDLNGEH(typeof(LANNINJFJNI), new string[] { })]
[NECCFHPLDLJ(typeof(ENLINJHCCDI))]
internal class ENLINJHCCDI : LANNINJFJNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<JGECFECPNBB> BMPHNFIKFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<JGECFECPNBB> NJGFLPDLOCH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action ICPOGOKNJNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2954FB0", Offset = "0x29543B0", VA = "0x182954FB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x29551E0", Offset = "0x29545E0", VA = "0x1829551E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action OPOMLBLJGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x29550F0", Offset = "0x29544F0", VA = "0x1829550F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2955050", Offset = "0x2954450", VA = "0x182955050", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action HFGAACOJJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2954E70", Offset = "0x2954270", VA = "0x182954E70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2954F10", Offset = "0x2954310", VA = "0x182954F10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8BF920", Offset = "0x8BED20", VA = "0x1808BF920")]
	public void KPCDGHPLLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xC61130", Offset = "0xC60530", VA = "0x180C61130")]
	public void LBIHLELNNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0xAA77D0", Offset = "0xAA6BD0", VA = "0x180AA77D0")]
	public void BAPOBPEECJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2954E20", Offset = "0x2954220", VA = "0x182954E20")]
	public void ALGKKHKILHC(JGECFECPNBB OEKGCGIOGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2955190", Offset = "0x2954590", VA = "0x182955190")]
	public void KMIPOEKHPAM(JGECFECPNBB OEKGCGIOGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public ENLINJHCCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BOFOINMHPHO(FGCKLJIPPNH.OMRoom)]
internal class BBKIANLHGIK : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private KPNAFCNKGOC EILANMHJFJA;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x28FC660", Offset = "0x28FBA60", VA = "0x1828FC660", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x28FC6B0", Offset = "0x28FBAB0", VA = "0x1828FC6B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public BBKIANLHGIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EHDKJAGCMNN
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class PMJJABODGMM
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PMJJABODGMM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum IIBLABALCCO
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
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
[EPJIKDLNGEH(typeof(OCCDPACEAEH), new string[] { "Editor" })]
public sealed class OCCDPACEAEH
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate void DGLENJKLPOP(JDPNCHCMAIA DDCHJBPICDC, BACOLBMJCKD CLCAIFLMLCJ, IIBLABALCCO BLBMFDIEDCO);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void GOCPNHHNCNO(JDPNCHCMAIA DDCHJBPICDC, IIBLABALCCO BLBMFDIEDCO);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void BNEICIIHLGJ(JDPNCHCMAIA DDCHJBPICDC, FDOJMOENJAL LEMJCNJPDLJ, CIMGDHMJEHM CBNEMGEKLOD, CIMGDHMJEHM BGDHKJDGOAL, IIBLABALCCO BLBMFDIEDCO);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate void DAPJDBCMBBH(JGELFBOFGKF PMMAAICOJOP, ReadOnlySpan<byte> HOJNLEBJGLH);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public OCCDPACEAEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class LMHAGNEHKNM : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D920", Offset = "0x2A6CD20", VA = "0x182A6D920", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public LMHAGNEHKNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[EPJIKDLNGEH(typeof(GLKFEKFDENH), new string[] { })]
public class DCHGFNAANLH : GLKFEKFDENH, NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[BOJGNOMIPCG]
	private IMBCAHJKJCI MGODNOADCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[BOJGNOMIPCG]
	private BEAMFJPLEGH OBNOKFDCHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<NativeListAsync<Entity>> PDEHPAFDMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<(NativeListAsync<Entity>, bool)> JNOIEAACCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AOOJDPMKIIA PNICBAANHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Dictionary<Entity, MKGELIIKCMD> FHMJKAJIJCO;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x29159F0", Offset = "0x2914DF0", VA = "0x1829159F0", Slot = "8")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2915120", Offset = "0x2914520", VA = "0x182915120", Slot = "4")]
	public void CJDBNDMLJCH(NativeListAsync<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x29150D0", Offset = "0x29144D0", VA = "0x1829150D0", Slot = "5")]
	public void BFEPMJBOFDP(AOOJDPMKIIA PNICBAANHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2915620", Offset = "0x2914A20", VA = "0x182915620", Slot = "6")]
	public void EENCMLEMDJN(NativeListAsync<Entity> NOEOKDNGNCK, bool HMIFEGBEHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2915CA0", Offset = "0x29150A0", VA = "0x182915CA0", Slot = "7")]
	public void NOFIGPOBCNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2915190", Offset = "0x2914590", VA = "0x182915190", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2916020", Offset = "0x2915420", VA = "0x182916020")]
	private int PFFFJHAHPPN(NativeListAsync<Entity> PDEHPAFDMCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2915700", Offset = "0x2914B00", VA = "0x182915700")]
	private int FCBEKJHEEPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2915A60", Offset = "0x2914E60", VA = "0x182915A60")]
	private int JGECGBFAIAH(NativeListAsync<Entity> JNOIEAACCBL, bool GJHNOJOPHID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2916310", Offset = "0x2915710", VA = "0x182916310")]
	public DCHGFNAANLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x29159A0", Offset = "0x2914DA0", VA = "0x1829159A0")]
	[CompilerGenerated]
	private HEKFLAGDMLJ GEKELEIONLL(Entity GKMECPLEALF)
	{
		return default(HEKFLAGDMLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[EPJIKDLNGEH(typeof(BJKJCFIJEFI), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public class BJKJCFIJEFI
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool OMIGIJBCKAP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool GKODBKCLOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8BD740", Offset = "0x8BCB40", VA = "0x1808BD740")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x28FDDF0", Offset = "0x28FD1F0", VA = "0x1828FDDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public BJKJCFIJEFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal abstract class GIIEPEDCIPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private uint FAGPKKJICLM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract uint LPMCCAMMPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x28DDFC0", Offset = "0x28DD3C0", VA = "0x1828DDFC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x28DDF70", Offset = "0x28DD370", VA = "0x1828DDF70")]
	public JDPNCHCMAIA DFPFPABPPKJ()
	{
		return default(JDPNCHCMAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x28DE0D0", Offset = "0x28DD4D0", VA = "0x1828DE0D0")]
	public void GFBKGENPPPL(NativeArray<JDPNCHCMAIA> JJHDBMCJEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x28DE140", Offset = "0x28DD540", VA = "0x1828DE140")]
	public void GFBKGENPPPL(JDPNCHCMAIA DDCHJBPICDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0xAB7830", Offset = "0xAB6C30", VA = "0x180AB7830", Slot = "6")]
	public virtual void IKCBOKMOGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x28DE160", Offset = "0x28DD560", VA = "0x1828DE160")]
	private unsafe void IJNHAGKPIAO(JDPNCHCMAIA* JOONJMEEOBM, int FJFMKNIHPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x28DDFE0", Offset = "0x28DD3E0", VA = "0x1828DDFE0")]
	private unsafe void GFBKGENPPPL(JDPNCHCMAIA* JOONJMEEOBM, int FJFMKNIHPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x105E4F0", Offset = "0x105D8F0", VA = "0x18105E4F0")]
	protected GIIEPEDCIPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[EPJIKDLNGEH(typeof(PIKIKJOOODC), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal sealed class PIKIKJOOODC : GIIEPEDCIPL, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[BOJGNOMIPCG]
	private LEHIKHOEAMN DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private uint GAAPLDCPBBH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public override uint LPMCCAMMPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA0C050", Offset = "0xA0B450", VA = "0x180A0C050", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2484080", Offset = "0x2483480", VA = "0x182484080", Slot = "7")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2483FB0", Offset = "0x24833B0", VA = "0x182483FB0")]
	private void DGBMPPHNNND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2484060", Offset = "0x2483460", VA = "0x182484060", Slot = "6")]
	public override void IKCBOKMOGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x24840E0", Offset = "0x24834E0", VA = "0x1824840E0")]
	public PIKIKJOOODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
[EPJIKDLNGEH(typeof(AGBDOJAAHAP), new string[] { })]
internal sealed class AGBDOJAAHAP : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[BOJGNOMIPCG]
	private GOACFOHKEAA DOJPHKDLJHO;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x28FAC30", Offset = "0x28FA030", VA = "0x1828FAC30", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x28FABE0", Offset = "0x28F9FE0", VA = "0x1828FABE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public AGBDOJAAHAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[EPJIKDLNGEH(typeof(PLDHONMGCJE), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public class PLDHONMGCJE : FFLHMNCCPBG, BLHEKNIGKIO, GMHONDBOJEM, NEHPEGODEDF, BKHNPHMEICP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class AFLBDKBIKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public IABLIMOJJBC services;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AFLBDKBIKAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4C4BEE0", Offset = "0x4C4B2E0", VA = "0x184C4BEE0")]
		internal void HLEAOMIFIJI(NEHPEGODEDF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class JHJFGOMEALH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IABLIMOJJBC services;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JHJFGOMEALH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x4C4BF60", Offset = "0x4C4B360", VA = "0x184C4BF60")]
		internal void JMBEHPNJMEF(BKHNPHMEICP svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[BOJGNOMIPCG]
	private GAGBBBEFGOD KJBLOFFCELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[BOJGNOMIPCG]
	private DOKFAOCNIFN ILDIIFMLPBD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GPJLAPAOJAB FJOGDMJJGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x12DF490", Offset = "0x12DE890", VA = "0x1812DF490", Slot = "4")]
		get
		{
			return default(GPJLAPAOJAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x24854E0", Offset = "0x24848E0", VA = "0x1824854E0", Slot = "5")]
	public void HKHFIGFLBOE(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2485280", Offset = "0x2484680", VA = "0x182485280", Slot = "6")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2485570", Offset = "0x2484970", VA = "0x182485570", Slot = "7")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2485650", Offset = "0x2484A50", VA = "0x182485650", Slot = "8")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x24853B0", Offset = "0x24847B0", VA = "0x1824853B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3237D10", Offset = "0x3237110", VA = "0x183237D10")]
	private void DGDKFGHHFIP<T>(Action<T> DKOFNPGJCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public PLDHONMGCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[EPJIKDLNGEH(typeof(APLOJNPIIKE), new string[] { })]
public sealed class LGONLELLBPC : APLOJNPIIKE, BLHEKNIGKIO, GMHONDBOJEM, NEHPEGODEDF, BKHNPHMEICP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class MLLMFKKOGCE : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
		public LGONLELLBPC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9D48A0", Offset = "0x9D3CA0", VA = "0x1809D48A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x27BA070", Offset = "0x27B9470", VA = "0x1827BA070", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x259A8D0", Offset = "0x2599CD0", VA = "0x18259A8D0")]
		[DebuggerHidden]
		public MLLMFKKOGCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x27B9D30", Offset = "0x27B9130", VA = "0x1827B9D30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x27BA030", Offset = "0x27B9430", VA = "0x1827BA030", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x27B9F80", Offset = "0x27B9380", VA = "0x1827B9F80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x27B9F80", Offset = "0x27B9380", VA = "0x1827B9F80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[BOJGNOMIPCG]
	private OENENEPEABD OEGNIABGFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly ILHNOICDLPN MHHFFOGCLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Dictionary<string, IDDIDOGCIFG> OGEJNFNLEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<int, FIPBNNCGAFF> FHOGFHDMEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<FLJMOFPACJP> IIBPIOIBBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private DFIJJNIGPNA PEACADEJCBG;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public FIPBNNCGAFF BGCEJHPHLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A030", Offset = "0x2A69430", VA = "0x182A6A030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public List<FLJMOFPACJP> BEAJLOOMGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "9")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A320", Offset = "0x2A69720", VA = "0x182A6A320", Slot = "10")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A600", Offset = "0x2A69A00", VA = "0x182A6A600", Slot = "11")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2A69DC0", Offset = "0x2A691C0", VA = "0x182A69DC0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A4E0", Offset = "0x2A698E0", VA = "0x182A6A4E0", Slot = "6")]
	public bool KOHBPKJMHDI(FLJMOFPACJP LEMJCNJPDLJ, out FIPBNNCGAFF BBMDLCNKBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2A698C0", Offset = "0x2A68CC0", VA = "0x182A698C0")]
	private void CJEHBEBLBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A180", Offset = "0x2A69580", VA = "0x182A6A180")]
	private void INNIEMMKLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A090", Offset = "0x2A69490", VA = "0x182A6A090")]
	private IDDIDOGCIFG HEECNIIFOHB(string BKBNGHCLCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A030", Offset = "0x2A69430", VA = "0x182A6A030")]
	private IDDIDOGCIFG HIDCIEDMBCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A710", Offset = "0x2A69B10", VA = "0x182A6A710")]
	private IDDIDOGCIFG OEMHPJKLOGG(string BKBNGHCLCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A3D0", Offset = "0x2A697D0", VA = "0x182A6A3D0")]
	private IDDIDOGCIFG KACGFCLADOG(string GBGNJPBFOBA, string AEMEEHLIDCM, [Optional] IDDIDOGCIFG JJOACLKIOIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A0F0", Offset = "0x2A694F0", VA = "0x182A6A0F0")]
	[IteratorStateMachine(typeof(MLLMFKKOGCE))]
	private IEnumerable<(string, string)> HJKDNKIGFED(string BKBNGHCLCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A380", Offset = "0x2A69780", VA = "0x182A6A380")]
	private bool JPJADAKKDCB(FLJMOFPACJP LEMJCNJPDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2A69F50", Offset = "0x2A69350", VA = "0x182A69F50")]
	private ILHNOICDLPN GINEHAGONJF(FLJMOFPACJP LEMJCNJPDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2A69F00", Offset = "0x2A69300", VA = "0x182A69F00")]
	private ILHNOICDLPN FICNCMICCHL(FLJMOFPACJP LEMJCNJPDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2A69C50", Offset = "0x2A69050", VA = "0x182A69C50")]
	private ILHNOICDLPN CNOACDIFDGM(FLJMOFPACJP LEMJCNJPDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2387460", Offset = "0x2386860", VA = "0x182387460")]
	private T DKIPCHFPLPN<T>(FLJMOFPACJP LEMJCNJPDLJ) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2A69CE0", Offset = "0x2A690E0", VA = "0x182A69CE0")]
	private FieldInfo DHEMIDAFILG(FLJMOFPACJP LEMJCNJPDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2A69E50", Offset = "0x2A69250", VA = "0x182A69E50", Slot = "7")]
	public void EHBDNPLCIKI(FLJMOFPACJP LEMJCNJPDLJ, AFNDKOFPEDG NMBCGMHEDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A660", Offset = "0x2A69A60", VA = "0x182A6A660", Slot = "8")]
	public void OAPBCJNJKMP(FLJMOFPACJP LEMJCNJPDLJ, AFNDKOFPEDG NMBCGMHEDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A980", Offset = "0x2A69D80", VA = "0x182A6A980")]
	public LGONLELLBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A570", Offset = "0x2A69970", VA = "0x182A6A570")]
	[CompilerGenerated]
	private int LKMKCJDBKFC(FLJMOFPACJP NPBBJPKPNCJ, FLJMOFPACJP KBAEKPMBMFG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class FPOAMMIBBAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class MNMAKINCLCO
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class JCDHBMPHILB
{
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x28ED890", Offset = "0x28ECC90", VA = "0x1828ED890")]
	public static void CEPODDDJNMN(EHKEPJIBENP IGCLICKKCHJ, string FOEKJOGJCIL, HEKFLAGDMLJ MPCCMHGJCME, Action FGLJNBIGPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x28ED620", Offset = "0x28ECA20", VA = "0x1828ED620")]
	public static void CEPODDDJNMN(EHKEPJIBENP IGCLICKKCHJ, string FOEKJOGJCIL, FDJPAKEFOJE INMOOFIOOOB, Action FGLJNBIGPIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[EPJIKDLNGEH(typeof(EHDBBIHDADI), new string[] { })]
public class PJBAOEEGCHL : NEHPEGODEDF, EHDBBIHDADI
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2484FF0", Offset = "0x24843F0", VA = "0x182484FF0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2484E40", Offset = "0x2484240", VA = "0x182484E40", Slot = "5")]
	public void ADJPGHMCOKF(HEKFLAGDMLJ JBFCCDGDFOM, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2484F80", Offset = "0x2484380", VA = "0x182484F80", Slot = "6")]
	public void GEKPKMIHAHB(HEKFLAGDMLJ JBFCCDGDFOM, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2484EB0", Offset = "0x24842B0", VA = "0x182484EB0", Slot = "7")]
	public void CGKJOCACEPG(HEKFLAGDMLJ JBFCCDGDFOM, int AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3230490", Offset = "0x322F890", VA = "0x183230490")]
	private void AFLFAPDAOKF<T>(HEKFLAGDMLJ JBFCCDGDFOM, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x3230760", Offset = "0x322FB60", VA = "0x183230760")]
	private void AFLFAPDAOKF<T>(HEKFLAGDMLJ JBFCCDGDFOM, T CLCAIFLMLCJ) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public PJBAOEEGCHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[EPJIKDLNGEH(typeof(EHOIGMKOEFH), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public sealed class EHOIGMKOEFH : NEHPEGODEDF, BKHNPHMEICP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class PJDKNMKJKCM : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
		public EHOIGMKOEFH <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public PJDKNMKJKCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x27BD0A0", Offset = "0x27BC4A0", VA = "0x1827BD0A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x27BCC30", Offset = "0x27BC030", VA = "0x1827BCC30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x27BCF70", Offset = "0x27BC370", VA = "0x1827BCF70")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x27BD060", Offset = "0x27BC460", VA = "0x1827BD060", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x27BCFC0", Offset = "0x27BC3C0", VA = "0x1827BCFC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x27BCFC0", Offset = "0x27BC3C0", VA = "0x1827BCFC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Dictionary<SerializableGuid, LDPBHDEACKL> EHBOLACIBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly List<SerializableGuid> MALGIIBBHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<SerializableGuid, GameObject> PJGJLPEKIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private OENENEPEABD OEGNIABGFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private IFPFMOBMMJJ DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private LANNINJFJNI OCKKDLPLKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private DOKFAOCNIFN ILDIIFMLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private LKPHPGGEFLH<LDPBHDEACKL> FHHAMKDPPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private GameObject HFKBGBEMHLD;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2951C70", Offset = "0x2951070", VA = "0x182951C70", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2952740", Offset = "0x2951B40", VA = "0x182952740", Slot = "5")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x29515E0", Offset = "0x29509E0", VA = "0x1829515E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2952920", Offset = "0x2951D20", VA = "0x182952920")]
	private void PEDFGODKMEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2952200", Offset = "0x2951600", VA = "0x182952200")]
	internal void MDGEABAGNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2951400", Offset = "0x2950800", VA = "0x182951400")]
	private void DNEDHCFLFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2952640", Offset = "0x2951A40", VA = "0x182952640")]
	private void NEKPJPOLKPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2951390", Offset = "0x2950790", VA = "0x182951390")]
	[IteratorStateMachine(typeof(PJDKNMKJKCM))]
	private IEnumerable<RRCustomPropTag> DDGIILFIACJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2951D40", Offset = "0x2951140", VA = "0x182951D40")]
	private void KNFMALKMAMA(HEKFLAGDMLJ LEMCMBEMOCB, in CIMGDHMJEHM FNIKJMODJCE, in CIMGDHMJEHM PINJDLEFOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2951780", Offset = "0x2950B80", VA = "0x182951780")]
	private void EHBDNPLCIKI(SerializableGuid DDJMKPCJBFO, GameObject NNAKJIJAOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x29518C0", Offset = "0x2950CC0", VA = "0x1829518C0")]
	private void HJBCEAGCMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x29511C0", Offset = "0x29505C0", VA = "0x1829511C0")]
	private bool BEMJCNAEAEN(LDPBHDEACKL PICAEEIAFAJ, Transform OJBGDMNECON, out GameObject IILNPDLGJIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x29528D0", Offset = "0x2951CD0", VA = "0x1829528D0")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x29529C0", Offset = "0x2951DC0", VA = "0x1829529C0")]
	public EHOIGMKOEFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
[EPJIKDLNGEH(typeof(OENENEPEABD), new string[] { })]
public class LFCCCDLMLNG : OENENEPEABD, IEnumerable<FLJMOFPACJP>, IEnumerable, NEHPEGODEDF, BKHNPHMEICP, EJLEFJCKIEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[BOJGNOMIPCG]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[BOJGNOMIPCG]
	private IJGPMAMDKLF KCJJGLLIALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private FLJMOFPACJP[] KKHLCEENFDE;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2A68010", Offset = "0x2A67410", VA = "0x182A68010", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public FLJMOFPACJP ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2A67EF0", Offset = "0x2A672F0", VA = "0x182A67EF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2A68060", Offset = "0x2A67460", VA = "0x182A68060", Slot = "10")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2A68280", Offset = "0x2A67680", VA = "0x182A68280", Slot = "11")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2A680D0", Offset = "0x2A674D0", VA = "0x182A680D0")]
	private FLJMOFPACJP JPKIENLJFLN(int BNOAGGNAMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2A67D30", Offset = "0x2A67130", VA = "0x182A67D30", Slot = "6")]
	public FLJMOFPACJP DNDGKGKJHCH(LOHCJILDMLL OCFGMKDOPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2A681B0", Offset = "0x2A675B0", VA = "0x182A681B0", Slot = "7")]
	public FDOJMOENJAL LEEAMPOIODD(LOHCJILDMLL OCFGMKDOPDP)
	{
		return default(FDOJMOENJAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2A67F00", Offset = "0x2A67300", VA = "0x182A67F00", Slot = "8")]
	public IEnumerator<FLJMOFPACJP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2A67F00", Offset = "0x2A67300", VA = "0x182A67F00", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x23795E0", Offset = "0x23789E0", VA = "0x1823795E0", Slot = "12")]
	public void GEGICBEPEAB<TKey, T>(FIPEENHHKAO<TKey, T> LEMJCNJPDLJ, [Optional] object AKPCLGIGABA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2A67E50", Offset = "0x2A67250", VA = "0x182A67E50", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public LFCCCDLMLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2A67EF0", Offset = "0x2A672F0", VA = "0x182A67EF0")]
	[CompilerGenerated]
	private FLJMOFPACJP KHJDHHKFEMC(int APEMPONKPBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal class ELCFCJGPCHO : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private EntityQuery LPCDFIJEMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2954B20", Offset = "0x2953F20", VA = "0x182954B20", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2954B70", Offset = "0x2953F70", VA = "0x182954B70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2954C00", Offset = "0x2954000", VA = "0x182954C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public ELCFCJGPCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class PFBHIKNMFMI<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[EPJIKDLNGEH(typeof(MAPAMEBHHIJ), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public class MAPAMEBHHIJ : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[BOJGNOMIPCG]
	private NBPNODCEBKF FBJJPAAFOIC;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F600", Offset = "0x2A6EA00", VA = "0x182A6F600", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F5D0", Offset = "0x2A6E9D0", VA = "0x182A6F5D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public MAPAMEBHHIJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class DisembodiedObjectView : MonoBehaviour, GLHHELGFOCN
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool HPOMJOMGINK
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HEKFLAGDMLJ MIHFCEGNEMF
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x17F1CB0", Offset = "0x17F10B0", VA = "0x1817F1CB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(HEKFLAGDMLJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x17F1CE0", Offset = "0x17F10E0", VA = "0x1817F1CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x294F050", Offset = "0x294E450", VA = "0x18294F050")]
		public void SetName(string GDKOBCHHFLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public DisembodiedObjectView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class IOBGGMFCECH
{
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x28EC940", Offset = "0x28EBD40", VA = "0x1828EC940")]
	public static void DAMNJNMNNEI(ComponentSystemBase GDOFPEAGKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(MOAKKCGMOKH), new string[] { })]
internal sealed class MOAKKCGMOKH : GIIEPEDCIPL
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public override uint LPMCCAMMPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x24840E0", Offset = "0x24834E0", VA = "0x1824840E0")]
	public MOAKKCGMOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class NLHOPFFLGBK
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class NJBANINKLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public IABLIMOJJBC services;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NJBANINKLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x27BA2B0", Offset = "0x27B96B0", VA = "0x1827BA2B0")]
		internal void AMILDEHIMKL(NEHPEGODEDF svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x27BA250", Offset = "0x27B9650", VA = "0x1827BA250")]
		internal void AFFFFLOJNEN(BKHNPHMEICP svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BBD0", Offset = "0x2A7AFD0", VA = "0x182A7BBD0")]
	public static void LJIONFHJJPI(this World GLBDCLCAOJH, IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1022370", Offset = "0x1021770", VA = "0x181022370")]
	public static void LCKIBAOMMOO<T>(this World GLBDCLCAOJH, Action<T> DKOFNPGJCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2405730", Offset = "0x2404B30", VA = "0x182405730")]
	public static void JGFAJLHFJMG<T>(this World GLBDCLCAOJH, Action<T> DKOFNPGJCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2405980", Offset = "0x2404D80", VA = "0x182405980")]
	public static void JGFAJLHFJMG<T>(IEnumerable<ComponentSystemBase> NNFPDEGNOEP, Action<T> DKOFNPGJCMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[EPJIKDLNGEH(typeof(MAFOFLPIDLK), new string[] { })]
internal class NDPELMOIHPM : MAFOFLPIDLK, NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private enum Flag
	{
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Allowed,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		AllowedInRoomV1,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		RoomUpgrade,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Clone,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Copy,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Undo,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		UndoCreation,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Physics,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		SerializationV4,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		HierarchyViewVisible
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class NIMKNFDFPJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NIMKNFDFPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x27BA1D0", Offset = "0x27B95D0", VA = "0x1827BA1D0")]
		internal object JLEMCPNLPPC((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[BOJGNOMIPCG]
	private DCIHBGMKNDA DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[BOJGNOMIPCG]
	private OEGCJPFACKE OMIGIJBCKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NativeBitArray LJPEMGIEKOJ;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KPBHHFJCLAD KCCKMALAJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2A75FC0", Offset = "0x2A753C0", VA = "0x182A75FC0", Slot = "4")]
		get
		{
			return default(KPBHHFJCLAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public KPBHHFJCLAD IKJHLMNHPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2A76320", Offset = "0x2A75720", VA = "0x182A76320", Slot = "5")]
		get
		{
			return default(KPBHHFJCLAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KPBHHFJCLAD EENMJALKMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2A76300", Offset = "0x2A75700", VA = "0x182A76300", Slot = "6")]
		get
		{
			return default(KPBHHFJCLAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KPBHHFJCLAD EMCLIHJFPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2A75F70", Offset = "0x2A75370", VA = "0x182A75F70", Slot = "7")]
		get
		{
			return default(KPBHHFJCLAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KPBHHFJCLAD CJPAEEBHBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2A76310", Offset = "0x2A75710", VA = "0x182A76310", Slot = "8")]
		get
		{
			return default(KPBHHFJCLAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KPBHHFJCLAD IEPBIKJEDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2A76190", Offset = "0x2A75590", VA = "0x182A76190", Slot = "9")]
		get
		{
			return default(KPBHHFJCLAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KPBHHFJCLAD IKOFANNLAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2A75F80", Offset = "0x2A75380", VA = "0x182A75F80", Slot = "10")]
		get
		{
			return default(KPBHHFJCLAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public KPBHHFJCLAD JALHPAIJBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2A75F90", Offset = "0x2A75390", VA = "0x182A75F90", Slot = "11")]
		get
		{
			return default(KPBHHFJCLAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public KPBHHFJCLAD BACCOFFHAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2A75CF0", Offset = "0x2A750F0", VA = "0x182A75CF0", Slot = "12")]
		get
		{
			return default(KPBHHFJCLAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private int CLGLDMNNHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2A760E0", Offset = "0x2A754E0", VA = "0x182A760E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2A761A0", Offset = "0x2A755A0", VA = "0x182A761A0", Slot = "13")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2A76030", Offset = "0x2A75430", VA = "0x182A76030", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x2A75FE0", Offset = "0x2A753E0", VA = "0x182A75FE0")]
	private void DOPHPLPJMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2A75D00", Offset = "0x2A75100", VA = "0x182A75D00")]
	private void BFPIEJEIPKE(Flag BEAPEKCODAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2A76350", Offset = "0x2A75750", VA = "0x182A76350")]
	private KPBHHFJCLAD NPKLHAOACJF(Flag BEAPEKCODAF)
	{
		return default(KPBHHFJCLAD);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2A75FA0", Offset = "0x2A753A0", VA = "0x182A75FA0")]
	private KPBHHFJCLAD DMCHOFCGCPC(Flag BEAPEKCODAF)
	{
		return default(KPBHHFJCLAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public NDPELMOIHPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[EPJIKDLNGEH(typeof(FEEKAOBEJNL), new string[] { })]
public class OLJMFFGDEGG : NEHPEGODEDF, BKHNPHMEICP, FEEKAOBEJNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private OHAMPNBKDLP LJNICDIKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private JIDPKPDHEOA OAHDHLNKBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private DFIJJNIGPNA PEACADEJCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private OMLGJABBHNL DPDHOFHAAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int LGHKAJOKCOI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PFHIAFAGPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x24804A0", Offset = "0x247F8A0", VA = "0x1824804A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public HEKFLAGDMLJ HGAPDNGDCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2480E80", Offset = "0x2480280", VA = "0x182480E80", Slot = "9")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2480C70", Offset = "0x2480070", VA = "0x182480C70", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public MDECDPGCMCD IAGEFKLKOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2480240", Offset = "0x247F640", VA = "0x182480240", Slot = "11")]
		get
		{
			return default(MDECDPGCMCD);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2480C70", Offset = "0x2480070", VA = "0x182480C70", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private uint OBDPDBHGEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2480F30", Offset = "0x2480330", VA = "0x182480F30")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event JKFKEKENGGE FBBGMFMCEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x24812A0", Offset = "0x24806A0", VA = "0x1824812A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x24801A0", Offset = "0x247F5A0", VA = "0x1824801A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2480CA0", Offset = "0x24800A0", VA = "0x182480CA0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2480FE0", Offset = "0x24803E0", VA = "0x182480FE0", Slot = "5")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2480890", Offset = "0x247FC90", VA = "0x182480890", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2480560", Offset = "0x247F960", VA = "0x182480560")]
	private void CALIIOCCJBB(CNKGMANFGNC CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2481180", Offset = "0x2480580", VA = "0x182481180", Slot = "13")]
	public HEKFLAGDMLJ OKDEEBIDGEN(HEKFLAGDMLJ JNHEGOFDJBP, HEKFLAGDMLJ JBNLIGHJDME)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2480D70", Offset = "0x2480170", VA = "0x182480D70", Slot = "14")]
	public bool MPHFLBOJAHA(HEKFLAGDMLJ JNHEGOFDJBP, HEKFLAGDMLJ JBNLIGHJDME, out HEKFLAGDMLJ MCDGHNFJPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2480980", Offset = "0x247FD80", VA = "0x182480980", Slot = "15")]
	public void EHGPIGIEBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2480170", Offset = "0x247F570", VA = "0x182480170", Slot = "16")]
	public void ADGPAGFGHPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2480AE0", Offset = "0x247FEE0", VA = "0x182480AE0", Slot = "17")]
	public bool EKHOIKIJAFN(HEKFLAGDMLJ JNHEGOFDJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x24802A0", Offset = "0x247F6A0", VA = "0x1824802A0")]
	private void AONJBDGPNDD(HEKFLAGDMLJ IPNCPIKMHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public OLJMFFGDEGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[EPJIKDLNGEH(typeof(FEKJMMMBFDP), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
internal class FEKJMMMBFDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public void INCILMPOGAN(string GDKOBCHHFLB, EntityManager BEBIJONEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public FEKJMMMBFDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class JFDABCJLGIK
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x28EFD10", Offset = "0x28EF110", VA = "0x1828EFD10")]
	public static bool KBMAHKKCGMB(KINEJENHFEI CEEKDAMNLIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x28EF8F0", Offset = "0x28EECF0", VA = "0x1828EF8F0")]
	public static KINEJENHFEI EHBDNPLCIKI(GameObject NNAKJIJAOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x28EFB30", Offset = "0x28EEF30", VA = "0x1828EFB30")]
	public static KINEJENHFEI EHBDNPLCIKI(GameObject NNAKJIJAOJG, JDPNCHCMAIA DDCHJBPICDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x28EF700", Offset = "0x28EEB00", VA = "0x1828EF700")]
	public static bool BCANEGJJEEB(GameObject OEHOBCLILGI, string KNPFDHANMOI, bool EBOOICCKBKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal readonly struct IBCENFMLMKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly ComponentSystemBase GDOFPEAGKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly ProfilerMarker KFHNGFCGHNP;

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x28EAAB0", Offset = "0x28E9EB0", VA = "0x1828EAAB0")]
	public IBCENFMLMKG(World GLBDCLCAOJH, Type GANFKPHKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x28EAA30", Offset = "0x28E9E30", VA = "0x1828EAA30")]
	public void HEKKEPHAEDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(PIMNGKKLMII), new string[] { })]
internal sealed class PIMNGKKLMII : NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private JFEOPDDGNAJ PJGJLPEKIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[BOJGNOMIPCG]
	private CEPHAKHFAFK NEJHPGNLCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[BOJGNOMIPCG]
	private DOKFAOCNIFN POHDPKBODCF;

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2484290", Offset = "0x2483690", VA = "0x182484290", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2484D10", Offset = "0x2484110", VA = "0x182484D10")]
	public FDJPAKEFOJE OHHBKCKEINJ(FDJPAKEFOJE HAMAKNIIOKD, Allocator DGGNDNPDKKD)
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x24840F0", Offset = "0x24834F0", VA = "0x1824840F0")]
	private void INJDBCKJPMG(NativeParallelMultiHashMap<int, (HEKFLAGDMLJ src, HEKFLAGDMLJ dst)> KDLCDCOIKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2484890", Offset = "0x2483C90", VA = "0x182484890")]
	private void NCPDBPMIHJD(NativeParallelMultiHashMap<int, (HEKFLAGDMLJ src, HEKFLAGDMLJ dst)> KDLCDCOIKKE, int JBGKOICMKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2484340", Offset = "0x2483740", VA = "0x182484340")]
	private void KLCOPKIGHDD(NativeParallelMultiHashMap<int, (HEKFLAGDMLJ src, HEKFLAGDMLJ dst)> KDLCDCOIKKE, int JBGKOICMKNG, CMCADLOKOGK OEGNIABGFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2484540", Offset = "0x2483940", VA = "0x182484540")]
	private NativeParallelMultiHashMap<int, (HEKFLAGDMLJ, HEKFLAGDMLJ)> KMDHDKAEFED(Allocator DGGNDNPDKKD, FDJPAKEFOJE HAMAKNIIOKD, out FDJPAKEFOJE MGBLLIAGKDJ)
	{
		return default(NativeParallelMultiHashMap<int, (HEKFLAGDMLJ, HEKFLAGDMLJ)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public PIMNGKKLMII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[EPJIKDLNGEH(typeof(GMGFOIPGMLF), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public class GMGFOIPGMLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly Dictionary<DJOJBOPMMAC, string> NLFNAOJEBBL;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x28E0350", Offset = "0x28DF750", VA = "0x1828E0350")]
	public GameObject LGGFADCAFCL(DJOJBOPMMAC GDBONNHGFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x28E0420", Offset = "0x28DF820", VA = "0x1828E0420")]
	public GMGFOIPGMLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class KANKNJLPPLF<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[EPJIKDLNGEH(typeof(NAAJCDOIDBM), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.PhotonRoom)]
public class NAAJCDOIDBM : BLHEKNIGKIO, GMHONDBOJEM, NEHPEGODEDF, BKHNPHMEICP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private IFPFMOBMMJJ DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private POKOBOIBHEN MLHNGKAODMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private NativeList<int> KEHHOKPHOBD;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A73B70", Offset = "0x2A72F70", VA = "0x182A73B70", Slot = "4")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A73E60", Offset = "0x2A73260", VA = "0x182A73E60", Slot = "5")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A73F10", Offset = "0x2A73310", VA = "0x182A73F10", Slot = "6")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A73BD0", Offset = "0x2A72FD0", VA = "0x182A73BD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A73C90", Offset = "0x2A73090", VA = "0x182A73C90")]
	public void EFGDJCDGADL(NativeParallelHashSet<int> FAKGNPCFIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A73ED0", Offset = "0x2A732D0", VA = "0x182A73ED0")]
	public void LAMOILEGLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public NAAJCDOIDBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(NEKIMECDAKH), new string[] { })]
internal class NEKIMECDAKH : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly EHKEPJIBENP OCAAONNOLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[BOJGNOMIPCG]
	private KFDENICELLH DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[BOJGNOMIPCG]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[BOJGNOMIPCG]
	private GGNFHIGGHPN IIGHBGGPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private HMHHFNDBEKM OCKKDLPLKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private EntityQuery JJAGMBLMCPJ;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A77C70", Offset = "0x2A77070", VA = "0x182A77C70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A784F0", Offset = "0x2A778F0", VA = "0x182A784F0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A775F0", Offset = "0x2A769F0", VA = "0x182A775F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A78DA0", Offset = "0x2A781A0", VA = "0x182A78DA0")]
	public ALNGHMJNFBH MDJOMPBEPAG(IEnumerable<GGLLEGPCFPG> EFGAJJINKPM)
	{
		return default(ALNGHMJNFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A78750", Offset = "0x2A77B50", VA = "0x182A78750")]
	public static bool KHPNFJBDHPO(GGLLEGPCFPG OALKBFHLHKE, out JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A77CC0", Offset = "0x2A770C0", VA = "0x182A77CC0")]
	private ALNGHMJNFBH ICIAJDMLAKF(IEnumerable<GGLLEGPCFPG> EFGAJJINKPM)
	{
		return default(ALNGHMJNFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A77970", Offset = "0x2A76D70", VA = "0x182A77970")]
	private (List<GGLLEGPCFPG>, int[], int) FEGBBLHMCIC(IEnumerable<GGLLEGPCFPG> EFGAJJINKPM)
	{
		return default((List<GGLLEGPCFPG>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A76A80", Offset = "0x2A75E80", VA = "0x182A76A80")]
	private Dictionary<JDPNCHCMAIA, (GGLLEGPCFPG, int)> DKBBDDMGAJG(IEnumerable<GGLLEGPCFPG> EFGAJJINKPM, Entity ANPGBEIJINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A77600", Offset = "0x2A76A00", VA = "0x182A77600")]
	private void ENFGCLPDPOP(Dictionary<JDPNCHCMAIA, (GGLLEGPCFPG request, int srcIndex)> BJIHAMCKFIH, IEnumerable<GGLLEGPCFPG> EFGAJJINKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A790C0", Offset = "0x2A784C0", VA = "0x182A790C0")]
	private void OLGKDKKDDGK(Dictionary<JDPNCHCMAIA, (GGLLEGPCFPG request, int srcIndex)> BJIHAMCKFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A76450", Offset = "0x2A75850", VA = "0x182A76450")]
	private void BGDGANNOOJL(Dictionary<JDPNCHCMAIA, (GGLLEGPCFPG request, int srcIndex)> BJIHAMCKFIH, JDPNCHCMAIA DDCHJBPICDC, string GDKOBCHHFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A771E0", Offset = "0x2A765E0", VA = "0x182A771E0")]
	private void DPBAAIOPFJA(Dictionary<JDPNCHCMAIA, (GGLLEGPCFPG request, int srcIndex)> BJIHAMCKFIH, Entity ANPGBEIJINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2A76B30", Offset = "0x2A75F30", VA = "0x182A76B30")]
	private (List<GGLLEGPCFPG>, int[], int) DLHAENBBCKH(Dictionary<JDPNCHCMAIA, (GGLLEGPCFPG request, int srcIndex)> BJIHAMCKFIH, Entity ANPGBEIJINJ)
	{
		return default((List<GGLLEGPCFPG>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A78A90", Offset = "0x2A77E90", VA = "0x182A78A90")]
	private void LIPOIDDNGIO(Dictionary<JDPNCHCMAIA, (GGLLEGPCFPG request, int srcIndex)> BJIHAMCKFIH, List<GGLLEGPCFPG> JGJJDBHDMOC, int[] HKJMOPHHLAM, NativeArray<Entity> NOEOKDNGNCK, NativeList<JDPNCHCMAIA> JJHDBMCJEFK, NativeList<Entity> CJJCANJBPFE, Entity ANPGBEIJINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A769B0", Offset = "0x2A75DB0", VA = "0x182A769B0")]
	private static bool CKJCKHGCDMB(Entity GKMECPLEALF, ComponentDataFromEntity<EODNMPFLBLP> IDPELHFEGAC, Entity ANPGBEIJINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A781A0", Offset = "0x2A775A0", VA = "0x182A781A0")]
	private void INFOIJHIKBN(Dictionary<JDPNCHCMAIA, (GGLLEGPCFPG request, int srcIndex)> BJIHAMCKFIH, List<GGLLEGPCFPG> JGJJDBHDMOC, int[] HKJMOPHHLAM, NativeList<Entity> CJJCANJBPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A78EB0", Offset = "0x2A782B0", VA = "0x182A78EB0")]
	private NativeList<JDPNCHCMAIA> MKGBKPPDHDL(Dictionary<JDPNCHCMAIA, (GGLLEGPCFPG request, int srcIndex)> BJIHAMCKFIH)
	{
		return default(NativeList<JDPNCHCMAIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A788A0", Offset = "0x2A77CA0", VA = "0x182A788A0")]
	private NativeArray<Entity> KOPGLPJJFGI(NativeList<JDPNCHCMAIA> JJHDBMCJEFK)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A77B50", Offset = "0x2A76F50", VA = "0x182A77B50")]
	private static void FMAKKNKIBNO(Dictionary<JDPNCHCMAIA, (GGLLEGPCFPG request, int srcIndex)> BJIHAMCKFIH, JDPNCHCMAIA DDCHJBPICDC, GGLLEGPCFPG OALKBFHLHKE, string GDKOBCHHFLB, int KMKDEDLCLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A78D10", Offset = "0x2A78110", VA = "0x182A78D10")]
	private void LLNBCKGEOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public NEKIMECDAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(AHJMHEDKMKK), new string[] { })]
public class AHJMHEDKMKK : GMHONDBOJEM, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[BOJGNOMIPCG]
	private JEGMBOPKKDO PHLDDLGGOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private bool NFDAGCBHCLM;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TimeData HNDENAKKHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x28FAE80", Offset = "0x28FA280", VA = "0x1828FAE80")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x28FAEF0", Offset = "0x28FA2F0", VA = "0x1828FAEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool IGCJJFFNPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x901ED0", Offset = "0x9012D0", VA = "0x180901ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x15F79C0", Offset = "0x15F6DC0", VA = "0x1815F79C0", Slot = "4")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x28FAF50", Offset = "0x28FA350", VA = "0x1828FAF50", Slot = "5")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x28FADE0", Offset = "0x28FA1E0", VA = "0x1828FADE0")]
	public void AJBOGFPBNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	public void BBKEHFENGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public AHJMHEDKMKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[EPJIKDLNGEH(typeof(OHAMPNBKDLP), new string[] { })]
public class CNJNPPJIMBM : OHAMPNBKDLP, BLHEKNIGKIO, GMHONDBOJEM, NEHPEGODEDF, BKHNPHMEICP, IDisposable, CNJNPPJIMBM.NEMIGIILEEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal interface NEMIGIILEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DFGGNIIPDNH(global::HDHFLPILNPM DFLHLPHDCDC);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private KNNCGINAGFA GBFJPPHEION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private OGNMAJKNMBP NEJHPGNLCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private COKHJGJNDIB LGIGGJMIOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private global::HDHFLPILNPM EJMHGDFOMEM;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private LKPHPGGEFLH<HEKFLAGDMLJ> BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x9E3C00", Offset = "0x9E3000", VA = "0x1809E3C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x290AC20", Offset = "0x290A020", VA = "0x18290AC20")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<JPKFBBKCAIK> PMHLBEAPEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x290B340", Offset = "0x290A740", VA = "0x18290B340", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x290ABC0", Offset = "0x2909FC0", VA = "0x18290ABC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xB41420", Offset = "0xB40820", VA = "0x180B41420", Slot = "17")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x290AF60", Offset = "0x290A360", VA = "0x18290AF60", Slot = "18")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x290B250", Offset = "0x290A650", VA = "0x18290B250", Slot = "19")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xB9A340", Offset = "0xB99740", VA = "0x180B9A340", Slot = "21")]
	private void LOBKPDGDECO(global::HDHFLPILNPM DFLHLPHDCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0xB41360", Offset = "0xB40760", VA = "0x180B41360", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x290A9D0", Offset = "0x2909DD0", VA = "0x18290A9D0")]
	private HEKFLAGDMLJ ABOPLEIFCAD(Entity GKMECPLEALF)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x290B030", Offset = "0x290A430", VA = "0x18290B030", Slot = "6")]
	public HEKFLAGDMLJ LAAKJDOAPFC(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x290AD30", Offset = "0x290A130", VA = "0x18290AD30", Slot = "7")]
	public void IJBFDPMGIJM(ref List<HEKFLAGDMLJ> LEIIMBCJOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x290B4E0", Offset = "0x290A8E0", VA = "0x18290B4E0", Slot = "11")]
	public int ONPGMOCNIHI(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x290AA20", Offset = "0x2909E20", VA = "0x18290AA20", Slot = "12")]
	public FDJPAKEFOJE AMLMJHKBLMG(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x290B3A0", Offset = "0x290A7A0", VA = "0x18290B3A0", Slot = "15")]
	public HEKFLAGDMLJ OKDEEBIDGEN(HEKFLAGDMLJ JNHEGOFDJBP, HEKFLAGDMLJ JBNLIGHJDME)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x290B120", Offset = "0x290A520", VA = "0x18290B120", Slot = "16")]
	public bool MPHFLBOJAHA(HEKFLAGDMLJ JNHEGOFDJBP, HEKFLAGDMLJ JBNLIGHJDME, out HEKFLAGDMLJ MCDGHNFJPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x290B680", Offset = "0x290AA80", VA = "0x18290B680", Slot = "8")]
	public HEKFLAGDMLJ OPCIHBBNLKJ(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x290B0C0", Offset = "0x290A4C0", VA = "0x18290B0C0", Slot = "14")]
	public bool LOJMEIIDDGG(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ BGACBDKLDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x290AC70", Offset = "0x290A070", VA = "0x18290AC70", Slot = "13")]
	public bool GNBOGMACBNL(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ BPLKOFNPIGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x290AB40", Offset = "0x2909F40", VA = "0x18290AB40", Slot = "9")]
	public bool CILNNMACHKK(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ OJBGDMNECON, bool KJNJDCMKFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x290ACD0", Offset = "0x290A0D0", VA = "0x18290ACD0", Slot = "10")]
	public bool IHIEJEAIEMM(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ OJBGDMNECON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public CNJNPPJIMBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class HGJEOGGNKED : JGECFECPNBB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> OAOEFJJHNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private int GJCEJHBAGBE;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> NLAOAIANNAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9857D0", Offset = "0x984BD0", VA = "0x1809857D0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int FDMDKOOPHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA0C050", Offset = "0xA0B450", VA = "0x180A0C050", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x28E6F60", Offset = "0x28E6360", VA = "0x1828E6F60")]
	public HGJEOGGNKED(NativeArray<EntityRemapUtility.EntityRemapInfo> OAOEFJJHNOK, int GJCEJHBAGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x28E6E80", Offset = "0x28E6280", VA = "0x1828E6E80", Slot = "6")]
	public HEKFLAGDMLJ FCOJNMGNAII(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x28E6F20", Offset = "0x28E6320", VA = "0x1828E6F20", Slot = "8")]
	public LocalId FCOJNMGNAII(LocalId GKMECPLEALF)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x28E6E20", Offset = "0x28E6220", VA = "0x1828E6E20", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[NECCFHPLDLJ(typeof(JNOKJGPGAHI))]
[EPJIKDLNGEH(typeof(FEGFINCBOCB), new string[] { })]
[NECCFHPLDLJ(typeof(OEGCJPFACKE))]
public class KBMPCMLFMEC : FEGFINCBOCB, FFLHMNCCPBG, OEGCJPFACKE, IDisposable, JNOKJGPGAHI
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly ProfilerMarker JHJNDBFHIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private DOFBPGFFJDE CEMAJLICLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private FFCBJDNAPKG NNFPDEGNOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private EEKNAEJEFGF DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private POKOBOIBHEN APIEELPANAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public DOFBPGFFJDE DANEBHHOICE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public EEKNAEJEFGF GHGAMEAKNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public POKOBOIBHEN CKBGDPGPGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x11AA2E0", Offset = "0x11A96E0", VA = "0x1811AA2E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool GKODBKCLOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1578920", Offset = "0x1577D20", VA = "0x181578920", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x1578930", Offset = "0x1577D30", VA = "0x181578930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public GPJLAPAOJAB FJOGDMJJGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x12DF490", Offset = "0x12DE890", VA = "0x1812DF490", Slot = "9")]
		get
		{
			return default(GPJLAPAOJAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x28F8460", Offset = "0x28F7860", VA = "0x1828F8460", Slot = "13")]
	private void DMPOFLHPBAG(bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x28F82E0", Offset = "0x28F76E0", VA = "0x1828F82E0")]
	public static KBMPCMLFMEC DEDAFMGEJMH(DOFBPGFFJDE CEMAJLICLCP, NFLPKIOPICE BLBMFDIEDCO = NFLPKIOPICE.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void HJMJNDMEONN(DOFBPGFFJDE CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void GMAMPAMNFBI(DOFBPGFFJDE CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x28F86F0", Offset = "0x28F7AF0", VA = "0x1828F86F0", Slot = "10")]
	public void HKHFIGFLBOE(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xA2D570", Offset = "0xA2C970", VA = "0x180A2D570")]
	private void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x28F8800", Offset = "0x28F7C00", VA = "0x1828F8800")]
	private void KGMFJDGAAHI(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x28F8690", Offset = "0x28F7A90", VA = "0x1828F8690", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public KBMPCMLFMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class GEAPPJEGLCN
{
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, GLHHELGFOCN
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static readonly EHKEPJIBENP IGCLICKKCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private IMPAOGMALJN prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private HEKFLAGDMLJ LEMCMBEMOCB;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual IMPAOGMALJN FEDCCKGMNFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x978170", Offset = "0x977570", VA = "0x180978170", Slot = "6")]
			get
			{
				return default(IMPAOGMALJN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD50", Offset = "0x8BB150", VA = "0x1808BBD50", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public HEKFLAGDMLJ MIHFCEGNEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xF4B480", Offset = "0xF4A880", VA = "0x180F4B480", Slot = "5")]
			get
			{
				return default(HEKFLAGDMLJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool HPOMJOMGINK
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x8C8440", Offset = "0x8C7840", VA = "0x1808C8440", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8C84B0", Offset = "0x8C78B0", VA = "0x1808C84B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		internal Entity JFBIKPNIMAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2496610", Offset = "0x2495A10", VA = "0x182496610")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		internal IMBCAHJKJCI CLDDIHPGFHC
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x24969A0", Offset = "0x2495DA0", VA = "0x1824969A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		internal GGNFHIGGHPN PLNCJGGLGBA
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x24964F0", Offset = "0x24958F0", VA = "0x1824964F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x24963A0", Offset = "0x24957A0", VA = "0x1824963A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x24963B0", Offset = "0x24957B0", VA = "0x1824963B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2496620", Offset = "0x2495A20", VA = "0x182496620")]
		internal void MHIDNOPDKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2496570", Offset = "0x2495970", VA = "0x182496570")]
		private bool JFEDIEGCKEC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x24964C0", Offset = "0x24958C0", VA = "0x1824964C0")]
		private void DPHOLGAGDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x24963B0", Offset = "0x24957B0", VA = "0x1824963B0")]
		internal void DODJNFMPKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x24969B0", Offset = "0x2495DB0", VA = "0x1824969B0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2496B10", Offset = "0x2495F10", VA = "0x182496B10")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class NDJMBBEGBFP : JFGEDJGHDDN
{
	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2A75930", Offset = "0x2A74D30", VA = "0x182A75930", Slot = "5")]
	public override Action JBHGDLCJEJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void IFJNBLLMIJI<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2A758A0", Offset = "0x2A74CA0", VA = "0x182A758A0")]
	[UnityEngine.Scripting.Preserve]
	public void EDICCMGOAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2954E10", Offset = "0x2954210", VA = "0x182954E10")]
	protected NDJMBBEGBFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[EPJIKDLNGEH(typeof(ICCLAPFHPJL), new string[] { })]
public class PDPJKLHOMKJ : ICCLAPFHPJL, IDisposable, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	[BOJGNOMIPCG]
	private NNFPBHEJLKI MKJDJNIEIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[BOJGNOMIPCG]
	private OCCDPACEAEH FEJNNANFOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private World GPJPADMHJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private World OKHCNMBCCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private bool MPKLCKFMAAF;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public World HBDGJGALOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public World GLGFHNDCHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x24832D0", Offset = "0x24826D0", VA = "0x1824832D0", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x15CD790", Offset = "0x15CCB90", VA = "0x1815CD790", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x24832F0", Offset = "0x24826F0", VA = "0x1824832F0", Slot = "10")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2482E20", Offset = "0x2482220", VA = "0x182482E20")]
	private void DEDAFMGEJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2482FD0", Offset = "0x24823D0", VA = "0x182482FD0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2482FB0", Offset = "0x24823B0", VA = "0x182482FB0", Slot = "8")]
	public ComponentSystemBase DGLBDIOIPBK(Type GANFKPHKNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public PDPJKLHOMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[EPJIKDLNGEH(typeof(JCHEJDGEOCC), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public class JCHEJDGEOCC : NEHPEGODEDF, APKELBFAHNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct DKGHJJJLBGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private NativeArray<int> HFHDBOMHMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private NativeArray<int> MMCGJOGCCIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Dictionary<ComponentSystemBase, int> LKFLFMJGHAP;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x27B28F0", Offset = "0x27B1CF0", VA = "0x1827B28F0")]
		public DKGHJJJLBGG(NativeArray<int> HFHDBOMHMAP, NativeArray<int> MMCGJOGCCIJ, Dictionary<ComponentSystemBase, int> LKFLFMJGHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x27B27C0", Offset = "0x27B1BC0", VA = "0x1827B27C0")]
		public static void LLOMAJNEHAA(World GLBDCLCAOJH, FGCKLJIPPNH LLLDEPJNABK, NativeArray<int> HFHDBOMHMAP, NativeArray<int> MMCGJOGCCIJ, Dictionary<ComponentSystemBase, int> LKFLFMJGHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x27B2530", Offset = "0x27B1930", VA = "0x1827B2530")]
		public void FEFDKGNCLIC(IEnumerable<ComponentSystemBase> NNFPDEGNOEP, FGCKLJIPPNH LLLDEPJNABK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class BPAGLKNFFBJ : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private ComponentSystemBase <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private int start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public int <>3__start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private int end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int <>3__end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public JCHEJDGEOCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private int <i>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public BPAGLKNFFBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x27AF8F0", Offset = "0x27AECF0", VA = "0x1827AF8F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x27AFAC0", Offset = "0x27AEEC0", VA = "0x1827AFAC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x27AFA10", Offset = "0x27AEE10", VA = "0x1827AFA10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x27AFA10", Offset = "0x27AEE10", VA = "0x1827AFA10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly EHKEPJIBENP NBHHMEANBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private World GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private IABLIMOJJBC CEMAJLICLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeArray<int> ABLJJCBIBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private NativeArray<int> HKIGJOMGCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private int LJJHJABONIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private FGCKLJIPPNH EONOEAEOKGN;

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x28EE5E0", Offset = "0x28ED9E0", VA = "0x1828EE5E0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x28EDE10", Offset = "0x28ED210", VA = "0x1828EDE10", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x28EDCE0", Offset = "0x28ED0E0", VA = "0x1828EDCE0")]
	[IteratorStateMachine(typeof(BPAGLKNFFBJ))]
	private IEnumerable<ComponentSystemBase> CDEHHMAKLGM(int OANIJIEMEHN, int ELBJBJNOEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x28EDB50", Offset = "0x28ECF50", VA = "0x1828EDB50", Slot = "5")]
	public void FBBGMFMCEJA(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x28EDB50", Offset = "0x28ECF50", VA = "0x1828EDB50")]
	private void BGJIKPOFDMG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x28EDBD0", Offset = "0x28ECFD0", VA = "0x1828EDBD0")]
	public void BGJIKPOFDMG(FGCKLJIPPNH JENBKILGPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x28EE880", Offset = "0x28EDC80", VA = "0x1828EE880")]
	private void OBEOLNBBGHA(FGCKLJIPPNH JENBKILGPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x28EDD70", Offset = "0x28ED170", VA = "0x1828EDD70")]
	private void CJEDEEOOOGD(FGCKLJIPPNH JENBKILGPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x28EE810", Offset = "0x28EDC10", VA = "0x1828EE810")]
	private void NJEEPHKKOMC(FGCKLJIPPNH JENBKILGPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x28EDFB0", Offset = "0x28ED3B0", VA = "0x1828EDFB0")]
	private void GFKLDAEPJOP(int OANIJIEMEHN, int ELBJBJNOEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x28EEB20", Offset = "0x28EDF20", VA = "0x1828EEB20")]
	private void PKHBEMIICDL(int OANIJIEMEHN, int ELBJBJNOEIJ, bool OMIGIJBCKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x28EDAF0", Offset = "0x28ECEF0", VA = "0x1828EDAF0")]
	private int AMDMGFPFLDF(FGCKLJIPPNH JENBKILGPDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x28EE0D0", Offset = "0x28ED4D0", VA = "0x1828EE0D0")]
	private bool HKCIDEAIBDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x28EE6C0", Offset = "0x28EDAC0", VA = "0x1828EE6C0")]
	private Dictionary<ComponentSystemBase, int> LMDEBOOBHDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x28EDB10", Offset = "0x28ECF10", VA = "0x1828EDB10")]
	private void BFELBFDBJED(NativeArray<int> HFHDBOMHMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x28EDEA0", Offset = "0x28ED2A0", VA = "0x1828EDEA0")]
	private void EJAHBOGDMAN(NativeArray<int> MMCGJOGCCIJ, NativeArray<int> HFHDBOMHMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x28EE070", Offset = "0x28ED470", VA = "0x1828EE070")]
	private static FGCKLJIPPNH GMIGLFFHBPF(Type GANFKPHKNKH, FGCKLJIPPNH CHKFHALGEFG)
	{
		return default(FGCKLJIPPNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x28EECB0", Offset = "0x28EE0B0", VA = "0x1828EECB0")]
	public JCHEJDGEOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x28EDF50", Offset = "0x28ED350", VA = "0x1828EDF50")]
	[CompilerGenerated]
	private void FKDJPMLBLBJ(NEHPEGODEDF HODIGKENGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x28EE7B0", Offset = "0x28EDBB0", VA = "0x1828EE7B0")]
	[CompilerGenerated]
	private void MFHNEBPBCHC(BKHNPHMEICP HODIGKENGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class GKMDMNGLEOD : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x28DEB20", Offset = "0x28DDF20", VA = "0x1828DEB20", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x28DED60", Offset = "0x28DE160", VA = "0x1828DED60")]
	[UnityEngine.Scripting.Preserve]
	private void LAFIHKBMMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public GKMDMNGLEOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[EPJIKDLNGEH(typeof(POKOBOIBHEN), new string[] { })]
public class IHLFFDGHEKN : POKOBOIBHEN, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly EHKEPJIBENP EHKPBHOOFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private DOFBPGFFJDE CEMAJLICLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private JNOKJGPGAHI DPBAOGNAELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private EEKNAEJEFGF DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private FEGFINCBOCB PKDKKELFBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private HMHHFNDBEKM OCKKDLPLKDJ;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool JDNLFCKFPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x28EBB00", Offset = "0x28EAF00", VA = "0x1828EBB00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action PBLAFGAPNDF
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x28EBFF0", Offset = "0x28EB3F0", VA = "0x1828EBFF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x28EBB70", Offset = "0x28EAF70", VA = "0x1828EBB70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x28EBF20", Offset = "0x28EB320", VA = "0x1828EBF20", Slot = "12")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x28EBC10", Offset = "0x28EB010", VA = "0x1828EBC10", Slot = "6")]
	public void FJDLLGFKIPL(bool PINJDLEFOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x28EC0A0", Offset = "0x28EB4A0", VA = "0x1828EC0A0", Slot = "7")]
	public bool PPDPHLPNKOF(ByteString DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x28EC090", Offset = "0x28EB490", VA = "0x1828EC090", Slot = "11")]
	public void LBDHAKIGGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x974A30", Offset = "0x973E30", VA = "0x180974A30", Slot = "9")]
	public void FCDBHEJBCCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x28EBDE0", Offset = "0x28EB1E0", VA = "0x1828EBDE0", Slot = "10")]
	public void ICPOGOKNJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public IHLFFDGHEKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[Flags]
public enum NFLPKIOPICE
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
[EPJIKDLNGEH(typeof(MLLPEILMGAD), new string[] { })]
public class MLLPEILMGAD : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[BOJGNOMIPCG]
	private BJKJCFIJEFI IGHEGPOBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[BOJGNOMIPCG]
	private JCHEJDGEOCC FDCNKJCHIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[BOJGNOMIPCG]
	private NBPNODCEBKF FBJJPAAFOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[BOJGNOMIPCG]
	private COKHJGJNDIB LGIGGJMIOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2A71570", Offset = "0x2A70970", VA = "0x182A71570", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2A71510", Offset = "0x2A70910", VA = "0x182A71510", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x2A71440", Offset = "0x2A70840", VA = "0x182A71440")]
	private void BLMNCBKFDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x2A71510", Offset = "0x2A70910", VA = "0x182A71510")]
	private void GFILLOGNBKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x2A713F0", Offset = "0x2A707F0", VA = "0x182A713F0")]
	private void BJIEGNMFPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public MLLPEILMGAD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public EntityReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[EPJIKDLNGEH(typeof(FOMKJGJNDPD), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal class FOMKJGJNDPD : NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private IJGPMAMDKLF KCJJGLLIALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private OENENEPEABD PICIAEGHAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private KCPMLDAAPLA AMAMOMGEHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[BOJGNOMIPCG]
	private DOKFAOCNIFN ILDIIFMLPBD;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public OPKICLGEFDB PIHEIIEBIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8D0170", Offset = "0x8CF570", VA = "0x1808D0170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x28DB820", Offset = "0x28DAC20", VA = "0x1828DB820", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x28DB780", Offset = "0x28DAB80", VA = "0x1828DB780")]
	private void GKHMMOAPNGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x28DB6B0", Offset = "0x28DAAB0", VA = "0x1828DB6B0")]
	public KEJDGFDNFFK GIINAFHDMKE(LOHCJILDMLL GDKOBCHHFLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x17B4AA0", Offset = "0x17B3EA0", VA = "0x1817B4AA0")]
	public FODDMFHDJFA<T> BGJNILMKFDJ<T>(LOHCJILDMLL GDKOBCHHFLB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public FOMKJGJNDPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class IFCEIBELGMC
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x227FA20", Offset = "0x227EE20", VA = "0x18227FA20")]
	public static DFGKOFELELE<T> GIINAFHDMKE<T>(this FOMKJGJNDPD EJJJBNPLDND, ENIPADEGOMD<T> GDKOBCHHFLB) where T : struct
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x24826D0", Offset = "0x2481AD0", VA = "0x1824826D0")]
		public static ObjectModelConfigAsset AHIPHBBLPCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x9840D0", Offset = "0x9834D0", VA = "0x1809840D0")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class JFGEDJGHDDN : DNFEOMMLDKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly MethodInfo ACHJFKKDNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Type[] AIEGNLJMEEC;

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x28F0BB0", Offset = "0x28EFFB0", VA = "0x1828F0BB0")]
	public JFGEDJGHDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action JBHGDLCJEJH();

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x28F0B70", Offset = "0x28EFF70", VA = "0x1828F0B70")]
	public MethodInfo FIIOMCAGGPC(Action NDPBOAHDPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x28F09C0", Offset = "0x28EFDC0", VA = "0x1828F09C0", Slot = "4")]
	public void EHBDNPLCIKI(Type GANFKPHKNKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[NECCFHPLDLJ(typeof(GNNOHHPIEOC))]
[EPJIKDLNGEH(typeof(HMHHFNDBEKM), new string[] { })]
internal class GNNOHHPIEOC : HMHHFNDBEKM, IDisposable, NEHPEGODEDF, APKELBFAHNG
{
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly EHKEPJIBENP EHKPBHOOFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[BOJGNOMIPCG]
	private EEKNAEJEFGF DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[BOJGNOMIPCG]
	private POKOBOIBHEN APIEELPANAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[BOJGNOMIPCG]
	private ENLINJHCCDI PBBOHGPNEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private FEGFINCBOCB PKDKKELFBAB;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool EDDAPKJCLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x11AA2E0", Offset = "0x11A96E0", VA = "0x1811AA2E0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x11B7640", Offset = "0x11B6A40", VA = "0x1811B7640", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool IBNACHJKIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x28E0FD0", Offset = "0x28E03D0", VA = "0x1828E0FD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool IIDCPPLGBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x1578920", Offset = "0x1577D20", VA = "0x181578920", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x1578930", Offset = "0x1577D30", VA = "0x181578930", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public MPCJLDHBHBF JEGJLHEAILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x8D0170", Offset = "0x8CF570", VA = "0x1808D0170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x28E15A0", Offset = "0x28E09A0", VA = "0x1828E15A0", Slot = "15")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x28E1190", Offset = "0x28E0590", VA = "0x1828E1190", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x28E0FE0", Offset = "0x28E03E0", VA = "0x1828E0FE0", Slot = "8")]
	public CEGKNKGECDI DCPFAFGEGGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x28E12B0", Offset = "0x28E06B0", VA = "0x1828E12B0")]
	public CEGKNKGECDI GMCGBJGGAOO(IEnumerable<HEKFLAGDMLJ> GAOJFDPACED, in IJEMHFEELIK LALJEPDPLMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x28E0DD0", Offset = "0x28E01D0", VA = "0x1828E0DD0", Slot = "10")]
	public MHBNDALDLMC CFMILAHIEDD(ByteString DCBJJADOEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x28E1A90", Offset = "0x28E0E90", VA = "0x1828E1A90")]
	public NDHMEAKEDNA OINMJBEDGCK(ByteString DCBJJADOEJL, HEKFLAGDMLJ OJBGDMNECON, in IJEMHFEELIK CEBAGGBJPNN, MFMOHGACDCK COFIPIBFCKH, bool EDLLHCLBOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x28E1650", Offset = "0x28E0A50", VA = "0x1828E1650", Slot = "12")]
	public void KPCDGHPLLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x28E18D0", Offset = "0x28E0CD0", VA = "0x1828E18D0", Slot = "13")]
	public ALNGHMJNFBH MDJOMPBEPAG(IEnumerable<GGLLEGPCFPG> COINOLJIGKE)
	{
		return default(ALNGHMJNFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x28E1CC0", Offset = "0x28E10C0", VA = "0x1828E1CC0")]
	public static bool PPDPHLPNKOF(ByteString DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x28E1190", Offset = "0x28E0590", VA = "0x1828E1190")]
	private void JGCKCGBCGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2115BE0", Offset = "0x2114FE0", VA = "0x182115BE0")]
	private void MEGHFINJAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x28E1810", Offset = "0x28E0C10", VA = "0x1828E1810")]
	private void LMBELOFKPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x28E1200", Offset = "0x28E0600", VA = "0x1828E1200", Slot = "16")]
	public void FBBGMFMCEJA(IABLIMOJJBC LLDNLOJJLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public GNNOHHPIEOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x28E11F0", Offset = "0x28E05F0", VA = "0x1828E11F0", Slot = "9")]
	private CEGKNKGECDI EAHCCPMEMKK(IEnumerable<HEKFLAGDMLJ> GAOJFDPACED, in IJEMHFEELIK LALJEPDPLMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x28E0F80", Offset = "0x28E0380", VA = "0x1828E0F80", Slot = "11")]
	private NDHMEAKEDNA CHPEDGNEGKG(ByteString DCBJJADOEJL, HEKFLAGDMLJ OJBGDMNECON, in IJEMHFEELIK CEBAGGBJPNN, MFMOHGACDCK COFIPIBFCKH, bool EDLLHCLBOMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct OBBJAOPMBHM : IEnumerable<EPNLHMEPBGM>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum INEOFMFNJEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct JDPDJIACAEL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private NativeList<byte> CLCAIFLMLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private OBBJAOPMBHM FIONHDMDJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly EPNLHMEPBGM OIEACLJHHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int OANIJIEMEHN;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x27B7940", Offset = "0x27B6D40", VA = "0x1827B7940")]
		internal JDPDJIACAEL(OBBJAOPMBHM FIONHDMDJNK, EPNLHMEPBGM OIEACLJHHPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x27B7860", Offset = "0x27B6C60", VA = "0x1827B7860", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x27B7890", Offset = "0x27B6C90", VA = "0x1827B7890")]
		public void JHGLEICCIMO(ReadOnlySpan<byte> AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x27B7760", Offset = "0x27B6B60", VA = "0x1827B7760")]
		private void DINKMEMLJBL(ReadOnlySpan<byte> AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x27B7800", Offset = "0x27B6C00", VA = "0x1827B7800")]
		private unsafe void DINKMEMLJBL(void* JOONJMEEOBM, int HBBGBOONHJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct LDEDJLPIMLA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private OBBJAOPMBHM FIONHDMDJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private NativeArray<byte> CLCAIFLMLCJ;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x27B8A50", Offset = "0x27B7E50", VA = "0x1827B8A50")]
		internal LDEDJLPIMLA(OBBJAOPMBHM FIONHDMDJNK, NativeArray<byte> CLCAIFLMLCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x27B8980", Offset = "0x27B7D80", VA = "0x1827B8980", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x27B8990", Offset = "0x27B7D90", VA = "0x1827B8990")]
		public NativeArray<byte> MKCMDPHEHFF(int HBBGBOONHJE)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x27B8840", Offset = "0x27B7C40", VA = "0x1827B8840")]
		public void DJIDKKAAOFC(Span<byte> AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public struct HGJNABBNMDA : IEnumerator<EPNLHMEPBGM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly NativeList<EPNLHMEPBGM> EACKPMFPNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int BNOAGGNAMKG;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public EPNLHMEPBGM AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x27B6750", Offset = "0x27B5B50", VA = "0x1827B6750", Slot = "4")]
			get
			{
				return default(EPNLHMEPBGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x27B6710", Offset = "0x27B5B10", VA = "0x1827B6710", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x27B65C0", Offset = "0x27B59C0", VA = "0x1827B65C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x27B66D0", Offset = "0x27B5AD0", VA = "0x1827B66D0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private struct CPBCGNEAJGC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private NativeArray<int> CLCAIFLMLCJ;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool NDGDBIMBJKD
		{
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x27B0750", Offset = "0x27AFB50", VA = "0x1827B0750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int LNCFJAILFEH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x27B06C0", Offset = "0x27AFAC0", VA = "0x1827B06C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x27B0790", Offset = "0x27AFB90", VA = "0x1827B0790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public INEOFMFNJEE EOAFMIEKBPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x27B0730", Offset = "0x27AFB30", VA = "0x1827B0730")]
			get
			{
				return default(INEOFMFNJEE);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x27B0740", Offset = "0x27AFB40", VA = "0x1827B0740")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool GCDNFMKJMOL
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x27B06A0", Offset = "0x27AFAA0", VA = "0x1827B06A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool ALKEIEICINI
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x27B06D0", Offset = "0x27AFAD0", VA = "0x1827B06D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x27B07D0", Offset = "0x27AFBD0", VA = "0x1827B07D0")]
		public CPBCGNEAJGC(INEOFMFNJEE APMKINDDMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x27B07A0", Offset = "0x27AFBA0", VA = "0x1827B07A0")]
		private int PHGLOPEHIMO(int AEHKIMOEIJL, int OGLNCDJGOGI = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x27B0660", Offset = "0x27AFA60", VA = "0x1827B0660")]
		private void AFLFAPDAOKF(int AEHKIMOEIJL, int AGLCIEKHLEE, int OGLNCDJGOGI = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x27B06F0", Offset = "0x27AFAF0", VA = "0x1827B06F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly EPNLHMEPBGM MLFHPEAHODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeParallelHashMap<EPNLHMEPBGM, int> LJDAPCBGJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeList<EPNLHMEPBGM> PBBOHGPNEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NativeList<int> HKIGJOMGCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private NativeList<byte> AEFPPICIIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeList<byte> CLCAIFLMLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private CPBCGNEAJGC NPOLKGPPPJC;

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D5A0", Offset = "0x2A7C9A0", VA = "0x182A7D5A0")]
	public static OBBJAOPMBHM DEDAFMGEJMH(INEOFMFNJEE APMKINDDMDL = INEOFMFNJEE.Last, int JEACNBLLDHO = 16, int LINAAHCFPDO = 256)
	{
		return default(OBBJAOPMBHM);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DF80", Offset = "0x2A7D380", VA = "0x182A7DF80")]
	private OBBJAOPMBHM(INEOFMFNJEE APMKINDDMDL, int JEACNBLLDHO, int LINAAHCFPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D5E0", Offset = "0x2A7C9E0", VA = "0x182A7D5E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D8B0", Offset = "0x2A7CCB0", VA = "0x182A7D8B0")]
	public JDPDJIACAEL JEBFOOFJHCO(EPNLHMEPBGM OIEACLJHHPB)
	{
		return default(JDPDJIACAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DAE0", Offset = "0x2A7CEE0", VA = "0x182A7DAE0")]
	public bool PCKHEMACOMB(EPNLHMEPBGM OIEACLJHHPB, out LDEDJLPIMLA FLFEOLIKEEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D9A0", Offset = "0x2A7CDA0", VA = "0x182A7D9A0")]
	public bool OGANDLBGJOJ(EPNLHMEPBGM OIEACLJHHPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DDB0", Offset = "0x2A7D1B0", VA = "0x182A7DDB0")]
	public bool PFPMPIAMNHI(EPNLHMEPBGM OIEACLJHHPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DCD0", Offset = "0x2A7D0D0", VA = "0x182A7DCD0")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D6C0", Offset = "0x2A7CAC0", VA = "0x182A7D6C0")]
	private void IADCGMMJKJH(EPNLHMEPBGM OIEACLJHHPB, int OANIJIEMEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D9F0", Offset = "0x2A7CDF0", VA = "0x182A7D9F0")]
	private void PAEMBCIMPJO(int EDAHLELDGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D4B0", Offset = "0x2A7C8B0", VA = "0x182A7D4B0")]
	private void CHEDHBPOBFP(EPNLHMEPBGM OIEACLJHHPB, int OANIJIEMEHN, int HBBGBOONHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DEC0", Offset = "0x2A7D2C0", VA = "0x182A7DEC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DE80", Offset = "0x2A7D280", VA = "0x182A7DE80", Slot = "4")]
	private IEnumerator<EPNLHMEPBGM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
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
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public override IMPAOGMALJN FEDCCKGMNFD
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x24939B0", Offset = "0x2492DB0", VA = "0x1824939B0", Slot = "6")]
			get
			{
				return default(IMPAOGMALJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2493950", Offset = "0x2492D50", VA = "0x182493950")]
		public RbexEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class GLBAPBLLOKL
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public static class PNGJMICMOEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly EHKEPJIBENP IGCLICKKCHJ;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x27BDB30", Offset = "0x27BCF30", VA = "0x1827BDB30")]
		public static JDPNCHCMAIA NCHEABGJMBM(int DKHENKBOAEL, MPCJLDHBHBF CMBFEPDDNLN)
		{
			return default(JDPNCHCMAIA);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x27BDFD0", Offset = "0x27BD3D0", VA = "0x1827BDFD0")]
		private static HEKFLAGDMLJ NCPDBHNFFIE(MPCJLDHBHBF NNJOJJMDCHN, HEKFLAGDMLJ CPDGCDENHHH)
		{
			return default(HEKFLAGDMLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x27BD980", Offset = "0x27BCD80", VA = "0x1827BD980")]
		private static void HECNLHPLBOB(HEKFLAGDMLJ MEANFKLOIIE, HEKFLAGDMLJ CGEKDMFLOCI, JDPNCHCMAIA DDCHJBPICDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x27BD720", Offset = "0x27BCB20", VA = "0x1827BD720")]
		public static int DBBFGGGAFPI(GameObject NNAKJIJAOJG, CEGKNKGECDI NKCAEBHOIOK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static DOFBPGFFJDE NDLJCHBKHGN;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static FEGFINCBOCB PKDKKELFBAB;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public static FEGFINCBOCB DCPCPFHMBHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x28DF120", Offset = "0x28DE520", VA = "0x1828DF120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public static bool MNKMLJNGFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x28DF8E0", Offset = "0x28DECE0", VA = "0x1828DF8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public static IABLIMOJJBC DANEBHHOICE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x28DFAD0", Offset = "0x28DEED0", VA = "0x1828DFAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public static FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x28DF280", Offset = "0x28DE680", VA = "0x1828DF280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public static FEEKAOBEJNL JIOBCDMNGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x28DF780", Offset = "0x28DEB80", VA = "0x1828DF780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public static IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x28E00C0", Offset = "0x28DF4C0", VA = "0x1828E00C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public static OHAMPNBKDLP LJHMBDPCDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x28DF800", Offset = "0x28DEC00", VA = "0x1828DF800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public static MAFOFLPIDLK OLAINEOHBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x28E0140", Offset = "0x28DF540", VA = "0x1828E0140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public static bool PFHIAFAGPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x28DEF80", Offset = "0x28DE380", VA = "0x1828DEF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public static bool OKGAKMODECF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x28DFA80", Offset = "0x28DEE80", VA = "0x1828DFA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public static MDECDPGCMCD IAGEFKLKOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x28DEE40", Offset = "0x28DE240", VA = "0x1828DEE40")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public static bool KCGJNGJNAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x28DF300", Offset = "0x28DE700", VA = "0x1828DF300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public static byte PHPEDHAFEON
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x28DF660", Offset = "0x28DEA60", VA = "0x1828DF660")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public static byte OKNIOMJNKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public static bool KHKNEIKBHCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x28DF880", Offset = "0x28DEC80", VA = "0x1828DF880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public static bool BDONMFCMOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x28DEDE0", Offset = "0x28DE1E0", VA = "0x1828DEDE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x28DFDF0", Offset = "0x28DF1F0", VA = "0x1828DFDF0")]
	public static void NFNGMLJEMPJ(DOFBPGFFJDE AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x28DF4E0", Offset = "0x28DE8E0", VA = "0x1828DF4E0")]
	public static HEKFLAGDMLJ FLILGDFALDL(GameObject NNAKJIJAOJG)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x28DFF50", Offset = "0x28DF350", VA = "0x1828DFF50")]
	public static MDECDPGCMCD ODHJCPPNPBP(JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x28DF3A0", Offset = "0x28DE7A0", VA = "0x1828DF3A0")]
	public static bool FEEDIAEPHJG(GameObject NNAKJIJAOJG, out JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x28DFB50", Offset = "0x28DEF50", VA = "0x1828DFB50")]
	public static ALNGHMJNFBH MDJOMPBEPAG(IEnumerable<GGLLEGPCFPG> COINOLJIGKE)
	{
		return default(ALNGHMJNFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x28DF000", Offset = "0x28DE400", VA = "0x1828DF000")]
	private static FEGFINCBOCB BMDGIMGMNJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x28DFC90", Offset = "0x28DF090", VA = "0x1828DFC90")]
	private static bool NAGMMMLJNHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class BHNKLPADIJB
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct EPNLHMEPBGM : IComparable<EPNLHMEPBGM>, IEquatable<EPNLHMEPBGM>
{
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public static readonly EPNLHMEPBGM ENEHFIHPPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public JDPNCHCMAIA JBFCCDGDFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public FDOJMOENJAL IOPMEPNDGKE;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool NNGOFJDJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x295DBF0", Offset = "0x295CFF0", VA = "0x18295DBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xAEEC80", Offset = "0xAEE080", VA = "0x180AEEC80")]
	public EPNLHMEPBGM(JDPNCHCMAIA JBFCCDGDFOM, FDOJMOENJAL IOPMEPNDGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x295DA80", Offset = "0x295CE80", VA = "0x18295DA80", Slot = "4")]
	public int CompareTo(EPNLHMEPBGM ICELKIGIKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x295DC00", Offset = "0x295D000", VA = "0x18295DC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x295DB10", Offset = "0x295CF10", VA = "0x18295DB10", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x295DAC0", Offset = "0x295CEC0", VA = "0x18295DAC0", Slot = "5")]
	public bool Equals(EPNLHMEPBGM ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x295DBB0", Offset = "0x295CFB0", VA = "0x18295DBB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[EPJIKDLNGEH(typeof(GPOAEEEPBAB), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
internal class GPOAEEEPBAB : NEHPEGODEDF, BKHNPHMEICP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private GGNFHIGGHPN IIGHBGGPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private DFGKOFELELE<Entity> OJBGDMNECON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private COKHJGJNDIB HJBFJMLNKGK;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x28E2300", Offset = "0x28E1700", VA = "0x1828E2300", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x28E2370", Offset = "0x28E1770", VA = "0x1828E2370", Slot = "5")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x28E2260", Offset = "0x28E1660", VA = "0x1828E2260", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x28E2130", Offset = "0x28E1530", VA = "0x1828E2130")]
	private void CFJMHOEBGPN(Entity GKMECPLEALF, in CIMGDHMJEHM FNIKJMODJCE, in CIMGDHMJEHM PINJDLEFOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public GPOAEEEPBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[EPJIKDLNGEH(typeof(NJNJAPPDECP), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal class NJNJAPPDECP : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[BOJGNOMIPCG]
	private IJGPMAMDKLF OEGNIABGFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly Dictionary<int, NFCKPDCDELJ> HDGOEDAKAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A7AFC0", Offset = "0x2A7A3C0", VA = "0x182A7AFC0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A7AA10", Offset = "0x2A79E10", VA = "0x182A7AA10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A7AC90", Offset = "0x2A7A090", VA = "0x182A7AC90")]
	public NFCKPDCDELJ FEMJGENMDLA(LOHCJILDMLL OCFGMKDOPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A7AD90", Offset = "0x2A7A190", VA = "0x182A7AD90")]
	public NFCKPDCDELJ FEMJGENMDLA(FDOJMOENJAL IOPMEPNDGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B010", Offset = "0x2A7A410", VA = "0x182A7B010")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B1B0", Offset = "0x2A7A5B0", VA = "0x182A7B1B0")]
	public NJNJAPPDECP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[EPJIKDLNGEH(typeof(KLFMCFLGABP), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public class KLFMCFLGABP
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public struct JBONKPEPDPF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private readonly KLFMCFLGABP OJBGDMNECON;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x27B7740", Offset = "0x27B6B40", VA = "0x1827B7740", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int CNAHNJHPBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action GHFNNGLIKEC;

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A64670", Offset = "0x2A63A70", VA = "0x182A64670")]
	public void GMNLIGHENPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public KLFMCFLGABP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DefaultMember("Item")]
public class LPCJLGHGNMN<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Func<From, To> AGHGFPLOCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly Func<To, From> MFDLOAEMICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<From> EACKPMFPNLH;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public To ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x271C9D0", Offset = "0x271BDD0", VA = "0x18271C9D0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x271CA20", Offset = "0x271BE20", VA = "0x18271CA20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x271C990", Offset = "0x271BD90", VA = "0x18271C990", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool BAJNPCIAOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2456A10", Offset = "0x2455E10", VA = "0x182456A10")]
	public LPCJLGHGNMN(Func<From, To> AGHGFPLOCKI, Func<To, From> MFDLOAEMICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x271C5A0", Offset = "0x271B9A0", VA = "0x18271C5A0", Slot = "11")]
	public void Add(To CFHFBNLLHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x271C5E0", Offset = "0x271B9E0", VA = "0x18271C5E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x271C620", Offset = "0x271BA20", VA = "0x18271C620", Slot = "13")]
	public bool Contains(To CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x271C6E0", Offset = "0x271BAE0", VA = "0x18271C6E0", Slot = "14")]
	public void CopyTo(To[] EACKPMFPNLH, int LKNMOMDDHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x271C7A0", Offset = "0x271BBA0", VA = "0x18271C7A0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x271C860", Offset = "0x271BC60", VA = "0x18271C860", Slot = "6")]
	public int IndexOf(To CFHFBNLLHPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x271C8D0", Offset = "0x271BCD0", VA = "0x18271C8D0", Slot = "7")]
	public void Insert(int BNOAGGNAMKG, To CFHFBNLLHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x271C950", Offset = "0x271BD50", VA = "0x18271C950", Slot = "15")]
	public bool Remove(To CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x271C910", Offset = "0x271BD10", VA = "0x18271C910", Slot = "8")]
	public void RemoveAt(int BNOAGGNAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1765D20", Offset = "0x1765120", VA = "0x181765D20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[FPEACHBODJG]
public class AIMCFNGPACI : ComponentSystem, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private IABLIMOJJBC DANEBHHOICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x8D0170", Offset = "0x8CF570", VA = "0x1808D0170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xB9A340", Offset = "0xB99740", VA = "0x180B9A340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x28FB030", Offset = "0x28FA430", VA = "0x1828FB030", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
	public AIMCFNGPACI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, KINEJENHFEI, GLHHELGFOCN
	{
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private static readonly EHKEPJIBENP IGCLICKKCHJ;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private const string PFPPNLAEALG = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private DBDEKGOAMDF HEAMCFPFNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private HEKFLAGDMLJ JBFCCDGDFOM;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public HEKFLAGDMLJ MIHFCEGNEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x295E9E0", Offset = "0x295DDE0", VA = "0x18295E9E0", Slot = "15")]
			get
			{
				return default(HEKFLAGDMLJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MDECDPGCMCD ICGJOIEICNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x295EA90", Offset = "0x295DE90", VA = "0x18295EA90", Slot = "6")]
			get
			{
				return default(MDECDPGCMCD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool HPOMJOMGINK
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x295E9D0", Offset = "0x295DDD0", VA = "0x18295E9D0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public DBDEKGOAMDF GAIBMIMMKDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xFA2B00", Offset = "0xFA1F00", VA = "0x180FA2B00", Slot = "7")]
			get
			{
				return default(DBDEKGOAMDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private FFCBJDNAPKG MBFMJLDEOAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x295DE20", Offset = "0x295D220", VA = "0x18295DE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool JPMGNMKAIOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x8C8440", Offset = "0x8C7840", VA = "0x1808C8440", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x8C84B0", Offset = "0x8C78B0", VA = "0x1808C84B0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<bool> HPLAJENKOCE
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x295E890", Offset = "0x295DC90", VA = "0x18295E890")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x295EAD0", Offset = "0x295DED0", VA = "0x18295EAD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<KINEJENHFEI> FCOPPBGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x295E930", Offset = "0x295DD30", VA = "0x18295E930", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x295EB70", Offset = "0x295DF70", VA = "0x18295EB70", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x295DD00", Offset = "0x295D100", VA = "0x18295DD00")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x295E5E0", Offset = "0x295D9E0", VA = "0x18295E5E0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x295E080", Offset = "0x295D480", VA = "0x18295E080", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x295E560", Offset = "0x295D960", VA = "0x18295E560", Slot = "10")]
		public void OnEmbody(ICCLAPFHPJL GLBDCLCAOJH, HEKFLAGDMLJ JBFCCDGDFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x295E5D0", Offset = "0x295D9D0", VA = "0x18295E5D0", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x295E3B0", Offset = "0x295D7B0", VA = "0x18295E3B0", Slot = "12")]
		public void OnDisembody(bool MAALBIDADJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x295DEB0", Offset = "0x295D2B0", VA = "0x18295DEB0")]
		private void GDJFGIJDNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x295E020", Offset = "0x295D420", VA = "0x18295E020", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x9D4920", Offset = "0x9D3D20", VA = "0x1809D4920", Slot = "9")]
		private GameObject IJOOFDGKDFP()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public class FODDMFHDJFA<T> : LKPHPGGEFLH<T>, FIPEENHHKAO<HEKFLAGDMLJ, T>, IEPDOHHLJHK<HEKFLAGDMLJ>, LKKBEGLFKGM, IDisposable, FLJMOFPACJP where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly IEPDOHHLJHK<Entity> LEMJCNJPDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private Delegate PEBLALKDODH;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x3821F70", Offset = "0x3821370", VA = "0x183821F70", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Type OILIJCDIDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x381C440", Offset = "0x381B840", VA = "0x18381C440", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public LFHCENHMBCH GOPBFOMCJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x381ABA0", Offset = "0x3819FA0", VA = "0x18381ABA0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public int HCGDGPKMKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x381B2D0", Offset = "0x381A6D0", VA = "0x18381B2D0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public ENOELDAICIL LMBDELGFHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x381AD30", Offset = "0x381A130", VA = "0x18381AD30", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event IAFCDGIJOEA<HEKFLAGDMLJ> HLFBHENDGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x381FC00", Offset = "0x381F000", VA = "0x18381FC00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x38204F0", Offset = "0x381F8F0", VA = "0x1838204F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2073D80", Offset = "0x2073180", VA = "0x182073D80")]
	public FODDMFHDJFA(IEPDOHHLJHK<Entity> LEMJCNJPDLJ, IMBCAHJKJCI CNNBPGGDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x381BB40", Offset = "0x381AF40", VA = "0x18381BB40")]
	private Entity DJKLNEJICMK(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x381BAF0", Offset = "0x381AEF0", VA = "0x18381BAF0")]
	private HEKFLAGDMLJ DJKLNEJICMK(Entity GKMECPLEALF)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x3823A30", Offset = "0x3822E30", VA = "0x183823A30", Slot = "4")]
	public T PHGLOPEHIMO(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x3819490", Offset = "0x3818890", VA = "0x183819490")]
	public bool AFLFAPDAOKF(HEKFLAGDMLJ LEMCMBEMOCB, in T PINJDLEFOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x381CB20", Offset = "0x381BF20", VA = "0x18381CB20", Slot = "7")]
	public bool HFDNCCJGOAI(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x38240D0", Offset = "0x38234D0", VA = "0x1838240D0", Slot = "8")]
	public void PHGLOPEHIMO(HEKFLAGDMLJ LEMCMBEMOCB, KKEKCMELKKJ AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x3819380", Offset = "0x3818780", VA = "0x183819380", Slot = "9")]
	public bool AFLFAPDAOKF(HEKFLAGDMLJ LEMCMBEMOCB, CIMGDHMJEHM PINJDLEFOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2071A60", Offset = "0x2070E60", VA = "0x182071A60", Slot = "16")]
	public void OMAPCNDDLGL(EJLEFJCKIEJ ACLKHAFOJLC, [Optional] object AKPCLGIGABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x381BDC0", Offset = "0x381B1C0", VA = "0x18381BDC0", Slot = "10")]
	public bool EMCLIHJFPMF(HEKFLAGDMLJ NBCAFBHOFIE, HEKFLAGDMLJ CIDBOBPIINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x3822450", Offset = "0x3821850", VA = "0x183822450")]
	private void PCAAFIDODME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x3821690", Offset = "0x3820A90", VA = "0x183821690")]
	private void KJOIKOBGPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x381E820", Offset = "0x381DC20", VA = "0x18381E820")]
	private void HFIELIGKBMK(Entity GKMECPLEALF, in CIMGDHMJEHM FNIKJMODJCE, in CIMGDHMJEHM PINJDLEFOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x381B670", Offset = "0x381AA70", VA = "0x18381B670")]
	private void CEIMEADLILL(Entity GKMECPLEALF, in CIMGDHMJEHM FNIKJMODJCE, in CIMGDHMJEHM PINJDLEFOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x3136FD0", Offset = "0x31363D0", VA = "0x183136FD0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x38257B0", Offset = "0x3824BB0", VA = "0x1838257B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[EPJIKDLNGEH(typeof(BMHCJDBMOMA), new string[] { })]
public class EPJBIDONNKE : BMHCJDBMOMA, NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private class AMLOOFCKMHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public List<CapsuleCollider> KHPJKGKBHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public List<SphereCollider> PELKDJKBDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public GameObject PBLCLLGCBLA;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x27AEC00", Offset = "0x27AE000", VA = "0x1827AEC00")]
		public AMLOOFCKMHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	[BOJGNOMIPCG]
	private IMBCAHJKJCI MGODNOADCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	[BOJGNOMIPCG]
	private ONIGLBMFNHJ GDALCAJJKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Dictionary<Entity, AMLOOFCKMHH> MJKDAKPHKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private GameObject ICFLOEJAAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private GameObject LIIJCBEHDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private GameObject PHAFEIJKKJL;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private GameObject GIMDEBCJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x295D6E0", Offset = "0x295CAE0", VA = "0x18295D6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x295C960", Offset = "0x295BD60", VA = "0x18295C960", Slot = "6")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x295C570", Offset = "0x295B970", VA = "0x18295C570", Slot = "4")]
	public void HLOAHCBDBCB(Entity NPLCKCLGNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x295BA70", Offset = "0x295AE70", VA = "0x18295BA70", Slot = "5")]
	public void CKBOEGKFNCF(Entity NPLCKCLGNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x295C200", Offset = "0x295B600", VA = "0x18295C200", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x295D570", Offset = "0x295C970", VA = "0x18295D570")]
	private AMLOOFCKMHH MBCOKGLJKKO(Entity NPLCKCLGNFA, MKIIJMKIKEO EFDPMAIOLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x295C9D0", Offset = "0x295BDD0", VA = "0x18295C9D0")]
	private void KMKFMGEGBBF(MKIIJMKIKEO EFDPMAIOLJO, AMLOOFCKMHH JGIHCHJIGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x295C360", Offset = "0x295B760", VA = "0x18295C360")]
	private void GKLBFKKBNDI(MKIIJMKIKEO EFDPMAIOLJO, AMLOOFCKMHH JGIHCHJIGIG, int NMNIAMKGEKD, Vector3 FGLOAKJBDBO, Quaternion OCEJJKMFIJB, float BJDNODMMNIO, float DPJCAKENMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x295C040", Offset = "0x295B440", VA = "0x18295C040")]
	private void CNALODGJCHF(AMLOOFCKMHH JGIHCHJIGIG, int MELAAEPEFJA, Vector3 FGLOAKJBDBO, float BJDNODMMNIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x295B770", Offset = "0x295AB70", VA = "0x18295B770")]
	private void ANOILGDPDKJ(MKIIJMKIKEO EFDPMAIOLJO, AMLOOFCKMHH JGIHCHJIGIG, int HIIGEJLMAGL, int CNNGPBNCIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x224D990", Offset = "0x224CD90", VA = "0x18224D990")]
	private T ILONBJLAOKB<T>(MKIIJMKIKEO EFDPMAIOLJO, ref GameObject OGOBDKNMJKA, Vector3 IEGBDEAOAGE, Quaternion IKMDCPAAKBK) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x295D830", Offset = "0x295CC30", VA = "0x18295D830")]
	public EPJBIDONNKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DefaultMember("Item")]
public class FLCDDKOJLLJ<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[EPJIKDLNGEH(typeof(DLIMMLKNEFD), new string[] { })]
[ODFCLLMCKOH(typeof(CBPMCDKGJGE))]
public class JGIONPHOOBA : DLIMMLKNEFD, GMHONDBOJEM, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly Dictionary<int, ICBIKEFGDEP> OBFDKGNPPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private readonly Dictionary<ICBIKEFGDEP, int> KOKHMHNMOPJ;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x28F5CE0", Offset = "0x28F50E0", VA = "0x1828F5CE0", Slot = "6")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x28F5F00", Offset = "0x28F5300", VA = "0x1828F5F00", Slot = "7")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x28F5FF0", Offset = "0x28F53F0", VA = "0x1828F5FF0")]
	private void JECKJIINFMN(List<(ICBIKEFGDEP nameHash, MAFKLBIHIJI stableTypeHash, Type type)> FIONHDMDJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x28F5DB0", Offset = "0x28F51B0", VA = "0x1828F5DB0", Slot = "4")]
	public ICBIKEFGDEP ICBJJDAHMJA(int DCJNJIADGPK)
	{
		return default(ICBIKEFGDEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x28F6200", Offset = "0x28F5600", VA = "0x1828F6200", Slot = "5")]
	public int MALFOLDDHMP(ICBIKEFGDEP GBANGIMAALB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x28F6270", Offset = "0x28F5670", VA = "0x1828F6270")]
	public JGIONPHOOBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class CCNJLFPKLJF
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class DONAMEMPIBE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class KCOMCBDAEMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class EDAMOJKNBCI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2903AA0", Offset = "0x2902EA0", VA = "0x182903AA0")]
	public static Entity GOIFFCINFLG(this EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2903B10", Offset = "0x2902F10", VA = "0x182903B10")]
	public static DynamicBuffer<NCPPJPJLJPP> HMDBADKJNGN(this EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(DynamicBuffer<NCPPJPJLJPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2903DC0", Offset = "0x29031C0", VA = "0x182903DC0")]
	public static bool LOGCJHGFPIM(this EntityManager BEBIJONEMLA, Entity GKMECPLEALF, Allocator DGGNDNPDKKD, out NativeArray<Entity> GFCJEFAFKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2904280", Offset = "0x2903680", VA = "0x182904280")]
	public static NativeArray<Entity> NHNPNGNEFDO(this EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x29043F0", Offset = "0x29037F0", VA = "0x1829043F0")]
	public static int ONPGMOCNIHI(this EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2903390", Offset = "0x2902790", VA = "0x182903390")]
	public static void BNCICJCBLNH(NativeArray<Entity> GBFJPPHEION, NativeArray<Entity> LEGMMMPKLOM, EntityManager BEBIJONEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2903EC0", Offset = "0x29032C0", VA = "0x182903EC0")]
	public static bool LOJMEIIDDGG(this EntityManager BEBIJONEMLA, Entity GKMECPLEALF, Entity BGACBDKLDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2903900", Offset = "0x2902D00", VA = "0x182903900")]
	public static bool GNBOGMACBNL(this EntityManager BEBIJONEMLA, Entity GKMECPLEALF, Entity BPLKOFNPIGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x29036E0", Offset = "0x2902AE0", VA = "0x1829036E0")]
	public static NativeList<Entity> GMDDCNFABJA(this EntityManager BEBIJONEMLA, Entity GKMECPLEALF, bool PBDNMAHJCFC = false, Allocator DGGNDNPDKKD = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2903BA0", Offset = "0x2902FA0", VA = "0x182903BA0")]
	public static Entity LAAKJDOAPFC(this EntityManager BEBIJONEMLA, Entity GKMECPLEALF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2904030", Offset = "0x2903430", VA = "0x182904030")]
	public static bool MPHFLBOJAHA(this EntityManager BEBIJONEMLA, Entity JNHEGOFDJBP, Entity JBNLIGHJDME, out Entity BOLOBEEEGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2903CA0", Offset = "0x29030A0", VA = "0x182903CA0")]
	internal static void LIKHGMCBAIO(EntityManager BEBIJONEMLA, Entity OJBGDMNECON, Entity KEGFIDMGBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x29035F0", Offset = "0x29029F0", VA = "0x1829035F0")]
	private static bool EKLPCNCAGLP(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, Entity BGACBDKLDPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[GMDDLKFJECG]
internal struct MCCEOPILOBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public IJEMHFEELIK LALJEPDPLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public JPBAIPNMNMH LFJAMNBIHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public HKLFADGAAOL.FLIDIKJCJLC.MHKNGGLDEBB LJJHJABONIO;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static readonly LMDMHELMEME<MCCEOPILOBA> KCIIGNIKLNC;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2A70170", Offset = "0x2A6F570", VA = "0x182A70170")]
	public static MCCEOPILOBA HLIOCABPHCE(in IJEMHFEELIK LALJEPDPLMD)
	{
		return default(MCCEOPILOBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface MIAFHNOGEFO
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	HKLFADGAAOL.FLIDIKJCJLC.MHKNGGLDEBB FGELOCJLGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public static class FHOGFFKCGKI
{
	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2962F30", Offset = "0x2962330", VA = "0x182962F30")]
	public static IJEMHFEELIK NOJAKOGCFIP(MDECDPGCMCD OJBGDMNECON)
	{
		return default(IJEMHFEELIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class OJGGICJIDMN : CEGKNKGECDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public JGECFECPNBB OGCDKDFJJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2480000", Offset = "0x247F400", VA = "0x182480000", Slot = "5")]
	public ByteString CIBKNCFFHFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public OJGGICJIDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class CONHHDONOCJ
{
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly EHKEPJIBENP LDKHEMMIGPF;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static readonly EHKEPJIBENP EHKPBHOOFBL;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly ProfilerMarker ODEJPOALGAL;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly ProfilerMarker AIGAGFDCGDP;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly ProfilerMarker KAFJBOEOOGB;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly ProfilerMarker MGHOAFGOJOE;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly ProfilerMarker IIFBKKDCJAG;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly ProfilerMarker PACONNGLLJO;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly ProfilerMarker EINCFIPKBCJ;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly ProfilerMarker JNGEFFACENB;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly ProfilerMarker NMCGCONOGLJ;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly ProfilerMarker ECDMMINLPKH;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly ProfilerMarker FEDJJKGPFBO;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly ProfilerMarker LLNPLCANNPD;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly ProfilerMarker MCPNNFNHHMK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly ProfilerMarker ICLFCBCIDAK;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly ProfilerMarker KIPJLFABDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly NGGMHODKILL HPIHOOLAHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly ByteString DCBJJADOEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly DOFBPGFFJDE CEMAJLICLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly LBENECEAHJK DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private readonly GNNOHHPIEOC FPGMLACCJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private readonly ENLINJHCCDI PBBOHGPNEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private readonly FEKJMMMBFDP IEPMBAPAGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private readonly TaskCompletionSource<bool> ECBAFHPLLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private readonly AGLDNCEFJKF NPOLKGPPPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private readonly FFBCEEGACPH.IPJNMDDDIMC DBPNCCFNAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private NNFPBHEJLKI FKINDIOPEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private EHLKKIDPCHN LDCEPPBCHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private HKLFADGAAOL EFIFDDMLKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private JGECFECPNBB OEKGCGIOGPN;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Action LNDBOOHJCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x973B50", Offset = "0x972F50", VA = "0x180973B50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xB61820", Offset = "0xB60C20", VA = "0x180B61820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Action NFMAKAHBPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x997310", Offset = "0x996710", VA = "0x180997310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x997010", Offset = "0x996410", VA = "0x180997010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Action MHACLNAOCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x9972F0", Offset = "0x9966F0", VA = "0x1809972F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x996B50", Offset = "0x995F50", VA = "0x180996B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public IEnumerable<GGLLEGPCFPG> OOJFKOEJFPA
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x9870C0", Offset = "0x9864C0", VA = "0x1809870C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xC5AD70", Offset = "0xC5A170", VA = "0x180C5AD70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public ALNGHMJNFBH KFJOBECICAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2912080", Offset = "0x2911480", VA = "0x182912080")]
		[CompilerGenerated]
		get
		{
			return default(ALNGHMJNFBH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x29102B0", Offset = "0x290F6B0", VA = "0x1829102B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public JGECFECPNBB OGCDKDFJJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x9E36F0", Offset = "0x9E2AF0", VA = "0x1809E36F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public BDDDPJDFJGN GNNEKHDLANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xE088B0", Offset = "0xE07CB0", VA = "0x180E088B0")]
		get
		{
			return default(BDDDPJDFJGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public LocalId BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2910440", Offset = "0x290F840", VA = "0x182910440")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Task GJOOGKJBEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x29113A0", Offset = "0x29107A0", VA = "0x1829113A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x29129C0", Offset = "0x2911DC0", VA = "0x1829129C0")]
	public CONHHDONOCJ(ByteString DCBJJADOEJL, BDDDPJDFJGN OPPMMFGGHMP, in AGLDNCEFJKF NPOLKGPPPJC, DOFBPGFFJDE CEMAJLICLCP, MPCJLDHBHBF NEMNGPCIMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2911490", Offset = "0x2910890", VA = "0x182911490")]
	public void KAEENGGDABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2911C00", Offset = "0x2911000", VA = "0x182911C00")]
	public bool NBOCHEIPFNJ(BDDDPJDFJGN JNHEGOFDJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2910D00", Offset = "0x2910100", VA = "0x182910D00")]
	private bool IIHAALBNIIH(BDDDPJDFJGN GMAFCCAHJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2910450", Offset = "0x290F850", VA = "0x182910450")]
	private void FBJLDBGAIOI(BDDDPJDFJGN FINNOCNBIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x29100F0", Offset = "0x290F4F0", VA = "0x1829100F0")]
	private bool AJMOJMPFGIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x29123F0", Offset = "0x29117F0", VA = "0x1829123F0")]
	public bool OPPMHEJDBHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x29120B0", Offset = "0x29114B0", VA = "0x1829120B0")]
	private bool ONKPBGBNKJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2911850", Offset = "0x2910C50", VA = "0x182911850")]
	private bool MBKMFKNFFAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2910C30", Offset = "0x2910030", VA = "0x182910C30")]
	private bool IHLDHEAHGJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2911C20", Offset = "0x2911020", VA = "0x182911C20")]
	private bool NDPCKCHHLOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x29112A0", Offset = "0x29106A0", VA = "0x1829112A0")]
	private bool JENODLNBJAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2910570", Offset = "0x290F970", VA = "0x182910570")]
	public void GDPMMJCECMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x29113E0", Offset = "0x29107E0", VA = "0x1829113E0")]
	[CompilerGenerated]
	private void JPCOGIBPJCH(BDDDPJDFJGN GMAFCCAHJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x290FF70", Offset = "0x290F370", VA = "0x18290FF70")]
	[CompilerGenerated]
	private bool ACPEICGAGOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2911C40", Offset = "0x2911040", VA = "0x182911C40")]
	[CompilerGenerated]
	private void NJNNAMPHIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x2911B10", Offset = "0x2910F10", VA = "0x182911B10")]
	[CompilerGenerated]
	private World MKOLKIIGJIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2911760", Offset = "0x2910B60", VA = "0x182911760")]
	[CompilerGenerated]
	private void LKKHIKKFGPP(World PBGBLNAIFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2910B20", Offset = "0x290FF20", VA = "0x182910B20")]
	[CompilerGenerated]
	private int IFOPMEJLOOA(World PBGBLNAIFDC, ByteString DCBJJADOEJL, HKLFADGAAOL.FLIDIKJCJLC.MHKNGGLDEBB LJJHJABONIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2911580", Offset = "0x2910980", VA = "0x182911580")]
	[CompilerGenerated]
	private void KHCEKEGLONN(World GLBDCLCAOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x29109E0", Offset = "0x290FDE0", VA = "0x1829109E0")]
	[CompilerGenerated]
	internal static HGJEOGGNKED GEMKJOFCHOD(EntityManager IKJGCBKMPGO, EntityManager JMHJBBKIMAB, int GJCEJHBAGBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x29111D0", Offset = "0x29105D0", VA = "0x1829111D0")]
	[CompilerGenerated]
	private void JBHKAAKMEND(JGECFECPNBB OEKGCGIOGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2911000", Offset = "0x2910400", VA = "0x182911000")]
	[CompilerGenerated]
	private void JAFMNCOCPIG(EntityManager BEBIJONEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2910380", Offset = "0x290F780", VA = "0x182910380")]
	[CompilerGenerated]
	private void CALCNEAPDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x29102E0", Offset = "0x290F6E0", VA = "0x1829102E0")]
	[CompilerGenerated]
	private void BPBFAGIJKFM(string GDKOBCHHFLB, EntityManager BEBIJONEMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2910300", Offset = "0x290F700", VA = "0x182910300")]
	[CompilerGenerated]
	private MKDAMMLEKFE<AGLDNCEFJKF> CAGPONJNNNJ(EntityManager BEBIJONEMLA)
	{
		return default(MKDAMMLEKFE<AGLDNCEFJKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class GGBCGCEGGMB : HFMGHJGABMC
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly EHKEPJIBENP EHKPBHOOFBL;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x28DCBE0", Offset = "0x28DBFE0", VA = "0x1828DCBE0")]
	public GGBCGCEGGMB(DOFBPGFFJDE CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x28DCA80", Offset = "0x28DBE80", VA = "0x1828DCA80", Slot = "10")]
	protected override void BCACIOLOALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x28DCB00", Offset = "0x28DBF00", VA = "0x1828DCB00", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> GHNGCACELDN(NativeArray<EntityRemapUtility.EntityRemapInfo> FJNDBDPOJOI)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal struct AGLDNCEFJKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public IJEMHFEELIK CEBAGGBJPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public Entity OJBGDMNECON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public ALGIECDKBAP LFJAMNBIHGB;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public static readonly LMDMHELMEME<AGLDNCEFJKF> KCIIGNIKLNC;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal class NGGMHODKILL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private enum CAIGABFFELK
	{
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		Running,
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		Disposed
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class ICOCGBEPHDI : IEnumerable<BDDDPJDFJGN>, IEnumerable, IEnumerator<BDDDPJDFJGN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private BDDDPJDFJGN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private BDDDPJDFJGN target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public BDDDPJDFJGN <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public NGGMHODKILL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private int <allowedTarget>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private int <nextCompletedPhases>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private BDDDPJDFJGN <phase>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private BDDDPJDFJGN System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x985830", Offset = "0x984C30", VA = "0x180985830", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(BDDDPJDFJGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x27B6920", Offset = "0x27B5D20", VA = "0x1827B6920", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xE72620", Offset = "0xE71A20", VA = "0x180E72620")]
		[DebuggerHidden]
		public ICOCGBEPHDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x27B67A0", Offset = "0x27B5BA0", VA = "0x1827B67A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x27B68E0", Offset = "0x27B5CE0", VA = "0x1827B68E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x27B6830", Offset = "0x27B5C30", VA = "0x1827B6830", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BDDDPJDFJGN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x27B6830", Offset = "0x27B5C30", VA = "0x1827B6830", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class LEKOBOAPKKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public BDDDPJDFJGN phase;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LEKOBOAPKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x27B8A90", Offset = "0x27B7E90", VA = "0x1827B8A90")]
		internal object HDKENADHJPM(BDDDPJDFJGN a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly EHKEPJIBENP EHKPBHOOFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly BDDDPJDFJGN OPPMMFGGHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<BDDDPJDFJGN, bool> MDJFFAEGKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Action<BDDDPJDFJGN> EHJLHFOAMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private int ICAKIKCJHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private CAIGABFFELK HEAMCFPFNOL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public BDDDPJDFJGN GNNEKHDLANG
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x81F160", Offset = "0x81E560", VA = "0x18081F160")]
		get
		{
			return default(BDDDPJDFJGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2A79F30", Offset = "0x2A79330", VA = "0x182A79F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A490", Offset = "0x2A79890", VA = "0x182A7A490")]
	public NGGMHODKILL(BDDDPJDFJGN OPPMMFGGHMP, Func<BDDDPJDFJGN, bool> MDJFFAEGKGI, Action<BDDDPJDFJGN> EHJLHFOAMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x2A79F40", Offset = "0x2A79340", VA = "0x182A79F40")]
	[IteratorStateMachine(typeof(ICOCGBEPHDI))]
	private IEnumerable<BDDDPJDFJGN> DBOKCKALCEH(BDDDPJDFJGN JNHEGOFDJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A020", Offset = "0x2A79420", VA = "0x182A7A020")]
	public bool NBOCHEIPFNJ(BDDDPJDFJGN JNHEGOFDJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2A79FC0", Offset = "0x2A793C0", VA = "0x182A79FC0")]
	private void EIFJDOAKCLM(BDDDPJDFJGN GMAFCCAHJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x295E5D0", Offset = "0x295D9D0", VA = "0x18295E5D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct MKDAMMLEKFE<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly Entity HMIHELIIOGG;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C09B50", Offset = "0x2C08F50", VA = "0x182C09B50")]
	public MKDAMMLEKFE(EntityManager BEBIJONEMLA, in T NPOLKGPPPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C09B40", Offset = "0x2C08F40", VA = "0x182C09B40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal class HOINBLHCGDC : HFMGHJGABMC
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private static readonly EHKEPJIBENP EHKPBHOOFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly MCCEOPILOBA NPOLKGPPPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private NativeList<Entity> NGFMCPICGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private NativeArray<Entity> GNCAGDNCOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> APEBCNILBCB;

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x28E9F30", Offset = "0x28E9330", VA = "0x1828E9F30")]
	public HOINBLHCGDC(IEnumerable<HEKFLAGDMLJ> GAOJFDPACED, in MCCEOPILOBA NPOLKGPPPJC, DOFBPGFFJDE CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x28E9E30", Offset = "0x28E9230", VA = "0x1828E9E30", Slot = "9")]
	protected override MCCEOPILOBA PPDECOCGBPD()
	{
		return default(MCCEOPILOBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x28E9B50", Offset = "0x28E8F50", VA = "0x1828E9B50", Slot = "10")]
	protected override void BCACIOLOALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x28E9D70", Offset = "0x28E9170", VA = "0x1828E9D70", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> GHNGCACELDN(NativeArray<EntityRemapUtility.EntityRemapInfo> FJNDBDPOJOI)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x28E9CC0", Offset = "0x28E90C0", VA = "0x1828E9CC0", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal abstract class HFMGHJGABMC : CEGKNKGECDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private static readonly ProfilerMarker KAFJBOEOOGB;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static readonly ProfilerMarker DFKNMLOAAAM;

	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private static readonly ProfilerMarker MGHOAFGOJOE;

	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private static readonly ProfilerMarker GBDFLLIGJLB;

	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private static readonly ProfilerMarker PACONNGLLJO;

	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private static readonly ProfilerMarker LHJPCKAMFNI;

	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private static readonly ProfilerMarker POBANAKCEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private readonly DOFBPGFFJDE CEMAJLICLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private readonly ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private readonly NNFPBHEJLKI FKINDIOPEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private readonly FEKJMMMBFDP IEPMBAPAGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly ENLINJHCCDI PBBOHGPNEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly EHKEPJIBENP EHKPBHOOFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private readonly FFBCEEGACPH.IPJNMDDDIMC DBPNCCFNAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private World EDDMJGOKIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private JGECFECPNBB OEKGCGIOGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private IDisposable LFLLGKKGGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private ByteString NJAGDDFICFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private HKLFADGAAOL.FLIDIKJCJLC.MHKNGGLDEBB NNIAIGNNOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private bool IHAJLHKGLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private OCCDPACEAEH FEJNNANFOFM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	protected World MBIBMKKILNI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	protected World HBDGJGALOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x28E69A0", Offset = "0x28E5DA0", VA = "0x1828E69A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public JGECFECPNBB OGCDKDFJJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x28E6C80", Offset = "0x28E6080", VA = "0x1828E6C80")]
	public HFMGHJGABMC(DOFBPGFFJDE CEMAJLICLCP, EHKEPJIBENP IGCLICKKCHJ, EHKEPJIBENP EHKPBHOOFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x28E5F40", Offset = "0x28E5340", VA = "0x1828E5F40", Slot = "5")]
	public ByteString CIBKNCFFHFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x28E6030", Offset = "0x28E5430", VA = "0x1828E6030", Slot = "7")]
	public void FOLFCGOHDPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x28E5FD0", Offset = "0x28E53D0", VA = "0x1828E5FD0", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x28E69F0", Offset = "0x28E5DF0", VA = "0x1828E69F0", Slot = "9")]
	protected virtual MCCEOPILOBA PPDECOCGBPD()
	{
		return default(MCCEOPILOBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void BCACIOLOALA();

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> GHNGCACELDN(NativeArray<EntityRemapUtility.EntityRemapInfo> FJNDBDPOJOI);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[EPJIKDLNGEH(typeof(MIAFHNOGEFO), new string[] { })]
internal sealed class CGJAGEKDOJC : MIAFHNOGEFO, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	[BOJGNOMIPCG]
	private MAFOFLPIDLK GFBPAALFLEL;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public HKLFADGAAOL.FLIDIKJCJLC.MHKNGGLDEBB FGELOCJLGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x2905E20", Offset = "0x2905220", VA = "0x182905E20", Slot = "4")]
		get
		{
			return default(HKLFADGAAOL.FLIDIKJCJLC.MHKNGGLDEBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x2905DD0", Offset = "0x29051D0", VA = "0x182905DD0", Slot = "5")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public CGJAGEKDOJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class EPIPGJIKNFH : MHBNDALDLMC, MPCJLDHBHBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly CONHHDONOCJ CMBFEPDDNLN;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LocalId ELGHMFCLLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x295B5B0", Offset = "0x295A9B0", VA = "0x18295B5B0", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public IEnumerable<GGLLEGPCFPG> OOJFKOEJFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x28DA700", Offset = "0x28D9B00", VA = "0x1828DA700", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ALNGHMJNFBH KFJOBECICAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x28DA790", Offset = "0x28D9B90", VA = "0x1828DA790", Slot = "5")]
		get
		{
			return default(ALNGHMJNFBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Task GJOOGKJBEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x28DA730", Offset = "0x28D9B30", VA = "0x1828DA730", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public JGECFECPNBB APOELKPGKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x28DA770", Offset = "0x28D9B70", VA = "0x1828DA770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x295B5C0", Offset = "0x295A9C0", VA = "0x18295B5C0")]
	public EPIPGJIKNFH(ByteString DCBJJADOEJL, DOFBPGFFJDE CEMAJLICLCP, Action HPKEDCEKPAH, Action ADAPDEKHJAJ, Action IAEKIDJDAJF, bool KFGFKALJPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x28DA750", Offset = "0x28D9B50", VA = "0x1828DA750", Slot = "9")]
	public bool NBOCHEIPFNJ(BDDDPJDFJGN GMAFCCAHJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x28DA660", Offset = "0x28D9A60", VA = "0x1828DA660", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class NGBNCMENNHB
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A79E50", Offset = "0x2A79250", VA = "0x182A79E50")]
	public static FFBCEEGACPH.IPJNMDDDIMC MNIPDFAOMLK(DOFBPGFFJDE CEMAJLICLCP)
	{
		return default(FFBCEEGACPH.IPJNMDDDIMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2A79AE0", Offset = "0x2A78EE0", VA = "0x182A79AE0")]
	public static NativeList<Entity> KGLGBOAGFCB(EntityManager BEBIJONEMLA, IEnumerable<HEKFLAGDMLJ> GAOJFDPACED)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A79A30", Offset = "0x2A78E30", VA = "0x182A79A30")]
	public static void GHNGCACELDN(NativeArray<Entity> GNCAGDNCOKE, NativeList<Entity> NGFMCPICGAD, NativeArray<EntityRemapUtility.EntityRemapInfo> FJNDBDPOJOI, NativeArray<EntityRemapUtility.EntityRemapInfo> APEBCNILBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x24030D0", Offset = "0x24024D0", VA = "0x1824030D0")]
	public static Entity KLAOKHGKFGO<T>(EntityManager BEBIJONEMLA, in T AGLCIEKHLEE) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class FKGLFCBCIGL : NDHMEAKEDNA, MPCJLDHBHBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly CONHHDONOCJ CMBFEPDDNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly KPNAFCNKGOC GOLCMKBOFGH;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public MFMOHGACDCK JIGOFCBPEGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public LocalId ELGHMFCLLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x28DA680", Offset = "0x28D9A80", VA = "0x1828DA680", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task GJOOGKJBEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x28DA730", Offset = "0x28D9B30", VA = "0x1828DA730", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IEnumerable<GGLLEGPCFPG> OOJFKOEJFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x28DA700", Offset = "0x28D9B00", VA = "0x1828DA700", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ALNGHMJNFBH KFJOBECICAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x28DA790", Offset = "0x28D9B90", VA = "0x1828DA790", Slot = "8")]
		get
		{
			return default(ALNGHMJNFBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public JGECFECPNBB APOELKPGKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x28DA770", Offset = "0x28D9B70", VA = "0x1828DA770", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x28DA7D0", Offset = "0x28D9BD0", VA = "0x1828DA7D0")]
	public FKGLFCBCIGL(ByteString DCBJJADOEJL, MFMOHGACDCK JEFJMLOCMJL, in AGLDNCEFJKF NPOLKGPPPJC, DOFBPGFFJDE CEMAJLICLCP, Action IAEKIDJDAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x28DA6A0", Offset = "0x28D9AA0", VA = "0x1828DA6A0", Slot = "5")]
	public void FOLFCGOHDPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x28DA750", Offset = "0x28D9B50", VA = "0x1828DA750", Slot = "12")]
	public bool NBOCHEIPFNJ(BDDDPJDFJGN GMAFCCAHJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x28DA6E0", Offset = "0x28D9AE0", VA = "0x1828DA6E0", Slot = "6")]
	public void GDPMMJCECMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x28DA660", Offset = "0x28D9A60", VA = "0x1828DA660", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[EPJIKDLNGEH(typeof(FFCBJDNAPKG), new string[] { })]
public class NGHLIIDIDDN : FFCBJDNAPKG, FFLHMNCCPBG, APKELBFAHNG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private IABLIMOJJBC CEMAJLICLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private EEKNAEJEFGF DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private EHLKKIDPCHN LDCEPPBCHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private FEGFINCBOCB PKDKKELFBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private OHAMPNBKDLP LJNICDIKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private GGNFHIGGHPN IIGHBGGPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private HMHHFNDBEKM OCKKDLPLKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private OENENEPEABD OEGNIABGFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private HPKBHAJJNGO BBLELAOFBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private EPICOOKCMFM OGLMDJKECED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private EKDKPLKGAMN GGANGKPIJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private FEEKAOBEJNL FLFEOLIKEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private ONIGLBMFNHJ NKJGHMLOANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private EMGCNKHPFCN FNJHGBOKJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private EHDBBIHDADI NKKJPODIBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private LJNPGILBMKJ FJEEMPDKANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private HKJFJAJNFAP FHLNOIFJIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private FIOENEMHNNB LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private MAFOFLPIDLK AKOBMCIAGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private DOKFAOCNIFN ILDIIFMLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IABLIMOJJBC DANEBHHOICE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public EEKNAEJEFGF GHGAMEAKNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public ICCLAPFHPJL GMBOJNPAEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public OHAMPNBKDLP LJHMBDPCDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C3A00", Offset = "0x8C2E00", VA = "0x1808C3A00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public GGNFHIGGHPN PLNCJGGLGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public HMHHFNDBEKM HNPEOGNDDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public HPKBHAJJNGO NKFNOHKFIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public EPICOOKCMFM CNENFCIOLAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public EKDKPLKGAMN GCNBKHCAMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public FEEKAOBEJNL JIOBCDMNGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x8F8D80", Offset = "0x8F8180", VA = "0x1808F8D80", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public ONIGLBMFNHJ IKOFANNLAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x8F8470", Offset = "0x8F7870", VA = "0x1808F8470", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public EMGCNKHPFCN HDMPHJDALFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B8210", Offset = "0x9B7610", VA = "0x1809B8210", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public EHDBBIHDADI KNGCKNHANNE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x8CA060", Offset = "0x8C9460", VA = "0x1808CA060", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public LJNPGILBMKJ AOJKPFHOGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5D0", Offset = "0x8BD9D0", VA = "0x1808BE5D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public HKJFJAJNFAP IHIAGHCJPDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xAFBF00", Offset = "0xAFB300", VA = "0x180AFBF00", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public FIOENEMHNNB MEJOIGEJGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xA66160", Offset = "0xA65560", VA = "0x180A66160", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public MAFOFLPIDLK OLAINEOHBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xA36AC0", Offset = "0xA35EC0", VA = "0x180A36AC0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public DOKFAOCNIFN OJLAHIBKJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xA31EB0", Offset = "0xA312B0", VA = "0x180A31EB0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public GPJLAPAOJAB FJOGDMJJGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x822D80", Offset = "0x822180", VA = "0x180822D80", Slot = "23")]
		get
		{
			return default(GPJLAPAOJAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A530", Offset = "0x2A79930", VA = "0x182A7A530", Slot = "24")]
	public void HKHFIGFLBOE(IABLIMOJJBC LLDNLOJJLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A500", Offset = "0x2A79900", VA = "0x182A7A500", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A510", Offset = "0x2A79910", VA = "0x182A7A510", Slot = "25")]
	public void FBBGMFMCEJA(IABLIMOJJBC LLDNLOJJLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public NGHLIIDIDDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[EPJIKDLNGEH(typeof(EEKNAEJEFGF), new string[] { })]
public class DJAPFBCLLIL : EEKNAEJEFGF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public GOACFOHKEAA HBHMJOBMNKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private HKKLACDDFPJ CIDKPBMAFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private ODHMMPJEMFO DGPBPONKEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private DCIHBGMKNDA LEIEJIMPNID
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD30", Offset = "0x8BB130", VA = "0x1808BBD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public KFDENICELLH OFHGLFHAELL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4C0", Offset = "0x8B98C0", VA = "0x1808BA4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public FHJJAMLGNLD HKNCEJNPJII
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x8D0170", Offset = "0x8CF570", VA = "0x1808D0170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IFPFMOBMMJJ JGFNMBKDLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C3A00", Offset = "0x8C2E00", VA = "0x1808C3A00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xB9A340", Offset = "0xB99740", VA = "0x180B9A340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IPHFEDLNEOL FLKENKPMODI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x9E3C00", Offset = "0x9E3000", VA = "0x1809E3C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private LBENECEAHJK MIFJCGCBHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA490F0", Offset = "0xA484F0", VA = "0x180A490F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public LEHIKHOEAMN PFLFOFIHPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x997FD0", Offset = "0x9973D0", VA = "0x180997FD0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xABA5D0", Offset = "0xAB99D0", VA = "0x180ABA5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public HEGBKEOPNPO AEHHKDKCOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFF0", Offset = "0x8CB3F0", VA = "0x1808CBFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private PNJMMCGHBPJ BKKPGKPGAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x999290", Offset = "0x998690", VA = "0x180999290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public FKKAJAEPALJ GNDJHGHKFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA48FA0", Offset = "0xA483A0", VA = "0x180A48FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private GBFIINBNALL JIOBCDMNGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x8F8760", Offset = "0x8F7B60", VA = "0x1808F8760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private PINCEFFEDIB JLIBFMIABPD
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8CB0F0", Offset = "0x8CA4F0", VA = "0x1808CB0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x29476B0", Offset = "0x2946AB0", VA = "0x1829476B0", Slot = "12")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public DJAPFBCLLIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[DefaultMember("Item")]
public class EHJCOKOIGFD : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class OJJPBMGFPKL : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public EHJCOKOIGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private int <indexOffset>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private int <intCount>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private ulong <value>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private int <index>5__5;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x985830", Offset = "0x984C30", VA = "0x180985830", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x27BB300", Offset = "0x27BA700", VA = "0x1827BB300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public OJJPBMGFPKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x27BB140", Offset = "0x27BA540", VA = "0x1827BB140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x27BB2C0", Offset = "0x27BA6C0", VA = "0x1827BB2C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private readonly List<ulong> EMIMOFFOLBA;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x978170", Offset = "0x977570", VA = "0x180978170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2951140", Offset = "0x2950540", VA = "0x182951140")]
	public EHJCOKOIGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x29510D0", Offset = "0x29504D0", VA = "0x1829510D0", Slot = "4")]
	[IteratorStateMachine(typeof(OJJPBMGFPKL))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x29510D0", Offset = "0x29504D0", VA = "0x1829510D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class PJHJLMFMCII
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly ComponentType[] CMLFABLEIMA;

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2485100", Offset = "0x2484500", VA = "0x182485100")]
	public static Entity AANLOCDIPBE(this EntityManager BEBIJONEMLA)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public sealed class PINOHFBDHIA<T> : NABLAJEBMMC<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AC90", Offset = "0x2C4A090", VA = "0x182C4AC90")]
	public PINOHFBDHIA(T BBMNFGPBPNE, T KBFJHJENIED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[EPJIKDLNGEH(typeof(DDCOJKKDDIF), new string[] { })]
public sealed class LCFPGHKLFFA : DDCOJKKDDIF, CBPAPHMCJAC<DDCOJKKDDIF>, GMHONDBOJEM, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly Dictionary<FDOJMOENJAL, DHFCPGFDHFO> FBACFIFAMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private FBDOLOIEMBJ MCPOEMPMKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private KCPMLDAAPLA OEGNIABGFIK;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool EGMCOFDHICC
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x8C8440", Offset = "0x8C7840", VA = "0x1808C8440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2A66830", Offset = "0x2A65C30", VA = "0x182A66830")]
	public LCFPGHKLFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2A66530", Offset = "0x2A65930", VA = "0x182A66530", Slot = "5")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2A66720", Offset = "0x2A65B20", VA = "0x182A66720", Slot = "6")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2A66590", Offset = "0x2A65990", VA = "0x182A66590", Slot = "4")]
	public bool HBBLEOHJDFE(FDOJMOENJAL JNHCLKAAKHA, out DHFCPGFDHFO BIMCFGLAOAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(FBDOLOIEMBJ), new string[] { })]
internal sealed class FBDOLOIEMBJ : GMHONDBOJEM
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private readonly Dictionary<Type, DHFCPGFDHFO> FBACFIFAMFB;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x295EC10", Offset = "0x295E010", VA = "0x18295EC10", Slot = "4")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x295EC60", Offset = "0x295E060", VA = "0x18295EC60")]
	public void EHBDNPLCIKI(Type GANFKPHKNKH, DHFCPGFDHFO BIMCFGLAOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x295ED70", Offset = "0x295E170", VA = "0x18295ED70")]
	public bool HBBLEOHJDFE(Type GANFKPHKNKH, out DHFCPGFDHFO BIMCFGLAOAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x295EEE0", Offset = "0x295E2E0", VA = "0x18295EEE0")]
	public FBDOLOIEMBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class NHPECALDIEE
{
	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A880", Offset = "0x2A79C80", VA = "0x182A7A880")]
	public static void EHBDNPLCIKI(this FBDOLOIEMBJ DEMMAINGNBB, DHFCPGFDHFO BIMCFGLAOAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class NABLAJEBMMC<T> : GPDKOOLHAGB<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	protected LHCEIALHAIF<T> HKMOIPMNIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	protected POOANCPOGBB<T> OLGOLCEJCCN;

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x1016C80", Offset = "0x1016080", VA = "0x181016C80")]
	public NABLAJEBMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x1D3B310", Offset = "0x1D3A710", VA = "0x181D3B310")]
	public NABLAJEBMMC(LHCEIALHAIF<T> HKMOIPMNIJF, POOANCPOGBB<T> OLGOLCEJCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x1D3B080", Offset = "0x1D3A480", VA = "0x181D3B080", Slot = "10")]
	protected override T EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x1D3AC20", Offset = "0x1D3A020", VA = "0x181D3AC20", Slot = "11")]
	protected override void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO, T AGLCIEKHLEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class NOIJPNCDPFD
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[EPJIKDLNGEH(typeof(DEPDBGLFLFP), new string[] { })]
internal sealed class GOMCCAEAMBJ : DEPDBGLFLFP, GMHONDBOJEM, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private readonly Dictionary<FDOJMOENJAL, GAIEDAHOCAL> CODOLPNDLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private KCPMLDAAPLA OEGNIABGFIK;

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x28E1E80", Offset = "0x28E1280", VA = "0x1828E1E80", Slot = "6")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x28E1FB0", Offset = "0x28E13B0", VA = "0x1828E1FB0", Slot = "7")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x28E1F40", Offset = "0x28E1340", VA = "0x1828E1F40", Slot = "4")]
	public void EHBDNPLCIKI(FDOJMOENJAL IOPMEPNDGKE, Type FELELGOJAHG, GAIEDAHOCAL PKJKDKKAEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x28E1ED0", Offset = "0x28E12D0", VA = "0x1828E1ED0", Slot = "5")]
	public bool EGAIBILKDBJ(FDOJMOENJAL IOPMEPNDGKE, out GAIEDAHOCAL PKJKDKKAEHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x28E2010", Offset = "0x28E1410", VA = "0x1828E2010")]
	public GOMCCAEAMBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[EPJIKDLNGEH(typeof(NDDKNGFIEKO), new string[] { })]
internal sealed class ALDAHNICMBM : NDDKNGFIEKO, NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	[BOJGNOMIPCG]
	private KCPMLDAAPLA OEGNIABGFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private NativeBitArray LJPEMGIEKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private NativeParallelHashMap<JDPNCHCMAIA, int> NFBADENCLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private NativeList<int> DMMAEEMJHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private int BCHPLAEJDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private int EMAGHODJPHI;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool GKODBKCLOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x28FBBC0", Offset = "0x28FAFC0", VA = "0x1828FBBC0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public KMAJJBPLHDC OEKFNEAMGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x28FBAE0", Offset = "0x28FAEE0", VA = "0x1828FBAE0", Slot = "7")]
		get
		{
			return default(KMAJJBPLHDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x28FBD40", Offset = "0x28FB140", VA = "0x1828FBD40", Slot = "4")]
	public bool LHHCCJOLOHI(JDPNCHCMAIA DDCHJBPICDC, FDOJMOENJAL LEMJCNJPDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x28FBBE0", Offset = "0x28FAFE0", VA = "0x1828FBBE0", Slot = "8")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x28FBDC0", Offset = "0x28FB1C0", VA = "0x1828FBDC0", Slot = "6")]
	public void OEDANOEGNMN(NativeArray<JDPNCHCMAIA> JJHDBMCJEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x28FB860", Offset = "0x28FAC60", VA = "0x1828FB860", Slot = "5")]
	public void BFBFKFPPNNC(JDPNCHCMAIA DDCHJBPICDC, Span<FDOJMOENJAL> OEGNIABGFIK, bool IDLJEEILMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x28FBB30", Offset = "0x28FAF30", VA = "0x1828FBB30", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public ALDAHNICMBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[EPJIKDLNGEH(typeof(JIDPKPDHEOA), new string[] { })]
public class CCNLOEHIDNI : JIDPKPDHEOA, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	[BOJGNOMIPCG]
	private LEHIKHOEAMN DOJPHKDLJHO;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private uint HHGEBFNEOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2904590", Offset = "0x2903990", VA = "0x182904590", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x29045E0", Offset = "0x29039E0", VA = "0x1829045E0", Slot = "5")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public CCNLOEHIDNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public abstract class HDCOJIIDNNK : DHFCPGFDHFO
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public abstract Type KHBMFPOLFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF, Span<byte> AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO, ReadOnlySpan<byte> AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	protected HDCOJIIDNNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public abstract class GPDKOOLHAGB<T> : HDCOJIIDNNK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override Type KHBMFPOLFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2C75EF0", Offset = "0x2C752F0", VA = "0x182C75EF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO, T AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x2C755B0", Offset = "0x2C749B0", VA = "0x182C755B0", Slot = "8")]
	public override void EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF, Span<byte> JNHEGOFDJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2C74BC0", Offset = "0x2C73FC0", VA = "0x182C74BC0", Slot = "9")]
	public override void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO, ReadOnlySpan<byte> OIEACLJHHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6C80", Offset = "0x1CA6080", VA = "0x181CA6C80")]
	protected GPDKOOLHAGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class LHCBICNIEGK
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public struct MDCEFCALBHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public IMBCAHJKJCI CNNBPGGDJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public KCPMLDAAPLA LELAEJFCKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public IJGPMAMDKLF KCJJGLLIALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NDDKNGFIEKO PCEDMCPKNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public JPKPMPALKHK IPNFEMGMOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public DDCOJKKDDIF FBACFIFAMFB;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x27B98D0", Offset = "0x27B8CD0", VA = "0x1827B98D0")]
		public void DKPCMCGGMHB(IABLIMOJJBC CEMAJLICLCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public struct FGGGLCNMAPO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public NativeList<JDPNCHCMAIA> AMMLHKPHIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public NativeList<BACOLBMJCKD> LHMBGJCLFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public NativeList<JDPNCHCMAIA> NKBMDMOANEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public NativeParallelMultiHashMap<JDPNCHCMAIA, FNCDFGODHHE> OEGNIABGFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public NativeList<byte> KCHKCPICHPB;

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public bool BICPPBKALMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x27B3B40", Offset = "0x27B2F40", VA = "0x1827B3B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x27B3AA0", Offset = "0x27B2EA0", VA = "0x1827B3AA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private struct MBECKDNEOGJ : IComparer<FNCDFGODHHE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x27B9710", Offset = "0x27B8B10", VA = "0x1827B9710", Slot = "4")]
		public int Compare(FNCDFGODHHE EOMIKPKMCAG, FNCDFGODHHE PPNFDCNFKFC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private static readonly EHKEPJIBENP CGFMJKJDKBD;

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AAF0", Offset = "0x2A69EF0", VA = "0x182A6AAF0")]
	public static void BJLIKALGEKC(ref KJIMKGCGBFG OMPJFFNAHDO, FGGGLCNMAPO CLCAIFLMLCJ, MDCEFCALBHP CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CAE0", Offset = "0x2A6BEE0", VA = "0x182A6CAE0")]
	public static FGGGLCNMAPO PBNHENPMFCO(ref PPDNPLENLDL BFNPCLOLNAF, Allocator DGGNDNPDKKD, MDCEFCALBHP CEMAJLICLCP)
	{
		return default(FGGGLCNMAPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C530", Offset = "0x2A6B930", VA = "0x182A6C530")]
	public static void OEELPNPOLFP(FGGGLCNMAPO CLCAIFLMLCJ, MDCEFCALBHP CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B980", Offset = "0x2A6AD80", VA = "0x182A6B980")]
	public static void IALPDIIHFKB(FGGGLCNMAPO CLCAIFLMLCJ, MDCEFCALBHP CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C3B0", Offset = "0x2A6B7B0", VA = "0x182A6C3B0")]
	public static int NEKDBIILJPC(FGGGLCNMAPO CLCAIFLMLCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C2F0", Offset = "0x2A6B6F0", VA = "0x182A6C2F0")]
	private static void MGKJNOHIJPB(ref KJIMKGCGBFG OMPJFFNAHDO, NativeArray<JDPNCHCMAIA> AMMLHKPHIHN, NativeArray<BACOLBMJCKD> LHMBGJCLFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C8C0", Offset = "0x2A6BCC0", VA = "0x182A6C8C0")]
	private static void OGKFNIPFHBK(ref PPDNPLENLDL BFNPCLOLNAF, Allocator DGGNDNPDKKD, out NativeList<JDPNCHCMAIA> AMMLHKPHIHN, out NativeList<BACOLBMJCKD> CGFJEJGMGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CA50", Offset = "0x2A6BE50", VA = "0x182A6CA50")]
	private static void OOIPNODLKIB(ref KJIMKGCGBFG OMPJFFNAHDO, NativeArray<JDPNCHCMAIA> NKBMDMOANEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B880", Offset = "0x2A6AC80", VA = "0x182A6B880")]
	private static void FDPJENGGHOD(ref PPDNPLENLDL BFNPCLOLNAF, Allocator DGGNDNPDKKD, out NativeList<JDPNCHCMAIA> NKBMDMOANEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6ADD0", Offset = "0x2A6A1D0", VA = "0x182A6ADD0")]
	private static void DDPCIBBCIGF(ref KJIMKGCGBFG OMPJFFNAHDO, NativeParallelMultiHashMap<JDPNCHCMAIA, FNCDFGODHHE> OEGNIABGFIK, NativeList<byte> KCHKCPICHPB, MDCEFCALBHP CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BC70", Offset = "0x2A6B070", VA = "0x182A6BC70")]
	private static void KFFGGOPDEAK(ref PPDNPLENLDL BFNPCLOLNAF, Allocator DGGNDNPDKKD, out NativeParallelMultiHashMap<JDPNCHCMAIA, FNCDFGODHHE> OEGNIABGFIK, out NativeList<byte> KCHKCPICHPB, MDCEFCALBHP CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6ADB0", Offset = "0x2A6A1B0", VA = "0x182A6ADB0")]
	private static void DBIIPNGPPLK(int FLDMJKMOBHF, ref int HHAGLKKHKOO, ref KJIMKGCGBFG OMPJFFNAHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AD90", Offset = "0x2A6A190", VA = "0x182A6AD90")]
	private static int CDNCOFMEKOJ(int HHAGLKKHKOO, ref PPDNPLENLDL BFNPCLOLNAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class EOMBPOINEAH
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class JEFFDGLOBFC
	{
		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class NAFKBEGKIPM<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
			public NAFKBEGKIPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x1D3B5F0", Offset = "0x1D3A9F0", VA = "0x181D3B5F0")]
			internal void JEGGLHGMIAP(ref KJIMKGCGBFG writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x1D3B470", Offset = "0x1D3A870", VA = "0x181D3B470")]
			internal T ABHOLGLKEBD(ref PPDNPLENLDL reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x27B79E0", Offset = "0x27B6DE0", VA = "0x1827B79E0")]
		public static void HDNGMJPJNFE(FBDOLOIEMBJ FBACFIFAMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x27C6880", Offset = "0x27C5C80", VA = "0x1827C6880")]
		private static void IHFJMHMFNHB<T>(FBDOLOIEMBJ FBACFIFAMFB, int KBFJHJENIED) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x27C69A0", Offset = "0x27C5DA0", VA = "0x1827C69A0")]
		private static void LBFBLHHPKOD<T>(ref KJIMKGCGBFG OMPJFFNAHDO, T GFDOPOBNKBA, int KBFJHJENIED) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x27C6A40", Offset = "0x27C5E40", VA = "0x1827C6A40")]
		private static T MGILMKAIIAO<T>(ref PPDNPLENLDL BFNPCLOLNAF, int KBFJHJENIED) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JEFFDGLOBFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class OKJGFBEHHFA : NJLPIFCFDMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private FBDOLOIEMBJ FBACFIFAMFB;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x27C94D0", Offset = "0x27C88D0", VA = "0x1827C94D0", Slot = "6")]
		public override void NGJNBPGHOAI<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x27BB350", Offset = "0x27BA750", VA = "0x1827BB350")]
		public static void JEMBAFFAJDG(FBDOLOIEMBJ FBACFIFAMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x27BB400", Offset = "0x27BA800", VA = "0x1827BB400")]
		public OKJGFBEHHFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x29582F0", Offset = "0x29576F0", VA = "0x1829582F0")]
	public static void EHEAMCLELJO(FBDOLOIEMBJ FBACFIFAMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2959D50", Offset = "0x2959150", VA = "0x182959D50")]
	private static void MCPEBEOAODD(ref KJIMKGCGBFG OPBCFGIPEAC, quaternion GFDOPOBNKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x2958210", Offset = "0x2957610", VA = "0x182958210")]
	private static quaternion CCIFMABHLJD(ref PPDNPLENLDL OEMJPJIELLC)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x224D890", Offset = "0x224CC90", VA = "0x18224D890")]
	public static void IOJAFFEEPGP<T>(FBDOLOIEMBJ FBACFIFAMFB, LHCEIALHAIF<T> HKMOIPMNIJF, POOANCPOGBB<T> OLGOLCEJCCN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x224D920", Offset = "0x224CD20", VA = "0x18224D920")]
	public static void LKHKMBDPBFB<T>(FBDOLOIEMBJ BIMCFGLAOAL) where T : struct, AKHJKCAIBOP
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[EPJIKDLNGEH(typeof(HOFAHHJLGEA), new string[] { })]
internal class FIFCAOCKPGO : NEHPEGODEDF, HOFAHHJLGEA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[BOJGNOMIPCG]
	private JIDPKPDHEOA OAHDHLNKBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private KBGKFCEPELG HJKCFBOLBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private int IJAAILKENCH;

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x28DA130", Offset = "0x28D9530", VA = "0x1828DA130", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x28DA000", Offset = "0x28D9400", VA = "0x1828DA000", Slot = "5")]
	public JGELFBOFGKF FLAAFOIJKBF(ReadOnlySpan<byte> HOJNLEBJGLH)
	{
		return default(JGELFBOFGKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x28D9FF0", Offset = "0x28D93F0", VA = "0x1828D9FF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public FIFCAOCKPGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[EPJIKDLNGEH(typeof(JPKPMPALKHK), new string[] { })]
public class EGBHMGGEJNE : JPKPMPALKHK, GMHONDBOJEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private OBBJAOPMBHM JKCFOAPCEGN;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x294FD70", Offset = "0x294F170", VA = "0x18294FD70", Slot = "8")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x294FE10", Offset = "0x294F210", VA = "0x18294FE10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2950460", Offset = "0x294F860", VA = "0x182950460", Slot = "4")]
	public void OEELPNPOLFP(JDPNCHCMAIA JBFCCDGDFOM, FDOJMOENJAL IOPMEPNDGKE, ReadOnlySpan<byte> KPDLBKBOMOO, ReadOnlySpan<byte> CDDMJOBFBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x29502A0", Offset = "0x294F6A0", VA = "0x1829502A0", Slot = "7")]
	public bool FGJCNEMODHE(JDPNCHCMAIA JBFCCDGDFOM, FDOJMOENJAL IOPMEPNDGKE, Span<byte> KPDLBKBOMOO, Span<byte> CDDMJOBFBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x2950280", Offset = "0x294F680", VA = "0x182950280", Slot = "5")]
	public bool EMHKIBFHLAN(JDPNCHCMAIA JBFCCDGDFOM, FDOJMOENJAL IOPMEPNDGKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2950420", Offset = "0x294F820", VA = "0x182950420", Slot = "6")]
	public bool IALPDIIHFKB(JDPNCHCMAIA JBFCCDGDFOM, FDOJMOENJAL IOPMEPNDGKE, ReadOnlySpan<byte> CDDMJOBFBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x294FE20", Offset = "0x294F220", VA = "0x18294FE20")]
	private bool EHJNJKNGONM(JDPNCHCMAIA JBFCCDGDFOM, FDOJMOENJAL IOPMEPNDGKE, ReadOnlySpan<byte> CDDMJOBFBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EGBHMGGEJNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class MCAFBJJINLD<T> : GPDKOOLHAGB<T> where T : struct, AKHJKCAIBOP
{
	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x22ED6C0", Offset = "0x22ECAC0", VA = "0x1822ED6C0", Slot = "10")]
	protected override T EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x22ED570", Offset = "0x22EC970", VA = "0x1822ED570", Slot = "11")]
	protected override void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO, T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x1316A40", Offset = "0x1315E40", VA = "0x181316A40")]
	public MCAFBJJINLD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	public class PhysicsSceneAddCollidersSystem : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		private struct PhysicsSceneAddCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400029F")]
			public PhysicsSceneAddCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A0")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C170", Offset = "0x4C4B570", VA = "0x184C4C170")]
			private void OPBILJIDNNC(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C0C0", Offset = "0x4C4B4C0", VA = "0x184C4C0C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EPFJAKLLFHC ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private FOODIHPHGKA colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x2489150", Offset = "0x2488550", VA = "0x182489150", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x2488E00", Offset = "0x2488200", VA = "0x182488E00", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x24891B0", Offset = "0x24885B0", VA = "0x1824891B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x2488E60", Offset = "0x2488260", VA = "0x182488E60")]
		private void JIBBKDGFAKB(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x2488F50", Offset = "0x2488350", VA = "0x182488F50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class HMKPFHPLADP : DFCPJAAPILG
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	protected override NGLJBCFJFFJ BNNGAFLNGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "17")]
		get
		{
			return default(NGLJBCFJFFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x28E8A50", Offset = "0x28E7E50", VA = "0x1828E8A50")]
	public HMKPFHPLADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class PCAGIAJLOKA : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[BurstCompile]
	private struct GKNHKGLJGDD : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		[ReadOnly]
		public ComponentTypeHandle<LEIMONNOBFD> AKJFJNPFBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public ComponentTypeHandle<AIMKNIFBJLG> PJJEAGCGHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public ComponentTypeHandle<PODMOPJDKIH> CGGIGHCHPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public ComponentTypeHandle<LAEGLBOPBMJ> KKMDPOMGLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public uint CDOBDMBCFLE;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x27B58B0", Offset = "0x27B4CB0", VA = "0x1827B58B0", Slot = "4")]
		public void Execute(ArchetypeChunk DHCAFCLHBAO, int BNOAGGNAMKG, int JBHKGNDKFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x27B5820", Offset = "0x27B4C20", VA = "0x1827B5820")]
		public bool AMNIIBHEDHA(ArchetypeChunk DHCAFCLHBAO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private EntityQuery IIGHBGGPCLN;

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x2482770", Offset = "0x2481B70", VA = "0x182482770", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x2482880", Offset = "0x2481C80", VA = "0x182482880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public PCAGIAJLOKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public sealed class HAPKKGPLJBP : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private DFIJJNIGPNA CHLJPKFIHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private KPNAFCNKGOC GOLCMKBOFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private MDPDEGLCMGA GMAFCCAHJCD;

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x28E3910", Offset = "0x28E2D10", VA = "0x1828E3910", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x28E39A0", Offset = "0x28E2DA0", VA = "0x1828E39A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public HAPKKGPLJBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class JIKGJPJAGIC : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x28F7360", Offset = "0x28F6760", VA = "0x1828F7360", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public JIKGJPJAGIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[EPJIKDLNGEH(typeof(DHBPJPLPADA), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal class DHBPJPLPADA : BKHNPHMEICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private GHKKIEINAJP<MJNEFILJOEE, FJFOKCMNCHF, EJNBEFLGKCF, PHKJDNACMEE> IAHDAGMCMBE;

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x2947570", Offset = "0x2946970", VA = "0x182947570", Slot = "4")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public DHBPJPLPADA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	public class PreSerializeTransformRoots : NILFPPHEEJF
	{
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[NoAlias]
		[BurstCompile]
		private struct PreSerializeTransformRoots_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public ComponentTypeHandle<OKLGNNPGBAD> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x4C4A8D0", Offset = "0x4C49CD0", VA = "0x184C4A8D0")]
			private void OPBILJIDNNC([NoAlias] ref OKLGNNPGBAD data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x4C4EDC0", Offset = "0x4C4E1C0", VA = "0x184C4EDC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[BurstCompile]
		[NoAlias]
		private struct PreSerializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public ComponentTypeHandle<KIKJFGLKOHO> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x4C49530", Offset = "0x4C48930", VA = "0x184C49530")]
			private void OPBILJIDNNC([NoAlias] ref KIKJFGLKOHO data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x4C4EE90", Offset = "0x4C4E290", VA = "0x184C4EE90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EntityQuery PreSerializeTransformRoots_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private EntityQuery PreSerializeTransformRoots_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery __query_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private ComponentTypeHandle<OKLGNNPGBAD> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private ComponentTypeHandle<KIKJFGLKOHO> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x24935A0", Offset = "0x24929A0", VA = "0x1824935A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x2492D00", Offset = "0x2492100", VA = "0x182492D00")]
		private void ILHGGBGEFNI(in IJEMHFEELIK transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x2492F20", Offset = "0x2492320", VA = "0x182492F20")]
		private JobHandle KICLOFEMBIB(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x2492BF0", Offset = "0x2491FF0", VA = "0x182492BF0")]
		private JobHandle GMAGGNHABFK(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x2493060", Offset = "0x2492460", VA = "0x182493060", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PreSerializeTransformRoots()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class KCCHKNIHFEP : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x28F8B70", Offset = "0x28F7F70", VA = "0x1828F8B70", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public KCCHKNIHFEP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	public class PhysicsSceneRemoveCollidersSystem : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		private struct PhysicsSceneRemoveCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			public PhysicsSceneRemoveCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			[ReadOnly]
			public ComponentTypeHandle<IALMBCEDHEH> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C390", Offset = "0x4C4B790", VA = "0x184C4C390")]
			private void OPBILJIDNNC(Entity e, in IALMBCEDHEH ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C270", Offset = "0x4C4B670", VA = "0x184C4C270", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EPFJAKLLFHC ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private FOODIHPHGKA colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private ComponentTypeHandle<IALMBCEDHEH> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x2489690", Offset = "0x2488A90", VA = "0x182489690", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x24893F0", Offset = "0x24887F0", VA = "0x1824893F0", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x24896F0", Offset = "0x2488AF0", VA = "0x1824896F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x24892B0", Offset = "0x24886B0", VA = "0x1824892B0")]
		private void GMIJODJBLJP(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x2489450", Offset = "0x2488850", VA = "0x182489450", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class OEFEHELLEJJ : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[BurstCompile]
	private struct NABLJACKPBO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[ReadOnly]
		public NativeArray<NIPLHJPNFGF> BJJEPJAEKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[ReadOnly]
		public NativeArray<Entity> NOEOKDNGNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public ComponentDataFromEntity CIGGMFDKAJM;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x27BA0C0", Offset = "0x27B94C0", VA = "0x1827BA0C0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[BurstCompile]
	private struct GEPKENJPHKF : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> HKDOAMDPLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> HGDJALDNGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> KJBNOGJOPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> MENDLKBADHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> FBJKFFFPGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public NativeList<EntityArchetype> APMGLFIENCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public NativeList<EntityArchetype> HHMCONHPJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public NativeList<EEMOBOLLAKL> DMMLFLOICLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public NativeList<EEMOBOLLAKL> IEDEBLALICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public NativeList<NIPLHJPNFGF> DHEBIHNACIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public NativeList<ComponentType> EBNDPHJDIPK;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x27B57E0", Offset = "0x27B4BE0", VA = "0x1827B57E0", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x27B4E20", Offset = "0x27B4220", VA = "0x1827B4E20", Slot = "5")]
		public JobHandle Dispose(JobHandle PAHMPOAEKCN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x27B5220", Offset = "0x27B4620", VA = "0x1827B5220", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x27B5740", Offset = "0x27B4B40", VA = "0x1827B5740")]
		private int GNGHDGMFPMK(EEMOBOLLAKL ABODDCIOGOC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x27B5020", Offset = "0x27B4420", VA = "0x1827B5020")]
		private bool EEJKHEMIGHA(int BDAKNHBHKII, EntityArchetype HDIFJNCBAOD, out EntityArchetype EIHJGPDGJFJ, out Entity GDODNFLDFMK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[BurstCompile]
	private struct ELJMPALHOPK : IComparer<NIPLHJPNFGF>
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x27B38C0", Offset = "0x27B2CC0", VA = "0x1827B38C0", Slot = "4")]
		public int Compare(NIPLHJPNFGF EOMIKPKMCAG, NIPLHJPNFGF PPNFDCNFKFC)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[BurstCompile]
	private struct IDFFHCOBNID : APLPGNLHJBF<NIPLHJPNFGF, int>
	{
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x19EBF10", Offset = "0x19EB310", VA = "0x1819EBF10")]
		public int EGDPOBLMKNF(in NIPLHJPNFGF CIDBOBPIINF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x19EBF10", Offset = "0x19EB310", VA = "0x1819EBF10", Slot = "4")]
		private int GLAOPBABFCA(in NIPLHJPNFGF AGLCIEKHLEE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private struct NIPLHJPNFGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public Entity GDODNFLDFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public EEMOBOLLAKL NOEOKDNGNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int MGBNOJEAFCD;
	}

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private DEMPLIAGLNN PJGJLPEKIPH;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x247DDF0", Offset = "0x247D1F0", VA = "0x18247DDF0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x247E8F0", Offset = "0x247DCF0", VA = "0x18247E8F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x247E9A0", Offset = "0x247DDA0", VA = "0x18247E9A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x247E400", Offset = "0x247D800", VA = "0x18247E400")]
	private GEPKENJPHKF KNGBLHMALBI(NativeArray<ArchetypeChunk> DCNPJMFMDBH)
	{
		return default(GEPKENJPHKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x247EFD0", Offset = "0x247E3D0", VA = "0x18247EFD0")]
	private void POKINOAEGGM(NativeArray<EntityArchetype> HHMCONHPJNJ, NativeArray<EEMOBOLLAKL> DMMLFLOICLI, NativeArray<EEMOBOLLAKL> IEDEBLALICK, NativeArray<ComponentType> EBNDPHJDIPK, NativeArray<ArchetypeChunk> DCNPJMFMDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x247E6B0", Offset = "0x247DAB0", VA = "0x18247E6B0")]
	private EntityArchetype KOLBEONMNBF(EntityArchetype HOMJKKIKFAG, NativeArray<ComponentType> EBNDPHJDIPK, EEMOBOLLAKL KBMIFPNEOLH)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x247DE40", Offset = "0x247D240", VA = "0x18247DE40")]
	private JobHandle JFIGCLFHENI(NativeList<NIPLHJPNFGF> BJJEPJAEKOM, NativeArray<Entity> NOEOKDNGNCK, JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x247DC20", Offset = "0x247D020", VA = "0x18247DC20")]
	private JobHandle IKOOLFOPCCM(NativeArray<Entity> NOEOKDNGNCK, NativeArray<NIPLHJPNFGF> BJJEPJAEKOM, int DCJNJIADGPK, EEMOBOLLAKL KBMIFPNEOLH, JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x247E3F0", Offset = "0x247D7F0", VA = "0x18247E3F0")]
	public static bool JHNHHLPBACL(ComponentType OOMLHJHCPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public OEFEHELLEJJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	public class PostDeserializeTransformRoots : NILFPPHEEJF
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeTransformRoots_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			public ComponentTypeHandle<OKLGNNPGBAD> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x4C49450", Offset = "0x4C48850", VA = "0x184C49450")]
			private void OPBILJIDNNC([NoAlias] ref OKLGNNPGBAD data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C940", Offset = "0x4C4BD40", VA = "0x184C4C940", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			public ComponentTypeHandle<KIKJFGLKOHO> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x4C49530", Offset = "0x4C48930", VA = "0x184C49530")]
			private void OPBILJIDNNC([NoAlias] ref KIKJFGLKOHO data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x4C4CA10", Offset = "0x4C4BE10", VA = "0x184C4CA10", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			public ComponentTypeHandle<OHBGCALBLDC> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			[ReadOnly]
			public ComponentTypeHandle<OKLGNNPGBAD> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x4C49540", Offset = "0x4C48940", VA = "0x184C49540")]
			private void OPBILJIDNNC([NoAlias] ref OHBGCALBLDC authoredPose, [NoAlias] in OKLGNNPGBAD pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x4C4CAE0", Offset = "0x4C4BEE0", VA = "0x184C4CAE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeTransformRoots_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public ComponentTypeHandle<AMAHPEIBDEI> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			[ReadOnly]
			public ComponentTypeHandle<KIKJFGLKOHO> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x4C49560", Offset = "0x4C48960", VA = "0x184C49560")]
			private void OPBILJIDNNC([NoAlias] ref AMAHPEIBDEI authoredScale, [NoAlias] in KIKJFGLKOHO scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x4C4CC30", Offset = "0x4C4C030", VA = "0x184C4CC30", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private EntityQuery __query_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private ComponentTypeHandle<OKLGNNPGBAD> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private ComponentTypeHandle<KIKJFGLKOHO> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private ComponentTypeHandle<OHBGCALBLDC> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private ComponentTypeHandle<OKLGNNPGBAD> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private ComponentTypeHandle<AMAHPEIBDEI> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private ComponentTypeHandle<KIKJFGLKOHO> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x248C0B0", Offset = "0x248B4B0", VA = "0x18248C0B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x248B110", Offset = "0x248A510", VA = "0x18248B110")]
		private void ILHGGBGEFNI(in IJEMHFEELIK transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x248AEC0", Offset = "0x248A2C0", VA = "0x18248AEC0")]
		private void GHCCLJIIDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x248B4A0", Offset = "0x248A8A0", VA = "0x18248B4A0")]
		private JobHandle KMDAKGNMDKP(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x248ADB0", Offset = "0x248A1B0", VA = "0x18248ADB0")]
		private JobHandle DFGACJEMNAH(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x248B340", Offset = "0x248A740", VA = "0x18248B340")]
		private JobHandle JLJJHKFJKJB(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x248B5E0", Offset = "0x248A9E0", VA = "0x18248B5E0")]
		private JobHandle KPLPNNEHODL(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x248B740", Offset = "0x248AB40", VA = "0x18248B740", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PostDeserializeTransformRoots()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal struct PFAOFBHMNPJ : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	internal class SplinePointParentChangedSystem : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		[NoAlias]
		[BurstCompile]
		private struct SplinePointParentChangedSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public DynamicBuffer<global::CJGIDBLNKDB> splineIndexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			[ReadOnly]
			public ComponentTypeHandle<OPILEFNOLAG> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x4C51EF0", Offset = "0x4C512F0", VA = "0x184C51EF0")]
			private void OPBILJIDNNC(Entity splinePoint, [NoAlias] in OPILEFNOLAG splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x4C51DD0", Offset = "0x4C511D0", VA = "0x184C51DD0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		private struct SplinePointParentChangedSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			[ReadOnly]
			public ComponentTypeHandle<global::GOFDHIDALFI> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x4C52120", Offset = "0x4C51520", VA = "0x184C52120")]
			private void OPBILJIDNNC(Entity splinePoint, [NoAlias] in global::GOFDHIDALFI splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x4C52000", Offset = "0x4C51400", VA = "0x184C52000", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private EntityQuery needsAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private EntityQuery needsRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[BOJGNOMIPCG]
		private JEGMBOPKKDO singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private ComponentTypeHandle<OPILEFNOLAG> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private ComponentTypeHandle<global::GOFDHIDALFI> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x2495CA0", Offset = "0x24950A0", VA = "0x182495CA0", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x2496150", Offset = "0x2495550", VA = "0x182496150", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x2496140", Offset = "0x2495540", VA = "0x182496140", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x2495500", Offset = "0x2494900", VA = "0x182495500")]
		private void DIPOADCOJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x2495A00", Offset = "0x2494E00", VA = "0x182495A00")]
		private void HJOMENKHOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x2495CF0", Offset = "0x24950F0", VA = "0x182495CF0")]
		private EntityCommandBufferSystem MAIDFODBFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x24958A0", Offset = "0x2494CA0", VA = "0x1824958A0")]
		private JobHandle GIPHBLKELNK(EntityCommandBuffer ecb, DynamicBuffer<global::CJGIDBLNKDB> splineIndexUpdatesRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x2495750", Offset = "0x2494B50", VA = "0x182495750")]
		private JobHandle EGNNJFMAGOH(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2495D40", Offset = "0x2495140", VA = "0x182495D40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public SplinePointParentChangedSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	public class UpdateInertialProperties : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[NoAlias]
		[BurstCompile]
		private struct UpdateInertialProperties_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20000EA")]
			public delegate void RunWithoutJobSystem_00000775$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			internal static class RunWithoutJobSystem_00000775$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x400030A")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x400030B")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000607")]
				[Cpp2IlInjected.Address(RVA = "0x4C50520", Offset = "0x4C4F920", VA = "0x184C50520")]
				[BurstDiscard]
				private static void PPBJJPEFDAD(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000608")]
				[Cpp2IlInjected.Address(RVA = "0x4C50390", Offset = "0x4C4F790", VA = "0x184C50390")]
				private static IntPtr OADLLJMHHGD()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000609")]
				[Cpp2IlInjected.Address(RVA = "0x4C500B0", Offset = "0x4C4F4B0", VA = "0x184C500B0")]
				public static void KNPKHMCBHMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600060A")]
				[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
				public static void MHIDNOPDKCM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600060C")]
				[Cpp2IlInjected.Address(RVA = "0x4C50170", Offset = "0x4C4F570", VA = "0x184C50170")]
				public static void LABHLMFNFCH(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public EntityQueryInJob isTaggedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public EntityQueryInJob rootRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			public EntityQueryInJob deformationScaleChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			public EntityQueryInJob generalRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			public ChunkFilterAnyOf5ComponentsChanged changeFilter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			public int maxEntityCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public NativeList<Entity> changedRoots;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			[ReadOnly]
			public EntityExistenceLookupByEntity entityExists;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[ReadOnly]
			public EntityTypeHandle entityTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			[ReadOnly]
			public ComponentTypeHandle<DEIPAKLKMIE> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			[ReadOnly]
			public ComponentDataFromEntity<GKLKKMKPHFN> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x4C52690", Offset = "0x4C51A90", VA = "0x184C52690")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x4C525C0", Offset = "0x4C519C0", VA = "0x184C525C0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x4C52630", Offset = "0x4C51A30", VA = "0x184C52630")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void IEKCDBAOBHK(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x4C525D0", Offset = "0x4C519D0", VA = "0x184C525D0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void HLCPEFLMIJJ(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery isTaggedForUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery generalRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private EntityQuery rootRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private EntityQuery deformationScaleChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private EntityQuery removeMassOfHierarchyQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private JJLJCDMIEAB rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private IMBCAHJKJCI objects;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x249B800", Offset = "0x249AC00", VA = "0x18249B800", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x249BF50", Offset = "0x249B350", VA = "0x18249BF50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x249C2C0", Offset = "0x249B6C0", VA = "0x18249C2C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x249B870", Offset = "0x249AC70", VA = "0x18249B870")]
		protected void MABINJOIHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x249B370", Offset = "0x249A770", VA = "0x18249B370")]
		protected void DCOABKKOHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x249B3F0", Offset = "0x249A7F0", VA = "0x18249B3F0")]
		private bool GAPJOLEKIMD(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, out NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x249BBB0", Offset = "0x249AFB0", VA = "0x18249BBB0")]
		private void MOFLBDLJODL(ref EntityQueryInJob isTaggedForUpdate, ref EntityQueryInJob rootRbexChangedQuery, ref EntityQueryInJob deformationScaleChangedQuery, ref EntityQueryInJob generalRbexChangedQuery, ref ChunkFilterAnyOf5ComponentsChanged changeFilter, ref int maxEntityCount, ref NativeList<Entity> changedRoots, ref EntityExistenceLookupByEntity entityExists, ref EntityTypeHandle entityTypeRO, ref ComponentTypeHandle<DEIPAKLKMIE> rbexRootTypeRO, ref ComponentDataFromEntity<GKLKKMKPHFN> rbexIsKinematicRO, ref Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x249BE90", Offset = "0x249B290", VA = "0x18249BE90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x249B320", Offset = "0x249A720", VA = "0x18249B320")]
		public static void ALBODHNGABL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public class NDNGNIJPLOF : NILFPPHEEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x2A759C0", Offset = "0x2A74DC0", VA = "0x182A759C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x2A75A80", Offset = "0x2A74E80", VA = "0x182A75A80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public NDNGNIJPLOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[DefaultMember("Item")]
public readonly struct OLDCGNLHOFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly int DCJNJIADGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly int EMFEDKKDAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly NativeArray<EEMOBOLLAKL>.ReadOnly OEGNIABGFIK;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public int NMCJNDHCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2480110", Offset = "0x247F510", VA = "0x182480110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public IBPKMONNJNM ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2480070", Offset = "0x247F470", VA = "0x182480070")]
		get
		{
			return default(IBPKMONNJNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public int AOJKKHLCGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x176BAF0", Offset = "0x176AEF0", VA = "0x18176BAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public NativeArray<EEMOBOLLAKL>.ReadOnly HHCNCEENPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x176BA60", Offset = "0x176AE60", VA = "0x18176BA60")]
		get
		{
			return default(NativeArray<EEMOBOLLAKL>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x2480160", Offset = "0x247F560", VA = "0x182480160")]
	public OLDCGNLHOFL(int DCJNJIADGPK, int EMFEDKKDAGH, NativeArray<EEMOBOLLAKL>.ReadOnly OEGNIABGFIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class DMKKPIEMGMO : LPMKPFADJKH
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	protected override NGPJOPHOOLK JCFDBPMPNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x294C8A0", Offset = "0x294BCA0", VA = "0x18294C8A0", Slot = "15")]
		get
		{
			return default(NGPJOPHOOLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x28DEB10", Offset = "0x28DDF10", VA = "0x1828DEB10")]
	public DMKKPIEMGMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class MPEKNPJGOIM : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private struct KEAHMHBDDGL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public FJMPDOIMHHI IIGHBGGPCLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public NativeParallelHashSet<Entity> NOEOKDNGNCK;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x27B87A0", Offset = "0x27B7BA0", VA = "0x1827B87A0")]
		public KEAHMHBDDGL(int GLDHDJHPIPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x27B8720", Offset = "0x27B7B20", VA = "0x1827B8720", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[BurstCompile]
	private struct MBIMCCNKEAG : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[ReadOnly]
		public NativeArray<Entity> NOEOKDNGNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		[ReadOnly]
		public ComponentDataFromEntity<AIMKNIFBJLG> GEPLBHBOJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[ReadOnly]
		public ComponentDataFromEntity<LAEGLBOPBMJ> EKGBAMHJBCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		[ReadOnly]
		public ComponentDataFromEntity<PODMOPJDKIH> HDEKNGPHPOO;

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x27B9740", Offset = "0x27B8B40", VA = "0x1827B9740", Slot = "4")]
		public void Execute(int BNOAGGNAMKG, TransformAccess DKKDEHMFAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[BurstCompile]
	private struct PEBJIPIACMA : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[ReadOnly]
		public NativeArray<Entity> NOEOKDNGNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		[ReadOnly]
		public ComponentDataFromEntity<AIMKNIFBJLG> GEPLBHBOJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[ReadOnly]
		public ComponentDataFromEntity<PODMOPJDKIH> HDEKNGPHPOO;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x27BB870", Offset = "0x27BAC70", VA = "0x1827BB870", Slot = "4")]
		public void Execute(int BNOAGGNAMKG, TransformAccess DKKDEHMFAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private FOODIHPHGKA ANNIKNAGBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private EntityQuery JHKGGLIOCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private EntityQuery CPBEGDEFPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private EntityQuery CPPBJELGMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private EntityQuery NKKFCLOLGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private EntityQuery MLHJFBJMJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private JobHandle CJOJCCHJJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private KEAHMHBDDGL DAIBPIJNEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private KEAHMHBDDGL HLKACCFODBE;

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x2A72980", Offset = "0x2A71D80", VA = "0x182A72980", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x2A729E0", Offset = "0x2A71DE0", VA = "0x182A729E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x2A72940", Offset = "0x2A71D40", VA = "0x182A72940", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x2A72C90", Offset = "0x2A72090", VA = "0x182A72C90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x2A726C0", Offset = "0x2A71AC0", VA = "0x182A726C0")]
	private void HLDHODJGKDH(EntityQuery BEHDAMIMGBM, out (NativeArrayAsync<IALMBCEDHEH> handles, NativeArrayAsync<BFOKBMJCBHG> bounds) CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x2A72340", Offset = "0x2A71740", VA = "0x182A72340")]
	private void ECABAHHJGNL((NativeArrayAsync<IALMBCEDHEH> handles, NativeArrayAsync<BFOKBMJCBHG> bounds) CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x2A72940", Offset = "0x2A71D40", VA = "0x182A72940")]
	private void IHBJMKMEGMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x2A72800", Offset = "0x2A71C00", VA = "0x182A72800")]
	private void IBPLIPBGOLA(EntityQuery BEHDAMIMGBM, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<IALMBCEDHEH> handles) CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x2A720A0", Offset = "0x2A714A0", VA = "0x182A720A0")]
	private void BMIBKJHFBFL((NativeArrayAsync<Entity> entities, NativeArrayAsync<IALMBCEDHEH> handles) CLCAIFLMLCJ, KEAHMHBDDGL HMHINJBEENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x2A72560", Offset = "0x2A71960", VA = "0x182A72560")]
	private JobHandle HBLBBHMLDDN(KEAHMHBDDGL HMHINJBEENE, ComponentDataFromEntity<AIMKNIFBJLG> GEPLBHBOJPD, ComponentDataFromEntity<PODMOPJDKIH> HDEKNGPHPOO, ComponentDataFromEntity<LAEGLBOPBMJ> EKGBAMHJBCG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x2A73440", Offset = "0x2A72840", VA = "0x182A73440")]
	private JobHandle PNBIALAFHKH(KEAHMHBDDGL HMHINJBEENE, ComponentDataFromEntity<AIMKNIFBJLG> GEPLBHBOJPD, ComponentDataFromEntity<PODMOPJDKIH> HDEKNGPHPOO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public MPEKNPJGOIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[AOMCBLMBOHN]
public class HBDPLMBNGNC : NILFPPHEEJF, GKBNEPAKIAE.MELEMKFOOIC
{
	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x28E3AF0", Offset = "0x28E2EF0", VA = "0x1828E3AF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x28E3AA0", Offset = "0x28E2EA0", VA = "0x1828E3AA0")]
	private EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public HBDPLMBNGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[NECCFHPLDLJ(typeof(OLPNFLMELII))]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(IDBLECGOEML), new string[] { })]
internal class IDBLECGOEML : NEHPEGODEDF, OLPNFLMELII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	[BOJGNOMIPCG]
	private BJKJCFIJEFI IGHEGPOBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private OCCDPACEAEH GAMHDJBAEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private NativeList<byte> CLCAIFLMLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private NativeList<JGELFBOFGKF> LOPPOJIGJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private NativeList<EEMOBOLLAKL> EJMNBLACDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private int JJKECDAEKDE;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<JGELFBOFGKF, NativeArray<byte>> NKCILBNNIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x28EAF10", Offset = "0x28EA310", VA = "0x1828EAF10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x28EAE70", Offset = "0x28EA270", VA = "0x1828EAE70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x28EAFB0", Offset = "0x28EA3B0", VA = "0x1828EAFB0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x28EADF0", Offset = "0x28EA1F0", VA = "0x1828EADF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x28EAC40", Offset = "0x28EA040", VA = "0x1828EAC40", Slot = "5")]
	public void AKDMLHDMGHC(JGELFBOFGKF OIEACLJHHPB, ReadOnlySpan<byte> HOJNLEBJGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x28EB0E0", Offset = "0x28EA4E0", VA = "0x1828EB0E0")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x28EB1F0", Offset = "0x28EA5F0", VA = "0x1828EB1F0")]
	public IDBLECGOEML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class AOMCBLMBOHN : HFNAELOJHJC
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	public AOMCBLMBOHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class AJBDNPAGFDD : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[BurstCompile]
	private struct JHIPOGEJFFK : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		[ReadOnly]
		public NativeArray<Entity> NOEOKDNGNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<OKLGNNPGBAD> FNFCBOAICAN;

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x27B7AD0", Offset = "0x27B6ED0", VA = "0x1827B7AD0", Slot = "4")]
		public void Execute(int BNOAGGNAMKG, TransformAccess DKKDEHMFAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x27B7AA0", Offset = "0x27B6EA0", VA = "0x1827B7AA0")]
		private bool DEPALJICEMC(float3 BGDHKJDGOAL, float3 CBNEMGEKLOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x27B7CA0", Offset = "0x27B70A0", VA = "0x1827B7CA0")]
		private bool GDKHMAOIDOJ(quaternion BGDHKJDGOAL, quaternion CBNEMGEKLOD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[BurstCompile]
	private struct JLGOAALJLIO : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		[ReadOnly]
		public NativeArray<Entity> NOEOKDNGNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<KIKJFGLKOHO> KDLHNECFJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<HAGJKHAGDIE> NIOEPAHNOKB;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x27B82A0", Offset = "0x27B76A0", VA = "0x1827B82A0", Slot = "4")]
		public void Execute(int BNOAGGNAMKG, TransformAccess DKKDEHMFAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private static readonly EHKEPJIBENP PKGJGEMIJDH;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private static readonly EHKEPJIBENP KPCMMDMMAMA;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private static readonly EHKEPJIBENP ABKOPKCLNDE;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly ProfilerMarker JPKIELHCOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private GPGAADBKEBC CEHFBMMMCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x28FB0A0", Offset = "0x28FA4A0", VA = "0x1828FB0A0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x28FB110", Offset = "0x28FA510", VA = "0x1828FB110", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x28FB150", Offset = "0x28FA550", VA = "0x1828FB150", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public AJBDNPAGFDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class IIJIPMMBKLK : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private OHAMPNBKDLP LJNICDIKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private MAIOFFPLJPO KAAJMNBNLBG;

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x28EC240", Offset = "0x28EB640", VA = "0x1828EC240", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x28EC1B0", Offset = "0x28EB5B0", VA = "0x1828EC1B0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x28EC340", Offset = "0x28EB740", VA = "0x1828EC340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public IIJIPMMBKLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[IICIJFGHOAB]
internal abstract class CLDIIDMFCAD : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	protected IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	protected FIOENEMHNNB LDOEEENLAJO;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected abstract NGPJOPHOOLK JCFDBPMPNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x2908A70", Offset = "0x2907E70", VA = "0x182908A70", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x2908AE0", Offset = "0x2907EE0", VA = "0x182908AE0")]
	protected void OHKNPFIPGBK(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x29087B0", Offset = "0x2907BB0", VA = "0x1829087B0")]
	protected void BHPHIPMEJEM(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x2908A00", Offset = "0x2907E00", VA = "0x182908A00")]
	protected FDJPAKEFOJE CLDLCKKBDJK(EntityQuery BEHDAMIMGBM)
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	protected CLDIIDMFCAD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal struct CPMLNJKHFLE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public struct FJMPDOIMHHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private NativeList<Entity> NOEOKDNGNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private TransformAccessArray IIGHBGGPCLN;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x28DA4B0", Offset = "0x28D98B0", VA = "0x1828DA4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public NativeList<Entity> FFECOAFANCF
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public TransformAccessArray FMPOCJLJAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x28DA300", Offset = "0x28D9700", VA = "0x1828DA300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x28DA5D0", Offset = "0x28D99D0", VA = "0x1828DA5D0")]
	public FJMPDOIMHHI(int GLDHDJHPIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x28DA320", Offset = "0x28D9720", VA = "0x1828DA320")]
	public Entity BFJCDGBMIDG(int BNOAGGNAMKG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x28DA4C0", Offset = "0x28D98C0", VA = "0x1828DA4C0")]
	public void NIJJIEPMABP(int GLDHDJHPIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x28DA510", Offset = "0x28D9910", VA = "0x1828DA510")]
	public int NNFBEGDMHOD(Transform DKKDEHMFAEC, Entity GKMECPLEALF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x28DA430", Offset = "0x28D9830", VA = "0x1828DA430")]
	public int GKECBACHJLK(int BNOAGGNAMKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x28DA3B0", Offset = "0x28D97B0", VA = "0x1828DA3B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x28DA370", Offset = "0x28D9770", VA = "0x1828DA370")]
	private void DFMNGDCODMC(int CKCNPDKFFGK = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class CIBLKJDNMEH : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private CKMPIFKEGBJ EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x2905F00", Offset = "0x2905300", VA = "0x182905F00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2905E90", Offset = "0x2905290", VA = "0x182905E90", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x2905FD0", Offset = "0x29053D0", VA = "0x182905FD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public CIBLKJDNMEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
[EPJIKDLNGEH(typeof(FOODIHPHGKA), new string[] { })]
public sealed class HJHPGKEGCMI : FOODIHPHGKA, MBDFLOLPEII, GMHONDBOJEM, NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	[BOJGNOMIPCG]
	private LANNINJFJNI OCKKDLPLKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private Collider[] JNDOGICEEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private RaycastHit[] GGLBHGLNOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private MBHLHJKBIIN<PAAEECCICPH, BoxCollider> CJKHIINBGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private Scene PJOBCGNOOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private PhysicsScene HJNPPFIJCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private GameObject OGOBDKNMJKA;

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x28E7470", Offset = "0x28E6870", VA = "0x1828E7470", Slot = "9")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x28E7D20", Offset = "0x28E7120", VA = "0x1828E7D20", Slot = "10")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x28E78C0", Offset = "0x28E6CC0", VA = "0x1828E78C0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x28E7A90", Offset = "0x28E6E90", VA = "0x1828E7A90", Slot = "4")]
	public PAAEECCICPH FBDDCJHOFOO(Entity GKMECPLEALF)
	{
		return default(PAAEECCICPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x28E76B0", Offset = "0x28E6AB0", VA = "0x1828E76B0", Slot = "5")]
	public void DPILJEDEJAJ(NativeArray<PAAEECCICPH> KCIHKMODENE, NativeArray<BFOKBMJCBHG> CHMGFONJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x28E75E0", Offset = "0x28E69E0", VA = "0x1828E75E0", Slot = "6")]
	public void CEAHOIPMOHF(PAAEECCICPH PAHMPOAEKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x28E7BE0", Offset = "0x28E6FE0", VA = "0x1828E7BE0", Slot = "7")]
	public bool GFFOILJFPCP(PAAEECCICPH PAHMPOAEKCN, out Collider MPDBOOOIMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x28E8240", Offset = "0x28E7640", VA = "0x1828E8240")]
	public bool NMAPLLCJFCD(in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, float AKODDLNKMDE, Allocator DGGNDNPDKKD, out NativeArray<Entity> NOEOKDNGNCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x28E7C70", Offset = "0x28E7070", VA = "0x1828E7C70")]
	private void HEIFANEFMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x1088890", Offset = "0x1087C90", VA = "0x181088890")]
	private void DLFGBKIFNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x28E7A40", Offset = "0x28E6E40", VA = "0x1828E7A40")]
	private void EOFGGNEBOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0xD276D0", Offset = "0xD26AD0", VA = "0x180D276D0")]
	private void BCFLHGGHGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x28E7DE0", Offset = "0x28E71E0", VA = "0x1828E7DE0")]
	private BoxCollider KIALCHBOPGK(Entity GKMECPLEALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x28E79C0", Offset = "0x28E6DC0", VA = "0x1828E79C0")]
	private void EMABMFBKDIP(BoxCollider HLPOACLACJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x28E7F30", Offset = "0x28E7330", VA = "0x1828E7F30")]
	private void NIALKDFIJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x28E8120", Offset = "0x28E7520", VA = "0x1828E8120")]
	private void NJIJGJLJHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x28E8540", Offset = "0x28E7940", VA = "0x1828E8540")]
	private void PGJKDKKMIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x28E7F00", Offset = "0x28E7300", VA = "0x1828E7F00")]
	private void MMGBJEGAAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x28E7D10", Offset = "0x28E7110", VA = "0x1828E7D10")]
	private void IODCIFHGHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x28E7CD0", Offset = "0x28E70D0", VA = "0x1828E7CD0")]
	private void HPHGKAJEPMP(Scene HEBJJIFDAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public HJHPGKEGCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x28E7CC0", Offset = "0x28E70C0", VA = "0x1828E7CC0", Slot = "8")]
	private bool HOMLMLDCPOM(in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, float AKODDLNKMDE, Allocator DGGNDNPDKKD, out NativeArray<Entity> NOEOKDNGNCK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public readonly struct NGPJOPHOOLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public readonly ComponentType? AJFOLGMHCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public readonly ComponentType? EOBOMHPPFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public readonly ComponentType FJICGKCDIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public readonly object AEMEEHLIDCM;

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A840", Offset = "0x2A79C40", VA = "0x182A7A840")]
	public NGPJOPHOOLK(ComponentType? AJFOLGMHCOP, ComponentType? EOBOMHPPFHN, ComponentType FJICGKCDIDB, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2403570", Offset = "0x2402970", VA = "0x182403570")]
	public static NGPJOPHOOLK MAGDPJAHCBO<TReq, TTag>(object AEMEEHLIDCM)
	{
		return default(NGPJOPHOOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x2403350", Offset = "0x2402750", VA = "0x182403350")]
	public static NGPJOPHOOLK ENIHNCJDKDG<TReq, TMissing, TTag>(object AEMEEHLIDCM)
	{
		return default(NGPJOPHOOLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class FKJFFFJNBHI : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private NDDKNGFIEKO PCEDMCPKNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private KPNAFCNKGOC OJPBCBIFPOJ;

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x28DA8D0", Offset = "0x28D9CD0", VA = "0x1828DA8D0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x28DA940", Offset = "0x28D9D40", VA = "0x1828DA940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public FKJFFFJNBHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[EPJIKDLNGEH(typeof(GAGBBBEFGOD), new string[] { })]
[ODFCLLMCKOH(typeof(CBPMCDKGJGE))]
public class EGNAKLFPFCI : GAGBBBEFGOD, GMHONDBOJEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private readonly Dictionary<int, GKINOCIEEIK> LELGOIECNNP;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IEnumerable<GKINOCIEEIK> NHGIAHBMLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x2950A50", Offset = "0x294FE50", VA = "0x182950A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x2950650", Offset = "0x294FA50", VA = "0x182950650", Slot = "6")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x2950AA0", Offset = "0x294FEA0", VA = "0x182950AA0", Slot = "5")]
	public bool KFICFAEICON(int DCJNJIADGPK, out GKINOCIEEIK BIMCFGLAOAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x2950A00", Offset = "0x294FE00", VA = "0x182950A00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x2950B10", Offset = "0x294FF10", VA = "0x182950B10")]
	public EGNAKLFPFCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal class KLDAJFJPABG : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private EntityQuery FAFHOFMMIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private PINCEFFEDIB DOJPHKDLJHO;

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x2A64270", Offset = "0x2A63670", VA = "0x182A64270", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x2A64330", Offset = "0x2A63730", VA = "0x182A64330", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x2A643E0", Offset = "0x2A637E0", VA = "0x182A643E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x2370360", Offset = "0x236F760", VA = "0x182370360")]
	private bool APKKCKDIPEJ<TComponentData>(EntityQuery BEHDAMIMGBM, out NativeArray<Entity> NOEOKDNGNCK, out NativeArray<TComponentData> OEBIFBLEMHJ) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x2A642C0", Offset = "0x2A636C0", VA = "0x182A642C0")]
	public KINEJENHFEI NJBIJNJIGHA(Entity GKMECPLEALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public KLDAJFJPABG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000103")]
public struct OEEDGGFHCLB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[IICIJFGHOAB]
public class DMOIDPEEGFL : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[BurstCompile]
	private struct PBHHAJIDNNO : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		[ReadOnly]
		public NativeArray<Entity> CKNFOIFNHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		[ReadOnly]
		public ComponentDataFromEntity<OPILEFNOLAG> IGBHNMCJMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		[ReadOnly]
		public ComponentDataFromEntity<BFOKBMJCBHG> CNILHCMLPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter CNDCFLIPPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter GNECPDNFFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter MEEBFHMOMHN;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x27BB410", Offset = "0x27BA810", VA = "0x1827BB410", Slot = "4")]
		public void Execute(int BNOAGGNAMKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[BurstCompile]
	private struct BFANLBKPKKD : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		[ReadOnly]
		public NativeArray<Entity> MOEACIBEBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> CCGDONFKPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		[ReadOnly]
		public ComponentDataFromEntity<JFMBCHEMIHN> ABNCJNEJILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		[ReadOnly]
		public ComponentDataFromEntity<PPPFOFLFJIM> ILNFBHMAJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		[NativeDisableParallelForRestriction]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<BFOKBMJCBHG> HPACMKFNAGM;

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x27AF050", Offset = "0x27AE450", VA = "0x1827AF050", Slot = "4")]
		public void Execute(int BNOAGGNAMKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private EntityQuery DILEDDFMKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private EntityQuery PKOLHCCLCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private EntityQuery GLPJEIEPJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private EntityQuery BADAKGDAMJL;

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x294D6D0", Offset = "0x294CAD0", VA = "0x18294D6D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x294D8E0", Offset = "0x294CCE0", VA = "0x18294D8E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x294CEA0", Offset = "0x294C2A0", VA = "0x18294CEA0")]
	private JobHandle HAELFKCJLDJ(NativeArrayAsync<Entity> EACKPMFPNLH, int HBBGBOONHJE, JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x294CF80", Offset = "0x294C380", VA = "0x18294CF80")]
	private JobHandle HAELFKCJLDJ(NativeArray<Entity> DLEFNPLFKEM, int HBBGBOONHJE, [Optional] JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x294C920", Offset = "0x294BD20", VA = "0x18294C920")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) BJBJCJKHGNB(NativeArrayAsync<Entity> LMEGFDDKEAP)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x294D640", Offset = "0x294CA40", VA = "0x18294D640")]
	private void KNIKPMBCAEN(out NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x294D5B0", Offset = "0x294C9B0", VA = "0x18294D5B0")]
	private void JOIDKJPMOLF(NativeList<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x294D4E0", Offset = "0x294C8E0", VA = "0x18294D4E0")]
	private void JOIDKJPMOLF(NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x294CD70", Offset = "0x294C170", VA = "0x18294CD70")]
	private void DBDBPOCNIMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void IIAFDKPENGH(int FCMELKLCLNE, int OGMELNEHHAM, int MCGFHCKMMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x294D1B0", Offset = "0x294C5B0", VA = "0x18294D1B0")]
	private static BFOKBMJCBHG INMOOHOLJBP(NativeArray<Entity> INMHJPDMDLI, ComponentDataFromEntity<JFMBCHEMIHN> ABNCJNEJILK, ComponentDataFromEntity<PPPFOFLFJIM> ILNFBHMAJLG)
	{
		return default(BFOKBMJCBHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public DMOIDPEEGFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct LJPBJFAFPOA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private NativeArray<EEMOBOLLAKL> EADNKKGPKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private NativeArray<int> DAAKIDEMCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private NativeParallelHashMap<int, EEMOBOLLAKL> HEKFAKJBCHD;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public readonly int HCLKHAAFLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABD510", VA = "0x180ABE110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public readonly int FGHOJHOIGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x131F5F0", Offset = "0x131E9F0", VA = "0x18131F5F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D320", Offset = "0x2A6C720", VA = "0x182A6D320")]
	public LJPBJFAFPOA(IReadOnlyCollection<CMCADLOKOGK> OEBIFBLEMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D1E0", Offset = "0x2A6C5E0", VA = "0x182A6D1E0")]
	public readonly OLDCGNLHOFL IJPAGMLGBCG(int DCJNJIADGPK)
	{
		return default(OLDCGNLHOFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D160", Offset = "0x2A6C560", VA = "0x182A6D160", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
[AlwaysUpdateSystem]
public abstract class GJPGACKBJOK : NILFPPHEEJF, GKBNEPAKIAE.MELEMKFOOIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private NativeList<EntityQuery> NEJHPGNLCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private bool HELNCBKPDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private EntityCommandBufferSystem ICHBDANIEME;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	protected bool CGCNKCIPCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x28DE8B0", Offset = "0x28DDCB0", VA = "0x1828DE8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected abstract EHKEPJIBENP JGFJHJADKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<GKBNEPAKIAE.HIFHIPGNECO> DJGCEJKFFPB();

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x28DE910", Offset = "0x28DDD10", VA = "0x1828DE910", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x28DEA30", Offset = "0x28DDE30", VA = "0x1828DEA30", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x28DE9E0", Offset = "0x28DDDE0", VA = "0x1828DE9E0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void GHEFEAJKGFI();

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x28DE8C0", Offset = "0x28DDCC0", VA = "0x1828DE8C0")]
	protected EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x16DDDC0", Offset = "0x16DD1C0", VA = "0x1816DDDC0")]
	protected EntityQuery EJPCPGLANMK<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x16DE2C0", Offset = "0x16DD6C0", VA = "0x1816DE2C0")]
	protected MHDFJIJCFFB<T> IMBJKJMFBID<T>() where T : struct, IComponentData
	{
		return default(MHDFJIJCFFB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x16DEFC0", Offset = "0x16DE3C0", VA = "0x1816DEFC0")]
	protected DBDPDMBEOFD<T> JJACDCGJAJD<T>() where T : struct, IComponentData
	{
		return default(DBDPDMBEOFD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x16DF0D0", Offset = "0x16DE4D0", VA = "0x1816DF0D0")]
	protected static void MKLIAMKIHKM<T1, T2>(JEDNPGEGKOA<T1> EDPNPLHIKON, JEDNPGEGKOA<T2> CJIMKBDFDKD) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x16DF0D0", Offset = "0x16DE4D0", VA = "0x1816DF0D0")]
	protected static void MKLIAMKIHKM<T1, T2>(JEDNPGEGKOA<T1> EDPNPLHIKON, FANFGPLECFE<T2> CJIMKBDFDKD) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x16DF1D0", Offset = "0x16DE5D0", VA = "0x1816DF1D0")]
	private static void MKLIAMKIHKM<T1, T2>(OFDCNLDBOIC<T1> EDPNPLHIKON, OFDCNLDBOIC<T2> CJIMKBDFDKD) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	protected GJPGACKBJOK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	[AOMCBLMBOHN]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : GJPGACKBJOK
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public MHDFJIJCFFB<FOINBIBPFDI> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public MHDFJIJCFFB<JJDHCPGNCCG> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public MHDFJIJCFFB<NEKAOFOHDGA> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public MHDFJIJCFFB<JFJAAJOMDDN> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public DBDPDMBEOFD<AEINALOEIKO> v4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public NEKAOFOHDGA v2Default;

			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0x4C4D030", Offset = "0x4C4C430", VA = "0x184C4D030")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x4C4D020", Offset = "0x4C4C420", VA = "0x184C4D020", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		protected override EHKEPJIBENP Log
		{
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x248D0C0", Offset = "0x248C4C0", VA = "0x18248D0C0", Slot = "14")]
			get
			{
				return default(EHKEPJIBENP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x248CBE0", Offset = "0x248BFE0", VA = "0x18248CBE0", Slot = "15")]
		public override IEnumerable<GKBNEPAKIAE.HIFHIPGNECO> DJGCEJKFFPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x248D120", Offset = "0x248C520", VA = "0x18248D120", Slot = "16")]
		protected override void GHEFEAJKGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x248CF20", Offset = "0x248C320", VA = "0x18248CF20")]
		private static void FMIENFPENCH(OFDCNLDBOIC<JJDHCPGNCCG> srcVersion, OFDCNLDBOIC<NEKAOFOHDGA> dstVersion, NEKAOFOHDGA dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x248CE00", Offset = "0x248C200", VA = "0x18248CE00")]
		private static void ECHNDJHBEBI(OFDCNLDBOIC<NEKAOFOHDGA> srcVersion, OFDCNLDBOIC<JFJAAJOMDDN> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x248CAB0", Offset = "0x248BEB0", VA = "0x18248CAB0")]
		private static void CJNOLAOAAKF(OFDCNLDBOIC<JFJAAJOMDDN> srcVersion, OFDCNLDBOIC<AEINALOEIKO> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x248D4B0", Offset = "0x248C8B0", VA = "0x18248D4B0")]
		private JobHandle OKIEBCLENKA(MHDFJIJCFFB<FOINBIBPFDI> v0, MHDFJIJCFFB<JJDHCPGNCCG> v1, MHDFJIJCFFB<NEKAOFOHDGA> v2, MHDFJIJCFFB<JFJAAJOMDDN> v3, DBDPDMBEOFD<AEINALOEIKO> v4, NEKAOFOHDGA v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x2488DF0", Offset = "0x24881F0", VA = "0x182488DF0")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[AlwaysUpdateSystem]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public abstract class DKFENIMBODI : NILFPPHEEJF, BKHNPHMEICP
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private struct IDMDIHDPELI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public NativeListAsync<Entity> LDIIDFNMGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public NativeListAsync<Entity> PGFPMMKPMMN;

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x27B7230", Offset = "0x27B6630", VA = "0x1827B7230")]
		public IDMDIHDPELI(NativeList<Entity> LDIIDFNMGMM, NativeList<Entity> PGFPMMKPMMN, JobHandle PDLPHPDOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x27B71B0", Offset = "0x27B65B0", VA = "0x1827B71B0")]
		public JobHandle HBLDGIOBNHP(JobHandle BMMIBMDGEID)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x27B7120", Offset = "0x27B6520", VA = "0x1827B7120", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct OFCENCLEBLJ : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		public enum DODMAOLIEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		[WriteOnly]
		public NativeList<Entity> GGOAFLKMNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		[WriteOnly]
		public NativeList<Entity> DHMCBIBFMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		[ReadOnly]
		public NativeArray<Entity> IPDAEHNBLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		[ReadOnly]
		public BufferFromEntity<NCPPJPJLJPP> PMHEKAFIMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		[ReadOnly]
		public ComponentDataFromEntity AOGJKNNDCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		[ReadOnly]
		public ComponentDataFromEntity BBEMBIGJKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		[ReadOnly]
		public ComponentDataFromEntity<EODNMPFLBLP> KCEBEFHKNNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public int FNCFGPEBGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public int GMKGAMJGAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private DODMAOLIEHJ GOKPJCPEPEI;

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x27BA780", Offset = "0x27B9B80", VA = "0x1827BA780", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x27BA9B0", Offset = "0x27B9DB0", VA = "0x1827BA9B0")]
		private bool IDNDAAHEMFN(Entity GKMECPLEALF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x27BA6F0", Offset = "0x27B9AF0", VA = "0x1827BA6F0")]
		private void BGDJCCFLPGA(Entity GKMECPLEALF, bool GBMCFCAMFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x27BAC20", Offset = "0x27BA020", VA = "0x1827BAC20")]
		private void KKJGMKGLFAK(Entity GKMECPLEALF, bool GBMCFCAMFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x27BA930", Offset = "0x27B9D30", VA = "0x1827BA930")]
		public IDMDIHDPELI HDFJMPIOFNN(NativeArray<Entity> LEIIMBCJOOL, JobHandle BMMIBMDGEID)
		{
			return default(IDMDIHDPELI);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x27BA8B0", Offset = "0x27B9CB0", VA = "0x1827BA8B0")]
		public IDMDIHDPELI FILBBOEGMAD(NativeArray<Entity> LEIIMBCJOOL, JobHandle BMMIBMDGEID)
		{
			return default(IDMDIHDPELI);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x27BAB40", Offset = "0x27B9F40", VA = "0x1827BAB40")]
		public IDMDIHDPELI KKHMKKADHHL(NativeList<NBMOHGNDFOG> FIONHDMDJNK, JobHandle BMMIBMDGEID)
		{
			return default(IDMDIHDPELI);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x27BAFB0", Offset = "0x27BA3B0", VA = "0x1827BAFB0")]
		public IDMDIHDPELI PONDNAOEECI(NativeList<NBMOHGNDFOG> FIONHDMDJNK, JobHandle BMMIBMDGEID)
		{
			return default(IDMDIHDPELI);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x27BAA60", Offset = "0x27B9E60", VA = "0x1827BAA60")]
		public IDMDIHDPELI IONONNMLMMD(NativeList<BOEBMGGFPKG> FIONHDMDJNK, JobHandle BMMIBMDGEID)
		{
			return default(IDMDIHDPELI);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x27C9390", Offset = "0x27C8790", VA = "0x1827C9390")]
		private IDMDIHDPELI LHDJNHNGBBG<T>(NativeList<T> FIONHDMDJNK, int GKDDPKHJODJ, int CGIKEHHNFDB, DODMAOLIEHJ ADMMGKCBODC, JobHandle BMMIBMDGEID) where T : struct
		{
			return default(IDMDIHDPELI);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x27BAD30", Offset = "0x27BA130", VA = "0x1827BAD30")]
		private IDMDIHDPELI LHDJNHNGBBG(NativeArray<Entity> NOEOKDNGNCK, int GKDDPKHJODJ, int CGIKEHHNFDB, DODMAOLIEHJ ADMMGKCBODC, JobHandle BMMIBMDGEID)
		{
			return default(IDMDIHDPELI);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private EntityQuery JHMPFPFBNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private EntityQuery GHPHFLELCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	private NFCKPDCDELJ FFFKCFKIEEG;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	protected abstract ComponentType OKLPIHFJNJO
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	protected abstract ComponentType OMNLNLCFBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	protected abstract ComponentType LOJAJIIODNP
	{
		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x2949240", Offset = "0x2948640", VA = "0x182949240")]
	protected DKFENIMBODI(EHKEPJIBENP IGCLICKKCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x2947F00", Offset = "0x2947300", VA = "0x182947F00", Slot = "14")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x2947FE0", Offset = "0x29473E0", VA = "0x182947FE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x2948210", Offset = "0x2947610", VA = "0x182948210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x159D8A0", Offset = "0x159CCA0", VA = "0x18159D8A0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x2947BA0", Offset = "0x2946FA0", VA = "0x182947BA0")]
	private void FKGKMHHMIJM(NativeArray<Entity> FIONHDMDJNK, EntityCommandBuffer JNKKDKMNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x2947EB0", Offset = "0x29472B0", VA = "0x182947EB0")]
	private void KLOEJNCDIBL(NativeArray<Entity> FIONHDMDJNK, EntityCommandBuffer JNKKDKMNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2947A70", Offset = "0x2946E70", VA = "0x182947A70")]
	private void BGODIMPBFFK(IDMDIHDPELI GDGPGKAGPPN, string FJIALGMLGCF, EntityCommandBuffer JNKKDKMNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x2947960", Offset = "0x2946D60", VA = "0x182947960")]
	private void BGODIMPBFFK(NativeListAsync<Entity> KNNNPNGLLNF, string FJIALGMLGCF, EntityCommandBuffer JNKKDKMNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x2947BF0", Offset = "0x2946FF0", VA = "0x182947BF0")]
	private void HGDLBHLALAI(IDMDIHDPELI GDGPGKAGPPN, string FJIALGMLGCF, EntityCommandBuffer JNKKDKMNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2947D20", Offset = "0x2947120", VA = "0x182947D20")]
	private void HGDLBHLALAI(NativeListAsync<Entity> KNNNPNGLLNF, string FJIALGMLGCF, EntityCommandBuffer JNKKDKMNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2947E30", Offset = "0x2947230", VA = "0x182947E30")]
	private bool IIMFMDHCKIK()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	public class RegisterTransforms : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		private struct RegisterTransforms_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public RegisterTransforms __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public ComponentTypeHandle<HAJLKENCNBI> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(RVA = "0x4C4FFA0", Offset = "0x4C4F3A0", VA = "0x184C4FFA0")]
			private void OriginalLambdaBody(Entity entity, in HAJLKENCNBI arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(RVA = "0x4C4FDB0", Offset = "0x4C4F1B0", VA = "0x184C4FDB0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private GPGAADBKEBC embodiedTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private EntityQuery allTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private EntityQuery addNewTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private EntityQuery removeOldTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private EntityQuery clearTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery RegisterTransforms_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private ComponentTypeHandle<HAJLKENCNBI> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2493E80", Offset = "0x2493280", VA = "0x182493E80", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2494100", Offset = "0x2493500", VA = "0x182494100", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2494370", Offset = "0x2493770", VA = "0x182494370", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2493B00", Offset = "0x2492F00", VA = "0x182493B00")]
		private void AddTransforms(EntityQuery query, FJMPDOIMHHI accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x24946A0", Offset = "0x2493AA0", VA = "0x1824946A0")]
		private void RemoveTransforms(EntityQuery query, FJMPDOIMHHI accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2494310", Offset = "0x2493710", VA = "0x182494310", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x24939C0", Offset = "0x2492DC0", VA = "0x1824939C0")]
		private void AddNewTransforms(NativeArray<Entity> entities, FJMPDOIMHHI accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2494460", Offset = "0x2493860", VA = "0x182494460")]
		internal static void RemoveOldTransforms(NativeArray<HAJLKENCNBI> arrayIndices, ComponentDataFromEntity<HAJLKENCNBI> transformAccess, FJMPDOIMHHI accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		private static void DebugLogRemove(int index, FJMPDOIMHHI accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2493D50", Offset = "0x2493150", VA = "0x182493D50")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2493D50", Offset = "0x2493150", VA = "0x182493D50")]
		private void RegisterTransforms_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2493ED0", Offset = "0x24932D0", VA = "0x182493ED0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public RegisterTransforms()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[EPJIKDLNGEH(typeof(COKHJGJNDIB), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal sealed class COKHJGJNDIB : BLHEKNIGKIO, GMHONDBOJEM, NEHPEGODEDF, BKHNPHMEICP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	[BOJGNOMIPCG]
	private GGNFHIGGHPN IIGHBGGPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	[BOJGNOMIPCG]
	private EEKNAEJEFGF DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	[BOJGNOMIPCG]
	private LANNINJFJNI OCKKDLPLKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	[BOJGNOMIPCG]
	private DBDLLHJFBEC GPLIFAOGPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	[BOJGNOMIPCG]
	private KILFBCLKOFO BOGFNOJBJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	[BOJGNOMIPCG]
	private MDPDEGLCMGA GMAFCCAHJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private readonly Dictionary<JDPNCHCMAIA, KINEJENHFEI> PEGCDOBDLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private BJEAIDIMNMH MNKNJJOEMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x290D600", Offset = "0x290CA00", VA = "0x18290D600")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x8B8B20", Offset = "0x8B7F20", VA = "0x1808B8B20", Slot = "4")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x290D6D0", Offset = "0x290CAD0", VA = "0x18290D6D0", Slot = "5")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x290BA00", Offset = "0x290AE00", VA = "0x18290BA00")]
	public void AFHMDCEBBKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x290FA20", Offset = "0x290EE20", VA = "0x18290FA20", Slot = "6")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x290C2F0", Offset = "0x290B6F0", VA = "0x18290C2F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x290F550", Offset = "0x290E950", VA = "0x18290F550")]
	public int MJDIJOGFLFC(SceneTag PJOBCGNOOBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x290BAA0", Offset = "0x290AEA0", VA = "0x18290BAA0")]
	public bool ALGOKNICFOF(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x290BF60", Offset = "0x290B360", VA = "0x18290BF60")]
	public bool CNIFBOMIGIC(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x290C240", Offset = "0x290B640", VA = "0x18290C240")]
	public bool DFFNJGBMJCN(Entity GKMECPLEALF, out KINEJENHFEI LGIGGJMIOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x290C190", Offset = "0x290B590", VA = "0x18290C190")]
	private bool DFFNJGBMJCN(Transform DKKDEHMFAEC, out KINEJENHFEI LGIGGJMIOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x290BEC0", Offset = "0x290B2C0", VA = "0x18290BEC0")]
	private void CCFBHDDOLDM(Entity GKMECPLEALF, KINEJENHFEI LGIGGJMIOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x290F2D0", Offset = "0x290E6D0", VA = "0x18290F2D0")]
	private bool MAFFCAGEKAO(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x290C3A0", Offset = "0x290B7A0", VA = "0x18290C3A0")]
	public void EHBDNPLCIKI(JDPNCHCMAIA DDCHJBPICDC, KINEJENHFEI GIMDOLBCAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x290D800", Offset = "0x290CC00", VA = "0x18290D800")]
	public bool JHEBCKBPEPC(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x290DDE0", Offset = "0x290D1E0", VA = "0x18290DDE0")]
	public bool JHEBCKBPEPC(Entity GKMECPLEALF, [Optional] object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x290DE50", Offset = "0x290D250", VA = "0x18290DE50")]
	public bool JHEBCKBPEPC(KINEJENHFEI CKAMNJPHKHD, object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x290C930", Offset = "0x290BD30", VA = "0x18290C930")]
	public bool FDENDKGBGMI(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x290DE80", Offset = "0x290D280", VA = "0x18290DE80")]
	public bool JHEBCKBPEPC(KINEJENHFEI LGIGGJMIOOL, bool DGLCECEILBL, [Optional] object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x290E040", Offset = "0x290D440", VA = "0x18290E040")]
	private bool KFJMHDPJJPO(KINEJENHFEI LGIGGJMIOOL, object AEMEEHLIDCM, bool DGLCECEILBL, bool EHIFCDLNGIN, bool CNCFOGPJCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x290F340", Offset = "0x290E740", VA = "0x18290F340")]
	public Transform MAJGDDBOLJC(Entity GKMECPLEALF, [Optional] object AEMEEHLIDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x290BFD0", Offset = "0x290B3D0", VA = "0x18290BFD0")]
	public bool DAJCKLBFICP(Entity GKMECPLEALF, out Transform DKKDEHMFAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x290F1D0", Offset = "0x290E5D0", VA = "0x18290F1D0")]
	public KINEJENHFEI LPGPBDHIJGJ(Entity GKMECPLEALF, [Optional] object AEMEEHLIDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x290CEE0", Offset = "0x290C2E0", VA = "0x18290CEE0")]
	public void FICCFBHGGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x290C590", Offset = "0x290B990", VA = "0x18290C590")]
	public void EMOIPLOFGBD(SceneTag PJOBCGNOOBP, bool EHIFCDLNGIN, NativeParallelHashSet<int> OJJEHNMHGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x290E770", Offset = "0x290DB70", VA = "0x18290E770")]
	private void LHMJMBJHGBP(Entity GKMECPLEALF, bool EHIFCDLNGIN, bool CNCFOGPJCKI, NativeParallelHashSet<int> OJJEHNMHGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x290E6F0", Offset = "0x290DAF0", VA = "0x18290E6F0")]
	public bool KLHFNHDCKBB(Entity GKMECPLEALF, object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x290D650", Offset = "0x290CA50", VA = "0x18290D650")]
	public bool IBFCLOIPLKD(Entity GKMECPLEALF, object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x290DF80", Offset = "0x290D380", VA = "0x18290DF80")]
	public bool KAHAGBFGIHL(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x290F7F0", Offset = "0x290EBF0", VA = "0x18290F7F0")]
	private void MPEILLAJAEE(bool ELFHEFKGIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x290F8B0", Offset = "0x290ECB0", VA = "0x18290F8B0")]
	private bool NDKHKEDFPFN(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x290BA50", Offset = "0x290AE50", VA = "0x18290BA50")]
	public KINEJENHFEI AIIFKFPHGJD(Entity GKMECPLEALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x290BE20", Offset = "0x290B220", VA = "0x18290BE20")]
	private KINEJENHFEI CCCKCNJMMKM(Entity GKMECPLEALF, object AEMEEHLIDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x290F580", Offset = "0x290E980", VA = "0x18290F580")]
	private KINEJENHFEI MNKGMOJGCMJ(Entity GKMECPLEALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x290E550", Offset = "0x290D950", VA = "0x18290E550")]
	public void KKBJJIBABGG(NativeArray<JDPNCHCMAIA> JJHDBMCJEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x290C090", Offset = "0x290B490", VA = "0x18290C090")]
	private void DFBCDMOEMOO(HEKFLAGDMLJ LEMCMBEMOCB, KINEJENHFEI GIMDOLBCAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x290DEB0", Offset = "0x290D2B0", VA = "0x18290DEB0")]
	private void JIIPLDGHGCG(KINEJENHFEI GIMDOLBCAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x290FB00", Offset = "0x290EF00", VA = "0x18290FB00")]
	private void OCCKLMBIEBL(KINEJENHFEI LGIGGJMIOOL, Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x290D200", Offset = "0x290C600", VA = "0x18290D200")]
	private void GGPEBLEKPJG(Entity GKMECPLEALF, KINEJENHFEI LGIGGJMIOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x290F940", Offset = "0x290ED40", VA = "0x18290F940")]
	private void NEMHPDGANBI(Entity GKMECPLEALF, Transform DKKDEHMFAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x290A9D0", Offset = "0x2909DD0", VA = "0x18290A9D0")]
	private HEKFLAGDMLJ BIMEBDOPAGA(Entity GKMECPLEALF)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x290FEF0", Offset = "0x290F2F0", VA = "0x18290FEF0")]
	public COKHJGJNDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x290BD50", Offset = "0x290B150", VA = "0x18290BD50")]
	[CompilerGenerated]
	private void BHOBACEHGAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public struct IALMBCEDHEH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public PAAEECCICPH PAHMPOAEKCN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0")]
	public static IALMBCEDHEH LFFBPOODCDC(in PAAEECCICPH BALDCPLBNCN)
	{
		return default(IALMBCEDHEH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0")]
	public static PAAEECCICPH LFFBPOODCDC(in IALMBCEDHEH CHDFOELIFAB)
	{
		return default(PAAEECCICPH);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	[AOMCBLMBOHN]
	public class PostDeserializeUpgrade_Split_ContainerData : NILFPPHEEJF, GKBNEPAKIAE.MELEMKFOOIC
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Split_ContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public NativeArray<ODALONFHOFF> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0x4C4DCF0", Offset = "0x4C4D0F0", VA = "0x184C4DCF0")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x4C4DCE0", Offset = "0x4C4D0E0", VA = "0x184C4DCE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x248E270", Offset = "0x248D670", VA = "0x18248E270", Slot = "14")]
		public IEnumerable<GKBNEPAKIAE.HIFHIPGNECO> DJGCEJKFFPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x248E4E0", Offset = "0x248D8E0", VA = "0x18248E4E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x248E490", Offset = "0x248D890", VA = "0x18248E490")]
		private EntityCommandBufferSystem MAIDFODBFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x248E340", Offset = "0x248D740", VA = "0x18248E340")]
		private JobHandle EFMGLDMBEHC(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<ODALONFHOFF> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x248E9B0", Offset = "0x248DDB0", VA = "0x18248E9B0")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class MOCMGDOIGPM : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2A71AE0", Offset = "0x2A70EE0", VA = "0x182A71AE0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2A71B30", Offset = "0x2A70F30", VA = "0x182A71B30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x2A71BF0", Offset = "0x2A70FF0", VA = "0x182A71BF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x2A71920", Offset = "0x2A70D20", VA = "0x182A71920")]
	private NativeArray<Entity> CFKLFPABBIP(int FJFMKNIHPDJ)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2A71810", Offset = "0x2A70C10", VA = "0x182A71810")]
	private void CAIICEKFCBP(NativeArray<Entity> CLIPADKCFCK, NativeArray<Entity> GGDHPGMOAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public MOCMGDOIGPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[DefaultMember("Item")]
public struct GFDLJGBGAEO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private FNJDMJLKEHA<T> CLCAIFLMLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private int HBBGBOONHJE;

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x3549A00", Offset = "0x3548E00", VA = "0x183549A00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x3549A50", Offset = "0x3548E50", VA = "0x183549A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[BurstCompile]
public struct ALAFGKLDHDM<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> FBJKFFFPGCC;

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0B10", Offset = "0x1A9FF10", VA = "0x181AA0B10")]
	public ALAFGKLDHDM(SharedComponentTypeHandle<T> FBJKFFFPGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x30C5CE0", Offset = "0x30C50E0", VA = "0x1830C5CE0", Slot = "4")]
	public bool Equals(ArchetypeChunk EOMIKPKMCAG, ArchetypeChunk PPNFDCNFKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x30C5DF0", Offset = "0x30C51F0", VA = "0x1830C5DF0", Slot = "5")]
	public int GetHashCode(ArchetypeChunk DHCAFCLHBAO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[IICIJFGHOAB]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class MFKIGPPDEIM : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	private AHJMHEDKMKK FIFIJDGGGND;

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x2A70AE0", Offset = "0x2A6FEE0", VA = "0x182A70AE0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x2A70B30", Offset = "0x2A6FF30", VA = "0x182A70B30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public MFKIGPPDEIM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	[IICIJFGHOAB]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	public class UpdateConnectableVisuals : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x200011C")]
		private struct HandlePosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public ELCJDJGAIGE handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public float3 position;

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x3D35A80", Offset = "0x3D34E80", VA = "0x183D35A80")]
			public HandlePosition(ELCJDJGAIGE handle, float3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x4C4BF40", Offset = "0x4C4B340", VA = "0x184C4BF40")]
			public void CILAAEFJCBE(out ELCJDJGAIGE handle, out float3 position)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011D")]
		private struct UpdateVisualPositions_ParentWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public UpdateConnectableVisuals __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			[ReadOnly]
			public ComponentTypeHandle<AIMKNIFBJLG> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public BufferTypeHandle<MJMJIDFKILJ> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x4C53BC0", Offset = "0x4C52FC0", VA = "0x184C53BC0")]
			private void OPBILJIDNNC(Entity entity, in AIMKNIFBJLG pose, DynamicBuffer<MJMJIDFKILJ> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x4C53A00", Offset = "0x4C52E00", VA = "0x184C53A00", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011E")]
		[NoAlias]
		[BurstCompile]
		private struct UpdateVisualPositions_ChildWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			[ReadOnly]
			public ComponentTypeHandle<AIMKNIFBJLG> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public BufferTypeHandle<LMCOECELJLH> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x4C53910", Offset = "0x4C52D10", VA = "0x184C53910")]
			private void OPBILJIDNNC([NoAlias] in AIMKNIFBJLG pose, DynamicBuffer<LMCOECELJLH> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x4C537A0", Offset = "0x4C52BA0", VA = "0x184C537A0", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			[ReadOnly]
			public ComponentTypeHandle<AIMKNIFBJLG> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			[ReadOnly]
			public ComponentTypeHandle<CABAKAOCBGH> __comTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public BufferTypeHandle<LMCOECELJLH> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x4C53660", Offset = "0x4C52A60", VA = "0x184C53660")]
			private void OPBILJIDNNC([NoAlias] in AIMKNIFBJLG pose, [NoAlias] in CABAKAOCBGH com, DynamicBuffer<LMCOECELJLH> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x4C53480", Offset = "0x4C52880", VA = "0x184C53480", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery addGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery addGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery updateGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private EntityQuery updateGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private EntityQuery removeExpiredGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private EntityQuery removeExpiredGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private EntityQuery removeAllGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private EntityQuery queryLegacyGizmoParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private EntityQuery queryChildrenWoutCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private EntityQuery queryChildrenWithCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private MBHLHJKBIIN<ELCJDJGAIGE, MPFACGKGBND> linkVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private HKJFJAJNFAP connectables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private IMBCAHJKJCI objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private FEEKAOBEJNL scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private BEJBBGIEBIB makerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private EntityQuery UpdateVisualPositions_ParentWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery UpdateVisualPositions_ChildWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery UpdateVisualPositions_ChildWithCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private ComponentTypeHandle<AIMKNIFBJLG> __RecRoom_Components_WorldPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private ComponentTypeHandle<CABAKAOCBGH> __RecRoom_Rbex_RbexLocalCenterOfMassOfSelfData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x2498740", Offset = "0x2497B40", VA = "0x182498740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x2498D70", Offset = "0x2498170", VA = "0x182498D70")]
		internal MPFACGKGBND JJMFAGJCIMB(ELCJDJGAIGE handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x2498CB0", Offset = "0x24980B0", VA = "0x182498CB0", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x249A8D0", Offset = "0x2499CD0", VA = "0x18249A8D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x249AB40", Offset = "0x2499F40", VA = "0x18249AB40", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x249ACD0", Offset = "0x249A0D0", VA = "0x18249ACD0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x249AB00", Offset = "0x2499F00", VA = "0x18249AB00", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x2499B30", Offset = "0x2498F30", VA = "0x182499B30")]
		private void MNLELLLJMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x2498A70", Offset = "0x2497E70", VA = "0x182498A70")]
		private void IBDJHGAOKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x24971E0", Offset = "0x24965E0", VA = "0x1824971E0")]
		private void BBOFHANLIGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x249AD10", Offset = "0x249A110", VA = "0x18249AD10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2498120", Offset = "0x2497520", VA = "0x182498120")]
		private void GLINDFMMGLK(EntityQuery add, EntityQuery update, EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x2499960", Offset = "0x2498D60", VA = "0x182499960")]
		private void LOBOHMPHNJE(EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x2499DA0", Offset = "0x24991A0", VA = "0x182499DA0")]
		private void NFAKHKDDDKG(NativeArrayAsync<Entity> oldEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2498010", Offset = "0x2497410", VA = "0x182498010")]
		private void GCNCHDJHJKC(NativeArrayAsync<Entity> newEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2498DC0", Offset = "0x24981C0", VA = "0x182498DC0")]
		private void KCCFGFFMOFP(NativeArrayAsync<Entity> updateEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2498BB0", Offset = "0x2497FB0", VA = "0x182498BB0")]
		private void IDIBDLEJONJ(NativeList<ELCJDJGAIGE> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2497A90", Offset = "0x2496E90", VA = "0x182497A90")]
		private NativeList<ELCJDJGAIGE> FPPLHECCBCP(NativeArray<Entity> entities)
		{
			return default(NativeList<ELCJDJGAIGE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x24993E0", Offset = "0x24987E0", VA = "0x1824993E0")]
		private void LDONLCNMDDB(NativeArray<Entity> entities, NativeList<ELCJDJGAIGE> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x2496B20", Offset = "0x2495F20", VA = "0x182496B20")]
		private void ACBJNLHKONE(NativeArray<Entity> addParents, NativeArray<Entity> addChildren, NativeList<ELCJDJGAIGE> freeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x249AE40", Offset = "0x249A240", VA = "0x18249AE40")]
		private void PBDEOAHPFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x2499C40", Offset = "0x2499040", VA = "0x182499C40")]
		private NativeListAsync<HandlePosition> NECFLINODEK(EntityQuery query, Func<NativeList<HandlePosition>, JobHandle> populateHandles)
		{
			return default(NativeListAsync<HandlePosition>);
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x24985D0", Offset = "0x24979D0", VA = "0x1824985D0")]
		private JobHandle GNBMIKOHIOJ(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x2499100", Offset = "0x2498500", VA = "0x182499100")]
		private JobHandle KOGIENELHID(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x2498F60", Offset = "0x2498360", VA = "0x182498F60")]
		private JobHandle KKLGAGPLNCO(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x2497800", Offset = "0x2496C00", VA = "0x182497800")]
		private void ENFAIMGHPEN(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x24987E0", Offset = "0x2497BE0", VA = "0x1824987E0")]
		private void HLDHLGNBLCK(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2498780", Offset = "0x2497B80", VA = "0x182498780")]
		private bool HLDEPLLPOHJ(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x2497730", Offset = "0x2496B30", VA = "0x182497730")]
		private NativeArray<Entity> DHIJKHDBHMP(Entity entity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2499FF0", Offset = "0x24993F0", VA = "0x182499FF0")]
		private ELCJDJGAIGE OMEAHLMIEMG(NativeList<ELCJDJGAIGE> freeList)
		{
			return default(ELCJDJGAIGE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2499A40", Offset = "0x2498E40", VA = "0x182499A40")]
		private void MDJDKMAHPMA(ELCJDJGAIGE handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2497090", Offset = "0x2496490", VA = "0x182497090")]
		private void AMPBHGAJDLE(ref NativeList<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2499270", Offset = "0x2498670", VA = "0x182499270")]
		private JobHandle LAOEPFCIKNB(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2497590", Offset = "0x2496990", VA = "0x182497590")]
		private JobHandle BKOPDJHLOOF(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x249A1B0", Offset = "0x24995B0", VA = "0x18249A1B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public UpdateConnectableVisuals()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	internal sealed class WriteDiffChangePacketToNetworkSystem : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[NoAlias]
		[BurstCompile]
		private struct WriteDiffChangePacketToNetworkSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x2000123")]
			public delegate void RunWithoutJobSystem_00000905$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000124")]
			internal static class RunWithoutJobSystem_00000905$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40003EF")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40003F0")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000774")]
				[Cpp2IlInjected.Address(RVA = "0x4C50B60", Offset = "0x4C4FF60", VA = "0x184C50B60")]
				[BurstDiscard]
				private static void PPBJJPEFDAD(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000775")]
				[Cpp2IlInjected.Address(RVA = "0x4C509D0", Offset = "0x4C4FDD0", VA = "0x184C509D0")]
				private static IntPtr OADLLJMHHGD()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000776")]
				[Cpp2IlInjected.Address(RVA = "0x4C506F0", Offset = "0x4C4FAF0", VA = "0x184C506F0")]
				public static void KNPKHMCBHMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000777")]
				[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
				public static void MHIDNOPDKCM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000779")]
				[Cpp2IlInjected.Address(RVA = "0x4C507B0", Offset = "0x4C4FBB0", VA = "0x184C507B0")]
				public static void LABHLMFNFCH(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public KMAJJBPLHDC replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			[ReadOnly]
			public NativeArray<JDPNCHCMAIA> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			[ReadOnly]
			public NativeArray<BACOLBMJCKD> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			[ReadOnly]
			public NativeArray<JDPNCHCMAIA> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, OFDKMKMCECL> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public NativeList<JDPNCHCMAIA> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public NativeList<BACOLBMJCKD> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public NativeList<JDPNCHCMAIA> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public NativeParallelMultiHashMap<JDPNCHCMAIA, FNCDFGODHHE> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public ComponentDataFromEntity<CCNJGHCPMLN> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x4C53F10", Offset = "0x4C53310", VA = "0x184C53F10")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x4C53E40", Offset = "0x4C53240", VA = "0x184C53E40", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x4C53EB0", Offset = "0x4C532B0", VA = "0x184C53EB0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void IEKCDBAOBHK(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x4C53E50", Offset = "0x4C53250", VA = "0x184C53E50")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void HLCPEFLMIJJ(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private static readonly EHKEPJIBENP logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		[BOJGNOMIPCG]
		private HOFAHHJLGEA packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		[BOJGNOMIPCG]
		private KPNAFCNKGOC diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		[BOJGNOMIPCG]
		private OCCDPACEAEH editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		[BOJGNOMIPCG]
		private BJKJCFIJEFI transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private LHCBICNIEGK.MDCEFCALBHP utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		private IIBLABALCCO EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x27C0070", Offset = "0x27BF470", VA = "0x1827C0070")]
			get
			{
				return default(IIBLABALCCO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x27BFFB0", Offset = "0x27BF3B0", VA = "0x1827BFFB0", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x27C1660", Offset = "0x27C0A60", VA = "0x1827C1660", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x27BFA20", Offset = "0x27BEE20", VA = "0x1827BFA20")]
		private bool GDPCPGLJDMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x27BFAF0", Offset = "0x27BEEF0", VA = "0x1827BFAF0")]
		private bool GLCAFOAJBMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x27BF310", Offset = "0x27BE710", VA = "0x1827BF310")]
		private bool BDGFDGBAKJC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x27C0AB0", Offset = "0x27BFEB0", VA = "0x1827C0AB0")]
		private LHCBICNIEGK.FGGGLCNMAPO ODMAIDFLOJJ(AMAKEGIKBFI state)
		{
			return default(LHCBICNIEGK.FGGGLCNMAPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x27BF780", Offset = "0x27BEB80", VA = "0x1827BF780")]
		private NativeKeyValueArrays<Entity, OFDKMKMCECL> DHCAIMEHCBG(AMAKEGIKBFI state, out int capacity)
		{
			return default(NativeKeyValueArrays<Entity, OFDKMKMCECL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x27BF360", Offset = "0x27BE760", VA = "0x1827BF360")]
		private void BHEELLELDBC(LHCBICNIEGK.FGGGLCNMAPO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x27C1310", Offset = "0x27C0710", VA = "0x1827C1310")]
		private void OEELPNPOLFP(LHCBICNIEGK.FGGGLCNMAPO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x27BFC00", Offset = "0x27BF000", VA = "0x1827BFC00")]
		private void IPFCJOBAHOH(LHCBICNIEGK.FGGGLCNMAPO data, AMAKEGIKBFI state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x27BF200", Offset = "0x27BE600", VA = "0x1827BF200")]
		private void APPIHDEJJGE(NativeArray<JDPNCHCMAIA> createdIds, NativeArray<BACOLBMJCKD> creationData, IIBLABALCCO flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x27C03E0", Offset = "0x27BF7E0", VA = "0x1827C03E0")]
		private void OAAPINFPEHI(NativeMultiHashMapAsync<Entity, OFDKMKMCECL> differences, IIBLABALCCO flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x27BF6C0", Offset = "0x27BEAC0", VA = "0x1827BF6C0")]
		private void CPKDAKDCNJK(NativeArray<JDPNCHCMAIA> destroyedIds, IIBLABALCCO flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x27C0110", Offset = "0x27BF510", VA = "0x1827C0110")]
		private void KOKEIINHBKF(ref KMAJJBPLHDC replication, ref NativeBitArray entityByProperty, ref NativeArray<JDPNCHCMAIA> srcCreatedIds, ref NativeArray<BACOLBMJCKD> srcCreationData, ref NativeArray<JDPNCHCMAIA> srcDestroyedIds, ref NativeKeyValueArrays<Entity, OFDKMKMCECL> srcPropertyKeyValues, ref NativeList<JDPNCHCMAIA> dstCreatedIds, ref NativeList<BACOLBMJCKD> dstCreationData, ref NativeList<JDPNCHCMAIA> dstDestroyedIds, ref NativeParallelMultiHashMap<JDPNCHCMAIA, FNCDFGODHHE> dstProperties, ref NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x27C1400", Offset = "0x27C0800", VA = "0x1827C1400", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x27BF9D0", Offset = "0x27BEDD0", VA = "0x1827BF9D0")]
		public static void FGPALDKAJBG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal readonly struct HMEAKIFOEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private readonly GJDIEPENDPN LDBPGDDOOAJ;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private static readonly ProfilerMarker KFHNGFCGHNP;

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x28E89F0", Offset = "0x28E7DF0", VA = "0x1828E89F0")]
	public HMEAKIFOEIM(World OKHCNMBCCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x28E8800", Offset = "0x28E7C00", VA = "0x1828E8800")]
	public JobHandle GLINDFMMGLK(JobHandle BKMNMGHEGFI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal static class PDJOLPANOCD
{
	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x322A6A0", Offset = "0x3229AA0", VA = "0x18322A6A0")]
	public static NativeArray<T> LHDJNHNGBBG<T>(NativeArray<Entity> NOEOKDNGNCK, EntityManager BEBIJONEMLA) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x2482A40", Offset = "0x2481E40", VA = "0x182482A40")]
	public static void HJJGJNCCMNN(EntityQuery BEHDAMIMGBM, EntityManager BEBIJONEMLA, IMBCAHJKJCI CNNBPGGDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x2482B80", Offset = "0x2481F80", VA = "0x182482B80")]
	public static void MGEJEBADHBC(NativeArray<Entity> CLIPADKCFCK, IMBCAHJKJCI CNNBPGGDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x2482CD0", Offset = "0x24820D0", VA = "0x182482CD0")]
	public static void ONDODGFAOND(NativeArray<Entity> CLIPADKCFCK, IMBCAHJKJCI CNNBPGGDJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class CKGKDOHEPFK : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	private ADEFNGMMPNA MNJPDGCOLON;

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x2908740", Offset = "0x2907B40", VA = "0x182908740", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x2908790", Offset = "0x2907B90", VA = "0x182908790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public CKGKDOHEPFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public class IHIDECBLFMB : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	private static EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	private EntityQuery HKCEOKDIMCM;

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x28EB720", Offset = "0x28EAB20", VA = "0x1828EB720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000785")]
	[Cpp2IlInjected.Address(RVA = "0x28EB9C0", Offset = "0x28EADC0", VA = "0x1828EB9C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000786")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public IHIDECBLFMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal struct BFOGCKHMEOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	private static readonly ProfilerMarker KFHNGFCGHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	private readonly NILFPPHEEJF GDOFPEAGKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private NativeList<(EntityQuery query, int componentIndex)> PAKIPJOJAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	private NativeList<(EntityQuery query, int componentIndex)> OMKGBPKOBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private NativeList<(EntityQuery query, int componentIndex)> OMONDKOCBPF;

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x28FD340", Offset = "0x28FC740", VA = "0x1828FD340")]
	public BFOGCKHMEOJ(NILFPPHEEJF GDOFPEAGKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x28FC9A0", Offset = "0x28FBDA0", VA = "0x1828FC9A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x28FC770", Offset = "0x28FBB70", VA = "0x1828FC770")]
	public NativeList<(EntityQuery, int, int, BOJCCJMKNAG.PKECAOCFACM)> CNOHIOEKCPK(uint EJAIBPIPMNM, out int FMFPEJONGDB)
	{
		return default(NativeList<(EntityQuery, int, int, BOJCCJMKNAG.PKECAOCFACM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x28FD0D0", Offset = "0x28FC4D0", VA = "0x1828FD0D0")]
	private int PMANCFMJPGC(BOJCCJMKNAG.PKECAOCFACM ADMMGKCBODC, NativeList<(EntityQuery query, int typeIndex)> MNNPDPNIFNM, NativeList<(EntityQuery query, int typeIndex, int count, BOJCCJMKNAG.PKECAOCFACM mode)> DFGDOEHKFHA, uint EJAIBPIPMNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x28FC730", Offset = "0x28FBB30", VA = "0x1828FC730")]
	private NativeList<(EntityQuery, int)> APOAEMCKBEE(NativeParallelHashSet<int> OEBIFBLEMHJ, int DKNJKEPPMMF)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x28FC6E0", Offset = "0x28FBAE0", VA = "0x1828FC6E0")]
	private NativeList<(EntityQuery, int)> AADAEPBHGKE(NativeParallelHashSet<int> OEBIFBLEMHJ, int DKNJKEPPMMF)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x28FCA00", Offset = "0x28FBE00", VA = "0x1828FCA00")]
	private NativeList<(EntityQuery, int)> GFLOKBEEGME(NativeParallelHashSet<int> OEBIFBLEMHJ, int DKNJKEPPMMF, BOJCCJMKNAG.PKECAOCFACM ADMMGKCBODC)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x28FCDE0", Offset = "0x28FC1E0", VA = "0x1828FCDE0")]
	private NativeList<(EntityQuery, int)> NDGCPHEHHGB()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public enum EABPIIFAODJ
{
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public struct NKHAMFBDDCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public EABPIIFAODJ EPHAAOEPCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public int EDAHLELDGOH;

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0xAEEC80", Offset = "0xAEE080", VA = "0x180AEEC80")]
	public NKHAMFBDDCG(EABPIIFAODJ EPHAAOEPCGL, int EDAHLELDGOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BA20", Offset = "0x2A7AE20", VA = "0x182A7BA20")]
	public static NKHAMFBDDCG LFFBPOODCDC((EABPIIFAODJ eventType, int eventIndex) EOMIKPKMCAG)
	{
		return default(NKHAMFBDDCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BA10", Offset = "0x2A7AE10", VA = "0x182A7BA10")]
	public void CILAAEFJCBE(out EABPIIFAODJ EPHAAOEPCGL, out int EDAHLELDGOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct DBDPDMBEOFD<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private NGGLHMEMLAF<T> LJJHJABONIO;

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x22FC700", Offset = "0x22FBB00", VA = "0x1822FC700")]
	public DBDPDMBEOFD(NGGLHMEMLAF<T> LJJHJABONIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x2581750", Offset = "0x2580B50", VA = "0x182581750")]
	public FANFGPLECFE<T> JMNCFKBKLBM()
	{
		return default(FANFGPLECFE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public readonly struct OFDKMKMCECL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly FDOJMOENJAL JNHCLKAAKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly int GDKDDPCMMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private unsafe readonly byte* BKAKEEKKHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private unsafe readonly byte* NGOMFIMAAFA;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public FDOJMOENJAL MCOMIPJPJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30")]
		get
		{
			return default(FDOJMOENJAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public int MMHHHCFJGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x176BAF0", Offset = "0x176AEF0", VA = "0x18176BAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public unsafe byte* KENOHAEPMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xBC5870", Offset = "0xBC4C70", VA = "0x180BC5870")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public unsafe byte* DDGCNKJGOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x247F1D0", Offset = "0x247E5D0", VA = "0x18247F1D0")]
	public CIMGDHMJEHM INEIGIHCJAA(Type GANFKPHKNKH)
	{
		return default(CIMGDHMJEHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x202A240", Offset = "0x2029640", VA = "0x18202A240")]
	public T DHKAEJJGOKM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x202A260", Offset = "0x2029660", VA = "0x18202A260")]
	public T INEIGIHCJAA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x247F3B0", Offset = "0x247E7B0", VA = "0x18247F3B0")]
	public unsafe OFDKMKMCECL(FDOJMOENJAL JNHCLKAAKHA, int AJCINIIEJAJ, byte* BKAKEEKKHCF, byte* NGOMFIMAAFA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal struct KIIHIDJAPJO : IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[AOMCBLMBOHN]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : GJPGACKBJOK
	{
		[Cpp2IlInjected.Token(Token = "0x2000130")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public MHDFJIJCFFB<HDNKACKGINB> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public DBDPDMBEOFD<HNFKHNCLACN> v2;

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x4C4CD90", Offset = "0x4C4C190", VA = "0x184C4CD90")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x4C4CD80", Offset = "0x4C4C180", VA = "0x184C4CD80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		protected override EHKEPJIBENP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600079E")]
			[Cpp2IlInjected.Address(RVA = "0x248C720", Offset = "0x248BB20", VA = "0x18248C720", Slot = "14")]
			get
			{
				return default(EHKEPJIBENP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x248C590", Offset = "0x248B990", VA = "0x18248C590", Slot = "15")]
		public override IEnumerable<GKBNEPAKIAE.HIFHIPGNECO> DJGCEJKFFPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x248C780", Offset = "0x248BB80", VA = "0x18248C780", Slot = "16")]
		protected override void GHEFEAJKGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x248C650", Offset = "0x248BA50", VA = "0x18248C650")]
		private static void FMIENFPENCH(OFDCNLDBOIC<HDNKACKGINB> srcVersion, OFDCNLDBOIC<HNFKHNCLACN> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x248C8F0", Offset = "0x248BCF0", VA = "0x18248C8F0")]
		private JobHandle HAHAMDNAOJJ(MHDFJIJCFFB<HDNKACKGINB> v1, DBDPDMBEOFD<HNFKHNCLACN> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x2488DF0", Offset = "0x24881F0", VA = "0x182488DF0")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class NPIHPFHENAI : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private EntityQuery HNGNEGHJKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private EntityQuery EMNDDJPHHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private GBFIINBNALL DOJPHKDLJHO;

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C950", Offset = "0x2A7BD50", VA = "0x182A7C950", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C9A0", Offset = "0x2A7BDA0", VA = "0x182A7C9A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CAF0", Offset = "0x2A7BEF0", VA = "0x182A7CAF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C8E0", Offset = "0x2A7BCE0", VA = "0x182A7C8E0")]
	private void CEOEEFKLLJJ(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public NPIHPFHENAI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
public struct ILEFNMCLEHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal class HMNKGMHFPKI : JCEINDAJIBO, AMAKEGIKBFI
{
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly KHFJDJKGIKC HODIGKENGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly NGLJBCFJFFJ GMAFCCAHJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly World OKHCNMBCCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly List<FEHKACBIOPC> GLPDAHCEKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private NativeParallelMultiHashMap<Entity, OFDKMKMCECL> OOINFNACJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private NativeParallelHashMap<int, int> LGMHFNBCEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private NativeArray<JDPNCHCMAIA> AMMLHKPHIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private NativeArray<BACOLBMJCKD> LHMBGJCLFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private NativeArray<JDPNCHCMAIA> NKBMDMOANEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private JobHandle GHIEAMIDDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private JobHandle GKDLKMAGPOP;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private NativeParallelMultiHashMap<Entity, OFDKMKMCECL> NPIJDAIDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E60", Offset = "0xCE6260", VA = "0x180CE6E60", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, OFDKMKMCECL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private uint LLBNENEMJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x28E8AB0", Offset = "0x28E7EB0", VA = "0x1828E8AB0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private bool PPEHOIDCOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x28E8E20", Offset = "0x28E8220", VA = "0x1828E8E20", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	private NativeArray<JDPNCHCMAIA> IKCHOHCLFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x16BEE30", Offset = "0x16BE230", VA = "0x1816BEE30", Slot = "10")]
		get
		{
			return default(NativeArray<JDPNCHCMAIA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private NativeArray<BACOLBMJCKD> IPMLFNJOBMM
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5ABE0", Offset = "0xA59FE0", VA = "0x180A5ABE0", Slot = "11")]
		get
		{
			return default(NativeArray<BACOLBMJCKD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private NativeArray<JDPNCHCMAIA> OGJJKJCHADP
	{
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x284A3D0", Offset = "0x28497D0", VA = "0x18284A3D0", Slot = "12")]
		get
		{
			return default(NativeArray<JDPNCHCMAIA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x28E98E0", Offset = "0x28E8CE0", VA = "0x1828E98E0")]
	public HMNKGMHFPKI(KHFJDJKGIKC HODIGKENGJG, NGLJBCFJFFJ GMAFCCAHJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x28E8F80", Offset = "0x28E8380", VA = "0x1828E8F80", Slot = "6")]
	private bool JOJCBCDOAPG(NativeArray<JDPNCHCMAIA> AMMLHKPHIHN, NativeArray<BACOLBMJCKD> LHMBGJCLFKL, NativeArray<JDPNCHCMAIA> NKBMDMOANEL, int CEFOHNHEFFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x28E9180", Offset = "0x28E8580", VA = "0x1828E9180", Slot = "7")]
	private void LAAPIGNNHPJ(in FEHKACBIOPC PHDIMPCFBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x28E8E30", Offset = "0x28E8230", VA = "0x1828E8E30", Slot = "8")]
	private void GENDABJMCAF(JobHandle PAHMPOAEKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x28E9260", Offset = "0x28E8660", VA = "0x1828E9260", Slot = "13")]
	private bool OOKFDPOEKFK(out NativeArray<int> FKKINIOIAPD, Allocator DGGNDNPDKKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x28E9670", Offset = "0x28E8A70", VA = "0x1828E9670", Slot = "14")]
	private bool PMAHLHEPGKL(ComponentType OOMLHJHCPCJ, out FEHKACBIOPC FBCMJKHLOEK, out OLDCGNLHOFL HMNOECLMMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x28E8DA0", Offset = "0x28E81A0", VA = "0x1828E8DA0", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, OFDKMKMCECL> CLMJCNHBJBO()
	{
		return default(NativeMultiHashMapAsync<Entity, OFDKMKMCECL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x28E9310", Offset = "0x28E8710", VA = "0x1828E9310")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x28E8B00", Offset = "0x28E7F00", VA = "0x1828E8B00")]
	private bool BLGCBGDENEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[InternalBufferCapacity(4)]
internal struct MJMJIDFKILJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public ELCJDJGAIGE PAHMPOAEKCN;
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class KCGIIKEIFCO : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A61D70", Offset = "0x2A61170", VA = "0x182A61D70", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public KCGIIKEIFCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class OENDLLELEIL : LAOHLEGNFJB
{
	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public OENDLLELEIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal class GDKGIGGEFPI
{
	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public GDKGIGGEFPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
public readonly struct FNCDFGODHHE : IEquatable<FNCDFGODHHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private readonly FDOJMOENJAL JNHCLKAAKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private readonly int GDKDDPCMMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private readonly int BKAKEEKKHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private readonly int NGOMFIMAAFA;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public FDOJMOENJAL MCOMIPJPJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30")]
		get
		{
			return default(FDOJMOENJAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x28DAB70", Offset = "0x28D9F70", VA = "0x1828DAB70")]
	public unsafe ReadOnlySpan<byte> DHKAEJJGOKM(void* KHJOCEHIGCB)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x28DAD60", Offset = "0x28DA160", VA = "0x1828DAD60")]
	public unsafe ReadOnlySpan<byte> INEIGIHCJAA(void* KHJOCEHIGCB)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x20D3A50", Offset = "0x20D2E50", VA = "0x1820D3A50")]
	public FNCDFGODHHE(FDOJMOENJAL JNHCLKAAKHA, int AJCINIIEJAJ, int BKAKEEKKHCF, int NGOMFIMAAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x28DACB0", Offset = "0x28DA0B0", VA = "0x1828DACB0", Slot = "4")]
	public bool Equals(FNCDFGODHHE ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x28DABE0", Offset = "0x28D9FE0", VA = "0x1828DABE0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x28DAD20", Offset = "0x28DA120", VA = "0x1828DAD20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[AOMCBLMBOHN]
	[IICIJFGHOAB]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : GJPGACKBJOK, GKBNEPAKIAE.MELEMKFOOIC
	{
		[Cpp2IlInjected.Token(Token = "0x200013A")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			public MHDFJIJCFFB<PILBPMBIBMJ> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			public MHDFJIJCFFB<LDPEKMBFPGE> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x4C4D710", Offset = "0x4C4CB10", VA = "0x184C4D710")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x4C4D700", Offset = "0x4C4CB00", VA = "0x184C4D700", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		protected override EHKEPJIBENP Log
		{
			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x248D8A0", Offset = "0x248CCA0", VA = "0x18248D8A0", Slot = "14")]
			get
			{
				return default(EHKEPJIBENP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x248D770", Offset = "0x248CB70", VA = "0x18248D770", Slot = "15")]
		public override IEnumerable<GKBNEPAKIAE.HIFHIPGNECO> DJGCEJKFFPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x248D900", Offset = "0x248CD00", VA = "0x18248D900", Slot = "16")]
		protected override void GHEFEAJKGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x248DB00", Offset = "0x248CF00", VA = "0x18248DB00")]
		private static void IPDAKKBJHHN(JEDNPGEGKOA<LDPEKMBFPGE> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x248DC40", Offset = "0x248D040", VA = "0x18248DC40")]
		private JobHandle NFDCADDALBN(MHDFJIJCFFB<PILBPMBIBMJ> v0, MHDFJIJCFFB<LDPEKMBFPGE> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2488DF0", Offset = "0x24881F0", VA = "0x182488DF0")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
public readonly struct FEHKACBIOPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public NativeList<Entity> FFECOAFANCF
	{
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NativeList<Entity> FBDADMFBFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x9857D0", Offset = "0x984BD0", VA = "0x1809857D0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public NativeList<byte> GGIAEEDMHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x9857E0", Offset = "0x984BE0", VA = "0x1809857E0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public NativeList<byte> PJPLFINCLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E60", Offset = "0xCE6260", VA = "0x180CE6E60")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public NativeList<byte> EOMHEJAEGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x985800", Offset = "0x984C00", VA = "0x180985800")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public ComponentType OOMINBLBOCF
	{
		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public JobHandle JHAIGONPOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0xA48C60", Offset = "0xA48060", VA = "0x180A48C60")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int AOJKKHLCGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x1F06550", Offset = "0x1F05950", VA = "0x181F06550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public int AFPKCEPAOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xABE120", Offset = "0xABD520", VA = "0x180ABE120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public bool EJHPBGNJGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x2962850", Offset = "0x2961C50", VA = "0x182962850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x29628D0", Offset = "0x2961CD0", VA = "0x1829628D0")]
	public FEHKACBIOPC(ComponentType OOMLHJHCPCJ, JobHandle PAHMPOAEKCN, NativeList<Entity> NOEOKDNGNCK, NativeList<Entity> JCPIHOLLAML, NativeList<byte> GGICOEBEIPA, NativeList<byte> LMGDNFKAADJ, NativeList<byte> LOHGDEDLJGJ, int EMFEDKKDAGH, int GDKDDPCMMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x2962730", Offset = "0x2961B30", VA = "0x182962730", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public abstract class EIPCEABGPFF : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected virtual NGEGBFMLEIK NKJHDOLBGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "14")]
		get
		{
			return default(NGEGBFMLEIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	protected virtual NGEGBFMLEIK JLLFBEMCIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x822D80", Offset = "0x822180", VA = "0x180822D80", Slot = "15")]
		get
		{
			return default(NGEGBFMLEIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void HFHBKKDGPPD(NGEGBFMLEIK LJJHJABONIO);

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x29542C0", Offset = "0x29536C0", VA = "0x1829542C0", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0x2954260", Offset = "0x2953660", VA = "0x182954260")]
	private NGEGBFMLEIK LENCHPICOIF()
	{
		return default(NGEGBFMLEIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	protected EIPCEABGPFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[NECCFHPLDLJ(typeof(HPKBHAJJNGO))]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
[EPJIKDLNGEH(typeof(DFIJJNIGPNA), new string[] { })]
public class DFIJJNIGPNA : HPKBHAJJNGO, NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	private struct JCECIAEAKMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public AFNDKOFPEDG DPMJOLDHNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public Type GANFKPHKNKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	private struct GHNKFGEDNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public JCECIAEAKMG[] OEGNIABGFIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[BurstCompile]
	private struct FDOLDGGBPLG : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		[ReadOnly]
		public NativeArray<byte> IAJCOFMCAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		[ReadOnly]
		public NativeArray<Entity> LIAAOFFEIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		[ReadOnly]
		public NativeArray<byte> LJPKLLLAADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		[ReadOnly]
		public NativeArray<byte> CGMMHFNJBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		[WriteOnly]
		public NativeList<Entity> DGOPBEGDPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		[WriteOnly]
		public NativeList<byte> MAHPMLCFEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		[WriteOnly]
		public NativeList<byte> IBMHCHEKBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public int EMAGHODJPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public int FPJONEPAHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int FDCPCHCLFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int MEOMIGAHALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public int CEPEALGLHJE;

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x27B38E0", Offset = "0x27B2CE0", VA = "0x1827B38E0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private readonly Dictionary<FDOJMOENJAL, AFNDKOFPEDG> HHKNGECDECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private readonly Dictionary<int, GHNKFGEDNOO> EKGBLIGLBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private IJGPMAMDKLF OEGNIABGFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action JKAALEHMNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x2945C60", Offset = "0x2945060", VA = "0x182945C60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x2945610", Offset = "0x2944A10", VA = "0x182945610")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action FBLEMLIFDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x2945BC0", Offset = "0x2944FC0", VA = "0x182945BC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x29453F0", Offset = "0x29447F0", VA = "0x1829453F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x2946600", Offset = "0x2945A00", VA = "0x182946600", Slot = "6")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x29458F0", Offset = "0x2944CF0", VA = "0x1829458F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x2945980", Offset = "0x2944D80", VA = "0x182945980", Slot = "4")]
	public void EHBDNPLCIKI(LOHCJILDMLL LEMJCNJPDLJ, AFNDKOFPEDG NMBCGMHEDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x2946AF0", Offset = "0x2945EF0", VA = "0x182946AF0", Slot = "5")]
	public void OAPBCJNJKMP(LOHCJILDMLL LEMJCNJPDLJ, AFNDKOFPEDG NMBCGMHEDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x2945AD0", Offset = "0x2944ED0", VA = "0x182945AD0", Slot = "8")]
	public void EHBDNPLCIKI(FDOJMOENJAL IOPMEPNDGKE, AFNDKOFPEDG IPDGCBIIEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x29469D0", Offset = "0x2945DD0", VA = "0x1829469D0", Slot = "9")]
	public void OAPBCJNJKMP(FDOJMOENJAL IOPMEPNDGKE, AFNDKOFPEDG IPDGCBIIEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x2946C40", Offset = "0x2946040", VA = "0x182946C40")]
	private void OPMPGPMKAEB(FDOJMOENJAL IOPMEPNDGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x29456B0", Offset = "0x2944AB0", VA = "0x1829456B0")]
	internal void DPAGHGHOADI(AMAKEGIKBFI HEAMCFPFNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x2945D00", Offset = "0x2945100", VA = "0x182945D00")]
	private void IJABAKBMNNM(AMAKEGIKBFI HEAMCFPFNOL, int DCJNJIADGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x2946760", Offset = "0x2945B60", VA = "0x182946760")]
	private void LKGLECFOIHB(KEJDGFDNFFK HAIJKGCOLFL, LFHCENHMBCH ENHHGLMHBMK, JCECIAEAKMG GEFIFDJJAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x2945490", Offset = "0x2944890", VA = "0x182945490")]
	private GHNKFGEDNOO AOMHGFOKKBD(KEJDGFDNFFK HAIJKGCOLFL, LFHCENHMBCH ENHHGLMHBMK)
	{
		return default(GHNKFGEDNOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x2946670", Offset = "0x2945A70", VA = "0x182946670")]
	private JCECIAEAKMG JMKJDAAMLEI(GHNKFGEDNOO HMNOECLMMGK, KEJDGFDNFFK HAIJKGCOLFL, LFHCENHMBCH ENHHGLMHBMK)
	{
		return default(JCECIAEAKMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x2946E20", Offset = "0x2946220", VA = "0x182946E20")]
	public DFIJJNIGPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal class KCJJCPPGLLI : DFCPJAAPILG
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	protected override NGLJBCFJFFJ BNNGAFLNGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x822D80", Offset = "0x822180", VA = "0x180822D80", Slot = "17")]
		get
		{
			return default(NGLJBCFJFFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A63A60", Offset = "0x2A62E60", VA = "0x182A63A60")]
	public KCJJCPPGLLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public class HGNPKDAMCFH : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[BurstCompile]
	private struct LNDAHCEICLN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		[ReadOnly]
		public ComponentTypeHandle<OADFAJIFNBN> GFNHGNACODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		[ReadOnly]
		public BufferTypeHandle<NCPPJPJLJPP> JDPCIFFDMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		[ReadOnly]
		public BufferFromEntity<NCPPJPJLJPP> PMHEKAFIMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		[ReadOnly]
		public ComponentDataFromEntity<OADFAJIFNBN> JLHBIBOKOLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public ComponentTypeHandle<LEIMONNOBFD> JKPNADLKMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<LEIMONNOBFD> CDFOEGJFNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public uint CDOBDMBCFLE;

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x27B9000", Offset = "0x27B8400", VA = "0x1827B9000", Slot = "4")]
		public void Execute(ArchetypeChunk DHCAFCLHBAO, int BNOAGGNAMKG, int JBHKGNDKFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x27B9300", Offset = "0x27B8700", VA = "0x1827B9300")]
		private void PEKALAMALPO(float4x4 FPBHBEHBOKB, Entity GKMECPLEALF, bool KGCNKIDPCBC, int NGPIKDPNLGJ = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery PBPCGONEOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private EntityQuery OLPIOOLJKJN;

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x28E6FA0", Offset = "0x28E63A0", VA = "0x1828E6FA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x28E70C0", Offset = "0x28E64C0", VA = "0x1828E70C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public HGNPKDAMCFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
[IICIJFGHOAB]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class NJNOHCHBGHL : NILFPPHEEJF, GMHONDBOJEM, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[BurstCompile]
	private struct LKJIHOCHONJ : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		[ReadOnly]
		public EntityTypeHandle LIAAOFFEIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		[ReadOnly]
		public ComponentTypeHandle<AIMKNIFBJLG> LGBDKPJHCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		[WriteOnly]
		public NativeList<IICPIKDEMDN>.ParallelWriter OOLBEJGGHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public ComponentTypeHandle<HDPPOKAAIMG> NLNAIDCOOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public float3 JNHEGOFDJBP;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private static readonly float4x2 MECBHAFIHAL;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static readonly float4x2 AFJOLNCEMDJ;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private static readonly int4x2 NHCLNLOLDNF;

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x27B8BA0", Offset = "0x27B7FA0", VA = "0x1827B8BA0", Slot = "4")]
		public void Execute(ArchetypeChunk DHCAFCLHBAO, int JGOFFILAMJM, int OLGOGAFHIIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private static EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private EntityQuery GBIMDKLCKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	private EntityQuery MIFGPKFJNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private double NBOBCGGPCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private LEHIKHOEAMN DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private FDDOEJHEPEH GFGMELPMDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private AHJMHEDKMKK FIFIJDGGGND;

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B230", Offset = "0x2A7A630", VA = "0x182A7B230", Slot = "14")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B5A0", Offset = "0x2A7A9A0", VA = "0x182A7B5A0", Slot = "15")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B630", Offset = "0x2A7AA30", VA = "0x182A7B630", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B780", Offset = "0x2A7AB80", VA = "0x182A7B780", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B530", Offset = "0x2A7A930", VA = "0x182A7B530")]
	private bool HJEBOEGNHOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B240", Offset = "0x2A7A640", VA = "0x182A7B240")]
	private void BDDLLFIBDCD(EntityQuery BEHDAMIMGBM, float3 CIIOCJNELBJ, string GDKOBCHHFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public NJNOHCHBGHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
[EPJIKDLNGEH(typeof(DOKFAOCNIFN), new string[] { })]
[ODFCLLMCKOH(typeof(CBPMCDKGJGE))]
public class EOFHNABNIDP : DOKFAOCNIFN, GMHONDBOJEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private readonly Dictionary<int, CMCADLOKOGK> KHMLHGBEBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	private readonly Dictionary<Type, CMCADLOKOGK> FBBGCMFLKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	private readonly Dictionary<Type, CMCADLOKOGK> DCODIPANADA;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public IReadOnlyCollection<CMCADLOKOGK> AELEPOEPMJP
	{
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x2957630", Offset = "0x2956A30", VA = "0x182957630", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x2957390", Offset = "0x2956790", VA = "0x182957390", Slot = "7")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x2957740", Offset = "0x2956B40", VA = "0x182957740", Slot = "6")]
	public CMCADLOKOGK KEHPFDBPLPI(Type GANFKPHKNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x29576D0", Offset = "0x2956AD0", VA = "0x1829576D0", Slot = "5")]
	public bool FKODLFANPKN(int DCJNJIADGPK, out CMCADLOKOGK OEGNIABGFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x2957680", Offset = "0x2956A80", VA = "0x182957680", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x29577C0", Offset = "0x2956BC0", VA = "0x1829577C0")]
	public EOFHNABNIDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal class LBDGHIIPAFI : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private HKKLACDDFPJ DOJPHKDLJHO;

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x2A65F50", Offset = "0x2A65350", VA = "0x182A65F50", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x2A65FA0", Offset = "0x2A653A0", VA = "0x182A65FA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x2A66050", Offset = "0x2A65450", VA = "0x182A66050", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x2A65A20", Offset = "0x2A64E20", VA = "0x182A65A20")]
	private void GGMEEGFIHML(NativeArray<Entity> NOEOKDNGNCK, NativeList<Entity> KHGEAFLMBAE, ComponentDataFromEntity<DCOFGBOLKBH> AKHBJOBAENN, BufferFromEntity<NCPPJPJLJPP> EGBKFJOOADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public LBDGHIIPAFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public class IENHBNCPAHL : NILFPPHEEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	private GJBAGKCKADE ICHBDANIEME;

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x28EB540", Offset = "0x28EA940", VA = "0x1828EB540", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x28EB610", Offset = "0x28EAA10", VA = "0x1828EB610", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public IENHBNCPAHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public static class FIIMIHHICDO
{
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly NGPJOPHOOLK KNGCKNHANNE;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly NGPJOPHOOLK GLMOKCDCNPP;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly NGPJOPHOOLK IHFOAAJCGDG;
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public class MAGOFDGFBAD : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[BurstCompile]
	private struct EDBELPAHEMB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		[ReadOnly]
		public ComponentTypeHandle<OKLGNNPGBAD> KGKHBLNACOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		[ReadOnly]
		public ComponentTypeHandle<HAGJKHAGDIE> KBKKOBPBLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		[ReadOnly]
		public ComponentTypeHandle<KIKJFGLKOHO> NNCHHILLOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public ComponentTypeHandle<OADFAJIFNBN> GDNDMJNKKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public uint CDOBDMBCFLE;

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x27B30F0", Offset = "0x27B24F0", VA = "0x1827B30F0", Slot = "4")]
		public void Execute(ArchetypeChunk DHCAFCLHBAO, int BNOAGGNAMKG, int JBHKGNDKFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x27B2FF0", Offset = "0x27B23F0", VA = "0x1827B2FF0")]
		public bool AMNIIBHEDHA(ArchetypeChunk DHCAFCLHBAO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private EntityQuery IIGHBGGPCLN;

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F2E0", Offset = "0x2A6E6E0", VA = "0x182A6F2E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F410", Offset = "0x2A6E810", VA = "0x182A6F410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public MAGOFDGFBAD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePoints : NILFPPHEEJF
	{
		[Cpp2IlInjected.Token(Token = "0x200014D")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			public ComponentDataFromEntity<ENDJAOGKOIP> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C040", Offset = "0x4C4B440", VA = "0x184C4C040", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C8B0", Offset = "0x4C4BCB0", VA = "0x184C4C8B0")]
			private void OPBILJIDNNC(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C780", Offset = "0x4C4BB80", VA = "0x184C4C780", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private EntityQuery PostDeserializeSortSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x248AC00", Offset = "0x248A000", VA = "0x18248AC00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x248A790", Offset = "0x2489B90", VA = "0x18248A790")]
		private void AEKEFLCDJOB(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x248A8C0", Offset = "0x2489CC0", VA = "0x18248A8C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PostDeserializeSortSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
public static class GKBNEPAKIAE
{
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public interface MELEMKFOOIC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface HIFHIPGNECO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public class FPLHNDMFLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public class OICOPJLGCFL : HIFHIPGNECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x27BB090", Offset = "0x27BA490", VA = "0x1827BB090")]
		public OICOPJLGCFL(ComponentType OIEACLJHHPB, ComponentType MAHPNNFCHBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public class FGEHFAGKNKE : HIFHIPGNECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2612FF0", Offset = "0x26123F0", VA = "0x182612FF0")]
		public FGEHFAGKNKE(ComponentType OIEACLJHHPB, ComponentType[] MAHPNNFCHBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public class JMHKCEOBLKK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x16DF510", Offset = "0x16DE910", VA = "0x1816DF510")]
	public static HIFHIPGNECO JKELMLILMEJ<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x16DF410", Offset = "0x16DE810", VA = "0x1816DF410")]
	public static HIFHIPGNECO FLIAEFAFKIB<TFrom>(params ComponentType[] ILPHELCGIDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[EPJIKDLNGEH(typeof(LFMJEINKAPC), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal sealed class LFMJEINKAPC : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private COKHJGJNDIB LGIGGJMIOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private OANPLLGCPAI LHOGJJGDLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2A69150", Offset = "0x2A68550", VA = "0x182A69150")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<FDJPAKEFOJE, NativeArray<IMPAOGMALJN>> OJINPMLFCEI
	{
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x2A687A0", Offset = "0x2A67BA0", VA = "0x182A687A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x2A68D70", Offset = "0x2A68170", VA = "0x182A68D70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<FDJPAKEFOJE> BKENOIEFKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2A693B0", Offset = "0x2A687B0", VA = "0x182A693B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2A68E10", Offset = "0x2A68210", VA = "0x182A68E10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(RVA = "0x2A69450", Offset = "0x2A68850", VA = "0x182A69450", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(RVA = "0x1133630", Offset = "0x1132A30", VA = "0x181133630", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000831")]
	[Cpp2IlInjected.Address(RVA = "0x2A69330", Offset = "0x2A68730", VA = "0x182A69330")]
	public bool HFDNCCJGOAI(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000832")]
	[Cpp2IlInjected.Address(RVA = "0x2A684D0", Offset = "0x2A678D0", VA = "0x182A684D0")]
	public void ADLMBBDHIJK(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(RVA = "0x2A69560", Offset = "0x2A68960", VA = "0x182A69560")]
	public void LPLHOIEAKPC(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0x2A691A0", Offset = "0x2A685A0", VA = "0x182A691A0")]
	private bool GLFAOJFHMBL(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x2A68840", Offset = "0x2A67C40", VA = "0x182A68840")]
	public void EHKLIGBABLK(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x2A68B50", Offset = "0x2A67F50", VA = "0x182A68B50")]
	private bool FGIGEHGFFBL(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0x2A68A40", Offset = "0x2A67E40", VA = "0x182A68A40")]
	public void FCGGIDBOLFJ(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x2A68D10", Offset = "0x2A68110", VA = "0x182A68D10")]
	private void FPLHICKIBGK(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000839")]
	[Cpp2IlInjected.Address(RVA = "0x2A68580", Offset = "0x2A67980", VA = "0x182A68580")]
	private void CEMHMHFHPHJ(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x2A69500", Offset = "0x2A68900", VA = "0x182A69500")]
	private void KEOHMNBELOH(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2A68EB0", Offset = "0x2A682B0", VA = "0x182A68EB0")]
	private void GEOFELAOGED(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2A695B0", Offset = "0x2A689B0", VA = "0x182A695B0")]
	public void PEOBLLIFNJH(FDJPAKEFOJE JCKPFMCHBED, NativeArray<IMPAOGMALJN> HGLHDDKIKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2A68510", Offset = "0x2A67910", VA = "0x182A68510")]
	public void BCHIOHFFDHF(FDJPAKEFOJE JCKPFMCHBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private void LKHNMJGNBPK(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2A69630", Offset = "0x2A68A30", VA = "0x182A69630")]
	private void PHEOGLDMGKN(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public LFMJEINKAPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
public class BJEAIDIMNMH : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private EntityQuery MJMBJPOMICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery GPDPOEGJNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private EntityQuery FOLDPLCLNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private EntityQuery HEGKBDODHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private COKHJGJNDIB GPPAHIAKNDH;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public int HIGNCADDICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x28FD770", Offset = "0x28FCB70", VA = "0x1828FD770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x28FD710", Offset = "0x28FCB10", VA = "0x1828FD710", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x28FDA00", Offset = "0x28FCE00", VA = "0x1828FDA00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x28FDC00", Offset = "0x28FD000", VA = "0x1828FDC00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x28FD7E0", Offset = "0x28FCBE0", VA = "0x1828FD7E0")]
	public int MJDIJOGFLFC(SceneTag PJOBCGNOOBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x28FDC20", Offset = "0x28FD020", VA = "0x1828FDC20")]
	protected void PAOCMBEIFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x28FD800", Offset = "0x28FCC00", VA = "0x1828FD800")]
	protected void MKKJGLGPBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0x28FD6C0", Offset = "0x28FCAC0", VA = "0x1828FD6C0")]
	public NativeArrayAsync<Entity> DLCJMMJKDJM(SceneTag PJOBCGNOOBP, Allocator DGGNDNPDKKD = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x28FD920", Offset = "0x28FCD20", VA = "0x1828FD920")]
	public NativeArrayAsync<Entity> NCLPMJKGDCC(SceneTag PJOBCGNOOBP, Allocator DGGNDNPDKKD = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600084B")]
	[Cpp2IlInjected.Address(RVA = "0x28FD970", Offset = "0x28FCD70", VA = "0x1828FD970")]
	public bool OGDHGJIJOHM(SceneTag PJOBCGNOOBP, out NativeArrayAsync<Entity> LGIGGJMIOOL, Allocator DGGNDNPDKKD = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x28FD5F0", Offset = "0x28FC9F0", VA = "0x1828FD5F0")]
	public bool CNIFBOMIGIC(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x28FD650", Offset = "0x28FCA50", VA = "0x1828FD650")]
	public bool DFFNJGBMJCN(Entity GKMECPLEALF, out OCNDKBGOCHB LGIGGJMIOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x28FD5B0", Offset = "0x28FC9B0", VA = "0x1828FD5B0")]
	public void CCFBHDDOLDM(Entity GKMECPLEALF, OCNDKBGOCHB LGIGGJMIOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x28FD780", Offset = "0x28FCB80", VA = "0x1828FD780")]
	public bool MAFFCAGEKAO(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public BJEAIDIMNMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
[EPJIKDLNGEH(typeof(MDPDEGLCMGA), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal sealed class MDPDEGLCMGA
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public enum FFCMIBNMJHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public struct EHADBKMEHJO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private FFCMIBNMJHC KDODHFPKNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private readonly MDPDEGLCMGA OJBGDMNECON;

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x27B3860", Offset = "0x27B2C60", VA = "0x1827B3860")]
		public EHADBKMEHJO(MDPDEGLCMGA OJBGDMNECON, FFCMIBNMJHC GMAFCCAHJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x27B3830", Offset = "0x27B2C30", VA = "0x1827B3830", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public FFCMIBNMJHC GMAFCCAHJCD;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public FFCMIBNMJHC MDFFCBODPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x81F160", Offset = "0x81E560", VA = "0x18081F160")]
		get
		{
			return default(FFCMIBNMJHC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x9C1170", Offset = "0x9C0570", VA = "0x1809C1170")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool HFGOICCNGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x1FFF6C0", Offset = "0x1FFEAC0", VA = "0x181FFF6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x2A702F0", Offset = "0x2A6F6F0", VA = "0x182A702F0")]
	public EHADBKMEHJO ADNGAKCIMED()
	{
		return default(EHADBKMEHJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x2A70320", Offset = "0x2A6F720", VA = "0x182A70320")]
	public EHADBKMEHJO KEOPLDDEFKO()
	{
		return default(EHADBKMEHJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x105E4F0", Offset = "0x105D8F0", VA = "0x18105E4F0")]
	public MDPDEGLCMGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal readonly struct OJFEGHECHFL
{
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private static readonly ProfilerMarker KFHNGFCGHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private readonly NILFPPHEEJF GDOFPEAGKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly World OKHCNMBCCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private readonly EntityQuery DLPMAGJIOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private readonly EntityQuery FOAHNPCGKED;

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x247FEE0", Offset = "0x247F2E0", VA = "0x18247FEE0")]
	public OJFEGHECHFL(NILFPPHEEJF GDOFPEAGKBE, World OKHCNMBCCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x247F900", Offset = "0x247ED00", VA = "0x18247F900")]
	public NativeArray<JDPNCHCMAIA> GLINDFMMGLK()
	{
		return default(NativeArray<JDPNCHCMAIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x247F890", Offset = "0x247EC90", VA = "0x18247F890")]
	public void FNFKDOKFNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x247FA10", Offset = "0x247EE10", VA = "0x18247FA10")]
	private NativeArray<JDPNCHCMAIA> NBOCHEIPFNJ(EntityQuery BEHDAMIMGBM)
	{
		return default(NativeArray<JDPNCHCMAIA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class EIDMFJMADGP : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x2952AC0", Offset = "0x2951EC0", VA = "0x182952AC0", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public EIDMFJMADGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal class HFENECCNNJF : LAOHLEGNFJB
{
	[Cpp2IlInjected.Token(Token = "0x6000861")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public HFENECCNNJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class LIMDFMEIHBA : LAOHLEGNFJB
{
	[Cpp2IlInjected.Token(Token = "0x6000862")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public LIMDFMEIHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct LNKBMNDCLBA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public int FKHPMLNOHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public int BLBNLGCJCGP;
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
public class OAKMEICDILB : ParentSystemBase<MJNEFILJOEE, FJFOKCMNCHF, PHKJDNACMEE>
{
	[Cpp2IlInjected.Token(Token = "0x6000863")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CCC0", Offset = "0x2A7C0C0", VA = "0x182A7CCC0", Slot = "14")]
	protected override EntityQueryDesc FPODJLPANIA(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000864")]
	[Cpp2IlInjected.Address(RVA = "0x944020", Offset = "0x943420", VA = "0x180944020", Slot = "15")]
	protected override EntityQueryDesc ECKKNPGPDKI(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CC80", Offset = "0x2A7C080", VA = "0x182A7CC80", Slot = "16")]
	protected override EntityQueryDesc FNMNPLHOFDJ(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CC40", Offset = "0x2A7C040", VA = "0x182A7CC40", Slot = "17")]
	protected override EntityQueryDesc EBDCDKHPHOA(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CD00", Offset = "0x2A7C100", VA = "0x182A7CD00")]
	public OAKMEICDILB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal class GKDHMHHDGJJ : LPMKPFADJKH
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected override NGPJOPHOOLK JCFDBPMPNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x28DEA90", Offset = "0x28DDE90", VA = "0x1828DEA90", Slot = "15")]
		get
		{
			return default(NGPJOPHOOLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x28DEB10", Offset = "0x28DDF10", VA = "0x1828DEB10")]
	public GKDHMHHDGJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
public sealed class EOJMFMCAAAB : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x29578B0", Offset = "0x2956CB0", VA = "0x1829578B0", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public EOJMFMCAAAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[ExecuteAlways]
public class JDKFBFECHOM : FDPFJCKHLML
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	public JDKFBFECHOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class FHPOHEKBHDF : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private EntityQuery EGCCHJMFEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private EntityQuery DCIMHHNOADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery KIAIDEHLPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private EntityQuery BNDBOGKDBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private KFDENICELLH DOJPHKDLJHO;

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x2963060", Offset = "0x2962460", VA = "0x182963060", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x2963190", Offset = "0x2962590", VA = "0x182963190", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x29633C0", Offset = "0x29627C0", VA = "0x1829633C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x2963120", Offset = "0x2962520", VA = "0x182963120")]
	private void NNFBEGDMHOD(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x29630B0", Offset = "0x29624B0", VA = "0x1829630B0")]
	private void LOBOHMPHNJE(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x2963350", Offset = "0x2962750", VA = "0x182963350", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x29634F0", Offset = "0x29628F0", VA = "0x1829634F0")]
	private void PBPDINCCFCM(EntityQuery BEHDAMIMGBM, bool BHEFCHPMIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public FHPOHEKBHDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
public sealed class HPDBHBADCJJ : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x28EA100", Offset = "0x28E9500", VA = "0x1828EA100", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public HPDBHBADCJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
[EPJIKDLNGEH(typeof(EHAENJFLFOL), new string[] { })]
internal sealed class EHAENJFLFOL : NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	private MDPDEGLCMGA NEDHMAOKAJD;

	[Cpp2IlInjected.Token(Token = "0x6000878")]
	[Cpp2IlInjected.Address(RVA = "0x2951050", Offset = "0x2950450", VA = "0x182951050", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000879")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EHAENJFLFOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal class IANCHGIEOED : IPNJFEEEFKG
{
	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	protected override NGPJOPHOOLK JCFDBPMPNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x28EA950", Offset = "0x28E9D50", VA = "0x1828EA950", Slot = "15")]
		get
		{
			return default(NGPJOPHOOLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600087B")]
	[Cpp2IlInjected.Address(RVA = "0x28EA9D0", Offset = "0x28E9DD0", VA = "0x1828EA9D0")]
	public IANCHGIEOED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
[EPJIKDLNGEH(typeof(HKJFJAJNFAP), new string[] { })]
internal class FDKFJEJGDMN : HKJFJAJNFAP, NEHPEGODEDF, BKHNPHMEICP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class PLNKOGDOBFH : IEnumerable<HEKFLAGDMLJ>, IEnumerable, IEnumerator<HEKFLAGDMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private HEKFLAGDMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private HEKFLAGDMLJ localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public HEKFLAGDMLJ <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public FDKFJEJGDMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private EntityManager <entityManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private LocalId <entity>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private DynamicBuffer<PHKJDNACMEE> <children>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private NativeArray<Entity> <childEntities>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private NativeArray<Entity> <childEntitiesCopy>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private NativeArray<Entity>.Enumerator <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private Entity <child>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		private HEKFLAGDMLJ System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x27B2480", Offset = "0x27B1880", VA = "0x1827B2480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HEKFLAGDMLJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x27BD600", Offset = "0x27BCA00", VA = "0x1827BD600", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public PLNKOGDOBFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x27BD650", Offset = "0x27BCA50", VA = "0x1827BD650", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x27BD180", Offset = "0x27BC580", VA = "0x1827BD180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x27BD4C0", Offset = "0x27BC8C0", VA = "0x1827BD4C0")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x27BD130", Offset = "0x27BC530", VA = "0x1827BD130")]
		private void MKCFKGNFONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x27BD5C0", Offset = "0x27BC9C0", VA = "0x1827BD5C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x27BD510", Offset = "0x27BC910", VA = "0x1827BD510", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HEKFLAGDMLJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x27BD510", Offset = "0x27BC910", VA = "0x1827BD510", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private static readonly EHKEPJIBENP GGBEGHPGCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private ODHMMPJEMFO DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	private DFIJJNIGPNA PEACADEJCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private DFGKOFELELE<Entity> IDHIALLNMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private DFGKOFELELE<float3> CMCAFDIOIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private DFGKOFELELE<quaternion> EFPEFMMPHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private DFGKOFELELE<float> KGJHOOIHANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private HashSet<Entity> OONFOHDPDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private HashSet<Entity> DFFFHCIDFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private EntityQuery CHKGOHBFCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Func<MPFACGKGBND> IHMIAOAOIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5D0", Offset = "0x8BD9D0", VA = "0x1808BE5D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x822D70", Offset = "0x822170", VA = "0x180822D70", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HEKFLAGDMLJ, HEKFLAGDMLJ> BJOHDIAEMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x2961950", Offset = "0x2960D50", VA = "0x182961950", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x2960D50", Offset = "0x2960150", VA = "0x182960D50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HEKFLAGDMLJ, HEKFLAGDMLJ> IPHHDBHFCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x2960000", Offset = "0x295F400", VA = "0x182960000", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x295FF60", Offset = "0x295F360", VA = "0x18295FF60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<HEKFLAGDMLJ, HEKFLAGDMLJ, HEKFLAGDMLJ> HNMEBPEEKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x29619F0", Offset = "0x2960DF0", VA = "0x1829619F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2962030", Offset = "0x2961430", VA = "0x182962030", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<HEKFLAGDMLJ> MLIDBNANFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x29613F0", Offset = "0x29607F0", VA = "0x1829613F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2960240", Offset = "0x295F640", VA = "0x182960240", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000886")]
	[Cpp2IlInjected.Address(RVA = "0x2960ED0", Offset = "0x29602D0", VA = "0x182960ED0", Slot = "26")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000887")]
	[Cpp2IlInjected.Address(RVA = "0x2961B50", Offset = "0x2960F50", VA = "0x182961B50", Slot = "27")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000888")]
	[Cpp2IlInjected.Address(RVA = "0x29603B0", Offset = "0x295F7B0", VA = "0x1829603B0", Slot = "28")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000889")]
	[Cpp2IlInjected.Address(RVA = "0x2961390", Offset = "0x2960790", VA = "0x182961390")]
	private void JDEPAOKKOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600088A")]
	[Cpp2IlInjected.Address(RVA = "0x2960BC0", Offset = "0x295FFC0", VA = "0x182960BC0")]
	private void FOENPBNLLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600088B")]
	[Cpp2IlInjected.Address(RVA = "0x29607B0", Offset = "0x295FBB0", VA = "0x1829607B0")]
	private void EHOKEPBHIJI(CNKGMANFGNC CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600088C")]
	[Cpp2IlInjected.Address(RVA = "0x295FE40", Offset = "0x295F240", VA = "0x18295FE40")]
	private void ALIJNHCLIBP(CNKGMANFGNC CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600088D")]
	[Cpp2IlInjected.Address(RVA = "0x1897050", Offset = "0x1896450", VA = "0x181897050", Slot = "14")]
	public Color JCOMMEPAIEL(HEKFLAGDMLJ LEMCMBEMOCB, int AKDCODMMCOP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600088E")]
	[Cpp2IlInjected.Address(RVA = "0x2961490", Offset = "0x2960890", VA = "0x182961490", Slot = "15")]
	public float3 LNLADOOOFAA(HEKFLAGDMLJ LEMCMBEMOCB, int AKDCODMMCOP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600088F")]
	[Cpp2IlInjected.Address(RVA = "0x2960DF0", Offset = "0x29601F0", VA = "0x182960DF0", Slot = "16")]
	public bool ILCNJPOOKDE(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ OOJNBAAADPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000890")]
	[Cpp2IlInjected.Address(RVA = "0x2960AC0", Offset = "0x295FEC0", VA = "0x182960AC0", Slot = "17")]
	public HEKFLAGDMLJ FJOAILPKGJI(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000891")]
	[Cpp2IlInjected.Address(RVA = "0x29600A0", Offset = "0x295F4A0", VA = "0x1829600A0", Slot = "20")]
	public void DBAKOAAEPOK(HEKFLAGDMLJ LEMCMBEMOCB, Vector3 IENBCOJMMMC, Quaternion OEHFJJBIAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000892")]
	[Cpp2IlInjected.Address(RVA = "0x2961A90", Offset = "0x2960E90", VA = "0x182961A90", Slot = "21")]
	public void NAPIGNIBENE(HEKFLAGDMLJ LEMCMBEMOCB, float DHHEBBKINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000893")]
	[Cpp2IlInjected.Address(RVA = "0x29602E0", Offset = "0x295F6E0", VA = "0x1829602E0", Slot = "24")]
	public float3 DHKCGKEJKJD(KBEIKKHCOLG AOGEOLMJAOJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000894")]
	[Cpp2IlInjected.Address(RVA = "0x29606F0", Offset = "0x295FAF0", VA = "0x1829606F0", Slot = "25")]
	public quaternion EFFJFOCKPJD(KBEIKKHCOLG AOGEOLMJAOJ)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x2961030", Offset = "0x2960430", VA = "0x182961030", Slot = "22")]
	public bool JANMMNONCHL(HEKFLAGDMLJ LEMCMBEMOCB, out RigidTransform IHDDGLAPAKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x2961210", Offset = "0x2960610", VA = "0x182961210", Slot = "23")]
	public bool JDCINEHHBAP(HEKFLAGDMLJ LEMCMBEMOCB, out float DHHEBBKINNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x29620D0", Offset = "0x29614D0", VA = "0x1829620D0", Slot = "18")]
	[IteratorStateMachine(typeof(PLNKOGDOBFH))]
	public IEnumerable<HEKFLAGDMLJ> OHCOKMJMLPG(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x29617D0", Offset = "0x2960BD0", VA = "0x1829617D0", Slot = "19")]
	public HEKFLAGDMLJ MBOBKDBNHKI(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x29616C0", Offset = "0x2960AC0", VA = "0x1829616C0")]
	private Entity MBOBKDBNHKI(Entity GKMECPLEALF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0x2962230", Offset = "0x2961630", VA = "0x182962230")]
	public FDKFJEJGDMN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : NILFPPHEEJF
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		[BurstCompile]
		[NoAlias]
		private struct PreSerializeDowngrade_RRObjectPrefabTypeData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			[ReadOnly]
			public SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunksRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			[ReadOnly]
			public NativeParallelHashMap<int, int> prefabTypeFromIndexRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public FHEOCFCLBBC.DKHHGNMFGPH<ArchetypeChunk, ALAFGKLDHDM<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public NativeList<LDPEKMBFPGE> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0x4C4EB00", Offset = "0x4C4DF00", VA = "0x184C4EB00")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x4C4EAF0", Offset = "0x4C4DEF0", VA = "0x184C4EAF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x2491AC0", Offset = "0x2490EC0", VA = "0x182491AC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x2491B50", Offset = "0x2490F50", VA = "0x182491B50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x24918B0", Offset = "0x2490CB0", VA = "0x1824918B0")]
		private EntityCommandBufferSystem MAIDFODBFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x2491700", Offset = "0x2490B00", VA = "0x182491700")]
		private JobHandle JNFMMHOJLPL(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, FHEOCFCLBBC.DKHHGNMFGPH<ArchetypeChunk, ALAFGKLDHDM<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<LDPEKMBFPGE> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2491900", Offset = "0x2490D00", VA = "0x182491900", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal struct ELCJDJGAIGE : LDJIGAKAEPB, IEquatable<ELCJDJGAIGE>
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public int FKHPMLNOHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public int BLBNLGCJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x176BAF0", Offset = "0x176AEF0", VA = "0x18176BAF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x2954C40", Offset = "0x2954040", VA = "0x182954C40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0x2954C50", Offset = "0x2954050", VA = "0x182954C50", Slot = "8")]
	public bool Equals(ELCJDJGAIGE ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B4")]
	[Cpp2IlInjected.Address(RVA = "0x2954CA0", Offset = "0x29540A0", VA = "0x182954CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[EPJIKDLNGEH(typeof(JFEOPDDGNAJ), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal sealed class JFEOPDDGNAJ : NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	[BOJGNOMIPCG]
	private MOAKKCGMOKH GBNCCFKGPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	[BOJGNOMIPCG]
	private PIKIKJOOODC NOKAFPBFFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	[BOJGNOMIPCG]
	private GGPOHFHPOPM OJMPJGNAJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	[BOJGNOMIPCG]
	private DEMPLIAGLNN PJGJLPEKIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	[BOJGNOMIPCG]
	private PIMNGKKLMII JLEPOMODEEP;

	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(RVA = "0x28F0590", Offset = "0x28EF990", VA = "0x1828F0590", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x28EFEC0", Offset = "0x28EF2C0", VA = "0x1828EFEC0")]
	public void BEGKLCGFGLD(NativeArray<IMPAOGMALJN> HGLHDDKIKCC, NativeArray<JDPNCHCMAIA> JJHDBMCJEFK, NativeArray<Entity> AMBAOGAFEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x28EFEB0", Offset = "0x28EF2B0", VA = "0x1828EFEB0")]
	public Entity BEGKLCGFGLD(IMPAOGMALJN JBGKOICMKNG, JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0x28F06F0", Offset = "0x28EFAF0", VA = "0x1828F06F0")]
	public Entity MAHAICGFPFA(IMPAOGMALJN JBGKOICMKNG, bool MBDCIOFDMHF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(RVA = "0x28F06E0", Offset = "0x28EFAE0", VA = "0x1828F06E0")]
	public Entity MAHAICGFPFA(IMPAOGMALJN JBGKOICMKNG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(RVA = "0x28F0370", Offset = "0x28EF770", VA = "0x1828F0370")]
	public Entity GIOEOGPFLEP()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x28F06A0", Offset = "0x28EFAA0", VA = "0x1828F06A0")]
	public Entity LEPFNPDPKPM(DJOJBOPMMAC GANFKPHKNKH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x28F0780", Offset = "0x28EFB80", VA = "0x1828F0780")]
	public FDJPAKEFOJE OHHBKCKEINJ(FDJPAKEFOJE HAMAKNIIOKD, Allocator DGGNDNPDKKD)
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0x28F0550", Offset = "0x28EF950", VA = "0x1828F0550")]
	public EntityArchetype IIHIBANPOIL(IMPAOGMALJN JBGKOICMKNG)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(RVA = "0x28F0680", Offset = "0x28EFA80", VA = "0x1828F0680")]
	public Entity JAGJFGHADMB(IMPAOGMALJN JBGKOICMKNG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0x28F02E0", Offset = "0x28EF6E0", VA = "0x1828F02E0")]
	private Entity EKNAJBGJLME(IMPAOGMALJN JBGKOICMKNG, bool MBDCIOFDMHF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C0")]
	[Cpp2IlInjected.Address(RVA = "0x28F00A0", Offset = "0x28EF4A0", VA = "0x1828F00A0")]
	private Entity EKNAJBGJLME(IMPAOGMALJN JBGKOICMKNG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C1")]
	[Cpp2IlInjected.Address(RVA = "0x28F0130", Offset = "0x28EF530", VA = "0x1828F0130")]
	private Entity EKNAJBGJLME(IMPAOGMALJN JBGKOICMKNG, JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C2")]
	[Cpp2IlInjected.Address(RVA = "0x28F07E0", Offset = "0x28EFBE0", VA = "0x1828F07E0")]
	private void PAOFNNOAKCG(IMPAOGMALJN JBGKOICMKNG, NativeArray<JDPNCHCMAIA> JJHDBMCJEFK, NativeArray<Entity> AMBAOGAFEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C3")]
	[Cpp2IlInjected.Address(RVA = "0x28F0380", Offset = "0x28EF780", VA = "0x1828F0380")]
	private void HJEEPAEIHCP(NativeArray<IMPAOGMALJN> HGLHDDKIKCC, NativeArray<JDPNCHCMAIA> JJHDBMCJEFK, NativeArray<Entity> AMBAOGAFEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public JFEOPDDGNAJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[IICIJFGHOAB]
	[CompilerGenerated]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : NILFPPHEEJF
	{
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x248A410", Offset = "0x2489810", VA = "0x18248A410", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x248A4A0", Offset = "0x24898A0", VA = "0x18248A4A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x248A200", Offset = "0x2489600", VA = "0x18248A200")]
		private EntityCommandBufferSystem MAIDFODBFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x248A250", Offset = "0x2489650", VA = "0x18248A250", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[ExecuteAlways]
public class GJBAGKCKADE : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
	public GJBAGKCKADE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(NBPNODCEBKF), new string[] { })]
internal class NBPNODCEBKF : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly SceneTag DJEMBCLDJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	[BOJGNOMIPCG]
	private EHLKKIDPCHN LDCEPPBCHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	[BOJGNOMIPCG]
	private COKHJGJNDIB LGIGGJMIOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	[BOJGNOMIPCG]
	private CEPHAKHFAFK NEJHPGNLCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	[BOJGNOMIPCG]
	private JEGMBOPKKDO BGKOAKBCHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	[BOJGNOMIPCG]
	private NAAJCDOIDBM LHMPCAFFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	private EntityQuery IANHDMAADOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private EntityQuery NAFDFHBODHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private EntityQuery CCOPKHDDJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private Entity MCPHKDKMNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public NativeArray<Entity> GHLKNAEHCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x9E5620", Offset = "0x9E4A20", VA = "0x1809E5620")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x9E4630", Offset = "0x9E3A30", VA = "0x1809E4630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public Entity HEIBBFJEHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A74C70", Offset = "0x2A74070", VA = "0x182A74C70")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public SceneTag JACPNDFJKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A742B0", Offset = "0x2A736B0", VA = "0x182A742B0")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Entity LMDCMNDMCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A742B0", Offset = "0x2A736B0", VA = "0x182A742B0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A74A90", Offset = "0x2A73E90", VA = "0x182A74A90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A74F40", Offset = "0x2A74340", VA = "0x182A74F40")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A750C0", Offset = "0x2A744C0", VA = "0x182A750C0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A749A0", Offset = "0x2A73DA0", VA = "0x182A749A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A74F00", Offset = "0x2A74300", VA = "0x182A74F00")]
	public void FPFNENGHAPJ(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A75200", Offset = "0x2A74600", VA = "0x182A75200")]
	public NativeArray<Entity> LDPLLONPMMI(Allocator DGGNDNPDKKD = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A74300", Offset = "0x2A73700", VA = "0x182A74300")]
	public void BJJPEKKAKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A741B0", Offset = "0x2A735B0", VA = "0x182A741B0")]
	public void AJDIFEMMLLI(Entity PJOBCGNOOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A749E0", Offset = "0x2A73DE0", VA = "0x182A749E0")]
	public Entity ECMHHJFGAND(string GDKOBCHHFLB = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A748C0", Offset = "0x2A73CC0", VA = "0x182A748C0")]
	public void DKIHIKJMBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A757E0", Offset = "0x2A74BE0", VA = "0x182A757E0")]
	public void OFNJDCENBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DD")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public void BGFCAHIKHHA(Entity PJOBCGNOOBP, string GDKOBCHHFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A74400", Offset = "0x2A73800", VA = "0x182A74400")]
	public void CBOPLPJPEPH(Entity PJOBCGNOOBP, bool KPLCIFPNLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A75410", Offset = "0x2A74810", VA = "0x182A75410")]
	public void NOEOIIHCINH(Entity GKMECPLEALF, Entity PJOBCGNOOBP, bool FKNCAIDPKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A75600", Offset = "0x2A74A00", VA = "0x182A75600")]
	public void NOEOIIHCINH(NativeArray<Entity> NOEOKDNGNCK, Entity PJOBCGNOOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A75230", Offset = "0x2A74630", VA = "0x182A75230")]
	private void MKFNCMDJDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A753E0", Offset = "0x2A747E0", VA = "0x182A753E0")]
	private void NHCGAFMKNCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A74C70", Offset = "0x2A74070", VA = "0x182A74C70")]
	private Entity LEDACPJOGHI()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A74510", Offset = "0x2A73910", VA = "0x182A74510")]
	private void DCNKDMIBLKH(EntityQuery FHOLCLCNNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A745E0", Offset = "0x2A739E0", VA = "0x182A745E0")]
	private void DCNKDMIBLKH(NativeArray<Entity> PFIBEKNCGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A74350", Offset = "0x2A73750", VA = "0x182A74350")]
	private void BPPFNAIHFCL(Entity PJOBCGNOOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A74F90", Offset = "0x2A74390", VA = "0x182A74F90")]
	private void IBPMJHCIJDL(Entity PJOBCGNOOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A74B00", Offset = "0x2A73F00", VA = "0x182A74B00")]
	private void EFIFBJAEFLC(SceneTag LFCPKOEFBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A751C0", Offset = "0x2A745C0", VA = "0x182A751C0")]
	private void JBFJNPMCNHL(SceneTag LFCPKOEFBPP, NativeParallelHashSet<int> OJJEHNMHGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A74D60", Offset = "0x2A74160", VA = "0x182A74D60")]
	private void FLKAJEJBEFH(SceneTag LFCPKOEFBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A748E0", Offset = "0x2A73CE0", VA = "0x182A748E0")]
	private void DNBJFLFBCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EC")]
	[Cpp2IlInjected.Address(RVA = "0x24013C0", Offset = "0x24007C0", VA = "0x1824013C0")]
	private void OECNBKEOHNL<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public NBPNODCEBKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class LDEBGDNPDLD : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private COKHJGJNDIB HJBFJMLNKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private KPNAFCNKGOC OJPBCBIFPOJ;

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A67760", Offset = "0x2A66B60", VA = "0x182A67760", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A677D0", Offset = "0x2A66BD0", VA = "0x182A677D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F1")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public LDEBGDNPDLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(GGPOHFHPOPM), new string[] { })]
internal sealed class GGPOHFHPOPM : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	[BOJGNOMIPCG]
	private MOAKKCGMOKH PINCKDHPPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	[BOJGNOMIPCG]
	private PIKIKJOOODC BINACICMOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private NativeParallelHashMap<JDPNCHCMAIA, Entity> HGAAHMGKCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	internal NativeParallelHashMap<JDPNCHCMAIA, Entity> LEMLIDJAPDF
	{
		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E60", Offset = "0xCE6260", VA = "0x180CE6E60")]
		get
		{
			return default(NativeParallelHashMap<JDPNCHCMAIA, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	internal uint KNPPCBBNICE
	{
		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x28DD6D0", Offset = "0x28DCAD0", VA = "0x1828DD6D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA3A860", Offset = "0xA39C60", VA = "0x180A3A860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x28DD830", Offset = "0x28DCC30", VA = "0x1828DD830", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x28DCFA0", Offset = "0x28DC3A0", VA = "0x1828DCFA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0x28DDCD0", Offset = "0x28DD0D0", VA = "0x1828DDCD0")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	[Cpp2IlInjected.Address(RVA = "0x28DD700", Offset = "0x28DCB00", VA = "0x1828DD700")]
	public JDPNCHCMAIA IMMKNGMAGMK(int FJFMKNIHPDJ)
	{
		return default(JDPNCHCMAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FA")]
	[Cpp2IlInjected.Address(RVA = "0x28DD960", Offset = "0x28DCD60", VA = "0x1828DD960")]
	public void JMOKBMHDEHP(JDPNCHCMAIA DDCHJBPICDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FB")]
	[Cpp2IlInjected.Address(RVA = "0x28DD170", Offset = "0x28DC570", VA = "0x1828DD170")]
	public HEKFLAGDMLJ FLILGDFALDL(JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0x28DD010", Offset = "0x28DC410", VA = "0x1828DD010")]
	public bool EHDJALGIOME(JDPNCHCMAIA DDCHJBPICDC, out HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0x28DD390", Offset = "0x28DC790", VA = "0x1828DD390")]
	public FDJPAKEFOJE FLILGDFALDL(NativeArray<JDPNCHCMAIA> DDCHJBPICDC, Allocator DGGNDNPDKKD)
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FE")]
	[Cpp2IlInjected.Address(RVA = "0x28DDB20", Offset = "0x28DCF20", VA = "0x1828DDB20")]
	public JDPNCHCMAIA NLIKCLIKHPF(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(JDPNCHCMAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x28DDC00", Offset = "0x28DD000", VA = "0x1828DDC00")]
	public JDPNCHCMAIA NLIKCLIKHPF(Entity GKMECPLEALF)
	{
		return default(JDPNCHCMAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0x28DD4F0", Offset = "0x28DC8F0", VA = "0x1828DD4F0")]
	public void GFACBFFKCOE(NativeArray<Entity> NOEOKDNGNCK, NativeArray<JDPNCHCMAIA> JJHDBMCJEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x28DCF50", Offset = "0x28DC350", VA = "0x1828DCF50")]
	private HEKFLAGDMLJ BIMEBDOPAGA(Entity GKMECPLEALF)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000902")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public GGPOHFHPOPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(JEGMBOPKKDO), new string[] { })]
internal sealed class JEGMBOPKKDO : NEHPEGODEDF, BKHNPHMEICP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	[BOJGNOMIPCG]
	private CEPHAKHFAFK NEJHPGNLCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private Entity GKMECPLEALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private ComponentTypeList OEBIFBLEMHJ;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x28EF5B0", Offset = "0x28EE9B0", VA = "0x1828EF5B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0x163CEE0", Offset = "0x163C2E0", VA = "0x18163CEE0")]
	public T PHGLOPEHIMO<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0x163CBE0", Offset = "0x163BFE0", VA = "0x18163CBE0")]
	public void AFLFAPDAOKF<T>(T AGLCIEKHLEE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0x163CCB0", Offset = "0x163C0B0", VA = "0x18163CCB0")]
	public DynamicBuffer<T> EEEABEBGIAE<T>(bool AIEFANFKBOM = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0x163CDB0", Offset = "0x163C1B0", VA = "0x18163CDB0")]
	public void OLBPKJNJEDJ<T>(T AGLCIEKHLEE) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000909")]
	[Cpp2IlInjected.Address(RVA = "0x28EF600", Offset = "0x28EEA00", VA = "0x1828EF600", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090A")]
	[Cpp2IlInjected.Address(RVA = "0x28EF310", Offset = "0x28EE710", VA = "0x1828EF310", Slot = "5")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0x28EF310", Offset = "0x28EE710", VA = "0x1828EF310")]
	private void ECCHNBPBHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x28EF060", Offset = "0x28EE460", VA = "0x1828EF060", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x28EECC0", Offset = "0x28EE0C0", VA = "0x1828EECC0")]
	private ComponentTypeList BOLMOPLGAMA()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void JHLKMMGMGLP(int FJFMKNIHPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void LPEKDLBOIEG(Type GANFKPHKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000910")]
	[Cpp2IlInjected.Address(RVA = "0x28EF4B0", Offset = "0x28EE8B0", VA = "0x1828EF4B0")]
	private static void EOOCMHLKNGF(Type GANFKPHKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000911")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public JEGMBOPKKDO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000174")]
[AIPCDKCBABC]
internal struct IJHCDKJGBND : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class NLHNNBIBPLH : NILFPPHEEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private EntityQuery AAGIJEEIGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	private EntityQuery FKGAFKEHGMP;

	[Cpp2IlInjected.Token(Token = "0x6000913")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BA40", Offset = "0x2A7AE40", VA = "0x182A7BA40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000914")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BB30", Offset = "0x2A7AF30", VA = "0x182A7BB30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000915")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public NLHNNBIBPLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[AOMCBLMBOHN]
public class DECKOGKPEKM : NILFPPHEEJF, GKBNEPAKIAE.MELEMKFOOIC
{
	[Cpp2IlInjected.Token(Token = "0x6000916")]
	[Cpp2IlInjected.Address(RVA = "0x2916770", Offset = "0x2915B70", VA = "0x182916770", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000917")]
	[Cpp2IlInjected.Address(RVA = "0x2916720", Offset = "0x2915B20", VA = "0x182916720")]
	private EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000918")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public DECKOGKPEKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
public class GJOFAFNBGMA : NILFPPHEEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x6000919")]
	[Cpp2IlInjected.Address(RVA = "0x28DE7C0", Offset = "0x28DDBC0", VA = "0x1828DE7C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091A")]
	[Cpp2IlInjected.Address(RVA = "0x28DE850", Offset = "0x28DDC50", VA = "0x1828DE850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091B")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public GJOFAFNBGMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[AlwaysUpdateSystem]
public class EPFJAKLLFHC : FDPFJCKHLML
{
	[Cpp2IlInjected.Token(Token = "0x600091C")]
	[Cpp2IlInjected.Address(RVA = "0x295B580", Offset = "0x295A980", VA = "0x18295B580", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091D")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	public EPFJAKLLFHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(KPNAFCNKGOC), new string[] { })]
internal class KPNAFCNKGOC : NEHPEGODEDF, BKHNPHMEICP, KHFJDJKGIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	internal readonly struct DEAIIBOHCOE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private readonly NGLJBCFJFFJ CNMJBJOBHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private readonly KPNAFCNKGOC DEMMAINGNBB;

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x27B1670", Offset = "0x27B0A70", VA = "0x1827B1670")]
		public DEAIIBOHCOE(KPNAFCNKGOC DEMMAINGNBB, NGLJBCFJFFJ PCIAGHEPMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x27B1650", Offset = "0x27B0A50", VA = "0x1827B1650", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private static readonly EHKEPJIBENP MMCHDOMGAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	[BOJGNOMIPCG]
	private DOKFAOCNIFN ILDIIFMLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	[BOJGNOMIPCG]
	private DEMPLIAGLNN PJGJLPEKIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private readonly HMNKGMHFPKI[] IEFNGEEOOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private LJPBJFAFPOA ALBPJGCMMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private NativeParallelHashMap<int, Entity> BMFMDNEJCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private NGLJBCFJFFJ BGLHKGHNALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public World HBDGJGALOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x2A65360", Offset = "0x2A64760", VA = "0x182A65360", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public World GLGFHNDCHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x8F8470", Offset = "0x8F7870", VA = "0x1808F8470", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x8CB0F0", Offset = "0x8CA4F0", VA = "0x1808CB0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public LJPBJFAFPOA MFHBJAMIFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x2A65260", Offset = "0x2A64660", VA = "0x182A65260", Slot = "8")]
		get
		{
			return default(LJPBJFAFPOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public uint CDOBDMBCFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0xD282C0", Offset = "0xD276C0", VA = "0x180D282C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xD280A0", Offset = "0xD274A0", VA = "0x180D280A0", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private bool KHCEPFDCLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xD28090", Offset = "0xD27490", VA = "0x180D28090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0xA48720", Offset = "0xA47B20", VA = "0x180A48720", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public NativeParallelHashMap<int, Entity> CAGJLANJEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2A65200", Offset = "0x2A64600", VA = "0x182A65200")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public AMAKEGIKBFI LFNCEMFGHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2A65180", Offset = "0x2A64580", VA = "0x182A65180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public JCEINDAJIBO MLKHPPKECLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2A65180", Offset = "0x2A64580", VA = "0x182A65180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public NGLJBCFJFFJ MDFFCBODPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x97BD50", Offset = "0x97B150", VA = "0x18097BD50")]
		get
		{
			return default(NGLJBCFJFFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2A651C0", Offset = "0x2A645C0", VA = "0x182A651C0")]
	public AMAKEGIKBFI IJLDNPINEMI(NGLJBCFJFFJ GMAFCCAHJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x2A651C0", Offset = "0x2A645C0", VA = "0x182A651C0")]
	public JCEINDAJIBO EBFBNPGMPOP(NGLJBCFJFFJ GMAFCCAHJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600092C")]
	[Cpp2IlInjected.Address(RVA = "0x2A65290", Offset = "0x2A64690", VA = "0x182A65290", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092D")]
	[Cpp2IlInjected.Address(RVA = "0x2A65620", Offset = "0x2A64A20", VA = "0x182A65620", Slot = "5")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092E")]
	[Cpp2IlInjected.Address(RVA = "0x2A653B0", Offset = "0x2A647B0", VA = "0x182A653B0")]
	private NativeParallelHashMap<int, Entity> MOCFEMHHJCO()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600092F")]
	[Cpp2IlInjected.Address(RVA = "0x2A65210", Offset = "0x2A64610", VA = "0x182A65210")]
	public void FIBBHFEFHAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000930")]
	[Cpp2IlInjected.Address(RVA = "0x2A65890", Offset = "0x2A64C90", VA = "0x182A65890")]
	public void PDPMCCCKLBI(NGLJBCFJFFJ GMAFCCAHJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000931")]
	[Cpp2IlInjected.Address(RVA = "0x2A657C0", Offset = "0x2A64BC0", VA = "0x182A657C0")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000932")]
	[Cpp2IlInjected.Address(RVA = "0x2A65060", Offset = "0x2A64460", VA = "0x182A65060", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000933")]
	[Cpp2IlInjected.Address(RVA = "0x2A65600", Offset = "0x2A64A00", VA = "0x182A65600")]
	public DEAIIBOHCOE NFFPIGHAPAO(NGLJBCFJFFJ GMAFCCAHJCD)
	{
		return default(DEAIIBOHCOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000934")]
	[Cpp2IlInjected.Address(RVA = "0x2A659B0", Offset = "0x2A64DB0", VA = "0x182A659B0")]
	public KPNAFCNKGOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class LEKJLPAPNDE : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private EntityQuery LPNJBBLGDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	private KNNCGINAGFA GBFJPPHEION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	private FEEKAOBEJNL BFDACLEBABK;

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x2A67B60", Offset = "0x2A66F60", VA = "0x182A67B60", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x2A67BF0", Offset = "0x2A66FF0", VA = "0x182A67BF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x2A67C90", Offset = "0x2A67090", VA = "0x182A67C90", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public LEKJLPAPNDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[IICIJFGHOAB]
public class PNGCEJPDOMN : CCBLHMCLOCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x2488A10", Offset = "0x2487E10", VA = "0x182488A10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x2488AC0", Offset = "0x2487EC0", VA = "0x182488AC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x24889C0", Offset = "0x2487DC0", VA = "0x1824889C0")]
	private EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public PNGCEJPDOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public class MPEPDEFAJFO : CCBLHMCLOCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x2A73680", Offset = "0x2A72A80", VA = "0x182A73680", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0x2A73630", Offset = "0x2A72A30", VA = "0x182A73630")]
	private EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public MPEPDEFAJFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public struct OCPDMAFPMAF<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private GCHandle PAHMPOAEKCN;

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x23D53D0", Offset = "0x23D47D0", VA = "0x1823D53D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
[AOMCBLMBOHN]
public class JIHHDJLLAMB : NILFPPHEEJF, GKBNEPAKIAE.MELEMKFOOIC
{
	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x28F7250", Offset = "0x28F6650", VA = "0x1828F7250", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x28F7200", Offset = "0x28F6600", VA = "0x1828F7200")]
	private EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public JIHHDJLLAMB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIds : NILFPPHEEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x24927F0", Offset = "0x2491BF0", VA = "0x1824927F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x2492880", Offset = "0x2491C80", VA = "0x182492880", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x24925E0", Offset = "0x24919E0", VA = "0x1824925E0")]
		private EntityCommandBufferSystem FFDPBBPOCGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x2492630", Offset = "0x2491A30", VA = "0x182492630", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PreSerializeSaveNetworkIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[AlwaysUpdateSystem]
public class MCAKCNCOLKA : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x2A6FA30", Offset = "0x2A6EE30", VA = "0x182A6FA30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public MCAKCNCOLKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[IICIJFGHOAB]
[BOFOINMHPHO(FGCKLJIPPNH.OMRoom)]
public class FDMPPIOKGCK : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private FOODIHPHGKA ANNIKNAGBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private NBPNODCEBKF PFIBEKNCGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x29622E0", Offset = "0x29616E0", VA = "0x1829622E0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x2962350", Offset = "0x2961750", VA = "0x182962350", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x29623F0", Offset = "0x29617F0", VA = "0x1829623F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public FDMPPIOKGCK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	internal class SplinePointOrderingUpdateSystem : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile]
		private struct UpdateSplineIndexJob : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			[ReadOnly]
			public NativeArray<global::CJGIDBLNKDB> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			[ReadOnly]
			public ComponentDataFromEntity<OPILEFNOLAG> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			public ComponentDataFromEntity<ENDJAOGKOIP> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0x4C53250", Offset = "0x4C52650", VA = "0x184C53250", Slot = "4")]
			public void Execute(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000186")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			[ReadOnly]
			public ComponentDataFromEntity<ENDJAOGKOIP> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0x4C4BFC0", Offset = "0x4C4B3C0", VA = "0x184C4BFC0", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000187")]
		[NoAlias]
		[BurstCompile]
		private struct SplinePointOrderingUpdateSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x4C51D40", Offset = "0x4C51140", VA = "0x184C51D40")]
			private void OPBILJIDNNC(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0x4C51C10", Offset = "0x4C51010", VA = "0x184C51C10", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		[BOJGNOMIPCG]
		private JEGMBOPKKDO singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x2494FA0", Offset = "0x24943A0", VA = "0x182494FA0", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x24953A0", Offset = "0x24947A0", VA = "0x1824953A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x2494AD0", Offset = "0x2493ED0", VA = "0x182494AD0")]
		private void HGODBEPCJLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x2494970", Offset = "0x2493D70", VA = "0x182494970")]
		private void ENHMPLCLGKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x2494FF0", Offset = "0x24943F0", VA = "0x182494FF0")]
		private static EEICHPGJODP LGBKPPNHMGB(int insertionIndex, ComponentDataFromEntity<ENDJAOGKOIP> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(EEICHPGJODP);
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x2494E60", Offset = "0x2494260", VA = "0x182494E60")]
		private JobHandle IKEBNIOPKPA(OrderComparer comparer, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x2495150", Offset = "0x2494550", VA = "0x182495150", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	public class UpdateMassOfShapes : NILFPPHEEJF
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		[NoAlias]
		private struct UpdateMassOfShapes_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			[ReadOnly]
			public ComponentDataFromEntity<HAGJKHAGDIE> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			[ReadOnly]
			public ComponentDataFromEntity<PODMOPJDKIH> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			[ReadOnly]
			public ComponentDataFromEntity<MFFCMBGAGGG> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			[ReadOnly]
			public ComponentDataFromEntity<AAPPBDIJGNP> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			[ReadOnly]
			public ComponentDataFromEntity<KIKJFGLKOHO> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			public ComponentDataFromEntity<MFNPNAGNGGD> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			public ComponentDataFromEntity<CABAKAOCBGH> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0x4C52CC0", Offset = "0x4C520C0", VA = "0x184C52CC0")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0x4C52CB0", Offset = "0x4C520B0", VA = "0x184C52CB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x249C830", Offset = "0x249BC30", VA = "0x18249C830", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x249C960", Offset = "0x249BD60", VA = "0x18249C960", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x249C340", Offset = "0x249B740", VA = "0x18249C340")]
		private void DOFDOECGEEB(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x249C650", Offset = "0x249BA50", VA = "0x18249C650")]
		private JobHandle FJDGMMHKBMO(NativeList<Entity> entities, ComponentDataFromEntity<HAGJKHAGDIE> worldDeformableScalesRO, ComponentDataFromEntity<PODMOPJDKIH> worldUniformScalesRO, ComponentDataFromEntity<MFFCMBGAGGG> physicsMaterialsRO, ComponentDataFromEntity<AAPPBDIJGNP> primitiveShapesRO, ComponentDataFromEntity<KIKJFGLKOHO> localUniformScalesRO, ComponentDataFromEntity<MFNPNAGNGGD> massesRW, ComponentDataFromEntity<CABAKAOCBGH> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public UpdateMassOfShapes()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct GIKJCKEFOIO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
public class AJNFMBOFKOM : EGPDILJJNOF
{
	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x28FB630", Offset = "0x28FAA30", VA = "0x1828FB630", Slot = "14")]
	protected override EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x2488DF0", Offset = "0x24881F0", VA = "0x182488DF0")]
	public AJNFMBOFKOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class KCJEADEFJBB : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private HKKLACDDFPJ DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private EntityQuery LIHILMCCCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private EntityQuery DGLFKNPPKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private EntityQuery BNDBOGKDBHI;

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0x2A62FB0", Offset = "0x2A623B0", VA = "0x182A62FB0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x2A63510", Offset = "0x2A62910", VA = "0x182A63510", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(RVA = "0x2A63690", Offset = "0x2A62A90", VA = "0x182A63690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2A63660", Offset = "0x2A62A60", VA = "0x182A63660", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000975")]
	[Cpp2IlInjected.Address(RVA = "0x2A63020", Offset = "0x2A62420", VA = "0x182A63020")]
	private void JKHPBCNNGMB(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x2A63360", Offset = "0x2A62760", VA = "0x182A63360")]
	private void KCMFHLAOIKL(NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x2A62CB0", Offset = "0x2A620B0", VA = "0x182A62CB0")]
	private void EHFEBKGDBJL(NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x2A63810", Offset = "0x2A62C10", VA = "0x182A63810")]
	private void PPAFCGOMFDJ(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x2A62AA0", Offset = "0x2A61EA0", VA = "0x182A62AA0")]
	private void AAINKBCDEOH(NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x2A636D0", Offset = "0x2A62AD0", VA = "0x182A636D0")]
	private void PNEGDOMJBLE(HEKFLAGDMLJ LEMCMBEMOCB, int GAAPLDCPBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public KCJEADEFJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[ODFCLLMCKOH(typeof(CBPMCDKGJGE))]
[EPJIKDLNGEH(typeof(FCPFIHPBBHN), new string[] { })]
public class DCCOMFOJKIB : FCPFIHPBBHN, GMHONDBOJEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private static readonly Dictionary<int, int> HMODPCKEEBG;

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x2914CD0", Offset = "0x29140D0", VA = "0x182914CD0", Slot = "5")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x2914FB0", Offset = "0x29143B0", VA = "0x182914FB0", Slot = "4")]
	public int LENCHPICOIF(int DCJNJIADGPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x2914F30", Offset = "0x2914330", VA = "0x182914F30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public DCCOMFOJKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[EPJIKDLNGEH(typeof(EPICOOKCMFM), new string[] { })]
public class LPKNOGDMJJE : NEHPEGODEDF, BKHNPHMEICP, EPICOOKCMFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class DHLGCNNGPML : IEnumerable<HEKFLAGDMLJ>, IEnumerable, IEnumerator<HEKFLAGDMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private HEKFLAGDMLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private HEKFLAGDMLJ splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public HEKFLAGDMLJ <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public LPKNOGDMJJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private NativeArray<Entity> <children>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		private HEKFLAGDMLJ System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x27B2480", Offset = "0x27B1880", VA = "0x1827B2480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HEKFLAGDMLJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x27B24E0", Offset = "0x27B18E0", VA = "0x1827B24E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x9C1680", Offset = "0x9C0A80", VA = "0x1809C1680")]
		[DebuggerHidden]
		public DHLGCNNGPML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x27B22E0", Offset = "0x27B16E0", VA = "0x1827B22E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x27B24A0", Offset = "0x27B18A0", VA = "0x1827B24A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x27B23D0", Offset = "0x27B17D0", VA = "0x1827B23D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HEKFLAGDMLJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x27B23D0", Offset = "0x27B17D0", VA = "0x1827B23D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private DOKFAOCNIFN ILDIIFMLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private JFEOPDDGNAJ PJGJLPEKIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private LFMJEINKAPC BHEMNPHLEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private JEGMBOPKKDO PHLDDLGGOJM;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E070", Offset = "0x2A6D470", VA = "0x182A6E070")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E2C0", Offset = "0x2A6D6C0", VA = "0x182A6E2C0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DFF0", Offset = "0x2A6D3F0", VA = "0x182A6DFF0")]
	private void GCDGJGDCPHF(Entity HOCJOMLKNGE, int BNOAGGNAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DE30", Offset = "0x2A6D230", VA = "0x182A6DE30", Slot = "10")]
	public void DJFCEKBBKAL(HEKFLAGDMLJ LEMCMBEMOCB, MGFBLKCEIKC NPOLKGPPPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x2A6ECC0", Offset = "0x2A6E0C0", VA = "0x182A6ECC0", Slot = "9")]
	public MGFBLKCEIKC PPDECOCGBPD(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(MGFBLKCEIKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E670", Offset = "0x2A6DA70", VA = "0x182A6E670", Slot = "11")]
	public HEKFLAGDMLJ LBCACPHOJKL(HEKFLAGDMLJ KKAFGGAMJPO, [Optional] float3? FGLOAKJBDBO, [Optional] quaternion? OCEJJKMFIJB, [Optional] float3? ECOCGLBAPIP)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DD80", Offset = "0x2A6D180", VA = "0x182A6DD80", Slot = "12")]
	public HEKFLAGDMLJ CNLNBFIICKK(HEKFLAGDMLJ KKAFGGAMJPO, int BNOAGGNAMKG, [Optional] float3? FGLOAKJBDBO, [Optional] quaternion? OCEJJKMFIJB, [Optional] float3? ECOCGLBAPIP)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E3B0", Offset = "0x2A6D7B0", VA = "0x182A6E3B0")]
	private HEKFLAGDMLJ KHCOHMIJDLB(HEKFLAGDMLJ KKAFGGAMJPO, int BNOAGGNAMKG, [Optional] float3? FGLOAKJBDBO, [Optional] quaternion? OCEJJKMFIJB, [Optional] float3? ECOCGLBAPIP)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DC20", Offset = "0x2A6D020", VA = "0x182A6DC20", Slot = "7")]
	public HEKFLAGDMLJ BPOEDPNLICI(HEKFLAGDMLJ KKAFGGAMJPO, int BNOAGGNAMKG)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E720", Offset = "0x2A6DB20", VA = "0x182A6E720", Slot = "16")]
	public void MJEFGIJGCMJ(HEKFLAGDMLJ KKAFGGAMJPO, HEKFLAGDMLJ HOCJOMLKNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E0C0", Offset = "0x2A6D4C0", VA = "0x182A6E0C0", Slot = "13")]
	public void IFHJGGIJKAH(HEKFLAGDMLJ KKAFGGAMJPO, int BNOAGGNAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E880", Offset = "0x2A6DC80", VA = "0x182A6E880", Slot = "14")]
	public void OCJFGDHJIOC(HEKFLAGDMLJ KKAFGGAMJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DF10", Offset = "0x2A6D310", VA = "0x182A6DF10", Slot = "8")]
	public int FIBJAKKEOHC(HEKFLAGDMLJ KKAFGGAMJPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E7F0", Offset = "0x2A6DBF0", VA = "0x182A6E7F0", Slot = "6")]
	[IteratorStateMachine(typeof(DHLGCNNGPML))]
	public IEnumerable<HEKFLAGDMLJ> NFAKONJLIID(HEKFLAGDMLJ KKAFGGAMJPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EBE0", Offset = "0x2A6DFE0", VA = "0x182A6EBE0")]
	private bool PNMFIFENECM(HEKFLAGDMLJ KKAFGGAMJPO, out NativeArray<Entity> LEGMMMPKLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public LPKNOGDMJJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[AlwaysUpdateSystem]
public class OONENFNKEAJ : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x24825C0", Offset = "0x24819C0", VA = "0x1824825C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099D")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public OONENFNKEAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
internal class GIFPBAKGHNN : DKFENIMBODI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	public struct LIAFBNJHJCK : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	protected override ComponentType OKLPIHFJNJO
	{
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x28DDE40", Offset = "0x28DD240", VA = "0x1828DDE40", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	protected override ComponentType OMNLNLCFBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x28DDDE0", Offset = "0x28DD1E0", VA = "0x1828DDDE0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	protected override ComponentType LOJAJIIODNP
	{
		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x28DDE10", Offset = "0x28DD210", VA = "0x1828DDE10", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099E")]
	[Cpp2IlInjected.Address(RVA = "0x28DDF00", Offset = "0x28DD300", VA = "0x1828DDF00")]
	public GIFPBAKGHNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class NOGIJEOIHNC : NILFPPHEEJF, BKHNPHMEICP
{
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private NJNJAPPDECP GGAOKDLNNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private NFCKPDCDELJ CLAOAKAOJHH;

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A67C90", Offset = "0x2A67090", VA = "0x182A67C90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C040", Offset = "0x2A7B440", VA = "0x182A7C040", Slot = "14")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C200", Offset = "0x2A7B600", VA = "0x182A7C200", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BEC0", Offset = "0x2A7B2C0", VA = "0x182A7BEC0")]
	private static void GILGKGALPFD(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, Entity OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BE20", Offset = "0x2A7B220", VA = "0x182A7BE20")]
	private static bool DAJCKLBFICP(EntityManager BEBIJONEMLA, Entity GKMECPLEALF, out Transform DKKDEHMFAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public NOGIJEOIHNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public struct JEDNPGEGKOA<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private OFDCNLDBOIC<T> LJJHJABONIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private EntityCommandBuffer JNKKDKMNHPP;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public OFDCNLDBOIC<T> ADOIFKGELEE
	{
		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x176B940", Offset = "0x176AD40", VA = "0x18176B940")]
		get
		{
			return default(OFDCNLDBOIC<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x1317080", Offset = "0x1316480", VA = "0x181317080")]
	public JEDNPGEGKOA(OFDCNLDBOIC<T> LJJHJABONIO, EntityCommandBuffer JNKKDKMNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B93170", Offset = "0x2B92570", VA = "0x182B93170")]
	public void GDPBCACCHMJ(NGGLHMEMLAF<T> DGGFKEMHDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B92C70", Offset = "0x2B92070", VA = "0x182B92C70", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x1317060", Offset = "0x1316460", VA = "0x181317060")]
	public static OFDCNLDBOIC<T> LFFBPOODCDC(JEDNPGEGKOA<T> GFDOPOBNKBA)
	{
		return default(OFDCNLDBOIC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public class OCNDKBGOCHB : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public KINEJENHFEI LGIGGJMIOOL;

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public OCNDKBGOCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	public OCNDKBGOCHB(KINEJENHFEI LGIGGJMIOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0x247DBB0", Offset = "0x247CFB0", VA = "0x18247DBB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	[AOMCBLMBOHN]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : GJPGACKBJOK
	{
		[Cpp2IlInjected.Token(Token = "0x2000197")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			public MHDFJIJCFFB<CNMPOKOKCIB> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public DBDPDMBEOFD<LNFKIFAJNMB> v1;

			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x4C4DA80", Offset = "0x4C4CE80", VA = "0x184C4DA80")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x4C4DA70", Offset = "0x4C4CE70", VA = "0x184C4DA70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		protected override EHKEPJIBENP Log
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x248DEE0", Offset = "0x248D2E0", VA = "0x18248DEE0", Slot = "14")]
			get
			{
				return default(EHKEPJIBENP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x248DE20", Offset = "0x248D220", VA = "0x18248DE20", Slot = "15")]
		public override IEnumerable<GKBNEPAKIAE.HIFHIPGNECO> DJGCEJKFFPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x248DF40", Offset = "0x248D340", VA = "0x18248DF40", Slot = "16")]
		protected override void GHEFEAJKGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x248E0B0", Offset = "0x248D4B0", VA = "0x18248E0B0")]
		private JobHandle NGFNGNHOPEH(MHDFJIJCFFB<CNMPOKOKCIB> v0, DBDPDMBEOFD<LNFKIFAJNMB> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x2488DF0", Offset = "0x24881F0", VA = "0x182488DF0")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
[AlwaysUpdateSystem]
internal class BIBBGFDMJMO : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public BIBBGFDMJMO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentData : CCBLHMCLOCJ, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x200019A")]
		private struct DebugPostLoadValidateParentData_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			public DebugPostLoadValidateParentData __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			[ReadOnly]
			public ComponentTypeHandle<EODNMPFLBLP> __parentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0x27B2D90", Offset = "0x27B2190", VA = "0x1827B2D90")]
			private void OPBILJIDNNC(Entity entity, in EODNMPFLBLP parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C4")]
			[Cpp2IlInjected.Address(RVA = "0x27B2C70", Offset = "0x27B2070", VA = "0x1827B2C70", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private IMBCAHJKJCI objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private EntityQuery DebugPostLoadValidateParentData_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private ComponentTypeHandle<EODNMPFLBLP> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x294ECE0", Offset = "0x294E0E0", VA = "0x18294ECE0", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x294ED40", Offset = "0x294E140", VA = "0x18294ED40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x294ED40", Offset = "0x294E140", VA = "0x18294ED40")]
		private void JGFLEHJJGIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x294EE20", Offset = "0x294E220", VA = "0x18294EE20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public DebugPostLoadValidateParentData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x294EA90", Offset = "0x294DE90", VA = "0x18294EA90")]
		[CompilerGenerated]
		private void AJFKJPFENJG(Entity entity, in EODNMPFLBLP parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal class KJJODKCKEJJ : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private object CONEEGIKPHA;

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A63EF0", Offset = "0x2A632F0", VA = "0x182A63EF0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A63F70", Offset = "0x2A63370", VA = "0x182A63F70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A64010", Offset = "0x2A63410", VA = "0x182A64010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public KJJODKCKEJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
[BurstCompatible]
internal readonly struct IPMKALHJAGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private readonly EKIJOGFFHLI ECFHAHDOLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private readonly AOILHOBPGBG ADBMAPOIAEC;

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xAEEC80", Offset = "0xAEE080", VA = "0x180AEEC80")]
	public IPMKALHJAGB(EKIJOGFFHLI ECFHAHDOLOJ, AOILHOBPGBG ADBMAPOIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x28ECC10", Offset = "0x28EC010", VA = "0x1828ECC10")]
	public bool FOPKBACCHIA(IPMKALHJAGB OJBGDMNECON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x28ECC10", Offset = "0x28EC010", VA = "0x1828ECC10")]
	public bool KOIGLPHEHLI(IPMKALHJAGB KEGFIDMGBNO)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	public class CalculateContainerCollisionIslandGraphChangesSystem : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x200019E")]
		[BurstCompile]
		private struct FindChangedIslandsJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			[ReadOnly]
			public EntityQueryInJob deletedConnectablesQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			[ReadOnly]
			public EntityQueryInJob changedIslandQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			[ReadOnly]
			public EntityQueryInJob hierarchyChangeQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			[ReadOnly]
			public EntityQueryInJob newRootsQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			[ReadOnly]
			public ChunkFilterAnyOf2ComponentsChanged islandSplitChangeFilterRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			[ReadOnly]
			public ComponentTypeHandle<NDOFDMPLNDB> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			[ReadOnly]
			public ComponentDataFromEntity<LFKJHHMKPGF> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			[ReadOnly]
			public ComponentDataFromEntity<EKIJOGFFHLI> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			[ReadOnly]
			public ComponentDataFromEntity<AOILHOBPGBG> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			[ReadOnly]
			public ComponentDataFromEntity<NACBJGKILAP> containerCollisionIslandRootTagRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			[ReadOnly]
			public ComponentDataFromEntity<EODNMPFLBLP> parentRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			[ReadOnly]
			public BufferFromEntity<NCPPJPJLJPP> childrenRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			[WriteOnly]
			public NativeList<Entity> changedIslandComponentsBufferWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			[WriteOnly]
			public NativeList<GOJJIKKHBCG> changedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			[WriteOnly]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			[WriteOnly]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			public ComponentDataFromEntity<JJKAHCIIMPM> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x27B3D40", Offset = "0x27B3140", VA = "0x1827B3D40", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x27B45E0", Offset = "0x27B39E0", VA = "0x1827B45E0")]
			private void LFNKPKAAKCP(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x27B4480", Offset = "0x27B3880", VA = "0x1827B4480")]
			private Entity KDPHHEPPNOD(Entity curEntity, IPMKALHJAGB classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0x27B3C70", Offset = "0x27B3070", VA = "0x1827B3C70")]
			private bool BNFFLHDOCDG(Entity curEntity, IPMKALHJAGB classifier, out Entity parentEntity, out IPMKALHJAGB parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x27B43B0", Offset = "0x27B37B0", VA = "0x1827B43B0")]
			private void INMLJMHEJNJ(Entity islandRoot, IPMKALHJAGB classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x27B47A0", Offset = "0x27B3BA0", VA = "0x1827B47A0")]
			private void LMBPBFDEIBN(Entity islandRoot, Entity entity, IPMKALHJAGB classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x27B4500", Offset = "0x27B3900", VA = "0x1827B4500")]
			private void LALFNBFAOHH(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009DB")]
			[Cpp2IlInjected.Address(RVA = "0x27B49A0", Offset = "0x27B3DA0", VA = "0x1827B49A0")]
			private bool MBEBIDKGOLL(Entity entity, out IPMKALHJAGB classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009DC")]
			[Cpp2IlInjected.Address(RVA = "0x27B3BD0", Offset = "0x27B2FD0", VA = "0x1827B3BD0")]
			private IPMKALHJAGB AAGABFPOEGC(Entity entity)
			{
				return default(IPMKALHJAGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200019F")]
		[NoAlias]
		[BurstCompile]
		private struct CalculateContainerCollisionIslandGraphChangesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			[ReadOnly]
			public EntityTypeHandle entityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0x27B1070", Offset = "0x27B0470", VA = "0x1827B1070")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009DE")]
			[Cpp2IlInjected.Address(RVA = "0x27B1060", Offset = "0x27B0460", VA = "0x1827B1060", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[BOJGNOMIPCG]
		private GLKFEKFDENH collisionIslandService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private EntityQuery changedIslandStructureQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private EntityQuery hierarchyChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private EntityQuery newRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private EntityQuery deletedConnectablesQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private EntityQuery deletedRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private EntityQuery islandRootDataQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private EntityQuery islandRootTagQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private JBGNEIHONBO ecbs;

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x2913900", Offset = "0x2912D00", VA = "0x182913900", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x2914370", Offset = "0x2913770", VA = "0x182914370", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x2914780", Offset = "0x2913B80", VA = "0x182914780", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x2913950", Offset = "0x2912D50", VA = "0x182913950")]
		private JobHandle JOCAFEPOONL(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x29140B0", Offset = "0x29134B0", VA = "0x1829140B0")]
		private JobHandle OCNCKMIMMJF(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x2913800", Offset = "0x2912C00", VA = "0x182913800")]
		private JobHandle CJPDKJGGKCJ(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
[IICIJFGHOAB]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class DLNAENEDEFK : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> EIBJMJGOJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FJIAILEGHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> ILIPOCLNFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private ADEFNGMMPNA MNJPDGCOLON;

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x294BBB0", Offset = "0x294AFB0", VA = "0x18294BBB0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x294C010", Offset = "0x294B410", VA = "0x18294C010", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x294B7D0", Offset = "0x294ABD0", VA = "0x18294B7D0")]
	private void FDMGOEIBICD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FIONHDMDJNK, EntityQueryDesc APAAFACFMDB, bool MOJFAKMKAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x294B690", Offset = "0x294AA90", VA = "0x18294B690")]
	private void FDMGOEIBICD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FIONHDMDJNK, EntityQueryDesc APAAFACFMDB, bool MOJFAKMKAFL, bool EDAEDABCFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x294C270", Offset = "0x294B670", VA = "0x18294C270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x294C590", Offset = "0x294B990", VA = "0x18294C590")]
	private void PDFPHCJBIKI(EntityQuery BEHDAMIMGBM, bool EKDAOLMBPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0x294B8E0", Offset = "0x294ACE0", VA = "0x18294B8E0")]
	private void GIHHFJMEJEE(EntityQuery BEHDAMIMGBM, bool IHKJAHPKJGG, bool EKDAOLMBPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0x294BC00", Offset = "0x294B000", VA = "0x18294BC00")]
	private void JLDMLOJMAOD(NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x294BE60", Offset = "0x294B260", VA = "0x18294BE60")]
	private void OACAFMGOFME(NativeList<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0x294BA90", Offset = "0x294AE90", VA = "0x18294BA90")]
	private void HJDEFELPOCF(NativeArray<Entity> NOEOKDNGNCK, bool IHKJAHPKJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0x294B470", Offset = "0x294A870", VA = "0x18294B470")]
	private NativeList<Entity> CMGACAHEPBL(NativeArray<Entity> NOEOKDNGNCK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0x294BE20", Offset = "0x294B220", VA = "0x18294BE20")]
	private NativeList<Entity> LDKILFGMDAL(NativeArray<Entity> NOEOKDNGNCK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0x294BFD0", Offset = "0x294B3D0", VA = "0x18294BFD0")]
	private NativeList<Entity> OMHLIKPCODH(NativeArray<Entity> NOEOKDNGNCK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x294B2B0", Offset = "0x294A6B0", VA = "0x18294B2B0")]
	private NativeList<Entity> BCMCGGPKCLO(NativeArray<Entity> NOEOKDNGNCK, bool AMIHJECMBOP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x294C7D0", Offset = "0x294BBD0", VA = "0x18294C7D0")]
	public DLNAENEDEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal class HJAEKNFJGHD : LPMKPFADJKH
{
	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	protected override NGPJOPHOOLK JCFDBPMPNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0x28E73F0", Offset = "0x28E67F0", VA = "0x1828E73F0", Slot = "15")]
		get
		{
			return default(NGPJOPHOOLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x28DEB10", Offset = "0x28DDF10", VA = "0x1828DEB10")]
	public HJAEKNFJGHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[UpdateBefore(typeof(MGLANHLKELD))]
public class OBKMBFBOHHC : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x247D9B0", Offset = "0x247CDB0", VA = "0x18247D9B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x247DA50", Offset = "0x247CE50", VA = "0x18247DA50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public OBKMBFBOHHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class CIDFBKFDGJK : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[BurstCompile]
	private struct IEPCCLOGIMD : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		[ReadOnly]
		public ComponentDataFromEntity<OKLGNNPGBAD> FNFCBOAICAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		[ReadOnly]
		public NativeArray<Entity> NOEOKDNGNCK;

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x27B7320", Offset = "0x27B6720", VA = "0x1827B7320", Slot = "4")]
		public void Execute(int BNOAGGNAMKG, TransformAccess DKKDEHMFAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[BurstCompile]
	private struct LGGHCDPPPEE : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		[ReadOnly]
		public ComponentDataFromEntity<KIKJFGLKOHO> KDLHNECFJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		[ReadOnly]
		public NativeArray<Entity> NOEOKDNGNCK;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x27B8B00", Offset = "0x27B7F00", VA = "0x1827B8B00", Slot = "4")]
		public void Execute(int BNOAGGNAMKG, TransformAccess DKKDEHMFAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[BurstCompile]
	private struct MJIJDIKLLKH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		[ReadOnly]
		public ComponentDataFromEntity<KIKJFGLKOHO> KDLHNECFJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		[ReadOnly]
		public ComponentDataFromEntity<HAGJKHAGDIE> NIOEPAHNOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[ReadOnly]
		public NativeArray<Entity> NOEOKDNGNCK;

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x27B9C30", Offset = "0x27B9030", VA = "0x1827B9C30", Slot = "4")]
		public void Execute(int BNOAGGNAMKG, TransformAccess DKKDEHMFAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private static readonly EHKEPJIBENP PKGJGEMIJDH;

	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private static readonly EHKEPJIBENP KPCMMDMMAMA;

	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private static readonly EHKEPJIBENP ABKOPKCLNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private GPGAADBKEBC CEHFBMMMCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private EntityQuery HNNHHJAKAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private EntityQuery IJDLOHJOHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private EntityQuery DDOMJJIMFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private TransformAccessArray HOGPBMKIOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private TransformAccessArray LEJCOCCCEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private TransformAccessArray NCKKANKBLOL;

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x2906390", Offset = "0x2905790", VA = "0x182906390", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x29063E0", Offset = "0x29057E0", VA = "0x1829063E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x29065D0", Offset = "0x29059D0", VA = "0x1829065D0", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x2906660", Offset = "0x2905A60", VA = "0x182906660", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x2906690", Offset = "0x2905A90", VA = "0x182906690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x29061F0", Offset = "0x29055F0", VA = "0x1829061F0")]
	private NativeArray<Entity> FNGEGFHIDHF(NativeArray<HAJLKENCNBI> MMCGJOGCCIJ, NativeList<Entity> MEHONAIFBIF, TransformAccessArray NMMHIKFKIAO, TransformAccessArray PLCIGJHHIAA)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public CIDFBKFDGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class LBPBODLGDHK : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x2A663E0", Offset = "0x2A657E0", VA = "0x182A663E0", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public LBPBODLGDHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(KILFBCLKOFO), new string[] { })]
internal sealed class KILFBCLKOFO : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private static readonly EHKEPJIBENP OIMPABNBIFD;

	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private static readonly EHKEPJIBENP OAPOAEBPMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	private FMGLEPMNDMM<BDPBKBOOLFE, Entity> BGKJEHJEALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	private DNDPKOJDFNF<HFJJMBGFFCA> DMCPDLHAEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private DNDPKOJDFNF<GKLKKMKPHFN> JGDJNOLMOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private DNDPKOJDFNF<GGMJCOHJNGG> CPJFPMFNKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private DNDPKOJDFNF<KGDHKJAMGAD> BJCINAIHBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private DNDPKOJDFNF<HNNIENJEABJ> HJBFJMLNKGK;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public DFMOAIPJPDE<Entity> KHOBMANKIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public DIHICPLKFAA MLLNACMLKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public DIHICPLKFAA KAFPAANEIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public DIHICPLKFAA GEBCJDDHFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public DIHICPLKFAA CHPOLONJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public DIHICPLKFAA MLGFCANMGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x8C3A00", Offset = "0x8C2E00", VA = "0x1808C3A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x2A63BB0", Offset = "0x2A62FB0", VA = "0x182A63BB0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x2A63C00", Offset = "0x2A63000", VA = "0x182A63C00", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2A63AC0", Offset = "0x2A62EC0", VA = "0x182A63AC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x1D93C60", Offset = "0x1D93060", VA = "0x181D93C60")]
	private void DKPCMCGGMHB<T>(ref DNDPKOJDFNF<T> KKDDOIAGHBK, EntityCommandBufferSystem ICHBDANIEME, EHKEPJIBENP IGCLICKKCHJ) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x1D93BD0", Offset = "0x1D92FD0", VA = "0x181D93BD0")]
	private void DKPCMCGGMHB<TC, TV>(ref FMGLEPMNDMM<TC, TV> KKDDOIAGHBK) where TC : struct, GNJLMOPJNKA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public KILFBCLKOFO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct GKLKKMKPHFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public struct HFJJMBGFFCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public struct GGMJCOHJNGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct KGDHKJAMGAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public struct HNNIENJEABJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
[ExecuteAlways]
public class GHBPFJHDFEM : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
	public GHBPFJHDFEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal readonly struct KCGEPNLLLGL
{
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[CompilerGenerated]
	private sealed class JNNAMPIHJGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public NILFPPHEEJF system;

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JNNAMPIHJGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x27B8520", Offset = "0x27B7920", VA = "0x1827B8520")]
		internal (EntityQuery, ComponentType) NPOEGFKJKPN((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private static readonly ProfilerMarker KFHNGFCGHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private readonly NILFPPHEEJF GDOFPEAGKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] INJAHIDHCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private readonly EntityQuery DKBBMPFODCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private readonly EntityQuery AEDEGOMMAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private readonly ComponentTypes GGDKFGPKHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private readonly ComponentTypes GMAGNHEIJHL;

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x28F9480", Offset = "0x28F8880", VA = "0x1828F9480")]
	public KCGEPNLLLGL(NILFPPHEEJF GDOFPEAGKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x28F91C0", Offset = "0x28F85C0", VA = "0x1828F91C0")]
	public void GLINDFMMGLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class PNNFOBKOPFC : EGPDILJJNOF
{
	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x2488DA0", Offset = "0x24881A0", VA = "0x182488DA0", Slot = "14")]
	protected override EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x2488DF0", Offset = "0x24881F0", VA = "0x182488DF0")]
	public PNNFOBKOPFC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	[IICIJFGHOAB]
	[CompilerGenerated]
	public class DebugPostDeserializeRemoveOrphanedSplinePoints : CCBLHMCLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		[NoAlias]
		[BurstCompile]
		private struct DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			[ReadOnly]
			public ComponentDataFromEntity<KACENJHHHOI> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			[ReadOnly]
			public ComponentTypeHandle<OPILEFNOLAG> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A21")]
			[Cpp2IlInjected.Address(RVA = "0x27B2A30", Offset = "0x27B1E30", VA = "0x1827B2A30")]
			private void OPBILJIDNNC(Entity entity, [NoAlias] in OPILEFNOLAG point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A22")]
			[Cpp2IlInjected.Address(RVA = "0x27B2910", Offset = "0x27B1D10", VA = "0x1827B2910", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private EntityQuery DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private ComponentTypeHandle<OPILEFNOLAG> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x294E3D0", Offset = "0x294D7D0", VA = "0x18294E3D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x294DFA0", Offset = "0x294D3A0", VA = "0x18294DFA0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void FBKICBKLDDK(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x294E180", Offset = "0x294D580", VA = "0x18294E180")]
		private EntityCommandBufferSystem MAIDFODBFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x294E040", Offset = "0x294D440", VA = "0x18294E040")]
		private JobHandle LFNMDDCDIKG(EntityCommandBuffer ecb, ComponentDataFromEntity<KACENJHHHOI> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x294E1D0", Offset = "0x294D5D0", VA = "0x18294E1D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public DebugPostDeserializeRemoveOrphanedSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public struct NGGLHMEMLAF<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	[ReadOnly]
	public EntityQueryInJob BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	[ReadOnly]
	public EntityTypeHandle NOLCKIFFBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	[ReadOnly]
	public ComponentTypeHandle<T> MPDOACJPLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A6")]
	[WriteOnly]
	public EntityCommandBuffer JNKKDKMNHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A7")]
	public AllocatorManager.AllocatorHandle DGGNDNPDKKD;

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x278D500", Offset = "0x278C900", VA = "0x18278D500")]
	public OFDCNLDBOIC<T> JMNCFKBKLBM()
	{
		return default(OFDCNLDBOIC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public static class CLFJJCCLJOE
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[BurstCompile]
	private struct ILJLLLJHJIJ : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[ReadOnly]
		public NativeParallelHashSet<int> OBKKGNADCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> MENDLKBADHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public NativeList<EntityArchetype> OPIAGALIIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public NativeList<EEMOBOLLAKL> DMMLFLOICLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public NativeList<EEMOBOLLAKL> IEDEBLALICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public NativeList<ComponentType> JHKBMOGDDKO;

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x27B7490", Offset = "0x27B6890", VA = "0x1827B7490", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x27B7400", Offset = "0x27B6800", VA = "0x1827B7400", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x29090E0", Offset = "0x29084E0", VA = "0x1829090E0")]
	public static NativeParallelHashSet<int> CCEHFLDANAG(Allocator DGGNDNPDKKD)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x2909630", Offset = "0x2908A30", VA = "0x182909630")]
	public static NativeParallelHashSet<int> LJCIBBMFKIK(Allocator DGGNDNPDKKD)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x29091C0", Offset = "0x29085C0", VA = "0x1829091C0")]
	private static void EPGIBKCFJON(NativeParallelHashSet<int> HMHINJBEENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A27")]
	[Cpp2IlInjected.Address(RVA = "0x2909790", Offset = "0x2908B90", VA = "0x182909790")]
	private static bool MKLPECGANHE(Type GANFKPHKNKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A28")]
	[Cpp2IlInjected.Address(RVA = "0x2908F50", Offset = "0x2908350", VA = "0x182908F50")]
	private static void BDEFMFOGFAL(NativeParallelHashSet<int> HMHINJBEENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x290A110", Offset = "0x2909510", VA = "0x18290A110")]
	private static void ONNKOEIDPBE(NativeParallelHashSet<int> HMHINJBEENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x2908DC0", Offset = "0x29081C0", VA = "0x182908DC0")]
	private static void ANCNKJIJJMC(NativeParallelHashSet<int> HMHINJBEENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0x2909880", Offset = "0x2908C80", VA = "0x182909880")]
	public static void NIDGELBLGNE(EntityManager BEBIJONEMLA, EntityQuery BEHDAMIMGBM, NativeParallelHashSet<int> EDPFLIMEOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x29094B0", Offset = "0x29088B0", VA = "0x1829094B0")]
	public static void JDKPMEFHNMP(EntityManager BEBIJONEMLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
public class MNPOHLIIKFE : ParentSystemBase<EODNMPFLBLP, LMCCJLJHFEM, NCPPJPJLJPP>
{
	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x2A71790", Offset = "0x2A70B90", VA = "0x182A71790", Slot = "14")]
	protected override EntityQueryDesc FPODJLPANIA(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0x944020", Offset = "0x943420", VA = "0x180944020", Slot = "15")]
	protected override EntityQueryDesc ECKKNPGPDKI(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x2A71750", Offset = "0x2A70B50", VA = "0x182A71750", Slot = "16")]
	protected override EntityQueryDesc FNMNPLHOFDJ(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x2A71710", Offset = "0x2A70B10", VA = "0x182A71710", Slot = "17")]
	protected override EntityQueryDesc EBDCDKHPHOA(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x2A717D0", Offset = "0x2A70BD0", VA = "0x182A717D0")]
	public MNPOHLIIKFE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : NILFPPHEEJF where TParentData : struct, IComponentData, LILBGEFEHNB where TPreviousParentData : struct, IComponentData, LILBGEFEHNB where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, LILBGEFEHNB
	{
		[Cpp2IlInjected.Token(Token = "0x20001BA")]
		[BurstCompile]
		internal struct PPLJNDGLGMN : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter HKPKNPFPJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter NLIDIMFMOHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public NativeParallelHashMap<Entity, int>.ParallelWriter GBBLKLIMGMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B9")]
			public ComponentTypeHandle<TPreviousParentData> IEPFGOPOKKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			[ReadOnly]
			public ComponentTypeHandle<TParentData> OAFKFLOICAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BB")]
			[ReadOnly]
			public EntityTypeHandle JIKHMGKBKLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			public uint CDOBDMBCFLE;

			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x2455250", Offset = "0x2454650", VA = "0x182455250", Slot = "4")]
			public void Execute(ArchetypeChunk DHCAFCLHBAO, int JGOFFILAMJM, int OLGOGAFHIIN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BB")]
		[BurstCompile]
		internal struct CANCGINCPOA : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> GBBLKLIMGMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> HEOPIANMHLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public NativeList<Entity> GBJLNHLLKNH;

			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0x34929C0", Offset = "0x3491DC0", VA = "0x1834929C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BC")]
		[BurstCompile]
		internal struct OHBKLFBAHDI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> HKPKNPFPJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> NLIDIMFMOHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> GBBLKLIMGMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			public BufferFromEntity<TChildrenData> HEOPIANMHLH;

			[Cpp2IlInjected.Token(Token = "0x6000A44")]
			[Cpp2IlInjected.Address(RVA = "0x23DAD30", Offset = "0x23DA130", VA = "0x1823DAD30")]
			private int FKCMDIMEMFB(DynamicBuffer<TChildrenData> LEGMMMPKLOM, Entity GKMECPLEALF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0x23DADF0", Offset = "0x23DA1F0", VA = "0x1823DADF0")]
			private void NIAMDACNLJI(Entity OJBGDMNECON, DynamicBuffer<TChildrenData> LEGMMMPKLOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A46")]
			[Cpp2IlInjected.Address(RVA = "0x23DA860", Offset = "0x23D9C60", VA = "0x1823DA860")]
			private void ECGJKCCCPMK(Entity OJBGDMNECON, DynamicBuffer<TChildrenData> LEGMMMPKLOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A47")]
			[Cpp2IlInjected.Address(RVA = "0x23DA990", Offset = "0x23D9D90", VA = "0x1823DA990", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		[BurstCompile]
		private struct JJLHGNDEFBK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			[ReadOnly]
			public NativeArray<Entity> LHBKIMGLGOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public NativeList<Entity> DDHIFCMPLOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> HEOPIANMHLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			[ReadOnly]
			public ComponentDataFromEntity<TParentData> HINDOOCGEHK;

			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0x2FD48B0", Offset = "0x2FD3CB0", VA = "0x182FD48B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		protected EntityQuery MJBOEFFPIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		protected EntityQuery IFLFBBNDAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		protected EntityQuery DLIEHBIGMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		protected EntityQuery HNPHHEMIOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		protected ProfilerMarker KFNLMPHHPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		protected ProfilerMarker LELKBOAGCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		protected ProfilerMarker FJICKIDAEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		protected ProfilerMarker CMOBFGHDEGJ;

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x245ECC0", Offset = "0x245E0C0", VA = "0x18245ECC0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x245CC30", Offset = "0x245C030", VA = "0x18245CC30")]
		private int FKCMDIMEMFB(DynamicBuffer<TChildrenData> LEGMMMPKLOM, Entity GKMECPLEALF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x245C930", Offset = "0x245BD30", VA = "0x18245C930")]
		private void CGNDNJBMAHL(Entity OIOKEJJKBGH, Entity CGIPHBNLBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x944020", Offset = "0x943420", VA = "0x180944020", Slot = "14")]
		protected virtual EntityQueryDesc FPODJLPANIA(EntityQueryDesc BEHDAMIMGBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x944020", Offset = "0x943420", VA = "0x180944020", Slot = "15")]
		protected virtual EntityQueryDesc ECKKNPGPDKI(EntityQueryDesc BEHDAMIMGBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x944020", Offset = "0x943420", VA = "0x180944020", Slot = "16")]
		protected virtual EntityQueryDesc FNMNPLHOFDJ(EntityQueryDesc BEHDAMIMGBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc EBDCDKHPHOA(EntityQueryDesc BEHDAMIMGBM);

		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x245E4D0", Offset = "0x245D8D0", VA = "0x18245E4D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x245CB60", Offset = "0x245BF60", VA = "0x18245CB60")]
		private void DPPDMDMELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x245E110", Offset = "0x245D510", VA = "0x18245E110")]
		private void LHHHNIJCCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x245CE10", Offset = "0x245C210", VA = "0x18245CE10")]
		private JobHandle JGMOJAHEANC(JobHandle BMMIBMDGEID)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3F")]
		[Cpp2IlInjected.Address(RVA = "0x245DD50", Offset = "0x245D150", VA = "0x18245DD50")]
		private void KNMLFNAJPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x245EA90", Offset = "0x245DE90", VA = "0x18245EA90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x1D3AA00", Offset = "0x1D39E00", VA = "0x181D3AA00", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public class JJLJJEBOEGJ : EIPCEABGPFF
{
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	protected override NGEGBFMLEIK JLLFBEMCIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "15")]
		get
		{
			return default(NGEGBFMLEIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x28F7440", Offset = "0x28F6840", VA = "0x1828F7440", Slot = "16")]
	protected override void HFHBKKDGPPD(NGEGBFMLEIK LJJHJABONIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x28F7710", Offset = "0x28F6B10", VA = "0x1828F7710")]
	private EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x28F77F0", Offset = "0x28F6BF0", VA = "0x1828F77F0")]
	public JJLJJEBOEGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
[IICIJFGHOAB]
public class MFCDLNDOLGP : CCBLHMCLOCJ
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	private struct KCEHDNMCENH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		[ReadOnly]
		public NativeParallelHashSet<int> BJAKJCNMMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		[ReadOnly]
		public EntityTypeHandle OJNLLHIJIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> FILFICKNHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public NativeList<Entity>.ParallelWriter FEKNDGABDBF;

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x27B8640", Offset = "0x27B7A40", VA = "0x1827B8640", Slot = "4")]
		public void Execute(ArchetypeChunk DHCAFCLHBAO, int JGOFFILAMJM, int OLGOGAFHIIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x2A70430", Offset = "0x2A6F830", VA = "0x182A70430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x2A704C0", Offset = "0x2A6F8C0", VA = "0x182A704C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x2A703E0", Offset = "0x2A6F7E0", VA = "0x182A703E0")]
	private EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public MFCDLNDOLGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public struct IICPIKDEMDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	public Entity GKMECPLEALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	public GFEODBLIPAM CBNEMGEKLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	public GFEODBLIPAM BGDHKJDGOAL;
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(GPGAADBKEBC), new string[] { })]
internal sealed class GPGAADBKEBC : GMHONDBOJEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private FJMPDOIMHHI KINJMJNGLBI;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public FJMPDOIMHHI HEIOBCLLGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x2881EE0", Offset = "0x28812E0", VA = "0x182881EE0")]
		get
		{
			return default(FJMPDOIMHHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x28E2090", Offset = "0x28E1490", VA = "0x1828E2090", Slot = "4")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x28E2120", Offset = "0x28E1520", VA = "0x1828E2120", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public GPGAADBKEBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
internal sealed class KPDJHJGNEIO : ParentSystemBase<EODNMPFLBLP, LMCCJLJHFEM, NCPPJPJLJPP>
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x944020", Offset = "0x943420", VA = "0x180944020", Slot = "14")]
	protected override EntityQueryDesc FPODJLPANIA(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x944020", Offset = "0x943420", VA = "0x180944020", Slot = "15")]
	protected override EntityQueryDesc ECKKNPGPDKI(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x944020", Offset = "0x943420", VA = "0x180944020", Slot = "16")]
	protected override EntityQueryDesc FNMNPLHOFDJ(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x2A64FE0", Offset = "0x2A643E0", VA = "0x182A64FE0", Slot = "17")]
	protected override EntityQueryDesc EBDCDKHPHOA(EntityQueryDesc BEHDAMIMGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2A65020", Offset = "0x2A64420", VA = "0x182A65020")]
	public KPDJHJGNEIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[EPJIKDLNGEH(typeof(NNFPBHEJLKI), new string[] { })]
internal class MBIKABOJABM : NNFPBHEJLKI, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	[BOJGNOMIPCG]
	private NKIFCJBAGBF JPGDAAPDBJK;

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F8B0", Offset = "0x2A6ECB0", VA = "0x182A6F8B0", Slot = "8")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F650", Offset = "0x2A6EA50", VA = "0x182A6F650", Slot = "4")]
	public World ALGDIKEMKBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F990", Offset = "0x2A6ED90", VA = "0x182A6F990", Slot = "5")]
	public World PFJDPFFMNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F770", Offset = "0x2A6EB70", VA = "0x182A6F770", Slot = "6")]
	public World BJODIHFMCOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F810", Offset = "0x2A6EC10", VA = "0x182A6F810", Slot = "7")]
	public World EBGHHEMKOED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F900", Offset = "0x2A6ED00", VA = "0x182A6F900")]
	private World OIHPOHEADJI(string GDKOBCHHFLB, FJNMBOHBDKO BLBMFDIEDCO, Type EKPIDEHALOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public MBIKABOJABM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
public enum NGLJBCFJFFJ
{
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
internal class GNIGPCJPMPI : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private object CONEEGIKPHA;

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x28E0A50", Offset = "0x28DFE50", VA = "0x1828E0A50", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x28E0AD0", Offset = "0x28DFED0", VA = "0x1828E0AD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x28E0B70", Offset = "0x28DFF70", VA = "0x1828E0B70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public GNIGPCJPMPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
internal class BPIMBDNFDDN : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private LEHIKHOEAMN DOJPHKDLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private EntityQuery FDHLCGGFADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private EntityQuery DCBENAPOJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private NBPNODCEBKF FBJJPAAFOIC;

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x2902E00", Offset = "0x2902200", VA = "0x182902E00", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x2903180", Offset = "0x2902580", VA = "0x182903180", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x2903290", Offset = "0x2902690", VA = "0x182903290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x29028D0", Offset = "0x2901CD0", VA = "0x1829028D0")]
	private void BMPJPDFEKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2902C30", Offset = "0x2902030", VA = "0x182902C30")]
	private void EMKIMPIIHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x2902E70", Offset = "0x2902270", VA = "0x182902E70")]
	private void NHDIEDPBIIL(NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2902AF0", Offset = "0x2901EF0", VA = "0x182902AF0")]
	private void DJKAEAMKPAO(NativeArray<Entity> NOEOKDNGNCK, int EDLAEBCDIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x29029E0", Offset = "0x2901DE0", VA = "0x1829029E0")]
	private void DAIOIPJLLAE(NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x2902DA0", Offset = "0x29021A0", VA = "0x182902DA0")]
	private void IMPJIEKNCAH(Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x8D4D80", Offset = "0x8D4180", VA = "0x1808D4D80")]
	private static void EGFPDOHIAOH(int GAAPLDCPBBH, Transform DKKDEHMFAEC, Entity GKMECPLEALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public BPIMBDNFDDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal static class GLOLMJJDCNK
{
	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x28E02C0", Offset = "0x28DF6C0", VA = "0x1828E02C0")]
	public static bool AJMNFGFDDEB(this SystemBase GDOFPEAGKBE, out Entity GKMECPLEALF)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[CompilerGenerated]
	[BOFOINMHPHO(FGCKLJIPPNH.OMRoom)]
	public class PostLoadRemapCircuitIds : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		private struct PostLoadRemapCircuitIds_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005E3")]
			public MFMOHGACDCK remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005E4")]
			public ComponentTypeHandle<HEGLKDBKLOA> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A7B")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E8B0", Offset = "0x4C4DCB0", VA = "0x184C4E8B0")]
			private void OPBILJIDNNC(ref HEGLKDBKLOA node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7C")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E7E0", Offset = "0x4C4DBE0", VA = "0x184C4E7E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		[BOJGNOMIPCG]
		private HMHHFNDBEKM serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private EntityQuery PostLoadRemapCircuitIds_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private ComponentTypeHandle<HEGLKDBKLOA> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x2491220", Offset = "0x2490620", VA = "0x182491220", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x24914A0", Offset = "0x24908A0", VA = "0x1824914A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A77")]
		[Cpp2IlInjected.Address(RVA = "0x2491130", Offset = "0x2490530", VA = "0x182491130")]
		private void CBAHPIEAFBO(MFMOHGACDCK remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x2491610", Offset = "0x2490A10", VA = "0x182491610")]
		private void PBBDDIMDKJH(ref MFMOHGACDCK remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2491270", Offset = "0x2490670", VA = "0x182491270", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PostLoadRemapCircuitIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class DLFDDELLBEJ : NILFPPHEEJF, NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private static readonly EHKEPJIBENP EIDKDJCLAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	[BOJGNOMIPCG]
	private JIDPKPDHEOA OAHDHLNKBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	[BOJGNOMIPCG]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	[BOJGNOMIPCG]
	private JPKPMPALKHK IPNFEMGMOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	[BOJGNOMIPCG]
	private DEPDBGLFLFP PKJKDKKAEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	[BOJGNOMIPCG]
	private IDBLECGOEML ACLJAANEKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	[BOJGNOMIPCG]
	private FEALACGMELJ FEJNNANFOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private LHCBICNIEGK.MDCEFCALBHP DJHIANOHMEG;

	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x294A140", Offset = "0x2949540", VA = "0x18294A140", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x29497B0", Offset = "0x2948BB0", VA = "0x1829497B0", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x294B040", Offset = "0x294A440", VA = "0x18294B040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x2949850", Offset = "0x2948C50", VA = "0x182949850")]
	private void FGGPIKIPIDL(JGELFBOFGKF PMMAAICOJOP, NativeArray<byte> KCNLHBFAGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x29496F0", Offset = "0x2948AF0", VA = "0x1829496F0")]
	private bool DMHDBPNGOJB(JGELFBOFGKF PMMAAICOJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x294B060", Offset = "0x294A460", VA = "0x18294B060")]
	private LHCBICNIEGK.FGGGLCNMAPO PBNHENPMFCO(NativeArray<byte> KCNLHBFAGFJ, Allocator DGGNDNPDKKD)
	{
		return default(LHCBICNIEGK.FGGGLCNMAPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x2949D30", Offset = "0x2949130", VA = "0x182949D30")]
	private void IALPDIIHFKB(LHCBICNIEGK.FGGGLCNMAPO JKCFOAPCEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x29493F0", Offset = "0x29487F0", VA = "0x1829493F0")]
	private void BNNKHBJLPND(NativeList<JDPNCHCMAIA> AMMLHKPHIHN, NativeList<BACOLBMJCKD> LHMBGJCLFKL, Allocator DGGNDNPDKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A85")]
	[Cpp2IlInjected.Address(RVA = "0x294A550", Offset = "0x2949950", VA = "0x18294A550")]
	private void NFHMMJCDOOF(NativeParallelMultiHashMap<JDPNCHCMAIA, FNCDFGODHHE> ALDDGAFFIJM, NativeList<byte> FCEPIGFHGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0x294A2F0", Offset = "0x29496F0", VA = "0x18294A2F0")]
	private void JCMFGFJHFEJ(NativeList<JDPNCHCMAIA> NKBMDMOANEL, Allocator DGGNDNPDKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x2949E20", Offset = "0x2949220", VA = "0x182949E20")]
	private void IPFCJOBAHOH(LHCBICNIEGK.FGGGLCNMAPO CLCAIFLMLCJ, bool HGLPFECCHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x2949270", Offset = "0x2948670", VA = "0x182949270")]
	private void APPIHDEJJGE(NativeList<JDPNCHCMAIA> AMMLHKPHIHN, NativeList<BACOLBMJCKD> LHMBGJCLFKL, bool HGLPFECCHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x294AA10", Offset = "0x2949E10", VA = "0x18294AA10")]
	private void OAAPINFPEHI(NativeParallelMultiHashMap<JDPNCHCMAIA, FNCDFGODHHE> ALDDGAFFIJM, NativeList<byte> FCEPIGFHGIB, bool HGLPFECCHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x29495E0", Offset = "0x29489E0", VA = "0x1829495E0")]
	private void CPKDAKDCNJK(NativeList<JDPNCHCMAIA> NKBMDMOANEL, bool HGLPFECCHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void GJIGILMIGNA(JGELFBOFGKF PMMAAICOJOP, bool HGLPFECCHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public DLFDDELLBEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class COJJDDELCHK : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x290B720", Offset = "0x290AB20", VA = "0x18290B720", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public COJJDDELCHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
internal interface JCEINDAJIBO
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	NativeParallelMultiHashMap<Entity, OFDKMKMCECL> GDPHKGIICHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	uint CDOBDMBCFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MJGIDLOGJJF(NativeArray<JDPNCHCMAIA> AMMLHKPHIHN, NativeArray<BACOLBMJCKD> LHMBGJCLFKL, NativeArray<JDPNCHCMAIA> NKBMDMOANEL, int CEFOHNHEFFE);

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LCDNCGBNMGO(in FEHKACBIOPC PHDIMPCFBCF);

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHOGFBAIODI(JobHandle PAHMPOAEKCN);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	public class CalculateCollisionIslandUpdatesSystem : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		[NoAlias]
		[BurstCompile]
		private struct CalculateCollisionIslandUpdatesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public NativeList<Entity> rootsWithForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public NativeList<Entity> rootsWithoutForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			[ReadOnly]
			public ComponentTypeHandle<JJKAHCIIMPM> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			[ReadOnly]
			public ComponentDataFromEntity<JJKAHCIIMPM> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			[ReadOnly]
			public ComponentTypeHandle<OPILEFNOLAG> splineParentHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			public EntityQueryInJob changedLocalPoseQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			public EntityQueryInJob changedSplinePointsQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			public EntityQueryInJob splinesWithChangedChildrenQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			public EntityQueryInJob changedCollisionModeQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			public EntityQueryInJob changedScopeRootQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x27B0860", Offset = "0x27AFC60", VA = "0x1827B0860")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x27B0850", Offset = "0x27AFC50", VA = "0x1827B0850", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private EntityQuery changedLocalPoseQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private EntityQuery changedSplinePointsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private EntityQuery splinesWithChangedChildrenQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private EntityQuery changedCollisionModeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private EntityQuery scopeRootChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private GLKFEKFDENH collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x6000A95")]
		[Cpp2IlInjected.Address(RVA = "0x2912C60", Offset = "0x2912060", VA = "0x182912C60", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A96")]
		[Cpp2IlInjected.Address(RVA = "0x2912CB0", Offset = "0x29120B0", VA = "0x182912CB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A97")]
		[Cpp2IlInjected.Address(RVA = "0x2913010", Offset = "0x2912410", VA = "0x182913010", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x2913650", Offset = "0x2912A50", VA = "0x182913650")]
		private JobHandle PKPOOHLOMEE(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<JJKAHCIIMPM> collisionIslandRootDataHandleRO, ComponentDataFromEntity<JJKAHCIIMPM> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<OPILEFNOLAG> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[IICIJFGHOAB]
public class ACKFJIIAILI : CCBLHMCLOCJ
{
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x28F9A00", Offset = "0x28F8E00", VA = "0x1828F9A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x28F9A90", Offset = "0x28F8E90", VA = "0x1828F9A90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x28F99B0", Offset = "0x28F8DB0", VA = "0x1828F99B0")]
	private EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public ACKFJIIAILI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class AOFKLKGMEPJ : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	[BurstCompile]
	private struct CHHHKGBAMOA : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		[ReadOnly]
		public int EMMKPJKBEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		[ReadOnly]
		public EntityQueryInJob ADEJIHNMENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		[ReadOnly]
		public EntityQueryInJob IMHOCGBMKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged NHMEKKJKJMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		[ReadOnly]
		public EntityTypeHandle OJNLLHIJIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		[ReadOnly]
		public ComponentDataFromEntity<MFFCMBGAGGG> EGBJOFEAHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		[ReadOnly]
		public ComponentDataFromEntity<PODMOPJDKIH> IAMINAJDHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> HMLJODGHOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		[ReadOnly]
		public ComponentTypeHandle<OPILEFNOLAG> EDBOEIENDMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		[ReadOnly]
		public ComponentDataFromEntity<JFMBCHEMIHN> PMHBILCNGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		[ReadOnly]
		public ComponentDataFromEntity<PPPFOFLFJIM> ILNFBHMAJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		[WriteOnly]
		public ComponentDataFromEntity<MFNPNAGNGGD> BELHHLEHJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		[WriteOnly]
		public ComponentDataFromEntity<CABAKAOCBGH> EJAOJBHOLOL;

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x27AFFB0", Offset = "0x27AF3B0", VA = "0x1827AFFB0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x27B0150", Offset = "0x27AF550", VA = "0x1827B0150")]
		private void GMCNFNCFHBM(NativeList<Entity> OGLMDJKECED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x27AFB00", Offset = "0x27AEF00", VA = "0x1827AFB00")]
		private void BGNBDEPEJAO(Entity EFDPMAIOLJO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private EntityQuery IEBHEJEHKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private EntityQuery ADBEJGOEOJM;

	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(RVA = "0x28FC030", Offset = "0x28FB430", VA = "0x1828FC030", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x28FC1D0", Offset = "0x28FB5D0", VA = "0x1828FC1D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x2197460", Offset = "0x2196860", VA = "0x182197460")]
	private bool CGCNKCIPCIA<T>(T APLHNMAPBKL, out int DLBEGCMPMKC) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public AOFKLKGMEPJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkId : CCBLHMCLOCJ, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x20001D4")]
		private struct DebugPostLoadValidateNetworkId_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000613")]
			public NativeParallelHashMap<JDPNCHCMAIA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			[ReadOnly]
			public ComponentTypeHandle<CCNJGHCPMLN> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x27B2BC0", Offset = "0x27B1FC0", VA = "0x1827B2BC0")]
			private void OPBILJIDNNC(Entity entity, in CCNJGHCPMLN networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x27B2AA0", Offset = "0x27B1EA0", VA = "0x1827B2AA0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private GGPOHFHPOPM networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private EntityQuery DebugPostLoadValidateNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private ComponentTypeHandle<CCNJGHCPMLN> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x294E620", Offset = "0x294DA20", VA = "0x18294E620", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x294E9A0", Offset = "0x294DDA0", VA = "0x18294E9A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x294E680", Offset = "0x294DA80", VA = "0x18294E680")]
		private void KHNBCACBFAC(ref NativeParallelHashMap<JDPNCHCMAIA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x294E770", Offset = "0x294DB70", VA = "0x18294E770", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public DebugPostLoadValidateNetworkId()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
public readonly struct IBPKMONNJNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private readonly int DCJNJIADGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private readonly int JNHCLKAAKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private readonly EEMOBOLLAKL KBMIFPNEOLH;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public EEMOBOLLAKL HPEEGFAJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0xBC5870", Offset = "0xBC4C70", VA = "0x180BC5870")]
		get
		{
			return default(EEMOBOLLAKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x28EAC30", Offset = "0x28EA030", VA = "0x1828EAC30")]
	public IBPKMONNJNM(int DCJNJIADGPK, int JNHCLKAAKHA, EEMOBOLLAKL KBMIFPNEOLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[InternalBufferCapacity(1)]
internal struct LMCOECELJLH : ISystemStateBufferElementData, IBufferElementData, IEquatable<LMCOECELJLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	public ELCJDJGAIGE PAHMPOAEKCN;

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D910", Offset = "0x2A6CD10", VA = "0x182A6D910", Slot = "4")]
	public bool Equals(LMCOECELJLH ICELKIGIKKP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static LMCOECELJLH LFFBPOODCDC(ELCJDJGAIGE PAHMPOAEKCN)
	{
		return default(LMCOECELJLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
[EPJIKDLNGEH(typeof(EKDKPLKGAMN), new string[] { })]
public sealed class DFPMMAHFJEO : EKDKPLKGAMN, NEHPEGODEDF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001D8")]
	private struct DPGCJCHNHJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public float HJLLDLMGKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public uint FFFCLEBOHNE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	[BOJGNOMIPCG]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	[BOJGNOMIPCG]
	private MBDFLOLPEII JLLIHOOONJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	[BOJGNOMIPCG]
	private CHLGHCACLPB EMPMCELMIEJ;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x2946FF0", Offset = "0x29463F0", VA = "0x182946FF0", Slot = "5")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x2947090", Offset = "0x2946490", VA = "0x182947090")]
	public bool NMAPLLCJFCD(in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, float AKODDLNKMDE, out EIPPCECOLNJ MGALLJFBEGH, out HEKFLAGDMLJ EFDPMAIOLJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x2946F10", Offset = "0x2946310", VA = "0x182946F10")]
	public static bool GOJNJLLLBPK(in Span<EIPPCECOLNJ> CGDMDOPDCJH, float AKODDLNKMDE, out int BNOAGGNAMKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x2946EE0", Offset = "0x29462E0", VA = "0x182946EE0")]
	public static float DFFCMMNCKNC(float HJLLDLMGKEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public DFPMMAHFJEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0x2947080", Offset = "0x2946480", VA = "0x182947080", Slot = "4")]
	private bool LEPBCJBBPIB(in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, float AKODDLNKMDE, out EIPPCECOLNJ MGALLJFBEGH, out HEKFLAGDMLJ EFDPMAIOLJO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal struct FKMFPNGLEFM : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public class GJDIEPENDPN : NILFPPHEEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	private EntityQuery NHPDGPIJEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000621")]
	private ComponentTypes ONEGHPDPIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000622")]
	private NativeParallelHashSet<int> EDPFLIMEOKH;

	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x28DE2A0", Offset = "0x28DD6A0", VA = "0x1828DE2A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0x28DE670", Offset = "0x28DDA70", VA = "0x1828DE670", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x28DE6F0", Offset = "0x28DDAF0", VA = "0x1828DE6F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x28DE200", Offset = "0x28DD600", VA = "0x1828DE200")]
	public JobHandle AFMCDAAELDH(JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public GJDIEPENDPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
public class GBANJAELPAG : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[BurstCompile]
	private struct DEKBFAELLLH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		[ReadOnly]
		public ComponentTypeHandle<OADFAJIFNBN> GFNHGNACODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public ComponentTypeHandle<LEIMONNOBFD> JKPNADLKMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public uint CDOBDMBCFLE;

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x27B1750", Offset = "0x27B0B50", VA = "0x1827B1750", Slot = "4")]
		public void Execute(ArchetypeChunk DHCAFCLHBAO, int BNOAGGNAMKG, int JBHKGNDKFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC7")]
		[Cpp2IlInjected.Address(RVA = "0x27B16C0", Offset = "0x27B0AC0", VA = "0x1827B16C0")]
		public bool AMNIIBHEDHA(ArchetypeChunk DHCAFCLHBAO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000626")]
	private EntityQuery PBPCGONEOIK;

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x28DB970", Offset = "0x28DAD70", VA = "0x1828DB970", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x28DBAA0", Offset = "0x28DAEA0", VA = "0x1828DBAA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public GBANJAELPAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
[ExecuteAlways]
public class JBGNEIHONBO : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
	public JBGNEIHONBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct MHDFJIJCFFB<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private NGGLHMEMLAF<T> LJJHJABONIO;

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x22FC700", Offset = "0x22FBB00", VA = "0x1822FC700")]
	public MHDFJIJCFFB(NGGLHMEMLAF<T> LJJHJABONIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x22FBF80", Offset = "0x22FB380", VA = "0x1822FBF80")]
	public JEDNPGEGKOA<T> LFEOBECAFGO()
	{
		return default(JEDNPGEGKOA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(FNJKJANBIAL), new string[] { })]
public class FNJKJANBIAL : NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	[BOJGNOMIPCG]
	private DOKFAOCNIFN ILDIIFMLPBD;

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x28DB4B0", Offset = "0x28DA8B0", VA = "0x1828DB4B0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public FNJKJANBIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class DECDNJDHOKH : HIJPEHDGBEB<MMNCNJEDPEA>
{
	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x29164C0", Offset = "0x29158C0", VA = "0x1829164C0", Slot = "14")]
	protected override void JBELCECMLIA(NativeArray<Entity> NOEOKDNGNCK, NativeArray<Entity> ENBJPNNFNAJ, NativeArray<Entity> BFJOOFPJKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x2916610", Offset = "0x2915A10", VA = "0x182916610")]
	private static void JBELCECMLIA(NativeArray<Entity> NOEOKDNGNCK, NativeArray<Entity> BFJOOFPJKKE, ComponentDataFromEntity<global::MHNCPPLJJKH> NAJLKANLAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x29166E0", Offset = "0x2915AE0", VA = "0x1829166E0")]
	public DECDNJDHOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class JGPPJBOKGPH : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x28F6520", Offset = "0x28F5920", VA = "0x1828F6520", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public JGPPJBOKGPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
public abstract class FBICFKJAIIM : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private COKHJGJNDIB HJBFJMLNKGK;

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x295EF60", Offset = "0x295E360", VA = "0x18295EF60", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x295EFC0", Offset = "0x295E3C0", VA = "0x18295EFC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x295EFF0", Offset = "0x295E3F0", VA = "0x18295EFF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	protected FBICFKJAIIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
public static class JBOKPDKIPOI
{
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] MPJOPBOBFDE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001E5")]
internal struct HNJJDAMKKGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal struct DODCHLGBNJA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class EDFOOOEDBPJ : CCBLHMCLOCJ
{
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private static EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private EntityQuery OMKFJJGCDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private EntityQuery HGCNHCEJAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private EntityQuery IJLCKEHIDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private EntityQuery KAPIFCHFCHE;

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x294F520", Offset = "0x294E920", VA = "0x18294F520", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x294F6E0", Offset = "0x294EAE0", VA = "0x18294F6E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x294F360", Offset = "0x294E760", VA = "0x18294F360")]
	private void GIPJABMENEF(EntityQuery BEHDAMIMGBM, bool DHGLPENOPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x294F1A0", Offset = "0x294E5A0", VA = "0x18294F1A0")]
	private void FPEJNMGLMCM(EntityQuery BEHDAMIMGBM, bool DHGLPENOPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public EDFOOOEDBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
internal class AFAOJOGDGMD : IPNJFEEEFKG
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	protected override NGPJOPHOOLK JCFDBPMPNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADD")]
		[Cpp2IlInjected.Address(RVA = "0x28FAB50", Offset = "0x28F9F50", VA = "0x1828FAB50", Slot = "15")]
		get
		{
			return default(NGPJOPHOOLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x28FABD0", Offset = "0x28F9FD0", VA = "0x1828FABD0")]
	public AFAOJOGDGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[DefaultMember("Item")]
public struct OFDCNLDBOIC<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	public NativeList<Entity> NOEOKDNGNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	public NativeList<T> CLCAIFLMLCJ;

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public int NMCJNDHCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADF")]
		[Cpp2IlInjected.Address(RVA = "0x23D9290", Offset = "0x23D8690", VA = "0x1823D9290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public (Entity entity, T value) ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE0")]
		[Cpp2IlInjected.Address(RVA = "0x23D8740", Offset = "0x23D7B40", VA = "0x1823D8740")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x23D95C0", Offset = "0x23D89C0", VA = "0x1823D95C0")]
	public void NNFBEGDMHOD(Entity GKMECPLEALF, T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x23D8690", Offset = "0x23D7A90", VA = "0x1823D8690")]
	public void BMHBJEKGFDP(NativeArray<Entity> GKMECPLEALF, NativeArray<T> AGLCIEKHLEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EA")]
[IICIJFGHOAB]
public class OANPLLGCPAI : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private static readonly EHKEPJIBENP KOJCLGMKKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	[BOJGNOMIPCG]
	private GGPOHFHPOPM OJMPJGNAJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	private EntityQuery LBHFNLOKLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	private EntityQuery BNDBOGKDBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D270", Offset = "0x2A7C670", VA = "0x182A7D270", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D050", Offset = "0x2A7C450", VA = "0x182A7D050")]
	public bool HPHFNOHKOKF(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D2E0", Offset = "0x2A7C6E0", VA = "0x182A7D2E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D2C0", Offset = "0x2A7C6C0", VA = "0x182A7D2C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0xED9280", Offset = "0xED8680", VA = "0x180ED9280", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D3C0", Offset = "0x2A7C7C0", VA = "0x182A7D3C0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D2C0", Offset = "0x2A7C6C0", VA = "0x182A7D2C0")]
	private void NDEOKODLILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CD40", Offset = "0x2A7C140", VA = "0x182A7CD40")]
	private void BBCDPLPENHJ(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D100", Offset = "0x2A7C500", VA = "0x182A7D100")]
	private void IFAGOOLJHNK(NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public OANPLLGCPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public struct FANFGPLECFE<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private OFDCNLDBOIC<T> LJJHJABONIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private EntityCommandBuffer JNKKDKMNHPP;

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x1317080", Offset = "0x1316480", VA = "0x181317080")]
	public FANFGPLECFE(OFDCNLDBOIC<T> LJJHJABONIO, EntityCommandBuffer JNKKDKMNHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x1316A70", Offset = "0x1315E70", VA = "0x181316A70", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x1317060", Offset = "0x1316460", VA = "0x181317060")]
	public static OFDCNLDBOIC<T> LFFBPOODCDC(FANFGPLECFE<T> GFDOPOBNKBA)
	{
		return default(OFDCNLDBOIC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EC")]
public static class EINNNAAMCGI
{
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	internal static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x223E730", Offset = "0x223DB30", VA = "0x18223E730")]
	public static void DKPCMCGGMHB<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(IABLIMOJJBC CEMAJLICLCP, ENIPADEGOMD<Entity> OCFGMKDOPDP, out GHKKIEINAJP<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> LBIPEFBIOGK) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LILBGEFEHNB where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LILBGEFEHNB, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x2954180", Offset = "0x2953580", VA = "0x182954180")]
	public static bool NMGBCBEPENG(MDECDPGCMCD CKAMNJPHKHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001ED")]
public class GHKKIEINAJP<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LILBGEFEHNB where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LILBGEFEHNB, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private readonly ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private readonly DFGKOFELELE<Entity> LEMJCNJPDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private readonly CEPHAKHFAFK PGKGEAIIPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private readonly GPKGHEJLJCL OJBGDMNECON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private readonly EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private readonly NFCKPDCDELJ CLAOAKAOJHH;

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x2227150", Offset = "0x2226550", VA = "0x182227150")]
	public GHKKIEINAJP(IABLIMOJJBC CEMAJLICLCP, ENIPADEGOMD<Entity> OCFGMKDOPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x22256F0", Offset = "0x2224AF0", VA = "0x1822256F0")]
	private bool BEGMJIBNBDM(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x2226520", Offset = "0x2225920", VA = "0x182226520")]
	private bool JFEGOLNBIMP(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2226A80", Offset = "0x2225E80", VA = "0x182226A80")]
	private bool PHCPBNLDGMA(Entity GKMECPLEALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x2226490", Offset = "0x2225890", VA = "0x182226490")]
	public bool IHIEJEAIEMM(Entity GKMECPLEALF, in Entity ICPFLJENDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x22257B0", Offset = "0x2224BB0", VA = "0x1822257B0")]
	public bool BPODMKLLIJF(Entity GKMECPLEALF, in Entity ICPFLJENDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x22257E0", Offset = "0x2224BE0", VA = "0x1822257E0")]
	private bool BPODMKLLIJF(Entity GKMECPLEALF, in Entity ICPFLJENDFI, bool IKILHMILMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void EKPOKMEBHLB(Entity GKMECPLEALF, in Entity ICPFLJENDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void DMELMOINNDI(Entity GKMECPLEALF, in Entity ICPFLJENDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void AGPLKBMILDO(Entity GKMECPLEALF, in Entity ICPFLJENDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void HJKJNNNPELO(Entity GKMECPLEALF, in Entity ICPFLJENDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void OHKGOJEBIEH(Entity GKMECPLEALF, in Entity ICPFLJENDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x2226660", Offset = "0x2225A60", VA = "0x182226660")]
	private bool LOJMEIIDDGG(Entity GKMECPLEALF, Entity BGACBDKLDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x2225E80", Offset = "0x2225280", VA = "0x182225E80")]
	private void ENNDIAHALKD(Entity GKMECPLEALF, in Entity PCAHPLBOKJA, in Entity ICPFLJENDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B02")]
	[Cpp2IlInjected.Address(RVA = "0x2226740", Offset = "0x2225B40", VA = "0x182226740")]
	private void OGGILHCAJPJ(Entity GKMECPLEALF, in Entity PCAHPLBOKJA, in Entity ICPFLJENDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B03")]
	[Cpp2IlInjected.Address(RVA = "0x2225F70", Offset = "0x2225370", VA = "0x182225F70")]
	private bool FNKFECEFKNJ(JPKPMPALKHK LICBMLMJHDB, in JDPNCHCMAIA MHOJHDABEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x2225C40", Offset = "0x2225040", VA = "0x182225C40")]
	private void EFGKFCOBOBC(Entity OJBGDMNECON, Entity KEGFIDMGBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x2226370", Offset = "0x2225770", VA = "0x182226370")]
	private void GKKELJKGEHE(Entity OJBGDMNECON, Entity KEGFIDMGBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private void AJLNGAELLMG(Entity GKMECPLEALF, Entity PCAHPLBOKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private void IEJNFEAECGP(Entity GKMECPLEALF, Entity ICPFLJENDFI)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001EE")]
	[CompilerGenerated]
	public class GatherModifiedParents : NILFPPHEEJF, BKHNPHMEICP
	{
		[Cpp2IlInjected.Token(Token = "0x20001EF")]
		[NoAlias]
		[BurstCompile]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			public NativeList<NBMOHGNDFOG> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			[ReadOnly]
			public ComponentTypeHandle<EODNMPFLBLP> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B10")]
			[Cpp2IlInjected.Address(RVA = "0x27B63A0", Offset = "0x27B57A0", VA = "0x1827B63A0")]
			private void OPBILJIDNNC(Entity entity, [NoAlias] in EODNMPFLBLP current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B11")]
			[Cpp2IlInjected.Address(RVA = "0x27B6280", Offset = "0x27B5680", VA = "0x1827B6280", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001F0")]
		[BurstCompile]
		[NoAlias]
		private struct GatherModifiedParents_AddChangedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			public NativeList<BOEBMGGFPKG> changedParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			[ReadOnly]
			public ComponentTypeHandle<EODNMPFLBLP> __currentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			[ReadOnly]
			public ComponentTypeHandle<LMCCJLJHFEM> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B12")]
			[Cpp2IlInjected.Address(RVA = "0x27B61C0", Offset = "0x27B55C0", VA = "0x1827B61C0")]
			private void OPBILJIDNNC(Entity entity, [NoAlias] in EODNMPFLBLP current, [NoAlias] in LMCCJLJHFEM previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B13")]
			[Cpp2IlInjected.Address(RVA = "0x27B6020", Offset = "0x27B5420", VA = "0x1827B6020", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001F1")]
		[BurstCompile]
		[NoAlias]
		private struct GatherModifiedParents_AddRemovedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			public NativeList<NBMOHGNDFOG> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			[ReadOnly]
			public ComponentTypeHandle<LMCCJLJHFEM> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B14")]
			[Cpp2IlInjected.Address(RVA = "0x27B6540", Offset = "0x27B5940", VA = "0x1827B6540")]
			private void OPBILJIDNNC(Entity entity, [NoAlias] in LMCCJLJHFEM previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B15")]
			[Cpp2IlInjected.Address(RVA = "0x27B6420", Offset = "0x27B5820", VA = "0x1827B6420", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private NFCKPDCDELJ parentEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private EntityQuery GatherModifiedParents_AddNewParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private EntityQuery GatherModifiedParents_AddChangedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private EntityQuery GatherModifiedParents_AddRemovedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private ComponentTypeHandle<EODNMPFLBLP> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private ComponentTypeHandle<LMCCJLJHFEM> __RecRoom_Components_PreviousParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x28E27D0", Offset = "0x28E1BD0", VA = "0x1828E27D0", Slot = "14")]
		public void NOIFEHLCEFG(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x28E3070", Offset = "0x28E2470", VA = "0x1828E3070", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x28E2530", Offset = "0x28E1930", VA = "0x1828E2530")]
		private JobHandle AGKLNKJLJBH(NativeList<NBMOHGNDFOG> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x28E2660", Offset = "0x28E1A60", VA = "0x1828E2660")]
		private JobHandle HODECJNFJJI(NativeList<BOEBMGGFPKG> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x28E28B0", Offset = "0x28E1CB0", VA = "0x1828E28B0")]
		private JobHandle OIFEFFIJKJM(NativeList<NBMOHGNDFOG> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x28E29E0", Offset = "0x28E1DE0", VA = "0x1828E29E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public GatherModifiedParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F2")]
[UpdateBefore(typeof(OEFEHELLEJJ))]
public class MGLANHLKELD : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private NBPNODCEBKF FBJJPAAFOIC;

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x2A71100", Offset = "0x2A70500", VA = "0x182A71100", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B17")]
	[Cpp2IlInjected.Address(RVA = "0x2A71150", Offset = "0x2A70550", VA = "0x182A71150", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B18")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public MGLANHLKELD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F3")]
[EPJIKDLNGEH(typeof(DEMPLIAGLNN), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal class DEMPLIAGLNN : DIFPONKGMOA, NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001F5")]
	[CompilerGenerated]
	private sealed class DHFIKDKEHGE : IEnumerable<(DJOJBOPMMAC, IMPAOGMALJN)>, IEnumerable, IEnumerator<(DJOJBOPMMAC, IMPAOGMALJN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private (DJOJBOPMMAC primitiveType, IMPAOGMALJN prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public DEMPLIAGLNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private int <i>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private DJOJBOPMMAC <primitiveType>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private IMPAOGMALJN <prefabType>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		private (DJOJBOPMMAC, IMPAOGMALJN) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B37")]
			[Cpp2IlInjected.Address(RVA = "0x225AB50", Offset = "0x2259F50", VA = "0x18225AB50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((DJOJBOPMMAC, IMPAOGMALJN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x27B2260", Offset = "0x27B1660", VA = "0x1827B2260", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x27B22B0", Offset = "0x27B16B0", VA = "0x1827B22B0")]
		[DebuggerHidden]
		public DHFIKDKEHGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x27B20A0", Offset = "0x27B14A0", VA = "0x1827B20A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x27B2220", Offset = "0x27B1620", VA = "0x1827B2220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x27B2180", Offset = "0x27B1580", VA = "0x1827B2180", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(DJOJBOPMMAC, IMPAOGMALJN)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x27B2180", Offset = "0x27B1580", VA = "0x1827B2180", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065A")]
	private World GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400065B")]
	private NativeParallelHashMap<int, Entity> PJGJLPEKIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	private NativeParallelHashMap<int, EntityArchetype> OPIAGALIIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private NativeParallelHashMap<int, int> KJBNOGJOPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private IMPAOGMALJN[] HGLHDDKIKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private readonly Dictionary<DJOJBOPMMAC, IMPAOGMALJN> JKEDJNLMICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private readonly Dictionary<HMPGJEKMJBE, IMPAOGMALJN> GBHMAGEKABP;

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x2917100", Offset = "0x2916500", VA = "0x182917100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0xA7C430", Offset = "0xA7B830", VA = "0x180A7C430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1D")]
	[Cpp2IlInjected.Address(RVA = "0x29173A0", Offset = "0x29167A0", VA = "0x1829173A0", Slot = "5")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1E")]
	[Cpp2IlInjected.Address(RVA = "0x2916A60", Offset = "0x2915E60", VA = "0x182916A60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1F")]
	[Cpp2IlInjected.Address(RVA = "0x9857E0", Offset = "0x984BE0", VA = "0x1809857E0")]
	internal NativeParallelHashMap<int, Entity> DFKDGHFIGJP()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B20")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E60", Offset = "0xCE6260", VA = "0x180CE6E60")]
	internal NativeParallelHashMap<int, EntityArchetype> JGONIKBMKJI()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B21")]
	[Cpp2IlInjected.Address(RVA = "0x985800", Offset = "0x984C00", VA = "0x180985800")]
	internal NativeParallelHashMap<int, int> CHMDCCMJCCM()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B22")]
	[Cpp2IlInjected.Address(RVA = "0x2917FD0", Offset = "0x29173D0", VA = "0x182917FD0")]
	internal IEnumerable<Type> MOPKEKNOFCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B23")]
	[Cpp2IlInjected.Address(RVA = "0x2916880", Offset = "0x2915C80", VA = "0x182916880")]
	internal AAOKHJFFILP BFICJNMPAEN(Type GANFKPHKNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B24")]
	[Cpp2IlInjected.Address(RVA = "0x2917330", Offset = "0x2916730", VA = "0x182917330")]
	public EntityArchetype IIHIBANPOIL(IMPAOGMALJN JBGKOICMKNG)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B25")]
	[Cpp2IlInjected.Address(RVA = "0x29172C0", Offset = "0x29166C0", VA = "0x1829172C0", Slot = "4")]
	[IteratorStateMachine(typeof(DHFIKDKEHGE))]
	public IEnumerable<(DJOJBOPMMAC, IMPAOGMALJN)> ICENLMBENOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B26")]
	[Cpp2IlInjected.Address(RVA = "0x2918030", Offset = "0x2917430", VA = "0x182918030")]
	public Entity OHHBKCKEINJ(IMPAOGMALJN JBGKOICMKNG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B27")]
	[Cpp2IlInjected.Address(RVA = "0x2917140", Offset = "0x2916540", VA = "0x182917140")]
	public void HJEEPAEIHCP(NativeArray<IMPAOGMALJN> HGLHDDKIKCC, NativeArray<Entity> AMBAOGAFEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B28")]
	[Cpp2IlInjected.Address(RVA = "0x2918120", Offset = "0x2917520", VA = "0x182918120")]
	public void PAOFNNOAKCG(IMPAOGMALJN JBGKOICMKNG, NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B29")]
	[Cpp2IlInjected.Address(RVA = "0x2917E90", Offset = "0x2917290", VA = "0x182917E90")]
	public IMPAOGMALJN LOONLFGPLMG(DJOJBOPMMAC GANFKPHKNKH)
	{
		return default(IMPAOGMALJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2A")]
	[Cpp2IlInjected.Address(RVA = "0x2917EF0", Offset = "0x29172F0", VA = "0x182917EF0")]
	public Entity MEBLBGLIJCG(IMPAOGMALJN JBGKOICMKNG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2B")]
	[Cpp2IlInjected.Address(RVA = "0x2918170", Offset = "0x2917570", VA = "0x182918170")]
	private void PHBMDGHJPHP(AAOKHJFFILP CKEKPGDMMKA, NativeList<int> HGLHDDKIKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2C")]
	[Cpp2IlInjected.Address(RVA = "0x2916DD0", Offset = "0x29161D0", VA = "0x182916DD0")]
	internal void HCPBOGOAKFG(IMPAOGMALJN JBGKOICMKNG, ComponentTypeList EBNDPHJDIPK, COKILELHEJE PIDKFJKABFI, AAOKHJFFILP CKEKPGDMMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2D")]
	[Cpp2IlInjected.Address(RVA = "0x29168F0", Offset = "0x2915CF0", VA = "0x1829168F0")]
	private EntityArchetype BJLCHKNJHEO(IMPAOGMALJN JBGKOICMKNG, ComponentTypeList OEBIFBLEMHJ)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2E")]
	[Cpp2IlInjected.Address(RVA = "0x2918500", Offset = "0x2917900", VA = "0x182918500")]
	public DEMPLIAGLNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F6")]
[EPJIKDLNGEH(typeof(LJNPGILBMKJ), new string[] { })]
public class HCIMKMBGJOF : NEHPEGODEDF, LJNPGILBMKJ
{
	[Cpp2IlInjected.Token(Token = "0x20001F7")]
	[CompilerGenerated]
	private sealed class JIGFCGMPGBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public GDCONIFJKEF objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public HEKFLAGDMLJ parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public HCIMKMBGJOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private MDECDPGCMCD <parentObject>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private Vector3 <pos>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private Quaternion <rot>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JIGFCGMPGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4E")]
		[Cpp2IlInjected.Address(RVA = "0x27B7D10", Offset = "0x27B7110", VA = "0x1827B7D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001F8")]
	[CompilerGenerated]
	private sealed class ANDAAPKBIHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public MDECDPGCMCD obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public HCIMKMBGJOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ANDAAPKBIHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x27AECC0", Offset = "0x27AE0C0", VA = "0x1827AECC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	[BOJGNOMIPCG]
	private PNJKCGEKCHD EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.Token(Token = "0x6000B3C")]
	[Cpp2IlInjected.Address(RVA = "0x28E48F0", Offset = "0x28E3CF0", VA = "0x1828E48F0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3D")]
	[Cpp2IlInjected.Address(RVA = "0x28E5220", Offset = "0x28E4620", VA = "0x1828E5220", Slot = "5")]
	public bool PIDCGHFEMCA(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3E")]
	[Cpp2IlInjected.Address(RVA = "0x28E4F80", Offset = "0x28E4380", VA = "0x1828E4F80", Slot = "7")]
	public bool NHHLJEGKOGI(HEKFLAGDMLJ LEMCMBEMOCB, out Guid AANELEBBHAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3F")]
	[Cpp2IlInjected.Address(RVA = "0x28E3C00", Offset = "0x28E3000", VA = "0x1828E3C00", Slot = "8")]
	public Guid CNHCPHPAEPD(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B40")]
	[Cpp2IlInjected.Address(RVA = "0x28E4600", Offset = "0x28E3A00", VA = "0x1828E4600", Slot = "9")]
	public void IHKEJEODIPF(HEKFLAGDMLJ LEMCMBEMOCB, Guid AANELEBBHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B41")]
	[Cpp2IlInjected.Address(RVA = "0x28E4990", Offset = "0x28E3D90", VA = "0x1828E4990", Slot = "10")]
	public bool KCFEBCKBICI(HEKFLAGDMLJ LEMCMBEMOCB, out Guid MNLPDHHHFIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B42")]
	[Cpp2IlInjected.Address(RVA = "0x28E4190", Offset = "0x28E3590", VA = "0x1828E4190", Slot = "11")]
	public Guid EGOPOHCLDNE(HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B43")]
	[Cpp2IlInjected.Address(RVA = "0x28E3EA0", Offset = "0x28E32A0", VA = "0x1828E3EA0", Slot = "12")]
	public void EEPLPMNOMOL(HEKFLAGDMLJ LEMCMBEMOCB, Guid MNLPDHHHFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B44")]
	[Cpp2IlInjected.Address(RVA = "0x28E4ED0", Offset = "0x28E42D0", VA = "0x1828E4ED0", Slot = "13")]
	public void LEPGKOCONPI(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B45")]
	[Cpp2IlInjected.Address(RVA = "0x28E4AB0", Offset = "0x28E3EB0", VA = "0x1828E4AB0", Slot = "14")]
	public void KJHACINJHPO(HEKFLAGDMLJ JNHEGOFDJBP, HEKFLAGDMLJ OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B46")]
	[Cpp2IlInjected.Address(RVA = "0x28E50A0", Offset = "0x28E44A0", VA = "0x1828E50A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JIGFCGMPGBA))]
	private Task PBFOOAKMKJC(GDCONIFJKEF GIJAGJDPJFB, HEKFLAGDMLJ OJBGDMNECON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B47")]
	[Cpp2IlInjected.Address(RVA = "0x28E5350", Offset = "0x28E4750", VA = "0x1828E5350")]
	private void PIPDIGNLNFN(GDCONIFJKEF GIJAGJDPJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B48")]
	[Cpp2IlInjected.Address(RVA = "0x28E3D50", Offset = "0x28E3150", VA = "0x1828E3D50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ANDAAPKBIHL))]
	private Task DDCFEPKALPE(MDECDPGCMCD HFAGBIOODHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B49")]
	[Cpp2IlInjected.Address(RVA = "0x28E4370", Offset = "0x28E3770", VA = "0x1828E4370")]
	private Task IFGELPBDJFN(MDECDPGCMCD HFAGBIOODHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4A")]
	[Cpp2IlInjected.Address(RVA = "0x28E42E0", Offset = "0x28E36E0", VA = "0x1828E42E0", Slot = "6")]
	public bool GLEDIKEEJGK(HEKFLAGDMLJ JBFCCDGDFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4B")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public HCIMKMBGJOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F9")]
internal class HODPJCAFLOG : DKFENIMBODI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001FA")]
	public struct KKHHCCKCCFF : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400067D")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	protected override ComponentType OKLPIHFJNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x28E9A20", Offset = "0x28E8E20", VA = "0x1828E9A20", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	protected override ComponentType OMNLNLCFBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x28E99C0", Offset = "0x28E8DC0", VA = "0x1828E99C0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	protected override ComponentType LOJAJIIODNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x28E99F0", Offset = "0x28E8DF0", VA = "0x1828E99F0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B53")]
	[Cpp2IlInjected.Address(RVA = "0x28E9AE0", Offset = "0x28E8EE0", VA = "0x1828E9AE0")]
	public HODPJCAFLOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FB")]
internal abstract class HIJPEHDGBEB<TPlayerTag> : NILFPPHEEJF where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private EntityQuery OKDNBCPJIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private EntityQuery PHNOEDMCIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private EntityQuery HGCGKEDHLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private EntityQuery LIBHNDFNNHM;

	[Cpp2IlInjected.Token(Token = "0x6000B58")]
	[Cpp2IlInjected.Address(RVA = "0x2084BC0", Offset = "0x2083FC0", VA = "0x182084BC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B59")]
	[Cpp2IlInjected.Address(RVA = "0x2084F90", Offset = "0x2084390", VA = "0x182084F90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5A")]
	[Cpp2IlInjected.Address(RVA = "0x2084F60", Offset = "0x2084360", VA = "0x182084F60", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5B")]
	[Cpp2IlInjected.Address(RVA = "0x2083C20", Offset = "0x2083020", VA = "0x182083C20")]
	private void NKONPKHIMKF(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5C")]
	[Cpp2IlInjected.Address(RVA = "0x2083870", Offset = "0x2082C70", VA = "0x182083870")]
	private void JNMCLOALJCO(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5D")]
	[Cpp2IlInjected.Address(RVA = "0x20843E0", Offset = "0x20837E0", VA = "0x1820843E0")]
	private void NNJCDFGLHLG(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void JBELCECMLIA(NativeArray<Entity> NOEOKDNGNCK, NativeArray<Entity> ENBJPNNFNAJ, NativeArray<Entity> BFJOOFPJKKE);

	[Cpp2IlInjected.Token(Token = "0x6000B5F")]
	[Cpp2IlInjected.Address(RVA = "0x2085020", Offset = "0x2084420", VA = "0x182085020")]
	protected HIJPEHDGBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FC")]
[AlwaysUpdateSystem]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class JFIHJBCKELM : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	[BOJGNOMIPCG]
	private JEGMBOPKKDO PHLDDLGGOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	[BOJGNOMIPCG]
	private JJLJCDMIEAB OLJMDFOPLAI;

	[Cpp2IlInjected.Token(Token = "0x6000B60")]
	[Cpp2IlInjected.Address(RVA = "0x28F0C60", Offset = "0x28F0060", VA = "0x1828F0C60", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B61")]
	[Cpp2IlInjected.Address(RVA = "0x28F0CF0", Offset = "0x28F00F0", VA = "0x1828F0CF0")]
	protected void MJKDOAKLFCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B62")]
	[Cpp2IlInjected.Address(RVA = "0x28F0D70", Offset = "0x28F0170", VA = "0x1828F0D70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B63")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public JFIHJBCKELM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001FD")]
public struct ANOKDAPKHNG : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	public static readonly ANOKDAPKHNG KCIIGNIKLNC;

	[Cpp2IlInjected.Token(Token = "0x6000B64")]
	[Cpp2IlInjected.Address(RVA = "0x28FBF50", Offset = "0x28FB350", VA = "0x1828FBF50", Slot = "4")]
	public bool Equals(LinkedEntityGroup EOMIKPKMCAG, LinkedEntityGroup PPNFDCNFKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B65")]
	[Cpp2IlInjected.Address(RVA = "0x28FBF70", Offset = "0x28FB370", VA = "0x1828FBF70", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup HFAGBIOODHL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FE")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class KNGLLDFMPJJ : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private FDDOEJHEPEH GFGMELPMDGA;

	[Cpp2IlInjected.Token(Token = "0x6000B67")]
	[Cpp2IlInjected.Address(RVA = "0x2A649D0", Offset = "0x2A63DD0", VA = "0x182A649D0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B68")]
	[Cpp2IlInjected.Address(RVA = "0x2A64A20", Offset = "0x2A63E20", VA = "0x182A64A20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B69")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public KNGLLDFMPJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FF")]
internal abstract class LPMKPFADJKH : CLDIIDMFCAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private EntityQuery CLACKKFNJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private EntityQuery COAAACCMKPA;

	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EE50", Offset = "0x2A6E250", VA = "0x182A6EE50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F1D0", Offset = "0x2A6E5D0", VA = "0x182A6F1D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EDA0", Offset = "0x2A6E1A0", VA = "0x182A6EDA0")]
	private void CEOEEFKLLJJ(EntityQuery BEHDAMIMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F280", Offset = "0x2A6E680", VA = "0x182A6F280")]
	protected LPMKPFADJKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000201")]
public class INEJLKPGHJD : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000B70")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B71")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public INEJLKPGHJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000202")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class PFBDABECPLN : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	private KPNAFCNKGOC OJPBCBIFPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private LFMJEINKAPC BHEMNPHLEJM;

	[Cpp2IlInjected.Token(Token = "0x6000B72")]
	[Cpp2IlInjected.Address(RVA = "0x2483690", Offset = "0x2482A90", VA = "0x182483690", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x2483720", Offset = "0x2482B20", VA = "0x182483720", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B74")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public PFBDABECPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000203")]
[EPJIKDLNGEH(typeof(KNNCGINAGFA), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
internal sealed class KNNCGINAGFA : NEHPEGODEDF, BKHNPHMEICP
{
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	[BOJGNOMIPCG]
	private GGNFHIGGHPN IIGHBGGPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private DFGKOFELELE<Entity> LEMJCNJPDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private GHKKIEINAJP<EODNMPFLBLP, LMCCJLJHFEM, HJPPACGEKOP, NCPPJPJLJPP> IAHDAGMCMBE;

	[Cpp2IlInjected.Token(Token = "0x6000B76")]
	[Cpp2IlInjected.Address(RVA = "0x2A64B40", Offset = "0x2A63F40", VA = "0x182A64B40", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B77")]
	[Cpp2IlInjected.Address(RVA = "0x2A64B90", Offset = "0x2A63F90", VA = "0x182A64B90", Slot = "5")]
	public void NOIFEHLCEFG(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x2A64F00", Offset = "0x2A64300", VA = "0x182A64F00")]
	public Entity OPCIHBBNLKJ(Entity GKMECPLEALF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x2A64AE0", Offset = "0x2A63EE0", VA = "0x182A64AE0")]
	public bool IHIEJEAIEMM(Entity GKMECPLEALF, Entity ICPFLJENDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x2A64A40", Offset = "0x2A63E40", VA = "0x182A64A40")]
	public bool CILNNMACHKK(Entity GKMECPLEALF, Entity ICPFLJENDFI, bool KJNJDCMKFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x2A64CD0", Offset = "0x2A640D0", VA = "0x182A64CD0")]
	private bool ODADNADFHAH(Entity GKMECPLEALF, Entity ICPFLJENDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public KNNCGINAGFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000204")]
internal readonly struct CFGMAIBJPMM
{
	[Cpp2IlInjected.Token(Token = "0x2000205")]
	[BurstCompile]
	private struct IDFHMPMHHKJ : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		[ReadOnly]
		public EntityTypeHandle OAHOKNMIOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		[ReadOnly]
		public ComponentDataFromEntity<LNKBMNDCLBA> NEHMGLNKCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		[ReadOnly]
		public DynamicComponentTypeHandle BCBHDNDGKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> AEFCGGAFEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> ADINEOHEFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		[ReadOnly]
		public ComponentDataFromEntity KMPKMFCPNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly BGKIIOOLHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		[ReadOnly]
		public NativeArray<EEMOBOLLAKL>.ReadOnly KPHOKAKKKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public ComponentDataFromEntity NHAELJMKOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public NativeList<Entity> EHHJJNJJFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public NativeList<Entity> ADACHANLGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public NativeList<byte> JDFPAKGNDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public NativeList<byte> BNBEEAOJMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public NativeList<byte> EKJKBDOFKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public int GDKDDPCMMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public int EMFEDKKDAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public bool OLIECOBHPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public BOJCCJMKNAG.PKECAOCFACM ADMMGKCBODC;

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x27B6A00", Offset = "0x27B5E00", VA = "0x1827B6A00", Slot = "4")]
		public void Execute(ArchetypeChunk DHCAFCLHBAO, int JGOFFILAMJM, int OLGOGAFHIIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B85")]
		[Cpp2IlInjected.Address(RVA = "0x27B6D70", Offset = "0x27B6170", VA = "0x1827B6D70")]
		private unsafe bool JHMDIIGOGIC(Entity KGPIFFKHLCF, Entity FLADKEBJBBN, byte* IJKDFHLHPKH, byte* GGHJFEBLHDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B86")]
		[Cpp2IlInjected.Address(RVA = "0x27B69E0", Offset = "0x27B5DE0", VA = "0x1827B69E0")]
		private unsafe void EMCLIHJFPMF(byte* IJKDFHLHPKH, byte* GGHJFEBLHDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B87")]
		[Cpp2IlInjected.Address(RVA = "0x27B6F80", Offset = "0x27B6380", VA = "0x1827B6F80")]
		private unsafe byte* MJGJJNEHLKH(NativeArray<byte> DJFGBDGCPPK, int APEMPONKPBB)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B88")]
		[Cpp2IlInjected.Address(RVA = "0x27B6970", Offset = "0x27B5D70", VA = "0x1827B6970")]
		private unsafe byte* DBLJEJAPABP(Entity FLADKEBJBBN)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x27B7020", Offset = "0x27B6420", VA = "0x1827B7020")]
		private unsafe byte* OBGFEFDLJKL(ArchetypeChunk DHCAFCLHBAO)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x27B6F40", Offset = "0x27B6340", VA = "0x1827B6F40")]
		private static Entity JJBAGEGIPPO(in LNKBMNDCLBA CLCAIFLMLCJ)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000206")]
	[BurstCompile]
	private struct MGJDHAHLIFG : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		[ReadOnly]
		public NativeList<Entity> NJAMLKFKEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		[ReadOnly]
		public NativeList<byte> BKNGGPBFPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		[ReadOnly]
		public NativeList<byte> NDKGEPBADIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		[ReadOnly]
		public NativeList<byte> DOKBJIFOEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		[ReadOnly]
		public NativeArray<EEMOBOLLAKL>.ReadOnly KPHOKAKKKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public NativeParallelMultiHashMap<Entity, OFDKMKMCECL> IIPIJPOOCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int GDKDDPCMMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public int EMFEDKKDAGH;

		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(RVA = "0x27B99C0", Offset = "0x27B8DC0", VA = "0x1827B99C0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private static readonly ProfilerMarker KFHNGFCGHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private readonly NILFPPHEEJF GDOFPEAGKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private readonly World OKHCNMBCCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private readonly LJPBJFAFPOA ALBPJGCMMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private readonly NativeParallelHashMap<int, Entity> BMFMDNEJCLH;

	[Cpp2IlInjected.Token(Token = "0x6000B7E")]
	[Cpp2IlInjected.Address(RVA = "0x2905D50", Offset = "0x2905150", VA = "0x182905D50")]
	public CFGMAIBJPMM(NILFPPHEEJF GDOFPEAGKBE, World OKHCNMBCCNM, KPNAFCNKGOC GOLCMKBOFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7F")]
	[Cpp2IlInjected.Address(RVA = "0x2905110", Offset = "0x2904510", VA = "0x182905110")]
	public JobHandle GLINDFMMGLK(JCEINDAJIBO HEAMCFPFNOL, NativeList<(EntityQuery query, int typeIndex, int count, BOJCCJMKNAG.PKECAOCFACM mode)> NEJHPGNLCPA, JobHandle BMMIBMDGEID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x29057F0", Offset = "0x2904BF0", VA = "0x1829057F0")]
	private MGJDHAHLIFG OLHFJHMHBIL(in IDFHMPMHHKJ KJJNJKAEJHE, NativeParallelMultiHashMap<Entity, OFDKMKMCECL> AHLAJPCNODL)
	{
		return default(MGJDHAHLIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x2905860", Offset = "0x2904C60", VA = "0x182905860")]
	private IDFHMPMHHKJ PMBAHAJFBDC(ComponentType OOMLHJHCPCJ, EntityManager ICMBPPDLCAJ, int HNLBICMFANA, BOJCCJMKNAG.PKECAOCFACM ADMMGKCBODC)
	{
		return default(IDFHMPMHHKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x2904F40", Offset = "0x2904340", VA = "0x182904F40")]
	private static void GIKKHEFBCDL(JCEINDAJIBO HEAMCFPFNOL, ComponentType OOMLHJHCPCJ, JobHandle PDLPHPDOMPP, in IDFHMPMHHKJ KJJNJKAEJHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000207")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class CIMDCOFBEPO : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	private BLLGOKJBFOC IIGHBGGPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private LFMJEINKAPC BHEMNPHLEJM;

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x2907C80", Offset = "0x2907080", VA = "0x182907C80", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8D")]
	[Cpp2IlInjected.Address(RVA = "0x2908600", Offset = "0x2907A00", VA = "0x182908600", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8E")]
	[Cpp2IlInjected.Address(RVA = "0x29086A0", Offset = "0x2907AA0", VA = "0x1829086A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8F")]
	[Cpp2IlInjected.Address(RVA = "0x2907E20", Offset = "0x2907220", VA = "0x182907E20")]
	private void KKAGAALLNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B90")]
	[Cpp2IlInjected.Address(RVA = "0x2907D10", Offset = "0x2907110", VA = "0x182907D10")]
	private void JCOGBMMCDOD(NativeArray<Entity> CLIPADKCFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B91")]
	[Cpp2IlInjected.Address(RVA = "0x2907440", Offset = "0x2906840", VA = "0x182907440")]
	private void FPGPKDBNNBG(NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B92")]
	[Cpp2IlInjected.Address(RVA = "0x2908490", Offset = "0x2907890", VA = "0x182908490")]
	private void LNNLFKGLGNH(NativeArray<Entity> GGDHPGMOAFC, NativeArray<RigidTransform> OKOKNPNJDMK, NativeArray<RigidTransform> HOHFDFBDJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x2906FC0", Offset = "0x29063C0", VA = "0x182906FC0")]
	private void FEPICHAPHJD(NativeArray<RigidTransform> HOHFDFBDJAB, NativeArray<Entity> GGDHPGMOAFC, NativeList<Entity> PAHFIOEHLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public CIMDCOFBEPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class GGMDHJCHDJF : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x28DCCB0", Offset = "0x28DC0B0", VA = "0x1828DCCB0", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B97")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public GGMDHJCHDJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
internal abstract class DFCPJAAPILG : MGAGGMBOOMG, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private KPNAFCNKGOC GOLCMKBOFGH;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	protected abstract NGLJBCFJFFJ BNNGAFLNGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x2945270", Offset = "0x2944670", VA = "0x182945270", Slot = "16")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x29452C0", Offset = "0x29446C0", VA = "0x1829452C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x2944E60", Offset = "0x2944260", VA = "0x182944E60", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	protected DFCPJAAPILG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020A")]
public class AKDNMFLOOAC : NILFPPHEEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private GJBAGKCKADE ICHBDANIEME;

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x28FB680", Offset = "0x28FAA80", VA = "0x1828FB680", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x28FB750", Offset = "0x28FAB50", VA = "0x1828FB750", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public AKDNMFLOOAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020B")]
[UpdateAfter(typeof(MFCDLNDOLGP))]
public class LJNBLOPJCCO : NILFPPHEEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private EntityArchetype BIAGOHLLIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CF20", Offset = "0x2A6C320", VA = "0x182A6CF20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D010", Offset = "0x2A6C410", VA = "0x182A6D010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CED0", Offset = "0x2A6C2D0", VA = "0x182A6CED0")]
	private EntityCommandBufferSystem MAIDFODBFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public LJNBLOPJCCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020C")]
internal class JGOANAPNCJB : DKFENIMBODI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200020D")]
	public struct JODBDGLIPDB : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	protected override ComponentType OKLPIHFJNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x28F63F0", Offset = "0x28F57F0", VA = "0x1828F63F0", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	protected override ComponentType OMNLNLCFBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x28F6390", Offset = "0x28F5790", VA = "0x1828F6390", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	protected override ComponentType LOJAJIIODNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x28F63C0", Offset = "0x28F57C0", VA = "0x1828F63C0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA5")]
	[Cpp2IlInjected.Address(RVA = "0x28F64B0", Offset = "0x28F58B0", VA = "0x1828F64B0")]
	public JGOANAPNCJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020E")]
[AlwaysUpdateSystem]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class EOOCENLELNK : NILFPPHEEJF, NEHPEGODEDF, GMHONDBOJEM
{
	[Cpp2IlInjected.Token(Token = "0x200020F")]
	[CompilerGenerated]
	private sealed class AIAJDCNEEGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public HEKFLAGDMLJ localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public HCMODPLKBON collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public CBLMAECOKDO containerFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public bool physicsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public bool gravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public bool hasUnityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public EOOCENLELNK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AIAJDCNEEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x27AEAE0", Offset = "0x27ADEE0", VA = "0x1827AEAE0")]
		internal void PPJIONJOMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x27AE9C0", Offset = "0x27ADDC0", VA = "0x1827AE9C0")]
		internal void BGDCEIKCELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x27AE880", Offset = "0x27ADC80", VA = "0x1827AE880")]
		internal void BFBNGAJBADA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	[BOJGNOMIPCG]
	private JJLJCDMIEAB OLJMDFOPLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	[BOJGNOMIPCG]
	private BEAMFJPLEGH OBNOKFDCHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	[BOJGNOMIPCG]
	private MAFOFLPIDLK AKOBMCIAGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	public ComponentTypeHandle<CBLMAECOKDO> AOGKMDMIOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	public ComponentTypeHandle<EKIJOGFFHLI> PGCLDALLHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	public ComponentTypeHandle<AOILHOBPGBG> MHKBELFPDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	public ComponentTypeHandle<HNFKHNCLACN> FPLBLNKLJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	public ComponentTypeHandle<KLNPDGMJJML> AGBLJMBKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	public DynamicComponentTypeHandle JHEBDCEDFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	public EntityTypeHandle OJNLLHIJIBH;

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x2959E50", Offset = "0x2959250", VA = "0x182959E50", Slot = "15")]
	public void BAEFCGCBCNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x295A3F0", Offset = "0x29597F0", VA = "0x18295A3F0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAC")]
	[Cpp2IlInjected.Address(RVA = "0x295A4A0", Offset = "0x29598A0", VA = "0x18295A4A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAD")]
	[Cpp2IlInjected.Address(RVA = "0x2959F10", Offset = "0x2959310", VA = "0x182959F10")]
	private void EDCLDEPIEJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAE")]
	[Cpp2IlInjected.Address(RVA = "0x295A0E0", Offset = "0x29594E0", VA = "0x18295A0E0")]
	private bool IIMFMDHCKIK(out int ANKHDFKKMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAF")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public EOOCENLELNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000210")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public sealed class AEEDNFGLKML : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private NJNJAPPDECP GGAOKDLNNDD;

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x28FAAD0", Offset = "0x28F9ED0", VA = "0x1828FAAD0", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB6")]
	[Cpp2IlInjected.Address(RVA = "0x28FAB30", Offset = "0x28F9F30", VA = "0x1828FAB30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB7")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public AEEDNFGLKML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000211")]
internal abstract class IPNJFEEEFKG : CLDIIDMFCAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x6000BB8")]
	[Cpp2IlInjected.Address(RVA = "0x28ECC30", Offset = "0x28EC030", VA = "0x1828ECC30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB9")]
	[Cpp2IlInjected.Address(RVA = "0x28ECF10", Offset = "0x28EC310", VA = "0x1828ECF10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBA")]
	[Cpp2IlInjected.Address(RVA = "0x28EA9D0", Offset = "0x28E9DD0", VA = "0x1828EA9D0")]
	protected IPNJFEEEFKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000212")]
[AlwaysUpdateSystem]
public class BOJCCJMKNAG : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x2000213")]
	public enum PKECAOCFACM
	{
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		Remove
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL JPBBMKJHAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	[BOJGNOMIPCG]
	private KPNAFCNKGOC GOLCMKBOFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private FCNEOLBGCGK IJHNFOMGKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private OJFEGHECHFL AKNLHADEDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private KCGEPNLLLGL DBDDNHGOPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private HMEAKIFOEIM FFBGFFBNNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private CFGMAIBJPMM FGKJNODLLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private BFOGCKHMEOJ HNDNOCCCGKP;

	[Cpp2IlInjected.Token(Token = "0x6000BBB")]
	[Cpp2IlInjected.Address(RVA = "0x2902040", Offset = "0x2901440", VA = "0x182902040", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBC")]
	[Cpp2IlInjected.Address(RVA = "0x29023E0", Offset = "0x29017E0", VA = "0x1829023E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBD")]
	[Cpp2IlInjected.Address(RVA = "0x29024D0", Offset = "0x29018D0", VA = "0x1829024D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBE")]
	[Cpp2IlInjected.Address(RVA = "0x2902310", Offset = "0x2901710", VA = "0x182902310")]
	private void LAKILNDBDMM(out NativeArray<JDPNCHCMAIA> AMMLHKPHIHN, out NativeArray<BACOLBMJCKD> LHMBGJCLFKL, out NativeArray<JDPNCHCMAIA> NKBMDMOANEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBF")]
	[Cpp2IlInjected.Address(RVA = "0x29024C0", Offset = "0x29018C0", VA = "0x1829024C0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC0")]
	[Cpp2IlInjected.Address(RVA = "0x2902450", Offset = "0x2901850", VA = "0x182902450", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC1")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public BOJCCJMKNAG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000214")]
	[CompilerGenerated]
	[BOFOINMHPHO(FGCKLJIPPNH.OMRoom)]
	public class PostLoadInitializeNetworkId : NILFPPHEEJF, NEHPEGODEDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000215")]
		[NoAlias]
		[BurstCompile]
		private struct PostLoadInitializeNetworkId_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x2000216")]
			public delegate void RunWithoutJobSystem_00000DD3$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000217")]
			internal static class RunWithoutJobSystem_00000DD3$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40006F3")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40006F4")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BDC")]
				[Cpp2IlInjected.Address(RVA = "0x4C511C0", Offset = "0x4C505C0", VA = "0x184C511C0")]
				[BurstDiscard]
				private static void PPBJJPEFDAD(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BDD")]
				[Cpp2IlInjected.Address(RVA = "0x4C51030", Offset = "0x4C50430", VA = "0x184C51030")]
				private static IntPtr OADLLJMHHGD()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BDE")]
				[Cpp2IlInjected.Address(RVA = "0x4C50D30", Offset = "0x4C50130", VA = "0x184C50D30")]
				public static void KNPKHMCBHMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BDF")]
				[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
				public static void MHIDNOPDKCM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BE1")]
				[Cpp2IlInjected.Address(RVA = "0x4C50DF0", Offset = "0x4C501F0", VA = "0x184C50DF0")]
				public static void LABHLMFNFCH(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public NativeParallelHashMap<JDPNCHCMAIA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public uint playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public uint offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			public ComponentTypeHandle<CCNJGHCPMLN> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BD4")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E1D0", Offset = "0x4C4D5D0", VA = "0x184C4E1D0")]
			private void OPBILJIDNNC(Entity entity, int entityInQueryIndex, [NoAlias] ref CCNJGHCPMLN dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD5")]
			[Cpp2IlInjected.Address(RVA = "0x4C4DFA0", Offset = "0x4C4D3A0", VA = "0x184C4DFA0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD6")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E160", Offset = "0x4C4D560", VA = "0x184C4E160")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void IEKCDBAOBHK(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD7")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E0E0", Offset = "0x4C4D4E0", VA = "0x184C4E0E0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void HLCPEFLMIJJ(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000218")]
		[NoAlias]
		[BurstCompile]
		private struct PostLoadInitializeNetworkId_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.Token(Token = "0x2000219")]
			public delegate void RunWithoutJobSystem_00000DD6$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x200021A")]
			internal static class RunWithoutJobSystem_00000DD6$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40006FB")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40006FC")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BEA")]
				[Cpp2IlInjected.Address(RVA = "0x4C51A20", Offset = "0x4C50E20", VA = "0x184C51A20")]
				[BurstDiscard]
				private static void PPBJJPEFDAD(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BEB")]
				[Cpp2IlInjected.Address(RVA = "0x4C51890", Offset = "0x4C50C90", VA = "0x184C51890")]
				private static IntPtr OADLLJMHHGD()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BEC")]
				[Cpp2IlInjected.Address(RVA = "0x4C51590", Offset = "0x4C50990", VA = "0x184C51590")]
				public static void KNPKHMCBHMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BED")]
				[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
				public static void MHIDNOPDKCM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BEF")]
				[Cpp2IlInjected.Address(RVA = "0x4C51650", Offset = "0x4C50A50", VA = "0x184C51650")]
				public static void LABHLMFNFCH(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006F5")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006F6")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006F7")]
			public NativeParallelHashMap<JDPNCHCMAIA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F8")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public ComponentTypeHandle<CCNJGHCPMLN> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E4F0", Offset = "0x4C4D8F0", VA = "0x184C4E4F0")]
			private void OPBILJIDNNC(Entity entity, [NoAlias] ref CCNJGHCPMLN dstValue, [NoAlias] in OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE3")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E260", Offset = "0x4C4D660", VA = "0x184C4E260", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E480", Offset = "0x4C4D880", VA = "0x184C4E480")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void IEKCDBAOBHK(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E400", Offset = "0x4C4D800", VA = "0x184C4E400")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void HLCPEFLMIJJ(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200021B")]
		private struct PostLoadInitializeNetworkId_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			public NativeParallelHashMap<JDPNCHCMAIA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BF0")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E6B0", Offset = "0x4C4DAB0", VA = "0x184C4E6B0")]
			private void OPBILJIDNNC(Entity entity, in OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x4C4E590", Offset = "0x4C4D990", VA = "0x184C4E590", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		[BOJGNOMIPCG]
		private GGPOHFHPOPM networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		[BOJGNOMIPCG]
		private NBPNODCEBKF scenes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private EntityQuery queryAllInScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private EntityQuery queryAllInActiveRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private EntityQuery additiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private EntityQuery __query_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private ComponentTypeHandle<CCNJGHCPMLN> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x248F640", Offset = "0x248EA40", VA = "0x18248F640", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2490500", Offset = "0x248F900", VA = "0x182490500", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2490630", Offset = "0x248FA30", VA = "0x182490630", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x248EC40", Offset = "0x248E040", VA = "0x18248EC40")]
		public void BJIEGNMFPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x248F700", Offset = "0x248EB00", VA = "0x18248F700")]
		private void KFAAPKIHLAD(NativeParallelHashMap<JDPNCHCMAIA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x248F050", Offset = "0x248E450", VA = "0x18248F050")]
		private void CMKJDFFLLKN(NativeParallelHashMap<JDPNCHCMAIA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x248ECB0", Offset = "0x248E0B0", VA = "0x18248ECB0")]
		private void BNEADNGBALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x248EED0", Offset = "0x248E2D0", VA = "0x18248EED0")]
		private void BOONCOKPFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x248FBD0", Offset = "0x248EFD0", VA = "0x18248FBD0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void LCLDEDMLMDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2490890", Offset = "0x248FC90", VA = "0x182490890")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void PKCJOLEGMAC(NativeParallelHashMap<JDPNCHCMAIA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x248F4E0", Offset = "0x248E8E0", VA = "0x18248F4E0")]
		private void IKCPLPPKNNA(ref NativeParallelHashMap<JDPNCHCMAIA, Entity> map, ref uint playerId, ref uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x248FBF0", Offset = "0x248EFF0", VA = "0x18248FBF0")]
		private void NNHJANIIPCA(ref NativeParallelHashMap<JDPNCHCMAIA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x248F3E0", Offset = "0x248E7E0", VA = "0x18248F3E0")]
		private void GNOAOLKEDKF(ref NativeParallelHashMap<JDPNCHCMAIA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x248FD70", Offset = "0x248F170", VA = "0x18248FD70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x248EBF0", Offset = "0x248DFF0", VA = "0x18248EBF0")]
		public static void APOKDJJFHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x248F6B0", Offset = "0x248EAB0", VA = "0x18248F6B0")]
		public static void KDNIPBMKMLO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200021C")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class KCBEKGENCOO : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	private EntityQuery HNGNEGHJKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	private FEEKAOBEJNL BFDACLEBABK;

	[Cpp2IlInjected.Token(Token = "0x6000BF2")]
	[Cpp2IlInjected.Address(RVA = "0x28F8970", Offset = "0x28F7D70", VA = "0x1828F8970", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF3")]
	[Cpp2IlInjected.Address(RVA = "0x28F89C0", Offset = "0x28F7DC0", VA = "0x1828F89C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF4")]
	[Cpp2IlInjected.Address(RVA = "0x28F8A70", Offset = "0x28F7E70", VA = "0x1828F8A70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF5")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public KCBEKGENCOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021D")]
[EPJIKDLNGEH(typeof(OAAFNCLLJOJ), new string[] { })]
[HIFHEPGGLJB(FGCKLJIPPNH.PhotonRoom)]
internal class MGCHIJJEGFE : NEHPEGODEDF, OAAFNCLLJOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	[BOJGNOMIPCG]
	private NBPNODCEBKF PFIBEKNCGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	private readonly Dictionary<int, Entity> CPPDKIHMFCA;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x2A70FA0", Offset = "0x2A703A0", VA = "0x182A70FA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF8")]
	[Cpp2IlInjected.Address(RVA = "0x2A70FF0", Offset = "0x2A703F0", VA = "0x182A70FF0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF9")]
	[Cpp2IlInjected.Address(RVA = "0x2A70E10", Offset = "0x2A70210", VA = "0x182A70E10", Slot = "5")]
	public void FPFNENGHAPJ(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFA")]
	[Cpp2IlInjected.Address(RVA = "0x2A70BC0", Offset = "0x2A6FFC0", VA = "0x182A70BC0", Slot = "6")]
	public bool FKDEAJCIHBO(HEKFLAGDMLJ LEMCMBEMOCB, Transform DKKDEHMFAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFB")]
	[Cpp2IlInjected.Address(RVA = "0x2A70B50", Offset = "0x2A6FF50", VA = "0x182A70B50")]
	private bool BGBEJGIMHHH(Scene PJOBCGNOOBP, out Entity EAIGKFDIPNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFC")]
	[Cpp2IlInjected.Address(RVA = "0x2A71080", Offset = "0x2A70480", VA = "0x182A71080")]
	public MGCHIJJEGFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021E")]
public class DHIIICKMAPE : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000706")]
	[BOJGNOMIPCG]
	private KPNAFCNKGOC KCOPNEGIMGJ;

	[Cpp2IlInjected.Token(Token = "0x6000BFD")]
	[Cpp2IlInjected.Address(RVA = "0x2947640", Offset = "0x2946A40", VA = "0x182947640", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFE")]
	[Cpp2IlInjected.Address(RVA = "0x2947690", Offset = "0x2946A90", VA = "0x182947690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFF")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public DHIIICKMAPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021F")]
public abstract class EGPDILJJNOF : NILFPPHEEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000707")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem MAIDFODBFFJ();

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x2950B90", Offset = "0x294FF90", VA = "0x182950B90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x2950C20", Offset = "0x2950020", VA = "0x182950C20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	protected EGPDILJJNOF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000220")]
public struct JMBOFDMPJEF : HDPFBKINIJO<EODNMPFLBLP>
{
	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x28F7850", Offset = "0x28F6C50", VA = "0x1828F7850", Slot = "4")]
	public bool DJEDHDKNJHJ(EODNMPFLBLP AGLCIEKHLEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000221")]
public static class FNHHBAHEIFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000C05")]
	[Cpp2IlInjected.Address(RVA = "0x28DAF90", Offset = "0x28DA390", VA = "0x1828DAF90")]
	public static NativeParallelHashSet<int> KOJDOGFDIKI(EntityManager BEBIJONEMLA, Allocator DGGNDNPDKKD)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x28DADD0", Offset = "0x28DA1D0", VA = "0x1828DADD0")]
	public static NativeParallelHashMap<int, int> HIJJPFKCIGO(EntityManager BEBIJONEMLA, Allocator DGGNDNPDKKD)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000222")]
internal readonly struct FCNEOLBGCGK
{
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private static readonly ProfilerMarker KFHNGFCGHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	private readonly NILFPPHEEJF GDOFPEAGKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400070B")]
	private readonly World OKHCNMBCCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070C")]
	private readonly EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	private readonly EntityQuery NDBFIFBMAKC;

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x295F5F0", Offset = "0x295E9F0", VA = "0x18295F5F0")]
	public FCNEOLBGCGK(NILFPPHEEJF GDOFPEAGKBE, World OKHCNMBCCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x295F010", Offset = "0x295E410", VA = "0x18295F010")]
	public (NativeArray<JDPNCHCMAIA>, NativeArray<BACOLBMJCKD>) GLINDFMMGLK()
	{
		return default((NativeArray<JDPNCHCMAIA>, NativeArray<BACOLBMJCKD>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000223")]
internal interface AMAKEGIKBFI
{
	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	bool EJHPBGNJGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	NativeArray<JDPNCHCMAIA> CKCADBBINPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	NativeArray<BACOLBMJCKD> NJJOAPGDCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C0C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	NativeArray<JDPNCHCMAIA> CKEPEIKGKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HDLKKIGIJEK(out NativeArray<int> FKKINIOIAPD, Allocator DGGNDNPDKKD);

	[Cpp2IlInjected.Token(Token = "0x6000C0F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IAEHFCGGGJF(ComponentType OOMLHJHCPCJ, out FEHKACBIOPC FBCMJKHLOEK, out OLDCGNLHOFL HMNOECLMMGK);

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, OFDKMKMCECL> NOPAIPPIOAH();
}
[Cpp2IlInjected.Token(Token = "0x2000224")]
internal static class NAOMEJDPEMB
{
	[Cpp2IlInjected.Token(Token = "0x6000C11")]
	[Cpp2IlInjected.Address(RVA = "0x2A74040", Offset = "0x2A73440", VA = "0x182A74040")]
	public static bool BICPPBKALMK(this AMAKEGIKBFI HEAMCFPFNOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000225")]
[EPJIKDLNGEH(typeof(CHLGHCACLPB), new string[] { })]
public sealed class EEDNBAACMOB : CHLGHCACLPB, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x2000226")]
	[BurstCompile]
	private struct PFAOBFPEPLG : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		[ReadOnly]
		public NativeArray<Entity> NOEOKDNGNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		[ReadOnly]
		public float3 PBNBNBDOPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		[ReadOnly]
		public float3 PMJNKMBMHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		[ReadOnly]
		public ComponentDataFromEntity<EODNMPFLBLP> MDMBJPNKPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		[ReadOnly]
		public ComponentDataFromEntity<LEIMONNOBFD> COKLAADCEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> CCGDONFKPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		[ReadOnly]
		public ComponentDataFromEntity<JFMBCHEMIHN> PMHBILCNGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		[ReadOnly]
		public ComponentDataFromEntity<PPPFOFLFJIM> ILNFBHMAJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		[WriteOnly]
		public NativeArray<EIPPCECOLNJ> FMKJCIDEBCN;

		[Cpp2IlInjected.Token(Token = "0x4000718")]
		private static readonly EIPPCECOLNJ CGJMHIPHPHJ;

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x27BC020", Offset = "0x27BB420", VA = "0x1827BC020", Slot = "4")]
		public void Execute(int BNOAGGNAMKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x27BC4E0", Offset = "0x27BB8E0", VA = "0x1827BC4E0")]
		private static float3 LEFHKIHKLAC(in float4x4 KLMGAKGOLOO, in float3 LPFEMKLCPIB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x27BC9E0", Offset = "0x27BBDE0", VA = "0x1827BC9E0")]
		private static float3 PDIEGGNAAKM(in float4x4 KLMGAKGOLOO, in float3 FPFFKAACHPJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x27BC5B0", Offset = "0x27BB9B0", VA = "0x1827BC5B0")]
		private static float3 LKMBOJMAFDF(in float4x4 KLMGAKGOLOO, in float3 LPFEMKLCPIB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x27BC310", Offset = "0x27BB710", VA = "0x1827BC310")]
		private static float3 KCILIMCFBGG(in float4x4 KLMGAKGOLOO, in float3 FPFFKAACHPJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x27BC6C0", Offset = "0x27BBAC0", VA = "0x1827BC6C0")]
		private bool OPFANNCIAIJ(in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, in NativeArray<Entity> DPEBEECGALI, out float3 MGALLJFBEGH, out float3 PKGGKJEKINO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x27BB9C0", Offset = "0x27BADC0", VA = "0x1827BB9C0")]
		public static bool EPCIOBMMGPG(in float3 BDMIGCFLFBF, in float3 LIDEGHDCDLC, in float3 DBBBDKPLHON, in float3 FCGJKMOCDLM, float NIOOCLKPIFN, float FOMGMDJCAOB, out float NINFMGLENJD, out float3 LKJCEFPILGA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private EntityManager BEBIJONEMLA;

	[Cpp2IlInjected.Token(Token = "0x6000C12")]
	[Cpp2IlInjected.Address(RVA = "0x294F7F0", Offset = "0x294EBF0", VA = "0x18294F7F0", Slot = "5")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C13")]
	[Cpp2IlInjected.Address(RVA = "0x294F880", Offset = "0x294EC80", VA = "0x18294F880")]
	public void NMAPLLCJFCD(in NativeArray<Entity> NOEOKDNGNCK, in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, in NativeArray<EIPPCECOLNJ> BGNIPJHMELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C14")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EEDNBAACMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C15")]
	[Cpp2IlInjected.Address(RVA = "0x294F870", Offset = "0x294EC70", VA = "0x18294F870", Slot = "4")]
	private void JOPHPPACHGA(in NativeArray<Entity> NOEOKDNGNCK, in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, in NativeArray<EIPPCECOLNJ> BGNIPJHMELG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000227")]
[DefaultMember("Item")]
public struct FNJDMJLKEHA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private T[] CLCAIFLMLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private int HBBGBOONHJE;

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(RVA = "0x38153D0", Offset = "0x38147D0", VA = "0x1838153D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000228")]
public struct BOEBMGGFPKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	public Entity GKMECPLEALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	public Entity PCAHPLBOKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	public Entity ICPFLJENDFI;

	[Cpp2IlInjected.Token(Token = "0x6000C1F")]
	[Cpp2IlInjected.Address(RVA = "0x2902030", Offset = "0x2901430", VA = "0x182902030")]
	public BOEBMGGFPKG(Entity GKMECPLEALF, Entity PCAHPLBOKJA, Entity ICPFLJENDFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C20")]
	[Cpp2IlInjected.Address(RVA = "0x2901FF0", Offset = "0x29013F0", VA = "0x182901FF0")]
	public static BOEBMGGFPKG LFFBPOODCDC((Entity entity, Entity oldParent, Entity newParent) HFABIHIFANG)
	{
		return default(BOEBMGGFPKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C21")]
	[Cpp2IlInjected.Address(RVA = "0x2901FD0", Offset = "0x29013D0", VA = "0x182901FD0")]
	public void CILAAEFJCBE(out Entity GKMECPLEALF, out Entity PCAHPLBOKJA, out Entity ICPFLJENDFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
public class KMPFFENKPEL : NILFPPHEEJF
{
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	private EntityQuery BEHDAMIMGBM;

	[Cpp2IlInjected.Token(Token = "0x6000C22")]
	[Cpp2IlInjected.Address(RVA = "0x2A64690", Offset = "0x2A63A90", VA = "0x182A64690", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C23")]
	[Cpp2IlInjected.Address(RVA = "0x2A64740", Offset = "0x2A63B40", VA = "0x182A64740", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C24")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public KMPFFENKPEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022A")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal class OMLGJABBHNL : HIJPEHDGBEB<ILMNACFNHNL>, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	private EMGCNKHPFCN FNJHGBOKJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	private EntityQuery HKNHBFAMNBN;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private Entity MNOJDBHOMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x2481420", Offset = "0x2480820", VA = "0x182481420")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x2481600", Offset = "0x2480A00", VA = "0x182481600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public HEKFLAGDMLJ PMJNIFPJBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x2481830", Offset = "0x2480C30", VA = "0x182481830")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x2481C60", Offset = "0x2481060", VA = "0x182481C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2A")]
	[Cpp2IlInjected.Address(RVA = "0x2481D10", Offset = "0x2481110", VA = "0x182481D10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2B")]
	[Cpp2IlInjected.Address(RVA = "0x2481660", Offset = "0x2480A60", VA = "0x182481660", Slot = "15")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2C")]
	[Cpp2IlInjected.Address(RVA = "0x2481DB0", Offset = "0x24811B0", VA = "0x182481DB0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2D")]
	[Cpp2IlInjected.Address(RVA = "0x24816D0", Offset = "0x2480AD0", VA = "0x1824816D0", Slot = "14")]
	protected override void JBELCECMLIA(NativeArray<Entity> NOEOKDNGNCK, NativeArray<Entity> ENBJPNNFNAJ, NativeArray<Entity> BFJOOFPJKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0x2481340", Offset = "0x2480740", VA = "0x182481340")]
	private void AJBFDDOIPBC(NativeArray<Entity> NOEOKDNGNCK, NativeArray<Entity> BFJOOFPJKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0x24818D0", Offset = "0x2480CD0", VA = "0x1824818D0")]
	private void MEOPBHLHMPL(Entity GKMECPLEALF, Entity LABPOLAAKNE, Entity MLABAGOFDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0x202C370", Offset = "0x202B770", VA = "0x18202C370")]
	private bool HBBLEOHJDFE<T>(out T AGLCIEKHLEE) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0x202C2B0", Offset = "0x202B6B0", VA = "0x18202C2B0")]
	private void FIEDDFKBONB<T>(T AGLCIEKHLEE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0x2481480", Offset = "0x2480880", VA = "0x182481480")]
	public bool EJAEPLPAGIO(HEKFLAGDMLJ KBGDHFBCPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0x2481570", Offset = "0x2480970", VA = "0x182481570")]
	private static bool GDOOICEIBNA(HEKFLAGDMLJ LKGLMHHDKBI, HEKFLAGDMLJ OMEGPPLEFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C34")]
	[Cpp2IlInjected.Address(RVA = "0x2481EC0", Offset = "0x24812C0", VA = "0x182481EC0")]
	public OMLGJABBHNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022B")]
internal class BGEJHNGHPFJ : IPNJFEEEFKG
{
	[Cpp2IlInjected.Token(Token = "0x17000151")]
	protected override NGPJOPHOOLK JCFDBPMPNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x28FD530", Offset = "0x28FC930", VA = "0x1828FD530", Slot = "15")]
		get
		{
			return default(NGPJOPHOOLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C37")]
	[Cpp2IlInjected.Address(RVA = "0x28FABD0", Offset = "0x28F9FD0", VA = "0x1828FABD0")]
	public BGEJHNGHPFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022C")]
public class OOADMKCCNEA : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	[BOJGNOMIPCG]
	private KPNAFCNKGOC KCOPNEGIMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	[BOJGNOMIPCG]
	private GGPOHFHPOPM NKKCFABPHDO;

	[Cpp2IlInjected.Token(Token = "0x6000C38")]
	[Cpp2IlInjected.Address(RVA = "0x2482030", Offset = "0x2481430", VA = "0x182482030", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C39")]
	[Cpp2IlInjected.Address(RVA = "0x2482430", Offset = "0x2481830", VA = "0x182482430", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3A")]
	[Cpp2IlInjected.Address(RVA = "0x24820A0", Offset = "0x24814A0", VA = "0x1824820A0")]
	private void MIHEDGBINHM(NativeArray<JDPNCHCMAIA> GPMOEKHMPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3B")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public OOADMKCCNEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
public class IPBICDFIFEJ : NILFPPHEEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private EntityQuery MJMBJPOMICA;

	[Cpp2IlInjected.Token(Token = "0x6000C3D")]
	[Cpp2IlInjected.Address(RVA = "0x28EC9F0", Offset = "0x28EBDF0", VA = "0x1828EC9F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3E")]
	[Cpp2IlInjected.Address(RVA = "0x28ECA80", Offset = "0x28EBE80", VA = "0x1828ECA80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3F")]
	[Cpp2IlInjected.Address(RVA = "0x28EC9A0", Offset = "0x28EBDA0", VA = "0x1828EC9A0")]
	private EntityCommandBufferSystem FFDPBBPOCGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C40")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public IPBICDFIFEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022E")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class EPJJGFKOLAI : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000C41")]
	[Cpp2IlInjected.Address(RVA = "0x295D8B0", Offset = "0x295CCB0", VA = "0x18295D8B0", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C42")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public EPJJGFKOLAI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200022F")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParent : NILFPPHEEJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		private static readonly EHKEPJIBENP log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2490BD0", Offset = "0x248FFD0", VA = "0x182490BD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2490CB0", Offset = "0x24900B0", VA = "0x182490CB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x2490A10", Offset = "0x248FE10", VA = "0x182490A10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C46")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PostLoadMoveRootsUnderParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000230")]
public struct NBMOHGNDFOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	public Entity GKMECPLEALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400072C")]
	public Entity OJBGDMNECON;

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0x176AAD0", Offset = "0x1769ED0", VA = "0x18176AAD0")]
	public NBMOHGNDFOG(Entity GKMECPLEALF, Entity OJBGDMNECON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x2A74180", Offset = "0x2A73580", VA = "0x182A74180")]
	public static NBMOHGNDFOG LFFBPOODCDC((Entity entity, Entity parent) HFABIHIFANG)
	{
		return default(NBMOHGNDFOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x2A74170", Offset = "0x2A73570", VA = "0x182A74170")]
	public void CILAAEFJCBE(out Entity GKMECPLEALF, out Entity OJBGDMNECON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000231")]
[AlwaysUpdateSystem]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public class MCNNKDBGGCO : NILFPPHEEJF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072D")]
	[BOJGNOMIPCG]
	private GLKFEKFDENH FMJCNNBPLKG;

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x2A70250", Offset = "0x2A6F650", VA = "0x182A70250", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4C")]
	[Cpp2IlInjected.Address(RVA = "0x2A702A0", Offset = "0x2A6F6A0", VA = "0x182A702A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4D")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public MCNNKDBGGCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000232")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[EPJIKDLNGEH(typeof(OGNMAJKNMBP), new string[] { })]
internal sealed class OGNMAJKNMBP : NEHPEGODEDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	[BOJGNOMIPCG]
	private ICCLAPFHPJL GLBDCLCAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private EntityQuery CHKGOHBFCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x247F3F0", Offset = "0x247E7F0", VA = "0x18247F3F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4F")]
	[Cpp2IlInjected.Address(RVA = "0x247F550", Offset = "0x247E950", VA = "0x18247F550", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C50")]
	[Cpp2IlInjected.Address(RVA = "0x247F3D0", Offset = "0x247E7D0", VA = "0x18247F3D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C51")]
	[Cpp2IlInjected.Address(RVA = "0x247F700", Offset = "0x247EB00", VA = "0x18247F700")]
	public bool LOJMEIIDDGG(Entity GKMECPLEALF, Entity BGACBDKLDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C52")]
	[Cpp2IlInjected.Address(RVA = "0x247F440", Offset = "0x247E840", VA = "0x18247F440")]
	public bool GNBOGMACBNL(Entity GKMECPLEALF, Entity BPLKOFNPIGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C53")]
	[Cpp2IlInjected.Address(RVA = "0x247F650", Offset = "0x247EA50", VA = "0x18247F650")]
	public Entity LAAKJDOAPFC(Entity GKMECPLEALF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C54")]
	[Cpp2IlInjected.Address(RVA = "0x247F500", Offset = "0x247E900", VA = "0x18247F500")]
	public NativeArray<Entity> IJBFDPMGIJM()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C55")]
	[Cpp2IlInjected.Address(RVA = "0x247F7C0", Offset = "0x247EBC0", VA = "0x18247F7C0")]
	public bool MPHFLBOJAHA(Entity JNHEGOFDJBP, Entity JBNLIGHJDME, out Entity MCDGHNFJPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C56")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public OGNMAJKNMBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000233")]
internal interface KHFJDJKGIKC
{
	[Cpp2IlInjected.Token(Token = "0x17000153")]
	World HBDGJGALOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	World GLGFHNDCHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	LJPBJFAFPOA MFHBJAMIFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	uint CDOBDMBCFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000234")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplines : NILFPPHEEJF
	{
		[Cpp2IlInjected.Token(Token = "0x2000235")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000735")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000736")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C64")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C540", Offset = "0x4C4B940", VA = "0x184C4C540")]
			private void OPBILJIDNNC(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C490", Offset = "0x4C4B890", VA = "0x184C4C490", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000236")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000737")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000738")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000739")]
			[ReadOnly]
			public ComponentTypeHandle<OPILEFNOLAG> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C66")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C6F0", Offset = "0x4C4BAF0", VA = "0x184C4C6F0")]
			private void OPBILJIDNNC(Entity splinePoint, [NoAlias] in OPILEFNOLAG splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C67")]
			[Cpp2IlInjected.Address(RVA = "0x4C4C5D0", Offset = "0x4C4B9D0", VA = "0x184C4C5D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private ComponentTypeHandle<OPILEFNOLAG> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x2489E40", Offset = "0x2489240", VA = "0x182489E40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2489EF0", Offset = "0x24892F0", VA = "0x182489EF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2489AA0", Offset = "0x2488EA0", VA = "0x182489AA0")]
		private EntityCommandBufferSystem MAIDFODBFFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x2489850", Offset = "0x2488C50", VA = "0x182489850")]
		private void KALANMNBFEK(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C61")]
		[Cpp2IlInjected.Address(RVA = "0x2489950", Offset = "0x2488D50", VA = "0x182489950")]
		private void KPAIPNAPOJJ(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x2489AF0", Offset = "0x2488EF0", VA = "0x182489AF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public PostDeserializeAddSplinePointsToSplines()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000237")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
	public class UpdateSplineGameCollidersSystem : NILFPPHEEJF, NEHPEGODEDF
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000238")]
		public struct SplineGameCollisionSystemTag : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000239")]
		private struct ProcessCollisionModeChangesForSplineGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000747")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000748")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000749")]
			[ReadOnly]
			public ComponentDataFromEntity<KACENJHHHOI> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400074A")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400074B")]
			[ReadOnly]
			public ComponentTypeHandle<EKIJOGFFHLI> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400074C")]
			public BufferTypeHandle<NCPPJPJLJPP> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C76")]
			[Cpp2IlInjected.Address(RVA = "0x4C4F2B0", Offset = "0x4C4E6B0", VA = "0x184C4F2B0")]
			private void OPBILJIDNNC(in EKIJOGFFHLI collisionMode, DynamicBuffer<NCPPJPJLJPP> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C77")]
			[Cpp2IlInjected.Address(RVA = "0x4C4F140", Offset = "0x4C4E540", VA = "0x184C4F140", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023A")]
		private struct ProcessActiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400074D")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400074E")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400074F")]
			[ReadOnly]
			public ComponentDataFromEntity<EKIJOGFFHLI> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000751")]
			[ReadOnly]
			public ComponentTypeHandle<EODNMPFLBLP> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C78")]
			[Cpp2IlInjected.Address(RVA = "0x4C4F080", Offset = "0x4C4E480", VA = "0x184C4F080")]
			private void OPBILJIDNNC(Entity entity, in EODNMPFLBLP parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C79")]
			[Cpp2IlInjected.Address(RVA = "0x4C4EF60", Offset = "0x4C4E360", VA = "0x184C4EF60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023B")]
		private struct ProcessInactiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000752")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000753")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000754")]
			[ReadOnly]
			public ComponentDataFromEntity<EKIJOGFFHLI> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000755")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000756")]
			[ReadOnly]
			public ComponentTypeHandle<EODNMPFLBLP> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C7A")]
			[Cpp2IlInjected.Address(RVA = "0x4C4F720", Offset = "0x4C4EB20", VA = "0x184C4F720")]
			private void OPBILJIDNNC(Entity entity, in EODNMPFLBLP parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C7B")]
			[Cpp2IlInjected.Address(RVA = "0x4C4F600", Offset = "0x4C4EA00", VA = "0x184C4F600", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023C")]
		private struct UpdateSplineGameCollidersSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000757")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C7C")]
			[Cpp2IlInjected.Address(RVA = "0x4C531D0", Offset = "0x4C525D0", VA = "0x184C531D0")]
			private void OPBILJIDNNC(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C7D")]
			[Cpp2IlInjected.Address(RVA = "0x4C53120", Offset = "0x4C52520", VA = "0x184C53120", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023D")]
		private struct ProcessSplineEditsForGameCollision_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x400075A")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400075B")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400075C")]
			[ReadOnly]
			public ComponentTypeHandle<OPILEFNOLAG> splinePointParentHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400075D")]
			[ReadOnly]
			public EntityTypeHandle entityHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400075E")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400075F")]
			public EntityQueryInJob splinePointEditedQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000760")]
			public EntityQueryInJob splineStructureChangedQueryInJob;

			[Cpp2IlInjected.Token(Token = "0x6000C7E")]
			[Cpp2IlInjected.Address(RVA = "0x4C4F840", Offset = "0x4C4EC40", VA = "0x184C4F840")]
			private void OPBILJIDNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C7F")]
			[Cpp2IlInjected.Address(RVA = "0x4C4F7D0", Offset = "0x4C4EBD0", VA = "0x184C4F7D0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C80")]
			[Cpp2IlInjected.Address(RVA = "0x4C4F7E0", Offset = "0x4C4EBE0", VA = "0x184C4F7E0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void IEKCDBAOBHK(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private BMHCJDBMOMA splineCollisionService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private EntityQuery collisionModeChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private EntityQuery activeSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private EntityQuery inactiveSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private EntityQuery splinePointEditedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private EntityQuery splineStructureChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private EntityQuery splinesDeletedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private EntityQuery ProcessCollisionModeChangesForSplineGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private EntityQuery ProcessActiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private EntityQuery ProcessInactiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private EntityQuery UpdateSplineGameCollidersSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private ComponentTypeHandle<EKIJOGFFHLI> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private ComponentTypeHandle<EODNMPFLBLP> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x249D800", Offset = "0x249CC00", VA = "0x18249D800", Slot = "14")]
		public void InitReferences(IABLIMOJJBC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x249E500", Offset = "0x249D900", VA = "0x18249E500", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x249E6D0", Offset = "0x249DAD0", VA = "0x18249E6D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x249DA30", Offset = "0x249CE30", VA = "0x18249DA30")]
		private void MEGOCJJEKMP(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x249D060", Offset = "0x249C460", VA = "0x18249D060")]
		private void APPAGBMKCNM(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x249D510", Offset = "0x249C910", VA = "0x18249D510")]
		private void HAMNLHGCNCM(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x249D940", Offset = "0x249CD40", VA = "0x18249D940")]
		private void LGKKMCBIKLE(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x249D320", Offset = "0x249C720", VA = "0x18249D320")]
		private void EKPMDKALCNO(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<KACENJHHHOI> splineComponentAccess, ref ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x249EE40", Offset = "0x249E240", VA = "0x18249EE40")]
		private void PAEDIEEGEFG(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<EKIJOGFFHLI> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x249EFB0", Offset = "0x249E3B0", VA = "0x18249EFB0")]
		private void POPJGAIADPC(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<EKIJOGFFHLI> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x249D850", Offset = "0x249CC50", VA = "0x18249D850")]
		private void LEMCNKIANAC(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x249D6C0", Offset = "0x249CAC0", VA = "0x18249D6C0")]
		private void ILMDMLBBGJC(ref ComponentTypeHandle<OPILEFNOLAG> splinePointParentHandle, ref EntityTypeHandle entityHandle, ref ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, ref EntityQueryInJob splinePointEditedQueryInJob, ref EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x249DC50", Offset = "0x249D050", VA = "0x18249DC50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200023E")]
public sealed class CNJIGGNAEBG : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x290A2A0", Offset = "0x29096A0", VA = "0x18290A2A0", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public CNJIGGNAEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023F")]
[ExecuteAlways]
public class BECNMNFKPFB : FDPFJCKHLML
{
	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	public BECNMNFKPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000240")]
public sealed class KCENEBIKDFP : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x28F8C50", Offset = "0x28F8050", VA = "0x1828F8C50", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C85")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public KCENEBIKDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
public class LNBPOIFPDHC : CCBLHMCLOCJ, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private NBPNODCEBKF FBJJPAAFOIC;

	[Cpp2IlInjected.Token(Token = "0x6000C86")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DA70", Offset = "0x2A6CE70", VA = "0x182A6DA70", Slot = "14")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C87")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C88")]
	[Cpp2IlInjected.Address(RVA = "0x247DBA0", Offset = "0x247CFA0", VA = "0x18247DBA0")]
	public LNBPOIFPDHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class FEIGIMHIDHN : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000C89")]
	[Cpp2IlInjected.Address(RVA = "0x2962930", Offset = "0x2961D30", VA = "0x182962930", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8A")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public FEIGIMHIDHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
internal class PLPENBOKCKH : DFCPJAAPILG
{
	[Cpp2IlInjected.Token(Token = "0x17000158")]
	protected override NGLJBCFJFFJ BNNGAFLNGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x8C05F0", Offset = "0x8BF9F0", VA = "0x1808C05F0", Slot = "17")]
		get
		{
			return default(NGLJBCFJFFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8C")]
	[Cpp2IlInjected.Address(RVA = "0x2485730", Offset = "0x2484B30", VA = "0x182485730")]
	public PLPENBOKCKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
public sealed class IEBAFBOPAOE : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000C8D")]
	[Cpp2IlInjected.Address(RVA = "0x28EB300", Offset = "0x28EA700", VA = "0x1828EB300", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8E")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public IEBAFBOPAOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class PEPFJIBOMGI : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000C8F")]
	[Cpp2IlInjected.Address(RVA = "0x24835B0", Offset = "0x24829B0", VA = "0x1824835B0", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C90")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public PEPFJIBOMGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000246")]
[GPJMDNAJGCP(typeof(OKLGNNPGBAD))]
public sealed class LOCOEMPBFPK : HGPCLMMHPLB
{
	[Cpp2IlInjected.Token(Token = "0x6000C91")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DAD0", Offset = "0x2A6CED0", VA = "0x182A6DAD0", Slot = "8")]
	protected override bool FHEKMPIJECB(ReadOnlySpan<OKLGNNPGBAD> JFJPDDKMGLD, CNPNLDAEMGP JNKBIJELCHM, out ReadOnlySpan<byte> DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C92")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DB50", Offset = "0x2A6CF50", VA = "0x182A6DB50", Slot = "9")]
	protected override bool HPJEOBEBHIB(int LJJHJABONIO, Span<OKLGNNPGBAD> JFJPDDKMGLD, in ReadOnlySpan<byte> DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C93")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DC10", Offset = "0x2A6D010", VA = "0x182A6DC10")]
	public LOCOEMPBFPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
[GPJMDNAJGCP(typeof(OHBGCALBLDC))]
public sealed class MFJICNJLMEE : CDPPGONKNJA
{
	[Cpp2IlInjected.Token(Token = "0x6000C94")]
	[Cpp2IlInjected.Address(RVA = "0x2A70990", Offset = "0x2A6FD90", VA = "0x182A70990", Slot = "8")]
	protected override bool FHEKMPIJECB(ReadOnlySpan<OHBGCALBLDC> JFJPDDKMGLD, CNPNLDAEMGP JNKBIJELCHM, out ReadOnlySpan<byte> DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C95")]
	[Cpp2IlInjected.Address(RVA = "0x2A70A10", Offset = "0x2A6FE10", VA = "0x182A70A10", Slot = "9")]
	protected override bool HPJEOBEBHIB(int LJJHJABONIO, Span<OHBGCALBLDC> JFJPDDKMGLD, in ReadOnlySpan<byte> DCBJJADOEJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C96")]
	[Cpp2IlInjected.Address(RVA = "0x2A70AD0", Offset = "0x2A6FED0", VA = "0x182A70AD0")]
	public MFJICNJLMEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
[BOFOINMHPHO(FGCKLJIPPNH.LoadInstance)]
internal sealed class HDLNLLAFENN : MGAGGMBOOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000C97")]
	[Cpp2IlInjected.Address(RVA = "0x28E5560", Offset = "0x28E4960", VA = "0x1828E5560", Slot = "15")]
	protected override ComponentSystemBase CEMGMADDGGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public HDLNLLAFENN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000249")]
internal class LDOPAJCPHIA : LAOHLEGNFJB
{
	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x247F1C0", Offset = "0x247E5C0", VA = "0x18247F1C0")]
	public LDOPAJCPHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
[EPJIKDLNGEH(typeof(MBDFLOLPEII), new string[] { })]
public sealed class ONIDOFONLGD : MBDFLOLPEII, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private FOODIHPHGKA ANNIKNAGBIK;

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x2481FE0", Offset = "0x24813E0", VA = "0x182481FE0", Slot = "5")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x2481F00", Offset = "0x2481300", VA = "0x182481F00")]
	public bool NMAPLLCJFCD(in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, float AKODDLNKMDE, Allocator DGGNDNPDKKD, out NativeArray<Entity> NOEOKDNGNCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public ONIDOFONLGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x2481F00", Offset = "0x2481300", VA = "0x182481F00", Slot = "4")]
	private bool HOMLMLDCPOM(in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, float AKODDLNKMDE, Allocator DGGNDNPDKKD, out NativeArray<Entity> NOEOKDNGNCK)
	{
		return default(bool);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200024B")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : NBHAMHKLBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C9E")]
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0x27C1D80", Offset = "0x27C1180", VA = "0x1827C1D80", Slot = "6")]
		public sealed override void FIPMMMKIJLD(KJGAKLCAAAB IPDGCBIIEII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA0")]
		[Cpp2IlInjected.Address(RVA = "0x27C1B80", Offset = "0x27C0F80", VA = "0x1827C1B80", Slot = "4")]
		public sealed override void ALPFLNNIPAO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200024C")]
internal class __UnmanagedPostProcessorOutput__3051310927
{
	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x27C4490", Offset = "0x27C3890", VA = "0x1827C4490")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024D")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3051310927
{
	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x27C2EF0", Offset = "0x27C22F0", VA = "0x1827C2EF0")]
	public static void GLGONCDEFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x27C2EE0", Offset = "0x27C22E0", VA = "0x1827C2EE0")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024E")]
internal class DEBNLCDHGNJ : ContainerPropertyBag<OCNDKBGOCHB>
{
	[Cpp2IlInjected.Token(Token = "0x200024F")]
	private class DDKHKFNEGJP : Property<OCNDKBGOCHB, KINEJENHFEI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public override string ANHHJLAHIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA5")]
			[Cpp2IlInjected.Address(RVA = "0x27B1620", Offset = "0x27B0A20", VA = "0x1827B1620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public override bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA6")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x27B15E0", Offset = "0x27B09E0", VA = "0x1827B15E0")]
		public DDKHKFNEGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x27B1590", Offset = "0x27B0990", VA = "0x1827B1590", Slot = "14")]
		public override KINEJENHFEI GetValue(ref OCNDKBGOCHB DOJDGHDKCLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x27B15B0", Offset = "0x27B09B0", VA = "0x1827B15B0", Slot = "15")]
		public override void SetValue(ref OCNDKBGOCHB DOJDGHDKCLO, KINEJENHFEI AGLCIEKHLEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x2916410", Offset = "0x2915810", VA = "0x182916410")]
	public DEBNLCDHGNJ()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000250")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2493870", Offset = "0x2492C70", VA = "0x182493870")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000251")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000CAB")]
	[Cpp2IlInjected.Address(RVA = "0x2918A20", Offset = "0x2917E20", VA = "0x182918A20")]
	[RuntimeInitializeOnLoadMethod]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000252")]
public class MGDDIBLAEHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000CAC")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public MGDDIBLAEHJ()
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
