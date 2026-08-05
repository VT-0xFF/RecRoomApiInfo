using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Core;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
public sealed class GNFCDLGGEDJ<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class CAJOKPMKHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::GNFCDLGGEDJ<T> FAGMKGFJEIK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] HPIMPDJADFN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public CAJOKPMKHGD(global::GNFCDLGGEDJ<T> FAGMKGFJEIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class LDENNANFPJJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::GNFCDLGGEDJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <count>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "4")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[DebuggerHidden]
		public LDENNANFPJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const int NADGEGAEAMO = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> EMEJKCCEGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int DCKOJAKBNLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private bool JFJDDAHJJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool AFLJLHIMPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool PLEAOFBAHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DGLKHMNKMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	public GNFCDLGGEDJ(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public GNFCDLGGEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void NDBILFDGAPJ(int NNHNOIMLALG, T PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void CILEDFDJAAI(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] NEECKNOMDLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void MADBNGLIMGE(NativeArray<T> PALKODKBAJM, int NBMFMGFDNJC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::GNFCDLGGEDJ<>.LDENNANFPJJ))]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	public int IHBPJFIMNDJ(T PIBOOIGHJBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool CJGLMEKHGBL(T PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void PPIPBPEKJGB(int NDMNBAOJFBH, int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void CMAHKHFOACC(int NDMNBAOJFBH, int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void JHMJOBGMAHO(int NDMNBAOJFBH, int NGOMPMICLHJ, int MNBBKKLFBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int OPJGCNLLEGH(int NNHNOIMLALG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T KPIJBBGGFAF(int NNHNOIMLALG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void KEBFGOGGMMD(int NNHNOIMLALG, T PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void AHMPLMFKOAF(int NNHNOIMLALG, T PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void MBCKEBDONGE(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int DIAEMMIPKFA(int MGFMONLLLPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int CPFIPDNFBBG(int MGFMONLLLPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void PIAIDPJJBCD(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void FJONGJOEEEB(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T LJPFFPCAKDF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T PAJFDMFCCBM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void DMGJHHPJCON(int NNHNOIMLALG, IReadOnlyCollection<T> BFJIAFJFPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void JHFAJBICPBC(int NNHNOIMLALG, int DAIIOFJCMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void JIOAMCNOMPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void IHBLDPINBNA(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void ICCJGDBMHNL(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void HIJCOKMPICM(int NGOMPMICLHJ, int MNBBKKLFBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T BIDGHJBFFGF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T OLAMLCOLIFE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[MJHKBCGNEBF]
public static class OOEMILDKJEO
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EBB0", Offset = "0x2D1D9B0", VA = "0x182D1EBB0")]
	static OOEMILDKJEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x27D99F0", Offset = "0x27D87F0", VA = "0x1827D99F0")]
	public static void EIMPNBNIPFN<T>(T EKDHPMHGKLM, ref T JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EB40", Offset = "0x2D1D940", VA = "0x182D1EB40")]
	public static void EIMPNBNIPFN(FixedString32 EKDHPMHGKLM, ref string JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EB70", Offset = "0x2D1D970", VA = "0x182D1EB70")]
	public static void EIMPNBNIPFN(string EKDHPMHGKLM, ref FixedString32 JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E8E0", Offset = "0x2D1D6E0", VA = "0x182D1E8E0")]
	public static void EIMPNBNIPFN(FixedString64 EKDHPMHGKLM, ref string JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EAE0", Offset = "0x2D1D8E0", VA = "0x182D1EAE0")]
	public static void EIMPNBNIPFN(string EKDHPMHGKLM, ref FixedString64 JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E8B0", Offset = "0x2D1D6B0", VA = "0x182D1E8B0")]
	public static void EIMPNBNIPFN(EICKHCLMIDC EKDHPMHGKLM, ref Vector3 JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EA80", Offset = "0x2D1D880", VA = "0x182D1EA80")]
	public static void EIMPNBNIPFN(Vector3 EKDHPMHGKLM, ref EICKHCLMIDC JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E950", Offset = "0x2D1D750", VA = "0x182D1E950")]
	public static void EIMPNBNIPFN(IJDBLOLDNFP EKDHPMHGKLM, ref Vector4 JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E840", Offset = "0x2D1D640", VA = "0x182D1E840")]
	public static void EIMPNBNIPFN(Vector4 EKDHPMHGKLM, ref IJDBLOLDNFP JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E950", Offset = "0x2D1D750", VA = "0x182D1E950")]
	public static void EIMPNBNIPFN(IJDBLOLDNFP EKDHPMHGKLM, ref Quaternion JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E840", Offset = "0x2D1D640", VA = "0x182D1E840")]
	public static void EIMPNBNIPFN(Quaternion EKDHPMHGKLM, ref IJDBLOLDNFP JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EA50", Offset = "0x2D1D850", VA = "0x182D1EA50")]
	public static void EIMPNBNIPFN(EICKHCLMIDC EKDHPMHGKLM, ref float3 JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EA80", Offset = "0x2D1D880", VA = "0x182D1EA80")]
	public static void EIMPNBNIPFN(float3 EKDHPMHGKLM, ref EICKHCLMIDC JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E910", Offset = "0x2D1D710", VA = "0x182D1E910")]
	public static void EIMPNBNIPFN(IJDBLOLDNFP EKDHPMHGKLM, ref float4 JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E840", Offset = "0x2D1D640", VA = "0x182D1E840")]
	public static void EIMPNBNIPFN(float4 EKDHPMHGKLM, ref IJDBLOLDNFP JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E910", Offset = "0x2D1D710", VA = "0x182D1E910")]
	public static void EIMPNBNIPFN(IJDBLOLDNFP EKDHPMHGKLM, ref quaternion JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E9A0", Offset = "0x2D1D7A0", VA = "0x182D1E9A0")]
	public static void EIMPNBNIPFN(quaternion EKDHPMHGKLM, ref IJDBLOLDNFP JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D1EA10", Offset = "0x2D1D810", VA = "0x182D1EA10")]
	public static void EIMPNBNIPFN(Entity EKDHPMHGKLM, ref MLFENIOHFPB JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E980", Offset = "0x2D1D780", VA = "0x182D1E980")]
	public static void EIMPNBNIPFN(MLFENIOHFPB EKDHPMHGKLM, ref Entity JENDJNEIBPJ, KBICDOOODLG MNPIJNFAMOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JFPMCOMHGMD]
public class OPGNDIEBJDD : ComponentSystem, JPLAKHLHFLM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LKAAGIKDPMH MFKBNBOKJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AFJJBHJMGFE HOOKCAMEDII
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7833A0", Offset = "0x7821A0", VA = "0x1807833A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F590", Offset = "0x2D1E390", VA = "0x182D1F590", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
	public OPGNDIEBJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[JFPMCOMHGMD]
[UpdateInGroup(typeof(OHNNLDNHKCN))]
internal class ODPABDEMPBO : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D6D0", Offset = "0x2D1C4D0", VA = "0x182D1D6D0", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D910", Offset = "0x2D1C710", VA = "0x182D1D910")]
	[Preserve]
	private void MAPLFKKLACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public ODPABDEMPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[JFPMCOMHGMD]
[UpdateInGroup(typeof(OHNNLDNHKCN))]
internal class NFHFPAFNLAH : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C6E0", Offset = "0x2D1B4E0", VA = "0x182D1C6E0", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public NFHFPAFNLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2D24E70", Offset = "0x2D23C70", VA = "0x182D24E70")]
		public static ObjectModelConfigAsset FEPJODLGJML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xE8B1B0", Offset = "0xE89FB0", VA = "0x180E8B1B0")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DKGMECGHCPI(OJBFOICGDOF.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[DKGMECGHCPI(OJBFOICGDOF.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int IALIPEBLGLO = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly FGEMECIGOCC EKOKIILLNMO;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x44ADEC0", Offset = "0x44ACCC0", VA = "0x1844ADEC0")]
			public static MFDODOEBKCJ INIOAGKOPKL(int BIAPPEIECJC)
			{
				return default(MFDODOEBKCJ);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x44AE2B0", Offset = "0x44AD0B0", VA = "0x1844AE2B0")]
			private static void IPMNNEKANFP(CGKCPDMKDFM GBKNCKPDPOA, CGKCPDMKDFM ICPDIICEJJO, MFDODOEBKCJ FIIEHBGLOHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x44ADC70", Offset = "0x44ACA70", VA = "0x1844ADC70")]
			public static int BPIIKFIBNCH(GameObject HNLFAAIOFFP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x44ADE40", Offset = "0x44ACC40", VA = "0x1844ADE40")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void DHFIJBCLNMA(CGKCPDMKDFM HPLAKDFIDCJ, int BIAPPEIECJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static GMLHNNIDAIC IPJNDIBMKEC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static OANGJKKDDJL ILNHBFHICOK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static GMLHNNIDAIC GKFOBOEAKOL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2D25690", Offset = "0x2D24490", VA = "0x182D25690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2D25E70", Offset = "0x2D24C70", VA = "0x182D25E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static OANGJKKDDJL NDNILNONBDB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2D25420", Offset = "0x2D24220", VA = "0x182D25420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2D256F0", Offset = "0x2D244F0", VA = "0x182D256F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool IIGMMDMAJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2D25970", Offset = "0x2D24770", VA = "0x182D25970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static LKAAGIKDPMH MFKBNBOKJLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2D25CD0", Offset = "0x2D24AD0", VA = "0x182D25CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static AFJJBHJMGFE HOOKCAMEDII
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2D25D70", Offset = "0x2D24B70", VA = "0x182D25D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static OOMOONHDGPN OHHBHNKBJML
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2D25AD0", Offset = "0x2D248D0", VA = "0x182D25AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static LDOPIEJCCFG CNPBCJHLEOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2D26850", Offset = "0x2D25650", VA = "0x182D26850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static JCAPLMJKCDN DHCMMAHEOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2D25DF0", Offset = "0x2D24BF0", VA = "0x182D25DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static OOHEIMOEIOG JABNJIEFCNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2D25040", Offset = "0x2D23E40", VA = "0x182D25040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool FCGHIIIEEME
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2D268D0", Offset = "0x2D256D0", VA = "0x182D268D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool PJELHKHALNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2D25F50", Offset = "0x2D24D50", VA = "0x182D25F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool DCICJDKKPGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2D26080", Offset = "0x2D24E80", VA = "0x182D26080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool JDAIKGCNLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2D26510", Offset = "0x2D25310", VA = "0x182D26510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2D250C0", Offset = "0x2D23EC0", VA = "0x182D250C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool GGFJGKGNNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2D25C70", Offset = "0x2D24A70", VA = "0x182D25C70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2D266F0", Offset = "0x2D254F0", VA = "0x182D266F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action JMPJGIBKKIA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2D25240", Offset = "0x2D24040", VA = "0x182D25240")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2D26750", Offset = "0x2D25550", VA = "0x182D26750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2D26270", Offset = "0x2D25070", VA = "0x182D26270")]
		public static CGKCPDMKDFM LCEDMMGGMOH(GameObject HNLFAAIOFFP)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2D26360", Offset = "0x2D25160", VA = "0x182D26360")]
		public static bool MEDJEHNMKFL(ByteString AAOFEOFDGLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2D25B50", Offset = "0x2D24950", VA = "0x182D25B50")]
		public static EGBCNCKGEND GOLDLHCBAAO(MFDODOEBKCJ FIIEHBGLOHB)
		{
			return default(EGBCNCKGEND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2D25540", Offset = "0x2D24340", VA = "0x182D25540")]
		public static (ByteString, IDisposable) EPOBOPBJBKM()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2D263C0", Offset = "0x2D251C0", VA = "0x182D263C0")]
		public static (ByteString, IDisposable) MKDFPNDAFDN(IEnumerable<CGKCPDMKDFM> DFJIKCOIMCG)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2D24F10", Offset = "0x2D23D10", VA = "0x182D24F10")]
		public static bool ABMKMNJMNDO(GameObject HNLFAAIOFFP, out MFDODOEBKCJ FIIEHBGLOHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2D25120", Offset = "0x2D23F20", VA = "0x182D25120")]
		public static bool BGMMHNGFLPJ(IEnumerable<HMBPFBEHPFM> GILIMMAGMGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2D269B0", Offset = "0x2D257B0", VA = "0x182D269B0")]
		public static void OMLFHIGGKLA(bool LJCKIACCBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2D26570", Offset = "0x2D25370", VA = "0x182D26570")]
		public static Task NLDFBNDLGPG(bool LJCKIACCBLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2D25340", Offset = "0x2D24140", VA = "0x182D25340")]
		private static OANGJKKDDJL CMHMEFFEBBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2D26A90", Offset = "0x2D25890", VA = "0x182D26A90")]
		private static bool PCKJJPACPGO()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DKGMECGHCPI(OJBFOICGDOF.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BBA0", Offset = "0x2D2A9A0", VA = "0x182D2BBA0")]
		public static bool KDDLBOALCOO(BOGOKBNBEFE FHMIGGAIHOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B970", Offset = "0x2D2A770", VA = "0x182D2B970")]
		public static BOGOKBNBEFE GLJEDJEGGBC(GameObject HNLFAAIOFFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B770", Offset = "0x2D2A570", VA = "0x182D2B770")]
		public static BOGOKBNBEFE GLJEDJEGGBC(GameObject HNLFAAIOFFP, MFDODOEBKCJ FIIEHBGLOHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BC50", Offset = "0x2D2AA50", VA = "0x182D2BC50")]
		public static bool LNJAJGHFIBB(GameObject KOFDCLCOPIN, string KPDMMOJHOAL, bool PDMJMFKHCIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B570", Offset = "0x2D2A370", VA = "0x182D2B570")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void CEPBNCMFCNP(GameObject KOFDCLCOPIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BD50", Offset = "0x2D2AB50", VA = "0x182D2BD50")]
		[CompilerGenerated]
		internal static string OCELLEMNEOK((GameObject go, string prefabName) CFGJGLPAHFD)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, NJOEKKHDNMG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool PBGELHMIIFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CGKCPDMKDFM DAGKFBFFJOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7621D0", Offset = "0x760FD0", VA = "0x1807621D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(CGKCPDMKDFM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x2ECE0F0", Offset = "0x2ECCEF0", VA = "0x182ECE0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[DKGMECGHCPI(OJBFOICGDOF.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, BOGOKBNBEFE, NJOEKKHDNMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string OBKPFOLOIBN = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private JDEBCIMJANA GMDALJMBJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private CGKCPDMKDFM BMINGOEPCBN;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public CGKCPDMKDFM DAGKFBFFJOO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2ED3F00", Offset = "0x2ED2D00", VA = "0x182ED3F00", Slot = "15")]
			get
			{
				return default(CGKCPDMKDFM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public EGBCNCKGEND CFDPJBBJBKC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2ED3FB0", Offset = "0x2ED2DB0", VA = "0x182ED3FB0", Slot = "6")]
			get
			{
				return default(EGBCNCKGEND);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool PBGELHMIIFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2ED3EF0", Offset = "0x2ED2CF0", VA = "0x182ED3EF0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public JDEBCIMJANA CAIHMOLACJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA21270", Offset = "0xA20070", VA = "0x180A21270", Slot = "7")]
			get
			{
				return default(JDEBCIMJANA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private AFJJBHJMGFE HOOKCAMEDII
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2ED3500", Offset = "0x2ED2300", VA = "0x182ED3500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private EOKNELNBMBB FIBEAAKCHIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2ED34A0", Offset = "0x2ED22A0", VA = "0x182ED34A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool NNEGHPPMKPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x849670", Offset = "0x848470", VA = "0x180849670", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x812860", Offset = "0x811660", VA = "0x180812860", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> EMDBJPJBMKF
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2ED3DB0", Offset = "0x2ED2BB0", VA = "0x182ED3DB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2ED3FE0", Offset = "0x2ED2DE0", VA = "0x182ED3FE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<BOGOKBNBEFE> BNHKIHAHCKP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2ED3E50", Offset = "0x2ED2C50", VA = "0x182ED3E50", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2ED4080", Offset = "0x2ED2E80", VA = "0x182ED4080", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2ED32C0", Offset = "0x2ED20C0", VA = "0x182ED32C0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2ED3C10", Offset = "0x2ED2A10", VA = "0x182ED3C10", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2ED38C0", Offset = "0x2ED26C0", VA = "0x182ED38C0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2ED3B80", Offset = "0x2ED2980", VA = "0x182ED3B80", Slot = "10")]
		public void OnEmbody(AEJNGPFNACL BFCIPJDFKAG, CGKCPDMKDFM BMINGOEPCBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2ED3C00", Offset = "0x2ED2A00", VA = "0x182ED3C00", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2ED3970", Offset = "0x2ED2770", VA = "0x182ED3970", Slot = "12")]
		public void OnDisembody(bool OBLOGNGGALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2ED3760", Offset = "0x2ED2560", VA = "0x182ED3760")]
		private void LNPIAJENGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2ED35E0", Offset = "0x2ED23E0", VA = "0x182ED35E0")]
		private void JPMLKAINGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2ED3670", Offset = "0x2ED2470", VA = "0x182ED3670")]
		private void LCKLIMBFKHN(bool MNFDLPFDLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2ED3860", Offset = "0x2ED2660", VA = "0x182ED3860", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x10897A0", Offset = "0x10885A0", VA = "0x1810897A0", Slot = "9")]
		private GameObject AGMLLFMHFNJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[DKGMECGHCPI(OJBFOICGDOF.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override IAFDFFOCDLF BPPCHAHJKLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2D36B10", Offset = "0x2D35910", VA = "0x182D36B10", Slot = "6")]
			get
			{
				return default(IAFDFFOCDLF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D36AB0", Offset = "0x2D358B0", VA = "0x182D36AB0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[DKGMECGHCPI(OJBFOICGDOF.Registration)]
	public class TransformEntity : MonoBehaviour, NJOEKKHDNMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private IAFDFFOCDLF prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private CGKCPDMKDFM HPLAKDFIDCJ;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual IAFDFFOCDLF BPPCHAHJKLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x741BD0", Offset = "0x7409D0", VA = "0x180741BD0", Slot = "6")]
			get
			{
				return default(IAFDFFOCDLF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7FCB10", Offset = "0x7FB910", VA = "0x1807FCB10", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public CGKCPDMKDFM DAGKFBFFJOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xC94130", Offset = "0xC92F30", VA = "0x180C94130", Slot = "5")]
			get
			{
				return default(CGKCPDMKDFM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool PBGELHMIIFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x740030", Offset = "0x73EE30", VA = "0x180740030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA94EC0", Offset = "0xA93CC0", VA = "0x180A94EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity JJNHNHIMFGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal JCAPLMJKCDN DHCMMAHEOLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal EOKNELNBMBB BPBACDCNJOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2FE70C0", Offset = "0x2FE5EC0", VA = "0x182FE70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2FE70B0", Offset = "0x2FE5EB0", VA = "0x182FE70B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7130", Offset = "0x2FE5F30", VA = "0x182FE7130")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2FE72E0", Offset = "0x2FE60E0", VA = "0x182FE72E0")]
		internal void PGIHAENGDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7010", Offset = "0x2FE5E10", VA = "0x182FE7010")]
		private bool AELDJHGOHHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7220", Offset = "0x2FE6020", VA = "0x182FE7220")]
		private void OLJADMNHJHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7130", Offset = "0x2FE5F30", VA = "0x182FE7130")]
		internal void NEMCOOEJGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7250", Offset = "0x2FE6050", VA = "0x182FE7250")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7640", Offset = "0x2FE6440", VA = "0x182FE7640")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[GDFKOGKEDCG(typeof(OANGJKKDDJL), new string[] { })]
[BOOKNJKHAPG(typeof(NLIFEGBDOEH))]
public class MFCABGJOKGJ : OANGJKKDDJL, KDIIDKDLOKO, NLIFEGBDOEH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MEALJBAKAEI MENEIDJFFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private AFJJBHJMGFE POEIPOGPNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private LCLOCHGKNKG BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private ENCGEBBECLL PKINOBJMPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DGEELDEPBLB NOAFOBDAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private CNJKAGGGIMN OBLJBLEBOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public MEALJBAKAEI MFKBNBOKJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LCLOCHGKNKG DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public AFJJBHJMGFE HOOKCAMEDII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public DGEELDEPBLB BDNOOOIGFPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public CNJKAGGGIMN FNNDOAMKCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EFIIIACBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8F4C00", Offset = "0x8F3A00", VA = "0x1808F4C00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GJLNPONCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A0A0", Offset = "0x2D18EA0", VA = "0x182D1A0A0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CNDIDONCODC IHCFCPOGFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x995790", Offset = "0x994590", VA = "0x180995790", Slot = "10")]
		get
		{
			return default(CNDIDONCODC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D19E60", Offset = "0x2D18C60", VA = "0x182D19E60")]
	public static MFCABGJOKGJ CJALKNOJAHB(MEALJBAKAEI MENEIDJFFEP, HLDHFLCELPP AAPGBKEJGGC = HLDHFLCELPP.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void APHOPHFKPPA(MEALJBAKAEI MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void DJDAGHPKBEF(MEALJBAKAEI MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A0B0", Offset = "0x2D18EB0", VA = "0x182D1A0B0", Slot = "11")]
	public void HDEKFDKFOAD(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2840B90", Offset = "0x283F990", VA = "0x182840B90")]
	private void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2D19FB0", Offset = "0x2D18DB0", VA = "0x182D19FB0")]
	private void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D19F50", Offset = "0x2D18D50", VA = "0x182D19F50", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MFCABGJOKGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KFLGBPPCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x32B0980", Offset = "0x32AF780", VA = "0x1832B0980")]
	public static EGBCNCKGEND CPHCLKAHMMB(this OANGJKKDDJL ILNHBFHICOK, MFDODOEBKCJ FIIEHBGLOHB, IAFDFFOCDLF KCFAHJGLHLA)
	{
		return default(EGBCNCKGEND);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x32B0BE0", Offset = "0x32AF9E0", VA = "0x1832B0BE0")]
	public static KDLCLFDEGLN EJKDBBANIDE(this OANGJKKDDJL ILNHBFHICOK)
	{
		return default(KDLCLFDEGLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x32B0D00", Offset = "0x32AFB00", VA = "0x1832B0D00")]
	public static CGKCPDMKDFM LCEDMMGGMOH(this OANGJKKDDJL ILNHBFHICOK, Entity NEAKDKENHHP)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x32B0DB0", Offset = "0x32AFBB0", VA = "0x1832B0DB0")]
	public static CGKCPDMKDFM LCEDMMGGMOH(this OANGJKKDDJL ILNHBFHICOK, MFDODOEBKCJ FIIEHBGLOHB)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x32B0AC0", Offset = "0x32AF8C0", VA = "0x1832B0AC0")]
	public static MFDODOEBKCJ DOPAKLHPIEI(this OANGJKKDDJL ILNHBFHICOK, CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return default(MFDODOEBKCJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum HLDHFLCELPP
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
[Cpp2IlInjected.Token(Token = "0x2000015")]
[GDFKOGKEDCG(typeof(CNJKAGGGIMN), new string[] { })]
public class GOEDJMDNFJG : CNJKAGGGIMN, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[DNEBGGIIGBA]
	private NLIFEGBDOEH LPAHIKHANFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private MEALJBAKAEI MENEIDJFFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private CJEAPPIFFGL NOAFOBDAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private ENCGEBBECLL PKINOBJMPCN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OIDCFIJBIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x32A2F40", Offset = "0x32A1D40", VA = "0x1832A2F40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x32A3380", Offset = "0x32A2180", VA = "0x1832A3380", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x32A30A0", Offset = "0x32A1EA0", VA = "0x1832A30A0", Slot = "16")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x32A3220", Offset = "0x32A2020", VA = "0x1832A3220", Slot = "13")]
	public void IPNHLGCNIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "6")]
	public void DACGIMMGMBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x32A3330", Offset = "0x32A2130", VA = "0x1832A3330", Slot = "7")]
	public void MDOKDFDOBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x32A3260", Offset = "0x32A2060", VA = "0x1832A3260", Slot = "8")]
	public void JNBDECCIDAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1C1F3C0", Offset = "0x1C1E1C0", VA = "0x181C1F3C0", Slot = "9")]
	public void DFCKDFOJOGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x32A31D0", Offset = "0x32A1FD0", VA = "0x1832A31D0", Slot = "10")]
	public void HNCAPECACBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x32A2FE0", Offset = "0x32A1DE0", VA = "0x1832A2FE0", Slot = "11")]
	public bool BGMMHNGFLPJ(IEnumerable<HMBPFBEHPFM> GILIMMAGMGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x32A32E0", Offset = "0x32A20E0", VA = "0x1832A32E0", Slot = "12")]
	public void LLHAFDOBLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x32A3180", Offset = "0x32A1F80", VA = "0x1832A3180", Slot = "14")]
	public void HLIOCJAOGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x32A3420", Offset = "0x32A2220", VA = "0x1832A3420", Slot = "15")]
	public void NNMFJAAEPBA(bool HJLCONBGBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x32A3150", Offset = "0x32A1F50", VA = "0x1832A3150")]
	private void HCCKNEIOBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GOEDJMDNFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[GDFKOGKEDCG(typeof(DGEELDEPBLB), new string[] { })]
public class DBEBIBJHPMJ : DGEELDEPBLB, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[DNEBGGIIGBA]
	private NLIFEGBDOEH LPAHIKHANFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private MEALJBAKAEI MENEIDJFFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private CJEAPPIFFGL NOAFOBDAJFE;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9B50", Offset = "0x2EC8950", VA = "0x182EC9B50", Slot = "6")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9BE0", Offset = "0x2EC89E0", VA = "0x182EC9BE0", Slot = "4")]
	public ByteString EPOBOPBJBKM(out IDisposable LCLABMMKDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9A30", Offset = "0x2EC8830", VA = "0x182EC9A30", Slot = "5")]
	public void BPPOCFBLMGN(ByteString MMJOHADFCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public DBEBIBJHPMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class LIEGJFFGAMJ<T> : global::LIIFNCOLBAG<T>, global::LFLIGLKEMAN<MFDODOEBKCJ, T>, global::MFKIABFKCIC<MFDODOEBKCJ>, CANPGFJEDGO, IDisposable, LMCAKPAONGF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly global::MFKIABFKCIC<Entity> FHINIKPHPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Delegate FKKJFLBEBHO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string JAGOKEMFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2C00710", Offset = "0x2BFF510", VA = "0x182C00710", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type FKLLKDBMLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C03200", Offset = "0x2C02000", VA = "0x182C03200", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KBEOGLGHKEJ NLGGOOGIJFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C03350", Offset = "0x2C02150", VA = "0x182C03350", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int NBCFDMNOBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C006C0", Offset = "0x2BFF4C0", VA = "0x182C006C0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ANLDNMOIDKD PBNMDOIMFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C00190", Offset = "0x2BFEF90", VA = "0x182C00190", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x109CA20", Offset = "0x109B820", VA = "0x18109CA20", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C04150", Offset = "0x2C02F50", VA = "0x182C04150", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::BHGLGGOBCED<MFDODOEBKCJ> JMPJGIBKKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BFF030", Offset = "0x2BFDE30", VA = "0x182BFF030", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C046F0", Offset = "0x2C034F0", VA = "0x182C046F0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C060A0", Offset = "0x2C04EA0", VA = "0x182C060A0")]
	public LIEGJFFGAMJ(global::MFKIABFKCIC<Entity> FHINIKPHPFG, JCAPLMJKCDN MKBBGINEDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2BFFE50", Offset = "0x2BFEC50", VA = "0x182BFFE50")]
	private Entity EJPGKLALKON(MFDODOEBKCJ FIIEHBGLOHB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2BFFD70", Offset = "0x2BFEB70", VA = "0x182BFFD70")]
	private MFDODOEBKCJ EJPGKLALKON(Entity NEAKDKENHHP)
	{
		return default(MFDODOEBKCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE350", Offset = "0x2BFD150", VA = "0x182BFE350", Slot = "4")]
	public T BANNGLOAJDI(MFDODOEBKCJ FIIEHBGLOHB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C03730", Offset = "0x2C02530", VA = "0x182C03730")]
	public bool KKNDJJJFEOO(MFDODOEBKCJ FIIEHBGLOHB, in T IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF380", Offset = "0x2BFE180", VA = "0x182BFF380")]
	public bool DFPHNCLNGAI(MFDODOEBKCJ FIIEHBGLOHB, in T IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C03FC0", Offset = "0x2C02DC0", VA = "0x182C03FC0", Slot = "9")]
	public bool LCHDIFCJOJC(MFDODOEBKCJ FIIEHBGLOHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF2A0", Offset = "0x2BFE0A0", VA = "0x182BFF2A0", Slot = "26")]
	public object BKOOJPCAPLL(MFDODOEBKCJ FIIEHBGLOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C04E60", Offset = "0x2C03C60", VA = "0x182C04E60")]
	public bool OBJICEBFPBG(MFDODOEBKCJ FIIEHBGLOHB, in object IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BFEBF0", Offset = "0x2BFD9F0", VA = "0x182BFEBF0")]
	public void BANNGLOAJDI(MFDODOEBKCJ FIIEHBGLOHB, in KPCNMJOGJPJ MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C033F0", Offset = "0x2C021F0", VA = "0x182C033F0")]
	public bool KKNDJJJFEOO(MFDODOEBKCJ FIIEHBGLOHB, in BDKOOLPOOEA IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BFFCF0", Offset = "0x2BFEAF0", VA = "0x182BFFCF0")]
	public bool DFPHNCLNGAI(MFDODOEBKCJ FIIEHBGLOHB, in BDKOOLPOOEA IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C013F0", Offset = "0x2C001F0", VA = "0x182C013F0", Slot = "22")]
	public void JEDOBACEBFK(BJCPCNKDADF PDDEBNBLNHF, [Optional] object IJBJKIBEJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C01710", Offset = "0x2C00510", VA = "0x182C01710", Slot = "15")]
	public void JEDOBACEBFK(MFDODOEBKCJ JHANOPJHOLP, LCJKGBJCLDD PDDEBNBLNHF, object IJBJKIBEJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C004C0", Offset = "0x2BFF2C0", VA = "0x182C004C0", Slot = "14")]
	public bool FGNHAFDBLPE(MFDODOEBKCJ JENDJNEIBPJ, MFDODOEBKCJ EKDHPMHGKLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2351080", Offset = "0x234FE80", VA = "0x182351080", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C06000", Offset = "0x2C04E00", VA = "0x182C06000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2BFECB0", Offset = "0x2BFDAB0", VA = "0x182BFECB0")]
	public string BCBMBCODPAD(in BDKOOLPOOEA BEFJJAKNEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2C056F0", Offset = "0x2C044F0", VA = "0x182C056F0")]
	private void PEMEJKBKKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2C00D90", Offset = "0x2BFFB90", VA = "0x182C00D90")]
	private void ILNJDAHBEJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C02C50", Offset = "0x2C01A50", VA = "0x182C02C50")]
	private void KAGIEBIJJDC(Entity NEAKDKENHHP, in BDKOOLPOOEA BFKCKCENCEE, in BDKOOLPOOEA IJHAJFKAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C043A0", Offset = "0x2C031A0", VA = "0x182C043A0")]
	private void NLMDPBOJHFM(Entity NEAKDKENHHP, in BDKOOLPOOEA BFKCKCENCEE, in BDKOOLPOOEA IJHAJFKAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BFCEC0", Offset = "0x2BFBCC0", VA = "0x182BFCEC0")]
	[Conditional("DEBUG_BUILD")]
	private static void AFJJEKGJFJL(Entity NEAKDKENHHP, MFDODOEBKCJ FIIEHBGLOHB, string HANNKCHKNMG, string IMHNOFKAKFA, [CallerMemberName] string HKIMNJFCDEB = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2BFEEA0", Offset = "0x2BFDCA0", VA = "0x182BFEEA0", Slot = "5")]
	private bool BEDOLAGGIAB(MFDODOEBKCJ JHANOPJHOLP, in T IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2C008A0", Offset = "0x2BFF6A0", VA = "0x182C008A0", Slot = "6")]
	private bool HDEKMDJELJD(MFDODOEBKCJ JHANOPJHOLP, in T IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x24F1E70", Offset = "0x24F0C70", VA = "0x1824F1E70", Slot = "10")]
	private bool HACAJGFEKFE(MFDODOEBKCJ JHANOPJHOLP, in object IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2C05260", Offset = "0x2C04060", VA = "0x182C05260", Slot = "11")]
	private void OFOKIDKEIEF(MFDODOEBKCJ JHANOPJHOLP, in KPCNMJOGJPJ MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2C03DE0", Offset = "0x2C02BE0", VA = "0x182C03DE0", Slot = "12")]
	private bool LAFIHICJPMA(MFDODOEBKCJ JHANOPJHOLP, in BDKOOLPOOEA IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2C040E0", Offset = "0x2C02EE0", VA = "0x182C040E0", Slot = "13")]
	private bool MCGJJEFOGHA(MFDODOEBKCJ JHANOPJHOLP, in BDKOOLPOOEA IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2C008D0", Offset = "0x2BFF6D0", VA = "0x182C008D0", Slot = "16")]
	private string HJAOEJKKIPG(in BDKOOLPOOEA MGFMONLLLPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class DONPKNBBDNA<T> : global::FHOFMOODKOK<T>, global::LFLIGLKEMAN<CGKCPDMKDFM, T>, global::MFKIABFKCIC<CGKCPDMKDFM>, CANPGFJEDGO, IDisposable, AFJNBCJHANB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly global::MFKIABFKCIC<Entity> FHINIKPHPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Delegate FKKJFLBEBHO;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string JAGOKEMFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4CB9B40", Offset = "0x4CB8940", VA = "0x184CB9B40", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type FKLLKDBMLDL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4CC3B80", Offset = "0x4CC2980", VA = "0x184CC3B80", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public KBEOGLGHKEJ NLGGOOGIJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4CC4080", Offset = "0x4CC2E80", VA = "0x184CC4080", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int NBCFDMNOBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4CB9410", Offset = "0x4CB8210", VA = "0x184CB9410", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public ANLDNMOIDKD PBNMDOIMFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8C40", Offset = "0x4CB7A40", VA = "0x184CB8C40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4189D00", Offset = "0x4188B00", VA = "0x184189D00", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4193340", Offset = "0x4192140", VA = "0x184193340", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::BHGLGGOBCED<CGKCPDMKDFM> JMPJGIBKKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4CB57B0", Offset = "0x4CB45B0", VA = "0x184CB57B0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4CC8660", Offset = "0x4CC7460", VA = "0x184CC8660", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2C060A0", Offset = "0x2C04EA0", VA = "0x182C060A0")]
	public DONPKNBBDNA(global::MFKIABFKCIC<Entity> FHINIKPHPFG, JCAPLMJKCDN MKBBGINEDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1D09F00", Offset = "0x1D08D00", VA = "0x181D09F00")]
	private Entity EJPGKLALKON(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x41889B0", Offset = "0x41877B0", VA = "0x1841889B0")]
	private CGKCPDMKDFM EJPGKLALKON(Entity NEAKDKENHHP)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3870", Offset = "0x4CB2670", VA = "0x184CB3870", Slot = "4")]
	public T BANNGLOAJDI(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4CC50A0", Offset = "0x4CC3EA0", VA = "0x184CC50A0")]
	public bool KKNDJJJFEOO(CGKCPDMKDFM HPLAKDFIDCJ, in T IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4CB72C0", Offset = "0x4CB60C0", VA = "0x184CB72C0")]
	public bool DFPHNCLNGAI(CGKCPDMKDFM HPLAKDFIDCJ, in T IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4CC71A0", Offset = "0x4CC5FA0", VA = "0x184CC71A0", Slot = "9")]
	public bool LCHDIFCJOJC(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4186C40", Offset = "0x4185A40", VA = "0x184186C40", Slot = "26")]
	public object BKOOJPCAPLL(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4CCAA30", Offset = "0x4CC9830", VA = "0x184CCAA30")]
	public bool OBJICEBFPBG(CGKCPDMKDFM HPLAKDFIDCJ, in object IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2220", Offset = "0x4CB1020", VA = "0x184CB2220")]
	public void BANNGLOAJDI(CGKCPDMKDFM HPLAKDFIDCJ, in KPCNMJOGJPJ MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4190E50", Offset = "0x418FC50", VA = "0x184190E50")]
	public bool KKNDJJJFEOO(CGKCPDMKDFM HPLAKDFIDCJ, in BDKOOLPOOEA IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4186FE0", Offset = "0x4185DE0", VA = "0x184186FE0")]
	public bool DFPHNCLNGAI(CGKCPDMKDFM HPLAKDFIDCJ, in BDKOOLPOOEA IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2C013F0", Offset = "0x2C001F0", VA = "0x182C013F0", Slot = "22")]
	public void JEDOBACEBFK(BJCPCNKDADF PDDEBNBLNHF, [Optional] object IJBJKIBEJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4CBCA90", Offset = "0x4CBB890", VA = "0x184CBCA90", Slot = "15")]
	public void JEDOBACEBFK(CGKCPDMKDFM JHANOPJHOLP, LCJKGBJCLDD PDDEBNBLNHF, object IJBJKIBEJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x41893F0", Offset = "0x41881F0", VA = "0x1841893F0", Slot = "14")]
	public bool FGNHAFDBLPE(CGKCPDMKDFM JENDJNEIBPJ, CGKCPDMKDFM EKDHPMHGKLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4CCD110", Offset = "0x4CCBF10", VA = "0x184CCD110")]
	private void PEMEJKBKKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4CBA150", Offset = "0x4CB8F50", VA = "0x184CBA150")]
	private void ILNJDAHBEJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4CC0BC0", Offset = "0x4CBF9C0", VA = "0x184CC0BC0")]
	private void KAGIEBIJJDC(Entity NEAKDKENHHP, in BDKOOLPOOEA BFKCKCENCEE, in BDKOOLPOOEA IJHAJFKAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4CC7ED0", Offset = "0x4CC6CD0", VA = "0x184CC7ED0")]
	private void NLMDPBOJHFM(Entity NEAKDKENHHP, in BDKOOLPOOEA BFKCKCENCEE, in BDKOOLPOOEA IJHAJFKAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4188980", Offset = "0x4187780", VA = "0x184188980", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4CCE3D0", Offset = "0x4CCD1D0", VA = "0x184CCE3D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2BFECB0", Offset = "0x2BFDAB0", VA = "0x182BFECB0")]
	public string BCBMBCODPAD(in BDKOOLPOOEA BEFJJAKNEPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4193200", Offset = "0x4192000", VA = "0x184193200", Slot = "5")]
	private bool LNHDCNJBHAJ(CGKCPDMKDFM JHANOPJHOLP, in T IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x418CD90", Offset = "0x418BB90", VA = "0x18418CD90", Slot = "6")]
	private bool JGNAFBNCPDG(CGKCPDMKDFM JHANOPJHOLP, in T IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4188DF0", Offset = "0x4187BF0", VA = "0x184188DF0", Slot = "10")]
	private bool EOBMDLHAAOO(CGKCPDMKDFM JHANOPJHOLP, in object IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4190A00", Offset = "0x418F800", VA = "0x184190A00", Slot = "11")]
	private void KEMHNIPGAMB(CGKCPDMKDFM JHANOPJHOLP, in KPCNMJOGJPJ MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x41931C0", Offset = "0x4191FC0", VA = "0x1841931C0", Slot = "12")]
	private bool LFKIBPHIHLL(CGKCPDMKDFM JHANOPJHOLP, in BDKOOLPOOEA IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4193240", Offset = "0x4192040", VA = "0x184193240", Slot = "13")]
	private bool MGPNDIECCMN(CGKCPDMKDFM JHANOPJHOLP, in BDKOOLPOOEA IJHAJFKAPBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2C008D0", Offset = "0x2BFF6D0", VA = "0x182C008D0", Slot = "16")]
	private string EEPEOOOLGCG(in BDKOOLPOOEA MGFMONLLLPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NNJPEODGOHC : IDisposable, BINGFNLPMDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> AMNCKIPHFNF;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> DBGLMPMGFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xD5A960", Offset = "0xD59760", VA = "0x180D5A960", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xD60330", Offset = "0xD5F130", VA = "0x180D60330")]
	public NNJPEODGOHC(NativeArray<EntityRemapUtility.EntityRemapInfo> AMNCKIPHFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CFA0", Offset = "0x2D1BDA0", VA = "0x182D1CFA0", Slot = "6")]
	public CGKCPDMKDFM NLLPPGHKENN(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CFF0", Offset = "0x2D1BDF0", VA = "0x182D1CFF0", Slot = "7")]
	public Entity NLLPPGHKENN(Entity NEAKDKENHHP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CF00", Offset = "0x2D1BD00", VA = "0x182D1CF00", Slot = "8")]
	public IEnumerable<CGKCPDMKDFM> NLLPPGHKENN(IEnumerable<CGKCPDMKDFM> DFJIKCOIMCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CEA0", Offset = "0x2D1BCA0", VA = "0x182D1CEA0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DKGMECGHCPI(OJBFOICGDOF.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly FGEMECIGOCC JMHHANPIEON;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static int EGICHGODHGH;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static BINGFNLPMDN ODEHDAALPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool KBBLKCFCJBA;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> DBGLMPMGFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x2FDF660", Offset = "0x2FDE460", VA = "0x182FDF660")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool MFIKILBBBLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2FDF880", Offset = "0x2FDE680", VA = "0x182FDF880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2FDFBA0", Offset = "0x2FDE9A0", VA = "0x182FDFBA0")]
		public static SerializationRemapScope PJABLCJPIHL()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2FDFC90", Offset = "0x2FDEA90", VA = "0x182FDFC90")]
		public SerializationRemapScope(BINGFNLPMDN OLEGKEENCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF770", Offset = "0x2FDE570", VA = "0x182FDF770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF910", Offset = "0x2FDE710", VA = "0x182FDF910")]
		public static CGKCPDMKDFM NLLPPGHKENN(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2FDFA70", Offset = "0x2FDE870", VA = "0x182FDFA70")]
		public static Entity NLLPPGHKENN(Entity NEAKDKENHHP)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[JAPKICPMJLM(DIMCOFJGPGL.Application)]
[GDFKOGKEDCG(typeof(KNDJIOLEELA), new string[] { "Editor" })]
public sealed class KNDJIOLEELA
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void BDMLEAGMAND(MFDODOEBKCJ PPGNBGBKLEI, FDFCOIOFJLK MMJOHADFCHO, bool NMBGLEDOGPH);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void OHPNJELBNEA(MFDODOEBKCJ PPGNBGBKLEI, bool NMBGLEDOGPH);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void FBDPOCIPBIN(MFDODOEBKCJ PPGNBGBKLEI, DFNAMHCDDIN FHINIKPHPFG, in BDKOOLPOOEA MGFMONLLLPD, bool NMBGLEDOGPH);

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event BDMLEAGMAND EGEIBDJBKAO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x32B26E0", Offset = "0x32B14E0", VA = "0x1832B26E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x32B2350", Offset = "0x32B1150", VA = "0x1832B2350")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event OHPNJELBNEA CKJNEMLONEG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x32B2580", Offset = "0x32B1380", VA = "0x1832B2580")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x32B2640", Offset = "0x32B1440", VA = "0x1832B2640")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event FBDPOCIPBIN HAKCBKOJEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x32B2490", Offset = "0x32B1290", VA = "0x1832B2490")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x32B23F0", Offset = "0x32B11F0", VA = "0x1832B23F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x32B2620", Offset = "0x32B1420", VA = "0x1832B2620")]
	[Conditional("UNITY_EDITOR")]
	public void FNLCKBACFII(MFDODOEBKCJ PPGNBGBKLEI, in FDFCOIOFJLK MMJOHADFCHO, bool NMBGLEDOGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x32B2560", Offset = "0x32B1360", VA = "0x1832B2560")]
	[Conditional("UNITY_EDITOR")]
	public void FGHDJCAFIOM(MFDODOEBKCJ PPGNBGBKLEI, bool NMBGLEDOGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x32B2530", Offset = "0x32B1330", VA = "0x1832B2530")]
	[Conditional("UNITY_EDITOR")]
	public void ECMEDFJOIED(MFDODOEBKCJ PPGNBGBKLEI, DFNAMHCDDIN FHINIKPHPFG, in BDKOOLPOOEA MGFMONLLLPD, bool NMBGLEDOGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KNDJIOLEELA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[GDFKOGKEDCG(typeof(KDBCABAKEFA), new string[] { "Editor" })]
[JAPKICPMJLM(DIMCOFJGPGL.Application)]
public sealed class KDBCABAKEFA
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void LDPPKFENFEO(MFDODOEBKCJ FIIEHBGLOHB, FDFCOIOFJLK MMJOHADFCHO, bool NMBGLEDOGPH);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void PMCKOAJJGID(MFDODOEBKCJ FIIEHBGLOHB, bool NMBGLEDOGPH);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void JPEHKNLCLND(MFDODOEBKCJ FIIEHBGLOHB, DFNAMHCDDIN FHINIKPHPFG, in BDKOOLPOOEA MGFMONLLLPD, bool NMBGLEDOGPH, bool OEENKOMGMEP);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void CLJLHJKBBFL(MFDODOEBKCJ FIIEHBGLOHB, DFNAMHCDDIN FHINIKPHPFG, in BDKOOLPOOEA BFKCKCENCEE, in BDKOOLPOOEA IJHAJFKAPBA);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate void ICBLANOKKJL(DJGPOMDGMPN JHANOPJHOLP, ReadOnlyMemory<byte> HIHKKNOLPAP);

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event Action<World> BJPNBJDPFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x32AFC50", Offset = "0x32AEA50", VA = "0x1832AFC50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x32B0330", Offset = "0x32AF130", VA = "0x1832B0330")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> EFIFLNJKEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x32B03F0", Offset = "0x32AF1F0", VA = "0x1832B03F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x32AFD80", Offset = "0x32AEB80", VA = "0x1832AFD80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event LDPPKFENFEO EGEIBDJBKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x32B0180", Offset = "0x32AEF80", VA = "0x1832B0180")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x32AF550", Offset = "0x32AE350", VA = "0x1832AF550")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event PMCKOAJJGID CKJNEMLONEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x32AF940", Offset = "0x32AE740", VA = "0x1832AF940")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x32AFBB0", Offset = "0x32AE9B0", VA = "0x1832AFBB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event LDPPKFENFEO NKPBBJMJHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x32B0220", Offset = "0x32AF020", VA = "0x1832B0220")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x32AFA50", Offset = "0x32AE850", VA = "0x1832AFA50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event PMCKOAJJGID IHIMGLCFBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x32B00E0", Offset = "0x32AEEE0", VA = "0x1832B00E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x32AFAF0", Offset = "0x32AE8F0", VA = "0x1832AFAF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event JPEHKNLCLND HAKCBKOJEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x32AF730", Offset = "0x32AE530", VA = "0x1832AF730")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x32AF5F0", Offset = "0x32AE3F0", VA = "0x1832AF5F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event CLJLHJKBBFL KIFGELAEGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x32AF8A0", Offset = "0x32AE6A0", VA = "0x1832AF8A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x32B0010", Offset = "0x32AEE10", VA = "0x1832B0010")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> JHFLIDPPGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x32AFF70", Offset = "0x32AED70", VA = "0x1832AFF70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x32AF7D0", Offset = "0x32AE5D0", VA = "0x1832AF7D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event ICBLANOKKJL GJLNHEKEJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x32AF690", Offset = "0x32AE490", VA = "0x1832AF690")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x32AFED0", Offset = "0x32AECD0", VA = "0x1832AFED0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x32AFEA0", Offset = "0x32AECA0", VA = "0x1832AFEA0")]
	[Conditional("UNITY_EDITOR")]
	public void NADDAHMEPFP(MFDODOEBKCJ FIIEHBGLOHB, in FDFCOIOFJLK MMJOHADFCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x32AFB90", Offset = "0x32AE990", VA = "0x1832AFB90")]
	[Conditional("UNITY_EDITOR")]
	public void IBFIBMODLFL(MFDODOEBKCJ FIIEHBGLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x32AF870", Offset = "0x32AE670", VA = "0x1832AF870")]
	[Conditional("UNITY_EDITOR")]
	public void DCKFIAGAIFK(MFDODOEBKCJ FIIEHBGLOHB, in FDFCOIOFJLK MMJOHADFCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x32AFA00", Offset = "0x32AE800", VA = "0x1832AFA00")]
	[Conditional("UNITY_EDITOR")]
	public void GHNIBADDCLG(MFDODOEBKCJ FIIEHBGLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x32AFA20", Offset = "0x32AE820", VA = "0x1832AFA20")]
	[Conditional("UNITY_EDITOR")]
	public void GIGBAGFOOCC(MFDODOEBKCJ FIIEHBGLOHB, DFNAMHCDDIN FHINIKPHPFG, in BDKOOLPOOEA MGFMONLLLPD, bool OEENKOMGMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x32AF9E0", Offset = "0x32AE7E0", VA = "0x1832AF9E0")]
	[Conditional("UNITY_EDITOR")]
	public void FPCNKDAKDDP(MFDODOEBKCJ FIIEHBGLOHB, DFNAMHCDDIN FHINIKPHPFG, in BDKOOLPOOEA BFKCKCENCEE, in BDKOOLPOOEA IJHAJFKAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x32AFE40", Offset = "0x32AEC40", VA = "0x1832AFE40")]
	[Conditional("UNITY_EDITOR")]
	public void MBBAFDLEJGJ(string ICIEGOLHGJN, object HIHKKNOLPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x32B00B0", Offset = "0x32AEEB0", VA = "0x1832B00B0")]
	[Conditional("UNITY_EDITOR")]
	public void OIIDDBGPKDG(DJGPOMDGMPN JHANOPJHOLP, ReadOnlyMemory<byte> HIHKKNOLPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x32B02C0", Offset = "0x32AF0C0", VA = "0x1832B02C0")]
	[Conditional("UNITY_EDITOR")]
	public void PIBPHOGCFJC(World BFCIPJDFKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x32AFD10", Offset = "0x32AEB10", VA = "0x1832AFD10")]
	[Conditional("UNITY_EDITOR")]
	public void KLNAEKJMIEA(World BFCIPJDFKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KDBCABAKEFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[GDFKOGKEDCG(typeof(DAEINMEAKHD), new string[] { })]
public class KEFKLFJEAOO : DAEINMEAKHD
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x32B05A0", Offset = "0x32AF3A0", VA = "0x1832B05A0", Slot = "5")]
	public void CDEOINOGOKA(object GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x32B0690", Offset = "0x32AF490", VA = "0x1832B0690", Slot = "6")]
	public void ILLIMMIBOAK(object GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x32B04B0", Offset = "0x32AF2B0", VA = "0x1832B04B0", Slot = "7")]
	public void CCAFNAAICMB(object GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x32B0780", Offset = "0x32AF580", VA = "0x1832B0780", Slot = "4")]
	public IDisposable KLODGIEEKCH(object GPAOLHFLBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KEFKLFJEAOO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[DKGMECGHCPI(OJBFOICGDOF.Serialization)]
	[GDFKOGKEDCG(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	internal class BulkInstantiateSceneObjectService : JPLAKHLHFLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string GBGIDBGLPAO = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[DNEBGGIIGBA]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL EOHGMNFKFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[DNEBGGIIGBA]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[DNEBGGIIGBA]
		private EOKNELNBMBB LPMGOCJAKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EntityQuery MDGOJCELDPM;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EntityManager CCEKCIJDDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2EB9D40", Offset = "0x2EB8B40", VA = "0x182EB9D40")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8BA0", Offset = "0x2EB79A0", VA = "0x182EB8BA0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8B90", Offset = "0x2EB7990", VA = "0x182EB8B90", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8840", Offset = "0x2EB7640", VA = "0x182EB8840")]
		public bool BGMMHNGFLPJ(IEnumerable<HMBPFBEHPFM> DGECPAGIOBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9D90", Offset = "0x2EB8B90", VA = "0x182EB9D90")]
		public static bool IFMDPKBHOFM(HMBPFBEHPFM CCNKPMLIOPA, out MFDODOEBKCJ FIIEHBGLOHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8D20", Offset = "0x2EB7B20", VA = "0x182EB8D20")]
		private void EGEHGJJAEID(Dictionary<MFDODOEBKCJ, HMBPFBEHPFM> HNFKMIGCOAJ, IEnumerable<HMBPFBEHPFM> DGECPAGIOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2EB90A0", Offset = "0x2EB7EA0", VA = "0x182EB90A0")]
		private void FNAHMDGIAHJ(Dictionary<MFDODOEBKCJ, HMBPFBEHPFM> HNFKMIGCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9EA0", Offset = "0x2EB8CA0", VA = "0x182EB9EA0")]
		private void MFGJDNJHEBG(Dictionary<MFDODOEBKCJ, HMBPFBEHPFM> HNFKMIGCOAJ, MFDODOEBKCJ FIIEHBGLOHB, string ICIEGOLHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2EB84E0", Offset = "0x2EB72E0", VA = "0x182EB84E0")]
		private void BDNDNIOBACD(Dictionary<MFDODOEBKCJ, HMBPFBEHPFM> HNFKMIGCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2EB94A0", Offset = "0x2EB82A0", VA = "0x182EB94A0")]
		private void GFOELGDGAAN(Dictionary<MFDODOEBKCJ, HMBPFBEHPFM> HNFKMIGCOAJ, List<HMBPFBEHPFM> HLBIOHHGJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2EB89C0", Offset = "0x2EB77C0", VA = "0x182EB89C0")]
		private NativeList<MFDODOEBKCJ> CLHNFHJCHJN(Dictionary<MFDODOEBKCJ, HMBPFBEHPFM> HNFKMIGCOAJ)
		{
			return default(NativeList<MFDODOEBKCJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2EB92D0", Offset = "0x2EB80D0", VA = "0x182EB92D0")]
		private NativeArray<Entity> FNNJDIFNAME(NativeList<MFDODOEBKCJ> HKFILLHGGHI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA380", Offset = "0x2EB9180", VA = "0x182EBA380")]
		private static void PIBPEBKAONN(Dictionary<MFDODOEBKCJ, HMBPFBEHPFM> HNFKMIGCOAJ, MFDODOEBKCJ FIIEHBGLOHB, HMBPFBEHPFM CCNKPMLIOPA, string ICIEGOLHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[JAPKICPMJLM(DIMCOFJGPGL.Application)]
	[GDFKOGKEDCG(typeof(DebugWorldsService), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.Serialization)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static bool GJLNPONCPOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x2ECD8D0", Offset = "0x2ECC6D0", VA = "0x182ECD8D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x2ECD950", Offset = "0x2ECC750", VA = "0x182ECD950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool PNLFDBMOIBB
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x2ECD990", Offset = "0x2ECC790", VA = "0x182ECD990")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x2ECD910", Offset = "0x2ECC710", VA = "0x182ECD910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		public void MPNHCDPCOOP(string ICIEGOLHGJN, EntityManager PAHBLOLNPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		public static void ODCBHOABBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[GDFKOGKEDCG(typeof(ENCGEBBECLL), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.Application)]
internal class ENCGEBBECLL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool GJLNPONCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x745880", Offset = "0x744680", VA = "0x180745880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7458A0", Offset = "0x7446A0", VA = "0x1807458A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool GKHIINHLAJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C8A60", Offset = "0x7C7860", VA = "0x1807C8A60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C8A70", Offset = "0x7C7870", VA = "0x1807C8A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public ENCGEBBECLL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[GDFKOGKEDCG(typeof(CJEAPPIFFGL), new string[] { })]
	[BOOKNJKHAPG(typeof(SerializationService))]
	[DKGMECGHCPI(OJBFOICGDOF.Serialization)]
	internal class SerializationService : CJEAPPIFFGL, IDisposable, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly FGEMECIGOCC EKBOKAGOJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[DNEBGGIIGBA]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[DNEBGGIIGBA]
		private DOIIJCEPMEC NKBLKEDOMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[DNEBGGIIGBA]
		private ENCGEBBECLL PKINOBJMPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private BPGFDLNBIPE EKCIGGHMEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private HPJPPBPFICL MBCGEPONBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private SerializationRemapScope LCLABMMKDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool? NKGHGAHFNFH;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool PBMHAAKPPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2FE0AD0", Offset = "0x2FDF8D0", VA = "0x182FE0AD0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2FE1270", Offset = "0x2FE0070", VA = "0x182FE1270", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool JDABGHGMDNP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x7FC3E0", Offset = "0x7FB1E0", VA = "0x1807FC3E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x7FCB90", Offset = "0x7FB990", VA = "0x1807FCB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public HPJPPBPFICL KMGHEIGLPDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0A30", Offset = "0x2FDF830", VA = "0x182FE0A30", Slot = "16")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0A20", Offset = "0x2FDF820", VA = "0x182FE0A20", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2FE14B0", Offset = "0x2FE02B0", VA = "0x182FE14B0")]
		public static bool MEDJEHNMKFL(ByteString AAOFEOFDGLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7833A0", Offset = "0x7821A0", VA = "0x1807833A0")]
		public void INLOHAJHEON(BPGFDLNBIPE NKFBAGFDEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2FE1B80", Offset = "0x2FE0980", VA = "0x182FE1B80", Slot = "5")]
		public void OOJHCFEKAGP(bool LJCKIACCBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2FE11E0", Offset = "0x2FDFFE0", VA = "0x182FE11E0", Slot = "6")]
		public Task KOBCIODDPDF(bool LJCKIACCBLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0CC0", Offset = "0x2FDFAC0", VA = "0x182FE0CC0", Slot = "7")]
		public ByteString EPOBOPBJBKM(out IDisposable LCLABMMKDIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0AE0", Offset = "0x2FDF8E0", VA = "0x182FE0AE0", Slot = "19")]
		public ByteString EPOBOPBJBKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0330", Offset = "0x2FDF130", VA = "0x182FE0330", Slot = "9")]
		public bool BPPOCFBLMGN(ByteString KFFNDELDPON, BPENIKLHEOF AAPGBKEJGGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2FE15E0", Offset = "0x2FE03E0", VA = "0x182FE15E0")]
		private bool NKCJCCPDGBI(ByteString KFFNDELDPON, BPENIKLHEOF AAPGBKEJGGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2FE06C0", Offset = "0x2FDF4C0", VA = "0x182FE06C0", Slot = "8")]
		public void CPAELHNGHAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0F70", Offset = "0x2FDFD70", VA = "0x182FE0F70", Slot = "10")]
		public bool HNCAPECACBE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2FDFFB0", Offset = "0x2FDEDB0", VA = "0x182FDFFB0", Slot = "11")]
		public bool BGMMHNGFLPJ(IEnumerable<HMBPFBEHPFM> GILIMMAGMGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2FE08F0", Offset = "0x2FDF6F0", VA = "0x182FE08F0")]
		public bool DGDOFAKEFBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2FE1280", Offset = "0x2FE0080", VA = "0x182FE1280", Slot = "12")]
		public bool LLHAFDOBLDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2FDFD20", Offset = "0x2FDEB20", VA = "0x182FDFD20")]
		public void ADABIJIJAJJ(HPJPPBPFICL.CNKLKIACEHB.POHFFIGCOHA PHFANALOCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0390", Offset = "0x2FDF190", VA = "0x182FE0390")]
		private bool CENKJICJKFA(ByteString KFFNDELDPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2FE09D0", Offset = "0x2FDF7D0", VA = "0x182FE09D0")]
		private void DPFFGBEBPCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0890", Offset = "0x2FDF690", VA = "0x182FE0890")]
		private ByteString DEGKJMLBKCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0220", Offset = "0x2FDF020", VA = "0x182FE0220")]
		private ByteString BIPACGLPNFO(ByteString AAOFEOFDGLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0620", Offset = "0x2FDF420", VA = "0x182FE0620")]
		private HPJPPBPFICL.CNKLKIACEHB.POHFFIGCOHA CNPJKOLBDOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2FE1C50", Offset = "0x2FE0A50", VA = "0x182FE1C50")]
		private void PNBALPPJCDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2FE0DA0", Offset = "0x2FDFBA0", VA = "0x182FE0DA0", Slot = "13")]
		public bool HLIOCJAOGNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2FE1900", Offset = "0x2FE0700", VA = "0x182FE1900", Slot = "14")]
		public void NNMFJAAEPBA(bool HJLCONBGBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2FE19B0", Offset = "0x2FE07B0", VA = "0x182FE19B0")]
		private void ODCBHOABBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[GDFKOGKEDCG(typeof(LNDAGNKEEKN), new string[] { })]
[BOOKNJKHAPG(typeof(DOIIJCEPMEC))]
internal class DOIIJCEPMEC : LNDAGNKEEKN
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action MDOKDFDOBLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2ECCFF0", Offset = "0x2ECBDF0", VA = "0x182ECCFF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2ECCF50", Offset = "0x2ECBD50", VA = "0x182ECCF50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<BINGFNLPMDN> BKHJEIJPDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2ECCC30", Offset = "0x2ECBA30", VA = "0x182ECCC30", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2ECCD70", Offset = "0x2ECBB70", VA = "0x182ECCD70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action KEBPBAGGDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2ECCEB0", Offset = "0x2ECBCB0", VA = "0x182ECCEB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2ECCB90", Offset = "0x2ECB990", VA = "0x182ECCB90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action IFDPPDIJLJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2ECCAF0", Offset = "0x2ECB8F0", VA = "0x182ECCAF0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2ECCCD0", Offset = "0x2ECBAD0", VA = "0x182ECCCD0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BINGFNLPMDN> MMMFFFDNOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2ECCE10", Offset = "0x2ECBC10", VA = "0x182ECCE10", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2ECCA00", Offset = "0x2ECB800", VA = "0x182ECCA00", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x11E6F10", Offset = "0x11E5D10", VA = "0x1811E6F10")]
	public void CPAELHNGHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x12C16E0", Offset = "0x12C04E0", VA = "0x1812C16E0")]
	public void HALBCFLFNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x12C1850", Offset = "0x12C0650", VA = "0x1812C1850")]
	public void JNPHKGEPHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2ECCAA0", Offset = "0x2ECB8A0", VA = "0x182ECCAA0")]
	public void DENMCLBECKG(BINGFNLPMDN ODEHDAALPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC9B0", Offset = "0x2ECB7B0", VA = "0x182ECC9B0")]
	public void BLOIGPBFELB(BINGFNLPMDN ODEHDAALPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public DOIIJCEPMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[GDFKOGKEDCG(typeof(OOHEIMOEIOG), new string[] { })]
public class GDPOOKNJOCP : OOHEIMOEIOG, KHEIMMLCGKM, MDEPDIFNFKG, JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityHierarchyParents ODLKGBFEGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private FLFEDLBACFM FJJEAMJCBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ObjectEmbodimentService FNEHIFGGEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public global::FHOFMOODKOK<CGKCPDMKDFM> CKPAOFJPCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x748BB0", Offset = "0x7479B0", VA = "0x180748BB0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x748BD0", Offset = "0x7479D0", VA = "0x180748BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager CCEKCIJDDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x32A0400", Offset = "0x329F200", VA = "0x1832A0400")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x10055B0", Offset = "0x10043B0", VA = "0x1810055B0", Slot = "14")]
	public void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x329FBF0", Offset = "0x329E9F0", VA = "0x18329FBF0", Slot = "15")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x329FFD0", Offset = "0x329EDD0", VA = "0x18329FFD0", Slot = "16")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x10054E0", Offset = "0x10042E0", VA = "0x1810054E0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D22AF0", Offset = "0x2D218F0", VA = "0x182D22AF0")]
	private CGKCPDMKDFM GDBFKDDIFAF(Entity NEAKDKENHHP)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x32A0A60", Offset = "0x329F860", VA = "0x1832A0A60", Slot = "4")]
	public CGKCPDMKDFM NLBAAPEIHLL(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x32A0830", Offset = "0x329F630", VA = "0x1832A0830", Slot = "19")]
	public void LKPMFJHOJAL(ref List<CGKCPDMKDFM> ENPKPDCDBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x329F9F0", Offset = "0x329E7F0", VA = "0x18329F9F0", Slot = "20")]
	public IEnumerable<CGKCPDMKDFM> DOLFPEHJDDA(CGKCPDMKDFM HPLAKDFIDCJ, bool JCJOHJLDEGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x329FE00", Offset = "0x329EC00", VA = "0x18329FE00", Slot = "21")]
	public CGKCPDMKDFM FLHJGBCLEDO(CGKCPDMKDFM HPLAKDFIDCJ, int NNHNOIMLALG)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x32A0B50", Offset = "0x329F950", VA = "0x1832A0B50", Slot = "22")]
	public int OMOHDGMPNMJ(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x32A05E0", Offset = "0x329F3E0", VA = "0x1832A05E0", Slot = "8")]
	public int LHCEIHOIEFB(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x329F830", Offset = "0x329E630", VA = "0x18329F830", Slot = "9")]
	public DFFGCDANCCG DNFAFMDPEPE(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return default(DFFGCDANCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x32A0160", Offset = "0x329EF60", VA = "0x1832A0160", Slot = "23")]
	public bool GKNHDBJKNOM(CGKCPDMKDFM HPLAKDFIDCJ, out DFFGCDANCCG JIHJNMMJJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x32A0510", Offset = "0x329F310", VA = "0x1832A0510", Slot = "24")]
	public IEnumerable<CGKCPDMKDFM> IFCFIKDPHDL(CGKCPDMKDFM HPLAKDFIDCJ, bool JCJOHJLDEGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x329F920", Offset = "0x329E720", VA = "0x18329F920", Slot = "12")]
	public CGKCPDMKDFM DNIGCLHPCNL(CGKCPDMKDFM BFHFOJLNIBJ, CGKCPDMKDFM LCOPPMGLLED)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x32A0330", Offset = "0x329F130", VA = "0x1832A0330", Slot = "13")]
	public bool HHABHMMJHLE(CGKCPDMKDFM BFHFOJLNIBJ, CGKCPDMKDFM LCOPPMGLLED, out CGKCPDMKDFM AMDBLMMBPFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x32A00C0", Offset = "0x329EEC0", VA = "0x1832A00C0", Slot = "5")]
	public CGKCPDMKDFM GDGNMAEBLIK(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x32A0450", Offset = "0x329F250", VA = "0x1832A0450", Slot = "11")]
	public bool IEKAEDOCFHK(CGKCPDMKDFM HPLAKDFIDCJ, CGKCPDMKDFM DEKNDEIHCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x329FCC0", Offset = "0x329EAC0", VA = "0x18329FCC0", Slot = "25")]
	public bool FHDFBCILAKL(CGKCPDMKDFM HPLAKDFIDCJ, CGKCPDMKDFM LDCHDOICMMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x329F720", Offset = "0x329E520", VA = "0x18329F720", Slot = "10")]
	public bool CKLEPDHPDLB(CGKCPDMKDFM HPLAKDFIDCJ, CGKCPDMKDFM BFHFOJLNIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x32A0780", Offset = "0x329F580", VA = "0x1832A0780", Slot = "6")]
	public bool LHHNBAKNDJK(CGKCPDMKDFM HPLAKDFIDCJ, CGKCPDMKDFM GANAMHNGMGO, bool HGILIEKABBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x329F6B0", Offset = "0x329E4B0", VA = "0x18329F6B0", Slot = "7")]
	public bool CCCLAJJMOJG(CGKCPDMKDFM HPLAKDFIDCJ, CGKCPDMKDFM GANAMHNGMGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GDPOOKNJOCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
[GDFKOGKEDCG(typeof(EHGPJENGIMI), new string[] { })]
internal class EHGPJENGIMI : JPLAKHLHFLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[DNEBGGIIGBA]
	private HJJNHNANFFG PGPGHEAKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<int, CICKPKKFIHK> JBPHKHJKGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1B80", Offset = "0x2ED0980", VA = "0x182ED1B80", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1900", Offset = "0x2ED0700", VA = "0x182ED1900", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1800", Offset = "0x2ED0600", VA = "0x182ED1800")]
	public CICKPKKFIHK BOMDDMIJIMO(NMPGGHIBJDP HANNKCHKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2ED15E0", Offset = "0x2ED03E0", VA = "0x182ED15E0")]
	public CICKPKKFIHK BOMDDMIJIMO(DFNAMHCDDIN HEDGDEEAPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1BD0", Offset = "0x2ED09D0", VA = "0x182ED1BD0")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1D60", Offset = "0x2ED0B60", VA = "0x182ED1D60")]
	public EHGPJENGIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class CICKPKKFIHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<MIDBAIEMEBA> LENJAODKKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<OIFPFJGMJPN> JEHEJJDICHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<PHPDCDGCNKA> NCMOIIJGMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<OIFPFJGMJPN> ONDPPNKIJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<MIDBAIEMEBA> HEAONCFJPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xD5A960", Offset = "0xD59760", VA = "0x180D5A960")]
		get
		{
			return default(NativeList<MIDBAIEMEBA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<OIFPFJGMJPN> LABCAHEOCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xC94130", Offset = "0xC92F30", VA = "0x180C94130")]
		get
		{
			return default(NativeList<OIFPFJGMJPN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<PHPDCDGCNKA> KICHEOMHKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xEFFCD0", Offset = "0xEFEAD0", VA = "0x180EFFCD0")]
		get
		{
			return default(NativeList<PHPDCDGCNKA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<OIFPFJGMJPN> BHOMJHAAKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x11EE620", Offset = "0x11ED420", VA = "0x1811EE620")]
		get
		{
			return default(NativeList<OIFPFJGMJPN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle CFOFBHHDINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x10B3EA0", Offset = "0x10B2CA0", VA = "0x1810B3EA0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x10B23D0", Offset = "0x10B11D0", VA = "0x1810B23D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool EFIIIACBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x12C06C0", Offset = "0x12BF4C0", VA = "0x1812C06C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool GMKILCIPLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2EBBC10", Offset = "0x2EBAA10", VA = "0x182EBBC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC1B0", Offset = "0x2EBAFB0", VA = "0x182EBC1B0")]
	public CICKPKKFIHK(Allocator MBJMPHBLMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2EBBDF0", Offset = "0x2EBABF0", VA = "0x182EBBDF0")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2EBBCC0", Offset = "0x2EBAAC0", VA = "0x182EBBCC0")]
	public void NFGECJODELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2EBBE80", Offset = "0x2EBAC80", VA = "0x182EBBE80")]
	public void OEECIDDHIAM(Entity NEAKDKENHHP, Entity LGBLENLGMIP, Entity EBAJDMMJHBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[GDFKOGKEDCG(typeof(EAGDOHKBCNN), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
public class EAGDOHKBCNN : JPLAKHLHFLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[DNEBGGIIGBA]
	private SceneService BLHCMMNIILB;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2ECE720", Offset = "0x2ECD520", VA = "0x182ECE720", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2ECE700", Offset = "0x2ECD500", VA = "0x182ECE700", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public EAGDOHKBCNN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[GDFKOGKEDCG(typeof(PhotonInstanceCleanupService), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.Lifecycle)]
	[JAPKICPMJLM(DIMCOFJGPGL.PhotonRoom)]
	public class PhotonInstanceCleanupService : JPLAKHLHFLM, MDEPDIFNFKG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private CNJKAGGGIMN PGOCGNBJIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private NLIFEGBDOEH LPAHIKHANFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool LINNMJPFKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeList<int> MPLHBEGJLOO;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E9D0", Offset = "0x2D2D7D0", VA = "0x182D2E9D0", Slot = "5")]
		public void NIACEKGLEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E880", Offset = "0x2D2D680", VA = "0x182D2E880", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E8F0", Offset = "0x2D2D6F0", VA = "0x182D2E8F0")]
		public void FMFPGNCJLHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E790", Offset = "0x2D2D590", VA = "0x182D2E790", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E580", Offset = "0x2D2D380", VA = "0x182D2E580")]
		public void CEBHLIFGDCE(global::DIKACGHNDIB<int> AIFBFJMJMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E990", Offset = "0x2D2D790", VA = "0x182D2E990")]
		public void HPNAIAOPKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PhotonInstanceCleanupService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal abstract class AIJHBIHMOJL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint CCGBJGFHDAM;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public abstract uint PCACJFPNPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA1EF70", Offset = "0xA1DD70", VA = "0x180A1EF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4C20", Offset = "0x2EB3A20", VA = "0x182EB4C20")]
	public MFDODOEBKCJ EBOLDLCCNOA()
	{
		return default(MFDODOEBKCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4C70", Offset = "0x2EB3A70", VA = "0x182EB4C70")]
	public void OMCBLOIDLJG(MFDODOEBKCJ FIIEHBGLOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x12CA220", Offset = "0x12C9020", VA = "0x1812CA220", Slot = "6")]
	public virtual void JJEDLPKLPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	protected AIJHBIHMOJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
[GDFKOGKEDCG(typeof(IHOEJJJOAOC), new string[] { })]
internal sealed class IHOEJJJOAOC : AIJHBIHMOJL, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[DNEBGGIIGBA]
	private LCLOCHGKNKG BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint COGEDNMFBOF;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint PCACJFPNPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x740010", Offset = "0x73EE10", VA = "0x180740010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x32AAFA0", Offset = "0x32A9DA0", VA = "0x1832AAFA0", Slot = "7")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x32AAF50", Offset = "0x32A9D50", VA = "0x1832AAF50")]
	private void AKAOFCECPAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x32AB040", Offset = "0x32A9E40", VA = "0x1832AB040", Slot = "6")]
	public override void JJEDLPKLPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
	public IHOEJJJOAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[GDFKOGKEDCG(typeof(EPJKDONCCEC), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
internal sealed class EPJKDONCCEC : AIJHBIHMOJL
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint PCACJFPNPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public EPJKDONCCEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
[GDFKOGKEDCG(typeof(PPBAOAMBNHH), new string[] { })]
internal sealed class PPBAOAMBNHH : KHEIMMLCGKM, MDEPDIFNFKG, JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[DNEBGGIIGBA]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery CEGAJOEKPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery CBFCLKAIINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery BDGPEEOPFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery LBKBHBHLEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery AGJAMPOOHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery GKINFJEIMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private EntityManager CCEKCIJDDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D920", Offset = "0x2D2C720", VA = "0x182D2D920")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery MFPCPFNADIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7621D0", Offset = "0x760FD0", VA = "0x1807621D0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery HLPPLKJECMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7621C0", Offset = "0x760FC0", VA = "0x1807621C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery GECFPHOPDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x117C490", Offset = "0x117B290", VA = "0x18117C490")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery HEKPEIHDIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x10B3EA0", Offset = "0x10B2CA0", VA = "0x1810B3EA0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery NGHLFGEAFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x10B31D0", Offset = "0x10B1FD0", VA = "0x1810B31D0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery DCCDGKLPFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D2A0", Offset = "0x2D2C0A0", VA = "0x182D2D2A0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int EGKAMJNHJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DA80", Offset = "0x2D2C880", VA = "0x182D2DA80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int LKLJHPADNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D990", Offset = "0x2D2C790", VA = "0x182D2D990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int LNDDLAHAPND
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DB20", Offset = "0x2D2C920", VA = "0x182D2DB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int IMKMEJODEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DA60", Offset = "0x2D2C860", VA = "0x182D2DA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int GOLKBPPNOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2D2D970", Offset = "0x2D2C770", VA = "0x182D2D970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int GFHHNNMDAMA
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2D2DAA0", Offset = "0x2D2C8A0", VA = "0x182D2DAA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "4")]
	public void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D250", Offset = "0x2D2C050", VA = "0x182D2D250", Slot = "5")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D480", Offset = "0x2D2C280", VA = "0x182D2D480", Slot = "6")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2D2DAC0", Offset = "0x2D2C8C0", VA = "0x182D2DAC0")]
	private EntityQueryDesc NEANIKNAEAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D1F0", Offset = "0x2D2BFF0", VA = "0x182D2D1F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D320", Offset = "0x2D2C120", VA = "0x182D2D320")]
	public AIMELIENNAP FBGCEPHMJGB(CGKCPDMKDFM BMINGOEPCBN)
	{
		return default(AIMELIENNAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D3D0", Offset = "0x2D2C1D0", VA = "0x182D2D3D0")]
	public AIMELIENNAP FBGCEPHMJGB(Entity NEAKDKENHHP)
	{
		return default(AIMELIENNAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D9B0", Offset = "0x2D2C7B0", VA = "0x182D2D9B0")]
	public IAFDFFOCDLF LMJPABMDDMP(Entity NEAKDKENHHP)
	{
		return default(IAFDFFOCDLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2D2DB40", Offset = "0x2D2C940", VA = "0x182D2DB40")]
	public PPBAOAMBNHH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[DKGMECGHCPI(OJBFOICGDOF.All)]
	[GDFKOGKEDCG(typeof(JCAPLMJKCDN), new string[] { })]
	public class ObjectService : JPLAKHLHFLM, JCAPLMJKCDN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly FGEMECIGOCC KFFLAIJHEBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[DNEBGGIIGBA]
		private AFJJBHJMGFE POEIPOGPNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[DNEBGGIIGBA]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[DNEBGGIIGBA]
		private ObjectLifecycleService LHNDLBANJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[DNEBGGIIGBA]
		private ObjectEmbodimentService FNEHIFGGEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[DNEBGGIIGBA]
		private ObjectInstantiationService FHLJIJCKGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[DNEBGGIIGBA]
		private PPBAOAMBNHH FJJEAMJCBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ObjectNetworkToLocalMapService JJPJMEBEPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool LINNMJPFKHN;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public AFJJBHJMGFE HOOKCAMEDII
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int EGKAMJNHJIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2D2B0E0", Offset = "0x2D29EE0", VA = "0x182D2B0E0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int LKLJHPADNNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2D2AD20", Offset = "0x2D29B20", VA = "0x182D2AD20", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int LNDDLAHAPND
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2D2B1E0", Offset = "0x2D29FE0", VA = "0x182D2B1E0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int IMKMEJODEBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2D2B040", Offset = "0x2D29E40", VA = "0x182D2B040", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int GOLKBPPNOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2D2AAD0", Offset = "0x2D298D0", VA = "0x182D2AAD0", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int GFHHNNMDAMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2D2B110", Offset = "0x2D29F10", VA = "0x182D2B110", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<CGKCPDMKDFM, IAFDFFOCDLF> BBGFPCOELEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2D2A170", Offset = "0x2D28F70", VA = "0x182D2A170", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2D2B2F0", Offset = "0x2D2A0F0", VA = "0x182D2B2F0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<CGKCPDMKDFM> KMOIDOINCLM
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2D294D0", Offset = "0x2D282D0", VA = "0x182D294D0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2D2B390", Offset = "0x2D2A190", VA = "0x182D2B390", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2D29D80", Offset = "0x2D28B80", VA = "0x182D29D80", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2D29C00", Offset = "0x2D28A00", VA = "0x182D29C00", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AB00", Offset = "0x2D29900", VA = "0x182D2AB00")]
		private void LBICJKDGLKO(Entity NEAKDKENHHP, IAFDFFOCDLF KCFAHJGLHLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A2F0", Offset = "0x2D290F0", VA = "0x182D2A2F0")]
		private void FDLPJOODEEG(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A380", Offset = "0x2D29180", VA = "0x182D2A380")]
		internal CGKCPDMKDFM GDBFKDDIFAF(Entity NEAKDKENHHP)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B140", Offset = "0x2D29F40", VA = "0x182D2B140", Slot = "41")]
		public DFFGCDANCCG NDOGKCABLOI()
		{
			return default(DFFGCDANCCG);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A7A0", Offset = "0x2D295A0", VA = "0x182D2A7A0", Slot = "42")]
		public DFFGCDANCCG IOPOPBPDKDC()
		{
			return default(DFFGCDANCCG);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A680", Offset = "0x2D29480", VA = "0x182D2A680", Slot = "43")]
		public DFFGCDANCCG HGDOOENCPGM()
		{
			return default(DFFGCDANCCG);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A0B0", Offset = "0x2D28EB0", VA = "0x182D2A0B0", Slot = "10")]
		public AIMELIENNAP FBGCEPHMJGB(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(AIMELIENNAP);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AF70", Offset = "0x2D29D70", VA = "0x182D2AF70", Slot = "11")]
		public IAFDFFOCDLF LMJPABMDDMP(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(IAFDFFOCDLF);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2D29AB0", Offset = "0x2D288B0", VA = "0x182D29AB0")]
		private DFFGCDANCCG DNIBNDIODEH(EntityQuery NOJJNNFMBAH)
		{
			return default(DFFGCDANCCG);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AC90", Offset = "0x2D29A90", VA = "0x182D2AC90", Slot = "33")]
		public bool LCHDIFCJOJC(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AD50", Offset = "0x2D29B50", VA = "0x182D2AD50", Slot = "29")]
		public void LGPDJPMAIOD(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A620", Offset = "0x2D29420", VA = "0x182D2A620", Slot = "30")]
		public void HFIKMPOCHJC(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2D293B0", Offset = "0x2D281B0", VA = "0x182D293B0", Slot = "31")]
		public void BLDGMOBIAFP(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2D2ADA0", Offset = "0x2D29BA0", VA = "0x182D2ADA0", Slot = "22")]
		public EGBCNCKGEND LIGKIHLEECP(IAFDFFOCDLF KCFAHJGLHLA, bool CKJCCLALEPN)
		{
			return default(EGBCNCKGEND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AE60", Offset = "0x2D29C60", VA = "0x182D2AE60", Slot = "23")]
		public EGBCNCKGEND LIGKIHLEECP(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(EGBCNCKGEND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A590", Offset = "0x2D29390", VA = "0x182D2A590", Slot = "24")]
		public EGBCNCKGEND HCEEHEJIEII(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(EGBCNCKGEND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2D29570", Offset = "0x2D28370", VA = "0x182D29570", Slot = "25")]
		public EGBCNCKGEND CPHCLKAHMMB(MFDODOEBKCJ FIIEHBGLOHB, IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(EGBCNCKGEND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B070", Offset = "0x2D29E70", VA = "0x182D2B070", Slot = "44")]
		public EGBCNCKGEND MBFLIIKNBFJ(int FPELAEDPLCO, IAFDFFOCDLF KCFAHJGLHLA, GameObject HNLFAAIOFFP)
		{
			return default(EGBCNCKGEND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2D29FF0", Offset = "0x2D28DF0", VA = "0x182D29FF0", Slot = "26")]
		public KDLCLFDEGLN EJKDBBANIDE()
		{
			return default(KDLCLFDEGLN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2D29990", Offset = "0x2D28790", VA = "0x182D29990", Slot = "45")]
		public DJPMNEBBEKE DLIABOGEIKL(LBMBGCOHJHK LEDIIMFEFLP)
		{
			return default(DJPMNEBBEKE);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A210", Offset = "0x2D29010", VA = "0x182D2A210", Slot = "27")]
		public GCMMIONNLDE FDCBEKHEEPO()
		{
			return default(GCMMIONNLDE);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2D29850", Offset = "0x2D28650", VA = "0x182D29850", Slot = "28")]
		public HNLNHLOBMEA DHPLHAEKNON(ENALNDEOHNF LEDIIMFEFLP)
		{
			return default(HNLNHLOBMEA);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A520", Offset = "0x2D29320", VA = "0x182D2A520", Slot = "12")]
		public void GLJEDJEGGBC(MFDODOEBKCJ FIIEHBGLOHB, BOGOKBNBEFE HBKFLBDCJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A3A0", Offset = "0x2D291A0", VA = "0x182D2A3A0", Slot = "13")]
		public EGBCNCKGEND GGJLDHOIIEB(CGKCPDMKDFM HPLAKDFIDCJ, [Optional] object AMBDKIOJFBL)
		{
			return default(EGBCNCKGEND);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B2A0", Offset = "0x2D2A0A0", VA = "0x182D2B2A0", Slot = "14")]
		public bool OIBIDLDJMDF(CGKCPDMKDFM HPLAKDFIDCJ, out BOGOKBNBEFE AJCHMFJLMGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A540", Offset = "0x2D29340", VA = "0x182D2A540", Slot = "46")]
		public Transform GNCJOLNGNHB(CGKCPDMKDFM HPLAKDFIDCJ, [Optional] object AMBDKIOJFBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B250", Offset = "0x2D2A050", VA = "0x182D2B250", Slot = "16")]
		public bool OGOEGJMKFMI(CGKCPDMKDFM HPLAKDFIDCJ, out Transform KGHIPKNMKHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2D29320", Offset = "0x2D28120", VA = "0x182D29320", Slot = "17")]
		public bool BIJLKKKABDK(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AF10", Offset = "0x2D29D10", VA = "0x182D2AF10")]
		public bool LKFDHEMLLKP(BOGOKBNBEFE MGFMONLLLPD, [Optional] object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2D2AF40", Offset = "0x2D29D40", VA = "0x182D2AF40", Slot = "47")]
		public bool LKFDHEMLLKP(CGKCPDMKDFM HPLAKDFIDCJ, [Optional] object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2D297C0", Offset = "0x2D285C0", VA = "0x182D297C0", Slot = "48")]
		public void DCIACLMEMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A920", Offset = "0x2D29720", VA = "0x182D2A920", Slot = "15")]
		public void JMKCOIGPEKC(BOGOKBNBEFE OJGAEOFIMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B210", Offset = "0x2D2A010", VA = "0x182D2B210", Slot = "49")]
		public void OEIMAKFNOOC(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A720", Offset = "0x2D29520", VA = "0x182D2A720", Slot = "18")]
		public bool HNDJOPKPFJK(Entity NEAKDKENHHP, object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2D29450", Offset = "0x2D28250", VA = "0x182D29450", Slot = "19")]
		public bool CHCADJAODHG(Entity NEAKDKENHHP, object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A8B0", Offset = "0x2D296B0", VA = "0x182D2A8B0", Slot = "50")]
		public bool JHAANOMAEAO(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2D297E0", Offset = "0x2D285E0", VA = "0x182D297E0", Slot = "51")]
		public bool DDKACAAGONK(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A4C0", Offset = "0x2D292C0", VA = "0x182D2A4C0", Slot = "32")]
		public NativeArray<(CGKCPDMKDFM, CGKCPDMKDFM)> GLCFKEABDII(NativeArray<CGKCPDMKDFM> OBDCOIDPANM, Allocator MBJMPHBLMBF)
		{
			return default(NativeArray<(CGKCPDMKDFM, CGKCPDMKDFM)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2D29B60", Offset = "0x2D28960", VA = "0x182D29B60", Slot = "21")]
		public MFDODOEBKCJ DOPAKLHPIEI(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(MFDODOEBKCJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2D2ABA0", Offset = "0x2D299A0", VA = "0x182D2ABA0", Slot = "20")]
		public CGKCPDMKDFM LCEDMMGGMOH(MFDODOEBKCJ FIIEHBGLOHB)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2D2B430", Offset = "0x2D2A230", VA = "0x182D2B430")]
		private void PCNJKKOHNND(IAFDFFOCDLF KCFAHJGLHLA, CGKCPDMKDFM HPLAKDFIDCJ, MFDODOEBKCJ FIIEHBGLOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
[GDFKOGKEDCG(typeof(FNIFMGLPHAO), new string[] { })]
internal sealed class FNIFMGLPHAO : JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private ObjectInstantiationService FHLJIJCKGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[DNEBGGIIGBA]
	private PPBAOAMBNHH FJJEAMJCBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[DNEBGGIIGBA]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x329E5D0", Offset = "0x329D3D0", VA = "0x18329E5D0", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x329E940", Offset = "0x329D740", VA = "0x18329E940")]
	public NativeArray<(CGKCPDMKDFM, CGKCPDMKDFM)> GLCFKEABDII(NativeArray<CGKCPDMKDFM> OBDCOIDPANM, Allocator MBJMPHBLMBF)
	{
		return default(NativeArray<(CGKCPDMKDFM, CGKCPDMKDFM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x329E3F0", Offset = "0x329D1F0", VA = "0x18329E3F0")]
	private void BLAOGNKIPKJ(NativeMultiHashMap<int, (CGKCPDMKDFM src, CGKCPDMKDFM dst)> NCBGEINHHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x329EA40", Offset = "0x329D840", VA = "0x18329EA40")]
	private void IENOHLOLIHP(NativeMultiHashMap<int, (CGKCPDMKDFM src, CGKCPDMKDFM dst)> NCBGEINHHHM, int KCFAHJGLHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x329EED0", Offset = "0x329DCD0", VA = "0x18329EED0")]
	private void MFKHPAAHJAH(NativeMultiHashMap<int, (CGKCPDMKDFM src, CGKCPDMKDFM dst)> NCBGEINHHHM, int KCFAHJGLHLA, LPGGBJGEPLD PGPGHEAKODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x329E660", Offset = "0x329D460", VA = "0x18329E660")]
	private NativeMultiHashMap<int, (CGKCPDMKDFM, CGKCPDMKDFM)> FDFDKMMICGB(Allocator MBJMPHBLMBF, NativeArray<CGKCPDMKDFM> OBDCOIDPANM, out NativeArray<(CGKCPDMKDFM src, CGKCPDMKDFM dst)> CBKLKOLDOLK)
	{
		return default(NativeMultiHashMap<int, (CGKCPDMKDFM, CGKCPDMKDFM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public FNIFMGLPHAO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[DKGMECGHCPI(OJBFOICGDOF.TransformSyncing)]
	[BOOKNJKHAPG(typeof(TransformService))]
	[GDFKOGKEDCG(typeof(EOKNELNBMBB), new string[] { })]
	public class TransformService : EOKNELNBMBB, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly FGEMECIGOCC FPIKCGFJKEO;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly FGEMECIGOCC DNKBEIHEJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private HDPLFGHLJGK GOCPDFPAIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private AEJNGPFNACL BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private OOHEIMOEIOG IALAEABLGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TransformOwnershipPhase PICAKHHKOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ObjectEmbodimentService DPEPLNEHLIL;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private EntityManager CCEKCIJDDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x2FEA310", Offset = "0x2FE9110", VA = "0x182FEA310")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private DMGDMAGLCAD EDDGIILAJBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x2FE87F0", Offset = "0x2FE75F0", VA = "0x182FE87F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2FE88B0", Offset = "0x2FE76B0", VA = "0x182FE88B0", Slot = "33")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB510", Offset = "0x2FEA310", VA = "0x182FEB510", Slot = "34")]
		public bool MMOGCAFPOPC(Transform KGHIPKNMKHP, out CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA160", Offset = "0x2FE8F60", VA = "0x182FEA160", Slot = "35")]
		public Transform HJHMDDGMDEN(Entity NEAKDKENHHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2FEBCC0", Offset = "0x2FEAAC0", VA = "0x182FEBCC0", Slot = "30")]
		public bool OGOEGJMKFMI(Entity NEAKDKENHHP, out Transform KGHIPKNMKHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8420", Offset = "0x2FE7220", VA = "0x182FE8420")]
		private void DLJCELOPBKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7EC0", Offset = "0x2FE6CC0", VA = "0x182FE7EC0", Slot = "29")]
		public void AILAMMALOIJ(Entity NEAKDKENHHP, out Matrix4x4 EMIFMEDAAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA450", Offset = "0x2FE9250", VA = "0x182FEA450", Slot = "4")]
		public void JPMLKAINGKD(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2FEAF60", Offset = "0x2FE9D60", VA = "0x182FEAF60")]
		public void KPDJMNICDKK(Entity NEAKDKENHHP, Vector3 LNLPNIDIPMD, Quaternion BBEANHLOOHL, Vector3 PHCOJKGGKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC5F0", Offset = "0x2FEB3F0", VA = "0x182FEC5F0")]
		public void PODJOLOPHFJ(Entity NEAKDKENHHP, Vector3 LNLPNIDIPMD, Quaternion BBEANHLOOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8140", Offset = "0x2FE6F40", VA = "0x182FE8140", Slot = "27")]
		public void DANHEKOOHPA(Entity NEAKDKENHHP, out Matrix4x4 JOGJBGAPMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC000", Offset = "0x2FEAE00", VA = "0x182FEC000")]
		public void ONNECIPBIDP(Entity NEAKDKENHHP, in Matrix4x4 EMIFMEDAAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8010", Offset = "0x2FE6E10", VA = "0x182FE8010")]
		public void BGLKPPBNEFM(Entity NEAKDKENHHP, in Matrix4x4 EMIFMEDAAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8520", Offset = "0x2FE7320", VA = "0x182FE8520")]
		public void DONNDFIFMBG(Entity NEAKDKENHHP, in Matrix4x4 BPHGFBFCGBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2FE95A0", Offset = "0x2FE83A0", VA = "0x182FE95A0", Slot = "5")]
		public void GAKLJELINPB(Entity NEAKDKENHHP, Vector3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2FE96C0", Offset = "0x2FE84C0", VA = "0x182FE96C0", Slot = "6")]
		public Vector3 GDACJGGPNDD(Entity NEAKDKENHHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB6D0", Offset = "0x2FEA4D0", VA = "0x182FEB6D0", Slot = "7")]
		public void NBFLOLLBDBH(Entity NEAKDKENHHP, Quaternion MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA220", Offset = "0x2FE9020", VA = "0x182FEA220", Slot = "8")]
		public Quaternion HLOGFCFIGMF(Entity NEAKDKENHHP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8150", Offset = "0x2FE6F50", VA = "0x182FE8150", Slot = "12")]
		public void DKBGNKEEKOA(Entity NEAKDKENHHP, Vector3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA9E0", Offset = "0x2FE97E0", VA = "0x182FEA9E0", Slot = "11")]
		public Vector3 KGGDGNDMNLP(Entity NEAKDKENHHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB7D0", Offset = "0x2FEA5D0", VA = "0x182FEB7D0")]
		public void NDJLCPINFJM(Entity NEAKDKENHHP, Vector3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2FEBF60", Offset = "0x2FEAD60", VA = "0x182FEBF60")]
		private Vector3 OLGIHIHDMEF(Entity NEAKDKENHHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2FE9500", Offset = "0x2FE8300", VA = "0x182FE9500", Slot = "14")]
		public float FNGJIEMHJDM(Entity NEAKDKENHHP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2FE86E0", Offset = "0x2FE74E0", VA = "0x182FE86E0", Slot = "13")]
		public void DPCDHNKEFFL(Entity NEAKDKENHHP, float MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA360", Offset = "0x2FE9160", VA = "0x182FEA360")]
		private float HPKHLGNEFDB(Entity NEAKDKENHHP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2FEAED0", Offset = "0x2FE9CD0", VA = "0x182FEAED0")]
		public void KNMCGHIMPJD(Entity NEAKDKENHHP, float ADPDNKBPJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2FE97D0", Offset = "0x2FE85D0", VA = "0x182FE97D0", Slot = "16")]
		public Vector3 GEIHGBOEHJB(Entity NEAKDKENHHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2FE9D10", Offset = "0x2FE8B10", VA = "0x182FE9D10", Slot = "15")]
		public void GMNEHPBONND(Entity NEAKDKENHHP, Vector3 JBBFKLLNFJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB3E0", Offset = "0x2FEA1E0", VA = "0x182FEB3E0")]
		private Vector3 MJEEFGDPNOC(Entity NEAKDKENHHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8AE0", Offset = "0x2FE78E0", VA = "0x182FE8AE0")]
		public void EIMGDOPPJDJ(Entity NEAKDKENHHP, Vector3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2FEBDB0", Offset = "0x2FEABB0", VA = "0x182FEBDB0")]
		[Conditional("DEBUG_BUILD")]
		private void OHCKBEGMNGE(Entity NEAKDKENHHP, Vector3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2FEBB60", Offset = "0x2FEA960", VA = "0x182FEBB60", Slot = "36")]
		public void NPMEMGDFGPB(Entity NEAKDKENHHP, Vector3 DNPAJCANFPF, Quaternion NNAIELBMKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8250", Offset = "0x2FE7050", VA = "0x182FE8250", Slot = "9")]
		public void DKGEAOFPJLD(Entity NEAKDKENHHP, out Vector3 DNPAJCANFPF, out Quaternion NNAIELBMKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8BB0", Offset = "0x2FE79B0", VA = "0x182FE8BB0", Slot = "10")]
		public void ENNEPKJDJIH(Entity NEAKDKENHHP, out Vector3 DNPAJCANFPF, out Quaternion NNAIELBMKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2FEAAF0", Offset = "0x2FE98F0", VA = "0x182FEAAF0", Slot = "37")]
		public void KIONFBNJFDE(Entity NEAKDKENHHP, Vector3 DNPAJCANFPF, Quaternion NNAIELBMKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2FEAD10", Offset = "0x2FE9B10", VA = "0x182FEAD10")]
		public void KMCJLBEIEIA(Entity NEAKDKENHHP, Vector3 DNPAJCANFPF, Quaternion NNAIELBMKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC3C0", Offset = "0x2FEB1C0", VA = "0x182FEC3C0", Slot = "17")]
		public void PECBHGLOBJK(Entity NEAKDKENHHP, Vector3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2FE9F30", Offset = "0x2FE8D30", VA = "0x182FE9F30", Slot = "18")]
		public Vector3 HEEGDPKGLAP(Entity NEAKDKENHHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8CE0", Offset = "0x2FE7AE0", VA = "0x182FE8CE0", Slot = "19")]
		public void EOEMAJAFPJD(Entity NEAKDKENHHP, Quaternion MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2FE9E40", Offset = "0x2FE8C40", VA = "0x182FE9E40", Slot = "20")]
		public Quaternion GPPOFNLNBEL(Entity NEAKDKENHHP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2FE98B0", Offset = "0x2FE86B0", VA = "0x182FE98B0", Slot = "22")]
		public void GGODEBPNHBP(Entity NEAKDKENHHP, Vector3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8F20", Offset = "0x2FE7D20", VA = "0x182FE8F20", Slot = "21")]
		public Vector3 FADKMCJDHBO(Entity NEAKDKENHHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB270", Offset = "0x2FEA070", VA = "0x182FEB270", Slot = "23")]
		public void LHKLKEOLKHJ(Entity NEAKDKENHHP, float MMJDGJFHKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2FE89C0", Offset = "0x2FE77C0", VA = "0x182FE89C0", Slot = "24")]
		public float EBKPGMAFDJD(Entity NEAKDKENHHP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2FE9010", Offset = "0x2FE7E10", VA = "0x182FE9010", Slot = "25")]
		public void FEACLHNJLBB(Entity NEAKDKENHHP, Vector3 DDPLNKFDLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2FEBA20", Offset = "0x2FEA820", VA = "0x182FEBA20", Slot = "26")]
		public Vector3 NJJHJCNAPEK(Entity NEAKDKENHHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7700", Offset = "0x2FE6500", VA = "0x182FE7700", Slot = "31")]
		public void AFAEJKNJDNA(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA010", Offset = "0x2FE8E10", VA = "0x182FEA010")]
		private CGKCPDMKDFM HGOPLLLOHCL(Transform KGHIPKNMKHP)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB040", Offset = "0x2FE9E40", VA = "0x182FEB040")]
		private static TransformEntity LDIKFEFMOOJ(IAFDFFOCDLF LEDIIMFEFLP, GameObject KOFDCLCOPIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7DA0", Offset = "0x2FE6BA0", VA = "0x182FE7DA0", Slot = "32")]
		public void AHHPENFOGEF(Entity NEAKDKENHHP, Entity LGBLENLGMIP, Entity EBAJDMMJHBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2FE83A0", Offset = "0x2FE71A0", VA = "0x182FE83A0")]
		private BHDGOBBHANE DKGEAOFPJLD(Entity NEAKDKENHHP)
		{
			return default(BHDGOBBHANE);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2FE8440", Offset = "0x2FE7240", VA = "0x182FE8440")]
		private bool DMNCKINECGL(Entity NEAKDKENHHP, out Entity GANAMHNGMGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB870", Offset = "0x2FEA670", VA = "0x182FEB870")]
		private void NGMPPFGDKDF(Entity NEAKDKENHHP, out Matrix4x4 EMIFMEDAAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA640", Offset = "0x2FE9440", VA = "0x182FEA640")]
		private void KFAMEFIFAGN(Entity NEAKDKENHHP, out Matrix4x4 BPHGFBFCGBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2FEB030", Offset = "0x2FE9E30", VA = "0x182FEB030", Slot = "28")]
		private void LCKOPBNONNJ(Entity NEAKDKENHHP, in Matrix4x4 JOGJBGAPMFF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
[GDFKOGKEDCG(typeof(DLKGFCGLMDE), new string[] { })]
internal sealed class DLKGFCGLMDE : JPLAKHLHFLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[DNEBGGIIGBA]
	private LCLOCHGKNKG BGEMPOFCNMN;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBA80", Offset = "0x2ECA880", VA = "0x182ECBA80", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBA10", Offset = "0x2ECA810", VA = "0x182ECBA10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public DLKGFCGLMDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
[GDFKOGKEDCG(typeof(DFDPLCEHANK), new string[] { })]
public class DFDPLCEHANK
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct FIMLAIFJNJO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly DFDPLCEHANK GANAMHNGMGO;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x2FD94C0", Offset = "0x2FD82C0", VA = "0x182FD94C0")]
		public FIMLAIFJNJO(DFDPLCEHANK GANAMHNGMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x2FD94A0", Offset = "0x2FD82A0", VA = "0x182FD94A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int CHGCAJALALN;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool JFLDLIHNKHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x12B1710", Offset = "0x12B0510", VA = "0x1812B1710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action MEDGPJEKHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA8A0", Offset = "0x2EC96A0", VA = "0x182ECA8A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2ECA940", Offset = "0x2EC9740", VA = "0x182ECA940")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2ECAA00", Offset = "0x2EC9800", VA = "0x182ECAA00")]
	public FIMLAIFJNJO PJJKOMODBIF()
	{
		return default(FIMLAIFJNJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1772E20", Offset = "0x1771C20", VA = "0x181772E20")]
	public void BGEHPFFJCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2ECA9E0", Offset = "0x2EC97E0", VA = "0x182ECA9E0")]
	public void PADCKMIMCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public DFDPLCEHANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[GDFKOGKEDCG(typeof(HMBGMNAKOHP), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
public class HMBGMNAKOHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int CHGCAJALALN;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool GJLNPONCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xE3F720", Offset = "0xE3E520", VA = "0x180E3F720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA2BB50", Offset = "0xA2A950", VA = "0x180A2BB50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public HMBGMNAKOHP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[GDFKOGKEDCG(typeof(EnableComponentSystemsInScope), new string[] { })]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[DKGMECGHCPI(OJBFOICGDOF.ComponentSystemTypes)]
	public class EnableComponentSystemsInScope : JPLAKHLHFLM, BDCEBKAEALJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct CPJIPDBENFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private NativeArray<int> LKEEOFIAHCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private NativeArray<int> MBDEKLPMDOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private Dictionary<ComponentSystemBase, int> EHJHHGKJCJG;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9270", Offset = "0x2FD8070", VA = "0x182FD9270")]
			public CPJIPDBENFP(NativeArray<int> LKEEOFIAHCE, NativeArray<int> MBDEKLPMDOP, Dictionary<ComponentSystemBase, int> EHJHHGKJCJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x2FD8FF0", Offset = "0x2FD7DF0", VA = "0x182FD8FF0")]
			public void LPOBDHLDDBO(IEnumerable<ComponentSystemBase> POEIPOGPNCF, DIMCOFJGPGL BNEGMHGONKJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class HMLKMIMBKFK : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private ComponentSystemBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public EnableComponentSystemsInScope <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private int start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public int <>3__start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private int end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>3__end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
			[DebuggerHidden]
			public HMLKMIMBKFK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9C10", Offset = "0x2FD8A10", VA = "0x182FD9C10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9DE0", Offset = "0x2FD8BE0", VA = "0x182FD9DE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9D30", Offset = "0x2FD8B30", VA = "0x182FD9D30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9D30", Offset = "0x2FD8B30", VA = "0x182FD9D30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const DIMCOFJGPGL DIPKAHCACFE = DIMCOFJGPGL.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly FGEMECIGOCC OFBAHILIEJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL EOHGMNFKFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private World BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private LKAAGIKDPMH MENEIDJFFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeArray<int> FCBJFJEKCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NativeArray<int> ABKGMLJJHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int HHCMOLFBCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private DIMCOFJGPGL ADOGLBIMILC;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2ED45F0", Offset = "0x2ED33F0", VA = "0x182ED45F0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4560", Offset = "0x2ED3360", VA = "0x182ED4560", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2ED5120", Offset = "0x2ED3F20", VA = "0x182ED5120")]
		[IteratorStateMachine(typeof(HMLKMIMBKFK))]
		private IEnumerable<ComponentSystemBase> OBLFJPFNDGC(int CKCLNMMLENB, int KHILBFLOBFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4B80", Offset = "0x2ED3980", VA = "0x182ED4B80", Slot = "5")]
		public void MDJPCEPGALH(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4220", Offset = "0x2ED3020", VA = "0x182ED4220")]
		private void BBLFGGCJLCL(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4120", Offset = "0x2ED2F20", VA = "0x182ED4120")]
		public void BBLFGGCJLCL(DIMCOFJGPGL NJHBELAPFGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4860", Offset = "0x2ED3660", VA = "0x182ED4860")]
		private void LMKJMAPEAAP(DIMCOFJGPGL NJHBELAPFGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4AF0", Offset = "0x2ED38F0", VA = "0x182ED4AF0")]
		private void MALBNKDBFGD(DIMCOFJGPGL NJHBELAPFGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4760", Offset = "0x2ED3560", VA = "0x182ED4760")]
		private void JJLCNNGKDCC(DIMCOFJGPGL NJHBELAPFGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4370", Offset = "0x2ED3170", VA = "0x182ED4370")]
		private void BKIDLAPEFAG(int CKCLNMMLENB, int KHILBFLOBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2ED51B0", Offset = "0x2ED3FB0", VA = "0x182ED51B0")]
		private void OMLFHIGGKLA(int CKCLNMMLENB, int KHILBFLOBFB, bool LJCKIACCBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4540", Offset = "0x2ED3340", VA = "0x182ED4540")]
		private int CFDEANHKGBC(DIMCOFJGPGL NJHBELAPFGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4B90", Offset = "0x2ED3990", VA = "0x182ED4B90")]
		private bool MOPDLCNBJGE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4670", Offset = "0x2ED3470", VA = "0x182ED4670")]
		private Dictionary<ComponentSystemBase, int> EPONAAIPHFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2ED47C0", Offset = "0x2ED35C0", VA = "0x182ED47C0")]
		private void KFFACMBHHMI(NativeArray<int> LKEEOFIAHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4490", Offset = "0x2ED3290", VA = "0x182ED4490")]
		private void BPMFDALGECM(NativeArray<int> MBDEKLPMDOP, NativeArray<int> LKEEOFIAHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4800", Offset = "0x2ED3600", VA = "0x182ED4800")]
		private static DIMCOFJGPGL KMBLJEEEOLJ(Type LEDIIMFEFLP, DIMCOFJGPGL HPJBCMEILDI)
		{
			return default(DIMCOFJGPGL);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2ED5360", Offset = "0x2ED4160", VA = "0x182ED5360")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4430", Offset = "0x2ED3230", VA = "0x182ED4430")]
		[CompilerGenerated]
		private void BMELAJGJHKL(JPLAKHLHFLM BICFBDPFFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2ED5270", Offset = "0x2ED4070", VA = "0x182ED5270")]
		[CompilerGenerated]
		private void ONCKEAJALMK(NEGCPFIDGDD BICFBDPFFBN)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[DKGMECGHCPI(OJBFOICGDOF.WorldService)]
	[GDFKOGKEDCG(typeof(LPJCNLHLDJN), new string[] { })]
	public class TickService : JPLAKHLHFLM, LPJCNLHLDJN
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly ProfilerMarker JAPALKNLDEK;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ProfilerMarker LEBCFGBLJNH;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly ProfilerMarker EFKNBNFFIAL;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly ProfilerMarker KLNFHLJCMAD;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly ProfilerMarker OGEPIJPHFEN;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly ProfilerMarker JMCGEONBEJM;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly ProfilerMarker LOKBOLCICAG;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly ProfilerMarker HHFACJPKAGE;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly ProfilerMarker EJOKPIAOPGG;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly ProfilerMarker JKENJKCOAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL EOHGMNFKFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[DNEBGGIIGBA]
		private CJEAPPIFFGL NOAFOBDAJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[DNEBGGIIGBA]
		private ENCGEBBECLL ONNODGAIHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[DNEBGGIIGBA]
		private TransformOwnershipPhase MCAIMDMBACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[DNEBGGIIGBA]
		private TimeService KJGEPMINMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private MKGAEINCAIG BFCIPJDFKAG;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool NELBNFFOBMN
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x2FE67C0", Offset = "0x2FE55C0", VA = "0x182FE67C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool CNGKAINBHBB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2FE6720", Offset = "0x2FE5520", VA = "0x182FE6720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool AFECIPCPEDI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2FE67C0", Offset = "0x2FE55C0", VA = "0x182FE67C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool BNDHIGNLGOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x2FE67C0", Offset = "0x2FE55C0", VA = "0x182FE67C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2FE5FA0", Offset = "0x2FE4DA0", VA = "0x182FE5FA0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2FE6110", Offset = "0x2FE4F10", VA = "0x182FE6110", Slot = "14")]
		public void EGNFKKENOKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2FE6230", Offset = "0x2FE5030", VA = "0x182FE6230", Slot = "15")]
		public void EKPHEIMLBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2FE5D80", Offset = "0x2FE4B80", VA = "0x182FE5D80", Slot = "5")]
		public void CCCACJFFKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2FE69B0", Offset = "0x2FE57B0", VA = "0x182FE69B0", Slot = "6")]
		public void PEDFPCNFMOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2FE6830", Offset = "0x2FE5630", VA = "0x182FE6830", Slot = "7")]
		public void NKJOIGFBOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2FE6420", Offset = "0x2FE5220", VA = "0x182FE6420", Slot = "8")]
		public void HMBPCOBLJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2FE65A0", Offset = "0x2FE53A0", VA = "0x182FE65A0", Slot = "9")]
		public void JHIOELEODKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2FE5940", Offset = "0x2FE4740", VA = "0x182FE5940", Slot = "10")]
		public void ALDLLJHMGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2FE6350", Offset = "0x2FE5150", VA = "0x182FE6350", Slot = "11")]
		public void HGAHKCMJIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "13")]
		public void EABBFAJCEDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2FE5E50", Offset = "0x2FE4C50", VA = "0x182FE5E50", Slot = "12")]
		public void CPMHKEDPPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[GDFKOGKEDCG(typeof(AEJNGPFNACL), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.WorldService)]
	public class WorldService : AEJNGPFNACL, IDisposable, MDEPDIFNFKG, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private MKGAEINCAIG BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool LINNMJPFKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private KDBCABAKEFA CMDDNCNFEMB;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MKGAEINCAIG CADGIMEBGCG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public DMGDMAGLCAD EDDGIILAJBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2ECBFD0", Offset = "0x2ECADD0", VA = "0x182ECBFD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager CCEKCIJDDIO
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2FF54D0", Offset = "0x2FF42D0", VA = "0x182FF54D0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool EFIIIACBDGM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x75BA60", Offset = "0x75A860", VA = "0x18075BA60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2FF5510", Offset = "0x2FF4310", VA = "0x182FF5510", Slot = "10")]
		public void NIACEKGLEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2FF5480", Offset = "0x2FF4280", VA = "0x182FF5480", Slot = "11")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2FF5140", Offset = "0x2FF3F40", VA = "0x182FF5140")]
		private void CJALKNOJAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2FF5250", Offset = "0x2FF4050", VA = "0x182FF5250", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2FF54F0", Offset = "0x2FF42F0", VA = "0x182FF54F0", Slot = "8")]
		public ComponentSystemBase JPOOEOCPBOJ(Type LEDIIMFEFLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[GDFKOGKEDCG(typeof(JDPMGELIKJO), new string[] { })]
public sealed class DAJEIIKBHBO : JDPMGELIKJO, KHEIMMLCGKM, MDEPDIFNFKG, JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KMEAFELOJIF : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7621D0", Offset = "0x760FD0", VA = "0x1807621D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x2FDB740", Offset = "0x2FDA540", VA = "0x182FDB740", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9D05F0", Offset = "0x9CF3F0", VA = "0x1809D05F0")]
		[DebuggerHidden]
		public KMEAFELOJIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB430", Offset = "0x2FDA230", VA = "0x182FDB430", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB700", Offset = "0x2FDA500", VA = "0x182FDB700", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB660", Offset = "0x2FDA460", VA = "0x182FDB660", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB660", Offset = "0x2FDA460", VA = "0x182FDB660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[DNEBGGIIGBA]
	private ENDOBGIHNAA PGPGHEAKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly JACOMBPBHFF HNIEOKPIJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Dictionary<string, IPLMDDOHKAG> EJBAIEJEHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Dictionary<int, DIPMPDBMMIB> ICCIOFKINBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<AFJNBCJHANB> MOHMJGLIGLG;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public DIPMPDBMMIB FMGPHLAMFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2EC93C0", Offset = "0x2EC81C0", VA = "0x182EC93C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<AFJNBCJHANB> MGHOPDOBBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
	public void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8950", Offset = "0x2EC7750", VA = "0x182EC8950", Slot = "8")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8B20", Offset = "0x2EC7920", VA = "0x182EC8B20", Slot = "9")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2EC88C0", Offset = "0x2EC76C0", VA = "0x182EC88C0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2EC97D0", Offset = "0x2EC85D0", VA = "0x182EC97D0", Slot = "6")]
	public bool PLGLCKOIOPM(AFJNBCJHANB FHINIKPHPFG, out DIPMPDBMMIB HCBJJHBALOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8F50", Offset = "0x2EC7D50", VA = "0x182EC8F50")]
	private void HMDDAHCJCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8B40", Offset = "0x2EC7940", VA = "0x182EC8B40")]
	private void HGHGEOMKOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9860", Offset = "0x2EC8660", VA = "0x182EC9860")]
	private IPLMDDOHKAG PMGGDFMIGJJ(string CEJNDAAGFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2EC93C0", Offset = "0x2EC81C0", VA = "0x182EC93C0")]
	private IPLMDDOHKAG JAGHMLCLGIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8CE0", Offset = "0x2EC7AE0", VA = "0x182EC8CE0")]
	private IPLMDDOHKAG HIBHMIHPIIM(string CEJNDAAGFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9420", Offset = "0x2EC8220", VA = "0x182EC9420")]
	private IPLMDDOHKAG JIODACNKGJE(string DIHIPMILEPF, string AMBDKIOJFBL, [Optional] IPLMDDOHKAG KHOLNGEGHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9350", Offset = "0x2EC8150", VA = "0x182EC9350")]
	[IteratorStateMachine(typeof(KMEAFELOJIF))]
	private IEnumerable<(string, string)> IENPACPEMIF(string CEJNDAAGFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9530", Offset = "0x2EC8330", VA = "0x182EC9530")]
	private bool JMNHCBJLOBN(AFJNBCJHANB FHINIKPHPFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9580", Offset = "0x2EC8380", VA = "0x182EC9580")]
	private JACOMBPBHFF MBEDIIDJOMK(AFJNBCJHANB FHINIKPHPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8870", Offset = "0x2EC7670", VA = "0x182EC8870")]
	private JACOMBPBHFF DIDIEIGIAON(AFJNBCJHANB FHINIKPHPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2EC96D0", Offset = "0x2EC84D0", VA = "0x182EC96D0")]
	private JACOMBPBHFF MPJFDJOPIPC(AFJNBCJHANB FHINIKPHPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x22C1DD0", Offset = "0x22C0BD0", VA = "0x1822C1DD0")]
	private T MDALDMHNCOF<T>(AFJNBCJHANB FHINIKPHPFG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8A40", Offset = "0x2EC7840", VA = "0x182EC8A40")]
	private FieldInfo FJFKOEGGNEL(AFJNBCJHANB FHINIKPHPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2EC98C0", Offset = "0x2EC86C0", VA = "0x182EC98C0")]
	public DAJEIIKBHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2EC89B0", Offset = "0x2EC77B0", VA = "0x182EC89B0")]
	[CompilerGenerated]
	private int FJDDCMPHDFM(AFJNBCJHANB GCKGDDMIIDO, AFJNBCJHANB EJKHFJILHAC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class IPLMDDOHKAG : DIPMPDBMMIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly string FDONKAGHFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly IPLMDDOHKAG KHOLNGEGHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly List<IPLMDDOHKAG> EBICECENDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly List<AFJNBCJHANB> PGPGHEAKODE;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string BJALLCBAEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DIPMPDBMMIB ABHNBLAMHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<DIPMPDBMMIB> OIAJMICFMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<AFJNBCJHANB> BBGHDOFPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x32AC400", Offset = "0x32AB200", VA = "0x1832AC400")]
	public IPLMDDOHKAG(string ICIEGOLHGJN, IPLMDDOHKAG GANAMHNGMGO)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[GDFKOGKEDCG(typeof(LDOPIEJCCFG), new string[] { })]
	[BOOKNJKHAPG(typeof(HistoryService))]
	[DKGMECGHCPI(OJBFOICGDOF.History)]
	public class HistoryService : JPLAKHLHFLM, IDisposable, LDOPIEJCCFG
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private enum PHJLCOHBHLL
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private readonly struct JBIGDIHHOGK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly PHJLCOHBHLL MJONNNACEAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly HistoryService HGNLGIBOCHA;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x44A7CA0", Offset = "0x44A6AA0", VA = "0x1844A7CA0")]
			public JBIGDIHHOGK(HistoryService HGNLGIBOCHA, bool LPKPEDHDMIN, uint HHCMOLFBCEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x44A7C70", Offset = "0x44A6A70", VA = "0x1844A7C70", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public class OLHGLNODCFA
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct NNAHCJHGJBM : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private readonly OLHGLNODCFA GCFKLPPHEMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private readonly bool MELOABKKIKC;

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x44AC550", Offset = "0x44AB350", VA = "0x1844AC550")]
				public NNAHCJHGJBM(OLHGLNODCFA GCFKLPPHEMH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x44A1150", Offset = "0x449FF50", VA = "0x1844A1150", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct ALAMJOMDIIO : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private readonly OLHGLNODCFA GCFKLPPHEMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private readonly bool MELOABKKIKC;

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x44A1180", Offset = "0x449FF80", VA = "0x1844A1180")]
				public ALAMJOMDIIO(OLHGLNODCFA GCFKLPPHEMH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x44A1150", Offset = "0x449FF50", VA = "0x1844A1150", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly HistoryService CBNHCPJLDIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private bool GKJCKBBLIBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int PFFFBGAHCMP;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x44ACD30", Offset = "0x44ABB30", VA = "0x1844ACD30")]
			public OLHGLNODCFA(HistoryService CBNHCPJLDIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x44ACC60", Offset = "0x44ABA60", VA = "0x1844ACC60")]
			public bool AKAOHJNMAIA(MFDODOEBKCJ BMINGOEPCBN, DFNAMHCDDIN HEDGDEEAPPO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x44ACCE0", Offset = "0x44ABAE0", VA = "0x1844ACCE0")]
			public ALAMJOMDIIO LLMEKDBMGNL()
			{
				return default(ALAMJOMDIIO);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x44ACC90", Offset = "0x44ABA90", VA = "0x1844ACC90")]
			public NNAHCJHGJBM GPECOIHPNNO()
			{
				return default(NNAHCJHGJBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class KJDFOCPDOHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public KJDFOCPDOHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x44A8820", Offset = "0x44A7620", VA = "0x1844A8820")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class DBJFCKOCEHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public DBJFCKOCEHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x44A36D0", Offset = "0x44A24D0", VA = "0x1844A36D0")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class IMFAPHNEHED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public IMFAPHNEHED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x44A7C40", Offset = "0x44A6A40", VA = "0x1844A7C40")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly UndoAction GOANKNLIJCO;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly RedoAction MGJIFLAMBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private DIEHLHFKBFL DGCMMNOKCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ActionBuffer BDPKLLFELHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ActionBuffer LJAKPEDIKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private OLKFKKGNKNJ GLGFLIFNJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TransformOwnershipPhase MCAIMDMBACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private PropertyChangeRouterService OHGEPLBFKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private JPOGMFHNGKL NFJMOBIDFNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private PHJLCOHBHLL NIPEDJLIFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private OLHGLNODCFA GCFKLPPHEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool LINNMJPFKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private KKIMGPLCJHJ BHBPCKBHHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private HJJNHNANFFG PENDBOHJAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private DFNAMHCDDIN CBBGDOHBGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly GatherPropertiesForUndelete ENHCEGCPKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private uint CIPJMJDCAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private uint PIFHLLEBFJK;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private OLHGLNODCFA GLBDBAECNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x757900", Offset = "0x756700", VA = "0x180757900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool MJOJHHONKIK
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x32A8D30", Offset = "0x32A7B30", VA = "0x1832A8D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool BHJJPDHBNDC
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x32A9070", Offset = "0x32A7E70", VA = "0x1832A9070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool AOGCBAADHJF
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x32A8690", Offset = "0x32A7490", VA = "0x1832A8690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int HGCDNOKJMCM
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x32A70C0", Offset = "0x32A5EC0", VA = "0x1832A70C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int CMODGOLMGAC
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x32A7500", Offset = "0x32A6300", VA = "0x1832A7500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool HCGCHCOFIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x32A8D20", Offset = "0x32A7B20", VA = "0x1832A8D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool MKKFLOINDKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x32A8810", Offset = "0x32A7610", VA = "0x1832A8810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool PKDEALBPNFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBA0", Offset = "0xB4E9A0", VA = "0x180B4FBA0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x16B3250", Offset = "0x16B2050", VA = "0x1816B3250", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer HJJIPMFLAGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x32A7160", Offset = "0x32A5F60", VA = "0x1832A7160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action IFILIKONPJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x32A7240", Offset = "0x32A6040", VA = "0x1832A7240", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x32A7460", Offset = "0x32A6260", VA = "0x1832A7460", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action MEPPNNABGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x32A8150", Offset = "0x32A6F50", VA = "0x1832A8150")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x32A8FD0", Offset = "0x32A7DD0", VA = "0x1832A8FD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x32A78C0", Offset = "0x32A66C0", VA = "0x1832A78C0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x32A7560", Offset = "0x32A6360", VA = "0x1832A7560", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x32A7FD0", Offset = "0x32A6DD0", VA = "0x1832A7FD0")]
		private void FJDJKMJKPIM(MFDODOEBKCJ BMINGOEPCBN, FDFCOIOFJLK CGGDKMMOHHB, bool NCBDCIGDJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x32A7D70", Offset = "0x32A6B70", VA = "0x1832A7D70")]
		private void EDCLCEHAGBL(MFDODOEBKCJ BMINGOEPCBN, DFNAMHCDDIN HEDGDEEAPPO, BDKOOLPOOEA LPAEDOGOMAK, BDKOOLPOOEA IJHAJFKAPBA, bool NCBDCIGDJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x32A8DA0", Offset = "0x32A7BA0", VA = "0x1832A8DA0")]
		private void OCEHPPAIAOB(MFDODOEBKCJ BMINGOEPCBN, bool NCBDCIGDJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x32A71E0", Offset = "0x32A5FE0", VA = "0x1832A71E0", Slot = "14")]
		public IDisposable DADJPFAALIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x32A7060", Offset = "0x32A5E60", VA = "0x1832A7060", Slot = "9")]
		public IDisposable AHFDOHGCPHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x32A7800", Offset = "0x32A6600", VA = "0x1832A7800", Slot = "6")]
		public UndoAction EAAACKNICJG()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x32A8940", Offset = "0x32A7740", VA = "0x1832A8940", Slot = "15")]
		public RedoAction KPNBEIPJAKB()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x32A85D0", Offset = "0x32A73D0", VA = "0x1832A85D0", Slot = "16")]
		public UndoAction INEJMAIGFJE()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x32A8820", Offset = "0x32A7620", VA = "0x1832A8820", Slot = "7")]
		public RedoAction KPNBEIPJAKB(UndoAction ONDHOAIGIEB)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x32A84B0", Offset = "0x32A72B0", VA = "0x1832A84B0", Slot = "8")]
		public UndoAction INEJMAIGFJE(RedoAction ONDHOAIGIEB)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x32A9110", Offset = "0x32A7F10", VA = "0x1832A9110")]
		public bool PAHHGHGADOJ(FJIMCHJBNBO GPOMMDBJAHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x32A8F80", Offset = "0x32A7D80", VA = "0x1832A8F80", Slot = "17")]
		public void ODCBHOABBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x32A8A00", Offset = "0x32A7800", VA = "0x1832A8A00")]
		public void LIGKIHLEECP(MFDODOEBKCJ BMINGOEPCBN, FDFCOIOFJLK CGGDKMMOHHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x32A7EF0", Offset = "0x32A6CF0", VA = "0x1832A7EF0")]
		public void FIHINEFJMFK(MFDODOEBKCJ BMINGOEPCBN, DFNAMHCDDIN HEDGDEEAPPO, in BDKOOLPOOEA IJHAJFKAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x32A9150", Offset = "0x32A7F50", VA = "0x1832A9150")]
		public void PPBGICNKHPD(MFDODOEBKCJ BMINGOEPCBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x32A71A0", Offset = "0x32A5FA0", VA = "0x1832A71A0")]
		private void CGHIPCGILDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x32A8090", Offset = "0x32A6E90", VA = "0x1832A8090")]
		private void GDHIEKHDAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x32A7540", Offset = "0x32A6340", VA = "0x1832A7540")]
		private void DOBNJOPEHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x32A8C20", Offset = "0x32A7A20", VA = "0x1832A8C20")]
		private FJBKGIFPJMB MDCNKPJHNBA()
		{
			return default(FJBKGIFPJMB);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x32A7D90", Offset = "0x32A6B90", VA = "0x1832A7D90")]
		private uint EKKLICLIJKB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x32A7520", Offset = "0x32A6320", VA = "0x1832A7520")]
		private bool DNPLGOOOAPJ(out FJBKGIFPJMB JBJAGOLOBKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x32A80D0", Offset = "0x32A6ED0", VA = "0x1832A80D0")]
		private bool GNBHFBOJKKE(out FJBKGIFPJMB JBJAGOLOBKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x32A80F0", Offset = "0x32A6EF0", VA = "0x1832A80F0")]
		private RedoAction HEPBCKJKIIJ(FJBKGIFPJMB JBJAGOLOBKN)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x32A7DB0", Offset = "0x32A6BB0", VA = "0x1832A7DB0")]
		private UndoAction ENMHDCJLMNO(FJBKGIFPJMB JBJAGOLOBKN)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x32A81F0", Offset = "0x32A6FF0", VA = "0x1832A81F0")]
		private FJBKGIFPJMB IKNEHJBDOAH(FJBKGIFPJMB JBJAGOLOBKN, ActionBuffer DGHAJCHPAJF, bool LPKPEDHDMIN)
		{
			return default(FJBKGIFPJMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x32A7E10", Offset = "0x32A6C10", VA = "0x1832A7E10")]
		private void FHEDLMPAADI(Action JBJAGOLOBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCE10", Offset = "0x2AFBC10", VA = "0x182AFCE10")]
		private T FHEDLMPAADI<T>(Func<T> OEPNKLLOMPF)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x32A7170", Offset = "0x32A5F70", VA = "0x1832A7170")]
		private JBIGDIHHOGK BONGJLHDFPC(bool LPKPEDHDMIN, uint HHCMOLFBCEB)
		{
			return default(JBIGDIHHOGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x32A92E0", Offset = "0x32A80E0", VA = "0x1832A92E0")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x32A86C0", Offset = "0x32A74C0", VA = "0x1832A86C0")]
		[CompilerGenerated]
		private UndoAction KGLHBNOMGME()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x32A72E0", Offset = "0x32A60E0", VA = "0x1832A72E0")]
		[CompilerGenerated]
		private RedoAction DCIAIPJPPBO()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x32A8AC0", Offset = "0x32A78C0", VA = "0x1832A8AC0")]
		[CompilerGenerated]
		private UndoAction LNGNFBEBJIP()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class FAFGACAPKGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<byte> PALKODKBAJM;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int GOGPPCBDCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x741BD0", Offset = "0x7409D0", VA = "0x180741BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xD60330", Offset = "0xD5F130", VA = "0x180D60330")]
	public FAFGACAPKGA(NativeArray<byte> PALKODKBAJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x329D4A0", Offset = "0x329C2A0", VA = "0x18329D4A0")]
	public static FAFGACAPKGA JMLJLLKELMG(NativeArray<byte> PALKODKBAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public T OBCCOCIEALD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public NativeArray<T> GPKCGJOEBNI<T>(int PFLGNDMCMIN, Allocator MBJMPHBLMBF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public NativeArray<T> GOMMJALOIMM<T>(Allocator MBJMPHBLMBF) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class OLDIDEMOIHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<byte> PALKODKBAJM;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int GOGPPCBDCFB
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x741BD0", Offset = "0x7409D0", VA = "0x180741BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0xD60330", Offset = "0xD5F130", VA = "0x180D60330")]
	public OLDIDEMOIHF(NativeArray<byte> PALKODKBAJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D9D0", Offset = "0x2D1C7D0", VA = "0x182D1D9D0")]
	public static OLDIDEMOIHF JMLJLLKELMG(NativeArray<byte> PALKODKBAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2AD87A0", Offset = "0x2AD75A0", VA = "0x182AD87A0")]
	public T OBCCOCIEALD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	public NativeArray<T> GPKCGJOEBNI<T>(int PFLGNDMCMIN, Allocator MBJMPHBLMBF) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GNALMKLNLIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<byte> PALKODKBAJM;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int GOGPPCBDCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x741BD0", Offset = "0x7409D0", VA = "0x180741BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xD60330", Offset = "0xD5F130", VA = "0x180D60330")]
	public GNALMKLNLIE(NativeArray<byte> PALKODKBAJM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x32A2EE0", Offset = "0x32A1CE0", VA = "0x1832A2EE0")]
	public static GNALMKLNLIE JMLJLLKELMG(NativeArray<byte> PALKODKBAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4860", Offset = "0x2AE3660", VA = "0x182AE4860")]
	public void HMNPDNIBONI<T>(in T MGFMONLLLPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2AE48C0", Offset = "0x2AE36C0", VA = "0x182AE48C0")]
	public void LIDJMFLNGJB<T>(NativeArray<T> EKDHPMHGKLM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	public void DKGPJLMJFEH<T>(NativeArray<T> MGFMONLLLPD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class CPIOADJEIBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD0C0", Offset = "0x2EBBEC0", VA = "0x182EBD0C0")]
	public static Span<byte> JEOKKNGMKDH(this NativeArray<byte> PALKODKBAJM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD2C0", Offset = "0x2EBC0C0", VA = "0x182EBD2C0")]
	public static ReadOnlySpan<byte> OPBBHGLNKPG(this NativeArray<byte> PALKODKBAJM)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD240", Offset = "0x2EBC040", VA = "0x182EBD240")]
	public static NativeArray<byte> NNBEKIGFIMM(this NativeArray<byte> PALKODKBAJM, int CKCLNMMLENB)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD040", Offset = "0x2EBBE40", VA = "0x182EBD040")]
	public static NativeArray<byte> IKALIGBNAOD(this NativeArray<byte> PALKODKBAJM, int MNBBKKLFBKD = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x22ABF10", Offset = "0x22AAD10", VA = "0x1822ABF10")]
	public static NativeArray<byte> IKALIGBNAOD<T>(this NativeArray<byte> PALKODKBAJM, int MNBBKKLFBKD = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD150", Offset = "0x2EBBF50", VA = "0x182EBD150")]
	public static NativeArray<byte> MDGBIDPGJBD(this NativeArray<byte> PALKODKBAJM, int MNBBKKLFBKD)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x22ABF70", Offset = "0x22AAD70", VA = "0x1822ABF70")]
	public static NativeArray<byte> MDGBIDPGJBD<T>(this NativeArray<byte> PALKODKBAJM, int MNBBKKLFBKD = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2EBD1C0", Offset = "0x2EBBFC0", VA = "0x182EBD1C0")]
	public static NativeArray<byte> MNPEKOOILFO(this NativeArray<byte> PALKODKBAJM, int MNBBKKLFBKD = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x22ABFD0", Offset = "0x22AADD0", VA = "0x1822ABFD0")]
	public static NativeArray<byte> MNPEKOOILFO<T>(this NativeArray<byte> PALKODKBAJM, int MNBBKKLFBKD = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class MBMOGNGBFJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeList<byte> MPMKGFKPBEN;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xD60330", Offset = "0xD5F130", VA = "0x180D60330")]
	public MBMOGNGBFJE(NativeList<byte> MPMKGFKPBEN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2D19D80", Offset = "0x2D18B80", VA = "0x182D19D80")]
	public static MBMOGNGBFJE JMLJLLKELMG(NativeList<byte> PALKODKBAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	public void HMNPDNIBONI<T>(in T MGFMONLLLPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	public void LIDJMFLNGJB<T>(NativeArray<T> MGFMONLLLPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	public void DKGPJLMJFEH<T>(NativeArray<T> MGFMONLLLPD) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[GDFKOGKEDCG(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.PropertyChanges)]
	public class PropertyChangeNetworkRouter : MDEPDIFNFKG, JPLAKHLHFLM, BJCPCNKDADF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[DNEBGGIIGBA]
		private KOOIKIEEIDN IMGJFGGFPOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[DNEBGGIIGBA]
		private HLKMGBJJBCF PGPGHEAKODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[DNEBGGIIGBA]
		private DFDPLCEHANK KMBFMGEALGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[DNEBGGIIGBA]
		private PropertyChangeRouterService OHGEPLBFKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private DIEHLHFKBFL KAHIPMIDNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private LIGDBLEDHNA CNAHAPLPDDH;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public DIEHLHFKBFL ELEEACIPPNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2D34E70", Offset = "0x2D33C70", VA = "0x182D34E70")]
		public DIEHLHFKBFL.KICHKPBFALH PJJKOMODBIF()
		{
			return default(DIEHLHFKBFL.KICHKPBFALH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2D34AD0", Offset = "0x2D338D0", VA = "0x182D34AD0", Slot = "4")]
		public void NIACEKGLEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2D34500", Offset = "0x2D33300", VA = "0x182D34500", Slot = "5")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2D341D0", Offset = "0x2D32FD0", VA = "0x182D341D0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2D343F0", Offset = "0x2D331F0", VA = "0x182D343F0")]
		public void EAAACKNICJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2D34B30", Offset = "0x2D33930", VA = "0x182D34B30")]
		public void ODCBHOABBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2D349C0", Offset = "0x2D337C0", VA = "0x182D349C0")]
		private void JBGJHEFDNFJ(MFDODOEBKCJ BMINGOEPCBN, FDFCOIOFJLK CGGDKMMOHHB, bool NCBDCIGDJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2D34A90", Offset = "0x2D33890", VA = "0x182D34A90")]
		private void LAMCNKBALDJ(MFDODOEBKCJ BMINGOEPCBN, DFNAMHCDDIN HEDGDEEAPPO, BDKOOLPOOEA LPAEDOGOMAK, BDKOOLPOOEA IJHAJFKAPBA, bool NCBDCIGDJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2D34990", Offset = "0x2D33790", VA = "0x182D34990")]
		private void ICFFMINJEAK(MFDODOEBKCJ BMINGOEPCBN, bool NCBDCIGDJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2D34B70", Offset = "0x2D33970", VA = "0x182D34B70")]
		private void PHIOOFPGFNF(LIGDBLEDHNA NFJHHMHDKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2D34840", Offset = "0x2D33640", VA = "0x182D34840")]
		private void FPPCOCLKBDD(LIGDBLEDHNA NFJHHMHDKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2D34780", Offset = "0x2D33580", VA = "0x182D34780")]
		private void FLLKLHEJIKM(LIGDBLEDHNA NFJHHMHDKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2D341B0", Offset = "0x2D32FB0", VA = "0x182D341B0")]
		private void BGEHPFFJCDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2D34B50", Offset = "0x2D33950", VA = "0x182D34B50")]
		private void PADCKMIMCKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2D349F0", Offset = "0x2D337F0", VA = "0x182D349F0")]
		private void KNCFEKNGIJB(LIGDBLEDHNA NFJHHMHDKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5868B80", Offset = "0x5867980", VA = "0x185868B80", Slot = "6")]
		private void PLIKHFAAICA<TKey, T>(global::LFLIGLKEMAN<TKey, T> FHINIKPHPFG, object IJBJKIBEJLN) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[DKGMECGHCPI(OJBFOICGDOF.History)]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[GDFKOGKEDCG(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate void NPEALFJNEDH(MFDODOEBKCJ BMINGOEPCBN, FDFCOIOFJLK CGGDKMMOHHB, bool NCBDCIGDJGD);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate void APDPCHFILGE(MFDODOEBKCJ BMINGOEPCBN, DFNAMHCDDIN HEDGDEEAPPO, BDKOOLPOOEA LPAEDOGOMAK, BDKOOLPOOEA IJHAJFKAPBA, bool NCBDCIGDJGD);

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public delegate void LLKEFLEEBBJ(MFDODOEBKCJ BMINGOEPCBN, bool NCBDCIGDJGD);

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public NPEALFJNEDH CJALKNOJAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public APDPCHFILGE JOPOECLJJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public LLKEFLEEBBJ LGPDJPMAIOD;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2D34F50", Offset = "0x2D33D50", VA = "0x182D34F50")]
		public void LIGKIHLEECP(MFDODOEBKCJ BMINGOEPCBN, FDFCOIOFJLK CGGDKMMOHHB, bool NCBDCIGDJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2D34EE0", Offset = "0x2D33CE0", VA = "0x182D34EE0")]
		public void FIHINEFJMFK(MFDODOEBKCJ BMINGOEPCBN, DFNAMHCDDIN HEDGDEEAPPO, in BDKOOLPOOEA LPAEDOGOMAK, in BDKOOLPOOEA IJHAJFKAPBA, bool NCBDCIGDJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2D34F70", Offset = "0x2D33D70", VA = "0x182D34F70")]
		public void PPBGICNKHPD(MFDODOEBKCJ BMINGOEPCBN, bool NCBDCIGDJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DebuggerTypeProxy(typeof(FAJJPBHLAGG))]
	[DKGMECGHCPI(OJBFOICGDOF.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		internal class FAJJPBHLAGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private readonly ActionBuffer MMBEBPNKEHD;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public int JKIABPBFIHG
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x2FD9450", Offset = "0x2FD8250", VA = "0x182FD9450")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public BEBLMKEEGLF[] IGEFGABBNHH
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x2FD9290", Offset = "0x2FD8090", VA = "0x182FD9290")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
			public FAJJPBHLAGG(ActionBuffer FMBIIHIKLGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9360", Offset = "0x2FD8160", VA = "0x182FD9360")]
			[CompilerGenerated]
			private BEBLMKEEGLF IKKGMJHBKCD(FJBKGIFPJMB JBJAGOLOBKN)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		internal class BEBLMKEEGLF : BJCPCNKDADF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private readonly ActionBuffer MMBEBPNKEHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly FJBKGIFPJMB JBJAGOLOBKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private List<(LIGDBLEDHNA, string, object)> NKBLKEDOMIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private OLDIDEMOIHF IDIEIECFGPN;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public int JKIABPBFIHG
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0x2FD8AE0", Offset = "0x2FD78E0", VA = "0x182FD8AE0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(LIGDBLEDHNA, string, object)> KKDAPIDEODJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2FD8E70", Offset = "0x2FD7C70", VA = "0x182FD8E70")]
			public BEBLMKEEGLF(ActionBuffer FMBIIHIKLGB, FJBKGIFPJMB JBJAGOLOBKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2FD89E0", Offset = "0x2FD77E0", VA = "0x182FD89E0")]
			private string MOLPLPNNKGM(LIGDBLEDHNA CNAHAPLPDDH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2FD8B30", Offset = "0x2FD7930", VA = "0x182FD8B30")]
			private void OLEPBNNLDDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x2C06EB0", Offset = "0x2C05CB0", VA = "0x182C06EB0", Slot = "4")]
			public void DDPMFKKJOPK<TKey, T>(global::LFLIGLKEMAN<TKey, T> FHINIKPHPFG, [Optional] object IJBJKIBEJLN) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NativeList<byte> CANNGAMIHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Stack<FJBKGIFPJMB> KBBGMCNGHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly MFGDGPLICEG JPJEHDBLDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly KKIMGPLCJHJ BHBPCKBHHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly HLKMGBJJBCF PGPGHEAKODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly bool EEIBEBBLMPI;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public JKFGECFIHIA OAFAFEDHHDE
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x2EB5840", Offset = "0x2EB4640", VA = "0x182EB5840")]
			get
			{
				return default(JKFGECFIHIA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int JKIABPBFIHG
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x2EB5B90", Offset = "0x2EB4990", VA = "0x182EB5B90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5C90", Offset = "0x2EB4A90", VA = "0x182EB5C90")]
		public ActionBuffer(KKIMGPLCJHJ BHBPCKBHHME, HLKMGBJJBCF PGPGHEAKODE, bool EEIBEBBLMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5B00", Offset = "0x2EB4900", VA = "0x182EB5B00")]
		public bool MIGLBLIPAMO(out FJBKGIFPJMB JBJAGOLOBKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5BD0", Offset = "0x2EB49D0", VA = "0x182EB5BD0")]
		public void ODCBHOABBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2EB54B0", Offset = "0x2EB42B0", VA = "0x182EB54B0")]
		public FJBKGIFPJMB EAAACKNICJG(INMIPNLGEDJ NKBLKEDOMIK, JPOGMFHNGKL NFJMOBIDFNG, uint DDGPCOEJDIH)
		{
			return default(FJBKGIFPJMB);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5AD0", Offset = "0x2EB48D0", VA = "0x182EB5AD0")]
		public bool LNGHFCKNOKB(uint DDGPCOEJDIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2EB55F0", Offset = "0x2EB43F0", VA = "0x182EB55F0")]
		public bool GOBDBNDHDJA(uint DDGPCOEJDIH, out FJBKGIFPJMB ONDHOAIGIEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2EB4FC0", Offset = "0x2EB3DC0", VA = "0x182EB4FC0")]
		public void ACCKIFBPOIE(FJBKGIFPJMB ONDHOAIGIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5880", Offset = "0x2EB4680", VA = "0x182EB5880")]
		[Conditional("DEBUG_BUILD")]
		private void IJOMGDAIDKN(FJBKGIFPJMB ONDHOAIGIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2EB59C0", Offset = "0x2EB47C0", VA = "0x182EB59C0")]
		private void IKNEHJBDOAH(FJBKGIFPJMB GPBCAOBLFKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2EB51F0", Offset = "0x2EB3FF0", VA = "0x182EB51F0")]
		private void DCFKMAOLJEO(OLDIDEMOIHF EICGHALPPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2EB57E0", Offset = "0x2EB45E0", VA = "0x182EB57E0")]
		private void GOPJMMPMBMB(FJBKGIFPJMB JBJAGOLOBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5130", Offset = "0x2EB3F30", VA = "0x182EB5130")]
		private OLDIDEMOIHF DBGCOMKFPKM(FJBKGIFPJMB JBJAGOLOBKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5440", Offset = "0x2EB4240", VA = "0x182EB5440", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class MFGDGPLICEG : BJCPCNKDADF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly KKIMGPLCJHJ BHBPCKBHHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly HLKMGBJJBCF PGPGHEAKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private MFDODOEBKCJ BMINGOEPCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private OLDIDEMOIHF EKGKOFOOCAK;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7406E0", Offset = "0x73F4E0", VA = "0x1807406E0")]
	public MFGDGPLICEG(KKIMGPLCJHJ BHBPCKBHHME, HLKMGBJJBCF PGPGHEAKODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F040", Offset = "0x2B3DE40", VA = "0x182B3F040", Slot = "4")]
	public void DDPMFKKJOPK<TKey, T>(global::LFLIGLKEMAN<TKey, T> DHOJPBEDLBH, [Optional] object IJBJKIBEJLN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A200", Offset = "0x2D19000", VA = "0x182D1A200")]
	public void JEDOBACEBFK(LIGDBLEDHNA CNAHAPLPDDH, ref OLDIDEMOIHF EICGHALPPHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class DIEHLHFKBFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct KICHKPBFALH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly DIEHLHFKBFL GANAMHNGMGO;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB400", Offset = "0x2FDA200", VA = "0x182FDB400")]
		public KICHKPBFALH(DIEHLHFKBFL GANAMHNGMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB3E0", Offset = "0x2FDA1E0", VA = "0x182FDB3E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	protected INMIPNLGEDJ NKBLKEDOMIK;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public INMIPNLGEDJ KKDAPIDEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2ECB340", Offset = "0x2ECA140", VA = "0x182ECB340")]
		get
		{
			return default(INMIPNLGEDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool LIKHMDFHKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2ECB230", Offset = "0x2ECA030", VA = "0x182ECB230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB730", Offset = "0x2ECA530", VA = "0x182ECB730")]
	public DIEHLHFKBFL(INMIPNLGEDJ.MGPAHAOLKAH OFKOOBEBPFK = INMIPNLGEDJ.MGPAHAOLKAH.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB510", Offset = "0x2ECA310", VA = "0x182ECB510")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB420", Offset = "0x2ECA220", VA = "0x182ECB420")]
	public void LIGKIHLEECP(MFDODOEBKCJ BMINGOEPCBN, FDFCOIOFJLK CGGDKMMOHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB390", Offset = "0x2ECA190", VA = "0x182ECB390")]
	public void FIHINEFJMFK(MFDODOEBKCJ BMINGOEPCBN, DFNAMHCDDIN HEDGDEEAPPO, in BDKOOLPOOEA IJHAJFKAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB650", Offset = "0x2ECA450", VA = "0x182ECB650")]
	public void PPBGICNKHPD(MFDODOEBKCJ BMINGOEPCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB240", Offset = "0x2ECA040", VA = "0x182ECB240")]
	public void BGEHPFFJCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB520", Offset = "0x2ECA320", VA = "0x182ECB520")]
	public void PADCKMIMCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB380", Offset = "0x2ECA180", VA = "0x182ECB380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB620", Offset = "0x2ECA420", VA = "0x182ECB620")]
	public KICHKPBFALH PJJKOMODBIF()
	{
		return default(KICHKPBFALH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct LIGDBLEDHNA : IComparable<LIGDBLEDHNA>, IEquatable<LIGDBLEDHNA>
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly LIGDBLEDHNA IALIPEBLGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public MFDODOEBKCJ BMINGOEPCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public DFNAMHCDDIN HEDGDEEAPPO;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool EMDPCLDELLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF510", Offset = "0x2EFE310", VA = "0x182EFF510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7621E0", Offset = "0x760FE0", VA = "0x1807621E0")]
	public LIGDBLEDHNA(MFDODOEBKCJ BMINGOEPCBN, DFNAMHCDDIN HEDGDEEAPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x32B6850", Offset = "0x32B5650", VA = "0x1832B6850")]
	public void AOLMNMDAHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x32B6860", Offset = "0x32B5660", VA = "0x1832B6860", Slot = "4")]
	public int CompareTo(LIGDBLEDHNA IDBPJJAKCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x32B6A60", Offset = "0x32B5860", VA = "0x1832B6A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x32B68E0", Offset = "0x32B56E0", VA = "0x1832B68E0", Slot = "0")]
	public override bool Equals(object OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x32B6980", Offset = "0x32B5780", VA = "0x1832B6980", Slot = "5")]
	public bool Equals(LIGDBLEDHNA IDBPJJAKCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x32B68A0", Offset = "0x32B56A0", VA = "0x1832B68A0")]
	public static bool EJGLOGBEPOL(LIGDBLEDHNA JGEPMPFGKOG, LIGDBLEDHNA CPIBOCOHLLI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x32B6A10", Offset = "0x32B5810", VA = "0x1832B6A10")]
	public static bool IKFCAHNLBFO(LIGDBLEDHNA JGEPMPFGKOG, LIGDBLEDHNA CPIBOCOHLLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x32B69D0", Offset = "0x32B57D0", VA = "0x1832B69D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[DKGMECGHCPI(OJBFOICGDOF.History)]
	public class GatherPropertiesForUndelete : LCJKGBJCLDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private KKIMGPLCJHJ BHBPCKBHHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private MFDODOEBKCJ BMINGOEPCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HistoryService CBNHCPJLDIB;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x32A4770", Offset = "0x32A3570", VA = "0x1832A4770")]
		public void PAKNGBNHMME(MFDODOEBKCJ BMINGOEPCBN, KKIMGPLCJHJ BHBPCKBHHME, HistoryService CBNHCPJLDIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x32A46A0", Offset = "0x32A34A0", VA = "0x1832A46A0", Slot = "4")]
		private void EDLBECEBMDG(CANPGFJEDGO FHINIKPHPFG, in BDKOOLPOOEA MGFMONLLLPD, object IJBJKIBEJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class PMLNODPOOGD
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CEE0", Offset = "0x2D2BCE0", VA = "0x182D2CEE0")]
	public static void FPPCOCLKBDD(INMIPNLGEDJ NKBLKEDOMIK, LIGDBLEDHNA CNAHAPLPDDH, FDFCOIOFJLK CGGDKMMOHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CFE0", Offset = "0x2D2BDE0", VA = "0x182D2CFE0")]
	public static void JLPEMLFCJBD(INMIPNLGEDJ NKBLKEDOMIK, LIGDBLEDHNA CNAHAPLPDDH, in BDKOOLPOOEA IJHAJFKAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CE90", Offset = "0x2D2BC90", VA = "0x182D2CE90")]
	public static void FLLKLHEJIKM(INMIPNLGEDJ NKBLKEDOMIK, LIGDBLEDHNA CNAHAPLPDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D140", Offset = "0x2D2BF40", VA = "0x182D2D140")]
	public static void NKHGLPBJFMO(INMIPNLGEDJ NKBLKEDOMIK, LIGDBLEDHNA CNAHAPLPDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D0F0", Offset = "0x2D2BEF0", VA = "0x182D2D0F0")]
	public static FDFCOIOFJLK MBAEILIMJLO(INMIPNLGEDJ NKBLKEDOMIK, LIGDBLEDHNA CNAHAPLPDDH)
	{
		return default(FDFCOIOFJLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x27E9260", Offset = "0x27E8060", VA = "0x1827E9260")]
	public static T CCBFJMELKEK<T>(INMIPNLGEDJ NKBLKEDOMIK, LIGDBLEDHNA CNAHAPLPDDH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x27E9230", Offset = "0x27E8030", VA = "0x1827E9230")]
	public static T CCBFJMELKEK<T>(ref OLDIDEMOIHF MMJOHADFCHO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D2D0A0", Offset = "0x2D2BEA0", VA = "0x182D2D0A0")]
	public static FDFCOIOFJLK MBAEILIMJLO(ref OLDIDEMOIHF MMJOHADFCHO)
	{
		return default(FDFCOIOFJLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct INMIPNLGEDJ : IEnumerable<LIGDBLEDHNA>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum MGPAHAOLKAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct DFEFKNKLMCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly INMIPNLGEDJ MPMKGFKPBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly JPOGMFHNGKL NFJMOBIDFNG;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x44A4060", Offset = "0x44A2E60", VA = "0x1844A4060")]
		public DFEFKNKLMCC(INMIPNLGEDJ MPMKGFKPBEN, JPOGMFHNGKL NFJMOBIDFNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x44A3750", Offset = "0x44A2550", VA = "0x1844A3750")]
		public void CNMKJDDHOPK(NativeList<byte> KHIILPEBNKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x44A3C40", Offset = "0x44A2A40", VA = "0x1844A3C40")]
		private void FKKNNBIDDBJ(LIGDBLEDHNA CNAHAPLPDDH, ref GNALMKLNLIE PEHKJIJBKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x44A3DF0", Offset = "0x44A2BF0", VA = "0x1844A3DF0")]
		private void LNFMDBJBCEH(LIGDBLEDHNA CNAHAPLPDDH, ref GNALMKLNLIE PEHKJIJBKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x44A3E80", Offset = "0x44A2C80", VA = "0x1844A3E80")]
		private NativeArray<byte> OMPMHACNLCJ(NativeList<byte> KHIILPEBNKK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x44A3F70", Offset = "0x44A2D70", VA = "0x1844A3F70")]
		private NativeArray<byte> PGDDCMFPEOJ(NativeList<byte> KHIILPEBNKK, int PFLGNDMCMIN)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x44A39F0", Offset = "0x44A27F0", VA = "0x1844A39F0")]
		private int DMOKCDHDONL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x44A3C90", Offset = "0x44A2A90", VA = "0x1844A3C90")]
		private bool HMIONCMNHBJ(LIGDBLEDHNA CNAHAPLPDDH, out NativeArray<byte> FCBNFGLKJOG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct FOCJLJOLAMC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeList<byte> MMJOHADFCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private INMIPNLGEDJ MPMKGFKPBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly LIGDBLEDHNA NFJHHMHDKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly int CKCLNMMLENB;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x44A6B90", Offset = "0x44A5990", VA = "0x1844A6B90")]
		internal FOCJLJOLAMC(INMIPNLGEDJ MPMKGFKPBEN, LIGDBLEDHNA NFJHHMHDKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x44A6AF0", Offset = "0x44A58F0", VA = "0x1844A6AF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x44A6A90", Offset = "0x44A5890", VA = "0x1844A6A90")]
		public void JGODCOIELOK(NativeArray<byte> MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x44A6B20", Offset = "0x44A5920", VA = "0x1844A6B20")]
		public void GIBGCILCIEO(NativeArray<byte> MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x44A6B80", Offset = "0x44A5980", VA = "0x1844A6B80")]
		public void LNFMDBJBCEH(in BDKOOLPOOEA MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2C14580", Offset = "0x2C13380", VA = "0x182C14580")]
		public void LNFMDBJBCEH<T>(T MGFMONLLLPD) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x44A6910", Offset = "0x44A5710", VA = "0x1844A6910")]
		private void DMGFCCHBICE(int MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x44A69E0", Offset = "0x44A57E0", VA = "0x1844A69E0")]
		private void DMGFCCHBICE(in BDKOOLPOOEA MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x44A6980", Offset = "0x44A5780", VA = "0x1844A6980")]
		private unsafe void DMGFCCHBICE(void* IDNDOLEIGFD, int PFLGNDMCMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x44A6A90", Offset = "0x44A5890", VA = "0x1844A6A90")]
		private void DMGFCCHBICE(NativeArray<byte> EKDHPMHGKLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct JMCPELPCIFB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private INMIPNLGEDJ MPMKGFKPBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<byte> MMJOHADFCHO;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x44A7FD0", Offset = "0x44A6DD0", VA = "0x1844A7FD0")]
		internal JMCPELPCIFB(INMIPNLGEDJ MPMKGFKPBEN, NativeArray<byte> MMJOHADFCHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x44A7D10", Offset = "0x44A6B10", VA = "0x1844A7D10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x44A7E10", Offset = "0x44A6C10", VA = "0x1844A7E10")]
		public NativeArray<byte> GPKCGJOEBNI(int PFLGNDMCMIN)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x44A7D20", Offset = "0x44A6B20", VA = "0x1844A7D20")]
		public NativeArray<byte> GOMMJALOIMM()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2C14F50", Offset = "0x2C13D50", VA = "0x182C14F50")]
		public T OBCCOCIEALD<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x44A7ED0", Offset = "0x44A6CD0", VA = "0x1844A7ED0")]
		public void OBCCOCIEALD(in KPCNMJOGJPJ MGFMONLLLPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct GCBEHGMFFKM : IEnumerator<LIGDBLEDHNA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly NativeList<LIGDBLEDHNA> PALKODKBAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int NNHNOIMLALG;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public LIGDBLEDHNA OAFAFEDHHDE
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x44A6FC0", Offset = "0x44A5DC0", VA = "0x1844A6FC0", Slot = "4")]
			get
			{
				return default(LIGDBLEDHNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x44A6F80", Offset = "0x44A5D80", VA = "0x1844A6F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x333BED0", Offset = "0x333ACD0", VA = "0x18333BED0")]
		internal GCBEHGMFFKM(NativeList<LIGDBLEDHNA> EKDHPMHGKLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x44A6E40", Offset = "0x44A5C40", VA = "0x1844A6E40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x44A6F40", Offset = "0x44A5D40", VA = "0x1844A6F40", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct GBGJIODGKKO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int KCLMIKLBODI = 0;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int JOMNCKLGCAB = 1;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int PJEHKMANFAP = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NativeArray<int> MMJOHADFCHO;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool MNPJEDKKEAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x44A6D60", Offset = "0x44A5B60", VA = "0x1844A6D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int FLMIIFNAEOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x44A6C40", Offset = "0x44A5A40", VA = "0x1844A6C40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x44A6DA0", Offset = "0x44A5BA0", VA = "0x1844A6DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public MGPAHAOLKAH ANACIDAOGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x44A6DB0", Offset = "0x44A5BB0", VA = "0x1844A6DB0")]
			get
			{
				return default(MGPAHAOLKAH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x44A6CF0", Offset = "0x44A5AF0", VA = "0x1844A6CF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool LIKHMDFHKEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x44A6C30", Offset = "0x44A5A30", VA = "0x1844A6C30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x44A6CC0", Offset = "0x44A5AC0", VA = "0x1844A6CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool KDJKOHLDAKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x44A6CE0", Offset = "0x44A5AE0", VA = "0x1844A6CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x44A6D00", Offset = "0x44A5B00", VA = "0x1844A6D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x44A6DC0", Offset = "0x44A5BC0", VA = "0x1844A6DC0")]
		public GBGJIODGKKO(MGPAHAOLKAH OFKOOBEBPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x44A6C50", Offset = "0x44A5A50", VA = "0x1844A6C50")]
		private int BANNGLOAJDI(int NGOMPMICLHJ, int EELMODCKMCL = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x44A6D20", Offset = "0x44A5B20", VA = "0x1844A6D20")]
		private void KKNDJJJFEOO(int NGOMPMICLHJ, int MGFMONLLLPD, int EELMODCKMCL = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x44A6C80", Offset = "0x44A5A80", VA = "0x1844A6C80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private const int MPAENGFCJOB = -1;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private const int GGOAPLOCFAI = 0;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly LIGDBLEDHNA NKMOHMKOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeHashMap<LIGDBLEDHNA, int> IJDLHBAHPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NativeList<LIGDBLEDHNA> NKBLKEDOMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NativeList<int> ABKGMLJJHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NativeList<byte> BPDFNJHIOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private NativeList<byte> MMJOHADFCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private GBGJIODGKKO DNHNNDBCPLH;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool LIKHMDFHKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x32AB4E0", Offset = "0x32AA2E0", VA = "0x1832AB4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool GMKILCIPLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x32ABAE0", Offset = "0x32AA8E0", VA = "0x1832ABAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int FLMIIFNAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x32AB4F0", Offset = "0x32AA2F0", VA = "0x1832AB4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int HFCCHEOAHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x32AB640", Offset = "0x32AA440", VA = "0x1832AB640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool MNPJEDKKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x32ABCF0", Offset = "0x32AAAF0", VA = "0x1832ABCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x32AB710", Offset = "0x32AA510", VA = "0x1832AB710")]
	public static INMIPNLGEDJ CJALKNOJAHB(MGPAHAOLKAH OFKOOBEBPFK = MGPAHAOLKAH.Last, int GIFKKJLOACJ = 16, int IDCLEHKJOBM = 256)
	{
		return default(INMIPNLGEDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x32AC1D0", Offset = "0x32AAFD0", VA = "0x1832AC1D0")]
	private INMIPNLGEDJ(MGPAHAOLKAH OFKOOBEBPFK, int GIFKKJLOACJ, int IDCLEHKJOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x32AB840", Offset = "0x32AA640", VA = "0x1832AB840", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x32ABE50", Offset = "0x32AAC50", VA = "0x1832ABE50")]
	public FOCJLJOLAMC PHIOOFPGFNF(LIGDBLEDHNA NFJHHMHDKEL)
	{
		return default(FOCJLJOLAMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x32AB680", Offset = "0x32AA480", VA = "0x1832AB680")]
	public JMCPELPCIFB CHKOPIBHAIF(LIGDBLEDHNA NFJHHMHDKEL)
	{
		return default(JMCPELPCIFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x32ABEE0", Offset = "0x32AACE0", VA = "0x1832ABEE0")]
	public bool PIDJOKEKBGP(LIGDBLEDHNA NFJHHMHDKEL, out JMCPELPCIFB NAHLJGLOPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x32AB5F0", Offset = "0x32AA3F0", VA = "0x1832AB5F0")]
	public bool BBCBJNFLLOK(LIGDBLEDHNA NFJHHMHDKEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x32ABA10", Offset = "0x32AA810", VA = "0x1832ABA10")]
	public bool IMFJOIPCBKG(LIGDBLEDHNA NFJHHMHDKEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x32AB750", Offset = "0x32AA550", VA = "0x1832AB750")]
	public void DIDKHFDDPIL(NativeList<byte> KHIILPEBNKK, JPOGMFHNGKL NFJMOBIDFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x293ECB0", Offset = "0x293DAB0", VA = "0x18293ECB0")]
	public T IHLCJELLMHC<T>(LIGDBLEDHNA NFJHHMHDKEL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x32ABD70", Offset = "0x32AAB70", VA = "0x1832ABD70")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x32ABD30", Offset = "0x32AAB30", VA = "0x1832ABD30")]
	public GCBEHGMFFKM NEACBAFBFJC()
	{
		return default(GCBEHGMFFKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x32ABB00", Offset = "0x32AA900", VA = "0x1832ABB00")]
	private void KOHPGNPJJMI(LIGDBLEDHNA NFJHHMHDKEL, int CKCLNMMLENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x32AB500", Offset = "0x32AA300", VA = "0x1832AB500")]
	private void AOLMNMDAHNM(int DDIBLPMPEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x32AB920", Offset = "0x32AA720", VA = "0x1832AB920")]
	private void FBDCCKIGEFF(LIGDBLEDHNA NFJHHMHDKEL, int CKCLNMMLENB, int PFLGNDMCMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x276A2F0", Offset = "0x27690F0", VA = "0x18276A2F0")]
	private static T IHLCJELLMHC<T>(NativeArray<byte> PALKODKBAJM, int NGOMPMICLHJ = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x32AC110", Offset = "0x32AAF10", VA = "0x1832AC110", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x32AC0D0", Offset = "0x32AAED0", VA = "0x1832AC0D0", Slot = "4")]
	private IEnumerator<LIGDBLEDHNA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class FHIHJKOIBFK<T> : CENINKGGFPK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private EntityQuery NOJJNNFMBAH;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2A67C70", Offset = "0x2A66A70", VA = "0x182A67C70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2A67D90", Offset = "0x2A66B90", VA = "0x182A67D90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2A67E00", Offset = "0x2A66C00", VA = "0x182A67E00")]
	public FHIHJKOIBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1058C20", Offset = "0x1057A20", VA = "0x181058C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	internal class CleanupRigidbodyExImpl : CENINKGGFPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private EntityQuery NOJJNNFMBAH;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF0E0", Offset = "0x2EBDEE0", VA = "0x182EBF0E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF180", Offset = "0x2EBDF80", VA = "0x182EBF180", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[Preserve]
internal class HANLHNBIDAC : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private EntityQuery PPPOINPFNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x32A48D0", Offset = "0x32A36D0", VA = "0x1832A48D0", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x32A4920", Offset = "0x32A3720", VA = "0x1832A4920", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x32A49B0", Offset = "0x32A37B0", VA = "0x1832A49B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public HANLHNBIDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
internal class EGFOLDGDJGL : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private PropertyDiffStateService KLMOGBHEHLH;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0AC0", Offset = "0x2ECF8C0", VA = "0x182ED0AC0", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B10", Offset = "0x2ECF910", VA = "0x182ED0B10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public EGFOLDGDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EntityQuery NOJJNNFMBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private SceneService GOCPDFPAIOP;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2ECE110", Offset = "0x2ECCF10", VA = "0x182ECE110", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2ECE160", Offset = "0x2ECCF60", VA = "0x182ECE160", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2ECE1F0", Offset = "0x2ECCFF0", VA = "0x182ECE1F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
	[GDFKOGKEDCG(typeof(CullingBandService), new string[] { })]
	public class CullingBandService : JPLAKHLHFLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<NativeListAsync<IFOFHCJELOG>> JHANAFGMPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL EOHGMNFKFFO;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2EC82E0", Offset = "0x2EC70E0", VA = "0x182EC82E0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8100", Offset = "0x2EC6F00", VA = "0x182EC8100")]
		public void CNEHLAACCBF(NativeListAsync<IFOFHCJELOG> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8330", Offset = "0x2EC7130", VA = "0x182EC8330")]
		public void GAMAKJPBCMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8170", Offset = "0x2EC6F70", VA = "0x182EC8170", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC87F0", Offset = "0x2EC75F0", VA = "0x182EC87F0")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[GDFKOGKEDCG(typeof(KLJOBFNPICE), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	public class PhysicsService : JPLAKHLHFLM, NEGCPFIDGDD, KLJOBFNPICE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly FGEMECIGOCC NJABPNODPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EntityManager PAHBLOLNPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private AEJNGPFNACL BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private EOEMDGEDOLM KNKLCNGOIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PropertyEventCallbacksService PHKLPEIEANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private global::POPOOFGODGI<EHKLCKPLADJ> BABLGCLAIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool LINNMJPFKHN;

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<CGKCPDMKDFM, EHKLCKPLADJ> HPKMHJPJPOM
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x2D313F0", Offset = "0x2D301F0", VA = "0x182D313F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x2D31B40", Offset = "0x2D30940", VA = "0x182D31B40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2D315F0", Offset = "0x2D303F0", VA = "0x182D315F0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2D318A0", Offset = "0x2D306A0", VA = "0x182D318A0", Slot = "5")]
		public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2D31490", Offset = "0x2D30290", VA = "0x182D31490", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2D31710", Offset = "0x2D30510", VA = "0x182D31710", Slot = "8")]
		public bool FFOMGEOAMFK(CGKCPDMKDFM HPLAKDFIDCJ, out Collider GAGPONOIJAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2D317E0", Offset = "0x2D305E0", VA = "0x182D317E0")]
		private void FKLFCIMFIBC(Entity NEAKDKENHHP, DFNAMHCDDIN HEDGDEEAPPO, BDKOOLPOOEA DNEMONMIDEC, BDKOOLPOOEA NCBOBCDAKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2D31BE0", Offset = "0x2D309E0", VA = "0x182D31BE0", Slot = "9")]
		public void JCGCCCNMEBO(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	[GDFKOGKEDCG(typeof(CJPPPCOPNEF), new string[] { })]
	public class RbexService : JPLAKHLHFLM, CJPPPCOPNEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private AEJNGPFNACL EOHGMNFKFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private World BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private CDEJGDBDLCH LHMAKOKFMJF;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private EntityManager CCEKCIJDDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x2D388C0", Offset = "0x2D376C0", VA = "0x182D388C0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2D37740", Offset = "0x2D36540", VA = "0x182D37740", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2D37C70", Offset = "0x2D36A70", VA = "0x182D37C70", Slot = "6")]
		public PGIGMPAIANJ FPOLMHAPJEE(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2D378A0", Offset = "0x2D366A0", VA = "0x182D378A0", Slot = "5")]
		public void EILLKDLPAHO(CGKCPDMKDFM HPLAKDFIDCJ, PGIGMPAIANJ MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2D36FA0", Offset = "0x2D35DA0", VA = "0x182D36FA0", Slot = "34")]
		public CollisionDetectionMode BKODJFDLBKL(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2D37E00", Offset = "0x2D36C00", VA = "0x182D37E00", Slot = "35")]
		public void GBONKAIFOGJ(CGKCPDMKDFM HPLAKDFIDCJ, CollisionDetectionMode MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2D389A0", Offset = "0x2D377A0", VA = "0x182D389A0", Slot = "36")]
		public LKPJABIJCHN IHAIEAKLBHG(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(LKPJABIJCHN);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2D37D60", Offset = "0x2D36B60", VA = "0x182D37D60", Slot = "37")]
		public void GBDBHNCJPIM(CGKCPDMKDFM HPLAKDFIDCJ, LKPJABIJCHN MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2D39230", Offset = "0x2D38030", VA = "0x182D39230", Slot = "38")]
		public bool LPDJIPJPAAK(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2D391C0", Offset = "0x2D37FC0", VA = "0x182D391C0", Slot = "39")]
		public void LMHNBBGHJDL(CGKCPDMKDFM HPLAKDFIDCJ, bool MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2D39590", Offset = "0x2D38390", VA = "0x182D39590", Slot = "40")]
		public CGKCPDMKDFM NLBAAPEIHLL(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2D371E0", Offset = "0x2D35FE0", VA = "0x182D371E0", Slot = "41")]
		public void CEDNCBGHEBM(CGKCPDMKDFM HPLAKDFIDCJ, CGKCPDMKDFM MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2D37F70", Offset = "0x2D36D70", VA = "0x182D37F70", Slot = "42")]
		public CGKCPDMKDFM GDGNMAEBLIK(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2D39140", Offset = "0x2D37F40", VA = "0x182D39140", Slot = "43")]
		public void LHHNBAKNDJK(CGKCPDMKDFM HPLAKDFIDCJ, CGKCPDMKDFM MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2D39290", Offset = "0x2D38090", VA = "0x182D39290", Slot = "7")]
		public void MJIINKEILDI(CGKCPDMKDFM HPLAKDFIDCJ, CGKCPDMKDFM MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2D37A40", Offset = "0x2D36840", VA = "0x182D37A40", Slot = "8")]
		public void FIIMPCEKEOB(CGKCPDMKDFM HPLAKDFIDCJ, CGKCPDMKDFM MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2D39050", Offset = "0x2D37E50", VA = "0x182D39050", Slot = "9")]
		public int LHCEIHOIEFB(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2D37B50", Offset = "0x2D36950", VA = "0x182D37B50", Slot = "10")]
		public CGKCPDMKDFM FLHJGBCLEDO(CGKCPDMKDFM HPLAKDFIDCJ, int NNHNOIMLALG)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2D37950", Offset = "0x2D36750", VA = "0x182D37950", Slot = "11")]
		public void EJNAKCFNMLD(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2D39680", Offset = "0x2D38480", VA = "0x182D39680", Slot = "12")]
		public void OIGNBOHHDGM(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL, CGKCPDMKDFM MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2D36D50", Offset = "0x2D35B50", VA = "0x182D36D50", Slot = "13")]
		public void BBHKOPBALPL(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2D39430", Offset = "0x2D38230", VA = "0x182D39430", Slot = "14")]
		public bool NEOGCBAJHEK(CGKCPDMKDFM HPLAKDFIDCJ, out CGKCPDMKDFM MGFMONLLLPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2D36F20", Offset = "0x2D35D20", VA = "0x182D36F20", Slot = "15")]
		public void BKAJPIACAJF(CGKCPDMKDFM HPLAKDFIDCJ, float3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2D39B90", Offset = "0x2D38990", VA = "0x182D39B90", Slot = "16")]
		public bool PNHEFEFDKKD(CGKCPDMKDFM HPLAKDFIDCJ, out float3 MGFMONLLLPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2D37090", Offset = "0x2D35E90", VA = "0x182D37090", Slot = "17")]
		public void BMNPNINNJHB(CGKCPDMKDFM HPLAKDFIDCJ, float3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2D386D0", Offset = "0x2D374D0", VA = "0x182D386D0", Slot = "18")]
		public bool HKEPEDHDGNP(CGKCPDMKDFM HPLAKDFIDCJ, out float3 MGFMONLLLPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2D36B20", Offset = "0x2D35920", VA = "0x182D36B20", Slot = "26")]
		public float3 AECCPBMIGMB(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2D37820", Offset = "0x2D36620", VA = "0x182D37820", Slot = "27")]
		public void EIBOPOCNLLJ(CGKCPDMKDFM HPLAKDFIDCJ, float3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2D376E0", Offset = "0x2D364E0", VA = "0x182D376E0", Slot = "28")]
		public float DKOFGFOEKAF(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2D37170", Offset = "0x2D35F70", VA = "0x182D37170", Slot = "29")]
		public void BNPMDLAHEAM(CGKCPDMKDFM HPLAKDFIDCJ, float MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2D388E0", Offset = "0x2D376E0", VA = "0x182D388E0", Slot = "30")]
		public float IABJEJNIMBJ(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2D36C80", Offset = "0x2D35A80", VA = "0x182D36C80", Slot = "31")]
		public void AKEMBNFBLOH(CGKCPDMKDFM HPLAKDFIDCJ, float MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2D38F80", Offset = "0x2D37D80", VA = "0x182D38F80", Slot = "32")]
		public bool LAHGNFFMPCG(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2D374B0", Offset = "0x2D362B0", VA = "0x182D374B0", Slot = "33")]
		public void DGOCAGPFOJP(CGKCPDMKDFM HPLAKDFIDCJ, bool MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2D36BA0", Offset = "0x2D359A0", VA = "0x182D36BA0", Slot = "19")]
		public void AFFHMEKPNMJ(CGKCPDMKDFM HPLAKDFIDCJ, float3 MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2D382D0", Offset = "0x2D370D0", VA = "0x182D382D0", Slot = "20")]
		public bool GJLBOFNFFML(CGKCPDMKDFM HPLAKDFIDCJ, out float3 MGFMONLLLPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2D39610", Offset = "0x2D38410", VA = "0x182D39610", Slot = "21")]
		public void NOINBJOBEIK(CGKCPDMKDFM HPLAKDFIDCJ, quaternion MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2D38170", Offset = "0x2D36F70", VA = "0x182D38170", Slot = "22")]
		public bool GHFOBBCGELO(CGKCPDMKDFM HPLAKDFIDCJ, out quaternion MGFMONLLLPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2D39CF0", Offset = "0x2D38AF0", VA = "0x182D39CF0", Slot = "23")]
		public bool PNLFFHJMGMG(CGKCPDMKDFM HPLAKDFIDCJ, out float3 NLBCLPFBGLP, out quaternion FFGINLIODDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2D37260", Offset = "0x2D36060", VA = "0x182D37260", Slot = "44")]
		public MMEDPPALLJF CFMLKLLEEMP(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(MMEDPPALLJF);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2D38660", Offset = "0x2D37460", VA = "0x182D38660", Slot = "45")]
		public void HJPLABJAADL(CGKCPDMKDFM HPLAKDFIDCJ, MMEDPPALLJF MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2D397B0", Offset = "0x2D385B0", VA = "0x182D397B0", Slot = "72")]
		public void OJGHLEHMGNI(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2D38E00", Offset = "0x2D37C00", VA = "0x182D38E00", Slot = "73")]
		public void JPABOFKMOIN(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2D373C0", Offset = "0x2D361C0", VA = "0x182D373C0", Slot = "74")]
		public bool DBGFOECDENL(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2D38EF0", Offset = "0x2D37CF0", VA = "0x182D38EF0", Slot = "81")]
		public void KLPMMIHBLOI(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2D37000", Offset = "0x2D35E00", VA = "0x182D37000", Slot = "82")]
		public void BLEAPHFKDMJ(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2D38D80", Offset = "0x2D37B80", VA = "0x182D38D80", Slot = "83")]
		public bool JOIHHCBPGJK(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2D37E70", Offset = "0x2D36C70", VA = "0x182D37E70", Slot = "84")]
		public IEnumerable<object> GCHOELJACJG(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2D38940", Offset = "0x2D37740", VA = "0x182D38940", Slot = "46")]
		public bool IBKIHOAIDCK(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2D37D00", Offset = "0x2D36B00", VA = "0x182D37D00", Slot = "47")]
		public void FPONDBMEEKF(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2D37520", Offset = "0x2D36320", VA = "0x182D37520", Slot = "48")]
		public bool DHDLAJHEIFO(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2D36EB0", Offset = "0x2D35CB0", VA = "0x182D36EB0", Slot = "49")]
		public void BFMPPIFGAIC(CGKCPDMKDFM HPLAKDFIDCJ, bool MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2D36CF0", Offset = "0x2D35AF0", VA = "0x182D36CF0", Slot = "50")]
		public bool AOEGALIPJMG(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2D38FE0", Offset = "0x2D37DE0", VA = "0x182D38FE0", Slot = "51")]
		public void LGIBAJJHNGB(CGKCPDMKDFM HPLAKDFIDCJ, bool MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2D39B30", Offset = "0x2D38930", VA = "0x182D39B30", Slot = "52")]
		public RigidbodyConstraints PEDLNJGEGNG(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2D38B30", Offset = "0x2D37930", VA = "0x182D38B30", Slot = "53")]
		public void IOMHMPBNPBE(CGKCPDMKDFM HPLAKDFIDCJ, RigidbodyConstraints MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2D36C20", Offset = "0x2D35A20", VA = "0x182D36C20", Slot = "54")]
		public float AJICHEJEJBI(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2D384B0", Offset = "0x2D372B0", VA = "0x182D384B0", Slot = "55")]
		public void HCGLKMCDEJI(CGKCPDMKDFM HPLAKDFIDCJ, float MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2D38520", Offset = "0x2D37320", VA = "0x182D38520", Slot = "56")]
		public float HDBLANBGBBN(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x2D37440", Offset = "0x2D36240", VA = "0x182D37440", Slot = "57")]
		public void DGHMPIDMHKM(CGKCPDMKDFM HPLAKDFIDCJ, float MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2D38110", Offset = "0x2D36F10", VA = "0x182D38110", Slot = "58")]
		public bool GHEAPFNBAJK(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2D399A0", Offset = "0x2D387A0", VA = "0x182D399A0", Slot = "59")]
		public void OPHJIIFKDIJ(CGKCPDMKDFM HPLAKDFIDCJ, bool MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2D38AD0", Offset = "0x2D378D0", VA = "0x182D38AD0", Slot = "60")]
		public bool IOJODNCCGKK(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2D372C0", Offset = "0x2D360C0", VA = "0x182D372C0", Slot = "61")]
		public void CFNMAGJFFPJ(CGKCPDMKDFM HPLAKDFIDCJ, bool MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2D38020", Offset = "0x2D36E20", VA = "0x182D38020", Slot = "62")]
		public int GFCCEOPOECD(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2D38580", Offset = "0x2D37380", VA = "0x182D38580", Slot = "63")]
		public void HGDHLCDGABD(CGKCPDMKDFM HPLAKDFIDCJ, int MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2D393A0", Offset = "0x2D381A0", VA = "0x182D393A0", Slot = "64")]
		public Rigidbody MOIIHBIFIBD(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2D37580", Offset = "0x2D36380", VA = "0x182D37580", Slot = "65")]
		public void DKFPKPHEIHM(CGKCPDMKDFM HPLAKDFIDCJ, Rigidbody MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2D38080", Offset = "0x2D36E80", VA = "0x182D38080", Slot = "75")]
		public void GFCJILGEJFN(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2D37330", Offset = "0x2D36130", VA = "0x182D37330", Slot = "76")]
		public void COBKOODNDCN(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2D38430", Offset = "0x2D37230", VA = "0x182D38430", Slot = "77")]
		public bool HBIEKJJNIPH(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2D38A40", Offset = "0x2D37840", VA = "0x182D38A40", Slot = "66")]
		public object IMPENHFFPBF(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2D39840", Offset = "0x2D38640", VA = "0x182D39840", Slot = "67")]
		public void OMDCEEPMINE(CGKCPDMKDFM HPLAKDFIDCJ, object MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D39A10", Offset = "0x2D38810", VA = "0x182D39A10", Slot = "68")]
		public object PCKJMKICEHK(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2D38C20", Offset = "0x2D37A20", VA = "0x182D38C20", Slot = "69")]
		public void JJEHABIPCCG(CGKCPDMKDFM HPLAKDFIDCJ, object MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2D38E90", Offset = "0x2D37C90", VA = "0x182D38E90", Slot = "70")]
		public float KBHCICABNDJ(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D385F0", Offset = "0x2D373F0", VA = "0x182D385F0", Slot = "71")]
		public void HIOACPIJLIL(CGKCPDMKDFM HPLAKDFIDCJ, float MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D39AA0", Offset = "0x2D388A0", VA = "0x182D39AA0", Slot = "78")]
		public void PEBKACDPMHA(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D38830", Offset = "0x2D37630", VA = "0x182D38830", Slot = "79")]
		public void HMCOOKJLLED(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D38BA0", Offset = "0x2D379A0", VA = "0x182D38BA0", Slot = "80")]
		public bool JFILLALBEGF(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D37110", Offset = "0x2D35F10", VA = "0x182D37110", Slot = "24")]
		public void BNPJBECJLGA(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D39F60", Offset = "0x2D38D60", VA = "0x182D39F60", Slot = "25")]
		public void PPIEGJDHELI(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x30B5EF0", Offset = "0x30B4CF0", VA = "0x1830B5EF0")]
		private void OJJFPDKINNI<T>(CGKCPDMKDFM HPLAKDFIDCJ, bool MGFMONLLLPD) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x30B5E30", Offset = "0x30B4C30", VA = "0x1830B5E30")]
		private bool LIAJOBEJPNK<T>(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x30B51B0", Offset = "0x30B3FB0", VA = "0x1830B51B0")]
		private void CJGLMEKHGBL<T>(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x30B4AE0", Offset = "0x30B38E0", VA = "0x1830B4AE0")]
		private bool BACDOKNGCOB<TC, TV>(CGKCPDMKDFM HPLAKDFIDCJ, Func<TC, TV> OEPNKLLOMPF, out TV MGFMONLLLPD) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x30B4A60", Offset = "0x30B3860", VA = "0x1830B4A60")]
		private bool BACDOKNGCOB<T>(CGKCPDMKDFM HPLAKDFIDCJ, out T MGFMONLLLPD) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x30B5210", Offset = "0x30B4010", VA = "0x1830B5210")]
		private T GHOBHEDDEAP<T>(CGKCPDMKDFM HPLAKDFIDCJ) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x30B4C60", Offset = "0x30B3A60", VA = "0x1830B4C60")]
		private void BMCHEJOOMOF<T>(CGKCPDMKDFM HPLAKDFIDCJ, T MGFMONLLLPD) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x30B57D0", Offset = "0x30B45D0", VA = "0x1830B57D0")]
		private void KFEAONONJPC<T>(CGKCPDMKDFM HPLAKDFIDCJ, T MGFMONLLLPD) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x30B4A60", Offset = "0x30B3860", VA = "0x1830B4A60")]
		private bool OEGEOILLKEH<T>(CGKCPDMKDFM HPLAKDFIDCJ, out T MGFMONLLLPD) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x30B5E90", Offset = "0x30B4C90", VA = "0x1830B5E90")]
		private T OBPEMGIMFDN<T>(CGKCPDMKDFM HPLAKDFIDCJ) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x30B4A60", Offset = "0x30B3860", VA = "0x1830B4A60")]
		private void HFDEPPIAEIP<T>(CGKCPDMKDFM HPLAKDFIDCJ, T MGFMONLLLPD) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x30B5660", Offset = "0x30B4460", VA = "0x1830B5660")]
		private void GMKJJBKBLDA<T>(CGKCPDMKDFM HPLAKDFIDCJ, T MGFMONLLLPD) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D377F0", Offset = "0x2D365F0", VA = "0x182D377F0")]
		private CGKCPDMKDFM ECPBNFGEBJF(Entity NEAKDKENHHP)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D36DE0", Offset = "0x2D35BE0", VA = "0x182D36DE0")]
		private DynamicBuffer<Entity> BCGFPGHJCDH(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x30B5710", Offset = "0x30B4510", VA = "0x1830B5710")]
		private void IJIIIHPBLKE<T>(CGKCPDMKDFM HPLAKDFIDCJ, object MGFMONLLLPD, Func<object, T> OEPNKLLOMPF) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		private void OLEPBNNLDDG<T>(ref global::NAJLOMAKLJC<T> AKILODLIDKE) where T : struct, GIILAPEPKKN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		private void OLEPBNNLDDG<TC, TV>(ref global::MKJONDBJAIE<TC, TV> AKILODLIDKE) where TC : struct, GIILAPEPKKN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
	[GDFKOGKEDCG(typeof(KinematicSleepChangeService), new string[] { })]
	public class KinematicSleepChangeService : JPLAKHLHFLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class NFIDJDKHLLM : IEnumerable<PGIGMPAIANJ>, IEnumerable, IEnumerator<PGIGMPAIANJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private PGIGMPAIANJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public KinematicSleepChangeService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public NativeArray<Entity> <>3__entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private EntityManager <entityManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			private PGIGMPAIANJ System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
			[DebuggerHidden]
			public NFIDJDKHLLM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x44AC010", Offset = "0x44AAE10", VA = "0x1844AC010", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x44ABCD0", Offset = "0x44AAAD0", VA = "0x1844ABCD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x44AC090", Offset = "0x44AAE90", VA = "0x1844AC090")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x44ABFD0", Offset = "0x44AADD0", VA = "0x1844ABFD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x44ABF20", Offset = "0x44AAD20", VA = "0x1844ABF20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PGIGMPAIANJ> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x44ABF20", Offset = "0x44AAD20", VA = "0x1844ABF20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> GILOJGCKOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL EOHGMNFKFFO;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x32B3680", Offset = "0x32B2480", VA = "0x1832B3680", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x32B3410", Offset = "0x32B2210", VA = "0x1832B3410")]
		public void CNEHLAACCBF(NativeArray<Entity> KMDDIGFEEEI, bool ENPGEFMALHP, bool FFAOIOAEDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x32B36D0", Offset = "0x32B24D0", VA = "0x1832B36D0")]
		public void GAMAKJPBCMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x32B2C50", Offset = "0x32B1A50", VA = "0x1832B2C50")]
		private void BPAKNOMIHCM(NativeArray<Entity> KMDDIGFEEEI, bool ENPGEFMALHP, bool FFAOIOAEDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x32B38E0", Offset = "0x32B26E0", VA = "0x1832B38E0")]
		[IteratorStateMachine(typeof(NFIDJDKHLLM))]
		private IEnumerable<PGIGMPAIANJ> OHAMAJBPOGK(NativeArray<Entity> KMDDIGFEEEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x32B3530", Offset = "0x32B2330", VA = "0x1832B3530", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x32B39C0", Offset = "0x32B27C0", VA = "0x1832B39C0")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
[GDFKOGKEDCG(typeof(HJJNHNANFFG), new string[] { })]
public class OMNOBKOIIHA : HJJNHNANFFG, IEnumerable<ANKHGKIKDDO>, IEnumerable, KHEIMMLCGKM, MDEPDIFNFKG, JPLAKHLHFLM, NEGCPFIDGDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[DNEBGGIIGBA]
	private LLKLEKEMMAM PGPGHEAKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<(Type, string), int> JJCLPMKLBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private DNGLBPIAKDE GKNGGGJPNJN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E730", Offset = "0x2D1D530", VA = "0x182D1E730", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public ANKHGKIKDDO BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E330", Offset = "0x2D1D130", VA = "0x182D1E330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public ANKHGKIKDDO BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E330", Offset = "0x2D1D130", VA = "0x182D1E330", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E750", Offset = "0x2D1D550", VA = "0x182D1E750", Slot = "11")]
	public void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E180", Offset = "0x2D1CF80", VA = "0x182D1E180", Slot = "12")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "13")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E430", Offset = "0x2D1D230", VA = "0x182D1E430")]
	private void MFBKCKJKKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x291E920", Offset = "0x291D720", VA = "0x18291E920")]
	private string GALDBEOOIFM(string ICIEGOLHGJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E350", Offset = "0x2D1D150", VA = "0x182D1E350", Slot = "7")]
	public ANKHGKIKDDO IDJJFCHGDEO(NMPGGHIBJDP HANNKCHKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DED0", Offset = "0x2D1CCD0", VA = "0x182D1DED0")]
	private bool DLJEBJIKKFJ(Type CHMGCHLLEJC, string ICIEGOLHGJN, out ANKHGKIKDDO CKFDCLEBNMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E200", Offset = "0x2D1D000", VA = "0x182D1E200", Slot = "8")]
	public DFNAMHCDDIN EMJGNLBFHIP(NMPGGHIBJDP HANNKCHKNMG)
	{
		return default(DFNAMHCDDIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E310", Offset = "0x2D1D110", VA = "0x182D1E310", Slot = "9")]
	public IEnumerator<ANKHGKIKDDO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E310", Offset = "0x2D1D110", VA = "0x182D1E310", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E7A0", Offset = "0x2D1D5A0", VA = "0x182D1E7A0")]
	public OMNOBKOIIHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
[DefaultMember("Item")]
public interface JPOGMFHNGKL
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKCIEOLJNAM(DFNAMHCDDIN LNJCEIMJDGG, out int MKGODNJCKOC);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
[GDFKOGKEDCG(typeof(JPOGMFHNGKL), new string[] { })]
public class IFPMHABPOGI : JPLAKHLHFLM, NEGCPFIDGDD, JPOGMFHNGKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[DNEBGGIIGBA]
	private HLKMGBJJBCF PGPGHEAKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<DFNAMHCDDIN, int> OBGDINGABHF;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x32AAD00", Offset = "0x32A9B00", VA = "0x1832AAD00", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x32AAD60", Offset = "0x32A9B60", VA = "0x1832AAD60", Slot = "6")]
	public bool IKCIEOLJNAM(DFNAMHCDDIN LNJCEIMJDGG, out int MKGODNJCKOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x32AAA20", Offset = "0x32A9820", VA = "0x1832AAA20", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x32AACF0", Offset = "0x32A9AF0", VA = "0x1832AACF0", Slot = "5")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x32AAA80", Offset = "0x32A9880", VA = "0x1832AAA80")]
	private void FJABKKCABLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x32AADD0", Offset = "0x32A9BD0", VA = "0x1832AADD0")]
	public IFPMHABPOGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[GDFKOGKEDCG(typeof(HLKMGBJJBCF), new string[] { })]
[DefaultMember("Item")]
public class HCKDKLEOAPM : HLKMGBJJBCF, IEnumerable<LMCAKPAONGF>, IEnumerable, KHEIMMLCGKM, MDEPDIFNFKG, JPLAKHLHFLM, NEGCPFIDGDD, BJCPCNKDADF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[DNEBGGIIGBA]
	private JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[DNEBGGIIGBA]
	private HJJNHNANFFG PENDBOHJAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private LMCAKPAONGF[] OHFPOPMLCGI;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x32A5C80", Offset = "0x32A4A80", VA = "0x1832A5C80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public LMCAKPAONGF BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x32A5A30", Offset = "0x32A4830", VA = "0x1832A5A30", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LMCAKPAONGF BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x32A5A30", Offset = "0x32A4830", VA = "0x1832A5A30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "10")]
	public void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x32A56C0", Offset = "0x32A44C0", VA = "0x1832A56C0", Slot = "11")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "12")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x32A5B50", Offset = "0x32A4950", VA = "0x1832A5B50", Slot = "6")]
	public LMCAKPAONGF IDJJFCHGDEO(NMPGGHIBJDP HANNKCHKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x32A5960", Offset = "0x32A4760", VA = "0x1832A5960", Slot = "7")]
	public DFNAMHCDDIN EMJGNLBFHIP(NMPGGHIBJDP HANNKCHKNMG)
	{
		return default(DFNAMHCDDIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x32A5A70", Offset = "0x32A4870", VA = "0x1832A5A70", Slot = "8")]
	public IEnumerator<LMCAKPAONGF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x32A5C90", Offset = "0x32A4A90", VA = "0x1832A5C90", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA330", Offset = "0x2AE9130", VA = "0x182AEA330", Slot = "13")]
	public void DDPMFKKJOPK<TKey, T>(global::LFLIGLKEMAN<TKey, T> FHINIKPHPFG, [Optional] object IJBJKIBEJLN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x32A5580", Offset = "0x32A4380", VA = "0x1832A5580", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public HCKDKLEOAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x32A5A30", Offset = "0x32A4830", VA = "0x1832A5A30")]
	[CompilerGenerated]
	private LMCAKPAONGF GCBJMNINBPB(int FCPPLBLBJIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
[GDFKOGKEDCG(typeof(ENDOBGIHNAA), new string[] { })]
public class GIFLOKJFFMF : ENDOBGIHNAA, IEnumerable<AFJNBCJHANB>, IEnumerable, JPLAKHLHFLM, NEGCPFIDGDD, BJCPCNKDADF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[DNEBGGIIGBA]
	private JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[DNEBGGIIGBA]
	private HJJNHNANFFG PENDBOHJAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private AFJNBCJHANB[] OHFPOPMLCGI;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x32A2C40", Offset = "0x32A1A40", VA = "0x1832A2C40", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public AFJNBCJHANB BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x32A2A00", Offset = "0x32A1800", VA = "0x1832A2A00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public AFJNBCJHANB BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x32A2A00", Offset = "0x32A1800", VA = "0x1832A2A00", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x32A2580", Offset = "0x32A1380", VA = "0x1832A2580", Slot = "9")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x32A27A0", Offset = "0x32A15A0", VA = "0x1832A27A0", Slot = "10")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x32A25F0", Offset = "0x32A13F0", VA = "0x1832A25F0")]
	private AFJNBCJHANB EGJHNAAKGIL(int NNHNOIMLALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x32A2B20", Offset = "0x32A1920", VA = "0x1832A2B20", Slot = "6")]
	public AFJNBCJHANB IDJJFCHGDEO(NMPGGHIBJDP HANNKCHKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x32A26D0", Offset = "0x32A14D0", VA = "0x1832A26D0", Slot = "14")]
	public DFNAMHCDDIN EMJGNLBFHIP(NMPGGHIBJDP HANNKCHKNMG)
	{
		return default(DFNAMHCDDIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x32A2A10", Offset = "0x32A1810", VA = "0x1832A2A10", Slot = "7")]
	public IEnumerator<AFJNBCJHANB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x32A2A10", Offset = "0x32A1810", VA = "0x1832A2A10", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2090430", Offset = "0x208F230", VA = "0x182090430", Slot = "11")]
	public void DDPMFKKJOPK<TKey, T>(global::LFLIGLKEMAN<TKey, T> FHINIKPHPFG, [Optional] object IJBJKIBEJLN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x32A24E0", Offset = "0x32A12E0", VA = "0x1832A24E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GIFLOKJFFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x32A2A00", Offset = "0x32A1800", VA = "0x1832A2A00")]
	[CompilerGenerated]
	private AFJNBCJHANB GCBJMNINBPB(int FCPPLBLBJIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[GDFKOGKEDCG(typeof(LLKLEKEMMAM), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
internal class LLKLEKEMMAM : JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private HJJNHNANFFG PENDBOHJAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private ENDOBGIHNAA GNIGOHENNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private HLKMGBJJBCF MFGAIMOCMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private global::LHAHHAJLMCG<LPGGBJGEPLD> HIOCNACBAKI;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public DNGLBPIAKDE CEFJBNGAFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x748BC0", Offset = "0x7479C0", VA = "0x180748BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x32B7050", Offset = "0x32B5E50", VA = "0x1832B7050", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x32B7320", Offset = "0x32B6120", VA = "0x1832B7320")]
	private void NDNCHKEOGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x27D76B0", Offset = "0x27D64B0", VA = "0x1827D76B0")]
	public T OKMANMIJPPH<T>() where T : LPGGBJGEPLD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x32B7180", Offset = "0x32B5F80", VA = "0x1832B7180")]
	public ANKHGKIKDDO GKODOCGPONJ(NMPGGHIBJDP ICIEGOLHGJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	public global::POPOOFGODGI<T> GKODOCGPONJ<T>(NMPGGHIBJDP ICIEGOLHGJN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x32B7250", Offset = "0x32B6050", VA = "0x1832B7250")]
	public AFJNBCJHANB JAFJAEEKMLG(NMPGGHIBJDP ICIEGOLHGJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x27D7630", Offset = "0x27D6430", VA = "0x1827D7630")]
	public global::DONPKNBBDNA<T> JAFJAEEKMLG<T>(NMPGGHIBJDP ICIEGOLHGJN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x32B6F80", Offset = "0x32B5D80", VA = "0x1832B6F80")]
	public LMCAKPAONGF DDBNBPNOCDC(NMPGGHIBJDP ICIEGOLHGJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	public global::LIEGJFFGAMJ<T> DDBNBPNOCDC<T>(NMPGGHIBJDP ICIEGOLHGJN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public LLKLEKEMMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class JJPJPHDHCNE
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x1641E60", Offset = "0x1640C60", VA = "0x181641E60")]
	public static global::POPOOFGODGI<T> GKODOCGPONJ<T>(this LLKLEKEMMAM EOGAOOPCPLC, global::KIEJCGOPPBK<T> ICIEGOLHGJN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	public static global::DONPKNBBDNA<T> JAFJAEEKMLG<T>(this LLKLEKEMMAM EOGAOOPCPLC, global::KIEJCGOPPBK<T> ICIEGOLHGJN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	public static global::LIEGJFFGAMJ<T> DDBNBPNOCDC<T>(this LLKLEKEMMAM EOGAOOPCPLC, global::KIEJCGOPPBK<T> ICIEGOLHGJN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[GDFKOGKEDCG(typeof(KMNKNJIGBHA), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
public class KMNKNJIGBHA : JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private KKIMGPLCJHJ BHBPCKBHHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private DFNAMHCDDIN[] MEPPGNJCMBL;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x32B1FA0", Offset = "0x32B0DA0", VA = "0x1832B1FA0", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x32B2230", Offset = "0x32B1030", VA = "0x1832B2230")]
	public void LCKLIMBFKHN(MFDODOEBKCJ FIIEHBGLOHB, bool MNFDLPFDLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KMNKNJIGBHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[GDFKOGKEDCG(typeof(MPENADLGHGG), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
public sealed class MPENADLGHGG : JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class LECECPJHPFP : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x91D1E0", Offset = "0x91BFE0", VA = "0x18091D1E0")]
		[DebuggerHidden]
		public LECECPJHPFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x44A9170", Offset = "0x44A7F70", VA = "0x1844A9170", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x44A8DC0", Offset = "0x44A7BC0", VA = "0x1844A8DC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x44A91F0", Offset = "0x44A7FF0", VA = "0x1844A91F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x44A9130", Offset = "0x44A7F30", VA = "0x1844A9130", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x44A90A0", Offset = "0x44A7EA0", VA = "0x1844A90A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x44A90A0", Offset = "0x44A7EA0", VA = "0x1844A90A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string CMFFKGBGNCO = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<SerializableGuid, AINGGJIEHEF> KKDDDJIGLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<SerializableGuid> IBAADDEJOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Dictionary<SerializableGuid, GameObject> FHLJIJCKGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private ENDOBGIHNAA PGPGHEAKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private LCLOCHGKNKG BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private LNDAGNKEEKN NOAFOBDAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private DMGDMAGLCAD JKBGMBLHKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private global::FHOFMOODKOK<AINGGJIEHEF> FGCAEGDCBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject EBBHAMHAGBE;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B580", Offset = "0x2D1A380", VA = "0x182D1B580", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1BC60", Offset = "0x2D1AA60", VA = "0x182D1BC60", Slot = "5")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B3E0", Offset = "0x2D1A1E0", VA = "0x182D1B3E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C3B0", Offset = "0x2D1B1B0", VA = "0x182D1C3B0")]
	private void JHMIJBFDMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B830", Offset = "0x2D1A630", VA = "0x182D1B830")]
	internal void FFKPIJBBHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B200", Offset = "0x2D1A000", VA = "0x182D1B200")]
	private void AOPBJNDNBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B100", Offset = "0x2D19F00", VA = "0x182D1B100")]
	private void AHOHEOMPDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2D1BE90", Offset = "0x2D1AC90", VA = "0x182D1BE90")]
	[IteratorStateMachine(typeof(LECECPJHPFP))]
	private IEnumerable<RRCustomPropTag> GBKFOJAFJOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AC80", Offset = "0x2D19A80", VA = "0x182D1AC80")]
	private void AGKKOHNIFLC(CGKCPDMKDFM HPLAKDFIDCJ, in BDKOOLPOOEA BFKCKCENCEE, in BDKOOLPOOEA IJHAJFKAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2D1BEE0", Offset = "0x2D1ACE0", VA = "0x182D1BEE0")]
	private void GLJEDJEGGBC(SerializableGuid AOKEOLFIKCH, GameObject HNLFAAIOFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C020", Offset = "0x2D1AE20", VA = "0x182D1C020")]
	private void IALOOMINNJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B650", Offset = "0x2D1A450", VA = "0x182D1B650")]
	private bool EBNFEGEGGAH(AINGGJIEHEF AHNIBMMIDMH, Transform GANAMHNGMGO, out GameObject DMDACHFLMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C3C0", Offset = "0x2D1B1C0", VA = "0x182D1C3C0")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C410", Offset = "0x2D1B210", VA = "0x182D1C410")]
	public MPENADLGHGG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public SerializableGuid KJKAINKGCBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x7621D0", Offset = "0x760FD0", VA = "0x1807621D0")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2D36A30", Offset = "0x2D35830", VA = "0x182D36A30")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[GDFKOGKEDCG(typeof(OLPDEICJOOC), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
public class OLPDEICJOOC : JPLAKHLHFLM
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private const string GCCPHCJGCFJ = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private SceneService BLHCMMNIILB;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DE40", Offset = "0x2D1CC40", VA = "0x182D1DE40", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public OLPDEICJOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[GDFKOGKEDCG(typeof(MONHNCPCJPO), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
public class MONHNCPCJPO : JPLAKHLHFLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[DNEBGGIIGBA]
	private EnableComponentSystemsInScope OFLNAGHDAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[DNEBGGIIGBA]
	private SceneService BLHCMMNIILB;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2D1ABC0", Offset = "0x2D199C0", VA = "0x182D1ABC0", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB80", Offset = "0x2D19980", VA = "0x182D1AB80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AC60", Offset = "0x2D19A60", VA = "0x182D1AC60")]
	private void NDOHLIABOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AC30", Offset = "0x2D19A30", VA = "0x182D1AC30")]
	private void HLLKAOEOCHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MONHNCPCJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[GDFKOGKEDCG(typeof(OOMOONHDGPN), new string[] { })]
public class CFDGAEBEFAM : JPLAKHLHFLM, NEGCPFIDGDD, OOMOONHDGPN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private OOHEIMOEIOG IALAEABLGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private PEBHGNNKPLN FKMEODPLBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PropertyEventCallbacksService PHKLPEIEANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private LocalPlayerScopeSystem HGLMNMDKIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private int PMHIOAJCFKI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool FCGHIIIEEME
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB4F0", Offset = "0x2EBA2F0", VA = "0x182EBB4F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CGKCPDMKDFM FJLGFAFIHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB2C0", Offset = "0x2EBA0C0", VA = "0x182EBB2C0", Slot = "9")]
		get
		{
			return default(CGKCPDMKDFM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2EBAEE0", Offset = "0x2EB9CE0", VA = "0x182EBAEE0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public EGBCNCKGEND GJLOKCDADCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB3A0", Offset = "0x2EBA1A0", VA = "0x182EBB3A0", Slot = "11")]
		get
		{
			return default(EGBCNCKGEND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2EBAEE0", Offset = "0x2EB9CE0", VA = "0x182EBAEE0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public EGBCNCKGEND CHFCBJDIIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB3F0", Offset = "0x2EBA1F0", VA = "0x182EBB3F0", Slot = "13")]
		get
		{
			return default(EGBCNCKGEND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint AHGMMCNDKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB440", Offset = "0x2EBA240", VA = "0x182EBB440")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LAGBNMCLHLF MDJPCEPGALH
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2EBB120", Offset = "0x2EB9F20", VA = "0x182EBB120", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA6C0", Offset = "0x2EB94C0", VA = "0x182EBA6C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2EBACB0", Offset = "0x2EB9AB0", VA = "0x182EBACB0", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2EBAF80", Offset = "0x2EB9D80", VA = "0x182EBAF80", Slot = "5")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2EBAC00", Offset = "0x2EB9A00", VA = "0x182EBAC00", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA760", Offset = "0x2EB9560", VA = "0x182EBA760")]
	private void DDNBELJJLGK(Entity NEAKDKENHHP, DFNAMHCDDIN HEDGDEEAPPO, BDKOOLPOOEA DNEMONMIDEC, BDKOOLPOOEA NCBOBCDAKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2EBAAF0", Offset = "0x2EB98F0", VA = "0x182EBAAF0", Slot = "14")]
	public CGKCPDMKDFM DNIGCLHPCNL(CGKCPDMKDFM BFHFOJLNIBJ, CGKCPDMKDFM LCOPPMGLLED)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB1C0", Offset = "0x2EB9FC0", VA = "0x182EBB1C0", Slot = "15")]
	public bool HHABHMMJHLE(CGKCPDMKDFM BFHFOJLNIBJ, CGKCPDMKDFM LCOPPMGLLED, out CGKCPDMKDFM AMDBLMMBPFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA960", Offset = "0x2EB9760", VA = "0x182EBA960", Slot = "16")]
	public void DGEPGKJGCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB300", Offset = "0x2EBA100", VA = "0x182EBB300", Slot = "17")]
	public void IOPLOPLPDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2EBAD80", Offset = "0x2EB9B80", VA = "0x182EBAD80", Slot = "18")]
	public bool EKGKDICOBMP(CGKCPDMKDFM ONDHOAIGIEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2EBAEE0", Offset = "0x2EB9CE0", VA = "0x182EBAEE0")]
	private void FJNFMNHHDCP(CGKCPDMKDFM OJEDBADBCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public CFDGAEBEFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[GDFKOGKEDCG(typeof(OHCNDJAHENC), new string[] { })]
public class ACOFFBNGDJD : JPLAKHLHFLM, OHCNDJAHENC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EntityManager PAHBLOLNPLD;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4B30", Offset = "0x2EB3930", VA = "0x182EB4B30", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4BB0", Offset = "0x2EB39B0", VA = "0x182EB4BB0", Slot = "5")]
	public void MPCOICPDFEJ(CGKCPDMKDFM BMINGOEPCBN, bool MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x22E9250", Offset = "0x22E8050", VA = "0x1822E9250")]
	private void KKNDJJJFEOO<T>(CGKCPDMKDFM BMINGOEPCBN, bool MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public ACOFFBNGDJD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[GDFKOGKEDCG(typeof(CKKNHKEKJPE), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.RenderEffects)]
	public class SelectionService : JPLAKHLHFLM, CKKNHKEKJPE
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EntityManager PAHBLOLNPLD;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF520", Offset = "0x2FDE320", VA = "0x182FDF520", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF4B0", Offset = "0x2FDE2B0", VA = "0x182FDF4B0", Slot = "5")]
		public void BLNNCABNMID(CGKCPDMKDFM BMINGOEPCBN, bool MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF5A0", Offset = "0x2FDE3A0", VA = "0x182FDF5A0", Slot = "6")]
		public void HCEOIGAOIOC(CGKCPDMKDFM BMINGOEPCBN, bool MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x22E9250", Offset = "0x22E8050", VA = "0x1822E9250")]
		private void KKNDJJJFEOO<T>(CGKCPDMKDFM BMINGOEPCBN, bool MGFMONLLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
[GDFKOGKEDCG(typeof(IPHCLIDGNNC), new string[] { })]
internal sealed class IPHCLIDGNNC : JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[DNEBGGIIGBA]
	private ObjectEmbodimentService FNEHIFGGEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[DNEBGGIIGBA]
	private AEJNGPFNACL EOHGMNFKFFO;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x32AC340", Offset = "0x32AB140", VA = "0x1832AC340", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public IPHCLIDGNNC()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[DKGMECGHCPI(OJBFOICGDOF.Serialization)]
	[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
	[GDFKOGKEDCG(typeof(WorldSerialization), new string[] { })]
	internal sealed class WorldSerialization : JPLAKHLHFLM, BPGFDLNBIPE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly FGEMECIGOCC EKBOKAGOJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[DNEBGGIIGBA]
		private LPJCNLHLDJN HJLGKIBBEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[DNEBGGIIGBA]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[DNEBGGIIGBA]
		private SerializationService NOAFOBDAJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[DNEBGGIIGBA]
		private DOIIJCEPMEC NKBLKEDOMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[DNEBGGIIGBA]
		private DebugWorldsService GFJDCKLGMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[DNEBGGIIGBA]
		private BulkInstantiateSceneObjectService IOMEGNIFPHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private LKAAGIKDPMH MENEIDJFFEP;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private HPJPPBPFICL KMGHEIGLPDD
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xCB9330", Offset = "0xCB8130", VA = "0x180CB9330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4C00", Offset = "0x2FF3A00", VA = "0x182FF4C00", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH DNECIEEJBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2FF48F0", Offset = "0x2FF36F0", VA = "0x182FF48F0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4E80", Offset = "0x2FF3C80", VA = "0x182FF4E80", Slot = "6")]
		public bool NINHKAEDKHJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4E10", Offset = "0x2FF3C10", VA = "0x182FF4E10", Slot = "7")]
		public bool HHGKICFEKFM(IEnumerable<HMBPFBEHPFM> GILIMMAGMGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4460", Offset = "0x2FF3260", VA = "0x182FF4460", Slot = "5")]
		public ByteString DDEFMFGIGDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4DF0", Offset = "0x2FF3BF0", VA = "0x182FF4DF0")]
		private void ENGHNEOMKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4FE0", Offset = "0x2FF3DE0", VA = "0x182FF4FE0")]
		private void OCAOMNIMMLO(NNJPEODGOHC ODEHDAALPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2FF3F80", Offset = "0x2FF2D80", VA = "0x182FF3F80")]
		private void AGKAJOPCGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4920", Offset = "0x2FF3720", VA = "0x182FF4920")]
		private void EBCJIMKKAID(BINGFNLPMDN ODEHDAALPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4E30", Offset = "0x2FF3C30", VA = "0x182FF4E30", Slot = "8")]
		public void LLHAFDOBLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4D50", Offset = "0x2FF3B50", VA = "0x182FF4D50")]
		private NNJPEODGOHC EMJPPMAMGND(EntityManager DLLFCONCAGH, EntityManager KCCDGHKNKMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[GDFKOGKEDCG(typeof(EHGBCFBLOFM), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
public class EHGBCFBLOFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly Dictionary<ENALNDEOHNF, string> HPIBAEBMICI;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0ED0", Offset = "0x2ECFCD0", VA = "0x182ED0ED0")]
	public GameObject GBJGCIHCJAO(ENALNDEOHNF AEHKNGCNMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0FA0", Offset = "0x2ECFDA0", VA = "0x182ED0FA0")]
	public EHGBCFBLOFM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[GDFKOGKEDCG(typeof(TimeService), new string[] { })]
	public class TimeService : MDEPDIFNFKG, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[DNEBGGIIGBA]
		private SingletonComponentService CJKBFPKOMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool GIEPEOIBIEC;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TimeData JALBNKJHGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x2FE6F50", Offset = "0x2FE5D50", VA = "0x182FE6F50")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x2FE6ED0", Offset = "0x2FE5CD0", VA = "0x182FE6ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool ENLCBFPHEBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x75BA60", Offset = "0x75A860", VA = "0x18075BA60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x77D190", Offset = "0x77BF90", VA = "0x18077D190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x23C9510", Offset = "0x23C8310", VA = "0x1823C9510", Slot = "4")]
		public void NIACEKGLEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2FE6E80", Offset = "0x2FE5C80", VA = "0x182FE6E80", Slot = "5")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2FE6DC0", Offset = "0x2FE5BC0", VA = "0x182FE6DC0")]
		public void BKKHBAPNEIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[DKGMECGHCPI(OJBFOICGDOF.TransformSyncing)]
	[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
	[GDFKOGKEDCG(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	internal class SetTransformParentIfParentPropertyChanges : JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private EOKNELNBMBB LPMGOCJAKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private global::POPOOFGODGI<Entity> GANAMHNGMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ObjectEmbodimentService DPEPLNEHLIL;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2FE0", Offset = "0x2FE1DE0", VA = "0x182FE2FE0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3050", Offset = "0x2FE1E50", VA = "0x182FE3050", Slot = "5")]
		public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2F40", Offset = "0x2FE1D40", VA = "0x182FE2F40", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3180", Offset = "0x2FE1F80", VA = "0x182FE3180")]
		private void MCKJHABPNKP(Entity NEAKDKENHHP, in BDKOOLPOOEA BFKCKCENCEE, in BDKOOLPOOEA IJHAJFKAPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[DKGMECGHCPI(OJBFOICGDOF.Services)]
	[GDFKOGKEDCG(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
	public class EnableTransmissionOnlyInLoadInstance : JPLAKHLHFLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[DNEBGGIIGBA]
		private HMBGMNAKOHP LJCKIACCBLC;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private GMFKNDIEPLG JIFKCECPMNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x3299810", Offset = "0x3298610", VA = "0x183299810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private GPEMIIIBCHK EDEJNGOCKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x3299860", Offset = "0x3298660", VA = "0x183299860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x3299790", Offset = "0x3298590", VA = "0x183299790", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x3299770", Offset = "0x3298570", VA = "0x183299770", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[GDFKOGKEDCG(typeof(BOAAKIFNFPH), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
public class BOAAKIFNFPH : KDIIDKDLOKO, KHEIMMLCGKM, MDEPDIFNFKG, JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class CBBLGCKCNLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public LKAAGIKDPMH services;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CBBLGCKCNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8F90", Offset = "0x2FD7D90", VA = "0x182FD8F90")]
		internal void <InitReferences>b__0(JPLAKHLHFLM svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class BFAKNJIIANM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public LKAAGIKDPMH services;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BFAKNJIIANM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8F30", Offset = "0x2FD7D30", VA = "0x182FD8F30")]
		internal void <InitExternal>b__0(NEGCPFIDGDD svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[DNEBGGIIGBA]
	private AEJNGPFNACL EOHGMNFKFFO;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CNDIDONCODC IHCFCPOGFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x995790", Offset = "0x994590", VA = "0x180995790", Slot = "4")]
		get
		{
			return default(CNDIDONCODC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private MKGAEINCAIG CADGIMEBGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8480", Offset = "0x2EB7280", VA = "0x182EB8480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8300", Offset = "0x2EB7100", VA = "0x182EB8300", Slot = "5")]
	public void HDEKFDKFOAD(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8350", Offset = "0x2EB7150", VA = "0x182EB8350", Slot = "6")]
	public void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8140", Offset = "0x2EB6F40", VA = "0x182EB8140", Slot = "7")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8220", Offset = "0x2EB7020", VA = "0x182EB8220", Slot = "8")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2EB8010", Offset = "0x2EB6E10", VA = "0x182EB8010", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2664720", Offset = "0x2663520", VA = "0x182664720")]
	private void DKJLMPMCOIE<T>(Action<T> EDBFNCDKMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BOAAKIFNFPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class OBNHGGECPBC<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly Func<From, To> MHLJONEJJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly Func<To, From> OKLGNGGDDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public DynamicBuffer<From> MMBEBPNKEHD;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool JBDIBAAJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	public OBNHGGECPBC(Func<From, To> MHLJONEJJLC, Func<To, From> OKLGNGGDDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] PALKODKBAJM, int NBMFMGFDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To PIBOOIGHJBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int NNHNOIMLALG, To PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public class HGMJPGIHAMK<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<From, To> MHLJONEJJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Func<To, From> OKLGNGGDDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public List<From> MPMKGFKPBEN;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x35DB8C0", Offset = "0x35DA6C0", VA = "0x1835DB8C0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x35DB920", Offset = "0x35DA720", VA = "0x1835DB920", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x35DB890", Offset = "0x35DA690", VA = "0x1835DB890", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool JBDIBAAJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x849670", Offset = "0x848470", VA = "0x180849670", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x812860", Offset = "0x811660", VA = "0x180812860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x35DB800", Offset = "0x35DA600", VA = "0x1835DB800")]
	public HGMJPGIHAMK(Func<From, To> MHLJONEJJLC, Func<To, From> OKLGNGGDDCE, bool CCJDKCIDKAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x35DB450", Offset = "0x35DA250", VA = "0x1835DB450", Slot = "11")]
	public void Add(To PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x31B0A20", Offset = "0x31AF820", VA = "0x1831B0A20", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x35DB4B0", Offset = "0x35DA2B0", VA = "0x1835DB4B0", Slot = "13")]
	public bool Contains(To PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x35DB510", Offset = "0x35DA310", VA = "0x1835DB510", Slot = "14")]
	public void CopyTo(To[] PALKODKBAJM, int NBMFMGFDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x35DB620", Offset = "0x35DA420", VA = "0x1835DB620", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x35DB690", Offset = "0x35DA490", VA = "0x1835DB690", Slot = "6")]
	public int IndexOf(To PIBOOIGHJBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x35DB6F0", Offset = "0x35DA4F0", VA = "0x1835DB6F0", Slot = "7")]
	public void Insert(int NNHNOIMLALG, To PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x35DB7A0", Offset = "0x35DA5A0", VA = "0x1835DB7A0", Slot = "15")]
	public bool Remove(To PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x35DB770", Offset = "0x35DA570", VA = "0x1835DB770", Slot = "8")]
	public void RemoveAt(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x30DAB40", Offset = "0x30D9940", VA = "0x1830DAB40", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DefaultMember("Item")]
public class GLIGGMJGACO<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Func<From, To> MHLJONEJJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly Func<To, From> OKLGNGGDDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<From> PALKODKBAJM;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x38BDEB0", Offset = "0x38BCCB0", VA = "0x1838BDEB0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x38BDF00", Offset = "0x38BCD00", VA = "0x1838BDF00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x38BDE70", Offset = "0x38BCC70", VA = "0x1838BDE70", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool JBDIBAAJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x25DF2E0", Offset = "0x25DE0E0", VA = "0x1825DF2E0")]
	public GLIGGMJGACO(Func<From, To> MHLJONEJJLC, Func<To, From> OKLGNGGDDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x38BDA80", Offset = "0x38BC880", VA = "0x1838BDA80", Slot = "11")]
	public void Add(To PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x38BDAC0", Offset = "0x38BC8C0", VA = "0x1838BDAC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x38BDB00", Offset = "0x38BC900", VA = "0x1838BDB00", Slot = "13")]
	public bool Contains(To PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x38BDBC0", Offset = "0x38BC9C0", VA = "0x1838BDBC0", Slot = "14")]
	public void CopyTo(To[] PALKODKBAJM, int NBMFMGFDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x38BDC80", Offset = "0x38BCA80", VA = "0x1838BDC80", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x38BDD40", Offset = "0x38BCB40", VA = "0x1838BDD40", Slot = "6")]
	public int IndexOf(To PIBOOIGHJBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x38BDDB0", Offset = "0x38BCBB0", VA = "0x1838BDDB0", Slot = "7")]
	public void Insert(int NNHNOIMLALG, To PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x38BDE30", Offset = "0x38BCC30", VA = "0x1838BDE30", Slot = "15")]
	public bool Remove(To PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x38BDDF0", Offset = "0x38BCBF0", VA = "0x1838BDDF0", Slot = "8")]
	public void RemoveAt(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x25647D0", Offset = "0x25635D0", VA = "0x1825647D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public class FJJMICGOEIL<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly Func<From, To> MHLJONEJJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly Func<To, From> OKLGNGGDDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeList<From> MPMKGFKPBEN;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public To BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool JBDIBAAJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	public FJJMICGOEIL(Func<From, To> MHLJONEJJLC, Func<To, From> OKLGNGGDDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] PALKODKBAJM, int NBMFMGFDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To PIBOOIGHJBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int NNHNOIMLALG, To PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class FOPAKLABDBJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public const string BODHLLOACOD = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public const string JFEJFIJFLGJ = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const string HPEOOPGFLKH = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public const string OIJDCFHCODC = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const string LEPGJCDPIPJ = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public const string HBOKPFBNHKD = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public const string COMOBJMMNCM = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public const string EKKLFFKPKOL = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class NNLNBFKDIGB
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class PPBMOENOHLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public LKAAGIKDPMH services;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PPBMOENOHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x44ADAF0", Offset = "0x44AC8F0", VA = "0x1844ADAF0")]
		internal void <InitServices>b__1(JPLAKHLHFLM svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x44ADB50", Offset = "0x44AC950", VA = "0x1844ADB50")]
		internal void <InitServices>b__2(NEGCPFIDGDD svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D000", Offset = "0x2D1BE00", VA = "0x182D1D000")]
	public static void BANNIICCBHN(this MKGAEINCAIG BFCIPJDFKAG, LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x3492110", Offset = "0x3490F10", VA = "0x183492110")]
	public static void DKJLMPMCOIE<T>(this MKGAEINCAIG BFCIPJDFKAG, Action<T> EDBFNCDKMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x3492750", Offset = "0x3491550", VA = "0x183492750")]
	public static void KJPNNHHGMAO<T>(this MKGAEINCAIG BFCIPJDFKAG, Action<T> EDBFNCDKMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x34923F0", Offset = "0x34911F0", VA = "0x1834923F0")]
	public static void FNJJLDKJNFB<T>(this MKGAEINCAIG BFCIPJDFKAG, Action<T> EDBFNCDKMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x3492240", Offset = "0x3491040", VA = "0x183492240")]
	public static void FEFPIIEADJO<T>(this MKGAEINCAIG BFCIPJDFKAG, Action<T> EDBFNCDKMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x34925A0", Offset = "0x34913A0", VA = "0x1834925A0")]
	public static void HPIDBFOPHKA<T>(this MKGAEINCAIG BFCIPJDFKAG, Action<T> EDBFNCDKMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x34928F0", Offset = "0x34916F0", VA = "0x1834928F0")]
	public static void KJPNNHHGMAO<T>(IEnumerable<ComponentSystemBase> POEIPOGPNCF, Action<T> EDBFNCDKMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x3492180", Offset = "0x3490F80", VA = "0x183492180")]
	private static void FDMEABCFLKE<T>(object BAHPOEMJAPG, Action<T> EDBFNCDKMKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class KMDOBCNMGJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class EJGGECGKNIM
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1F30", Offset = "0x2ED0D30", VA = "0x182ED1F30")]
	public static void IHPJBGANHFJ(ComponentSystemBase BAHPOEMJAPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class AHONMDMOOID
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	public static bool MIMFCAIIKEF<T>(ref T GCKGDDMIIDO, ref T EJKHFJILHAC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class HBCKNGGPHBE
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class EMPMFNNOKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public EMPMFNNOKKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x32A49F0", Offset = "0x32A37F0", VA = "0x1832A49F0")]
	public static string DJKAHNCAGAG(Transform KGHIPKNMKHP, Transform ONDHOAIGIEB)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[DKGMECGHCPI(OJBFOICGDOF.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2FE1D10", Offset = "0x2FE0B10", VA = "0x182FE1D10")]
		public static void BBOGNFJPIAG(this MEALJBAKAEI MENEIDJFFEP, HLDHFLCELPP AAPGBKEJGGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2570", Offset = "0x2FE1370", VA = "0x182FE2570")]
		public static void MAPENLMEICJ(this MEALJBAKAEI MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2FE1F40", Offset = "0x2FE0D40", VA = "0x182FE1F40")]
		public static void BBOGNFJPIAG(this MEALJBAKAEI MENEIDJFFEP, [Optional] string[] KAJJNIFLJGL, [Optional] string[] JNEMMFECJJF, [Optional] string[] GBKAOMMDNDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2100", Offset = "0x2FE0F00", VA = "0x182FE2100")]
		public static void HKGGBFFAAHC(this MEALJBAKAEI MENEIDJFFEP, params string[] IMLMDNOCIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2050", Offset = "0x2FE0E50", VA = "0x182FE2050")]
		public static void DMGFFFAIDKF(this MEALJBAKAEI MENEIDJFFEP, params string[] IMLMDNOCIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2FE21B0", Offset = "0x2FE0FB0", VA = "0x182FE21B0")]
		private static string[] IMJHDNABLFC(HLDHFLCELPP AAPGBKEJGGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2FE23B0", Offset = "0x2FE11B0", VA = "0x182FE23B0")]
		private static bool KEJKKHFMADA(HLDHFLCELPP AAPGBKEJGGC, out string[] MDAMLCEGCPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330")]
		private static bool MFEAJJKKJCI()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class AKCDGIOFFOC : ANINIJFPHEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly MethodInfo FHACICPNGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Type[] CFGJGLPAHFD;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4F10", Offset = "0x2EB3D10", VA = "0x182EB4F10")]
	public AKCDGIOFFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action MKENENCFMMN();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4ED0", Offset = "0x2EB3CD0", VA = "0x182EB4ED0")]
	public MethodInfo IHEHLCHJHHB(Action JBJAGOLOBKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4D20", Offset = "0x2EB3B20", VA = "0x182EB4D20", Slot = "4")]
	public void GLJEDJEGGBC(Type LEDIIMFEFLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class KHBMCGJPJAF : AKCDGIOFFOC
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum JEMLEKPBJON
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x32B1170", Offset = "0x32AFF70", VA = "0x1832B1170", Slot = "5")]
	public override Action MKENENCFMMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void FGEHGDGKGLA<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x32B10E0", Offset = "0x32AFEE0", VA = "0x1832B10E0")]
	[Preserve]
	public void JCKCLBCKLPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x329D620", Offset = "0x329C420", VA = "0x18329D620")]
	protected KHBMCGJPJAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class GFFLMPEPEPD : AKCDGIOFFOC
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x32A1960", Offset = "0x32A0760", VA = "0x1832A1960", Slot = "5")]
	public override Action MKENENCFMMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void PDPACGCGIND<T>() where T : BDKNOJCPHDD;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x32A18D0", Offset = "0x32A06D0", VA = "0x1832A18D0")]
	[Preserve]
	public void JCKCLBCKLPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x329D620", Offset = "0x329C420", VA = "0x18329D620")]
	protected GFFLMPEPEPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class FEEMJLDFEFM : AKCDGIOFFOC
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x329D590", Offset = "0x329C390", VA = "0x18329D590", Slot = "5")]
	public override Action MKENENCFMMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void KGEABFBNIFE<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x329D500", Offset = "0x329C300", VA = "0x18329D500")]
	[Preserve]
	public void JCKCLBCKLPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x329D620", Offset = "0x329C420", VA = "0x18329D620")]
	protected FEEMJLDFEFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class IGIMFONMLEO
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x32AAE50", Offset = "0x32A9C50", VA = "0x1832AAE50")]
	public static Entity NIECBJGBLJJ(this EntityManager PAHBLOLNPLD)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[DKGMECGHCPI(OJBFOICGDOF.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class ICOFHEKJANK : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000625")]
				[Cpp2IlInjected.Address(RVA = "0x2355F70", Offset = "0x2354D70", VA = "0x182355F70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000627")]
				[Cpp2IlInjected.Address(RVA = "0x44A7BF0", Offset = "0x44A69F0", VA = "0x1844A7BF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9900", Offset = "0x2FD8700", VA = "0x182FD9900")]
			[DebuggerHidden]
			public ICOFHEKJANK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x44A7A20", Offset = "0x44A6820", VA = "0x1844A7A20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x44A7BB0", Offset = "0x44A69B0", VA = "0x1844A7BB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x44A7B00", Offset = "0x44A6900", VA = "0x1844A7B00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x44A7B00", Offset = "0x44A6900", VA = "0x1844A7B00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class GEBEMEPNAGB : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private IEnumerator<Entity> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600062E")]
				[Cpp2IlInjected.Address(RVA = "0x2355F70", Offset = "0x2354D70", VA = "0x182355F70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000630")]
				[Cpp2IlInjected.Address(RVA = "0x2FD97D0", Offset = "0x2FD85D0", VA = "0x182FD97D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9900", Offset = "0x2FD8700", VA = "0x182FD9900")]
			[DebuggerHidden]
			public GEBEMEPNAGB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9820", Offset = "0x2FD8620", VA = "0x182FD9820", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x2FD94F0", Offset = "0x2FD82F0", VA = "0x182FD94F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x2FD98B0", Offset = "0x2FD86B0", VA = "0x182FD98B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9790", Offset = "0x2FD8590", VA = "0x182FD9790", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x2FD96E0", Offset = "0x2FD84E0", VA = "0x182FD96E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x2FD96E0", Offset = "0x2FD84E0", VA = "0x182FD96E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class PEABPJAJGON : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			private ChildrenData <childData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			private IEnumerator<Entity> <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000638")]
				[Cpp2IlInjected.Address(RVA = "0x2355F70", Offset = "0x2354D70", VA = "0x182355F70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600063A")]
				[Cpp2IlInjected.Address(RVA = "0x44AD2C0", Offset = "0x44AC0C0", VA = "0x1844AD2C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9900", Offset = "0x2FD8700", VA = "0x182FD9900")]
			[DebuggerHidden]
			public PEABPJAJGON(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x44AD310", Offset = "0x44AC110", VA = "0x1844AD310", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x44ACD70", Offset = "0x44ABB70", VA = "0x1844ACD70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x44AD3E0", Offset = "0x44AC1E0", VA = "0x1844AD3E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x44AD430", Offset = "0x44AC230", VA = "0x1844AD430")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x44AD280", Offset = "0x44AC080", VA = "0x1844AD280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x44AD1E0", Offset = "0x44ABFE0", VA = "0x1844AD1E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x44AD1E0", Offset = "0x44ABFE0", VA = "0x1844AD1E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x329C4B0", Offset = "0x329B2B0", VA = "0x18329C4B0")]
		public static Entity CMEIMJNHMIK(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x329CD10", Offset = "0x329BB10", VA = "0x18329CD10")]
		public static DynamicBuffer<ChildrenData> JLIAKMMGBDP(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x329C040", Offset = "0x329AE40", VA = "0x18329C040")]
		public static DynamicBuffer<ChildrenData> APMBAHJDKJP(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x329C250", Offset = "0x329B050", VA = "0x18329C250")]
		public static NativeArray<Entity> CIIIBGOOODL(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, Allocator MBJMPHBLMBF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x329CDA0", Offset = "0x329BBA0", VA = "0x18329CDA0")]
		public static bool KCJLKJPCMME(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, Allocator MBJMPHBLMBF, out NativeArray<Entity> EHPKHANNOFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x329D040", Offset = "0x329BE40", VA = "0x18329D040")]
		public static NativeArray<Entity> MFBLFDBKDLC(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x329C6E0", Offset = "0x329B4E0", VA = "0x18329C6E0")]
		public static Entity FLHJGBCLEDO(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, int NNHNOIMLALG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x329CEA0", Offset = "0x329BCA0", VA = "0x18329CEA0")]
		public static int LHCEIHOIEFB(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x329BBD0", Offset = "0x329A9D0", VA = "0x18329BBD0")]
		public static void ABHDCCPILEJ(NativeArray<Entity> ODLKGBFEGFG, NativeArray<Entity> NFHDJMINDPN, EntityManager PAHBLOLNPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x329C400", Offset = "0x329B200", VA = "0x18329C400")]
		public static int CLFGDNIPEMP(this EntityManager PAHBLOLNPLD, Entity GANAMHNGMGO, Entity LDCHDOICMMM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x329C9B0", Offset = "0x329B7B0", VA = "0x18329C9B0")]
		public static bool IEKAEDOCFHK(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, Entity DEKNDEIHCLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x329C520", Offset = "0x329B320", VA = "0x18329C520")]
		public static IEnumerable<Entity> DOLFPEHJDDA(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, bool JCJOHJLDEGL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x329C630", Offset = "0x329B430", VA = "0x18329C630")]
		public static bool FHDFBCILAKL(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, Entity LDCHDOICMMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x329C380", Offset = "0x329B180", VA = "0x18329C380")]
		public static bool CKLEPDHPDLB(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, Entity BFHFOJLNIBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x329BE30", Offset = "0x329AC30", VA = "0x18329BE30")]
		public static NativeList<Entity> AOKPBDNFLEC(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, bool JCJOHJLDEGL = false, Allocator MBJMPHBLMBF = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x329CB10", Offset = "0x329B910", VA = "0x18329CB10")]
		public static IEnumerable<Entity> IFCFIKDPHDL(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, bool JCJOHJLDEGL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x329D280", Offset = "0x329C080", VA = "0x18329D280")]
		public static Entity NLBAAPEIHLL(this EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x329C810", Offset = "0x329B610", VA = "0x18329C810")]
		public static bool HHABHMMJHLE(this EntityManager PAHBLOLNPLD, Entity BFHFOJLNIBJ, Entity LCOPPMGLLED, out Entity AMDBLMMBPFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x329C0D0", Offset = "0x329AED0", VA = "0x18329C0D0")]
		internal static void BKECGNHHJMC(EntityManager PAHBLOLNPLD, Entity GANAMHNGMGO, Entity LDCHDOICMMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x329C150", Offset = "0x329AF50", VA = "0x18329C150")]
		internal static void CEDNCKGECBM(EntityManager PAHBLOLNPLD, Entity GANAMHNGMGO, Entity LDCHDOICMMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x329D380", Offset = "0x329C180", VA = "0x18329D380")]
		[IteratorStateMachine(typeof(ICOFHEKJANK))]
		private static IEnumerable<Entity> PIJEOCFMKNF(EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, bool JCJOHJLDEGL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x329CFB0", Offset = "0x329BDB0", VA = "0x18329CFB0")]
		[IteratorStateMachine(typeof(GEBEMEPNAGB))]
		private static IEnumerable<Entity> LPJIILPLHLO(EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, bool JCJOHJLDEGL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x329CC90", Offset = "0x329BA90", VA = "0x18329CC90")]
		[IteratorStateMachine(typeof(PEABPJAJGON))]
		private static IEnumerable<Entity> JJPPEEEJKIC(EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x329D1A0", Offset = "0x329BFA0", VA = "0x18329D1A0")]
		private static bool MLGPOEIBLFN(EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, Entity DEKNDEIHCLP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[GDFKOGKEDCG(typeof(AFJJBHJMGFE), new string[] { })]
public class GEIBDHNCGHO : AFJJBHJMGFE, KDIIDKDLOKO, BDCEBKAEALJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private LKAAGIKDPMH MENEIDJFFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private LCLOCHGKNKG BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private LPJCNLHLDJN HJLGKIBBEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private OANGJKKDDJL ILNHBFHICOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private OOHEIMOEIOG IALAEABLGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private EOKNELNBMBB LPMGOCJAKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private CJEAPPIFFGL NOAFOBDAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private KBEAAEAADAB BDBMDABLPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private ENDOBGIHNAA PGPGHEAKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private KOFIEJCNABD NHJGHECGOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private IKOGKFOOIAD PDMOGKMJNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private OOMOONHDGPN NAHLJGLOPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private LDOPIEJCCFG CBNHCPJLDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private KLJOBFNPICE IEMNADHGDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private OHCNDJAHENC BDDIDGFOMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private CKKNHKEKJPE NEMEEDIDKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private AEFBGNMHCNF CFNGNMIKNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private AAKKHKDJDBI JDLHADAKLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private CJPPPCOPNEF GACMGMIMIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public LKAAGIKDPMH MFKBNBOKJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public LCLOCHGKNKG DFBAGBDEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public AEJNGPFNACL CADGIMEBGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public LPJCNLHLDJN AELEKEFNLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public OANGJKKDDJL NDNILNONBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public JCAPLMJKCDN DHCMMAHEOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public OOHEIMOEIOG JABNJIEFCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x748BB0", Offset = "0x7479B0", VA = "0x180748BB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public EOKNELNBMBB BPBACDCNJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x7400D0", Offset = "0x73EED0", VA = "0x1807400D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public CJEAPPIFFGL BDNOOOIGFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7578F0", Offset = "0x7566F0", VA = "0x1807578F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public KBEAAEAADAB FOFLFOCGMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7400B0", Offset = "0x73EEB0", VA = "0x1807400B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public ENDOBGIHNAA BBGHDOFPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x757900", Offset = "0x756700", VA = "0x180757900", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public KOFIEJCNABD OMDDLEJGGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x757910", Offset = "0x756710", VA = "0x180757910", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IKOGKFOOIAD FPAIILLDACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x757890", Offset = "0x756690", VA = "0x180757890", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public OOMOONHDGPN OHHBHNKBJML
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x7578A0", Offset = "0x7566A0", VA = "0x1807578A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public LDOPIEJCCFG CNPBCJHLEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x77D860", Offset = "0x77C660", VA = "0x18077D860", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public KLJOBFNPICE APBEDDHGLDN
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x7483B0", Offset = "0x7471B0", VA = "0x1807483B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public OHCNDJAHENC KHJOGHBKEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x748450", Offset = "0x747250", VA = "0x180748450", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public CKKNHKEKJPE EJEDMBKEGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x77D830", Offset = "0x77C630", VA = "0x18077D830", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public AEFBGNMHCNF FAENEPAPAOO
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7578B0", Offset = "0x7566B0", VA = "0x1807578B0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public AAKKHKDJDBI HIOJOIFOLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x7578C0", Offset = "0x7566C0", VA = "0x1807578C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public CJPPPCOPNEF LIEMGIGJEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x7578E0", Offset = "0x7566E0", VA = "0x1807578E0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public CNDIDONCODC IHCFCPOGFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x767C30", Offset = "0x766A30", VA = "0x180767C30", Slot = "21")]
		get
		{
			return default(CNDIDONCODC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x32A0C70", Offset = "0x329FA70", VA = "0x1832A0C70", Slot = "22")]
	public void HDEKFDKFOAD(LKAAGIKDPMH DNECIEEJBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x1F12A10", Offset = "0x1F11810", VA = "0x181F12A10", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x32A0F60", Offset = "0x329FD60", VA = "0x1832A0F60", Slot = "23")]
	public void MDJPCEPGALH(LKAAGIKDPMH DNECIEEJBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GEIBDHNCGHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
public class GPPBPMJFODG : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class PJNBCOPBGPP : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public GPPBPMJFODG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x757920", Offset = "0x756720", VA = "0x180757920", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x44AD790", Offset = "0x44AC590", VA = "0x1844AD790", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public PJNBCOPBGPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x44AD5E0", Offset = "0x44AC3E0", VA = "0x1844AD5E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x44AD750", Offset = "0x44AC550", VA = "0x1844AD750", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected const ulong MHGPLBDGLGM = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected const ulong CGMBJCKPIFN = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected const int BNOMLFCBDIC = 8;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected const int AHHIIILJNHL = 6;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public const int EICHNAEOFFI = 64;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected const int PFMGMPIBPPN = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> BGHMAHLLPGD;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x741BD0", Offset = "0x7409D0", VA = "0x180741BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB10", Offset = "0x7FB910", VA = "0x1807FCB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int FDNEHEOMBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75BC20", VA = "0x18075CE20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA20", Offset = "0x7FB820", VA = "0x1807FCA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x32A3CE0", Offset = "0x32A2AE0", VA = "0x1832A3CE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x32A4150", Offset = "0x32A2F50", VA = "0x1832A4150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x32A4590", Offset = "0x32A3390", VA = "0x1832A4590")]
	public GPPBPMJFODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x32A4610", Offset = "0x32A3410", VA = "0x1832A4610")]
	public GPPBPMJFODG(int OPKOKMOCMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x32A3F60", Offset = "0x32A2D60", VA = "0x1832A3F60")]
	public bool KMJEMIBOEMK(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x32A3BF0", Offset = "0x32A29F0", VA = "0x1832A3BF0")]
	public bool HDKOEEMBPON(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x32A4040", Offset = "0x32A2E40", VA = "0x1832A4040")]
	public bool LEIOECBODIJ(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x32A39C0", Offset = "0x32A27C0", VA = "0x1832A39C0")]
	public bool EMDPCLDELLN(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x32A3B60", Offset = "0x32A2960", VA = "0x1832A3B60")]
	public void HBIKPHKOKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x32A3E70", Offset = "0x32A2C70", VA = "0x1832A3E70")]
	public void KMGLCOFHKPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x32A3D80", Offset = "0x32A2B80", VA = "0x1832A3D80")]
	public void KKNDJJJFEOO(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x32A4300", Offset = "0x32A3100", VA = "0x1832A4300")]
	public void ODCBHOABBME(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x32A40C0", Offset = "0x32A2EC0", VA = "0x1832A40C0")]
	public bool LLIHFOFDBAK(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x32A39D0", Offset = "0x32A27D0", VA = "0x1832A39D0")]
	public void FFMKFHPAGKC(int NGOMPMICLHJ, int MNBBKKLFBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x32A3800", Offset = "0x32A2600", VA = "0x1832A3800")]
	public void BKHBOJBGPJE(int KOIBMJMNGNL, int PJKMLKEDHEC, int MNBBKKLFBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x32A4450", Offset = "0x32A3250", VA = "0x1832A4450")]
	public int OEECIDDHIAM(int MNBBKKLFBKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x32A4520", Offset = "0x32A3320", VA = "0x1832A4520")]
	public int OEECIDDHIAM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x32A4400", Offset = "0x32A3200", VA = "0x1832A4400")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x32A3AF0", Offset = "0x32A28F0", VA = "0x1832A3AF0", Slot = "4")]
	[IteratorStateMachine(typeof(PJNBCOPBGPP))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x32A3AF0", Offset = "0x32A28F0", VA = "0x1832A3AF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class JPBCJFJDEEA<T> : global::EIKJBIHAFFB<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	protected global::GNEGFOHGEEM<T> MCALMAAGBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected global::DKAHCFDJNBN<T> LKNLKLMOPFA;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x168F9D0", Offset = "0x168E7D0", VA = "0x18168F9D0")]
	public JPBCJFJDEEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x233DE30", Offset = "0x233CC30", VA = "0x18233DE30")]
	public JPBCJFJDEEA(global::GNEGFOHGEEM<T> MCALMAAGBHP, global::DKAHCFDJNBN<T> LKNLKLMOPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x233D790", Offset = "0x233C590", VA = "0x18233D790", Slot = "11")]
	public override T BPPOCFBLMGN(KPPMFCMFLFA OGFKBLKBLHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x233DA80", Offset = "0x233C880", VA = "0x18233DA80", Slot = "12")]
	public override void EPOBOPBJBKM(KPPMFCMFLFA OGFKBLKBLHC, T MGFMONLLLPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class MDFBGIIIKGG
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x2B39AA0", Offset = "0x2B388A0", VA = "0x182B39AA0")]
	public static DFNAMHCDDIN GLJEDJEGGBC<T>(this OAHKLBPHALF PGPGHEAKODE, global::KIEJCGOPPBK<T> ICIEGOLHGJN, global::GNEGFOHGEEM<T> MCALMAAGBHP, global::DKAHCFDJNBN<T> LKNLKLMOPFA) where T : struct
	{
		return default(DFNAMHCDDIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class NECEPADNOCF<T> : global::JPBCJFJDEEA<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x31B0CE0", Offset = "0x31AFAE0", VA = "0x1831B0CE0")]
	public NECEPADNOCF(T NFEDIMPGFAA, T JEAHNGLGEAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class PDLFLHHEHAK<T> : global::EIKJBIHAFFB<T> where T : struct, BDKNOJCPHDD
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAB80", Offset = "0x1FF9980", VA = "0x181FFAB80", Slot = "11")]
	public override T BPPOCFBLMGN(KPPMFCMFLFA OGFKBLKBLHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x1FFACA0", Offset = "0x1FF9AA0", VA = "0x181FFACA0", Slot = "12")]
	public override void EPOBOPBJBKM(KPPMFCMFLFA OGFKBLKBLHC, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAD00", Offset = "0x1FF9B00", VA = "0x181FFAD00")]
	public PDLFLHHEHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class BGAGODDCLOC : GCAGPDNMHBA
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public abstract Type BECIGMCBGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void BPPOCFBLMGN(KPPMFCMFLFA OGFKBLKBLHC, in KPCNMJOGJPJ MGFMONLLLPD);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void EPOBOPBJBKM(KPPMFCMFLFA OGFKBLKBLHC, in BDKOOLPOOEA MGFMONLLLPD);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void JEDOBACEBFK(KPPMFCMFLFA OGFKBLKBLHC, FAPCNCJEMMP PDDEBNBLNHF, [Optional] object IJBJKIBEJLN);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	protected BGAGODDCLOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class EIKJBIHAFFB<T> : BGAGODDCLOC where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public override Type BECIGMCBGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x322EFE0", Offset = "0x322DDE0", VA = "0x18322EFE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T BPPOCFBLMGN(KPPMFCMFLFA OGFKBLKBLHC);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void EPOBOPBJBKM(KPPMFCMFLFA OGFKBLKBLHC, T MGFMONLLLPD);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x322DBA0", Offset = "0x322C9A0", VA = "0x18322DBA0", Slot = "8")]
	public override void BPPOCFBLMGN(KPPMFCMFLFA OGFKBLKBLHC, in KPCNMJOGJPJ ONDHOAIGIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x322E0A0", Offset = "0x322CEA0", VA = "0x18322E0A0", Slot = "9")]
	public override void EPOBOPBJBKM(KPPMFCMFLFA OGFKBLKBLHC, in BDKOOLPOOEA NFJHHMHDKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x322F270", Offset = "0x322E070", VA = "0x18322F270", Slot = "10")]
	public override void JEDOBACEBFK(KPPMFCMFLFA OGFKBLKBLHC, FAPCNCJEMMP PDDEBNBLNHF, object IJBJKIBEJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x1058C20", Offset = "0x1057A20", VA = "0x181058C20")]
	protected EIKJBIHAFFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class EFMDPOAPDPO
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class AIDOINOKGGP
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class AEAEOFFPOGK<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
			public AEAEOFFPOGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2BA4CF0", Offset = "0x2BA3AF0", VA = "0x182BA4CF0")]
			internal void <RegisterFixedString>b__0(KPPMFCMFLFA p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5010", Offset = "0x2BA3E10", VA = "0x182BA5010")]
			internal T <RegisterFixedString>b__1(KPPMFCMFLFA p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x2FD8920", Offset = "0x2FD7720", VA = "0x182FD8920")]
		public static void OGDDHFCFLBK(GBBKHOJAJOK LACPOBNLJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x2C066A0", Offset = "0x2C054A0", VA = "0x182C066A0")]
		private static void FBPKOLLLOHK<T>(GBBKHOJAJOK LACPOBNLJLI, int JEAHNGLGEAL) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x2C06E10", Offset = "0x2C05C10", VA = "0x182C06E10")]
		private static void NJJDFHEKMAB<T>(KPPMFCMFLFA NDFOGNBCBPD, T LABLHNPANGA, int JEAHNGLGEAL) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x2C067C0", Offset = "0x2C055C0", VA = "0x182C067C0")]
		private static T LMILBEBDCGD<T>(KPPMFCMFLFA NDFOGNBCBPD, int JEAHNGLGEAL) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public AIDOINOKGGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class HFDIGOGCBCH : KHBMCGJPJAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private GBBKHOJAJOK LACPOBNLJLI;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2C145D0", Offset = "0x2C133D0", VA = "0x182C145D0", Slot = "6")]
		public override void FGEHGDGKGLA<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2FD9B50", Offset = "0x2FD8950", VA = "0x182FD9B50")]
		public static void EBLEDDOOEPF(GBBKHOJAJOK LACPOBNLJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2FD9C00", Offset = "0x2FD8A00", VA = "0x182FD9C00")]
		public HFDIGOGCBCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2ECF060", Offset = "0x2ECDE60", VA = "0x182ECF060")]
	public static void OLGNCEHOAME(GBBKHOJAJOK LACPOBNLJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x20B39C0", Offset = "0x20B27C0", VA = "0x1820B39C0")]
	public static void MLGPBCHGJGE<T>(GBBKHOJAJOK LACPOBNLJLI, global::GNEGFOHGEEM<T> MCALMAAGBHP, global::DKAHCFDJNBN<T> LKNLKLMOPFA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x20B3950", Offset = "0x20B2750", VA = "0x1820B3950")]
	public static void CCDCKHNMOJN<T>(GBBKHOJAJOK CMDILNOCNKD) where T : struct, BDKNOJCPHDD
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
public interface GBBKHOJAJOK : global::IGNDDDGDGNA<GBBKHOJAJOK>
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLJEDJEGGBC(Type LEDIIMFEFLP, GCAGPDNMHBA CMDILNOCNKD);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EHAPPLAHJDF(Type LEDIIMFEFLP, out GCAGPDNMHBA CMDILNOCNKD);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class IJNBPMMOHJG
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x32AB0A0", Offset = "0x32A9EA0", VA = "0x1832AB0A0")]
	public static void GLJEDJEGGBC(this GBBKHOJAJOK HGNLGIBOCHA, GCAGPDNMHBA CMDILNOCNKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[GDFKOGKEDCG(typeof(OAHKLBPHALF), new string[] { })]
public sealed class LEDJBIEAHEJ : OAHKLBPHALF, global::IGNDDDGDGNA<OAHKLBPHALF>, MDEPDIFNFKG, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly Dictionary<DFNAMHCDDIN, GCAGPDNMHBA> LACPOBNLJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private GBBKHOJAJOK KIMLDKECGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private HLKMGBJJBCF PGPGHEAKODE;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool CEHAPAJLMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x849670", Offset = "0x848470", VA = "0x180849670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x812860", Offset = "0x811660", VA = "0x180812860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x32B49F0", Offset = "0x32B37F0", VA = "0x1832B49F0")]
	public LEDJBIEAHEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x32B4A70", Offset = "0x32B3870", VA = "0x1832B4A70")]
	public LEDJBIEAHEJ(Dictionary<DFNAMHCDDIN, GCAGPDNMHBA> LACPOBNLJLI, bool AKDAHFJKOGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x32B4940", Offset = "0x32B3740", VA = "0x1832B4940", Slot = "7")]
	public void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x32B42B0", Offset = "0x32B30B0", VA = "0x1832B42B0", Slot = "8")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x32B49A0", Offset = "0x32B37A0", VA = "0x1832B49A0", Slot = "9")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x32B44E0", Offset = "0x32B32E0", VA = "0x1832B44E0", Slot = "4")]
	public DFNAMHCDDIN EMJGNLBFHIP(NMPGGHIBJDP ICIEGOLHGJN)
	{
		return default(DFNAMHCDDIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x32B45B0", Offset = "0x32B33B0", VA = "0x1832B45B0", Slot = "5")]
	public void GLJEDJEGGBC(DFNAMHCDDIN LNJCEIMJDGG, GCAGPDNMHBA CMDILNOCNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x32B4720", Offset = "0x32B3520", VA = "0x1832B4720")]
	[Conditional("DEBUG_BUILD")]
	private void NFGNPPKMHPI(DFNAMHCDDIN LNJCEIMJDGG, Type LEDIIMFEFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x32B4330", Offset = "0x32B3130", VA = "0x1832B4330", Slot = "6")]
	public bool EHAPPLAHJDF(DFNAMHCDDIN LNJCEIMJDGG, out GCAGPDNMHBA CMDILNOCNKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x32B4860", Offset = "0x32B3660", VA = "0x1832B4860", Slot = "10")]
	public OAHKLBPHALF NGBOBANBPHB()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[GDFKOGKEDCG(typeof(GBBKHOJAJOK), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.TypeSerializer)]
	public sealed class TypeSerializerService : MDEPDIFNFKG, GBBKHOJAJOK, global::IGNDDDGDGNA<GBBKHOJAJOK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly Dictionary<Type, GCAGPDNMHBA> LACPOBNLJLI;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool CEHAPAJLMFG
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x75BA60", Offset = "0x75A860", VA = "0x18075BA60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x77D190", Offset = "0x77BF90", VA = "0x18077D190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2FECC00", Offset = "0x2FEBA00", VA = "0x182FECC00")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2FECC80", Offset = "0x2FEBA80", VA = "0x182FECC80")]
		public TypeSerializerService(Dictionary<Type, GCAGPDNMHBA> LACPOBNLJLI, bool AKDAHFJKOGA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2FECB50", Offset = "0x2FEB950", VA = "0x182FECB50", Slot = "4")]
		public void NIACEKGLEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC950", Offset = "0x2FEB750", VA = "0x182FEC950", Slot = "5")]
		public void GLJEDJEGGBC(Type LEDIIMFEFLP, GCAGPDNMHBA CMDILNOCNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC870", Offset = "0x2FEB670", VA = "0x182FEC870", Slot = "6")]
		public bool EHAPPLAHJDF(Type LEDIIMFEFLP, out GCAGPDNMHBA CMDILNOCNKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2FECA70", Offset = "0x2FEB870", VA = "0x182FECA70", Slot = "7")]
		public GBBKHOJAJOK NGBOBANBPHB()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[GDFKOGKEDCG(typeof(PGINGNIPPCL), new string[] { })]
internal sealed class LEFGHAKHKDG : PGINGNIPPCL, MDEPDIFNFKG, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<DFNAMHCDDIN, EEIKLICMPPC> DGLBEPDIAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private HLKMGBJJBCF PGPGHEAKODE;

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x32B6250", Offset = "0x32B5050", VA = "0x1832B6250", Slot = "6")]
	public void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x32B5FF0", Offset = "0x32B4DF0", VA = "0x1832B5FF0", Slot = "7")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x32B6050", Offset = "0x32B4E50", VA = "0x1832B6050", Slot = "4")]
	public void GLJEDJEGGBC(DFNAMHCDDIN HEDGDEEAPPO, Type OGDPHIGABNG, EEIKLICMPPC ANCBINDKPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x32B62A0", Offset = "0x32B50A0", VA = "0x1832B62A0", Slot = "5")]
	public bool OFHIHGFLHJC(DFNAMHCDDIN HEDGDEEAPPO, out EEIKLICMPPC ANCBINDKPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x32B60C0", Offset = "0x32B4EC0", VA = "0x1832B60C0")]
	[Conditional("DEBUG_BUILD")]
	private void NHFHGHOFBIC(DFNAMHCDDIN HEDGDEEAPPO, Type OGDPHIGABNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x32B6310", Offset = "0x32B5110", VA = "0x1832B6310")]
	public LEFGHAKHKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[GDFKOGKEDCG(typeof(JLBMBDKPHLM), new string[] { })]
internal sealed class GEOILCDAEPM : JLBMBDKPHLM, KHEIMMLCGKM, MDEPDIFNFKG, JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly GPPBPMJFODG KLFBDDLCNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly Dictionary<MFDODOEBKCJ, int> PACIIBNCBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Stack<int> EAJMKDJIOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[DNEBGGIIGBA]
	private HLKMGBJJBCF PGPGHEAKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[DNEBGGIIGBA]
	private JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private int EMMLEBBMCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x32A1680", Offset = "0x32A0480", VA = "0x1832A1680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool GJLNPONCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x823C30", Offset = "0x822A30", VA = "0x180823C30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x989B70", Offset = "0x988970", VA = "0x180989B70", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x32A0F80", Offset = "0x329FD80", VA = "0x1832A0F80", Slot = "6")]
	public void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x32A10C0", Offset = "0x329FEC0", VA = "0x1832A10C0", Slot = "7")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x32A1140", Offset = "0x329FF40", VA = "0x1832A1140", Slot = "8")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x32A16D0", Offset = "0x32A04D0", VA = "0x1832A16D0")]
	private void PILDACJKLCJ(CGKCPDMKDFM HPLAKDFIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x32A1540", Offset = "0x32A0340", VA = "0x1832A1540", Slot = "4")]
	public bool KHHCOIJFPGF(MFDODOEBKCJ FIIEHBGLOHB, DFNAMHCDDIN FHINIKPHPFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x32A11F0", Offset = "0x329FFF0", VA = "0x1832A11F0", Slot = "5")]
	public void KBIGFCMFANF(MFDODOEBKCJ FIIEHBGLOHB, Span<DFNAMHCDDIN> PGPGHEAKODE, bool DIDLKJBEMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x32A0F80", Offset = "0x329FD80", VA = "0x1832A0F80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x32A1770", Offset = "0x32A0570", VA = "0x1832A1770")]
	public GEOILCDAEPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class ECLMLKFEOIJ
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x2ECEE40", Offset = "0x2ECDC40", VA = "0x182ECEE40")]
	public static void KCCJFHBHPAF(this KPPMFCMFLFA OGFKBLKBLHC, ReadOnlyMemory<byte> EBJPFPHFBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x20AB870", Offset = "0x20AA670", VA = "0x1820AB870")]
	public static void LONJBINGFMO<T>(this KPPMFCMFLFA OGFKBLKBLHC, in T MGFMONLLLPD) where T : struct, BDKNOJCPHDD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x20AB6F0", Offset = "0x20AA4F0", VA = "0x1820AB6F0")]
	public static T FCMNAFCCACM<T>(this KPPMFCMFLFA OGFKBLKBLHC) where T : struct, BDKNOJCPHDD
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x2ECEEC0", Offset = "0x2ECDCC0", VA = "0x182ECEEC0")]
	public static void LONJBINGFMO(this KPPMFCMFLFA OGFKBLKBLHC, LKMNJCOAFFA OJBHOMKBJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x2ECEC60", Offset = "0x2ECDA60", VA = "0x182ECEC60")]
	public static LKMNJCOAFFA DOOHPKKFLOI(this KPPMFCMFLFA OGFKBLKBLHC)
	{
		return default(LKMNJCOAFFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x2ECEC90", Offset = "0x2ECDA90", VA = "0x182ECEC90")]
	public static void IFDLIAGECKE(this KPPMFCMFLFA IMGJFGGFPOC, uint EMGKKJPHAPE, bool KHPEIINADMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x2ECEB40", Offset = "0x2ECD940", VA = "0x182ECEB40")]
	public static uint ADKGIDNBKJL(this KPPMFCMFLFA IDIEIECFGPN, bool KHPEIINADMN = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class OMAIPDLGGDJ
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class AOGFBDLHFBG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public AOGFBDLHFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x34D70E0", Offset = "0x34D5EE0", VA = "0x1834D70E0")]
		internal void <GetByteEnumDelegates>b__0(KPPMFCMFLFA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x34D7150", Offset = "0x34D5F50", VA = "0x1834D7150")]
		internal T <GetByteEnumDelegates>b__1(KPPMFCMFLFA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class DAKEOMAJCBH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public DAKEOMAJCBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x36CE290", Offset = "0x36CD090", VA = "0x1836CE290")]
		internal void <GetSByteEnumDelegates>b__0(KPPMFCMFLFA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x36CE300", Offset = "0x36CD100", VA = "0x1836CE300")]
		internal T <GetSByteEnumDelegates>b__1(KPPMFCMFLFA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class JDIJIOCPFOC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public JDIJIOCPFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F210", Offset = "0x3F7E010", VA = "0x183F7F210")]
		internal void <GetShortEnumDelegates>b__0(KPPMFCMFLFA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F280", Offset = "0x3F7E080", VA = "0x183F7F280")]
		internal T <GetShortEnumDelegates>b__1(KPPMFCMFLFA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class AMIMEOHFJEL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public AMIMEOHFJEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x34D4790", Offset = "0x34D3590", VA = "0x1834D4790")]
		internal void <GetUShortEnumDelegates>b__0(KPPMFCMFLFA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x34D4800", Offset = "0x34D3600", VA = "0x1834D4800")]
		internal T <GetUShortEnumDelegates>b__1(KPPMFCMFLFA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class AKGKANFCNNP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public AKGKANFCNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x24E2AD0", Offset = "0x24E18D0", VA = "0x1824E2AD0")]
		internal void <GetIntEnumDelegates>b__0(KPPMFCMFLFA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x24E2B30", Offset = "0x24E1930", VA = "0x1824E2B30")]
		internal T <GetIntEnumDelegates>b__1(KPPMFCMFLFA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class ODGKIFLAKHL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public ODGKIFLAKHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x3B49E90", Offset = "0x3B48C90", VA = "0x183B49E90")]
		internal void <GetUIntEnumDelegates>b__0(KPPMFCMFLFA b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x3B49EF0", Offset = "0x3B48CF0", VA = "0x183B49EF0")]
		internal T <GetUIntEnumDelegates>b__1(KPPMFCMFLFA b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x27D8610", Offset = "0x27D7410", VA = "0x1827D8610")]
	public static void CBALKFLMAJJ<T>(T NFEDIMPGFAA, T JEAHNGLGEAL, out global::GNEGFOHGEEM<T> PDEIPDHKAAF, out global::DKAHCFDJNBN<T> NAOOFEOLAIK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x27D8980", Offset = "0x27D7780", VA = "0x1827D8980")]
	private static void NMELNFAFOGG<T>(T NFEDIMPGFAA, T JEAHNGLGEAL, out global::GNEGFOHGEEM<T> PDEIPDHKAAF, out global::DKAHCFDJNBN<T> NAOOFEOLAIK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x27D8980", Offset = "0x27D7780", VA = "0x1827D8980")]
	private static void MKNFDCJGEGM<T>(T NFEDIMPGFAA, T JEAHNGLGEAL, out global::GNEGFOHGEEM<T> PDEIPDHKAAF, out global::DKAHCFDJNBN<T> NAOOFEOLAIK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x27D8830", Offset = "0x27D7630", VA = "0x1827D8830")]
	private static void IJCANCKCCHN<T>(T NFEDIMPGFAA, T JEAHNGLGEAL, out global::GNEGFOHGEEM<T> PDEIPDHKAAF, out global::DKAHCFDJNBN<T> NAOOFEOLAIK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x27D8830", Offset = "0x27D7630", VA = "0x1827D8830")]
	private static void MMAPEMKNCMD<T>(T NFEDIMPGFAA, T JEAHNGLGEAL, out global::GNEGFOHGEEM<T> PDEIPDHKAAF, out global::DKAHCFDJNBN<T> NAOOFEOLAIK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x27D8AD0", Offset = "0x27D78D0", VA = "0x1827D8AD0")]
	private static void PABPBOMKGIJ<T>(T NFEDIMPGFAA, T JEAHNGLGEAL, out global::GNEGFOHGEEM<T> PDEIPDHKAAF, out global::DKAHCFDJNBN<T> NAOOFEOLAIK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x27D8AD0", Offset = "0x27D78D0", VA = "0x1827D8AD0")]
	private static void BFEIFNPGGHL<T>(T NFEDIMPGFAA, T JEAHNGLGEAL, out global::GNEGFOHGEEM<T> PDEIPDHKAAF, out global::DKAHCFDJNBN<T> NAOOFEOLAIK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class KIMODBMMIKD : DPMAFGCHFMD, NEGCPFIDGDD
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x32B12E0", Offset = "0x32B00E0", VA = "0x1832B12E0", Slot = "4")]
	private void LBCLLHHDBLG(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void PHIBAFCLPIM(OAHKLBPHALF PGPGHEAKODE);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
	protected KIMODBMMIKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[OALPEIBOLKA(typeof(LocalPoseData))]
public sealed class OCJDHHBNJAJ : KIMODBMMIKD
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D480", Offset = "0x2D1C280", VA = "0x182D1D480", Slot = "5")]
	protected override void PHIBAFCLPIM(OAHKLBPHALF PGPGHEAKODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0")]
	public OCJDHHBNJAJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	internal class CopyAuthorityToEntity : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery EGFKLMIDJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery NEPFIMCHFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery AIAEJKOKJEK;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4BB0", Offset = "0x2EC39B0", VA = "0x182EC4BB0", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5590", Offset = "0x2EC4390", VA = "0x182EC5590", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5710", Offset = "0x2EC4510", VA = "0x182EC5710", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC56E0", Offset = "0x2EC44E0", VA = "0x182EC56E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4C20", Offset = "0x2EC3A20", VA = "0x182EC4C20")]
		private void HHNEINMDEBO(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4F60", Offset = "0x2EC3D60", VA = "0x182EC4F60")]
		private void HKMPIIIOJDA(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5100", Offset = "0x2EC3F00", VA = "0x182EC5100")]
		private void KBOICJDCAHH(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2EC53E0", Offset = "0x2EC41E0", VA = "0x182EC53E0")]
		private void ONAEJANKHNK(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5830", Offset = "0x2EC4630", VA = "0x182EC5830")]
		private void PGPABHJKBKC(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5750", Offset = "0x2EC4550", VA = "0x182EC5750")]
		private void PFHBADMGFKA(CGKCPDMKDFM HPLAKDFIDCJ, int COGEDNMFBOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class HCDKPBDFFAK : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityQuery NOJJNNFMBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private LCLOCHGKNKG BGEMPOFCNMN;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x32A50A0", Offset = "0x32A3EA0", VA = "0x1832A50A0", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x32A50F0", Offset = "0x32A3EF0", VA = "0x1832A50F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x32A51B0", Offset = "0x32A3FB0", VA = "0x1832A51B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x32A4AC0", Offset = "0x32A38C0", VA = "0x1832A4AC0")]
	private void AFNFDLMIKIM(NativeArray<Entity> KMDDIGFEEEI, NativeList<Entity> JHANAFGMPLD, ComponentDataFromEntity<NEFKEEEGIKO> CDIPJPCJJLL, BufferFromEntity<ChildrenData> ELGNFJMALIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public HCDKPBDFFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class PMAILEOPKDM : ParentSystemBase<AuthoredParentData, NOHLODEKBPA, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CD50", Offset = "0x2D2BB50", VA = "0x182D2CD50", Slot = "14")]
	protected override EntityQueryDesc BHECJKFKMLG(EntityQueryDesc NOJJNNFMBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x803DB0", Offset = "0x802BB0", VA = "0x180803DB0", Slot = "15")]
	protected override EntityQueryDesc EEBBLHBDKPE(EntityQueryDesc NOJJNNFMBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CDD0", Offset = "0x2D2BBD0", VA = "0x182D2CDD0", Slot = "16")]
	protected override EntityQueryDesc IEHCDPANPPB(EntityQueryDesc NOJJNNFMBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CD90", Offset = "0x2D2BB90", VA = "0x182D2CD90", Slot = "17")]
	protected override EntityQueryDesc GHCOLLOCGLO(EntityQueryDesc NOJJNNFMBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CE50", Offset = "0x2D2BC50", VA = "0x182D2CE50")]
	public PMAILEOPKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CE10", Offset = "0x2D2BC10", VA = "0x182D2CE10", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class LCHGLNBOHNP : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EntityQuery NOJJNNFMBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private object PNKGBGLFPND;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x32B3F10", Offset = "0x32B2D10", VA = "0x1832B3F10", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x32B3F90", Offset = "0x32B2D90", VA = "0x1832B3F90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x32B4030", Offset = "0x32B2E30", VA = "0x1832B4030", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public LCHGLNBOHNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class PFMFOCLCHMP : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery NOJJNNFMBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private object PNKGBGLFPND;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C030", Offset = "0x2D2AE30", VA = "0x182D2C030", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C0B0", Offset = "0x2D2AEB0", VA = "0x182D2C0B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C150", Offset = "0x2D2AF50", VA = "0x182D2C150", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public PFMFOCLCHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(1)]
internal struct ILCNDBBKCGJ : ISystemStateBufferElementData, IBufferElementData, IEquatable<ILCNDBBKCGJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public LCCMCJFACMP EAHLOGLBEGD;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x32AB490", Offset = "0x32AA290", VA = "0x1832AB490", Slot = "4")]
	public bool Equals(ILCNDBBKCGJ IDBPJJAKCBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x7C69F0", Offset = "0x7C57F0", VA = "0x1807C69F0")]
	public static ILCNDBBKCGJ JMLJLLKELMG(LCCMCJFACMP EAHLOGLBEGD)
	{
		return default(ILCNDBBKCGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(4)]
internal struct OPFKKKCFNGM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public LCCMCJFACMP EAHLOGLBEGD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x7C69F0", Offset = "0x7C57F0", VA = "0x1807C69F0")]
	public static OPFKKKCFNGM JMLJLLKELMG(LCCMCJFACMP EAHLOGLBEGD)
	{
		return default(OPFKKKCFNGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class HIFKKIIGINI : DDANMEIOKBO
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x32A5CB0", Offset = "0x32A4AB0", VA = "0x1832A5CB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x32A5E40", Offset = "0x32A4C40", VA = "0x1832A5E40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x329D6A0", Offset = "0x329C4A0", VA = "0x18329D6A0")]
	protected HIFKKIIGINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[AJHMADEHCDB]
internal abstract class DDANMEIOKBO : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	protected EntityQuery NOJJNNFMBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected CJPPPCOPNEF GACMGMIMIEC;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected abstract CJCDGHKHAAI HELGBOPDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x2ECA5B0", Offset = "0x2EC93B0", VA = "0x182ECA5B0", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x2ECA330", Offset = "0x2EC9130", VA = "0x182ECA330")]
	protected void EABMILPONAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x2ECA620", Offset = "0x2EC9420", VA = "0x182ECA620")]
	protected void JIHEGDEICMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x2ECA2C0", Offset = "0x2EC90C0", VA = "0x182ECA2C0")]
	protected DFFGCDANCCG DNIBNDIODEH()
	{
		return default(DFFGCDANCCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	protected DDANMEIOKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class BCCJKNBMCII : DDANMEIOKBO
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x2EB71A0", Offset = "0x2EB5FA0", VA = "0x182EB71A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7330", Offset = "0x2EB6130", VA = "0x182EB7330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	protected BCCJKNBMCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class IKBEPEKCPGE : DDANMEIOKBO
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x32AB1A0", Offset = "0x32A9FA0", VA = "0x1832AB1A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x32AB2B0", Offset = "0x32AA0B0", VA = "0x1832AB2B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x329D6A0", Offset = "0x329C4A0", VA = "0x18329D6A0")]
	protected IKBEPEKCPGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class MJIJOLKHNHE : HIFKKIIGINI
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override CJCDGHKHAAI HELGBOPDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A300", Offset = "0x2D19100", VA = "0x182D1A300", Slot = "15")]
		get
		{
			return default(CJCDGHKHAAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2D19E50", Offset = "0x2D18C50", VA = "0x182D19E50")]
	public MJIJOLKHNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class KIOHPNGOCHB : BCCJKNBMCII
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override CJCDGHKHAAI HELGBOPDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x32B1340", Offset = "0x32B0140", VA = "0x1832B1340", Slot = "15")]
		get
		{
			return default(CJCDGHKHAAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x329D6A0", Offset = "0x329C4A0", VA = "0x18329D6A0")]
	public KIOHPNGOCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class FJADGBAFGPM : IKBEPEKCPGE
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override CJCDGHKHAAI HELGBOPDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x329D6B0", Offset = "0x329C4B0", VA = "0x18329D6B0", Slot = "15")]
		get
		{
			return default(CJCDGHKHAAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x329D6A0", Offset = "0x329C4A0", VA = "0x18329D6A0")]
	public FJADGBAFGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class GJGCDGMKDDB : HIFKKIIGINI
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected override CJCDGHKHAAI HELGBOPDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x32A2C90", Offset = "0x32A1A90", VA = "0x1832A2C90", Slot = "15")]
		get
		{
			return default(CJCDGHKHAAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x329D6A0", Offset = "0x329C4A0", VA = "0x18329D6A0")]
	public GJGCDGMKDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class FFKABCBLPHI : BCCJKNBMCII
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected override CJCDGHKHAAI HELGBOPDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x329D630", Offset = "0x329C430", VA = "0x18329D630", Slot = "15")]
		get
		{
			return default(CJCDGHKHAAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x329D6A0", Offset = "0x329C4A0", VA = "0x18329D6A0")]
	public FFKABCBLPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class MCCPHHCLLLN : IKBEPEKCPGE
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected override CJCDGHKHAAI HELGBOPDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2D19DE0", Offset = "0x2D18BE0", VA = "0x182D19DE0", Slot = "15")]
		get
		{
			return default(CJCDGHKHAAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x2D19E50", Offset = "0x2D18C50", VA = "0x182D19E50")]
	public MCCPHHCLLLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct CPAKFKFJAMB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct CGOPMAFACLC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct NLEBCKEBJLF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct CJCDGHKHAAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly ComponentType NGHKOJDCKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly ComponentType IHDKMDIGBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly object AMBDKIOJFBL;

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC2A0", Offset = "0x2EBB0A0", VA = "0x182EBC2A0")]
	public CJCDGHKHAAI(ComponentType NGHKOJDCKJD, ComponentType IHDKMDIGBKC, object AMBDKIOJFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x2615D70", Offset = "0x2614B70", VA = "0x182615D70")]
	public static CJCDGHKHAAI EJPGKLALKON<TReq, TTag>(object AMBDKIOJFBL)
	{
		return default(CJCDGHKHAAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class KEKEGBHMPOL
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public const string KHIAEPDAJCO = "Parented";

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public const string BKPIMEKGEIO = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly CJCDGHKHAAI EJEDMBKEGGK;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly CJCDGHKHAAI CIJGFEMJEAB;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct LCCMCJFACMP : global::BIINDPJIKMP<LCCMCJFACMP>, JMOHLFDBGCE, IEquatable<LCCMCJFACMP>
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int CEEBBJGGBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x80A490", Offset = "0x809290", VA = "0x18080A490", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int KAKKJFDONBF
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x90B640", Offset = "0x90A440", VA = "0x18090B640", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xF02C00", Offset = "0xF01A00", VA = "0x180F02C00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool EMDPCLDELLN
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x32B3E80", Offset = "0x32B2C80", VA = "0x1832B3E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x32AB490", Offset = "0x32AA290", VA = "0x1832AB490", Slot = "8")]
	public bool Equals(LCCMCJFACMP IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x32B3EC0", Offset = "0x32B2CC0", VA = "0x1832B3EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[AJHMADEHCDB]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.Connectables)]
	public class UpdateConnectableVisuals : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct FCDHHLHFLLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public LCCMCJFACMP EAHLOGLBEGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public float3 DNPAJCANFPF;

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x44A5960", Offset = "0x44A4760", VA = "0x1844A5960")]
			public FCDHHLHFLLP(LCCMCJFACMP EAHLOGLBEGD, float3 DNPAJCANFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x44A5940", Offset = "0x44A4740", VA = "0x1844A5940")]
			public void BJOOJLCIJFO(out LCCMCJFACMP EAHLOGLBEGD, out float3 DNPAJCANFPF)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct JPFHPJIFIKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<FCDHHLHFLLP> list;

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
			public JPFHPJIFIKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<OPFKKKCFNGM> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct IJENGKDGPDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeList<FCDHHLHFLLP> list;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
			public IJENGKDGPDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<ILCNDBBKCGJ> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct HFBOBIEAKOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<FCDHHLHFLLP> list;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
			public HFBOBIEAKOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in BEGBLDKOOHN com, in DynamicBuffer<ILCNDBBKCGJ> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct EOPIBPMCIKF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct ALDDOACLEOG
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				public struct ALPOBBFAENA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					public LambdaParameterValueProvider_Entity.Runtime LPBAJAEJLFN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MIGPINCNHFK;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public LambdaParameterValueProvider_DynamicBuffer<OPFKKKCFNGM>.Runtime KMDLHBMJBNE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CE")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity GPILJGHOMAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002CF")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> BKIFHMENPDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<OPFKKKCFNGM> OPBJKACJOHP;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x44A11C0", Offset = "0x449FFC0", VA = "0x1844A11C0")]
				public void FBJFNGKGEAG(UpdateConnectableVisuals KHKMOBDDHBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x44A1240", Offset = "0x44A0040", VA = "0x1844A1240")]
				public ALPOBBFAENA OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
				{
					return default(ALPOBBFAENA);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public UpdateConnectableVisuals BGDLJHFPCBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public NativeList<FCDHHLHFLLP> MPMKGFKPBEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private ALDDOACLEOG CEHPMGEJNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ALDDOACLEOG.ALPOBBFAENA* PAGEGEKEMGJ;

			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LMEJDEJHIBP;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x44A5020", Offset = "0x44A3E20", VA = "0x1844A5020")]
			internal void OPBACEEAMEO(Entity NEAKDKENHHP, WorldPoseData MNHEKPDFAKM, in DynamicBuffer<OPFKKKCFNGM> GMDALJMBJKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x44A53A0", Offset = "0x44A41A0", VA = "0x1844A53A0", Slot = "5")]
			public void ReadFromDisplayClass(ref JPFHPJIFIKE DBDHHAPIJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x44A53D0", Offset = "0x44A41D0", VA = "0x1844A53D0", Slot = "6")]
			public void WriteToDisplayClass(ref JPFHPJIFIKE DBDHHAPIJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x44A4E90", Offset = "0x44A3C90", VA = "0x1844A4E90", Slot = "4")]
			public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x44A5260", Offset = "0x44A4060", VA = "0x1844A5260")]
			public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, ref ALDDOACLEOG.ALPOBBFAENA ICBLKLNOLAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x44A4F70", Offset = "0x44A3D70", VA = "0x1844A4F70")]
			public void FBJFNGKGEAG(UpdateConnectableVisuals KHKMOBDDHBP, ref JPFHPJIFIKE DBDHHAPIJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x44A4FB0", Offset = "0x44A3DB0", VA = "0x1844A4FB0")]
			public unsafe static void HNMDANPFJNG(ArchetypeChunkIterator* DDBGPMPNMAB, void* HHAGMJBBFIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct OHLHPEAGOCC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct AHNGNKNCKKH
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct JPNJPMPCHOL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MIGPINCNHFK;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<ILCNDBBKCGJ>.Runtime KMDLHBMJBNE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> BKIFHMENPDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<ILCNDBBKCGJ> OPBJKACJOHP;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x44A0F20", Offset = "0x449FD20", VA = "0x1844A0F20")]
				public void FBJFNGKGEAG(UpdateConnectableVisuals KHKMOBDDHBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x44A0F90", Offset = "0x449FD90", VA = "0x1844A0F90")]
				public JPNJPMPCHOL OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
				{
					return default(JPNJPMPCHOL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NativeList<FCDHHLHFLLP> MPMKGFKPBEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private AHNGNKNCKKH CEHPMGEJNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe AHNGNKNCKKH.JPNJPMPCHOL* PAGEGEKEMGJ;

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x44AC9E0", Offset = "0x44AB7E0", VA = "0x1844AC9E0")]
			internal void OPBACEEAMEO(in WorldPoseData MNHEKPDFAKM, in DynamicBuffer<ILCNDBBKCGJ> GMDALJMBJKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x1213BF0", Offset = "0x12129F0", VA = "0x181213BF0", Slot = "5")]
			public void ReadFromDisplayClass(ref IJENGKDGPDA DBDHHAPIJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x44AC870", Offset = "0x44AB670", VA = "0x1844AC870", Slot = "4")]
			public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x44ACAF0", Offset = "0x44AB8F0", VA = "0x1844ACAF0")]
			public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, [NoAlias] ref AHNGNKNCKKH.JPNJPMPCHOL ICBLKLNOLAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x44AC940", Offset = "0x44AB740", VA = "0x1844AC940")]
			public void FBJFNGKGEAG(UpdateConnectableVisuals KHKMOBDDHBP, ref IJENGKDGPDA DBDHHAPIJND)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct KLPAOHJELAH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			private struct PJKCINILEKC
			{
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				[NoAlias]
				public struct FHMHBNHOFLP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MIGPINCNHFK;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<BEGBLDKOOHN>.Runtime PBHBBHHCBHG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002E3")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<ILCNDBBKCGJ>.Runtime KMDLHBMJBNE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> BKIFHMENPDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<BEGBLDKOOHN> ODMMMKDKBHF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<ILCNDBBKCGJ> OPBJKACJOHP;

				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x44AD480", Offset = "0x44AC280", VA = "0x1844AD480")]
				public void FBJFNGKGEAG(UpdateConnectableVisuals KHKMOBDDHBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x44AD510", Offset = "0x44AC310", VA = "0x1844AD510")]
				public FHMHBNHOFLP OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
				{
					return default(FHMHBNHOFLP);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<FCDHHLHFLLP> MPMKGFKPBEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private PJKCINILEKC CEHPMGEJNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PJKCINILEKC.FHMHBNHOFLP* PAGEGEKEMGJ;

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x44A8940", Offset = "0x44A7740", VA = "0x1844A8940")]
			internal void OPBACEEAMEO(in WorldPoseData MNHEKPDFAKM, in BEGBLDKOOHN JNEAPHALODL, in DynamicBuffer<ILCNDBBKCGJ> GMDALJMBJKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x1213BF0", Offset = "0x12129F0", VA = "0x181213BF0", Slot = "5")]
			public void ReadFromDisplayClass(ref HFBOBIEAKOD DBDHHAPIJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x44A8880", Offset = "0x44A7680", VA = "0x1844A8880", Slot = "4")]
			public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x44A8AA0", Offset = "0x44A78A0", VA = "0x1844A8AA0")]
			public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, [NoAlias] ref PJKCINILEKC.FHMHBNHOFLP ICBLKLNOLAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x44A8900", Offset = "0x44A7700", VA = "0x1844A8900")]
			public void FBJFNGKGEAG(UpdateConnectableVisuals KHKMOBDDHBP, ref HFBOBIEAKOD DBDHHAPIJND)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery NCEPDCJFDIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery OJFPBKOLIAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery GFMOLMEKGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery PKEBEGCBJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery MKFEELAMNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery HCDGLHABBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery LHKOMDAKNLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery NOPMKAKMCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery PKMEHLIDMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery EAMDJFDBBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private global::JEFOHNHCKHC<LCCMCJFACMP, IPOFABECGDG> KFMGKOKGIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private AAKKHKDJDBI JDLHADAKLHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private OOMOONHDGPN NAHLJGLOPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private LFFEMFLLJPL KMNLLMHDGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery EBPJOKPKILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ProfilerMarker PDNMIILLAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery NGJOBCKEOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery PINKBEPFPGN;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int JKIABPBFIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2FF1220", Offset = "0x2FF0020", VA = "0x182FF1220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2FEDC70", Offset = "0x2FECA70", VA = "0x182FEDC70")]
		internal IPOFABECGDG BHGGMBDKNNO(LCCMCJFACMP EAHLOGLBEGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2FEE870", Offset = "0x2FED670", VA = "0x182FEE870", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1880", Offset = "0x2FF0680", VA = "0x182FF1880", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1B00", Offset = "0x2FF0900", VA = "0x182FF1B00", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1C90", Offset = "0x2FF0A90", VA = "0x182FF1C90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1AC0", Offset = "0x2FF08C0", VA = "0x182FF1AC0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2FEF8C0", Offset = "0x2FEE6C0", VA = "0x182FEF8C0")]
		private void GLDJBDBDIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1260", Offset = "0x2FF0060", VA = "0x182FF1260")]
		private void NEFKFPFILME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2FEE4C0", Offset = "0x2FED2C0", VA = "0x182FEE4C0")]
		private void DFKEILPMEEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1CD0", Offset = "0x2FF0AD0", VA = "0x182FF1CD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2FEF020", Offset = "0x2FEDE20", VA = "0x182FEF020")]
		private void FPKIEKJDLAL(EntityQuery EGFKLMIDJPC, EntityQuery LOGNMBNKGBP, EntityQuery NEPFIMCHFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2FEE3F0", Offset = "0x2FED1F0", VA = "0x182FEE3F0")]
		private void CJGLMEKHGBL(EntityQuery NEPFIMCHFAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0620", Offset = "0x2FEF420", VA = "0x182FF0620")]
		private void KFNHJJGHMGE(NativeArrayAsync<Entity> JLLHJJCFLNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2FEE2E0", Offset = "0x2FED0E0", VA = "0x182FEE2E0")]
		private void CFNKKGICABE(NativeArrayAsync<Entity> PLMLKHGPJME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2FEF9D0", Offset = "0x2FEE7D0", VA = "0x182FEF9D0")]
		private void GMILKCKELMC(NativeArrayAsync<Entity> FGCOHLIFBFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2FF13B0", Offset = "0x2FF01B0", VA = "0x182FF13B0")]
		private void NIHECKDBJIC(NativeList<LCCMCJFACMP> PMCLNIPIEIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0D00", Offset = "0x2FEFB00", VA = "0x182FF0D00")]
		private NativeList<LCCMCJFACMP> LANDIEJAOMC(NativeArray<Entity> KMDDIGFEEEI)
		{
			return default(NativeList<LCCMCJFACMP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2FEDCC0", Offset = "0x2FECAC0", VA = "0x182FEDCC0")]
		private void BJLFFANFJOI(NativeArray<Entity> KMDDIGFEEEI, NativeList<LCCMCJFACMP> PMCLNIPIEIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2FEEAF0", Offset = "0x2FED8F0", VA = "0x182FEEAF0")]
		private void FFBMNFOEEBJ(NativeArray<Entity> NGFDPGGMIJN, NativeArray<Entity> BBCBCADEBNE, NativeList<LCCMCJFACMP> EAJMKDJIOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2FEFF40", Offset = "0x2FEED40", VA = "0x182FEFF40")]
		private void HCDDKOCACMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2FEFE00", Offset = "0x2FEEC00", VA = "0x182FEFE00")]
		private NativeListAsync<FCDHHLHFLLP> HBIFDINJHML(EntityQuery NOJJNNFMBAH, Func<NativeList<FCDHHLHFLLP>, JobHandle> AOKLFPCPMLD)
		{
			return default(NativeListAsync<FCDHHLHFLLP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0B70", Offset = "0x2FEF970", VA = "0x182FF0B70")]
		private JobHandle KOLFENBDIIF(NativeList<FCDHHLHFLLP> MPMKGFKPBEN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2FF03F0", Offset = "0x2FEF1F0", VA = "0x182FF03F0")]
		private JobHandle ILJAELJPLMA(NativeList<FCDHHLHFLLP> MPMKGFKPBEN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2FEF790", Offset = "0x2FEE590", VA = "0x182FEF790")]
		private JobHandle GGBNGCGHHBD(NativeList<FCDHHLHFLLP> MPMKGFKPBEN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2FEF500", Offset = "0x2FEE300", VA = "0x182FEF500")]
		private void GFPMPJAIJOO(NativeListAsync<FCDHHLHFLLP> MPMKGFKPBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2FEFB70", Offset = "0x2FEE970", VA = "0x182FEFB70")]
		private void GODPHLDEAAE(NativeListAsync<FCDHHLHFLLP> MPMKGFKPBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2FF05C0", Offset = "0x2FEF3C0", VA = "0x182FF05C0")]
		private bool JPBGKMLBBAK(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2FF2060", Offset = "0x2FF0E60", VA = "0x182FF2060")]
		private NativeArray<Entity> PMLOLAHHMEG(Entity NEAKDKENHHP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2FEE930", Offset = "0x2FED730", VA = "0x182FEE930")]
		private LCCMCJFACMP EODPKNNBCKO(NativeList<LCCMCJFACMP> EAJMKDJIOGN)
		{
			return default(LCCMCJFACMP);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0530", Offset = "0x2FEF330", VA = "0x182FF0530")]
		private void JDIDODGCNCM(LCCMCJFACMP EAHLOGLBEGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1720", Offset = "0x2FF0520", VA = "0x182FF1720", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1520", Offset = "0x2FF0320", VA = "0x182FF1520")]
		public static EntityQuery OIOCNMMKCHG(ComponentSystemBase KHKMOBDDHBP)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2FF1E00", Offset = "0x2FF0C00", VA = "0x182FF1E00")]
		public static EntityQuery PEPKMJLCOOL(ComponentSystemBase KHKMOBDDHBP)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2FF0900", Offset = "0x2FEF700", VA = "0x182FF0900")]
		public static EntityQuery KIGEBEDCMOJ(ComponentSystemBase KHKMOBDDHBP)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[DKGMECGHCPI(OJBFOICGDOF.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery NOJJNNFMBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private OOHEIMOEIOG IALAEABLGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private HIIFKNHAGAI DLHELKNOKFO;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D338F0", Offset = "0x2D326F0", VA = "0x182D338F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D33860", Offset = "0x2D32660", VA = "0x182D33860", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D339F0", Offset = "0x2D327F0", VA = "0x182D339F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class PBAJLJHEFKK : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public BOGOKBNBEFE FNEHIFGGEEN;

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public PBAJLJHEFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	public PBAJLJHEFKK(BOGOKBNBEFE FNEHIFGGEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x2D2BFC0", Offset = "0x2D2ADC0", VA = "0x182D2BFC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public abstract class ELKABBNFOMB : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private ObjectEmbodimentService DPEPLNEHLIL;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x2ED3210", Offset = "0x2ED2010", VA = "0x182ED3210", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2ED3270", Offset = "0x2ED2070", VA = "0x182ED3270", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2ED32A0", Offset = "0x2ED20A0", VA = "0x182ED32A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	protected ELKABBNFOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class PPBEACIICIJ : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EntityQuery EDLJHMCIGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery IEOMAJFKGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery LJBBMLBDELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery CMFJPMALICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private ObjectEmbodimentService CBNCNGGOMHC;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public int FHPJHCMAIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E2F0", Offset = "0x2D2D0F0", VA = "0x182D2E2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int CPJHHJPKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E090", Offset = "0x2D2CE90", VA = "0x182D2E090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x2D2DC60", Offset = "0x2D2CA60", VA = "0x182D2DC60", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E300", Offset = "0x2D2D100", VA = "0x182D2E300", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E500", Offset = "0x2D2D300", VA = "0x182D2E500", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E520", Offset = "0x2D2D320", VA = "0x182D2E520")]
	public int PDCOKFBLHIA(SceneTag OAALIIEEAME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x2D2DBB0", Offset = "0x2D2C9B0", VA = "0x182D2DBB0")]
	public int CAFKLEDEFJD(SceneTag OAALIIEEAME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x2D2DD50", Offset = "0x2D2CB50", VA = "0x182D2DD50")]
	protected void FAIMPFAEMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E170", Offset = "0x2D2CF70", VA = "0x182D2E170")]
	protected void NBGKHCPICHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x2D2DCC0", Offset = "0x2D2CAC0", VA = "0x182D2DCC0")]
	public NativeArrayAsync<Entity> EJDIEHNAIBO(SceneTag OAALIIEEAME, Allocator MBJMPHBLMBF = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E040", Offset = "0x2D2CE40", VA = "0x182D2E040")]
	public NativeArrayAsync<Entity> KALCCMBEHHF(SceneTag OAALIIEEAME, Allocator MBJMPHBLMBF = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x2D2DBD0", Offset = "0x2D2C9D0", VA = "0x182D2DBD0")]
	public bool CNAAJGPHOIB(SceneTag OAALIIEEAME, out NativeArrayAsync<Entity> FNEHIFGGEEN, Allocator MBJMPHBLMBF = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D2DB50", Offset = "0x2D2C950", VA = "0x182D2DB50")]
	public bool BIJLKKKABDK(Entity NEAKDKENHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E100", Offset = "0x2D2CF00", VA = "0x182D2E100")]
	public BOGOKBNBEFE MPNJHJOACKB(Entity NEAKDKENHHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E280", Offset = "0x2D2D080", VA = "0x182D2E280")]
	public bool OIBIDLDJMDF(Entity NEAKDKENHHP, out PBAJLJHEFKK FNEHIFGGEEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D2DD10", Offset = "0x2D2CB10", VA = "0x182D2DD10")]
	public void ENOCAFOAPNN(Entity NEAKDKENHHP, PBAJLJHEFKK FNEHIFGGEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E0A0", Offset = "0x2D2CEA0", VA = "0x182D2E0A0")]
	public bool MNEHBIKHLIJ(Entity NEAKDKENHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void KMKMHHNMKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public PPBEACIICIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class CGIAFINGNFB : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery MEDAIOLAEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private LCLOCHGKNKG BGEMPOFCNMN;

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB7B0", Offset = "0x2EBA5B0", VA = "0x182EBB7B0", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB870", Offset = "0x2EBA670", VA = "0x182EBB870", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB930", Offset = "0x2EBA730", VA = "0x182EBB930", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x26143A0", Offset = "0x26131A0", VA = "0x1826143A0")]
	private bool MNCBKICKAMM<TComponentData>(EntityQuery NOJJNNFMBAH, out NativeArray<Entity> KMDDIGFEEEI, out NativeArray<TComponentData> NACFHNCPJCH) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB800", Offset = "0x2EBA600", VA = "0x182EBB800")]
	public BOGOKBNBEFE MPNJHJOACKB(Entity NEAKDKENHHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public CGIAFINGNFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[DKGMECGHCPI(OJBFOICGDOF.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery GEGIJCNJKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery PNBJGNBBKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery FBOAAFNHLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery AIAEJKOKJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2770", Offset = "0x2FE1570", VA = "0x182FE2770", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2B90", Offset = "0x2FE1990", VA = "0x182FE2B90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2DC0", Offset = "0x2FE1BC0", VA = "0x182FE2DC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2B20", Offset = "0x2FE1920", VA = "0x182FE2B20")]
		private void OEECIDDHIAM(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2700", Offset = "0x2FE1500", VA = "0x182FE2700")]
		private void CJGLMEKHGBL(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2FE2D50", Offset = "0x2FE1B50", VA = "0x182FE2D50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2FE27C0", Offset = "0x2FE15C0", VA = "0x182FE27C0")]
		private void HJMBLIBCHLI(EntityQuery NOJJNNFMBAH, bool JNINJIMCJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal sealed class ICDGBNIMOPK : CENINKGGFPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct BCGEOADPLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		public BCGEOADPLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct EHDIMDIPOKN : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct LCDAJBKEFKI
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct CGDKELBHNHM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HJFHFFJBGOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime LEKCHEHFNDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime BGJBOEHLBNL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CPCIBADDPJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> AMAOIKMJDKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> EDMLGIDMKHD;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x44A8BC0", Offset = "0x44A79C0", VA = "0x1844A8BC0")]
			public void FBJFNGKGEAG(ICDGBNIMOPK KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x44A8C40", Offset = "0x44A7A40", VA = "0x1844A8C40")]
			public CGDKELBHNHM OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
			{
				return default(CGDKELBHNHM);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private LCDAJBKEFKI CEHPMGEJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LCDAJBKEFKI.CGDKELBHNHM* PAGEGEKEMGJ;

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x44A4960", Offset = "0x44A3760", VA = "0x1844A4960")]
		internal void OPBACEEAMEO(Entity BPCHDAFPJNL, SplineShapeData IDKOCJBGGJO, DynamicBuffer<LinkedEntityGroup> MMBEBPNKEHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x44A4880", Offset = "0x44A3680", VA = "0x1844A4880", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x44A49C0", Offset = "0x44A37C0", VA = "0x1844A49C0")]
		public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, [NoAlias] ref LCDAJBKEFKI.CGDKELBHNHM ICBLKLNOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x44A4950", Offset = "0x44A3750", VA = "0x1844A4950")]
		public void FBJFNGKGEAG(ICDGBNIMOPK KHKMOBDDHBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BALPEOPKPFL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct FALPNGAOJDA
		{
			[Cpp2IlInjected.Token(Token = "0x20000FB")]
			[NoAlias]
			public struct EPEJELAPFMN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MPNAICGBPLF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400030C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime JNDNOJEIBGD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity IDBGOBLGFJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> OPIIMOPAGLN;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x44A5410", Offset = "0x44A4210", VA = "0x1844A5410")]
			public void FBJFNGKGEAG(ICDGBNIMOPK KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x44A5470", Offset = "0x44A4270", VA = "0x1844A5470")]
			public EPEJELAPFMN OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
			{
				return default(EPEJELAPFMN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BufferFromEntity<LinkedEntityGroup> LAOPPMCHJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private FALPNGAOJDA CEHPMGEJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FALPNGAOJDA.EPEJELAPFMN* PAGEGEKEMGJ;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x44A1AB0", Offset = "0x44A08B0", VA = "0x1844A1AB0")]
		internal void OPBACEEAMEO(Entity DDDKKIPMBED, SplinePointParentData LKFMCEFFKOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x44A1BF0", Offset = "0x44A09F0", VA = "0x1844A1BF0", Slot = "5")]
		public void ReadFromDisplayClass(ref BCGEOADPLJJ DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x44A1980", Offset = "0x44A0780", VA = "0x1844A1980", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x44A1B40", Offset = "0x44A0940", VA = "0x1844A1B40")]
		public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, [NoAlias] ref FALPNGAOJDA.EPEJELAPFMN ICBLKLNOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x44A1A20", Offset = "0x44A0820", VA = "0x1844A1A20")]
		public void FBJFNGKGEAG(ICDGBNIMOPK KHKMOBDDHBP, ref BCGEOADPLJJ DBDHHAPIJND)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private EntityQuery NOJJNNFMBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery FKGOLPCNCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery EOPINEOJNOA;

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x32A97A0", Offset = "0x32A85A0", VA = "0x1832A97A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x32A9850", Offset = "0x32A8650", VA = "0x1832A9850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public ICDGBNIMOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x32A9500", Offset = "0x32A8300", VA = "0x1832A9500", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x32A9360", Offset = "0x32A8160", VA = "0x1832A9360")]
	public static EntityQuery KELJGMDKDJA(ComponentSystemBase KHKMOBDDHBP)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x32A9A90", Offset = "0x32A8890", VA = "0x1832A9A90")]
	public static EntityQuery PCFAJKCIOPP(ComponentSystemBase KHKMOBDDHBP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
public sealed class KMCHHDHBPFI : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private EHGPJENGIMI NKHACCELHCE;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x32B1650", Offset = "0x32B0450", VA = "0x1832B1650", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x32B16B0", Offset = "0x32B04B0", VA = "0x1832B16B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public KMCHHDHBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class GGBEHAMIPGA : CENINKGGFPK, NEGCPFIDGDD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct MCDDNCALNIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<OIFPFJGMJPN> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NativeList<PHPDCDGCNKA> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NativeList<OIFPFJGMJPN> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		public MCDDNCALNIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, PCOKOPHGBCI previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
		internal void <OnUpdate>b__2(Entity entity, PCOKOPHGBCI previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct HGPLJNFBKGC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct HGMNBDHHJLO
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct IAOHBPHGOMA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400031A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LPBAJAEJLFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400031B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime BGLAMNJKFGI;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity GPILJGHOMAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> OPNDJAPBGCA;

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x44A7310", Offset = "0x44A6110", VA = "0x1844A7310")]
			public void FBJFNGKGEAG(GGBEHAMIPGA KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x44A7370", Offset = "0x44A6170", VA = "0x1844A7370")]
			public IAOHBPHGOMA OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
			{
				return default(IAOHBPHGOMA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeList<OIFPFJGMJPN> JEHEJJDICHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private HGMNBDHHJLO CEHPMGEJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HGMNBDHHJLO.IAOHBPHGOMA* PAGEGEKEMGJ;

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x44A7520", Offset = "0x44A6320", VA = "0x1844A7520")]
		internal void OPBACEEAMEO(Entity NEAKDKENHHP, ParentData KAHIPMIDNOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x1213BF0", Offset = "0x12129F0", VA = "0x181213BF0", Slot = "5")]
		public void ReadFromDisplayClass(ref MCDDNCALNIL DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x44A73F0", Offset = "0x44A61F0", VA = "0x1844A73F0", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x44A75A0", Offset = "0x44A63A0", VA = "0x1844A75A0")]
		public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, [NoAlias] ref HGMNBDHHJLO.IAOHBPHGOMA ICBLKLNOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x44A7490", Offset = "0x44A6290", VA = "0x1844A7490")]
		public void FBJFNGKGEAG(GGBEHAMIPGA KHKMOBDDHBP, ref MCDDNCALNIL DBDHHAPIJND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MLMNHGMOIGB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct MLNBNCOJDHF
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct DIAMMHNJBFD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LPBAJAEJLFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime BGLAMNJKFGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<PCOKOPHGBCI>.Runtime DMMENFKNBLK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity GPILJGHOMAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> OPNDJAPBGCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<PCOKOPHGBCI> AKGEPCMKOFP;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x44AB4B0", Offset = "0x44AA2B0", VA = "0x1844AB4B0")]
			public void FBJFNGKGEAG(GGBEHAMIPGA KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x44AB530", Offset = "0x44AA330", VA = "0x1844AB530")]
			public DIAMMHNJBFD OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
			{
				return default(DIAMMHNJBFD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NativeList<PHPDCDGCNKA> NCMOIIJGMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private MLNBNCOJDHF CEHPMGEJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MLNBNCOJDHF.DIAMMHNJBFD* PAGEGEKEMGJ;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x44AB300", Offset = "0x44AA100", VA = "0x1844AB300")]
		internal void OPBACEEAMEO(Entity NEAKDKENHHP, ParentData KAHIPMIDNOL, PCOKOPHGBCI IJAHNJPEPDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x44AB4A0", Offset = "0x44AA2A0", VA = "0x1844AB4A0", Slot = "5")]
		public void ReadFromDisplayClass(ref MCDDNCALNIL DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x44AB1F0", Offset = "0x44A9FF0", VA = "0x1844AB1F0", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x44AB3C0", Offset = "0x44AA1C0", VA = "0x1844AB3C0")]
		public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, [NoAlias] ref MLNBNCOJDHF.DIAMMHNJBFD ICBLKLNOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x44AB2C0", Offset = "0x44AA0C0", VA = "0x1844AB2C0")]
		public void FBJFNGKGEAG(GGBEHAMIPGA KHKMOBDDHBP, ref MCDDNCALNIL DBDHHAPIJND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PLLPDMPEFEL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private struct ELCACGKMOOG
		{
			[Cpp2IlInjected.Token(Token = "0x2000107")]
			[NoAlias]
			public struct DMOHOEHNMNG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LPBAJAEJLFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<PCOKOPHGBCI>.Runtime DMMENFKNBLK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity GPILJGHOMAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<PCOKOPHGBCI> AKGEPCMKOFP;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x44A4AE0", Offset = "0x44A38E0", VA = "0x1844A4AE0")]
			public void FBJFNGKGEAG(GGBEHAMIPGA KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x44A4B40", Offset = "0x44A3940", VA = "0x1844A4B40")]
			public DMOHOEHNMNG OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
			{
				return default(DMOHOEHNMNG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NativeList<OIFPFJGMJPN> ONDPPNKIJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private ELCACGKMOOG CEHPMGEJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ELCACGKMOOG.DMOHOEHNMNG* PAGEGEKEMGJ;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x44AD910", Offset = "0x44AC710", VA = "0x1844AD910")]
		internal void OPBACEEAMEO(Entity NEAKDKENHHP, PCOKOPHGBCI IJAHNJPEPDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x44ADA40", Offset = "0x44AC840", VA = "0x1844ADA40", Slot = "5")]
		public void ReadFromDisplayClass(ref MCDDNCALNIL DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x44AD7E0", Offset = "0x44AC5E0", VA = "0x1844AD7E0", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x44AD990", Offset = "0x44AC790", VA = "0x1844AD990")]
		public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, [NoAlias] ref ELCACGKMOOG.DMOHOEHNMNG ICBLKLNOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x44AD880", Offset = "0x44AC680", VA = "0x1844AD880")]
		public void FBJFNGKGEAG(GGBEHAMIPGA KHKMOBDDHBP, ref MCDDNCALNIL DBDHHAPIJND)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private CICKPKKFIHK MFDDCHDPLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery NFNKFAIIMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery BODKBGGOOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery HOKABANNEOG;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x32A1A50", Offset = "0x32A0850", VA = "0x1832A1A50", Slot = "14")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x32A2220", Offset = "0x32A1020", VA = "0x1832A2220", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public GGBEHAMIPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x32A21C0", Offset = "0x32A0FC0", VA = "0x1832A21C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x32A1D30", Offset = "0x32A0B30", VA = "0x1832A1D30")]
	public static EntityQuery LPLGGMGHCEL(ComponentSystemBase KHKMOBDDHBP)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x32A1F90", Offset = "0x32A0D90", VA = "0x1832A1F90")]
	public static EntityQuery NOCGIKAGMHG(ComponentSystemBase KHKMOBDDHBP)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x32A1B30", Offset = "0x32A0930", VA = "0x1832A1B30")]
	public static EntityQuery JAGHEBNCIFO(ComponentSystemBase KHKMOBDDHBP)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[DKGMECGHCPI(OJBFOICGDOF.Connectables)]
	public class InitializeRigidbodyExHierarchy : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EntityQuery NOJJNNFMBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private AJBMOLCDKGM BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x32AC570", Offset = "0x32AB370", VA = "0x1832AC570", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x32AC500", Offset = "0x32AB300", VA = "0x1832AC500", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x32AC600", Offset = "0x32AB400", VA = "0x1832AC600", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class DFMFJPOGMME : ParentSystemBase<ParentData, PCOKOPHGBCI, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB0F0", Offset = "0x2EC9EF0", VA = "0x182ECB0F0", Slot = "14")]
	protected override EntityQueryDesc BHECJKFKMLG(EntityQueryDesc NOJJNNFMBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x803DB0", Offset = "0x802BB0", VA = "0x180803DB0", Slot = "15")]
	protected override EntityQueryDesc EEBBLHBDKPE(EntityQueryDesc NOJJNNFMBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB170", Offset = "0x2EC9F70", VA = "0x182ECB170", Slot = "16")]
	protected override EntityQueryDesc IEHCDPANPPB(EntityQueryDesc NOJJNNFMBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB130", Offset = "0x2EC9F30", VA = "0x182ECB130", Slot = "17")]
	protected override EntityQueryDesc GHCOLLOCGLO(EntityQueryDesc NOJJNNFMBAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB1F0", Offset = "0x2EC9FF0", VA = "0x182ECB1F0")]
	public DFMFJPOGMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB1B0", Offset = "0x2EC9FB0", VA = "0x182ECB1B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : CENINKGGFPK where ParentData : struct, IComponentData, GGMPGKPHADB where PreviousParentData : struct, IComponentData, GGMPGKPHADB where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, GGMPGKPHADB
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct KJEKMOAIPBF : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter GFGEHLCILFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter DONOKFKBBAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public NativeHashMap<Entity, int>.ParallelWriter IOIDKDIOAAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ArchetypeChunkComponentType<PreviousParentData> DHIJLMDBHNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> CPFMCAEGJEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public ArchetypeChunkEntityType JOPBNHFCKDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public uint CEMBNPIOMHK;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x3007F10", Offset = "0x3006D10", VA = "0x183007F10", Slot = "4")]
			public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[BurstCompile]
		private struct GPHIDOINFGI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> IOIDKDIOAAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> LPMKFBBONJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public NativeList<Entity> FOCEHPFHCND;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x47936B0", Offset = "0x47924B0", VA = "0x1847936B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		private struct OMBICMHOFKD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> GFGEHLCILFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> DONOKFKBBAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeHashMap<Entity, int> IOIDKDIOAAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BufferFromEntity<ChildrenData> LPMKFBBONJK;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x2547EF0", Offset = "0x2546CF0", VA = "0x182547EF0")]
			private int KJBGLHPKGOP(DynamicBuffer<ChildrenData> NFHDJMINDPN, Entity NEAKDKENHHP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x2548110", Offset = "0x2546F10", VA = "0x182548110")]
			private void KJJPPOJHFFD(Entity GANAMHNGMGO, DynamicBuffer<ChildrenData> NFHDJMINDPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x25483D0", Offset = "0x25471D0", VA = "0x1825483D0")]
			private void PEGEOLHPLGH(Entity GANAMHNGMGO, DynamicBuffer<ChildrenData> NFHDJMINDPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x2547C30", Offset = "0x2546A30", VA = "0x182547C30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[BurstCompile]
		private struct MDBCNMLDIEB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeArray<Entity> KMKBHFHKAMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public NativeList<Entity> BJGJELGHKHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public BufferFromEntity<ChildrenData> LPMKFBBONJK;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x2CDF730", Offset = "0x2CDE530", VA = "0x182CDF730", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery CNKPMJKJEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery BLNEEBOJAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery PONGKJCFLOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected EntityQuery EAMDFMFECJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker AAICBAKGMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker EJBDIALJPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker MBCFNFBCCIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected ProfilerMarker DFFAJGKIPLF;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x2A30B50", Offset = "0x2A2F950", VA = "0x182A30B50")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x2A30330", Offset = "0x2A2F130", VA = "0x182A30330")]
		private int KJBGLHPKGOP(DynamicBuffer<ChildrenData> NFHDJMINDPN, Entity NEAKDKENHHP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F730", Offset = "0x2A2E530", VA = "0x182A2F730")]
		private void ICHLEBGFGEE(Entity IFACDCGJDKK, Entity GFHLMIHGDAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x803DB0", Offset = "0x802BB0", VA = "0x180803DB0", Slot = "14")]
		protected virtual EntityQueryDesc BHECJKFKMLG(EntityQueryDesc NOJJNNFMBAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x803DB0", Offset = "0x802BB0", VA = "0x180803DB0", Slot = "15")]
		protected virtual EntityQueryDesc EEBBLHBDKPE(EntityQueryDesc NOJJNNFMBAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x803DB0", Offset = "0x802BB0", VA = "0x180803DB0", Slot = "16")]
		protected virtual EntityQueryDesc IEHCDPANPPB(EntityQueryDesc NOJJNNFMBAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc GHCOLLOCGLO(EntityQueryDesc NOJJNNFMBAH);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x2A30510", Offset = "0x2A2F310", VA = "0x182A30510", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F660", Offset = "0x2A2E460", VA = "0x182A2F660")]
		private void HDAMDBECDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x2A30170", Offset = "0x2A2EF70", VA = "0x182A30170")]
		private void KACBFHMFOEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F060", Offset = "0x2A2DE60", VA = "0x182A2F060")]
		private JobHandle DAMEGMCDAII(JobHandle DABCHKJGFPM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2A2FCD0", Offset = "0x2A2EAD0", VA = "0x182A2FCD0")]
		private void JHIMOIKOHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2A30A80", Offset = "0x2A2F880", VA = "0x182A30A80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2A30A50", Offset = "0x2A2F850", VA = "0x182A30A50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x1058C20", Offset = "0x1057A20", VA = "0x181058C20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[AlwaysUpdateSystem]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
public abstract class MBMFLIJKLGP : CENINKGGFPK, NEGCPFIDGDD
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct NCGLFKKDEPI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> BHBNBBMAJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> FBKCHCFHJBG;

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x44ABBE0", Offset = "0x44AA9E0", VA = "0x1844ABBE0")]
		public NCGLFKKDEPI(NativeList<Entity> BHBNBBMAJMH, NativeList<Entity> FBKCHCFHJBG, JobHandle BACBCMPFGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x44ABB60", Offset = "0x44AA960", VA = "0x1844ABB60")]
		public JobHandle IBMAMFEAKKM(JobHandle DABCHKJGFPM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x44ABAD0", Offset = "0x44AA8D0", VA = "0x1844ABAD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct MCILKLIEAKM : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[Flags]
		public enum DIBBOGDFOCM
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
		public NativeList<Entity> FGEJFBEJMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> IHHHLABLKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> EAPKMALNBEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> AIOIGCPMMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity BIBMEEEIGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity AFFEOLCGMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> AOBJNCJHOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int JNADLJIFFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int HPAFCLEMCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private DIBBOGDFOCM EICGMFLDELE;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x44AA850", Offset = "0x44A9650", VA = "0x1844AA850", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x44AAA60", Offset = "0x44A9860", VA = "0x1844AAA60")]
		private void IAGOFCKHNFP(Entity NEAKDKENHHP, bool CIEMDMDPGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x44AAAF0", Offset = "0x44A98F0", VA = "0x1844AAAF0")]
		private void JGGLKHJHCPA(Entity NEAKDKENHHP, bool CIEMDMDPGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x44AA490", Offset = "0x44A9290", VA = "0x1844AA490")]
		public NCGLFKKDEPI BFFGPGNGOKI(NativeArray<Entity> ENPKPDCDBJB, JobHandle DABCHKJGFPM)
		{
			return default(NCGLFKKDEPI);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x44AA9E0", Offset = "0x44A97E0", VA = "0x1844AA9E0")]
		public NCGLFKKDEPI FGIAICPFMJM(NativeArray<Entity> ENPKPDCDBJB, JobHandle DABCHKJGFPM)
		{
			return default(NCGLFKKDEPI);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x44AA510", Offset = "0x44A9310", VA = "0x1844AA510")]
		public NCGLFKKDEPI CBONNBJOPPD(NativeList<OIFPFJGMJPN> MPMKGFKPBEN, JobHandle DABCHKJGFPM)
		{
			return default(NCGLFKKDEPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x44AAC00", Offset = "0x44A9A00", VA = "0x1844AAC00")]
		public NCGLFKKDEPI KCCKAAFKBPB(NativeList<OIFPFJGMJPN> MPMKGFKPBEN, JobHandle DABCHKJGFPM)
		{
			return default(NCGLFKKDEPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x44AACE0", Offset = "0x44A9AE0", VA = "0x1844AACE0")]
		public NCGLFKKDEPI KIHDHFLDBDN(NativeList<PHPDCDGCNKA> MPMKGFKPBEN, JobHandle DABCHKJGFPM)
		{
			return default(NCGLFKKDEPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x597AAC0", Offset = "0x59798C0", VA = "0x18597AAC0")]
		private NCGLFKKDEPI EILCFLFJLNK<T>(NativeList<T> MPMKGFKPBEN, int NKACMCAEILF, int MBCMENGLGAO, DIBBOGDFOCM LHDFDDPEACL, JobHandle DABCHKJGFPM) where T : struct
		{
			return default(NCGLFKKDEPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x44AA5F0", Offset = "0x44A93F0", VA = "0x1844AA5F0")]
		private NCGLFKKDEPI EILCFLFJLNK(NativeArray<Entity> KMDDIGFEEEI, int NKACMCAEILF, int MBCMENGLGAO, DIBBOGDFOCM LHDFDDPEACL, JobHandle DABCHKJGFPM)
		{
			return default(NCGLFKKDEPI);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly FGEMECIGOCC EKOKIILLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery HJJKLCDAKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery LAJNKIKGEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private CICKPKKFIHK BDLELKBPMHG;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected abstract ComponentType INNPLHHJJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract ComponentType FOGFKHBLBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected abstract ComponentType OJPEAJKJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x2D19D40", Offset = "0x2D18B40", VA = "0x182D19D40")]
	protected MBMFLIJKLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2D18900", Offset = "0x2D17700", VA = "0x182D18900", Slot = "14")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2D18CA0", Offset = "0x2D17AA0", VA = "0x182D18CA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2D18ED0", Offset = "0x2D17CD0", VA = "0x182D18ED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x7D3440", Offset = "0x7D2240", VA = "0x1807D3440", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2D185B0", Offset = "0x2D173B0", VA = "0x182D185B0")]
	private void ACIIKDCOHIJ(NativeArray<Entity> MPMKGFKPBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2D18610", Offset = "0x2D17410", VA = "0x182D18610")]
	private void AHHGEHHEFGG(NativeArray<Entity> MPMKGFKPBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2D18B60", Offset = "0x2D17960", VA = "0x182D18B60")]
	private void OLHAMLDDOLD(NCGLFKKDEPI LAEJJFIIDOG, string KIMCFMFLGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2D18A50", Offset = "0x2D17850", VA = "0x182D18A50")]
	private void OLHAMLDDOLD(NativeListAsync<Entity> PLFPKAJFFCD, string KIMCFMFLGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x2D186B0", Offset = "0x2D174B0", VA = "0x182D186B0")]
	private void ALDJILJCMPC(NCGLFKKDEPI LAEJJFIIDOG, string KIMCFMFLGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x2D187F0", Offset = "0x2D175F0", VA = "0x182D187F0")]
	private void ALDJILJCMPC(NativeListAsync<Entity> PLFPKAJFFCD, string KIMCFMFLGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2D189E0", Offset = "0x2D177E0", VA = "0x182D189E0")]
	private bool NEDOGCEEHBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
public class LFBIGGIEFBE : CENINKGGFPK, JPLAKHLHFLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct DODJJHPOBIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public LFBIGGIEFBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		public DODJJHPOBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FDELFCLKCIC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct DDCHMPBMMDH
		{
			[Cpp2IlInjected.Token(Token = "0x2000117")]
			public struct AKECOLBHDMJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime GMKHMJBDNAL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity KGLBMAGGLAF;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x44A3730", Offset = "0x44A2530", VA = "0x1844A3730")]
			public void FBJFNGKGEAG(LFBIGGIEFBE KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x44A3740", Offset = "0x44A2540", VA = "0x1844A3740")]
			public AKECOLBHDMJ OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
			{
				return default(AKECOLBHDMJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public LFBIGGIEFBE BGDLJHFPCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EntityCommandBuffer HCJDENFDFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private DDCHMPBMMDH CEHPMGEJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe DDCHMPBMMDH.AKECOLBHDMJ* PAGEGEKEMGJ;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LMEJDEJHIBP;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x44A5A80", Offset = "0x44A4880", VA = "0x1844A5A80")]
		internal void OPBACEEAMEO(Entity EBHODPHNEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x44A5C00", Offset = "0x44A4A00", VA = "0x1844A5C00", Slot = "5")]
		public void ReadFromDisplayClass(ref DODJJHPOBIM DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x44A5C30", Offset = "0x44A4A30", VA = "0x1844A5C30", Slot = "6")]
		public void WriteToDisplayClass(ref DODJJHPOBIM DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x44A5980", Offset = "0x44A4780", VA = "0x1844A5980", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x44A5B90", Offset = "0x44A4990", VA = "0x1844A5B90")]
		public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, ref DDCHMPBMMDH.AKECOLBHDMJ ICBLKLNOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x44A59D0", Offset = "0x44A47D0", VA = "0x1844A59D0")]
		public void FBJFNGKGEAG(LFBIGGIEFBE KHKMOBDDHBP, ref DODJJHPOBIM DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x44A5A10", Offset = "0x44A4810", VA = "0x1844A5A10")]
		public unsafe static void HNMDANPFJNG(ArchetypeChunkIterator* DDBGPMPNMAB, void* HHAGMJBBFIP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private ELJDMGECPFM OINLFDIEEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EOEMDGEDOLM AINJAMGLMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery NKBJEFEGPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private ProfilerMarker LBFMLAODOEE;

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x32B66A0", Offset = "0x32B54A0", VA = "0x1832B66A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x32B6390", Offset = "0x32B5190", VA = "0x1832B6390", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x32B6700", Offset = "0x32B5500", VA = "0x1832B6700", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public LFBIGGIEFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x32B65C0", Offset = "0x32B53C0", VA = "0x1832B65C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x32B63F0", Offset = "0x32B51F0", VA = "0x1832B63F0")]
	public static EntityQuery GMEKDNGKMNM(ComponentSystemBase KHKMOBDDHBP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[AJHMADEHCDB]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
public class LJFPKMCMALC : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private EOEMDGEDOLM AINJAMGLMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private SceneService GOCPDFPAIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery NOJJNNFMBAH;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x32B6B20", Offset = "0x32B5920", VA = "0x1832B6B20", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x32B6B90", Offset = "0x32B5990", VA = "0x1832B6B90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x32B6C30", Offset = "0x32B5A30", VA = "0x1832B6C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public LJFPKMCMALC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public struct KKPEKAIEJBC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public OANHODMBAGD EAHLOGLBEGD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x740000", Offset = "0x73EE00", VA = "0x180740000")]
	public static KKPEKAIEJBC JMLJLLKELMG(in OANHODMBAGD PFIBEBILFLK)
	{
		return default(KKPEKAIEJBC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x740000", Offset = "0x73EE00", VA = "0x180740000")]
	public static OANHODMBAGD JMLJLLKELMG(in KKPEKAIEJBC GGDKIADHEGH)
	{
		return default(OANHODMBAGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[AlwaysUpdateSystem]
public class ELJDMGECPFM : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x2ED31E0", Offset = "0x2ED1FE0", VA = "0x182ED31E0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0")]
	public ELJDMGECPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[AlwaysUpdateSystem]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
public class KPEHMCJJANK : CENINKGGFPK, JPLAKHLHFLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct OLDMMMDCIIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public KPEHMCJJANK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		public OLDMMMDCIIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
		internal void <OnUpdate>b__0(Entity e, KKPEKAIEJBC ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct NIIJKEJBPPM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct KBFNFHBFDPK
		{
			[Cpp2IlInjected.Token(Token = "0x200011F")]
			public struct DDJFEBPEJHL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				public LambdaParameterValueProvider_Entity.Runtime GMKHMJBDNAL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public LambdaParameterValueProvider_IComponentData<KKPEKAIEJBC>.Runtime PDHNIGPHCFA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity KGLBMAGGLAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<KKPEKAIEJBC> DEIFBBLEOKH;

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x44A84B0", Offset = "0x44A72B0", VA = "0x1844A84B0")]
			public void FBJFNGKGEAG(KPEHMCJJANK KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x44A8510", Offset = "0x44A7310", VA = "0x1844A8510")]
			public DDJFEBPEJHL OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
			{
				return default(DDJFEBPEJHL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public KPEHMCJJANK BGDLJHFPCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EntityCommandBuffer HCJDENFDFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private KBFNFHBFDPK CEHPMGEJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KBFNFHBFDPK.DDJFEBPEJHL* PAGEGEKEMGJ;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LMEJDEJHIBP;

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x44AC280", Offset = "0x44AB080", VA = "0x1844AC280")]
		internal void OPBACEEAMEO(Entity EBHODPHNEOL, KKPEKAIEJBC FDDDHGKHBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x44A5C00", Offset = "0x44A4A00", VA = "0x1844A5C00", Slot = "5")]
		public void ReadFromDisplayClass(ref OLDMMMDCIIC DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x44A5C30", Offset = "0x44A4A30", VA = "0x1844A5C30", Slot = "6")]
		public void WriteToDisplayClass(ref OLDMMMDCIIC DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x44AC0E0", Offset = "0x44AAEE0", VA = "0x1844AC0E0", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x44AC380", Offset = "0x44AB180", VA = "0x1844AC380")]
		public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, ref KBFNFHBFDPK.DDJFEBPEJHL ICBLKLNOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x44AC180", Offset = "0x44AAF80", VA = "0x1844AC180")]
		public void FBJFNGKGEAG(KPEHMCJJANK KHKMOBDDHBP, ref OLDMMMDCIIC DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x44AC210", Offset = "0x44AB010", VA = "0x1844AC210")]
		public unsafe static void HNMDANPFJNG(ArchetypeChunkIterator* DDBGPMPNMAB, void* HHAGMJBBFIP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private ELJDMGECPFM OINLFDIEEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private EOEMDGEDOLM AINJAMGLMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery BIPFBCKEJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private ProfilerMarker DNAJLKPEJPM;

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x32B2A90", Offset = "0x32B1890", VA = "0x1832B2A90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x32B2950", Offset = "0x32B1750", VA = "0x1832B2950", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x32B2AF0", Offset = "0x32B18F0", VA = "0x1832B2AF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public KPEHMCJJANK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x32B29B0", Offset = "0x32B17B0", VA = "0x1832B29B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x32B2780", Offset = "0x32B1580", VA = "0x1832B2780")]
	public static EntityQuery BJBGBIOKPNB(ComponentSystemBase KHKMOBDDHBP)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct AKLEHPACCFF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public PGIDFFDFCKO LPMGOCJAKCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public NativeHashMap<Entity, JCKJOPOBLHO> KMDDIGFEEEI;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x44A10B0", Offset = "0x449FEB0", VA = "0x1844A10B0")]
			public AKLEHPACCFF(int JNGKGNOBDKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x44A1030", Offset = "0x449FE30", VA = "0x1844A1030", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct MPNBKBOLDOK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public NativeArray<Entity> KMDDIGFEEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> GIOLFPEKPMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> AAJCHHGMONH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> FPBMJEJOBMN;

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x44AB930", Offset = "0x44AA730", VA = "0x1844AB930", Slot = "4")]
			public void Execute(int NNHNOIMLALG, TransformAccess KGHIPKNMKHP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct LKHDFAMIMGO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public NativeArray<Entity> KMDDIGFEEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> GIOLFPEKPMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> FPBMJEJOBMN;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x44A92B0", Offset = "0x44A80B0", VA = "0x1844A92B0", Slot = "4")]
			public void Execute(int NNHNOIMLALG, TransformAccess KGHIPKNMKHP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private EOEMDGEDOLM AINJAMGLMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery LEJMGPDOGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery KCHCHPDPGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery GJAPHDPPMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery OFPJNNMGBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery HCEEDGLMCNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private JobHandle JFPMGGNHGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private AKLEHPACCFF DBNBHMFEGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private AKLEHPACCFF BKGDBJBLACI;

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2D30220", Offset = "0x2D2F020", VA = "0x182D30220", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2D30940", Offset = "0x2D2F740", VA = "0x182D30940", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2D303B0", Offset = "0x2D2F1B0", VA = "0x182D303B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2D30C00", Offset = "0x2D2FA00", VA = "0x182D30C00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FE40", Offset = "0x2D2EC40", VA = "0x182D2FE40")]
		private void AJLNFOACMAO(EntityQuery NOJJNNFMBAH, out (NativeArrayAsync<KKPEKAIEJBC> handles, NativeArrayAsync<HOMIJDPJNNL> bounds) MMJOHADFCHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2D303F0", Offset = "0x2D2F1F0", VA = "0x182D303F0")]
		private void LDFPIKAAAAB((NativeArrayAsync<KKPEKAIEJBC> handles, NativeArrayAsync<HOMIJDPJNNL> bounds) MMJOHADFCHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x2D303B0", Offset = "0x2D2F1B0", VA = "0x182D303B0")]
		private void KCLJNCBBPHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x2D300E0", Offset = "0x2D2EEE0", VA = "0x182D300E0")]
		private void DFGAOOCPMIN(EntityQuery NOJJNNFMBAH, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<KKPEKAIEJBC> handles) MMJOHADFCHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2D30650", Offset = "0x2D2F450", VA = "0x182D30650")]
		private void NKEMLKHACCC((NativeArrayAsync<Entity> entities, NativeArrayAsync<KKPEKAIEJBC> handles) MMJOHADFCHO, AKLEHPACCFF EGKBGLGDJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FF80", Offset = "0x2D2ED80", VA = "0x182D2FF80")]
		private JobHandle BEJLIDKNDGN(AKLEHPACCFF EGKBGLGDJLL, ComponentDataFromEntity<WorldPoseData> GIOLFPEKPMK, ComponentDataFromEntity<WorldUniformScaleData> FPBMJEJOBMN, ComponentDataFromEntity<WorldDeformableScaleData> AAJCHHGMONH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2D30280", Offset = "0x2D2F080", VA = "0x182D30280")]
		private JobHandle JFKDNMMNBKD(AKLEHPACCFF EGKBGLGDJLL, ComponentDataFromEntity<WorldPoseData> GIOLFPEKPMK, ComponentDataFromEntity<WorldUniformScaleData> FPBMJEJOBMN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct EHHKGKDJALF : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[AJHMADEHCDB]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	public class SplineLocalBoundsSystem : CENINKGGFPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile]
		private struct PPEGJFAPBJH : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public NativeArray<Entity> LIPFAMEOGGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> KBHIFFMIFNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			[ReadOnly]
			public ComponentDataFromEntity<HOMIJDPJNNL> FFPHDAENPIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[WriteOnly]
			public NativeHashMap<Entity, JCKJOPOBLHO>.ParallelWriter JFLMDMBFPNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter HNHOBAPOEFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter PEABKAAMGHH;

			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x44ADBB0", Offset = "0x44AC9B0", VA = "0x1844ADBB0", Slot = "4")]
			public void Execute(int NNHNOIMLALG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[BurstCompile]
		private struct KFBJDIBPEDD : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public NativeArray<Entity> POKAJMEJPIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> DGPECAOBBLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> PMNMELGAEFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> MAHKMDCFCHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<HOMIJDPJNNL> JOCHCOJJGAM;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x44A8590", Offset = "0x44A7390", VA = "0x1844A8590", Slot = "4")]
			public void Execute(int NNHNOIMLALG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery AIJGLMDFBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery GIJPGIHOKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery AHNCPHNNJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery MEIEJPEICCJ;

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2FE4890", Offset = "0x2FE3690", VA = "0x182FE4890", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2FE4AA0", Offset = "0x2FE38A0", VA = "0x182FE4AA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2FE45D0", Offset = "0x2FE33D0", VA = "0x182FE45D0")]
		private JobHandle MHLNENBKDAA(NativeArrayAsync<Entity> PALKODKBAJM, int PFLGNDMCMIN, JobHandle DABCHKJGFPM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2FE46B0", Offset = "0x2FE34B0", VA = "0x182FE46B0")]
		private JobHandle MHLNENBKDAA(NativeArray<Entity> NEDGPJFOBDF, int PFLGNDMCMIN, [Optional] JobHandle DABCHKJGFPM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2FE5420", Offset = "0x2FE4220", VA = "0x182FE5420")]
		private NativeArrayAsync<Entity> PJPHKGDBDDL(EntityQuery NOJJNNFMBAH)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x2FE54A0", Offset = "0x2FE42A0", VA = "0x182FE54A0")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) PMAIIJLKLHF(NativeArrayAsync<Entity> JPHIIPEMKFB)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x2FE43E0", Offset = "0x2FE31E0", VA = "0x182FE43E0")]
		private void EAIPOGIBHJC(out NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2FE4470", Offset = "0x2FE3270", VA = "0x182FE4470")]
		private void FOAIDOICEJA(NativeList<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2FE4500", Offset = "0x2FE3300", VA = "0x182FE4500")]
		private void FOAIDOICEJA(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2FE4FC0", Offset = "0x2FE3DC0", VA = "0x182FE4FC0")]
		private void PFIMGEGGKNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		private static void HPOOOGJJHAK(int OCLPFJBLOGP, int FOHFCAEDFCE, int HGPIEDLJEGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x2FE50F0", Offset = "0x2FE3EF0", VA = "0x182FE50F0")]
		private static HOMIJDPJNNL PJHLBCBGKNO(NativeArray<Entity> FDKNCPCHGLO, ComponentDataFromEntity<SplinePointPositionData> PMNMELGAEFE, ComponentDataFromEntity<SplinePointScaleData> MAHKMDCFCHP)
		{
			return default(HOMIJDPJNNL);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct DPBKFEBHHNF : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[AJHMADEHCDB]
	[DKGMECGHCPI(OJBFOICGDOF.Lifecycle)]
	public class DestroyLocalObjects : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[DNEBGGIIGBA]
		private ObjectNetworkToLocalMapService JJPJMEBEPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[DNEBGGIIGBA]
		private ObjectLifecycleService LHNDLBANJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private EntityQuery BGDHBHACMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery AMOAHKIHIDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery AIAEJKOKJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool LINNMJPFKHN;

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x2ECDA80", Offset = "0x2ECC880", VA = "0x182ECDA80", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2ECD9D0", Offset = "0x2ECC7D0", VA = "0x182ECD9D0")]
		public bool CJMMJJKLAAJ(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2ECDE10", Offset = "0x2ECCC10", VA = "0x182ECDE10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x2ECDCC0", Offset = "0x2ECCAC0", VA = "0x182ECDCC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2ECDF40", Offset = "0x2ECCD40", VA = "0x182ECDF40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x11DFFD0", Offset = "0x11DEDD0", VA = "0x1811DFFD0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2ECDCC0", Offset = "0x2ECCAC0", VA = "0x182ECDCC0")]
		private void KBGADOBNDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2ECDAF0", Offset = "0x2ECC8F0", VA = "0x182ECDAF0")]
		private void FHGJMHHJJGO(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2ECDF60", Offset = "0x2ECCD60", VA = "0x182ECDF60")]
		private void PLLFNCGJJAA(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2ECDD00", Offset = "0x2ECCB00", VA = "0x182ECDD00")]
		private void MDGEGFIAKGD(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2ECDBA0", Offset = "0x2ECC9A0", VA = "0x182ECDBA0")]
		private void IBJJDABDFMI(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[DKGMECGHCPI(OJBFOICGDOF.NetworkSend)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	public sealed class EnqueuePropertyDifferenceToNetwork : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private static KKOEPHEHHNN[] KJPAALEEFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private OMACKAJHNPM APKILFOODPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private HJJNHNANFFG JGDLCHPGHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PropertyDiffStateService NLHBFABKJKJ;

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x329AF50", Offset = "0x3299D50", VA = "0x18329AF50", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x329B590", Offset = "0x329A390", VA = "0x18329B590", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x329B000", Offset = "0x3299E00", VA = "0x18329B000")]
		private void JKLFLLMFGMH(KKOEPHEHHNN IGKPCADJEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		private void AMDHDNJKHDH(Entity NEAKDKENHHP, MFDODOEBKCJ FIIEHBGLOHB, ANKHGKIKDDO CKFDCLEBNMD, KLMKJNOOIJN GFIDBHLLFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[DKGMECGHCPI(OJBFOICGDOF.Callbacks)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	public sealed class PropertyEventCallbacks : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private PropertyEventCallbacksService GPCKGMCLNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private PropertyDiffStateService NLHBFABKJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TransformOwnershipPhase IGKPCADJEGG;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D368D0", Offset = "0x2D356D0", VA = "0x182D368D0", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D36960", Offset = "0x2D35760", VA = "0x182D36960", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[DKGMECGHCPI(OJBFOICGDOF.NetworkSend)]
	internal class TransmitNetworkDataSystem : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private KBEAAEAADAB BDBMDABLPFJ;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC7D0", Offset = "0x2FEB5D0", VA = "0x182FEC7D0", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC820", Offset = "0x2FEB620", VA = "0x182FEC820", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[AJHMADEHCDB]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	public class CalculateCullingBandChanges : CENINKGGFPK, MDEPDIFNFKG, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct JEPFFGHJADO : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ArchetypeChunkEntityType IJHOOCADGNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> GFFIJEJFMKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[WriteOnly]
			public NativeList<IFOFHCJELOG>.ParallelWriter LHBKPNBKOEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public ArchetypeChunkComponentType<HLBPABEEOOJ> OBBBJBBFPAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public float3 ONDHOAIGIEB;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private static readonly float4x2 MFCDDEAAPPH;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private static readonly float4x2 HJDJCPOFEFL;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private static readonly int4x2 GEAPGBGPIOE;

			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x2FDA470", Offset = "0x2FD9270", VA = "0x182FDA470", Slot = "4")]
			public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private static FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const int NJAGBAFKBLL = 10;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private const double GHPNCMJPMLN = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery DENONOHCMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery COIAFLJLFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private double CHLLEMOFAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private CullingBandService OJLLEEBOPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TimeService KJGEPMINMNI;

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD810", Offset = "0x2EBC610", VA = "0x182EBD810", Slot = "14")]
		public void NIACEKGLEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD780", Offset = "0x2EBC580", VA = "0x182EBD780", Slot = "15")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD890", Offset = "0x2EBC690", VA = "0x182EBD890", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD9E0", Offset = "0x2EBC7E0", VA = "0x182EBD9E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD820", Offset = "0x2EBC620", VA = "0x182EBD820")]
		private bool NKDKHADIJAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD440", Offset = "0x2EBC240", VA = "0x182EBD440")]
		private void DHGJLPMIPBI(EntityQuery NOJJNNFMBAH, float3 PLGMDHJMBCK, string ICIEGOLHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public struct IFOFHCJELOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Entity NEAKDKENHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public JAHBKEFENJN DNEMONMIDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public JAHBKEFENJN NCBOBCDAKLG;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	public class ProcessCullingBandChangeCallbacks : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CullingBandService OJLLEEBOPOP;

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D33780", Offset = "0x2D32580", VA = "0x182D33780", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D337D0", Offset = "0x2D325D0", VA = "0x182D337D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[DKGMECGHCPI(OJBFOICGDOF.Connectables)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	public class UpdateInertialProperties : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery LHMKHEMIGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private HFPJLGFFINN KEIFOJDONAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x2FF3BE0", Offset = "0x2FF29E0", VA = "0x182FF3BE0", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x2FF3C50", Offset = "0x2FF2A50", VA = "0x182FF3C50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2FF3CE0", Offset = "0x2FF2AE0", VA = "0x182FF3CE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[AJHMADEHCDB]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MLDIJELEABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> KOBEFGDCKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NKCPNGJGKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private KinematicSleepChangeService INCJFNCKLLE;

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x329A0D0", Offset = "0x3298ED0", VA = "0x18329A0D0", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x329A900", Offset = "0x3299700", VA = "0x18329A900", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x3299900", Offset = "0x3298700", VA = "0x183299900")]
		private void BIDLKEOMHAD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MPMKGFKPBEN, EntityQueryDesc DMKDCEINMBM, bool JMJOCNAKGDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x3299A10", Offset = "0x3298810", VA = "0x183299A10")]
		private void BIDLKEOMHAD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MPMKGFKPBEN, EntityQueryDesc DMKDCEINMBM, bool JMJOCNAKGDC, bool GICBOMHAJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x329AB60", Offset = "0x3299960", VA = "0x18329AB60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x329A680", Offset = "0x3299480", VA = "0x18329A680")]
		private void MBDKCOPKPMD(EntityQuery NOJJNNFMBAH, bool LIJELEPMPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x3299EC0", Offset = "0x3298CC0", VA = "0x183299EC0")]
		private void DIDBLPMAJMD(EntityQuery NOJJNNFMBAH, bool FFAOIOAEDJA, bool LIJELEPMPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x329A120", Offset = "0x3298F20", VA = "0x18329A120")]
		private void EPOIKDCHNJL(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x3299D50", Offset = "0x3298B50", VA = "0x183299D50")]
		private void CNLCFDLMICO(NativeList<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x329A560", Offset = "0x3299360", VA = "0x18329A560")]
		private void KGIOPHBBAEF(NativeArray<Entity> KMDDIGFEEEI, bool FFAOIOAEDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x3299B50", Offset = "0x3298950", VA = "0x183299B50")]
		private NativeList<Entity> CIJPDNPIFIO(NativeArray<Entity> KMDDIGFEEEI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x329A520", Offset = "0x3299320", VA = "0x18329A520")]
		private NativeList<Entity> JGMHHCLOACG(NativeArray<Entity> KMDDIGFEEEI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x329A340", Offset = "0x3299140", VA = "0x18329A340")]
		private NativeList<Entity> IILBMNDNMMF(NativeArray<Entity> KMDDIGFEEEI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x329A380", Offset = "0x3299180", VA = "0x18329A380")]
		private NativeList<Entity> IJPGPMJPNLL(NativeArray<Entity> KMDDIGFEEEI, bool FEGOOCEPCGD)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x329A870", Offset = "0x3299670", VA = "0x18329A870")]
		private EPMDFDFGGLI OHAMAJBPOGK(NativeArray<Entity> KMDDIGFEEEI)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(EPMDFDFGGLI);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x329AE80", Offset = "0x3299C80", VA = "0x18329AE80")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private KinematicSleepChangeService INCJFNCKLLE;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D337F0", Offset = "0x2D325F0", VA = "0x182D337F0", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D33840", Offset = "0x2D32640", VA = "0x182D33840", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : PCJBNPNGPAF
	{
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery CKNFNJBMOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery GEHGGDIMBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery LMLJBDOPFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery AILLFKIBCFL;

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x2ECD640", Offset = "0x2ECC440", VA = "0x182ECD640", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x2ECD800", Offset = "0x2ECC600", VA = "0x182ECD800", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x2ECD400", Offset = "0x2ECC200", VA = "0x182ECD400")]
		private void HIPCDPEFALH(EntityQuery NOJJNNFMBAH, bool IIEJCKFDDHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2ECD1C0", Offset = "0x2ECBFC0", VA = "0x182ECD1C0")]
		private void DPMGMGFKNGN(EntityQuery NOJJNNFMBAH, bool IIEJCKFDDHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	internal class AssignPlayerIdsSystem : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery NFEGPJLLGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery OIHLCJKIIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private SceneService BLHCMMNIILB;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6110", Offset = "0x2EB4F10", VA = "0x182EB6110", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6800", Offset = "0x2EB5600", VA = "0x182EB6800", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6910", Offset = "0x2EB5710", VA = "0x182EB6910", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2EB63D0", Offset = "0x2EB51D0", VA = "0x182EB63D0")]
		private void HGJHNILNONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5FA0", Offset = "0x2EB4DA0", VA = "0x182EB5FA0")]
		private void DPNFFIMPLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2EB64E0", Offset = "0x2EB52E0", VA = "0x182EB64E0")]
		private void MPHDEBKHLHG(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6180", Offset = "0x2EB4F80", VA = "0x182EB6180")]
		private void ECDDHNKHGDL(NativeArray<Entity> KMDDIGFEEEI, int DCKFKLICKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2EB62C0", Offset = "0x2EB50C0", VA = "0x182EB62C0")]
		private void HEJNHAGGKAH(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5F40", Offset = "0x2EB4D40", VA = "0x182EB5F40")]
		private void BBHALEECNMA(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		private static void KAHHGJOBIEC(int COGEDNMFBOF, Transform KGHIPKNMKHP, Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class KLHJLJMKHMI
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x32B13B0", Offset = "0x32B01B0", VA = "0x1832B13B0")]
	public static bool BNEIGHNAGPN(this SystemBase BAHPOEMJAPG, out Entity NEAKDKENHHP)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery LLPGFJHFLHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private OOMOONHDGPN MNODPGFIACM;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF530", Offset = "0x2EBE330", VA = "0x182EBF530", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF580", Offset = "0x2EBE380", VA = "0x182EBF580", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF640", Offset = "0x2EBE440", VA = "0x182EBF640", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<DNLJOHLJEBD>, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private const string NLHDCBDNGOM = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private OHCNDJAHENC BDDIDGFOMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery NGHPGFPELNE;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private Entity DFDIPDDOPED
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x2D17BA0", Offset = "0x2D169A0", VA = "0x182D17BA0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x2D17740", Offset = "0x2D16540", VA = "0x182D17740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity HFEFDGCNIEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x2D176E0", Offset = "0x2D164E0", VA = "0x182D176E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public CGKCPDMKDFM ILIJPOMDMHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x2D17AE0", Offset = "0x2D168E0", VA = "0x182D17AE0")]
			get
			{
				return default(CGKCPDMKDFM);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x2D17970", Offset = "0x2D16770", VA = "0x182D17970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public CGKCPDMKDFM IEBOFIDBNJD
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x2D17A50", Offset = "0x2D16850", VA = "0x182D17A50")]
			get
			{
				return default(CGKCPDMKDFM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2D17C40", Offset = "0x2D16A40", VA = "0x182D17C40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x2D179E0", Offset = "0x2D167E0", VA = "0x182D179E0", Slot = "15")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x2D17CE0", Offset = "0x2D16AE0", VA = "0x182D17CE0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x2D177A0", Offset = "0x2D165A0", VA = "0x182D177A0", Slot = "14")]
		protected override void ALPOOJPFOCL(NativeArray<Entity> KMDDIGFEEEI, NativeArray<Entity> OGDFKDAHOEM, NativeArray<Entity> EKEADKDCONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2D17D60", Offset = "0x2D16B60", VA = "0x182D17D60")]
		private void PGNBDEBJAMC(NativeArray<Entity> KMDDIGFEEEI, NativeArray<Entity> EKEADKDCONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2D17E40", Offset = "0x2D16C40", VA = "0x182D17E40")]
		private void PNAIAMMFEBL(Entity NEAKDKENHHP, Entity OIJAMKCIOJD, Entity HAGIGCKFCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2B33ED0", Offset = "0x2B32CD0", VA = "0x182B33ED0")]
		private bool EHAPPLAHJDF<T>(out T MGFMONLLLPD) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2B33F60", Offset = "0x2B32D60", VA = "0x182B33F60")]
		private void FEJHKBDMPAO<T>(T MGFMONLLLPD) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2D178F0", Offset = "0x2D166F0", VA = "0x182D178F0")]
		public bool BIFDAJGFGNH(CGKCPDMKDFM JKMKFHHEHOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2D17B70", Offset = "0x2D16970", VA = "0x182D17B70")]
		private static bool LAOEIHDFGHA(CGKCPDMKDFM KLBHJMNBGKP, CGKCPDMKDFM GNOALAEMHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2D18150", Offset = "0x2D16F50", VA = "0x182D18150")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2D17C00", Offset = "0x2D16A00", VA = "0x182D17C00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery NOJJNNFMBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7A20", Offset = "0x2EC6820", VA = "0x182EC7A20", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7A70", Offset = "0x2EC6870", VA = "0x182EC7A70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7B10", Offset = "0x2EC6910", VA = "0x182EC7B10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7F60", Offset = "0x2EC6D60", VA = "0x182EC7F60")]
		private NativeArray<Entity> PDJKBGPCPBL(int MNBBKKLFBKD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7910", Offset = "0x2EC6710", VA = "0x182EC7910")]
		private void DHJCMKMAKMH(NativeArray<Entity> LIFKDBAFKKC, NativeArray<Entity> NJABBHKPOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	internal class HideRemotePivotsNotInScope : CENINKGGFPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery HHABKGIHLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery ALKJKNJNEHD;

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x32A6ED0", Offset = "0x32A5CD0", VA = "0x1832A6ED0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x32A6FC0", Offset = "0x32A5DC0", VA = "0x1832A6FC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal static class EGJICDHIFDM
{
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public const string DFMIGICNECM = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x20B42E0", Offset = "0x20B30E0", VA = "0x1820B42E0")]
	public static NativeArray<T> EILCFLFJLNK<T>(NativeArray<Entity> KMDDIGFEEEI, EntityManager PAHBLOLNPLD) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0D90", Offset = "0x2ECFB90", VA = "0x182ED0D90")]
	public static void LOEIDEPIEMI(EntityQuery NOJJNNFMBAH, EntityManager PAHBLOLNPLD, JCAPLMJKCDN MKBBGINEDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0C60", Offset = "0x2ECFA60", VA = "0x182ED0C60")]
	public static void HEIGMKPLKAI(NativeArray<Entity> LIFKDBAFKKC, JCAPLMJKCDN MKBBGINEDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B30", Offset = "0x2ECF930", VA = "0x182ED0B30")]
	public static void EAIDJDEFKIB(NativeArray<Entity> LIFKDBAFKKC, JCAPLMJKCDN MKBBGINEDBB)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery NOJJNNFMBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TransformService LPMGOCJAKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ObjectLifecycleService LHNDLBANJBK;

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2FF2A50", Offset = "0x2FF1850", VA = "0x182FF2A50", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2FF3AE0", Offset = "0x2FF28E0", VA = "0x182FF3AE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2FF3B80", Offset = "0x2FF2980", VA = "0x182FF3B80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2FF3080", Offset = "0x2FF1E80", VA = "0x182FF3080")]
		private void MIJCNEMPELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2FF2AE0", Offset = "0x2FF18E0", VA = "0x182FF2AE0")]
		private void FCIPMENHGLK(NativeArray<Entity> LIFKDBAFKKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2FF2180", Offset = "0x2FF0F80", VA = "0x182FF2180")]
		private void DLMPKJKHKLO(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2FF3890", Offset = "0x2FF2690", VA = "0x182FF3890")]
		private void OCLBBCHKHBE(NativeArray<Entity> NJABBHKPOBM, NativeArray<RigidTransform> ICMJFFDEDHF, NativeArray<RigidTransform> DBNJGKOENFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2FF2BF0", Offset = "0x2FF19F0", VA = "0x182FF2BF0")]
		private void IHPBBBPPNBA(NativeArray<RigidTransform> DBNJGKOENFN, NativeArray<Entity> NJABBHKPOBM, NativeList<Entity> KDMMIIFLGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	internal class PostGameplayOnScopeChange : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery LLPGFJHFLHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery LFPHMEPNNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2D31D30", Offset = "0x2D30B30", VA = "0x182D31D30", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2D31E10", Offset = "0x2D30C10", VA = "0x182D31E10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2D31F60", Offset = "0x2D30D60", VA = "0x182D31F60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2D31DA0", Offset = "0x2D30BA0", VA = "0x182D31DA0")]
		private void OMNONGIPAON(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	internal class PreventDisembodiedScopesSystem : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EntityQuery GDNDCAMOGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private EntityHierarchyParents ODLKGBFEGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private OOMOONHDGPN MNODPGFIACM;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2D33460", Offset = "0x2D32260", VA = "0x182D33460", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2D33680", Offset = "0x2D32480", VA = "0x182D33680", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2D33720", Offset = "0x2D32520", VA = "0x182D33720", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2D334F0", Offset = "0x2D322F0", VA = "0x182D334F0")]
		private void NGCADBHNDNO(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<DAJPOEADLGL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD4B0", Offset = "0x2FDC2B0", VA = "0x182FDD4B0", Slot = "14")]
		protected override void ALPOOJPFOCL(NativeArray<Entity> KMDDIGFEEEI, NativeArray<Entity> OGDFKDAHOEM, NativeArray<Entity> EKEADKDCONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD600", Offset = "0x2FDC400", VA = "0x182FDD600")]
		[BurstCompile]
		private static void ALPOOJPFOCL(NativeArray<Entity> KMDDIGFEEEI, NativeArray<Entity> EKEADKDCONB, ComponentDataFromEntity<global::NBJFMCIJLJK> FCHKNMPHDJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD710", Offset = "0x2FDC510", VA = "0x182FDD710")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD6D0", Offset = "0x2FDC4D0", VA = "0x182FDD6D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[DKGMECGHCPI(OJBFOICGDOF.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : CENINKGGFPK where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private EntityQuery IEBOKFHKLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery IDPKHCCDGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private EntityQuery HHIJBAFHBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private EntityQuery MCMDNGMGEFD;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x3A14610", Offset = "0x3A13410", VA = "0x183A14610", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x3A149E0", Offset = "0x3A137E0", VA = "0x183A149E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x3A149B0", Offset = "0x3A137B0", VA = "0x183A149B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x3A13150", Offset = "0x3A11F50", VA = "0x183A13150")]
		private void HKAIGJKBNPP(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x3A14220", Offset = "0x3A13020", VA = "0x183A14220")]
		private void NCDAGBIMGAC(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x3A13590", Offset = "0x3A12390", VA = "0x183A13590")]
		private void LOLENDKFHDK(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void ALPOOJPFOCL(NativeArray<Entity> KMDDIGFEEEI, NativeArray<Entity> OGDFKDAHOEM, NativeArray<Entity> EKEADKDCONB);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x2A67E00", Offset = "0x2A66C00", VA = "0x182A67E00")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x1058C20", Offset = "0x1057A20", VA = "0x181058C20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class ECGFFHGOLED : CENINKGGFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private List<(EntityQuery, ComponentType)> FJJEAMJCBDE;

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2ECE770", Offset = "0x2ECD570", VA = "0x182ECE770", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x2ECE970", Offset = "0x2ECD770", VA = "0x182ECE970", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x2ECEAC0", Offset = "0x2ECD8C0", VA = "0x182ECEAC0")]
	public ECGFFHGOLED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct OAKAFEODFCD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public int CEEBBJGGBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public int KAKKJFDONBF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A2E0", Offset = "0x2D190E0", VA = "0x182D1A2E0")]
	public static Entity JMLJLLKELMG(OAKAFEODFCD MMJOHADFCHO)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A2E0", Offset = "0x2D190E0", VA = "0x182D1A2E0")]
	public static OAKAFEODFCD JMLJLLKELMG(Entity NEAKDKENHHP)
	{
		return default(OAKAFEODFCD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct ADCNKMONJKM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct BDPKNCJACAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly ComponentType ACHMOOKCOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly NativeList<int> MBDEKLPMDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly NativeList<int> MCAIJMCHMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly NativeArray<Entity> KMDDIGFEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly NativeArray<Entity> OIACGDKHKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NativeArray<byte> IJAHNJPEPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly NativeArray<byte> KAHIPMIDNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public readonly int MBFANLMPGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public readonly int OECIFEKIDAL;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool PBJKLADKACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x2EB7630", Offset = "0x2EB6430", VA = "0x182EB7630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7700", Offset = "0x2EB6500", VA = "0x182EB7700")]
	public BDPKNCJACAA(ComponentType ACHMOOKCOKG, NativeList<int> MBDEKLPMDOP, NativeList<int> MCAIJMCHMCP, NativeArray<Entity> KMDDIGFEEEI, NativeArray<Entity> OIACGDKHKKD, NativeArray<byte> IJAHNJPEPDC, NativeArray<byte> KAHIPMIDNOL, int MBFANLMPGHK, int OECIFEKIDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x2EB74B0", Offset = "0x2EB62B0", VA = "0x182EB74B0")]
	private BDKOOLPOOEA GHCCCMPKELP(NativeArray<byte> PALKODKBAJM, int NNHNOIMLALG)
	{
		return default(BDKOOLPOOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	private T GHCCCMPKELP<T>(NativeArray<byte> PALKODKBAJM, int NNHNOIMLALG) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x2EB76B0", Offset = "0x2EB64B0", VA = "0x182EB76B0")]
	public BDKOOLPOOEA PEHBOPCEJAL(int NNHNOIMLALG)
	{
		return default(BDKOOLPOOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	public T PEHBOPCEJAL<T>(int NNHNOIMLALG) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x2EB75E0", Offset = "0x2EB63E0", VA = "0x182EB75E0")]
	public BDKOOLPOOEA IIGOEBNFBKA(int NNHNOIMLALG)
	{
		return default(BDKOOLPOOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	public T IIGOEBNFBKA<T>(int NNHNOIMLALG) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x2EB73D0", Offset = "0x2EB61D0", VA = "0x182EB73D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct BGNMEHKBAPK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public readonly EntityQuery NOJJNNFMBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly NativeArray<BGIFPPJCHFK> PGPGHEAKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly ComponentType ACHMOOKCOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly int MBFANLMPGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly int OECIFEKIDAL;

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7900", Offset = "0x2EB6700", VA = "0x182EB7900")]
	public BGNMEHKBAPK(ComponentType ACHMOOKCOKG, int MBFANLMPGHK, int OECIFEKIDAL, EntityQuery NOJJNNFMBAH, NativeArray<BGIFPPJCHFK> PGPGHEAKODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x2EB78B0", Offset = "0x2EB66B0", VA = "0x182EB78B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct KKBOFAKHGPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public int NNHNOIMLALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public int EGOBGJILKKF;

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x7621E0", Offset = "0x760FE0", VA = "0x1807621E0")]
	public KKBOFAKHGPM(int NNHNOIMLALG, int EGOBGJILKKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct BGIFPPJCHFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly int NGOMPMICLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly int MKGODNJCKOC;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x7621E0", Offset = "0x760FE0", VA = "0x1807621E0")]
	public BGIFPPJCHFK(int NGOMPMICLHJ, int MKGODNJCKOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct KLMKJNOOIJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly DFNAMHCDDIN LNJCEIMJDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int MBFANLMPGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private unsafe readonly byte* IJAHNJPEPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private unsafe readonly byte* KAHIPMIDNOL;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool EMDPCLDELLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x32B1440", Offset = "0x32B0240", VA = "0x1832B1440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public DFNAMHCDDIN MMLDEBDAEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0")]
		get
		{
			return default(DFNAMHCDDIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x32B1450", Offset = "0x32B0250", VA = "0x1832B1450")]
	public BDKOOLPOOEA GHBPHFHDNAD(Type LEDIIMFEFLP)
	{
		return default(BDKOOLPOOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x32B1540", Offset = "0x32B0340", VA = "0x1832B1540")]
	public BDKOOLPOOEA OKAKJOEAGDL(Type LEDIIMFEFLP)
	{
		return default(BDKOOLPOOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x165ADC0", Offset = "0x1659BC0", VA = "0x18165ADC0")]
	public T GHBPHFHDNAD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x165ADE0", Offset = "0x1659BE0", VA = "0x18165ADE0")]
	public T OKAKJOEAGDL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x32B1630", Offset = "0x32B0430", VA = "0x1832B1630")]
	public unsafe KLMKJNOOIJN(DFNAMHCDDIN LNJCEIMJDGG, int MKGODNJCKOC, byte* IJAHNJPEPDC, byte* KAHIPMIDNOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal abstract class NIPNGMMLIDP : EBJAMMGLKGI, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private PropertyDiffStateService NLHBFABKJKJ;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected abstract KKOEPHEHHNN MJOKMBNGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C830", Offset = "0x2D1B630", VA = "0x182D1C830", Slot = "17")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CAC0", Offset = "0x2D1B8C0", VA = "0x182D1CAC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C880", Offset = "0x2D1B680", VA = "0x182D1C880", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	protected NIPNGMMLIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class EFGKHHLGOBB
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] HKADJOGODCN;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[DefaultMember("Item")]
internal class JDPHJHEBALE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly FGEMECIGOCC EKOKIILLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly Dictionary<ComponentType, BGNMEHKBAPK> CFOEJIGACJN;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public BGNMEHKBAPK BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x32ACA40", Offset = "0x32AB840", VA = "0x1832ACA40")]
		get
		{
			return default(BGNMEHKBAPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x32ACB80", Offset = "0x32AB980", VA = "0x1832ACB80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x32AD370", Offset = "0x32AC170", VA = "0x1832AD370")]
	public JDPHJHEBALE(AEJNGPFNACL EOHGMNFKFFO, FGEMECIGOCC EKOKIILLNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x32AC840", Offset = "0x32AB640", VA = "0x1832AC840")]
	public bool BOAPLFBFGDK(ComponentType ACHMOOKCOKG, out BGNMEHKBAPK PHFANALOCKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x32ACBD0", Offset = "0x32AB9D0", VA = "0x1832ACBD0")]
	public Dictionary<ComponentType, BGNMEHKBAPK>.Enumerator NEACBAFBFJC()
	{
		return default(Dictionary<ComponentType, BGNMEHKBAPK>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x32AC8B0", Offset = "0x32AB6B0", VA = "0x1832AC8B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x32ACF10", Offset = "0x32ABD10", VA = "0x1832ACF10")]
	private void PKPAKMFOKCH(IEnumerable<LPGGBJGEPLD> MGMDPMFEGMO, EntityManager PAHBLOLNPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x32ACAD0", Offset = "0x32AB8D0", VA = "0x1832ACAD0")]
	private static int MJKMNOEMFJF(LPGGBJGEPLD HIOCNACBAKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x32ACC60", Offset = "0x32ABA60", VA = "0x1832ACC60")]
	private static NativeArray<BGIFPPJCHFK> OBMCNJMADIA(LPGGBJGEPLD HIOCNACBAKI, Allocator MBJMPHBLMBF = Allocator.Persistent)
	{
		return default(NativeArray<BGIFPPJCHFK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal interface EIHJALEFJJC
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool PBJKLADKACD
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	World EHMOILHLDLA
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MCKPOFENHEF(out NativeArray<int> IPHKHCPGEPK, Allocator MBJMPHBLMBF);

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MMNCKEFICEB(ComponentType ACHMOOKCOKG, out BDPKNCJACAA ILJPIPFGHLD, out BGNMEHKBAPK NIAAPKAOANJ);

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MMNCKEFICEB(ComponentType ACHMOOKCOKG, out BDPKNCJACAA ILJPIPFGHLD);

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BDPKNCJACAA GCNHOEHLALP(ComponentType ACHMOOKCOKG);

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PJBEBFLEPPK KFNPBDPPIDE();

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MOOAFBEALLD(JobHandle BACBCMPFGHN);
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
internal interface KPHDFAICOOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	World EHMOILHLDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	JDPHJHEBALE PJGCHLMPOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	IECLDDPADOO HGALHLGFOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NativeMultiHashMap<Entity, KLMKJNOOIJN> LJEHDIOCCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JobHandle EAJDKFJPOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OLEPBNNLDDG();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODCBHOABBME();

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BHOMFFCPBFG(ComponentType ACHMOOKCOKG, in BDPKNCJACAA CNEFNNFKFMC);

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JIFKNEPGDAI(IAFDFFOCDLF KCFAHJGLHLA, out Entity PEINAPABAGG);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct PJBEBFLEPPK
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public struct FGLEKJMAOFM : IEnumerator<KLMKJNOOIJN>, IEnumerator, IDisposable, IEnumerable<KLMKJNOOIJN>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly NativeMultiHashMap<Entity, KLMKJNOOIJN> HNFKMIGCOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly Entity NEAKDKENHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private NativeMultiHashMapIterator<Entity> FDFAMNCJKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private KLMKJNOOIJN KAHIPMIDNOL;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public KLMKJNOOIJN OAFAFEDHHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0xD4C340", Offset = "0xD4B140", VA = "0x180D4C340", Slot = "4")]
			get
			{
				return default(KLMKJNOOIJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x44A6670", Offset = "0x44A5470", VA = "0x1844A6670", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x44A66C0", Offset = "0x44A54C0", VA = "0x1844A66C0")]
		internal FGLEKJMAOFM(NativeMultiHashMap<Entity, KLMKJNOOIJN> HNFKMIGCOAJ, Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x44A6430", Offset = "0x44A5230", VA = "0x1844A6430", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x44A6500", Offset = "0x44A5300", VA = "0x1844A6500")]
		public FGLEKJMAOFM NEACBAFBFJC()
		{
			return default(FGLEKJMAOFM);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x44A6530", Offset = "0x44A5330", VA = "0x1844A6530", Slot = "9")]
		private IEnumerator<KLMKJNOOIJN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x44A65D0", Offset = "0x44A53D0", VA = "0x1844A65D0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly KPHDFAICOOJ GMDALJMBJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly JobHandle LIOHLLFDDIE;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int HCALFPOKMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C920", Offset = "0x2D2B720", VA = "0x182D2C920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool MNPJEDKKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x2D2CC70", Offset = "0x2D2BA70", VA = "0x182D2CC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x2568930", Offset = "0x2567730", VA = "0x182568930")]
	public PJBEBFLEPPK(KPHDFAICOOJ GMDALJMBJKE, JobHandle LIOHLLFDDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CA10", Offset = "0x2D2B810", VA = "0x182D2CA10")]
	public bool CGMFNOHLPNN(Allocator MBJMPHBLMBF, out NativeKeyValueArrays<Entity, KLMKJNOOIJN> AJCHMFJLMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C7B0", Offset = "0x2D2B5B0", VA = "0x182D2C7B0")]
	public bool AHEGNMFLAIE(Allocator MBJMPHBLMBF, out (NativeArray<Entity> entities, int uniqueCount) AJCHMFJLMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2D2CB50", Offset = "0x2D2B950", VA = "0x182D2CB50")]
	public FGLEKJMAOFM DDEIGMPJNPC(Entity NEAKDKENHHP)
	{
		return default(FGLEKJMAOFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[DefaultMember("Item")]
internal class IECLDDPADOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly FGEMECIGOCC EKOKIILLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly List<BGNMEHKBAPK> MPMKGFKPBEN;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public BGNMEHKBAPK BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x32AA3C0", Offset = "0x32A91C0", VA = "0x1832AA3C0")]
		get
		{
			return default(BGNMEHKBAPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x32AA450", Offset = "0x32A9250", VA = "0x1832AA450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x32AA840", Offset = "0x32A9640", VA = "0x1832AA840")]
	public IECLDDPADOO(JDPHJHEBALE CFOEJIGACJN, AEJNGPFNACL EOHGMNFKFFO, FGEMECIGOCC EKOKIILLNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x32AA490", Offset = "0x32A9290", VA = "0x1832AA490")]
	public List<BGNMEHKBAPK>.Enumerator NEACBAFBFJC()
	{
		return default(List<BGNMEHKBAPK>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x32AA240", Offset = "0x32A9040", VA = "0x1832AA240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x32AA510", Offset = "0x32A9310", VA = "0x1832AA510")]
	private void PKPAKMFOKCH(JDPHJHEBALE CFOEJIGACJN, EntityManager PAHBLOLNPLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class JGCOPBLAKJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly FGEMECIGOCC EKOKIILLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly ObjectInstantiationService FHLJIJCKGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly global::LHAHHAJLMCG<LPGGBJGEPLD> GKNGGGJPNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly World AEIDONAKGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly EntityManager PAHBLOLNPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NativeHashMap<int, Entity> OCEJDJPHFHH;

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x32AEE30", Offset = "0x32ADC30", VA = "0x1832AEE30")]
	public JGCOPBLAKJC(ObjectInstantiationService FHLJIJCKGLN, AEJNGPFNACL EOHGMNFKFFO, FGEMECIGOCC EKOKIILLNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x32ADA90", Offset = "0x32AC890", VA = "0x1832ADA90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x32AE4C0", Offset = "0x32AD2C0", VA = "0x1832AE4C0")]
	public bool IBFMGPCLKDD(IAFDFFOCDLF KCFAHJGLHLA, out Entity PEINAPABAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x32AE520", Offset = "0x32AD320", VA = "0x1832AE520")]
	private void MBBOLKKJHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x32ADF90", Offset = "0x32ACD90", VA = "0x1832ADF90")]
	private EntityArchetype HLBDPGHCKLE(EntityArchetype GJILKAEMMKK)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x32ADB60", Offset = "0x32AC960", VA = "0x1832ADB60")]
	public static void GMDMFOLMPEM(EntityManager DLLFCONCAGH, EntityManager KCCDGHKNKMD, NativeArray<Entity> GIBCHKHFFAJ, NativeArray<EntityArchetype> CHLLNAOOLBD, [Optional] NativeArray<Entity> FKFABIDHBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x32AECC0", Offset = "0x32ADAC0", VA = "0x1832AECC0")]
	[Conditional("DEBUG_BUILD")]
	private static void OGOPLFMDFKD(NativeArray<EntityArchetype> ENCJCJLNBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x32AD5C0", Offset = "0x32AC3C0", VA = "0x1832AD5C0")]
	private static string BCBMBCODPAD(EntityArchetype DFDCBJPJDKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x32AEB80", Offset = "0x32AD980", VA = "0x1832AEB80")]
	[CompilerGenerated]
	internal static void MDGLHNGMBIK(ref Span<ComponentType> NLMGGDFALDE, ComponentType MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x32AD800", Offset = "0x32AC600", VA = "0x1832AD800")]
	[CompilerGenerated]
	internal static void BNNEALKHBJO(Span<ComponentType> PALKODKBAJM, ref Span<ComponentType> NLMGGDFALDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x32AD9B0", Offset = "0x32AC7B0", VA = "0x1832AD9B0")]
	[CompilerGenerated]
	internal static void CFBAKDLICBC(Span<ComponentType> PALKODKBAJM, ref Span<ComponentType> NLMGGDFALDE, ComponentType NGHKOJDCKJD)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[DKGMECGHCPI(OJBFOICGDOF.PropertyChanges)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld ENDGCGOCOMM;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5DD0", Offset = "0x2EB4BD0", VA = "0x182EB5DD0", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2EB5E90", Offset = "0x2EB4C90", VA = "0x182EB5E90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[AlwaysUpdateSystem]
	[DKGMECGHCPI(OJBFOICGDOF.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : CENINKGGFPK, JPLAKHLHFLM, NEGCPFIDGDD
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct MFHGMENACOB : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<byte> EFPMHFOAPKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<byte> HDEAEGDENDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeArray<BGIFPPJCHFK> BBGHDOFPAEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[WriteOnly]
			public NativeList<KKBOFAKHGPM>.ParallelWriter JEFKBAIIHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int CCGFFNNLKBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int HPEOAMNAMPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker NHJEBBCKDGL;

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x2FDB990", Offset = "0x2FDA790", VA = "0x182FDB990", Slot = "4")]
			public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x2FDBAD0", Offset = "0x2FDA8D0", VA = "0x182FDBAD0")]
			private unsafe int JJFBHGNHBAH(byte* OEALOJBEJML, byte* KHJAOGDHEIM)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[BurstCompile]
		internal struct OJGCOMPOAOF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			[WriteOnly]
			public NativeList<int> MBDEKLPMDOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			[WriteOnly]
			public NativeList<int> IAFFPFOGEOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			[ReadOnly]
			public NativeList<KKBOFAKHGPM> JHANAFGMPLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public ProfilerMarker NHJEBBCKDGL;

			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0x2FDBF90", Offset = "0x2FDAD90", VA = "0x182FDBF90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[BurstCompile]
		internal struct KBNPBIHBPLA : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[WriteOnly]
			public NativeArray<byte> KMEDOGLMCHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			public NativeArray<Entity> KMDDIGFEEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			[ReadOnly]
			public ComponentDataFromEntity EHIGJGFCPMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int MBFANLMPGHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public ProfilerMarker NHJEBBCKDGL;

			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x2FDACE0", Offset = "0x2FD9AE0", VA = "0x182FDACE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[BurstCompile]
		internal struct JAMHLOBPDGD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, KLMKJNOOIJN> KIHCFBPPHAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			[ReadOnly]
			public NativeArray<byte> IJAHNJPEPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			public NativeArray<byte> KAHIPMIDNOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			public NativeArray<Entity> KMDDIGFEEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			[ReadOnly]
			public NativeArray<BGIFPPJCHFK> CKKNGLLMJEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			[ReadOnly]
			public NativeList<int> MCAIJMCHMCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			[ReadOnly]
			public NativeList<int> MBDEKLPMDOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int GIADEHACMND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int OECIFEKIDAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public ProfilerMarker NHJEBBCKDGL;

			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x2FDA0F0", Offset = "0x2FD8EF0", VA = "0x182FDA0F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private static readonly ProfilerMarker ADLOAJGCMIE;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private static readonly ProfilerMarker BIFCDFNEBCG;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private static readonly ProfilerMarker HFDFEDAIMPF;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private static readonly ProfilerMarker FCLMMNIFPJC;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private static readonly ProfilerMarker CHPLNFODLPK;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private static readonly ProfilerMarker CALJGDJHAFK;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private static readonly ProfilerMarker OMFGJHADBOG;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly ProfilerMarker MOJHFCPADFB;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private static readonly ProfilerMarker OBEIBIFPMLH;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private static readonly ProfilerMarker NEOHKKJPLOK;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private static readonly ProfilerMarker JHLEKGCLMJL;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly ProfilerMarker IMDECGEAADM;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private static readonly ProfilerMarker GBOBFJMODLM;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private static readonly ProfilerMarker LGJDIGDDGPJ;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly ProfilerMarker JEPDJBJCLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private PropertyDiffStateService NLHBFABKJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private EntityQuery EGFKLMIDJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private EntityQuery NEPFIMCHFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private EntityQuery AIAEJKOKJEK;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		internal World EHMOILHLDLA
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x2EC16A0", Offset = "0x2EC04A0", VA = "0x182EC16A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private KPHDFAICOOJ CAIHMOLACJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x2EC0940", Offset = "0x2EBF740", VA = "0x182EC0940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0240", Offset = "0x2EBF040", VA = "0x182EC0240", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "15")]
		public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC24E0", Offset = "0x2EC12E0", VA = "0x182EC24E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC26A0", Offset = "0x2EC14A0", VA = "0x182EC26A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2630", Offset = "0x2EC1430", VA = "0x182EC2630", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0BD0", Offset = "0x2EBF9D0", VA = "0x182EC0BD0")]
		private void LHHEEKAGFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF890", Offset = "0x2EBE690", VA = "0x182EBF890")]
		internal void CNNAMNDPIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF8B0", Offset = "0x2EBE6B0", VA = "0x182EBF8B0")]
		private void CNNAMNDPIKN(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0700", Offset = "0x2EBF500", VA = "0x182EC0700")]
		private void GDOGAMGHONJ(NativeArray<Entity> GIBCHKHFFAJ, NativeArray<RRObjectPrefabData> IJAAPMINDJN, ref NativeArray<Entity> HJCOMKIMNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2EC20C0", Offset = "0x2EC0EC0", VA = "0x182EC20C0")]
		internal void OOCKLGBOECG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2EC20E0", Offset = "0x2EC0EE0", VA = "0x182EC20E0")]
		private void OOCKLGBOECG(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0F40", Offset = "0x2EBFD40", VA = "0x182EC0F40")]
		internal void NELEFODIINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0290", Offset = "0x2EBF090", VA = "0x182EC0290")]
		private void FDBBNCADKJJ(KPHDFAICOOJ GMDALJMBJKE, BGNMEHKBAPK NIAAPKAOANJ, bool HPEDFIEIANK, ref JobHandle JFNHEAAMHKF, ref JobHandle LFGJHBFKION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1760", Offset = "0x2EC0560", VA = "0x182EC1760")]
		internal bool ONPADAILBLK(in BGNMEHKBAPK KHJAOGDHEIM, out JobHandle EAHLOGLBEGD, out BDPKNCJACAA OKPKHLBJJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1790", Offset = "0x2EC0590", VA = "0x182EC1790")]
		private bool ONPADAILBLK(in BGNMEHKBAPK KHJAOGDHEIM, bool HPEDFIEIANK, out JobHandle EAHLOGLBEGD, out BDPKNCJACAA OKPKHLBJJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0080", Offset = "0x2EBEE80", VA = "0x182EC0080")]
		internal (NativeList<int>, NativeList<int>) DLFBIPAOMKP(NativeList<KKBOFAKHGPM> JHANAFGMPLD, int JNGKGNOBDKI, JobHandle DABCHKJGFPM, out JobHandle BACBCMPFGHN, Allocator MBJMPHBLMBF = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0E90", Offset = "0x2EBFC90", VA = "0x182EC0E90")]
		internal static NativeArray<Entity> MJHHDPKNDJJ(EntityQuery NOJJNNFMBAH, out JobHandle JPLIIMMJGAE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF700", Offset = "0x2EBE500", VA = "0x182EBF700")]
		internal static NativeArray<byte> AAABMLMDOOP(int EMGPHLLIACG, out JobHandle JGAIIACNEOK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF780", Offset = "0x2EBE580", VA = "0x182EBF780")]
		internal static NativeArray<byte> CNDGJNFPNMF(EntityQuery NOJJNNFMBAH, int JMJHPMGKKMH, out JobHandle JGAIIACNEOK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC27E0", Offset = "0x2EC15E0", VA = "0x182EC27E0")]
		internal static NativeArray<Entity> PJPHKGDBDDL(EntityQuery NOJJNNFMBAH, out JobHandle EBHCNGKEMKE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0960", Offset = "0x2EBF760", VA = "0x182EC0960")]
		internal NativeArray<byte> LGFPAMNGCDM(NativeArray<Entity> KMDDIGFEEEI, BGNMEHKBAPK NIAAPKAOANJ, JobHandle DABCHKJGFPM, out JobHandle BACBCMPFGHN, Allocator MBJMPHBLMBF = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0570", Offset = "0x2EBF370", VA = "0x182EC0570")]
		internal JobHandle FKHIJACPIIK(in BDPKNCJACAA MMJOHADFCHO, in BGNMEHKBAPK NIAAPKAOANJ, NativeMultiHashMap<Entity, KLMKJNOOIJN> KIHCFBPPHAG, JobHandle DABCHKJGFPM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A590", Offset = "0x1D09390", VA = "0x181D0A590")]
		private JobHandle BJGPIOMEJCD(JobHandle POMIOLEAMOL, JobHandle ABHEHDFPNLB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A590", Offset = "0x1D09390", VA = "0x181D0A590")]
		private JobHandle BJGPIOMEJCD(JobHandle POMIOLEAMOL, JobHandle ABHEHDFPNLB, JobHandle PDIOIOPEEOF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[DKGMECGHCPI(OJBFOICGDOF.RenderEffects)]
	internal class PropagateHoverRootTag : MBMFLIJKLGP
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public struct DNKJPEPPBEA : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType INNPLHHJJCF
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x2D34030", Offset = "0x2D32E30", VA = "0x182D34030", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType FOGFKHBLBJF
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x2D34060", Offset = "0x2D32E60", VA = "0x182D34060", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType OJPEAJKJGCN
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x2D34000", Offset = "0x2D32E00", VA = "0x182D34000", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D19D40", Offset = "0x2D18B40", VA = "0x182D19D40")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[DKGMECGHCPI(OJBFOICGDOF.RenderEffects)]
	internal class PropagateSelectionRootTag : MBMFLIJKLGP
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public struct NKDPFHCFPJK : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType INNPLHHJJCF
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x2D340C0", Offset = "0x2D32EC0", VA = "0x182D340C0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType FOGFKHBLBJF
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x2D340F0", Offset = "0x2D32EF0", VA = "0x182D340F0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType OJPEAJKJGCN
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x2D34090", Offset = "0x2D32E90", VA = "0x182D34090", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D19D40", Offset = "0x2D18B40", VA = "0x182D19D40")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[AJHMADEHCDB]
public class KMIJOANPAAG : PCJBNPNGPAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery NOJJNNFMBAH;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x32B1880", Offset = "0x32B0680", VA = "0x1832B1880", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x32B1910", Offset = "0x32B0710", VA = "0x1832B1910", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public KMIJOANPAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[AJHMADEHCDB]
public class IDBFAIBNDOJ : PCJBNPNGPAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct CFPCHAGKHDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		public CFPCHAGKHDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct EGLKLAFMNNO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct MFEAFOMKHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000161")]
			[NoAlias]
			public struct MGJNBKBABGD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LPBAJAEJLFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000464")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime IDHKENPMFMO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity GPILJGHOMAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> ILLANDHEFCB;

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x44AADC0", Offset = "0x44A9BC0", VA = "0x1844AADC0")]
			public void FBJFNGKGEAG(IDBFAIBNDOJ KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x44AAE20", Offset = "0x44A9C20", VA = "0x1844AAE20")]
			public MGJNBKBABGD OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
			{
				return default(MGJNBKBABGD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EntityManager PAHBLOLNPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NativeList<Entity> FBLIEKJBBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private MFEAFOMKHOJ CEHPMGEJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MFEAFOMKHOJ.MGJNBKBABGD* PAGEGEKEMGJ;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LMEJDEJHIBP;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PKKMDNGCGGC;

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x44A4740", Offset = "0x44A3540", VA = "0x1844A4740")]
		internal void OPBACEEAMEO(Entity NEAKDKENHHP, SplinePointParentData LOFCJGHDJHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x44A4860", Offset = "0x44A3660", VA = "0x1844A4860", Slot = "5")]
		public void ReadFromDisplayClass(ref CFPCHAGKHDD DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x44A4870", Offset = "0x44A3670", VA = "0x1844A4870", Slot = "6")]
		public void WriteToDisplayClass(ref CFPCHAGKHDD DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x44A45A0", Offset = "0x44A33A0", VA = "0x1844A45A0", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x44A47B0", Offset = "0x44A35B0", VA = "0x1844A47B0")]
		public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, [NoAlias] ref MFEAFOMKHOJ.MGJNBKBABGD ICBLKLNOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x44A4640", Offset = "0x44A3440", VA = "0x1844A4640")]
		public void FBJFNGKGEAG(IDBFAIBNDOJ KHKMOBDDHBP, ref CFPCHAGKHDD DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x44A46D0", Offset = "0x44A34D0", VA = "0x1844A46D0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void HNMDANPFJNG(ArchetypeChunkIterator* DDBGPMPNMAB, void* HHAGMJBBFIP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery FKGOLPCNCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private ProfilerMarker JKFKAELOPLO;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A8D80", VA = "0x1832A9F80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public IDBFAIBNDOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x32A9D50", Offset = "0x32A8B50", VA = "0x1832A9D50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x32A9BF0", Offset = "0x32A89F0", VA = "0x1832A9BF0")]
	public static EntityQuery KELJGMDKDJA(ComponentSystemBase KHKMOBDDHBP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[AJHMADEHCDB]
public class IKHEIIKOLND : PCJBNPNGPAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityQuery FFGOKPCPABP;

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x32AB340", Offset = "0x32AA140", VA = "0x1832AB340", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x32AB3D0", Offset = "0x32AA1D0", VA = "0x1832AB3D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public IKHEIIKOLND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(KMIJOANPAAG))]
public class KHAOHJAKJEN : CENINKGGFPK
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x32B0EE0", Offset = "0x32AFCE0", VA = "0x1832B0EE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public KHAOHJAKJEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class GCCADBLDADK : PCJBNPNGPAF, JPLAKHLHFLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct PLBJFCCDKAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NativeHashMap<MFDODOEBKCJ, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		public PLBJFCCDKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct DLAOGJAFFGB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct GMDCGEOJNKG
		{
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			public struct IOKCIOGCMHP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				public LambdaParameterValueProvider_Entity.Runtime LPBAJAEJLFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime EFNNCNJGLCN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GPILJGHOMAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> MIIKLBNGJHH;

			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x44A7010", Offset = "0x44A5E10", VA = "0x1844A7010")]
			public void FBJFNGKGEAG(GCCADBLDADK KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x44A7070", Offset = "0x44A5E70", VA = "0x1844A7070")]
			public IOKCIOGCMHP OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
			{
				return default(IOKCIOGCMHP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NativeHashMap<MFDODOEBKCJ, Entity> HNFKMIGCOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private GMDCGEOJNKG CEHPMGEJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GMDCGEOJNKG.IOKCIOGCMHP* PAGEGEKEMGJ;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LMEJDEJHIBP;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x44A4240", Offset = "0x44A3040", VA = "0x1844A4240")]
		internal void OPBACEEAMEO(Entity NEAKDKENHHP, ObjectNetworkIdComponentData IJKHFJIJENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x1213BF0", Offset = "0x12129F0", VA = "0x181213BF0", Slot = "5")]
		public void ReadFromDisplayClass(ref PLBJFCCDKAE DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x210CC60", Offset = "0x210BA60", VA = "0x18210CC60", Slot = "6")]
		public void WriteToDisplayClass(ref PLBJFCCDKAE DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x44A40A0", Offset = "0x44A2EA0", VA = "0x1844A40A0", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x44A42C0", Offset = "0x44A30C0", VA = "0x1844A42C0")]
		public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, ref GMDCGEOJNKG.IOKCIOGCMHP ICBLKLNOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x44A4140", Offset = "0x44A2F40", VA = "0x1844A4140")]
		public void FBJFNGKGEAG(GCCADBLDADK KHKMOBDDHBP, ref PLBJFCCDKAE DBDHHAPIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x44A41D0", Offset = "0x44A2FD0", VA = "0x1844A41D0")]
		public unsafe static void HNMDANPFJNG(ArchetypeChunkIterator* DDBGPMPNMAB, void* HHAGMJBBFIP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ObjectNetworkToLocalMapService JJPJMEBEPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private EntityQuery FKGOLPCNCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private ProfilerMarker JKFKAELOPLO;

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x329F1B0", Offset = "0x329DFB0", VA = "0x18329F1B0", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x329F570", Offset = "0x329E370", VA = "0x18329F570", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public GCCADBLDADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x329F370", Offset = "0x329E170", VA = "0x18329F370", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x329F210", Offset = "0x329E010", VA = "0x18329F210")]
	public static EntityQuery KELJGMDKDJA(ComponentSystemBase KHKMOBDDHBP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public class DFKKMIFIPBP : PCJBNPNGPAF, JPLAKHLHFLM
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HOHHJFLMPHP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct ELCMGOELPCM
		{
			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public struct FIGEMHIOPHJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				public LambdaParameterValueProvider_Entity.Runtime LPBAJAEJLFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime FBEPDOPGILF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GPILJGHOMAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> HLHGBINMFKP;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x44A4BC0", Offset = "0x44A39C0", VA = "0x1844A4BC0")]
			public void FBJFNGKGEAG(DFKKMIFIPBP KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x44A4C20", Offset = "0x44A3A20", VA = "0x1844A4C20")]
			public FIGEMHIOPHJ OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
			{
				return default(FIGEMHIOPHJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public DFKKMIFIPBP JKJMLGFJGMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private ELCMGOELPCM CEHPMGEJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ELCMGOELPCM.FIGEMHIOPHJ* PAGEGEKEMGJ;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LMEJDEJHIBP;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x2FDA020", Offset = "0x2FD8E20", VA = "0x182FDA020")]
		public void OPBACEEAMEO(Entity NEAKDKENHHP, ParentData HIEGMELOKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2FD9F00", Offset = "0x2FD8D00", VA = "0x182FD9F00", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x2FDA040", Offset = "0x2FD8E40", VA = "0x182FDA040")]
		public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, ref ELCMGOELPCM.FIGEMHIOPHJ ICBLKLNOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x2FD9F70", Offset = "0x2FD8D70", VA = "0x182FD9F70")]
		public void FBJFNGKGEAG(DFKKMIFIPBP KHKMOBDDHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x2FD9FB0", Offset = "0x2FD8DB0", VA = "0x182FD9FB0")]
		public unsafe static void HNMDANPFJNG(ArchetypeChunkIterator* DDBGPMPNMAB, void* HHAGMJBBFIP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private EntityQuery FKGOLPCNCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private ProfilerMarker JKFKAELOPLO;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x2ECAA30", Offset = "0x2EC9830", VA = "0x182ECAA30", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x2ECAFE0", Offset = "0x2EC9DE0", VA = "0x182ECAFE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public DFKKMIFIPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2ECABF0", Offset = "0x2EC99F0", VA = "0x182ECABF0")]
	[CompilerGenerated]
	private void MGGKBDLIMGH(Entity NEAKDKENHHP, ParentData HIEGMELOKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x2ECADE0", Offset = "0x2EC9BE0", VA = "0x182ECADE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x2ECAA90", Offset = "0x2EC9890", VA = "0x182ECAA90")]
	public static EntityQuery KELJGMDKDJA(ComponentSystemBase KHKMOBDDHBP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class LOJCNGJIDAN : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private int CGLBKHLJNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery NOJJNNFMBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private ObjectPrefabs FHLJIJCKGLN;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x32B7CD0", Offset = "0x32B6AD0", VA = "0x1832B7CD0", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x32B7D20", Offset = "0x32B6B20", VA = "0x1832B7D20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x32B7E00", Offset = "0x32B6C00", VA = "0x1832B7E00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x32B7980", Offset = "0x32B6780", VA = "0x1832B7980")]
	private void BIBCPCFOBHH(Entity NEAKDKENHHP, IAFDFFOCDLF KCFAHJGLHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public LOJCNGJIDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[DKGMECGHCPI(OJBFOICGDOF.Serialization)]
	[UpdateBefore(typeof(LOJCNGJIDAN))]
	public class PostLoadAddSceneTagEntity : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private SceneService BLHCMMNIILB;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x2D32070", Offset = "0x2D30E70", VA = "0x182D32070", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x2D320C0", Offset = "0x2D30EC0", VA = "0x182D320C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[AIMPMHLOEBK(DIMCOFJGPGL.OMRoom)]
	[DKGMECGHCPI(OJBFOICGDOF.Serialization)]
	public class PostLoadInitializeNetworkId : CENINKGGFPK, JPLAKHLHFLM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct KKJPCLNJHEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public NativeHashMap<MFDODOEBKCJ, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
			public KKJPCLNJHEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct MPKDMGFPLBH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000172")]
			private struct NMDDJICJHEM
			{
				[Cpp2IlInjected.Token(Token = "0x2000173")]
				[NoAlias]
				public struct MIKIFFHFMFB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000491")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime LPBAJAEJLFN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000492")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime NAHOIEODBNI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000493")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime EFNNCNJGLCN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity GPILJGHOMAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400048F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex OHEFOFFPDIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000490")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> MIIKLBNGJHH;

				[Cpp2IlInjected.Token(Token = "0x6000A32")]
				[Cpp2IlInjected.Address(RVA = "0x44AC430", Offset = "0x44AB230", VA = "0x1844AC430")]
				public void FBJFNGKGEAG(PostLoadInitializeNetworkId KHKMOBDDHBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x44AC4A0", Offset = "0x44AB2A0", VA = "0x1844AC4A0")]
				public MIKIFFHFMFB OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
				{
					return default(MIKIFFHFMFB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public NativeHashMap<MFDODOEBKCJ, Entity> HNFKMIGCOAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private NMDDJICJHEM CEHPMGEJNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NMDDJICJHEM.MIKIFFHFMFB* PAGEGEKEMGJ;

			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LMEJDEJHIBP;

			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PKKMDNGCGGC;

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x44AB7D0", Offset = "0x44AA5D0", VA = "0x1844AB7D0")]
			internal void OPBACEEAMEO(Entity NEAKDKENHHP, int GELPIKDKGHG, ref ObjectNetworkIdComponentData IJKHFJIJENG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x1213BF0", Offset = "0x12129F0", VA = "0x181213BF0", Slot = "5")]
			public void ReadFromDisplayClass(ref KKJPCLNJHEH DBDHHAPIJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x210CC60", Offset = "0x210BA60", VA = "0x18210CC60", Slot = "6")]
			public void WriteToDisplayClass(ref KKJPCLNJHEH DBDHHAPIJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x44AB5D0", Offset = "0x44AA3D0", VA = "0x1844AB5D0", Slot = "4")]
			public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x44AB860", Offset = "0x44AA660", VA = "0x1844AB860")]
			public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, [NoAlias] ref NMDDJICJHEM.MIKIFFHFMFB ICBLKLNOLAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x44AB6C0", Offset = "0x44AA4C0", VA = "0x1844AB6C0")]
			public void FBJFNGKGEAG(PostLoadInitializeNetworkId KHKMOBDDHBP, ref KKJPCLNJHEH DBDHHAPIJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x44AB760", Offset = "0x44AA560", VA = "0x1844AB760")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void HNMDANPFJNG(ArchetypeChunkIterator* DDBGPMPNMAB, void* HHAGMJBBFIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[DNEBGGIIGBA]
		private ObjectNetworkToLocalMapService JJPJMEBEPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		[DNEBGGIIGBA]
		private SceneService GOCPDFPAIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery NOJJNNFMBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EntityQuery ILFNBOLLPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ProfilerMarker AKEBNEECBIN;

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x2D322D0", Offset = "0x2D310D0", VA = "0x182D322D0", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x2D32FF0", Offset = "0x2D31DF0", VA = "0x182D32FF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2D32A30", Offset = "0x2D31830", VA = "0x182D32A30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2D32A30", Offset = "0x2D31830", VA = "0x182D32A30")]
		public void NDHPBDGADKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2D324E0", Offset = "0x2D312E0", VA = "0x182D324E0")]
		private void MBAJBHPFOOH(NativeHashMap<MFDODOEBKCJ, Entity> HNFKMIGCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2D32B00", Offset = "0x2D31900", VA = "0x182D32B00")]
		private void ODGPHLKKJBI(NativeHashMap<MFDODOEBKCJ, Entity> HNFKMIGCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2D32D60", Offset = "0x2D31B60", VA = "0x182D32D60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2D32340", Offset = "0x2D31140", VA = "0x182D32340")]
		public static EntityQuery ELMHOENOAFH(ComponentSystemBase KHKMOBDDHBP)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class DOOHFJMFMDN : CENINKGGFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery EDLJHMCIGLP;

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2ECD090", Offset = "0x2ECBE90", VA = "0x182ECD090", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2ECD120", Offset = "0x2ECBF20", VA = "0x182ECD120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public DOOHFJMFMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public class LEFGEFIJDFA : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::LHAHHAJLMCG<EHDBFDAEFOI> BMOLJIDLDJM;

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x32B53F0", Offset = "0x32B41F0", VA = "0x1832B53F0", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x32B5CF0", Offset = "0x32B4AF0", VA = "0x1832B5CF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x32B5A90", Offset = "0x32B4890", VA = "0x1832B5A90")]
	private void JIDBMNPEBIC(NativeList<EntityArchetype> ENCJCJLNBGD, NativeHashMap<int, JCKJOPOBLHO> DDCKOABPDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x32B52B0", Offset = "0x32B40B0", VA = "0x1832B52B0")]
	private Span<int> CDGJJJCPKDI(EntityArchetype DFDCBJPJDKJ)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x32B5C20", Offset = "0x32B4A20", VA = "0x1832B5C20")]
	private bool KHDBOKEKIJD(int JMJHPMGKKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x32B5490", Offset = "0x32B4290", VA = "0x1832B5490")]
	private void FNDHEBGEGGK(NativeHashMap<int, JCKJOPOBLHO> DDCKOABPDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public LEFGEFIJDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[DKGMECGHCPI(OJBFOICGDOF.Serialization)]
	public class PreSerializeRemoveEntities : CENINKGGFPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EntityQuery INDOAICPGMM;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x2D330E0", Offset = "0x2D31EE0", VA = "0x182D330E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x2D33360", Offset = "0x2D32160", VA = "0x182D33360", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[DKGMECGHCPI(OJBFOICGDOF.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : CENINKGGFPK, JPLAKHLHFLM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct LAKEANMBFCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public ComponentDataFromEntity dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
			public LAKEANMBFCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x44A1C00", Offset = "0x44A0A00", VA = "0x1844A1C00")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct DMABKOJKGHI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[ReadOnly]
			public NativeList<int> MBDEKLPMDOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			[ReadOnly]
			public NativeArray<Entity> OIACGDKHKKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public ComponentDataFromEntity JOMLIPIGFJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			[ReadOnly]
			public NativeArray<byte> KAHIPMIDNOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public int MBFANLMPGHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public ComponentType ACHMOOKCOKG;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x44A43A0", Offset = "0x44A31A0", VA = "0x1844A43A0")]
			internal void OPBACEEAMEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x44A4560", Offset = "0x44A3360", VA = "0x1844A4560", Slot = "5")]
			public void ReadFromDisplayClass(ref LAKEANMBFCG DBDHHAPIJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x44A4370", Offset = "0x44A3170", VA = "0x1844A4370", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x44A4380", Offset = "0x44A3180", VA = "0x1844A4380")]
			public void FBJFNGKGEAG(ShadowWorldApplyPropertyDifferencesToShadowWorld KHKMOBDDHBP, ref LAKEANMBFCG DBDHHAPIJND)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private PropertyDiffStateService NLHBFABKJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private JobHandle LNICKLOOAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JobHandle LDKLEFIGOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private EIHJALEFJJC GMDALJMBJKE;

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3620", Offset = "0x2FE2420", VA = "0x182FE3620", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3680", Offset = "0x2FE2480", VA = "0x182FE3680")]
		public JobHandle JHBHAOJGOFG(JobHandle DABCHKJGFPM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x2FE36C0", Offset = "0x2FE24C0", VA = "0x182FE36C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3310", Offset = "0x2FE2110", VA = "0x182FE3310")]
		private bool ABAGLBNNJMI(JobHandle DABCHKJGFPM, int JMJHPMGKKMH, out JobHandle JMHKBIKKDJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[JFPMCOMHGMD]
[ExecuteAlways]
[UpdateInGroup(typeof(CCJBNKKKNFM))]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
internal sealed class KHFDNPKGOMP : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x32B1200", Offset = "0x32B0000", VA = "0x1832B1200", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public KHFDNPKGOMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[JFPMCOMHGMD]
[ExecuteAlways]
[UpdateInGroup(typeof(POPEOKKPGPB))]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
internal sealed class CPGOEIFKNBJ : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x2EBCEF0", Offset = "0x2EBBCF0", VA = "0x182EBCEF0", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public CPGOEIFKNBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[JFPMCOMHGMD]
[ExecuteAlways]
[UpdateInGroup(typeof(FPMHFMCKIGB))]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
internal sealed class BGLKCADFJPE : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7760", Offset = "0x2EB6560", VA = "0x182EB7760", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public BGLKCADFJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[JFPMCOMHGMD]
[ExecuteAlways]
[UpdateInGroup(typeof(LGEKDPLLGIK))]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
internal sealed class GMFKNDIEPLG : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x32A2D60", Offset = "0x32A1B60", VA = "0x1832A2D60", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public GMFKNDIEPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class BPBEJPKGACL : NIPNGMMLIDP
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override KKOEPHEHHNN MJOKMBNGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x767C30", Offset = "0x766A30", VA = "0x180767C30", Slot = "18")]
		get
		{
			return default(KKOEPHEHHNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2EB84D0", Offset = "0x2EB72D0", VA = "0x182EB84D0")]
	public BPBEJPKGACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[JFPMCOMHGMD]
[ExecuteAlways]
[UpdateInGroup(typeof(LEMPJHMHLKC))]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
internal sealed class BBJGFIIPFFE : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x2EB6980", Offset = "0x2EB5780", VA = "0x182EB6980", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public BBJGFIIPFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class JBJGEILEHNO : CNPEJNDMKOG
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public JBJGEILEHNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class NIMBELCAGGE : NIPNGMMLIDP
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override KKOEPHEHHNN MJOKMBNGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "18")]
		get
		{
			return default(KKOEPHEHHNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public NIMBELCAGGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[JFPMCOMHGMD]
[ExecuteAlways]
[UpdateInGroup(typeof(ACMBDJLIJHF))]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
internal sealed class HMGIKGJICFG : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x32A5EE0", Offset = "0x32A4CE0", VA = "0x1832A5EE0", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public HMGIKGJICFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class KPJNODIPHPK : CNPEJNDMKOG
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public KPJNODIPHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class OEEGLOBDEDK : CNPEJNDMKOG
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public OEEGLOBDEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class GBELNEJKCKK : CENINKGGFPK
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public GBELNEJKCKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[AJHMADEHCDB]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
public class ABGFOACEMLP : CENINKGGFPK, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private TimeService KJGEPMINMNI;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4AC0", Offset = "0x2EB38C0", VA = "0x182EB4AC0", Slot = "14")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2EB4B10", Offset = "0x2EB3910", VA = "0x182EB4B10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public ABGFOACEMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.TransformSyncing)]
	public class CopyTransformDataFromGameObjects : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct JIFMJHIKNDJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private const float EOPDBLOGCJF = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[ReadOnly]
			public NativeArray<Entity> KMDDIGFEEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> BKKPJKLBEDD;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x2FDA9D0", Offset = "0x2FD97D0", VA = "0x182FDA9D0", Slot = "4")]
			public void Execute(int NNHNOIMLALG, TransformAccess KGHIPKNMKHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x2FDAB90", Offset = "0x2FD9990", VA = "0x182FDAB90")]
			private bool FDHJDDFDMME(float3 NCBOBCDAKLG, float3 DNEMONMIDEC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x2FDABD0", Offset = "0x2FD99D0", VA = "0x182FDABD0")]
			private bool LIJBGJAOJOF(quaternion NCBOBCDAKLG, quaternion DNEMONMIDEC)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		private struct GIFFMKKMIFI : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			[ReadOnly]
			public NativeArray<Entity> KMDDIGFEEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> HLAPAMGHAJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> NLEHJKGFAPL;

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9930", Offset = "0x2FD8730", VA = "0x182FD9930", Slot = "4")]
			public void Execute(int NNHNOIMLALG, TransformAccess KGHIPKNMKHP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly FGEMECIGOCC PIJJPBBMMLN;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly FGEMECIGOCC IJKEIJCJKBO;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly FGEMECIGOCC LEBLPAHGGON;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly ProfilerMarker EEOCDAANOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private GKPFAHJAGDC PDJLILLKNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private AEJNGPFNACL EOHGMNFKFFO;

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5A90", Offset = "0x2EC4890", VA = "0x182EC5A90", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5B00", Offset = "0x2EC4900", VA = "0x182EC5B00", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5B30", Offset = "0x2EC4930", VA = "0x182EC5B30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[DKGMECGHCPI(OJBFOICGDOF.TransformSyncing)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	public class RegisterTransforms : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct MFPBGCEMGCJ : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct HCFPNOHLMLG
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				public struct DGDGJOJAGIH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004CA")]
					public LambdaParameterValueProvider_Entity.Runtime LPBAJAEJLFN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004CB")]
					public LambdaParameterValueProvider_IComponentData<OHDKAJBDLEH>.Runtime BPLKJPDFBNC;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004CC")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime EHANLILLIBL;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity GPILJGHOMAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<OHDKAJBDLEH> OHFACNFPLCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> NPLKPAABDCB;

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x44A71D0", Offset = "0x44A5FD0", VA = "0x1844A71D0")]
				public void FBJFNGKGEAG(RegisterTransforms KHKMOBDDHBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x44A7250", Offset = "0x44A6050", VA = "0x1844A7250")]
				public DGDGJOJAGIH OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
				{
					return default(DGDGJOJAGIH);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private HCFPNOHLMLG CEHPMGEJNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HCFPNOHLMLG.DGDGJOJAGIH* PAGEGEKEMGJ;

			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LMEJDEJHIBP;

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x44AB010", Offset = "0x44A9E10", VA = "0x1844AB010")]
			internal void OPBACEEAMEO(Entity NEAKDKENHHP, OHDKAJBDLEH NBMFMGFDNJC, Transform KGHIPKNMKHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x44AAEA0", Offset = "0x44A9CA0", VA = "0x1844AAEA0", Slot = "4")]
			public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x44AB110", Offset = "0x44A9F10", VA = "0x1844AB110")]
			public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, ref HCFPNOHLMLG.DGDGJOJAGIH ICBLKLNOLAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x44AAF90", Offset = "0x44A9D90", VA = "0x1844AAF90")]
			public void FBJFNGKGEAG(RegisterTransforms KHKMOBDDHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x44AAFA0", Offset = "0x44A9DA0", VA = "0x1844AAFA0")]
			public unsafe static void HNMDANPFJNG(ArchetypeChunkIterator* DDBGPMPNMAB, void* HHAGMJBBFIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct OAJDCFPKEDB : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000190")]
			private struct GPDGBHBAOOL
			{
				[Cpp2IlInjected.Token(Token = "0x2000191")]
				[NoAlias]
				public struct BNEJBFBHFMP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004D1")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime LPBAJAEJLFN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004D2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<OHDKAJBDLEH>.Runtime BPLKJPDFBNC;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004CF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity GPILJGHOMAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004D0")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<OHDKAJBDLEH> OHFACNFPLCJ;

				[Cpp2IlInjected.Token(Token = "0x6000AA3")]
				[Cpp2IlInjected.Address(RVA = "0x44A70F0", Offset = "0x44A5EF0", VA = "0x1844A70F0")]
				public void FBJFNGKGEAG(RegisterTransforms KHKMOBDDHBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x44A7150", Offset = "0x44A5F50", VA = "0x1844A7150")]
				public BNEJBFBHFMP OGBONCDAHGF(ref ArchetypeChunk ELBFLOLLCLM, int IINBHCFHOMC, int IICHIPIFCMJ)
				{
					return default(BNEJBFBHFMP);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private GPDGBHBAOOL CEHPMGEJNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe GPDGBHBAOOL.BNEJBFBHFMP* PAGEGEKEMGJ;

			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x44AC6E0", Offset = "0x44AB4E0", VA = "0x1844AC6E0")]
			internal void OPBACEEAMEO(Entity NEAKDKENHHP, OHDKAJBDLEH NBMFMGFDNJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x44AC650", Offset = "0x44AB450", VA = "0x1844AC650", Slot = "4")]
			public void Execute(ArchetypeChunk CFENEJCFJAK, int BCPIMODLIBN, int HPGOGDGKMKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x44AC7C0", Offset = "0x44AB5C0", VA = "0x1844AC7C0")]
			public void PLIDCPEJIPD(ref ArchetypeChunk CFENEJCFJAK, [NoAlias] ref GPDGBHBAOOL.BNEJBFBHFMP ICBLKLNOLAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x44A70F0", Offset = "0x44A5EF0", VA = "0x1844A70F0")]
			public void FBJFNGKGEAG(RegisterTransforms KHKMOBDDHBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private GKPFAHJAGDC PDJLILLKNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery BIFIKFJPKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery JNEDCHLAKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EntityQuery AFDILEDDHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private EntityQuery EJHELGNOBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private EntityQuery NMKHGLAAJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ProfilerMarker MHCLAINIPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private EntityQuery NHCAJDPJCOD;

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x2FDC1B0", Offset = "0x2FDAFB0", VA = "0x182FDC1B0", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD180", Offset = "0x2FDBF80", VA = "0x182FDD180", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD390", Offset = "0x2FDC190", VA = "0x182FDD390", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2FDC8C0", Offset = "0x2FDB6C0", VA = "0x182FDC8C0")]
		private void HOOFKONIFDJ(EntityQuery NOJJNNFMBAH, PGIDFFDFCKO AFNOKICNJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x2FDCB00", Offset = "0x2FDB900", VA = "0x182FDCB00")]
		private void KDKOMMNFJOO(EntityQuery NOJJNNFMBAH, PGIDFFDFCKO AFNOKICNJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD330", Offset = "0x2FDC130", VA = "0x182FDD330", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x2FDC070", Offset = "0x2FDAE70", VA = "0x182FDC070")]
		private void CMHHFDKIKMJ(NativeArray<Entity> KMDDIGFEEEI, PGIDFFDFCKO AFNOKICNJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2FDC200", Offset = "0x2FDB000", VA = "0x182FDC200")]
		[BurstCompile]
		internal static void ELAOAJNJEGC(NativeArray<OHDKAJBDLEH> IOCJCCCNIEH, ComponentDataFromEntity<OHDKAJBDLEH> GEHCCBBMEBA, PGIDFFDFCKO AFNOKICNJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		private static void MJDGGBLJMNK(Transform KGHIPKNMKHP, Entity NEAKDKENHHP, int NNHNOIMLALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		private static void HPAOFLADKMM(Entity NEAKDKENHHP, int NNHNOIMLALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		private static void CKGGCFMMIGK(int NNHNOIMLALG, PGIDFFDFCKO AFNOKICNJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2FDC6E0", Offset = "0x2FDB4E0", VA = "0x182FDC6E0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void HLBBFFLCIDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2FDCF10", Offset = "0x2FDBD10", VA = "0x182FDCF10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2FDCD70", Offset = "0x2FDBB70", VA = "0x182FDCD70")]
		public static EntityQuery OJDBEIANCFA(ComponentSystemBase KHKMOBDDHBP)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x2FDC510", Offset = "0x2FDB310", VA = "0x182FDC510")]
		public static EntityQuery GCNKKGNCHLJ(ComponentSystemBase KHKMOBDDHBP)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	[DKGMECGHCPI(OJBFOICGDOF.TransformSyncing)]
	public class CopyTransformDataToGameObjects : CENINKGGFPK, JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[BurstCompile]
		private struct HOALJNANCBJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> BKKPJKLBEDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public NativeArray<Entity> KMDDIGFEEEI;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9E20", Offset = "0x2FD8C20", VA = "0x182FD9E20", Slot = "4")]
			public void Execute(int NNHNOIMLALG, TransformAccess KGHIPKNMKHP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[BurstCompile]
		private struct JMFAOKCCKEK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> HLAPAMGHAJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public NativeArray<Entity> KMDDIGFEEEI;

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x2FDAC40", Offset = "0x2FD9A40", VA = "0x182FDAC40", Slot = "4")]
			public void Execute(int NNHNOIMLALG, TransformAccess KGHIPKNMKHP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct JAPNBMNAILG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> HLAPAMGHAJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> NLEHJKGFAPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			[ReadOnly]
			public NativeArray<Entity> KMDDIGFEEEI;

			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x2FDA370", Offset = "0x2FD9170", VA = "0x182FDA370", Slot = "4")]
			public void Execute(int NNHNOIMLALG, TransformAccess KGHIPKNMKHP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly FGEMECIGOCC PIJJPBBMMLN;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly FGEMECIGOCC IJKEIJCJKBO;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static readonly FGEMECIGOCC LEBLPAHGGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private GKPFAHJAGDC PDJLILLKNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery BDEIKMPMBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EntityQuery CKIIECOBLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private EntityQuery JDAPFNCCDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TransformAccessArray JOFHKBPBONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TransformAccessArray GAPCKPEFMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TransformAccessArray PDFLICILONC;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5FE0", Offset = "0x2EC4DE0", VA = "0x182EC5FE0", Slot = "14")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC61B0", Offset = "0x2EC4FB0", VA = "0x182EC61B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x2EC63A0", Offset = "0x2EC51A0", VA = "0x182EC63A0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6430", Offset = "0x2EC5230", VA = "0x182EC6430", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6460", Offset = "0x2EC5260", VA = "0x182EC6460", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6030", Offset = "0x2EC4E30", VA = "0x182EC6030")]
		private NativeArray<Entity> KBNHMCONBBN(NativeArray<OHDKAJBDLEH> MBDEKLPMDOP, NativeList<Entity> GIBCHKHFFAJ, TransformAccessArray PBJDAGENLDE, TransformAccessArray IMBDCKKCHAI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[DKGMECGHCPI(OJBFOICGDOF.TransformSyncing)]
	[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
	public class CopyTransformParentsToGameObjects : CENINKGGFPK, NEGCPFIDGDD
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private EHGPJENGIMI NKHACCELHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private CICKPKKFIHK GAGLCOBIACG;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x2D33720", Offset = "0x2D32520", VA = "0x182D33720", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6D90", Offset = "0x2EC5B90", VA = "0x182EC6D90", Slot = "14")]
		public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7180", Offset = "0x2EC5F80", VA = "0x182EC7180", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6F60", Offset = "0x2EC5D60", VA = "0x182EC6F60")]
		private static void KLLHOKMCKKG(EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, Entity GANAMHNGMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC70E0", Offset = "0x2EC5EE0", VA = "0x182EC70E0")]
		private static bool OGOEGJMKFMI(EntityManager PAHBLOLNPLD, Entity NEAKDKENHHP, out Transform KGHIPKNMKHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[DKGMECGHCPI(OJBFOICGDOF.TransformSyncing)]
	public class L2PToL2WHierarchy : CENINKGGFPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[BurstCompile]
		private struct FGGFIJNCJAI : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> NFKOKNOHLCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> KNNBPACHDBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> AIOIGCPMMCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> PDKLPEINKEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public ArchetypeChunkComponentType<LocalToWorldData> NEJJECGDPDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> LHJOJGFPEGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public uint CEMBNPIOMHK;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x44A6360", Offset = "0x44A5160", VA = "0x1844A6360")]
			[Conditional("DEBUG_BUILD")]
			private void KMBCDKDFFLJ(Entity NEAKDKENHHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x44A5C70", Offset = "0x44A4A70", VA = "0x1844A5C70", Slot = "4")]
			public void Execute(ArchetypeChunk CFENEJCFJAK, int NNHNOIMLALG, int HCJOMGLMNPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x44A5F60", Offset = "0x44A4D60", VA = "0x1844A5F60")]
			private void HKCMNBIKPDA(float4x4 EGLJMJEAJCI, Entity NEAKDKENHHP, bool NEICKIMFILH, int JDFNCOHPHEI = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery KGNOIBGDDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery CGDGJGEGBHK;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x32B3A40", Offset = "0x32B2840", VA = "0x1832B3A40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x32B3B60", Offset = "0x32B2960", VA = "0x1832B3B60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class NOLOBANJCDO : CCDGKGFAGLN
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct ENHNLEFBLII : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> NFKOKNOHLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ArchetypeChunkComponentType<LocalToWorldData> NEJJECGDPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public uint CEMBNPIOMHK;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x44A4D10", Offset = "0x44A3B10", VA = "0x1844A4D10", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int NNHNOIMLALG, int HCJOMGLMNPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x44A4E10", Offset = "0x44A3C10", VA = "0x1844A4E10")]
		public bool MIMFCAIIKEF(ArchetypeChunk CFENEJCFJAK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery KGNOIBGDDDN;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D250", Offset = "0x2D1C050", VA = "0x182D1D250", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D380", Offset = "0x2D1C180", VA = "0x182D1D380", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OIKDMLJCOEA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public NOLOBANJCDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class CFGCMCKFHOK : CCDGKGFAGLN
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct MFLLNLELKAK : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> DODFPKPPCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public ArchetypeChunkComponentType<WorldPoseData> DAJOKBLFEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> EDHFIJFAANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> IINMAKGAEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public uint CEMBNPIOMHK;

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x2FDBB60", Offset = "0x2FDA960", VA = "0x182FDBB60", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int NNHNOIMLALG, int HCJOMGLMNPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x2FDBF10", Offset = "0x2FDAD10", VA = "0x182FDBF10")]
		public bool MIMFCAIIKEF(ArchetypeChunk CFENEJCFJAK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery LPMGOCJAKCP;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB530", Offset = "0x2EBA330", VA = "0x182EBB530", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x2EBB640", Offset = "0x2EBA440", VA = "0x182EBB640", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OIKDMLJCOEA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0xF01AA0", Offset = "0xF008A0", VA = "0x180F01AA0")]
	public CFGCMCKFHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class GPLFLIAFCFE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct LKOEHOMEBKD : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> MEMMFJMOKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> AHFEKBJBMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> AOGKIFLIIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ArchetypeChunkComponentType<LocalToParentData> OICJBFEIJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public uint CEMBNPIOMHK;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x44A9400", Offset = "0x44A8200", VA = "0x1844A9400", Slot = "4")]
		public void Execute(ArchetypeChunk CFENEJCFJAK, int NNHNOIMLALG, int HCJOMGLMNPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x44A9B10", Offset = "0x44A8910", VA = "0x1844A9B10")]
		public bool MIMFCAIIKEF(ArchetypeChunk CFENEJCFJAK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery LPMGOCJAKCP;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x32A3560", Offset = "0x32A2360", VA = "0x1832A3560", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x32A3690", Offset = "0x32A2490", VA = "0x1832A3690", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle OIKDMLJCOEA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0")]
	public GPLFLIAFCFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[DKGMECGHCPI(OJBFOICGDOF.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : MBMFLIJKLGP
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public struct LPEAADCCLHC : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override ComponentType INNPLHHJJCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x2D34150", Offset = "0x2D32F50", VA = "0x182D34150", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType FOGFKHBLBJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x2D34180", Offset = "0x2D32F80", VA = "0x182D34180", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType OJPEAJKJGCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x2D34120", Offset = "0x2D32F20", VA = "0x182D34120", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2D19D40", Offset = "0x2D18B40", VA = "0x182D19D40")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[KGBNGDCCBPL(GBFMHHOKKMG.Game)]
public class BLJGKIMPOOE : PDAIJELFDEO
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type IEFAGFBLBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2EB7930", Offset = "0x2EB6730", VA = "0x182EB7930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] HKKMFIENLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x2EB79A0", Offset = "0x2EB67A0", VA = "0x182EB79A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BLJGKIMPOOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[KGBNGDCCBPL(GBFMHHOKKMG.Loading)]
public class MKNMMMJNGEM : PDAIJELFDEO
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type IEFAGFBLBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] HKKMFIENLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A370", Offset = "0x2D19170", VA = "0x182D1A370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MKNMMMJNGEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class NJFJOMNECKB : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CB60", Offset = "0x2D1B960", VA = "0x182D1CB60", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public NJFJOMNECKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[KGBNGDCCBPL(GBFMHHOKKMG.Saving)]
public class PAOONKIPNCI : PDAIJELFDEO
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type IEFAGFBLBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] HKKMFIENLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2D2BED0", Offset = "0x2D2ACD0", VA = "0x182D2BED0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public PAOONKIPNCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class NFFEIPDBPMI : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C510", Offset = "0x2D1B310", VA = "0x182D1C510", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public NFFEIPDBPMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[KGBNGDCCBPL(GBFMHHOKKMG.Simulation)]
public class MAAKHELNMHN : PDAIJELFDEO
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public Type IEFAGFBLBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x2D18190", Offset = "0x2D16F90", VA = "0x182D18190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] HKKMFIENLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x2D18200", Offset = "0x2D17000", VA = "0x182D18200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public MAAKHELNMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[GDFKOGKEDCG(typeof(EABLKOCAIPO), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
internal class EABLKOCAIPO : NEGCPFIDGDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private global::HHAJDOOHLOD<AuthoredParentData, NOHLODEKBPA, CONHOMJMCGH, AuthoredChildrenData> MICDHGNCHMM;

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x2ECE660", Offset = "0x2ECD460", VA = "0x182ECE660", Slot = "4")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public EABLKOCAIPO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[GDFKOGKEDCG(typeof(EntityHierarchyParents), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.HierarchySystems)]
	internal sealed class EntityHierarchyParents : JPLAKHLHFLM, NEGCPFIDGDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[DNEBGGIIGBA]
		private EOKNELNBMBB LPMGOCJAKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[DNEBGGIIGBA]
		private PropertyChangeNetworkRouter BOAOPADFMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private global::POPOOFGODGI<Entity> FHINIKPHPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private global::HHAJDOOHLOD<ParentData, PCOKOPHGBCI, COCAFKEMOAD, ChildrenData> MICDHGNCHMM;

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x329B920", Offset = "0x329A720", VA = "0x18329B920", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x329B990", Offset = "0x329A790", VA = "0x18329B990", Slot = "5")]
		public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x329BA90", Offset = "0x329A890", VA = "0x18329BA90")]
		public Entity GDGNMAEBLIK(Entity NEAKDKENHHP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x329B6E0", Offset = "0x329A4E0", VA = "0x18329B6E0")]
		public bool CCCLAJJMOJG(Entity NEAKDKENHHP, Entity EBAJDMMJHBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x329BAE0", Offset = "0x329A8E0", VA = "0x18329BAE0")]
		public bool LHHNBAKNDJK(Entity NEAKDKENHHP, Entity EBAJDMMJHBJ, bool HGILIEKABBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x329B740", Offset = "0x329A540", VA = "0x18329B740")]
		private bool CHBLKDOFABE(Entity NEAKDKENHHP, Entity EBAJDMMJHBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
[GDFKOGKEDCG(typeof(FLFEDLBACFM), new string[] { })]
internal sealed class FLFEDLBACFM : JPLAKHLHFLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	[DNEBGGIIGBA]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery EOLMEKHBIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EntityManager CCEKCIJDDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x329DFE0", Offset = "0x329CDE0", VA = "0x18329DFE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x329DB90", Offset = "0x329C990", VA = "0x18329DB90", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x329DB70", Offset = "0x329C970", VA = "0x18329DB70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x329E030", Offset = "0x329CE30", VA = "0x18329E030")]
	public bool IEKAEDOCFHK(Entity NEAKDKENHHP, Entity DEKNDEIHCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x329D9F0", Offset = "0x329C7F0", VA = "0x18329D9F0")]
	public IEnumerable<Entity> DOLFPEHJDDA(Entity NEAKDKENHHP, bool JCJOHJLDEGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x329DC90", Offset = "0x329CA90", VA = "0x18329DC90")]
	public bool FHDFBCILAKL(Entity NEAKDKENHHP, Entity LDCHDOICMMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x329D800", Offset = "0x329C600", VA = "0x18329D800")]
	public bool CKLEPDHPDLB(Entity NEAKDKENHHP, Entity BFHFOJLNIBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x329D720", Offset = "0x329C520", VA = "0x18329D720")]
	public NativeList<Entity> AOKPBDNFLEC(Entity NEAKDKENHHP, bool JCJOHJLDEGL = false, Allocator MBJMPHBLMBF = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x329E0F0", Offset = "0x329CEF0", VA = "0x18329E0F0")]
	public IEnumerable<Entity> IFCFIKDPHDL(Entity NEAKDKENHHP, bool JCJOHJLDEGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x329E340", Offset = "0x329D140", VA = "0x18329E340")]
	public Entity NLBAAPEIHLL(Entity NEAKDKENHHP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x329E2F0", Offset = "0x329D0F0", VA = "0x18329E2F0")]
	public NativeArray<Entity> LKPMFJHOJAL()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x329DDC0", Offset = "0x329CBC0", VA = "0x18329DDC0")]
	public bool HHABHMMJHLE(Entity BFHFOJLNIBJ, Entity LCOPPMGLLED, out Entity AMDBLMMBPFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x329D900", Offset = "0x329C700", VA = "0x18329D900")]
	private Entity CMEIMJNHMIK(Entity NEAKDKENHHP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public FLFEDLBACFM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[DKGMECGHCPI(OJBFOICGDOF.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x27EC8A0", Offset = "0x27EB6A0", VA = "0x1827EC8A0")]
		public static void OLEPBNNLDDG<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(LKAAGIKDPMH MENEIDJFFEP, global::KIEJCGOPPBK<Entity> HANNKCHKNMG, out global::HHAJDOOHLOD<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> GCJODOFFKKC) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, GGMPGKPHADB where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, GGMPGKPHADB, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E540", Offset = "0x2D2D340", VA = "0x182D2E540")]
		public static bool DLMIKOPBBNJ(EGBCNCKGEND LNBPHBEKGAD)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class HHAJDOOHLOD<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, GGMPGKPHADB where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, GGMPGKPHADB, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly FGEMECIGOCC EKOKIILLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private readonly AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private readonly global::POPOOFGODGI<Entity> FHINIKPHPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private readonly PPBAOAMBNHH CLPANBFEHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private readonly LMCAKPAONGF GANAMHNGMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly EntityManager PAHBLOLNPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly CICKPKKFIHK GAGLCOBIACG;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x35DD1E0", Offset = "0x35DBFE0", VA = "0x1835DD1E0")]
	public HHAJDOOHLOD(LKAAGIKDPMH MENEIDJFFEP, global::KIEJCGOPPBK<Entity> HANNKCHKNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x35DCB30", Offset = "0x35DB930", VA = "0x1835DCB30")]
	private bool PIAACKLGNGH(Entity NEAKDKENHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x35DBE10", Offset = "0x35DAC10", VA = "0x1835DBE10")]
	private bool BHELKHNFPGP(Entity NEAKDKENHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x35DBE60", Offset = "0x35DAC60", VA = "0x1835DBE60")]
	public bool CCCLAJJMOJG(Entity NEAKDKENHHP, in Entity EBAJDMMJHBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x35DBDE0", Offset = "0x35DABE0", VA = "0x1835DBDE0")]
	public bool BAOIBNBMEDH(Entity NEAKDKENHHP, in Entity EBAJDMMJHBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x35DB9A0", Offset = "0x35DA7A0", VA = "0x1835DB9A0")]
	private bool BAOIBNBMEDH(Entity NEAKDKENHHP, in Entity EBAJDMMJHBJ, bool EAIGIHNHBMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void IEBAIDIFILF(Entity NEAKDKENHHP, in Entity EBAJDMMJHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void DNBGPPMFFKO(Entity NEAKDKENHHP, in Entity EBAJDMMJHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void JAAGLFGKMKC(Entity NEAKDKENHHP, in Entity EBAJDMMJHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void HIBJJGFJLGL(Entity NEAKDKENHHP, in Entity EBAJDMMJHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private static void CNGOKDPKKMF(Entity NEAKDKENHHP, in Entity EBAJDMMJHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x35DC0A0", Offset = "0x35DAEA0", VA = "0x1835DC0A0")]
	private bool IEKAEDOCFHK(Entity NEAKDKENHHP, Entity DEKNDEIHCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x35DC8C0", Offset = "0x35DB6C0", VA = "0x1835DC8C0")]
	private void LHOMANLHDJM(Entity NEAKDKENHHP, in Entity LGBLENLGMIP, in Entity EBAJDMMJHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x35DC720", Offset = "0x35DB520", VA = "0x1835DC720")]
	private void JMPNGHKHOPB(Entity NEAKDKENHHP, in Entity LGBLENLGMIP, in Entity EBAJDMMJHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x35DC380", Offset = "0x35DB180", VA = "0x1835DC380")]
	private bool JFEPCHNIDFB(JGMKMBGBDJP PIPEONHBKBP, in MFDODOEBKCJ KDMCNECEHCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x35DBE90", Offset = "0x35DAC90", VA = "0x1835DBE90")]
	private void FIIMPCEKEOB(Entity GANAMHNGMGO, Entity LDCHDOICMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x35DC9B0", Offset = "0x35DB7B0", VA = "0x1835DC9B0")]
	private void MJIINKEILDI(Entity GANAMHNGMGO, Entity LDCHDOICMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private void CKGGCFMMIGK(Entity NEAKDKENHHP, Entity LGBLENLGMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	private void MJDGGBLJMNK(Entity NEAKDKENHHP, Entity EBAJDMMJHBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct AIJLHKGIGJG : GIILAPEPKKN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public FFMMEOPFOOM GDOAAODOKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x740000", Offset = "0x73EE00", VA = "0x180740000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FFMMEOPFOOM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x7A65B0", Offset = "0x7A53B0", VA = "0x1807A65B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[GDFKOGKEDCG(typeof(ObjectEmbodimentService), new string[] { })]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[DKGMECGHCPI(OJBFOICGDOF.Embodiment)]
	internal sealed class ObjectEmbodimentService : KHEIMMLCGKM, MDEPDIFNFKG, JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private ObjectLifecycleService LHNDLBANJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[DNEBGGIIGBA]
		private EOKNELNBMBB LPMGOCJAKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[DNEBGGIIGBA]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[DNEBGGIIGBA]
		private LNDAGNKEEKN NOAFOBDAJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[DNEBGGIIGBA]
		private CDEJGDBDLCH BLDFMDNNPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[DNEBGGIIGBA]
		private TransformOwnershipPhase IGKPCADJEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private readonly Dictionary<MFDODOEBKCJ, BOGOKBNBEFE> DAAACEBLNAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private PPBEACIICIJ GDLGJDACDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool LINNMJPFKHN;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager CCEKCIJDDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x2D21B80", Offset = "0x2D20980", VA = "0x182D21B80")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int FHPJHCMAIHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x2D236F0", Offset = "0x2D224F0", VA = "0x182D236F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int CPJHHJPKFKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x2D22AC0", Offset = "0x2D218C0", VA = "0x182D22AC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x1BAF6D0", Offset = "0x1BAE4D0", VA = "0x181BAF6D0", Slot = "4")]
		public void NIACEKGLEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2D206F0", Offset = "0x2D1F4F0", VA = "0x182D206F0", Slot = "5")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2D21670", Offset = "0x2D20470", VA = "0x182D21670")]
		public void HEJLIMLDEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2D20AF0", Offset = "0x2D1F8F0", VA = "0x182D20AF0", Slot = "6")]
		public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2D205C0", Offset = "0x2D1F3C0", VA = "0x182D205C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2D23720", Offset = "0x2D22520", VA = "0x182D23720")]
		public int PDCOKFBLHIA(SceneTag OAALIIEEAME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x2D1FAC0", Offset = "0x2D1E8C0", VA = "0x182D1FAC0")]
		public int CAFKLEDEFJD(SceneTag OAALIIEEAME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2D22B90", Offset = "0x2D21990", VA = "0x182D22B90")]
		public bool OAFCILOPKEP(Entity NEAKDKENHHP, Allocator MBJMPHBLMBF, out NativeList<Entity> EOIHMNGABIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2D22050", Offset = "0x2D20E50", VA = "0x182D22050")]
		public bool JNGLHLEEAOC(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2D1FA50", Offset = "0x2D1E850", VA = "0x182D1FA50")]
		public bool BIJLKKKABDK(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x2D233D0", Offset = "0x2D221D0", VA = "0x182D233D0")]
		public bool OIBIDLDJMDF(Entity NEAKDKENHHP, out BOGOKBNBEFE FNEHIFGGEEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2D23320", Offset = "0x2D22120", VA = "0x182D23320")]
		private bool OIBIDLDJMDF(Transform KGHIPKNMKHP, out BOGOKBNBEFE FNEHIFGGEEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2D20A40", Offset = "0x2D1F840", VA = "0x182D20A40")]
		private void ENOCAFOAPNN(Entity NEAKDKENHHP, BOGOKBNBEFE FNEHIFGGEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2D22B20", Offset = "0x2D21920", VA = "0x182D22B20")]
		private bool MNEHBIKHLIJ(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2D21210", Offset = "0x2D20010", VA = "0x182D21210")]
		public void GLJEDJEGGBC(MFDODOEBKCJ FIIEHBGLOHB, BOGOKBNBEFE HBKFLBDCJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2D20E50", Offset = "0x2D1FC50", VA = "0x182D20E50")]
		public bool GKAFDPLBCAC(Entity NEAKDKENHHP, object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2D22710", Offset = "0x2D21510", VA = "0x182D22710")]
		public bool LKFDHEMLLKP(CGKCPDMKDFM HPLAKDFIDCJ, object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2D22310", Offset = "0x2D21110", VA = "0x182D22310")]
		public bool LKFDHEMLLKP(Entity NEAKDKENHHP, [Optional] object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2D222F0", Offset = "0x2D210F0", VA = "0x182D222F0")]
		public bool LKFDHEMLLKP(BOGOKBNBEFE LNBPHBEKGAD, object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2D22E30", Offset = "0x2D21C30", VA = "0x182D22E30")]
		public bool OEIMAKFNOOC(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2D23220", Offset = "0x2D22020", VA = "0x182D23220")]
		public bool OEIMAKFNOOC(BOGOKBNBEFE FNEHIFGGEEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2D22360", Offset = "0x2D21160", VA = "0x182D22360")]
		public bool LKFDHEMLLKP(BOGOKBNBEFE FNEHIFGGEEN, [Optional] object AMBDKIOJFBL, bool ONFDAKCOPIF = false, bool IBMCPFDKDAK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2D21550", Offset = "0x2D20350", VA = "0x182D21550")]
		public Transform GNCJOLNGNHB(Entity NEAKDKENHHP, [Optional] object AMBDKIOJFBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2D23250", Offset = "0x2D22050", VA = "0x182D23250")]
		public bool OGOEGJMKFMI(Entity NEAKDKENHHP, out Transform KGHIPKNMKHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2D20CE0", Offset = "0x2D1FAE0", VA = "0x182D20CE0")]
		public BOGOKBNBEFE GGJLDHOIIEB(Entity NEAKDKENHHP, [Optional] object AMBDKIOJFBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2D20250", Offset = "0x2D1F050", VA = "0x182D20250")]
		public void DCIACLMEMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x2D21760", Offset = "0x2D20560", VA = "0x182D21760")]
		public void HKLJCNJPACG(SceneTag OAALIIEEAME, bool BHGJIPMHKFG, global::DIKACGHNDIB<int> DKGNKBEEKDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x2D1FB70", Offset = "0x2D1E970", VA = "0x182D1FB70")]
		private void CIIDMNELMAP(Entity NEAKDKENHHP, bool BHGJIPMHKFG, bool CPLDMGBNFHK, global::DIKACGHNDIB<int> DKGNKBEEKDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x2D20C40", Offset = "0x2D1FA40", VA = "0x182D20C40")]
		private void FMNJBOABBFO(Entity NEAKDKENHHP, BOGOKBNBEFE FNEHIFGGEEN, bool BHGJIPMHKFG, bool CPLDMGBNFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x2D20500", Offset = "0x2D1F300", VA = "0x182D20500")]
		public BOGOKBNBEFE DCIGOGFIKHH(Entity NEAKDKENHHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2D21BD0", Offset = "0x2D209D0", VA = "0x182D21BD0")]
		public bool HNDJOPKPFJK(Entity NEAKDKENHHP, object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x2D1FAF0", Offset = "0x2D1E8F0", VA = "0x182D1FAF0")]
		public bool CHCADJAODHG(Entity NEAKDKENHHP, object AMBDKIOJFBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2D20550", Offset = "0x2D1F350", VA = "0x182D20550")]
		public bool DDKACAAGONK(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2D21F10", Offset = "0x2D20D10", VA = "0x182D21F10")]
		public bool JHAANOMAEAO(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2D21F80", Offset = "0x2D20D80", VA = "0x182D21F80")]
		public bool JHAANOMAEAO(FFMMEOPFOOM EAHLOGLBEGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void KMKMHHNMKAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2D21C50", Offset = "0x2D20A50", VA = "0x182D21C50")]
		private void IGONNIBPBAK(bool PKDEAGINFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2D214C0", Offset = "0x2D202C0", VA = "0x182D214C0")]
		private bool GNBIEPKEFHI(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2D216C0", Offset = "0x2D204C0", VA = "0x182D216C0")]
		private BOGOKBNBEFE HKFDFPBBPEA(Entity NEAKDKENHHP, object AMBDKIOJFBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F860", Offset = "0x2D1E660", VA = "0x182D1F860")]
		private BOGOKBNBEFE BDHGOLMMCKD(Entity NEAKDKENHHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2D20820", Offset = "0x2D1F620", VA = "0x182D20820")]
		private (Vector3, Quaternion, Vector3) ENFGBCKKLEC(Entity NEAKDKENHHP)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2D20020", Offset = "0x2D1EE20", VA = "0x182D20020")]
		private void COHPNIDOAPF(Entity NEAKDKENHHP, IAFDFFOCDLF KCFAHJGLHLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2D21450", Offset = "0x2D20250", VA = "0x182D21450")]
		private void GMOFBKEMHHA(CGKCPDMKDFM HPLAKDFIDCJ, BOGOKBNBEFE HBKFLBDCJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2D21DF0", Offset = "0x2D20BF0", VA = "0x182D21DF0")]
		private void IKBHMNNAALE(BOGOKBNBEFE HBKFLBDCJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2D23490", Offset = "0x2D22290", VA = "0x182D23490")]
		private void OIBMCMGNPNB(BOGOKBNBEFE FNEHIFGGEEN, Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F600", Offset = "0x2D1E400", VA = "0x182D1F600")]
		private void ADGFOIMKAFK(Entity NEAKDKENHHP, BOGOKBNBEFE FNEHIFGGEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2D21D10", Offset = "0x2D20B10", VA = "0x182D21D10")]
		private void IJLBHBHNFGG(Entity NEAKDKENHHP, Transform KGHIPKNMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2D22AF0", Offset = "0x2D218F0", VA = "0x182D22AF0")]
		private CGKCPDMKDFM MAJLOGOOOGO(Entity NEAKDKENHHP)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2D237A0", Offset = "0x2D225A0", VA = "0x182D237A0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x2D20D80", Offset = "0x2D1FB80", VA = "0x182D20D80")]
		[CompilerGenerated]
		private void GJJHEOOBCAA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class ONNDMEHPJGA
{
	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E820", Offset = "0x2D1D620", VA = "0x182D1E820")]
	public static BOGOKBNBEFE GGJLDHOIIEB(this ObjectEmbodimentService DPEPLNEHLIL, CGKCPDMKDFM HPLAKDFIDCJ, [Optional] object AMBDKIOJFBL)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[GDFKOGKEDCG(typeof(ObjectLifecycleService), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.Lifecycle)]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	internal sealed class ObjectLifecycleService : JPLAKHLHFLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ObjectEmbodimentService FNEHIFGGEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL EOHGMNFKFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private KDBCABAKEFA CMDDNCNFEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DestroyLocalObjects MICGEMDIHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool LINNMJPFKHN;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		private EntityManager CCEKCIJDDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x2D24290", Offset = "0x2D23090", VA = "0x182D24290")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, IAFDFFOCDLF> BBGFPCOELEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x2D241B0", Offset = "0x2D22FB0", VA = "0x182D241B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x2D24CE0", Offset = "0x2D23AE0", VA = "0x182D24CE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> MFBCIOPGMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x2D24D80", Offset = "0x2D23B80", VA = "0x182D24D80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x2D24030", Offset = "0x2D22E30", VA = "0x182D24030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2D240D0", Offset = "0x2D22ED0", VA = "0x182D240D0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x10054E0", Offset = "0x10042E0", VA = "0x1810054E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2D24850", Offset = "0x2D23650", VA = "0x182D24850")]
		public bool LCHDIFCJOJC(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2D23EE0", Offset = "0x2D22CE0", VA = "0x182D23EE0")]
		internal void ALAIPIDFNNE(Entity NEAKDKENHHP, IAFDFFOCDLF KCFAHJGLHLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2D24250", Offset = "0x2D23050", VA = "0x182D24250")]
		public void HFIKMPOCHJC(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2D242E0", Offset = "0x2D230E0", VA = "0x182D242E0")]
		public void IDANHPDHEIN(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2D24590", Offset = "0x2D23390", VA = "0x182D24590")]
		private bool IKGLMFIHGFK(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2D248D0", Offset = "0x2D236D0", VA = "0x182D248D0")]
		public void LGPDJPMAIOD(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2D24B20", Offset = "0x2D23920", VA = "0x182D24B20")]
		private bool MGBHPCMGANI(Entity NEAKDKENHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2D23FA0", Offset = "0x2D22DA0", VA = "0x182D23FA0")]
		public void BLDGMOBIAFP(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2D23F40", Offset = "0x2D22D40", VA = "0x182D23F40")]
		private void BCDHICEPMIP(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2D24330", Offset = "0x2D23130", VA = "0x182D24330")]
		private void IFOLEAMLBPJ(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2D24AD0", Offset = "0x2D238D0", VA = "0x182D24AD0")]
		public void MDGEGFIAKGD(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		private void NBHBLFOHIFG(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x2D24650", Offset = "0x2D23450", VA = "0x182D24650")]
		private void KICAJJMOCEB(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[GDFKOGKEDCG(typeof(ObjectPrefabs), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.Prefabs)]
	internal class ObjectPrefabs : BACCEOHKDED, JPLAKHLHFLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class FOALADMOPPH : IEnumerable<(ENALNDEOHNF, IAFDFFOCDLF)>, IEnumerable, IEnumerator<(ENALNDEOHNF, IAFDFFOCDLF)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private (ENALNDEOHNF primitiveType, IAFDFFOCDLF prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700013A")]
			private (ENALNDEOHNF, IAFDFFOCDLF) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B85")]
				[Cpp2IlInjected.Address(RVA = "0x2355F70", Offset = "0x2354D70", VA = "0x182355F70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((ENALNDEOHNF, IAFDFFOCDLF));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B87")]
				[Cpp2IlInjected.Address(RVA = "0x44A68C0", Offset = "0x44A56C0", VA = "0x1844A68C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x2FD9900", Offset = "0x2FD8700", VA = "0x182FD9900")]
			[DebuggerHidden]
			public FOALADMOPPH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x44A66E0", Offset = "0x44A54E0", VA = "0x1844A66E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x44A6880", Offset = "0x44A5680", VA = "0x1844A6880", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x44A67E0", Offset = "0x44A55E0", VA = "0x1844A67E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(ENALNDEOHNF, IAFDFFOCDLF)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x44A67E0", Offset = "0x44A55E0", VA = "0x1844A67E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL EOHGMNFKFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private World BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly Dictionary<IAFDFFOCDLF, Entity> FHLJIJCKGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<IAFDFFOCDLF, EntityArchetype> ENCJCJLNBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private readonly Dictionary<ENALNDEOHNF, IAFDFFOCDLF> KPLFCCDJFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<LBMBGCOHJHK, IAFDFFOCDLF> NNCIEKGFLNJ;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public int JKIABPBFIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x2D28B10", Offset = "0x2D27910", VA = "0x182D28B10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager CCEKCIJDDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x2D284A0", Offset = "0x2D272A0", VA = "0x182D284A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x2D27D60", Offset = "0x2D26B60", VA = "0x182D27D60", Slot = "5")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x2D27A30", Offset = "0x2D26830", VA = "0x182D27A30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x2D28140", Offset = "0x2D26F40", VA = "0x182D28140")]
		internal IEnumerable<Type> EDLKMBCPHGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x2D28430", Offset = "0x2D27230", VA = "0x182D28430")]
		internal NMHEIOCPIJH GOBDHFBAKJI(Type LEDIIMFEFLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x2D281A0", Offset = "0x2D26FA0", VA = "0x182D281A0")]
		public EntityArchetype FMGJABCMJIP(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x2D278B0", Offset = "0x2D266B0", VA = "0x182D278B0")]
		public NativeHashMap<int, EntityArchetype> CKGGAICLNEG(Allocator MBJMPHBLMBF = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x2D28530", Offset = "0x2D27330", VA = "0x182D28530")]
		public bool IPKEAJJGBOH(IAFDFFOCDLF KCFAHJGLHLA, out EntityArchetype DFDCBJPJDKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x2D28CC0", Offset = "0x2D27AC0", VA = "0x182D28CC0", Slot = "4")]
		[IteratorStateMachine(typeof(FOALADMOPPH))]
		public IEnumerable<(ENALNDEOHNF, IAFDFFOCDLF)> PKCHKKPIIFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x2D28320", Offset = "0x2D27120", VA = "0x182D28320")]
		public Entity GLCFKEABDII(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x2D289F0", Offset = "0x2D277F0", VA = "0x182D289F0")]
		public IAFDFFOCDLF LMJPABMDDMP(LBMBGCOHJHK LEDIIMFEFLP)
		{
			return default(IAFDFFOCDLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x2D28A50", Offset = "0x2D27850", VA = "0x182D28A50")]
		public IAFDFFOCDLF LMJPABMDDMP(ENALNDEOHNF LEDIIMFEFLP)
		{
			return default(IAFDFFOCDLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2D274C0", Offset = "0x2D262C0", VA = "0x182D274C0")]
		public NativeHashMap<int, Entity> ABDNJKEBMIL(Allocator MBJMPHBLMBF = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2D27860", Offset = "0x2D26660", VA = "0x182D27860")]
		public IEnumerable<IAFDFFOCDLF> CBAIBOKMHOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x2D28AB0", Offset = "0x2D278B0", VA = "0x182D28AB0")]
		public Entity MLDEKCBFDJD(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x2D284C0", Offset = "0x2D272C0", VA = "0x182D284C0")]
		public bool IBFMGPCLKDD(IAFDFFOCDLF KCFAHJGLHLA, out Entity PEINAPABAGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x2D285A0", Offset = "0x2D273A0", VA = "0x182D285A0")]
		private void JDAHCJOCIME(NMHEIOCPIJH OOBGDACPNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x2D27630", Offset = "0x2D26430", VA = "0x182D27630")]
		internal void BLIBIMNDDAG(IAFDFFOCDLF KCFAHJGLHLA, ComponentTypeList JNHJFEHGOCG, OCDOGPHMNFN HLHGCJJJMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x2D28B60", Offset = "0x2D27960", VA = "0x182D28B60")]
		private void NJMHPCEFHAK(IAFDFFOCDLF KCFAHJGLHLA, ComponentTypeList NACFHNCPJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x2D28200", Offset = "0x2D27000", VA = "0x182D28200")]
		internal Entity FNAICAHEFLI(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x2D28D80", Offset = "0x2D27B80", VA = "0x182D28D80")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum KKOEPHEHHNN
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal interface FHGCPJJBCEA
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World EHMOILHLDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	JDPHJHEBALE PJGCHLMPOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal class DMMEFECCOLJ : KPHDFAICOOJ, EIHJALEFJJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly GFJMGOEJHDC KPABJKFJKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly KKOEPHEHHNN IGKPCADJEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly List<BDPKNCJACAA> HDKCBBGOOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private NativeMultiHashMap<Entity, KLMKJNOOIJN> HHIAGLHPIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NativeHashMap<int, int> OMCPPLPGIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private JobHandle PEIGPCCODEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private JobHandle IIFKNMPJHCD;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private World FPBOCIBJLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x2ECBB50", Offset = "0x2ECA950", VA = "0x182ECBB50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JDPHJHEBALE IIAKIOIGJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2ECBFD0", Offset = "0x2ECADD0", VA = "0x182ECBFD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private IECLDDPADOO BBOEPNLFMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x7557F0", Offset = "0x7545F0", VA = "0x1807557F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, KLMKJNOOIJN> JGJHGJMPKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x7621C0", Offset = "0x760FC0", VA = "0x1807621C0", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, KLMKJNOOIJN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle HGJGANLANEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB410", Offset = "0x1AAA210", VA = "0x181AAB410", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x1E773B0", Offset = "0x1E761B0", VA = "0x181E773B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool CDKKDHJFKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x2ECC440", Offset = "0x2ECB240", VA = "0x182ECC440", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World GLFGBGILJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x2ECC540", Offset = "0x2ECB340", VA = "0x182ECC540", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC900", Offset = "0x2ECB700", VA = "0x182ECC900")]
	public DMMEFECCOLJ(GFJMGOEJHDC KPABJKFJKFK, KKOEPHEHHNN IGKPCADJEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBFF0", Offset = "0x2ECADF0", VA = "0x182ECBFF0", Slot = "11")]
	private void IIMOBMEEMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC5A0", Offset = "0x2ECB3A0", VA = "0x182ECC5A0", Slot = "10")]
	private bool NDNOEDBHLPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC450", Offset = "0x2ECB250", VA = "0x182ECC450", Slot = "12")]
	private void LOMKEEJEBMN(ComponentType ACHMOOKCOKG, in BDPKNCJACAA CNEFNNFKFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBBF0", Offset = "0x2ECA9F0", VA = "0x182ECBBF0", Slot = "13")]
	private bool CFIJKGLMJOE(IAFDFFOCDLF KCFAHJGLHLA, out Entity PEINAPABAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBE40", Offset = "0x2ECAC40", VA = "0x182ECBE40", Slot = "16")]
	private bool EJJFEIPPJKJ(out NativeArray<int> IPHKHCPGEPK, Allocator MBJMPHBLMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC000", Offset = "0x2ECAE00", VA = "0x182ECC000", Slot = "17")]
	private bool IMBGEJJHNCC(ComponentType ACHMOOKCOKG, out BDPKNCJACAA ILJPIPFGHLD, out BGNMEHKBAPK NIAAPKAOANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC180", Offset = "0x2ECAF80", VA = "0x182ECC180", Slot = "18")]
	private bool IMBGEJJHNCC(ComponentType ACHMOOKCOKG, out BDPKNCJACAA ILJPIPFGHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBEE0", Offset = "0x2ECACE0", VA = "0x182ECBEE0", Slot = "19")]
	private BDPKNCJACAA FGNLOLBFKGN(ComponentType ACHMOOKCOKG)
	{
		return default(BDPKNCJACAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC400", Offset = "0x2ECB200", VA = "0x182ECC400", Slot = "20")]
	private PJBEBFLEPPK JKNIKMHEHHB()
	{
		return default(PJBEBFLEPPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBBB0", Offset = "0x2ECA9B0", VA = "0x182ECBBB0", Slot = "21")]
	private void BGLHBDLANKO(JobHandle BACBCMPFGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC690", Offset = "0x2ECB490", VA = "0x182ECC690")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBC20", Offset = "0x2ECAA20", VA = "0x182ECBC20")]
	private bool EDMHMPBPCKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC2B0", Offset = "0x2ECB0B0", VA = "0x182ECC2B0")]
	private int IMGMJGONAMH()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal class GFJMGOEJHDC : FHGCPJJBCEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public AEJNGPFNACL EOHGMNFKFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ObjectInstantiationService FHLJIJCKGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public JDPHJHEBALE CFOEJIGACJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public IECLDDPADOO CMNCFNBJLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public JGCOPBLAKJC OCEJDJPHFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public World EHMOILHLDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x32A19F0", Offset = "0x32A07F0", VA = "0x1832A19F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public JDPHJHEBALE PJGCHLMPOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GFJMGOEJHDC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[GDFKOGKEDCG(typeof(PropertyDiffStateService), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.PropertyChanges)]
	internal class PropertyDiffStateService : JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal readonly struct CCNFANKGKIM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private readonly KKOEPHEHHNN MNEEIGFJKPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private readonly PropertyDiffStateService HGNLGIBOCHA;

			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0x44A1F20", Offset = "0x44A0D20", VA = "0x1844A1F20")]
			public CCNFANKGKIM(PropertyDiffStateService HGNLGIBOCHA, KKOEPHEHHNN AOBPBHMKAOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x44A1F00", Offset = "0x44A0D00", VA = "0x1844A1F00", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly GFJMGOEJHDC KPABJKFJKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly DMMEFECCOLJ[] ALDDCKBNIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private KKOEPHEHHNN GJMAJNLJFHL;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public FHGCPJJBCEA PBGMOJMCENB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public EIHJALEFJJC DBILCFDOFAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x2B190B0", Offset = "0x2B17EB0", VA = "0x182B190B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public KPHDFAICOOJ JHMICEHHIKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x2B190B0", Offset = "0x2B17EB0", VA = "0x182B190B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x90FF50", Offset = "0x90ED50", VA = "0x18090FF50")]
		public EIHJALEFJJC LOLLDBADPIF(KKOEPHEHHNN IGKPCADJEGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x90FF50", Offset = "0x90ED50", VA = "0x18090FF50")]
		public KPHDFAICOOJ MPHANJEDGLO(KKOEPHEHHNN IGKPCADJEGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2D350C0", Offset = "0x2D33EC0", VA = "0x182D350C0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2D35140", Offset = "0x2D33F40", VA = "0x182D35140", Slot = "5")]
		public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2D353F0", Offset = "0x2D341F0", VA = "0x182D353F0")]
		public void ODCBHOABBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2D34FE0", Offset = "0x2D33DE0", VA = "0x182D34FE0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2D353D0", Offset = "0x2D341D0", VA = "0x182D353D0")]
		public CCNFANKGKIM MFFIGKODDJL(KKOEPHEHHNN IGKPCADJEGG)
		{
			return default(CCNFANKGKIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2D354A0", Offset = "0x2D342A0", VA = "0x182D354A0")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[DKGMECGHCPI(OJBFOICGDOF.HierarchySystems)]
	[GDFKOGKEDCG(typeof(SceneService), new string[] { })]
	internal class SceneService : JPLAKHLHFLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly SceneTag LJNAEAOPIAD;

		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public const string LCHCFKJAKFH = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private const string AFKDHHHINKP = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[DNEBGGIIGBA]
		private LPJCNLHLDJN HJLGKIBBEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[DNEBGGIIGBA]
		private ObjectEmbodimentService FNEHIFGGEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[DNEBGGIIGBA]
		private PPBAOAMBNHH FJJEAMJCBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[DNEBGGIIGBA]
		private SingletonComponentService CNIOIEABFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[DNEBGGIIGBA]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[DNEBGGIIGBA]
		private PhotonInstanceCleanupService OOJDMGJFBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery JAKBMAAOABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery MMADMHNNHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery EIPLJHGAPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private Entity JOCAKHMFBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool LINNMJPFKHN;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public bool MCINHELLDKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x2FDD9B0", Offset = "0x2FDC7B0", VA = "0x182FDD9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> LICMPKIIEKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x171C730", Offset = "0x171B530", VA = "0x18171C730")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0x2161BE0", Offset = "0x21609E0", VA = "0x182161BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity HILKIEIJGPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x2FDD750", Offset = "0x2FDC550", VA = "0x182FDD750")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag CNAHLEBPNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x2FDE3D0", Offset = "0x2FDD1D0", VA = "0x182FDE3D0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity IGDDKJLMOFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x2FDE3D0", Offset = "0x2FDD1D0", VA = "0x182FDE3D0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x2FDEDD0", Offset = "0x2FDDBD0", VA = "0x182FDEDD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager CCEKCIJDDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x2FDE630", Offset = "0x2FDD430", VA = "0x182FDE630")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE1C0", Offset = "0x2FDCFC0", VA = "0x182FDE1C0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE170", Offset = "0x2FDCF70", VA = "0x182FDE170", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE390", Offset = "0x2FDD190", VA = "0x182FDE390")]
		public void GHAPFEIDJMC(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2FDDF90", Offset = "0x2FDCD90", VA = "0x182FDDF90")]
		public NativeArray<Entity> DKAGJOOLGEA(Allocator MBJMPHBLMBF = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEC20", Offset = "0x2FDDA20", VA = "0x182FDEC20")]
		public void JAAABMPCEII(Entity OAALIIEEAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEFD0", Offset = "0x2FDDDD0", VA = "0x182FDEFD0")]
		public Entity MALMGBBFJCH(string ICIEGOLHGJN = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEF50", Offset = "0x2FDDD50", VA = "0x182FDEF50")]
		public void KKMDICKJHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF2B0", Offset = "0x2FDE0B0", VA = "0x182FDF2B0")]
		public void NDOHLIABOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE2F0", Offset = "0x2FDD0F0", VA = "0x182FDE2F0")]
		public void EKKAEPBKKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE2E0", Offset = "0x2FDD0E0", VA = "0x182FDE2E0")]
		public void EBLHPHLMHPM(Entity OAALIIEEAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF200", Offset = "0x2FDE000", VA = "0x182FDF200")]
		public bool NCKPBOIIEKI(Entity OAALIIEEAME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEB40", Offset = "0x2FDD940", VA = "0x182FDEB40")]
		public void IEHCKEMLGMG(Entity OAALIIEEAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEE40", Offset = "0x2FDDC40", VA = "0x182FDEE40")]
		public string JPLMDINNCMI(Entity OAALIIEEAME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		public void NPJIJKFDKFH(Entity OAALIIEEAME, string ICIEGOLHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF1E0", Offset = "0x2FDDFE0", VA = "0x182FDF1E0")]
		public bool NCGCADEMKLD(string ICIEGOLHGJN, out Entity OAALIIEEAME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD8A0", Offset = "0x2FDC6A0", VA = "0x182FDD8A0")]
		public void AMOEKEAPPPN(Entity OAALIIEEAME, bool NHPFCGLPFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE580", Offset = "0x2FDD380", VA = "0x182FDE580")]
		public void HFNLBEGAEJM(Entity NEAKDKENHHP, bool MNMGOLOFPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE420", Offset = "0x2FDD220", VA = "0x182FDE420")]
		public void HFNLBEGAEJM(NativeArray<Entity> KMDDIGFEEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE490", Offset = "0x2FDD290", VA = "0x182FDE490")]
		public void HFNLBEGAEJM(EntityQuery NOJJNNFMBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE680", Offset = "0x2FDD480", VA = "0x182FDE680")]
		public void HMJDJELLCMH(Entity NEAKDKENHHP, Entity OAALIIEEAME, bool MNMGOLOFPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE960", Offset = "0x2FDD760", VA = "0x182FDE960")]
		public void HMJDJELLCMH(NativeArray<Entity> KMDDIGFEEEI, Entity OAALIIEEAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE8B0", Offset = "0x2FDD6B0", VA = "0x182FDE8B0")]
		public void HMJDJELLCMH(EntityQuery NOJJNNFMBAH, Entity OAALIIEEAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2FDDFC0", Offset = "0x2FDCDC0", VA = "0x182FDDFC0")]
		private void DMFMLHFKAHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE600", Offset = "0x2FDD400", VA = "0x182FDE600")]
		private void HJKCLJAOHCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD750", Offset = "0x2FDC550", VA = "0x182FDD750")]
		private Entity AKMFGCAIBPL()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2FDED20", Offset = "0x2FDDB20", VA = "0x182FDED20")]
		private void JCFOBJCOFEE(Entity OAALIIEEAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2FDDA00", Offset = "0x2FDC800", VA = "0x182FDDA00")]
		private void CBBELDLPJKB(EntityQuery FDHPIJHNIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2FDDAD0", Offset = "0x2FDC8D0", VA = "0x182FDDAD0")]
		private void CBBELDLPJKB(NativeArray<Entity> GOCPDFPAIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2FDDEE0", Offset = "0x2FDCCE0", VA = "0x182FDDEE0")]
		private void DBBDCDPLOMJ(Entity OAALIIEEAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2FDDDB0", Offset = "0x2FDCBB0", VA = "0x182FDDDB0")]
		private void CJHEFIGALIL(Entity OAALIIEEAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF2D0", Offset = "0x2FDE0D0", VA = "0x182FDF2D0")]
		private void OPKPKNPKMKH(SceneTag NAFHJBELBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2FDE350", Offset = "0x2FDD150", VA = "0x182FDE350")]
		private void FLGNMELNOGO(SceneTag NAFHJBELBLG, global::DIKACGHNDIB<int> DKGNKBEEKDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x2FDF050", Offset = "0x2FDDE50", VA = "0x182FDF050")]
		private void MHPEHLDEAKP(SceneTag NAFHJBELBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEB50", Offset = "0x2FDD950", VA = "0x182FDEB50")]
		private void IMFKBJMHAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x30CD6B0", Offset = "0x30CC4B0", VA = "0x1830CD6B0")]
		private void IOKJCKEPGNH<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void NCMBFGAHOFI(SceneTag NAFHJBELBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEF70", Offset = "0x2FDDD70", VA = "0x182FDEF70")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void LHNNPPKEEGI(EntityQuery NOJJNNFMBAH, string ICIEGOLHGJN, SceneTag NAFHJBELBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEBF0", Offset = "0x2FDD9F0", VA = "0x182FDEBF0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void IOPJFPMNKAB(Entity OAALIIEEAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void JCKGIGOBGNC(Entity OAALIIEEAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[JAPKICPMJLM(DIMCOFJGPGL.PhotonRoom)]
	[GDFKOGKEDCG(typeof(HDPLFGHLJGK), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.HierarchySystems)]
	internal class UnitySceneService : JPLAKHLHFLM, HDPLFGHLJGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[DNEBGGIIGBA]
		private SceneService GOCPDFPAIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private readonly Dictionary<int, Entity> JLDEKIGJPHN;

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager CCEKCIJDDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x2FEDB30", Offset = "0x2FEC930", VA = "0x182FEDB30")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x2FED740", Offset = "0x2FEC540", VA = "0x182FED740", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2FED7D0", Offset = "0x2FEC5D0", VA = "0x182FED7D0", Slot = "5")]
		public void GHAPFEIDJMC(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x2FED940", Offset = "0x2FEC740", VA = "0x182FED940", Slot = "6")]
		public bool GNKABFJGNNH(CGKCPDMKDFM HPLAKDFIDCJ, Transform KGHIPKNMKHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2FEDB80", Offset = "0x2FEC980", VA = "0x182FEDB80")]
		private bool KPDBLFOHECM(Scene OAALIIEEAME, out Entity JHOLMANFKIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2FEDBF0", Offset = "0x2FEC9F0", VA = "0x182FEDBF0")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[DKGMECGHCPI(OJBFOICGDOF.ComponentSystemTypes)]
	[GDFKOGKEDCG(typeof(SingletonComponentService), new string[] { })]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	internal sealed class SingletonComponentService : JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[DNEBGGIIGBA]
		private PPBAOAMBNHH FJJEAMJCBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private Entity NEAKDKENHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private ComponentTypeList NACFHNCPJCH;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int JKIABPBFIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0x2FE4380", Offset = "0x2FE3180", VA = "0x182FE4380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity JJNHNHIMFGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager CCEKCIJDDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x2FE4290", Offset = "0x2FE3090", VA = "0x182FE4290")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x30CEE40", Offset = "0x30CDC40", VA = "0x1830CEE40")]
		public T BANNGLOAJDI<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x30CEF00", Offset = "0x30CDD00", VA = "0x1830CEF00")]
		public void KKNDJJJFEOO<T>(T MGFMONLLLPD) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3D80", Offset = "0x2FE2B80", VA = "0x182FE3D80", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3DF0", Offset = "0x2FE2BF0", VA = "0x182FE3DF0", Slot = "5")]
		public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3DF0", Offset = "0x2FE2BF0", VA = "0x182FE3DF0")]
		private void NPLKLCPDCIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3AB0", Offset = "0x2FE28B0", VA = "0x182FE3AB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3F90", Offset = "0x2FE2D90", VA = "0x182FE3F90")]
		private ComponentTypeList GLIKOJKNFNL()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		private static void NABJKMPCPMM(int MNBBKKLFBKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		private static void BMGGALGIIIC(Type LEDIIMFEFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x2FE42E0", Offset = "0x2FE30E0", VA = "0x182FE42E0")]
		private static void LGCHELPACCD(Type LEDIIMFEFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal struct JJFHEPDBCHP : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
[GDFKOGKEDCG(typeof(CDEJGDBDLCH), new string[] { })]
internal sealed class CDEJGDBDLCH : JPLAKHLHFLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	[DNEBGGIIGBA]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private global::MKJONDBJAIE<KPNEELIOKGG, Entity> FAKMLADKKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private global::NAJLOMAKLJC<CHIOPFPMONO> CCMLEKLPCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private global::NAJLOMAKLJC<GCAFPBOIJAC> EKAPKIOCIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private global::NAJLOMAKLJC<DHOOMDIBOGH> GFAIMEMPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private global::NAJLOMAKLJC<PFDCLPGLBHK> ANHIACAPOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private global::NAJLOMAKLJC<AIJLHKGIGJG> DPEPLNEHLIL;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public global::MGNADEHMBPL<Entity> NNHOGEPNECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public PNKPBLCDKGP GFLNOMHGCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public PNKPBLCDKGP DJEADDCBIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public PNKPBLCDKGP NNNEJHPDAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public PNKPBLCDKGP HHKICGEKHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public PNKPBLCDKGP GLDINHGDLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x748BB0", Offset = "0x7479B0", VA = "0x180748BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager CCEKCIJDDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2EBA670", Offset = "0x2EB9470", VA = "0x182EBA670")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA560", Offset = "0x2EB9360", VA = "0x182EBA560", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x2EBA470", Offset = "0x2EB9270", VA = "0x182EBA470", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x26080B0", Offset = "0x2606EB0", VA = "0x1826080B0")]
	private void OLEPBNNLDDG<T>(ref global::NAJLOMAKLJC<T> AKILODLIDKE) where T : struct, GIILAPEPKKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x26080B0", Offset = "0x2606EB0", VA = "0x1826080B0")]
	private void OLEPBNNLDDG<TC, TV>(ref global::MKJONDBJAIE<TC, TV> AKILODLIDKE) where TC : struct, GIILAPEPKKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public CDEJGDBDLCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[GDFKOGKEDCG(typeof(GKPFAHJAGDC), new string[] { })]
[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
internal sealed class GKPFAHJAGDC : MDEPDIFNFKG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private PGIDFFDFCKO BDOLEJMAJLL;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public PGIDFFDFCKO IEFLLHMLAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x1F98610", Offset = "0x1F97410", VA = "0x181F98610")]
		get
		{
			return default(PGIDFFDFCKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x32A2D10", Offset = "0x32A1B10", VA = "0x1832A2D10", Slot = "4")]
	public void NIACEKGLEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x32A2D00", Offset = "0x32A1B00", VA = "0x1832A2D00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public GKPFAHJAGDC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[GDFKOGKEDCG(typeof(TransformOwnershipPhase), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public enum DBBNGMBKIGH
		{
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public struct LGNBCGBKGOK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private DBBNGMBKIGH IHNFBBECINL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private readonly TransformOwnershipPhase GANAMHNGMGO;

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x44A9260", Offset = "0x44A8060", VA = "0x1844A9260")]
			public LGNBCGBKGOK(TransformOwnershipPhase GANAMHNGMGO, DBBNGMBKIGH IGKPCADJEGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x44A9240", Offset = "0x44A8040", VA = "0x1844A9240", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public DBBNGMBKIGH IGKPCADJEGG;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public DBBNGMBKIGH OPFAKOBHLAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040")]
			get
			{
				return default(DBBNGMBKIGH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x7620C0", Offset = "0x760EC0", VA = "0x1807620C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool MIBIKOPIGCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xBFC1E0", Offset = "0xBFAFE0", VA = "0x180BFC1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool DHDABFOGHBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x1025F00", Offset = "0x1024D00", VA = "0x181025F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7650", Offset = "0x2FE6450", VA = "0x182FE7650")]
		public LGNBCGBKGOK CDEHPGNABOL()
		{
			return default(LGNBCGBKGOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x2FE7680", Offset = "0x2FE6480", VA = "0x182FE7680")]
		public LGNBCGBKGOK EIPKHHNAEOF()
		{
			return default(LGNBCGBKGOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[GDFKOGKEDCG(typeof(AEFBGNMHCNF), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.Circuits)]
	public class CircuitsService : JPLAKHLHFLM, AEFBGNMHCNF
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		[DNEBGGIIGBA]
		private KMIPELKBEOL BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityManager PAHBLOLNPLD;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE1C0", Offset = "0x2EBCFC0", VA = "0x182EBE1C0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE4B0", Offset = "0x2EBD2B0", VA = "0x182EBE4B0", Slot = "5")]
		public bool GALHPGHCHAO(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE0D0", Offset = "0x2EBCED0", VA = "0x182EBE0D0", Slot = "7")]
		public bool CHGDICIHOHK(CGKCPDMKDFM HPLAKDFIDCJ, out Guid NGCHMGLJNOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE610", Offset = "0x2EBD410", VA = "0x182EBE610", Slot = "8")]
		public Guid IEDFNAKPHBC(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDE70", Offset = "0x2EBCC70", VA = "0x182EBDE70", Slot = "9")]
		public void BMFCHBKIDCH(CGKCPDMKDFM HPLAKDFIDCJ, Guid NGCHMGLJNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEAD0", Offset = "0x2EBD8D0", VA = "0x182EBEAD0", Slot = "10")]
		public bool OMHFJOKDGHO(CGKCPDMKDFM HPLAKDFIDCJ, out Guid KOHDEAFCAKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEBC0", Offset = "0x2EBD9C0", VA = "0x182EBEBC0", Slot = "11")]
		public Guid PENGDLFNBDA(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE870", Offset = "0x2EBD670", VA = "0x182EBE870", Slot = "12")]
		public void JJJEONNOPFJ(CGKCPDMKDFM HPLAKDFIDCJ, Guid KOHDEAFCAKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE3F0", Offset = "0x2EBD1F0", VA = "0x182EBE3F0", Slot = "13")]
		public bool FAOMPDOIPII(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE440", Offset = "0x2EBD240", VA = "0x182EBE440", Slot = "14")]
		public void FMIJGCMCPHO(CGKCPDMKDFM HPLAKDFIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2EBECD0", Offset = "0x2EBDAD0", VA = "0x182EBECD0", Slot = "15")]
		public void PIGHOPJGLPL(CGKCPDMKDFM ONDHOAIGIEB, CGKCPDMKDFM GANAMHNGMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDC50", Offset = "0x2EBCA50", VA = "0x182EBDC50")]
		private void AJGMKONJFGM(BJLMGLFGEEK DCODIDJDLFA, CGKCPDMKDFM GANAMHNGMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE260", Offset = "0x2EBD060", VA = "0x182EBE260")]
		private void ENHFBOEBIIM(BJLMGLFGEEK DCODIDJDLFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE720", Offset = "0x2EBD520", VA = "0x182EBE720")]
		private bool JEFEGCAFFCJ(EGBCNCKGEND OJGAEOFIMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDDC0", Offset = "0x2EBCBC0", VA = "0x182EBDDC0")]
		private bool BBEPFPEKPLJ(EGBCNCKGEND OJGAEOFIMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE5B0", Offset = "0x2EBD3B0", VA = "0x182EBE5B0", Slot = "6")]
		public bool GJKMFMHNFIG(CGKCPDMKDFM BMINGOEPCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[GDFKOGKEDCG(typeof(AAKKHKDJDBI), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.Connectables)]
	internal class ConnectableService : AAKKHKDJDBI, JPLAKHLHFLM, NEGCPFIDGDD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class KDNCEPHFCNI : IEnumerable<CGKCPDMKDFM>, IEnumerable, IEnumerator<CGKCPDMKDFM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private CGKCPDMKDFM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			private CGKCPDMKDFM localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public CGKCPDMKDFM <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			private CGKCPDMKDFM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0x7621D0", Offset = "0x760FD0", VA = "0x1807621D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(CGKCPDMKDFM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x2FDB220", Offset = "0x2FDA020", VA = "0x182FDB220", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x9D05F0", Offset = "0x9CF3F0", VA = "0x1809D05F0")]
			[DebuggerHidden]
			public KDNCEPHFCNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x2FDB270", Offset = "0x2FDA070", VA = "0x182FDB270", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x2FDAE30", Offset = "0x2FD9C30", VA = "0x182FDAE30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x2FDB340", Offset = "0x2FDA140", VA = "0x182FDB340")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x2FDB390", Offset = "0x2FDA190", VA = "0x182FDB390")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x2FDB1E0", Offset = "0x2FD9FE0", VA = "0x182FDB1E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x2FDB130", Offset = "0x2FD9F30", VA = "0x182FDB130", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CGKCPDMKDFM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x2FDB130", Offset = "0x2FD9F30", VA = "0x182FDB130", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly FGEMECIGOCC NJABPNODPLH;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public const int IKAAOEOAAEM = 0;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public const int GBLJEFLHIIC = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private EOKNELNBMBB LPMGOCJAKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private AEJNGPFNACL BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private LCLOCHGKNKG BGEMPOFCNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PropertyEventCallbacksService PHKLPEIEANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private global::POPOOFGODGI<Entity> CBEPBDFAAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private global::POPOOFGODGI<float3> KKJOLNKMFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private global::POPOOFGODGI<quaternion> PAOPDILGNDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private global::POPOOFGODGI<Entity> GANAMHNGMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private global::POPOOFGODGI<float3> LNLPNIDIPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private global::POPOOFGODGI<quaternion> BBEANHLOOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HashSet<Entity> CPDGPPJNHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private HashSet<Entity> EKODFGKKIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private EntityQuery EOLMEKHBIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private bool LINNMJPFKHN;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public Func<IPOFABECGDG> LGAJMKMEGOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x7578E0", Offset = "0x7566E0", VA = "0x1807578E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x8751C0", Offset = "0x873FC0", VA = "0x1808751C0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<CGKCPDMKDFM, CGKCPDMKDFM> EKKANDJFNAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x2EC4320", Offset = "0x2EC3120", VA = "0x182EC4320", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x2EC3170", Offset = "0x2EC1F70", VA = "0x182EC3170", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<CGKCPDMKDFM, CGKCPDMKDFM> FKMDIAFIDMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2F20", Offset = "0x2EC1D20", VA = "0x182EC2F20", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x2EC4450", Offset = "0x2EC3250", VA = "0x182EC4450", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<CGKCPDMKDFM, CGKCPDMKDFM, CGKCPDMKDFM> APBDFBPFMHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2E80", Offset = "0x2EC1C80", VA = "0x182EC2E80", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x2EC3210", Offset = "0x2EC2010", VA = "0x182EC3210", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<CGKCPDMKDFM> GKNNODLJDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x2EC4670", Offset = "0x2EC3470", VA = "0x182EC4670", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2DE0", Offset = "0x2EC1BE0", VA = "0x182EC2DE0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3680", Offset = "0x2EC2480", VA = "0x182EC3680", Slot = "25")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3E80", Offset = "0x2EC2C80", VA = "0x182EC3E80", Slot = "26")]
		public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x2EC34D0", Offset = "0x2EC22D0", VA = "0x182EC34D0", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x2EC47B0", Offset = "0x2EC35B0", VA = "0x182EC47B0")]
		private void MCPHNPFGBOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x2EC32B0", Offset = "0x2EC20B0", VA = "0x182EC32B0")]
		private void DBIGOHNEECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3800", Offset = "0x2EC2600", VA = "0x182EC3800")]
		private void EHICOPGMCPM(Entity NEAKDKENHHP, DFNAMHCDDIN HEDGDEEAPPO, BDKOOLPOOEA DNEMONMIDEC, BDKOOLPOOEA NCBOBCDAKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x2EC39C0", Offset = "0x2EC27C0", VA = "0x182EC39C0")]
		private void FDJNJGEIDHB(Entity NEAKDKENHHP, DFNAMHCDDIN HEDGDEEAPPO, BDKOOLPOOEA DNEMONMIDEC, BDKOOLPOOEA NCBOBCDAKLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A590", Offset = "0x1D09390", VA = "0x181D0A590", Slot = "14")]
		public CGKCPDMKDFM PFPBBKMINBM(CGKCPDMKDFM HPLAKDFIDCJ, int CKDHPFHDBDK)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x14F93E0", Offset = "0x14F81E0", VA = "0x1814F93E0", Slot = "15")]
		public Color IMEHHKFIFAC(CGKCPDMKDFM HPLAKDFIDCJ, int CKDHPFHDBDK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3CA0", Offset = "0x2EC2AA0", VA = "0x182EC3CA0", Slot = "16")]
		public float3 FLFFACEIDJL(CGKCPDMKDFM HPLAKDFIDCJ, int CKDHPFHDBDK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2EC30C0", Offset = "0x2EC1EC0", VA = "0x182EC30C0", Slot = "17")]
		public bool CGACKHHLPDI(CGKCPDMKDFM HPLAKDFIDCJ, CGKCPDMKDFM JKPPANPCFJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3420", Offset = "0x2EC2220", VA = "0x182EC3420", Slot = "18")]
		public CGKCPDMKDFM DOBEPLDFNGJ(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2C90", Offset = "0x2EC1A90", VA = "0x182EC2C90", Slot = "21")]
		public void ACCMFHOFBIK(CGKCPDMKDFM HPLAKDFIDCJ, Vector3 CCAPENLIPFM, Quaternion EKEODPHAOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4710", Offset = "0x2EC3510", VA = "0x182EC4710", Slot = "23")]
		public float3 LJLILNDEHOB(PFHOKKBIOKO CPALDKAGDCL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC49E0", Offset = "0x2EC37E0", VA = "0x182EC49E0", Slot = "24")]
		public quaternion PPJLBDBIOOL(PFHOKKBIOKO CPALDKAGDCL)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2FC0", Offset = "0x2EC1DC0", VA = "0x182EC2FC0", Slot = "28")]
		public RigidTransform BKPLJLFCBPM(PFHOKKBIOKO CPALDKAGDCL)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2EC44F0", Offset = "0x2EC32F0", VA = "0x182EC44F0", Slot = "22")]
		public bool JIKHEMFEKKH(CGKCPDMKDFM HPLAKDFIDCJ, out RigidTransform MMFAJCHOLEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2EC43C0", Offset = "0x2EC31C0", VA = "0x182EC43C0", Slot = "19")]
		[IteratorStateMachine(typeof(KDNCEPHFCNI))]
		public IEnumerable<CGKCPDMKDFM> IJLAMAEEEJI(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3B40", Offset = "0x2EC2940", VA = "0x182EC3B40", Slot = "20")]
		public CGKCPDMKDFM FFPIFLNLHGA(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4810", Offset = "0x2EC3610", VA = "0x182EC4810", Slot = "29")]
		public void PHHFLPECKEO(ref List<CGKCPDMKDFM> ENPKPDCDBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3A20", Offset = "0x2EC2820", VA = "0x182EC3A20")]
		private Entity FFPIFLNLHGA(Entity NEAKDKENHHP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4B00", Offset = "0x2EC3900", VA = "0x182EC4B00")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[DKGMECGHCPI(OJBFOICGDOF.Prefabs)]
	[GDFKOGKEDCG(typeof(ObjectInstantiationService), new string[] { })]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	internal sealed class ObjectInstantiationService : JPLAKHLHFLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL BFCIPJDFKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[DNEBGGIIGBA]
		private EPJKDONCCEC KKBFGBBEIPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[DNEBGGIIGBA]
		private IHOEJJJOAOC FLLJEJDMPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[DNEBGGIIGBA]
		private ObjectNetworkToLocalMapService JJPJMEBEPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[DNEBGGIIGBA]
		private ObjectLifecycleService LHNDLBANJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[DNEBGGIIGBA]
		private ObjectPrefabs FHLJIJCKGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[DNEBGGIIGBA]
		private FNIFMGLPHAO ANGLELIFCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private KDBCABAKEFA CMDDNCNFEMB;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public int LKLJHPADNNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0x2D23DE0", Offset = "0x2D22BE0", VA = "0x182D23DE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x2D23BA0", Offset = "0x2D229A0", VA = "0x182D23BA0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2D23DC0", Offset = "0x2D22BC0", VA = "0x182D23DC0")]
		public Entity HCEEHEJIEII(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x2D23A20", Offset = "0x2D22820", VA = "0x182D23A20")]
		public Entity CPHCLKAHMMB(MFDODOEBKCJ FIIEHBGLOHB, IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2D23940", Offset = "0x2D22740", VA = "0x182D23940")]
		public Entity LIGKIHLEECP(IAFDFFOCDLF KCFAHJGLHLA, bool CKJCCLALEPN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2D23990", Offset = "0x2D22790", VA = "0x182D23990")]
		public Entity LIGKIHLEECP(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2D23CD0", Offset = "0x2D22AD0", VA = "0x182D23CD0")]
		public Entity FDCBEKHEEPO()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2D23A80", Offset = "0x2D22880", VA = "0x182D23A80")]
		public Entity DHPLHAEKNON(ENALNDEOHNF LEDIIMFEFLP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2D23B10", Offset = "0x2D22910", VA = "0x182D23B10")]
		public Entity DLIABOGEIKL(LBMBGCOHJHK LEDIIMFEFLP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2D23D70", Offset = "0x2D22B70", VA = "0x182D23D70")]
		public NativeArray<(CGKCPDMKDFM, CGKCPDMKDFM)> GLCFKEABDII(NativeArray<CGKCPDMKDFM> OBDCOIDPANM, Allocator MBJMPHBLMBF)
		{
			return default(NativeArray<(CGKCPDMKDFM, CGKCPDMKDFM)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2D239D0", Offset = "0x2D227D0", VA = "0x182D239D0")]
		public IEnumerable<IAFDFFOCDLF> CBAIBOKMHOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2D23D10", Offset = "0x2D22B10", VA = "0x182D23D10")]
		public EntityArchetype FMGJABCMJIP(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2D23E30", Offset = "0x2D22C30", VA = "0x182D23E30")]
		public Entity MLDEKCBFDJD(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x2D23990", Offset = "0x2D22790", VA = "0x182D23990")]
		private Entity ALOCIDMDFKD(IAFDFFOCDLF KCFAHJGLHLA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2D23940", Offset = "0x2D22740", VA = "0x182D23940")]
		private Entity ALOCIDMDFKD(IAFDFFOCDLF KCFAHJGLHLA, bool CKJCCLALEPN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2D23820", Offset = "0x2D22620", VA = "0x182D23820")]
		private Entity ALOCIDMDFKD(IAFDFFOCDLF KCFAHJGLHLA, MFDODOEBKCJ FIIEHBGLOHB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[GDFKOGKEDCG(typeof(EOEMDGEDOLM), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.Physics)]
	public sealed class PhysicsSceneColliderService : EOEMDGEDOLM, HCCDBOIGFKL, MDEPDIFNFKG, JPLAKHLHFLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private const string HJCANCPEJAN = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private const int LFLKPPJEPBM = -1;

		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private const int ACICDEMKAOE = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[DNEBGGIIGBA]
		private LNDAGNKEEKN NOAFOBDAJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Collider[] MMMFHJJPFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private RaycastHit[] BDICKFIBEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private global::JEFOHNHCKHC<OANHODMBAGD, BoxCollider> PDNKMCMONEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private Scene OAALIIEEAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PhysicsScene FNBGAOHLJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GameObject PEINAPABAGG;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public int PALIANCCJNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x2D2EC70", Offset = "0x2D2DA70", VA = "0x182D2EC70", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FA10", Offset = "0x2D2E810", VA = "0x182D2FA10", Slot = "9")]
		public void NIACEKGLEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x2D2EF10", Offset = "0x2D2DD10", VA = "0x182D2EF10", Slot = "10")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x2D2EE10", Offset = "0x2D2DC10", VA = "0x182D2EE10", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x2D2ECB0", Offset = "0x2D2DAB0", VA = "0x182D2ECB0", Slot = "4")]
		public OANHODMBAGD CHALOAKMFEE(Entity NEAKDKENHHP)
		{
			return default(OANHODMBAGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FBE0", Offset = "0x2D2E9E0", VA = "0x182D2FBE0", Slot = "5")]
		public void PONGCEJENAA(NativeArray<OANHODMBAGD> JDFFPELNHAE, NativeArray<HOMIJDPJNNL> HGOGEJKCLKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F940", Offset = "0x2D2E740", VA = "0x182D2F940", Slot = "6")]
		public void KOJFHGJPGHE(OANHODMBAGD EAHLOGLBEGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F050", Offset = "0x2D2DE50", VA = "0x182D2F050", Slot = "7")]
		public bool FACABBCAOCG(OANHODMBAGD EAHLOGLBEGD, out Collider GAGPONOIJAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F2D0", Offset = "0x2D2E0D0", VA = "0x182D2F2D0")]
		public bool KHEMAAGDLHA(in float3 OBMFGFCEDPK, in float3 DJIMPKHJJFP, float JOJDHMIFOPA, Allocator MBJMPHBLMBF, out NativeArray<Entity> KMDDIGFEEEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FB80", Offset = "0x2D2E980", VA = "0x182D2FB80")]
		private void OLOFJMEBGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xC9CAF0", Offset = "0xC9B8F0", VA = "0x180C9CAF0")]
		private void FACKFGOBCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F0F0", Offset = "0x2D2DEF0", VA = "0x182D2F0F0")]
		private void FOFNMCPDPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x9CC7F0", Offset = "0x9CB5F0", VA = "0x1809CC7F0")]
		private void CIGABFMOHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F1B0", Offset = "0x2D2DFB0", VA = "0x182D2F1B0")]
		private BoxCollider IHNKNBBMFIJ(Entity NEAKDKENHHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2D2EFD0", Offset = "0x2D2DDD0", VA = "0x182D2EFD0")]
		private void EIEFIJGCFNM(BoxCollider AEKAAGJCNCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F140", Offset = "0x2D2DF40", VA = "0x182D2F140")]
		[Conditional("UNITY_EDITOR")]
		private void GHBFHBDDKNN(GameObject HNLFAAIOFFP, Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x2D2EA80", Offset = "0x2D2D880", VA = "0x182D2EA80")]
		private void AEDPBMCEEJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F620", Offset = "0x2D2E420", VA = "0x182D2F620")]
		private void KLNHBPEHBPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F730", Offset = "0x2D2E530", VA = "0x182D2F730")]
		private void KNCNAHBNFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F180", Offset = "0x2D2DF80", VA = "0x182D2F180")]
		private void GNFNNOEMNPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x2D2EE00", Offset = "0x2D2DC00", VA = "0x182D2EE00")]
		private void CIAHKDBJBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2D2F5E0", Offset = "0x2D2E3E0", VA = "0x182D2F5E0")]
		private void KLACPNCLMOL(Scene OLDNOOGEEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FBD0", Offset = "0x2D2E9D0", VA = "0x182D2FBD0", Slot = "8")]
		private bool PMHPJKGPJAI(in float3 OBMFGFCEDPK, in float3 DJIMPKHJJFP, float JOJDHMIFOPA, Allocator MBJMPHBLMBF, out NativeArray<Entity> KMDDIGFEEEI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[GDFKOGKEDCG(typeof(IKOGKFOOIAD), new string[] { })]
public sealed class CMPMBBIPPBI : IKOGKFOOIAD, JPLAKHLHFLM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	private struct LHMNCHMDAMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public float EKLPJLEIPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public uint IDNEIOJCCMO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private HCCDBOIGFKL HIFBLAKHMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private DBLELPAFJKM PIGPAAOBFCE;

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC9D0", Offset = "0x2EBB7D0", VA = "0x182EBC9D0", Slot = "5")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x2EBCA40", Offset = "0x2EBB840", VA = "0x182EBCA40")]
	public bool KHEMAAGDLHA(in float3 OBMFGFCEDPK, in float3 DJIMPKHJJFP, float JOJDHMIFOPA, out HGKKCBJAMCJ BGNDJBOJFIN, out Entity BMOCHBGHPNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC8D0", Offset = "0x2EBB6D0", VA = "0x182EBC8D0")]
	public static bool DDDBFPEGKEE(in Span<HGKKCBJAMCJ> KPMPNJBGCHJ, float JOJDHMIFOPA, out int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x2EBCEC0", Offset = "0x2EBBCC0", VA = "0x182EBCEC0")]
	public static float LPJLGFGDCPB(float EKLPJLEIPME)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public CMPMBBIPPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC8C0", Offset = "0x2EBB6C0", VA = "0x182EBC8C0", Slot = "4")]
	private bool AKIJBOHOELP(in float3 OBMFGFCEDPK, in float3 DJIMPKHJJFP, float JOJDHMIFOPA, out HGKKCBJAMCJ BGNDJBOJFIN, out Entity BMOCHBGHPNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[GDFKOGKEDCG(typeof(DBLELPAFJKM), new string[] { })]
public sealed class LMAIPCBHBFB : DBLELPAFJKM, JPLAKHLHFLM
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[BurstCompile]
	private struct CEJFOGIOONG : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<Entity> KMDDIGFEEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[ReadOnly]
		public float3 HPONOEPKEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[ReadOnly]
		public float3 AAKPKLAEJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> AOGGJHFEDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> GBNGOJNJEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> DGPECAOBBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> NNNEOKOGPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> MAHKMDCFCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[WriteOnly]
		public NativeArray<HGKKCBJAMCJ> JKMNIBOONCB;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private static readonly HGKKCBJAMCJ EFOHOCHMBIK;

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x44A2420", Offset = "0x44A1220", VA = "0x1844A2420", Slot = "4")]
		public void Execute(int NNHNOIMLALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x44A2350", Offset = "0x44A1150", VA = "0x1844A2350")]
		private static float3 EIHGOOFPNEC(in float4x4 MIFHCKPPNKL, in float3 NDFOGNBCBPD)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x44A2190", Offset = "0x44A0F90", VA = "0x1844A2190")]
		private static float3 EBLHGALLGMG(in float4x4 MIFHCKPPNKL, in float3 EIBINODMDGE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x44A2700", Offset = "0x44A1500", VA = "0x1844A2700")]
		private static float3 GGIMCHLMJMO(in float4x4 MIFHCKPPNKL, in float3 NDFOGNBCBPD)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x44A1F70", Offset = "0x44A0D70", VA = "0x1844A1F70")]
		private static float3 APNGLLPPIDP(in float4x4 MIFHCKPPNKL, in float3 EIBINODMDGE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x44A2800", Offset = "0x44A1600", VA = "0x1844A2800")]
		private bool IMLKLAJCLEO(in float3 OBMFGFCEDPK, in float3 DJIMPKHJJFP, in NativeArray<Entity> CKDHMFKJAMK, out float3 BGNDJBOJFIN, out float3 DLBJKHMIPFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x44A2B50", Offset = "0x44A1950", VA = "0x1844A2B50")]
		public static bool MAJJJFEBKJP(in float3 IFBOFKIDHBL, in float3 JANLCKICDAF, in float3 FBOMMFFIHIP, in float3 NKLBACNHPAG, float AHMOPMELELC, float DIKFONLHEFA, out float DJCNOMGFLPK, out float3 BFJFBGNMECP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager PAHBLOLNPLD;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x32B7420", Offset = "0x32B6220", VA = "0x1832B7420", Slot = "5")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x32B74A0", Offset = "0x32B62A0", VA = "0x1832B74A0")]
	public void KHEMAAGDLHA(in NativeArray<Entity> KMDDIGFEEEI, in float3 OBMFGFCEDPK, in float3 DJIMPKHJJFP, in NativeArray<HGKKCBJAMCJ> CDGIOOBNHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public LMAIPCBHBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x32B7410", Offset = "0x32B6210", VA = "0x1832B7410", Slot = "4")]
	private void DFNFEFONHHB(in NativeArray<Entity> KMDDIGFEEEI, in float3 OBMFGFCEDPK, in float3 DJIMPKHJJFP, in NativeArray<HGKKCBJAMCJ> CDGIOOBNHJL)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[DKGMECGHCPI(OJBFOICGDOF.Embodiment)]
	[JAPKICPMJLM(DIMCOFJGPGL.OMRoom)]
	[GDFKOGKEDCG(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : JPLAKHLHFLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[DNEBGGIIGBA]
		private AEJNGPFNACL EOHGMNFKFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[DNEBGGIIGBA]
		private EPJKDONCCEC GNOCPPKHAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[DNEBGGIIGBA]
		private IHOEJJJOAOC PKDJLFEANKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private JCAPLMJKCDN MKBBGINEDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NativeHashMap<MFDODOEBKCJ, Entity> IKEBGKLKBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private EntityManager PAHBLOLNPLD;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal NativeHashMap<MFDODOEBKCJ, Entity> EDJEHDEOPKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0xEFFCD0", Offset = "0xEFEAD0", VA = "0x180EFFCD0")]
			get
			{
				return default(NativeHashMap<MFDODOEBKCJ, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint CICOPBECGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x2D26ED0", Offset = "0x2D25CD0", VA = "0x182D26ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool EFIIIACBDGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x942E70", Offset = "0x941C70", VA = "0x180942E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0xD9C7F0", Offset = "0xD9B5F0", VA = "0x180D9C7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x2D26DB0", Offset = "0x2D25BB0", VA = "0x182D26DB0", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x2D26D40", Offset = "0x2D25B40", VA = "0x182D26D40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x2D273F0", Offset = "0x2D261F0", VA = "0x182D273F0")]
		public void ODCBHOABBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x2D270C0", Offset = "0x2D25EC0", VA = "0x182D270C0")]
		public void KOGDOOHPOCL(MFDODOEBKCJ FIIEHBGLOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x2D273C0", Offset = "0x2D261C0", VA = "0x182D273C0")]
		private CGKCPDMKDFM MAJLOGOOOGO(Entity NEAKDKENHHP)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2D27280", Offset = "0x2D26080", VA = "0x182D27280")]
		public CGKCPDMKDFM LCEDMMGGMOH(MFDODOEBKCJ FIIEHBGLOHB)
		{
			return default(CGKCPDMKDFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2D26CB0", Offset = "0x2D25AB0", VA = "0x182D26CB0")]
		public MFDODOEBKCJ DOPAKLHPIEI(CGKCPDMKDFM HPLAKDFIDCJ)
		{
			return default(MFDODOEBKCJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x2D26F60", Offset = "0x2D25D60", VA = "0x182D26F60")]
		public void JMABAPEANAD(Entity NEAKDKENHHP, MFDODOEBKCJ FIIEHBGLOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x2D26F00", Offset = "0x2D25D00", VA = "0x182D26F00")]
		public void JLLJBCAGIAI(Entity NEAKDKENHHP, MFDODOEBKCJ FIIEHBGLOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x2D27360", Offset = "0x2D26160", VA = "0x182D27360")]
		public void LJHNOKFBAGD(Entity NEAKDKENHHP, MFDODOEBKCJ FIIEHBGLOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x2D26FF0", Offset = "0x2D25DF0", VA = "0x182D26FF0")]
		public void KLBBHDMNKDO(Entity NEAKDKENHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
	[GDFKOGKEDCG(typeof(PropertyEventCallbacksService), new string[] { })]
	[DKGMECGHCPI(OJBFOICGDOF.Callbacks)]
	public class PropertyEventCallbacksService : JPLAKHLHFLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		private struct MJJMOHOBEHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public MBNMMGJMEEE FNIOCOFMFAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public Type LEDIIMFEFLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public int MKGODNJCKOC;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		private struct GGGMGCPAEKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public MJJMOHOBEHH[] PGPGHEAKODE;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		public delegate void MBNMMGJMEEE(Entity NEAKDKENHHP, DFNAMHCDDIN HEDGDEEAPPO, BDKOOLPOOEA DNEMONMIDEC, BDKOOLPOOEA NCBOBCDAKLG);

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private static readonly FGEMECIGOCC EKOKIILLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly Dictionary<DFNAMHCDDIN, MBNMMGJMEEE> NBMFEGIPHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private readonly Dictionary<int, GGGMGCPAEKI> CCGJJCEKLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private HJJNHNANFFG PGPGHEAKODE;

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action BMDCPOMIGDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x2D36680", Offset = "0x2D35480", VA = "0x182D36680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x2D36140", Offset = "0x2D34F40", VA = "0x182D36140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action EDNNCCAMANJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x2D36350", Offset = "0x2D35150", VA = "0x182D36350")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x2D36720", Offset = "0x2D35520", VA = "0x182D36720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2D36000", Offset = "0x2D34E00", VA = "0x182D36000", Slot = "4")]
		public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x2D35F70", Offset = "0x2D34D70", VA = "0x182D35F70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x2D361E0", Offset = "0x2D34FE0", VA = "0x182D361E0")]
		public void GLJEDJEGGBC(DFNAMHCDDIN HEDGDEEAPPO, MBNMMGJMEEE FNIOCOFMFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2D36050", Offset = "0x2D34E50", VA = "0x182D36050")]
		public void FGGPPOHECMI(DFNAMHCDDIN HEDGDEEAPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x2D363F0", Offset = "0x2D351F0", VA = "0x182D363F0")]
		internal void KIMEONBLALA(EIHJALEFJJC GMDALJMBJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x2D35A30", Offset = "0x2D34830", VA = "0x182D35A30")]
		private void CAAKJGPDDKH(EIHJALEFJJC GMDALJMBJKE, int JMJHPMGKKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2D357B0", Offset = "0x2D345B0", VA = "0x182D357B0")]
		private void BLOJEKJHJKP(ANKHGKIKDDO CKFDCLEBNMD, KBEOGLGHKEJ JIPLJLMKHBM, MJJMOHOBEHH GNGOGCKHHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2D35630", Offset = "0x2D34430", VA = "0x182D35630")]
		private GGGMGCPAEKI BDKLMLAEPDN(ANKHGKIKDDO CKFDCLEBNMD, KBEOGLGHKEJ JIPLJLMKHBM)
		{
			return default(GGGMGCPAEKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2D35540", Offset = "0x2D34340", VA = "0x182D35540")]
		private MJJMOHOBEHH AHCEHPMKEKO(GGGMGCPAEKI NIAAPKAOANJ, ANKHGKIKDDO CKFDCLEBNMD, KBEOGLGHKEJ JIPLJLMKHBM)
		{
			return default(MJJMOHOBEHH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2D36810", Offset = "0x2D35610", VA = "0x182D36810")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[GDFKOGKEDCG(typeof(KOFIEJCNABD), new string[] { })]
public class EKOBNPBICPG : JPLAKHLHFLM, NEGCPFIDGDD, KOFIEJCNABD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	private sealed class MBLDNKGCKJA : IEnumerable<CGKCPDMKDFM>, IEnumerable, IEnumerator<CGKCPDMKDFM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private CGKCPDMKDFM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public EKOBNPBICPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private CGKCPDMKDFM splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public CGKCPDMKDFM <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		private CGKCPDMKDFM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0x7621D0", Offset = "0x760FD0", VA = "0x1807621D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CGKCPDMKDFM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0x2FDB940", Offset = "0x2FDA740", VA = "0x182FDB940", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x9D05F0", Offset = "0x9CF3F0", VA = "0x1809D05F0")]
		[DebuggerHidden]
		public MBLDNKGCKJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB790", Offset = "0x2FDA590", VA = "0x182FDB790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB900", Offset = "0x2FDA700", VA = "0x182FDB900", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB850", Offset = "0x2FDA650", VA = "0x182FDB850", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CGKCPDMKDFM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x2FDB850", Offset = "0x2FDA650", VA = "0x182FDB850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private JCAPLMJKCDN MKBBGINEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private JFHJCDONLLP DLENKLJDNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private ObjectInstantiationService FHLJIJCKGLN;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EntityManager CCEKCIJDDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x2ED2790", Offset = "0x2ED1590", VA = "0x182ED2790")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private DMGDMAGLCAD EDDGIILAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2ED2190", Offset = "0x2ED0F90", VA = "0x182ED2190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2300", Offset = "0x2ED1100", VA = "0x182ED2300", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2590", Offset = "0x2ED1390", VA = "0x182ED2590", Slot = "5")]
	public void FMFPGNCJLHE(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2250", Offset = "0x2ED1050", VA = "0x182ED2250", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2A30", Offset = "0x2ED1830", VA = "0x182ED2A30")]
	private void KFBJKAGFJNN(Entity HDHDNFAJDGH, in BDKOOLPOOEA BFKCKCENCEE, in BDKOOLPOOEA IJHAJFKAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2390", Offset = "0x2ED1190", VA = "0x182ED2390", Slot = "14")]
	public CGKCPDMKDFM FDCBEKHEEPO()
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x2ED20D0", Offset = "0x2ED0ED0", VA = "0x182ED20D0", Slot = "10")]
	public void DOAKIIAGLMF(CGKCPDMKDFM HPLAKDFIDCJ, AMAPINFMEGI DNHNNDBCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2ED27E0", Offset = "0x2ED15E0", VA = "0x182ED27E0", Slot = "9")]
	public AMAPINFMEGI IIGAMPANBHO(CGKCPDMKDFM HPLAKDFIDCJ)
	{
		return default(AMAPINFMEGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2D40", Offset = "0x2ED1B40", VA = "0x182ED2D40", Slot = "11")]
	public CGKCPDMKDFM MOLDKGKDLGC(CGKCPDMKDFM BPCHDAFPJNL, [Optional] Vector3? DNPAJCANFPF, [Optional] Quaternion? NNAIELBMKHJ, [Optional] Vector3? LFJHMANOJGJ)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2750", Offset = "0x2ED1550", VA = "0x182ED2750", Slot = "15")]
	public CGKCPDMKDFM HBJKNLEBKLM(CGKCPDMKDFM HLJEJOMJMMK, int NNHNOIMLALG, [Optional] Vector3? DNPAJCANFPF, [Optional] Quaternion? NNAIELBMKHJ, [Optional] Vector3? LFJHMANOJGJ)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x2ED28A0", Offset = "0x2ED16A0", VA = "0x182ED28A0", Slot = "7")]
	public CGKCPDMKDFM IMJNAGKOOAF(CGKCPDMKDFM HLJEJOMJMMK, int NNHNOIMLALG)
	{
		return default(CGKCPDMKDFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2690", Offset = "0x2ED1490", VA = "0x182ED2690", Slot = "16")]
	public void GMCEALOAPAA(CGKCPDMKDFM HLJEJOMJMMK, CGKCPDMKDFM DDDKKIPMBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x2ED3040", Offset = "0x2ED1E40", VA = "0x182ED3040", Slot = "12")]
	public void OHFEJAEJNPI(CGKCPDMKDFM HLJEJOMJMMK, int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x2ED23F0", Offset = "0x2ED11F0", VA = "0x182ED23F0", Slot = "17")]
	public void FINJBHBOFEL(CGKCPDMKDFM HLJEJOMJMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2990", Offset = "0x2ED1790", VA = "0x182ED2990", Slot = "8")]
	public int JKKDDCBEKAK(CGKCPDMKDFM HLJEJOMJMMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1F80", Offset = "0x2ED0D80", VA = "0x182ED1F80", Slot = "6")]
	[IteratorStateMachine(typeof(MBLDNKGCKJA))]
	public IEnumerable<CGKCPDMKDFM> BCIKPMJHPBL(CGKCPDMKDFM HLJEJOMJMMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2CB0", Offset = "0x2ED1AB0", VA = "0x182ED2CB0")]
	private bool LMMINLMHNHN(CGKCPDMKDFM HLJEJOMJMMK, out NativeArray<Entity> NFHDJMINDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2ED2010", Offset = "0x2ED0E10", VA = "0x182ED2010")]
	private NativeArray<Entity> CNMIHAEPPFB(CGKCPDMKDFM HLJEJOMJMMK)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public EKOBNPBICPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[JAPKICPMJLM(DIMCOFJGPGL.LoadInstance)]
[GDFKOGKEDCG(typeof(OLKFKKGNKNJ), new string[] { })]
internal sealed class OLKFKKGNKNJ : JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private AEJNGPFNACL BFCIPJDFKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformOwnershipPhase MCAIMDMBACN;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private MKGAEINCAIG CADGIMEBGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x2D1DD90", Offset = "0x2D1CB90", VA = "0x182D1DD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DB00", Offset = "0x2D1C900", VA = "0x182D1DB00", Slot = "4")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DA30", Offset = "0x2D1C830", VA = "0x182D1DA30")]
	public void AEFHKKOLOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DB80", Offset = "0x2D1C980", VA = "0x182D1DB80")]
	public void KDBFOPLJECI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public OLKFKKGNKNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct LONCLNDEOLA : IEquatable<LONCLNDEOLA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly int JMJHPMGKKMH;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Type FKLLKDBMLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x2D17590", Offset = "0x2D16390", VA = "0x182D17590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x2D17670", Offset = "0x2D16470", VA = "0x182D17670")]
	public LONCLNDEOLA(Type LEDIIMFEFLP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x2D17530", Offset = "0x2D16330", VA = "0x182D17530")]
	public static LONCLNDEOLA JMLJLLKELMG(Type LEDIIMFEFLP)
	{
		return default(LONCLNDEOLA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x2D174E0", Offset = "0x2D162E0", VA = "0x182D174E0")]
	public static Type JMLJLLKELMG(LONCLNDEOLA EAHLOGLBEGD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x1081290", Offset = "0x1080090", VA = "0x181081290")]
	public static bool EJGLOGBEPOL(LONCLNDEOLA GCKGDDMIIDO, LONCLNDEOLA EJKHFJILHAC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x1081290", Offset = "0x1080090", VA = "0x181081290")]
	public static bool IKFCAHNLBFO(LONCLNDEOLA GCKGDDMIIDO, LONCLNDEOLA EJKHFJILHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x8E9610", Offset = "0x8E8410", VA = "0x1808E9610", Slot = "4")]
	public bool Equals(LONCLNDEOLA IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x2D17460", Offset = "0x2D16260", VA = "0x182D17460", Slot = "0")]
	public override bool Equals(object OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x2D175F0", Offset = "0x2D163F0", VA = "0x182D175F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public static class DCFIELFDAKM
{
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static Dictionary<Type, int> ALGLJEEHFNB;

	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private static List<Type> MOBOBOPCLMI;

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x2ECA150", Offset = "0x2EC8F50", VA = "0x182ECA150")]
	static DCFIELFDAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x22C2B90", Offset = "0x22C1990", VA = "0x1822C2B90")]
	public static bool OEECIDDHIAM<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9F70", Offset = "0x2EC8D70", VA = "0x182EC9F70")]
	public static bool OEECIDDHIAM(Type LEDIIMFEFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9FE0", Offset = "0x2EC8DE0", VA = "0x182EC9FE0")]
	private static bool OEECIDDHIAM(Type LEDIIMFEFLP, out int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x22C2A60", Offset = "0x22C1860", VA = "0x1822C2A60")]
	public static int EEILMIDAPKF<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9D40", Offset = "0x2EC8B40", VA = "0x182EC9D40")]
	public static int EEILMIDAPKF(Type LEDIIMFEFLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x22C2AF0", Offset = "0x22C18F0", VA = "0x1822C2AF0")]
	public static bool EHAPPLAHJDF<T>(out int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9ED0", Offset = "0x2EC8CD0", VA = "0x182EC9ED0")]
	public static bool EHAPPLAHJDF(Type LEDIIMFEFLP, out int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9CA0", Offset = "0x2EC8AA0", VA = "0x182EC9CA0")]
	public static Type BANNGLOAJDI(int NNHNOIMLALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9DB0", Offset = "0x2EC8BB0", VA = "0x182EC9DB0")]
	public static bool EHAPPLAHJDF(int NNHNOIMLALG, out Type LEDIIMFEFLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DefaultMember("Item")]
public struct DMKOBEBHCKE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private T[] MMJOHADFCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private int PFLGNDMCMIN;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int GOGPPCBDCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x7C8AD0", Offset = "0x7C78D0", VA = "0x1807C8AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x23004D0", Offset = "0x22FF2D0", VA = "0x1823004D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> GOHJDNJJCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B190", Offset = "0x2B19F90", VA = "0x182B1B190")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool MNPJEDKKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x967680", Offset = "0x966480", VA = "0x180967680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B230", Offset = "0x2B1A030", VA = "0x182B1B230")]
	public DMKOBEBHCKE(int PFLGNDMCMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B0E0", Offset = "0x2B19EE0", VA = "0x182B1B0E0")]
	public int IHBPJFIMNDJ(T MGFMONLLLPD, int CKCLNMMLENB, int MNBBKKLFBKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B020", Offset = "0x2B19E20", VA = "0x182B1B020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DefaultMember("Item")]
public struct EOGLIKIHONO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private global::DMKOBEBHCKE<T> MMJOHADFCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private int PFLGNDMCMIN;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public T BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x1053A60", Offset = "0x1052860", VA = "0x181053A60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int GOGPPCBDCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x1054AB0", Offset = "0x10538B0", VA = "0x181054AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int DGLKHMNKMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x1054B00", Offset = "0x1053900", VA = "0x181054B00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x1054350", Offset = "0x1053150", VA = "0x181054350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool MNPJEDKKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x10545E0", Offset = "0x10533E0", VA = "0x1810545E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> GOHJDNJJCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x10541A0", Offset = "0x1052FA0", VA = "0x1810541A0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x1054BA0", Offset = "0x10539A0", VA = "0x181054BA0")]
	public EOGLIKIHONO(int PFLGNDMCMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x1053800", Offset = "0x1052600", VA = "0x181053800")]
	public T HDKDGGOFKIK(int NNHNOIMLALG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x1053650", Offset = "0x1052450", VA = "0x181053650")]
	public void FGFPNBGMEGL(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x1053B80", Offset = "0x1052980", VA = "0x181053B80")]
	public void IHKDAKHGMPD(Span<T> MPMKGFKPBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x10548E0", Offset = "0x10536E0", VA = "0x1810548E0")]
	public void OEECIDDHIAM(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x1053420", Offset = "0x1052220", VA = "0x181053420")]
	private void BNHNCMMHBHL(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x10543A0", Offset = "0x10531A0", VA = "0x1810543A0")]
	public void MBEELBLAEJN(Span<T> BNPIGAGGDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x1054000", Offset = "0x1052E00", VA = "0x181054000")]
	public void KKODKLFGINH(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x1053200", Offset = "0x1052000", VA = "0x181053200")]
	public void BGIPIJDNFFJ(int LHKICKJBBLD, int KHILBFLOBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x10535A0", Offset = "0x10523A0", VA = "0x1810535A0")]
	public void CILEDFDJAAI(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x1053850", Offset = "0x1052650", VA = "0x181053850")]
	public void HIJCOKMPICM(int LHKICKJBBLD, int KHILBFLOBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x1054620", Offset = "0x1053420", VA = "0x181054620")]
	public void NKDEFIKDPCD(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x10549F0", Offset = "0x10537F0", VA = "0x1810549F0")]
	public void OPIOILLLCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x1053AF0", Offset = "0x10528F0", VA = "0x181053AF0")]
	public int IHBPJFIMNDJ(T MGFMONLLLPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x10542F0", Offset = "0x10530F0", VA = "0x1810542F0")]
	public bool LDEEBLCAEDK(T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x1053600", Offset = "0x1052400", VA = "0x181053600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x1054B30", Offset = "0x1053930", VA = "0x181054B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x1053F90", Offset = "0x1052D90", VA = "0x181053F90")]
	public static Span<T> JMLJLLKELMG(global::EOGLIKIHONO<T> MPMKGFKPBEN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x10536C0", Offset = "0x10524C0", VA = "0x1810536C0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void GBJDPAIFBCK(int MGFMONLLLPD, int PFLGNDMCMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void JJCAMJHFHAP(int PFLGNDMCMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x1053E30", Offset = "0x1052C30", VA = "0x181053E30")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void JJCAMJHFHAP(int PFLGNDMCMIN, int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x1053CF0", Offset = "0x1052AF0", VA = "0x181053CF0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void IOKCLHHNLPL(int MGFMONLLLPD, int PFLGNDMCMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x10546E0", Offset = "0x10534E0", VA = "0x1810546E0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void OCNMHBFNFKC(int LHKICKJBBLD, int KHILBFLOBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x1054060", Offset = "0x1052E60", VA = "0x181054060")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void KNLOMAFHABN(int MGFMONLLLPD, int PFLGNDMCMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public struct PGIDFFDFCKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private const int KFEGKDBHAFJ = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NativeList<Entity> KMDDIGFEEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private TransformAccessArray LPMGOCJAKCP;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C550", Offset = "0x2D2B350", VA = "0x182D2C550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> MDEKPILIFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0xCCADA0", Offset = "0xCC9BA0", VA = "0x180CCADA0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray EEMNJPEBLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool EFIIIACBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x2D2C530", Offset = "0x2D2B330", VA = "0x182D2C530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C6C0", Offset = "0x2D2B4C0", VA = "0x182D2C6C0")]
	public PGIDFFDFCKO(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C3D0", Offset = "0x2D2B1D0", VA = "0x182D2C3D0")]
	public Entity AIFKHLLOEDM(int NNHNOIMLALG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C4A0", Offset = "0x2D2B2A0", VA = "0x182D2C4A0")]
	public Transform HJHMDDGMDEN(int NNHNOIMLALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C560", Offset = "0x2D2B360", VA = "0x182D2C560")]
	public void NAJGIDGIDMI(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C5B0", Offset = "0x2D2B3B0", VA = "0x182D2C5B0")]
	public int OEECIDDHIAM(Transform KGHIPKNMKHP, Entity NEAKDKENHHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C4B0", Offset = "0x2D2B2B0", VA = "0x182D2C4B0")]
	public int KKODKLFGINH(int NNHNOIMLALG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C420", Offset = "0x2D2B220", VA = "0x182D2C420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C680", Offset = "0x2D2B480", VA = "0x182D2C680")]
	private void PKHEOKFNGGF(int GEMEMFPEHLG = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class LEDNKJAABIE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private NativeHashMap<LONCLNDEOLA, int2> BHCEPDFPJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private NativeList<byte> MMBEBPNKEHD;

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x32B5210", Offset = "0x32B4010", VA = "0x1832B5210")]
	public LEDNKJAABIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x32B51B0", Offset = "0x32B3FB0", VA = "0x1832B51B0")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	public void KKNDJJJFEOO<T>(T MGFMONLLLPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	public T BANNGLOAJDI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x32B4FA0", Offset = "0x32B3DA0", VA = "0x1832B4FA0")]
	public void KKNDJJJFEOO(Type LEDIIMFEFLP, BDKOOLPOOEA MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x32B4B30", Offset = "0x32B3930", VA = "0x1832B4B30")]
	public BDKOOLPOOEA BANNGLOAJDI(Type LEDIIMFEFLP)
	{
		return default(BDKOOLPOOEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x32B4DE0", Offset = "0x32B3BE0", VA = "0x1832B4DE0")]
	private NativeArray<byte> FNJHNEINGCN(int2 LMLPMJCKCHL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x32B4D40", Offset = "0x32B3B40", VA = "0x1832B4D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x32B4E80", Offset = "0x32B3C80", VA = "0x1832B4E80", Slot = "1")]
	~LEDNKJAABIE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public struct KFMFGCOFHGC<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	internal static T KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	public static global::KFMFGCOFHGC<T> JMLJLLKELMG(T MGFMONLLLPD)
	{
		return default(global::KFMFGCOFHGC<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	public static T JMLJLLKELMG(global::KFMFGCOFHGC<T> HPJBCMEILDI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public static class DKGGOLMFBHN
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly LEDNKJAABIE LBPMOCKCPDH;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB930", Offset = "0x2ECA730", VA = "0x182ECB930")]
	internal static void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void KKNDJJJFEOO<T>(T MGFMONLLLPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB890", Offset = "0x2ECA690", VA = "0x182ECB890")]
	public static void KKNDJJJFEOO(Type LEDIIMFEFLP, BDKOOLPOOEA MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T BANNGLOAJDI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB7F0", Offset = "0x2ECA5F0", VA = "0x182ECB7F0")]
	public static BDKOOLPOOEA BANNGLOAJDI(Type LEDIIMFEFLP)
	{
		return default(BDKOOLPOOEA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class IFAKJFKDDCN : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public static readonly IFAKJFKDDCN ONJMHIPHCCM;

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x32AA920", Offset = "0x32A9720", VA = "0x1832AA920", Slot = "4")]
	public bool Equals(LinkedEntityGroup NHKCICGBPMI, LinkedEntityGroup PEKPPEFFGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x32AA940", Offset = "0x32A9740", VA = "0x1832AA940", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup OJGAEOFIMPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public IFAKJFKDDCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class KMEAPDLCNEA
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("DEBUG_BUILD")]
	public static void EGHLJBKOAAJ(in Vector3 DNPAJCANFPF, in Quaternion NNAIELBMKHJ, in Vector3 LFJHMANOJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("DEBUG_BUILD")]
	public static void HBGHLGKFALB(in Vector3 MAIGLADMFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("DEBUG_BUILD")]
	public static void OCMGJBEDGAE(in Quaternion NNAIELBMKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("DEBUG_BUILD")]
	public static void NMHHBJHHHBF(in Vector3 NEFLENMJEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("DEBUG_BUILD")]
	public static void GIMPKKOJMFC(in Vector3 NEFLENMJEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("DEBUG_BUILD")]
	public static void AMBJMHMPJIE(in float OFCOBBDBKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x32B17D0", Offset = "0x32B05D0", VA = "0x1832B17D0")]
	[Conditional("DEBUG_BUILD")]
	public static void NCKDFEDFIBF(in float3 MGFMONLLLPD, string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("DEBUG_BUILD")]
	public static void ICDBENPGPPI(in float MGFMONLLLPD, string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x32B1780", Offset = "0x32B0580", VA = "0x1832B1780")]
	[Conditional("DEBUG_BUILD")]
	public static void ICDBENPGPPI(in Vector3 MGFMONLLLPD, string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x32B1750", Offset = "0x32B0550", VA = "0x1832B1750")]
	[Conditional("DEBUG_BUILD")]
	public static void ICDBENPGPPI(in Quaternion MGFMONLLLPD, string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x32B1740", Offset = "0x32B0540", VA = "0x1832B1740")]
	[Conditional("DEBUG_BUILD")]
	public static void EIOENKPPBOI(in float MGFMONLLLPD, string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x32B1700", Offset = "0x32B0500", VA = "0x1832B1700")]
	[Conditional("DEBUG_BUILD")]
	public static void EIOENKPPBOI(in Vector3 MGFMONLLLPD, string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x32B16D0", Offset = "0x32B04D0", VA = "0x1832B16D0")]
	[Conditional("DEBUG_BUILD")]
	public static void EIOENKPPBOI(in Quaternion MGFMONLLLPD, string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KMEAPDLCNEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct PHPDCDGCNKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public Entity NEAKDKENHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public Entity LGBLENLGMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public Entity EBAJDMMJHBJ;

	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C7A0", Offset = "0x2D2B5A0", VA = "0x182D2C7A0")]
	public PHPDCDGCNKA(Entity NEAKDKENHHP, Entity LGBLENLGMIP, Entity EBAJDMMJHBJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C760", Offset = "0x2D2B560", VA = "0x182D2C760")]
	public static PHPDCDGCNKA JMLJLLKELMG((Entity entity, Entity oldParent, Entity newParent) AJHLCHKPODH)
	{
		return default(PHPDCDGCNKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C740", Offset = "0x2D2B540", VA = "0x182D2C740")]
	public void BJOOJLCIJFO(out Entity NEAKDKENHHP, out Entity LGBLENLGMIP, out Entity EBAJDMMJHBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct OIFPFJGMJPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public Entity NEAKDKENHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public Entity GANAMHNGMGO;

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0xF08C10", Offset = "0xF07A10", VA = "0x180F08C10")]
	public OIFPFJGMJPN(Entity NEAKDKENHHP, Entity GANAMHNGMGO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D9A0", Offset = "0x2D1C7A0", VA = "0x182D1D9A0")]
	public static OIFPFJGMJPN JMLJLLKELMG((Entity entity, Entity parent) AJHLCHKPODH)
	{
		return default(OIFPFJGMJPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D990", Offset = "0x2D1C790", VA = "0x182D1D990")]
	public void BJOOJLCIJFO(out Entity NEAKDKENHHP, out Entity GANAMHNGMGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct PABAMLLEIDC<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private GCHandle EAHLOGLBEGD;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public bool ACEJEDJGCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF510", Offset = "0x2EFE310", VA = "0x182EFF510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF520", Offset = "0x2EFE320", VA = "0x182EFF520")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF420", Offset = "0x2EFE220", VA = "0x182EFF420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x2EFF5C0", Offset = "0x2EFE3C0", VA = "0x182EFF5C0")]
	public PABAMLLEIDC(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x2EFF4E0", Offset = "0x2EFE2E0", VA = "0x182EFF4E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public enum MHFLFFIFEME
{
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public struct MIDBAIEMEBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public MHFLFFIFEME LFFGDPPFNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public int DDIBLPMPEIL;

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0x7621E0", Offset = "0x760FE0", VA = "0x1807621E0")]
	public MIDBAIEMEBA(MHFLFFIFEME LFFGDPPFNAC, int DDIBLPMPEIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A2E0", Offset = "0x2D190E0", VA = "0x182D1A2E0")]
	public static MIDBAIEMEBA JMLJLLKELMG((MHFLFFIFEME eventType, int eventIndex) NHKCICGBPMI)
	{
		return default(MIDBAIEMEBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A2D0", Offset = "0x2D190D0", VA = "0x182D1A2D0")]
	public void BJOOJLCIJFO(out MHFLFFIFEME LFFGDPPFNAC, out int DDIBLPMPEIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[GDFKOGKEDCG(typeof(HCCDBOIGFKL), new string[] { })]
public sealed class JFEDBCOADIF : HCCDBOIGFKL, JPLAKHLHFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private EOEMDGEDOLM AINJAMGLMOC;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x32AD480", Offset = "0x32AC280", VA = "0x1832AD480", Slot = "5")]
	public void EBGPFBJMHBP(LKAAGIKDPMH MENEIDJFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x32AD4D0", Offset = "0x32AC2D0", VA = "0x1832AD4D0")]
	public bool KHEMAAGDLHA(in float3 OBMFGFCEDPK, in float3 DJIMPKHJJFP, float JOJDHMIFOPA, Allocator MBJMPHBLMBF, out NativeArray<Entity> KMDDIGFEEEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public JFEDBCOADIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x32AD4D0", Offset = "0x32AC2D0", VA = "0x1832AD4D0", Slot = "4")]
	private bool PMHPJKGPJAI(in float3 OBMFGFCEDPK, in float3 DJIMPKHJJFP, float JOJDHMIFOPA, Allocator MBJMPHBLMBF, out NativeArray<Entity> KMDDIGFEEEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[JFPMCOMHGMD]
[UpdateInGroup(typeof(EMCOIEJOGIA))]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
internal sealed class CMLCFNPMCKD : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC3A0", Offset = "0x2EBB1A0", VA = "0x182EBC3A0", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public CMLCFNPMCKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[JFPMCOMHGMD]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
[UpdateInGroup(typeof(BEMOBJNKEIN))]
public sealed class CMCFPHICFJD : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0x2EBC2C0", Offset = "0x2EBB0C0", VA = "0x182EBC2C0", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public CMCFPHICFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[JFPMCOMHGMD]
[UpdateInGroup(typeof(GLLJIGHFJGA))]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
internal sealed class MOAIOPDGKGG : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A460", Offset = "0x2D19260", VA = "0x182D1A460", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public MOAIOPDGKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class LKGCFFJINJA : CNPEJNDMKOG
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public LKGCFFJINJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[JFPMCOMHGMD]
[ExecuteAlways]
[AIMPMHLOEBK(DIMCOFJGPGL.LoadInstance)]
[UpdateInGroup(typeof(CBGKKBIFHPA))]
internal sealed class GPEMIIIBCHK : EBJAMMGLKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0x32A3480", Offset = "0x32A2280", VA = "0x1832A3480", Slot = "16")]
	protected override ComponentSystemBase ELEDNLKCBIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB70", Offset = "0x2D19970", VA = "0x182D1AB70")]
	public GPEMIIIBCHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[AFNDJJALAGK(typeof(AuthoredLocalPoseData))]
public sealed class EHHNPECEEPO : CIDGAIEGGCH
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1DE0", Offset = "0x2ED0BE0", VA = "0x182ED1DE0", Slot = "8")]
	protected override bool FIEMNCLHKDD(ReadOnlySpan<AuthoredLocalPoseData> BNPIGAGGDHK, KBICDOOODLG MNPIJNFAMOJ, out ReadOnlySpan<byte> AAOFEOFDGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1E60", Offset = "0x2ED0C60", VA = "0x182ED1E60", Slot = "9")]
	protected override bool MOIFOFMFBNA(int HHCMOLFBCEB, Span<AuthoredLocalPoseData> BNPIGAGGDHK, in ReadOnlySpan<byte> AAOFEOFDGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1F20", Offset = "0x2ED0D20", VA = "0x182ED1F20")]
	public EHHNPECEEPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[AFNDJJALAGK(typeof(LocalPoseData))]
public sealed class FONEGAJAINJ : AIKMPDFICPB
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x329F060", Offset = "0x329DE60", VA = "0x18329F060", Slot = "8")]
	protected override bool FIEMNCLHKDD(ReadOnlySpan<LocalPoseData> BNPIGAGGDHK, KBICDOOODLG MNPIJNFAMOJ, out ReadOnlySpan<byte> AAOFEOFDGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x329F0E0", Offset = "0x329DEE0", VA = "0x18329F0E0", Slot = "9")]
	protected override bool MOIFOFMFBNA(int HHCMOLFBCEB, Span<LocalPoseData> BNPIGAGGDHK, in ReadOnlySpan<byte> AAOFEOFDGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x329F1A0", Offset = "0x329DFA0", VA = "0x18329F1A0")]
	public FONEGAJAINJ()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Preserve]
	internal class _RRAssemblyIndex : JHKNIKIBBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x2FF5670", Offset = "0x2FF4470", VA = "0x182FF5670", Slot = "6")]
		public sealed override void BBOGNFJPIAG(KOGMDLCFDAH FNIOCOFMFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6690", Offset = "0x2FF5490", VA = "0x182FF6690", Slot = "4")]
		public sealed override void FODOGCDFONM()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x32AF270", Offset = "0x32AE070", VA = "0x1832AF270")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x32AEF20", Offset = "0x32ADD20", VA = "0x1832AEF20")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001ED")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EE")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
